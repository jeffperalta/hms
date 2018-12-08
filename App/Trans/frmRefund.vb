Option Explicit On
Option Strict On

Imports System.Data
Imports System.Data.SqlClient

' Programmer:   Jo Jefferson D. Peralta
' Date:         March 26, 2007
' Title:        frmRefund
' Purpose:      This interface is used to finalize and edit a refund information, release unexpired refunds, 
'               and manually set the status of a refund to 'EXPIRED' when it reaches the expiration date.
'               Use this also when creating a refund, but usually it is recommended that refunds are created
'               when there are actual changes in the reservation and registration balances. For instance,
'               in modifying the amount of a registration its balance may be changed to negative therefore
'               (in other interface, frmModifyAmount) a refund occurs. However when this happens the user will have to 
'               go first at the frmRefund [this]interface to finalized it before it can be used to pay existing bill
'               or release it as cash.
' Requirements: ->  (*)REFUND(REFStat, RefTimeChanged, RefAmt, RefDate, RefIssuedAmt, RefExpDate, RefRemarks)
'               ->  (+)REFUND(RefId, RefAmt, RefDate, RefStat, RefIssuedAmt, RefExpDate, RefRemarks, ResNo, Regno, LNo)
'               ->  (-)REFUND(RefId)
'               ->  When creating a new refund information, the default expiration date and percentage of refund
'                   is used however it this can be changed but is not recommended unless the manager allows it.
'                   However there are no authentication used so anyone(FDO) is allowed to change the refund percentage 
'                   and amount.
'               ->  However, In creating a refund or editing it, it must not excede the total payment of a guest
'                   on the specific transaction (reservation or registration). This includes, in the computation,
'                   the previous refund amounts.
'               ->  When creating a new refund information, the user will have to choose on the guest's existing 
'                   transactions to where this refund must be charged.
'               ->  The user can set a refund to any transaction may it be a reservation or registration and
'                   no matter what status it has. However, the refund is only allowed to transactions that has
'                   payments since a refund amount must not excede the total payment amount.
'               ->  When editing/adding/deleting a refund information, the user will have to use the guest search.
'                   There is no need to use the guest search when releasing a refund or updating the database with
'                   expired refunds.
'               ->  Cannot delete a refund when it is already used in the recompense/payment
'               ->  The user can also mark the refunds that excede the expiration date to expired. Or 
'                   do this even if it is not yet exceding the refund date.
'               ->  If a user accidentally releases a refund, he can edit its status to onhold to have it 
'                   again available for a recompense. However the user must be careful in doing this because the
'                   application is currently not checking the system privilege, thus anyone can do this modification.
' Results:      ->  The refund is finalized and is ready for release or use as a payment at the frmPayment interface
'               ->  Refund information are modified or changed.
'               ->  Refunds that excede the expiration date is marked as expired.

Public Class frmRefund

    Private gState() As State = {State.waiting, State.waiting, State.waiting}
    Private gRegNo As String = String.Empty
    Private gResNo As String = String.Empty
    Private gGiid As String = String.Empty
    Private gdblPercentage As Double = 0
    Private gintGracePeriod As Integer = 0

#Region "Refund Issuance"

#Region "Functions And SubRoutines"

    Private Sub DisplayFinalizedRefunds()

        lblCountAtRefundIssuance.Text = ListItems(DatabasePath, "SELECT REFUND.RefID AS [Refund ID], ISNULL(GUEST_INFO.GIFName, '') + ' ' + ISNULL(GUEST_INFO.GILName, '') + ' ' + ISNULL(GUEST_INFO.GIMI, '')  " & _
                                                                "       AS Name, REFUND.RefAmt AS [Original Amount], REFUND.RefIssuedAmt AS [Amount to issue], 'REGISTRATION ' + REFUND.RegNo AS [Transaction],  " & _
                                                                "       REFUND.RefDate AS [Refund Date], REFUND.RefExpDate AS [Expiration Date], REFUND.RefRemarks AS Remarks, GUEST.GIID as [Guest ID] " & _
                                                                "FROM   REFUND INNER JOIN " & _
                                                                "       REGISTRATION ON REFUND.RegNo = REGISTRATION.RegNo INNER JOIN " & _
                                                                "       GUEST ON REGISTRATION.GNo = GUEST.GNo INNER JOIN " & _
                                                                "       GUEST_INFO ON GUEST.GIID = GUEST_INFO.GIID " & _
                                                                "WHERE  (REFUND.RefStat = 'ONHOLD') " & IIf(chkSelectAll.Checked, "", "AND REFUND.RefDate BETWEEN'" & dtpDateReleased.Value.AddDays(-1).ToString & "' AND '" & dtpDateReleased.Value.AddDays(1).ToString & "' ").ToString & _
                                                                "UNION " & _
                                                                "SELECT REFUND_1.RefID AS [Refund ID], ISNULL(GUEST_INFO_1.GIFName, '') + ' ' + ISNULL(GUEST_INFO_1.GILName, '') + ' ' + ISNULL(GUEST_INFO_1.GIMI,  " & _
                                                                "       '') AS Name, REFUND_1.RefAmt AS [Original Amount], REFUND_1.RefIssuedAmt AS [Amount to issue],  " & _
                                                                "       'RESERVATION ' + REFUND_1.ResNo AS [Transaction], REFUND_1.RefDate AS [Refund Date], REFUND_1.RefExpDate AS [Expiration Date],  " & _
                                                                "       REFUND_1.RefRemarks AS Remarks, GUEST_1.GIID as [Guest ID] " & _
                                                                "FROM   GUEST AS GUEST_1 INNER JOIN " & _
                                                                "       RESERVATION ON GUEST_1.GNo = RESERVATION.GNo INNER JOIN " & _
                                                                "       GUEST_INFO AS GUEST_INFO_1 ON GUEST_1.GIID = GUEST_INFO_1.GIID INNER JOIN " & _
                                                                "       REFUND AS REFUND_1 ON RESERVATION.ResNo = REFUND_1.ResNo " & _
                                                                "WHERE  (REFUND_1.RefStat = 'ONHOLD') " & IIf(chkSelectAll.Checked, "", "AND REFUND_1.RefDate BETWEEN '" & dtpDateReleased.Value.AddDays(-1).ToString & "' AND '" & dtpDateReleased.Value.AddDays(1).ToString & "' ").ToString, _
                                                                dgvListOfRefundAtRefundIssuance).ToString 'CONVERT(DATETIME, '2001-01-01 00:00:00', 102)

        Dim dblCtr As Double = 0.0
        For intCtr As Integer = 0 To dgvListOfRefundAtRefundIssuance.Rows.Count - 1
            dblCtr += CType(dgvListOfRefundAtRefundIssuance.Item(3, intCtr).Value, Double)
        Next
        lblTotalAmountAtRefundIssuance.Text = Format(dblCtr, "n")

    End Sub

    Private Sub UpdateRefundsToRelease()
        Dim dblAmount As Double = 0
        For Each lsvItem_2 As ListViewItem In lsvToRelease.Items
            dblAmount += CType(lsvItem_2.SubItems(3).Text, Double)
        Next
        lblTotalAmountToRelease.Text = Format(dblAmount, "n")

        lblCountRefundsToRelease.Text = lsvToRelease.Items.Count.ToString
    End Sub

