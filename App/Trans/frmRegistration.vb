Option Explicit On
Option Strict On

Imports System.Data.SqlClient

' Programmer:   Howell Quindara
' Date:         March 18, 2007
' Title:        frmRegistration
' Purpose:      This interface is use to register existing or new guest
' Requirements: ->  (+)GUEST_INFO (GITITLE, GIFNAME, GIMI, GILNAME, GIGENDER, GIBDAY, GICOUNTRY, GIZIP, GIADDRESS,GICONTACT,GIEMAIL,GICIVILSTAT,GINAT,GICIT,GIID)
'               ->  (+)COMPANY (CNAME, CADDRESS, CBRANCH, CCONTACTPERSON, CCONTACT, CPOS, CID)
'               ->  (+)GUEST (Gno, GIID, CID)
'               ->  (+)FOLIO_DETAILS (FDNO, FDRECEIPTNO, FDDATE, FDCHARGE, FDMODIFIEDBYAMT, FDMODIFIEDBYPERCENT, FDMODIFIEDCHARGE, FDBALANCE, FDSTAT, REGNO, REGDNO, FDDESC, FDNAME)
'               ->  (+)REGISTRATION (REGNO, REGDATE, REGSTAT, REGGUESTTYPE, REGAMT, REGBALANCE, REGREMARKS, GNO, RESNO)
'               ->  (+)REGISTRATION_DETAILS (REGDNO, REGDCHKINTIME, REGDCHKOUTTIME, REGDRMAMT, REGDSTAT, REGDNOGUEST, REGDNOOFEXTDAYS, RMNO, REGNO, REGDDAYSUPDATED)
'               ->  (+)RMSTATUS (RMSID, RMSNAME, RMSSTARTTIME, RMSENDTIME, RMNO)
'               ->  (*)GUEST_INFO (GITITLE, GIFNAME, GIMI, GILNAME, GIGENDER, GIBDAY, GICOUNTRY, GIZIP, GIADDRESS,GICONTACT,GIEMAIL,GICIVILSTAT,GINAT,GICIT,GIID)
'               ->  (*)COMPANY (CNAME, CADDRESS, CBRANCH, CCONTACTPERSON, CCONTACT, CPOS, CID)
'               ->  (*)RESERVATION (RESSTAT, REGNO)
'               ->  (*)RESERVATION_DETAILS (RESDSTAT)
'               ->  (*)FOLIO_DETAILS (REGNO)
'               ->  Guest to be registered
'               ->  Room to be registered must be clean
'               ->  Reservation to be registered
' Results:      ->  New guest is added to the GUEST_INFO table
'               ->  New company is added to the COMPANY table
'               ->  A registration is given to a guest
'               ->  A reservation is registered

Public Class frmRegistration

#Region "Declaration"
    Private objAdapter As SqlDataAdapter
    Private objTransaction As SqlTransaction
    Private objCommand As SqlCommand
    Private objDataView As New DataView
    Private objRoomDataView As New DataView
    Private objReservedDataView As New DataView
    Private objDataSet As DataSet
    Private objReservedDataSet As DataSet
    Private objDataTable As DataTable
    Private objDataRow As DataRow
    Private objDataGridViewRow As DataGridViewRow
    Private gstrGuest As String
    Private gstrCompany As String
    Private gstrRoomNo As String
    Private gstrRMSID As String
    Private gstrDownPayment As String
    Private gstrReservedRoom() As String
    Private blnReserved As Boolean
#End Region

