Option Explicit On
Option Strict On

Imports System.Data.SqlClient

' Programmer:   Howell Quindara
' Date:         March 18, 2007
' Title:        frmUpdateReservation
' Purpose:      This interface changes room information such as check out day and 
'               adds new room to the reservation of a guest
' Requirements: ->  (+)ACTIVITY_LOG (ALID, ALRESORREG, ALNATURE, ALOLDVAL, ALNEWVAL, ALTIMECHANGED, GNO, EID, RESNO)
'               ->  (+)RESERVATION_DETAILS (RESNO, RMNO, RESDTIMEIN, RESDTIMEOUT, RESDSTAT, RESDNODAYS, RESDBYREQUEST, RESDNOOCCUPANTS)
'               ->  (+)RMSTATUS (RMSID, RMSNAME, RMSSTARTTIME, RMSENDTIME, RMNO, RESNO)
'               ->  (*)RESERVATION (RESBALANCE, RESSTAT, RESNOROOM, RESAMT, RESNOOCCUPANTS, RESREMARKS)
'               ->  (*)RESERVATION_DETAILS (RESDTIMEIN, RESDTIMEOUT, RESDSTAT, RESDNODAYS, RESDBYREQUEST, RESDNOOCCUPANTS)
'               ->  (*)RMSTATUS (RMSSTAT)
'               ->  Reservation must not be cancelled
'               ->  Room to be reserved
' Results:      ->  New room is added to the reservation of the guest
'               ->  The information of the room reserved to the guest is changed
'               ->  A reservation is Cancelled

Public Class frmUpdateReservation

#Region "Declaration"

    Private objAdapter As SqlDataAdapter
    Private objTransaction As SqlTransaction
    Private objCommand As SqlCommand
    Private objReservedDataView As New DataView
    Private objRoomDataView As New DataView
    Private objDataView As New DataView
    Private objReservedDataSet As DataSet
    Private objDataSet As DataSet
    Private objDataTable As DataTable
    Private objDataRow As DataRow
    Private objDataGridViewRow As DataGridViewRow
    Private gstrReservedRoom() As String
    Private gstrRoomNo As String
    Private gstrRMSID As String
    Private gstrDownPayment As String
    Private gstrUpdatedRoom As String

#End Region

#Region "Guest Information"

    Private Sub lblReservationGIID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblReservationGIID.TextChanged

        If lblReservationGIID.Text <> "new" Then

            btnUpdateReservationSave.Enabled = True
            btnAddRoom.Enabled = True

            Using objDatabaseConnection As SqlConnection = SetUpConnection(DatabasePath, True)

                Try

                    objAdapter = New SqlDataAdapter("SELECT * " & _
                                                    "FROM GUEST_INFO " & _
                                                    "WHERE GIID = '" & lblReservationGIID.Text & "';", objDatabaseConnection)
                    objDataSet = SetUpDataSet(objAdapter, "qryguest")
                    radCompanyInfoNew.Checked = True
                    objDataRow = objDataSet.Tables("qryguest").Rows(0)

                    If objDataSet.Tables("qryguest").Rows.Count = 1 Then

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

                    End If

                    lblNameOfGuest.Text = txtGuestInfoFirstName.Text & " " & txtGuestInfoLastName.Text

                Catch ex As Exception

                    Msg("1008", , "An error occured while loading guest info")

                End Try

            End Using

        Else
            btnUpdateReservationSave.Enabled = False
            btnAddRoom.Enabled = False
        End If
    End Sub

#End Region

