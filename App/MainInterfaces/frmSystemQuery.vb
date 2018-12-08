Option Explicit On
Option Strict On

Public Class frmSystemQuery

    Private Sub picRoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picRoom.Click
        Display(Forms.frmQueryRMStat)
    End Sub

    Private Sub picUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picUser.Click
        Display(Forms.frmQueryShift)
    End Sub

    Private Sub picBilling_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picBilling.Click
        Display(Forms.frmQuerySettings)
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class