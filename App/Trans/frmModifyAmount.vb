Option Explicit On
Option Strict On

Imports System.Data
Imports System.Data.SqlClient

' Programmer:   Jo Jefferson D. Peralta
' Date:         March 24, 2007
' Title:        frmModifyAmount
' Purpose:      This form is used to modify the amount of amenities and services which are  
'               charged to a given active registration. Modifications can be made through percentage or 
'               directly modifying the amount.
' Requirements: ->  (*)REGISTRATION(RegAmt, RegBalance)
'               ->  (*)FOLIO_DETAILS(FDModifiedByAmt, FDModifiedByPercent, FDModifiedCharge, FDRemarks, FDBalance)
'               ->  (+)REFUND(RefID, RefAmt, RefDate, RefStat, RefIssuedAmt, RefExpDate, RefRemarks, RegNo, Lno)
'               ->  Required information is needed in the four input fields and must be equal or greater than zero
'               ->  A refund occurs when the total balance of a registration is negative.
'               ->  When this occurs a new record is inserted to the REFUND table with status equal to UNFINALIZED
'               ->  If input is specified to both increase and discount the applications computes the difference
'                   between the two and the result is saved to the database. Same is true when there is an input at the 
'                   percentage and amount. The changes by percent is computed first and the changes in amount follow
' Results:      ->  The guest folio is modified and its bills are given discounts and/or increases.
'               ->  It is possible that a refund will occur and will prompt the user to this event
'               ->  To release this refund or use this as a payments the FDO will have to go to the
'               ->  refund table and finalize it. 
'msgbox

Public Class frmModifyAmount

    Private gState As State = State.waiting
    Private gGiid As String = String.Empty
    Private gRegNo As String = String.Empty
    Private gPayments As Double = 0.0

