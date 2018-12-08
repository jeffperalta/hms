Option Explicit On
Option Strict On

Imports System.Data
Imports System.Data.SqlClient

Public Class frmGuestSearch

#Region "Declarations"

    'Multiple searches are delimited by Comma
    Private strSearchString As String
    Private strGIID As String
    Private strCID As String
    Private TrigerredAtDoubleClickAtGuest As Boolean = False
    Private TrigerredAtDoubleClickAtGuestAtCompany As Boolean = False

    Private strDefaultGuestInformationSelectClause As String
    Private strDefaultGuestInformationFromClause As String
    Private strDefaultGuestInformationWhereClause As String
    Private strDefaultGuestInformationConnector As String

    Private strModifiedGuestInformationSelectClause As String
    Private strModifiedGuestInformationFromClause As String
    Private strModifiedGuestInformationWhereClause As String

    Private strDefaultReservationSelectClause As String
    Private strDefaultReservationFromClause As String
    Private strDefaultReservationWhereClause As String
    Private strDefaultReservationGroupByClause As String
    Private strDefaultReservationConnector As String

    Private strModifiedReservationSelectClause As String
    Private strModifiedReservationFromClause As String
    Private strModifiedReservationWhereClause As String
    Private strModifiedReservationGroupByClause As String

    Private strDefaultRegistrationSelectClause As String
    Private strDefaultRegistrationFromClause As String
    Private strDefaultRegistrationWhereClause As String
    Private strDefaultRegistrationGroupByClause As String
    Private strDefaultRegistrationConnector As String

    Private strModifiedRegistrationSelectClause As String
    Private strModifiedRegistrationFromClause As String
    Private strModifiedRegistrationWhereClause As String
    Private strModifiedRegistrationGroupByClause As String

    Private strDefaultCompanySelectClause As String
    Private strDefaultCompanyFromClause As String
    Private strDefaultCompanyWhereClause As String
    Private strDefaultCompanyGroupByClause As String

    Private strModifiedCompanySelectClause As String
    Private strModifiedCompanyFromClause As String
    Private strModifiedCompanyWhereClause As String
    Private strModifiedCompanyGroupByClause As String
#End Region

#Region "MISC"

    Private Sub frmGuestSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Read the default view from the registry
        ReadFromRegistry()

        'Clear the variables at the guest search module
        'This marks a new guest search
        ClearPreviousSearchResults()

        dgvGuestInformation.AlternatingRowsDefaultCellStyle = SetAlternatingColor()
        dgvWithReservation.AlternatingRowsDefaultCellStyle = SetAlternatingColor()
        dgvWithRegistration.AlternatingRowsDefaultCellStyle = SetAlternatingColor()
        dgvCompany.AlternatingRowsDefaultCellStyle = SetAlternatingColor()

        'Update combo boxes
        Using objConnection As SqlConnection = SetUpConnection(DatabasePath(), True)
            objConnection.Open()

            With cboCriteriaGITitle
                .DataSource = Nothing
                .DataSource = SetUpDataSet(SetUpDataAdapter(objConnection, "SELECT DISTINCT GITitle FROM GUEST_INFO WHERE (NOT(GITitle IS NULL)); ", DatabaseTransactionState.SelectState), "List").Tables("List")
                .DisplayMember = "GITitle"
                .SelectedIndex = -1
            End With

            With cboCriteriaGICit
                .DataSource = Nothing
                .DataSource = SetUpDataSet(SetUpDataAdapter(objConnection, "SELECT DISTINCT GICit FROM GUEST_INFO WHERE (NOT(GICit IS NULL)); ", DatabaseTransactionState.SelectState), "List").Tables("List")
                .DisplayMember = "GICit"
                .SelectedIndex = -1
            End With

            With cboCriteriaGICountry
                .DataSource = Nothing
                .DataSource = SetUpDataSet(SetUpDataAdapter(objConnection, "SELECT DISTINCT GICountry FROM GUEST_INFO WHERE (NOT(GICountry IS NULL)); ", DatabaseTransactionState.SelectState), "List").Tables("List")
                .DisplayMember = "GICountry"
                .SelectedIndex = -1
            End With

            With cboCriteriaGIGender
                .DataSource = Nothing
                .DataSource = SetUpDataSet(SetUpDataAdapter(objConnection, "SELECT DISTINCT GIGender FROM GUEST_INFO WHERE (NOT(GIGender IS NULL)); ", DatabaseTransactionState.SelectState), "List").Tables("List")
                .DisplayMember = "GIGender"
                .SelectedIndex = -1
            End With

            With cboCriteriaGINat
                .DataSource = Nothing
                .DataSource = SetUpDataSet(SetUpDataAdapter(objConnection, "SELECT DISTINCT GINat FROM GUEST_INFO WHERE (NOT(GINat IS NULL)); ", DatabaseTransactionState.SelectState), "List").Tables("List")
                .DisplayMember = "GINat"
                .SelectedIndex = -1
            End With

            With cboCriteriaResGuestType
                .DataSource = Nothing
                .DataSource = SetUpDataSet(SetUpDataAdapter(objConnection, "SELECT DISTINCT ResGuestType FROM RESERVATION WHERE (NOT(ResGuestType IS NULL)); ", DatabaseTransactionState.SelectState), "List").Tables("List")
                .DisplayMember = "ResGuestType"
                .SelectedIndex = -1
            End With

            With cboCriteriaRegGuestType
                .DataSource = Nothing
                .DataSource = SetUpDataSet(SetUpDataAdapter(objConnection, "SELECT DISTINCT RegGuestType FROM REGISTRATION WHERE (NOT(RegGuestType IS NULL)); ", DatabaseTransactionState.SelectState), "List").Tables("List")
                .DisplayMember = "RegGuestType"
                .SelectedIndex = -1
            End With

            objConnection.Close()
        End Using

        'Initial contents of guest list

        lblCountGuestInformation.Text = ListItems(DatabasePath, ConstructGuestInformationSearchString(), dgvGuestInformation).ToString

    End Sub

    Private Sub txtSearchPhrase_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchPhrase.TextChanged

        TrigerredAtDoubleClickAtGuest = False
        TrigerredAtDoubleClickAtGuestAtCompany = False

        Dim strCommandString As String = String.Empty

        Select Case tbcGuestSearch.SelectedIndex
            Case 0 'Guest Information
                lblCountGuestInformation.Text = ListItems(DatabasePath, ConstructGuestInformationSearchString(), dgvGuestInformation).ToString
            Case 1 'Company information
                lblCountCompany.Text = ListItems(DatabasePath, ConstructCompanyInformationSearchString, dgvCompany).ToString
            Case 2 'search reservation
                lblCountWithReservation.Text = ListItems(DatabasePath, ConstructReservationInformationSearchString(), dgvWithReservation).ToString
            Case 3 'search at registration
                lblCountWithRegistration.Text = ListItems(DatabasePath, ConstructRegistrationInformationSearchString, dgvWithRegistration).ToString
        End Select

    End Sub

    Private Sub tbcGuestSearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbcGuestSearch.SelectedIndexChanged

        Select Case tbcGuestSearch.SelectedIndex
            Case 0 'Guest information
                tbcOption.SelectedIndex = 0
            Case 1 'Guest information
                tbcOption.SelectedIndex = 0
            Case 2 'Reservation
                tbcOption.SelectedIndex = 1
            Case 3 'Registration
                tbcOption.SelectedIndex = 2
        End Select

        txtSearchPhrase.SelectAll()
        txtSearchPhrase.Focus()

        'Display what is in the search phrase textbox
        If Not TrigerredAtDoubleClickAtGuestAtCompany And Not TrigerredAtDoubleClickAtGuest Then
            btnDisplay_Click(Nothing, Nothing)
        End If

    End Sub

    Private Sub radResSpecifyDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radResSpecifyDate.CheckedChanged
        dtpResSpecifyDateTo.Enabled = radResSpecifyDate.Checked
        dtpResSpecifyDateFrom.Enabled = radResSpecifyDate.Checked
    End Sub

    Private Sub radRegSpecifyDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radRegSpecifyDate.CheckedChanged
        dtpRegSpecifyDateTo.Enabled = radRegSpecifyDate.Checked
        dtpRegSpecifyDateFrom.Enabled = radRegSpecifyDate.Checked
    End Sub

