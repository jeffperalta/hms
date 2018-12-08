Option Explicit On
Option Strict On

Imports System.Data.SqlClient

' Programmer:   Howell Quindara
' Date:         March 18, 2007
' Title:        frmUpdateRegistration
' Purpose:      This interface changes room information such as check out day and 
'               adds new room to the registration of a guest
' Requirements: ->  (+)REGISTRATION_DETAILS (REGDNO, REGDCHKINTIME, REGDCHKOUTTIME, REGDRMAMT, REGDSTAT, REGDNOGUEST, REGDNOOFEXTDAYS, RMNO, REGNO)
'               ->  (+)ACTIVITY_LOG (ALID, ALRESORREG, ALNATURE, ALOLDVAL, ALNEWVAL, ALTIMECHANGED, GNO, EID, REGNO, REGDNO)
'               ->  (+)RMSTATUS (RMSID, RMSNAME, RMSSTARTTIME, RMSENDTIME, RMNO)
'               ->  (+)FOLIO_DETAILS (FDNO, FDRECEIPTNO, FDDATE, FDCHARGE, FDMODIFIEDBYAMT, FDMODIFIEDBYPERCENT, FDMODIFIEDCHARGE, FDBALANCE, FDSTAT, REGNO, REGDNO, FDDESC, FDNAME)
'               ->  (*)REGISTRATION_DETAILS (REGDCHKOUTTIME, REGDNOOFEXTDAYS,REGDNOGUEST)
'               ->  (*)RMSTATUS (RMSENDTIME)
'               ->  (*)REGISTRATION(REGAMT,REGBALANCE)
'               ->  Registration must be active or not fully checked out
' Results:      ->  New room is added to the registration of the guest
'               ->  The information of the room registered to the guest is changed

Public Class frmUpdateRegistration

#Region "Declaration"

    Private objAdapter As SqlDataAdapter
    Private objTransaction As SqlTransaction
    Private objCommand As SqlCommand
    Private objDataView As New DataView
    Private objRoomDataView As New DataView
    Private objRegisteredDataView As New DataView
    Private objDataSet As DataSet
    Private objRegisteredDataSet As DataSet
    Private objDataTable As DataTable
    Private objDataRow As DataRow
    Private objDataGridViewRow As DataGridViewRow
    Private gstrGuest As String
    Private gstrRoomNo As String
    Private gstrRMSID As String
    Private gstrUpdatedRoom As String

#End Region

#Region "Guest Information"

    Private Sub lblRegistrationGIID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblRegistrationGIID.TextChanged

        If lblRegistrationGIID.Text <> "new" Then

            lblRegistrationGIID.Tag = "old"

            Using objDatabaseConnection As SqlConnection = SetUpConnection(DatabasePath, True)

                objAdapter = New SqlDataAdapter("SELECT * " & _
                                                "FROM GUEST_INFO " & _
                                                "WHERE GIID = '" & lblRegistrationGIID.Text & "';", objDatabaseConnection)
                objDataSet = SetUpDataSet(objAdapter, "qryguest")
                radCompanyInfoNew.Checked = True

                If objDataSet.Tables("qryguest").Rows.Count = 1 Then

                    objDataRow = objDataSet.Tables("qryguest").Rows(0)
                    txtGuestInfoTitle.Text = objDataRow.Item(1).ToString
                    txtGuestInfoFirstName.Text = objDataRow.Item(2).ToString
                    txtGuestInfoLastName.Text = objDataRow.Item(3).ToString
                    txtGuestInfoMiddleInitial.Text = objDataRow.Item(4).ToString
                    cboGuestInfoCountry.Text = objDataRow.Item(5).ToString
                    txtGuestInfoAddress.Text = objDataRow.Item(6).ToString
                    txtGuestInfoZipCode.Text = objDataRow.Item(7).ToString
                    txtGuestInfoContactNo.Text = objDataRow.Item(8).ToString
                    txtGuestInfoEmail.Text = objDataRow.Item(9).ToString
                    cboGuestInfoGender.Text = objDataRow.Item(10).ToString
                    cboGuestInfoCivilStatus.Text = objDataRow.Item(11).ToString
                    txtGuestInfoNationality.Text = objDataRow.Item(12).ToString
                    txtGuestInfoCitezenship.Text = objDataRow.Item(13).ToString

                    If objDataRow.Item(14) Is DBNull.Value Then

                        dtpGuestInfoBirthDate.Checked = False

                    Else

                        dtpGuestInfoBirthDate.Value = CDate(objDataRow.Item(14))

                    End If

                    lblNameOfGuest.Text = txtGuestInfoFirstName.Text & " " & txtGuestInfoLastName.Text

                End If

            End Using

        End If

    End Sub

