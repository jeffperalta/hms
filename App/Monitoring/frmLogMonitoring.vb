Option Explicit On
Option Strict On

Imports System.Data
Imports System.Data.SqlClient

' Programmer:   Jo Jefferson D. Peralta
' Date:         March 06, 2007
' Title:        frmLogMonitoring
' Purpose:      The hotel manager uses this interface to end the logs within a shift. 
'               Although users can end their own logs. However it is possible that users where
'               not able to end their log on time maybe because of power failures or simply they forgot 
'               to log out and end the shift before the next shift starts.
'               The manager can monitor the log ins in a shift and determine the total sales for a single log no.
' Requirements: ->  (+) SHIFT_INFO(LNo, SIAmtTurnOver, SITotalAmtCollected, SIAmtReceivable, SICashOnHand, SICashOut, SIRemarks, SICashOut, SIRemarks, SICash, SICheque, SIBank, SICard)
'               ->  (*) LOG_INFO(LStat)
'               ->  Displays all the logs in a shift except the current logno
'                   A current log is encourage to end at the log out interface
'               ->  The manager can modify the cashout and amount turnover.
'               ->  Total On Hand =  CASH + CHEQUE
'               ->  Total Receivable = BANK + CREDIT CARD
'               ->  Total Recompense are payments from refunds
'               ->  Total Sales = TotalOnHand + TotalReceivable + TotaRecompense
'               ->  Amount Turnover = TotalSales - Cashout
' Results:      ->  A log is ended (LStat='END')
'               ->  Financial summary is saved.
'               ->  If the user would like to see the financial summary of all logs
'                   The application provides a report for this information
'Message>>> Done
Public Class frmLogMonitoring

    Private dblTurnOver As Double = 0.0

