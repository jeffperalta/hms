Option Explicit On
Option Strict On

Imports System.Data
Imports System.Data.SqlClient

Imports System.Drawing.Imaging

Public Class frmParent

#Region "Command Button"

    Private Sub btnSideMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSideMenu.Click
        If btnSideMenu.Text = ">" Then
            tlsMainButton.Show()
            btnSideMenu.Text = "<"
        Else
            tlsMainButton.Hide()
            btnSideMenu.Text = ">"
        End If
    End Sub

    Private Sub Control_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picMinimize.MouseEnter, picExit.MouseEnter, picHelp.MouseEnter, PictureBox5.MouseEnter, PictureBox2.MouseEnter
        Dim ctl As PictureBox = CType(sender, PictureBox)
        ctl.Width += 2
        ctl.Height += 2
        ctl.Top -= 1
        ctl.Left -= 1
        lblToolTip.Text = CType(ctl.Tag, String)
    End Sub

    Private Sub Control_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picMinimize.MouseLeave, picExit.MouseLeave, picHelp.MouseLeave, PictureBox5.MouseLeave, PictureBox2.MouseLeave
        Dim ctl As PictureBox = CType(sender, PictureBox)
        ctl.Width -= 2
        ctl.Height -= 2
        ctl.Top += 1
        ctl.Left += 1
        lblToolTip.Text = String.Empty
    End Sub

#End Region

#Region "MISC"

    Private Sub FrmParent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tssTime.Text = Format(Date.Now, "MMMM dd, yyyy hh:mm ss tt")
        tssStatus.Width = Me.Width - tssTime.Width - 75

        lblHotelName.Text = GetHotelName
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        tssTime.Text = Format(Date.Now, "MMMM dd, yyyy hh:mm ss tt")
    End Sub

    Private Sub frmParent_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        'Using objConnection As SqlConnection = SetUpConnection(GetControlFile(), True)
        '    objConnection.Open()
        '    Using objDataSet As DataSet = SetUpDataSet(SetUpDataAdapter(objConnection, "SELECT * FROM DatabaseFile WHERE LastUsed = 'TRUE'", DatabaseTransactionState.SelectState), "Check")
        '        If objDataSet.Tables("Check").Rows.Count <> 1 Then

        '            With frmSystemDatabase_parent
        '                .MdiParent = Me
        '                .Show()
        '                .Top = 0
        '                .Left = 0
        '                .AutoScaleMode = AutoScaleMode.None
        '            End With

        '            e.Cancel = True
        '        Else
        '            e.Cancel = False
        '            frmLogout.Show()
        '        End If
        '    End Using
        '    objConnection.Close()
        'End Using

    End Sub

#End Region

#Region "Control ICON"

    Private Sub picExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picExit.Click
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        BackToMain()
        Me.Close()
    End Sub

    Private Sub picMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub picHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picHelp.Click
        HELP.Show()
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        frmAboutUs.ShowDialog()
    End Sub

#End Region

#Region "TAB"

    Private Sub tsbGuestInformation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuestInfo.Click
        Display(Forms.frmGuestInformation)
    End Sub

    Private Sub tsbRegistration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbRegistration.Click
        Display(Forms.frmRegistration)
    End Sub

    Private Sub tsbPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbBilling.Click
        Display(Forms.frmPayment)
    End Sub

    Private Sub tsbGuestInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuestInfo.Click
        Display(Forms.frmGuestInformation)
    End Sub

    Private Sub tsbGuestFolio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuestFolio.Click
        Display(Forms.frmGuestFolio)
    End Sub

    Private Sub tsbCheckOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbDeparture.Click
        Display(Forms.frmDeparture)
    End Sub

    Private Sub tsbRoomInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbRoomRack.Click
        Display(Forms.frmRoomRack)
    End Sub

    Private Sub tsbQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbQueries.Click
        Display(Forms.frmSystemQuery)
    End Sub

    Private Sub tsbReports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbReports.Click
        Display(Forms.frmReports)
    End Sub

    Private Sub tsbSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSettings.Click
        Display(Forms.frmSettings)
    End Sub

    Private Sub tsbReservation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbReservation.Click
        Display(Forms.frmReservation)
    End Sub

#End Region

