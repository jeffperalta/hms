Option Explicit On
Option Strict On

Imports System.Data.SqlClient
Imports System.Data

' Programmer:   Jo Jefferson D. Peralta
' Date:         February 27, 2007
' Title:        frmSystemSettingsRLFormat
' Purpose:      This interface modifies the record locator/primary key of a reservation, registration
'               Guest Information, and company information. The client would like to have an annual changes
'               in the record locator so this interface is created.
' Requirements: ->  (*)PREKEYGEN(Attribute, Alpha, Previous)
'               ->  (*)KEYGEN(Attribute, CurrentNo)
'               ->  Required Field at Alpha, CurrentNo
'               ->  For all combinations of [Alpha][CurrentNo++] the generated RL must be unique
'               ->  The record locators should be unique in all cases - that is, the concatenation
'               ->  of the VALUE and the NUMBERING
'               ->  Previous values are saved to determine the used RL numbers.
'               ->  A remarks is also provided.
' Results:      ->  A unique record locator is created
'msgbox

Class frmSystemSettingsRLFormat

    Private gState As State = State.waiting

#Region "Functions/SubRoutines"

    Private Sub DisplayRecordLocator()
        ListItems(DatabasePath, "SELECT ISNULL(PREKEYGEN.Attribute, '') AS [Record Locator], ISNULL(PREKEYGEN.Alpha,'') AS Value, ISNULL(KEYGEN.CurrentNo, 0) AS Numbering, " & _
                                "       ISNULL(PREKEYGEN.Previous, '') AS [Previous Values], ISNULL(PREKEYGEN.Remarks,'') AS [Remarks]" & _
                                "FROM   KEYGEN INNER JOIN " & _
                                "       PREKEYGEN ON KEYGEN.Attribute = PREKEYGEN.Attribute ", dgvRl)

    End Sub

    Private Function IsValidRL() As Boolean

        If Not IsNumeric(txtNumbering.Text) Then
            txtNumbering.SelectAll()
            txtNumbering.Focus()
            Msg("1001")
            Return False
            Exit Function
        Else
            If CType(txtNumbering.Text, Integer) < 0 Then
                txtNumbering.SelectAll()
                txtNumbering.Focus()
                Msg("1001", , "A positive integer value is needed")
                Return False
                Exit Function
            End If
        End If

        If String.Compare(txtNewValue.Text, dgvRl.Item(1, dgvRl.CurrentRow.Index).Value.ToString, True) = 0 Then
            If CType(txtNumbering.Text, Integer) < CType(dgvRl.Item(2, dgvRl.CurrentRow.Index).Value, Integer) Then
                txtNumbering.SelectAll()
                txtNumbering.Focus()
                Msg("1044")
                Return False
                Exit Function
            End If
        End If

        If dgvRl.Item(3, dgvRl.CurrentRow.Index).Value.ToString.ToUpper.Contains(TrimAll(txtNewValue.Text)) Then
            txtNewValue.SelectAll()
            txtNewValue.Focus()
            Msg("1044")
            Return False
            Exit Function
        End If

        If Not IsValidInput(TrimAll(txtNewValue.Text)) Then
            txtNewValue.SelectAll()
            txtNewValue.Focus()
            Msg("1001", , "Input must not contain special charaters")
            Return False
            Exit Function
        End If

        Return True

    End Function

#End Region