#Region "Function/Subroutines"

    Public Sub FillMe()

        Try
            If RegistrationIsNotSet Then
                Msg("1045", , "A registration is needed.")
                Exit Sub
            End If

            'Checked out registrations are no longer allowed to modify their accounts
            'SearchedRegistrationNo is set by the guest search interface
            If Not IsExisting("SELECT REGNO FROM REGISTRATION WHERE " & _
                              "RegNo='" & SearchedRegistrationNo & "' AND RegStat='REGISTERED'; ") Then
                Msg("1045", , "An active registration is needed.")
                Exit Sub
            End If


            gGiid = SearchedGuestID
            gRegNo = SearchedRegistrationNo

            'Display the guest name to confirm a success guest search
            Using objConnection As SqlConnection = SetUpConnection(DatabasePath(), True)
                objConnection.Open()
                Using objCommand As SqlCommand = New SqlCommand("SELECT ISNULL(GITitle,''), ISNULL(GIFname,''), ISNULL(GILname,'') " & _
                                                                "FROM GUEST_INFO WHERE GIID='" & gGiid & "'", objConnection)
                    Using objReader As SqlDataReader = objCommand.ExecuteReader
                        objReader.Read()

                        lblGuest.Text = String.Empty
                        lblGuest.Text &= objReader(0).ToString & " "
                        lblGuest.Text &= objReader(1).ToString & " "
                        lblGuest.Text &= objReader(2).ToString

                    End Using
                End Using
                objConnection.Close()
            End Using

            DisplayAmenitiesAndServices()
            UpdateTotals()

        Catch ex As Exception
            ClearControls(Me)
        End Try
    End Sub

    Private Function ThereAreInputErrors() As Boolean

        If TrimAll(txtDiscountInAmount.Text) = String.Empty Then
            txtDiscountInAmount.Text = "0"
        End If
        If TrimAll(txtDiscountInPercent.Text) = String.Empty Then
            txtDiscountInPercent.Text = "0"
        End If
        If TrimAll(txtIncreaseInAmount.Text) = String.Empty Then
            txtIncreaseInAmount.Text = "0"
        End If
        If TrimAll(txtIncreaseInPercent.Text) = String.Empty Then
            txtIncreaseInPercent.Text = "0"
        End If

        If TrimAll(txtIncreaseInAmount.Text) <> String.Empty AndAlso Not IsNumeric(txtIncreaseInAmount.Text) Then
            Msg("1001", , "A numeric value is required")
            txtIncreaseInAmount.Focus()
            txtIncreaseInAmount.SelectAll()
            Return True
            Exit Function
        End If

        If TrimAll(txtIncreaseInPercent.Text) <> String.Empty AndAlso Not IsNumeric(txtIncreaseInPercent.Text) Then
            Msg("1001", , "A numeric value is required")
            txtIncreaseInPercent.Focus()
            txtIncreaseInPercent.SelectAll()
            Return True
            Exit Function
        End If

        If TrimAll(txtDiscountInAmount.Text) <> String.Empty AndAlso Not IsNumeric(txtDiscountInAmount.Text) Then
            Msg("1000")
            txtDiscountInAmount.Focus()
            txtDiscountInAmount.SelectAll()
            Return True
            Exit Function
        End If

        If TrimAll(txtDiscountInPercent.Text) <> String.Empty AndAlso Not IsNumeric(txtDiscountInPercent.Text) Then
            Msg("1001", , "A numeric value is required")
            txtDiscountInPercent.Focus()
            txtDiscountInPercent.SelectAll()
            Return True
            Exit Function
        End If

        If CType(txtModifiedAmount.Text, Double) < 0 Then
            Msg("1001", , "A negative amount is not allowed")
            txtModifiedAmount.SelectAll()
            txtModifiedAmount.Focus()
            Return True
            Exit Function
        End If
        '---->>>
        'There is no input error
        Return False

    End Function

    Private Sub DisplayAmenitiesAndServices()
        lblCount.Text = ListItems(DatabasePath, _
                        "SELECT FOLIO_DETAILS.FDNo AS [Folio No], ISNULL(REGISTRATION_DETAILS.RMNo, 'REGISTRATION') AS [Charged To],  " & _
                        "       FOLIO_DETAILS.FDName AS [Service/Amenity], FOLIO_DETAILS.FDCharge AS [Original Amount],  " & _
                        "       FOLIO_DETAILS.FDModifiedCharge AS [Modified Charge], FOLIO_DETAILS.FDModifiedByAmt AS [Amount Modification],  " & _
                        "       FOLIO_DETAILS.FDModifiedByPercent AS [Percentage Modification], FOLIO_DETAILS.FDBalance AS Balance,  " & _
                        "       FOLIO_DETAILS.FDReceiptNo AS [Receipt No], FOLIO_DETAILS.FDDate AS [Date Incurred], FOLIO_DETAILS.FDRemarks AS Remarks,  " & _
                        "       FOLIO_DETAILS.FDServiceRep AS [Serviced By], FOLIO_DETAILS.FDDesc AS Description " & _
                        "FROM   FOLIO_DETAILS LEFT OUTER JOIN " & _
                        "       REGISTRATION_DETAILS ON FOLIO_DETAILS.RegDNo = REGISTRATION_DETAILS.RegDNo " & _
                        "WHERE  (FOLIO_DETAILS.FDDesc <> 'DOWNPAYMENT') AND (FOLIO_DETAILS.RegNo = '" & gRegNo & "') AND (FOLIO_DETAILS.FDStat<>'PAID')", dgvPreviousAmenitiesAndServices).ToString

        Dim dblCtr As Double = 0.0
        For ctr As Integer = 0 To dgvPreviousAmenitiesAndServices.Rows.Count - 1
            dblCtr += CType(dgvPreviousAmenitiesAndServices.Item(4, ctr).Value, Double)
        Next
        lblAmount.Text = Format(dblCtr, "n")
    End Sub

    Private Sub ComputeCurrentAmount()

        If dgvPreviousAmenitiesAndServices.SelectedRows.Count <> 1 Then Exit Sub

        txtModifiedAmount.Text = Format(dgvPreviousAmenitiesAndServices.Item(3, dgvPreviousAmenitiesAndServices.CurrentRow.Index).Value, "n")

        If TrimAll(txtIncreaseInPercent.Text) <> String.Empty AndAlso IsNumeric(txtIncreaseInPercent.Text) Then
            txtModifiedAmount.Text = Format(CType(txtModifiedAmount.Text, Double) * (1.0 + CType(txtIncreaseInPercent.Text, Double) / 100), "n")
        End If

        If TrimAll(txtDiscountInPercent.Text) <> String.Empty AndAlso IsNumeric(txtDiscountInPercent.Text) Then
            txtModifiedAmount.Text = Format(CType(txtModifiedAmount.Text, Double) * (1.0 - CType(txtDiscountInPercent.Text, Double) / 100), "n")
        End If

        If TrimAll(txtIncreaseInAmount.Text) <> String.Empty AndAlso IsNumeric(txtIncreaseInAmount.Text) Then
            txtModifiedAmount.Text = Format(CType(txtModifiedAmount.Text, Double) + CType(txtIncreaseInAmount.Text, Double), "n")
        End If

        If TrimAll(txtDiscountInAmount.Text) <> String.Empty AndAlso IsNumeric(txtDiscountInAmount.Text) Then
            txtModifiedAmount.Text = Format(CType(txtModifiedAmount.Text, Double) - CType(txtDiscountInAmount.Text, Double), "n")
        End If

    End Sub

    Private Sub UpdateTotals()
        If gRegNo <> String.Empty Then
            lblTotalCharges.Text = Format(TotalCharges(gRegNo, Transaction.Registration), "n")
            lblTotalPayments.Text = Format(TotalPayments(gRegNo, Transaction.Registration), "n")
            lblTotalBalance.Text = Format(TotalBalance(gRegNo, Transaction.Registration), "n")
        End If
    End Sub

