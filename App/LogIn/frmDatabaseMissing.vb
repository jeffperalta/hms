Option Explicit On
Option Strict On

Imports System.Data.SqlClient
Imports System.Data

' Programmer:   Jo Jefferson D. Peralta
' Date:         March 07, 2007
' Title:        frmDatabaseMissing
' Purpose:      When the data files are missing this interface is triggered to
'               determine and authenticate the user 
' Requirements: ->  Only system users (sys, quer, and trans) are allowed to proceed
' Results:      ->  frmSystemDatabase is shown when a system user logs

Public Class frmDatabaseMissing

    Private intAttempt As Integer = 0

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

        Select Case CheckUserNameAndPassword(txtUserName.Text, txtPassword.Text, True, False)
            Case KindOfUserAccess.Authorized
                frmSystemDatabase.Show()
                Me.Close()
            Case KindOfUserAccess.Illegal 'Check the default database
                Msg("1028", Button.Ok)
                intAttempt += 1

            Case KindOfUserAccess.Blocked
                Msg("1070", Button.Ok)
                intAttempt += 1

        End Select

        If intAttempt = 5 Then
            Application.Exit()
        Else
            lblAttempt.Text = CType(5 - intAttempt, String) & IIf((5 - intAttempt) = 1, " try ", " tries ").ToString & "left."
        End If

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class