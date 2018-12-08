Option Explicit On
Option Strict On

Imports System.Data
Imports System.Data.SqlClient

' Programmer:   Jo Jefferson D. Peralta
' Date:         April 03, 2007
' Title:        frmUpdateRoomCharge
' Purpose:      This interface is used to add room charges that is usually done on a daily basis.
'               The FDO can charge a room rate base on what is in the guest registration or use the current
'               room rate since it is possible that it will change during the guest's stay at the hotel.
' Requirements: ->  (+)FOLIO_DETAILS(FDNo, FDReceiptNo, FDDate, FDCharge, FDName, FDModifiedByAmt, 
'                                   FDModifiedByPercent, FDModifiedCharge, FDBalance, FDStat, FDDesc, RegNo, RegDNo)
'                   (*)REGISTRATION(RegAmt, RegBalance)
'                   (*)REGISTRATION_DETAILS(RegDLastUpdate, RegDDaysUpdated)
'               ->  The user can choose to apply the charges specified in registration or the current room rates.
'                   This decision happens when special and seasonal charges are in effect.
'               ->  The number of days stayed in the hotel and the days updated (charges) are shown in the interface  
'                   to easily determine the un-updated rooms.
'               ->  It is also possible to determine the last update made. The form displays the rooms that 
'                   are not yet updated on a given date.
'               ->  Depending on the rooms availability and the managers approval, the guest's rooms can be charged
'                   even it excedes the supposed check out date. However to make the extension formal the FDO/manager
'                   will have to edit the registration. This is to ensure that the rooms are still available on the 
'                   dates of extension.
' Results:      ->  The room charges are added to the bills of a guest.
'               ->  Registration amount and balances are also updated.
'msgbox

Public Class frmUpdateRoomCharge