#End Region

#Region "Command Buttons"

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If ThereAreInputErrors() Then Exit Sub

        Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
            objConnection.Open()
            Using objTransaction As SqlTransaction = objConnection.BeginTransaction
                Using objCommand As SqlCommand = objConnection.CreateCommand
                    With objCommand
                        .Transaction = objTransaction

                        Dim dblOriginalAmt As Double, dblModifiedByAmt As Double, dblNewAmount As Double, _
                            dblModifiedByPercent As Double, dblBalance As Double, dblPayments As Double

                        dblNewAmount = CType(txtModifiedAmount.Text, Double)
                        dblOriginalAmt = CType(dgvPreviousAmenitiesAndServices.Item(3, dgvPreviousAmenitiesAndServices.CurrentRow.Index).Value, Double)
                        dblBalance = CType(dgvPreviousAmenitiesAndServices.Item(7, dgvPreviousAmenitiesAndServices.CurrentRow.Index).Value, Double)
                        dblPayments = dblOriginalAmt - dblBalance
                        dblModifiedByAmt = CType(txtIncreaseInAmount.Text, Double) - CType(txtDiscountInAmount.Text, Double)
                        dblModifiedByPercent = CType(txtIncreaseInPercent.Text, Double) - CType(txtDiscountInPercent.Text, Double)


                        Try
                            .CommandText = "UPDATE FOLIO_DETAILS SET FDModifiedByAmt=@FDModifiedByAmt, " & _
                                            "FDModifiedByPercent=@FDModifiedByPercent, " & _
                                            "FDModifiedCharge=@FDModifiedCharge, " & _
                                            "FDRemarks=@FDRemarks, FDBalance = @FDBalance " & _
                                            "WHERE FDNo=@FDNo"

                            With .Parameters
                                .Clear()
                                .AddWithValue("@FDModifiedByAmt", dblModifiedByAmt)
                                .AddWithValue("@FdModifiedByPercent", dblModifiedByPercent)
                                .AddWithValue("@FDModifiedCharge", dblNewAmount)
                                .AddWithValue("@FDRemarks", TrimAll(txtRemarks.Text, True))

                                If dblNewAmount - dblPayments < 0 Then
                                    .AddWithValue("@FDBalance", 0)
                                Else
                                    .AddWithValue("@FDBalance", dblNewAmount - dblPayments)
                                End If

                                .AddWithValue("@FDNo", dgvPreviousAmenitiesAndServices.Item(0, dgvPreviousAmenitiesAndServices.CurrentRow.Index).Value.ToString)

                            End With
                            .ExecuteNonQuery()

                            .CommandText = "SELECT ISNULL(SUM(FDModifiedCharge),0) AS TotalCharges " & _
                                            "FROM  FOLIO_DETAILS " & _
                                            "WHERE (RegNo = '" & gRegNo & "') AND FDStat<>'UNCOLLECTIBLE'"
                            Dim dblRegCharges As Double = CType(.ExecuteScalar, Double)

                            .CommandText = "SELECT ISNULL(SUM(PAmt),0) AS TotalPayments " & _
                                            "FROM  PAYMENT " & _
                                            "WHERE (RegNo = '" & gRegNo & "') "
                            Dim dblRegPayments As Double = CType(.ExecuteScalar, Double)

                            .CommandText = "SELECT ISNULL(SUM(RefAmt), 0) FROM REFUND " & _
                                           "WHERE RegNo='" & gRegNo & "'"
                            Dim dblRegRefund As Double = CType(.ExecuteScalar, Double)
                            Dim dblRegBalance As Double = dblRegCharges - dblRegPayments + dblRegRefund

                            Dim blnRefund As Boolean = False
                            If dblRegBalance >= 0 Then

                                .CommandText = "UPDATE REGISTRATION SET RegBalance = @RegBalance WHERE RegNo = @RegNo"
                                .Parameters.Clear()
                                .Parameters.AddWithValue("@RegBalance", dblRegBalance)
                                .Parameters.AddWithValue("@RegNo", gRegNo)
                                .ExecuteNonQuery()

                                blnRefund = False

                            Else
                                dblRegBalance *= -1

                                .CommandText = "SELECT RefGracePeriod FROM SYSTEM WHERE SysID=(SELECT MAX(SYSID) FROM System); "
                                Dim intGracePeriod As Integer = CType(.ExecuteScalar, Integer)

                                'Start saving at the refund table
                                .CommandText = "INSERT INTO REFUND (RefID, RefAmt, RefDate, RefStat, RefIssuedAmt, RefExpDate, RefRemarks, RegNo, Lno) " & _
                                               "VALUES (@RefID, @RefAmt, @RefDate, @RefStat, @RefIssuedAmt, @RefExpDate, @RefRemarks, @RegNo, @Lno); "

                                With .Parameters
                                    .Clear()
                                    .AddWithValue("@RefID", GetPrimaryKeyNo("REFUND"))
                                    .AddWithValue("@RefAmt", dblRegBalance).SqlDbType = SqlDbType.Money
                                    .AddWithValue("@RefDate", Date.Now)
                                    .AddWithValue("@RefStat", "UNFINALIZED")
                                    .AddWithValue("@RefIssuedAmt", 0).SqlDbType = SqlDbType.Money
                                    .AddWithValue("@RefExpDate", Date.Now.AddDays(intGracePeriod))
                                    .AddWithValue("@RefRemarks", "REFUND FROM MODIFY AMOUNT")
                                    .AddWithValue("@RegNo", gRegNo)
                                    .AddWithValue("@LNo", LogNo())
                                End With
                                .ExecuteNonQuery()
                                IncrementPrimaryKeyNo("REFUND")

                                'Update Registration Amount And Balance
                                .CommandText = "UPDATE REGISTRATION SET RegBalance = 0 WHERE RegNo = @RegNo"
                                .Parameters.Clear()
                                .Parameters.AddWithValue("@RegNo", gRegNo)
                                .ExecuteNonQuery()

                                blnRefund = True

                            End If

                            objTransaction.Commit()

                            DisplayAmenitiesAndServices()
                            UpdateTotals()

                            If blnRefund Then
                                Msg("1056")
                            End If

                            frmParent.tssStatus.Text = "The amount was modified..."

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