#End Region

#Region "Command Buttons"

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If dgvListOfRefundAtRefundIssuance.RowCount > 0 Then

            frmParent.tssStatus.Text = String.Empty

            For Each lsvItem_1 As ListViewItem In lsvToRelease.Items
                If lsvItem_1.Text = dgvListOfRefundAtRefundIssuance.Item(0, dgvListOfRefundAtRefundIssuance.CurrentRow.Index).Value.ToString Then
                    frmParent.tssStatus.Text = "The item is already in the list..."
                    Exit Sub
                    Exit For
                End If
            Next

            Dim lsvItem As ListViewItem = lsvToRelease.Items.Add(dgvListOfRefundAtRefundIssuance.Item(0, dgvListOfRefundAtRefundIssuance.CurrentRow.Index).Value.ToString)
            lsvItem.SubItems.Add(dgvListOfRefundAtRefundIssuance.Item(1, dgvListOfRefundAtRefundIssuance.CurrentRow.Index).Value.ToString)
            lsvItem.SubItems.Add(dgvListOfRefundAtRefundIssuance.Item(2, dgvListOfRefundAtRefundIssuance.CurrentRow.Index).Value.ToString)
            lsvItem.SubItems.Add(dgvListOfRefundAtRefundIssuance.Item(3, dgvListOfRefundAtRefundIssuance.CurrentRow.Index).Value.ToString)
            lsvItem.SubItems.Add(dgvListOfRefundAtRefundIssuance.Item(4, dgvListOfRefundAtRefundIssuance.CurrentRow.Index).Value.ToString)
            lsvItem.SubItems.Add(dgvListOfRefundAtRefundIssuance.Item(5, dgvListOfRefundAtRefundIssuance.CurrentRow.Index).Value.ToString)
            lsvItem.SubItems.Add(dgvListOfRefundAtRefundIssuance.Item(6, dgvListOfRefundAtRefundIssuance.CurrentRow.Index).Value.ToString)
            lsvItem.SubItems.Add(dgvListOfRefundAtRefundIssuance.Item(7, dgvListOfRefundAtRefundIssuance.CurrentRow.Index).Value.ToString)

            UpdateRefundsToRelease()

        End If
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        If lsvToRelease.SelectedItems.Count <> 0 Then
            lsvToRelease.Items.Remove(lsvToRelease.Items(lsvToRelease.FocusedItem.Index))
            UpdateRefundsToRelease()
        Else
            Msg("1005")
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Msg("1034", Button.YesNo, "This will release the refund(s) in the list, Are you sure?") = ButtonClicked.Yes Then

            Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
                objConnection.Open()
                Using objTransaction As SqlTransaction = objConnection.BeginTransaction
                    Using objCommand As SqlCommand = objConnection.CreateCommand
                        With objCommand
                            .Transaction = objTransaction

                            .Parameters.AddWithValue("@RefTimeChanged", dtpDateReleased.Value).SqlDbType = SqlDbType.DateTime
                            Try
                                For Each ctlListView As ListViewItem In lsvToRelease.Items
                                    .CommandText = "UPDATE REFUND SET REFStat='RELEASED', RefTimeChanged=@RefTimeChanged WHERE REFID='" & ctlListView.SubItems(0).Text & "'"
                                    .ExecuteNonQuery()
                                Next

                                objTransaction.Commit()

                                DisplayFinalizedRefunds()
                                DisplayRefundInformation() '2nd tab

                                frmParent.tssStatus.Text = "The trnsaction was saved..."

                            Catch ex As Exception

                                objTransaction.Rollback()
                                Msg("1008", , NWLN & ex.Message)

                            End Try
                        End With
                    End Using
                End Using
                objConnection.Close()
            End Using

            'Update the list 
            DisplayFinalizedRefunds()
            lsvToRelease.Items.Clear()
            UpdateRefundsToRelease()

        End If
    End Sub

    Private Sub btnEdit_Info_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit_Info.Click
        If dgvListOfRefundAtRefundIssuance.SelectedRows.Count = 1 Then
            SearchedGuestID = dgvListOfRefundAtRefundIssuance.Item(8, dgvListOfRefundAtRefundIssuance.CurrentRow.Index).Value.ToString
            FillMe()
            tbcRefund.SelectedIndex = 1
            btnEdit_Click(Nothing, Nothing)
        Else
            Msg("1005", , "There is nothing to edit")
        End If
    End Sub

    Private Sub EditInformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditInformationToolStripMenuItem.Click
        btnEdit_Info_Click(Nothing, Nothing)
    End Sub

