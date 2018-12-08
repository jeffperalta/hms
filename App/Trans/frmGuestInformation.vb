Option Explicit On
Option Strict On

Imports System.Data.SqlClient
Imports System.Data

' Programmers:  Bobby Elbert D. Quiñones 
'               Jo Jefferson D. Peralta
' Date:         April 06, 2007
' Title:        frmGuestInformation
' Purpose:      This interface is used to add, edit, or delete guest and company information. The user can
'               add a new information for a company or guest even before their actual reservation and registrations
'               Also through this interface, the user can have a glimpse on the guest history  he can 
'               view all the transactions made by the guest or that company.
' Requirements: ->  (+/-)GUEST_INFO(GIID, GITitle, GIFName, GILName, GIMI, GICountry, GIAddress, GIZIP, GIContact, GIEMail, GIGender, GICivilStat, GINat, GICit, GIBday)
'               ->  (*)GUEST_INFO(GITitle, GIFName, GILName, GIMI, GICountry, GIAddress, GIZIP, GIContact,GIEMail, GIGender, GICivilStat, GINat, GICit, GIBday)
'               ->  (+/-)COMPANY(CID, CName, CAddress, CBranch, CContactPerson, CContact, Cpos)
'               ->  (*)COMPANY(CName, CAddress, CBranch, CContactPerson, CContact, Cpos)
'               ->  The user cannot delete the guest or company information if it already has a reservations or registrations.
'               ->  At this interface, there is no relationship yet between the newly added guest and the company information
'                   It is only realized at the reservation and registration interfaces.
'               ->  Aside from right-clicking the items to view guest history the user can also use the guest search interface
'                   for more advanced/filtered results.
'               ->  Total charges, payments, and balances are also seen at guest history.
' Results:      ->  A new guest and company information is saved.
'               ->  Currently there is no relationship between the newly added guest and company information.
'               ->  It is only during reservation or registration where this association is established.
'>>Messages: Done

Public Class frmGuestInformation

    Private gState() As State = {State.waiting, State.waiting}
    Private gGiid As String = String.Empty
    Private gCid As String = String.Empty

#Region "Individual Information"

#Region "Functions/Subroutines"

    Private Sub DisplayIndividualGuest()
        lblCount.Text = ListItems(DatabasePath, _
                    "SELECT GIID AS [Guest Id], ISNULL(GITitle, '') AS Title, ISNULL(GIFName, '') AS [First Name], ISNULL(GIMI, '') AS [Middle Name], ISNULL(GILName, '') AS [Last Name], ISNULL(GIGender,'') AS Gender,  " & _
                    "       ISNULL(GIBDay,'') AS Birthdate, ISNULL(GICountry,'') AS Country, ISNULL(GIZIP,'') AS ZIP, ISNULL(GIAddress,'') AS Address, ISNULL(GICivilStat,'') AS [Civil Status], ISNULL(GIContact,'') AS [Contact No],  " & _
                    "       ISNULL(GIEmail,'') AS EMail, ISNULL(GINat,'') AS Nationality, ISNULL(GICit,'') AS Citizenship " & _
                    "FROM   GUEST_INFO " & _
                    IIf(Trim(txtGuestName.Text) = String.Empty, "", "WHERE  (GILName LIKE '" & Trim(txtGuestName.Text) & "%') OR " & _
                    "       (GIFName LIKE '" & txtGuestName.Text & "%') ").ToString, _
                    dgvGuests).ToString
    End Sub

    Private Function ThereAreInputErrorsAtGuestInformation() As Boolean

        If Trim(txtFirstName.Text) = String.Empty Then
            Msg("1000", Button.Ok)
            txtFirstName.SelectAll()
            txtFirstName.Focus()
            Return True
            Exit Function
        End If

        If Trim(txtAddress.Text) = String.Empty Then
            Msg("1000", Button.Ok)
            txtAddress.SelectAll()
            txtAddress.Focus()
            Return True
            Exit Function
        End If

        Return False

    End Function

    Private Sub UpdateComboBoxes()
        ListItems(DatabasePath, "SELECT DISTINCT GICountry FROM GUEST_INFO WHERE GICountry<>''", cboCountry, "GICountry")
        cboCountry.Text = String.Empty
        ListItems(DatabasePath, "SELECT DISTINCT GICivilStat FROM GUEST_INFO WHERE GICivilStat<>''", cboCivilStatus, "GICivilStat")
        cboCivilStatus.Text = String.Empty
        ListItems(DatabasePath, "SELECT DISTINCT GINat FROM GUEST_INFO WHERE GINat<>''", cboNationality, "GINat")
        cboNationality.Text = String.Empty
        ListItems(DatabasePath, "SELECT DISTINCT GICit FROM GUEST_INFO WHERE GICit<>''", cboCitizenship, "GICit")
        cboCitizenship.Text = String.Empty
    End Sub

