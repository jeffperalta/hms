Option Explicit On
Option Strict On

Imports System.Data
Imports System.Data.SqlClient

' Programmer:   Jo Jefferson D. Peralta
' Date:         March 02, 2007
' Title:        frmFeaturesAndFacilities
' Purpose:      This interface adds, edits, deletes features and facilities of a room
' Requirements: ->  (+/-)RMFeature(RMFID, RMFName, RMFStatus, RMFRemarks)
'               ->  (*) RMFeature(RMFname, RMFStatus, RMFRemarks)
'               ->  Deletion will not continue if the feature is already used by any rooms
'               ->  RMFStatus, RMFname are required
'               ->  Unique value at RMFName
' Results:      ->  A new feature is added.
'               ->  Saved information of a feature and facility is edited
'               ->  If a feature/facility is not used the user can delete it.
'               ->  Otherwise if the user cannot delete the item he can edit the status to UNAVAILABLE
'MESSAGE DONE>>>

Public Class frmFeaturesAndFacilities

    Private gstate As State = State.waiting

#Region "Functions and Subroutines"

    Private Sub DisplayFeaturesAndFacilities()

        ' 0 RMFID
        ' 1 RMFName
        ' 2 RMFStatus
        ' 3 RMFRemarks
        Dim CommandString As String = String.Empty

        If optViewAll.Checked = True Or optUnused.Checked = True Then

            CommandString = "SELECT RMFID AS [Facility No], RMFName AS Name, RMFStatus AS Status, RMFRemarks AS Remarks " & _
                            "FROM   RMFEATURE "

            If optUnused.Checked Then
                CommandString &= "WHERE  (RMFID NOT IN  (SELECT DISTINCT RMFID FROM RMFEATURE_DETAILS)) "
                Select Case TrimAll(cboViewStatus.Text, True)
                    Case "ALL"
                        CommandString &= " "
                    Case "UNAVAILABLE"
                        CommandString &= " AND RMFStatus='FALSE' "
                    Case "AVAILABLE"
                        CommandString &= " AND RMFStatus='TRUE' "
                    Case Else
                        'Can't clear data grid so use this instead
                        CommandString &= " AND RMFStatus='TRUE' AND RMFStatus='FALSE' " 'To display nothing
                End Select
            Else
                Select Case TrimAll(cboViewStatus.Text, True)
                    Case "ALL"
                        CommandString &= " "
                    Case "UNAVAILABLE"
                        CommandString &= " WHERE RMFStatus='FALSE' "
                    Case "AVAILABLE"
                        CommandString &= " WHERE RMFStatus='TRUE' "
                    Case Else
                        CommandString &= " WHERE RMFStatus='TRUE' AND RMFStatus='FALSE' "
                End Select
            End If

        Else
            CommandString = "SELECT RMFID AS [Facility No], RMFName AS Name, RMFStatus AS Status, RMFRemarks AS Remarks " & _
                            "FROM   RMFEATURE WHERE RMFStatus='TRUE' AND RMFStatus='FALSE' " 'display nothing
        End If

        lblCount.Text = ListItems(DatabasePath(), CommandString, dgvFeaturesAndFacilities).ToString
    End Sub

    Private Function ThereAreInputErrors() As Boolean
        If TrimAll(txtName.Text, True) = String.Empty Then
            Msg("1000")
            txtName.SelectAll()
            txtName.Focus()
            Return True
            Exit Function
        End If

        If TrimAll(cboStatus.Text, True) = String.Empty Then
            Msg("1000")
            cboStatus.SelectAll()
            cboStatus.Focus()
            Return True
            Exit Function
        End If

        If gstate = State.adding Or _
          (gstate = State.updating AndAlso String.Compare(dgvFeaturesAndFacilities.Item(1, dgvFeaturesAndFacilities.CurrentRow.Index).Value.ToString, TrimAll(txtName.Text, True), True) <> 0) Then
            If IsExisting("SELECT RMFID FROM RMFEATURE WHERE RMFName='" & TrimAll(txtName.Text, True) & "'") Then
                Msg("1002")
                txtName.SelectAll()
                txtName.Focus()
                Return True
                Exit Function
            End If
        End If

        Return False

    End Function

#End Region