#End Region

#Region "MISC"

    Private Sub chkSelectAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSelectAll.CheckedChanged
        DisplayFinalizedRefunds()
    End Sub

    Private Sub dtpDateReleased_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDateReleased.ValueChanged
        DisplayFinalizedRefunds()
    End Sub

#End Region

#End Region

#Region "Refund Information"

#Region "Subroutines And Functions"

    Private Sub DisplayRefundInformation()

        If gGiid = String.Empty Then Exit Sub

        lblTotalCountRefInfo.Text = ListItems(DatabasePath, _
            "SELECT REFUND.RefID AS [Refund ID], REFUND.RefAmt AS Amount, REFUND.RefIssuedAmt AS [Amount To Issue], REFUND.RefDate AS [Date Incurred], " & _
            "       REFUND.RefExpDate AS [Expiration Date], REFUND.RefRemarks AS Remarks, REFUND.RefStat AS Status, REFUND.ResNo AS [Transaction No], 'RESERVATION' AS [Transaction] " & _
            "FROM   REFUND INNER JOIN " & _
            "       RESERVATION ON REFUND.ResNo = RESERVATION.ResNo INNER JOIN " & _
            "       GUEST ON RESERVATION.GNo = GUEST.GNo " & _
            "WHERE  (GUEST.GIID = '" & gGiid & "') " & IIf(cboStatus.Text = String.Empty, "", "AND (REFUND.RefStat = '" & cboStatus.Text & "') ").ToString & _
            "UNION " & _
            "SELECT REFUND_1.RefID, REFUND_1.RefAmt, REFUND_1.RefIssuedAmt, REFUND_1.RefDate, REFUND_1.RefExpDate, REFUND_1.RefRemarks,  " & _
            "       REFUND_1.RefStat AS Status, REFUND_1.RegNo AS [Transaction No], 'REGISTRATION' AS [Transaction] " & _
            "FROM   REFUND AS REFUND_1 INNER JOIN " & _
            "       REGISTRATION ON REFUND_1.RegNo = REGISTRATION.RegNo INNER JOIN " & _
            "       GUEST AS GUEST_1 ON REGISTRATION.GNo = GUEST_1.GNo " & _
            "WHERE  (GUEST_1.GIID = '" & gGiid & "') " & IIf(cboStatus.Text = String.Empty, "", "AND (REFUND_1.RefStat = '" & cboStatus.Text & "') ").ToString, _
            dgvListOfRefundAtRefundView).ToString

        Dim dblTotalAmountToRelease As Double = 0.0
        For intCtr As Integer = 0 To dgvListOfRefundAtRefundView.RowCount - 1
            dblTotalAmountToRelease += CType(dgvListOfRefundAtRefundView.Item(2, intCtr).Value, Double)
        Next

        lblTotalAmountToReleaseAtRefundInformation.Text = Format(dblTotalAmountToRelease, "n")

    End Sub

    Public Sub FillMe()

        Try
            If GuestIsNotSet Then
                Msg("1065", , "Please Choose a guest ID from the Guest Search Interface")
                Exit Sub
            End If

            'Inform use if he really likes to do this with a current transaction on hand
            gGiid = SearchedGuestID

            Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
                objConnection.Open()
                Using objCommand As SqlCommand = New SqlCommand("SELECT ISNULL(GIFName,''), ISNULL(GILName,''), ISNULL(GITitle,'') FROM GUEST_INFO WHERE GIID='" & gGiid & "'", objConnection)
                    Using objReader As SqlDataReader = objCommand.ExecuteReader
                        objReader.Read()
                        lblGuestName.Text = ""
                        lblGuestName.Text &= objReader(2).ToString & " "
                        lblGuestName.Text &= objReader(0).ToString & " "
                        lblGuestName.Text &= objReader(1).ToString
                    End Using
                End Using
                objConnection.Close()
            End Using

            DisplayRefundInformation()
            DisplayTransactions()

            lblTotalPayments.Text = "0"
            lblTotalCharges.Text = "0"
            lblTotalBalance.Text = "0"

            tbcRefund.SelectedIndex = 1

        Catch ex As Exception
            ClearControls(Me)
        End Try

    End Sub

    Public Function ThereAreInputErrors() As Boolean

        If Trim(txtOriginalAmount.Text) = String.Empty Then
            Msg("1000")
            txtOriginalAmount.SelectAll()
            txtOriginalAmount.Focus()
            Return True
            Exit Function
        Else
            If Not IsNumeric(txtOriginalAmount.Text) Then
                Msg("1001", , "A numeric value is required.")
                txtOriginalAmount.SelectAll()
                txtOriginalAmount.Focus()
                Return True
                Exit Function
            Else
                If CType(txtOriginalAmount.Text, Double) <= 0 Then
                    Msg("1001", , "A refund amount must be greater than zero.")
                    txtOriginalAmount.SelectAll()
                    txtOriginalAmount.Focus()
                    Return True
                    Exit Function
                End If
            End If
        End If

        If Trim(txtRefundPercentage.Text) <> String.Empty AndAlso Not IsNumeric(txtRefundPercentage.Text) Then
            Msg("1001", , "A numeric value is required.")
            txtRefundPercentage.SelectAll()
            txtRefundPercentage.Focus()
            Return True
            Exit Function
        ElseIf Trim(txtRefundPercentage.Text) <> String.Empty AndAlso CType(txtRefundPercentage.Text, Double) < 0 Then
            Msg("1001", , "A positive number is required.")
            txtRefundPercentage.SelectAll()
            txtRefundPercentage.Focus()
            Return True
            Exit Function
        End If

        If Trim(cboStatus_Input.Text) = String.Empty Then
            Msg("1000", , "A required information must be specified.")
            cboStatus_Input.SelectAll()
            cboStatus_Input.Focus()
            Return True
            Exit Function
        Else
            If Trim(cboStatus_Input.Text) <> "RELEASED" And Trim(cboStatus_Input.Text) <> "ONHOLD" And _
                Trim(cboStatus_Input.Text) <> "EXPIRED" And Trim(cboStatus_Input.Text) <> "UNFINALIZED" Then
                Msg("1092")
                cboStatus_Input.SelectAll()
                cboStatus_Input.Focus()
                Return True
                Exit Function
            End If
        End If

        If Trim(txtAmountToIssue.Text) = String.Empty Then
            Msg("1000")
            txtAmountToIssue.SelectAll()
            txtAmountToIssue.Focus()
            Return True
            Exit Function
        Else
            If Not IsNumeric(txtAmountToIssue.Text) Then
                Msg("1001", , "A numeric value is required.")
                txtAmountToIssue.SelectAll()
                txtAmountToIssue.Focus()
                Return True
                Exit Function
            Else
                If CType(txtAmountToIssue.Text, Double) <= 0 Then
                    Msg("1001", , "Amount should be greater than zero")
                    txtAmountToIssue.SelectAll()
                    txtAmountToIssue.Focus()
                    Return True
                    Exit Function
                End If
            End If
        End If

        If lsvTransactions.SelectedItems.Count = 0 Then
            Msg("1046", , "Please specify a transaction from the list.")
            lsvTransactions.Focus()
            Return True
            Exit Function
        End If


        'Dim intSelected As Integer
        'For intSelected = 0 To lsvTransactions.Items.Count - 1
        '    If lsvTransactions.Items(intSelected).Selected = True Then
        '        Exit For
        '    Else
        '        intSelected += 1
        '    End If
        'Next

        Dim dblTotalAmountRefund As Double = 0
        For intCtr As Integer = 0 To dgvListOfRefundAtRefundView.Rows.Count - 1
            If dgvListOfRefundAtRefundView.Item(0, intCtr).Value.ToString.ToUpper <> dgvListOfRefundAtRefundView.Item(0, dgvListOfRefundAtRefundView.CurrentRow.Index).Value.ToString.ToUpper AndAlso _
                lsvTransactions.FocusedItem.Text.ToUpper = dgvListOfRefundAtRefundView.Item(7, intCtr).Value.ToString.ToUpper Then
                dblTotalAmountRefund += CType(dgvListOfRefundAtRefundView.Item(1, intCtr).Value, Double)
            End If
        Next

        If CType(txtOriginalAmount.Text, Double) > CType(lblTotalPayments.Text, Double) - dblTotalAmountRefund Then
            Msg("1057", , "Cannot have a refund greater than the total payments made")
            txtOriginalAmount.SelectAll()
            txtOriginalAmount.Focus()
            Return True
            Exit Function
        End If

        If CType(txtAmountToIssue.Text, Double) > CType(lblTotalPayments.Text, Double) Then
            Msg("1057", , "Cannot have a refund greater than the total payments made")
            txtAmountToIssue.SelectAll()
            txtAmountToIssue.Focus()
            Return True
            Exit Function
        End If

        Return False

    End Function

    Private Sub DisplayTransactions()

        Dim objDataset As DataSet = SetUpDataSet(SetUpDataAdapter(SetUpConnection(DatabasePath, True), _
                "SELECT RESERVATION.ResNo AS [Trans No], 'RESERVATION' AS [Transaction], RESERVATION.ResDate AS Date, RESERVATION.ResStat AS Status " & _
                "FROM   GUEST INNER JOIN " & _
                "       RESERVATION ON GUEST.GNo = RESERVATION.GNo " & _
                "WHERE  (GUEST.GIID = '" & gGiid & "') " & _
                "UNION " & _
                "SELECT REGISTRATION.RegNo, 'REGISTRATION' AS [Transaction], REGISTRATION.RegDate, REGISTRATION.RegStat " & _
                "FROM   GUEST AS GUEST_1 INNER JOIN " & _
                "       REGISTRATION ON GUEST_1.GNo = REGISTRATION.GNo " & _
                "WHERE (GUEST_1.GIID = '" & gGiid & "') ", DatabaseTransactionState.SelectState), "Transaction")

        ListItems(lsvTransactions, objDataset, "Transaction")

        lsvTransactions.Columns(0).Width = 82
        lsvTransactions.Columns(1).Width = 106
        lsvTransactions.Columns(2).Width = 106
        lsvTransactions.Columns(3).Width = 108

    End Sub

    Private Sub UpdateTotals()

        'Try
        Dim lsvItem As ListViewItem = lsvTransactions.Items(lsvTransactions.FocusedItem.Index)

        If lsvItem.SubItems(1).Text.ToUpper = "RESERVATION" Then
            lblTotalCharges.Text = Format(TotalCharges(lsvItem.Text, Transaction.Reservation), "n")
            lblTotalPayments.Text = Format(TotalPayments(lsvItem.Text, Transaction.Reservation), "n")
            lblTotalBalance.Text = Format(CType(lblTotalCharges.Text, Double) - CType(lblTotalPayments.Text, Double), "n")
        ElseIf lsvItem.SubItems(1).Text.ToUpper = "REGISTRATION" Then
            lblTotalCharges.Text = Format(TotalCharges(lsvItem.Text, Transaction.Registration), "n")
            lblTotalPayments.Text = Format(TotalPayments(lsvItem.Text, Transaction.Registration), "n")
            lblTotalBalance.Text = Format(CType(lblTotalCharges.Text, Double) - CType(lblTotalPayments.Text, Double), "n")
        End If

        'Catch ex As Exception
        '    'error when the selected item at lsvTransactions is changed at code
        'End Try

    End Sub

