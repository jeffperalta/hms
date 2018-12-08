Option Explicit On
Option Strict On

Imports System.Data
Imports System.Data.SqlClient

' Programmer:   Jo Jefferson D. Peralta
' Date:         March 02, 2007
' Title:        frmRoomTypeAndRates
' Purpose:      This interface adds, edits, deletes Room types and rates 
' Requirements: ->  (+/-) RMRATE (RMRID, RMRRemarks, RMRAmt, RMRStartTime, RMREndTime, RMRType, RMRName)
'               ->  (*) RMRATE (RMRRemarks, RMRAmt, RMRAmt, RMRStartTime, RMREndTime, RMRType, RMRName)
'               ->  Deletion will not occur if a single room has this Rate or type
'               ->  Required Fields at RMRID, RMRAmt, RMRType, RMRName
'               ->  Unique values at RMRID
'               ->  RMRAmt >=0
'               ->  Room rates are based on the room types
' Results:      ->  A new room rate and type are added
'               ->  Room rate and type information are edited
'               ->  If a type or rate is not applied to any room the user can delete the information
'Message>>> true

Public Class frmRoomTypeAndRates

    Private gState As State = State.waiting

#Region "Functions/Subroutines"

    Private Sub DisplayRoomTypesAndRates()

        Dim CommandString As String = "SELECT RMRID AS [Rate No], RMRName AS [Rate Name], RMRType AS [Applied To Room Type], RMRAmt AS Rate, RMRStartTime AS [Starts on], " & _
                                      "       RMREndTime AS [End On], RMRRemarks AS Remarks " & _
                                      "FROM   RMRATE "

        If Not chkRoomRateSelectAll.Checked Then
            CommandString &= "WHERE RMRType LIKE '" & Trim(cboRoomRateRoomType.Text) & "%' "
        End If

        lblCount.Text = ListItems(DatabasePath(), CommandString, dgvRates).ToString

    End Sub

    Private Sub UpdateComboBox()
        ListItems(DatabasePath, "SELECT DISTINCT RMRType FROM RMRATE UNION SELECT DISTINCT RMType FROM ROOM", cboRoomType, "RMRType")
        ListItems(DatabasePath, "SELECT DISTINCT RMRType FROM RMRATE UNION SELECT DISTINCT RMType FROM ROOM", cboRoomRateRoomType, "RMRType")
    End Sub

    Private Function ThereAreInputErrors() As Boolean

        Dim strRoomType As String = TrimAll(cboRoomType.Text, True)
        Dim strRateName As String = TrimAll(txtRateName.Text, True)
        Dim strRate As String = TrimAll(txtRate.Text, True)

        If strRateName = String.Empty Then
            Msg("1000")
            txtRateName.SelectAll()
            txtRateName.Focus()
            Return True
            Exit Function
        End If

        If strRate = String.Empty Then
            Msg("1000")
            txtRate.SelectAll()
            txtRate.Focus()
            Return True
            Exit Function
        End If

        If Not IsNumeric(strRate) Then
            Msg("1001")
            txtRate.SelectAll()
            txtRate.Focus()
            Return True
            Exit Function
        Else
            If CType(strRate, Double) < 0 Then
                Msg("1001", , "The amount must not be a negative number")
                txtRate.SelectAll()
                txtRate.Focus()
                Return True
                Exit Function
            End If

        End If

        If strRoomType = String.Empty Then
            Msg("1000")
            cboRoomType.SelectAll()
            cboRoomType.Focus()
            Return True
            Exit Function
        End If

        'If gState = State.adding Or (gState = State.updating AndAlso String.Compare(strRateName, dgvRates.Item(1, dgvRates.CurrentRow.Index).Value.ToString, True) <> 0) Then
        '    If IsExisting("SELECT RMRID FROM RMRATE WHERE RMRName='" & strRateName & "'") Then
        '        MsgBox("Cannot have a duplicate value")
        '        txtRateName.SelectAll()
        '        txtRateName.Focus()
        '        Return True
        '        Exit Function
        '    End If
        'End If

        Return False

    End Function

