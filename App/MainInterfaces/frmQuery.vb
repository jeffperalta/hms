Option Explicit On
Option Strict On

Imports System.Data.SqlClient
Imports System.Data

Public Class frmQuery

#Region "Functions/Subroutines"

    Private Sub DisplayInformation()

        'Display hotel name
        lblHotelName.Text = GetHotelName()

        'Display user information
        Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
            objConnection.Open()
            Using objCommand As SqlCommand = New SqlCommand("SELECT ISNULL(EFName,'') AS EFName, ISNULL(ELName,'') AS ELName, ISNULL(EMI,'') AS EMI, ISNULL(EPosition,'') AS EPosition, ISNULL(EPicPath,'') AS EPicPath FROM EMPLOYEE WHERE EID='" & DatabaseUser() & "'", objConnection)
                Using objReader As SqlDataReader = objCommand.ExecuteReader
                    objReader.Read()
                    lblName.Text = IIf(LogInAsSystem, DatabaseUser(), objReader("ELName").ToString).ToString & ", " & NormalCase(objReader("EFName").ToString) & " " & NormalCase(objReader("EMI").ToString)
                    lblPosition.Text = NormalCase(objReader("EPosition").ToString)

                    If LogInAsSystem Then
                        picEmployee.BackgroundImage = My.Resources.SystemUser
                        picEmployee.BackgroundImageLayout = ImageLayout.Stretch
                    Else
                        LoadPicture(objReader("EPicPath").ToString, picEmployee)
                    End If

                    objReader.Close()
                End Using
            End Using
            objConnection.Close()
        End Using

    End Sub

#End Region

#Region "MISC"

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblTime.Text = Format(Date.Now, "MMMM dd, yyyy hh:mm:ss tt")
    End Sub

    Private Sub frmQuery_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblTime.Text = Format(Date.Now, "MMMM dd, yyyy hh:mm:ss tt")
        DisplayInformation()
    End Sub

    Private Sub lblLogOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblLogOut.Click
        frmLogout.ShowDialog()
    End Sub

#End Region