#End Region

#Region "Command Buttons"

    Private Sub btnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNew.Click

        If My.Settings.RestrictRefund AndAlso UserPrivilege = Privilege.transaction Then
            frmAuthorization.ShowDialog()
            If frmAuthorization.Result = False Then
                Exit Sub
            End If
        End If

        gbxInformation.Enabled = False
        gbxRefundInformation.Enabled = True
        ClearControls(gbxRefundInformation)
        gState(1) = State.adding
        txtOriginalAmount.Focus()
        txtRefundPercentage.Text = gdblPercentage.ToString
        dtpExpirationDate.Value = dtpDateIncurred.Value.AddDays(gintGracePeriod)
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If dgvListOfRefundAtRefundView.SelectedRows.Count <> 1 Then
            Msg("1005")
            Exit Sub
        End If

        If My.Settings.RestrictRefund AndAlso UserPrivilege = Privilege.transaction Then
            frmAuthorization.ShowDialog()
            If frmAuthorization.Result = False Then
                Exit Sub
            End If
        End If

        gbxInformation.Enabled = False
        gbxRefundInformation.Enabled = True

        ClearControls(gbxRefundInformation)
        gState(1) = State.updating

        dtpDateIncurred.Value = CType(dgvListOfRefundAtRefundView.Item(3, dgvListOfRefundAtRefundView.CurrentRow.Index).Value, Date)
        dtpExpirationDate.Value = CType(dgvListOfRefundAtRefundView.Item(4, dgvListOfRefundAtRefundView.CurrentRow.Index).Value, Date)
        txtOriginalAmount.Text = Format(dgvListOfRefundAtRefundView.Item(1, dgvListOfRefundAtRefundView.CurrentRow.Index).Value, "n")
        txtAmountToIssue.Text = Format(dgvListOfRefundAtRefundView.Item(2, dgvListOfRefundAtRefundView.CurrentRow.Index).Value, "n")

        txtRefundPercentage.Text = Format((CType(txtAmountToIssue.Text, Double) / CType(txtOriginalAmount.Text, Double)) * 100, "n")
        cboStatus_Input.Text = dgvListOfRefundAtRefundView.Item(6, dgvListOfRefundAtRefundView.CurrentRow.Index).Value.ToString.ToUpper
        txtRemarks.Text = dgvListOfRefundAtRefundView.Item(5, dgvListOfRefundAtRefundView.CurrentRow.Index).Value.ToString.ToUpper

        txtOriginalAmount.SelectAll()
        txtOriginalAmount.Focus()

        DisplayTransactions()

        'Supposedly this will select the current transaction no (Registration or reservation no) where this refund belongs
        'For Each lvwItem As ListViewItem In lsvTransactions.Items
        '    If lvwItem.Text.ToUpper = dgvListOfRefundAtRefundView.Item(7, dgvListOfRefundAtRefundView.CurrentRow.Index).Value.ToString.ToUpper AndAlso _
        '        lvwItem.SubItems(1).Text.ToUpper = dgvListOfRefundAtRefundView.Item(8, dgvListOfRefundAtRefundView.CurrentRow.Index).Value.ToString.ToUpper Then
        '        lvwItem.Selected = True
        '        Exit For
        '    Else
        '        lvwItem.Selected = False
        '    End If
        'Next

    End Sub

    Private Sub btnSaveEditRefundInformation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveEditRefundInformation.Click
        If ThereAreInputErrors() Then Exit Sub

        Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
            objConnection.Open()
            Using objTransaction As SqlTransaction = objConnection.BeginTransaction
                Using objCommand As SqlCommand = objConnection.CreateCommand
                    With objCommand
                        .Transaction = objTransaction
                        Try

                            With .Parameters
                                .Clear()
                                .AddWithValue("@RefExpDate", dtpExpirationDate.Value).SqlDbType = SqlDbType.DateTime
                                .AddWithValue("@RefDate", dtpDateIncurred.Value).SqlDbType = SqlDbType.DateTime
                                .AddWithValue("@RefStat", cboStatus_Input.Text)
                                .AddWithValue("@RefIssuedAmt", txtAmountToIssue.Text).SqlDbType = SqlDbType.Money
                                .AddWithValue("@RefAmt", txtOriginalAmount.Text).SqlDbType = SqlDbType.Money
                                .AddWithValue("@RefRemarks", TrimAll(txtRemarks.Text))
                                .AddWithValue("@TransactionNo", lsvTransactions.FocusedItem.Text)

                                If gState(1) = State.adding Then
                                    .AddWithValue("@RefId", GetPrimaryKeyNo("Refund"))
                                    IncrementPrimaryKeyNo("Refund")
                                ElseIf gState(1) = State.updating Then
                                    .AddWithValue("@RefID", dgvListOfRefundAtRefundView.Item(0, dgvListOfRefundAtRefundView.CurrentRow.Index).Value.ToString)
                                End If
                                .AddWithValue("@LogNo", LogNo())

                            End With

                            Select Case gState(1)
                                Case State.adding

                                    If lsvTransactions.Items(lsvTransactions.FocusedItem.Index).SubItems(1).Text.ToUpper = "RESERVATION" Then
                                        .CommandText = "INSERT INTO REFUND (RefId, RefAmt, RefDate, RefStat, RefIssuedAmt, RefExpDate, RefRemarks, ResNo, LNo) " & _
                                        "VALUES (@RefID, @RefAmt, @RefDate, @RefStat, @RefIssuedAmt, @RefExpDate, @RefRemarks, @TransactionNo, @LogNo)"
                                        .ExecuteNonQuery()

                                        'Update Reservation amount?
                                        'If not updated the user can use the recompense amount to pay for the unupdated transaction
                                        'This is done as if the user paid using his refund though he was able to get the refund cash
                                        'The user will therefore use the remarks section to identify this type of refund.

                                    ElseIf lsvTransactions.Items(lsvTransactions.FocusedItem.Index).SubItems(1).Text.ToUpper = "REGISTRATION" Then
                                        .CommandText = "INSERT INTO REFUND (RefId, RefAmt, RefDate, RefStat, RefIssuedAmt, RefExpDate, RefRemarks, RegNo, LNo) " & _
                                        "VALUES (@RefID, @RefAmt, @RefDate, @RefStat, @RefIssuedAmt, @RefExpDate, @RefRemarks, @TransactionNo, @LogNo)"
                                        .ExecuteNonQuery()

                                        'Update Registration Amount?
                                    End If

                                Case State.updating

                                    .CommandText = "UPDATE REFUND SET RefAmt=@RefAmt, RefDate=@RefDate, RefStat=@RefStat, RefIssuedAmt=@RefIssuedAmt, RefExpDate=@RefExpDate, RefRemarks=@RefRemarks " & _
                                                   "WHERE RefID=@RefID"
                                    .ExecuteNonQuery()

                            End Select

                            objTransaction.Commit()

                            If gState(1) = State.adding Then
                                frmParent.tssStatus.Text = "A new refund information is saved..."
                            ElseIf gState(1) = State.updating Then
                                frmParent.tssStatus.Text = "Previous information was successfully modified..."
                            End If

                            gState(1) = State.waiting
                            gbxInformation.Enabled = True
                            gbxRefundInformation.Enabled = False

                            DisplayRefundInformation()

                            DisplayFinalizedRefunds() 'first tab
                            lsvToRelease.Items.Clear() 'first tab

                        Catch ex As Exception

                            objTransaction.Rollback()
                            Msg("1008", , NWLN & ex.Message)

                        End Try
                    End With
                End Using
            End Using
            objConnection.Close()
        End Using
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        gState(1) = State.waiting
        ClearControls(gbxRefundInformation)
        gbxInformation.Enabled = True
        gbxRefundInformation.Enabled = False
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        If dgvListOfRefundAtRefundView.SelectedRows.Count <> 1 Then
            Msg("1005", , "There is nothing to delete")
        Else

            If My.Settings.RestrictRefund AndAlso UserPrivilege = Privilege.transaction Then
                frmAuthorization.ShowDialog()
                If frmAuthorization.Result = False Then
                    Exit Sub
                End If
            End If

            If Not IsExisting("SELECT RefID FROM RECOMPENSE WHERE RefID='" & dgvListOfRefundAtRefundView.Item(0, dgvListOfRefundAtRefundView.CurrentRow.Index).Value.ToString & "'") Then

                If Msg("1035", Button.YesNo) = ButtonClicked.No Then Exit Sub

                Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
                    objConnection.Open()
                    Using objTransaction As SqlTransaction = objConnection.BeginTransaction
                        Using objCommand As SqlCommand = objConnection.CreateCommand
                            With objCommand

                                .Transaction = objTransaction
                                Try
                                    .CommandText = "DELETE FROM REFUND WHERE RefID=@RefID"
                                    .Parameters.Clear()
                                    .Parameters.AddWithValue("@RefId", dgvListOfRefundAtRefundView.Item(0, dgvListOfRefundAtRefundView.CurrentRow.Index).Value)
                                    .ExecuteNonQuery()

                                    objTransaction.Commit()
                                    frmParent.tssStatus.Text = "The refund was succesfully deleted..."

                                    DisplayRefundInformation()
                                    DisplayFinalizedRefunds() 'first tab

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
                Msg("1006", , "Cannot delete the record because its information is already used.")
            End If
        End If

    End Sub

