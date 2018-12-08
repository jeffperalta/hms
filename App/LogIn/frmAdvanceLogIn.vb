Option Explicit On
Option Strict On

Imports System.Data.SqlClient
Imports System.Data

' Programmer:   Jo Jefferson D. Peralta
' Date:         March 07, 2007
' Title:        frmAdvanceLogIn
' Purpose:      If there are conflicting shifts or if the user would like to manually change 
'               the shift then he can use this interface.
'               If the user wishes to change his account password use this form
'               Usernames of typical users are changed  at the frmAddEditUser form, so the employees
'               will have to call the manager or any system user.
'               Usernames or passwords of an administrator (SYS, TRANS, QUER) is also set at frmAddEditUser
' Requirements: ->  (*) EMPLOYEE(EUserPassword)
'               ->  Change of username and password of admin account is done at frmAddEditUser
'               ->  Users cannot change the password of a blocked account (EActive='INACTIVE')
'               ->  The user cannot just change the shift on his own will but will have to call the manager
'               ->  to allow his intention
' Results:      ->  Conflicts in shift schedules are resolved by manually specifying the shift from where to log 
'               ->  Password of typical users are changed
'Messagebox>>> DONE

Public Class frmAdvanceLogIn

#Region "Functions/Subroutines"

    Private Sub DisplayShift()

        Using objConnection As SqlConnection = SetUpConnection(DatabasePath(), True)
            objConnection.Open()
            Using objCommand As SqlCommand = New SqlCommand("SELECT ShiftName FROM SHIFT WHERE SHIFTID='" & ShiftNow & "'", objConnection)
                Dim objShiftName As Object
                objShiftName = objCommand.ExecuteScalar
                If objShiftName Is Nothing Then
                    lblShiftName.Text = "NONE"
                Else
                    lblShiftName.Text = objShiftName.ToString
                End If
            End Using
            objConnection.Close()
        End Using


        lblCount.Text = ListItems(DatabasePath, "SELECT ShiftId AS [Shift No], ShiftName AS [Shift Name], " & _
                                                "CONVERT(char(2), {fn HOUR(ShiftTimeStart)}) + ':' + CONVERT(char(2),{fn MINUTE(ShiftTimeStart)}) AS [Start Time], " & _
                                                "CONVERT(char(2), {fn HOUR(ShiftTimeEnd)}) + ':' + CONVERT(char(2),{fn MINUTE(ShiftTimeEnd)}) AS [End Time], " & _
                                                "ShiftStat AS Status, ShiftRemarks AS Remarks FROM SHIFT " & _
                                                "WHERE ShiftStat='ACTIVE' AND ShiftId <> '" & ShiftNow & "' " & _
                                                "ORDER BY ShiftID ", dgvListOfShift).ToString

        For intCtr As Integer = 0 To dgvListOfShift.Rows.Count - 1
            Dim strTime() As String = Split(dgvListOfShift.Item(2, intCtr).Value.ToString, ":")

            If Trim(strTime(0)).Length = 1 Then
                strTime(0) = "0" & strTime(0)
            End If

            If Trim(strTime(1)).Length = 1 Then
                strTime(1) = "0" & strTime(1)
            End If

            dgvListOfShift.Item(2, intCtr).Value = Trim(strTime(0)) & ":" & Trim(strTime(1))


            strTime = Split(dgvListOfShift.Item(3, intCtr).Value.ToString, ":")

            If Trim(strTime(0)).Length = 1 Then
                strTime(0) = "0" & strTime(0)
            End If

            If Trim(strTime(1)).Length = 1 Then
                strTime(1) = "0" & strTime(1)
            End If

            dgvListOfShift.Item(3, intCtr).Value = Trim(strTime(0)) & ":" & Trim(strTime(1))

        Next


    End Sub

#End Region

#Region "Command Buttons"

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If dgvListOfShift.SelectedRows.Count > 0 Then
            If My.Settings.RestrictShiftChange Then
                frmAuthorization.ShowDialog()
                If frmAuthorization.Result = True Then
                    frmLogin.ChangeShiftNumber = dgvListOfShift.Item(0, dgvListOfShift.CurrentRow.Index).Value.ToString
                    DisplayShift()
                    Msg("1032", , "The shift was manually changed." & NWLN & "Current Shift is " & lblShiftName.Text)
                Else
                    Msg("1020")
                End If
            Else
                frmLogin.ChangeShiftNumber = dgvListOfShift.Item(0, dgvListOfShift.CurrentRow.Index).Value.ToString
                DisplayShift()
                Msg("1032", , "The shift was manually changed." & NWLN & "Current Shift is " & lblShiftName.Text)
            End If
        Else
            Msg("1021")
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSavePassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSavePassword.Click
        If txtNewPassword.Text = txtConfirm.Text Then
            If txtOldUsername.Text.ToUpper = "SYS" Or txtOldUsername.Text.ToUpper = "QUER" Or txtOldUsername.Text.ToUpper = "TRANS" Then
                Msg("1027")
                txtOldPassword.SelectAll()
                txtOldPassword.Focus()
            Else
                Select Case CheckUserNameAndPassword(txtOldUsername.Text, txtOldPassword.Text, False, False)
                    Case KindOfUserAccess.Authorized

                        If Msg("1034", Button.YesNo) = ButtonClicked.No Then Exit Sub

                        Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
                            objConnection.Open()
                            Using objTransaction As SqlTransaction = objConnection.BeginTransaction
                                Dim objCommand As SqlCommand = objConnection.CreateCommand
                                objCommand.Transaction = objTransaction
                                objCommand.Connection = objConnection
                                objCommand.CommandText = "UPDATE EMPLOYEE SET EUserPassword=@EUserPassword WHERE EUserName=@EUserName; "
                                objCommand.CommandType = CommandType.Text

                                If Trim(txtNewPassword.Text).Length < 6 Then
                                    Msg("1078")
                                    txtNewPassword.SelectAll()
                                    txtNewPassword.Focus()
                                    Exit Sub
                                End If

                                objCommand.Parameters.AddWithValue("@EUserPassword", Encrypt(txtNewPassword.Text))
                                objCommand.Parameters.AddWithValue("@EUserName", txtOldUsername.Text)

                                Try
                                    objCommand.ExecuteNonQuery()
                                    objTransaction.Commit()

                                    Msg("1032")

                                Catch ex As Exception
                                    objTransaction.Rollback()
                                    Msg("1008", , NWLN & ex.Message)
                                End Try
                            End Using
                            objConnection.Close()

                        End Using

                        ClearControls(gbxChangePassword)
                        txtOldUsername.Focus()

                    Case KindOfUserAccess.Blocked
                        Msg("1070", Button.Ok)

                        txtOldUsername.SelectAll()
                        txtOldUsername.Focus()

                    Case KindOfUserAccess.Illegal

                        Msg("1028", Button.Ok)

                End Select
            End If
        Else
            Msg("1030")
            txtConfirm.SelectAll()
            txtConfirm.Focus()
        End If
    End Sub

    Private Sub btnExit_Password_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit_Password.Click
        Me.Close()
    End Sub

#End Region

#Region "MISC"

    Private Sub frmAdvanceLogIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DisplayShift()
        dgvListOfShift.AlternatingRowsDefaultCellStyle = SetAlternatingColor()
    End Sub

#End Region

End Class