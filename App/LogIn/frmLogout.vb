Option Explicit On
Option Strict On

Imports System.Data
Imports System.Data.SqlClient

' Programmer:   Jo Jefferson D. Peralta
' Date:         March 08, 2007
' Title:        frmLogout
' Purpose:      This interface is used to log off from the system and resume the front desk later
'               If the user chooses this option his current log no. is maintained upon log in.
'               The employees will have to provide the cashout and turnover information before he can
'               log out and end the shift.
'               If the user forgets to log out and end a shift the manager can go to another interface 
'               to manually end and finalize the shift (frmLogMonitoring)
' Requirements: ->  (+) SHIFT_INFO(LNo, SIAmtTurnOver, SITotalAmtCollected, SIAmtReceivable, SICashOnHand, 
'                                   SICashOut, SIRemarks, SICash, SICheque, SIBank, SICCard, SIRecompense)
'               ->  (*) LOG_INFO (LTimeOut, LStat)
'               ->  (*) SYSTEM (TotalCashInFD)
'               ->  The Amount Turnover is checked by this form. 
'                   If the system detects that it is less than the supposed amount (TotalOnHand=Cash+Cheque) then
'                   the application will need the authentication from the manager
'               ->  The cashout is also checked so that it will not excede the total cash at the front desk
' Results:      ->  The log of a user is ended and the End Shift Information is finalized
'               ->  Information such as the total sales, mode of payments, and the total cash at the front desk

Public Class frmLogout

    Private dblTurnOver As Double = 0