#Region "ShortCuts"

    Private Sub ReservationToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpFileToolStripMenuItem1.Click
        HELP.Show()
    End Sub

    Private Sub GuestSearchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuestSearchToolStripMenuItem.Click
        Display(Forms.frmRoomRack)
        TriggeredBy = TriggeringForm.RoomRack
        frmGuestSearch.ShowDialog()
    End Sub

    Private Sub DepartureToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartureToolStripMenuItem.Click
        If UserPrivilege <> Privilege.query Then
            Display(Forms.frmDeparture)
        End If
    End Sub

    Private Sub GuestInformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuestInformationToolStripMenuItem.Click
        Display(Forms.frmGuestInformation)
    End Sub

    Private Sub UpdateReservationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateReservationToolStripMenuItem.Click
        If UserPrivilege <> Privilege.query Then
            If My.Settings.RestrictUpdateReservation AndAlso UserPrivilege = Privilege.transaction Then
                'Nothing
            Else
                Display(Forms.frmUpdateReservation)
            End If
        End If
    End Sub

    Private Sub UpdateRegistrationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateRegistrationToolStripMenuItem.Click
        If UserPrivilege <> Privilege.query Then
            If My.Settings.RestrictUpdateRegistration AndAlso UserPrivilege = Privilege.transaction Then
                'Nothing
            Else
                Display(Forms.frmUpdateRegistration)
            End If
        End If
    End Sub

    Private Sub RoomTransferToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomTransferToolStripMenuItem.Click
        If UserPrivilege <> Privilege.query Then
            Display(Forms.frmRoomTransfer)
        End If
    End Sub

    Private Sub AmenitiesAndServicesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AmenitiesAndServicesToolStripMenuItem.Click
        If UserPrivilege <> Privilege.query Then
            Display(Forms.frmAmenitiesAndServices)
        End If
    End Sub

    Private Sub UpdateRoomChargeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateRoomChargeToolStripMenuItem.Click
        If UserPrivilege <> Privilege.query Then
            Display(Forms.frmUpdateRoomCharge)
        End If
    End Sub

    Private Sub AccountTransferToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccountTransferToolStripMenuItem.Click
        If UserPrivilege <> Privilege.query Then
            Display(Forms.frmAccountTransfer)
        End If
    End Sub

    Private Sub ModifyAmountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifyAmountToolStripMenuItem.Click
        If UserPrivilege <> Privilege.query Then
            Display(Forms.frmModifyAmount)
        End If
    End Sub

    Private Sub UncollectibleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UncollectibleToolStripMenuItem.Click
        If UserPrivilege <> Privilege.query Then
            Display(Forms.frmUncollectible)
        End If
    End Sub

    Private Sub RoomMaintenanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomMaintenanceToolStripMenuItem.Click
        If UserPrivilege <> Privilege.query Then
            Display(Forms.frmRoomMaintenance)
        End If
    End Sub

    Private Sub RoomStatusQueryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomStatusQueryToolStripMenuItem.Click
        Display(Forms.frmQueryRMStat)

    End Sub

    Private Sub ShiftQueryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShiftQueryToolStripMenuItem.Click
        Display(Forms.frmQueryShift)
    End Sub

    Private Sub SettingsQueryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsQueryToolStripMenuItem.Click
        Display(Forms.frmQuerySettings)
    End Sub

    Private Sub ReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportsToolStripMenuItem.Click
        Display(Forms.frmReports)
    End Sub

    Private Sub UserSettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserSettingsToolStripMenuItem.Click
        If UserPrivilege = Privilege.system Then
            Display(Forms.frmSystemAddEditUserAccount)
        End If
    End Sub

    Private Sub DatabaseSettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatabaseSettingsToolStripMenuItem.Click
        If UserPrivilege = Privilege.system Then
            Display(Forms.frmSystemDatabase_parent)
        End If
    End Sub

    Private Sub RoomSettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomSettingsToolStripMenuItem.Click
        If UserPrivilege = Privilege.system Then
            Display(Forms.frmRoomSettings)
        End If
    End Sub

    Private Sub BillingSettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BillingSettingsToolStripMenuItem.Click
        If UserPrivilege = Privilege.system Then
            Display(Forms.frmSystemBillingInfo)
        End If
    End Sub

    Private Sub RecordLocatorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecordLocatorToolStripMenuItem.Click
        If UserPrivilege = Privilege.system Then
            Display(Forms.frmSystemSettingsRLFormat)
        End If
    End Sub

    Private Sub ShiftSettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShiftSettingsToolStripMenuItem.Click
        If UserPrivilege = Privilege.system Then
            Display(Forms.frmSystemShift)
        End If
    End Sub

    Private Sub EndLogShiftToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EndLogShiftToolStripMenuItem.Click
        If UserPrivilege = Privilege.system Then
            Display(Forms.frmLogMonitoring)
        End If
    End Sub

    Private Sub ResetPasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetPasswordToolStripMenuItem.Click
        If UserPrivilege = Privilege.system Then
            Display(Forms.frmResetPassword)
        End If
    End Sub

    Private Sub ReservationToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReservationToolStripMenuItem1.Click
        If UserPrivilege <> Privilege.query Then
            Display(Forms.frmReservation)
        End If
    End Sub

    Private Sub RegistrationToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistrationToolStripMenuItem1.Click
        If UserPrivilege <> Privilege.query Then
            Display(Forms.frmRegistration)
        End If
    End Sub

    Private Sub BillingToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BillingToolStripMenuItem1.Click
        If UserPrivilege <> Privilege.query Then
            Display(Forms.frmPayment)
        End If
    End Sub

    Private Sub RoomRackToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomRackToolStripMenuItem1.Click
        Display(Forms.frmRoomRack)
    End Sub

    Private Sub GuestFolioToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuestFolioToolStripMenuItem1.Click
        Display(Forms.frmGuestFolio)
    End Sub

    Private Sub RefundToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefundToolStripMenuItem.Click
        If UserPrivilege <> Privilege.query Then
            Display(Forms.frmRefund)
        End If
    End Sub

    Private Sub DirectBillerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DirectBillerToolStripMenuItem.Click
        If UserPrivilege <> Privilege.query Then
            Display(Forms.frmDirectBiller)
        End If
    End Sub

    Private Sub MainPageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MainPageToolStripMenuItem.Click
        BackToMain()
        Me.Close()
    End Sub

    Private Sub MyNotesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyNotesToolStripMenuItem1.Click
        If UserPrivilege <> Privilege.query Then
            frmMyNotes.Show()
            frmMyNotes.BringToFront()
        End If
    End Sub
#End Region

End Class