#Region "ICONS"

    Private Sub pnlGuestFolio_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlGuestFolio.MouseHover
        lblGuestFolio.ForeColor = Color.Black
    End Sub

    Private Sub pnlGuestFolio_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlGuestFolio.MouseLeave
        lblGuestFolio.ForeColor = Color.Gray
    End Sub

    Private Sub pnlRoomRack_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlRoomRack.MouseHover
        lblRoomRack.ForeColor = Color.Black
    End Sub

    Private Sub pnlRoomRack_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlRoomRack.MouseLeave
        lblRoomRack.ForeColor = Color.Gray
    End Sub

    Private Sub pnlQueries_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlQueries.MouseHover
        lblQueries.ForeColor = Color.Black
    End Sub

    Private Sub pnlQueries_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlQueries.MouseLeave
        lblQueries.ForeColor = Color.Gray
    End Sub

    Private Sub pnlReports_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlReports.MouseHover
        lblReports.ForeColor = Color.Black
    End Sub

    Private Sub pnlReports_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlReports.MouseLeave
        lblReports.ForeColor = Color.Gray
    End Sub

    Private Sub pnlGuestInformation_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlGuestInformation.MouseHover
        lblGuestInformation.ForeColor = Color.Black
    End Sub

    Private Sub pnlGuestInformation_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlGuestInformation.MouseLeave
        lblGuestInformation.ForeColor = Color.Gray
    End Sub




    Private Sub pnlGuestFolio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlGuestFolio.Click
        Display(Forms.frmGuestFolio)
        Me.Close()
    End Sub

    Private Sub pnlRoomRack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlRoomRack.Click
        Display(Forms.frmRoomRack)
        Me.Close()
    End Sub

    Private Sub pnlGuestInformation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlGuestInformation.Click
        Display(Forms.frmGuestInformation)
        Me.Close()
    End Sub

    Private Sub pnlQueries_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlQueries.Click
        Display(Forms.frmSystemQuery)
        Me.Close()
    End Sub

    Private Sub pnlReports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlReports.Click
        Display(Forms.frmReports)
        Me.Close()
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
        Me.Close()
    End Sub

    Private Sub DepartureToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartureToolStripMenuItem.Click
        If UserPrivilege <> Privilege.query Then
            Display(Forms.frmDeparture)
            Me.Close()
        End If
    End Sub

    Private Sub GuestInformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuestInformationToolStripMenuItem.Click
        Display(Forms.frmGuestInformation)
        Me.Close()
    End Sub

    Private Sub UpdateReservationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateReservationToolStripMenuItem.Click
        If UserPrivilege <> Privilege.query Then
            If My.Settings.RestrictUpdateReservation AndAlso UserPrivilege = Privilege.transaction Then
                'Nothing
            Else
                Display(Forms.frmUpdateReservation)
                Me.Close()
            End If
        End If
    End Sub

    Private Sub UpdateRegistrationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateRegistrationToolStripMenuItem.Click
        If UserPrivilege <> Privilege.query Then
            If My.Settings.RestrictUpdateRegistration AndAlso UserPrivilege = Privilege.transaction Then
                'Nothing
            Else
                Display(Forms.frmUpdateRegistration)
                Me.Close()
            End If
        End If
    End Sub

    Private Sub RoomTransferToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomTransferToolStripMenuItem.Click
        If UserPrivilege <> Privilege.query Then
            Display(Forms.frmRoomTransfer)
            Me.Close()
        End If
    End Sub

    Private Sub AmenitiesAndServicesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AmenitiesAndServicesToolStripMenuItem.Click
        If UserPrivilege <> Privilege.query Then
            Display(Forms.frmAmenitiesAndServices)
            Me.Close()
        End If
    End Sub

    Private Sub UpdateRoomChargeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateRoomChargeToolStripMenuItem.Click
        If UserPrivilege <> Privilege.query Then
            Display(Forms.frmUpdateRoomCharge)
            Me.Close()
        End If
    End Sub

    Private Sub AccountTransferToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccountTransferToolStripMenuItem.Click
        If UserPrivilege <> Privilege.query Then
            Display(Forms.frmAccountTransfer)
            Me.Close()
        End If
    End Sub

    Private Sub ModifyAmountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifyAmountToolStripMenuItem.Click
        If UserPrivilege <> Privilege.query Then
            Display(Forms.frmModifyAmount)
            Me.Close()
        End If
    End Sub

    Private Sub UncollectibleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UncollectibleToolStripMenuItem.Click
        If UserPrivilege <> Privilege.query Then
            Display(Forms.frmUncollectible)
            Me.Close()
        End If
    End Sub

    Private Sub RoomMaintenanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomMaintenanceToolStripMenuItem.Click
        If UserPrivilege <> Privilege.query Then
            Display(Forms.frmRoomMaintenance)
            Me.Close()
        End If
    End Sub

    Private Sub RoomStatusQueryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomStatusQueryToolStripMenuItem.Click
        Display(Forms.frmQueryRMStat)
        Me.Close()
    End Sub

    Private Sub ShiftQueryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShiftQueryToolStripMenuItem.Click
        Display(Forms.frmQueryShift)
        Me.Close()
    End Sub

    Private Sub SettingsQueryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsQueryToolStripMenuItem.Click
        Display(Forms.frmQuerySettings)
        Me.Close()
    End Sub

    Private Sub ReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportsToolStripMenuItem.Click
        Display(Forms.frmReports)
        Me.Close()
    End Sub

    Private Sub UserSettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserSettingsToolStripMenuItem.Click
        If UserPrivilege = Privilege.system Then
            Display(Forms.frmSystemAddEditUserAccount)
            Me.Close()
        End If
    End Sub

    Private Sub DatabaseSettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatabaseSettingsToolStripMenuItem.Click
        If UserPrivilege = Privilege.system Then
            Display(Forms.frmSystemDatabase_parent)
            Me.Close()
        End If
    End Sub

    Private Sub RoomSettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomSettingsToolStripMenuItem.Click
        If UserPrivilege = Privilege.system Then
            Display(Forms.frmRoomSettings)
            Me.Close()
        End If
    End Sub

    Private Sub BillingSettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BillingSettingsToolStripMenuItem.Click
        If UserPrivilege = Privilege.system Then
            Display(Forms.frmSystemBillingInfo)
            Me.Close()
        End If
    End Sub

    Private Sub RecordLocatorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecordLocatorToolStripMenuItem.Click
        If UserPrivilege = Privilege.system Then
            Display(Forms.frmSystemSettingsRLFormat)
            Me.Close()
        End If
    End Sub

    Private Sub ShiftSettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShiftSettingsToolStripMenuItem.Click
        If UserPrivilege = Privilege.system Then
            Display(Forms.frmSystemShift)
            Me.Close()
        End If
    End Sub

    Private Sub EndLogShiftToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EndLogShiftToolStripMenuItem.Click
        If UserPrivilege = Privilege.system Then
            Display(Forms.frmLogMonitoring)
            Me.Close()
        End If
    End Sub

    Private Sub ResetPasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetPasswordToolStripMenuItem.Click
        If UserPrivilege = Privilege.system Then
            Display(Forms.frmResetPassword)
            Me.Close()
        End If
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOutToolStripMenuItem.Click
        frmLogout.ShowDialog()
    End Sub

    Private Sub ReservationToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReservationToolStripMenuItem1.Click
        If UserPrivilege <> Privilege.query Then
            Display(Forms.frmReservation)
            Me.Close()
        End If
    End Sub

    Private Sub RegistrationToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistrationToolStripMenuItem1.Click
        If UserPrivilege <> Privilege.query Then
            Display(Forms.frmRegistration)
            Me.Close()
        End If
    End Sub

    Private Sub BillingToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BillingToolStripMenuItem1.Click
        If UserPrivilege <> Privilege.query Then
            Display(Forms.frmPayment)
            Me.Close()
        End If
    End Sub

    Private Sub RoomRackToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomRackToolStripMenuItem1.Click
        Display(Forms.frmRoomRack)
        Me.Close()
    End Sub

    Private Sub GuestFolioToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuestFolioToolStripMenuItem1.Click
        Display(Forms.frmGuestFolio)
        Me.Close()
    End Sub

    Private Sub RefundToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefundToolStripMenuItem.Click
        If UserPrivilege <> Privilege.query Then
            Display(Forms.frmRefund)
            Me.Close()
        End If
    End Sub

    Private Sub DirectBillerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DirectBillerToolStripMenuItem.Click
        If UserPrivilege <> Privilege.query Then
            Display(Forms.frmDirectBiller)
            Me.Close()
        End If
    End Sub

#End Region

End Class