#Region "Functions/Subroutines"

    Private Sub DisplayShift()

        'lblCountShift.Text = ListItems(DatabasePath(), "SELECT ShiftID AS [Shift No], ShiftName AS [Shift Name], ShiftTimeStart AS [Time Start], " & _
        '                                               "       ShiftTimeEnd AS [Time End], ShiftStat as Status, ShiftRemarks AS Remarks " & _
        '                                               "FROM   SHIFT", dgvShift).ToString()
        lblCountShift.Text = ListItems(DatabasePath, "SELECT ShiftId AS [Shift No], ShiftName AS [Shift Name], " & _
                                                     "CONVERT(char(2), {fn HOUR(ShiftTimeStart)}) + ':' + CONVERT(char(2),{fn MINUTE(ShiftTimeStart)}) AS [Start Time], " & _
                                                     "CONVERT(char(2), {fn HOUR(ShiftTimeEnd)}) + ':' + CONVERT(char(2),{fn MINUTE(ShiftTimeEnd)}) AS [End Time], " & _
                                                     "ShiftStat AS Status, ShiftRemarks AS Remarks FROM SHIFT " & _
                                                     "ORDER BY ShiftID ", dgvShift).ToString

        For intCtr As Integer = 0 To dgvShift.Rows.Count - 1
            Dim strTime() As String = Split(dgvShift.Item(2, intCtr).Value.ToString, ":")

            If Trim(strTime(0)).Length = 1 Then
                strTime(0) = "0" & strTime(0)
            End If

            If Trim(strTime(1)).Length = 1 Then
                strTime(1) = "0" & strTime(1)
            End If

            dgvShift.Item(2, intCtr).Value = Trim(strTime(0)) & ":" & Trim(strTime(1))


            strTime = Split(dgvShift.Item(3, intCtr).Value.ToString, ":")

            If Trim(strTime(0)).Length = 1 Then
                strTime(0) = "0" & strTime(0)
            End If

            If Trim(strTime(1)).Length = 1 Then
                strTime(1) = "0" & strTime(1)
            End If

            dgvShift.Item(3, intCtr).Value = Trim(strTime(0)) & ":" & Trim(strTime(1))

        Next

    End Sub

    Private Sub DisplayLogs()
        If dgvShift.SelectedRows.Count > 0 Then
            lblNumberOfEmployee.Text = ListItems(DatabasePath(), "SELECT LOG_INFO.LNo AS [Log No], EMPLOYEE.EID AS [Employee ID], ISNULL(EMPLOYEE.ELName, '') + ', ' + ISNULL(EMPLOYEE.EFName, '') " & _
                                                                 "       + ' ' + ISNULL(EMPLOYEE.EMI, '') AS EMPLOYEE, LOG_INFO.LTimeIn AS [Time In], DATEDIFF(Hour, LOG_INFO.LTimeIn, { fn NOW() })  " & _
                                                                 "       AS [Hours Worked At Hotel], COUNT(PAYMENT.PID) AS [Payment Serviced], ISNULL(SUM(PAYMENT.PAmt), '0') AS [Total Payment Received],  " & _
                                                                 "       ISNULL(SUM(REFUND.RefAmt), '0') AS [Total Refund Created], EMPLOYEE.EPosition AS Position, EMPLOYEE.EUserType AS [Access Type],  " & _
                                                                 "       LOG_INFO.ShiftID " & _
                                                                 "FROM   LOG_INFO INNER JOIN " & _
                                                                 "       EMPLOYEE ON LOG_INFO.EID = EMPLOYEE.EID LEFT OUTER JOIN " & _
                                                                 "       REFUND ON LOG_INFO.LNo = REFUND.LNo LEFT OUTER JOIN " & _
                                                                 "       PAYMENT ON LOG_INFO.LNo = PAYMENT.LNo " & _
                                                                 "WHERE  (LOG_INFO.LStat = 'RESUME') AND LOG_INFO.LNo <> '" & LogNo() & "' " & _
                                                                 "GROUP BY LOG_INFO.LNo, EMPLOYEE.EID, ISNULL(EMPLOYEE.ELName, '') + ', ' + ISNULL(EMPLOYEE.EFName, '') + ' ' + ISNULL(EMPLOYEE.EMI, ''),  " & _
                                                                 "       LOG_INFO.LTimeIn, DATEDIFF(Hour, LOG_INFO.LTimeIn, { fn NOW() }), EMPLOYEE.EPosition, EMPLOYEE.EUserType, LOG_INFO.ShiftID " & _
                                                                 "HAVING (LOG_INFO.ShiftID = '" & dgvShift.Item(0, dgvShift.CurrentRow.Index).Value.ToString & "')", dgvEmployee).ToString()
        End If
    End Sub

    Private Function ThereAreInputErrors() As Boolean

        If Trim(txtCashOut.Text) = String.Empty Then
            Msg("1000")
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


            If CType(txtCashOut.Text, Double) > CType(lblCashAtFrontDesk.Text, Double) Then
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

    Private Sub btnEndLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEndLog.Click

        If dgvEmployee.SelectedRows.Count = 0 Then
            Msg("1005")
            Exit Sub
        End If

        If ThereAreInputErrors() Then Exit Sub
        If Msg("1026", Button.YesNo) = ButtonClicked.No Then Exit Sub

        Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
            objConnection.Open()
            Using objTransaction As SqlTransaction = objConnection.BeginTransaction
                Using objCommand As SqlCommand = objConnection.CreateCommand
                    With objCommand
                        .Transaction = objTransaction


                        .CommandText = "INSERT INTO SHIFT_INFO (LNo, SIAmtTurnOver, SITotalAmtCollected, SIAmtReceivable, SICashOnHand, SICashOut, SIRemarks, SICash, SICheque, SIBank, SICCard, SIRecompense) " & _
                                       "VALUES (@LNo, @SIAmtTurnOver, @SITotalAmtCollected, @SIAmtReceivable, @SICashOnHand, @SICashOut, @SIRemarks, @SICash, @SICheque, @SIBank, @SICCard, @SIRecompense)"

                        With .Parameters
                            .AddWithValue("@LNo", dgvEmployee.Item(0, dgvEmployee.CurrentRow.Index).Value.ToString)
                            .AddWithValue("@SIAmtTurnOver", txtTurnOver.Text).SqlDbType = SqlDbType.Money
                            .AddWithValue("@SITotalAmtCollected", txtTotal.Text).SqlDbType = SqlDbType.Money
                            .AddWithValue("@SIAmtReceivable", txtReceivable.Text).SqlDbType = SqlDbType.Money
                            .AddWithValue("@SICashOnHand", txtOnHand.Text).SqlDbType = SqlDbType.Money
                            .AddWithValue("@SICashOut", txtCashOut.Text).SqlDbType = SqlDbType.Money
                            .AddWithValue("@SIRemarks", TrimAll(txtRemarks.Text))
                            .AddWithValue("@SICash", txtCash.Text).SqlDbType = SqlDbType.Money
                            .AddWithValue("@SICheque", txtCheque.Text).SqlDbType = SqlDbType.Money
                            .AddWithValue("@SIBank", txtBank.Text).SqlDbType = SqlDbType.Money
                            .AddWithValue("@SICCard", txtCreditCard.Text).SqlDbType = SqlDbType.Money
                            .AddWithValue("@LTimeOut", Date.Now)
                            .AddWithValue("@SIRecompense", txtRecompense.Text).SqlDbType = SqlDbType.Money
                        End With

                        Try

                            .ExecuteNonQuery()

                            .CommandText = "UPDATE LOG_INFO SET LTimeOut=@LTimeOut, LStat='END' WHERE LNo=@LNo"
                            .ExecuteNonQuery()

                            .CommandText = "UPDATE SYSTEM SET TotalCashInFD=TotalCashInFD - @SICashOut"
                            .ExecuteNonQuery()

                            objTransaction.Commit()
                            DisplayLogs()

                            frmParent.tssStatus.Text = "The log was ended..."

                        Catch ex As Exception

                            objTransaction.Rollback()
                            Msg("1008", , ex.Message)

                        End Try

                    End With
                End Using
            End Using
            objConnection.Close()
        End Using

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