#End Region

#Region "Command Buttons"

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        gState(0) = State.adding
        ClearControls(grpPersonalInformation)
        gbxGuestInformation.Enabled = False
        grpPersonalInformation.Enabled = True
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click

        If dgvGuests.SelectedRows.Count = 0 Then Msg("1005", Button.Ok) : Exit Sub
      
        gState(0) = State.updating
        ClearControls(grpPersonalInformation)
        gbxGuestInformation.Enabled = False
        grpPersonalInformation.Enabled = True

        With dgvGuests
            txtTitle.Text = .Item(1, .CurrentRow.Index).Value.ToString
            txtFirstName.Text = .Item(2, .CurrentRow.Index).Value.ToString
            txtMiddleInitial.Text = .Item(3, .CurrentRow.Index).Value.ToString
            txtLastName.Text = .Item(4, .CurrentRow.Index).Value.ToString
            cboGender.Text = .Item(5, .CurrentRow.Index).Value.ToString
            dtpBirthDate.Value = CType(.Item(6, .CurrentRow.Index).Value, Date)
            cboCountry.Text = .Item(7, .CurrentRow.Index).Value.ToString
            txtZipCode.Text = .Item(8, .CurrentRow.Index).Value.ToString
            txtAddress.Text = .Item(9, .CurrentRow.Index).Value.ToString
            cboCivilStatus.Text = .Item(10, .CurrentRow.Index).Value.ToString
            txtContactNo.Text = .Item(11, .CurrentRow.Index).Value.ToString
            txtEmail.Text = .Item(12, .CurrentRow.Index).Value.ToString
            cboNationality.Text = .Item(13, .CurrentRow.Index).Value.ToString
            cboCitizenship.Text = .Item(14, .CurrentRow.Index).Value.ToString
        End With

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If dgvGuests.SelectedRows.Count = 1 Then
            If Not IsExisting("SELECT GNO FROM GUEST WHERE GIID = '" & dgvGuests.Item(0, dgvGuests.CurrentRow.Index).Value.ToString & "'") Then
                If Msg("1035", Button.YesNo) = ButtonClicked.No Then Exit Sub

                Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
                    objConnection.Open()
                    Using objTransaction As SqlTransaction = objConnection.BeginTransaction
                        Using objCommand As SqlCommand = objConnection.CreateCommand
                            With objCommand
                                .Transaction = objTransaction

                                Try
                                    .CommandText = "DELETE FROM GUEST_INFO WHERE GIID =@GIID"
                                    .Parameters.Clear()
                                    .Parameters.AddWithValue("@GIID", dgvGuests.Item(0, dgvGuests.CurrentRow.Index).Value)
                                    .ExecuteNonQuery()

                                    objTransaction.Commit()

                                    frmParent.tssStatus.Text = "The information is deleted..."
                                    DisplayIndividualGuest()

                                Catch ex As Exception
                                    objTransaction.Commit()
                                    Msg("1008", Button.Ok, ex.Message)

                                End Try

                            End With
                        End Using
                    End Using
                    objConnection.Close()
                End Using
            Else
                Msg("1006", Button.Ok, "Cannot delete the information because the guest already has a reservation or a registration.")
            End If
        Else
            Msg("1005", Button.Ok)
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ClearControls(grpPersonalInformation)
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If ThereAreInputErrorsAtGuestInformation() Then Exit Sub

        Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
            objConnection.Open()
            Using objTransaction As SqlTransaction = objConnection.BeginTransaction
                Using objCommand As SqlCommand = objConnection.CreateCommand
                    With objCommand
                        .Transaction = objTransaction
                        Try
                            .Parameters.Clear()

                            Select Case gState(0)
                                Case State.adding
                                    .CommandText = "INSERT INTO GUEST_INFO (GIID, GITitle, GIFName, GILName, GIMI, GICountry, GIAddress, GIZIP, GIContact, GIEmail, GIGender, GICivilStat, GINat, GICit, GIBday) " & _
                                                   "VALUES (@GIID, @GITitle, @GIFName, @GILName, @GIMI, @GICountry, @GIAddress, @GIZIP, " & _
                                                   "@GIContact, @GIEmail, @GIGender, @GICivilStat, @GINat, @GICit, @GIBday)"
                                    With .Parameters
                                        .AddWithValue("@GIID", GetPreKeyGen("GuestInfo") & GetPrimaryKeyNo("GuestInfo"))
                                        IncrementPrimaryKeyNo("GuestInfo")
                                    End With

                                Case State.updating
                                    .CommandText = "UPDATE GUEST_INFO SET GITitle=@GITitle, GIFName=@GIFName, GILName=@GILName, GIMI=@GIMI, " & _
                                                   "GICountry=@GICountry, GIAddress=@GIAddress, GIZIP= @GIZIP, GIContact=@GIContact, " & _
                                                   "GIEmail = @GIEmail, GIGender = @GIGender, GICivilStat=@GICivilStat, GINat=@GINat, " & _
                                                   "GICit=@GICit, GIBDay=@GIBday " & _
                                                   "WHERE GIID=@GIID "
                                    .Parameters.AddWithValue("@GIID", dgvGuests.Item(0, dgvGuests.CurrentRow.Index).Value)
                            End Select

                            With .Parameters
                                .AddWithValue("@GITitle", TrimAll(txtTitle.Text))
                                .AddWithValue("@GIFname", TrimAll(txtFirstName.Text))
                                .AddWithValue("@GILName", TrimAll(txtLastName.Text))
                                .AddWithValue("@GIMI", TrimAll(txtMiddleInitial.Text))
                                .AddWithValue("@GICountry", TrimAll(cboCountry.Text))
                                .AddWithValue("@GIAddress", TrimAll(txtAddress.Text))
                                .AddWithValue("@GIZIP", TrimAll(txtZipCode.Text))
                                .AddWithValue("@GIContact", TrimAll(txtContactNo.Text))
                                .AddWithValue("@GIEmail", TrimAll(txtEmail.Text))
                                .AddWithValue("@GIGender", TrimAll(cboGender.Text))
                                .AddWithValue("@GICivilStat", TrimAll(cboCivilStatus.Text))
                                .AddWithValue("@GINat", TrimAll(cboNationality.Text))
                                .AddWithValue("@GICit", TrimAll(cboCitizenship.Text))
                                .AddWithValue("@GIBday", dtpBirthDate.Value).SqlDbType = SqlDbType.DateTime
                            End With

                            .ExecuteNonQuery()

                            objTransaction.Commit()
                            If gState(0) = State.adding Then
                                frmParent.tssStatus.Text = "A new information was added..."
                            ElseIf gState(0) = State.updating Then
                                frmParent.tssStatus.Text = "Information was successfully modified..."
                            End If

                            gState(0) = State.waiting
                            ClearControls(grpPersonalInformation)
                            gbxGuestInformation.Enabled = True
                            grpPersonalInformation.Enabled = False

                            DisplayIndividualGuest()
                            UpdateComboBoxes()

                        Catch ex As Exception

                            objTransaction.Rollback()
                            Msg("1008", Button.Ok, ex.Message)

                        End Try
                    End With
                End Using
            End Using
            objConnection.Close()
        End Using
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        gState(0) = State.waiting
        ClearControls(grpPersonalInformation)
        gbxGuestInformation.Enabled = True
        grpPersonalInformation.Enabled = False
    End Sub