#Region "Functions/SubRoutines"

    Private Sub DisplayRegisteredRooms()

        Using objConnection As SqlConnection = SetUpConnection(DatabasePath(), True)
            objConnection.Open()
            Using objCommand As SqlCommand = New SqlCommand( _
                                                "SELECT REGISTRATION_DETAILS.RMNo AS [Room No], ISNULL(GUEST_INFO.GIFName, '') + ' ' + ISNULL(GUEST_INFO.GILName, '') AS [Guest name],  " & _
                                                "       REGISTRATION_DETAILS.RegDDaysUpdated AS [Charged Days], DATEDIFF(day, REGISTRATION_DETAILS.RegDChkInTime, { fn NOW() })  " & _
                                                "       AS [Stayed In Hotel], REGISTRATION_DETAILS.RegDNo AS [Accommodation No.] " & _
                                                "FROM   REGISTRATION_DETAILS INNER JOIN " & _
                                                "       REGISTRATION ON REGISTRATION_DETAILS.RegNo = REGISTRATION.RegNo INNER JOIN " & _
                                                "       GUEST ON REGISTRATION.GNo = GUEST.GNo INNER JOIN " & _
                                                "       GUEST_INFO ON GUEST.GIID = GUEST_INFO.GIID " & _
                                                "WHERE  (REGISTRATION_DETAILS.RegDStat = 'REGISTERED') " & IIf(chkDisplayAll.Checked, "", _
                                                "       AND (REGISTRATION_DETAILS.RegDLastUpdate BETWEEN CONVERT(DATETIME, '" & dtpLastUpdate.Value.AddDays(-1).ToString & "', 102) AND { fn NOW() }) ").ToString & _
                                                "ORDER BY REGISTRATION_DETAILS.RMNo ", _
                                                objConnection)
                Using objReader As SqlDataReader = objCommand.ExecuteReader
                    lsvRegisteredRooms.Items.Clear()
                    Do While objReader.Read

                        Dim blnFound As Boolean = False
                        For Each ctlItem As ListViewItem In lvwRoomsToUpdate.Items
                            If ctlItem.Text.ToUpper = objReader(0).ToString.ToUpper Then
                                blnFound = True
                                Exit For
                            End If
                        Next

                        If Not blnFound Then
                            Dim lsvItem As ListViewItem = lsvRegisteredRooms.Items.Add(objReader(0).ToString)
                            lsvItem.SubItems.Add(objReader(1).ToString)
                            lsvItem.SubItems.Add(objReader(2).ToString)
                            lsvItem.SubItems.Add(objReader(3).ToString)
                            lsvItem.SubItems.Add(objReader(4).ToString)
                            lsvItem.ImageKey = "Occupied"
                        End If
                    Loop
                    lblCountRegisteredRoom.Text = lsvRegisteredRooms.Items.Count.ToString
                End Using
            End Using
            objConnection.Close()
        End Using

    End Sub

    Public Sub FillMe()

        lsvRegisteredRooms.Items.Clear()

        If RegistrationIsNotSet Then
            Msg("1045")
            Exit Sub
        End If

        Using objConnection As SqlConnection = SetUpConnection(DatabasePath(), True)
            objConnection.Open()
            Using objCommand As SqlCommand = New SqlCommand( _
                                                "SELECT REGISTRATION_DETAILS.RMNo AS [Room No], ISNULL(GUEST_INFO.GIFName, '') + ' ' + ISNULL(GUEST_INFO.GILName, '') AS [Guest name],  " & _
                                                "       REGISTRATION_DETAILS.RegDDaysUpdated AS [Charged Days], DATEDIFF(day, REGISTRATION_DETAILS.RegDChkInTime, { fn NOW() })  " & _
                                                "       AS [Stayed In Hotel], REGISTRATION_DETAILS.RegDNo AS [Accommodation No.] " & _
                                                "FROM   REGISTRATION_DETAILS INNER JOIN " & _
                                                "       REGISTRATION ON REGISTRATION_DETAILS.RegNo = REGISTRATION.RegNo INNER JOIN " & _
                                                "       GUEST ON REGISTRATION.GNo = GUEST.GNo INNER JOIN " & _
                                                "       GUEST_INFO ON GUEST.GIID = GUEST_INFO.GIID " & _
                                                "WHERE  (REGISTRATION_DETAILS.RegDStat = 'REGISTERED') " & IIf(chkDisplayAll.Checked, "", _
                                                "       AND (REGISTRATION_DETAILS.RegDLastUpdate BETWEEN CONVERT(DATETIME, '" & dtpLastUpdate.Value.AddDays(-1).ToString & "', 102) AND { fn NOW() }) ").ToString & _
                                                "       AND REGISTRATION.RegNo ='" & SearchedRegistrationNo & "' " & _
                                                "ORDER BY REGISTRATION_DETAILS.RMNo ", _
                                                objConnection)

                Using objReader As SqlDataReader = objCommand.ExecuteReader
                    lsvRegisteredRooms.Items.Clear()
                    Do While objReader.Read

                        Dim blnFound As Boolean = False
                        For Each ctlItem As ListViewItem In lvwRoomsToUpdate.Items
                            If ctlItem.Text.ToUpper = objReader(0).ToString.ToUpper Then
                                blnFound = True
                                Exit For
                            End If
                        Next

                        If Not blnFound Then
                            Dim lsvItem As ListViewItem = lsvRegisteredRooms.Items.Add(objReader(0).ToString)
                            lsvItem.SubItems.Add(objReader(1).ToString)
                            lsvItem.SubItems.Add(objReader(2).ToString)
                            lsvItem.SubItems.Add(objReader(3).ToString)
                            lsvItem.SubItems.Add(objReader(4).ToString)
                            lsvItem.ImageKey = "Occupied"
                        End If
                    Loop
                    lblCountRegisteredRoom.Text = lsvRegisteredRooms.Items.Count.ToString
                End Using
            End Using
            objConnection.Close()
        End Using

    End Sub

#End Region

