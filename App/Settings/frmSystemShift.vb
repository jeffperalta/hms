Option Explicit On
Option Strict On

Imports System.Data.SqlClient
Imports System.Data

' Programmer:   Jo Jefferson D. Peralta
' Date:         March 01, 2007
' Title:        frmSystemShift
' Purpose:      This interface defines the shift schedules in a hotel.
'               Although this allows overlapping in schedules however the problem can
'               be resolved at the advance log in option.
'               Deletion of shift schedules is not allowed when an employee has already logged
'               to that shift.
'               The shifts will only be effective when the [advance] user restarts the application.
' Requirements: ->  (+/-) SHIFT (ShiftID, ShiftTimeStart, ShiftTimeEnd, ShiftName, ShiftStat, ShiftRemarks)
'               ->  (*) SHIFT(ShiftTimeStart, ShiftTimeEnd, ShiftName, ShiftStat, ShiftRemarks)
'               ->  Deletion will not continue if an employee has logged to that shift
'               ->  Required Field at ShiftID, ShiftTimeStart, ShiftTimeEnd, ShiftName, ShiftStat
'               ->  Unique value at ShiftName
'               ->  Create a shift schedule for the hotel, Edit previous shifts and delete
'                   schedules that have not yet logged by an employee.
' Results:      ->  A new shift is created.
'               ->  Previous shift information are altered.
'messagebox

Public Class frmSystemShift

    Private gState As State = State.waiting

#Region "Functions/SubRoutines"

    Private Sub DisplayShift()

        ListItems(DatabasePath(), "SELECT ShiftID, ShiftTimeStart, ShiftTimeEnd FROM Shift ", dgvTemp)
        lblCount.Text = ListItems(DatabasePath, "SELECT ShiftId AS [Shift No], ShiftName AS [Shift Name], " & _
                                                "CONVERT(char(2), {fn HOUR(ShiftTimeStart)}) + ':' + CONVERT(char(2),{fn MINUTE(ShiftTimeStart)}) AS [Start Time], " & _
                                                "CONVERT(char(2), {fn HOUR(ShiftTimeEnd)}) + ':' + CONVERT(char(2),{fn MINUTE(ShiftTimeEnd)}) AS [End Time], " & _
                                                "ShiftStat AS Status, ShiftRemarks AS Remarks FROM SHIFT " & _
                                                IIf(String.Compare(cboViewStatus.Text, "all", True) = 0, " ", "WHERE ShiftStat='" & cboViewStatus.Text & "' ").ToString & _
                                                "ORDER BY ShiftID ", dgvShiftSchedule).ToString

        For intCtr As Integer = 0 To dgvShiftSchedule.Rows.Count - 1
            Dim strTime() As String = Split(dgvShiftSchedule.Item(2, intCtr).Value.ToString, ":")

            If Trim(strTime(0)).Length = 1 Then
                strTime(0) = "0" & strTime(0)
            End If

            If Trim(strTime(1)).Length = 1 Then
                strTime(1) = "0" & strTime(1)
            End If

            dgvShiftSchedule.Item(2, intCtr).Value = Trim(strTime(0)) & ":" & Trim(strTime(1))


            strTime = Split(dgvShiftSchedule.Item(3, intCtr).Value.ToString, ":")

            If Trim(strTime(0)).Length = 1 Then
                strTime(0) = "0" & strTime(0)
            End If

            If Trim(strTime(1)).Length = 1 Then
                strTime(1) = "0" & strTime(1)
            End If

            dgvShiftSchedule.Item(3, intCtr).Value = Trim(strTime(0)) & ":" & Trim(strTime(1))

        Next


    End Sub

    Private Function ThereAreInputErrors() As Boolean

        If Trim(txtShiftname.Text) = String.Empty Then
            Msg("1000")
            txtShiftname.Focus()
            Return True
            Exit Function
        End If

        If Trim(cboStatus.Text) = String.Empty Then
            Msg("1000")
            cboStatus.Focus()
            Return True
            Exit Function
        End If

        If TrimAll(cboStatus.Text) <> "ACTIVE" And TrimAll(cboStatus.Text) <> "INACTIVE" Then
            Msg("1001", , "Status must be ACTIVE or INACTIVE only")
            cboStatus.Focus()
            cboStatus.SelectAll()
            Return True
            Exit Function
        End If

        If gState = State.adding Then
            If IsExisting("SELECT ShiftID FROM SHIFT WHERE ShiftName='" & TrimAll(txtShiftname.Text, True) & "'") Then
                Msg("1002")
                txtShiftname.SelectAll()
                txtShiftname.Focus()
                Return True
                Exit Function
            End If
        ElseIf gState = State.updating Then
            If String.Compare(TrimAll(txtShiftname.Text), dgvShiftSchedule.Item(1, dgvShiftSchedule.CurrentRow.Index).Value.ToString, True) <> 0 Then 'Compare again
                If IsExisting("SELECT ShiftID FROM SHIFT WHERE ShiftName='" & TrimAll(txtShiftname.Text, True) & "'") Then
                    Msg("1002")
                    txtShiftname.SelectAll()
                    txtShiftname.Focus()
                    Return True
                    Exit Function
                End If
            End If
        End If

        Return False

    End Function