#End Region

#Region "MISC"

    Private Sub txtGuestName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGuestName.TextChanged
        DisplayIndividualGuest()
    End Sub

#End Region

#End Region

#Region "Company Information"

#Region "Functions/Subroutines"

    Private Sub DisplayCompanyInformation()
        lblCountCompany.Text = ListItems(DatabasePath, _
                                "SELECT CID AS [Company ID], CName AS [Name], CAddress AS [Address], CBranch AS [Branch], " & _
                                "       CContactPerson AS [Contact Person], CContact AS [Contact], CPos AS [Position] " & _
                                "FROM   COMPANY " & _
                                IIf(Trim(txtCompanyName.Text) = String.Empty, _
                                    "", "WHERE CName LIKE '" & txtCompanyName.Text & "%'").ToString, _
                                dgvCompany).ToString
    End Sub

    Private Function ThereAreInputErrorsAtCompany() As Boolean
        If Trim(txtNCompanyName.Text) = String.Empty Then
            Msg("1000")
            txtNCompanyName.SelectAll()
            txtNCompanyName.Focus()
            Return True
            Exit Function
        End If

        If Trim(txtNCompanyAddress.Text) = String.Empty Then
            Msg("1000")
            txtNCompanyAddress.SelectAll()
            txtNCompanyAddress.Focus()
            Return True
            Exit Function
        End If

    End Function

