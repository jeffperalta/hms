Option Explicit On
Option Strict On

Imports System.Data
Imports System.Data.SqlClient

' Programmer:   Jo Jefferson D. Peralta
' Date:         March 28, 2007
' Title:        frmUncollectible
' Purpose:      When a guest checks out from the hotel and there were remaining items that are still unpaid 
'               And for some reason was not able to pay it, the FDO can use this interface to mark that bill as 
'               uncollectibles. Once the bill is uncollectible it is no longer computed as part of the total bills
'               Thus the guest is allowed to check out without remaining balance.
' Requirements: ->  (*)FOLIO_DETAILS(FDStat)
'               ->  (*)RESERVATION(ResAmt, ResBalance)
'               ->  (*)REGISTRATION(RegAmt, RegBalance)
'               ->  An FDO will use this interface to mark the whole bill as uncollectible. And supposedly
'                   this action (marking bills to uncollectibles) will have to be done when the guest
'                   Checks out
'               ->  Meanwhile it is more appropriate to use the frmModifyAmount Interface when the guest
'                   is still staying at the hotel. The FDO can change the amount at that interface to a lower amount
'                   if the guest confirms that he cannot fully pay for the bill thus requesting a discount.
'               ->  For instance, a bill amounts to $1000 and the FDO would like to mark the $300 as uncollectibles.
'                   To follow the SOP, he will have to wait until the guest checks out to finally settle all his
'                   account. But what he can do at the moment is to modify the amount of $1000 to $300 at the frmModifyAmount
'                   The frmModifyAmount will also be incharged of the refunds if the changes will result to such.
'                   When the guest checks out and since at this time the amount is changed to $300 the FDO can now
'                   mark the whole bill(which amounts to $300 not $1000) as uncollectibles.
'               ->  Later when he checks out, the FDO can start marking the uncollectibles to let 
'                   guest settle his account.
'               ->  The user can use the History tab to view all the bills that are marked as uncollectibles.
' Results:      ->  The guest's folio is modified by changing the status of his bill(s) to uncollectibles.
'               ->  Reservation or registration amounts and balances are also changed.
'               ->  The FDO can review all the uncollectibles for a given period
'msgbox


Public Class frmUncollectible

    Private gRegNo As String = String.Empty
    Private gResNo As String = String.Empty
    Private gStatus As State = State.waiting
    Private gTransaction As Transaction