#End Region

#Region "Command Button"

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        gState = State.adding

        ClearControls(gbxInput)

        dtpStartTime.Value = CType("JAN 01, 2000 00:00 AM", Date)
        dtpEndTime.Value = CType("JAN 01, 2000 00:00 AM", Date)

        gbxInput.Enabled = True
        gbxShiftSchedules.Enabled = False

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If dgvShiftSchedule.SelectedRows.Count > 0 Then
            gState = State.updating

            txtShiftname.Text = dgvShiftSchedule.Item(1, dgvShiftSchedule.CurrentRow.Index).Value.ToString
            cboStatus.Text = dgvShiftSchedule.Item(4, dgvShiftSchedule.CurrentRow.Index).Value.ToString
            txtRemarks.Text = dgvShiftSchedule.Item(5, dgvShiftSchedule.CurrentRow.Index).Value.ToString

            Dim intCtr As Integer = 0
            For intCtr = 0 To dgvTemp.Rows.Count - 1
                If String.Compare(dgvShiftSchedule.Item(0, dgvShiftSchedule.CurrentRow.Index).Value.ToString, _
                                  dgvTemp.Item(0, intCtr).Value.ToString, True) = 0 Then
                    Exit For
                End If
            Next

            dtpStartTime.Value = CType(dgvTemp.Item(1, intCtr).Value, Date)
            dtpEndTime.Value = CType(dgvTemp.Item(2, intCtr).Value, Date)

            gbxInput.Enabled = True
            gbxShiftSchedules.Enabled = False
        Else
            Msg("1005")
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        If dgvShiftSchedule.SelectedRows.Count > 0 Then
            If IsExisting("SELECT ShiftID FROM LOG_INFO WHERE ShiftID='" & dgvShiftSchedule.Item(0, dgvShiftSchedule.CurrentRow.Index).Value.ToString & "'") Then
                Msg("1006", , "Cannot delete because an employee has already logged to this shift.")
            Else

                If Msg("1034", Button.YesNo) = ButtonClicked.Yes Then
                    Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
                        objConnection.Open()
                        Using objTransaction As SqlTransaction = objConnection.BeginTransaction
                            Using objCommand As SqlCommand = objConnection.CreateCommand
                                With objCommand
                                    .Transaction = objTransaction
                                    .CommandText = "DELETE FROM SHIFT WHERE ShiftID=@ShiftID"
                                    .Parameters.AddWithValue("@ShiftID", dgvShiftSchedule.Item(0, dgvShiftSchedule.CurrentRow.Index).Value)

                                    Try
                                        .ExecuteNonQuery()
                                        objTransaction.Commit()

                                        DisplayShift()
                                        frmParent.tssStatus.Text = "Shift deleted..."

                                    Catch ex As Exception

                                        objTransaction.Rollback()
                                        Msg("1008", , NWLN & ex.Message)
                                    End Try
                                End With
                            End Using
                        End Using
                        objConnection.Close()
                    End Using
                End If 'Are you sure?

            End If
        Else
            Msg("1005")
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If ThereAreInputErrors() Then Exit Sub

        Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
            objConnection.Open()
            Using objTransaction As SqlTransaction = objConnection.BeginTransaction
                Using objCommand As SqlCommand = objConnection.CreateCommand
                    With objCommand
                        .Transaction = objTransaction

                        Select Case gState
                            Case State.adding
                                .CommandText = "INSERT INTO SHIFT (ShiftID, ShiftTimeStart, ShiftTimeEnd, ShiftName, ShiftStat, ShiftRemarks) " & _
                                               "VALUES (@ShiftID, @ShiftTimeStart, @ShiftTimeEnd, @ShiftName, @ShiftStat, @ShiftRemarks)"
                                .Parameters.AddWithValue("@ShiftID", GetPrimaryKeyNo("Shift"))
                                IncrementPrimaryKeyNo("Shift")

                            Case State.updating
                                .CommandText = "UPDATE SHIFT SET ShiftTimeStart=@ShiftTimeStart, ShiftTimeEnd=@ShiftTimeEnd, ShiftName=@ShiftName, ShiftStat=@ShiftStat, ShiftRemarks=@ShiftRemarks WHERE ShiftID=@ShiftID"
                                .Parameters.AddWithValue("@ShiftID", dgvShiftSchedule.Item(0, dgvShiftSchedule.CurrentRow.Index).Value)

                        End Select

                        With .Parameters
                            .AddWithValue("@ShiftTimeStart", dtpStartTime.Value).SqlDbType = SqlDbType.DateTime
                            .AddWithValue("@ShiftTimeEnd", dtpEndTime.Value).SqlDbType = SqlDbType.DateTime
                            .AddWithValue("@ShiftName", TrimAll(txtShiftname.Text, True))
                            .AddWithValue("@ShiftStat", TrimAll(cboStatus.Text))
                            .AddWithValue("@ShiftRemarks", TrimAll(txtRemarks.Text))
                        End With

                        Try

                            .ExecuteNonQuery()
                            objTransaction.Commit()

                            Select Case gState
                                Case State.adding
                                    frmParent.tssStatus.Text = "A new shift was added..."
                                Case State.updating
                                    frmParent.tssStatus.Text = "Shift information was altered..."
                            End Select

                            gState = State.waiting
                            gbxInput.Enabled = False
                            gbxShiftSchedules.Enabled = True
                            ClearControls(gbxInput)

                            DisplayShift()

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
        gState = State.waiting
        gbxInput.Enabled = False
        gbxShiftSchedules.Enabled = True
        ClearControls(gbxInput)

        DisplayShift()
    End Sub

