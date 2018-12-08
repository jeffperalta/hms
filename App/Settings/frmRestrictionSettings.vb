Option Strict On
Option Explicit On

Public Class frmRestrictionSettings

#Region "MISC"

    Private Sub frmRestrictionSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With My.Settings
            chkGuestFolio.Checked = .RestrictDeleteAtFolio
            chkDirectBillers.Checked = .RestrictDirectBillers
            chkModification.Checked = .RestrictModifyAmount
            chkRefunds.Checked = .RestrictRefund()
            chkShift.Checked = .RestrictShiftChange
            chkUncollectibles.Checked = .RestrictUncollectibles
            chkRegistration.Checked = .RestrictUpdateRegistration
            chkReservation.Checked = .RestrictUpdateReservation
        End With
    End Sub

 
#End Region

End Class