Option Explicit On
Option Strict On

Public Class frmSettings

    Private Sub picRoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picRoom.Click
        Display(Forms.frmRoomSettings)
    End Sub

    Private Sub picDatabase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picDatabase.Click
        Display(Forms.frmSystemDatabase_parent)
    End Sub

    Private Sub picUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picUser.Click
        Display(Forms.frmSystemAddEditUserAccount)
    End Sub

    Private Sub picRL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picRL.Click
        Display(Forms.frmSystemSettingsRLFormat)
    End Sub

    Private Sub picBilling_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picBilling.Click
        Display(Forms.frmSystemBillingInfo)
    End Sub

    Private Sub picShift_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picShift.Click
        Display(Forms.frmSystemShift)
    End Sub

    Private Sub picResetPassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picResetPassword.Click
        Display(Forms.frmResetPassword)
    End Sub

    Private Sub picEndShift_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picEndShift.Click
        Display(Forms.frmLogMonitoring)
    End Sub

    Private Sub btnRestart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestart.Click
        If Msg("1011", Button.YesNo, "The system will now restart are you sure?") = ButtonClicked.Yes Then
            Application.ExitThread()
            Application.Restart()
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class