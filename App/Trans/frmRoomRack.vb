Option Explicit On
Option Strict On

Imports System.Data.SqlClient
Imports System.Data

' Programmer:   Bobby Elbert D. Quiñones 
'               Jo Jefferson D. Peralta
' Date:         April 08, 2007
' Title:        frmRoomRack
' Purpose:      This interface is used to view room status on a specified dates. For instance the user can 
'               determine the reserved, registered, and vacant rooms. And from that status, the user can apply
'               appropriate transaction in a room. For example, if a room is vacant the FDO can access the 
'               reservation and registration interface passing the information that the choosen room is ready for
'               a reservation or registration respectively.
' Requirements: ->  A query interface
'               ->  Aside from the room status, the user can use other search criteria such as Room type,
'                   No of Occupants, Room View, Features, and Room description
'               ->  This interface also determines the previous transactions in a room. That is, 
'                   Reservation and registration history of a room is seen.
' Results:      ->  Main searches on rooms through its room status on a given date are seen.
'               ->  Room History is also seen.
'>>>MESSAGES DONE:

Public Class frmRoomRack

    Private gGiid As String = String.Empty

#Region "Subroutines/Functions"

    Public Sub FillMe()

        If SearchedGuestID = String.Empty Then
            Msg("1065", Button.Ok)
            Exit Sub
        Else
            gGiid = SearchedGuestID
        End If

        lvwRooms.Items.Clear()
        Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
            objConnection.Open()

            'Is this guest Registered?
            Using objCommand As SqlCommand = New SqlCommand( _
                        "SELECT REGISTRATION_DETAILS.RMNo " & _
                        "FROM   GUEST INNER JOIN " & _
                        "       REGISTRATION ON GUEST.GNo = REGISTRATION.GNo INNER JOIN " & _
                        "       REGISTRATION_DETAILS ON REGISTRATION.RegNo = REGISTRATION_DETAILS.RegNo " & _
                        "WHERE  (GUEST.GIID = '" & gGiid & "') AND (REGISTRATION.RegStat <> 'CHECKED OUT') AND (REGISTRATION_DETAILS.RegDStat <> 'CHECKED OUT') ", objConnection)
                Using objReader As SqlDataReader = objCommand.ExecuteReader
                    If objReader.HasRows Then
                        Do While objReader.Read
                            Dim lsvItem As ListViewItem = lvwRooms.Items.Add(objReader(0).ToString)
                            lsvItem.ImageKey = "Occupied"
                        Loop
                    End If
                    objReader.Close()
                End Using

                objCommand.CommandText = _
                    "SELECT DISTINCT RESERVATION_DETAILS.RMNo " & _
                    "FROM   GUEST INNER JOIN " & _
                    "       RESERVATION ON GUEST.GNo = RESERVATION.GNo INNER JOIN " & _
                    "       RESERVATION_DETAILS ON RESERVATION.ResNo = RESERVATION_DETAILS.ResNo " & _
                    "WHERE  (RESERVATION.ResStat = 'WAIT LIST' OR " & _
                    "       RESERVATION.ResStat = 'RESERVED') AND (RESERVATION_DETAILS.ResDStat = 'WAIT LIST' OR " & _
                    "       RESERVATION_DETAILS.ResDStat = 'RESERVED') AND (GUEST.GIID = '" & gGiid & "') "

                Using objReader As SqlDataReader = objCommand.ExecuteReader
                    If objReader.HasRows Then
                        Do While objReader.Read
                            If Not lvwRooms.FindItemWithText(objReader(0).ToString) Is Nothing Then
                                If lvwRooms.FindItemWithText(objReader(0).ToString).ImageKey = "Occupied" Then
                                    lvwRooms.FindItemWithText(objReader(0).ToString).ImageKey = "ResReg"
                                End If
                            Else
                                Dim lsvItem As ListViewItem = lvwRooms.Items.Add(objReader(0).ToString)
                                lsvItem.ImageKey = "Reserved"
                            End If
                        Loop
                    End If
                End Using

            End Using
            objConnection.Close()
        End Using

        lblCount.Text = lvwRooms.Items.Count.ToString

        If lvwRooms.Items.Count = 0 Then
            Msg("1007") 'There are no results
        End If

    End Sub

    Private Sub DisplayRooms()

        If chkViewAll.Checked Then

            Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
                objConnection.Open()
                Using objCommand As SqlCommand = New SqlCommand("SELECT RMNo FROM ROOM", objConnection)
                    Using objReader As SqlDataReader = objCommand.ExecuteReader
                        lvwRooms.Items.Clear()

                        Do While objReader.Read
                            Dim lsvItems As ListViewItem = lvwRooms.Items.Add(objReader(0).ToString)
                            lsvItems.ImageKey = "VACANT"
                        Loop

                    End Using
                End Using
                objConnection.Close()
            End Using

        Else 'not checked/view all rooms
            Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
                objConnection.Open()
                Using objCommand As SqlCommand = New SqlCommand
                    With objCommand
                        .Connection = objConnection

                        Dim strSQL As String = "SELECT RMSTATUS.RMNo " & _
                                         "FROM   RMSTATUS LEFT OUTER JOIN " & _
                                         "       ROOM ON RMSTATUS.RMNo = ROOM.RMNo " & _
                                         "WHERE "

                        If cboStatus.Text.ToUpper = "VACANT" Then
                            strSQL = "SELECT ROOM.RMNo AS 'Room Number' " & _
                                      "FROM  ROOM INNER JOIN RMRATE_DETAILS ON ROOM.RMNo = RMRATE_DETAILS.RMNo INNER JOIN RMRATE ON RMRATE_DETAILS.RMRID = RMRATE.RMRID " & _
                                      "WHERE (RMRATE_DETAILS.RMDActive = 'TRUE') AND ROOM.RMCurrStat<>'DIRTY' AND (ROOM.RMNo NOT IN " & _
                                      "       (SELECT RMNo FROM RMStatus WHERE( RMSStartTime BETWEEN '" & dtpDateFrom.Value.AddDays(-1).ToString & "' AND '" & dtpDateTo.Value.AddDays(1).ToString & "') OR ( RMSEndTime BETWEEN '" & dtpDateFrom.Value.AddDays(-1).ToString & "' AND '" & dtpDateTo.Value.AddDays(1).ToString & "' ) AND ((RMSName = 'REGISTERED' OR RMSName= 'RESERVED') AND (RMSStat IS NULL)) ) ) " 'Rooms with cancelled and checked out RMStatus.RMSStat"
                        Else
                            strSQL &= " (RMSTATUS.RMSName = '" & cboStatus.Text & "') AND (RMSTATUS.RMSStat IS NULL) "
                        End If

                        If Trim(cboRoomType.Text) <> String.Empty Then
                            strSQL &= " AND (ROOM.RMType = '" & TrimAll(cboRoomType.Text, True) & "') "
                        End If

                        If Trim(cboView.Text) <> String.Empty Then
                            strSQL &= " AND (ROOM.RMView = '" & TrimAll(cboView.Text, True) & "') "
                        End If

                        If Trim(txtOccupants.Text) <> String.Empty AndAlso IsNumeric(txtOccupants.Text) = True Then
                            strSQL &= " AND (ROOM.RMMaxGuest=" & TrimAll(txtOccupants.Text, True) & ") "
                        End If

                        If Trim(txtDescription.Text) <> String.Empty Then
                            strSQL &= " AND (ROOM.RMDesc LIKE '%" & TrimAll(txtDescription.Text, True) & "%') "
                        End If

                        If Trim(cboFeatures.Text) <> String.Empty Then
                            strSQL &= " AND Room.RMNO IN (SELECT RMFEATURE_DETAILS.RMNo FROM  RMFEATURE INNER JOIN  RMFEATURE_DETAILS ON RMFEATURE.RMFID = RMFEATURE_DETAILS.RMFID WHERE (RMFEATURE.RMFName = '" & TrimAll(cboFeatures.Text, True) & "')) "
                        End If

                        If cboStatus.Text.ToUpper <> "VACANT" Then
                            strSQL &= " AND ((RMSTATUS.RMSStartTime BETWEEN  '" & dtpDateFrom.Value.AddDays(-1).ToString & "' AND '" & dtpDateTo.Value.AddDays(1).ToString & "') OR (RMSTATUS.RMSEndTime BETWEEN '" & dtpDateFrom.Value.AddDays(-1).ToString & "' AND '" & dtpDateTo.Value.AddDays(1).ToString & "')) "
                        End If

                        strSQL &= " ORDER BY Room.RMNO ASC "

                        .CommandText = strSQL


                        Using objReader As SqlDataReader = .ExecuteReader
                            lvwRooms.Items.Clear()
                            Do While objReader.Read
                                Dim lsvItems As ListViewItem = lvwRooms.Items.Add(objReader(0).ToString)
                                lsvItems.ImageKey = "VACANT"
                            Loop
                        End Using

                    End With
                End Using
                objConnection.Close()
            End Using
        End If

        '---Determine Status---
        Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
            objConnection.Open()
            Using objCommand As SqlCommand = New SqlCommand("SELECT RMNo FROM RMStatus WHERE RMSStat IS NULL AND RMSName='REGISTERED'", objConnection)
                Using objReader As SqlDataReader = objCommand.ExecuteReader
                    Do While objReader.Read
                        If Not lvwRooms.FindItemWithText(objReader(0).ToString) Is Nothing Then
                            lvwRooms.FindItemWithText(objReader(0).ToString).ImageKey = "Occupied"
                        End If
                    Loop
                End Using
            End Using
            objConnection.Close()
        End Using

        Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
            objConnection.Open()
            Using objCommand As SqlCommand = New SqlCommand("SELECT RMNo FROM RMStatus WHERE RMSStat IS NULL AND RMSName='RESERVED' AND ( ( RMSStartTime BETWEEN '" & dtpDateFrom.Value.AddDays(-1).ToString & "' AND '" & dtpDateTo.Value.AddDays(1).ToString & "' ) OR ( RMSEndTime BETWEEN '" & dtpDateFrom.Value.AddDays(-1).ToString & "' AND '" & dtpDateTo.Value.AddDays(1).ToString & "' ) ) ", objConnection)
                Using objReader As SqlDataReader = objCommand.ExecuteReader
                    Do While objReader.Read
                        If Not lvwRooms.FindItemWithText(objReader(0).ToString) Is Nothing Then
                            If lvwRooms.FindItemWithText(objReader(0).ToString).ImageKey = "Occupied" Then
                                lvwRooms.FindItemWithText(objReader(0).ToString).ImageKey = "ResReg"
                            Else
                                lvwRooms.FindItemWithText(objReader(0).ToString).ImageKey = "Reserved"
                            End If
                        End If
                    Loop
                End Using
            End Using
            objConnection.Close()
        End Using

        lblCount.Text = lvwRooms.Items.Count.ToString
    End Sub

    Private Sub UpdateComboBoxes()
        ListItems(DatabasePath, "SELECT DISTINCT RMType FROM ROOM", cboRoomType, "RMType")
        cboRoomType.Text = String.Empty
        ListItems(DatabasePath, "SELECT RMFName FROM RMFeature", cboFeatures, "RMFName")
        cboFeatures.Text = String.Empty
        ListItems(DatabasePath, "SELECT DISTINCT RMView FROM ROOM", cboView, "RMView")
        cboView.Text = String.Empty
    End Sub

    Private Function DetermineReservationInfo() As Boolean

        If dgvReservationsApplied.SelectedRows.Count = 0 Then
            Msg("1046")
            tbcInformation.SelectedIndex = 1
            Return False
        Else

            Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
                objConnection.Open()
                Using objCommand As SqlCommand = New SqlCommand("SELECT ISNULL(GUEST.GIID,''), ISNULL(GUEST.CID,'') " & _
                                                                "FROM   RESERVATION INNER JOIN " & _
                                                                "       GUEST ON RESERVATION.GNo = GUEST.GNo " & _
                                                                "WHERE  (RESERVATION.ResNo = '" & dgvReservationsApplied.Item(0, dgvReservationsApplied.CurrentRow.Index).Value.ToString & "')", objConnection)
                    Using objReader As SqlDataReader = objCommand.ExecuteReader
                        objReader.Read()
                        SearchedGuestID() = objReader(0).ToString
                        SearchedReservationNo() = dgvReservationsApplied.Item(0, dgvReservationsApplied.CurrentRow.Index).Value.ToString
                        SearchedCompanyID() = objReader(1).ToString
                        SearchedRegistrationNo() = String.Empty
                    End Using
                End Using
                objConnection.Close()
            End Using

            Return True
        End If

    End Function

    Private Function DetermineRegistrationInfo() As Boolean

        If dgvRegistrations.RowCount = 0 Then
            Msg("1049")
            Return False
        Else
            Dim blnFound As Boolean = False
            Dim strRegNo As String = String.Empty

            For intCtr As Integer = 0 To dgvRegistrations.RowCount - 1
                If dgvRegistrations.Item(1, intCtr).Value.ToString.ToUpper = "REGISTERED" Then
                    blnFound = True
                    strRegNo = dgvRegistrations.Item(0, intCtr).Value.ToString.ToUpper
                    Exit For
                End If
            Next

            If blnFound Then
                Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
                    objConnection.Open()
                    Using objCommand As SqlCommand = New SqlCommand("SELECT GUEST.GIID, GUEST.CID " & _
                                                                    "FROM   REGISTRATION INNER JOIN " & _
                                                                    "       GUEST ON REGISTRATION.GNo = GUEST.GNo " & _
                                                                    "WHERE  (REGISTRATION.RegNo = '" & strRegNo & "') ", objConnection)
                        Using objReader As SqlDataReader = objCommand.ExecuteReader
                            objReader.Read()
                            SearchedGuestID() = objReader(0).ToString
                            SearchedCompanyID() = objReader(1).ToString
                            SearchedRegistrationNo() = strRegNo
                            SearchedReservationNo() = String.Empty
                        End Using
                    End Using
                    objConnection.Close()
                End Using

                Return True
            Else
                Msg("1049")
                Return False
            End If

        End If

    End Function

