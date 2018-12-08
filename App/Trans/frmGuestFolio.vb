Option Explicit On
Option Strict On
Imports System.Data.SqlClient

' Programmer:   Jo Jefferson D. Peralta
' Date:         March 22, 2007
' Title:        frmGuestFolio
' Purpose:      This interface displays the bills and payments for all 
'               reservations and registrations in the hotel. No matter the status of a
'               transaction it can be viewed through this form.
' Requirements: ->  (-)FOLIO_DETAILS(FDNo)
'               ->  (*)REGISTRATION(RegAmt, RegBalance)
'               ->  (*)REGISTRATION_DETAILS(RegDDaysUpdated)
'               ->  System authorization is needed to successfully continue with the deletion of a bill information.
'               ->  The guest must use the reservation form to remove or modify the bills, usually the reservation
'                   downpayments, of a specific reservation. Otherwise if the user wishes to modify/delete the
'                   information of an active registration he may use this interface. 
'               ->  The user cannot delete the bill information if a registration is already checked out.
'               ->  Using this interface, the user can determine the balances of a transaction given a date.
'                   For instance, the FDO knows the current bills of a guest on his 3rd day or can show all the
'                   bills from the date of check in to the date of departure.
' Results:      ->  The user was able to determine the balances by mapping the current bills and payments of
'               ->  either a reservation or a registration.
'               ->  If authorized, the user can remove a bill information thus updating the folio and the reservation
'                   amount and balance.
'messagebox

Public Class frmGuestFolio

    Private gGiid As String = String.Empty
    Private gCid As String = String.Empty
    Private gRegNo As String = String.Empty
    Private gResNo As String = String.Empty
    Private gTransaction As Transaction

