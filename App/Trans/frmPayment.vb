Option Explicit On
Option Strict On

Imports System.Data
Imports System.Data.SqlClient

' Programmer:   Jo Jefferson D. Peralta
' Date:         April 01, 2007
' Title:        frmPayment
' Purpose:      This Interface accepts payments from registrations, reservations, and direct billers.
'               It accepts payment modes which includes payment through cash, credit card, bank,
'               cheque, and whenever there are refunds a recompense can be applied as payment.
'               Pay Slips are also saved and printed as requested by the guest.
' Requirements: ->  (+)PAYMENT (PID, PAmt, PDate, PPayer, DBID, LNO, RegNo, ResNo)
'               ->  (*)DIRECT_BILLER(DBBalance, DBStatus)
'               ->  (*)REGISTRATION(RegAmt, RegBalance)
'               ->  (*)RESERVATION(ResAmt, ResBalance)
'               ->  (*)FOLIO_DETAILS(FDNo, FDBalance, FDStat)
'               ->  (+)PAYMENT_DETAILS (PID, FDNO, PDAmt)
'               ->  (+)BANK(PTID, BNAcctNo, BNname, BNBranch)
'               ->  (+)CHEQUE(PTID, CHNO, CHBank, CHMatdate, CHExpDate)
'               ->  (+)CREDIT_CARD(PTID, CCOWNER, CCTYPE, CCNo)
'               ->  (+)RECOMPENSE(PTID, REFId)
'               ->  (*)REFUND(RefBalance, RefTimeChange, RefStat)
'               ->  (+)PAYMENT_TYPE_DETAILS(PTID, PTamt, PTType, PID)
'               ->  (*)SYSTEM (TotalCashInFd)
' Results:      ->  Previous payment slips are printed or viewed.
'               ->  If the folio item's balance is zero it is marked as paid. Users cannot pay uncollectibles
'                   in the folio or direct biller table.
'               ->  Total cash in front desk is updated for every cash and credit cards paid.
'messagebox

Public Class frmPayment

#Region "DECLARATION:"
    Private gGiid As String
    Private gDBID As String = String.Empty
    Private gResNo As String = String.Empty
    Private gRegNo As String = String.Empty
    Private gState As State = State.waiting
    Private gFirstName As String = String.Empty
    Private myTransaction As Transaction

    Private dblBaseTotalRecompense As Double = 0
    Private dblBaseTotalInHand As Double = 0
    Private dblBaseTotalReceivable As Double = 0
    Private dblTotalRecompense As Double = 0
    Private dblTotalInHand As Double = 0
    Private dblTotalReceivable As Double = 0

    Private blnComputeChange As Boolean = True
   
#End Region