#End Region

#Region "Command Buttons"

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        DisplayRooms()
        If lvwRooms.Items.Count = 0 Then
            Msg("1007")
        Else
            If cboStatus.Text.ToUpper.Trim = "VACANT" Then
                tbcInformation.SelectedIndex = 0
            ElseIf cboStatus.Text.ToUpper.Trim = "RESERVED" Then
                tbcInformation.SelectedIndex = 1
            ElseIf cboStatus.Text.ToUpper.Trim = "REGISTERED" Then
                tbcInformation.SelectedIndex = 2
            End If
        End If
    End Sub

    Private Sub cmsPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsPayment.Click
        If Not DetermineReservationInfo() Then Exit Sub
        Display(Forms.frmPayment)
        frmPayment.FillMe()
    End Sub

    Private Sub cmsRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsRegister.Click
        If Not DetermineReservationInfo() Then Exit Sub
        Display(Forms.frmRegistration)
        frmRegistration.FillMe()
    End Sub

    Private Sub tsmFolio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmFolio.Click
        If Not DetermineRegistrationInfo() Then Exit Sub
        Display(Forms.frmGuestFolio)
        frmGuestFolio.FillMe()
    End Sub

    Private Sub tsmPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmPayment.Click
        If Not DetermineRegistrationInfo() Then Exit Sub
        Display(Forms.frmPayment)
        frmPayment.FillMe()
    End Sub

    Private Sub tsmDeparture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmDeparture.Click
        If Not DetermineRegistrationInfo() Then Exit Sub
        Display(Forms.frmDeparture)
        frmDeparture.FillMe()
    End Sub

    Private Sub tsmUpdateRegistration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmUpdateRegistration.Click
        If Not DetermineRegistrationInfo() Then Exit Sub
        Display(Forms.frmUpdateRegistration)
        frmUpdateRegistration.FillMe()
    End Sub

    Private Sub tsmReservation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmReservation.Click
        If lvwRooms.SelectedItems.Count = 0 Then Exit Sub
        Dim strRoom As String = lvwRooms.FocusedItem.Text
        Display(Forms.frmReservation)
        frmReservation.tbcReservation.SelectedIndex = 1
        ReserveFromRoomRack(strRoom, dtpDateFrom.Value.Date.ToString, dtpDateTo.Value.Date.ToString)
    End Sub

    Private Sub tsmRegistration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmRegistration.Click
        If lvwRooms.SelectedItems.Count = 0 Then Exit Sub
        Dim strRoom As String = lvwRooms.FocusedItem.Text
        Display(Forms.frmRegistration)
        frmRegistration.tbcRegistration.SelectedIndex = 1
        RegisterFromRoomRack(strRoom)
    End Sub

