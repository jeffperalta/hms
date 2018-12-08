Option Strict On
Option Explicit On

Imports System.Data
Imports System.Data.SqlClient

' Programmer:   Jo Jefferson Peralta
' Date:         January, 2007
' Title:        frmAuthorization
' Purpose:      This is used to determine if the user is allowed to continue with the restricted action.
'               A manager's authorization is needed - that is, a system account at the hotel.
'               the user cannot enter the account of the system, quer, and trans.
' Requirements: To restrict and authorize a user if he can continue with a restricted action.
' Results:      ->  The transaction is allowed or not depending on the hotel managers approval.


Public Class frmAuthorization

    Private _UserIsAuthorized As Boolean = False

#Region "MISC"

    Public ReadOnly Property Result() As Boolean
        Get
            Return _UserIsAuthorized
            _UserIsAuthorized = False
        End Get
    End Property

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        'the 4th parameter means that the interface only checks the user credentials
        'and therefore maintains the previous user information
        Select Case CheckUserNameAndPassword(txtUserName.Text, txtPassword.Text, False, False)
            Case KindOfUserAccess.Authorized

                If IsExisting("SELECT EID FROM EMPLOYEE WHERE EUserName='" & txtUserName.Text & "' AND EUserType='SYSTEM'") Then
                    _UserIsAuthorized = True
                    Me.Close()
                Else
                    _UserIsAuthorized = False
                End If

            Case KindOfUserAccess.Illegal
                _UserIsAuthorized = False
                Msg("1071", Button.Ok)
                txtUserName.Text = String.Empty
                txtPassword.Text = String.Empty
                txtUserName.Focus()
            Case KindOfUserAccess.Blocked
                _UserIsAuthorized = False
                Msg("1070", Button.Ok)
                txtUserName.Text = String.Empty
                txtPassword.Text = String.Empty
                txtUserName.Focus()
        End Select
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
        _UserIsAuthorized = False
        ClearControls(Me)
    End Sub

    Private Sub frmAuthorization_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtUserName.Text = String.Empty
        txtPassword.Text = String.Empty
        _UserIsAuthorized = False
    End Sub

#End Region

End Class