#End Region

#Region "Command Buttons"

    Private Sub btnAddCompany_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddCompany.Click
        gState(1) = State.adding
        ClearControls(grpNCompanyDetails)
        gbxCompanyInformation.Enabled = False
        grpNCompanyDetails.Enabled = True
    End Sub

    Private Sub btnEditCompany_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditCompany.Click

        If dgvCompany.SelectedRows.Count = 0 Then
            Msg("1005")
        Else
            gState(1) = State.updating
            ClearControls(grpNCompanyDetails)
            gbxCompanyInformation.Enabled = False
            grpNCompanyDetails.Enabled = True

            With dgvCompany
                txtNCompanyName.Text = .Item(1, .CurrentRow.Index).Value.ToString
                txtNContactPerson.Text = .Item(4, .CurrentRow.Index).Value.ToString
                txtNPosition.Text = .Item(6, .CurrentRow.Index).Value.ToString
                txtNCompanyContactNo.Text = .Item(5, .CurrentRow.Index).Value.ToString
                txtNBranch.Text = .Item(3, .CurrentRow.Index).Value.ToString
                txtNCompanyAddress.Text = .Item(2, .CurrentRow.Index).Value.ToString
            End With

        End If
    End Sub

    Private Sub btnDelete_Company_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete_Company.Click
        If IsExisting("SELECT GNo FROM GUEST WHERE CID='" & dgvCompany.Item(0, dgvCompany.CurrentRow.Index).Value.ToString & "'") Then
            Msg("1006", Button.Ok, "Cannot delete information because the company already has a reservation or a registration.")
        Else
            If Msg("1035", Button.YesNo) = ButtonClicked.No Then Exit Sub

            Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
                objConnection.Open()
                Using objTransaction As SqlTransaction = objConnection.BeginTransaction
                    Using objCommand As SqlCommand = objConnection.CreateCommand
                        With objCommand
                            .Transaction = objTransaction
                            Try

                                .CommandText = "DELETE FROM COMPANY WHERE CID=@CID"
                                .Parameters.Clear()
                                .Parameters.AddWithValue("@CID", dgvCompany.Item(0, dgvCompany.CurrentRow.Index).Value)
                                .ExecuteNonQuery()

                                objTransaction.Commit()
                                frmParent.tssStatus.Text = "The record was successfully deleted..."
                                DisplayCompanyInformation()

                            Catch ex As Exception

                                objTransaction.Rollback()
                                Msg("1008", Button.Ok, ex.Message)

                            End Try

                        End With
                    End Using
                End Using
                objConnection.Close()
            End Using
        End If
    End Sub

    Private Sub btnClear_Company_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear_Company.Click
        ClearControls(grpNCompanyDetails)
    End Sub

    Private Sub btnCancel_Company_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel_Company.Click
        gState(1) = State.waiting
        ClearControls(grpNCompanyDetails)
        gbxCompanyInformation.Enabled = True
        grpNCompanyDetails.Enabled = False
    End Sub

    Private Sub btnSave_Company_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave_Company.Click
        If ThereAreInputErrorsAtCompany() Then Exit Sub

        Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
            objConnection.Open()
            Using objTransaction As SqlTransaction = objConnection.BeginTransaction
                Using objCommand As SqlCommand = objConnection.CreateCommand
                    With objCommand
                        .Transaction = objTransaction
                        Try

                            .Parameters.Clear()
                            Select Case gState(1)
                                Case State.adding
                                    .CommandText = "INSERT INTO COMPANY (CID, CName, CAddress, CBranch, CContactPerson, CContact, CPos) " & _
                                                   "VALUES(@CID, @CName, @CAddress, @CBranch, @CContactPerson, @CContact, @CPos) "
                                    .Parameters.AddWithValue("@CID", GetPreKeyGen("Company") & GetPrimaryKeyNo("Company"))
                                    IncrementPrimaryKeyNo("Company")

                                Case State.updating
                                    .CommandText = "UPDATE COMPANY SET CName=@CName, CAddress=@CAddress, CBranch=@CBranch, " & _
                                                     "CContactPerson=@CContactPerson, CContact=@CContact, CPos=@CPos " & _
                                                     "WHERE CID=@CID"
                                    .Parameters.AddWithValue("@CID", dgvCompany.Item(0, dgvCompany.CurrentRow.Index).Value)

                            End Select

                            With .Parameters
                                .AddWithValue("@CName", TrimAll(txtNCompanyName.Text))
                                .AddWithValue("@CAddress", TrimAll(txtNCompanyAddress.Text))
                                .AddWithValue("@CBranch", TrimAll(txtNBranch.Text))
                                .AddWithValue("@CContactPerson", TrimAll(txtNContactPerson.Text))
                                .AddWithValue("@CContact", TrimAll(txtNCompanyContactNo.Text))
                                .AddWithValue("@CPos", TrimAll(txtNPosition.Text))
                            End With
                            .ExecuteNonQuery()

                            objTransaction.Commit()

                            If gState(1) = State.adding Then
                                frmParent.tssStatus.Text = "A new record was added..."
                            ElseIf gState(1) = State.updating Then
                                frmParent.tssStatus.Text = "The record was successfully updated..."
                            End If

                            gState(1) = State.waiting
                            ClearControls(grpNCompanyDetails)
                            gbxCompanyInformation.Enabled = True
                            grpNCompanyDetails.Enabled = False

                            DisplayCompanyInformation()

                        Catch ex As Exception

                            objTransaction.Rollback()
                            Msg("1008", Button.Ok, ex.Message)

                        End Try
                    End With
                End Using
            End Using
            objConnection.Close()
        End Using
    End Sub