#End Region

#Region "MISC"

    Private Sub frmRoomRack_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        With imgSmallRoom.Images
            .Add("Reserved", My.Resources.Reserved)
            .Add("Occupied", My.Resources.Occupied)
            .Add("Dirty", My.Resources.Dirty)
            .Add("Vacant", My.Resources.Vacant)
            .Add("Construction", My.Resources.Construction)
            .Add("ResReg", My.Resources.RegisteredReserved)
        End With

        With imgLargeRooms.Images
            .Add("Reserved", My.Resources.Reserved)
            .Add("Occupied", My.Resources.Occupied)
            .Add("Dirty", My.Resources.Dirty)
            .Add("Vacant", My.Resources.Vacant)
            .Add("Construction", My.Resources.Construction)
            .Add("ResReg", My.Resources.RegisteredReserved)
        End With

        UpdateComboBoxes()

        cboStatus.Text = cboStatus.Items(0).ToString
        dtpDateFrom.Value = Date.Now
        dtpDateTo.Value = Date.Now

        dgvReservationsApplied.AlternatingRowsDefaultCellStyle = SetAlternatingColor()
        dgvRegistrations.AlternatingRowsDefaultCellStyle = SetAlternatingColor()

        Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
            objConnection.Open()
            Using objCommand As SqlCommand = New SqlCommand("SELECT COUNT(RMNO) FROM ROOM", objConnection)
                Using objReader As SqlDataReader = objCommand.ExecuteReader
                    objReader.Read()
                    lblTotalRooms.Text = objReader(0).ToString
                End Using
            End Using
            objConnection.Close()
        End Using

    End Sub

    Private Sub lvwRooms_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvwRooms.SelectedIndexChanged
        If lvwRooms.SelectedItems.Count > 0 Then

            'Determine Context menu
            Select Case lvwRooms.FocusedItem.ImageKey.ToUpper
                Case "RESERVED"
                    lvwRooms.ContextMenuStrip = Nothing
                Case "OCCUPIED", "RESREG"
                    lvwRooms.ContextMenuStrip = Me.cmsRegistration
                Case "VACANT"
                    lvwRooms.ContextMenuStrip = Me.cmsVacant
            End Select

            'Fill In Room Information
            'RmNo Floor view Type description telephone no occupants Amount features
            Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
                objConnection.Open()
                Using objCommand As SqlCommand = New SqlCommand("SELECT * FROM ROOM WHERE RMno='" & lvwRooms.FocusedItem.Text & "'", objConnection)
                    Using objReader As SqlDataReader = objCommand.ExecuteReader
                        objReader.Read()
                        lblRoomNo.Text = objReader("RMNo").ToString
                        lblFloor.Text = objReader("RMFloor").ToString
                        lblView.Text = objReader("RMView").ToString
                        lblRoomType.Text = objReader("RMType").ToString
                        lblDesc.Text = objReader("RMDesc").ToString
                        lblTelNo.Text = objReader("RMTelNo").ToString
                        lblOccupants.Text = objReader("RMMaxGuest").ToString
                        objReader.Close()
                    End Using

                    objCommand.CommandText = "SELECT RMRATE.RMRAmt FROM RMRATE INNER JOIN RMRATE_DETAILS ON RMRATE.RMRID = RMRATE_DETAILS.RMRID WHERE (RMRATE_DETAILS.RMDActive = 'TRUE') AND (RMRATE_DETAILS.RMNo = '" & lvwRooms.FocusedItem.Text & "')"
                    Using objReader As SqlDataReader = objCommand.ExecuteReader
                        objReader.Read()
                        lblAmount.Text = Format(CType(objReader(0), Double), "n")
                        objReader.Close()
                    End Using

                    objCommand.CommandText = "SELECT RMFEATURE.RMFName FROM RMFEATURE INNER JOIN RMFEATURE_DETAILS ON RMFEATURE.RMFID = RMFEATURE_DETAILS.RMFID WHERE (RMFEATURE.RMFStatus = 'TRUE') AND (RMFEATURE_DETAILS.RMNo = '" & lvwRooms.FocusedItem.Text & "')"
                    Using objReader As SqlDataReader = objCommand.ExecuteReader
                        lbxFeatures.Items.Clear()
                        Do While objReader.Read
                            lbxFeatures.Items.Add(objReader(0).ToString)
                        Loop
                        objReader.Close()
                    End Using

                End Using
                objConnection.Close()
            End Using

            'Fill in Reservation information
            ListItems(DatabasePath, _
                        "SELECT RESERVATION.ResNo AS [Reservation No], RESERVATION.ResStat AS Status, ROOM.RMNo AS [Room No], ISNULL(GUEST_INFO.GITitle, '') + ' ' + ISNULL(GUEST_INFO.GIFName, '') " & _
                        "       + ' ' + ISNULL(GUEST_INFO.GILName, '') AS Name, RESERVATION.ResAmt AS Amount, RESERVATION.ResBalance AS Balance,  " & _
                        "       RESERVATION.ResDate AS [Reservation Date], RESERVATION_DETAILS.ResDTimeIn AS [Expected Check In], RESERVATION_DETAILS.ResDTimeOut AS [Expected Check out],  " & _
                        "       RESERVATION.ResGuestType AS [Guest Type], RESERVATION.ResNoOccupants AS Occupants,  " & _
                        "       RESERVATION.ResRemarks AS Remarks " & _
                        "FROM   RESERVATION INNER JOIN " & _
                        "       RESERVATION_DETAILS ON RESERVATION.ResNo = RESERVATION_DETAILS.ResNo INNER JOIN " & _
                        "       GUEST ON RESERVATION.GNo = GUEST.GNo INNER JOIN " & _
                        "       GUEST_INFO ON GUEST.GIID = GUEST_INFO.GIID INNER JOIN " & _
                        "       ROOM ON RESERVATION_DETAILS.RMNo = ROOM.RMNo " & _
                        "WHERE  (ROOM.RMNo = '" & lvwRooms.FocusedItem.Text & "') AND RESERVATION.ResStat <>'CANCELLED' AND RESERVATION.ResStat<>'REGISTERED' ORDER BY RESERVATION.ResDate DESC ", _
                        dgvReservationsApplied)

            'fill in registration information
            ListItems(DatabasePath, _
                        "SELECT REGISTRATION.RegNo AS [Registration No], REGISTRATION_DETAILS.RegDStat AS Status, REGISTRATION_DETAILS.RMNo AS ROOM, ISNULL(GUEST_INFO.GITitle, '') + ' ' + ISNULL(GUEST_INFO.GIFName, '')  " & _
                        "       + ' ' + ISNULL(GUEST_INFO.GILName, '') AS NAME, REGISTRATION.RegGuestType AS [Guest Type],  " & _
                        "       REGISTRATION.RegAmt AS Amount, REGISTRATION.RegBalance AS Balance, REGISTRATION.RegDate AS [Registration Date], REGISTRATION_DETAILS.RegDChkInTime AS [Check In Date],  " & _
                        "       REGISTRATION_DETAILS.RegDChkOutTime AS [Check Out Date], REGISTRATION_DETAILS.RegDNoOfExtDays AS [Extension In Days], DATEDIFF(day,  " & _
                        "       REGISTRATION_DETAILS.RegDChkInTime, { fn NOW() }) AS [Days Stayed In Hotel], REGISTRATION.RegRemarks AS Remarks " & _
                        "FROM   REGISTRATION INNER JOIN " & _
                        "       REGISTRATION_DETAILS ON REGISTRATION.RegNo = REGISTRATION_DETAILS.RegNo INNER JOIN " & _
                        "       GUEST ON REGISTRATION.GNo = GUEST.GNo INNER JOIN " & _
                        "       GUEST_INFO ON GUEST.GIID = GUEST_INFO.GIID " & _
                        "WHERE  (REGISTRATION_DETAILS.RMNo = '" & lvwRooms.FocusedItem.Text & "') AND REGISTRATION_DETAILS.RegDStat <> 'CHECKED OUT' ORDER BY REGISTRATION.RegDate DESC ", _
                        dgvRegistrations)

        End If
    End Sub

    Private Sub dgvReservationsApplied_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvReservationsApplied.SelectionChanged

        If dgvReservationsApplied.SelectedRows.Count = 0 Then Exit Sub

        If dgvReservationsApplied.Item(1, dgvReservationsApplied.CurrentRow.Index).Value.ToString.ToUpper = "REGISTERED" Or _
            dgvReservationsApplied.Item(1, dgvReservationsApplied.CurrentRow.Index).Value.ToString.ToUpper = "CANCELLED" Then
            dgvReservationsApplied.ContextMenuStrip = Nothing
        Else
            dgvReservationsApplied.ContextMenuStrip = Me.cmsReservation
        End If

    End Sub

    Private Sub dgvRegistrations_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvRegistrations.SelectionChanged

        If dgvRegistrations.SelectedRows.Count = 0 Then Exit Sub

        If dgvRegistrations.Item(1, dgvRegistrations.CurrentRow.Index).Value.ToString.ToUpper = "CHECKED OUT" Then
            dgvRegistrations.ContextMenuStrip = Nothing
        ElseIf dgvRegistrations.Item(1, dgvRegistrations.CurrentRow.Index).Value.ToString.ToUpper = "REGISTERED" Then
            dgvRegistrations.ContextMenuStrip = Me.cmsRegistration
        End If

    End Sub

    Private Sub chkViewAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkViewAll.CheckedChanged

        cboRoomType.Enabled = Not chkViewAll.Checked
        cboFeatures.Enabled = Not chkViewAll.Checked
        txtDescription.Enabled = Not chkViewAll.Checked
        cboStatus.Enabled = Not chkViewAll.Checked
        cboView.Enabled = Not chkViewAll.Checked
        txtOccupants.Enabled = Not chkViewAll.Checked
        'dtpDateFrom.Enabled = Not chkViewAll.Checked
        'dtpDateTo.Enabled = Not chkViewAll.Checked

        DisplayRooms()

    End Sub

    Private Sub lblClose_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblClose.LinkClicked
        Me.Close()
    End Sub

    Private Sub dtpDateFrom_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDateFrom.ValueChanged
        DisplayRooms()
    End Sub

    Private Sub dtpDateTo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDateTo.ValueChanged
        DisplayRooms()
    End Sub

    Private Sub lvwRooms_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvwRooms.MouseClick
        If lvwRooms.SelectedItems.Count > 0 Then
            If e.Button = Windows.Forms.MouseButtons.Right Then
                If lvwRooms.FocusedItem.ImageKey.ToUpper = "RESERVED" Then
                    tbcInformation.SelectedIndex = 1
                ElseIf lvwRooms.FocusedItem.ImageKey.ToUpper = "OCCUPIED" Or lvwRooms.FocusedItem.ImageKey.ToUpper = "RESREG" Then
                    tbcInformation.SelectedIndex = 2
                ElseIf lvwRooms.FocusedItem.ImageKey.ToUpper = "VACANT" Then
                    tbcInformation.SelectedIndex = 0
                End If
            End If
        End If
    End Sub

    Private Sub chkLarge_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLarge.CheckedChanged
        If chkLarge.Checked Then
            lvwRooms.View = View.LargeIcon
        Else
            lvwRooms.View = View.SmallIcon
        End If
    End Sub

#End Region

#Region "SIDE BAR"

    Private Sub tsbRoomMaintenance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbRoomMaintenance.Click
        Display(Forms.frmRoomMaintenance)
    End Sub

    Private Sub tsbGuestSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuestSearch.Click
        TriggeredBy = TriggeringForm.RoomRack
        frmGuestSearch.ShowDialog()
    End Sub

#End Region

   
End Class