#End Region

#Region "Command Buttons"

    Private Sub btnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNew.Click

        gState = State.adding

        gbxRates.Enabled = False
        gbxInput.Enabled = True

        ClearControls(gbxInput)

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click

        If dgvRates.SelectedRows.Count <> 0 Then
            gState = State.updating

            gbxRates.Enabled = False
            gbxInput.Enabled = True
        Else
            Msg("1039")
        End If

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        If dgvRates.SelectedRows.Count <> 0 Then

            'No need to trimall(_,TRUE) because information will come from the data grid
            If Not IsExisting("SELECT RMRID FROM RMRATE_DETAILS WHERE RMRID='" & dgvRates.Item(0, dgvRates.CurrentRow.Index).Value.ToString & "'") Then

                If Msg("1035", Button.YesNo) = ButtonClicked.Yes Then
                    Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
                        objConnection.Open()
                        Using objTransaction As SqlTransaction = objConnection.BeginTransaction
                            Using objCommand As SqlCommand = objConnection.CreateCommand
                                With objCommand
                                    .Transaction = objTransaction
                                    .CommandText = "DELETE FROM RMRATE WHERE RMRID = @RMRID"
                                    .Parameters.AddWithValue("@RMRID", dgvRates.Item(0, dgvRates.CurrentRow.Index).Value)

                                    Try
                                        .ExecuteNonQuery()
                                        objTransaction.Commit()

                                        frmParent.tssStatus.Text = "Room rate deleted..."

                                        DisplayRoomTypesAndRates()
                                        UpdateComboBox()

                                    Catch ex As Exception
                                        objTransaction.Rollback()
                                        Msg("1008", , NWLN & ex.Message)

                                    End Try

                                End With
                            End Using
                        End Using
                        objConnection.Close()
                    End Using
                End If

            Else
                Msg("1006", , "Cannot delete because the rate was already assigned to a room")
            End If
        Else
            MsgBox("1005")
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        gState = State.waiting

        gbxInput.Enabled = False
        gbxRates.Enabled = True

        ClearControls(gbxInput)
        dgvRates_SelectionChanged(Nothing, Nothing)

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If ThereAreInputErrors() Then Exit Sub

        Using objConnection As SqlConnection = SetUpConnection(DatabasePath(), True)
            objConnection.Open()
            Using objTransaction As SqlTransaction = objConnection.BeginTransaction
                Using objCommand As SqlCommand = objConnection.CreateCommand
                    With objCommand
                        .Transaction = objTransaction

                        Select Case gState
                            Case State.adding
                                .CommandText = "INSERT INTO RMRATE (RMRID, RMRRemarks, RMRAmt, RMRStartTime, RMREndTime, RMRType, RMRName) " & _
                                                "VALUES (@RMRID, @RMRRemarks, @RMRAmt, @RMRStartTime, @RMREndTime, @RMRType, @RMRName) "

                                .Parameters.AddWithValue("@RMRID", GetPrimaryKeyNo("RMRate"))
                                IncrementPrimaryKeyNo("RMRate")

                            Case State.updating
                                .CommandText = "UPDATE RMRATE SET RMRRemarks=@RMRRemarks, RMRAmt=@RMRAmt, RMRStartTime=@RMRStartTime, " & _
                                                "RMREndTime=@RMREndTime, RMRType=@RMRType, RMRName=@RMRName WHERE RMRID=@RMRID"
                                .Parameters.AddWithValue("@RMRID", dgvRates.Item(0, dgvRates.CurrentRow.Index).Value)

                        End Select

                        With .Parameters
                            .AddWithValue("@RMRRemarks", TrimAll(txtRemarks.Text))
                            .AddWithValue("@RMRAmt", TrimAll(txtRate.Text, True)).SqlDbType = SqlDbType.Money
                            .AddWithValue("@RMRStartTime", dtpStartDate.Value).SqlDbType = SqlDbType.DateTime
                            .AddWithValue("@RMREndTime", dtpEndDate.Value).SqlDbType = SqlDbType.DateTime
                            .AddWithValue("@RMRType", TrimAll(cboRoomType.Text, True))
                            .AddWithValue("@RMRName", TrimAll(txtRateName.Text, True))
                        End With

                        Try
                            .ExecuteNonQuery()
                            objTransaction.Commit()

                            Select Case gState
                                Case State.adding
                                    frmParent.tssStatus.Text = "A new room type/rate is added..."
                                Case State.updating
                                    frmParent.tssStatus.Text = "Room rate/type information is altered..."
                            End Select

                            gState = State.waiting
                            gbxInput.Enabled = False
                            gbxRates.Enabled = True

                            DisplayRoomTypesAndRates()
                            UpdateComboBox()

                            dgvRates_SelectionChanged(Nothing, Nothing)

                        Catch ex As OverflowException
                            objTransaction.Rollback()
                            Msg("1003")
                            txtRate.SelectAll()
                            txtRate.Focus()

                        Catch ex As Exception
                            objTransaction.Rollback()
                            Msg("1008", Button.Ok, ex.Message)
                        End Try
                    End With
                End Using
            End Using
            objConnection.Close()
        End Using
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

