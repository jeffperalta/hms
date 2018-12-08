Option Explicit On
Option Strict On

Imports System.Data.SqlClient
Imports System.Data

' Programmer:   Jo Jefferson D. Peralta
' Date:         March 06, 2007
' Title:        frmResetPassword
' Purpose:      This interface is used when a user has lost track of his password. 
'               The password is reset to its default value x[UserName]
' Requirements: ->  (*)EMPLOYEE(EUserPassword)
' Results:      ->  The password is reset

Public Class frmResetPassword

    Dim ResetPassword As ArrayList = New ArrayList 'This holds the users whose passwords are already reset

#Region "SubRoutines/Functions"

    Private Sub DisplayUser()

        lblNumberOfEmployee.Text = ListItems(DatabasePath, "SELECT EID AS ID, EFName AS [First Name], ELName AS [Last Name], EMI AS [Middle Name], EPosition AS Position, EActive AS Status,  " & _
                                                           "       EUserName AS [User Name], EUserType AS [Access Type], EPicPath AS [Picture Path] " & _
                                                           "FROM   EMPLOYEE WHERE EID NOT IN ('DEFAULT1000','DEFAULT1001','DEFAULT1002')", dgvUsers).ToString


    End Sub

#End Region

#Region "Command Buttons"

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        If dgvUsers.SelectedRows.Count > 0 Then
            If lblStatus.Text = "-" Then
                If Msg("1034", Button.YesNo) = ButtonClicked.Yes Then
                    Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
                        objConnection.Open()
                        Using objTransaction As SqlTransaction = objConnection.BeginTransaction
                            Using objCommand As SqlCommand = objConnection.CreateCommand
                                With objCommand
                                    .Transaction = objTransaction

                                    .CommandText = "SELECT EUserName FROM EMPLOYEE WHERE EID=@EID"
                                    .Parameters.AddWithValue("@EID", dgvUsers.Item(0, dgvUsers.CurrentRow.Index).Value.ToString)
                                    Dim strUserName As String = .ExecuteScalar.ToString
                                    strUserName = Encrypt("x" & strUserName)

                                    .CommandText = "UPDATE EMPLOYEE SET EUserPassword=@EUserPassword WHERE EID=@EID"
                                    .Parameters.AddWithValue("@EUserPassword", strUserName)

                                    Try
                                        .ExecuteNonQuery()
                                        objTransaction.Commit()

                                        frmParent.tssStatus.Text = "Password was reset..."
                                        Msg("1032")

                                        ResetPassword.Add(dgvUsers.Item(0, dgvUsers.CurrentRow.Index).Value.ToString)
                                        lblStatus.Text = "Password was reset..."

                                    Catch ex As Exception
                                        objTransaction.Rollback()
                                        Msg("1008", Button.Ok, ex.Message)

                                    End Try

                                End With
                            End Using
                        End Using
                        objConnection.Close()
                    End Using
                End If
            Else
                Msg("1029")
            End If
        Else
            Msg("1005")
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

#End Region

#Region "MISC"

    Private Sub dgvUsers_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvUsers.SelectionChanged
        If dgvUsers.SelectedRows.Count > 0 Then
            LoadPicture(dgvUsers.Item(8, dgvUsers.CurrentRow.Index).Value.ToString, pnlEmployee)
            lblName.Text = dgvUsers.Item(2, dgvUsers.CurrentRow.Index).Value.ToString & ", " & _
                           dgvUsers.Item(1, dgvUsers.CurrentRow.Index).Value.ToString & " " & _
                           dgvUsers.Item(3, dgvUsers.CurrentRow.Index).Value.ToString
            lblPosition.Text = dgvUsers.Item(4, dgvUsers.CurrentRow.Index).Value.ToString

            If ResetPassword.IndexOf(dgvUsers.Item(0, dgvUsers.CurrentRow.Index).Value.ToString) <> -1 Then
                lblStatus.Text = "Password was reset..."
            Else
                lblStatus.Text = "-"
            End If

        Else
            pnlEmployee.BackgroundImage = Nothing
            lblName.Text = "-"
            lblPosition.Text = "-"
            lblStatus.Text = "-"
        End If

        frmParent.tssStatus.Text = String.Empty
    End Sub

    Private Sub frmResetPassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DisplayUser()
        dgvUsers.AlternatingRowsDefaultCellStyle = SetAlternatingColor()
    End Sub

    Private Sub lblClose_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblClose.LinkClicked
        Me.Close()
    End Sub
#End Region

#Region "Side Bars"

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Display(Forms.frmSettings)
    End Sub

    Private Sub tsbReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbReset.Click
        Display(Forms.frmSystemAddEditUserAccount)
    End Sub

    Private Sub ToolStripButton13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton13.Click
        Display(Forms.frmLogMonitoring)
    End Sub

#End Region

    
End Class