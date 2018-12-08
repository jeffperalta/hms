Option Explicit On
Option Strict On

Imports System.Data.SqlClient

' Programmer:   Howell Quindara
' Date:         March 18, 2007
' Title:        frmReservation
' Purpose:      This interface is use to reserve existing or new guest
' Requirements: ->  (+)GUEST_INFO (GITITLE, GIFNAME, GIMI, GILNAME, GIGENDER, GIBDAY, GICOUNTRY, GIZIP, GIADDRESS,GICONTACT,GIEMAIL,GICIVILSTAT,GINAT,GICIT,GIID)
'               ->  (+)COMPANY (CNAME, CADDRESS, CBRANCH, CCONTACTPERSON, CCONTACT, CPOS, CID)
'               ->  (+)GUEST (Gno, GIID, CID)
'               ->  (+)FOLIO_DETAILS (FDNO, FDRECEIPTNO, FDDATE, FDCHARGE, FDMODIFIEDBYAMT, FDMODIFIEDBYPERCENT, FDMODIFIEDCHARGE, FDBALANCE, FDSTAT, RESNO, FDDESC, FDNAME)
'               ->  (+)RESERVATION (RESNO, RESDATE, RESNOROOM, RESGUESTTYPE, RESAMT, RESDOWNPAY, RESBALANCE, RESSTAT, RESNOOCCUPANTS, RESREMARKS, GNO)
'               ->  (+)RESERVATION_DETAILS (RESNO, RMNO, RESDTIMEIN, RESDTIMEOUT, RESDSTAT, RESDNODAYS, RESDBYREQUEST, RESDNOOCCUPANTS)
'               ->  (+)RMSTATUS (RMSID, RMSNAME, RMSSTARTTIME, RMSENDTIME, RMNO, RESNO)
'               ->  (*)GUEST_INFO (GITITLE, GIFNAME, GIMI, GILNAME, GIGENDER, GIBDAY, GICOUNTRY, GIZIP, GIADDRESS,GICONTACT,GIEMAIL,GICIVILSTAT,GINAT,GICIT,GIID)
'               ->  (*)COMPANY (CNAME, CADDRESS, CBRANCH, CCONTACTPERSON, CCONTACT, CPOS, CID)
'               ->  Guest to be reserved
'               ->  Room to be reserved
' Results:      ->  New guest is added to the GUEST_INFO table
'               ->  New company is added to the COMPANY table
'               ->  A reservation is given to a guest

Public Class frmReservation

#Region "Declarations"
    Private objAdapter As SqlDataAdapter
    Private objRoomDataView As New DataView
    Private objDataView As New DataView
    Private objDataSet As DataSet
    Private objDataTable As DataTable
    Private objDataRow As DataRow
    Private objDataGridViewRow As DataGridViewRow
    Private strDownPayment As String
    Private gstrCompany As String
    Private gstrGuest As String

#End Region

