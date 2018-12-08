Option Explicit On
Option Strict On

Imports System.Data
Imports System.Data.SqlClient

' Programmer:   Mark Andrew O. Rivera
'               Howell Quindara
' Title:        frmRoomTransfer
' Purpose:      This interface is used to check for available rooms that can be registered for that day.
'               It also displays the registered and checked out rooms of the guest's stay.
'               The FDO with this information can then select an available room. Then set the room information on
'               which room the guest will transfer from and how many occupants staying. In cases that there are power
'               interruption or any reason that hinders the use of this system but there are guests that 
'               would like to transfer rooms, the FDO change the date of transfer with the manager's approval.
' Requirements: ->  (+)REGISTRATION_DETAILS (RegDNo, RegDChkInTime, RegDChkOutTime, RegDStat, RegDNoGuest, RegDRemarks, RMNo, RegNo, RegDRMAmt)
'               ->  (+)ACTIVITY_LOG (ALID, ALResOrReg, ALNature, ALOldVal, ALNewVal, ALTimeChanged, GNo, EID, RegDNo, RegNo)
'               ->  (+)RMSTATUS (RMSID, RMSName, RMSStartTime, RMSEndTime, RMNo)
'               ->  (*)REGISTRATION_DETAILS(RegDStat, RegDChkOutTime, RegDRemarks)
'               ->  (*)ROOM(RMCurrStat)
'               ->  (*)RMSTATUS(RMSEndTime, RMSStat)
'               ->  (+)FOLIO_DETAILS()
'               ->  (*)REGISTRATION(RegAmt, RegBalance)
'               ->  Registration must be active or not fully checked out
' Results:      ->  New room is added to the registration of the guest
'               ->  Registered room that is transfered from is checked out
'               ->  Activity Logs are added to record the room transfer and
'                   early room checkout or late room checkout.
' Messagebox done

Public Class frmRoomTransfer
    Private objRoomDataView As New DataView
    Private objDataGridViewRow As DataGridViewRow
    Private objTransferRoom As DataGridViewRow
    Private gRegno As String = String.Empty
    Private gState As State = State.waiting
    Private MyTag As Integer = 0