#Region "Reservation Information"

    Private Sub btnAddRoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddRoom.Click

        If dgvRoomVacancySearch.Rows.Count > 0 Then

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

            lblNumberOfOccupants.Text = "0"
            lblTotalAmount.Text = "0"

            For Each objDataGridViewRow In dgvGuestRooms.Rows

                lblNumberOfOccupants.Text = (CInt(lblNumberOfOccupants.Text) + CInt(objDataGridViewRow.Cells(3).Value.ToString())).ToString
                lblTotalAmount.Text = (CDbl(lblTotalAmount.Text) + (CDbl(objDataGridViewRow.Cells(1).Value.ToString()) * CDbl(objDataGridViewRow.Cells(4).Value.ToString()))).ToString("n")

            Next

        End If

    End Sub

    Private Sub btnRemoveRoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveRoom.Click
        'REMOVES A ROOM IN THE LIST OF THE GUEST'S ROOM

        If dgvGuestRooms.SelectedRows.Count > 0 Then

            Dim strRoomNo As String = String.Empty
            Dim ctr As Integer = 0
            Dim blnIsReservedRoom As Boolean = False

            For Each str As String In gstrReservedRoom

                If str = dgvGuestRooms.SelectedRows(0).Cells(0).Value.ToString Then
                    blnIsReservedRoom = True
                    Exit For
                End If

            Next

            If blnIsReservedRoom Then
                Dim blnDuplicate As Boolean = False

                For Each objDataGridViewRow In dgvCanceledRooms.Rows

                    If dgvGuestRooms.SelectedRows.Item(0).Cells(0).Value.ToString = objDataGridViewRow.Cells(0).Value.ToString Then
                        dgvGuestRooms.Rows.Remove(dgvGuestRooms.SelectedRows(0))
                        blnDuplicate = True
                        Exit For

                    End If

                Next

                If blnDuplicate = False Then
                    dgvCanceledRooms.Rows.Add(dgvGuestRooms.SelectedRows.Item(0).Cells(0).Value, dgvGuestRooms.SelectedRows.Item(0).Cells(1).Value, dgvGuestRooms.SelectedRows.Item(0).Cells(2).Value, dgvGuestRooms.SelectedRows.Item(0).Cells(3).Value, dgvGuestRooms.SelectedRows.Item(0).Cells(4).Value, dgvGuestRooms.SelectedRows.Item(0).Cells(5).Value, dgvGuestRooms.SelectedRows.Item(0).Cells(6).Value, dgvGuestRooms.SelectedRows.Item(0).Cells(7).Value, dgvGuestRooms.SelectedRows.Item(0).Cells(8).Value)
                    dgvGuestRooms.Rows.Remove(dgvGuestRooms.SelectedRows(0))
                End If

            Else
                dgvGuestRooms.Rows.Remove(dgvGuestRooms.SelectedRows(0))

                SearchRoomLoad(gstrRoomNo)

            End If

            lblNumberOfRooms.Text = CStr(dgvGuestRooms.Rows.Count)
            lblNumberOfOccupants.Text = "0"
            lblTotalAmount.Text = "0"

            For Each objDataGridViewRow In dgvGuestRooms.Rows
                lblNumberOfOccupants.Text = (CInt(lblNumberOfOccupants.Text) + CInt(objDataGridViewRow.Cells(3).Value.ToString())).ToString
                lblTotalAmount.Text = (CDbl(lblTotalAmount.Text) + (CDbl(objDataGridViewRow.Cells(1).Value.ToString()) * CDbl(objDataGridViewRow.Cells(4).Value.ToString()))).ToString("n")
            Next

            frmParent.tssStatus.Text = "Room removed successfully"
        End If

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

        If lblResourceLocator.Text <> String.Empty Then

            If Msg("1037", Button.YesNo) = ButtonClicked.Yes Then

                ClearUpdateReservation()

            End If

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

    Private Sub AddRoomToList()
        'USE TO ADD THE ROOM SELECTED TO THE GUEST ROOM

        '"SELECT RESERVATION_DETAILS.RMNo, RMRATE.RMRAmt, ROOM.RMType, RESERVATION_DETAILS.ResDNoOccupants, RESERVATION_DETAILS.ResDNoDays, RESERVATION_DETAILS.ResDTimeIn, RESERVATION_DETAILS.ResDTimeOut, RESERVATION_DETAILS.ResDByRequest, RMSTATUS.RMSID " & _
        '"FROM RESERVATION_DETAILS INNER JOIN RMRATE_DETAILS ON RESERVATION_DETAILS.RMNo = RMRATE_DETAILS.RMNo INNER JOIN RMRATE ON RMRATE_DETAILS.RMRID = RMRATE.RMRID INNER JOIN ROOM ON RESERVATION_DETAILS.RMNo = ROOM.RMNo INNER JOIN RMSTATUS ON RESERVATION_DETAILS.RMNo = RMSTATUS.RMNo AND RESERVATION_DETAILS.ResDTimeIn = RMSTATUS.RMSStartTime AND RESERVATION_DETAILS.ResDTimeIn = RMSTATUS.RMSStartTime And RESERVATION_DETAILS.ResDTimeOut <= RMSTATUS.RMSEndTime " & _
        '"WHERE (RESERVATION_DETAILS.ResNo = '" & lblResourceLocator.Text & "') AND (RMRATE_DETAILS.RMDActive = 'TRUE') AND (RMSTATUS.RMSStat IS NULL)", objDatabaseConnection)

        dgvGuestRooms.Rows.Add(lblRoomNumber.Text, lblRoomRate.Text, dgvRoomVacancySearch.SelectedRows.Item(0).Cells(2).Value.ToString, txtNoOfOccupants.Text, lblNumberOfNights.Text, dtpCheckInDate.Value.Date & " " & dtpCheckInTime.Value.ToShortTimeString, dtpCheckOutDate.Value.Date & " " & dtpCheckOutTime.Value.ToShortTimeString, chkRoomByRequest.Checked)
        dgvRoomVacancySearch.Rows.Remove(dgvRoomVacancySearch.SelectedRows(0))

        lblNumberOfRooms.Text = CStr(dgvGuestRooms.Rows.Count)
        lblNumberOfOccupants.Text = "0"
        lblTotalAmount.Text = "0"

        For Each objDataGridViewRow In dgvGuestRooms.Rows
            lblNumberOfOccupants.Text = (CInt(lblNumberOfOccupants.Text) + CInt(objDataGridViewRow.Cells(3).Value.ToString())).ToString
            lblTotalAmount.Text = (CDbl(lblTotalAmount.Text) + (CDbl(objDataGridViewRow.Cells(1).Value.ToString()) * CDbl(objDataGridViewRow.Cells(4).Value.ToString()))).ToString("n")
        Next


    End Sub

    Private Sub lblResourceLocator_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblResourceLocator.TextChanged

        Dim strReservedRoom As String = String.Empty
        gstrRoomNo = String.Empty
        Dim ctr As Integer = 0

        If lblResourceLocator.Text <> String.Empty Then

            If ActiveReservation(lblResourceLocator.Text.ToString) = False Then

                Msg("1097")
                lblResourceLocator.Text = String.Empty

            Else

                dgvCanceledRooms.Rows.Clear()
                dgvGuestRooms.Rows.Clear()

                Using objDatabaseConnection As SqlConnection = SetUpConnection(DatabasePath, True)

                    Try

                        objAdapter = New SqlDataAdapter("SELECT RESERVATION_DETAILS.RMNo, RMRATE.RMRAmt, ROOM.RMType, RESERVATION_DETAILS.ResDNoOccupants, RESERVATION_DETAILS.ResDNoDays, RESERVATION_DETAILS.ResDTimeIn, RESERVATION_DETAILS.ResDTimeOut, RESERVATION_DETAILS.ResDByRequest, RMSTATUS.RMSID " & _
                                                        "FROM RESERVATION_DETAILS INNER JOIN RMRATE_DETAILS ON RESERVATION_DETAILS.RMNo = RMRATE_DETAILS.RMNo INNER JOIN RMRATE ON RMRATE_DETAILS.RMRID = RMRATE.RMRID INNER JOIN ROOM ON RESERVATION_DETAILS.RMNo = ROOM.RMNo INNER JOIN RMSTATUS ON RESERVATION_DETAILS.RMNo = RMSTATUS.RMNo AND RESERVATION_DETAILS.ResDTimeIn = RMSTATUS.RMSStartTime AND RESERVATION_DETAILS.ResDTimeIn = RMSTATUS.RMSStartTime And RESERVATION_DETAILS.ResDTimeOut <= RMSTATUS.RMSEndTime " & _
                                                        "WHERE (RESERVATION_DETAILS.ResNo = '" & lblResourceLocator.Text & "') AND (RMRATE_DETAILS.RMDActive = 'TRUE') AND (RMSTATUS.RMSStat IS NULL)", objDatabaseConnection)
                        objReservedDataSet = SetUpDataSet(objAdapter, "qryUpdateReservationSearch")
                        objReservedDataView = New DataView(objReservedDataSet.Tables("qryUpdateReservationSearch"))

                        lblNumberOfOccupants.Text = "0"
                        lblTotalAmount.Text = "0"

                        For Each objDataRow In objReservedDataView.Table.Rows

                            dgvGuestRooms.Rows.Add(objDataRow.Item(0).ToString, CDbl(objDataRow.Item(1).ToString).ToString("n"), objDataRow.Item(2).ToString, objDataRow.Item(3).ToString, objDataRow.Item(4).ToString, objDataRow.Item(5).ToString, objDataRow.Item(6).ToString, objDataRow.Item(7).ToString, objDataRow.Item(8).ToString)
                            lblNumberOfOccupants.Text = (CInt(lblNumberOfOccupants.Text) + CInt(objDataRow.Item(3).ToString)).ToString
                            lblTotalAmount.Text = (CDbl(lblTotalAmount.Text) + (CDbl(objDataRow.Item(1).ToString) * CDbl(objDataRow.Item(4).ToString))).ToString("n")

                        Next

                        For Each objDataGridViewRow In dgvGuestRooms.Rows

                            If dgvGuestRooms.Rows.Count - 1 = ctr Then

                                strReservedRoom = strReservedRoom & objDataGridViewRow.Cells(0).Value.ToString
                                gstrRoomNo = gstrRoomNo & "'" & objDataGridViewRow.Cells(0).Value.ToString & "'"
                                gstrRMSID = gstrRMSID & "'" & objDataGridViewRow.Cells(8).Value.ToString & "'"

                            Else

                                strReservedRoom = strReservedRoom & objDataGridViewRow.Cells(0).Value.ToString & ","
                                gstrRoomNo = gstrRoomNo & "'" & objDataGridViewRow.Cells(0).Value.ToString & "'" & ","
                                gstrRMSID = gstrRMSID & "'" & objDataGridViewRow.Cells(0).Value.ToString & "'" & ","

                            End If

                            ctr += 1

                        Next

                        gstrReservedRoom = Split(strReservedRoom, ",")

                    Catch ex As Exception

                        Msg("1008", , NWLN & "An error occured while loading the reserved rooms" & NWLN & ex.Message)
                        ClearUpdateReservation()

                    End Try

                    Try

                        'CODE BY JEFF Remarks:
                        objAdapter = New SqlDataAdapter("SELECT GUEST.GIID " & _
                                                        "FROM GUEST INNER JOIN RESERVATION ON GUEST.GNo = RESERVATION.GNo " & _
                                                        "WHERE (RESERVATION.ResNo = '" & lblResourceLocator.Text & "')", objDatabaseConnection)
                        objDataSet = SetUpDataSet(objAdapter, "qryGuestID")
                        objDataRow = objDataSet.Tables("qryGuestID").Rows(0)
                        lblReservationGIID.Text = objDataRow.Item(0).ToString

                        objAdapter = New SqlDataAdapter("SELECT ResRemarks FROM RESERVATION WHERE ResNo='" & lblResourceLocator.Text & "'", objDatabaseConnection)
                        objDataSet = SetUpDataSet(objAdapter, "Remarks")
                        objDataRow = objDataSet.Tables("Remarks").Rows(0)
                        txtRemarks.Text = objDataRow.Item(0).ToString

                        '----

                    Catch ex As Exception

                        Msg("1008", , NWLN & "An error occured while loading the guest id" & NWLN & ex.Message)
                        ClearUpdateReservation()

                    End Try

                    Try

                        objAdapter = New SqlDataAdapter("SELECT  ResNoOccupants, ResNoRoom, ResAmt, ResDownPay " & _
                                                        "FROM RESERVATION " & _
                                                        "WHERE (RESERVATION.ResNo = '" & lblResourceLocator.Text & "')", objDatabaseConnection)
                        objDataSet = SetUpDataSet(objAdapter, "qryResno")
                        objDataRow = objDataSet.Tables("qryResno").Rows(0)
                        lblNumberOfOccupants.Text = objDataRow.Item(0).ToString
                        lblNumberOfRooms.Text = objDataRow.Item(1).ToString
                        lblTotalAmount.Text = objDataRow.Item(2).ToString
                        gstrDownPayment = objDataRow.Item(3).ToString

                    Catch ex As Exception

                        Msg("1008", , NWLN & "An error occured while loading the reservation information" & NWLN & ex.Message)
                        ClearUpdateReservation()

                    End Try


                End Using

                lblNumberOfOccupants.Text = "0"
                lblTotalAmount.Text = "0"

                For Each objDataGridViewRow In dgvGuestRooms.Rows
                    lblNumberOfOccupants.Text = (CInt(lblNumberOfOccupants.Text) + CInt(objDataGridViewRow.Cells(3).Value.ToString())).ToString
                    lblTotalAmount.Text = (CDbl(lblTotalAmount.Text) + (CDbl(objDataGridViewRow.Cells(1).Value.ToString()) * CDbl(objDataGridViewRow.Cells(4).Value.ToString()))).ToString("n")
                Next

                SearchRoomLoad(gstrRoomNo)
                btnAddRoom.Enabled = True
                btnUpdateReservationSave.Enabled = True
                btnCancelReservation.Enabled = True

            End If

        Else
            ClearControls(grpGuestInformation)
            ClearControls(pnlCompanyGroupInformation)
            lblNameOfGuest.Text = String.Empty
            lblReservationGIID.Text = "new"
            btnAddRoom.Enabled = False
            btnUpdateReservationSave.Enabled = False
            btnCancelReservation.Enabled = False

        End If

    End Sub

    Private Sub btnReturnRoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReturnRoom.Click

        If dgvCanceledRooms.Rows.Count > 0 Then

            For Each objDataGridViewRow In dgvGuestRooms.Rows

                If dgvCanceledRooms.SelectedRows.Item(0).Cells(0).Value.ToString = objDataGridViewRow.Cells(0).Value.ToString Then

                    Msg("1002", Button.Ok, "Room already in the list")
                    Exit Sub

                End If

            Next

            If dgvCanceledRooms.Rows.Count > 0 Then
                dgvGuestRooms.Rows.Add(dgvCanceledRooms.SelectedRows.Item(0).Cells(0).Value, dgvCanceledRooms.SelectedRows.Item(0).Cells(1).Value, dgvCanceledRooms.SelectedRows.Item(0).Cells(2).Value, dgvCanceledRooms.SelectedRows.Item(0).Cells(3).Value, dgvCanceledRooms.SelectedRows.Item(0).Cells(4).Value, dgvCanceledRooms.SelectedRows.Item(0).Cells(5).Value, dgvCanceledRooms.SelectedRows.Item(0).Cells(6).Value, dgvCanceledRooms.SelectedRows.Item(0).Cells(7).Value, dgvCanceledRooms.SelectedRows.Item(0).Cells(8).Value)
                dgvCanceledRooms.Rows.Remove(dgvCanceledRooms.SelectedRows(0))
            End If

            lblNumberOfOccupants.Text = "0"
            lblTotalAmount.Text = "0"

            For Each objDataGridViewRow In dgvGuestRooms.Rows
                lblNumberOfOccupants.Text = (CInt(lblNumberOfOccupants.Text) + CInt(objDataGridViewRow.Cells(3).Value.ToString())).ToString
                lblTotalAmount.Text = (CDbl(lblTotalAmount.Text) + (CDbl(objDataGridViewRow.Cells(1).Value.ToString()) * CDbl(objDataGridViewRow.Cells(4).Value.ToString()))).ToString("n")
            Next

        End If

    End Sub

    Private Sub btnEditRoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditRoom.Click

        If dgvGuestRooms.SelectedRows.Count > 0 Then
            Dim strRoomInfo As String = getRoomInfo(dgvGuestRooms.Rows(dgvGuestRooms.SelectedRows(0).Index), "Res")
            FormToEdit = EditRoom.UpdateReservation
            EditRoomFrom(strRoomInfo)
        End If

    End Sub

    Private Sub dgvRoomVacancySearch_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvRoomVacancySearch.SelectionChanged

        If dgvRoomVacancySearch.SelectedRows.Count > 0 Then
            txtNoOfOccupants.Text = dgvRoomVacancySearch.SelectedRows.Item(0).Cells(3).Value.ToString
            lblRoomNumber.Text = dgvRoomVacancySearch.SelectedRows.Item(0).Cells(0).Value.ToString
            lblRoomRate.Text = CDbl(dgvRoomVacancySearch.SelectedRows.Item(0).Cells(2).Value.ToString).ToString("n")
        End If

    End Sub