#Region "Functions/SubRoutines"

    Private Sub DisplayShiftInfo()

        Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
            objConnection.Open()
            Using objCommand As SqlCommand = New SqlCommand("SELECT LOG_INFO.LNo, ISNULL(SHIFT.ShiftName,'NONE') AS ShiftName, EMPLOYEE.ELName + ', ' + EMPLOYEE.EFName + ' ' + EMPLOYEE.EMI AS NAME, EMPLOYEE.EPosition, " & _
                                                            "       LOG_INFO.LTimeIn, SUM(ISNULL(PAYMENT.PAmt,0)) AS AmountReceived, ISNULL(COUNT(PAYMENT.PID),0) AS TotalPaymentsReceived, SUM(ISNULL(REFUND.RefAmt,0))  " & _
                                                            "       AS TotalRefund " & _
                                                            "FROM   LOG_INFO INNER JOIN " & _
                                                            "       EMPLOYEE ON LOG_INFO.EID = EMPLOYEE.EID LEFT OUTER JOIN " & _
                                                            "       SHIFT ON LOG_INFO.ShiftID = SHIFT.ShiftID LEFT OUTER JOIN " & _
                                                            "       REFUND ON LOG_INFO.LNo = REFUND.LNo LEFT OUTER JOIN " & _
                                                            "       PAYMENT ON LOG_INFO.LNo = PAYMENT.LNo " & _
                                                            "WHERE  (LOG_INFO.LNo = '" & LogNo & "') " & _
                                                            "GROUP BY LOG_INFO.LNo, SHIFT.ShiftName, EMPLOYEE.ELName + ', ' + EMPLOYEE.EFName + ' ' + EMPLOYEE.EMI, EMPLOYEE.EPosition, LOG_INFO.LTimeIn ", objConnection)

                Using objReader As SqlDataReader = objCommand.ExecuteReader

                    objReader.Read()

                    Dim lsvItem As ListViewItem = lvwSummary.Items.Add("Log No")
                    lsvItem.SubItems.Add(objReader("Lno").ToString)

                    lsvItem = lvwSummary.Items.Add("Shift Name")
                    lsvItem.SubItems.Add(objReader("ShiftName").ToString)

                    lsvItem = lvwSummary.Items.Add("Log In Time")
                    lsvItem.SubItems.Add(objReader("LTimeIn").ToString)

                    lsvItem = lvwSummary.Items.Add("Hours Since Log")
                    lsvItem.SubItems.Add(DateDiff(DateInterval.Hour, CType(objReader("LTimeIn"), Date), Date.Now).ToString)

                    lsvItem = lvwSummary.Items.Add("Employee Name")
                    lsvItem.SubItems.Add(objReader("NAME").ToString)

                    lsvItem = lvwSummary.Items.Add("Position")
                    lsvItem.SubItems.Add(objReader("EPosition").ToString)

                    lsvItem = lvwSummary.Items.Add("Payments Serviced")
                    lsvItem.SubItems.Add(objReader("TotalPaymentsReceived").ToString)

                    lsvItem = lvwSummary.Items.Add("Amount Collected")
                    lsvItem.SubItems.Add(Format(objReader("AmountReceived"), "n"))

                    lsvItem = lvwSummary.Items.Add("Refund Received")
                    lsvItem.SubItems.Add(Format(objReader("TotalRefund"), "n"))

                    objReader.Close()
                End Using

                objCommand.CommandText = "SELECT TotalCashInFD FROM SYSTEM"
                Using objReader As SqlDataReader = objCommand.ExecuteReader

                    objReader.Read()

                    Dim lsvItem As ListViewItem = lvwSummary.Items.Add("Cash at Front Desk: ")
                    lsvItem.SubItems.Add(Format(objReader("TotalCashInFD"), "n"))

                    objReader.Close()
                End Using

            End Using

            objConnection.Close()
        End Using


        lvwSummary.Columns(0).Width = 150
        lvwSummary.Columns(0).TextAlign = HorizontalAlignment.Right
        lvwSummary.Columns(1).Width = 222

    End Sub

    Private Sub DisplaySalesInfo()

        Dim dblCash As Double = 0, dblCreditCard As Double = 0, dblBank As Double = 0, _
            dblCheque As Double = 0, dblRecompense As Double = 0, dblTotalSales As Double = 0

        Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
            objConnection.Open()
            Using objCommand As SqlCommand = New SqlCommand("SELECT PAYMENT_TYPE_DETAILS.PTType, ISNULL(SUM(PAYMENT_TYPE_DETAILS.PTAmt), 0) AS Total " & _
                                                            "FROM   PAYMENT RIGHT OUTER JOIN " & _
                                                            "       PAYMENT_TYPE_DETAILS ON PAYMENT.PID = PAYMENT_TYPE_DETAILS.PID " & _
                                                            "WHERE  (PAYMENT.LNo = '" & LogNo & "')  " & _
                                                            "GROUP BY PAYMENT_TYPE_DETAILS.PTType ", objConnection)

                Using objReader As SqlDataReader = objCommand.ExecuteReader
                    Do While objReader.Read
                        Select Case objReader(0).ToString.ToUpper
                            Case "CC" 'Credit card
                                dblCreditCard += CType(objReader(1), Double)
                            Case "CS" 'Cash
                                dblCash += CType(objReader(1), Double)
                            Case "BN" 'Bank
                                dblBank += CType(objReader(1), Double)
                            Case "CQ" 'Cheque
                                dblCheque += CType(objReader(1), Double)
                            Case "RP" 'Recompense
                                dblRecompense += CType(objReader(1), Double)
                        End Select
                    Loop
                End Using
            End Using
            objConnection.Close()
        End Using

        Dim myFont As New Font("NewFont", 10, FontStyle.Bold)

        Dim lsvItem As ListViewItem = lswSalesInfo.Items.Add("Cash")
        lsvItem.SubItems.Add(Format(dblCash, "n").ToString)

        lsvItem = lswSalesInfo.Items.Add("Cheque")
        lsvItem.SubItems.Add(Format(dblCheque, "n"))

        Dim lsvItem_Totals As ListViewItem = lsvTotals.Items.Add("Total Cash On Hand")
        lsvItem_Totals.SubItems.Add(Format(dblCash + dblCheque, "n"))
        lsvItem_Totals.Font = myFont

        lsvItem = lswSalesInfo.Items.Add("Credit Card")
        lsvItem.SubItems.Add(Format(dblCreditCard, "n"))

        lsvItem = lswSalesInfo.Items.Add("Bank")
        lsvItem.SubItems.Add(Format(dblBank, "n"))

        lsvItem_Totals = lsvTotals.Items.Add("Total Receivable")
        lsvItem_Totals.SubItems.Add(Format(dblCreditCard + dblBank, "n"))
        lsvItem_Totals.Font = myFont

        lsvItem_Totals = lsvTotals.Items.Add("Recompense")
        lsvItem_Totals.SubItems.Add(Format(dblRecompense, "n"))
        lsvItem_Totals.Font = myFont

        lswSalesInfo.Columns(0).Width = 166
        lswSalesInfo.Columns(0).TextAlign = HorizontalAlignment.Right
        lswSalesInfo.Columns(1).Width = 203
        lswSalesInfo.Columns(1).TextAlign = HorizontalAlignment.Right

        lsvTotals.Columns(0).Width = 166
        lsvTotals.Columns(0).TextAlign = HorizontalAlignment.Right
        lsvTotals.Columns(1).Width = 203
        lsvTotals.Columns(1).TextAlign = HorizontalAlignment.Right

        dblTotalSales = dblCash + dblBank + dblCreditCard + dblCheque + dblRecompense
        txtTotal.Text = Format(dblTotalSales, "n")
        dblTurnOver = dblCash + dblCheque
        txtTurnOver.Text = Format(dblCash + dblCheque, "n")

    End Sub

    Private Function ThereAreInputErrors() As Boolean

        If Trim(txtCashOut.Text) = String.Empty Then
            Msg("1000", , "Cannot log out until the required information is specified")
            txtCashOut.SelectAll()
            txtCashOut.Focus()
            Return True
            Exit Function
        End If

        'Check Cash Out
        If Not IsNumeric(txtCashOut.Text) Then
            Msg("1001", , "A numeric value is required")
            txtCashOut.SelectAll()
            txtCashOut.Focus()
            Return True
            Exit Function
        Else
            If CType(txtCashOut.Text, Double) < 0 Then
                Msg("1001", , "A positive value is required")
                txtCashOut.SelectAll()
                txtCashOut.Focus()
                Return True
                Exit Function
            End If

            If CType(txtCashOut.Text, Double) > CType(lvwSummary.Items(9).SubItems(1).Text, Double) Then
                Msg("1025")
                txtCashOut.SelectAll()
                txtCashOut.Focus()
                Return True
                Exit Function
            End If

        End If

        Return False

    End Function