#End Region

#Region "MISC"

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmModifyAmount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblGuest.Text = String.Empty
        dgvPreviousAmenitiesAndServices.AlternatingRowsDefaultCellStyle = SetAlternatingColor()
    End Sub

    Private Sub txtDiscountInPercent_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDiscountInPercent.TextChanged, txtDiscountInAmount.TextChanged, txtIncreaseInAmount.TextChanged, txtIncreaseInPercent.TextChanged
        ComputeCurrentAmount()
    End Sub

    Private Sub dgvPreviousAmenitiesAndServices_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvPreviousAmenitiesAndServices.SelectionChanged
        txtRemarks.Text = dgvPreviousAmenitiesAndServices.Item(10, dgvPreviousAmenitiesAndServices.CurrentRow.Index).Value.ToString

        txtDiscountInAmount.Text = "0.00"
        txtDiscountInPercent.Text = "0.00"
        txtIncreaseInAmount.Text = "0.00"
        txtIncreaseInPercent.Text = "0.00"

        If CType(dgvPreviousAmenitiesAndServices.Item(5, dgvPreviousAmenitiesAndServices.CurrentRow.Index).Value, Double) < 0 Then
            txtDiscountInAmount.Text = Format(-1 * CType(dgvPreviousAmenitiesAndServices.Item(5, dgvPreviousAmenitiesAndServices.CurrentRow.Index).Value, Double), "#,0.00")
        Else
            txtIncreaseInAmount.Text = Format(CType(dgvPreviousAmenitiesAndServices.Item(5, dgvPreviousAmenitiesAndServices.CurrentRow.Index).Value, Double), "#,0.00")
        End If

        If CType(dgvPreviousAmenitiesAndServices.Item(6, dgvPreviousAmenitiesAndServices.CurrentRow.Index).Value, Double) < 0 Then
            txtDiscountInPercent.Text = Format(-1 * CType(dgvPreviousAmenitiesAndServices.Item(6, dgvPreviousAmenitiesAndServices.CurrentRow.Index).Value, Double), "#,0.00")
        Else
            txtIncreaseInPercent.Text = Format(CType(dgvPreviousAmenitiesAndServices.Item(6, dgvPreviousAmenitiesAndServices.CurrentRow.Index).Value, Double), "#,0.00")
        End If

        ComputeCurrentAmount()

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblClose.LinkClicked
        Me.Close()
    End Sub

#End Region

#Region "Side Bars"

    Private Sub tsbGuestSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuestSearch.Click
        TriggeredBy = TriggeringForm.ModifyAmount
        frmGuestSearch.ShowDialog()
    End Sub

    Private Sub tsbGuestFolio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuestFolio.Click
        SearchedGuestID = gGiid
        SearchedCompanyID = String.Empty
        SearchedRegistrationNo = gRegNo
        SearchedReservationNo = String.Empty

        Display(Forms.frmGuestFolio)

        frmGuestFolio.FillMe()

    End Sub

    Private Sub tsbGuestInformation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuestInformation.Click

        SearchedGuestID = gGiid
        SearchedCompanyID = String.Empty
        SearchedRegistrationNo = gRegNo
        SearchedReservationNo = String.Empty

        Display(Forms.frmGuestInformation)

        frmGuestInformation.FillMe()

    End Sub

    Private Sub tsbPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbPayment.Click

        SearchedGuestID = gGiid
        SearchedCompanyID = String.Empty
        SearchedRegistrationNo = gRegNo
        SearchedReservationNo = String.Empty

        Display(Forms.frmPayment)

        frmPayment.FillMe()

    End Sub

#End Region

End Class