#End Region

#Region "MISC"

    Private Sub frmLogMonitoring_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
            objConnection.Open()
            Using objCommand As SqlCommand = New SqlCommand("SELECT TotalCashInFD FROM SYSTEM", objConnection)
                lblCashAtFrontDesk.Text = objCommand.ExecuteScalar.ToString
            End Using
            objConnection.Close()
        End Using

        DisplayShift()
        dgvShift.AlternatingRowsDefaultCellStyle = SetAlternatingColor()
        dgvEmployee.AlternatingRowsDefaultCellStyle = SetAlternatingColor()
    End Sub

    Private Sub dgvShift_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvShift.SelectionChanged
        DisplayLogs()
    End Sub

    Private Sub dgvEmployee_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvEmployee.SelectionChanged

        If dgvEmployee.SelectedRows.Count > 0 Then

            frmParent.tssStatus.Text = ""
            txtCash.Text = "0.00"
            txtCreditCard.Text = "0.00"
            txtBank.Text = "0.00"
            txtCheque.Text = "0.00"
            txtRecompense.Text = "0.00"
            txtCashOut.Text = "0.00"

            Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
                objConnection.Open()
                Using objCommand As SqlCommand = New SqlCommand("SELECT ISNULL(PAYMENT_TYPE_DETAILS.PTType,'NONE'), ISNULL(SUM(PAYMENT_TYPE_DETAILS.PTAmt), 0) AS Total " & _
                                                                "FROM   PAYMENT RIGHT OUTER JOIN " & _
                                                                "       PAYMENT_TYPE_DETAILS ON PAYMENT.PID = PAYMENT_TYPE_DETAILS.PID " & _
                                                                "WHERE  (PAYMENT.LNo = '" & dgvEmployee.Item(0, dgvEmployee.CurrentRow.Index).Value.ToString & "')  " & _
                                                                "GROUP BY PAYMENT_TYPE_DETAILS.PTType ", objConnection)

                    Using objReader As SqlDataReader = objCommand.ExecuteReader

                        Do While objReader.Read
                            Select Case objReader(0).ToString.ToUpper
                                Case "CC" 'Credit card
                                    txtCreditCard.Text = Format(CType(objReader(1), Double) + CType(txtCreditCard.Text, Double), "#,#.0000")
                                Case "CS" 'Cash
                                    txtCash.Text = Format(CType(objReader(1), Double) + CType(txtCash.Text, Double), "#,#.0000")
                                Case "BN" 'Bank
                                    txtBank.Text = Format(CType(objReader(1), Double) + CType(txtBank.Text, Double), "#,#.0000")
                                Case "CQ" 'Cheque
                                    txtCheque.Text = Format(CType(objReader(1), Double) + CType(txtCheque.Text, Double), "#,#.0000")
                                Case "RP" 'Recompense
                                    txtRecompense.Text = Format(CType(objReader(1), Double) + CType(txtRecompense.Text, Double), "#,#.0000")
                            End Select
                        Loop

                    End Using

                End Using
                objConnection.Close()
            End Using

            txtOnHand.Text = Format(CType(txtCash.Text, Double) + CType(txtCheque.Text, Double), "n")
            txtReceivable.Text = Format(CType(txtBank.Text, Double) + CType(txtCreditCard.Text, Double), "n")
            txtTotal.Text = Format(CType(txtOnHand.Text, Double) + CType(txtReceivable.Text, Double) + CType(txtRecompense.Text, Double), "n")
            txtTurnOver.Text = txtOnHand.Text
            dblTurnOver = CType(txtTurnOver.Text, Double)

            txtRemarks.SelectAll()
            txtRemarks.Focus()
        End If

    End Sub

    Private Sub lblClose_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblClose.LinkClicked
        Me.Close()
    End Sub

#End Region

#Region "Side Bar"

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Display(Forms.frmSystemShift)
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Display(Forms.frmSettings)
    End Sub

#End Region


End Class