#Region "MISC"

    Public Sub FillMe()

        If gState <> State.waiting Then
            Select Case Msg("1033", Button.YesNoCancel)
                Case ButtonClicked.Yes
                    btnSave_Click(Nothing, Nothing)
                Case ButtonClicked.No
                Case ButtonClicked.Cancel
                    Exit Sub
            End Select
        End If

        If SearchedRegistrationNo = String.Empty Then
            Msg("1045", Button.Ok)
        Else
            'Check if the Registration is Registered and is not CheckedOut
            If IsExisting("SELECT REGNO FROM REGISTRATION WHERE REGNO='" & SearchedRegistrationNo & "' AND RegStat='REGISTERED'") Then
                gRegno = SearchedRegistrationNo
                Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
                    objConnection.Open()

                    Using objCommand As SqlCommand = New SqlCommand("SELECT ISNULL(GUEST_INFO.GITitle, '') + ' ' + ISNULL(GUEST_INFO.GIFName, '') + ' ' + ISNULL(GUEST_INFO.GILName, '') AS [Guest Name] " & _
                                                                    "FROM   REGISTRATION INNER JOIN " & _
                                                                    "       GUEST ON REGISTRATION.GNo = GUEST.GNo INNER JOIN " & _
                                                                    "       GUEST_INFO ON GUEST.GIID = GUEST_INFO.GIID " & _
                                                                    "WHERE  (REGISTRATION.RegNo = '" & gRegno & "')", objConnection)
                        Using objReader As SqlDataReader = objCommand.ExecuteReader
                            objReader.Read()
                            lblGuestName.Text = objReader(0).ToString
                            objReader.Close()
                        End Using
                    End Using
                    objConnection.Close()
                End Using
                dtpCheckInDate.Enabled = False
                dtpCheckInDate.MaxDate = DateAdd(DateInterval.Hour, 1, Date.Now)
                dtpCheckInDate.Value = Date.Now
                dtpCheckInTime.Enabled = False
                dtpCheckInTime.Value = Date.Now
                ShowRooms()
                lblTotalCharges.Text = Format(TotalCharges(gRegno, Transaction.Registration), "n")
                lblTotalPayments.Text = Format(TotalPayments(gRegno, Transaction.Registration), "n")
                lblTotalBalance.Text = Format(CType(lblTotalCharges.Text, Double) - CType(lblTotalPayments.Text, Double), "n")
            Else
                Msg("1050") 'registered only
            End If
        End If
    End Sub

    Private Sub frmRoomTransfer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim strConnectionString As String = "Data Source = .\SQLExpress; AttachDBFileName = " & DatabasePath & "; Integrated Security = True; User Instance = TRUE"
        Dim objAdapter As SqlDataAdapter
        Dim objDataSet As DataSet
        Dim objDataTable As DataTable
        Dim objDataRow As DataRow

        dtpCheckInDate.Value = Now
        dtpCheckInTime.Value = Now
        Using objDatabaseConnection As New SqlConnection(strConnectionString)
            Try
                objAdapter = New SqlDataAdapter("SELECT DISTINCT RMTYPE FROM ROOM", objDatabaseConnection)
                objDataSet = SetUpDataSet(objAdapter, "qryDistinctRMTYPE")
                objDataTable = objDataSet.Tables("qryDistinctRMTYPE")

                For Each objDataRow In objDataTable.Rows
                    cboRoomType.Items.Add(objDataRow(0))
                Next

            Catch ex As Exception
                Msg("1017", , "An error occured while loading the room type list")
            End Try

            Try
                objAdapter = New SqlDataAdapter("SELECT DISTINCT RMFLOOR FROM ROOM", objDatabaseConnection)
                objDataSet = SetUpDataSet(objAdapter, "qryDistinctRMFLOOR")
                objDataTable = objDataSet.Tables("qryDistinctRMFLOOR")

                For Each objDataRow In objDataTable.Rows
                    cboFloor.Items.Add(objDataRow(0))
                Next

            Catch ex As Exception
                Msg("1017", , "An error occured while loading the room floor list")
            End Try

            Try
                objAdapter = New SqlDataAdapter("SELECT DISTINCT RMVIEW FROM ROOM", objDatabaseConnection)
                objDataSet = SetUpDataSet(objAdapter, "qryDistinctRMVIEW")
                objDataTable = objDataSet.Tables("qryDistinctRMVIEW")

                For Each objDataRow In objDataTable.Rows
                    cboView.Items.Add(objDataRow(0))
                Next

            Catch ex As Exception
                Msg("1017", , "An error occured while loading the room view list")
            End Try
        End Using
        btnRoomVacancySearch.PerformClick()
    End Sub

    Private Sub ShowRooms()
        If gRegno <> String.Empty Then

            ListItems(DatabasePath, "SELECT     REGISTRATION_DETAILS.RegDNo AS [Accommodation No], ROOM.RMNo AS [Room No], ROOM.RMType AS [Room Type], " & _
                                           "    REGISTRATION_DETAILS.RegDChkInTime AS [Check In Time], REGISTRATION_DETAILS.RegDNoGuest AS [No of Occupants], DATEDIFF(day,  " & _
                                           "    REGISTRATION_DETAILS.RegDChkInTime, '" & dtpCheckOutDate.Value.ToString & "') AS [Days Stayed In Hotel],  " & _
                                           "    REGISTRATION_DETAILS.RegDNoOfExtDays AS [Extension in Days], DATEADD(DAY, REGISTRATION_DETAILS.RegDNoOfExtDays, " & _
                                           "    REGISTRATION_DETAILS.RegDChkOutTime) AS [Expected Checkout], REGISTRATION_DETAILS.RegNo AS [Registration No], " & _
                                           "    REGISTRATION_DETAILS.RegDRemarks AS Remarks " & _
                                    "FROM       REGISTRATION_DETAILS INNER JOIN " & _
                                           "    ROOM ON REGISTRATION_DETAILS.RMNo = ROOM.RMNo " & _
                                           "    WHERE (REGISTRATION_DETAILS.RegDStat = 'REGISTERED') " & _
                                           "    GROUP BY REGISTRATION_DETAILS.RegDNo, ROOM.RMNo, ROOM.RMType, REGISTRATION_DETAILS.RegDChkInTime,  " & _
                                           "    REGISTRATION_DETAILS.RegDNoOfExtDays, DATEADD(DAY, REGISTRATION_DETAILS.RegDNoOfExtDays,  " & _
                                           "    REGISTRATION_DETAILS.RegDChkOutTime), REGISTRATION_DETAILS.RegNo, REGISTRATION_DETAILS.RegDRemarks,  " & _
                                           "    REGISTRATION_DETAILS.RegDNoGuest " & _
                                           "    HAVING (REGISTRATION_DETAILS.RegNo = '" & gRegno & "') ", dgvRegRooms)


            ListItems(DatabasePath(), "SELECT REGISTRATION_DETAILS.RegDNo AS [Accommodation No], ROOM.RMNo AS [Room No], ROOM.RMType AS [Room Type], " & _
                                                                "       REGISTRATION_DETAILS.RegDChkInTime AS [Check In Time], DATEDIFF(day, REGISTRATION_DETAILS.RegDChkInTime, '" & dtpCheckOutDate.Value.ToString & "')  " & _
                                                                "       AS [Days Stayed In Hotel], REGISTRATION_DETAILS.RegDNoOfExtDays AS [Extension in Days], DATEADD(DAY,   " & _
                                                                "       REGISTRATION_DETAILS.RegDNoOfExtDays, REGISTRATION_DETAILS.RegDChkOutTime) AS [Expected Checkout],   " & _
                                                                "       SUM(FOLIO_DETAILS.FDModifiedCharge) AS [Total Amount], SUM(FOLIO_DETAILS.FDBalance) AS [Total Balance],   " & _
                                                                "       REGISTRATION_DETAILS.RegNo AS [Registration No], REGISTRATION_DETAILS.RegDRemarks AS [Remarks]  " & _
                                                                "FROM   REGISTRATION_DETAILS INNER JOIN  " & _
                                                                "       ROOM ON REGISTRATION_DETAILS.RMNo = ROOM.RMNo INNER JOIN  " & _
                                                                "       FOLIO_DETAILS ON REGISTRATION_DETAILS.RegDNo = FOLIO_DETAILS.RegDNo  " & _
                                                                "WHERE  (REGISTRATION_DETAILS.RegDStat = 'CHECKED OUT')  " & _
                                                                "GROUP BY REGISTRATION_DETAILS.RegDNo, ROOM.RMNo, ROOM.RMType, REGISTRATION_DETAILS.RegDChkInTime,   " & _
                                                                "       REGISTRATION_DETAILS.RegDNoOfExtDays, DATEADD(DAY, REGISTRATION_DETAILS.RegDNoOfExtDays,   " & _
                                                                "       REGISTRATION_DETAILS.RegDChkOutTime), REGISTRATION_DETAILS.RegNo, REGISTRATION_DETAILS.RegDRemarks  " & _
                                                                "HAVING (REGISTRATION_DETAILS.RegNo = '" & gRegno & "') ", dgvCheckOutRooms)

        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        If Msg("1033", Button.YesNo) = ButtonClicked.Yes Then
            Refresher()
        End If
    End Sub

    Sub Refresher()
        gRegno = String.Empty
        lblGuestName.Text = ""
        dgvRegRooms.DataSource = Nothing
        dgvRegRooms.Refresh()

        dgvCheckOutRooms.DataSource = Nothing
        dgvCheckOutRooms.Refresh()

        lvwTransferRooms.Items.Clear()
        gState = State.waiting

        btnRoomVacancySearch.PerformClick()
        txtRemarks.Text = ""
        lblTotalCharges.Text = Format(0, "n")
        lblTotalPayments.Text = Format(0, "n")
        lblTotalBalance.Text = Format(0, "n")
    End Sub