#Region "Command Buttons"

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        If lsvRegisteredRooms.SelectedItems.Count > 0 Then

            If txtNoOfDays.Value = 0 Then
                Msg("1095")
                txtNoOfDays.Select(0, 3)
                txtNoOfDays.Focus()
                Exit Sub
            End If

            Try
                Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
                    objConnection.Open()

                    For Each lsvSelectedItem As ListViewItem In lsvRegisteredRooms.SelectedItems

                        Using objCommand As SqlCommand = New SqlCommand("SELECT ROOM.RMNo AS [Room No], ISNULL(GUEST_INFO.GITitle, '') + ' ' + ISNULL(GUEST_INFO.GIFName, '') + ' ' + ISNULL(GUEST_INFO.GILName, '') AS Name,  " & _
                                                                        "       ROOM.RMType AS [Room Type], REGISTRATION_DETAILS.RegDRMAmt AS [Registration Amount],  " & _
                                                                        "       RMRATE.RMRAmt AS [Current Room Amount], REGISTRATION.RegDate AS [Registration Date],  " & _
                                                                        "       REGISTRATION_DETAILS.RegDNoOfExtDays AS [No of Extended days], REGISTRATION_DETAILS.RegDChkOutTime AS [Expected Check out],  " & _
                                                                        "       DATEDIFF(day, REGISTRATION_DETAILS.RegDChkInTime, { fn NOW() }) AS [Days Stayed],  " & _
                                                                        "       REGISTRATION_DETAILS.RegDDaysUpdated AS [Days That was already charged], REGISTRATION.RegNo AS [Registration No],  " & _
                                                                        "       REGISTRATION_DETAILS.RegDNo AS [Accommodation No] " & _
                                                                        "FROM   ROOM INNER JOIN " & _
                                                                        "       REGISTRATION_DETAILS ON ROOM.RMNo = REGISTRATION_DETAILS.RMNo INNER JOIN " & _
                                                                        "       REGISTRATION ON REGISTRATION_DETAILS.RegNo = REGISTRATION.RegNo INNER JOIN " & _
                                                                        "       GUEST ON REGISTRATION.GNo = GUEST.GNo INNER JOIN " & _
                                                                        "       GUEST_INFO ON GUEST.GIID = GUEST_INFO.GIID INNER JOIN " & _
                                                                        "       RMRATE_DETAILS ON ROOM.RMNo = RMRATE_DETAILS.RMNo INNER JOIN " & _
                                                                        "       RMRATE ON RMRATE_DETAILS.RMRID = RMRATE.RMRID " & _
                                                                        "WHERE  (RMRATE_DETAILS.RMDActive = 'TRUE') AND (ROOM.RMNo = '" & lsvSelectedItem.Text & "') AND (REGISTRATION_DETAILS.RegDStat = 'REGISTERED')", objConnection)

                            Using objReader As SqlDataReader = objCommand.ExecuteReader
                                objReader.Read()
                                Dim lsvItem As ListViewItem = lvwRoomsToUpdate.Items.Add(objReader(0).ToString)
                                lsvItem.SubItems.Add(objReader(1).ToString)
                                lsvItem.SubItems.Add(IIf(raduseRegistrationRoomRate.Checked, objReader(3).ToString, objReader(4).ToString).ToString)
                                lsvItem.SubItems.Add(txtNoOfDays.Value.ToString)
                                lsvItem.SubItems.Add(objReader(2).ToString)
                                lsvItem.SubItems.Add(objReader(3).ToString)
                                lsvItem.SubItems.Add(objReader(4).ToString)
                                lsvItem.SubItems.Add(objReader(5).ToString)
                                lsvItem.SubItems.Add(objReader(6).ToString)
                                lsvItem.SubItems.Add(objReader(7).ToString)
                                lsvItem.SubItems.Add(objReader(8).ToString)
                                lsvItem.SubItems.Add(objReader(9).ToString)
                                lsvItem.SubItems.Add(objReader(10).ToString)
                                lsvItem.SubItems.Add(objReader(11).ToString)

                                lblCountToUpdate.Text = lvwRoomsToUpdate.Items.Count.ToString

                                lsvRegisteredRooms.FocusedItem.Remove()
                                If lsvRegisteredRooms.Items.Count <> 0 Then lsvRegisteredRooms.Items(0).Selected = True

                            End Using
                        End Using
                    Next
                    objConnection.Close()
                End Using

            Catch ex As Exception
                Msg("2000")
                frmParent.tssStatus.Text = "Cannot update rooms with no rates."
            End Try
        Else
            Msg("1005")
        End If
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click

        chkDetails.Checked = True
        If lvwRoomsToUpdate.SelectedItems.Count > 0 Then
            For Each ctlListView As ListViewItem In lvwRoomsToUpdate.SelectedItems
                ctlListView.Remove()
                If lvwRoomsToUpdate.Items.Count <> 0 Then lvwRoomsToUpdate.Items(0).Selected = True
            Next
            lblCountToUpdate.Text = lvwRoomsToUpdate.Items.Count.ToString
        Else
            Msg("1005")
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If lvwRoomsToUpdate.Items.Count > 0 Then
            Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
                objConnection.Open()
                Using objTransaction As SqlTransaction = objConnection.BeginTransaction
                    Using objCommand As SqlCommand = objConnection.CreateCommand
                        With objCommand
                            .Transaction = objTransaction

                            Try
                                For Each ctlListViewItem As ListViewItem In lvwRoomsToUpdate.Items

                                    For intCtr As Integer = 1 To CType(ctlListViewItem.SubItems(3).Text, Integer) Step 1

                                        .CommandText = "INSERT INTO FOLIO_DETAILS (FDNo, FDReceiptNo, FDDate, FDCharge, FDName, FDModifiedByAmt, FDModifiedByPercent, FDModifiedCharge, FDBalance, FDStat, FDDesc, RegNo, RegDNo) " & _
                                                       "VALUES (@FDNo, @FDReceiptNo, @FDDate, @FDCharge, @FDName, 0, 0, @FDModifiedCharge, @FDBalance, @FDStat, @FDDesc, @RegNo, @RegDNo)"

                                        With .Parameters
                                            Dim strPrimaryKeyNo As String = GetPrimaryKeyNo("FDNo")
                                            IncrementPrimaryKeyNo("FDNo")
                                            .Clear()
                                            .AddWithValue("@FDNo", strPrimaryKeyNo)
                                            .AddWithValue("@FDReceiptNo", strPrimaryKeyNo)
                                            .AddWithValue("@FDDate", dtpDateOfUpdate.Value).SqlDbType = SqlDbType.DateTime
                                            .AddWithValue("@FDCharge", ctlListViewItem.SubItems(2).Text).SqlDbType = SqlDbType.Money
                                            .AddWithValue("@FDName", "ROOM CHARGES")
                                            .AddWithValue("@FDModifiedCharge", ctlListViewItem.SubItems(2).Text).SqlDbType = SqlDbType.Money
                                            .AddWithValue("@FDBalance", ctlListViewItem.SubItems(2).Text).SqlDbType = SqlDbType.Money
                                            .AddWithValue("@FDStat", "UNPAID")
                                            .AddWithValue("@FDDesc", "ROOM")
                                            .AddWithValue("@RegNo", ctlListViewItem.SubItems(12).Text)
                                            .AddWithValue("@RegDNo", ctlListViewItem.SubItems(13).Text)
                                        End With
                                        .ExecuteNonQuery()

                                        .CommandText = "UPDATE REGISTRATION SET RegBalance=RegBalance + @RegBalance, RegAmt=RegAmt + @RegAmt WHERE RegNo= @RegNo"
                                        With .Parameters
                                            .Clear()
                                            .AddWithValue("@RegBalance", ctlListViewItem.SubItems(2).Text).SqlDbType = SqlDbType.Money
                                            .AddWithValue("@RegAmt", ctlListViewItem.SubItems(2).Text).SqlDbType = SqlDbType.Money
                                            .AddWithValue("@RegNo", ctlListViewItem.SubItems(12).Text)

                                        End With
                                        .ExecuteNonQuery()

                                    Next

                                    .CommandText = "UPDATE REGISTRATION_DETAILS SET RegDLastUpdate=@RegDLastUpdate, RegDDaysUpdated=RegDDaysUpdated + @RegDDaysUpdated WHERE RegDNo=@RegDNo"
                                    With .Parameters
                                        .Clear()
                                        .AddWithValue("@RegDLastUpdate", dtpDateOfUpdate.Value).SqlDbType = SqlDbType.DateTime
                                        .AddWithValue("@RegDDaysUpdated", ctlListViewItem.SubItems(3).Text).SqlDbType = SqlDbType.Int
                                        .AddWithValue("@RegDNo", ctlListViewItem.SubItems(13).Text)
                                    End With
                                    .ExecuteNonQuery()

                                Next

                                objTransaction.Commit()

                                lvwRoomsToUpdate.Items.Clear()
                                DisplayRegisteredRooms()
                                frmParent.tssStatus.Text = "Changes have been successfully saved..."

                            Catch ex As Exception

                                objTransaction.Rollback()
                                Msg("1008", , NWLN & ex.Message)

                            End Try

                        End With
                    End Using
                End Using
                objConnection.Close()
            End Using
        Else
            Msg("1005")
        End If
    End Sub