#Region "Functions/SubRoutines"

    Public Sub FillMe()

        Try
            If RegistrationIsNotSet And ReservationIsNotSet Then
                Msg("1046")
                Exit Sub
            Else
                If Not RegistrationIsNotSet Then
                    gTransaction = Transaction.Registration
                    btnRemove.Enabled = True
                    gRegNo = SearchedRegistrationNo

                    Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
                        objConnection.Open()
                        Using objCommand As SqlCommand = New SqlCommand("SELECT  ISNULL(SUM(RefAmt),0), ISNULL(COUNT(RefID),0) FROM  REFUND GROUP BY RegNo HAVING (RegNo = '" & gRegNo & "')", objConnection)
                            Using objReader As SqlDataReader = objCommand.ExecuteReader
                                objReader.Read()
                                If objReader.HasRows Then
                                    lblNoOfRefunds.Text = objReader(1).ToString
                                    lblRefund.Text = Format(objReader(0), "n")
                                Else
                                    lblNoOfRefunds.Text = "0"
                                    lblRefund.Text = "0"
                                End If
                            End Using
                        End Using
                        objConnection.Close()
                    End Using

                    If IsExisting("SELECT RegNo FROM REGISTRATION WHERE RegNo='" & gRegNo & "' AND RegStat='REGISTERED'") Then
                        btnRemove.Enabled = True
                        lblRemove.Text = ""
                    Else
                        btnRemove.Enabled = False
                        lblRemove.Text = "Already Checked Out"
                    End If

                Else
                    gTransaction = Transaction.Reservation
                    btnRemove.Enabled = False
                    lblRemove.Text = "Use the reservation form to edit downpayment."
                    gResNo = SearchedReservationNo

                    Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
                        objConnection.Open()
                        Using objCommand As SqlCommand = New SqlCommand("SELECT  ISNULL(SUM(RefAmt),0), ISNULL(COUNT(RefID),0) FROM  REFUND GROUP BY ResNo HAVING (ResNo = '" & gResNo & "')", objConnection)
                            Using objReader As SqlDataReader = objCommand.ExecuteReader
                                objReader.Read()
                                If objReader.HasRows Then
                                    lblNoOfRefunds.Text = objReader(1).ToString
                                    lblRefund.Text = Format(objReader(0), "n")
                                Else
                                    lblNoOfRefunds.Text = "0"
                                    lblRefund.Text = "0"
                                End If
                            End Using
                        End Using
                        objConnection.Close()
                    End Using


                End If

                gGiid = SearchedGuestID
                gCid = SearchedCompanyID

            End If

            ConstructGuestInformation()
            UpdateBills()
            UpdatePayments()
            UpdateTotals()

        Catch ex As Exception
            'ClearControls(Me)
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub UpdateBills()

        If gRegNo = String.Empty And gResNo = String.Empty Then Exit Sub

        Select Case gTransaction
            Case Transaction.Registration

                lblCountBills.Text = ListItems(DatabasePath, _
                                        "SELECT FOLIO_DETAILS.FDNo AS [Folio No.], FOLIO_DETAILS.FDName AS [Service/Amenity], FOLIO_DETAILS.FDModifiedCharge AS Amount, " & _
                                        "       FOLIO_DETAILS.FDReceiptNo AS [Receipt No.], ISNULL(REGISTRATION_DETAILS.RMNo, 'REGISTRATION') AS [Charge To],  " & _
                                        "       FOLIO_DETAILS.FDDate AS [Date Incurred], FOLIO_DETAILS.FDModifiedByAmt AS [Modification in Amount],  " & _
                                        "       FOLIO_DETAILS.FDModifiedByPercent AS [Modification By Percent], FOLIO_DETAILS.FDServiceRep AS [Service Representative],  " & _
                                        "       FOLIO_DETAILS.FDRemarks AS Remarks, FDStat as Status, FDDesc as [Description], FDBalance as [Balance] " & _
                                        "FROM   FOLIO_DETAILS LEFT OUTER JOIN " & _
                                        "       REGISTRATION_DETAILS ON FOLIO_DETAILS.RegDNo = REGISTRATION_DETAILS.RegDNo " & _
                                        "WHERE  FOLIO_DETAILS.REGNO='" & gRegNo & "' " & IIf(chkSelectAll.Checked, " ", " AND FOLIO_DETAILS.FDDate BETWEEN '" & dtpStartDate.Value & "' AND '" & dtpEndDate.Value & "' ").ToString, _
                                        dgvBillBreakdown).ToString

            Case Transaction.Reservation

                lblCountBills.Text = ListItems(DatabasePath, _
                                        "SELECT FDNo AS [Folio No.], 'DOWNPAYMENT' AS [Service/Amenity], FDModifiedCharge AS Amount, FDReceiptNo AS [Receipt No.], FDDate AS [Date Incurred], " & _
                                        "       FDModifiedByAmt AS [Modification in Amount], FDModifiedByPercent AS [Modification By Percent], FDServiceRep AS [Service Representative], FDRemarks AS [Remarks], FDDesc as [Description], FDStat as [Status] " & _
                                        "FROM   FOLIO_DETAILS " & _
                                        "WHERE  FOLIO_DETAILS.ResNo='" & gResNo & "' " & IIf(chkSelectAll.Checked, " ", " AND FOLIO_DETAILS.FDDate BETWEEN '" & dtpStartDate.Value & "' AND '" & dtpEndDate.Value & "' ").ToString, _
                                        dgvBillBreakdown).ToString

        End Select

        Dim dblCtr As Double = 0.0
        Dim dblUncollectibles As Double = 0.0
        Dim intUncollectibles As Integer = 0
        For intCtr As Integer = 0 To dgvBillBreakdown.RowCount - 1
            If dgvBillBreakdown.Item(10, intCtr).Value.ToString.ToUpper <> "UNCOLLECTIBLE" Then
                dblCtr += CType(dgvBillBreakdown.Item(2, intCtr).Value, Double)
            Else
                dblUncollectibles += CType(dgvBillBreakdown.Item(2, intCtr).Value, Double)
                intUncollectibles += 1
            End If
        Next

        lblUncollectibles.Text = Format(dblUncollectibles, "n")
        lblCountUncollectibles.Text = intUncollectibles.ToString
        lblTotal.Text = Format(dblCtr, "n")

    End Sub

    Private Sub UpdatePayments()

        If gRegNo = String.Empty And gResNo = String.Empty Then Exit Sub

        Select Case gTransaction
            Case Transaction.Registration


                lblTotalNumberOfPayments.Text = ListItems(DatabasePath, _
                 "SELECT PAYMENT.PID AS [Payment No], PAYMENT.PAmt AS Amount, PAYMENT.PDate AS [Payment Date], PAYMENT.PPayer AS [Paid By],  " & _
                 "       ISNULL(EMPLOYEE.EFName, '') + ' ' + ISNULL(EMPLOYEE.ELName, '') AS [Received By] " & _
                 "FROM   PAYMENT INNER JOIN " & _
                 "       LOG_INFO ON PAYMENT.LNo = LOG_INFO.LNo INNER JOIN " & _
                 "       EMPLOYEE ON LOG_INFO.EID = EMPLOYEE.EID  " & _
                 "WHERE  (PAYMENT.RegNo = '" & gRegNo & "') " & _
                 "UNION " & _
                 "SELECT PAYMENT_DETAILS.PID, SUM(PAYMENT_DETAILS.PDAmt) AS Expr2, PAYMENT_1.PDate, PAYMENT_1.PPayer, ISNULL(EMPLOYEE_1.EFName, '')  " & _
                 "       + ' ' + ISNULL(EMPLOYEE_1.ELName, '') AS Expr1 " & _
                 "FROM   RESERVATION INNER JOIN " & _
                 "       FOLIO_DETAILS ON RESERVATION.ResNo = FOLIO_DETAILS.ResNo INNER JOIN " & _
                 "       PAYMENT_DETAILS ON FOLIO_DETAILS.FDNo = PAYMENT_DETAILS.FDNo INNER JOIN " & _
                 "       PAYMENT AS PAYMENT_1 ON PAYMENT_DETAILS.PID = PAYMENT_1.PID INNER JOIN " & _
                 "       LOG_INFO AS LOG_INFO_1 ON PAYMENT_1.LNo = LOG_INFO_1.LNo INNER JOIN " & _
                 "       EMPLOYEE AS EMPLOYEE_1 ON LOG_INFO_1.EID = EMPLOYEE_1.EID " & _
                 "GROUP BY PAYMENT_DETAILS.PID, PAYMENT_1.PPayer, ISNULL(EMPLOYEE_1.EFName, '') + ' ' + ISNULL(EMPLOYEE_1.ELName, ''), RESERVATION.RegNo,  " & _
                 "       PAYMENT_1.PDate " & _
                 "HAVING (RESERVATION.RegNo = '" & gRegNo & "') ", dgvPaymentHistory).ToString

            Case Transaction.Reservation

                lblTotalNumberOfPayments.Text = ListItems(DatabasePath, _
                       "SELECT PAYMENT.PID AS [Payment No], PAYMENT.PAmt AS Amount, PAYMENT.PDate AS [Payment Date], PAYMENT.PPayer AS [Paid By], " & _
                       "       ISNULL(EMPLOYEE.EFName, '') + ' ' + ISNULL(EMPLOYEE.ELName, '') AS [Received By]  " & _
                       "FROM   PAYMENT INNER JOIN " & _
                       "       LOG_INFO ON PAYMENT.LNo = LOG_INFO.LNo INNER JOIN " & _
                       "       EMPLOYEE ON LOG_INFO.EID = EMPLOYEE.EID " & _
                       "WHERE  (PAYMENT.PID IN " & _
                       "        (SELECT PAYMENT_DETAILS.PID " & _
                       "         FROM   FOLIO_DETAILS INNER JOIN " & _
                       "         PAYMENT_DETAILS ON FOLIO_DETAILS.FDNo = PAYMENT_DETAILS.FDNo " & _
                       "         WHERE  (FOLIO_DETAILS.ResNo = '" & gResNo & "'))) ", dgvPaymentHistory).ToString

        End Select

    End Sub

    Private Sub UpdateTotals()

        If gRegNo = String.Empty And gResNo = String.Empty Then Exit Sub

        If gTransaction = Transaction.Registration Then

            lblTotalBill.Text = Format(TotalCharges(gRegNo, Transaction.Registration), "n")
            lblTotalPayment.Text = Format(TotalPayments(gRegNo, Transaction.Registration), "n")
            lblTotalBalanceAmt.Text = Format(CType(lblTotalBill.Text, Double) - CType(lblTotalPayment.Text, Double), "n")

        ElseIf gTransaction = Transaction.Reservation Then

            lblTotalBill.Text = Format(TotalCharges(gResNo, Transaction.Reservation), "n")
            lblTotalPayment.Text = Format(TotalPayments(gResNo, Transaction.Reservation), "n")
            lblTotalBalanceAmt.Text = Format(CType(lblTotalBill.Text, Double) - CType(lblTotalPayment.Text, Double), "n")

        End If

    End Sub

    Private Sub ConstructGuestInformation()
        Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)

            objConnection.Open()

            Using objCommand As SqlCommand = New SqlCommand()

                objCommand.Connection = objConnection
                If gTransaction = Transaction.Registration Then

                    objCommand.CommandText = "SELECT ISNULL(GUEST_INFO.GITitle, '') + ' ' + ISNULL(GUEST_INFO.GIFName, '') + ' ' + ISNULL(GUEST_INFO.GIMI, '') + ' ' + ISNULL(GUEST_INFO.GILName, '')  " & _
                                             "       AS [Guest Name], GUEST_INFO.GIAddress + ' ' + ISNULL(GUEST_INFO.GICountry, '') + ' ' + ISNULL(GUEST_INFO.GIZIP, '') AS Address,  " & _
                                             "       GUEST_INFO.GIContact AS [Contact No], COMPANY.CName AS [Company Name], COMPANY.CAddress + ' ' + ISNULL(COMPANY.CBranch, '')  " & _
                                             "       AS [Company Address], ISNULL(COMPANY.CContactPerson, '') + ' ' + ISNULL(COMPANY.CPos, '') + ' ' + ISNULL (COMPANY.CContact,'') AS [COMPANY CONTACT], REGISTRATION.RegDate " & _
                                             "FROM   REGISTRATION INNER JOIN " & _
                                             "       GUEST ON REGISTRATION.GNo = GUEST.GNo LEFT OUTER JOIN " & _
                                             "       COMPANY ON GUEST.CID = COMPANY.CID RIGHT OUTER JOIN " & _
                                             "       GUEST_INFO ON GUEST.GIID = GUEST_INFO.GIID " & _
                                             "WHERE  REGISTRATION.REGNO='" & gRegNo & "'"
                ElseIf gTransaction = Transaction.Reservation Then

                    objCommand.CommandText = "SELECT ISNULL(GUEST_INFO.GITitle, '') + ' ' + ISNULL(GUEST_INFO.GIFName, '') + ' ' + ISNULL(GUEST_INFO.GIMI, '') + ' ' + ISNULL(GUEST_INFO.GILName, '')  " & _
                                             "       AS [Guest Name], GUEST_INFO.GIAddress + ' ' + ISNULL(GUEST_INFO.GICountry, '') + ' ' + ISNULL(GUEST_INFO.GIZIP, '') AS Address,  " & _
                                             "       GUEST_INFO.GIContact AS [Contact No], COMPANY.CName AS [Company Name], COMPANY.CAddress + ' ' + ISNULL(COMPANY.CBranch, '')  " & _
                                             "       AS [Company Address], ISNULL(COMPANY.CContactPerson, '') + ' ' + ISNULL(COMPANY.CPos, '') + ' ' + ISNULL (COMPANY.CContact,'') AS [COMPANY CONTACT], RESERVATION.ResDate " & _
                                             "FROM   RESERVATION INNER JOIN " & _
                                             "       GUEST ON RESERVATION.GNo = GUEST.GNo LEFT OUTER JOIN " & _
                                             "       COMPANY ON GUEST.CID = COMPANY.CID RIGHT OUTER JOIN " & _
                                             "       GUEST_INFO ON GUEST.GIID = GUEST_INFO.GIID " & _
                                             "WHERE RESERVATION.RESNO='" & gResNo & "'"
                End If

                Using objReader As SqlDataReader = objCommand.ExecuteReader
                    objReader.Read()
                    txtName.Text = objReader(0).ToString
                    txtAddress.Text = objReader(1).ToString
                    txtContactNo.Text = objReader(2).ToString
                    txtCompany.Text = objReader(3).ToString
                    txtCompanyAddress.Text = objReader(4).ToString
                    txtCompanyContactNo.Text = objReader(5).ToString 'txtCompanyContactNo
                    dtpStartDate.Value = CType(objReader(6), Date)
                    dtpEndDate.Value = Date.Now
                End Using

            End Using

            objConnection.Close()
        End Using
    End Sub