#End Region

#Region "MISC"

    Private Sub dgvRates_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvRates.SelectionChanged
        If dgvRates.SelectedRows.Count <> 0 Then
            Dim intSelectedRowIndex As Integer = dgvRates.CurrentRow.Index
            cboRoomType.Text = dgvRates.Item(2, intSelectedRowIndex).Value.ToString
            txtRateName.Text = dgvRates.Item(1, intSelectedRowIndex).Value.ToString
            txtRate.Text = dgvRates.Item(3, intSelectedRowIndex).Value.ToString
            txtRemarks.Text = dgvRates.Item(6, intSelectedRowIndex).Value.ToString
            dtpStartDate.Value = CType(dgvRates.Item(4, intSelectedRowIndex).Value, Date)
            dtpEndDate.Value = CType(dgvRates.Item(5, intSelectedRowIndex).Value, Date)
        End If
    End Sub

    Private Sub frmRoomTypeAndRates_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DisplayRoomTypesAndRates()
        UpdateComboBox()

        dgvRates.AlternatingRowsDefaultCellStyle = SetAlternatingColor()
    End Sub

    Private Sub frmRoomTypeAndRates_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If gState <> State.waiting Then
            Select Case Msg("1033", Button.YesNoCancel)
                Case ButtonClicked.Yes
                    If ThereAreInputErrors() Then
                        e.Cancel = True
                    Else
                        btnSave_Click(Nothing, Nothing)
                        frmRoomSettings.UpdateComboBoxes_FeaturesRatesTypes()
                        frmRoomSettings.DisplayRoomRatesAndTypes()
                        e.Cancel = False
                    End If

                Case ButtonClicked.No
                    btnCancel_Click(Nothing, Nothing)
                    frmRoomSettings.UpdateComboBoxes_FeaturesRatesTypes()
                    frmRoomSettings.DisplayRoomRatesAndTypes()
                    e.Cancel = False

                Case ButtonClicked.Cancel
                    e.Cancel = True

            End Select
        Else
            frmRoomSettings.UpdateComboBoxes_FeaturesRatesTypes()
            frmRoomSettings.DisplayRoomRatesAndTypes()
            e.Cancel = False
        End If
    End Sub

    Private Sub chkRoomRateSelectAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRoomRateSelectAll.CheckedChanged
        cboRoomRateRoomType.Enabled = Not chkRoomRateSelectAll.Checked
        DisplayRoomTypesAndRates()
    End Sub

    Private Sub cboRoomRateRoomType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRoomRateRoomType.SelectedIndexChanged
        DisplayRoomTypesAndRates()
    End Sub

#End Region

End Class