#Region "Guest Information"

    Private Sub chkGuestInfoCompanyGroup_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGuestInfoCompanyGroup.CheckedChanged
        'USE TO SET THE RESERVATION WITH COMPANY

        If chkGuestInfoCompanyGroup.Checked Then

            grpCompanyGroupInformation.Enabled = True
            lblRegistrationCID.Tag = "new"
            radCompanyInfoNew.Checked = True

        Else

            grpCompanyGroupInformation.Enabled = False
            lblRegistrationCID.Tag = "none"

        End If

    End Sub

    Private Sub radCompanyInfoPreviousCompany_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radCompanyInfoPreviousCompany.CheckedChanged
        'FILLS THE VIEW WITH THE PREVIOUS COMPANY OF THE CURRENT GUEST

        If radCompanyInfoPreviousCompany.Checked Then

            Using objDatabaseConnection As SqlConnection = SetUpConnection(DatabasePath, True)

                Try

                    objAdapter = New SqlDataAdapter("SELECT dbo.COMPANY.CName 'Company', dbo.COMPANY.CContactPerson 'Contact Person', dbo.COMPANY.CPos 'Position', dbo.COMPANY.CContact 'Contact Number', dbo.COMPANY.CAddress 'Address', dbo.COMPANY.CBranch 'Branch', dbo.COMPANY.CID 'Company ID' " & _
                                                    "FROM dbo.COMPANY INNER JOIN dbo.GUEST ON dbo.COMPANY.CID = dbo.GUEST.CID INNER JOIN dbo.GUEST_INFO ON dbo.GUEST.GIID = dbo.GUEST_INFO.GIID " & _
                                                    "WHERE (dbo.GUEST.GIID = '" & lblRegistrationGIID.Text & "')", objDatabaseConnection)
                    objDataSet = SetUpDataSet(objAdapter, "qryPreviousCompany")
                    objDataView = New DataView(objDataSet.Tables("qryPreviousCompany"))
                    dgvCompanyGroupInformation.DataSource = objDataView
                    dgvCompanyGroupInformation.Enabled = True
                    ClearDataBindings(pnlCompanyGroupInformation)
                    ClearControls(pnlCompanyGroupInformation)
                    txtCompanyInfoCompanyName.DataBindings.Add("Text", objDataView, "Company")
                    txtCompanyInfoContactPerson.DataBindings.Add("Text", objDataView, "Contact Person")
                    txtCompanyInfoPosition.DataBindings.Add("Text", objDataView, "Position")
                    txtCompanyInfoContactNo.DataBindings.Add("Text", objDataView, "Contact Number")
                    txtCompanyInfoAddress.DataBindings.Add("Text", objDataView, "Address")
                    txtCompanyInfoBranch.DataBindings.Add("Text", objDataView, "Branch")
                    lblRegistrationCID.DataBindings.Add("Text", objDataView, "Company ID")

                Catch

                    Msg("1008", , "An error occured while loading the company information")

                End Try

            End Using

        End If

    End Sub

    Private Sub radCompanyInfo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radCompanyInfo.CheckedChanged
        'FILLS THE VIEW WITH THE LIST OF COMPANY

        If radCompanyInfo.Checked Then
            Using objDatabaseConnection As SqlConnection = SetUpConnection(DatabasePath, True)
                Try
                    objAdapter = New SqlDataAdapter("SELECT CName 'Company', CContactPerson 'Contact Person', CPos 'Position', CContact 'Contact Number', CAddress 'Address', CBranch 'Branch',  CID 'Company ID' " & _
                                                    "FROM dbo.COMPANY", objDatabaseConnection)
                    objDataSet = SetUpDataSet(objAdapter, "qryCompany")
                    objDataView = New DataView(objDataSet.Tables("qryCompany"))
                    dgvCompanyGroupInformation.DataSource = objDataView
                    dgvCompanyGroupInformation.Enabled = True
                    ClearDataBindings(pnlCompanyGroupInformation)
                    ClearControls(pnlCompanyGroupInformation)
                    txtCompanyInfoCompanyName.DataBindings.Add("Text", objDataView, "Company")
                    txtCompanyInfoContactPerson.DataBindings.Add("Text", objDataView, "Contact Person")
                    txtCompanyInfoPosition.DataBindings.Add("Text", objDataView, "Position")
                    txtCompanyInfoContactNo.DataBindings.Add("Text", objDataView, "Contact Number")
                    txtCompanyInfoAddress.DataBindings.Add("Text", objDataView, "Address")
                    txtCompanyInfoBranch.DataBindings.Add("Text", objDataView, "Branch")
                    lblRegistrationCID.DataBindings.Add("Text", objDataView, "Company ID")
                Catch ex As Exception
                    Msg("1008", , "An error occured while loading the company information")
                End Try

            End Using

        End If

    End Sub

    Private Sub radCompanyInfoNew_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radCompanyInfoNew.CheckedChanged
        'THIS PREPARES FOR THE NEW COMPANY THAT WILL BE RESERVED

        If radCompanyInfoNew.Checked = True Then
            dgvCompanyGroupInformation.DataSource = vbNull
            dgvCompanyGroupInformation.Enabled = False
            ClearControls(pnlCompanyGroupInformation)
            lblRegistrationCID.Text = "new"
        End If

    End Sub

    Private Sub btnGuestInfoClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuestInfoClear.Click
        'USE TO RESET THE ENTRY OF GUEST INFORMATION

        clearGuestInfoTab()

    End Sub

    Private Sub txtGuestInfoFirstName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGuestInfoFirstName.TextAlignChanged

        'DISPLAYS THE FIRSTNAME OF THE GUEST

        lblNameOfGuest.Text = txtGuestInfoFirstName.Text & " " & txtGuestInfoLastName.Text

    End Sub

    Private Sub txtGuestInfoLastName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGuestInfoLastName.TextChanged

        'DISPLAYS THE LASTNAME OF THE GUEST

        lblNameOfGuest.Text = txtGuestInfoFirstName.Text & " " & txtGuestInfoLastName.Text

    End Sub

    Private Sub lblRegistrationGIID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblRegistrationGIID.TextChanged


        gstrGuest = String.Empty

        If lblRegistrationGIID.Text <> "new" Then

            lblRegistrationGIID.Tag = "old"

            Using objDatabaseConnection As SqlConnection = SetUpConnection(DatabasePath, True)

                Try

                    objAdapter = New SqlDataAdapter("SELECT * " & _
                                                    "FROM GUEST_INFO " & _
                                                    "WHERE GIID = '" & lblRegistrationGIID.Text & "';", objDatabaseConnection)
                    objDataSet = SetUpDataSet(objAdapter, "qryguest")
                    objDataRow = objDataSet.Tables("qryguest").Rows(0)

                    For i As Integer = 1 To 14

                        gstrGuest = gstrGuest & objDataRow.Item(i).ToString

                    Next

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

                        If Trim(objDataRow.Item(10).ToString) = "MALE" Then

                            cboGuestInfoGender.SelectedItem = cboGuestInfoGender.Items(1)

                        ElseIf Trim(objDataRow.Item(10).ToString) = "FEMALE" Then

                            cboGuestInfoGender.SelectedItem = cboGuestInfoGender.Items(2)

                        Else

                            cboGuestInfoGender.SelectedItem = cboGuestInfoGender.Items(0)

                        End If

                        cboGuestInfoCivilStatus.Text = objDataRow.Item(11).ToString
                        txtGuestInfoNationality.Text = objDataRow.Item(12).ToString
                        txtGuestInfoCitezenship.Text = objDataRow.Item(13).ToString

                        If objDataRow.Item(14) Is DBNull.Value Then

                            dtpGuestInfoBirthDate.Checked = False

                        Else

                            dtpGuestInfoBirthDate.Value = CDate(objDataRow.Item(14))

                        End If

                    End If

                Catch ex As Exception

                    Msg("1008", , "An error occured while loading guest info, guest information will be cleared" & NWLN & ex.Message)
                    clearGuestInfoTab()

                End Try

            End Using

        End If
    End Sub

    Private Sub lblRegistrationCID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblRegistrationCID.TextChanged

        gstrCompany = String.Empty

        If lblRegistrationCID.Text <> "new" Then

            lblRegistrationCID.Tag = "old"

            Using objDatabaseConnection As SqlConnection = SetUpConnection(DatabasePath, True)

                Try
                    objAdapter = New SqlDataAdapter("SELECT * " & _
                                                    "FROM COMPANY " & _
                                                    "WHERE CID = '" & lblRegistrationCID.Text & "';", objDatabaseConnection)
                    objDataSet = SetUpDataSet(objAdapter, "qryguest")
                    objDataRow = objDataSet.Tables("qryguest").Rows(0)

                    For i As Integer = 1 To 6

                        gstrCompany = gstrCompany & objDataRow.Item(i).ToString

                    Next

                Catch ex As Exception

                    Msg("1008", , "An error occured while loading company info, guest information will be cleared")
                    clearGuestInfoTab()

                End Try

            End Using

        ElseIf chkGuestInfoCompanyGroup.Checked = False Then

            lblRegistrationCID.Tag = "none"

        Else

            lblRegistrationCID.Tag = "new"

        End If

    End Sub

    Private Function GuestInfoCompare() As Boolean
        'USE TO DETERMINE IF CHANGES HAS BEEN DONE TO THE GUEST INFORMATION
        'if the value returned is true there are changes

        Dim strBirthDay As String

        If lblRegistrationGIID.Tag.ToString = "old" Then

            If dtpGuestInfoBirthDate.Checked Then
                strBirthDay = AllTrimNoSpace(dtpGuestInfoBirthDate.Value.Date & dtpGuestInfoBirthDate.Value.ToLongTimeString)
            Else
                strBirthDay = String.Empty
            End If

            If AllTrimNoSpace(gstrGuest).ToUpper = AllTrimNoSpace((txtGuestInfoTitle.Text & txtGuestInfoFirstName.Text & txtGuestInfoLastName.Text & _
               txtGuestInfoMiddleInitial.Text & cboGuestInfoCountry.Text & txtGuestInfoAddress.Text & _
               txtGuestInfoZipCode.Text & txtGuestInfoContactNo.Text & txtGuestInfoEmail.Text & _
               cboGuestInfoGender.Text & cboGuestInfoCivilStatus.Text & txtGuestInfoNationality.Text & _
               txtGuestInfoCitezenship.Text).ToUpper & strBirthDay) Then

                Return False
            Else

                Return True

            End If

        End If

    End Function

    Private Function CompanyInfoCompare() As Boolean
        'USE TO DETERMINE IF CHANGES HAS BEEN DONE TO THE GUEST INFORMATION
        'if the value returned is true there are changes
        If lblRegistrationCID.Tag.ToString = "old" Then

            If AllTrimNoSpace(gstrCompany).ToUpper = AllTrimNoSpace((txtCompanyInfoCompanyName.Text & txtCompanyInfoAddress.Text & txtCompanyInfoBranch.Text & _
               txtCompanyInfoContactPerson.Text & txtCompanyInfoContactNo.Text & txtCompanyInfoPosition.Text).ToUpper) Then

                Return False
            Else

                Return True
            End If

        End If

    End Function

