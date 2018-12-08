Option Explicit On
Option Strict On

Imports System.Data.SqlClient

' Programmers:  Bobby Elbert D. Quiñones 
' Date:         February 19, 2007
' Title:        frmQueryRmStat
' Purpose:      This query is used to determine the rooms that are registered, reserved on a given date
'               The user can know what rooms are dirty, clean, and under maintenance
' Requirements: ->  Must display all reserverved, registered rooms.
' Results:      ->  The user was able to know the rooms that are occupied, reserved, registered.
'>Messages: Done

Public Class frmQueryRmStat

#Region "SubRoutines and Functions"

    Private Sub DisplayFirstTab()

        Dim strSQLStatement As String = "SELECT ROOM.RMNo AS [Room No], RMRATE.RMRAmt AS Amount, ROOM.RMType AS [Room Type], ROOM.RMFloor AS Floor, ROOM.RMView AS [View],  " & _
                                        "       ROOM.RMCurrStat AS [Current Status], ROOM.RMMaxGuest AS [No. of Occupants], ROOM.RMTelNo AS [Tel No.], ROOM.RMDesc AS Description,  " & _
                                        "       ROOM.RMRemarks AS Remarks " & _
                                        "FROM   ROOM INNER JOIN " & _
                                        "       RMRATE_DETAILS ON ROOM.RMNo = RMRATE_DETAILS.RMNo INNER JOIN " & _
                                        "       RMRATE ON RMRATE_DETAILS.RMRID = RMRATE.RMRID " & _
                                        "WHERE  (RMRATE_DETAILS.RMDActive = 'TRUE') "

        If Trim(cboType.Text) <> String.Empty Then strSQLStatement &= IIf(chkExactMatch.Checked, " AND ", " OR ").ToString & " ROOM.RMType='" & TrimAll(cboType.Text, True) & "' "
        If Trim(cboFloor.Text) <> String.Empty Then strSQLStatement &= IIf(chkExactMatch.Checked, " AND ", " OR ").ToString & " ROOM.RMFloor='" & TrimAll(cboFloor.Text, True) & "' "
        If Trim(cboStatus.Text) <> String.Empty Then strSQLStatement &= "AND ROOM.RMCurrStat='" & TrimAll(cboStatus.Text, True) & "'"

        ListItems(DatabasePath, strSQLStatement, dgvRoomMaintenanceStatus)
        lblResult_1.Text = dgvRoomMaintenanceStatus.Rows.Count.ToString

    End Sub

    Private Sub DisplaySecondTab()

        Dim strSQLStatement As String = "SELECT RESERVATION_DETAILS.RMNo AS [Room No], ISNULL(GUEST_INFO.GIFName, '') + ' ' + ISNULL(GUEST_INFO.GILName, '') AS [Guest Name], RESERVATION.ResGuestType AS [Guest Type], " & _
                                        "       RESERVATION_DETAILS.ResDTimeIn AS [Check In Date], RESERVATION_DETAILS.ResDTimeOut AS [Check Out Date], RESERVATION_DETAILS.ResDByRequest AS [Room By Request],  " & _
                                        "       RESERVATION_DETAILS.ResDNoOccupants AS [No. of Occupants], RESERVATION_DETAILS.ResDStat AS [Status], RESERVATION.ResRemarks AS Remarks " & _
                                        "FROM   RESERVATION_DETAILS INNER JOIN " & _
                                        "       RESERVATION ON RESERVATION_DETAILS.ResNo = RESERVATION.ResNo INNER JOIN " & _
                                        "       GUEST ON RESERVATION.GNo = GUEST.GNo INNER JOIN " & _
                                        "       GUEST_INFO ON GUEST.GIID = GUEST_INFO.GIID " & _
                                        "WHERE  RESERVATION_DETAILS.ResDStat = 'RESERVED' AND " & _
                                        "       (RESERVATION_DETAILS.RMNo IN " & _
                                        "         (SELECT RMNo " & _
                                        "          FROM   RMSTATUS " & _
                                        "          WHERE  (RMSName = 'RESERVED') AND (RMSStat IS NULL) AND (RMSStartTime BETWEEN CONVERT(DATETIME, '" & dtpDateFrom2.Value.ToString & "', 102) AND " & _
                                        "                  CONVERT(DATETIME, '" & dtpDateTo2.Value.ToString & "', 102)) OR " & _
                                        "                 (RMSEndTime BETWEEN CONVERT(DATETIME, '" & dtpDateFrom2.Value.ToString & "', 102) AND CONVERT(DATETIME, '" & dtpDateTo2.Value.ToString & "', 102)))) "

        ListItems(DatabasePath, strSQLStatement, dgvReservedRooms)
        Label3.Text = dgvReservedRooms.Rows.Count.ToString

    End Sub

    Private Sub DisplayThirdTab()

        Dim strSQLStatement As String = "SELECT DISTINCT RMSTATUS.RMNo AS [Room No], ISNULL(GUEST_INFO.GIFName, '') + ' ' + ISNULL(GUEST_INFO.GILName, '') AS [Guest Name], " & _
                                        "       REGISTRATION.RegGuestType AS [Guest Type], REGISTRATION_DETAILS.RegDChkInTime AS [Check In Date],  " & _
                                        "       REGISTRATION_DETAILS.RegDChkOutTime AS [Check Out Date], REGISTRATION_DETAILS.RegDNoOfExtDays AS [Extension in Days],  " & _
                                        "       REGISTRATION_DETAILS.RegDNoGuest AS [No. of Occupants], REGISTRATION.RegRemarks AS Remarks " & _
                                        "FROM   REGISTRATION INNER JOIN " & _
                                        "       REGISTRATION_DETAILS ON REGISTRATION.RegNo = REGISTRATION_DETAILS.RegNo INNER JOIN " & _
                                        "       GUEST ON REGISTRATION.GNo = GUEST.GNo INNER JOIN " & _
                                        "       GUEST_INFO ON GUEST.GIID = GUEST_INFO.GIID INNER JOIN " & _
                                        "       RMSTATUS ON REGISTRATION_DETAILS.RMNo = RMSTATUS.RMNo " & _
                                        "WHERE  (RMSTATUS.RMNo IN " & _
                                        "        (SELECT RMNo " & _
                                        "         FROM   RMSTATUS AS RMSTATUS_1 " & _
                                        "         WHERE  (RMSName = 'REGISTERED') AND (RMSStat IS NULL) AND (RMSStartTime BETWEEN CONVERT(DATETIME, '" & dtpDateFrom3.Value.ToString & "',  " & _
                                        "                   102) AND CONVERT(DATETIME, '" & dtpDateTo3.Value.ToString & "', 102)) OR " & _
                                        "                (RMSEndTime BETWEEN CONVERT(DATETIME, '" & dtpDateFrom3.Value.ToString & "', 102) AND CONVERT(DATETIME, '" & dtpDateTo3.Value.ToString & "',  " & _
                                        "                   102)))) AND (REGISTRATION.RegStat <> 'CHECKED OUT') "
        ListItems(DatabasePath, strSQLStatement, dgvRegisteredRooms)
        Label9.Text = dgvRegisteredRooms.Rows.Count.ToString

    End Sub