#Region "Functions/SubRoutines"

    Public Sub FillMe()

        Try
            If RegistrationIsNotSet AndAlso ReservationIsNotSet Then
                Msg("1046")
            Else
                If Not RegistrationIsNotSet Then
                    If IsExisting("SELECT RegNo FROM REGISTRATION WHERE RegNo='" & SearchedRegistrationNo & "' AND RegStat='CHECKED OUT'") Then
                        If Msg("1047", Button.YesNo) = ButtonClicked.Yes Then
                            gTransaction = Transaction.Registration
                            gRegNo = SearchedRegistrationNo
                        Else
                            Exit Sub
                        End If
                    Else
                        gTransaction = Transaction.Registration
                        gRegNo = SearchedRegistrationNo
                    End If
                ElseIf Not ReservationIsNotSet Then
                    If IsExisting("SELECT ResNo FROM RESERVATION WHERE ResNo='" & SearchedReservationNo & "' AND ResStat='CANCELLED'") Then
                        If Msg("1048", Button.YesNo) = ButtonClicked.Yes Then
                            gTransaction = Transaction.Reservation
                            gResNo = SearchedReservationNo
                        Else
                            Exit Sub
                        End If
                    Else
                        gTransaction = Transaction.Reservation
                        gResNo = SearchedReservationNo
                    End If
                End If
                DisplayBillBreakdown()
                DisplayUncollectibles()
                UpdateTotals()
                DisplayAllUncollectibles()

                Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
                    objConnection.Open()
                    Using objCommand As SqlCommand = New SqlCommand("SELECT ISNULL(GITitle,''), ISNULL(GIFName,''), ISNULL(GILName,'') FROM GUEST_INFO WHERE GIID='" & SearchedGuestID & "'", objConnection)
                        Using objReader As SqlDataReader = objCommand.ExecuteReader
                            objReader.Read()
                            lblGuest.Text = objReader(0).ToString & " " & objReader(1).ToString & " " & objReader(2).ToString
                        End Using
                    End Using
                    objConnection.Close()
                End Using
            End If
        Catch ex As Exception
            ClearControls(Me)
        End Try

    End Sub

    Private Sub DisplayBillBreakdown()

        Select Case gTransaction
            Case Transaction.Registration
                lblCount.Text = ListItems(DatabasePath, _
                                            "SELECT FDNo AS [Folio No], FDName AS Service, FDModifiedCharge AS Amount, FDBalance AS Balance, FDReceiptNo AS [Receipt No],  " & _
                                            "       FDDate AS [Date Incurred], FDRemarks AS Remarks, FDDesc AS Description " & _
                                            "FROM   FOLIO_DETAILS " & _
                                            "WHERE  (FDStat <> 'UNCOLLECTIBLE') AND (RegNo = '" & gRegNo & "') ", _
                                             dgvBillBreakdown).ToString
            Case Transaction.Reservation
                lblCount.Text = ListItems(DatabasePath, _
                                           "SELECT FDNo AS [Folio No], FDName AS Service, FDModifiedCharge AS Amount, FDBalance AS Balance, FDReceiptNo AS [Receipt No],  " & _
                                           "       FDDate AS [Date Incurred], FDRemarks AS Remarks, FDDesc AS Description " & _
                                           "FROM   FOLIO_DETAILS " & _
                                           "WHERE  (FDStat <> 'UNCOLLECTIBLE') AND (ResNo = '" & gResNo & "') ", _
                                           dgvBillBreakdown).ToString
        End Select

        Dim dblMoney As Double = 0.0
        If dgvBillBreakdown.RowCount <> 0 Then

            For intCtr As Integer = 0 To dgvBillBreakdown.RowCount - 1
                dblMoney += CType(dgvBillBreakdown.Item(2, intCtr).Value, Double)
            Next

            lblAmount.Text = Format(dblMoney, "n")
        Else
            lblAmount.Text = "0.00"
        End If
        
    End Sub

    Private Sub DisplayUncollectibles()

        Select Case gTransaction
            Case Transaction.Registration
                lblTotalUncollectible.Text = ListItems(DatabasePath, _
                                                        "SELECT FDNo AS [Folio No], FDName AS Service, FDModifiedCharge AS Amount, FDBalance AS Balance, FDReceiptNo AS [Receipt No],  " & _
                                                        "       FDDate AS [Date Incurred], FDRemarks AS Remarks, FDDesc AS Description " & _
                                                        "FROM   FOLIO_DETAILS " & _
                                                        "WHERE  (FDStat = 'UNCOLLECTIBLE') AND (RegNo = '" & gRegNo & "') ", _
                                                         dgvUncollectibles_FirstTab).ToString
            Case Transaction.Reservation
                lblTotalUncollectible.Text = ListItems(DatabasePath, _
                                                       "SELECT FDNo AS [Folio No], FDName AS Service, FDModifiedCharge AS Amount, FDBalance AS Balance, FDReceiptNo AS [Receipt No],  " & _
                                                       "       FDDate AS [Date Incurred], FDRemarks AS Remarks, FDDesc AS Description " & _
                                                       "FROM   FOLIO_DETAILS " & _
                                                       "WHERE  (FDStat = 'UNCOLLECTIBLE') AND (ResNo = '" & gResNo & "') ", _
                                                       dgvUncollectibles_FirstTab).ToString
        End Select

        Dim dblMoney As Double = 0.0
        If dgvUncollectibles_FirstTab.RowCount <> 0 Then

            For intCtr As Integer = 0 To dgvUncollectibles_FirstTab.RowCount - 1
                dblMoney += CType(dgvUncollectibles_FirstTab.Item(2, intCtr).Value, Double)
            Next

            lblTotalAmountUncollectible.Text = Format(dblMoney, "n")
        Else
            lblTotalAmountUncollectible.Text = "0.00"
        End If

    End Sub

    Private Sub UpdateTotals()

        Select Case gTransaction
            Case Transaction.Registration
                lblTotalCharges.Text = Format(TotalCharges(gRegNo, Transaction.Registration), "n")
                lblTotalPayments.Text = Format(TotalPayments(gRegNo, Transaction.Registration), "n")
                lblTotalBalance.Text = Format(CType(lblTotalCharges.Text, Double) - CType(lblTotalPayments.Text, Double), "n")

                Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
                    objConnection.Open()
                    Using objTransaction As SqlTransaction = objConnection.BeginTransaction
                        Using objCommand As SqlCommand = objConnection.CreateCommand
                            With objCommand
                                .Transaction = objTransaction
                                Try
                                    .CommandText = "UPDATE REGISTRATION SET RegAmt=@RegAmt, RegBalance=@RegBalance WHERE RegNo=@RegNo"
                                    With .Parameters
                                        .Clear()
                                        .AddWithValue("@RegAmt", CType(lblTotalCharges.Text, Double)).SqlDbType = SqlDbType.Money
                                        .AddWithValue("@RegBalance", CType(lblTotalBalance.Text, Double)).SqlDbType = SqlDbType.Money
                                        .AddWithValue("@RegNo", gRegNo)
                                    End With

                                    .ExecuteNonQuery()
                                    objTransaction.Commit()

                                Catch ex As Exception

                                    objTransaction.Rollback()
                                    Msg("1008", , NWLN & ex.Message)

                                End Try
                            End With
                        End Using
                    End Using
                    objConnection.Close()
                End Using

            Case Transaction.Reservation
                lblTotalCharges.Text = Format(TotalCharges(gResNo, Transaction.Reservation), "n")
                lblTotalPayments.Text = Format(TotalPayments(gResNo, Transaction.Reservation), "n")
                lblTotalBalance.Text = Format(CType(lblTotalCharges.Text, Double) - CType(lblTotalPayments.Text, Double), "n")

                Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
                    objConnection.Open()
                    Using objTransaction As SqlTransaction = objConnection.BeginTransaction
                        Using objCommand As SqlCommand = objConnection.CreateCommand
                            With objCommand
                                .Transaction = objTransaction
                                Try
                                    .CommandText = "UPDATE RESERVATION SET ResAmt=@ResAmt, ResBalance=@ResBalance WHERE ResNo=@ResNo"
                                    With .Parameters
                                        .Clear()
                                        .AddWithValue("@ResAmt", CType(lblTotalCharges.Text, Double)).SqlDbType = SqlDbType.Money
                                        .AddWithValue("@ResBalance", CType(lblTotalBalance.Text, Double)).SqlDbType = SqlDbType.Money
                                        .AddWithValue("@ResNo", gResNo)
                                    End With

                                    .ExecuteNonQuery()
                                    objTransaction.Commit()

                                Catch ex As Exception

                                    objTransaction.Rollback()
                                    Msg("1008", , NWLN & ex.Message)

                                End Try
                            End With
                        End Using
                    End Using
                    objConnection.Close()
                End Using


        End Select

    End Sub

    Private Sub DisplayAllUncollectibles()

        lblCountAllUncollectibles.Text = ListItems(DatabasePath, _
                                            "SELECT FOLIO_DETAILS.FDNo AS [Folio No], ISNULL(GUEST_INFO.GITitle, '') + ' ' + ISNULL(GUEST_INFO.GIFName, '') + ' ' + ISNULL(GUEST_INFO.GILName, '') " & _
                                            "       AS Name, FOLIO_DETAILS.FDName AS Service, FOLIO_DETAILS.FDModifiedCharge AS Amount, FOLIO_DETAILS.FDBalance AS Balance,  " & _
                                            "       FOLIO_DETAILS.FDReceiptNo AS [Receipt No], FOLIO_DETAILS.FDDate AS [Date Incurred], FOLIO_DETAILS.FDRemarks AS Remarks,  " & _
                                            "       FOLIO_DETAILS.FDDesc AS Description " & _
                                            "FROM   GUEST INNER JOIN " & _
                                            "       REGISTRATION ON GUEST.GNo = REGISTRATION.GNo INNER JOIN " & _
                                            "       GUEST_INFO ON GUEST.GIID = GUEST_INFO.GIID INNER JOIN " & _
                                            "       FOLIO_DETAILS ON REGISTRATION.RegNo = FOLIO_DETAILS.RegNo " & _
                                            "WHERE  (FOLIO_DETAILS.FDStat = 'UNCOLLECTIBLE') " & IIf(chkViewAll.Checked, "", " AND FOLIO_DETAILS.FDDate BETWEEN '" & dtpStartDate.Value.ToString & "' AND '" & dtpEndDate.Value.ToString & "'").ToString, _
                                            dgvUncollectible).ToString

        If dgvUncollectible.RowCount <> 0 Then
            Dim dblMoney As Double = 0.0
            For intCtr As Integer = 0 To dgvUncollectible.RowCount - 1
                dblMoney += CType(dgvUncollectible.Item(3, intCtr).Value, Double)
            Next
            lblTotalAmountMoneyUncollectible.Text = Format(dblMoney, "n")
        Else
            lblTotalAmountMoneyUncollectible.Text = "0.00"
        End If

    End Sub