#End Region

#Region "Registration Information"

    Private Sub btnAddRoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddRoom.Click

        If dgvRoomVacancySearch.SelectedRows.Count > 0 Then
            'checks if the room is already in the list
            For Each objDataGridViewRow In dgvGuestRooms.Rows

                If lblRoomNumber.Text = objDataGridViewRow.Cells(0).Value.ToString And dtpCheckInDate.Value.Date & " " & dtpCheckInTime.Value.ToShortTimeString = objDataGridViewRow.Cells(5).Value.ToString And dtpCheckOutDate.Value.Date & " " & dtpCheckOutTime.Value.ToShortTimeString = objDataGridViewRow.Cells(6).Value.ToString Then

                    Msg("1002", , "Room already in the list")
                    Exit Sub

                End If

            Next

            If IntegerInput(txtNoOfOccupants.Text.ToString) = False Then

                Msg("1001", , "Invalid number of occupants input")
                txtNoOfOccupants.Focus()

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

            LabelUpdate()

        End If

    End Sub

    Private Sub btnRemoveRoomInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveRoomInfo.Click

        'REMOVES A ROOM IN THE LIST OF THE GUEST'S ROOM

        If dgvGuestRooms.SelectedRows.Count > 0 Then
            Dim strRoomNo As String = String.Empty
            Dim ctr As Integer = 0

            dgvGuestRooms.Rows.Remove(dgvGuestRooms.SelectedRows(0))

            If dgvGuestRooms.Rows.Count < 1 Then
                SearchRoomLoad("''")
            Else

                For Each objDataGridViewRow In dgvGuestRooms.Rows

                    If dgvGuestRooms.Rows.Count - 1 = ctr Then
                        strRoomNo = strRoomNo & "'" & objDataGridViewRow.Cells(0).Value.ToString & "'"
                    Else
                        strRoomNo = strRoomNo & "'" & objDataGridViewRow.Cells(0).Value.ToString & "'" & ","
                    End If

                    ctr += 1
                Next

                SearchRoomLoad(strRoomNo)

            End If

            frmParent.tssStatus.Text = "Room removed successfully"
            LabelUpdate()

        End If
    End Sub

    Private Sub btnClearInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearInfo.Click

        clearRegistrationInfoTab()

    End Sub

    Private Sub btnRegistrationSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrationSave.Click

        RegistrationSave()

    End Sub

    Private Sub dtpCheckInDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpCheckInDate.ValueChanged

        dtpCheckOutDate.MinDate = dtpCheckInDate.Value.Date
        dtpCheckOutDate.Value = dtpCheckInDate.Value.Date.AddDays(1)
        lblNumberOfNights.Text = (dtpCheckOutDate.Value - dtpCheckInDate.Value).Days.ToString

    End Sub

    Private Sub dtpCheckOutDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpCheckOutDate.ValueChanged

        lblNumberOfNights.Text = (dtpCheckOutDate.Value - dtpCheckInDate.Value).Days.ToString

    End Sub

    Private Sub dgvRoomVacancySearch_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvRoomVacancySearch.SelectionChanged

        If dgvRoomVacancySearch.SelectedRows.Count > 0 Then
            txtNoOfOccupants.Text = dgvRoomVacancySearch.SelectedRows.Item(0).Cells(3).Value.ToString
            lblRoomNumber.Text = dgvRoomVacancySearch.SelectedRows.Item(0).Cells(0).Value.ToString
            lblRoomRate.Text = CDbl(dgvRoomVacancySearch.SelectedRows.Item(0).Cells(2).Value.ToString).ToString("n")
        End If

    End Sub

    Private Sub lblResourceLoc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblResourceLoc.TextChanged

        gstrRoomNo = String.Empty

        If lblResourceLoc.Text <> String.Empty Then ' guest with reservation

            If frmUpdateReservation.ActiveReservation(lblResourceLoc.Text) = False Then

                Msg("1097")
                lblResourceLoc.Text = String.Empty

            Else
                blnReserved = True

                Using objDatabaseConnection As SqlConnection = SetUpConnection(DatabasePath, True)

                    Try ' loads the reservation details of the guest

                        objAdapter = New SqlDataAdapter("SELECT DISTINCT RESERVATION_DETAILS.RMNo, RMRATE.RMRAmt, ROOM.RMType, RESERVATION_DETAILS.ResDNoOccupants, RESERVATION_DETAILS.ResDNoDays, RESERVATION_DETAILS.ResDTimeIn, RESERVATION_DETAILS.ResDTimeOut " & _
                                                        "FROM RESERVATION_DETAILS INNER JOIN RMRATE_DETAILS ON RESERVATION_DETAILS.RMNo = RMRATE_DETAILS.RMNo INNER JOIN RMRATE ON RMRATE_DETAILS.RMRID = RMRATE.RMRID INNER JOIN ROOM ON RESERVATION_DETAILS.RMNo = ROOM.RMNo INNER JOIN RMSTATUS ON RESERVATION_DETAILS.RMNo = RMSTATUS.RMNo " & _
                                                        "WHERE (RESERVATION_DETAILS.ResNo = '" & lblResourceLoc.Text & "') AND (RMRATE_DETAILS.RMDActive = 'TRUE') AND (RMSTATUS.RMSName = 'RESERVED')", objDatabaseConnection)
                        objReservedDataSet = SetUpDataSet(objAdapter, "qryFromReservation")
                        objReservedDataView = New DataView(objReservedDataSet.Tables("qryFromReservation"))

                        For Each objDataRow In objReservedDataView.Table.Rows

                            dgvGuestRooms.Rows.Add(objDataRow.Item(0).ToString, objDataRow.Item(1).ToString, objDataRow.Item(2).ToString, objDataRow.Item(3).ToString, objDataRow.Item(4).ToString, objDataRow.Item(5).ToString, objDataRow.Item(6).ToString)

                        Next

                        LabelUpdate()

                    Catch ex As Exception

                        Msg("1108", , "An error occured while loading the reserved rooms" & NWLN & ex.Message)
                        clearRegistrationInfoTab()
                        clearGuestInfoTab()

                    End Try

                    Try 'load the information of the guest

                        objAdapter = New SqlDataAdapter("SELECT GUEST.GIID " & _
                                                        "FROM GUEST INNER JOIN RESERVATION ON GUEST.GNo = RESERVATION.GNo " & _
                                                        "WHERE (RESERVATION.ResNo = '" & lblResourceLoc.Text & "')", objDatabaseConnection)
                        objDataSet = SetUpDataSet(objAdapter, "qryGuestID")
                        objDataRow = objDataSet.Tables("qryGuestID").Rows(0)
                        lblRegistrationGIID.Text = objDataRow.Item(0).ToString

                        'CODE HERE JEFF
                        objAdapter = New SqlDataAdapter("SELECT RESERVATION.ResRemarks " & _
                                                        "FROM RESERVATION " & _
                                                        "WHERE (RESERVATION.ResNo = '" & lblResourceLoc.Text & "')", objDatabaseConnection)
                        objDataSet = SetUpDataSet(objAdapter, "qryRemarks_j")
                        objDataRow = objDataSet.Tables("qryRemarks_j").Rows(0)
                        txtRemarks.Text = objDataRow.Item(0).ToString

                    Catch ex As Exception

                        Msg("1108", , "An error occured while loading the guest information" & NWLN & ex.Message)
                        clearRegistrationInfoTab()
                        clearGuestInfoTab()

                    End Try

                    Try 'loads the reservation information of the guest
                        objAdapter = New SqlDataAdapter("SELECT  ResNoOccupants, ResNoRoom, ResAmt, ResBalance " & _
                                                        "FROM RESERVATION " & _
                                                        "WHERE (RESERVATION.ResNo = '" & lblResourceLoc.Text & "')", objDatabaseConnection)
                        objDataSet = SetUpDataSet(objAdapter, "qryResno")
                        objDataRow = objDataSet.Tables("qryResno").Rows(0)
                        lblNoOccupants.Text = objDataRow.Item(0).ToString
                        lblNoRooms.Text = objDataRow.Item(1).ToString
                        lblAmountTotal.Text = objDataRow.Item(2).ToString
                        lblAmountPaid.Text = CStr(CDbl(lblAmountTotal.Text) - CDbl(objDataRow.Item(3).ToString))

                    Catch ex As Exception

                        Msg("1108", , "An error occured while loading the Reservation" & NWLN & ex.Message)
                        clearRegistrationInfoTab()
                        clearGuestInfoTab()

                    End Try

                End Using

                SearchRoomLoad("''")

            End If

        Else ' no reservation

            blnReserved = False
            ClearControls(grpGuestInformation)
            ClearControls(pnlCompanyGroupInformation)
            lblNameOfGuest.Text = String.Empty

        End If

    End Sub

    Private Sub btnRoomVacancySearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRoomVacancySearch.Click

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