#End Region

#Region "Update Registration Information"

    Private Sub btnAddRoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddRoom.Click

        'checks if the room is already in the list
        For Each objDataGridViewRow In dgvGuestRooms.Rows

            If lblRoomNumber.Text = objDataGridViewRow.Cells(0).Value.ToString Then

                Msg("1002", Button.Ok, "Room already in the list")
                Exit Sub

            End If

        Next

        If IntegerInput(txtNoOfOccupants.Text.ToString) = False Then

            Msg("1001", , "Invalid number of occupants input")

        ElseIf dtpCheckOutDate.Value.Date <= dtpCheckInDate.Value.Date Then

            Msg("1001", , "Invalid date range")

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

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

        If lblRegistrationNumber.Text <> String.Empty Then

            If Msg("1037", Button.YesNo) = ButtonClicked.Yes Then

                ClearUpdateRegistration()
                dgvRoomVacancySearch.DataSource = vbNull

            End If

        End If

    End Sub

    Private Sub dtpCheckOutDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpCheckOutDate.ValueChanged

        lblNumberOfNights.Text = (dtpCheckOutDate.Value - dtpCheckInDate.Value).Days.ToString

    End Sub

    Private Sub lblRegistrationNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblRegistrationNumber.TextChanged

        Dim strReservedRoom As String = String.Empty
        gstrRoomNo = String.Empty
        Dim ctr As Integer = 1

        If lblRegistrationNumber.Text <> String.Empty Then

            If ActiveRegistration(lblRegistrationNumber.Text.ToString) = False Then

                Msg("1050")
                lblRegistrationNumber.Text = String.Empty

            Else

                dgvGuestRooms.Rows.Clear()
                gstrUpdatedRoom = String.Empty

                Using objDatabaseConnection As SqlConnection = SetUpConnection(DatabasePath, True)

                    Try
                        '----CODE BY JEFF HERE
                        objAdapter = New SqlDataAdapter("SELECT RegRemarks FROM REGISTRATION WHERE RegNo='" & lblRegistrationNumber.Text & "'", objDatabaseConnection)
                        objDataSet = SetUpDataSet(objAdapter, "qryRemarks")
                        objDataRow = objDataSet.Tables("qryRemarks").Rows(0)
                        txtRemarks.Text = objDataRow.Item(0).ToString
                        '----

                        objAdapter = New SqlDataAdapter("SELECT REGISTRATION_DETAILS.RMNo AS [Room No.], RMRATE.RMRAmt AS [Room Rate], ROOM.RMType AS [Room Type], REGISTRATION_DETAILS.RegDNoGuest AS [Number of Guest], DATEDIFF(day, REGISTRATION_DETAILS.RegDChkInTime, REGISTRATION_DETAILS.RegDChkOutTime) AS [Number of Nights], REGISTRATION_DETAILS.RegDChkInTime AS [Check In Date], REGISTRATION_DETAILS.RegDChkOutTime AS [Check Out Date], RMSTATUS.RMSID " & _
                                                        "FROM REGISTRATION_DETAILS INNER JOIN RMSTATUS ON REGISTRATION_DETAILS.RMNo = RMSTATUS.RMNo AND REGISTRATION_DETAILS.RegDChkInTime = RMSTATUS.RMSStartTime AND REGISTRATION_DETAILS.RegDChkOutTime = RMSTATUS.RMSEndTime INNER JOIN RMRATE_DETAILS ON REGISTRATION_DETAILS.RMNo = RMRATE_DETAILS.RMNo INNER JOIN RMRATE ON RMRATE_DETAILS.RMRID = RMRATE.RMRID INNER JOIN ROOM ON REGISTRATION_DETAILS.RMNo = ROOM.RMNo " & _
                                                        "WHERE (REGISTRATION_DETAILS.RegNo = '" & lblRegistrationNumber.Text & "') AND (RMSTATUS.RMSName = 'REGISTERED') AND (ISNULL(RMSTATUS.RMSStat, 'empty') = 'empty') AND (RMRATE_DETAILS.RMDActive = 'TRUE')", objDatabaseConnection)
                        objRegisteredDataSet = SetUpDataSet(objAdapter, "qryUpdateReservationSearch")
                        objRegisteredDataView = New DataView(objRegisteredDataSet.Tables("qryUpdateReservationSearch"))
                        lblNumberOfOccupants.Text = "0"
                        lblTotalAmount.Text = "0"

                        For Each objDataRow In objRegisteredDataView.Table.Rows

                            dgvGuestRooms.Rows.Add(objDataRow.Item(0).ToString, CDbl(objDataRow.Item(1).ToString).ToString("n"), objDataRow.Item(2).ToString, objDataRow.Item(3).ToString, objDataRow.Item(4).ToString, objDataRow.Item(5).ToString, objDataRow.Item(6).ToString, objDataRow.Item(7).ToString)
                            lblNumberOfOccupants.Text = (CInt(lblNumberOfOccupants.Text) + CInt(objDataRow.Item(3).ToString)).ToString
                            lblTotalAmount.Text = (CDbl(lblTotalAmount.Text) + (CDbl(objDataRow.Item(1).ToString) * CDbl(objDataRow.Item(4).ToString))).ToString("n")

                        Next

                        For Each objDataGridViewRow In dgvGuestRooms.Rows

                            If dgvGuestRooms.Rows.Count = ctr Then

                                strReservedRoom = strReservedRoom & objDataGridViewRow.Cells(0).Value.ToString

                            Else

                                strReservedRoom = strReservedRoom & objDataGridViewRow.Cells(0).Value.ToString & ","

                            End If

                            If dgvGuestRooms.Rows.Count = ctr Then

                                gstrRoomNo = gstrRoomNo & "'" & objDataGridViewRow.Cells(0).Value.ToString & "'"
                                gstrRMSID = gstrRMSID & "'" & objDataGridViewRow.Cells(6).Value.ToString & "'"

                            Else

                                gstrRoomNo = gstrRoomNo & "'" & objDataGridViewRow.Cells(0).Value.ToString & "'" & ","
                                gstrRMSID = gstrRMSID & "'" & objDataGridViewRow.Cells(0).Value.ToString & "'" & ","

                            End If

                            ctr += 1
                        Next

                    Catch ex As Exception

                        Msg("1008", , NWLN & "An error occured while loading the registered rooms" & NWLN & ex.Message)

                    End Try

                End Using

                lblNumberOfRooms.Text = dgvGuestRooms.Rows.Count.ToString
                SearchRoomLoad(gstrRoomNo)
                btnAddRoom.Enabled = True
                btnUpdateRegistrationSave.Enabled = True

            End If

        Else

            ClearControls(grpGuestInformation)
            ClearControls(pnlCompanyGroupInformation)
            lblNameOfGuest.Text = String.Empty
            lblRegistrationGIID.Text = "new"
            btnAddRoom.Enabled = False
            btnUpdateRegistrationSave.Enabled = False

        End If

    End Sub

    Private Sub ClearUpdateRegistration()

        SearchRoomLoad(gstrRoomNo)
        lblNumberOfOccupants.Text = "0"
        lblTotalAmount.Text = "0"
        lblNumberOfRooms.Text = "0"
        dgvGuestRooms.Rows.Clear()
        dgvNewRooms.Rows.Clear()
        lblRegistrationNumber.Text = String.Empty

    End Sub

    Private Sub btnEditRoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditRoom.Click

        If dgvGuestRooms.SelectedRows.Count > 0 Then

            Dim strRoomInfo As String = getRoomInfo(dgvGuestRooms.Rows(dgvGuestRooms.SelectedRows(0).Index), "Reg")
            FormToEdit = EditRoom.UpdateRegistration
            EditRoomFrom(strRoomInfo)

        End If

    End Sub

    Private Sub btnUpdateRegistrationSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateRegistrationSave.Click

        UpdateSave()

    End Sub

    Private Sub btnRemoveRoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveRoom.Click

        If dgvNewRooms.Rows.Count > 0 Then

            Dim strRoomNo As String = String.Empty
            Dim ctr As Integer = 0

            dgvNewRooms.Rows.Remove(dgvNewRooms.SelectedRows(0))

            If dgvNewRooms.Rows.Count < 1 Then

                SearchRoomLoad("''")

            Else

                For Each objDataGridViewRow In dgvNewRooms.Rows

                    If dgvNewRooms.Rows.Count - 1 = ctr Then

                        strRoomNo = strRoomNo & "'" & objDataGridViewRow.Cells(0).Value.ToString & "'"

                    Else

                        strRoomNo = strRoomNo & "'" & objDataGridViewRow.Cells(0).Value.ToString & "'" & ","

                    End If

                    ctr += 1
                Next

                SearchRoomLoad(strRoomNo)

            End If

        End If

        lblNumberOfRooms.Text = CStr(dgvGuestRooms.Rows.Count + dgvNewRooms.Rows.Count)

        Dim intNoOfOccupants As Integer = 0
        Dim dblTotalAmount As Double = 0

        For Each objDataGridViewRow In dgvGuestRooms.Rows

            intNoOfOccupants = intNoOfOccupants + CInt(objDataGridViewRow.Cells(3).Value.ToString())
            dblTotalAmount = dblTotalAmount + (CDbl(objDataGridViewRow.Cells(1).Value.ToString()) * CDbl(objDataGridViewRow.Cells(4).Value.ToString()))

        Next

        For Each objDataGridViewRow In dgvNewRooms.Rows

            intNoOfOccupants = intNoOfOccupants + CInt(objDataGridViewRow.Cells(3).Value.ToString())
            dblTotalAmount = dblTotalAmount + (CDbl(objDataGridViewRow.Cells(1).Value.ToString()) * CDbl(objDataGridViewRow.Cells(4).Value.ToString()))

        Next

        lblNumberOfOccupants.Text = intNoOfOccupants.ToString
        lblTotalAmount.Text = dblTotalAmount.ToString

    End Sub

    Private Sub dgvGuestRooms_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvGuestRooms.CellValueChanged

        Dim intNoOfOccupants As Integer = 0
        Dim dblTotalAmount As Double = 0

        For Each objDataGridViewRow In dgvGuestRooms.Rows

            intNoOfOccupants = intNoOfOccupants + CInt(objDataGridViewRow.Cells(3).Value.ToString())
            dblTotalAmount = dblTotalAmount + (CDbl(objDataGridViewRow.Cells(1).Value.ToString()) * CDbl(objDataGridViewRow.Cells(4).Value.ToString()))

        Next

        For Each objDataGridViewRow In dgvNewRooms.Rows

            intNoOfOccupants = intNoOfOccupants + CInt(objDataGridViewRow.Cells(3).Value.ToString())
            dblTotalAmount = dblTotalAmount + (CDbl(objDataGridViewRow.Cells(1).Value.ToString()) * CDbl(objDataGridViewRow.Cells(4).Value.ToString()))

        Next

        lblNumberOfOccupants.Text = intNoOfOccupants.ToString
        lblTotalAmount.Text = dblTotalAmount.ToString

    End Sub

    Private Sub dgvRoomVacancySearch_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvRoomVacancySearch.SelectionChanged

        If dgvRoomVacancySearch.SelectedRows.Count > 0 Then

            txtNoOfOccupants.Text = dgvRoomVacancySearch.SelectedRows.Item(0).Cells(3).Value.ToString
            lblRoomNumber.Text = dgvRoomVacancySearch.SelectedRows.Item(0).Cells(0).Value.ToString
            lblRoomRate.Text = CDbl(dgvRoomVacancySearch.SelectedRows.Item(0).Cells(2).Value.ToString).ToString("n")
        End If

    End Sub

    Private Sub btnRoomVacancySearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRoomVacancySearch.Click, dtpCheckInDate.LostFocus, dtpCheckInTime.LostFocus, dtpCheckOutDate.LostFocus, dtpCheckOutTime.LostFocus

        SearchRoomLoad("''")

        'CODE BY JEFF
        Dim blnFirstCriteria As Boolean = True
        Dim strCriteria As String = String.Empty

        If Trim(txtRoomNumber.Text) <> String.Empty Then
            If Not blnFirstCriteria Then
                strCriteria &= " AND "
            End If

            blnFirstCriteria = False

            strCriteria &= " [Room Number] LIKE '%" & TrimAll(txtRoomNumber.Text, True) & "%' "
        End If

        If Trim(cboRoomType.Text) <> String.Empty Then
            If Not blnFirstCriteria Then
                strCriteria &= " AND "
            End If

            blnFirstCriteria = False

            strCriteria &= " [Room Type] ='" & TrimAll(cboRoomType.Text) & "' "
        End If

        If Trim(cboFloor.Text) <> String.Empty Then
            If Not blnFirstCriteria Then
                strCriteria &= " AND "
            End If

            blnFirstCriteria = False

            strCriteria &= " Floor ='" & TrimAll(cboFloor.Text) & "' "
        End If

        If Trim(cboView.Text) <> String.Empty Then
            If Not blnFirstCriteria Then
                strCriteria &= " AND "
            End If

            blnFirstCriteria = False

            strCriteria &= " VIEW = '" & cboView.Text & "' "
        End If

        objRoomDataView.RowFilter = strCriteria

        lblSearchResult.Text = dgvRoomVacancySearch.Rows.Count.ToString

        'For Each ctrl As Control In gbxRoomVacancySearch.Controls

        '    If TypeOf ctrl Is TextBox Or TypeOf ctrl Is ComboBox Then

        '        If ctrl.Text <> String.Empty Then

        '            If txtRoomNumber.Text <> String.Empty Then

        '                objRoomDataView.RowFilter = "[Room Number]LIKE '%" & TrimAll(txtRoomNumber.Text, True) & "%' AND " & _
        '                                            "[Room Type] = '" & cboRoomType.Text & "' AND " & _
        '                                            "Floor = '" & cboFloor.Text & "' AND " & _
        '                                            "View = '" & cboView.Text & "'"

        '            Else

        '                objRoomDataView.RowFilter = "[Room Type] = '" & cboRoomType.Text & "' AND " & _
        '                                            "Floor = '" & cboFloor.Text & "' AND " & _
        '                                            "View = '" & cboView.Text & "'"

        '            End If

        '        End If

        '    End If

        'Next
    End Sub

    Private Sub dtpCheckInDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpCheckInDate.ValueChanged

        dtpCheckOutDate.MinDate = dtpCheckInDate.Value.Date
        dtpCheckOutDate.Value = dtpCheckInDate.Value.Date.AddDays(1)
        lblNumberOfNights.Text = (dtpCheckOutDate.Value - dtpCheckInDate.Value).Days.ToString

    End Sub

    Private Sub dtpDate_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpCheckInDate.Leave

        Dim dtpdate As DateTimePicker
        dtpdate = CType(sender, DateTimePicker)

        CheckDate(dtpdate)

    End Sub