#End Region

#Region "MISC"

    Private Sub lsvTransactions_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsvTransactions.SelectedIndexChanged
        If lsvTransactions.SelectedItems.Count = 1 Then UpdateTotals()
    End Sub

    Private Sub dtpDateIncurred_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDateIncurred.ValueChanged
        dtpExpirationDate.Value = DateAdd(DateInterval.Day, gintGracePeriod, dtpDateIncurred.Value)
    End Sub

    Private Sub txtOriginalAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOriginalAmount.TextChanged
        If IsNumeric(txtOriginalAmount.Text) And IsNumeric(txtRefundPercentage.Text) Then
            txtAmountToIssue.Text = Format(CType(txtOriginalAmount.Text, Double) * (CType(txtRefundPercentage.Text, Double) / 100), "n")
        End If
    End Sub

    Private Sub cboStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboStatus.SelectedIndexChanged
        If gGiid = String.Empty Then
            Msg("1093")
        Else
            If gState(1) = State.waiting Then
                DisplayRefundInformation()
            Else
                frmParent.tssStatus.Text = "Cannot display results because you are currently " & gState.ToString & " a record."
            End If
        End If
    End Sub

    Private Sub txtRefundPercentage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRefundPercentage.TextChanged
        If IsNumeric(txtOriginalAmount.Text) And IsNumeric(txtRefundPercentage.Text) Then
            txtAmountToIssue.Text = Format(CType(txtOriginalAmount.Text, Double) * (CType(txtRefundPercentage.Text, Double) / 100), "n")
        End If
    End Sub