#Region "Command Buttons"

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If Not IsValidRL() Then Exit Sub

        Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
            objConnection.Open()

            Using objTransaction As SqlTransaction = objConnection.BeginTransaction
                Using objCommand As SqlCommand = objConnection.CreateCommand
                    With objCommand
                        .Transaction = objTransaction
                        .CommandText = "UPDATE PREKEYGEN SET ALPHA=@ALPHA, Previous = ISNULL(Previous,'') + @Previous, Remarks=@Remarks WHERE Attribute=@Attribute"
                        With .Parameters
                            .AddWithValue("@Attribute", dgvRl.Item(0, dgvRl.CurrentRow.Index).Value)
                            .AddWithValue("@Alpha", TrimAll(txtNewValue.Text))
                            .AddWithValue("@Remarks", TrimAll(txtRemarks.Text))

                            If String.Compare(txtNewValue.Text, dgvRl.Item(1, dgvRl.CurrentRow.Index).Value.ToString, True) = 0 Then
                                .AddWithValue("@Previous", String.Empty)
                            Else
                                If dgvRl.Item(3, dgvRl.CurrentRow.Index).Value.ToString = String.Empty Then
                                    .AddWithValue("@Previous", dgvRl.Item(1, dgvRl.CurrentRow.Index).Value.ToString)
                                Else
                                    .AddWithValue("@Previous", ", " & dgvRl.Item(1, dgvRl.CurrentRow.Index).Value.ToString)
                                End If
                            End If
                        End With

                        Try
                            .ExecuteNonQuery()

                            .CommandText = "UPDATE KEYGEN SET CurrentNo=@CurrentNo WHERE Attribute=@Attribute"
                            '@Attribute is already declared
                            .Parameters.AddWithValue("@CurrentNo", CInt(txtNumbering.Text)).SqlDbType = SqlDbType.Int
                            .ExecuteNonQuery()

                            objTransaction.Commit()

                            DisplayRecordLocator()

                            frmParent.tssStatus.Text = "Record locator altered..."
                            gbxInput.Enabled = False
                            gbxList.Enabled = True

                            ClearControls(gbxInput)
                            dgvRl_SelectionChanged(Nothing, Nothing)

                            gState = State.waiting

                        Catch ex As Exception

                            objTransaction.Rollback()
                            Msg("1008", , NWLN & ex.Message)

                        End Try
                    End With
                End Using
            End Using

            objConnection.Close()
        End Using

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        gbxInput.Enabled = False
        gbxList.Enabled = True

        ClearControls(gbxInput)
        dgvRl_SelectionChanged(Nothing, Nothing)

        gState = State.waiting
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        gState = State.updating

        gbxInput.Enabled = True
        gbxList.Enabled = False

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

#End Region

#Region "MISC"

    Private Sub frmSystemSettingsRLFormat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DisplayRecordLocator()
        dgvRl.AlternatingRowsDefaultCellStyle = SetAlternatingColor()

    End Sub

    Private Sub dgvRl_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvRl.SelectionChanged
        txtNewValue.Text = dgvRl.Item(1, dgvRl.CurrentRow.Index).Value.ToString
        txtNumbering.Text = dgvRl.Item(2, dgvRl.CurrentRow.Index).Value.ToString
        txtRemarks.Text = dgvRl.Item(4, dgvRl.CurrentRow.Index).Value.ToString
        txtNumbering.Tag = txtNumbering.Text
    End Sub

    Private Sub frmSystemSettingsRLFormat_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If gState <> State.waiting Then
            Select Case Msg("1033", Button.YesNoCancel)
                Case ButtonClicked.Yes
                    If Not IsValidRL() Then
                        e.Cancel = True
                    Else
                        btnSave_Click(Nothing, Nothing)
                        e.Cancel = False
                    End If

                Case ButtonClicked.No
                    e.Cancel = False

                Case ButtonClicked.Cancel
                    e.Cancel = True

            End Select
        Else
            e.Cancel = False
        End If
    End Sub

    Private Sub txtNumbering_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNumbering.Validating
        If Trim(txtNumbering.Text) = String.Empty Then
            txtNumbering.Text = CType(txtNumbering.Tag, String)
        End If
    End Sub

    Private Sub lblClose_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblClose.LinkClicked
        Me.Close()
    End Sub

#End Region

#Region "Side Bar"

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Display(Forms.frmSettings)
    End Sub

#End Region

End Class