#End Region

#Region "Other"

    Public Sub FillMe()

        lblRegistrationNumber.Text = SearchedRegistrationNo

        If lblRegistrationNumber.Text <> String.Empty Then

            lblRegistrationGIID.Text = SearchedGuestID

        End If
    End Sub

    Private Sub tsbGuestSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuestSearch.Click

        TriggeredBy = TriggeringForm.UpdateRegistration
        frmGuestSearch.ShowDialog()

    End Sub

    Private Sub tsbNewRegistration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbNewRegistration.Click

        Display(Forms.frmRegistration)

    End Sub

    Private Sub frmUpdateRegistration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        tbcUpdateRegistration.SelectedIndex = 1
        LoadComboBox(cboGuestInfoCountry, cboGuestInfoCivilStatus, cboRoomType, cboFloor, cboView, cbo)
        lblRegistrationGNO.Text = GetPreKeyGen("Guest") & GetPrimaryKeyNo("Guest")
        dtpCheckInDate.Value = Now.Date
        dtpCheckOutDate.Value = dtpCheckInDate.Value.AddDays(1)
        dtpCheckOutDate.MinDate = dtpCheckInDate.Value.Date

    End Sub

    Private Sub AddRoomToList()
        'USE TO ADD THE ROOM SELECTED TO THE GUEST ROOM
        Dim intNoOfOccupants As Integer = 0
        Dim dblTotalAmount As Double = 0

        dgvNewRooms.Rows.Add(lblRoomNumber.Text, lblRoomRate.Text, dgvRoomVacancySearch.SelectedRows.Item(0).Cells(1).Value.ToString, txtNoOfOccupants.Text, lblNumberOfNights.Text, dtpCheckInDate.Value.Date & " " & dtpCheckInTime.Value.ToShortTimeString, dtpCheckOutDate.Value.Date & " " & dtpCheckOutTime.Value.ToShortTimeString)
        frmParent.tssStatus.Text = "New room added"
        dgvRoomVacancySearch.Rows.Remove(dgvRoomVacancySearch.SelectedRows(0))
        lblNumberOfRooms.Text = CStr(dgvGuestRooms.Rows.Count + dgvNewRooms.Rows.Count)

        For Each objDataGridViewRow In dgvGuestRooms.Rows

            intNoOfOccupants = intNoOfOccupants + CInt(objDataGridViewRow.Cells(3).Value.ToString())
            dblTotalAmount = dblTotalAmount + (CDbl(objDataGridViewRow.Cells(1).Value.ToString()) * CDbl(objDataGridViewRow.Cells(4).Value.ToString()))

        Next

        For Each objDataGridViewRow In dgvNewRooms.Rows

            intNoOfOccupants = intNoOfOccupants + CInt(objDataGridViewRow.Cells(3).Value.ToString())
            dblTotalAmount = dblTotalAmount + (CDbl(objDataGridViewRow.Cells(1).Value.ToString()) * CDbl(objDataGridViewRow.Cells(4).Value.ToString()))

        Next

        lblNumberOfOccupants.Text = intNoOfOccupants.ToString
        lblTotalAmount.Text = dblTotalAmount.ToString
        ClearControls(gbxRoomRegistrationDetails, dtpCheckOutDate, dtpCheckInDate, dtpCheckInTime, dtpCheckOutTime, lblNumberOfNights)

    End Sub

    Private Sub SearchRoomLoad(ByVal strRoomNo As String)

        objRoomDataView = SearchRoom(dtpCheckInDate.Value.Date & " " & dtpCheckInTime.Value.ToLongTimeString, dtpCheckOutDate.Value.Date & " " & dtpCheckOutTime.Value.ToLongTimeString, "reg")
        dgvRoomVacancySearch.DataSource = objRoomDataView

        If strRoomNo <> String.Empty Then

            objRoomDataView.RowFilter = "[Room Number]NOT IN (" & strRoomNo & ")"
            dgvRoomVacancySearch.Sort(dgvRoomVacancySearch.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
            lblSearchResult.Text = dgvRoomVacancySearch.RowCount.ToString

        End If

    End Sub

    Public Sub UpdateRoomInfo(ByVal strRoomInfo As String)

        Dim strInfo() As String
        Dim strNoOfOccupants As String = dgvGuestRooms.SelectedRows.Item(0).Cells(3).Value.ToString
        Dim strNoOfNights As String = dgvGuestRooms.SelectedRows.Item(0).Cells(4).Value.ToString
        Dim strCheckout As String = dgvGuestRooms.SelectedRows.Item(0).Cells(6).Value.ToString

        strInfo = Split(strRoomInfo, "|")

        If strInfo(1) <> strNoOfOccupants Or strInfo(2) <> strNoOfNights Or strInfo(4) <> strCheckout Then

            dgvGuestRooms.SelectedRows.Item(0).Cells(3).Value = strInfo(1) 'number of occupants
            dgvGuestRooms.SelectedRows.Item(0).Cells(4).Value = strInfo(2) 'number of nights
            dgvGuestRooms.SelectedRows.Item(0).Cells(6).Value = strInfo(4) 'check out
            gstrUpdatedRoom = gstrUpdatedRoom & "|" & strInfo(0)

        End If

    End Sub

    Private Sub tsbRoomTransfer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbRoomTransfer.Click

        Display(Forms.frmRoomTransfer)

    End Sub

    Private Sub tsbGuestFolio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuestFolio.Click

        Display(Forms.frmGuestFolio)

    End Sub

    Private Sub btnViewDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewDetails.Click

        Display(Forms.frmRoomRack)

    End Sub

    Private Sub UpdateSave()

        Dim strUpdatedRoom() As String
        Dim blnInList As Boolean = False

        strUpdatedRoom = Split(gstrUpdatedRoom, "|")

        Using objReservationSaveConnection As SqlConnection = SetUpConnection(DatabasePath, True)

            If objReservationSaveConnection.State = ConnectionState.Closed Then objReservationSaveConnection.Open()

            Using objTransaction As SqlTransaction = objReservationSaveConnection.BeginTransaction

                Using objCommand As SqlCommand = objReservationSaveConnection.CreateCommand

                    With objCommand
                        .Transaction = objTransaction

                        Try

                            For Each objDataGridViewRow In dgvGuestRooms.Rows
                                'gets the current information of the registration
                                .CommandText = "SELECT RegDChkOutTime, RegDNoGuest, RegDno FROM REGISTRATION_DETAILS " & _
                                               "WHERE (REGNO = '" & lblRegistrationNumber.Text & "') AND (RMNO = '" & objDataGridViewRow.Cells(0).Value.ToString & "');"
                                objAdapter = New SqlDataAdapter(objCommand)
                                objDataSet = SetUpDataSet(objAdapter, "qryRoomInfo")
                                objDataTable = objDataSet.Tables("qryRoomInfo")

                                'checks if the room info is edited
                                For Each str As String In strUpdatedRoom
                                    blnInList = False
                                    If str = objDataGridViewRow.Cells(0).Value.ToString Then
                                        blnInList = True
                                        Exit For
                                    End If
                                Next

                                If blnInList Then 'update the room in the list

                                    If objDataSet.Tables("qryRoomInfo").Rows(0).Item(0).ToString <> objDataGridViewRow.Cells(6).Value.ToString Then 'changes in checkout time

                                        Dim strExtDays As String = (CDate(objDataGridViewRow.Cells(6).Value.ToString) - CDate(objDataSet.Tables("qryRoomInfo").Rows(0).Item(0).ToString)).Days.ToString

                                        If CInt(strExtDays) > 0 Then

                                            .CommandText = "UPDATE REGISTRATION_DETAILS SET REGDCHKOUTTIME = '" & objDataGridViewRow.Cells(6).Value.ToString & "', REGDNOOFEXTDAYS = '" & strExtDays & "' " & _
                                                           "WHERE (REGNO = '" & lblRegistrationNumber.Text & "') AND (RMNO = '" & objDataGridViewRow.Cells(0).Value.ToString & "');"
                                            .ExecuteNonQuery()

                                        Else
                                            .CommandText = "UPDATE REGISTRATION_DETAILS SET REGDCHKOUTTIME = '" & objDataGridViewRow.Cells(6).Value.ToString & "' " & _
                                                           "WHERE (REGNO = '" & lblRegistrationNumber.Text & "') AND (RMNO = '" & objDataGridViewRow.Cells(0).Value.ToString & "');"
                                            .ExecuteNonQuery()

                                        End If
                                        .CommandText = "UPDATE RMSTATUS SET RMSENDTIME = '" & objDataGridViewRow.Cells(6).Value.ToString & "' " & _
                                                       "WHERE RMSID = '" & objDataGridViewRow.Cells(7).Value.ToString & "';"
                                        .ExecuteNonQuery()

                                        .CommandText = "INSERT INTO ACTIVITY_LOG (ALID, ALRESORREG, ALNATURE, ALOLDVAL, ALNEWVAL, ALTIMECHANGED, GNO, EID, REGNO, REGDNO)" & _
                                                       "VALUES ('" & GetPrimaryKeyNo("ALID") & "', 'REGISTRATION', 'TIME OUT CHANGE', '" & objDataSet.Tables("qryRoomInfo").Rows(0).Item(0).ToString & "', '" & objDataGridViewRow.Cells(6).Value.ToString & "', '" & Now.ToString & "', '" & lblRegistrationGNO.Text & "', '" & DatabaseUser & "', '" & lblRegistrationNumber.Text & "', '" & objDataSet.Tables("qryRoomInfo").Rows(0).Item(2).ToString & "');"
                                        .ExecuteNonQuery()
                                        IncrementPrimaryKeyNo("ALID")
                                    End If

                                    If objDataSet.Tables("qryRoomInfo").Rows(0).Item(1).ToString <> objDataGridViewRow.Cells(3).Value.ToString Then 'changes in occupants

                                        .CommandText = "UPDATE REGISTRATION_DETAILS SET REGDNOGUEST = '" & objDataGridViewRow.Cells(3).Value.ToString & "' " & _
                                                       "WHERE (REGNO = '" & lblRegistrationNumber.Text & "') AND (RMNO = '" & objDataGridViewRow.Cells(0).Value.ToString & "');"
                                        .ExecuteNonQuery()
                                        .CommandText = "INSERT INTO ACTIVITY_LOG (ALID, ALRESORREG, ALNATURE, ALOLDVAL, ALNEWVAL, ALTIMECHANGED, GNO, EID, REGNO, REGDNO)" & _
                                                       "VALUES ('" & GetPrimaryKeyNo("ALID") & "', 'REGISTRATION', 'OCCUPANTS', '" & objDataSet.Tables("qryRoomInfo").Rows(0).Item(1).ToString & "', '" & objDataGridViewRow.Cells(3).Value.ToString & "' , '" & Now.ToString & "' , '" & lblRegistrationGNO.Text & "', '" & DatabaseUser & "', '" & lblRegistrationNumber.Text & "','" & objDataSet.Tables("qryRoomInfo").Rows(0).Item(2).ToString & "');"
                                        .ExecuteNonQuery()
                                        IncrementPrimaryKeyNo("ALID")

                                    End If

                                End If

                            Next

                            For Each objDataGridViewRow In dgvNewRooms.Rows 'for new rooms

                                .CommandText = "INSERT INTO REGISTRATION_DETAILS (REGDNO, REGDCHKINTIME, REGDCHKOUTTIME, REGDRMAMT, REGDSTAT, REGDNOGUEST, REGDNOOFEXTDAYS, RMNO, REGNO, REGDDAYSUPDATED) " & _
                                               "VALUES ('" & GetPrimaryKeyNo("RegistrationDetails") & "', '" & objDataGridViewRow.Cells(5).Value.ToString & "' , '" & objDataGridViewRow.Cells(6).Value.ToString & "' , '" & objDataGridViewRow.Cells(1).Value.ToString & "', 'REGISTERED', '" & objDataGridViewRow.Cells(3).Value.ToString & "' , '0', '" & objDataGridViewRow.Cells(0).Value.ToString & "', '" & lblRegistrationNumber.Text & "', '1');"
                                .ExecuteNonQuery()
                                .CommandText = "INSERT INTO FOLIO_DETAILS (FDNO, FDRECEIPTNO, FDDATE, FDCHARGE, FDMODIFIEDBYAMT, FDMODIFIEDBYPERCENT, FDMODIFIEDCHARGE, FDBALANCE, FDSTAT, REGNO, REGDNO, FDDESC, FDNAME) " & _
                                               "VALUES ('" & GetPrimaryKeyNo("FDNo") & "', '" & GetPrimaryKeyNo("FDNo") & "', '" & Now.ToShortDateString & "', '" & objDataGridViewRow.Cells(1).Value.ToString & "', '0', '0', '" & objDataGridViewRow.Cells(1).Value.ToString & "', '" & objDataGridViewRow.Cells(1).Value.ToString & "', 'UNPAID', '" & lblRegistrationNumber.Text & "', '" & GetPrimaryKeyNo("RegistrationDetails") & "', 'ROOM', 'ROOM CHARGES');"
                                .ExecuteNonQuery()
                                .CommandText = "INSERT INTO ACTIVITY_LOG (ALID, ALRESORREG, ALNATURE, ALOLDVAL, ALNEWVAL, ALTIMECHANGED, GNO, EID, REGNO, REGDNO) " & _
                                               "VALUES ('" & GetPrimaryKeyNo("ALID") & "', 'REGISTRATION', 'NEW ROOM', 'NEW', '" & objDataGridViewRow.Cells(0).Value.ToString & "', '" & Now.ToString & "', '" & lblRegistrationGNO.Text & "', '" & DatabaseUser & "', '" & lblRegistrationNumber.Text & "', '" & GetPrimaryKeyNo("RegistrationDetails") & "');"
                                .ExecuteNonQuery()
                                IncrementPrimaryKeyNo("ALID")
                                IncrementPrimaryKeyNo("RegistrationDetails")
                                IncrementPrimaryKeyNo("FDNo")
                                .CommandText = "INSERT INTO RMSTATUS (RMSID, RMSNAME, RMSSTARTTIME, RMSENDTIME, RMNO) " & _
                                               "VALUES ( '" & GetPrimaryKeyNo("RMStatus") & "' , 'REGISTERED', '" & objDataGridViewRow.Cells(5).Value.ToString & "' , '" & objDataGridViewRow.Cells(6).Value.ToString & "' , '" & objDataGridViewRow.Cells(0).Value.ToString & "' );"
                                .ExecuteNonQuery()
                                IncrementPrimaryKeyNo("RMStatus")
                                .CommandText = "UPDATE REGISTRATION SET REGAMT = REGAMT + " & CDbl(objDataGridViewRow.Cells(1).Value.ToString) & ", REGBALANCE = REGBALANCE + " & CDbl(objDataGridViewRow.Cells(1).Value.ToString) & "WHERE REGNO = " & lblRegistrationNumber.Text & ""
                                .ExecuteNonQuery()
                            Next

                            objTransaction.Commit()
                            Msg("1032")
                            ClearUpdateRegistration()
                            dgvRoomVacancySearch.DataSource = vbNull

                        Catch ex As Exception

                            objTransaction.Rollback()
                            Msg("1008", , "Saving Updates failed,transaction will be reset" & NWLN & ex.Message)
                            ClearUpdateRegistration()
                            dgvRoomVacancySearch.DataSource = vbNull

                        Finally

                            objReservationSaveConnection.Close()

                        End Try

                    End With

                End Using

            End Using

        End Using
    End Sub

    Private Sub frmUpdateRegistration_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        If lblRegistrationNumber.Text <> String.Empty Then

            Select Case Msg("1033", Button.YesNoCancel)
                Case ButtonClicked.Yes
                    UpdateSave()
                Case ButtonClicked.Cancel
                    e.Cancel = True
            End Select

        End If

    End Sub

    Private Sub lblClose_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblClose.LinkClicked

        Me.Close()

    End Sub

    Private Sub dgvRoomVacancySearch_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvRoomVacancySearch.DoubleClick
        btnAddRoom_Click(Nothing, Nothing)
    End Sub

#End Region
    
End Class