#End Region

#End Region

#Region "Expired Information"

#Region "Functions/Subroutines"

    Private Sub DisplayUnmarkedRefunds()
        lblCountUnmarked.Text = ListItems(DatabasePath, _
                    "SELECT REFUND.RefID AS [Refund No], ISNULL(GUEST_INFO.GIFName, '') + ' ' + ISNULL(GUEST_INFO.GILName, '') AS Name, " & _
                    "       REFUND.RefAmt AS [Original Amount], REFUND.RefIssuedAmt AS [Amount To Issue], REFUND.RefDate AS [Date Incurred],  " & _
                    "       REFUND.RefExpDate AS [Expiration Date], REFUND.RefRemarks AS Remarks, REGISTRATION.RegNo AS [Transaction No],   " & _
                    "       'REGISTRATION' AS [Transaction]  " & _
                    "FROM   REFUND INNER JOIN  " & _
                    "       REGISTRATION ON REFUND.RegNo = REGISTRATION.RegNo INNER JOIN  " & _
                    "       GUEST ON REGISTRATION.GNo = GUEST.GNo INNER JOIN  " & _
                    "       GUEST_INFO ON GUEST.GIID = GUEST_INFO.GIID  " & _
                    "WHERE  (REFUND.RefStat <> 'EXPIRED') AND (REFUND.RefStat<>'RELEASED') AND (REFUND.RefExpDate <= CONVERT(DATETIME, '" & dtpDateOfExpiration.Value.ToString & "', 102))  " & _
                    "UNION  " & _
                    "SELECT REFUND_1.RefID, ISNULL(GUEST_INFO_1.GIFName, '') + ' ' + ISNULL(GUEST_INFO_1.GILName, '') AS Expr1, REFUND_1.RefAmt,   " & _
                    "       REFUND_1.RefIssuedAmt, REFUND_1.RefDate, REFUND_1.RefExpDate, REFUND_1.RefRemarks, REFUND_1.ResNo,   " & _
                    "       'RESERVATION' AS [Transaction]  " & _
                    "FROM   REFUND AS REFUND_1 INNER JOIN  " & _
                    "       RESERVATION ON REFUND_1.ResNo = RESERVATION.ResNo INNER JOIN  " & _
                    "       GUEST AS GUEST_1 ON RESERVATION.GNo = GUEST_1.GNo INNER JOIN  " & _
                    "       GUEST_INFO AS GUEST_INFO_1 ON GUEST_1.GIID = GUEST_INFO_1.GIID  " & _
                    "WHERE  (REFUND_1.RefStat <> 'EXPIRED') AND (REFUND_1.RefStat<>'RELEASED') AND (REFUND_1.RefExpDate <= CONVERT(DATETIME, '" & dtpDateOfExpiration.Value.ToString & "' , 102)) ", _
                dgvExpiredButNotMarked).ToString

        If dgvExpiredButNotMarked.RowCount = 0 Then
            lblTotalAmountToIssueUnmarked.Text = "0"
        Else
            Dim dblMoney As Double = 0.0
            For intCtr As Integer = 0 To dgvExpiredButNotMarked.RowCount - 1
                dblMoney += CType(dgvExpiredButNotMarked.Item(3, intCtr).Value, Double)
            Next
            lblTotalAmountToIssueUnmarked.Text = Format(dblMoney, "n")

        End If
    End Sub

    Private Sub DisplayMarkedRefunds()
        lblCountExpired.Text = ListItems(DatabasePath, _
                                    "SELECT REFUND.RefID AS [Refund No], ISNULL(GUEST_INFO.GIFName, '') + ' ' + ISNULL(GUEST_INFO.GILName, '') AS Name, " & _
                                    "       REFUND.RefAmt AS [Original Amount], REFUND.RefIssuedAmt AS [Amount To Issue], REFUND.RefDate AS [Date Incurred],  " & _
                                    "       REFUND.RefExpDate AS [Expiration Date], REFUND.RefRemarks AS Remarks, REGISTRATION.RegNo AS [Transaction No],  " & _
                                    "       'REGISTRATION' AS [Transaction] " & _
                                    "FROM   REFUND INNER JOIN " & _
                                    "       REGISTRATION ON REFUND.RegNo = REGISTRATION.RegNo INNER JOIN " & _
                                    "       GUEST ON REGISTRATION.GNo = GUEST.GNo INNER JOIN " & _
                                    "       GUEST_INFO ON GUEST.GIID = GUEST_INFO.GIID " & _
                                    "WHERE  (REFUND.RefStat = 'EXPIRED') " & _
                                    "UNION " & _
                                    "SELECT REFUND_1.RefID, ISNULL(GUEST_INFO_1.GIFName, '') + ' ' + ISNULL(GUEST_INFO_1.GILName, '') AS Expr1, REFUND_1.RefAmt,  " & _
                                    "       REFUND_1.RefIssuedAmt, REFUND_1.RefDate, REFUND_1.RefExpDate, REFUND_1.RefRemarks, REFUND_1.ResNo, 'RESERVATION' AS Expr2 " & _
                                    "FROM   REFUND AS REFUND_1 INNER JOIN " & _
                                    "       RESERVATION ON REFUND_1.ResNo = RESERVATION.ResNo INNER JOIN " & _
                                    "       GUEST AS GUEST_1 ON RESERVATION.GNo = GUEST_1.GNo INNER JOIN " & _
                                    "       GUEST_INFO AS GUEST_INFO_1 ON GUEST_1.GIID = GUEST_INFO_1.GIID " & _
                                    "WHERE  (REFUND_1.RefStat = 'EXPIRED') ", _
                                    dgvExpiredButMarked).ToString

        If dgvExpiredButMarked.RowCount = 0 Then
            lblTotalAmountToIssueMarked.Text = "0"
        Else
            Dim dblMoney As Double = 0.0
            For intCtr As Integer = 0 To dgvExpiredButMarked.RowCount - 1
                dblMoney += CType(dgvExpiredButMarked.Item(3, intCtr).Value, Double)
            Next
            lblTotalAmountToIssueMarked.Text = Format(dblMoney, "n")

        End If
    End Sub