#End Region

#Region "Room Search"
    'RoomSearch
    '0 RoomNo
    '1 RoomType
    '2 Amount
    '3 MaxGuest
    '4 Floor
    '5 View

    Private Sub btnChangeDateTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangeDateTime.Click
        If UserPrivilege <> Privilege.system Then
            If dtpCheckOutDate.Enabled = False Then
                frmAuthorization.ShowDialog()
                dtpCheckOutDate.Enabled = frmAuthorization.Result
            End If
        Else
            dtpCheckInDate.Enabled = True
            dtpCheckInTime.Enabled = True
        End If
    End Sub

    Private Sub dtpCheckOutDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpCheckOutDate.ValueChanged
        lblNumberOfNights.Text = (dtpCheckOutDate.Value - dtpCheckInDate.Value).Days.ToString
    End Sub

    Private Sub dtpCheckInDate_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpCheckInDate.Leave
        Dim dtpdate As DateTimePicker
        dtpdate = CType(sender, DateTimePicker)
        CheckDate(dtpdate)
    End Sub

    Private Sub dtpCheckInDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpCheckInDate.ValueChanged
        dtpCheckOutDate.MinDate = dtpCheckInDate.Value.Date
        dtpCheckOutDate.Value = dtpCheckInDate.Value.Date.AddDays(1)
        lblNumberOfNights.Text = (dtpCheckOutDate.Value - dtpCheckInDate.Value).Days.ToString
    End Sub

    Private Sub dgvRoomVacancySearch_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvRoomVacancySearch.SelectionChanged
        If dgvRoomVacancySearch.SelectedRows.Count > 0 Then
            txtNoOfOccupants.Text = dgvRoomVacancySearch.SelectedRows.Item(0).Cells(3).Value.ToString
            lblNumberOfNights.Text = (dtpCheckOutDate.Value - dtpCheckInDate.Value).Days.ToString
            lblRoomRate.Text = dgvRoomVacancySearch.Item(2, dgvRoomVacancySearch.CurrentRow.Index).Value.ToString
        End If
    End Sub

    Private Sub btnRoomVacancySearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRoomVacancySearch.Click
        SearchRoomLoad("''")

        For Each ctrl As Control In gbxRoomVacancySearch.Controls

            If TypeOf ctrl Is TextBox Or TypeOf ctrl Is ComboBox Then

                If ctrl.Text <> String.Empty Then

                    If txtRoomNumber.Text <> String.Empty Then
                        objRoomDataView.RowFilter = "[Room Number]LIKE '%" & txtRoomNumber.Text & "%' OR " & _
                                                    "[Room Type] = '" & cboRoomType.Text & "' OR " & _
                                                    "Floor = '" & cboFloor.Text & "' OR " & _
                                                    "View = '" & cboView.Text & "'"

                    Else
                        objRoomDataView.RowFilter = "[Room Type] = '" & cboRoomType.Text & "' OR " & _
                                                    "Floor = '" & cboFloor.Text & "' OR " & _
                                                    "View = '" & cboView.Text & "'"

                    End If

                End If

            End If

        Next

    End Sub

    Private Sub SearchRoomLoad(ByVal strRoomNo As String)

        objRoomDataView = SearchRoom(dtpCheckInDate.Value.Date & " " & dtpCheckInTime.Value.ToLongTimeString, dtpCheckOutDate.Value.Date & " " & dtpCheckOutTime.Value.ToLongTimeString, "reg")
        dgvRoomVacancySearch.DataSource = objRoomDataView
        objRoomDataView.RowFilter = "[Room Number]NOT IN (" & strRoomNo & ")"
        dgvRoomVacancySearch.Sort(dgvRoomVacancySearch.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
        ClearDataBindings(gbxRoomRegistrationDetails)
        lblRoomNumber.DataBindings.Add("Text", dgvRoomVacancySearch.DataSource, "Room Number")
    End Sub
#End Region

#Region "Room Transfer"

    Private Sub btnAddRoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddRoom.Click
        Dim HasOldRoom As Boolean = False
        Dim HasNewRoom As Boolean = False
        gState = State.updating

        'checks if the room is already in the list
        For intCtr As Integer = 0 To lvwTransferRooms.Items.Count - 1
            If lblRoomNumber.Text = lvwTransferRooms.Items(intCtr).SubItems(0).Text Or lblRoomNumberOld.Text = lvwTransferRooms.Items(intCtr).SubItems(1).Text Then
                Msg("1002") 'duplicate not allowed
                Exit Sub
            End If
        Next

        For Each objDataGridViewRow In dgvRegRooms.Rows
            If lblRoomNumberOld.Text = objDataGridViewRow.Cells(1).Value.ToString Then
                HasOldRoom = True
                objTransferRoom = objDataGridViewRow
            End If
        Next

        For Each objDataGridViewRow In dgvRoomVacancySearch.Rows
            If lblRoomNumber.Text = objDataGridViewRow.Cells(0).Value.ToString Then
                HasNewRoom = True
            End If
        Next

        If Char.IsNumber(CChar(txtNoOfOccupants.Text)) = False Then
            Msg("1001", , "Invalid number of occupants input")
        ElseIf Char.IsNumber(CChar(lblNumberOfNights.Text)) = False Then
            Msg("1001", , "Invalid number of nights input")
        ElseIf dtpCheckOutDate.Value.Date <= dtpCheckInDate.Value.Date Then
            Msg("1001", , "invalid date range")
        ElseIf HasOldRoom = False Then
            Msg("1001", , "Please select a previous room")
        ElseIf HasNewRoom = False Then
            Msg("1001", , "Please select an available room")
        Else
            If CInt(dgvRoomVacancySearch.SelectedRows.Item(0).Cells(3).Value.ToString) < CInt(txtNoOfOccupants.Text) Then

                If Msg("1042", Button.YesNo) = ButtonClicked.Yes Then
                    AddRoomToList()
                Else
                    txtNoOfOccupants.Focus()
                End If
            Else
                AddRoomToList()
            End If
        End If
    End Sub

    Sub AddRoomToList()
        'TransferRoom
        '0 RoomNo
        '1 OldRoomNo
        '2 RoomType
        '3 RoomRate
        '4 CheckIn
        '5 Expected(Checkout)
        '6 No of Occupants
        '7 RegNo
        '8 Remarks

        Dim lswItem As ListViewItem = lvwTransferRooms.Items.Add(lblRoomNumber.Text)
        lswItem.SubItems.Add(lblRoomNumberOld.Text)
        lswItem.SubItems.Add(dgvRoomVacancySearch.SelectedRows.Item(0).Cells(1).Value.ToString)
        lswItem.SubItems.Add(Format(CType(lblRoomRate.Text, Double), "n"))
        lswItem.SubItems.Add(dtpCheckInDate.Value.Date & " " & dtpCheckInTime.Value.ToShortTimeString)
        lswItem.SubItems.Add(dtpCheckOutDate.Value.Date & " " & dtpCheckOutTime.Value.ToShortTimeString)
        lswItem.SubItems.Add(txtNoOfOccupants.Text)
        lswItem.SubItems.Add(objTransferRoom.Cells(8).Value.ToString)
        lswItem.SubItems.Add(objTransferRoom.Cells(9).Value.ToString)
    End Sub

    Private Sub dgvRegRooms_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvRegRooms.SelectionChanged
        'RegRoom
        '0 RegDNo
        '1 RoomNo
        '2 RoomType
        '3 CheckIn
        '4 NoOfOccupants
        '5 DaysStayed
        '6 ExtensionInDays
        '7 CheckOut
        '8 RegNo
        '9 Remarks
        If dgvRegRooms.SelectedRows.Count > 0 Then
            lblRoomNumberOld.Text = dgvRegRooms.SelectedRows(0).Cells(1).Value.ToString
        End If
    End Sub

    Private Sub btnReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        gState = State.updating
        If lvwTransferRooms.SelectedItems.Count > 0 Then
            For Each ctlRow As ListViewItem In lvwTransferRooms.Items
                If ctlRow.Selected = True Then
                    ctlRow.Remove()
                End If
            Next
        Else
            Msg("1005", Button.Ok)
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Msg("1031", Button.YesNo) = ButtonClicked.Yes Then
            Dim txtRegDNo As String = ""
            Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
                objConnection.Open()
                Using objTransaction As SqlTransaction = objConnection.BeginTransaction

                    Using objCommand As SqlCommand = objConnection.CreateCommand
                        With objCommand
                            .Transaction = objTransaction
                            Try
                                'Update per row
                                For Each ctlListView As ListViewItem In lvwTransferRooms.Items
                                    'Find the RegDNo of the Old Room
                                    For iCtr As Integer = 0 To dgvRegRooms.RowCount - 1
                                        If ctlListView.SubItems(1).Text = dgvRegRooms.Rows(iCtr).Cells(1).Value.ToString Then
                                            txtRegDNo = dgvRegRooms.Rows(iCtr).Cells(0).Value.ToString
                                        End If
                                    Next

                                    'Create activity log for the Room transfer
                                    .CommandText = "INSERT INTO ACTIVITY_LOG (ALID, ALResOrReg, ALNature, ALOldVal, ALNewVal, ALTimeChanged, GNo, EID, RegDNo, RegNo) " & _
                                                                                             "VALUES (@ALID, @ALResOrReg, @ALNature, @ALOldVal, @ALNewVal, @ALTimeChanged, @GNo, @EID, @RegDNo, @RegNo);"
                                    .Parameters.AddWithValue("@ALID", GetPreKeyGen("ALID") & GetPrimaryKeyNo("ALID"))
                                    .Parameters.AddWithValue("@ALResOrReg", "Registration")
                                    .Parameters.AddWithValue("@ALNature", "ROOM TRANSFER")
                                    .Parameters.AddWithValue("@ALOldVal", ctlListView.SubItems(1).Text)
                                    .Parameters.AddWithValue("@ALNewVal", ctlListView.SubItems(0).Text)
                                    .Parameters.AddWithValue("@ALTimeChanged", Date.Now)
                                    .Parameters.AddWithValue("@GNo", SearchedGuestID)
                                    .Parameters.AddWithValue("@EID", DatabaseUser())
                                    .Parameters.AddWithValue("@RegDNo", txtRegDNo)
                                    .Parameters.AddWithValue("@RegNo", gRegno)
                                    .ExecuteNonQuery()
                                    .Parameters.Clear()
                                    IncrementPrimaryKeyNo("ALID")


                                    'Checking Out Rooms

                                    'Create activity log if there is either an early or late checkout
                                    .CommandText = "SELECT RegDChkOutTime From REGISTRATION_DETAILS WHERE RegDNo=@RegDNo;"
                                    .Parameters.AddWithValue("@RegDNo", txtRegDNo)
                                    Dim dtCheckOut As Date = CType(.ExecuteScalar, Date)
                                    .Parameters.Clear()

                                    If CType(ctlListView.SubItems(4).Text, Date) > dtCheckOut Then
                                        'Early Checkout
                                        .CommandText = "INSERT INTO ACTIVITY_LOG (ALID, ALResOrReg, ALNature, ALOldVal, ALNewVal, ALTimeChanged, GNo, EID, RegDNo, RegNo) " & _
                                                          "VALUES (@ALID, @ALResOrReg, @ALNature, @ALOldVal, @ALNewVal, @ALTimeChanged, @GNo, @EID, @RegDNo, @RegNo);"
                                        .Parameters.AddWithValue("@ALID", GetPreKeyGen("ALID") & GetPrimaryKeyNo("ALID"))
                                        .Parameters.AddWithValue("@ALResOrReg", "Registration")
                                        .Parameters.AddWithValue("@ALNature", "EARLY CHECKOUT")
                                        .Parameters.AddWithValue("@ALOldVal", dtCheckOut)
                                        .Parameters.AddWithValue("@ALNewVal", ctlListView.SubItems(4).Text)
                                        .Parameters.AddWithValue("@ALTimeChanged", Date.Now)
                                        .Parameters.AddWithValue("@GNo", SearchedGuestID)
                                        .Parameters.AddWithValue("@EID", DatabaseUser())
                                        .Parameters.AddWithValue("@RegDNo", txtRegDNo)
                                        .Parameters.AddWithValue("@RegNo", gRegno)
                                        .ExecuteNonQuery()
                                        .Parameters.Clear()
                                        IncrementPrimaryKeyNo("ALID")
                                    ElseIf CType(ctlListView.SubItems(4).Text, Date) < dtCheckOut Then
                                        'Late Checkout
                                        .CommandText = "INSERT INTO ACTIVITY_LOG (ALID, ALResOrReg, ALNature, ALOldVal, ALNewVal, ALTimeChanged, GNo, EID, RegDNo, RegNo) " & _
                                                   "VALUES (@ALID, @ALResOrReg, @ALNature, @ALOldVal, @ALNewVal, @ALTimeChanged, @GNo, @EID, @RegDNo, @RegNo);"
                                        .Parameters.AddWithValue("@ALID", GetPreKeyGen("ALID") & GetPrimaryKeyNo("ALID"))
                                        .Parameters.AddWithValue("@ALResOrReg", "Registration")
                                        .Parameters.AddWithValue("@ALNature", "LATE CHECKOUT")
                                        .Parameters.AddWithValue("@ALOldVal", dtCheckOut)
                                        .Parameters.AddWithValue("@ALNewVal", ctlListView.SubItems(4).Text)
                                        .Parameters.AddWithValue("@ALTimeChanged", Date.Now)
                                        .Parameters.AddWithValue("@GNo", SearchedGuestID)
                                        .Parameters.AddWithValue("@EID", DatabaseUser())
                                        .Parameters.AddWithValue("@RegDNo", txtRegDNo)
                                        .Parameters.AddWithValue("@RegNo", gRegno)
                                        .ExecuteNonQuery()
                                        .Parameters.Clear()
                                        IncrementPrimaryKeyNo("ALID")
                                    End If

                                    'Checkout each rooms at the list
                                    .CommandText = "UPDATE REGISTRATION_DETAILS SET RegDStat=@RegDStat, " & _
                                                   "RegDChkOutTime=@RegDChkOutTime, RegDRemarks = RegDRemarks + @RegDRemarks " & _
                                                   "WHERE RegDNo=@RegDNo;"
                                    .Parameters.AddWithValue("@RegDStat", "CHECKED OUT")
                                    .Parameters.AddWithValue("@RegDChkOutTime", ctlListView.SubItems(4).Text)
                                    .Parameters.AddWithValue("@RegDNo", txtRegDNo)
                                    .Parameters.AddWithValue("@RegDRemarks", ctlListView.SubItems(8).Text)
                                    .ExecuteNonQuery()
                                    .Parameters.Clear()

                                    'set checked out rooms to unclean
                                    .CommandText = "UPDATE ROOM SET RMCurrStat=@RMCurrStat WHERE RMNo=@RMNo;"
                                    .Parameters.AddWithValue("@RMCurrStat", "DIRTY")
                                    .Parameters.AddWithValue("@RMNo", ctlListView.SubItems(1).Text)
                                    .ExecuteNonQuery()
                                    .Parameters.Clear()

                                    'set room status info
                                    .CommandText = "UPDATE RMSTATUS SET RMSEndTime=@RMSEndTime, RMSStat=@RMSStat " & _
                                                   "WHERE RMNo=@RMNo AND RMSName='REGISTERED' AND RMSStat IS NULL;"
                                    .Parameters.AddWithValue("@RMSEndTime", ctlListView.SubItems(4).Text)
                                    .Parameters.AddWithValue("@RMSStat", "CHECKED OUT")
                                    .Parameters.AddWithValue("@RMNo", ctlListView.SubItems(1).Text)
                                    .ExecuteNonQuery()
                                    .Parameters.Clear()

                                    'Registering Rooms
                                    'set registration details
                                    .CommandText = "INSERT INTO REGISTRATION_DETAILS (RegDNo, RegDChkInTime, RegDChkOutTime, RegDDaysUpdated, RegDStat, RegDNoGuest, RegDRemarks, RMNo, RegNo, RegDRMAmt) " & _
                                                                             "VALUES (@RegDNo, @RegDChkInTime, @RegDChkOutTime,   1, @RegDStat, @RegDNoGuest, @RegDRemarks, @RMNo, @RegNo, @RegDRMAmt);"
                                    Dim strRegDNo As String = GetPrimaryKeyNo("RegistrationDetails")

                                    .Parameters.AddWithValue("@RegDNo", GetPreKeyGen("RegistrationDetails") & GetPrimaryKeyNo("RegistrationDetails"))
                                    .Parameters.AddWithValue("@RegDChkInTime", ctlListView.SubItems(4).Text)
                                    .Parameters.AddWithValue("@RegDChkOutTime", ctlListView.SubItems(5).Text)
                                    .Parameters.AddWithValue("@RegDStat", "REGISTERED")
                                    .Parameters.AddWithValue("@RegDNoGuest", ctlListView.SubItems(6).Text)
                                    .Parameters.AddWithValue("@RegDRemarks", ctlListView.SubItems(8).Text)
                                    .Parameters.AddWithValue("@RMNo", ctlListView.SubItems(0).Text)
                                    .Parameters.AddWithValue("@RegNo", gRegno)
                                    .Parameters.AddWithValue("@RegDRMAmt", ctlListView.SubItems(3).Text)
                                    .ExecuteNonQuery()
                                    .Parameters.Clear()
                                    IncrementPrimaryKeyNo("RegistrationDetails")

                                    .CommandText = "INSERT INTO FOLIO_DETAILS (FDNo, FDReceiptNo, FDDate, FDCharge, FDModifiedCharge, FDBalance, FDName, FDModifiedByAmt, FDModifiedByPercent, FDDesc, RegNo, RegDNo, FDStat) " & _
                                                    "VALUES(@FDNo, @FDReceiptNo, @FDDate, @FDCharge, @FDModifiedCharge, @FDBalance, @FDName, @FDModifiedByAmt, @FDModifiedByPercent, @FDDesc, @RegNo, @RegDNo, 'UNPAID') "
                                    .Parameters.Clear()
                                    With .Parameters
                                        .AddWithValue("@FDNo", GetPrimaryKeyNo("FDNo"))
                                        .AddWithValue("@FDReceiptNo", GetPrimaryKeyNo("FDNo"))
                                        IncrementPrimaryKeyNo("FDNo")
                                        .AddWithValue("@FDDate", Date.Now)
                                        .AddWithValue("@FDCharge", ctlListView.SubItems(3).Text)
                                        .AddWithValue("@FDModifiedCharge", ctlListView.SubItems(3).Text)
                                        .AddWithValue("@FDBalance", ctlListView.SubItems(3).Text)
                                        .AddWithValue("@FDName", "ROOM CHARGES")
                                        .AddWithValue("@FDModifiedByAmt", 0)
                                        .AddWithValue("@FDModifiedByPercent", 0)
                                        .AddWithValue("@FDDesc", "ROOM")
                                        .AddWithValue("@RegNo", gRegno)
                                        .AddWithValue("@RegDNo", strRegDNo)
                                    End With
                                    .ExecuteNonQuery()

                                    .CommandText = "UPDATE REGISTRATION SET REGAMT=REGAMT + @REGAMT, REGBALANCE=REGBALANCE+@REGBALANCE WHERE REGNO=@REGNO"
                                    With .Parameters
                                        .Clear()
                                        .AddWithValue("@RegAmt", ctlListView.SubItems(3).Text)
                                        .AddWithValue("@RegBalance", ctlListView.SubItems(3).Text)
                                        .AddWithValue("@regNo", gRegno)
                                    End With
                                    .ExecuteNonQuery()

                                    'set rmstatus
                                    .CommandText = "INSERT INTO RMSTATUS (RMSID, RMSName, RMSStartTime, RMSEndTime, RMNo) " & _
                                                   "VALUES (@RMSID, @RMSName, @RMSStartTime, @RMSEndTime, @RMNo);"
                                    .Parameters.AddWithValue("@RMSID", GetPreKeyGen("RMStatus") & GetPrimaryKeyNo("RMStatus"))
                                    .Parameters.AddWithValue("@RMSName", "REGISTERED")
                                    .Parameters.AddWithValue("@RMSStartTime", ctlListView.SubItems(4).Text)
                                    .Parameters.AddWithValue("@RMSEndTime", ctlListView.SubItems(5).Text)
                                    .Parameters.AddWithValue("@RMNo", ctlListView.SubItems(0).Text)
                                    .ExecuteNonQuery()
                                    .Parameters.Clear()
                                    IncrementPrimaryKeyNo("RMStatus")
                                Next
                                objTransaction.Commit()
                                gState = State.waiting
                                ShowRooms()
                                lvwTransferRooms.Items.Clear()
                                btnRoomVacancySearch.PerformClick()

                                Msg("1032", Button.Ok)

                            Catch ex As Exception

                                objTransaction.Rollback()
                                Msg("1008", , "Saving Failed." & NWLN & ex.Message)

                            End Try

                        End With
                    End Using
                End Using
                objConnection.Close()
            End Using
        End If
    End Sub
#End Region

#Region "Remarks"
    Private Sub lvwTransferRooms_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwTransferRooms.SelectedIndexChanged
        For intCtr As Integer = 0 To lvwTransferRooms.Items.Count - 1
            If lvwTransferRooms.Items(intCtr).Selected = True Then
                txtRemarks.Text = lvwTransferRooms.Items(intCtr).SubItems(8).Text
                MyTag = intCtr
            End If
        Next
    End Sub

    Private Sub txtRemarks_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRemarks.Validated
        If lvwTransferRooms.Items.Count > 0 Then
            lvwTransferRooms.Items(CType(MyTag, Integer)).SubItems(8).Text = txtRemarks.Text
        End If
    End Sub
#End Region

#Region "Tabs"
    Private Sub tsbGuestSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuestSearch.Click
        TriggeredBy = TriggeringForm.RoomTransfer
        frmGuestSearch.ShowDialog()
    End Sub

    Private Sub tsbNewRegistration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbNewRegistration.Click
        TriggeredBy = TriggeringForm.Registration
        Display(Forms.frmRegistration)
        Me.Close()
    End Sub

    Private Sub tsbUpdateRegistration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbUpdateRegistration.Click
        TriggeredBy = TriggeringForm.UpdateRegistration
        Display(Forms.frmUpdateRegistration)
        Me.Close()
    End Sub

    Private Sub tsbGuestFolio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuestFolio.Click
        TriggeredBy = TriggeringForm.GuestFolio
        Display(Forms.frmGuestFolio)
        Me.Close()
    End Sub

    Private Sub tsbPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbPayment.Click
        TriggeredBy = TriggeringForm.Payment
        Display(Forms.frmPayment)
        Me.Close()
    End Sub

    Private Sub lblClose_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblClose.LinkClicked
        Me.Close()
    End Sub

    Private Sub btnViewDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewDetails.Click
        Display(Forms.frmRoomRack)
    End Sub
#End Region
End Class