#End Region

#Region "Command Buttons"

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        If radLogOutAndEndShift.Checked = True Or DatabaseUser.ToUpper = "DEFAULT1000" Or DatabaseUser.ToUpper = "DEFAULT1001" Or DatabaseUser.ToUpper = "DEFAULT1002" Then
            If ThereAreInputErrors() Then Exit Sub

            If UserPrivilege <> Privilege.query Then
                If Msg("1024", Button.YesNo, "This will end and finalize the shift. Are you sure?") = ButtonClicked.No Then Exit Sub

                Using objConnection As SqlConnection = SetUpConnection(DatabasePath(), True)
                    objConnection.Open()
                    Using objTransaction As SqlTransaction = objConnection.BeginTransaction
                        Using objCommand As SqlCommand = objConnection.CreateCommand
                            With objCommand
                                .Transaction = objTransaction

                                Try
                                    If UserPrivilege <> Privilege.query Then
                                        .CommandText = "INSERT INTO SHIFT_INFO (LNo, SIAmtTurnOver, SITotalAmtCollected, SIAmtReceivable, SICashOnHand, SICashOut, SIRemarks, SICash, SICheque, SIBank, SICCard, SIRecompense) " & _
                                                       "VALUES (@LNo, @SIAmtTurnOver, @SITotalAmtCollected, @SIAmtReceivable, @SICashOnHand, @SICashOut, @SIRemarks, @SICash, @SICheque, @SIBank, @SICCard, @SIRecompense)"

                                        '0 cash, 1 cheque, 2 credit card, 3 bank,  
                                        '0 cashonhand, 1 totalreceivable,2 recompense
                                        With .Parameters
                                            .AddWithValue("@LNo", LogNo())
                                            .AddWithValue("@SIAmtTurnOver", txtTurnOver.Text).SqlDbType = SqlDbType.Money
                                            .AddWithValue("@SITotalAmtCollected", txtTotal.Text).SqlDbType = SqlDbType.Money
                                            .AddWithValue("@SIAmtReceivable", lsvTotals.Items(1).SubItems(1).Text).SqlDbType = SqlDbType.Money
                                            .AddWithValue("@SICashOnHand", lsvTotals.Items(0).SubItems(1).Text).SqlDbType = SqlDbType.Money
                                            .AddWithValue("@SICashOut", txtCashOut.Text).SqlDbType = SqlDbType.Money
                                            .AddWithValue("@SIRemarks", TrimAll(txtRemarks.Text))
                                            .AddWithValue("@SICash", lswSalesInfo.Items(0).SubItems(1).Text).SqlDbType = SqlDbType.Money
                                            .AddWithValue("@SICheque", lswSalesInfo.Items(1).SubItems(1).Text).SqlDbType = SqlDbType.Money
                                            .AddWithValue("@SIBank", lswSalesInfo.Items(3).SubItems(1).Text).SqlDbType = SqlDbType.Money
                                            .AddWithValue("@SICCard", lswSalesInfo.Items(2).SubItems(1).Text).SqlDbType = SqlDbType.Money
                                            .AddWithValue("@SIRecompense", lsvTotals.Items(2).SubItems(1).Text).SqlDbType = SqlDbType.Money
                                            .AddWithValue("@LTimeOut", Date.Now)
                                        End With

                                        .ExecuteNonQuery()

                                        .CommandText = "UPDATE SYSTEM SET TotalCashInFD=TotalCashInFD - @SICashOut"
                                        .ExecuteNonQuery()

                                    End If

                                    .CommandText = "UPDATE LOG_INFO SET LTimeOut=@LTimeOut, LStat='END' WHERE LNo=@LNo"
                                    .Parameters.Clear()
                                    .Parameters.AddWithValue("@LTimeOut", Date.Now)
                                    .Parameters.AddWithValue("@LNo", LogNo())
                                    .ExecuteNonQuery()

                                    objTransaction.Commit()
                                    Application.Restart()

                                Catch ex As Exception
                                    objTransaction.Rollback()
                                    Msg("1008", , NWLN & ex.Message)
                                    Exit Sub
                                End Try
                            End With
                        End Using
                    End Using
                    objConnection.Close()
                End Using
            Else
                If Msg("1034", Button.YesNo) = ButtonClicked.No Then Exit Sub
                Application.Restart()
            End If
        Else 'Resume
            If Msg("1034", Button.YesNo) = ButtonClicked.No Then
                Exit Sub
            Else
                Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
                    objConnection.Open()
                    Using objTransaction As SqlTransaction = objConnection.BeginTransaction
                        Using objCommand As SqlCommand = objConnection.CreateCommand
                            With objCommand
                                .Transaction = objTransaction

                                Try
                                    .CommandText = "UPDATE LOG_INFO SET LTimeOut=@LTimeOut, LStat='RESUME' WHERE LNo=@LNo"
                                    .Parameters.Clear()
                                    .Parameters.AddWithValue("@LTimeOut", Date.Now)
                                    .Parameters.AddWithValue("@LNo", LogNo())
                                    .ExecuteNonQuery()

                                    objTransaction.Commit()
                                Catch ex As Exception

                                    objTransaction.Rollback()
                                    Msg("1008", Button.Ok, ex.Message)
                                    Exit Sub

                                End Try

                            End With
                        End Using
                    End Using
                    objConnection.Close()
                End Using
                Application.Restart()
            End If
        End If

        
    End Sub