#End Region

#Region "Other"

    Public Sub FillMe()

        If SearchedReservationNo = String.Empty Then
            lblRegistrationGIID.Text = SearchedGuestID
        Else
            clearRegistrationInfoTab()
            lblResourceLoc.Text = SearchedReservationNo
        End If

    End Sub

    Private Sub tsbGuestSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuestSearch.Click

        TriggeredBy = TriggeringForm.Registration
        frmGuestSearch.ShowDialog()

    End Sub

    Private Sub tsbUpdateRegistration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbUpdateRegistration.Click
        Display(Forms.frmUpdateRegistration)
    End Sub

    Private Sub tsbPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbPayment.Click
        Display(Forms.frmPayment)
    End Sub

    Private Sub frmRegistration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LoadComboBox(cboGuestInfoCountry, cboGuestInfoCivilStatus, cboRoomType, cboFloor, cboView, cboGuestType)

        lblRegistrationGNO.Text = GetPreKeyGen("Guest") & GetPrimaryKeyNo("Guest")

        dtpCheckInDate.Value = Now.Date
        dtpCheckInDate.MaxDate = Now.Date
        dtpCheckOutDate.Value = dtpCheckInDate.Value.AddDays(1)
        dtpCheckOutDate.MinDate = dtpCheckInDate.Value.Date

        dtpDateOfRegistration.Value = Now.Date
        dtpDateOfRegistration.MaxDate = Now.Date

    End Sub

    Private Sub AddRoomToList()
        'USE TO ADD THE ROOM SELECTED TO THE GUEST ROOM

        dgvGuestRooms.Rows.Add(lblRoomNumber.Text, lblRoomRate.Text, dgvRoomVacancySearch.SelectedRows.Item(0).Cells(1).Value.ToString, txtNoOfOccupants.Text, lblNumberOfNights.Text, dtpCheckInDate.Value.Date & " " & dtpCheckInTime.Value.ToShortTimeString, dtpCheckOutDate.Value.Date & " " & dtpCheckOutTime.Value.ToShortTimeString)
        frmParent.tssStatus.Text = "New room added"
        dgvRoomVacancySearch.Rows.Remove(dgvRoomVacancySearch.SelectedRows(0))
        LabelUpdate()

    End Sub

    Private Sub txtEntries()
        'TRIMS THE EXTRA SPACES

        Dim ctrlEntries As Control

        For Each ctrlEntries In grpGuestInformation.Controls

            If TypeOf ctrlEntries Is TextBox Or TypeOf ctrlEntries Is ComboBox Then
                ctrlEntries.Text = TrimAll(ctrlEntries.Text)
            End If

        Next

        For Each ctrlEntries In pnlCompanyGroupInformation.Controls

            If TypeOf ctrlEntries Is TextBox Or TypeOf ctrlEntries Is ComboBox Then
                ctrlEntries.Text = TrimAll(ctrlEntries.Text)
            End If

        Next

    End Sub

    Private Sub SearchRoomLoad(ByVal strRoomNo As String)

        'If dgvRoomVacancySearch.Rows.Count > 0 Then

        'End If
        objRoomDataView = SearchRoom(dtpCheckInDate.Value.Date & " " & dtpCheckInTime.Value.ToLongTimeString, dtpCheckOutDate.Value.Date & " " & dtpCheckOutTime.Value.ToLongTimeString, "reg")
        dgvRoomVacancySearch.DataSource = objRoomDataView
        objRoomDataView.RowFilter = "[Room Number]NOT IN (" & strRoomNo & ")"
        dgvRoomVacancySearch.Sort(dgvRoomVacancySearch.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
        lblSearchResult.Text = dgvRoomVacancySearch.RowCount.ToString

    End Sub

    Private Sub LabelUpdate()
        lblNoRooms.Text = CStr(dgvGuestRooms.Rows.Count)
        lblNoOccupants.Text = "0"
        lblAmountTotal.Text = "0"

        For Each objDataGridViewRow In dgvGuestRooms.Rows
            lblNoOccupants.Text = (CInt(lblNoOccupants.Text) + CInt(objDataGridViewRow.Cells(3).Value.ToString())).ToString
            lblAmountTotal.Text = (CDbl(lblAmountTotal.Text) + (CDbl(objDataGridViewRow.Cells(1).Value.ToString()) * CDbl(objDataGridViewRow.Cells(4).Value.ToString()))).ToString("n")
        Next
    End Sub

    Private Sub dtpDate_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDateOfRegistration.Leave, dtpCheckInDate.Leave

        Dim dtpdate As DateTimePicker
        dtpdate = CType(sender, DateTimePicker)

        CheckDate(dtpdate)

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

    Private Function RequiredFields() As Boolean
        Dim value As Boolean = False

        If Trim(txtGuestInfoFirstName.Text) = String.Empty Then
            tbcRegistration.SelectedIndex = 0
            txtGuestInfoFirstName.Focus()
            Return True
            Exit Function
        ElseIf Trim(txtGuestInfoAddress.Text) = String.Empty Then
            tbcRegistration.SelectedIndex = 0
            txtGuestInfoAddress.Focus()
            Return True
            Exit Function
        End If

        If chkGuestInfoCompanyGroup.Checked = True Then
            If Trim(txtCompanyInfoCompanyName.Text) = String.Empty Then
                tbcRegistration.SelectedIndex = 0
                txtCompanyInfoCompanyName.Focus()
                Return True
                Exit Function
            ElseIf Trim(txtCompanyInfoContactPerson.Text) = String.Empty Then
                tbcRegistration.SelectedIndex = 0
                txtCompanyInfoContactPerson.Focus()
                Return True
                Exit Function
            ElseIf Trim(txtCompanyInfoContactNo.Text) = String.Empty Then
                tbcRegistration.SelectedIndex = 0
                txtCompanyInfoContactNo.Focus()
                Return True
                Exit Function
            End If

        End If

        Return False
    End Function

    Private Sub tbpRegistrationInformation_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbpRegistrationInformation.Enter
        SearchRoomLoad("''")
    End Sub

    Private Sub clearGuestInfoTab()

        ClearControls(grpGuestInformation)
        ClearControls(pnlCompanyGroupInformation)
        lblNameOfGuest.Text = String.Empty
        lblRegistrationGIID.Text = "new"
        lblRegistrationCID.Text = "new"
        lblRegistrationGNO.Text = GetPreKeyGen("Guest") & GetPrimaryKeyNo("Guest")
        chkGuestInfoCompanyGroup.Checked = False
        btnRegistrationSave.Enabled = True
        dtpGuestInfoBirthDate.Checked = False
        dgvCompanyGroupInformation.DataSource = vbNull

    End Sub

    Private Sub clearRegistrationInfoTab()

        dgvRoomVacancySearch.DataSource = vbNull
        lblResourceLoc.Text = String.Empty
        lblAmountPaid.Text = "0"
        lblAmountTotal.Text = "0"
        lblNoRooms.Text = "0"
        lblNoOccupants.Text = "0"
        dgvGuestRooms.Rows.Clear()
        txtRoomNumber.Text = String.Empty
        cboRoomType.Text = String.Empty
        cboFloor.Text = String.Empty
        cboView.Text = String.Empty
        cboGuestType.Text = String.Empty
        SearchRoomLoad("''")

    End Sub

    Public Sub addDefaultValue(ByVal strRoom As String)

        Dim blnExit As Boolean = False
        For Each objDataGridViewRow In dgvGuestRooms.Rows

            If lblRoomNumber.Text = objDataGridViewRow.Cells(0).Value.ToString Then

                Msg("1002", Button.Ok, "Room already in the list")

                Exit Sub

            End If

        Next

        For Each objDataGridViewRow In dgvRoomVacancySearch.Rows

            blnExit = False

            If strRoom = objDataGridViewRow.Cells(0).Value.ToString Then

                objDataGridViewRow.Selected = True
                dtpCheckInDate.Value = Now.Date
                dtpCheckOutDate.Value = dtpCheckInDate.Value.AddDays(1)
                lblRoomNumber.Text = objDataGridViewRow.Cells(0).Value.ToString
                lblRoomRate.Text = objDataGridViewRow.Cells(2).Value.ToString
                lblNumberOfNights.Text = "1"
                txtNoOfOccupants.Text = objDataGridViewRow.Cells(3).Value.ToString()

                AddRoomToList()
                blnExit = True

                If blnExit = True Then
                    Exit Sub
                End If

            End If

            Exit Sub

        Next

        Msg("1043")

    End Sub

    Private Sub RegistrationSave()
        If noRequiredMissing() = False Then
            Exit Sub
        Else
            txtEntries()
            Dim dblRegAmt As Double

            For Each objDataGridViewRow In dgvGuestRooms.Rows
                dblRegAmt = dblRegAmt + CDbl(objDataGridViewRow.Cells(1).Value.ToString)
            Next

            Dim strCase As String = lblRegistrationGIID.Tag.ToString & lblRegistrationCID.Tag.ToString
            Dim strInsertIntoGuestInfo As String = "INSERT INTO GUEST_INFO (GITITLE, GIFNAME, GIMI, GILNAME, GIGENDER, GIBDAY, GICOUNTRY, GIZIP, GIADDRESS, GICONTACT, GIEMAIL, GICIVILSTAT, GINAT, GICIT, GIID) " & _
                                                   "VALUES (@gititle, @gifname, @gimi, @gilname, @gigender, @gibday,@gicountry, @gizip, @giaddress, @gicontact, @giemail,@gicivilstat, @ginat, @gicit,@giid );"
            Dim strInsertIntoCompany As String = "INSERT INTO COMPANY (CNAME, CADDRESS, CBRANCH, CCONTACTPERSON, CCONTACT, CPOS, CID)" & _
                                                 " VALUES (@cname, @caddress, @cbranch, @ccontactperson, @ccontact,@cpos,@cid);"
            Dim strInsertIntoGuest As String = "INSERT INTO GUEST (Gno, GIID, CID)" & _
                                               " VALUES (@gno, @giid, @cid);"
            Dim strInsertIntoRegistration As String = "INSERT INTO REGISTRATION (REGNO, REGDATE, REGSTAT, REGGUESTTYPE, REGAMT, REGBALANCE, REGREMARKS, GNO, RESNO) " & _
                                                      "VALUES (@regno, @regdate, @regstat, @regguesttype, @regamt, @regamt, @regremarks, @gno, @resno );"
            Dim strUpdateReservation As String = "UPDATE RESERVATION SET " & _
                                                 "RESSTAT = 'REGISTERED', " & _
                                                 "REGNO = @regno " & _
                                                 "WHERE RESNO = '" & lblResourceLoc.Text & "';"
            Dim strUpdateGuestInfo As String = "UPDATE GUEST_INFO SET " & _
                                               "GITITLE = @gititle ," & _
                                               "GIFNAME = @gifname ," & _
                                               "GIMI = @gimi ," & _
                                               "GILNAME = @gilname ," & _
                                               "GIGENDER = @gigender ," & _
                                               "GIBDAY = @gibday ," & _
                                               "GICOUNTRY = @gicountry ," & _
                                               "GIZIP = @gizip ," & _
                                               "GIADDRESS = @giaddress ," & _
                                               "GICONTACT = @gicontact ," & _
                                               "GIEMAIL = @giemail ," & _
                                               "GICIVILSTAT = @gicivilstat ," & _
                                               "GINAT = @ginat ," & _
                                               "GICIT = @gicit " & _
                                               "WHERE GIID = '" & lblRegistrationGIID.Text & "';"
            Dim strupdateCompanyInfo As String = "UPDATE COMPANY SET " & _
                                               "CNAME = @cname ," & _
                                               "CADDRESS = @caddress ," & _
                                               "CBRANCH = @cbranch ," & _
                                               "CCONTACTPERSON = @ccontactperson ," & _
                                               "CCONTACT = @ccontact ," & _
                                               "CPOS = @cpos " & _
                                               "WHERE CID = '" & lblRegistrationCID.Text & "';"

            Using objRegistrationSaveConnection As SqlConnection = SetUpConnection(DatabasePath, True)

                If objRegistrationSaveConnection.State = ConnectionState.Closed Then objRegistrationSaveConnection.Open()

                Using objTransaction As SqlTransaction = objRegistrationSaveConnection.BeginTransaction

                    Using objCommand As SqlCommand = objRegistrationSaveConnection.CreateCommand

                        With objCommand
                            .Transaction = objTransaction

                            Try

                                With .Parameters
                                    .AddWithValue("@gno", lblRegistrationGNO.Text.ToUpper)
                                    .AddWithValue("@gititle", txtGuestInfoTitle.Text.ToUpper)
                                    .AddWithValue("@gifname", txtGuestInfoFirstName.Text.ToUpper)
                                    .AddWithValue("@gimi", txtGuestInfoMiddleInitial.Text.ToUpper)
                                    .AddWithValue("@gilname", txtGuestInfoLastName.Text.ToUpper)
                                    .AddWithValue("@gigender", cboGuestInfoGender.Text)
                                    .AddWithValue("@gibday", dtpGuestInfoBirthDate.Value)
                                    .AddWithValue("@gicountry", cboGuestInfoCountry.Text.ToUpper)
                                    .AddWithValue("@gizip", txtGuestInfoZipCode.Text.ToUpper)
                                    .AddWithValue("@giaddress", txtGuestInfoAddress.Text.ToUpper)
                                    .AddWithValue("@gicontact", txtGuestInfoContactNo.Text.ToUpper)
                                    .AddWithValue("@giemail", txtGuestInfoEmail.Text.ToUpper)
                                    .AddWithValue("@gicivilstat", cboGuestInfoCivilStatus.Text.ToUpper)
                                    .AddWithValue("@ginat", txtGuestInfoNationality.Text.ToUpper)
                                    .AddWithValue("@gicit", txtGuestInfoCitezenship.Text.ToUpper)

                                    If lblRegistrationGIID.Tag.ToString = "new" Then
                                        .AddWithValue("@giid", GetPreKeyGen("GuestInfo") & GetPrimaryKeyNo("GuestInfo"))
                                    Else
                                        .AddWithValue("@giid", lblRegistrationGIID.Text.ToUpper)
                                    End If

                                    .AddWithValue("@cname", txtCompanyInfoCompanyName.Text.ToUpper)
                                    .AddWithValue("@caddress", txtCompanyInfoAddress.Text.ToUpper)
                                    .AddWithValue("@cbranch", txtCompanyInfoBranch.Text.ToUpper)
                                    .AddWithValue("@ccontactperson", txtCompanyInfoContactPerson.Text.ToUpper)
                                    .AddWithValue("@ccontact", txtCompanyInfoContactNo.Text.ToUpper)
                                    .AddWithValue("@cpos", txtCompanyInfoPosition.Text.ToUpper)

                                    If lblRegistrationCID.Tag.ToString = "new" Then
                                        .AddWithValue("@cid", GetPreKeyGen("Company") & GetPrimaryKeyNo("Company"))
                                    ElseIf lblRegistrationCID.Tag.ToString = "none" Then
                                        .AddWithValue("@cid", DBNull.Value)
                                    Else
                                        .AddWithValue("@cid", lblRegistrationCID.Text.ToUpper)
                                    End If

                                    .AddWithValue("@regno", GetPreKeyGen("Registration") & GetPrimaryKeyNo("Registration"))
                                    .AddWithValue("@regdate", dtpDateOfRegistration.Value.Date)
                                    .AddWithValue("@regguesttype", cboGuestType.Text.ToUpper)
                                    .AddWithValue("@regamt", dblRegAmt)
                                    .AddWithValue("@regtamt", dblRegAmt)
                                    .AddWithValue("@regbalance", CDbl(lblAmountTotal.Text) - CDbl(lblAmountPaid.Text))
                                    .AddWithValue("@regstat", "REGISTERED")
                                    .AddWithValue("@regremarks", TrimAll(txtRemarks.Text.ToUpper))
                                    .AddWithValue("@resno", lblResourceLoc.Text.ToUpper)
                                    .AddWithValue("@regdnoofextdays", 0)
                                    .AddWithValue("@regdstat", "REGISTERED")
                                    .AddWithValue("@fdno", GetPrimaryKeyNo("FDNo"))

                                End With

                                If GuestInfoCompare() = True And CompanyInfoCompare() = True Then

                                    Select Case Msg("1101", Button.YesNoCancel)

                                        Case ButtonClicked.Yes
                                            .CommandText = strUpdateGuestInfo
                                            .ExecuteNonQuery()
                                            .CommandText = strupdateCompanyInfo
                                            .ExecuteNonQuery()
                                        Case ButtonClicked.Cancel
                                            Exit Sub

                                    End Select

                                ElseIf GuestInfoCompare() Then

                                    Select Case Msg("1102", Button.YesNoCancel)

                                        Case ButtonClicked.Yes
                                            .CommandText = strUpdateGuestInfo
                                            .ExecuteNonQuery()
                                        Case ButtonClicked.Cancel
                                            Exit Sub

                                    End Select

                                ElseIf CompanyInfoCompare() Then

                                    Select Case Msg("1103", Button.YesNoCancel)

                                        Case ButtonClicked.Yes
                                            .CommandText = strupdateCompanyInfo
                                            .ExecuteNonQuery()
                                        Case ButtonClicked.Cancel
                                            Exit Sub

                                    End Select

                                End If

                                Select Case strCase

                                    Case "newnone", "newold" 'new guest, no company: newgest old company
                                        .CommandText = strInsertIntoGuestInfo
                                        .ExecuteNonQuery()
                                        IncrementPrimaryKeyNo("GuestInfo")

                                    Case "newnew" 'new guest, new company
                                        .CommandText = strInsertIntoGuestInfo
                                        .ExecuteNonQuery()
                                        IncrementPrimaryKeyNo("GuestInfo")
                                        .CommandText = strInsertIntoCompany
                                        .ExecuteNonQuery()
                                        IncrementPrimaryKeyNo("Company")

                                    Case "oldnew" 'old guest, new company
                                        .CommandText = strInsertIntoCompany
                                        .ExecuteNonQuery()
                                        IncrementPrimaryKeyNo("Company")

                                End Select
                                .CommandText = strInsertIntoGuest
                                .ExecuteNonQuery()
                                IncrementPrimaryKeyNo("Guest")
                                .CommandText = strInsertIntoRegistration
                                .ExecuteNonQuery()
                                IncrementPrimaryKeyNo("Registration")

                                If lblResourceLoc.Text <> String.Empty Then
                                    .CommandText = strUpdateReservation
                                    .ExecuteNonQuery()
                                End If

                                Dim ctr As Integer = 1
                                Dim strReservedRoom As String = String.Empty

                                If blnReserved Then

                                    For Each objDataGridViewRow In dgvGuestRooms.Rows ' if the room is reserved

                                        If objReservedDataView.Table.Rows.Count = ctr Then
                                            strReservedRoom = strReservedRoom & objDataGridViewRow.Cells(0).Value.ToString
                                        Else
                                            strReservedRoom = strReservedRoom & objDataGridViewRow.Cells(0).Value.ToString & ","
                                        End If

                                    Next

                                    gstrReservedRoom = Split(strReservedRoom, ",") ' get the room numbers from the reservation of the guest

                                End If

                                For Each objDataGridViewRow In dgvGuestRooms.Rows
                                    Dim blnIsReservedRoom As Boolean = False 'if true the room to be registered is reserved

                                    If blnReserved Then

                                        For Each str As String In gstrReservedRoom

                                            If str = dgvGuestRooms.SelectedRows(0).Cells(0).Value.ToString Then
                                                blnIsReservedRoom = True
                                                Exit For
                                            End If

                                        Next

                                    End If

                                    If blnIsReservedRoom Then
                                        .CommandText = "UPDATE RESERVATION_DETAILS SET RESDSTAT = 'REGISTERED' " & _
                                                       "WHERE RESNO = '" & lblResourceLoc.Text & "';"
                                        .ExecuteNonQuery()
                                    End If

                                    .CommandText = "INSERT INTO REGISTRATION_DETAILS (REGDNO, REGDCHKINTIME, REGDCHKOUTTIME, REGDRMAMT, REGDSTAT, REGDNOGUEST, REGDNOOFEXTDAYS, RMNO, REGNO, REGDDAYSUPDATED) " & _
                                                             "VALUES ('" & GetPrimaryKeyNo("RegistrationDetails") & "', '" & objDataGridViewRow.Cells(5).Value.ToString & "' , '" & objDataGridViewRow.Cells(6).Value.ToString & "' , '" & objDataGridViewRow.Cells(1).Value.ToString & "', @regdstat, '" & objDataGridViewRow.Cells(3).Value.ToString & "' , @regdnoofextdays, '" & objDataGridViewRow.Cells(0).Value.ToString & "', @regno, '1');"
                                    .ExecuteNonQuery()

                                    .CommandText = "INSERT INTO FOLIO_DETAILS (FDNO, FDRECEIPTNO, FDDATE, FDCHARGE, FDMODIFIEDBYAMT, FDMODIFIEDBYPERCENT, FDMODIFIEDCHARGE, FDBALANCE, FDSTAT, REGNO, REGDNO, FDDESC, FDNAME) " & _
                                                                                   "VALUES ('" & GetPrimaryKeyNo("FDNo") & "', '" & GetPrimaryKeyNo("FDNo") & "', '" & Now.ToShortDateString & "', '" & objDataGridViewRow.Cells(1).Value.ToString & "', '0', '0', '" & objDataGridViewRow.Cells(1).Value.ToString & "', '" & objDataGridViewRow.Cells(1).Value.ToString & "', 'UNPAID', @regno, '" & GetPrimaryKeyNo("RegistrationDetails") & "', 'ROOM', 'ROOM CHARGES');"
                                    .ExecuteNonQuery()
                                    .CommandText = "INSERT INTO RMSTATUS (RMSID, RMSNAME, RMSSTARTTIME, RMSENDTIME, RMNO) " & _
                                                             "VALUES ( '" & GetPrimaryKeyNo("RMStatus") & "' , @regdstat, '" & objDataGridViewRow.Cells(5).Value.ToString & "' , '" & objDataGridViewRow.Cells(6).Value.ToString & "' , '" & objDataGridViewRow.Cells(0).Value.ToString & "');"
                                    .ExecuteNonQuery()
                                    IncrementPrimaryKeyNo("RMStatus")
                                    IncrementPrimaryKeyNo("RegistrationDetails")
                                    IncrementPrimaryKeyNo("FDNo")

                                    If lblResourceLoc.Text <> String.Empty Then
                                        .CommandText = "UPDATE FOLIO_DETAILS SET REGNO = @regno " & _
                                                       "WHERE RESNO = '" & lblResourceLoc.Text & "';"
                                    End If
                                Next

                                objTransaction.Commit()

                                lblRegistrationGNO.Text = GetPreKeyGen("Guest") & GetPrimaryKeyNo("Guest")
                                lblResourceLoc.Text = String.Empty
                                Msg("1032")
                                clearGuestInfoTab()
                                clearRegistrationInfoTab()
                                tbcRegistration.SelectedIndex = 0

                            Catch ex As Exception

                                objTransaction.Rollback()
                                Msg("1054", , "Reservation transaction will be reset" & NWLN & ex.Message)
                                clearGuestInfoTab()
                                clearRegistrationInfoTab()

                            End Try

                        End With

                    End Using

                End Using

            End Using

        End If
    End Sub

    Private Sub frmRegistration_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim result As DialogResult

        If lblRegistrationGIID.Text <> "new" Then

            Select Case Msg("1033", Button.YesNoCancel)

                Case ButtonClicked.Yes
                    RegistrationSave()

                    If noRequiredMissing() = False Then

                        e.Cancel = True

                    End If

                Case ButtonClicked.Cancel
                    e.Cancel = True

            End Select

        End If
    End Sub

    Private Sub llbClose_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llbClose.LinkClicked
        Me.Close()
    End Sub

    Private Function noRequiredMissing() As Boolean

        If RequiredFields() = True Then

            Msg("1000", , "Fields with * are required")
            Return False

        ElseIf dgvGuestRooms.Rows.Count < 1 Then

            Msg("1039", , "No room to be register")
            tbcRegistration.SelectedIndex = 1

        Else
            Return True
        End If

    End Function

    Private Sub dgvRoomVacancySearch_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvRoomVacancySearch.DoubleClick
        btnAddRoom_Click(Nothing, Nothing)
    End Sub

#End Region

End Class