#End Region

#Region "Command Buttons"

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If dgvBillBreakdown.SelectedRows.Count = 1 Then

            'If dgvBillBreakdown.RowCount = 1 Then
            '    Msg("1094")
            '    Exit Sub
            'End If

            If My.Settings.RestrictUncollectibles AndAlso UserPrivilege = Privilege.transaction Then
                frmAuthorization.ShowDialog()
                If frmAuthorization.Result = False Then
                    Exit Sub
                End If
            End If

            Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
                objConnection.Open()
                Using objTransaction As SqlTransaction = objConnection.BeginTransaction
                    Using objCommand As SqlCommand = objConnection.CreateCommand
                        With objCommand
                            .Transaction = objTransaction

                            Try
                                .CommandText = "UPDATE FOLIO_DETAILS SET FDStat='UNCOLLECTIBLE' WHERE FDNo=@FDNo"
                                .Parameters.Clear()
                                .Parameters.AddWithValue("@FDNo", dgvBillBreakdown.Item(0, dgvBillBreakdown.CurrentRow.Index).Value)
                                .ExecuteNonQuery()

                                objTransaction.Commit()
                                frmParent.tssStatus.Text = "Transaction was saved..."
                                DisplayBillBreakdown()
                                DisplayUncollectibles()
                                DisplayAllUncollectibles()
                                UpdateTotals()

                                gStatus = State.waiting

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

    Private Sub btnUnmark_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnmark.Click

        If dgvUncollectibles_FirstTab.SelectedRows.Count = 1 Then

            If My.Settings.RestrictUncollectibles AndAlso UserPrivilege = Privilege.transaction Then
                frmAuthorization.ShowDialog()
                If frmAuthorization.Result = False Then
                    Exit Sub
                End If
            End If

            Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
                objConnection.Open()
                Using objTransaction As SqlTransaction = objConnection.BeginTransaction
                    Using objCommand As SqlCommand = objConnection.CreateCommand
                        With objCommand
                            .Transaction = objTransaction
                            Try

                                .CommandText = "SELECT FDBalance FROM FOLIO_DETAILS WHERE FDNo=@FDNo"
                                .Parameters.Clear()
                                .Parameters.AddWithValue("@FDNo", dgvUncollectibles_FirstTab.Item(0, dgvUncollectibles_FirstTab.CurrentRow.Index).Value)
                                Dim dblBalance As Double = CType(.ExecuteScalar, Double)

                                .CommandText = "UPDATE FOLIO_DETAILS SET FDStat=@FDStat WHERE FDNo=@FDNo"
                                .Parameters.Clear()
                                If dblBalance = 0 Then
                                    .Parameters.AddWithValue("@FdStat", "PAID")
                                Else
                                    .Parameters.AddWithValue("@FdStat", "UNPAID")
                                End If
                                .Parameters.AddWithValue("@FDNo", dgvUncollectibles_FirstTab.Item(0, dgvUncollectibles_FirstTab.CurrentRow.Index).Value)
                                .ExecuteNonQuery()

                                objTransaction.Commit()
                                frmParent.tssStatus.Text = "Transaction was saved..."
                                DisplayBillBreakdown()
                                DisplayUncollectibles()
                                DisplayAllUncollectibles()
                                UpdateTotals()

                                gStatus = State.waiting

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