#End Region

#Region "MISC"

    Private Sub frmLogout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If UserPrivilege = Privilege.query Then
            Me.Height = 316
            radLogOut.Enabled = False
            radLogOutAndEndShift.Enabled = False
            radLogOut.Visible = False
            radLogOutAndEndShift.Visible = False
            radLogOutAndEndShift.Checked = True
            gbxEndShiftInformation.Visible = False
            OK.Top = 247
            OK.Text = "Log Out"
            Cancel.Top = 247
        Else
            Me.Height = 472
            radLogOut.Enabled = True
            radLogOutAndEndShift.Enabled = True
            radLogOut.Visible = True
            radLogOutAndEndShift.Visible = True
            gbxEndShiftInformation.Visible = True
            OK.Top = 405
            Cancel.Top = 405
        End If

        Me.StartPosition = FormStartPosition.CenterScreen

        Me.Text = "Log out at SLU Hotel: " & GetHotelName()
        txtTime.Text = Format(Date.Now, "MMMM dd, yyyy hh:mm:ss tt")

        lvwSummary.Items.Clear()
        lswSalesInfo.Items.Clear()
        lsvTotals.Items.Clear()

        DisplayShiftInfo()
        DisplaySalesInfo()

    End Sub

    Private Sub radLogOutAndEndShift_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radLogOutAndEndShift.CheckedChanged
        gbxEndShiftInformation.Enabled = radLogOutAndEndShift.Checked
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        txtTime.Text = Format(Date.Now, "MMMM dd, yyyy hh:mm:ss tt")
    End Sub

#End Region

End Class