#End Region

#Region "Construct SQL"

    Private Sub RefreshToDefault()

        strSearchString = txtSearchPhrase.Text

        'Ensure the GIID as at the first column since this is used in viewing the information
        'for the reservation and registrations.
        strDefaultGuestInformationSelectClause = "SELECT DISTINCT GUEST_INFO.GIID AS [Guest ID], GIFName AS [First Name], GILName AS [Last Name] "
        strDefaultGuestInformationFromClause = "FROM GUEST RIGHT OUTER JOIN GUEST_INFO ON GUEST.GIID = GUEST_INFO.GIID "

        If TrigerredAtDoubleClickAtGuestAtCompany Then
            strSearchString = String.Empty
        End If

        strDefaultGuestInformationWhereClause = "WHERE ((GUEST_INFO.GIFName LIKE '" & strSearchString & "%')  OR (GUEST_INFO.GILName LIKE '" & strSearchString & "%')) "

        If TrigerredAtDoubleClickAtGuestAtCompany Then
            strDefaultGuestInformationWhereClause += " AND GUEST.CID = '" & strCID & "' "
        End If

        If chkDisplayGuestWithRegistration.Checked Or chkDisplayGuestWithReservation.Checked Then
            strDefaultGuestInformationWhereClause += " AND "

            If chkDisplayGuestWithRegistration.Checked Then
                If chkDisplayGuestWithReservation.Checked Then
                    strDefaultGuestInformationWhereClause += " ( "
                End If

                strDefaultGuestInformationWhereClause += " (GUEST.GNo IN  (SELECT GNo FROM REGISTRATION)) "

            End If

            If chkDisplayGuestWithReservation.Checked Then
                If chkDisplayGuestWithRegistration.Checked Then
                    strDefaultGuestInformationWhereClause += " OR "
                End If

                strDefaultGuestInformationWhereClause += " (GUEST.GNo IN  (SELECT GNo FROM RESERVATION)) "

                If chkDisplayGuestWithRegistration.Checked Then
                    strDefaultGuestInformationWhereClause += " ) "
                End If
            End If

        End If


        strModifiedGuestInformationSelectClause = strDefaultGuestInformationSelectClause
        strModifiedGuestInformationFromClause = strDefaultGuestInformationFromClause
        strModifiedGuestInformationWhereClause = strDefaultGuestInformationWhereClause

        If chkGIExactMatches.Checked Then
            strDefaultGuestInformationConnector = " AND "
        Else
            strDefaultGuestInformationConnector = " OR "
        End If


        strDefaultReservationSelectClause = "SELECT RESERVATION.ResNo AS [Record Locator], GUEST_INFO.GIID AS [Guest ID], " & _
                                            "GUEST_INFO.GIFName AS [First Name], GUEST_INFO.GILName AS [LastName], COMPANY.CID AS [Company ID], " & _
                                            "MIN(RESERVATION_DETAILS.ResDTimeIn) AS [Check In Date],  MAX(RESERVATION_DETAILS.ResDTimeOut) AS [Check Out Date] "
        'Modify From clause to include reservation details
        strDefaultReservationFromClause = "FROM RESERVATION_DETAILS RIGHT OUTER JOIN " & _
                                          "RESERVATION ON RESERVATION_DETAILS.ResNo = RESERVATION.ResNo LEFT OUTER JOIN " & _
                                          "GUEST INNER JOIN " & _
                                          "GUEST_INFO ON GUEST.GIID = GUEST_INFO.GIID ON RESERVATION.GNo = GUEST.GNo LEFT OUTER JOIN " & _
                                          "COMPANY ON GUEST.CID = COMPANY.CID "
        If TrigerredAtDoubleClickAtGuest = True Then 'The user uses the datagridvied to display items at reservation
            strDefaultReservationWhereClause = "WHERE GUEST.GIID = '" & strGIID & "' "
        Else 'Triggered when the btnDisplay buttom is clicked or the select all
            strDefaultReservationWhereClause = "WHERE ((GUEST_INFO.GIFName LIKE '" & strSearchString & "%')  OR (GUEST_INFO.GILName LIKE '" & strSearchString & "%')) "
        End If

        strDefaultReservationGroupByClause = "GROUP BY RESERVATION.ResNo, GUEST_INFO.GIID, GUEST_INFO.GIFName, GUEST_INFO.GILName, COMPANY.CID "

        strModifiedReservationSelectClause = strDefaultReservationSelectClause
        strModifiedReservationFromClause = strDefaultReservationFromClause
        strModifiedReservationWhereClause = strDefaultReservationWhereClause
        strModifiedReservationGroupByClause = strDefaultReservationGroupByClause

        If chkCriteriaResExactMatches.Checked Then
            strDefaultReservationConnector = " AND "
        Else
            strDefaultReservationConnector = " OR "
        End If

        strDefaultRegistrationSelectClause = "SELECT REGISTRATION.RegNo AS [Registration No], GUEST_INFO.GIID AS [Guest ID], " & _
                                             "GUEST_INFO.GIFName AS [First Name], GUEST_INFO.GILName AS [LastName], COMPANY.CID AS [Company ID], " & _
                                             "RESERVATION.ResNo AS [Record Locator], DIRECT_BILLER.DBName AS [Direct Biller Name], " & _
                                             "MIN(REGISTRATION_DETAILS.RegDChkInTime) AS [Check In Date],  MAX(REGISTRATION_DETAILS.RegDChkOutTime) AS [Check Out Date] "
        strDefaultRegistrationFromClause = "FROM REGISTRATION_DETAILS RIGHT OUTER JOIN REGISTRATION ON REGISTRATION_DETAILS.RegNo = REGISTRATION.RegNo " & _
                                            "LEFT OUTER JOIN DIRECT_BILLER ON REGISTRATION.DBID = DIRECT_BILLER.DBID " & _
                                            "LEFT OUTER JOIN GUEST INNER JOIN GUEST_INFO ON GUEST.GIID = GUEST_INFO.GIID " & _
                                            "LEFT OUTER JOIN RESERVATION ON GUEST.GNo = RESERVATION.GNo ON REGISTRATION.GNo = GUEST.GNo " & _
                                            "LEFT OUTER JOIN COMPANY ON GUEST.CID = COMPANY.CID "
        If TrigerredAtDoubleClickAtGuest = True Then 'Triggered when the user double clicks the list of guest information datagridview
            strDefaultRegistrationWhereClause = "WHERE  GUEST.GIID = '" & strGIID & "' "
        Else 'Triggered when the btnDisplay buttom is clicked
            strDefaultRegistrationWhereClause = "WHERE ((GUEST_INFO.GIFName LIKE '" & strSearchString & "%') OR (GUEST_INFO.GILName LIKE '" & strSearchString & "%')) "
        End If

        strDefaultRegistrationGroupByClause = "GROUP BY REGISTRATION.RegNo, GUEST_INFO.GIID, GUEST_INFO.GIFName, GUEST_INFO.GILName, COMPANY.CID, RESERVATION.ResNo, DIRECT_BILLER.DBName "

        strModifiedRegistrationSelectClause = strDefaultRegistrationSelectClause
        strModifiedRegistrationFromClause = strDefaultRegistrationFromClause
        strModifiedRegistrationWhereClause = strDefaultRegistrationWhereClause
        strModifiedRegistrationGroupByClause = strDefaultRegistrationGroupByClause

        If chkCriteriaRegExactMatches.Checked Then
            strDefaultRegistrationConnector = " AND "
        Else
            strDefaultRegistrationConnector = " OR "
        End If


        strDefaultCompanySelectClause = "SELECT     COMPANY.CID AS [Company ID], COMPANY.CName AS Name, COMPANY.CAddress AS Address, COMPANY.CBranch AS Branch,  COUNT(GUEST.GNo) AS [Number of Representatives], " & _
                                        "           COMPANY.CContactPerson AS [Contact Person], COMPANY.CPos AS [Position of Contact Person], COMPANY.CContact AS Contact "
        strDefaultCompanyFromClause = "FROM COMPANY LEFT OUTER JOIN " & _
                                      "     GUEST ON COMPANY.CID = GUEST.CID "
        strDefaultCompanyWhereClause = "WHERE  (COMPANY.CName LIKE '" & strSearchString & "%') "
        strDefaultCompanyGroupByClause = "GROUP BY COMPANY.CID, COMPANY.CName, COMPANY.CAddress, COMPANY.CBranch, COMPANY.CContactPerson, COMPANY.CPos, COMPANY.CContact "

        strModifiedCompanySelectClause = strDefaultCompanySelectClause
        strModifiedCompanyFromClause = strDefaultCompanyFromClause
        strModifiedCompanyWhereClause = strDefaultCompanyWhereClause
        strModifiedCompanyGroupByClause = strDefaultCompanyGroupByClause

    End Sub

    Private Function ConstructGuestInformationSearchString() As String

        RefreshToDefault()

        'Construct The Select Clause

        'Display GIMI
        If chkGIMI.Checked Then
            strModifiedGuestInformationSelectClause += ", GUEST_INFO.GIMI AS [Middle Name] "
        End If

        'Display GITitle
        If chkGITitle.Checked Then
            strModifiedGuestInformationSelectClause += ", GUEST_INFO.GITitle AS [Title] "
        End If

        'Display Address
        If chkGIAddress.Checked Then
            strModifiedGuestInformationSelectClause += ", GUEST_INFO.GIAddress AS [Address] "
        End If

        'Display ZIP
        If chkGIZIP.Checked Then
            strModifiedGuestInformationSelectClause += ", GUEST_INFO.GIZIP AS [ZIP Code] "
        End If

        'Display Country
        If chkGICountry.Checked Then
            strModifiedGuestInformationSelectClause += ", GUEST_INFO.GICountry As [Country] "
        End If

        'Display Contact
        If chkGIContact.Checked Then
            strModifiedGuestInformationSelectClause += ", GUEST_INFO.GIContact AS [Contact] "
        End If

        'Display Citizenship
        If chkGICit.Checked Then
            strModifiedGuestInformationSelectClause += ", GUEST_INFO.GICit AS [Citizenship] "
        End If

        'Display BirthDate
        If chkGIBDay.Checked Then
            strModifiedGuestInformationSelectClause += ", GUEST_INFO.GIBday AS [Birth Date] "
        End If

        'Display Gender
        If chkGIGender.Checked Then
            strModifiedGuestInformationSelectClause += ", GUEST_INFO.GIGender AS [Gender] "
        End If

        'Display Civil Status
        If chkGICivilStat.Checked Then
            strModifiedGuestInformationSelectClause += ", GUEST_INFO.GICivilStat AS [Civil Status] "
        End If

        'Display Nationality
        If chkGINat.Checked Then
            strModifiedGuestInformationSelectClause += ", GUEST_INFO.GINat AS [Nationality] "
        End If

        'Display Email
        If chkGIEmail.Checked Then
            strModifiedGuestInformationSelectClause += ", GUEST_INFO.GIEmail AS [EMail] "
        End If

        'Set FROM clause- ALREADY set when RefreshToDefault is called

        'set WHERE clause

        If Trim(cboCriteriaGITitle.Text) <> String.Empty Then
            strModifiedGuestInformationWhereClause += strDefaultGuestInformationConnector + " GUEST_INFO.GITitle LIKE '%" & cboCriteriaGITitle.Text & "%' " 'Ensure space
            chkGITitle.Checked = True
        End If

        If Trim(cboCriteriaGICit.Text) <> String.Empty Then
            strModifiedGuestInformationWhereClause += strDefaultGuestInformationConnector + " GUEST_INFO.GICit LIKE '%" & cboCriteriaGICit.Text & "%' "
            chkGICit.Checked = True
        End If

        If Trim(cboCriteriaGICountry.Text) <> String.Empty Then
            strModifiedGuestInformationWhereClause += strDefaultGuestInformationConnector + " GUEST_INFO.GICountry LIKE '%" & cboCriteriaGICountry.Text & "%' "
            chkGICountry.Checked = True
        End If

        If Trim(cboCriteriaGIGender.Text) <> String.Empty Then
            strModifiedGuestInformationWhereClause += strDefaultGuestInformationConnector + " GUEST_INFO.GIGender='" & cboCriteriaGIGender.Text & "' "
            chkGIGender.Checked = True
        End If

        If Trim(cboCriteriaGIAddress.Text) <> String.Empty Then
            strModifiedGuestInformationWhereClause += strDefaultGuestInformationConnector + " GUEST_INFO.GIAddress LIKE '%" & cboCriteriaGIAddress.Text & "%' "
            chkGIAddress.Checked = True
        End If

        If Trim(cboCriteriaGICivilStat.Text) <> String.Empty Then
            strModifiedGuestInformationWhereClause += strDefaultGuestInformationConnector + " GUEST_INFO.GICivilStat='" & cboCriteriaGICivilStat.Text & "' "
            chkGICivilStat.Checked = True
        End If

        If Trim(cboCriteriaGINat.Text) <> String.Empty Then
            strModifiedGuestInformationWhereClause += strDefaultGuestInformationConnector + " GUEST_INFO.GINat LIKE '%" & cboCriteriaGINat.Text & "%' "
            chkGINat.Checked = True
        End If

        Return strModifiedGuestInformationSelectClause + " " + strModifiedGuestInformationFromClause + " " + strModifiedGuestInformationWhereClause

    End Function

    Private Function ConstructReservationInformationSearchString() As String
        RefreshToDefault()

        'Construct the SELECT Statement
        If chkResDate.Checked Then
            strModifiedReservationSelectClause += ", RESERVATION.ResDate AS [Reservation Date] " 'Ensure to have space
            strModifiedReservationGroupByClause += ", RESERVATION.ResDate "
        End If

        If chkResAmt.Checked Then
            strModifiedReservationSelectClause += ", RESERVATION.ResAmt AS [Total Amount] "
            strModifiedReservationGroupByClause += ", RESERVATION.ResAmt "
        End If

        If chkResNoRoom.Checked Then
            strModifiedReservationSelectClause += ", RESERVATION.ResNoRoom AS [No. of Rooms] "
            strModifiedReservationGroupByClause += ", RESERVATION.ResNoRoom "
        End If

        If chkResDownPay.Checked Then
            strModifiedReservationSelectClause += ", RESERVATION.ResDownPay AS [Downpayment] "
            strModifiedReservationGroupByClause += ", RESERVATION.ResDownPay "
        End If

        If chkResGuestType.Checked Then
            strModifiedReservationSelectClause += ", RESERVATION.ResGuestType AS [Guest Type] "
            strModifiedReservationGroupByClause += ", RESERVATION.ResGuestType "
        End If

        If chkResBalance.Checked Then
            strModifiedReservationSelectClause += ", RESERVATION.ResBalance AS [Total Balance] "
            strModifiedReservationGroupByClause += ", RESERVATION.ResBalance "
        End If

        If chkResNoOccupants.Checked Then
            strModifiedReservationSelectClause += ", RESERVATION.ResNoOccupants AS [No. of Occupants] "
            strModifiedReservationGroupByClause += ", RESERVATION.ResNoOccupants "
        End If

        If chkResStat.Checked Then
            strModifiedReservationSelectClause += ", RESERVATION.ResStat AS [Status] "
            strModifiedReservationGroupByClause += ", RESERVATION.ResStat "
        End If

        If chkResCName.Checked Then
            strModifiedReservationSelectClause += ", COMPANY.CName AS [Company] "
            strModifiedReservationGroupByClause += ", COMPANY.CName "
        End If

        If chkResCAddress.Checked Then
            strModifiedReservationSelectClause += ", COMPANY.CAddress AS [Company Address] "
            strModifiedReservationGroupByClause += ", COMPANY.CAddress "
        End If

        If chkResCBranch.Checked Then
            strModifiedReservationSelectClause += ", COMPANY.CBranch AS [Company Branch] "
            strModifiedReservationGroupByClause += ", COMPANY.CBranch "
        End If

        If chkResCContactPerson.Checked Then
            strModifiedReservationSelectClause += ", COMPANY.CContactPerson AS [Contact Person] "
            strModifiedReservationGroupByClause += ", COMPANY.CContactPerson "
        End If

        If chkResCPos.Checked Then
            strModifiedReservationSelectClause += ", COMPANY.CPOS AS [Position of Contact Person] "
            strModifiedReservationGroupByClause += ", COMPANY.CPos "
        End If

        If chkResCContact.Checked Then
            strModifiedReservationSelectClause += ", COMPANY.CContact AS [Contact] "
            strModifiedReservationGroupByClause += ", COMPANY.CContact "
        End If

        'Construct the FROM Clause - ALREADY SET whe RefreshToDefault was called

        'Construct the WHERE Clause

        If radResDontRemember.Checked = False Then
            Dim startDate As String = String.Empty
            Dim EndDate As String = Date.Now.ToString

            If radResWithinTheLastWeek.Checked Then
                startDate = Date.Now.AddDays(-7).ToString
            ElseIf radResPastMonth.Checked Then
                startDate = Date.Now.AddMonths(-1).ToString
            ElseIf radResWithinThePastYear.Checked Then
                startDate = Date.Now.AddYears(-1).ToString
            ElseIf radResSpecifyDate.Checked Then
                startDate = dtpResSpecifyDateFrom.Value.ToString
                EndDate = dtpResSpecifyDateTo.Value.ToString
            End If

            '(ResDate BETWEEN CONVERT(DATETIME, '1/14/1985 3:59:00 PM', 102) AND CONVERT(DATETIME, '1/10/2009 3:59:00 AM', 102))
            strModifiedReservationWhereClause += strDefaultReservationConnector + "(RESERVATION.Resdate BETWEEN CONVERT (DATETIME, '" & startDate & "', 102) AND CONVERT(DATETIME, '" & EndDate & "', 102)) "

        End If

        If Trim(txtCriteriaResNo.Text) <> String.Empty Then
            strModifiedReservationWhereClause += strDefaultReservationConnector + " RESERVATION.ResNo='" & txtCriteriaResNo.Text & "' "
        End If

        If Trim(cboCriteriaResStat.Text) <> String.Empty Then
            strModifiedReservationWhereClause += strDefaultReservationConnector + " RESERVATION.ResStat='" & cboCriteriaResStat.Text & "' "
            chkResStat.Checked = True
        End If

        If Trim(cboCriteriaResGuestType.Text) <> String.Empty Then
            strModifiedReservationWhereClause += strDefaultReservationConnector + " RESERVATION.ResGuestType='" & cboCriteriaResGuestType.Text & "' "
            chkResGuestType.Checked = True
        End If

        tssStatus.Text = ""
        If Trim(cboCriteriaResAmt.Text) <> String.Empty Then

            If IsNumeric(txtCriteriaResAmtTo.Text) Then
                If String.Compare("Equal To", Trim(cboCriteriaResAmt.Text), True) = 0 Then
                    strModifiedReservationWhereClause += strDefaultReservationConnector + " RESERVATION.ResAmt = " & CDbl(txtCriteriaResAmtTo.Text).ToString

                ElseIf String.Compare("Greater Than", Trim(cboCriteriaResAmt.Text), True) = 0 Then
                    strModifiedReservationWhereClause += strDefaultReservationConnector + " RESERVATION.ResAmt > " & CDbl(txtCriteriaResAmtTo.Text).ToString

                ElseIf String.Compare("Less Than", Trim(cboCriteriaResAmt.Text), True) = 0 Then
                    strModifiedReservationWhereClause += strDefaultReservationConnector + " RESERVATION.ResAmt < " & CDbl(txtCriteriaResAmtTo.Text).ToString

                ElseIf String.Compare("Within the range of", Trim(cboCriteriaResAmt.Text), True) = 0 Then
                    If IsNumeric(txtCriteriaResAmtFrom.Text) Then
                        strModifiedReservationWhereClause += strDefaultReservationConnector + " RESERVATION.ResAmt BETWEEN " & CDbl(txtCriteriaResAmtTo.Text).ToString & " AND " & CDbl(txtCriteriaResAmtFrom.Text).ToString & " "
                    Else
                        tssStatus.Text = "Reservation amount criteria is ignored because the value is not numeric..."
                    End If
                Else
                    tssStatus.Text = "Reservation amount criteria is ignored because the operation is invalid..."
                End If

                chkResAmt.Checked = True
            Else
                tssStatus.Text = "Reservation amount criteria is ignored because the value is not numeric..."
            End If
        End If

        tssStatus.Text = ""
        If Trim(cboCriteriaResBalance.Text) <> String.Empty Then
            If IsNumeric(txtCriteriaResBalanceTo.Text) Then
                If String.Compare("Equal To", Trim(cboCriteriaResBalance.Text), True) = 0 Then
                    strModifiedReservationWhereClause += strDefaultReservationConnector + " RESERVATION.ResBalance = " & CDbl(txtCriteriaResBalanceTo.Text).ToString
                ElseIf String.Compare("Greater than", Trim(cboCriteriaResBalance.Text), True) = 0 Then
                    strModifiedReservationWhereClause += strDefaultReservationConnector + " RESERVATION.ResBalance > " & CDbl(txtCriteriaResBalanceTo.Text).ToString
                ElseIf String.Compare("Less than", Trim(cboCriteriaResBalance.Text), True) = 0 Then
                    strModifiedReservationWhereClause += strDefaultReservationConnector + " RESERVATION.ResBalance < " & CDbl(txtCriteriaResBalanceTo.Text).ToString
                ElseIf String.Compare("Within the range of", Trim(cboCriteriaResBalance.Text), True) = 0 Then
                    If IsNumeric(txtCriteriaResBalanceFrom.Text) Then
                        strModifiedReservationWhereClause += strDefaultReservationConnector + " RESERVATION.ResBalance BETWEEN " & CDbl(txtCriteriaResBalanceTo.Text).ToString & " AND " & CDbl(txtCriteriaResBalanceFrom.Text).ToString & " "
                    Else
                        tssStatus.Text = "Reservation balance criteria is ignored because the value is not numeric..."
                    End If
                Else
                    tssStatus.Text = "Reservation balance criteria is ignored because the operation is invalid..."
                End If
            Else
                tssStatus.Text = "Reservation balance criteria is ignored because the value is not numeric..."
            End If

            chkResBalance.Checked = True
        End If

        tssStatus.Text = ""
        If Trim(cboCriteriaResDownPay.Text) <> String.Empty Then
            If IsNumeric(txtCriteriaResDownPayTo.Text) Then

                If String.Compare("Equal To", Trim(cboCriteriaResDownPay.Text), True) = 0 Then
                    strModifiedReservationWhereClause += strDefaultReservationConnector + " RESERVATION.ResDownPay = " & CDbl(txtCriteriaResDownPayTo.Text).ToString
                ElseIf String.Compare("Greater than", Trim(cboCriteriaResDownPay.Text), True) = 0 Then
                    strModifiedReservationWhereClause += strDefaultReservationConnector + " RESERVATION.ResDownPay > " & CDbl(txtCriteriaResDownPayTo.Text).ToString
                ElseIf String.Compare("Less than", Trim(cboCriteriaResDownPay.Text), True) = 0 Then
                    strModifiedReservationWhereClause += strDefaultReservationConnector + " RESERVATION.ResDownPay < " & CDbl(txtCriteriaResDownPayTo.Text).ToString
                ElseIf String.Compare("Within the range of", Trim(cboCriteriaResDownPay.Text), True) = 0 Then
                    If IsNumeric(txtCriteriaResDownPayFrom.Text) Then
                        strModifiedReservationWhereClause += strDefaultReservationConnector + " RESERVATION.ResDownPay BETWEEN " & CDbl(txtCriteriaResDownPayTo.Text).ToString & " AND " & CDbl(txtCriteriaResDownPayFrom.Text).ToString & " "
                    Else
                        tssStatus.Text = "Reservation downpayment criteria is ignored because the value is not numeric..."
                    End If
                Else
                    tssStatus.Text = "Reservation downpayment criteria is ignored because the operation is invalid..."
                End If
            Else
                tssStatus.Text = "Reservation downpayment criteria is ignored because the value is not numeric..."
            End If

            chkResDownPay.Checked = True
        End If

        'Youre hre
        If chkCriteriaResWithRefund.Checked Then
            strModifiedReservationWhereClause += strDefaultReservationConnector + " (RESERVATION.ResNo IN(SELECT ResNo FROM REFUND)) "
        End If

        Return strModifiedReservationSelectClause + " " + strModifiedReservationFromClause + " " + strModifiedReservationWhereClause + " " + strModifiedReservationGroupByClause

    End Function

    Private Function ConstructRegistrationInformationSearchString() As String
        RefreshToDefault()

        'Construct the SELECT Clause
        If chkRegDate.Checked Then
            strModifiedRegistrationSelectClause += ", REGISTRATION.RegDate AS [Registration Date] "
            strModifiedRegistrationGroupByClause += ", REGISTRATION.RegDate "
        End If

        If chkRegNoOfRooms.Checked Then
            strModifiedRegistrationSelectClause += ", COUNT(REGISTRATION_DETAILS.RegDNo) AS [No. of Occupied Rooms] "
        End If

        If chkRegGuestType.Checked Then
            strModifiedRegistrationSelectClause += ", REGISTRATION.RegGuestType AS [Guest Type] "
            strModifiedRegistrationGroupByClause += ", REGISTRATION.RegGuestType "
        End If

        If chkRegOccupants.Checked Then
            strModifiedRegistrationSelectClause += ", SUM(REGISTRATION_DETAILS.RegDNoGuest) AS [No. of Occupants] "
        End If

        If chkRegStat.Checked Then
            strModifiedRegistrationSelectClause += ", REGISTRATION.RegStat AS [Status] "
            strModifiedRegistrationGroupByClause += ", REGISTRATION.RegStat "
        End If

        If chkRegAmt.Checked Then
            strModifiedRegistrationSelectClause += ", REGISTRATION.RegAmt AS [Total Amount] "
            strModifiedRegistrationGroupByClause += ", REGISTRATION.RegAmt "
        End If

        If chkRegBalance.Checked Then
            strModifiedRegistrationSelectClause += ", REGISTRATION.RegBalance AS [Total Balance] "
            strModifiedRegistrationGroupByClause += ", REGISTRATION.RegBalance "
        End If

        If chkRegCName.Checked Then
            strModifiedRegistrationSelectClause += ", COMPANY.CName AS [Company] "
            strModifiedRegistrationGroupByClause += ", COMPANY.CName "
        End If

        If chkRegCAddress.Checked Then
            strModifiedRegistrationSelectClause += ", COMPANY.CAddress AS [Company Address] "
            strModifiedRegistrationGroupByClause += ", COMPANY.CAddress "
        End If

        If chkRegCBranch.Checked Then
            strModifiedRegistrationSelectClause += ", COMPANY.CBranch AS [Company Branch] "
            strModifiedRegistrationGroupByClause += ", COMPANY.CBranch "
        End If

        If chkRegCContactPerson.Checked Then
            strModifiedRegistrationSelectClause += ", COMPANY.CContactPerson AS [Contact Person] "
            strModifiedRegistrationGroupByClause += ", COMPANY.CContactPerson "
        End If

        If chkRegCPos.Checked Then
            strModifiedRegistrationSelectClause += ", COMPANY.Cpos AS [Position of Contact Person] "
            strModifiedRegistrationGroupByClause += ", COMPANY.Cpos "
        End If

        If chkRegCContact.Checked Then
            strModifiedRegistrationSelectClause += ", COMPANY.CContact AS [Contact] "
            strModifiedRegistrationGroupByClause += ", COMPANY.CContact "
        End If

        'construct the FROM clause

        'Construct the WHERE clause
        If radRegDontRemember.Checked = False Then
            Dim strStartDate As String = String.Empty
            Dim strEndDate As String = Date.Now.ToString

            If radRegWithinTheLastWeek.Checked Then
                strStartDate = Date.Now.AddDays(-7).ToString
            ElseIf radRegPastMonth.Checked Then
                strStartDate = Date.Now.AddMonths(-1).ToString
            ElseIf radRegWithinThePastYear.Checked Then
                strStartDate = Date.Now.AddYears(-1).ToString
            ElseIf radRegSpecifyDate.Checked Then
                strStartDate = dtpRegSpecifyDateTo.Value.ToString
                strEndDate = dtpRegSpecifyDateFrom.Value.ToString
            End If
            strModifiedRegistrationWhereClause += strDefaultRegistrationConnector + " (REGISTRATION.Regdate BETWEEN CONVERT (DATETIME, '" & strStartDate & "', 102) AND CONVERT(DATETIME, '" & strEndDate & "', 102)) "
        End If

        If Trim(cboCriteriaRegGuestType.Text) <> String.Empty Then
            strModifiedRegistrationWhereClause += strDefaultRegistrationConnector + " REGISTRATION.RegGuestType = '" & cboCriteriaRegGuestType.Text & "' "
            chkRegGuestType.Checked = True
        End If

        If Trim(cboCriteriaRegStat.Text) <> String.Empty Then
            strModifiedRegistrationWhereClause += strDefaultRegistrationConnector + " REGISTRATION.RegStat = '" & cboCriteriaRegStat.Text & "' "
            chkRegStat.Checked = True
        End If

        tssStatus.Text = ""
        If Trim(cboCriteriaRegAmt.Text) <> String.Empty Then
            If IsNumeric(txtCriteriaRegAmtTo.Text) Then
                If String.Compare("Equal to", Trim(cboCriteriaRegAmt.Text), True) = 0 Then
                    strModifiedRegistrationWhereClause += strDefaultRegistrationConnector + " REGISTRATION.RegAmt = " & CDbl(txtCriteriaRegAmtTo.Text).ToString & " "
                ElseIf String.Compare("Greater than", Trim(cboCriteriaRegAmt.Text), True) = 0 Then
                    strModifiedRegistrationWhereClause += strDefaultRegistrationConnector + " REGISTRATION.RegAmt > " & CDbl(txtCriteriaRegAmtTo.Text).ToString & " "
                ElseIf String.Compare("Less than", Trim(cboCriteriaRegAmt.Text), True) = 0 Then
                    strModifiedRegistrationWhereClause += strDefaultRegistrationConnector + " REGISTRATION.RegAmt < " & CDbl(txtCriteriaRegAmtTo.Text).ToString & " "
                ElseIf String.Compare("Within the range of", cboCriteriaRegAmt.Text, True) = 0 Then
                    If IsNumeric(txtCriteriaRegAmtFrom) Then
                        strModifiedRegistrationWhereClause += strDefaultRegistrationConnector + " REGISTRATION.RegAmt BETWEEN " & CDbl(txtCriteriaRegAmtTo.Text).ToString & " AND " & CDbl(txtCriteriaRegAmtFrom.Text.ToUpper) & " "
                    Else
                        tssStatus.Text = "Registration amount criteria is ignored because the value is not numeric..."
                    End If
                Else
                    tssStatus.Text = "Registration amount criteria is ignored because the operation is invalid..."
                End If
            Else
                tssStatus.Text = "Registration amount criteria is ignored because the value is not numeric..."
            End If

            chkRegAmt.Checked = True
        End If

        tssStatus.Text = ""
        If Trim(cboCriteriaRegBalance.Text) <> String.Empty Then
            If IsNumeric(txtCriteriaRegBalanceTo.Text) Then
                If String.Compare("Equal to", Trim(cboCriteriaRegBalance.Text), True) = 0 Then
                    strModifiedRegistrationWhereClause += strDefaultRegistrationConnector + " REGISTRATION.RegBalance = " & CDbl(txtCriteriaRegBalanceTo.Text).ToString & " "
                ElseIf String.Compare("Greater than", Trim(cboCriteriaRegBalance.Text), True) = 0 Then
                    strModifiedRegistrationWhereClause += strDefaultRegistrationConnector + " REGISTRATION.RegBalance > " & CDbl(txtCriteriaRegBalanceTo.Text).ToString & " "
                ElseIf String.Compare("Less than", Trim(cboCriteriaRegBalance.Text), True) = 0 Then
                    strModifiedRegistrationWhereClause += strDefaultRegistrationConnector + " REGISTRATION.RegBalance < " & CDbl(txtCriteriaRegBalanceTo.Text).ToString & " "
                ElseIf String.Compare("Within the range of", Trim(cboCriteriaRegBalance.Text), True) = 0 Then
                    If IsNumeric(txtCriteriaRegBalanceFrom.Text) Then
                        strModifiedRegistrationWhereClause += strDefaultRegistrationConnector + " REGISTRATION.RegBalance BETWEEN " & CDbl(txtCriteriaRegBalanceTo.Text).ToString & " AND " & CDbl(txtCriteriaRegBalanceFrom.Text).ToString & " "
                    Else
                        tssStatus.Text = "Registration balance criteria is ignored because the value is not numeric..."
                    End If
                Else
                    tssStatus.Text = "Registration amount criteria is ignored because the operation is invalid..."
                End If
            Else
                tssStatus.Text = "Registration balance criteria is ignored because the value is not numeric..."
            End If

            chkRegBalance.Checked = True
        End If


        If chkCriteriaRegWithRefund.Checked Then
            strModifiedRegistrationWhereClause += strDefaultRegistrationConnector + " (REGISTRATION.REGNO IN(SELECT REFUND.REGNO FROM REFUND) ) "
        End If

        If chkCriteriaRegWithDirectBiller.Checked Then
            strModifiedRegistrationWhereClause += strDefaultRegistrationConnector + " (REGISTRATION.DBID IS NOT NULL) "
        End If

        Return strModifiedRegistrationSelectClause + " " + strModifiedRegistrationFromClause + " " + strModifiedRegistrationWhereClause + " " + strModifiedRegistrationGroupByClause

    End Function

    Private Function ConstructCompanyInformationSearchString() As String
        RefreshToDefault()
        Return strModifiedCompanySelectClause & " " & strModifiedCompanyFromClause & " " & strModifiedCompanyWhereClause & " " & strModifiedCompanyGroupByClause
    End Function