#Region "Command Buttons"

    Private Sub btnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNew.Click
        gstate = State.adding

        gbxListOfFeaturesAndFacilities.Enabled = False
        gbxInput.Enabled = True

        ClearControls(gbxInput)
        cboStatus.Text = "Available"

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If dgvFeaturesAndFacilities.SelectedRows.Count <> 0 Then
            gstate = State.updating

            gbxListOfFeaturesAndFacilities.Enabled = False
            gbxInput.Enabled = True
        Else
            Msg("1005")
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        If dgvFeaturesAndFacilities.SelectedRows.Count <> 0 Then
            'no need to trim all since it came from a data grid control
            If IsExisting("SELECT RMFID FROM RMFEATURE_DETAILS WHERE RMFID='" & dgvFeaturesAndFacilities.Item(0, dgvFeaturesAndFacilities.CurrentRow.Index).Value.ToString & "'") Then
                Msg("1006", Button.Ok, "Cannot delete this feature since it is being used by a room, edit its status to make this feature unavailable")
            Else
                If Msg("1034", Button.YesNo) = ButtonClicked.Yes Then
                    Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
                        objConnection.Open()
                        Using objTransaction As SqlTransaction = objConnection.BeginTransaction
                            Using objCommand As SqlCommand = objConnection.CreateCommand
                                With objCommand
                                    .Transaction = objTransaction
                                    .CommandText = "DELETE FROM RMFEATURE WHERE RMFID=@RMFID"
                                    .Parameters.AddWithValue("@RMFID", dgvFeaturesAndFacilities.Item(0, dgvFeaturesAndFacilities.CurrentRow.Index).Value)

                                    Try
                                        .ExecuteNonQuery()
                                        objTransaction.Commit()

                                        frmParent.tssStatus.Text = "Feature/facility was deleted..."

                                        DisplayFeaturesAndFacilities()

                                    Catch ex As Exception

                                        objTransaction.Rollback()
                                        Msg("1008", , NWLN & ex.Message)

                                    End Try
                                End With
                            End Using 'command
                        End Using 'transaction
                        objConnection.Close()
                    End Using 'Connection
                End If
            End If
        Else
            Msg("1005")
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If ThereAreInputErrors() Then Exit Sub

        Using objConnection As SqlConnection = SetUpConnection(DatabasePath(), True)
            objConnection.Open()
            Using objTransaction As SqlTransaction = objConnection.BeginTransaction

                Using objCommand As SqlCommand = objConnection.CreateCommand
                    With objCommand
                        .Transaction = objTransaction

                        Select Case gstate
                            Case State.adding
                                .CommandText = "INSERT INTO RMFEATURE (RMFID, RMFName, RMFStatus, RMFRemarks) VALUES (@RMFID, @RMFName, @RMFStatus, @RMFRemarks)"
                                .Parameters.AddWithValue("@RMFID", GetPrimaryKeyNo("RMFeature"))
                                IncrementPrimaryKeyNo("RMFeature")

                            Case State.updating
                                .CommandText = "UPDATE RMFEATURE SET RMFName=@RMFName, RMFStatus=@RMFStatus, RMFRemarks=@RMFRemarks WHERE RMFID=@RMFID"
                                .Parameters.AddWithValue("@RMFID", dgvFeaturesAndFacilities.Item(0, dgvFeaturesAndFacilities.CurrentRow.Index).Value)

                        End Select

                        With .Parameters
                            .AddWithValue("@RMFName", TrimAll(txtName.Text, True))
                            .AddWithValue("@RMFRemarks", TrimAll(txtRemarks.Text))

                            'Already filtered by ThereAreInputErrors
                            If String.Compare(cboStatus.Text, "Available", True) = 0 Then
                                .AddWithValue("@RMFStatus", Boolean.TrueString).SqlDbType = SqlDbType.Bit
                            Else
                                .AddWithValue("@RMFStatus", Boolean.FalseString).SqlDbType = SqlDbType.Bit
                            End If
                        End With

                        Try
                            .ExecuteNonQuery()

                            objTransaction.Commit()

                            Select Case gstate
                                Case State.adding
                                    frmParent.tssStatus.Text = "A new feature and facility was added..."
                                Case State.updating
                                    frmParent.tssStatus.Text = "The information of feature/facility was altered..."
                            End Select

                            gstate = State.waiting
                            gbxListOfFeaturesAndFacilities.Enabled = True
                            gbxInput.Enabled = False

                            ClearControls(gbxInput)
                            dgvFeaturesAndFacilities_SelectionChanged(Nothing, Nothing)

                            DisplayFeaturesAndFacilities()

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
        gstate = State.waiting

        gbxInput.Enabled = False
        gbxListOfFeaturesAndFacilities.Enabled = True

        ClearControls(gbxInput)
        dgvFeaturesAndFacilities_SelectionChanged(Nothing, Nothing)

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

#End Region

#Region "MISC"

    Private Sub dgvFeaturesAndFacilities_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvFeaturesAndFacilities.SelectionChanged

        With dgvFeaturesAndFacilities
            If .SelectedRows.Count > 0 Then
                Dim intRowIndex As Integer = .CurrentRow.Index
                txtName.Text = .Item(1, intRowIndex).Value.ToString
                txtRemarks.Text = .Item(3, intRowIndex).Value.ToString
                If CType(.Item(2, intRowIndex).Value, Boolean) = True Then
                    cboStatus.Text = "Available"
                Else
                    cboStatus.Text = "Unavailable"
                End If
            End If
        End With
    End Sub

    Private Sub frmFeaturesAndFacilities_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        If gstate <> State.waiting Then
            Select Case Msg("1033", Button.YesNoCancel, "Would you like to save this transaction before leaving this form?")
                Case ButtonClicked.Yes
                    If ThereAreInputErrors() Then
                        e.Cancel = True
                    Else
                        btnSave_Click(Nothing, Nothing)
                        frmRoomSettings.UpdateComboBoxes_FeaturesRatesTypes()
                        frmRoomSettings.DisplayAmenitiesAndServices()
                        e.Cancel = False
                    End If
                Case ButtonClicked.No
                    btnCancel_Click(Nothing, Nothing)
                    frmRoomSettings.UpdateComboBoxes_FeaturesRatesTypes()
                    frmRoomSettings.DisplayAmenitiesAndServices()
                    e.Cancel = False
                Case ButtonClicked.Cancel
                    e.Cancel = True
            End Select
        Else
            frmRoomSettings.UpdateComboBoxes_FeaturesRatesTypes()
            frmRoomSettings.DisplayAmenitiesAndServices()
            e.Cancel = False
        End If
    End Sub

    Private Sub optViewAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optViewAll.CheckedChanged
        DisplayFeaturesAndFacilities()
    End Sub

    Private Sub optUnused_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optUnused.CheckedChanged
        DisplayFeaturesAndFacilities()
    End Sub

    Private Sub cboViewStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboViewStatus.SelectedIndexChanged
        DisplayFeaturesAndFacilities()
    End Sub

    Private Sub frmFeaturesAndFacilities_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DisplayFeaturesAndFacilities()
        dgvFeaturesAndFacilities.AlternatingRowsDefaultCellStyle = SetAlternatingColor()
    End Sub

#End Region
  
End Class