#Region "Guest Information"

    Private Sub chkGuestInfoCompanyGroup_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGuestInfoCompanyGroup.CheckedChanged
        'USE TO SET THE RESERVATION WITH COMPANY

        If chkGuestInfoCompanyGroup.Checked Then

            grpCompanyGroupInformation.Enabled = True
            lblReservationCID.Tag = "new"
            radCompanyInfoNew.Checked = True

        Else

            grpCompanyGroupInformation.Enabled = False
            lblReservationCID.Tag = "none"

        End If

    End Sub

    Private Sub radCompanyInfoPreviousCompany_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radCompanyInfoPreviousCompany.CheckedChanged
        'FILLS THE VIEW WITH THE PREVIOUS COMPANY OF THE CURRENT GUEST

        If radCompanyInfoPreviousCompany.Checked Then

            Using objDatabaseConnection As SqlConnection = SetUpConnection(DatabasePath, True)

                Try

                    objAdapter = New SqlDataAdapter("SELECT dbo.COMPANY.CName 'Company', dbo.COMPANY.CContactPerson 'Contact Person', dbo.COMPANY.CPos 'Position', dbo.COMPANY.CContact 'Contact Number', dbo.COMPANY.CAddress 'Address', dbo.COMPANY.CBranch 'Branch', dbo.COMPANY.CID 'Company ID' " & _
                                                    "FROM dbo.COMPANY INNER JOIN dbo.GUEST ON dbo.COMPANY.CID = dbo.GUEST.CID INNER JOIN dbo.GUEST_INFO ON dbo.GUEST.GIID = dbo.GUEST_INFO.GIID " & _
                                                    "WHERE (dbo.GUEST.GIID = '" & lblReservationGIID.Text & "')", objDatabaseConnection)
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
                    lblReservationCID.DataBindings.Add("Text", objDataView, "Company ID")

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
                    lblReservationCID.DataBindings.Add("Text", objDataView, "Company ID")

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
            lblReservationCID.Text = "new"

        End If

    End Sub

    Private Sub btnGuestInfoClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuestInfoClear.Click
        'USE TO RESET THE ENTRY OF GUEST INFORMATION

        clearGuestInfoTab()

    End Sub

    Private Sub lblReservationGIID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblReservationGIID.TextChanged
        'DETERMINES WEATHER THE GUEST IS OLD OR NEW AND FILLS THE INFORMATION OF THE GUEST

        gstrGuest = String.Empty

        If lblReservationGIID.Text <> "new" Then

            lblReservationGIID.Tag = "old"

            Using objDatabaseConnection As SqlConnection = SetUpConnection(DatabasePath, True)

                Try

                    objAdapter = New SqlDataAdapter("SELECT * " & _
                                                    "FROM GUEST_INFO " & _
                                                    "WHERE GIID = '" & lblReservationGIID.Text & "';", objDatabaseConnection)
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

    Private Sub lblReservationCID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblReservationCID.TextChanged
        'MAPS THE APPROPRIATE TAG OF THE CID

        gstrCompany = String.Empty

        If lblReservationCID.Text <> "new" Then

            lblReservationCID.Tag = "old"

            Using objDatabaseConnection As SqlConnection = SetUpConnection(DatabasePath, True)

                Try

                    objAdapter = New SqlDataAdapter("SELECT * " & _
                                                    "FROM COMPANY " & _
                                                    "WHERE CID = '" & lblReservationCID.Text & "';", objDatabaseConnection)
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

            lblReservationCID.Tag = "none"

        Else
            lblReservationCID.Tag = "new"

        End If

    End Sub

    Private Sub txtGuestInfoFirstName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGuestInfoFirstName.TextChanged
        'DISPLAYS THE FIRSTNAME OF THE GUEST

        lblNameOfGuest.Text = txtGuestInfoFirstName.Text & " " & txtGuestInfoLastName.Text

    End Sub

    Private Sub txtGuestInfoLastName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGuestInfoLastName.TextChanged
        'DISPLAYS THE LASTNAME OF THE GUEST

        lblNameOfGuest.Text = txtGuestInfoFirstName.Text & " " & txtGuestInfoLastName.Text

    End Sub

#End Region