#End Region

#Region "Other"

    Public Sub FillMe()
        lblResourceLocator.Text = SearchedReservationNo
    End Sub

    Private Sub tsbGuestSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuestSearch.Click
        'OPENS THE GUEST SEARCH FORM

        TriggeredBy = TriggeringForm.UpdateReservation
        frmGuestSearch.ShowDialog()

    End Sub

    Private Sub tsbReservation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbReservation.Click
        'OPENS THE UPDATE RESERVATION FORM

        'frmReservation.MdiParent = frmParent
        Display(Forms.frmReservation)

    End Sub

    Private Sub tsbPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbPayment.Click
        Display(Forms.frmPayment)

    End Sub

    Private Sub frmUpdateReservation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        tbcUpdateReservation.SelectedIndex = 1
        LoadComboBox(cboGuestInfoCountry, cboGuestInfoCivilStatus, cboRoomType, cboFloor, cboView, cbo)
        lblReservationGNO.Text = GetPreKeyGen("Guest") & GetPrimaryKeyNo("Guest")

        dtpCheckInDate.Value = Now.Date
        dtpCheckOutDate.Value = dtpCheckInDate.Value.AddDays(1)
        dtpCheckOutDate.MinDate = dtpCheckInDate.Value.Date

    End Sub

    Private Sub llbClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles llbClose.Click
        'CLOSES THE FORM AND OPENS THE MAIN FORM

        Me.Close()

    End Sub

    Private Sub chkRoomByRequest_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRoomByRequest.CheckedChanged
        'USE TO IDENTIFY IF THE ROOM IS REQUESTED BY THE GUEST OR NOT

        If chkRoomByRequest.Checked Then
            chkRoomByRequest.Tag = "Yes"
        Else
            chkRoomByRequest.Tag = "No"
        End If
    End Sub

    Private Sub SearchRoomLoad(ByVal strRoomNo As String)

        objRoomDataView = SearchRoom(dtpCheckInDate.Value.Date & " " & dtpCheckInTime.Value.ToLongTimeString, dtpCheckOutDate.Value.Date & " " & dtpCheckOutTime.Value.ToLongTimeString, "res")
        dgvRoomVacancySearch.DataSource = objRoomDataView

        If strRoomNo <> String.Empty Then

            objRoomDataView.RowFilter = "[Room Number]NOT IN (" & strRoomNo & ")"
            dgvRoomVacancySearch.Sort(dgvRoomVacancySearch.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
            lblSearchResult.Text = dgvRoomVacancySearch.RowCount.ToString

        End If
    End Sub

    Private Sub btnCancelReservation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelReservation.Click

        cancelReservation()

    End Sub

    Private Sub btnUpdateReservationSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateReservationSave.Click

        If lblNumberOfRooms.Text = "0" Then

            cancelReservation()

        Else

            UpdateSave()

        End If

    End Sub

    Private Sub ClearUpdateReservation()

        SearchRoomLoad(gstrRoomNo)
        ClearControls(gbxRoomReservaionDetails, dtpCheckOutDate, dtpCheckInDate, dtpCheckInTime, dtpCheckOutTime, lblNumberOfNights)
        lblNumberOfOccupants.Text = "0"
        lblTotalAmount.Text = "0"
        lblNumberOfRooms.Text = "0"
        dgvGuestRooms.Rows.Clear()
        dgvCanceledRooms.Rows.Clear()
        lblResourceLocator.Text = String.Empty

    End Sub

    Public Sub UpdateRoomInfo(ByVal strRoomInfo As String)
        Dim strInfo() As String
        Dim strNoOfOccupants As String = dgvGuestRooms.SelectedRows.Item(0).Cells(3).Value.ToString
        Dim strNoOfNights As String = dgvGuestRooms.SelectedRows.Item(0).Cells(4).Value.ToString
        Dim strcheckin As String = dgvGuestRooms.SelectedRows.Item(0).Cells(5).Value.ToString
        Dim strCheckout As String = dgvGuestRooms.SelectedRows.Item(0).Cells(6).Value.ToString
        Dim strRoomRequest As String = dgvGuestRooms.SelectedRows.Item(0).Cells(7).Value.ToString

        strInfo = Split(strRoomInfo, "|")

        If strInfo(1) <> strNoOfOccupants Or strInfo(2) <> strNoOfNights Or strInfo(3) <> strcheckin Or strInfo(4) <> strCheckout Or strInfo(5) <> strRoomRequest Then
            dgvGuestRooms.SelectedRows.Item(0).Cells(3).Value = strInfo(1) 'number of occupants
            dgvGuestRooms.SelectedRows.Item(0).Cells(4).Value = strInfo(2) 'number of nights
            dgvGuestRooms.SelectedRows.Item(0).Cells(5).Value = strInfo(3) 'number of nights
            dgvGuestRooms.SelectedRows.Item(0).Cells(6).Value = strInfo(4) 'check out
            dgvGuestRooms.SelectedRows.Item(0).Cells(7).Value = strInfo(5) 'number of nights
            gstrUpdatedRoom = gstrUpdatedRoom & "|" & strInfo(0)
        End If

    End Sub

    Private Sub btnViewDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewDetails.Click
        Display(Forms.frmRoomRack)
    End Sub

    Private Sub cancelReservation()

        ' add more update here for the rmstatus
        Dim strUpdateReservation As String = "UPDATE RESERVATION SET " & _
                                             "RESBALANCE = 0 ," & _
                                             "RESSTAT = 'CANCELLED' " & _
                                             "WHERE RESNO = '" & lblResourceLocator.Text & "';"
        Dim strUpdateReservationDetails As String = "UPDATE RESERVATION_DETAILS SET RESDSTAT = 'CANCELLED' " & _
                                                    "WHERE RESNO = '" & lblResourceLocator.Text & "';"

        If Msg("1098", Button.YesNo) = ButtonClicked.Yes Then

            Using objCancelReservationConnection As SqlConnection = SetUpConnection(DatabasePath, True)

                If objCancelReservationConnection.State = ConnectionState.Closed Then objCancelReservationConnection.Open()

                Using objTransaction As SqlTransaction = objCancelReservationConnection.BeginTransaction

                    Using objCommand As SqlCommand = objCancelReservationConnection.CreateCommand

                        With objCommand
                            .Transaction = objTransaction

                            Try
                                .CommandText = strUpdateReservation
                                .ExecuteNonQuery()
                                .CommandText = strUpdateReservationDetails
                                .ExecuteNonQuery()
                                .CommandText = "UPDATE RMSTATUS SET RMSSTAT = 'CANCELLED' " & _
                                               "WHERE RESNO = '" & lblResourceLocator.Text & "';"
                                .ExecuteNonQuery()
                                .CommandText = "INSERT INTO ACTIVITY_LOG (ALID, ALRESORREG, ALNATURE, ALOLDVAL, ALNEWVAL, ALTIMECHANGED, GNO, EID, RESNO) " & _
                                               "VALUES ('" & GetPrimaryKeyNo("ALID") & "', 'RESERVATION', 'CANCELATION OF RESERVATION', 'RESERVED', 'CANCELLED', '" & Now.ToString & "', '" & lblReservationGNO.Text & "', '" & DatabaseUser & "', '" & lblResourceLocator.Text & "');"
                                .ExecuteNonQuery()
                                IncrementPrimaryKeyNo("ALID")

                                objTransaction.Commit()
                                Msg("1032")
                                ClearUpdateReservation()

                            Catch ex As Exception

                                objTransaction.Rollback()
                                Msg("1008", , "Saving Updates failed,transaction will be reset" & NWLN & ex.Message)
                                ClearUpdateReservation()

                            End Try

                        End With

                    End Using

                End Using

            End Using

        End If

    End Sub

    Private Sub dgvGuestRooms_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvGuestRooms.CellValueChanged

        lblNumberOfOccupants.Text = "0"
        lblTotalAmount.Text = "0"

        For Each objDataGridViewRow In dgvGuestRooms.Rows
            lblNumberOfOccupants.Text = (CInt(lblNumberOfOccupants.Text) + CInt(objDataGridViewRow.Cells(3).Value.ToString())).ToString
            lblTotalAmount.Text = (CDbl(lblTotalAmount.Text) + (CDbl(objDataGridViewRow.Cells(1).Value.ToString()) * CDbl(objDataGridViewRow.Cells(4).Value.ToString()))).ToString("n")
        Next

    End Sub

    Private Sub UpdateSave()
        Dim strUpdatedRoom() As String
        Dim blnInList As Boolean = False
        Dim strUpdateReservation As String = "UPDATE RESERVATION SET " & _
                                             "RESNOROOM = '" & lblNumberOfRooms.Text & "' ," & _
                                             "RESAMT = '" & lblTotalAmount.Text & "' ," & _
                                             "RESBALANCE = '" & (CDbl(lblTotalAmount.Text) - CDbl(gstrDownPayment)).ToString & "' ," & _
                                             "RESNOOCCUPANTS =  '" & lblNumberOfOccupants.Text & "' ," & _
                                             "RESREMARKS = '" & txtRemarks.Text & "' " & _
                                             "WHERE RESNO = '" & lblResourceLocator.Text & "';"

        strUpdatedRoom = Split(gstrUpdatedRoom, "|")

        Using objCancelReservationConnection As SqlConnection = SetUpConnection(DatabasePath, True)

            If objCancelReservationConnection.State = ConnectionState.Closed Then objCancelReservationConnection.Open()

            Using objTransaction As SqlTransaction = objCancelReservationConnection.BeginTransaction

                Using objCommand As SqlCommand = objCancelReservationConnection.CreateCommand

                    With objCommand
                        .Transaction = objTransaction

                        Try

                            For Each objDataGridViewRow In dgvGuestRooms.Rows

                                Dim blnIsReservedRoom As Boolean = False

                                'gets the value true if the room is reserved before and false if newly added
                                For Each str As String In gstrReservedRoom
                                    If str = objDataGridViewRow.Cells(0).Value.ToString Then
                                        blnIsReservedRoom = True
                                        Exit For
                                    End If

                                Next

                                If blnIsReservedRoom Then
                                    'updates will be done here

                                    .CommandText = "SELECT  ResDTimeIn, ResDTimeOut, ResDNoDays, ResDByRequest, ResDNoOccupants FROM RESERVATION_DETAILS " & _
                                                   "WHERE (RESNO = '" & lblResourceLocator.Text & "') AND (RMNO = '" & objDataGridViewRow.Cells(0).Value.ToString & "');"
                                    objAdapter = New SqlDataAdapter(objCommand)
                                    objDataSet = SetUpDataSet(objAdapter, "qryRoomInfo")
                                    objDataTable = objDataSet.Tables("qryRoomInfo")

                                    For Each str As String In strUpdatedRoom
                                        blnInList = False
                                        If str = objDataGridViewRow.Cells(0).Value.ToString Then
                                            blnInList = True
                                            Exit For
                                        End If
                                    Next


                                    If blnInList Then 'update the room in the list

                                        'changes in checkin time
                                        If objDataSet.Tables("qryRoomInfo").Rows(0).Item(0).ToString <> objDataGridViewRow.Cells(6).Value.ToString Then

                                            .CommandText = "UPDATE RMSTATUS SET RMSSTARTTIME = '" & objDataGridViewRow.Cells(5).Value.ToString & "' " & _
                                                           "WHERE RMSID = '" & objDataGridViewRow.Cells(8).Value.ToString & "';"
                                            .ExecuteNonQuery()
                                            .CommandText = "UPDATE RESERVATION_DETAILS SET RESDTIMEIN = '" & objDataGridViewRow.Cells(5).Value.ToString & "' " & _
                                                           "WHERE (RESNO = '" & lblResourceLocator.Text & "') AND (RMNO = '" & objDataGridViewRow.Cells(0).Value.ToString & "');"
                                            .ExecuteNonQuery()
                                            .CommandText = "INSERT INTO ACTIVITY_LOG (ALID, ALRESORREG, ALNATURE, ALOLDVAL, ALNEWVAL, ALTIMECHANGED, GNO, EID, RESNO)" & _
                                                           "VALUES ('" & GetPrimaryKeyNo("ALID") & "', 'RESERVATION', 'TIME IN CHANGE', '" & objDataSet.Tables("qryRoomInfo").Rows(0).Item(0).ToString & "', '" & objDataGridViewRow.Cells(5).Value.ToString & "', '" & Now.ToString & "', '" & lblReservationGNO.Text & "', '" & DatabaseUser & "', '" & lblResourceLocator.Text & "');"
                                            .ExecuteNonQuery()
                                            IncrementPrimaryKeyNo("ALID")
                                        End If

                                        'changes in checkout time
                                        If objDataSet.Tables("qryRoomInfo").Rows(0).Item(1).ToString <> objDataGridViewRow.Cells(5).Value.ToString Then 'changes in checkin time

                                            .CommandText = "UPDATE RMSTATUS SET RMSENDTIME = '" & objDataGridViewRow.Cells(6).Value.ToString & "' " & _
                                                           "WHERE RMSID = '" & objDataGridViewRow.Cells(8).Value.ToString & "';"
                                            .ExecuteNonQuery()
                                            .CommandText = "UPDATE RESERVATION_DETAILS SET RESDTIMEOUT = '" & objDataGridViewRow.Cells(6).Value.ToString & "' " & _
                                                           "WHERE (RESNO = '" & lblResourceLocator.Text & "') AND (RMNO = '" & objDataGridViewRow.Cells(0).Value.ToString & "');"
                                            .ExecuteNonQuery()
                                            .CommandText = "INSERT INTO ACTIVITY_LOG (ALID, ALRESORREG, ALNATURE, ALOLDVAL, ALNEWVAL, ALTIMECHANGED, GNO, EID, RESNO)" & _
                                                           "VALUES ('" & GetPrimaryKeyNo("ALID") & "', 'RESERVATION', 'TIME OUT CHANGE', '" & objDataSet.Tables("qryRoomInfo").Rows(0).Item(1).ToString & "', '" & objDataGridViewRow.Cells(6).Value.ToString & "', '" & Now.ToString & "', '" & lblReservationGNO.Text & "', '" & DatabaseUser & "', '" & lblResourceLocator.Text & "');"
                                            .ExecuteNonQuery()
                                            IncrementPrimaryKeyNo("ALID")
                                        End If

                                        'changes in no of days
                                        If objDataSet.Tables("qryRoomInfo").Rows(0).Item(2).ToString <> objDataGridViewRow.Cells(4).Value.ToString Then

                                            .CommandText = "UPDATE RESERVATION_DETAILS SET RESDNODAYS = '" & objDataGridViewRow.Cells(4).Value.ToString & "' " & _
                                                           "WHERE (RESNO = '" & lblResourceLocator.Text & "') AND (RMNO = '" & objDataGridViewRow.Cells(0).Value.ToString & "');"
                                            .ExecuteNonQuery()
                                            .CommandText = "INSERT INTO ACTIVITY_LOG (ALID, ALRESORREG, ALNATURE, ALOLDVAL, ALNEWVAL, ALTIMECHANGED, GNO, EID, RESNO)" & _
                                                           "VALUES ('" & GetPrimaryKeyNo("ALID") & "', 'RESERVATION', 'NUMBER OF DAYS', '" & objDataSet.Tables("qryRoomInfo").Rows(0).Item(2).ToString & "', '" & objDataGridViewRow.Cells(4).Value.ToString & "' , '" & Now.ToString & "' , '" & lblReservationGNO.Text & "', '" & DatabaseUser & "', '" & lblResourceLocator.Text & "');"
                                            .ExecuteNonQuery()
                                            IncrementPrimaryKeyNo("ALID")
                                        End If

                                        'changes in room request
                                        If objDataSet.Tables("qryRoomInfo").Rows(0).Item(3).ToString <> objDataGridViewRow.Cells(7).Value.ToString Then

                                            .CommandText = "UPDATE RESERVATION_DETAILS SET RESDBYREQUEST = '" & objDataGridViewRow.Cells(7).Value.ToString & "' " & _
                                                           "WHERE (RESNO = '" & lblResourceLocator.Text & "') AND (RMNO = '" & objDataGridViewRow.Cells(0).Value.ToString & "');"
                                            .ExecuteNonQuery()
                                            .CommandText = "INSERT INTO ACTIVITY_LOG (ALID, ALRESORREG, ALNATURE, ALOLDVAL, ALNEWVAL, ALTIMECHANGED, GNO, EID, RESNO)" & _
                                                           "VALUES ('" & GetPrimaryKeyNo("ALID") & "', 'RESERVATION', 'ROOM BY REQUEST', '" & objDataSet.Tables("qryRoomInfo").Rows(0).Item(3).ToString & "', '" & objDataGridViewRow.Cells(7).Value.ToString & "' , '" & Now.ToString & "' , '" & lblReservationGNO.Text & "', '" & DatabaseUser & "', '" & lblResourceLocator.Text & "');"
                                            .ExecuteNonQuery()
                                            IncrementPrimaryKeyNo("ALID")
                                        End If

                                        'changes in occupants
                                        If objDataSet.Tables("qryRoomInfo").Rows(0).Item(4).ToString <> objDataGridViewRow.Cells(3).Value.ToString Then

                                            .CommandText = "UPDATE RESERVATION_DETAILS SET RESDNOOCCUPANTS = '" & objDataGridViewRow.Cells(3).Value.ToString & "' " & _
                                                           "WHERE (RESNO = '" & lblResourceLocator.Text & "') AND (RMNO = '" & objDataGridViewRow.Cells(0).Value.ToString & "');"
                                            .ExecuteNonQuery()
                                            .CommandText = "INSERT INTO ACTIVITY_LOG (ALID, ALRESORREG, ALNATURE, ALOLDVAL, ALNEWVAL, ALTIMECHANGED, GNO, EID, RESNO)" & _
                                                           "VALUES ('" & GetPrimaryKeyNo("ALID") & "', 'RESERVATION', 'OCCUPANTS', '" & objDataSet.Tables("qryRoomInfo").Rows(0).Item(4).ToString & "', '" & objDataGridViewRow.Cells(3).Value.ToString & "' , '" & Now.ToString & "' , '" & lblReservationGNO.Text & "', '" & DatabaseUser & "', '" & lblResourceLocator.Text & "');"
                                            .ExecuteNonQuery()
                                            IncrementPrimaryKeyNo("ALID")
                                        End If

                                    End If

                                Else ' add new room in the reservation
                                    .CommandText = "INSERT INTO RESERVATION_DETAILS (RESNO, RMNO, RESDTIMEIN, RESDTIMEOUT, RESDSTAT, RESDNODAYS, RESDBYREQUEST, RESDNOOCCUPANTS) " & _
                                                   "VALUES ('" & lblResourceLocator.Text & "', '" & objDataGridViewRow.Cells(0).Value.ToString & "' , '" & objDataGridViewRow.Cells(5).Value.ToString & "' , '" & objDataGridViewRow.Cells(6).Value.ToString & "' , 'RESERVED', '" & objDataGridViewRow.Cells(4).Value.ToString & "' , '" & chkRoomByRequest.Checked & "' , '" & objDataGridViewRow.Cells(3).Value.ToString & "' );"
                                    .ExecuteNonQuery()
                                    .CommandText = "INSERT INTO RMSTATUS (RMSID, RMSNAME, RMSSTARTTIME, RMSENDTIME, RMNO, RESNO) " & _
                                                  "VALUES ( '" & GetPrimaryKeyNo("RMStatus") & "' , 'RESERVED', '" & objDataGridViewRow.Cells(5).Value.ToString & "' , '" & objDataGridViewRow.Cells(6).Value.ToString & "' , '" & objDataGridViewRow.Cells(0).Value.ToString & "','" & lblResourceLocator.Text & "');"
                                    .ExecuteNonQuery()
                                    IncrementPrimaryKeyNo("RMStatus")
                                    .CommandText = "INSERT INTO ACTIVITY_LOG (ALID, ALRESORREG, ALNATURE, ALOLDVAL, ALNEWVAL, ALTIMECHANGED, GNO, EID, RESNO) " & _
                                                   "VALUES ('" & GetPrimaryKeyNo("ALID") & "', 'RESERVATION', 'NEW ROOM', 'NEW', '" & objDataGridViewRow.Cells(0).Value.ToString & "', '" & Now.ToString & "', '" & lblReservationGNO.Text & "', '" & DatabaseUser & "', '" & lblResourceLocator.Text & "');"
                                    .ExecuteNonQuery()
                                    IncrementPrimaryKeyNo("ALID")
                                End If

                            Next

                            If dgvCanceledRooms.RowCount > 0 Then
                                ' cancel all the room in the canceled rooms list
                                For Each objDataGridViewRow In dgvCanceledRooms.Rows
                                    .CommandText = "UPDATE RESERVATION_DETAILS SET RESDSTAT = 'CANCELLED' " & _
                                                   "WHERE (RESNO = '" & lblResourceLocator.Text & "') AND (RMNO = '" & objDataGridViewRow.Cells(0).Value.ToString & "') ;"
                                    .ExecuteNonQuery()
                                    .CommandText = "UPDATE RMSTATUS SET RMSSTAT = 'CANCELLED' " & _
                                                   "WHERE RMSID = '" & objDataGridViewRow.Cells(8).Value.ToString & "';"
                                    .ExecuteNonQuery()
                                    .CommandText = "INSERT INTO ACTIVITY_LOG (ALID, ALRESORREG, ALNATURE, ALOLDVAL, ALNEWVAL, ALTIMECHANGED, GNO, EID, RESNO) " & _
                                                   "VALUES ('" & GetPrimaryKeyNo("ALID") & "', 'RESERVATION', 'CANCELATION OF A ROOM', 'RESERVED', 'CANCELLED', '" & Now.ToString & "', '" & lblReservationGNO.Text & "', '" & DatabaseUser & "', '" & lblResourceLocator.Text & "');"
                                    .ExecuteNonQuery()
                                    IncrementPrimaryKeyNo("ALID")
                                Next

                            End If

                            .CommandText = strUpdateReservation
                            .ExecuteNonQuery()

                            objTransaction.Commit()
                            Msg("1032")
                            ClearUpdateReservation()

                        Catch ex As Exception

                            objTransaction.Rollback()
                            Msg("1008", , "Saving Updates failed,transaction will be reset" & NWLN & ex.Message)
                            ClearUpdateReservation()

                        End Try

                    End With

                End Using

            End Using

        End Using
    End Sub

    Public Function ActiveReservation(ByVal strResno As String) As Boolean

        Using objDatabaseConnection As SqlConnection = SetUpConnection(DatabasePath, True)

            Try

                objAdapter = New SqlDataAdapter("SELECT ResStat FROM RESERVATION " & _
                                                "WHERE (ResNo = '" & strResno & "')", objDatabaseConnection)
                objDataSet = SetUpDataSet(objAdapter, "qryResStat")
                objDataView = New DataView(objDataSet.Tables("qryResStat"))

                If objDataSet.Tables("qryResStat").Rows(0).Item(0).ToString() = "CANCELLED" Then

                    Return False

                Else

                    Return True

                End If

            Catch ex As Exception

                Msg("1008", , NWLN & "There was a problem in checking the status of the reservation" & NWLN & ex.Message)

            End Try

        End Using
    End Function

    Private Sub lblClose_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llbClose.LinkClicked
        Me.Close()
    End Sub

    Private Sub frmUpdateReservation_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        If lblResourceLocator.Text <> String.Empty Then

            Select Case Msg("1033", Button.YesNoCancel)

                Case ButtonClicked.Yes
                    UpdateSave()
                Case ButtonClicked.Cancel
                    e.Cancel = True

            End Select

        End If

    End Sub

    Private Sub dtpCheckInDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpCheckInDate.ValueChanged

        dtpCheckOutDate.MinDate = dtpCheckInDate.Value.Date
        dtpCheckOutDate.Value = dtpCheckInDate.Value.Date.AddDays(1)
        lblNumberOfNights.Text = (dtpCheckOutDate.Value - dtpCheckInDate.Value).Days.ToString

    End Sub

    Private Sub dgvRoomVacancySearch_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvRoomVacancySearch.DoubleClick
        btnAddRoom_Click(Nothing, Nothing)
    End Sub
#End Region
    
End Class