#End Region

#Region "Button"

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

        For intCtr As Integer = dgvGuestInformation.Rows.Count - 1 To 0 Step -1
            dgvGuestInformation.Rows.RemoveAt(intCtr)
        Next
        lblCountGuestInformation.Text = dgvGuestInformation.Rows.Count.ToString

        For intCtr As Integer = dgvWithReservation.Rows.Count - 1 To 0 Step -1
            dgvWithReservation.Rows.RemoveAt(intCtr)
        Next
        lblCountWithReservation.Text = dgvWithReservation.Rows.Count.ToString

        For intCtr As Integer = dgvWithRegistration.Rows.Count - 1 To 0 Step -1
            dgvWithRegistration.Rows.RemoveAt(intCtr)
        Next
        lblCountWithRegistration.Text = dgvWithRegistration.Rows.Count.ToString

        For intCtr As Integer = dgvCompany.Rows.Count - 1 To 0 Step -1
            dgvCompany.Rows.RemoveAt(intCtr)
        Next
        lblCountCompany.Text = dgvCompany.Rows.Count.ToString

    End Sub

    Private Sub dgvCompany_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvCompany.DoubleClick

        If dgvCompany.Rows.Count > 0 Then

            TrigerredAtDoubleClickAtGuestAtCompany = True
            strCID = dgvCompany.Item(0, dgvCompany.CurrentRow.Index).Value.ToString

            Dim objDataset As DataSet
            Dim objDataview As DataView

            objDataset = SetUpDataSet(SetUpDataAdapter(SetUpConnection(DatabasePath, True), _
                               ConstructGuestInformationSearchString(), DatabaseTransactionState.SelectState), _
                               "GuestInformation")
            objDataview = New DataView(objDataset.Tables("GuestInformation"))
            dgvGuestInformation.DataSource = Nothing
            dgvGuestInformation.DataSource = objDataview
            lblCountGuestInformation.Text = dgvGuestInformation.RowCount.ToString

            tssStatus.Text = ""
            If dgvGuestInformation.Rows.Count > 0 Then
                tbcGuestSearch.SelectedIndex = 0
            Else
                tssStatus.Text = "The selected company does not have a representative..."
            End If
        End If

    End Sub

    Private Sub dgvGuestInformation_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvGuestInformation.DoubleClick

        If dgvGuestInformation.RowCount > 0 Then

            TrigerredAtDoubleClickAtGuest = True

            'Set the Giid to the currently selected information at the datagrid view for guest information
            strGIID = dgvGuestInformation.Item(0, dgvGuestInformation.CurrentRow.Index).Value.ToString

            Dim objDataset As DataSet
            Dim objDataView As DataView

            objDataset = SetUpDataSet(SetUpDataAdapter(SetUpConnection(DatabasePath, True), _
                              ConstructReservationInformationSearchString(), DatabaseTransactionState.SelectState), _
                              "ReservationInformation")
            objDataView = New DataView(objDataset.Tables("ReservationInformation"))
            dgvWithReservation.DataSource = Nothing
            dgvWithReservation.DataSource = objDataView
            lblCountWithReservation.Text = dgvWithReservation.RowCount.ToString


            objDataset = SetUpDataSet(SetUpDataAdapter(SetUpConnection(DatabasePath, True), _
                       ConstructRegistrationInformationSearchString(), DatabaseTransactionState.SelectState), _
                       "RegistrationInformation")

            objDataView = New DataView(objDataset.Tables("RegistrationInformation"))
            dgvWithRegistration.DataSource = Nothing
            dgvWithRegistration.DataSource = objDataView
            lblCountWithRegistration.Text = dgvWithRegistration.RowCount.ToString

            tssStatus.Text = ""
            If dgvWithReservation.Rows.Count = 0 Then
                If dgvWithRegistration.Rows.Count = 0 Then
                    tssStatus.Text = "The selected guest does not have a reservation and registration..."
                Else
                    tbcGuestSearch.SelectedIndex = 3 ' go to the registration tab
                End If
            Else
                tbcGuestSearch.SelectedIndex = 2 'Go to reservation tab since it has a row to display
            End If
        Else
            tssStatus.Text = "There are no items in the list..."
            txtSearchPhrase.SelectAll()
            txtSearchPhrase.Focus()
        End If

    End Sub

    Private Sub btnGISelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGISelectAll.Click
        TrigerredAtDoubleClickAtGuest = False
        txtSearchPhrase.Text = String.Empty
        btnDisplay_Click(Nothing, Nothing)
    End Sub

    Private Sub btnResSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResSelectAll.Click
        TrigerredAtDoubleClickAtGuest = False
        txtSearchPhrase.Text = String.Empty
        btnDisplay_Click(Nothing, Nothing)
    End Sub

    Private Sub btnRegSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegSelectAll.Click
        TrigerredAtDoubleClickAtGuest = False
        txtSearchPhrase.Text = String.Empty
        btnDisplay_Click(Nothing, Nothing)
    End Sub

    Private Sub btnChoose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChoose.Click

        Select Case tbcGuestSearch.SelectedIndex
            Case 0 'When this is executed only the guest id has a value
                If dgvGuestInformation.Rows.Count > 0 Then 'There is a selection when there is at least one row displayed at the datagrid
                    SearchedGuestID = dgvGuestInformation.Item(0, dgvGuestInformation.CurrentRow.Index).Value.ToString

                    Me.Hide()
                    ReturnToTriggeringForm()
                    Me.Close()
                End If

            Case 1 'Set Company ID
                If dgvCompany.Rows.Count > 0 Then
                    SearchedCompanyID = dgvCompany.Item(0, dgvCompany.CurrentRow.Index).Value.ToString

                    Me.Hide()
                    ReturnToTriggeringForm()
                    Me.Close()

                End If

            Case 2 'Both the guest id and the reservation has values
                If dgvWithReservation.Rows.Count > 0 Then
                    SearchedReservationNo = dgvWithReservation.Item(0, dgvWithReservation.CurrentRow.Index).Value.ToString
                    'Determine the owner of this reservation
                    Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
                        objConnection.Open()
                        Using objCommand As SqlCommand = New SqlCommand("SELECT GUEST.GIID, GUEST.CID FROM RESERVATION INNER JOIN GUEST ON RESERVATION.GNo = GUEST.GNo WHERE (RESERVATION.ResNo = '" & dgvWithReservation.Item(0, dgvWithReservation.CurrentRow.Index).Value.ToString & "'); ", objConnection)
                            Using objReader As SqlDataReader = objCommand.ExecuteReader
                                objReader.Read()
                                SearchedGuestID = objReader("GIID").ToString

                                Try ' error will occur if value is null
                                    SearchedCompanyID = objReader("CID").ToString
                                Catch ex As SqlException
                                    SearchedCompanyID = String.Empty
                                End Try

                                objReader.Close()
                            End Using
                        End Using
                        objConnection.Close()
                    End Using

                    Me.Hide()
                    ReturnToTriggeringForm()
                    Me.Close()
                End If

            Case 3 'Registration and guest id has values
                If dgvWithRegistration.Rows.Count > 0 Then
                    SearchedRegistrationNo = dgvWithRegistration.Item(0, dgvWithRegistration.CurrentRow.Index).Value.ToString
                    Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
                        objConnection.Open()
                        Using objCommand As SqlCommand = New SqlCommand("SELECT GUEST.GIID, GUEST.CID FROM REGISTRATION INNER JOIN GUEST ON REGISTRATION.GNO = GUEST.GNO WHERE (REGISTRATION.RegNo='" & dgvWithRegistration.Item(0, dgvWithRegistration.CurrentRow.Index).Value.ToString & "')", objConnection)
                            Using objReader As SqlDataReader = objCommand.ExecuteReader
                                objReader.Read()
                                SearchedGuestID = objReader("GIID").ToString

                                Try 'error will occur if the value is null
                                    SearchedCompanyID = objReader("CID").ToString
                                Catch ex As SqlException
                                    SearchedCompanyID = String.Empty
                                End Try

                                objReader.Close()
                            End Using
                        End Using
                        objConnection.Close()
                    End Using

                    Me.Hide()
                    ReturnToTriggeringForm()
                    Me.Close()

                End If


            Case 4
                Select Case tbcOption.SelectedIndex
                    Case 0
                        tbcGuestSearch.SelectedIndex = 0
                    Case 1
                        tbcGuestSearch.SelectedIndex = 2
                    Case 2
                        tbcGuestSearch.SelectedIndex = 3
                End Select
        End Select
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click

        txtSearchPhrase.SelectAll()
        TrigerredAtDoubleClickAtGuest = False
        TrigerredAtDoubleClickAtGuestAtCompany = False

        Dim strCommandString As String = String.Empty

        Select Case tbcGuestSearch.SelectedIndex
            Case 0 'Guest Information
                lblCountGuestInformation.Text = ListItems(DatabasePath, ConstructGuestInformationSearchString(), dgvGuestInformation).ToString
            Case 1 'company information
                lblCountCompany.Text = ListItems(DatabasePath, ConstructCompanyInformationSearchString, dgvCompany).ToString
            Case 2 'search reservation
                lblCountWithReservation.Text = ListItems(DatabasePath, ConstructReservationInformationSearchString(), dgvWithReservation).ToString
            Case 3 'search at registration
                lblCountWithRegistration.Text = ListItems(DatabasePath, ConstructRegistrationInformationSearchString, dgvWithRegistration).ToString
        End Select

    End Sub

    Private Sub btnCompanySelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompanySelectAll.Click
        TrigerredAtDoubleClickAtGuest = False
        txtSearchPhrase.Text = String.Empty
        btnDisplay_Click(Nothing, Nothing)
    End Sub

    Private Sub dgvWithReservation_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvWithReservation.DoubleClick
        btnChoose_Click(Nothing, Nothing)
    End Sub

    Private Sub dgvWithRegistration_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvWithRegistration.DoubleClick
        btnChoose_Click(Nothing, Nothing)
    End Sub