#Region "Functions/SubRoutines"

    Private Sub DisplayTransaction()
        ListItems(DatabasePath, _
                    "SELECT REGISTRATION.RegNo AS [Transaction No], 'REGISTRATION' AS [Transaction], ISNULL(GUEST_INFO.GIFName, '') " & _
                    "       + ' ' + ISNULL(GUEST_INFO.GILName, '') AS Name, REGISTRATION.RegDate AS Date, REGISTRATION.RegAmt AS Amount,  " & _
                    "       REGISTRATION.RegBalance AS Balance, REGISTRATION.RegStat AS Status, REGISTRATION.RegRemarks AS Remarks " & _
                    "FROM   GUEST INNER JOIN " & _
                    "       REGISTRATION ON GUEST.GNo = REGISTRATION.GNo INNER JOIN " & _
                    "       GUEST_INFO ON GUEST.GIID = GUEST_INFO.GIID " & _
                    "WHERE  (REGISTRATION.RegStat = 'REGISTERED') AND (GUEST.GIID = '" & gGiid & "') " & _
                    "UNION " & _
                    "SELECT RESERVATION.ResNo, 'RESERVATION' AS Expr1, ISNULL(GUEST_INFO_1.GIFName, '') + ' ' + ISNULL(GUEST_INFO_1.GILName, '') AS Expr2,  " & _
                    "       RESERVATION.ResDate, RESERVATION.ResAmt, RESERVATION.ResBalance, RESERVATION.ResStat, RESERVATION.ResRemarks " & _
                    "FROM   RESERVATION INNER JOIN " & _
                    "       GUEST AS GUEST_1 ON RESERVATION.GNo = GUEST_1.GNo INNER JOIN " & _
                    "       GUEST_INFO AS GUEST_INFO_1 ON GUEST_1.GIID = GUEST_INFO_1.GIID " & _
                    "WHERE  (GUEST_1.GIID = '" & gGiid & "') AND (RESERVATION.ResStat <> 'CANCELLED') " & _
                    "UNION " & _
                    "SELECT DIRECT_BILLER.DBID, 'DIRECT BILLING' AS Expr1, DIRECT_BILLER.DBName, DIRECT_BILLER.DBDate, DIRECT_BILLER.DBAmt,  " & _
                    "       DIRECT_BILLER.DBBalance, DIRECT_BILLER.DBStatus, ISNULL(DIRECT_BILLER.DBRemarks, '') AS Expr2 " & _
                    "FROM   GUEST AS GUEST_2 INNER JOIN " & _
                    "       REGISTRATION AS REGISTRATION_1 ON GUEST_2.GNo = REGISTRATION_1.GNo RIGHT OUTER JOIN " & _
                    "       DIRECT_BILLER ON REGISTRATION_1.DBID = DIRECT_BILLER.DBID " & _
                    "WHERE  (GUEST_2.GIID = '" & gGiid & "') ", _
                    dgvTransaction)

    End Sub

    Private Sub DisplayBill()

        dgvBillingInformation.DataBindings.Clear()
        For Each ctlRow As DataGridViewRow In dgvBillingInformation.Rows
            dgvBillingInformation.Rows.Remove(ctlRow)
        Next

        If dgvTransaction.SelectedRows.Count = 1 Then

            Select Case dgvTransaction.Item(1, dgvTransaction.CurrentRow.Index).Value.ToString.ToUpper
                Case "REGISTRATION"
                    ListItems(DatabasePath, _
                            "SELECT FDNo AS [Billing No], FDReceiptNo AS [Receipt No], FDName AS [Service/Amenity], FDModifiedCharge AS Amount, FDBalance AS Balance,  " & _
                            "       FDDate AS Date, FDStat AS Status, FDDesc AS Description, FDRemarks AS Remarks " & _
                            "FROM   FOLIO_DETAILS " & _
                            "WHERE  (RegNo = '" & dgvTransaction.Item(0, dgvTransaction.CurrentRow.Index).Value.ToString & "') ", dgvBillingInformation)
                    myTransaction = Transaction.Registration

                    Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
                        objConnection.Open()
                        Using objCommand As SqlCommand = New SqlCommand("SELECT COMPANY.CName " & _
                                                                        "FROM   REGISTRATION INNER JOIN " & _
                                                                        "       GUEST ON REGISTRATION.GNo = GUEST.GNo INNER JOIN " & _
                                                                        "       COMPANY ON GUEST.CID = COMPANY.CID " & _
                                                                        "WHERE  (REGISTRATION.RegNo = '" & dgvTransaction.Item(0, dgvTransaction.CurrentRow.Index).Value.ToString & "') ", _
                                                                        objConnection)
                            Dim objCompanyName As Object = objCommand.ExecuteScalar
                            If objCompanyName Is DBNull.Value Then
                                lblCompanyName.Text = "-"
                            Else
                                lblCompanyName.Text = CType(objCompanyName, String)
                            End If
                        End Using
                        objConnection.Close()
                    End Using

                Case "RESERVATION"
                    ListItems(DatabasePath, _
                            "SELECT FDNo AS [Billing No], FDReceiptNo AS [Receipt No], FDName AS Service, FDModifiedCharge AS Amount, FDBalance AS Balance, FDDate AS Date,  " & _
                            "       FDStat AS Status, FDDesc AS Description, FDRemarks AS Remarks " & _
                            "FROM   FOLIO_DETAILS " & _
                            "WHERE  (ResNo = '" & dgvTransaction.Item(0, dgvTransaction.CurrentRow.Index).Value.ToString & "') ", dgvBillingInformation)
                    myTransaction = Transaction.Reservation

                    Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
                        objConnection.Open()
                        Using objCommand As SqlCommand = New SqlCommand("SELECT COMPANY.CName " & _
                                                                        "FROM   RESERVATION INNER JOIN " & _
                                                                        "       GUEST ON RESERVATION.GNo = GUEST.GNo INNER JOIN " & _
                                                                        "       COMPANY ON GUEST.CID = COMPANY.CID " & _
                                                                        "WHERE  (RESERVATION.ResNo = '" & dgvTransaction.Item(0, dgvTransaction.CurrentRow.Index).Value.ToString & "') ", _
                                                                        objConnection)
                            Dim objCompanyName As Object = objCommand.ExecuteScalar
                            If objCompanyName Is DBNull.Value Then
                                lblCompanyName.Text = "-"
                            Else
                                lblCompanyName.Text = CType(objCompanyName, String)
                            End If
                        End Using
                        objConnection.Close()
                    End Using

                Case "DIRECT BILLING"
                    ListItems(DatabasePath, _
                            "SELECT DBID AS [Direct Biller ID], DBName AS Name, DBAmt AS Amount, DBBalance AS Balance, DBDate AS [Date Incurred], DBExpDate AS [Expiration Date],  " & _
                            "       DBStatus AS Status, DBAddress AS Address, DBContact AS Contact, DBRemarks AS Remarks " & _
                            "FROM   DIRECT_BILLER " & _
                            "WHERE  (DBID = '" & dgvTransaction.Item(0, dgvTransaction.CurrentRow.Index).Value.ToString & "')", dgvBillingInformation)
                    myTransaction = Transaction.DirectBiller

                    Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
                        objConnection.Open()
                        Using objCommand As SqlCommand = New SqlCommand("SELECT COMPANY.CName " & _
                                                                        "FROM   REGISTRATION INNER JOIN " & _
                                                                        "       GUEST ON REGISTRATION.GNo = GUEST.GNo INNER JOIN " & _
                                                                        "       COMPANY ON GUEST.CID = COMPANY.CID " & _
                                                                        "WHERE  (REGISTRATION.DBID = '" & dgvTransaction.Item(0, dgvTransaction.CurrentRow.Index).Value.ToString & "') ", _
                                                                        objConnection)
                            Dim objCompanyName As Object = objCommand.ExecuteScalar
                            If objCompanyName Is DBNull.Value Then
                                lblCompanyName.Text = "-"
                            Else
                                lblCompanyName.Text = CType(objCompanyName, String)
                            End If
                        End Using
                        objConnection.Close()
                    End Using
            End Select

            lblTotalCharges.Text = Format(TotalCharges(dgvTransaction.Item(0, dgvTransaction.CurrentRow.Index).Value.ToString, myTransaction), "n")
            lblTotalPayments.Text = Format(TotalPayments(dgvTransaction.Item(0, dgvTransaction.CurrentRow.Index).Value.ToString, myTransaction), "n")
            lblTotalBalance.Text = Format(CType(lblTotalCharges.Text, Double) - CType(lblTotalPayments.Text, Double), "n")

        End If

    End Sub

    Public Sub FillMe()

        Try
            'Check if the user is currently doing a transaction
            If gState <> State.waiting Then
                Select Case Msg("1033", Button.YesNoCancel)
                    Case ButtonClicked.Yes
                        If ThereAreInputErrors() Then
                            Exit Sub
                        Else
                            btnSave_Payment_Click(Nothing, Nothing)
                        End If
                    Case ButtonClicked.No
                        'pass through
                    Case ButtonClicked.Cancel
                        Exit Sub
                End Select
            End If

            If GuestIsNotSet Then
                Msg("1065")
                Exit Sub
            End If

            lblTransaction.Text = "-"
            gState = State.waiting

            gGiid = SearchedGuestID

            tbcPayment.SelectedIndex = 0

            Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
                objConnection.Open()
                Using objCommand As SqlCommand = New SqlCommand("SELECT ISNULL(GITitle,'') + ' ' + ISNULL(GIFName,'') + ' ' + ISNULL(GILName,'') AS NAME, ISNULL(GIFName,'') FROM GUEST_INFO WHERE GIID='" & gGiid & "'", objConnection)
                    Using objReader As SqlDataReader = objCommand.ExecuteReader

                        objReader.Read()
                        lblGuestName.Text = objReader(0).ToString
                        gFirstName = objReader(1).ToString

                    End Using
                End Using
                objConnection.Close()
            End Using


            DisplayTransaction()

            If dgvTransaction.Rows.Count = 0 Then
                For Each ctlRow As DataGridViewRow In dgvBillingInformation.Rows
                    dgvBillingInformation.Rows.Remove(ctlRow)
                Next
                lblTransaction.Text = String.Empty
            Else
                DisplayBill()
            End If

        Catch ex As Exception
            ClearControls(Me)
        End Try

    End Sub

    Private Function ThereAreInputErrors() As Boolean

        If lsvReceipt.CheckedItems.Count = 0 Then
            Msg("1088")
            lsvReceipt.Focus()
            Return True
            Exit Function
        End If

        If CType(lblPaymentListTotalAmountTendered.Text, Double) <= 0 Then
            Msg("1089")
            tbcModeOfPayment.SelectedIndex = 0
            txtCashAmount.SelectAll()
            txtCashAmount.Focus()
            Return True
            Exit Function
        End If

        If Not My.Computer.FileSystem.DirectoryExists(My.Settings.ReceiptLocation) Then
            If Msg("1090", Button.Ok, "Cannot Find the Directory for the receipt. The application will now place the payment slips to MyDocuments") = ButtonClicked.Ok Then
                My.Settings.ReceiptLocation = My.Computer.FileSystem.SpecialDirectories.MyDocuments
                My.Settings.Save()
            Else
                Return True
                Exit Function
            End If
        End If

        Return False
    End Function

    Private Sub DisplayUnpaidBills()

        If dgvTransaction.SelectedRows.Count = 0 Then Exit Sub

        Select Case myTransaction
            Case Transaction.DirectBiller

                Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
                    objConnection.Open()
                    Using objCommand As SqlCommand = New SqlCommand("SELECT DBID AS [Direct Biller ID], DBName AS Name, DBAmt AS Amount, DBBalance AS Balance " & _
                                                                    "FROM   DIRECT_BILLER " & _
                                                                    "WHERE  (DBID = '" & dgvTransaction.Item(0, dgvTransaction.CurrentRow.Index).Value.ToString & "') " & _
                                                                    "AND DBstatus='UNPAID'", objConnection)
                        Using objReader As SqlDataReader = objCommand.ExecuteReader
                            lsvReceipt.Items.Clear()
                            Do While objReader.Read
                                Dim lsvItem As ListViewItem = lsvReceipt.Items.Add(objReader(0).ToString)
                                lsvItem.SubItems.Add("DIRECT BILLING")
                                lsvItem.SubItems.Add(Format(objReader(2), "n"))
                                lsvItem.SubItems.Add(Format(objReader(3), "n"))
                                txtPaidBy.Text = objReader(1).ToString
                            Loop

                        End Using
                    End Using
                    objConnection.Close()
                End Using

            Case Transaction.Reservation

                Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
                    objConnection.Open()
                    Using objCommand As SqlCommand = New SqlCommand("SELECT FDNo AS [Billing No], FDName AS Service, FDModifiedCharge AS Amount, FDBalance AS Balance " & _
                                                                    "FROM   FOLIO_DETAILS " & _
                                                                    "WHERE  (ResNo = '" & dgvTransaction.Item(0, dgvTransaction.CurrentRow.Index).Value.ToString & "') AND FDStat='UNPAID'", objConnection)
                        Using objReader As SqlDataReader = objCommand.ExecuteReader
                            lsvReceipt.Items.Clear()
                            Do While objReader.Read
                                Dim lsvItem As ListViewItem = lsvReceipt.Items.Add(objReader(0).ToString)
                                lsvItem.SubItems.Add(objReader(1).ToString)
                                lsvItem.SubItems.Add(Format(objReader(2), "n"))
                                lsvItem.SubItems.Add(Format(objReader(3), "n"))
                            Loop
                            txtPaidBy.Text = lblGuestName.Text
                        End Using
                    End Using
                    objConnection.Close()
                End Using

            Case Transaction.Registration

                Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
                    objConnection.Open()
                    Using objCommand As SqlCommand = New SqlCommand
                        objCommand.Connection = objConnection

                        If chkSelectAllRoom.Checked = False Then
                            objCommand.CommandText = "SELECT FOLIO_DETAILS.FDNo AS [Billing No], FOLIO_DETAILS.FDName AS [Service/Amenity], FOLIO_DETAILS.FDModifiedCharge AS Amount,  " & _
                                                     "       FOLIO_DETAILS.FDBalance AS Balance " & _
                                                     "FROM   FOLIO_DETAILS LEFT OUTER JOIN " & _
                                                     "       REGISTRATION_DETAILS ON FOLIO_DETAILS.RegDNo = REGISTRATION_DETAILS.RegDNo " & _
                                                     "WHERE   (REGISTRATION_DETAILS.RegNo = '" & dgvTransaction.Item(0, dgvTransaction.CurrentRow.Index).Value.ToString & "') AND FDStat='UNPAID' " & IIf(chkSelectAllRoom.Checked, "", "AND (REGISTRATION_DETAILS.RMNo = '" & cboRoom.Text & "')").ToString
                        Else
                            objCommand.CommandText = "SELECT FOLIO_DETAILS.FDNo AS [Billing No], FOLIO_DETAILS.FDName AS [Service/Amenity], FOLIO_DETAILS.FDModifiedCharge AS Amount,  " & _
                                                     "       FOLIO_DETAILS.FDBalance AS Balance " & _
                                                     "FROM   FOLIO_DETAILS " & _
                                                     "       " & _
                                                     "WHERE  FDStat='UNPAID' AND RegNo = '" & dgvTransaction.Item(0, dgvTransaction.CurrentRow.Index).Value.ToString & "' "
                        End If

                        Using objReader As SqlDataReader = objCommand.ExecuteReader
                            lsvReceipt.Items.Clear()
                            Do While objReader.Read
                                Dim lsvItem As ListViewItem = lsvReceipt.Items.Add(objReader(0).ToString)
                                lsvItem.SubItems.Add(objReader(1).ToString)
                                lsvItem.SubItems.Add(Format(objReader(2), "n"))
                                lsvItem.SubItems.Add(Format(objReader(3), "n"))
                            Loop
                            txtPaidBy.Text = lblGuestName.Text
                        End Using
                    End Using
                    objConnection.Close()
                End Using

        End Select
    End Sub

    Private Sub DisplayRecompense()

        Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
            objConnection.Open()
            Using objCommand As SqlCommand = New SqlCommand("SELECT REFUND.RefID AS [Refund No.], REFUND.RefAmt AS Amount, " & _
                                                            "      REFUND.RefDate AS [Date of Refund], REFUND.RefExpDate AS [Expiration Date], REFUND.RefRemarks AS Remarks " & _
                                                            "FROM  GUEST INNER JOIN " & _
                                                            "      REGISTRATION ON GUEST.GNo = REGISTRATION.GNo INNER JOIN " & _
                                                            "      REFUND ON REGISTRATION.RegNo = REFUND.RegNo " & _
                                                            "WHERE (REFUND.RefStat = 'ONHOLD') AND (GUEST.GIID = '" & gGiid & "') " & _
                                                            "UNION " & _
                                                            "SELECT REFUND_1.RefID, REFUND_1.RefAmt, REFUND_1.RefDate, REFUND_1.RefExpDate,  " & _
                                                            "       REFUND_1.RefRemarks " & _
                                                            "FROM   REFUND AS REFUND_1 INNER JOIN " & _
                                                            "       RESERVATION ON REFUND_1.ResNo = RESERVATION.ResNo INNER JOIN " & _
                                                            "       GUEST AS GUEST_1 ON RESERVATION.GNo = GUEST_1.GNo " & _
                                                            "WHERE  (REFUND_1.RefStat = 'ONHOLD') AND (GUEST_1.GIID = '" & gGiid & "') ", objConnection)
                Dim objDataAdapter As SqlDataAdapter = New SqlDataAdapter(objCommand)
                Dim objDataSet As DataSet = New DataSet
                objDataAdapter.Fill(objDataSet, "Recompense")
                ListItems(lvwRecompense, objDataSet, "Recompense")

                lvwRecompense.Columns(0).Width = 100 'Refund No
                lvwRecompense.Columns(1).Width = 100 'RefAmt
                lvwRecompense.Columns(1).TextAlign = HorizontalAlignment.Right
                lvwRecompense.Columns(2).Width = 150 'Date of Refund
                lvwRecompense.Columns(3).Width = 150 'Expiration Date
                lvwRecompense.Columns(4).Width = 120 'Remarks

            End Using
            objConnection.Close()
        End Using

    End Sub

    Private Sub UpdateComboBox()
        ListItems(DatabasePath, "SELECT DISTINCT CCTYPE FROM CREDIT_CARD", cboCreditCardType, "CCType")
        ListItems(DatabasePath, "SELECT DISTINCT CHBank FROM CHEQUE", cboChequeBank, "CHBank")
        ListItems(DatabasePath, "SELECT DISTINCT BNName FROM BANK", cboBank, "BNName")
    End Sub