#End Region

#Region "Misc"

    Private Sub frmQueryRmStat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'First Tab
        ListItems(DatabasePath, "SELECT DISTINCT RMType FROM ROOM", cboType, "RMType")
        cboType.Text = String.Empty
        ListItems(DatabasePath, "SELECT DISTINCT RMFloor FROM ROOM", cboFloor, "RMFloor")
        cboFloor.Text = String.Empty
        dgvRoomMaintenanceStatus.AlternatingRowsDefaultCellStyle = SetAlternatingColor()
        DisplayFirstTab()

        'Second Tab
        dgvReservedRooms.AlternatingRowsDefaultCellStyle = SetAlternatingColor()
        DisplaySecondTab()

        'Third Tab
        dgvRegisteredRooms.AlternatingRowsDefaultCellStyle = SetAlternatingColor()
        DisplayThirdTab()

    End Sub

#End Region

#Region "Command Button"

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        DisplayFirstTab()
    End Sub

    Private Sub btnViewRoomDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewRoomDetails.Click
        Display(Forms.frmRoomRack)
    End Sub

    Private Sub lblClose_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblClose.LinkClicked
        Me.Close()
    End Sub

    Private Sub btnShowReservedRooms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowReservedRooms.Click
        DisplaySecondTab()
    End Sub

    Private Sub btnShowRegisteredRooms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowRegisteredRooms.Click
        DisplayThirdTab()
    End Sub

    Private Sub tsbQueryShift_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbQueryShift.Click
        Display(Forms.frmQueryShift)
    End Sub

    Private Sub tsbQuerySettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbQuerySettings.Click
        Display(Forms.frmQuerySettings)
    End Sub

#End Region

End Class