#End Region

#Region "MISC"

    Private Sub txtCompanyName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCompanyName.TextChanged
        DisplayCompanyInformation()
    End Sub

#End Region

#End Region

#Region "Guest History"

    Public Sub FillMe()
        Try
            If GuestIsNotSet Then
                Msg("1058")
            Else
                gGiid = SearchedGuestID

                Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
                    objConnection.Open()
                    Using objCommand As SqlCommand = New SqlCommand("SELECT ISNULL(GITitle,'') + ' ' + ISNULL(GIFName,'') + ' ' + ISNULL(GILName, '') AS NAME FROM GUEST_INFO WHERE GIID='" & gGiid & "'", objConnection)
                        Using objReader As SqlDataReader = objCommand.ExecuteReader
                            objReader.Read()
                            lblGuestName.Text = objReader(0).ToString
                            objReader.Close()
                        End Using
                    End Using
                    objConnection.Close()
                End Using

                ConstructGuestHistory()
                tbcGuestInformation.SelectedIndex = 2
            End If
        Catch ex As Exception
            ClearControls(Me)
        End Try
    End Sub

    Private Sub ConstructGuestHistory()
        If gGiid <> String.Empty Then
            lblCountHistory.Text = ListItems(DatabasePath, _
                                        "SELECT RESERVATION.ResNo AS [Transaction No], 'RESERVATION' AS [Transaction], COMPANY.CName AS [Company Name],  " & _
                                        "       RESERVATION.ResGuestType AS [Guest Type], RESERVATION.ResDate AS Date, RESERVATION.ResAmt AS Amount,  " & _
                                        "       RESERVATION.ResNoRoom AS [No. of Rooms], RESERVATION.ResNoOccupants AS Occupants, RESERVATION.ResStat AS Status,  " & _
                                        "       RESERVATION.ResRemarks AS Remarks, RESERVATION.RegNo AS [Registration No.] " & _
                                        "FROM   GUEST INNER JOIN " & _
                                        "       RESERVATION ON GUEST.GNo = RESERVATION.GNo LEFT OUTER JOIN " & _
                                        "       COMPANY ON GUEST.CID = COMPANY.CID " & _
                                        "WHERE  (GUEST.GIID = '" & gGiid & "') " & _
                                        "UNION " & _
                                        "SELECT REGISTRATION.RegNo AS [Registration No], 'REGISTRATION' AS [Transaction], COMPANY_1.CName AS [Company Name],  " & _
                                        "       REGISTRATION.RegGuestType AS [Guest Type], REGISTRATION.RegDate AS Date, REGISTRATION.RegAmt AS Amount,  " & _
                                        "       COUNT(REGISTRATION_DETAILS.RegDNo) AS [No of Rooms], SUM(REGISTRATION_DETAILS.RegDNoGuest) AS [No of Occupants],  " & _
                                        "       REGISTRATION.RegStat AS Status, REGISTRATION.RegRemarks AS Remarks, '' AS RegNo " & _
                                        "FROM   REGISTRATION_DETAILS INNER JOIN " & _
                                        "       REGISTRATION ON REGISTRATION_DETAILS.RegNo = REGISTRATION.RegNo INNER JOIN " & _
                                        "       GUEST AS GUEST_1 ON REGISTRATION.GNo = GUEST_1.GNo LEFT OUTER JOIN " & _
                                        "       COMPANY AS COMPANY_1 ON GUEST_1.CID = COMPANY_1.CID " & _
                                        "GROUP BY REGISTRATION.RegNo, REGISTRATION.RegGuestType, REGISTRATION.RegDate, REGISTRATION.RegAmt, REGISTRATION.RegStat,  " & _
                                        "       REGISTRATION.RegRemarks, COMPANY_1.CName, GUEST_1.GIID " & _
                                        "HAVING (GUEST_1.GIID = '" & gGiid & "') ", _
                                            dgvListOfPreviousTransactions).ToString
        End If
    End Sub

    Private Sub ConstructCompanyHistory()
        If gCid <> String.Empty Then
            lblCountHistory.Text = ListItems(DatabasePath, _
                                        "SELECT RESERVATION.ResNo AS [Transaction No], 'RESERVATION' AS [Transaction], ISNULL(GUEST_INFO.GITitle, '') + ' ' + ISNULL(GUEST_INFO.GIFName, '')  " & _
                                        "       + ' ' + ISNULL(GUEST_INFO.GILName, '') AS [Guest Name], RESERVATION.ResGuestType AS [Guest Type], RESERVATION.ResDate AS Date,  " & _
                                        "       RESERVATION.ResAmt AS Amount, RESERVATION.ResNoRoom AS [No. of Rooms], RESERVATION.ResNoOccupants AS Occupants,  " & _
                                        "       RESERVATION.ResStat AS Status, RESERVATION.ResRemarks AS Remarks, RESERVATION.RegNo AS [Registration No.] " & _
                                        "FROM   GUEST INNER JOIN " & _
                                        "       RESERVATION ON GUEST.GNo = RESERVATION.GNo INNER JOIN " & _
                                        "       GUEST_INFO ON GUEST.GIID = GUEST_INFO.GIID " & _
                                        "WHERE  (GUEST.CID = '" & gCid & "') " & _
                                        "UNION " & _
                                        "SELECT REGISTRATION.RegNo, 'REGISTRATION' AS Expr1, ISNULL(GUEST_INFO_1.GITitle, '') + ' ' + ISNULL(GUEST_INFO_1.GIFName, '')  " & _
                                        "       + ' ' + ISNULL(GUEST_INFO_1.GILName, '') AS [Guest Name], REGISTRATION.RegGuestType, REGISTRATION.RegDate, REGISTRATION.RegAmt,  " & _
                                        "       COUNT(REGISTRATION_DETAILS.RegDNo) AS Expr2, SUM(REGISTRATION_DETAILS.RegDNoGuest) AS Expr3, REGISTRATION.RegStat,  " & _
                                        "       REGISTRATION.RegRemarks, '' AS Expr4 " & _
                                        "FROM   GUEST AS GUEST_1 INNER JOIN " & _
                                        "       GUEST_INFO AS GUEST_INFO_1 ON GUEST_1.GIID = GUEST_INFO_1.GIID INNER JOIN " & _
                                        "       REGISTRATION ON GUEST_1.GNo = REGISTRATION.GNo INNER JOIN " & _
                                        "       REGISTRATION_DETAILS ON REGISTRATION.RegNo = REGISTRATION_DETAILS.RegNo " & _
                                        "GROUP BY REGISTRATION.RegNo, ISNULL(GUEST_INFO_1.GITitle, '') + ' ' + ISNULL(GUEST_INFO_1.GIFName, '') + ' ' + ISNULL(GUEST_INFO_1.GILName, ''),  " & _
                                        "       REGISTRATION.RegGuestType, REGISTRATION.RegDate, REGISTRATION.RegAmt, REGISTRATION.RegStat, REGISTRATION.RegRemarks,  " & _
                                        "       GUEST_1.CID " & _
                                        "HAVING (GUEST_1.CID = '" & gCid & "') ", _
                                        dgvListOfPreviousTransactions).ToString
        End If
    End Sub

    Private Sub dgvListOfPreviousTransactions_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvListOfPreviousTransactions.SelectionChanged
        If dgvListOfPreviousTransactions.SelectedRows.Count <> 0 Then

            Dim myTransaction As Transaction

            If dgvListOfPreviousTransactions.Item(1, dgvListOfPreviousTransactions.CurrentRow.Index).Value.ToString.ToUpper = "RESERVATION" Then
                myTransaction = Transaction.Reservation
            ElseIf dgvListOfPreviousTransactions.Item(1, dgvListOfPreviousTransactions.CurrentRow.Index).Value.ToString.ToUpper = "REGISTRATION" Then
                myTransaction = Transaction.Registration
            End If

            lblTotalCharges.Text = Format(TotalCharges(dgvListOfPreviousTransactions.Item(0, dgvListOfPreviousTransactions.CurrentRow.Index).Value.ToString, myTransaction), "n")
            lblTotalPayments.Text = Format(TotalPayments(dgvListOfPreviousTransactions.Item(0, dgvListOfPreviousTransactions.CurrentRow.Index).Value.ToString, myTransaction), "n")
            lblTotalBalance.Text = Format(CType(lblTotalCharges.Text, Double) - CType(lblTotalPayments.Text, Double), "n")

        End If
    End Sub

    Private Sub tsmGuestHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmGuestHistory.Click
        If dgvGuests.SelectedRows.Count = 1 Then
            gGiid = dgvGuests.Item(0, dgvGuests.CurrentRow.Index).Value.ToString
            lblGuestName.Text = dgvGuests.Item(1, dgvGuests.CurrentRow.Index).Value.ToString & " " & _
                                dgvGuests.Item(2, dgvGuests.CurrentRow.Index).Value.ToString & " " & _
                                dgvGuests.Item(4, dgvGuests.CurrentRow.Index).Value.ToString
            ConstructGuestHistory()
            tbcGuestInformation.SelectedIndex = 2

        Else
            gGiid = String.Empty
        End If
    End Sub

    Private Sub tsmCompany_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmCompany.Click
        If dgvCompany.SelectedRows.Count = 1 Then
            gCid = dgvCompany.Item(0, dgvCompany.CurrentRow.Index).Value.ToString
            lblGuestName.Text = dgvCompany.Item(1, dgvCompany.CurrentRow.Index).Value.ToString 
            ConstructCompanyHistory()
            tbcGuestInformation.SelectedIndex = 2
        Else
            gCid = String.Empty
        End If
    End Sub