#End Region

#Region "MISC"

    Private Sub frmUncollectible_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgvBillBreakdown.AlternatingRowsDefaultCellStyle = SetAlternatingColor()
        dgvUncollectibles_FirstTab.AlternatingRowsDefaultCellStyle = SetAlternatingColor()
        dgvUncollectible.AlternatingRowsDefaultCellStyle = SetAlternatingColor()
        lblGuest.Text = String.Empty
    End Sub

    Private Sub chkViewAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkViewAll.CheckedChanged
        DisplayAllUncollectibles()
        dtpStartDate.Enabled = Not chkViewAll.Checked
        dtpEndDate.Enabled = Not chkViewAll.Checked
    End Sub

    Private Sub dtpStartDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpStartDate.ValueChanged
        DisplayAllUncollectibles()
    End Sub

    Private Sub dtpEndDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpEndDate.ValueChanged
        DisplayAllUncollectibles()
    End Sub

    Private Sub lblClose_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblClose.LinkClicked
        Me.Close()
    End Sub

#End Region

#Region "SIDE BARS"

    Private Sub tsbActGuestSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbActGuestSearch.Click
        TriggeredBy = TriggeringForm.Uncollectibles
        frmGuestSearch.ShowDialog()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        SearchedGuestID = String.Empty
        SearchedCompanyID = String.Empty
        SearchedRegistrationNo = gRegNo
        SearchedReservationNo = gResNo

        Display(Forms.frmGuestFolio)

        frmGuestFolio.FillMe()

    End Sub

    Private Sub tsbActPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbActPayment.Click
        'No giid
        Display(Forms.frmPayment)
    End Sub

#End Region

End Class