#End Region

#Region "Save Settings"

    Private Sub Form_Closing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        WriteToRegistry()
    End Sub

    Private Sub ReadFromRegistry()
        With My.Settings
            chkGITitle.Checked = .GITitle
            chkGIMI.Checked = .GIMI
            chkGICountry.Checked = .GICountry
            chkGIAddress.Checked = .GIAddress
            chkGIZIP.Checked = .GIZIP
            chkGIContact.Checked = .GIContact
            chkGICit.Checked = .GICit
            chkGIBDay.Checked = .GIBDay
            chkGIGender.Checked = .GIGender
            chkGICivilStat.Checked = .GICivilStat
            chkGINat.Checked = .GINat
            chkGIEmail.Checked = .GIEmail
            chkResDate.Checked = .ResDate
            chkResNoRoom.Checked = .ResNoRoom
            chkResNoOccupants.Checked = .ResNoOfOccupants
            chkResStat.Checked = .ResStat
            chkResAmt.Checked = .ResAmt
            chkResDownPay.Checked = .ResDownPay
            chkResBalance.Checked = .ResBalance
            chkResCName.Checked = .ResCName
            chkResCAddress.Checked = .ResCAddress
            chkResCBranch.Checked = .ResCBranch
            chkResCContactPerson.Checked = .ResCContactPerson
            chkResCPos.Checked = .ResCPos
            chkResCContact.Checked = .ResCContact
            chkResGuestType.Checked = .ResGuestType

            chkRegDate.Checked = .RegDate
            chkRegNoOfRooms.Checked = .RegNoOfRooms
            chkRegOccupants.Checked = .RegNoOccupants
            chkRegStat.Checked = .RegStat
            chkRegAmt.Checked = .RegAmt
            chkRegBalance.Checked = .RegBalance
            chkRegCName.Checked = .RegCName
            chkRegCAddress.Checked = .RegCAddress
            chkRegCBranch.Checked = .RegCBranch
            chkRegCContactPerson.Checked = .RegCContactPerson
            chkRegCPos.Checked = .RegCPos
            chkRegCContact.Checked = .RegCContact
            chkRegGuestType.Checked = .RegGuestType

        End With
    End Sub

    Private Sub WriteToRegistry()
        With My.Settings
            .GITitle = chkGITitle.Checked
            .GIMI = chkGIMI.Checked
            .GICountry = chkGITitle.Checked
            .GIAddress = chkGICountry.Checked
            .GIZIP = chkGIZIP.Checked
            .GIContact = chkGIContact.Checked
            .GICit = chkGICit.Checked
            .GIBDay = chkGIBDay.Checked
            .GIGender = chkGIGender.Checked
            .GICivilStat = chkGICivilStat.Checked
            .GINat = chkGINat.Checked
            .GIEmail = chkGIEmail.Checked

            .ResDate = chkResDate.Checked
            .ResNoRoom = chkResNoRoom.Checked
            .ResNoOfOccupants = chkResNoOccupants.Checked
            .ResStat = chkResStat.Checked
            .ResAmt = chkResAmt.Checked
            .ResDownPay = chkResDownPay.Checked
            .ResBalance = chkResBalance.Checked
            .ResCName = chkResCName.Checked
            .ResCAddress = chkResCAddress.Checked
            .ResCBranch = chkResCBranch.Checked
            .ResCContactPerson = chkResCContactPerson.Checked
            .ResCPos = chkResCPos.Checked
            .ResCContact = chkResCContact.Checked
            .ResGuestType = chkResGuestType.Checked

            .RegDate = chkRegDate.Checked
            .RegNoOfRooms = chkRegNoOfRooms.Checked
            .RegNoOccupants = chkRegOccupants.Checked
            .RegStat = chkRegStat.Checked
            .RegAmt = chkRegAmt.Checked
            .RegBalance = chkRegBalance.Checked
            .RegCName = chkRegCName.Checked
            .RegCAddress = chkRegCAddress.Checked
            .RegCBranch = chkRegCBranch.Checked
            .RegCContactPerson = chkRegCContactPerson.Checked
            .RegCPos = chkRegCPos.Checked
            .RegCContact = chkRegCContact.Checked
            .RegGuestType = chkRegGuestType.Checked

            .Save()
        End With
    End Sub