#End Region

#Region "MISC"

    Private Sub frmGuestInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgvGuests.AlternatingRowsDefaultCellStyle = SetAlternatingColor()
        dgvCompany.AlternatingRowsDefaultCellStyle = SetAlternatingColor()
        dgvListOfPreviousTransactions.AlternatingRowsDefaultCellStyle = SetAlternatingColor()

        lblGuestName.Text = "-"
        DisplayIndividualGuest()
        DisplayCompanyInformation()
        UpdateComboBoxes()
    End Sub

    Private Sub frmGuestInformation_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        Dim blnInformed As Boolean = False
        If gState(0) <> State.waiting Then
            tbcGuestInformation.SelectedIndex = 0
            blnInformed = True
            Select Case Msg("1033", Button.YesNoCancel)
                Case ButtonClicked.Yes
                    If ThereAreInputErrorsAtGuestInformation() Then
                        e.Cancel = True
                    Else
                        btnAdd_Click(Nothing, Nothing)
                    End If
                Case ButtonClicked.No
                    e.Cancel = False
                Case ButtonClicked.Cancel
                    e.Cancel = True
            End Select
        End If

        If blnInformed = False AndAlso gState(1) <> State.waiting Then
            tbcGuestInformation.SelectedIndex = 1
            Select Case Msg("1033", Button.YesNoCancel)
                Case ButtonClicked.Yes
                    If ThereAreInputErrorsAtCompany() Then
                        e.Cancel = True
                    Else
                        btnSave_Company_Click(Nothing, Nothing)
                    End If
                Case ButtonClicked.No
                    e.Cancel = False
                Case ButtonClicked.Cancel
                    e.Cancel = True
            End Select
        End If

    End Sub

    Private Sub lblClose_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblClose.LinkClicked
        Me.Close()
    End Sub

#End Region

#Region "Side Bars"

    Private Sub tsbGuestSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuestSearch.Click
        TriggeredBy = TriggeringForm.GuestInfo
        frmGuestSearch.ShowDialog()
    End Sub

    Private Sub tsbPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbPayment.Click
        SearchedGuestID = gGiid
        SearchedCompanyID = gCid
        Display(Forms.frmPayment)
        frmPayment.FillMe()
    End Sub

#End Region

End Class