#End Region

#Region "Command Buttons"

    Private Sub btnRemoveFromThisList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveFromThisList.Click
        If lvwPaymentList.SelectedItems.Count = 0 Then Exit Sub

        For Each ctlItem As ListViewItem In lvwPaymentList.SelectedItems

            If ctlItem.Text.ToUpper = "RECOMPENSE" Then
                Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
                    objConnection.Open()
                    Using objCommand As SqlCommand = New SqlCommand()
                        objCommand.Connection = objConnection
                        objCommand.CommandText = "SELECT REFUND.RefID AS [Refund No.], REFUND.RefAmt AS Amount, " & _
                                                "       REFUND.RefDate AS [Date of Refund], REFUND.RefExpDate AS [Expiration Date], " & _
                                                "       REFUND.RefRemarks AS Remarks " & _
                                                "FROM   REFUND " & _
                                                "WHERE  REFUND.RefID='" & ctlItem.SubItems(2).Text & "' "

                        Using objReader As SqlDataReader = objCommand.ExecuteReader
                            objReader.Read()
                            Dim lsvRecompenseItem As ListViewItem = lvwRecompense.Items.Add(objReader(0).ToString)
                            With lsvRecompenseItem.SubItems
                                .Add(objReader(1).ToString)
                                .Add(objReader(2).ToString)
                                .Add(objReader(3).ToString)
                                .Add(objReader(4).ToString)
                            End With
                        End Using
                    End Using
                    objConnection.Close()
                End Using
            End If

            Select Case ctlItem.SubItems(0).Text.ToUpper
                Case "CASH", "CHEQUE"
                    dblBaseTotalInHand -= CType(ctlItem.SubItems(1).Text, Double)
                    dblTotalInHand -= CType(ctlItem.SubItems(1).Text, Double)
                Case "BANK", "CREDIT CARD"
                    dblBaseTotalReceivable -= CType(ctlItem.SubItems(1).Text, Double)
                    dblTotalReceivable -= CType(ctlItem.SubItems(1).Text, Double)
                Case "RECOMPENSE"
                    dblBaseTotalRecompense -= CType(ctlItem.SubItems(1).Text, Double)
                    dblTotalRecompense -= CType(ctlItem.SubItems(1).Text, Double)
            End Select

            lblPaymentListTotalAmountTendered.Text = Format(CType(lblPaymentListTotalAmountTendered.Text, Double) - CType(ctlItem.SubItems(1).Text, Double), "n")
            If CType(lblReceiptAmountDue.Text, Double) > 0 Then
                txtRemainingBalance.Text = Format(CType(txtRemainingBalance.Text, Double) + CType(ctlItem.SubItems(1).Text, Double), "n")
            End If

            If CType(lblPaymentListTotalAmountTendered.Text, Double) - CType(lblReceiptAmountDue.Text, Double) > 0 Then
                lblTotalChange.Text = Format(CType(lblPaymentListTotalAmountTendered.Text, Double) - CType(lblReceiptAmountDue.Text, Double), "n")
            Else
                lblTotalChange.Text = Format(0, "n")
            End If

            ctlItem.Remove()
        Next

    End Sub

    Private Sub btnCash_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCash.Click

        If Trim(txtCashAmount.Text) = String.Empty Then
            Msg("1000")
            txtCashAmount.SelectAll()
            txtCashAmount.Focus()
            Exit Sub
        End If

        If Not IsNumeric(txtCashAmount.Text) Then
            Msg("1001", Button.Ok, "Input must be a number")
            txtCashAmount.SelectAll()
            txtCashAmount.Focus()
        Else
            If CType(txtCashAmount.Text, Double) <= 0 Then
                Msg("1001", Button.Ok, "The cash amount must be greater than zero(0)")
                txtCashAmount.SelectAll()
                txtCashAmount.Focus()
            Else
                Dim blnFound As Boolean = False

                For Each ctlItem As ListViewItem In lvwPaymentList.Items
                    If ctlItem.Text.ToUpper = "CASH" Then
                        ctlItem.SubItems(1).Text = Format(CType(ctlItem.SubItems(1).Text, Double) + CType(txtCashAmount.Text, Double), "n")

                        blnFound = True
                        Exit For
                    End If
                Next

                If Not blnFound Then
                    Dim lsvItem As ListViewItem = lvwPaymentList.Items.Add("CASH")
                    lsvItem.SubItems.Add(Format(CType(txtCashAmount.Text, Double), "n"))
                    dblTotalInHand += CType(txtCashAmount.Text, Double)
                    dblBaseTotalInHand += CType(txtCashAmount.Text, Double)
                    lsvItem.SubItems.Add("-")
                    lsvItem.SubItems.Add("-")
                    lsvItem.SubItems.Add("-")
                    lsvItem.SubItems.Add("-")
                    lsvItem.SubItems.Add("-")
                End If

                lblPaymentListTotalAmountTendered.Text = Format(CType(lblPaymentListTotalAmountTendered.Text, Double) + CType(txtCashAmount.Text, Double), "n")
                If CType(txtRemainingBalance.Text, Double) - CType(txtCashAmount.Text, Double) >= 0 Then
                    txtRemainingBalance.Text = Format(CType(txtRemainingBalance.Text, Double) - CType(txtCashAmount.Text, Double), "n")
                End If

                If CType(lblPaymentListTotalAmountTendered.Text, Double) - CType(lblReceiptAmountDue.Text, Double) > 0 Then
                    lblTotalChange.Text = Format(CType(lblPaymentListTotalAmountTendered.Text, Double) - CType(lblReceiptAmountDue.Text, Double), "n")
                Else
                    lblTotalChange.Text = Format(0, "n")
                End If

                txtCashAmount.Text = String.Empty

            End If
        End If
    End Sub

    Private Sub btnCreditCard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreditCard.Click
        If Trim(txtCreditCardAmount.Text) = String.Empty Then
            Msg("1000")
            txtCreditCardAmount.SelectAll()
            txtCreditCardAmount.Focus()
        Else
            If Not IsNumeric(txtCreditCardAmount.Text) Then
                Msg("1001", Button.Ok, "A numeric value is required")
                txtCreditCardAmount.SelectAll()
                txtCreditCardAmount.Focus()
            ElseIf CType(txtCreditCardAmount.Text, Double) <= 0 Then
                Msg("1001", Button.Ok, "The amount should be greater than zero(0)")
                txtCreditCardAmount.SelectAll()
                txtCreditCardAmount.Focus()
            Else

                Dim lsvItem As ListViewItem = lvwPaymentList.Items.Add("CREDIT CARD")
                lsvItem.SubItems.Add(Format(CType(txtCreditCardAmount.Text, Double), "n"))
                dblBaseTotalReceivable += CType(txtCreditCardAmount.Text, Double)
                dblTotalReceivable += CType(txtCreditCardAmount.Text, Double)

                lsvItem.SubItems.Add(txtCreditCardNo.Text)
                lsvItem.SubItems.Add(cboCreditCardType.Text)
                lsvItem.SubItems.Add(txtCreditCardOwner.Text)
                lsvItem.SubItems.Add("-")
                lsvItem.SubItems.Add("-")

                lblPaymentListTotalAmountTendered.Text = Format(CType(lblPaymentListTotalAmountTendered.Text, Double) + CType(txtCreditCardAmount.Text, Double), "n")
                If CType(txtRemainingBalance.Text, Double) - CType(txtCreditCardAmount.Text, Double) >= 0 Then
                    txtRemainingBalance.Text = Format(CType(txtRemainingBalance.Text, Double) - CType(txtCreditCardAmount.Text, Double), "n")
                End If

                If CType(lblPaymentListTotalAmountTendered.Text, Double) - CType(lblReceiptAmountDue.Text, Double) > 0 Then
                    lblTotalChange.Text = Format(CType(lblPaymentListTotalAmountTendered.Text, Double) - CType(lblReceiptAmountDue.Text, Double), "n")
                Else
                    lblTotalChange.Text = Format(0, "n")
                End If

                ClearControls(tbpCreditCard)

            End If
        End If
    End Sub

    Private Sub btnCheque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheque.Click
        If Trim(txtChequeAmount.Text) = String.Empty Then
            Msg("1000")
            txtChequeAmount.SelectAll()
            txtChequeAmount.Focus()
        ElseIf Trim(txtChequeNo.Text) = String.Empty Then
            Msg("1000", Button.Ok, "A required information is needed")
            txtChequeNo.SelectAll()
            txtChequeNo.Focus()
        Else
            If Not IsNumeric(txtChequeAmount.Text) Then
                Msg("1001", Button.Ok, "A numeric input is required.")
                txtChequeAmount.SelectAll()
                txtChequeAmount.Focus()
            ElseIf CType(txtChequeAmount.Text, Double) <= 0 Then
                Msg("1001", Button.Ok, "An input greater than zero (0) is required.")
                txtChequeAmount.SelectAll()
                txtChequeAmount.Focus()
            Else

                Dim lsvItem As ListViewItem = lvwPaymentList.Items.Add("CHEQUE")
                lsvItem.SubItems.Add(Format(CType(txtChequeAmount.Text, Double), "n"))
                dblBaseTotalReceivable += CType(txtChequeAmount.Text, Double)
                dblTotalReceivable += CType(txtChequeAmount.Text, Double)

                dblTotalInHand += CType(txtChequeAmount.Text, Double)
                dblBaseTotalInHand += CType(txtChequeAmount.Text, Double)
                lsvItem.SubItems.Add(txtChequeNo.Text)
                lsvItem.SubItems.Add("-")
                lsvItem.SubItems.Add(cboChequeBank.Text)
                lsvItem.SubItems.Add(dtpChequeMaturityDate.Value.ToString)
                lsvItem.SubItems.Add(dtpChequeExpirationDate.Value.ToString)

                lblPaymentListTotalAmountTendered.Text = Format(CType(lblPaymentListTotalAmountTendered.Text, Double) + CType(txtChequeAmount.Text, Double), "n")
                If CType(txtRemainingBalance.Text, Double) - CType(txtChequeAmount.Text, Double) >= 0 Then
                    txtRemainingBalance.Text = Format(CType(txtRemainingBalance.Text, Double) - CType(txtChequeAmount.Text, Double), "n")
                End If

                If CType(lblPaymentListTotalAmountTendered.Text, Double) - CType(lblReceiptAmountDue.Text, Double) > 0 Then
                    lblTotalChange.Text = Format(CType(lblPaymentListTotalAmountTendered.Text, Double) - CType(lblReceiptAmountDue.Text, Double), "n")
                Else
                    lblTotalChange.Text = Format(0, "n")
                End If

                ClearControls(tbpCheque)

            End If
        End If
    End Sub

    Private Sub btnBank_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBank.Click

        If Trim(txtBankAmount.Text) = String.Empty Then
            Msg("1000")
            txtBankAmount.SelectAll()
            txtBankAmount.Focus()
        ElseIf Trim(txtBankAccountNo.Text) = String.Empty Then
            Msg("1000")
            txtBankAccountNo.SelectAll()
            txtBankAccountNo.Focus()
        ElseIf Trim(cboBank.Text) = String.Empty Then
            Msg("1000")
            cboBank.SelectAll()
            cboBank.Focus()
        Else
            If Not IsNumeric(txtBankAmount.Text) Then
                Msg("1001", Button.Ok, "A numeric value is required")
                txtBankAmount.SelectAll()
                txtBankAmount.Focus()
            Else
                If CType(txtBankAmount.Text, Double) <= 0 Then
                    Msg("1001", Button.Ok, "Amount must be greater than zero (0)")
                    txtBankAmount.SelectAll()
                    txtBankAmount.Focus()
                Else
                    Dim lsvItem As ListViewItem = lvwPaymentList.Items.Add("BANK")
                    lsvItem.SubItems.Add(Format(CType(txtBankAmount.Text, Double), "n"))
                    dblBaseTotalReceivable += CType(txtBankAmount.Text, Double)
                    dblTotalReceivable += CType(txtBankAmount.Text, Double)

                    lsvItem.SubItems.Add(txtBankAccountNo.Text)
                    lsvItem.SubItems.Add(cboBank.Text)
                    lsvItem.SubItems.Add(txtBankBranch.Text)
                    lsvItem.SubItems.Add("-")
                    lsvItem.SubItems.Add("-")

                    lblPaymentListTotalAmountTendered.Text = Format(CType(lblPaymentListTotalAmountTendered.Text, Double) + CType(txtBankAmount.Text, Double), "n")
                    If CType(txtRemainingBalance.Text, Double) - CType(txtBankAmount.Text, Double) >= 0 Then
                        txtRemainingBalance.Text = Format(CType(txtRemainingBalance.Text, Double) - CType(txtBankAmount.Text, Double), "n")
                    End If

                    If CType(lblPaymentListTotalAmountTendered.Text, Double) - CType(lblReceiptAmountDue.Text, Double) > 0 Then
                        lblTotalChange.Text = Format(CType(lblPaymentListTotalAmountTendered.Text, Double) - CType(lblReceiptAmountDue.Text, Double), "n")
                    Else
                        lblTotalChange.Text = Format(0, "n")
                    End If

                    ClearControls(tbpBankAccount)
                End If
            End If
        End If

    End Sub

    Private Sub btnRecompense_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecompense.Click
        If lvwRecompense.CheckedItems.Count > 0 Then
            Dim lsvItem As ListViewItem = lvwPaymentList.Items.Add("RECOMPENSE")
            lsvItem.SubItems.Add(Format(CType(txtRecompenseAmount.Text, Double), "n"))
            dblBaseTotalRecompense += CType(txtRecompenseAmount.Text, Double)
            dblTotalRecompense += CType(txtRecompenseAmount.Text, Double)

            lsvItem.SubItems.Add(lvwRecompense.FocusedItem.Text)
            lsvItem.SubItems.Add("-")
            lsvItem.SubItems.Add("-")
            lsvItem.SubItems.Add("-")
            lsvItem.SubItems.Add("-")

            lblPaymentListTotalAmountTendered.Text = Format(CType(lblPaymentListTotalAmountTendered.Text, Double) + CType(txtRecompenseAmount.Text, Double), "n")
            If CType(txtRemainingBalance.Text, Double) - CType(txtRecompenseAmount.Text, Double) >= 0 Then
                txtRemainingBalance.Text = Format(CType(txtRemainingBalance.Text, Double) - CType(txtRecompenseAmount.Text, Double), "n")
            End If

            If CType(lblPaymentListTotalAmountTendered.Text, Double) - CType(lblReceiptAmountDue.Text, Double) > 0 Then
                lblTotalChange.Text = Format(CType(lblPaymentListTotalAmountTendered.Text, Double) - CType(lblReceiptAmountDue.Text, Double), "n")
            Else
                lblTotalChange.Text = Format(0, "n")
            End If

            ClearControls(tbpRecompense)
            lvwRecompense.FocusedItem.Remove()

        Else
            Msg("1005", , "Please choose a recompense from the list")
        End If
    End Sub

    Private Sub btnSave_Payment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave_Payment.Click
        If ThereAreInputErrors() Then Exit Sub


        Dim MyBills As ArrayList = New ArrayList
        Dim MyBillsAmount As ArrayList = New ArrayList
        Dim MyPayments As ArrayList = New ArrayList
        Dim MyPaymentsAmount As ArrayList = New ArrayList
        Dim blnRefund As Boolean = False
        Dim MyRefunds As ArrayList = New ArrayList
        Dim blnCommitted As Boolean = False
        Dim strReceiptNo As String = String.Empty
        Dim strPayer As String = txtPaidBy.Text
        Dim strDatePaid As String = Format(dtpDateOfPayment.Value, "MMM dd, yyyy")

        Dim strTotalPayment As String = Format(CType(lblPaymentListTotalAmountTendered.Text, Double), "n")
        Dim strTotalBill As String = Format(CType(lblReceiptAmountDue.Text, Double), "n")
        Dim strTotalChange As String = Format(CType(lblTotalChange.Text, Double), "n")

        For Each ctlItem As ListViewItem In lsvReceipt.CheckedItems
            MyBills.Add(ctlItem.SubItems(1).Text)
            MyBillsAmount.Add(ctlItem.SubItems(3).Text)
        Next

        For Each ctlItem As ListViewItem In lvwPaymentList.Items
            MyPayments.Add(ctlItem.Text)
            MyPaymentsAmount.Add(ctlItem.SubItems(1).Text)
        Next

        blnComputeChange = False 'Need this because the code will prompt for a refund even if there is none

        Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
            objConnection.Open()
            Using objTransaction As SqlTransaction = objConnection.BeginTransaction
                Using objCommand As SqlCommand = objConnection.CreateCommand
                    With objCommand
                        .Transaction = objTransaction

                        Try
                            'dblRecordedAmount = AmountTendered - Change
                            Dim dblRecordedAmount As Double = CType(lblPaymentListTotalAmountTendered.Text, Double) - CType(lblTotalChange.Text, Double)
                            Dim dblRecordedAmount_Copy2 As Double = dblRecordedAmount
                            Dim strPaymentID As String = GetPrimaryKeyNo("Payment")
                            strReceiptNo = strPaymentID
                            IncrementPrimaryKeyNo("Payment")

                            Select Case myTransaction
                                Case Transaction.DirectBiller
                                    .CommandText = "INSERT INTO PAYMENT (PID, PAmt, PDate, PPayer, DBID, LNO) " & _
                                                   "VALUES (@PID, @PAmt, @PDate, @PPayer, @DBID, @LNO) "
                                    With .Parameters
                                        .Clear()
                                        .AddWithValue("@PID", strPaymentID)
                                        .AddWithValue("@PAmt", dblRecordedAmount).SqlDbType = SqlDbType.Money
                                        .AddWithValue("@PDate", dtpDateOfPayment.Value).SqlDbType = SqlDbType.DateTime
                                        .AddWithValue("@PPayer", TrimAll(txtPaidBy.Text))
                                        .AddWithValue("@DBID", gDBID)
                                        .AddWithValue("@LNO", LogNo())
                                    End With

                                    .ExecuteNonQuery()

                                    'Update Balance of DirectBiller
                                    .CommandText = "UPDATE DIRECT_BILLER SET DBBalance = DBBalance - @TotalPaymentMinusTheChange WHERE DBID=@DBID; "
                                    With .Parameters
                                        .Clear()
                                        .AddWithValue("@TotalPaymentMinusTheChange", dblRecordedAmount)
                                        .AddWithValue("@DBID", gDBID)
                                    End With
                                    .ExecuteNonQuery()

                                    'Update direct billing 
                                    'If balance is already zero then update the status to PAID
                                    .CommandText = "UPDATE DIRECT_BILLER SET DBStatus='PAID' WHERE DBID=@DBID AND DBBalance<=0; "
                                    With .Parameters
                                        .Clear()
                                        .AddWithValue("@DBID", gDBID)
                                    End With
                                    .ExecuteNonQuery()

                                Case Transaction.Registration

                                    .CommandText = "INSERT INTO PAYMENT (PID, PAmt, PDate, PPayer, RegNo, LNO) " & _
                                                   "VALUES (@PID, @PAmt, @PDate, @PPayer, @RegNo, @Lno) "

                                    With .Parameters
                                        .AddWithValue("@PID", strPaymentID)
                                        .AddWithValue("@PAmt", dblRecordedAmount).SqlDbType = SqlDbType.Money
                                        .AddWithValue("@PDate", dtpDateOfPayment.Value).SqlDbType = SqlDbType.DateTime
                                        .AddWithValue("@PPayer", TrimAll(txtPaidBy.Text))
                                        .AddWithValue("@RegNo", gRegNo)
                                        .AddWithValue("@Lno", LogNo())
                                    End With
                                    'IncrementPrimaryKeyNo("Payment") 'Increment at first part of this sub routine
                                    .ExecuteNonQuery()

                                    For Each lswBill As ListViewItem In lsvReceipt.CheckedItems
                                        If dblRecordedAmount - CType(lswBill.SubItems(3).Text, Double) >= 0 Then
                                            'Full payment will occur on this bill
                                            .CommandText = "INSERT INTO PAYMENT_DETAILS (PID, FDNO, PDAmt) " & _
                                                            "VALUES (@PID, @FDNo, @PDAmt)"
                                            With .Parameters
                                                .Clear()
                                                .AddWithValue("@PID", strPaymentID)
                                                .AddWithValue("@FDNo", lswBill.Text)
                                                .AddWithValue("@PDAmt", lswBill.SubItems(3).Text).SqlDbType = SqlDbType.Money
                                            End With
                                            .ExecuteNonQuery()

                                            'Update Folio Details
                                            .CommandText = "UPDATE FOLIO_DETAILS SET FDBalance=0, FDStat='PAID' " & _
                                                           "WHERE FDNo=@FDNo"
                                            With .Parameters
                                                .Clear()
                                                .AddWithValue("@FDNo", lswBill.Text)
                                            End With
                                            .ExecuteNonQuery()

                                            dblRecordedAmount -= CType(lswBill.SubItems(3).Text, Double)
                                            lswBill.Remove()

                                        ElseIf dblRecordedAmount > 0 Then
                                            'Partial Payment will occur here
                                            .CommandText = "INSERT INTO PAYMENT_DETAILS (PID, FDNO, PDAmt) " & _
                                                            "VALUES (@PID, @FDNo, @PDAmt)"
                                            With .Parameters
                                                .Clear()
                                                .AddWithValue("@PID", strPaymentID)
                                                .AddWithValue("@FDNo", lswBill.Text)
                                                .AddWithValue("@PDAmt", dblRecordedAmount).SqlDbType = SqlDbType.Money
                                            End With
                                            .ExecuteNonQuery()

                                            'Update Folio details
                                            .CommandText = "UPDATE FOLIO_DETAILS SET FDBalance = FDBalance - @Amount WHERE FDNo=@FDNo "
                                            With .Parameters
                                                .Clear()
                                                .AddWithValue("@Amount", dblRecordedAmount).SqlDbType = SqlDbType.Money
                                                .AddWithValue("@FDNo", lswBill.Text)
                                            End With
                                            .ExecuteNonQuery()

                                            lswBill.SubItems(3).Text = Format(CType(lswBill.SubItems(3).Text, Double) - dblRecordedAmount, "n")
                                            dblRecordedAmount = 0

                                        Else
                                            'Msg that not all items are processed
                                            'There are still some items in the list that was not saved because 
                                            'The payment is not sufficient.
                                            'Use the parallel arrays to inform the user about this
                                            'This is a messagebox that may rollback a transaction
                                            'Dont forget to include an exit sub
                                        End If

                                    Next

                                    chkSelectAll.Checked = True : chkSelectAll.Checked = False

                                    .CommandText = "UPDATE REGISTRATION SET RegBalance = RegBalance - @TotalPaymentMinusTheChange " & _
                                                   "WHERE RegNo = @RegNo; "
                                    With .Parameters
                                        .Clear()
                                        .AddWithValue("@TotalPaymentMinusTheChange", dblRecordedAmount_Copy2)
                                        .AddWithValue("@RegNo", gRegNo)
                                    End With
                                    .ExecuteNonQuery()

                                Case Transaction.Reservation

                                    .CommandText = "INSERT INTO PAYMENT (PID, PAmt, PDate, PPayer, LNo) " & _
                                                   "VALUES (@PID, @PAmt, @PDate, @PPayer, @LNo); "

                                    With .Parameters
                                        .Clear()
                                        .AddWithValue("@PID", strPaymentID)
                                        .AddWithValue("@PAmt", dblRecordedAmount)
                                        .AddWithValue("@PDate", dtpDateOfPayment.Value)
                                        .AddWithValue("@PPayer", TrimAll(txtPaidBy.Text))
                                        .AddWithValue("@LNo", LogNo())
                                    End With
                                    .ExecuteNonQuery()

                                    For Each lswBill As ListViewItem In lsvReceipt.CheckedItems
                                        If dblRecordedAmount - CType(lswBill.SubItems(3).Text, Double) >= 0 Then
                                            'Full payment will occur on this bill
                                            .CommandText = "INSERT INTO PAYMENT_DETAILS (PID, FDNO, PDAmt) " & _
                                                            "VALUES (@PID, @FDNo, @PDAmt)"
                                            With .Parameters
                                                .Clear()
                                                .AddWithValue("@PID", strPaymentID)
                                                .AddWithValue("@FDNo", lswBill.Text)
                                                .AddWithValue("@PDAmt", lswBill.SubItems(3).Text).SqlDbType = SqlDbType.Money
                                            End With
                                            .ExecuteNonQuery()

                                            'Update Folio Details
                                            .CommandText = "UPDATE FOLIO_DETAILS SET FDBalance=0, FDStat='PAID' " & _
                                                           "WHERE FDNo=@FDNo"
                                            With .Parameters
                                                .Clear()
                                                .AddWithValue("@FDNo", lswBill.Text)
                                            End With
                                            .ExecuteNonQuery()

                                            dblRecordedAmount -= CType(lswBill.SubItems(3).Text, Double)
                                            lswBill.Remove()

                                        ElseIf dblRecordedAmount > 0 Then
                                            'Partial Payment will occur here
                                            .CommandText = "INSERT INTO PAYMENT_DETAILS (PID, FDNO, PDAmt) " & _
                                                            "VALUES (@PID, @FDNo, @PDAmt)"
                                            With .Parameters
                                                .Clear()
                                                .AddWithValue("@PID", strPaymentID)
                                                .AddWithValue("@FDNo", lswBill.Text)
                                                .AddWithValue("@PDAmt", dblRecordedAmount).SqlDbType = SqlDbType.Money
                                            End With
                                            .ExecuteNonQuery()

                                            'Update Folio details
                                            .CommandText = "UPDATE FOLIO_DETAILS SET FDBalance = FDBalance - @Amount WHERE FDNo=@FDNo "
                                            With .Parameters
                                                .Clear()
                                                .AddWithValue("@Amount", dblRecordedAmount).SqlDbType = SqlDbType.Money
                                                .AddWithValue("@FDNo", lswBill.Text)
                                            End With
                                            .ExecuteNonQuery()

                                            lswBill.SubItems(3).Text = Format(CType(lswBill.SubItems(3).Text, Double) - dblRecordedAmount, "n")
                                            dblRecordedAmount = 0

                                        Else
                                            'Msg that not all items are processed
                                            'There are still some items in the list that was not saved because 
                                            'The payment is not sufficient.
                                            'Use the parallel arrays to inform the user about this
                                            'This is a messagebox that may rollback a transaction
                                            'Dont forget to include an exit sub
                                        End If

                                    Next

                                    'Update reservation Balance
                                    .CommandText = "UPDATE RESERVATION SET ResBalance = ResBalance - @TotalPaymentMinusTheChange " & _
                                                   "WHERE ResNo=@ResNo "
                                    With .Parameters
                                        .Clear()
                                        .AddWithValue("@TotalPaymentMinusTheChange", dblRecordedAmount_Copy2).SqlDbType = SqlDbType.Money
                                        .AddWithValue("@ResNo", gResNo)
                                    End With
                                    .ExecuteNonQuery()
                            End Select

                            Dim dblCashOnHand As Double = 0
                            Dim dblCashReceivable As Double = 0
                            Dim dblRecompense As Double = 0

                            For Each lswPayment As ListViewItem In lvwPaymentList.Items

                                Dim strPTID As String = GetPrimaryKeyNo("PaymentTypeDetails")
                                IncrementPrimaryKeyNo("PaymentTypeDetails")

                                'A convertion from string to double and back to string
                                'must be done to the amount so that comma separating 
                                'the digits will be removed
                                Dim strPTAmt As String = CType(lswPayment.SubItems(1).Text, Double).ToString

                                Dim strCCowner As String = TrimAll(lswPayment.SubItems(4).Text)
                                Dim strCCType As String = TrimAll(lswPayment.SubItems(3).Text)
                                Dim strCCNo As String = TrimAll(lswPayment.SubItems(2).Text)

                                Dim strCHNo As String = TrimAll(lswPayment.SubItems(2).Text)
                                Dim strCHBank As String = TrimAll(lswPayment.SubItems(4).Text)
                                Dim strCHMatDate As String = TrimAll(lswPayment.SubItems(5).Text)
                                Dim strCHExpDate As String = TrimAll(lswPayment.SubItems(6).Text)

                                Dim strBNAcctNo As String = TrimAll(lswPayment.SubItems(2).Text)
                                Dim strBNName As String = TrimAll(lswPayment.SubItems(3).Text)
                                Dim strBNBranch As String = TrimAll(lswPayment.SubItems(4).Text)

                                Dim strRefID As String = lswPayment.SubItems(2).Text

                                Select Case lswPayment.Text.ToUpper
                                    Case "BANK"

                                        .CommandText = "INSERT INTO PAYMENT_TYPE_DETAILS (PTID, PTAmt, PTType, PID) " & _
                                                       "VALUES (@PTID, @PTAmt, 'BN', @PID) "
                                        With .Parameters
                                            .Clear()
                                            .AddWithValue("@PTID", strPTID)
                                            .AddWithValue("@PTAmt", strPTAmt).SqlDbType = SqlDbType.Money
                                            .AddWithValue("@PID", strPaymentID)
                                        End With
                                        .ExecuteNonQuery()

                                        .CommandText = "INSERT INTO BANK (PTID, BNAcctNo, BNName, BNBranch) " & _
                                                       "VALUES (@PTID, @BNAcctNo, @BNName, @BNBranch) "
                                        With .Parameters
                                            .Clear()
                                            .AddWithValue("@PTID", strPTID)
                                            .AddWithValue("@BNAcctNo", strBNAcctNo)
                                            .AddWithValue("@BNName", strBNName)
                                            .AddWithValue("@BNBranch", strBNBranch)
                                        End With
                                        .ExecuteNonQuery()

                                        dblCashReceivable += CType(strPTAmt, Double)


                                    Case "CASH"

                                        .CommandText = "INSERT INTO PAYMENT_TYPE_DETAILS (PTID, PTAmt, PTType, PID) " & _
                                                       "VALUES (@PTID, @PTAmt, 'CS', @PID) "
                                        With .Parameters
                                            .Clear()
                                            .AddWithValue("@PTID", strPTID)
                                            .AddWithValue("@PTAmt", strPTAmt).SqlDbType = SqlDbType.Money
                                            .AddWithValue("@PID", strPaymentID)
                                        End With
                                        .ExecuteNonQuery()

                                        dblCashOnHand += CType(strPTAmt, Double)

                                    Case "CHEQUE"

                                        .CommandText = "INSERT INTO PAYMENT_TYPE_DETAILS (PTID, PTAmt, PTType, PID) " & _
                                                       "VALUES (@PTID, @PTAmt, 'CQ', @PID) "
                                        With .Parameters
                                            .Clear()
                                            .AddWithValue("@PTID", strPTID)
                                            .AddWithValue("@PTAmt", strPTAmt).SqlDbType = SqlDbType.Money
                                            .AddWithValue("@PID", strPaymentID)
                                        End With
                                        .ExecuteNonQuery()

                                        .CommandText = "INSERT INTO CHEQUE (PTID, CHNo, CHBank, CHMatDate, CHExpDate) " & _
                                                       "VALUES (@PTID, @CHNo, @CHBank, @CHMatDate, @CHExpDate)"
                                        With .Parameters
                                            .Clear()
                                            .AddWithValue("@PTID", strPTID)
                                            .AddWithValue("@CHNo", strCHNo)
                                            .AddWithValue("@CHBank", strCHBank)
                                            .AddWithValue("@CHMatDate", strCHMatDate).SqlDbType = SqlDbType.DateTime
                                            .AddWithValue("@CHExpDate", strCHExpDate).SqlDbType = SqlDbType.DateTime
                                        End With
                                        .ExecuteNonQuery()

                                        dblCashOnHand += CType(strPTAmt, Double)

                                    Case "CREDIT CARD"

                                        .CommandText = "INSERT INTO PAYMENT_TYPE_DETAILS (PTID, PTAmt, PTType, PID) " & _
                                                       "VALUES (@PTID, @PTAmt, 'CC', @PID) "
                                        With .Parameters
                                            .Clear()
                                            .AddWithValue("@PTID", strPTID)
                                            .AddWithValue("@PTAmt", strPTAmt).SqlDbType = SqlDbType.Money
                                            .AddWithValue("@PID", strPaymentID)
                                        End With
                                        .ExecuteNonQuery()

                                        .CommandText = "INSERT INTO CREDIT_CARD (PTID, CCOwner, CCType, CCNo) " & _
                                                       "VALUES (@PTID, @CCOwner, @CCType, @CCNo)"
                                        With .Parameters
                                            .Clear()
                                            .AddWithValue("@PTID", strPTID)
                                            .AddWithValue("@CCOwner", strCCowner)
                                            .AddWithValue("@CCType", strCCType)
                                            .AddWithValue("@CCNo", strCCNo)
                                        End With
                                        .ExecuteNonQuery()

                                        dblCashReceivable += CType(strPTAmt, Double)

                                    Case "RECOMPENSE"

                                        .CommandText = "INSERT INTO PAYMENT_TYPE_DETAILS (PTID, PTAmt, PTType, PID) " & _
                                                       "VALUES (@PTID, @PTAmt,'RP', @PID) "
                                        With .Parameters
                                            .Clear()
                                            .AddWithValue("@PTID", strPTID)
                                            .AddWithValue("@PTAmt", strPTAmt).SqlDbType = SqlDbType.Money
                                            .AddWithValue("@PID", strPaymentID)
                                        End With
                                        .ExecuteNonQuery()

                                        .CommandText = "INSERT INTO RECOMPENSE (PTID, RefID) " & _
                                                       "VALUES (@PTID, @RefID) "
                                        With .Parameters
                                            .Clear()
                                            .AddWithValue("@PTID", strPTID)
                                            .AddWithValue("@RefID", strRefID)
                                        End With
                                        .ExecuteNonQuery()

                                        .CommandText = "UPDATE REFUND SET REFStat='RELEASED', RefTimeChanged=@RefTimeChanged, RefIssuedAmt= @PTAmt " & _
                                                       "WHERE RefID=@RefID; "
                                        With .Parameters
                                            .Clear()
                                            .AddWithValue("@RefID", strRefID)
                                            .AddWithValue("@RefTimeChanged", dtpDateOfPayment.Value).SqlDbType = SqlDbType.DateTime
                                            .AddWithValue("@PTAmt", strPTAmt).SqlDbType = SqlDbType.Money
                                        End With
                                        .ExecuteNonQuery()

                                End Select

                            Next

                            'UPDATE CASH AT FRONT DESK
                            .CommandText = "UPDATE SYSTEM SET TotalCashInFD = TotalCashInFD + @CashOnHand "
                            With .Parameters
                                .Clear()
                                .AddWithValue("@CashOnHand", dblCashOnHand).SqlDbType = SqlDbType.Money
                            End With
                            .ExecuteNonQuery()

                            If My.Settings.PromtChangeToRefund = True Then
                                If myTransaction = Transaction.Registration AndAlso CType(lblTotalChange.Text, Double) > 0 Then
                                    If Msg("1091", Button.YesNo) = ButtonClicked.Yes Then

                                        blnRefund = True

                                        Dim RefundGracePeriod As Integer = 0
                                        .CommandText = "SELECT RefGracePeriod FROM SYSTEM"
                                        RefundGracePeriod = CType(.ExecuteScalar, Integer)

                                        .CommandText = "INSERT INTO REFUND (RefID, RefAmt, RefDate, RefStat, RefExpDate, RegNo, LNo) " & _
                                                       "VALUES (@RefID, @RefAmt, @RefDate, @RefStat, @RefExpDate, @RegNo, @LNo)"
                                        Dim strRefundId As String = GetPrimaryKeyNo("Refund")
                                        With .Parameters
                                            .Clear()
                                            .AddWithValue("@RefID", strRefundId)
                                            .AddWithValue("@RefAmt", CType(lblTotalChange.Text, Double)).SqlDbType = SqlDbType.Money
                                            .AddWithValue("@RefDate", Date.Now).SqlDbType = SqlDbType.DateTime
                                            .AddWithValue("@RefStat", "UNFINALIZED")
                                            .AddWithValue("@RefExpDate", Date.Now.AddDays(RefundGracePeriod)).SqlDbType = SqlDbType.DateTime
                                            .AddWithValue("@RegNo", gRegNo)
                                            .AddWithValue("@LNo", LogNo())
                                        End With

                                        MyRefunds.Add(strRefundId)
                                        MyRefunds.Add(CType(lblTotalChange.Text, Double).ToString)

                                        IncrementPrimaryKeyNo("Refund")
                                        .ExecuteNonQuery()

                                    End If
                                End If
                            End If

                            blnComputeChange = True

                            objTransaction.Commit()
                            gState = State.waiting
                            blnCommitted = True

                            lvwPaymentList.Items.Clear()
                            lblReceiptAmountDue.Text = "$0.00"
                            lblPaymentListTotalAmountTendered.Text = "$0.00"
                            lblTotalChange.Text = "$0.00"

                            DisplayTransaction()
                            DisplayBill()
                            UpdateComboBox()
                            DisplayUnpaidBills()

                        Catch ex As Exception
                            objTransaction.Rollback()
                            blnCommitted = False

                            Msg("1008", , NWLN & ex.Message)
                        End Try

                    End With
                End Using
            End Using
            objConnection.Close()
        End Using

        'Save receipt
        If blnCommitted Then
            Try
                Dim strFilePath As String = System.IO.Path.Combine(My.Settings.ReceiptLocation, gFirstName.ToUpper & "-" & Format(Date.Now, "MMMM-dd-yyyy-hhmmss") & ".txt")

                Dim strContent As String = GetHotelName().ToUpper & NWLN & _
                                           "SAINT LOUIS UNIVERSITY HOTEL" & NWLN & _
                                           "BAGUIO CITY" & NWLN & NWLN & _
                                           "PAY SLIP NO:  " & strReceiptNo & NWLN & _
                                           "GUEST:        " & strPayer.ToUpper & NWLN & _
                                           "              " & strDatePaid & NWLN & _
                                           "=============================" & NWLN

                For ctr As Integer = 0 To MyBills.Count - 1
                    Dim strBill As String = String.Empty
                    If MyBills(ctr).ToString.Length > 14 Then
                        strBill &= MyBills(ctr).ToString.Substring(0, 14).ToUpper & "  "
                    Else
                        strBill &= MyBills(ctr).ToString
                        For intCtr As Integer = 0 To 15 - MyBills(ctr).ToString.Length
                            strBill &= " "
                        Next
                    End If
                    strBill &= MyBillsAmount(ctr).ToString & NWLN

                    strContent &= strBill
                Next
                strContent &= "-----------------------------" & NWLN & NWLN


                For ctr As Integer = 0 To MyPayments.Count - 1
                    Dim strPayment As String = String.Empty
                    If MyPayments(ctr).ToString.Length > 14 Then
                        strPayment &= MyPayments(ctr).ToString.Substring(0, 14).ToUpper
                    Else
                        strPayment &= MyPayments(ctr).ToString
                        For intctr As Integer = 0 To 15 - MyPayments(ctr).ToString.Length
                            strPayment &= " "
                        Next
                    End If
                    strPayment &= MyPaymentsAmount(ctr).ToString & NWLN

                    strContent &= strPayment
                Next

                strContent &= NWLN & "=============================" & NWLN
                strContent &= "Total Bill:      " & Format(CType(strTotalBill, Double), "n") & NWLN & _
                              "Total Payment:   " & Format(CType(strTotalPayment, Double), "n") & NWLN

                If blnRefund = True Then
                    strContent &= "Refund    :      " & NWLN & _
                                  "       " & MyRefunds(0).ToString & "      " & Format(CType(MyRefunds(1).ToString, Double), "n") & NWLN & _
                                  "Change    :        0" & NWLN
                Else
                    strContent &= "Change    :      " & Format(CType(strTotalChange, Double), "n") & NWLN
                End If

                strContent &= "============================="

                My.Computer.FileSystem.WriteAllText(strFilePath, strContent, False)

                frmPrint.lblTitle.Text = "Payment Slip"
                frmPrint.txtLocation.Text = strFilePath
                frmPrint.btnOpen.Enabled = False
                frmPrint.FillMe(strFilePath, "Print Receipt")
                frmPrint.ShowDialog()

            Catch ex As Exception
                Msg("1008", , NWLN & ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        frmPrint.lblTitle.Text = "Payment Slip"
        frmPrint.btnOpen.Enabled = True
        frmPrint.ShowDialog()
    End Sub

#End Region

#Region "MISC"

    Private Sub dgvTransaction_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvTransaction.SelectionChanged
        DisplayBill()
    End Sub

    Private Sub tbcPayment_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbcPayment.SelectedIndexChanged
        If tbcPayment.SelectedIndex = 0 Then Exit Sub

        If dgvTransaction.SelectedRows.Count > 0 Then
            If String.Compare(lblTransaction.Text, dgvTransaction.Item(0, dgvTransaction.CurrentRow.Index).Value.ToString) <> 0 Then

                If gState <> State.waiting Then
                    Select Case Msg("1033", Button.YesNoCancel)
                        Case ButtonClicked.Yes
                            If ThereAreInputErrors() Then
                                Exit Sub
                            Else
                                btnSave_Payment_Click(Nothing, Nothing)
                            End If
                        Case ButtonClicked.No
                            'Pass through
                        Case ButtonClicked.Cancel
                            Exit Sub
                    End Select
                End If

                chkSelectAllRoom.Checked = True
                DisplayUnpaidBills() 'When SelectAllRoom checked property is checked
                DisplayRecompense()

                If lsvReceipt.Items.Count > 0 Then

                    gDBID = String.Empty
                    gRegNo = String.Empty
                    gResNo = String.Empty

                    lblTransaction.Text = dgvTransaction.Item(0, dgvTransaction.CurrentRow.Index).Value.ToString

                    Select Case myTransaction
                        Case Transaction.DirectBiller
                            gDBID = lblTransaction.Text
                        Case Transaction.Registration
                            gRegNo = lblTransaction.Text

                            ListItems(DatabasePath, "SELECT REGISTRATION_DETAILS.RMNo " & _
                                                    "FROM   REGISTRATION INNER JOIN " & _
                                                    "       REGISTRATION_DETAILS ON REGISTRATION.RegNo = REGISTRATION_DETAILS.RegNo " & _
                                                    "WHERE  (REGISTRATION.RegNo = '" & gRegNo & "') ", cboRoom, "RMno")

                        Case Transaction.Reservation
                            gResNo = lblTransaction.Text
                    End Select

                    gState = State.updating

                    lsvReceipt.Enabled = True
                    chkSelectAll.Enabled = True
                    btnSave_Payment.Enabled = True
                Else

                    frmParent.tssStatus.Text = "There is nothing to pay."
                    lblTransaction.Text = "-"
                    gState = State.waiting

                    lsvReceipt.Enabled = False
                    chkSelectAll.Enabled = False
                    btnSave_Payment.Enabled = False
                    txtPaidBy.Text = String.Empty
                End If

            End If
        End If

    End Sub

    Private Sub chkSelectAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSelectAll.CheckedChanged

        For Each ctlItem As ListViewItem In lsvReceipt.Items
            ctlItem.Checked = chkSelectAll.Checked
        Next
    
    End Sub

    Private Sub lvwRecompense_ItemCheck(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles lvwRecompense.ItemCheck
        Dim dblAmount As Double = 0.0
        dblAmount += CType(lvwRecompense.FocusedItem.SubItems(1).Text, Double)
        txtRecompenseAmount.Text = Format(dblAmount, "n")
    End Sub

    Private Sub lsvReceipt_ItemCheck(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles lsvReceipt.ItemChecked
        Dim dblAmount As Double = 0.0
        Dim dblPayment As Double = 0.0

        For Each ctlItem As ListViewItem In lsvReceipt.CheckedItems
            dblAmount += CType(ctlItem.SubItems(3).Text, Double)
        Next

        For Each ctlItem As ListViewItem In lvwPaymentList.Items
            dblPayment += CType(ctlItem.SubItems(1).Text, Double)
        Next

        txtRemainingBalance.Text = Format(dblAmount - dblPayment, "n")
        lblReceiptAmountDue.Text = Format(dblAmount, "n")

        If blnComputeChange = True Then
            If CType(lblPaymentListTotalAmountTendered.Text, Double) - CType(lblReceiptAmountDue.Text, Double) > 0 Then
                lblTotalChange.Text = Format(CType(lblPaymentListTotalAmountTendered.Text, Double) - CType(lblReceiptAmountDue.Text, Double), "n")
            Else
                lblTotalChange.Text = Format(0, "n")
            End If
        End If

    End Sub

    Private Sub frmPayment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lblGuestName.Text = "-"
        lblCompanyName.Text = "-"
        lblTransaction.Text = "-"

        dgvTransaction.AlternatingRowsDefaultCellStyle = SetAlternatingColor()
        dgvBillingInformation.AlternatingRowsDefaultCellStyle = SetAlternatingColor()

        UpdateComboBox()

    End Sub

    Private Sub chkSelectAllRoom_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSelectAllRoom.CheckedChanged
        cboRoom.Enabled = Not chkSelectAllRoom.Checked
        DisplayUnpaidBills()
    End Sub

    Private Sub cboRoom_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRoom.SelectedIndexChanged
        DisplayUnpaidBills()
    End Sub

    Private Sub lblClose_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblClose.LinkClicked
        Me.Close()
    End Sub

#End Region

#Region "Side Bar"

    Private Sub tsbGuestSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuestSearch.Click
        TriggeredBy = TriggeringForm.Payment
        frmGuestSearch.ShowDialog()
    End Sub

    Private Sub tsbDirectBiller_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbDirectBiller.Click
        Display(Forms.frmDirectBiller)
    End Sub

    Private Sub tsbRefund_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbRefund.Click

        SearchedGuestID = gGiid
        SearchedCompanyID = String.Empty
        SearchedRegistrationNo = gRegNo
        SearchedReservationNo = gResNo

        Display(Forms.frmRefund)

        frmRefund.FillMe()

    End Sub

    Private Sub tsbGuestFolio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuestFolio.Click

        SearchedGuestID = gGiid
        SearchedCompanyID = String.Empty
        SearchedRegistrationNo = gRegNo
        SearchedReservationNo = gResNo

        Display(Forms.frmGuestFolio)

        frmGuestFolio.FillMe()

    End Sub

    Private Sub tsbGuestInformation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuestInformation.Click

        SearchedGuestID = gGiid
        SearchedCompanyID = String.Empty
        SearchedRegistrationNo = gRegNo
        SearchedReservationNo = gResNo

        Display(Forms.frmGuestInformation)

        frmGuestInformation.FillMe()

    End Sub

#End Region

End Class