#End Region

#Region "Command Buttons"

    Private Sub btnMarkAsExpired_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarkAsExpired.Click

        If dgvExpiredButNotMarked.SelectedRows.Count = 1 Then

            Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
                objConnection.Open()
                Using objTransaction As SqlTransaction = objConnection.BeginTransaction
                    Using objCommand As SqlCommand = objConnection.CreateCommand
                        With objCommand
                            .Transaction = objTransaction
                            Try

                                .CommandText = "UPDATE REFUND SET RefStat='EXPIRED' WHERE RefID=@RefID"
                                .Parameters.AddWithValue("@RefId", dgvExpiredButNotMarked.Item(0, dgvExpiredButNotMarked.CurrentRow.Index).Value)
                                .ExecuteNonQuery()

                                objTransaction.Commit()

                                DisplayUnmarkedRefunds()
                                DisplayMarkedRefunds()

                                DisplayFinalizedRefunds() 'first tab
                                lsvToRelease.Items.Clear() 'first tab

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

    Private Sub btnMarkAsUnexpired_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarkAsUnexpired.Click
        If dgvExpiredButMarked.SelectedRows.Count = 0 Then
            Msg("1005")
        Else
            Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
                objConnection.Open()
                Using objTransaction As SqlTransaction = objConnection.BeginTransaction
                    Using objCommand As SqlCommand = objConnection.CreateCommand
                        With objCommand
                            .Transaction = objTransaction
                            Try

                                .CommandText = "UPDATE REFUND SET RefStat='UNFINALIZED' WHERE RefID= @RefID"
                                .Parameters.AddWithValue("@RefId", dgvExpiredButMarked.Item(0, dgvExpiredButMarked.CurrentRow.Index).Value)
                                .ExecuteNonQuery()

                                objTransaction.Commit()

                                DisplayUnmarkedRefunds()
                                DisplayMarkedRefunds()

                                DisplayFinalizedRefunds() 'first tab
                                lsvToRelease.Items.Clear() 'first tab

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
    End Sub