#End Region

#Region "UPDATE SELECT"

    Private Sub cboCriteriaGITitle_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCriteriaGITitle.LostFocus
        If Trim(cboCriteriaGITitle.Text) <> String.Empty Then
            chkGITitle.Checked = True
        End If
    End Sub

    Private Sub cboCriteriaGICit_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCriteriaGICit.LostFocus
        If Trim(cboCriteriaGICit.Text) <> String.Empty Then
            chkGICit.Checked = True
        End If
    End Sub

    Private Sub cboCriteriaGICountry_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCriteriaGICountry.LostFocus
        If Trim(cboCriteriaGICountry.Text) <> String.Empty Then
            chkGICountry.Checked = True
        End If
    End Sub

    Private Sub cboCriteriaGIGender_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCriteriaGIGender.LostFocus
        If Trim(cboCriteriaGIGender.Text) <> String.Empty Then
            chkGIGender.Checked = True
        End If
    End Sub

    Private Sub cboCriteriaGIAddress_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCriteriaGIAddress.LostFocus
        If Trim(cboCriteriaGIAddress.Text) <> String.Empty Then
            chkGIAddress.Checked = True
        End If
    End Sub

    Private Sub cboCriteriaGICivilStat_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCriteriaGICivilStat.LostFocus
        If Trim(cboCriteriaGICivilStat.Text) <> String.Empty Then
            chkGICivilStat.Checked = True
        End If
    End Sub

    Private Sub cboCriteriaGINat_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCriteriaGINat.LostFocus
        If Trim(cboCriteriaGINat.Text) <> String.Empty Then
            chkGINat.Checked = True
        End If
    End Sub

    Private Sub cboCriteriaResStat_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCriteriaResStat.LostFocus
        If Trim(cboCriteriaResStat.Text) <> String.Empty Then
            chkResStat.Checked = True
        End If
    End Sub

    Private Sub cboCriteriaResGuestType_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCriteriaResGuestType.LostFocus
        If Trim(cboCriteriaResGuestType.Text) <> String.Empty Then
            chkResGuestType.Checked = True
        End If
    End Sub

    Private Sub cboCriteriaResAmt_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCriteriaResAmt.LostFocus
        If Trim(cboCriteriaResAmt.Text) <> String.Empty Then
            chkResAmt.Checked = True
        End If
    End Sub

    Private Sub cboCriteriaResBalance_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCriteriaResBalance.LostFocus
        If Trim(cboCriteriaResBalance.Text) <> String.Empty Then
            chkResBalance.Checked = True
        End If
    End Sub

    Private Sub cboCriteriaResDownPay_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCriteriaResDownPay.LostFocus
        If Trim(cboCriteriaResDownPay.Text) <> String.Empty Then
            chkResDownPay.Checked = True
        End If
    End Sub

    Private Sub cboCriteriaRegGuestType_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCriteriaRegGuestType.LostFocus
        If Trim(cboCriteriaRegGuestType.Text) <> String.Empty Then
            chkRegGuestType.Checked = True
        End If
    End Sub

    Private Sub cboCriteriaRegStat_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCriteriaRegStat.LostFocus
        If Trim(cboCriteriaRegStat.Text) <> String.Empty Then
            chkRegStat.Checked = True
        End If
    End Sub

    Private Sub cboCriteriaRegAmt_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCriteriaRegAmt.LostFocus
        If Trim(cboCriteriaRegStat.Text) <> String.Empty Then
            chkRegStat.Checked = True
        End If
    End Sub

    Private Sub cboCriteriaRegBalance_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCriteriaRegBalance.LostFocus
        If Trim(cboCriteriaRegBalance.Text) <> String.Empty Then
            chkRegBalance.Checked = True
        End If
    End Sub

    Private Sub txtCriteriaResAmtTo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCriteriaResAmtTo.TextChanged
        If Trim(cboCriteriaResAmt.Text) = String.Empty Then
            cboCriteriaResAmt.Text = "Equal to"
        End If

        chkResAmt.Checked = True
    End Sub

    Private Sub txtCriteriaResAmtFrom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCriteriaResAmtFrom.TextChanged
        cboCriteriaResAmt.Text = "Within the range of"
    End Sub

    Private Sub txtCriteriaResBalanceTo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCriteriaResBalanceTo.TextChanged
        If Trim(cboCriteriaResBalance.Text) = String.Empty Then
            cboCriteriaResBalance.Text = "Equal to"
        End If

        chkResBalance.Checked = True
    End Sub

    Private Sub txtCriteriaResBalanceFrom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCriteriaResBalanceFrom.TextChanged
        cboCriteriaResBalance.Text = "Within the range of"
    End Sub

    Private Sub txtCriteriaResDownPayTo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCriteriaResDownPayTo.TextChanged
        If Trim(cboCriteriaResDownPay.Text) = String.Empty Then
            cboCriteriaResDownPay.Text = "Equal to"
        End If

        chkResDownPay.Checked = True
    End Sub

    Private Sub txtCriteriaResDownPayFrom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCriteriaResDownPayFrom.TextChanged
        cboCriteriaResDownPay.Text = "Within the range of"
    End Sub

    Private Sub txtCriteriaRegAmtTo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCriteriaRegAmtTo.TextChanged
        If Trim(cboCriteriaRegAmt.Text) = String.Empty Then
            cboCriteriaRegAmt.Text = "Equal to"
        End If

        chkRegAmt.Checked = True
    End Sub

    Private Sub txtCriteriaRegAmtFrom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCriteriaRegAmtFrom.TextChanged
        cboCriteriaRegAmt.Text = "Within the range of"
    End Sub

    Private Sub txtCriteriaRegBalanceTo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCriteriaRegBalanceTo.TextChanged
        If Trim(cboCriteriaRegBalance.Text) = String.Empty Then
            cboCriteriaRegBalance.Text = "Equal to"
        End If

        chkRegBalance.Checked = True
    End Sub

    Private Sub txtCriteriaRegBalanceFrom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCriteriaRegBalanceFrom.TextChanged
        cboCriteriaRegBalance.Text = "Within the range of"
    End Sub

#End Region

End Class