#End Region

#Region "MISC"

    Private Sub frmUpdateRoomCharge_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ImageList1.Images.Add("Occupied", My.Resources.Occupied)
        DisplayRegisteredRooms()
        'ListItems(DatabasePath, "SELECT DISTINCT RMType FROM ROOM", cboRoomtType, "RMType")
        'cboRoomtType.Text = String.Empty
    End Sub

    Private Sub chkDisplayAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDisplayAll.CheckedChanged
        'cboRoomtType.Enabled = Not chkDisplayAll.Checked
        dtpLastUpdate.Enabled = Not chkDisplayAll.Checked
        DisplayRegisteredRooms()
    End Sub

    'Private Sub cboRoomtType_TextChange(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    DisplayRegisteredRooms()
    'End Sub

    Private Sub dtpLastUpdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpLastUpdate.ValueChanged
        DisplayRegisteredRooms()
    End Sub

    Private Sub lsvRegisteredRooms_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsvRegisteredRooms.DoubleClick
        btnSelect_Click(Nothing, Nothing)
    End Sub

    Private Sub chkDetails_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDetails.CheckedChanged

        If chkDetails.Checked = True Then
            lsvRegisteredRooms.View = View.Details
        Else
            lsvRegisteredRooms.View = View.LargeIcon
        End If
        DisplayRegisteredRooms()
    End Sub

    Private Sub lsvRegisteredRooms_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsvRegisteredRooms.SelectedIndexChanged

        If lsvRegisteredRooms.SelectedItems.Count = 0 Then Exit Sub

        Try
            Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
                objConnection.Open()
                Using objCommand As SqlCommand = New SqlCommand
                    objCommand.Connection = objConnection
                    objCommand.CommandText = "SELECT RegDRMAmt FROM REGISTRATION_DETAILS WHERE RMNo='" & lsvRegisteredRooms.FocusedItem.Text & "' AND RegDStat='REGISTERED'"
                    lblRegAmt.Text = Format(CType(objCommand.ExecuteScalar, Double), "n")

                    objCommand.CommandText = "SELECT RMRATE.RMRAmt " & _
                                             "FROM   ROOM INNER JOIN " & _
                                             "       RMRATE_DETAILS ON ROOM.RMNo = RMRATE_DETAILS.RMNo INNER JOIN " & _
                                             "       RMRATE ON RMRATE_DETAILS.RMRID = RMRATE.RMRID " & _
                                             "WHERE  (RMRATE_DETAILS.RMDActive = 'TRUE') AND (ROOM.RMNo = '" & lsvRegisteredRooms.FocusedItem.Text & "') "
                    lblCurAmt.Text = Format(CType(objCommand.ExecuteScalar, Double), "n")

                End Using
                objConnection.Close()
            End Using
        Catch ex As Exception
            lblRegAmt.Text = "0"
            lblCurAmt.Text = "0"
            MsgBox(ex.Message)
        End Try

        Dim strRoom As String
        Try
            strRoom = lsvRegisteredRooms.FocusedItem.Text
        Catch ex As Exception
            Exit Sub
        End Try

        'Dim intAlreadyUpdated As Integer = 0
        'For Each ctlItem As ListViewItem In lvwRoomsToUpdate.Items
        '    If ctlItem.Text.ToUpper = strRoom.ToUpper Then
        '        intAlreadyUpdated += CType(ctlItem.SubItems(3).Text, Integer)
        '    End If
        'Next

        If lsvRegisteredRooms.SelectedItems.Count <> 0 Then
            If CType(lsvRegisteredRooms.FocusedItem.SubItems(3).Text, Integer) - CType(lsvRegisteredRooms.FocusedItem.SubItems(2).Text, Integer) <= 0 Then
                txtNoOfDays.Value = 1
            Else
                txtNoOfDays.Value = CType(lsvRegisteredRooms.FocusedItem.SubItems(3).Text, Integer) - CType(lsvRegisteredRooms.FocusedItem.SubItems(2).Text, Integer)
            End If
        End If


    End Sub

    Private Sub lblClose_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblClose.LinkClicked
        Me.Close()
    End Sub


#End Region

#Region "Side Bar"

    Private Sub tsbActGuestFolio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbActGuestFolio.Click
        Display(Forms.frmGuestFolio)
    End Sub

    Private Sub tsbActGuestInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbActGuestInfo.Click
        Display(Forms.frmGuestInformation)
    End Sub

    Private Sub tsbActPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbActPayment.Click
        Display(Forms.frmPayment)
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Display(Forms.frmRoomRack)
    End Sub

    Private Sub tsbActGuestSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbActGuestSearch.Click
        TriggeredBy = TriggeringForm.UpdateRoomCharges
        frmGuestSearch.ShowDialog()
    End Sub

#End Region

End Class