#Region "Reservation Information"

    Private Sub btnAddRoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddRoom.Click
        'USE FOR ADDING NEW ROOM FOR THE GUEST

        If dgvRoomVacancySearch.SelectedRows.Count > 0 Then

            For Each objDataGridViewRow In dgvGuestRooms.Rows

                If lblRoomNumber.Text = objDataGridViewRow.Cells(0).Value.ToString Then

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

    Private Sub btnRemoveRoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveRoom.Click
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

    Private Sub btnReservationSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReservationSave.Click
        'THIS IS USE TO SAVE THE RESERVATION ALONG WITH THE NECESSARY INFORMATION

        ReservationSave()

    End Sub

    Private Sub btnViewDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewDetails.Click

        Display(Forms.frmRoomRack)

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'USE TO RESET THE RESERVATION INFORMATION

        clearReservationInfoTab()

    End Sub

    Private Sub dtpCheckInDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpCheckInDate.ValueChanged
        'ADJUSTS THE VALUE OF THE NUMBER OF NIGHTS WHEN THE DATE TIME PICKER IS USED TO SET IT

        dtpCheckOutDate.MinDate = dtpCheckInDate.Value.Date
        dtpCheckOutDate.Value = dtpCheckInDate.Value.Date.AddDays(1)
        lblNumberOfNights.Text = (dtpCheckOutDate.Value - dtpCheckInDate.Value).Days.ToString

    End Sub

    Private Sub dtpCheckOutDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpCheckOutDate.ValueChanged
        'ADJUSTS THE VALUE OF THE NUMBER OF NIGHTS WHEN THE DATE TIME PICKER IS USED TO SET IT

        lblNumberOfNights.Text = (dtpCheckOutDate.Value - dtpCheckInDate.Value).Days.ToString

    End Sub



    Private Sub btnRoomVacancySearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRoomVacancySearch.Click, dtpCheckInDate.LostFocus, dtpCheckInTime.LostFocus, dtpCheckOutDate.LostFocus, dtpCheckOutTime.LostFocus
        ' USE TO SEARCH THE ROOMS WITH FILTER

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

        lblReservationGIID.Text = SearchedGuestID

    End Sub

    Private Sub tsbGuestSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuestSearch.Click
        'OPENS THE GUEST SEARCH FORM

        TriggeredBy = TriggeringForm.Reservation
        frmGuestSearch.ShowDialog()

    End Sub

    Private Sub tsbUpdateReservation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbUpdateReservation.Click
        'OPENS THE UPDATE RESERVATION FORM

        Display(Forms.frmUpdateReservation)

    End Sub

    Private Sub tsbPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbPayment.Click

        Display(Forms.frmPayment)

    End Sub

    Private Sub frmReservation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'GETS THE VALUE OF THE DEFAULT RESERVATION DOWN PAYMENT, RESOURCE LOCATOR, GUEST ID AND LOADS COUNTRY LIST

        LoadComboBox(cboGuestInfoCountry, cboGuestInfoCivilStatus, cboRoomType, cboFloor, cboView, cboGuestType)

        Using objDatabaseConnection As SqlConnection = SetUpConnection(DatabasePath, True)

            Try

                objAdapter = New SqlDataAdapter("SELECT ResDownPaymentPercentage FROM SYSTEM", objDatabaseConnection)
                objDataSet = SetUpDataSet(objAdapter, "qryReservationDownpayment")
                objDataRow = objDataSet.Tables("qryReservationDownpayment").Rows(0)
                strDownPayment = objDataRow.Item(0).ToString

            Catch ex As Exception

                Msg("1096")

            End Try

        End Using

        lblResourceLocator.Text = GetPreKeyGen("Reservation") & GetPrimaryKeyNo("Reservation")
        lblReservationGNO.Text = GetPreKeyGen("Guest") & GetPrimaryKeyNo("Guest")

        dtpCheckInDate.Value = Now.Date
        dtpCheckOutDate.Value = dtpCheckInDate.Value.AddDays(1)
        dtpCheckOutDate.MinDate = dtpCheckInDate.Value.Date
        dtpCheckInDate.MinDate = Now.Date
        dtpDateOfReservation.Value = Now.Date
        dtpDateOfReservation.MinDate = Now.Date

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

    Private Sub AddRoomToList()
        'USE TO ADD THE ROOM SELECTED TO THE GUEST ROOM

        dgvGuestRooms.Rows.Add(lblRoomNumber.Text, lblRoomRate.Text, dgvRoomVacancySearch.SelectedRows.Item(0).Cells(1).Value.ToString, txtNoOfOccupants.Text, lblNumberOfNights.Text, dtpCheckInDate.Value.Date & " " & dtpCheckInTime.Value.ToShortTimeString, dtpCheckOutDate.Value.Date & " " & dtpCheckOutTime.Value.ToShortTimeString, chkRoomByRequest.Checked)
        frmParent.tssStatus.Text = "New room added"
        dgvRoomVacancySearch.Rows.Remove(dgvRoomVacancySearch.SelectedRows(0))

    End Sub

    Private Function GuestInfoCompare() As Boolean
        'USE TO DETERMINE IF CHANGES HAS BEEN DONE TO THE GUEST INFORMATION
        'if the value returned is true there are changes

        Dim strBirthDay As String

        If lblReservationGIID.Tag.ToString = "old" Then

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
        If lblReservationCID.Tag.ToString = "old" Then

            If AllTrimNoSpace(gstrCompany).ToUpper = AllTrimNoSpace((txtCompanyInfoCompanyName.Text & txtCompanyInfoAddress.Text & txtCompanyInfoBranch.Text & _
               txtCompanyInfoContactPerson.Text & txtCompanyInfoContactNo.Text & txtCompanyInfoPosition.Text).ToUpper) Then

                Return False
            Else

                Return True
            End If

        End If

    End Function

    Private Sub SearchRoomLoad(ByVal strRoomNo As String)

        objRoomDataView = SearchRoom(dtpCheckInDate.Value.Date & " " & dtpCheckInTime.Value.ToLongTimeString, dtpCheckOutDate.Value.Date & " " & dtpCheckOutTime.Value.ToLongTimeString, "res")
        dgvRoomVacancySearch.DataSource = objRoomDataView
        objRoomDataView.RowFilter = "[Room Number]NOT IN (" & strRoomNo & ")"
        dgvRoomVacancySearch.Sort(dgvRoomVacancySearch.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
        lblSearchResult.Text = dgvRoomVacancySearch.RowCount.ToString

    End Sub

    Private Sub LabelUpdate()

        lblNumberOfRooms.Text = CStr(dgvGuestRooms.Rows.Count)
        lblNumberOfOccupants.Text = "0"
        lblTotalAmount.Text = "0"

        For Each objDataGridViewRow In dgvGuestRooms.Rows

            lblNumberOfOccupants.Text = (CInt(lblNumberOfOccupants.Text) + CInt(objDataGridViewRow.Cells(3).Value.ToString())).ToString
            lblTotalAmount.Text = (CDbl(lblTotalAmount.Text) + (CDbl(objDataGridViewRow.Cells(1).Value.ToString()) * CDbl(objDataGridViewRow.Cells(4).Value.ToString()))).ToString("n")

        Next

        lblDownPayment.Text = (CDbl(lblTotalAmount.Text.ToString) * (CDbl(strDownPayment) / 100)).ToString("n")

    End Sub

    Private Sub dtpDate_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDateOfReservation.Leave, dtpCheckInDate.Leave

        Dim dtpdate As DateTimePicker

        dtpdate = CType(sender, DateTimePicker)
        CheckDate(dtpdate)

    End Sub

    Private Function RequiredFields() As Boolean

        Dim value As Boolean = False

        If Trim(txtGuestInfoFirstName.Text) = String.Empty Then

            tbcReservation.SelectedIndex = 0
            txtGuestInfoFirstName.Focus()
            Return True
            Exit Function

        ElseIf Trim(txtGuestInfoAddress.Text) = String.Empty Then

            tbcReservation.SelectedIndex = 0
            txtGuestInfoAddress.Focus()
            Return True
            Exit Function

        End If

        If chkGuestInfoCompanyGroup.Checked = True Then

            If Trim(txtCompanyInfoCompanyName.Text) = String.Empty Then
                tbcReservation.SelectedIndex = 0
                txtCompanyInfoCompanyName.Focus()
                Return True
                Exit Function

            ElseIf Trim(txtCompanyInfoContactPerson.Text) = String.Empty Then
                tbcReservation.SelectedIndex = 0
                txtCompanyInfoContactPerson.Focus()
                Return True
                Exit Function

            ElseIf Trim(txtCompanyInfoContactNo.Text) = String.Empty Then
                tbcReservation.SelectedIndex = 0
                txtCompanyInfoContactNo.Focus()
                Return True
                Exit Function

            End If

        End If

        Return False

    End Function

    Private Sub tbpReservationInformation_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbpReservationInformation.Enter

        SearchRoomLoad("''")

    End Sub

    Private Sub clearGuestInfoTab()

        ClearControls(grpGuestInformation)
        ClearControls(pnlCompanyGroupInformation)
        lblNameOfGuest.Text = String.Empty
        lblReservationGIID.Text = "new"
        lblReservationCID.Text = "new"
        lblReservationGNO.Text = GetPreKeyGen("Guest") & GetPrimaryKeyNo("Guest")
        chkGuestInfoCompanyGroup.Checked = False
        dgvCompanyGroupInformation.DataSource = vbNull
        dtpGuestInfoBirthDate.Checked = False

    End Sub

    Private Sub clearReservationInfoTab()

        ClearControls(gbxRoomReservationDetails, lblNumberOfNights)
        dgvGuestRooms.Rows.Clear()
        LabelUpdate()
        dtpDateOfReservation.Value = Now.Date
        dtpCheckInDate.Value = Now.Date
        dtpCheckInTime.Text = "12:00:00 PM"
        dtpCheckOutTime.Text = "11:59:00 AM"
        txtRoomNumber.Text = String.Empty
        cboRoomType.Text = String.Empty
        cboFloor.Text = String.Empty
        cboView.Text = String.Empty
        cboGuestType.Text = String.Empty
        SearchRoomLoad("''")

    End Sub

    Private Sub ReservationSave()

        If noRequiredMissing() = False Then

            Exit Sub

        Else

            txtEntries()
            Dim strCase As String = lblReservationGIID.Tag.ToString & lblReservationCID.Tag.ToString
            Dim strInsertIntoGuestInfo As String = "INSERT INTO GUEST_INFO (GITITLE, GIFNAME, GIMI, GILNAME, GIGENDER, GIBDAY, GICOUNTRY, GIZIP, GIADDRESS,GICONTACT,GIEMAIL,GICIVILSTAT,GINAT,GICIT,GIID) " & _
                                                   "VALUES (@gititle, @gifname, @gimi, @gilname, @gigender, @gibday,@gicountry, @gizip, @giaddress, @gicontact, @giemail,@gicivilstat, @ginat, @gicit,@giid );"
            Dim strInsertIntoCompany As String = "INSERT INTO COMPANY (CNAME, CADDRESS, CBRANCH, CCONTACTPERSON, CCONTACT, CPOS, CID)" & _
                                                 " VALUES (@cname, @caddress, @cbranch, @ccontactperson, @ccontact,@cpos,@cid);"
            Dim strInsertIntoGuest As String = "INSERT INTO GUEST (Gno, GIID, CID)" & _
                                               " VALUES (@gno, @giid, @cid);"
            Dim strInsertIntoFolioDetails As String = "INSERT INTO FOLIO_DETAILS (FDNO, FDRECEIPTNO, FDDATE, FDCHARGE, FDMODIFIEDBYAMT, FDMODIFIEDBYPERCENT, FDMODIFIEDCHARGE, FDBALANCE, FDSTAT, RESNO, FDDESC, FDNAME) " & _
                                                      "VALUES (@fdno, @fdno, @resdate, @resbalance, '0', '0',  @resbalance, @resbalance, @fdstatus, @resno, 'DOWNPAYMENT', 'RESERVATION DOWNPAYMENT');"
            Dim strInsertIntoReservation As String = "INSERT INTO RESERVATION (RESNO, RESDATE, RESNOROOM, RESGUESTTYPE, RESAMT, RESDOWNPAY, RESBALANCE, RESSTAT, RESNOOCCUPANTS, RESREMARKS, GNO) " & _
                                                     "VALUES (@resno, @resdate, @resnoroom, @resguesttype, @resamt, @resdownpay, @resbalance, @resstat, @resnooccupants, @resremarks, @gno );"
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
                                               "WHERE GIID = '" & lblReservationGIID.Text & "';"
            Dim strupdateCompanyInfo As String = "UPDATE COMPANY SET " & _
                                               "CNAME = @cname ," & _
                                               "CADDRESS = @caddress ," & _
                                               "CBRANCH = @cbranch ," & _
                                               "CCONTACTPERSON = @ccontactperson ," & _
                                               "CCONTACT = @ccontact ," & _
                                               "CPOS = @cpos " & _
                                               "WHERE CID = '" & lblReservationCID.Text & "';"

            Using objReservationSaveConnection As SqlConnection = SetUpConnection(DatabasePath, True)

                If objReservationSaveConnection.State = ConnectionState.Closed Then objReservationSaveConnection.Open()

                Using objTransaction As SqlTransaction = objReservationSaveConnection.BeginTransaction

                    Using objCommand As SqlCommand = objReservationSaveConnection.CreateCommand

                        With objCommand
                            .Transaction = objTransaction

                            Try

                                With .Parameters

                                    .AddWithValue("@gno", lblReservationGNO.Text)
                                    .AddWithValue("@resno", lblResourceLocator.Text)
                                    .AddWithValue("@gititle", txtGuestInfoTitle.Text)
                                    .AddWithValue("@gifname", txtGuestInfoFirstName.Text)
                                    .AddWithValue("@gimi", txtGuestInfoMiddleInitial.Text)
                                    .AddWithValue("@gilname", txtGuestInfoLastName.Text)
                                    .AddWithValue("@gigender", cboGuestInfoGender.Text)

                                    If dtpGuestInfoBirthDate.Checked = False Then

                                        .AddWithValue("@gibday", String.Empty)

                                    Else

                                        .AddWithValue("@gibday", dtpGuestInfoBirthDate.Value)

                                    End If

                                    .AddWithValue("@gicountry", cboGuestInfoCountry.Text)
                                    .AddWithValue("@gizip", txtGuestInfoZipCode.Text)
                                    .AddWithValue("@giaddress", txtGuestInfoAddress.Text)
                                    .AddWithValue("@gicontact", txtGuestInfoContactNo.Text)
                                    .AddWithValue("@giemail", txtGuestInfoEmail.Text)
                                    .AddWithValue("@gicivilstat", cboGuestInfoCivilStatus.Text)
                                    .AddWithValue("@ginat", txtGuestInfoNationality.Text)
                                    .AddWithValue("@gicit", txtGuestInfoCitezenship.Text)

                                    If lblReservationGIID.Tag.ToString = "new" Then

                                        .AddWithValue("@giid", GetPreKeyGen("GuestInfo") & GetPrimaryKeyNo("GuestInfo"))

                                    Else

                                        .AddWithValue("@giid", lblReservationGIID.Text)

                                    End If

                                    .AddWithValue("@cname", txtCompanyInfoCompanyName.Text)
                                    .AddWithValue("@caddress", txtCompanyInfoAddress.Text)
                                    .AddWithValue("@cbranch", txtCompanyInfoBranch.Text)
                                    .AddWithValue("@ccontactperson", txtCompanyInfoContactPerson.Text)
                                    .AddWithValue("@ccontact", txtCompanyInfoContactNo.Text)
                                    .AddWithValue("@cpos", txtCompanyInfoPosition.Text)

                                    If lblReservationCID.Tag.ToString = "new" Then

                                        .AddWithValue("@cid", GetPreKeyGen("Company") & GetPrimaryKeyNo("Company"))

                                    ElseIf lblReservationCID.Tag.ToString = "none" Then

                                        .AddWithValue("@cid", DBNull.Value)

                                    Else

                                        .AddWithValue("@cid", lblReservationCID.Text)

                                    End If

                                    .AddWithValue("@resdate", dtpDateOfReservation.Value.Date)
                                    .AddWithValue("@resnoroom", lblNumberOfRooms.Text)
                                    .AddWithValue("@resguesttype", cboGuestType.Text)
                                    .AddWithValue("@resamt", lblTotalAmount.Text)
                                    .AddWithValue("@resdownpay", lblDownPayment.Text)
                                    .AddWithValue("@resbalance", lblTotalAmount.Text)
                                    .AddWithValue("@resstat", "RESERVED")
                                    .AddWithValue("@resnooccupants", lblNumberOfOccupants.Text)
                                    .AddWithValue("@resremarks", txtRemarks.Text)
                                    .AddWithValue("@resdstat", "RESERVED")
                                    .AddWithValue("@rmsname", "VACANT")
                                    .AddWithValue("@fdno", GetPrimaryKeyNo("FDNo"))
                                    .AddWithValue("@fdstatus", "UNPAID")
                                    .AddWithValue("@fdnocharge", lblDownPayment.Text)

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
                                .CommandText = strInsertIntoReservation
                                .ExecuteNonQuery()
                                IncrementPrimaryKeyNo("Reservation")
                                .CommandText = strInsertIntoFolioDetails
                                .ExecuteNonQuery()
                                IncrementPrimaryKeyNo("FDNo")

                                For Each objDataGridViewRow In dgvGuestRooms.Rows

                                    .CommandText = "INSERT INTO RESERVATION_DETAILS (RESNO, RMNO, RESDTIMEIN, RESDTIMEOUT, RESDSTAT, RESDNODAYS, RESDBYREQUEST, RESDNOOCCUPANTS) " & _
                                                   "VALUES (@resno, '" & objDataGridViewRow.Cells(0).Value.ToString & "' , '" & objDataGridViewRow.Cells(5).Value.ToString & "' , '" & objDataGridViewRow.Cells(6).Value.ToString & "' , @resdstat, '" & objDataGridViewRow.Cells(4).Value.ToString & "' , '" & chkRoomByRequest.Checked & "' , '" & objDataGridViewRow.Cells(3).Value.ToString & "' );"
                                    .ExecuteNonQuery()
                                    .CommandText = "INSERT INTO RMSTATUS (RMSID, RMSNAME, RMSSTARTTIME, RMSENDTIME, RMNO, RESNO) " & _
                                                  "VALUES ( '" & GetPrimaryKeyNo("RMStatus") & "' , @resdstat, '" & objDataGridViewRow.Cells(5).Value.ToString & "' , '" & objDataGridViewRow.Cells(6).Value.ToString & "' , '" & objDataGridViewRow.Cells(0).Value.ToString & "',@resno );"
                                    .ExecuteNonQuery()
                                    IncrementPrimaryKeyNo("RMStatus")

                                Next

                                objTransaction.Commit()
                                lblResourceLocator.Text = GetPreKeyGen("Reservation") & GetPrimaryKeyNo("Reservation")
                                lblReservationGNO.Text = GetPreKeyGen("Guest") & GetPrimaryKeyNo("Guest")
                                Msg("1032")
                                clearGuestInfoTab()
                                clearReservationInfoTab()
                                tbcReservation.SelectedIndex = 0

                            Catch ex As Exception

                                objTransaction.Rollback()
                                Msg("1054", , "Reservation transaction will be reset" & NWLN & ex.Message)
                                clearGuestInfoTab()
                                clearReservationInfoTab()

                            End Try

                        End With

                    End Using

                End Using

            End Using

        End If

    End Sub

    Private Sub frmReservation_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing


        If lblReservationGIID.Text <> "new" Then

            Select Case Msg("1033", Button.YesNoCancel)

                Case ButtonClicked.Yes
                    ReservationSave()

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

            Msg("1039", , "No room to be reserved")
            tbcReservation.SelectedIndex = 1

            Return False

        Else

            Return True

        End If

    End Function

    Public Sub addValue(ByVal strRoom As String, ByVal strCheckInDate As String, ByVal strCheckOutDate As String)

        dtpCheckInDate.Value = CDate(strCheckInDate)
        dtpCheckOutDate.Value = CDate(strCheckOutDate)

        SearchRoomLoad("''")

        Dim blnExit As Boolean = False

        For Each objDataGridViewRow In dgvGuestRooms.Rows

            If strRoom = objDataGridViewRow.Cells(0).Value.ToString Then

                Msg("1002", Button.Ok, "Room already in the list")

                Exit Sub

            End If

        Next

        For Each objDataGridViewRow In dgvRoomVacancySearch.Rows

            blnExit = False

            If strRoom = objDataGridViewRow.Cells(0).Value.ToString Then

                objDataGridViewRow.Selected = True
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

    Private Sub dgvRoomVacancySearch_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvRoomVacancySearch.DoubleClick
        btnAddRoom_Click(Nothing, Nothing)
    End Sub

#End Region

End Class