#End Region

#Region "MISC"

    Private Sub dtpDateOfExpiration_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDateOfExpiration.ValueChanged
        DisplayUnmarkedRefunds()
    End Sub

#End Region

#End Region

#Region "MISC"

    Private Sub lblGuest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
            objConnection.Open()
            Using objCommand As SqlCommand = New SqlCommand("SELECT RefPercentage, RefGracePeriod FROM SYSTEM", objConnection)
                Using objReader As SqlDataReader = objCommand.ExecuteReader

                    objReader.Read()
                    gdblPercentage = CType(objReader(0), Double)
                    gintGracePeriod = CType(objReader(1), Integer)

                End Using
            End Using
            objConnection.Close()
        End Using

        DisplayFinalizedRefunds()

        dgvListOfRefundAtRefundIssuance.AlternatingRowsDefaultCellStyle = SetAlternatingColor()
        dgvListOfRefundAtRefundView.AlternatingRowsDefaultCellStyle = SetAlternatingColor()
        dgvExpiredButNotMarked.AlternatingRowsDefaultCellStyle = SetAlternatingColor()
        dgvExpiredButMarked.AlternatingRowsDefaultCellStyle = SetAlternatingColor()

        lblGuestName.Text = String.Empty

    End Sub

    Private Sub lblClose_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblClose.LinkClicked
        Me.Close()
    End Sub

#End Region

#Region "Side Bar"

    Private Sub tsbGuestSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuestSearch.Click
        TriggeredBy = TriggeringForm.Refund
        frmGuestSearch.ShowDialog()
    End Sub

    Private Sub tsbActGuestInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbActGuestInfo.Click

        SearchedGuestID = gGiid
        SearchedCompanyID = String.Empty
        SearchedRegistrationNo = gRegNo
        SearchedReservationNo = gResNo

        Display(Forms.frmGuestInformation)

        frmGuestInformation.FillMe()

    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click

        SearchedGuestID = gGiid
        SearchedCompanyID = String.Empty
        SearchedRegistrationNo = String.Empty
        SearchedReservationNo = String.Empty

        Display(Forms.frmPayment)

        frmPayment.FillMe()

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click

        SearchedGuestID = gGiid
        SearchedCompanyID = String.Empty
        SearchedRegistrationNo = gRegNo
        SearchedReservationNo = gResNo

        Display(Forms.frmGuestFolio)

        frmGuestFolio.FillMe()

    End Sub

#End Region

    
End Class