#End Region

#Region "Command Buttons"

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        If dgvBillBreakdown.SelectedRows.Count = 0 Then
            Msg("1005")
        Else

            If IsExisting("SELECT FDNO FROM PAYMENT_DETAILS WHERE FDNo='" & dgvBillBreakdown.Item(0, dgvBillBreakdown.CurrentRow.Index).Value.ToString & "'") Then
                Msg("1006", , "Cannot delete the folio because it already has payments.")
                Exit Sub
            End If

            Dim blnAuthorized As Boolean = False
            If UserPrivilege = Privilege.query Then
                blnAuthorized = False
            Else
                If My.Settings.RestrictDeleteAtFolio AndAlso UserPrivilege = Privilege.transaction Then
                    frmAuthorization.ShowDialog()
                    blnAuthorized = frmAuthorization.Result
                Else
                    If Msg("1034", Button.YesNo) = ButtonClicked.Yes Then
                        blnAuthorized = True
                    Else
                        blnAuthorized = False
                    End If
                End If
            End If

            If blnAuthorized Then
                Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
                    objConnection.Open()
                    Using objTransaction As SqlTransaction = objConnection.BeginTransaction
                        Using objCommand As SqlCommand = objConnection.CreateCommand
                            With objCommand
                                .Transaction = objTransaction

                                Try

                                    If gTransaction = Transaction.Registration AndAlso dgvBillBreakdown.Item(11, dgvBillBreakdown.CurrentRow.Index).Value.ToString.ToUpper = "ROOM" Then

                                        .CommandText = "SELECT RegDNo FROM FOLIO_DETAILS WHERE FDNo=@FDNo"
                                        .Parameters.Clear()
                                        .Parameters.AddWithValue("@FDNo", dgvBillBreakdown.Item(0, dgvBillBreakdown.CurrentRow.Index).Value)
                                        Dim strRegDNo As String = CType(.ExecuteScalar, String)

                                        '.CommandText = "SELECT ISNULL(COUNT(FDNO),0) FROM FOLIO_DETAILS WHERE RegDNo=@RegDNo AND FDDesc='ROOM'"
                                        '.Parameters.Clear()
                                        '.Parameters.AddWithValue("@RegDNo", strRegDNo)
                                        'Dim intNoOfRoomCharges As Integer = CType(.ExecuteScalar, Integer)

                                        .CommandText = "UPDATE REGISTRATION_DETAILS SET RegDDaysUpdated=RegDDaysUpdated - 1 WHERE RegDNo=@RegDNo"
                                        .Parameters.Clear()
                                        '.Parameters.AddWithValue("@RegDDaysUpdated", intNoOfRoomCharges).SqlDbType = SqlDbType.Int
                                        .Parameters.AddWithValue("@RegDNo", strRegDNo)
                                        .ExecuteNonQuery()

                                    End If

                                    .CommandText = "DELETE FROM FOLIO_DETAILS WHERE FDNo=@FDNo"
                                    .Parameters.Clear()
                                    .Parameters.AddWithValue("@FDNo", dgvBillBreakdown.Item(0, dgvBillBreakdown.CurrentRow.Index).Value)
                                    .ExecuteNonQuery()

                                    .CommandText = "UPDATE REGISTRATION SET RegAmt=RegAmt-@ThisAmount, RegBalance=RegBalance-@ThisAmount WHERE RegNo=@RegNo"
                                    .Parameters.Clear()
                                    .Parameters.AddWithValue("@ThisAmount", dgvBillBreakdown.Item(2, dgvBillBreakdown.CurrentRow.Index).Value).SqlDbType = SqlDbType.Money
                                    .Parameters.AddWithValue("@RegNo", gRegNo)
                                    .ExecuteNonQuery()

                                    objTransaction.Commit()

                                    UpdateBills()
                                    UpdateTotals()

                                Catch ex As Exception

                                    objTransaction.Rollback()
                                    Msg("1008", , NWLN & ex.Message)

                                End Try
                            End With
                        End Using
                    End Using
                    objConnection.Close()
                End Using
            End If


        End If
    End Sub