#End Region

#Region "MISC"

    Private Sub frmSystemShift_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListItems(DatabasePath(), "SELECT ShiftID, ShiftTimeStart, ShiftTimeEnd FROM Shift ", dgvTemp)

        DisplayShift()
        dgvShiftSchedule.AlternatingRowsDefaultCellStyle = SetAlternatingColor()
    End Sub

    Private Sub cboViewStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboViewStatus.SelectedIndexChanged
        DisplayShift()
    End Sub

    Private Sub frmSystemShift_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If gState <> State.waiting Then
            Select Case Msg("1033", Button.YesNoCancel)
                Case ButtonClicked.Yes
                    If ThereAreInputErrors() Then
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

    Private Sub dgvShiftSchedule_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvShiftSchedule.SelectionChanged


        If dgvTemp.Rows.Count <> 0 Then
            Try
                txtShiftname.Text = dgvShiftSchedule.Item(1, dgvShiftSchedule.CurrentRow.Index).Value.ToString
                cboStatus.Text = dgvShiftSchedule.Item(4, dgvShiftSchedule.CurrentRow.Index).Value.ToString
                txtRemarks.Text = dgvShiftSchedule.Item(5, dgvShiftSchedule.CurrentRow.Index).Value.ToString

                Dim intCtr As Integer = 0
                For intCtr = 0 To dgvTemp.Rows.Count - 1
                    If String.Compare(dgvShiftSchedule.Item(0, dgvShiftSchedule.CurrentRow.Index).Value.ToString, _
                                      dgvTemp.Item(0, intCtr).Value.ToString, True) = 0 Then
                        Exit For
                    End If
                Next

                dtpStartTime.Value = CType(dgvTemp.Item(1, intCtr).Value, Date)
                dtpEndTime.Value = CType(dgvTemp.Item(2, intCtr).Value, Date)
            Catch ex As Exception
                'Error when user clicks the column to reorder
            End Try
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

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Display(Forms.frmLogMonitoring)
    End Sub

#End Region

End Class