#End Region

#Region "MISC"

    Private Sub chkSelectAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSelectAll.CheckedChanged
        dtpStartDate.Enabled = Not chkSelectAll.Checked
        dtpEndDate.Enabled = Not chkSelectAll.Checked
        UpdateBills()
        UpdatePayments()
    End Sub

    Private Sub dtpEndDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpEndDate.ValueChanged
        UpdateBills()
        UpdatePayments()
    End Sub

    Private Sub dtpStartDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpStartDate.ValueChanged
        UpdateBills()
        UpdatePayments()
    End Sub

    Private Sub frmGuestFolio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        dgvBillBreakdown.AlternatingRowsDefaultCellStyle = SetAlternatingColor()
        dgvPaymentHistory.AlternatingRowsDefaultCellStyle = SetAlternatingColor()

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
    End Sub

#End Region

#Region "Side Bars"

    Private Sub tsbGuestSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuestSearch.Click
        TriggeredBy = TriggeringForm.GuestFolio
        frmGuestSearch.ShowDialog()
    End Sub

    Private Sub tsbActIncDec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbActIncDec.Click
        SearchedGuestID = gGiid
        SearchedCompanyID = gCid
        SearchedRegistrationNo = gRegNo
        SearchedReservationNo = gResNo

        Display(Forms.frmModifyAmount)

        frmModifyAmount.FillMe()
    End Sub

    Private Sub tsbUncollectibles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbUncollectibles.Click

        SearchedGuestID = gGiid
        SearchedCompanyID = gCid
        SearchedRegistrationNo = gRegNo
        SearchedReservationNo = gResNo

        Display(Forms.frmUncollectible)

        frmUncollectible.FillMe()

    End Sub

    Private Sub tsbActRmCharge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbActRmCharge.Click
        SearchedGuestID = gGiid
        SearchedCompanyID = gCid
        SearchedRegistrationNo = gRegNo
        SearchedReservationNo = gResNo

        Display(Forms.frmUpdateRoomCharge)

        frmUpdateRoomCharge.FillMe()

    End Sub

    Private Sub tsbActAmnServ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbActAmnServ.Click
        SearchedGuestID = gGiid
        SearchedCompanyID = gCid
        SearchedRegistrationNo = gRegNo
        SearchedReservationNo = gResNo

        Display(Forms.frmAmenitiesAndServices)

        frmAmenitiesAndServices.FillMe()
    End Sub

    Private Sub tsbActAccTrans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbActAccTrans.Click
        SearchedGuestID = gGiid
        SearchedCompanyID = gCid
        SearchedRegistrationNo = gRegNo
        SearchedReservationNo = gResNo

        Display(Forms.frmAccountTransfer)

        frmAccountTransfer.FillGuestBill()
    End Sub

    Private Sub tsbActPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbActPayment.Click

        SearchedGuestID = gGiid
        SearchedCompanyID = gCid
        SearchedRegistrationNo = gRegNo
        SearchedReservationNo = gResNo

        Display(Forms.frmPayment)

        frmPayment.FillMe()

    End Sub

#End Region
    
End Class