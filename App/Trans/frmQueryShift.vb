Option Explicit On
Option Strict On

Imports System.Data
Imports System.Data.SqlClient

' Programmer:   Mark Andrew O. Rivera
' Date:         April 05, 2007
' Title:        frmQueryShift
' Purpose:      It determines the different logs of guest even if he already ended his logs.
'               The manager can review the logs and the total sales during the guest's stay at the front desk
' Messagebox Done:

Public Class frmQueryShift

    Private dvDataView As New DataView
    Private objAdapter As SqlDataAdapter
    Private objDataSet As DataSet

#Region "Login"
    '0 Login ID
    '1 EMP ID
    '2 EMP Name
    '3 Log In Time
    '4 Log Out Time
    '5 Total Hours
    '6 Position
    '7 Access Type
    '8 Shift ID
    Sub ShowLogins()
        If dgvShifts.SelectedRows.Count > 0 Then
            Dim txtTo As String = Format(dtpTo.Value, "MM/dd/yyyy hh:mm:ss tt")
            Dim txtFrom As String = Format(dtpFrom.Value, "MM/dd/yyyy hh:mm:ss tt")

            If txtFDOName.Text = "" Then
                ListItems(DatabasePath(), "SELECT LOG_INFO.LNo AS [Log No], EMPLOYEE.EID AS [Employee ID], ISNULL(EMPLOYEE.ELName, '') + ', ' + ISNULL(EMPLOYEE.EFName, '')  " & _
                                          "+ ' ' + ISNULL(EMPLOYEE.EMI, '') AS Employee, LOG_INFO.LTimeIn AS [Time In], LOG_INFO.LTimeOut AS [Time Out], DATEDIFF(Hour,  " & _
                                          "LOG_INFO.LTimeIn, LOG_INFO.LTimeOut) AS [Hours Worked At Hotel], EMPLOYEE.EPosition AS Position, EMPLOYEE.EUserType AS [Access Type],  " & _
                                          "LOG_INFO.ShiftID AS [Shift No] " & _
                                          "FROM LOG_INFO INNER JOIN " & _
                                          "EMPLOYEE ON LOG_INFO.EID = EMPLOYEE.EID " & _
                                          "GROUP BY LOG_INFO.LNo, EMPLOYEE.EID, ISNULL(EMPLOYEE.ELName, '') + ', ' + ISNULL(EMPLOYEE.EFName, '') + ' ' + ISNULL(EMPLOYEE.EMI, ''),  " & _
                                          "LOG_INFO.LTimeIn, LOG_INFO.LTimeOut, DATEDIFF(Hour, LOG_INFO.LTimeIn, LOG_INFO.LTimeOut), EMPLOYEE.EPosition, EMPLOYEE.EUserType,  " & _
                                          "LOG_INFO.ShiftID   " & _
                                          "HAVING (LOG_INFO.ShiftID = '" & dgvShifts.Item(0, dgvShifts.CurrentRow.Index).Value.ToString & "') AND (LOG_INFO.LTimeIn BETWEEN '" & txtFrom & "' AND '" & txtTo & "')", dgvFDOLogins)
            Else
                ListItems(DatabasePath(), "SELECT LOG_INFO.LNo AS [Log No], EMPLOYEE.EID AS [Employee ID], ISNULL(EMPLOYEE.ELName, '') + ', ' + ISNULL(EMPLOYEE.EFName, '')  " & _
                                          "                      + ' ' + ISNULL(EMPLOYEE.EMI, '') AS Employee, LOG_INFO.LTimeIn AS [Time In], LOG_INFO.LTimeOut AS [Time Out], DATEDIFF(Hour,  " & _
                                          "                      LOG_INFO.LTimeIn, LOG_INFO.LTimeOut) AS [Hours Worked At Hotel], EMPLOYEE.EPosition AS Position, EMPLOYEE.EUserType AS [Access Type],  " & _
                                          "                      LOG_INFO.ShiftID AS [Shift No] " & _
                                          "FROM LOG_INFO INNER JOIN " & _
                                          "                      EMPLOYEE ON LOG_INFO.EID = EMPLOYEE.EID " & _
                                          "WHERE     (LOG_INFO.ShiftID = '" & dgvShifts.Item(0, dgvShifts.CurrentRow.Index).Value.ToString & "') AND  " & _
                                          "                      (EMPLOYEE.EFName LIKE '" & txtFDOName.Text & "%') AND (LOG_INFO.LTimeIn BETWEEN '" & txtFrom & "' AND '" & txtTo & "') OR " & _
                                          "                      (LOG_INFO.ShiftID = '" & dgvShifts.Item(0, dgvShifts.CurrentRow.Index).Value.ToString & "') AND (EMPLOYEE.EMI LIKE '" & txtFDOName.Text & "%') AND (LOG_INFO.LTimeIn BETWEEN '" & txtFrom & "' AND '" & txtTo & "') OR " & _
                                          "                      (LOG_INFO.ShiftID = '" & dgvShifts.Item(0, dgvShifts.CurrentRow.Index).Value.ToString & "') AND  " & _
                                          "                      (EMPLOYEE.ELName LIKE '" & txtFDOName.Text & "%') AND (LOG_INFO.LTimeIn BETWEEN '" & txtFrom & "' AND '" & txtTo & "') OR " & _
                                          "                      (LOG_INFO.ShiftID = '" & dgvShifts.Item(0, dgvShifts.CurrentRow.Index).Value.ToString & "') AND (EMPLOYEE.EID LIKE '" & txtFDOName.Text & "%') AND (LOG_INFO.LTimeIn BETWEEN '" & txtFrom & "' AND '" & txtTo & "')", dgvFDOLogins)
            End If
        End If
    End Sub

    Private Sub txtFDOName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFDOName.TextChanged
        ShowLogins()
    End Sub

    Private Sub dgvFDOLogins_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvFDOLogins.SelectionChanged
        If dgvFDOLogins.SelectedRows.Count > 0 Then
            lblFDO.Text = dgvFDOLogins.SelectedRows(0).Cells(2).Value.ToString
            lblLogIn.Text = dgvFDOLogins.SelectedRows(0).Cells(3).Value.ToString
            lblLogOut.Text = dgvFDOLogins.SelectedRows(0).Cells(4).Value.ToString

            Using objDatabaseConnection As SqlConnection = SetUpConnection(DatabasePath, True)
                '0 SIAmtTurnOver
                '1 SITotalAmtCollected
                '2 SIAmtReceivable
                '3 SICashOut
                '4 SICashOnHand 
                '5 SICash
                '6 SICheque
                '7 SIBank
                '8 SICCard
                '9 SIRemarks

                objAdapter = New SqlDataAdapter("SELECT SIAmtTurnOver, SITotalAmtCollected, SIAmtReceivable, SICashOut, SICashOnHand, SICash, SICheque, SIBank, SICCard, SIRemarks FROM SHIFT_INFO WHERE LNo = '" & dgvFDOLogins.SelectedRows(0).Cells(0).Value.ToString & "' ", objDatabaseConnection)
                objDataSet = SetUpDataSet(objAdapter, "qryLogin")
                dvDataView = New DataView(objDataSet.Tables("qryLogin"))
                If dvDataView.Table.Rows.Count > 0 Then
                    txtLoginRemarks2.Text = dvDataView.Table.Rows(0).Item(9).ToString
                    txtTurnOver.Text = Format(dvDataView.Table.Rows(0).Item(0), "n")
                    txtTotal.Text = Format(dvDataView.Table.Rows(0).Item(1), "n")
                    txtReceivable.Text = Format(dvDataView.Table.Rows(0).Item(2), "n")
                    txtCashOut.Text = Format(dvDataView.Table.Rows(0).Item(3), "n")
                    txtOnHand.Text = Format(dvDataView.Table.Rows(0).Item(4), "n")
                    txtCash.Text = Format(dvDataView.Table.Rows(0).Item(5), "n")
                    txtCheque.Text = Format(dvDataView.Table.Rows(0).Item(6), "n")
                    txtBank.Text = Format(dvDataView.Table.Rows(0).Item(7), "n")
                    txtCreditCard.Text = Format(dvDataView.Table.Rows(0).Item(8), "n")
                    Dim total As Double = CType(dvDataView.Table.Rows(0).Item(1).ToString, Double)
                    Dim onhand As Double = CType(dvDataView.Table.Rows(0).Item(4).ToString, Double)
                    Dim receivable As Double = CType(dvDataView.Table.Rows(0).Item(2).ToString, Double)
                    txtRecompense.Text = Format((total - onhand - receivable), "n")
                Else
                    txtTurnOver.Text = "0"
                    txtTotal.Text = "0"
                    txtReceivable.Text = "0"
                    txtCashOut.Text = "0"
                    txtOnHand.Text = "0"
                    txtCash.Text = "0"
                    txtCheque.Text = "0"
                    txtBank.Text = "0"
                    txtCreditCard.Text = "0"
                    txtRecompense.Text = "0"
                End If
            End Using
        Else
            txtLoginRemarks2.Text = ""
            lblLogIn.Text = ""
            lblLogOut.Text = ""
            txtTurnOver.Text = "0"
            txtTotal.Text = "0"
            txtReceivable.Text = "0"
            txtCashOut.Text = "0"
            txtOnHand.Text = "0"
            txtCash.Text = "0"
            txtCheque.Text = "0"
            txtBank.Text = "0"
            txtCreditCard.Text = "0"
            txtRecompense.Text = "0"
        End If
    End Sub

    Private Sub dtpFrom_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFrom.ValueChanged
        dtpTo.MinDate = dtpFrom.Value
        ShowLogins()
    End Sub

    Private Sub dtpTo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpTo.ValueChanged
        dtpFrom.MaxDate = dtpTo.Value
        ShowLogins()
    End Sub
#End Region

#Region "Shift"
    '0 Shift ID
    '1 Shift Name
    '2 Time Start
    '3 Time End
    '4 Status
    '5 Remarks

    Sub ShowShift()
        ListItems(DatabasePath(), "SELECT ShiftId AS [Shift No], ShiftName AS [Shift Name], " & _
                                                 "CONVERT(char(2), {fn HOUR(ShiftTimeStart)}) + ':' + CONVERT(char(2),{fn MINUTE(ShiftTimeStart)}) AS [Start Time], " & _
                                                 "CONVERT(char(2), {fn HOUR(ShiftTimeEnd)}) + ':' + CONVERT(char(2),{fn MINUTE(ShiftTimeEnd)}) AS [End Time], " & _
                                                 "ShiftStat AS Status, ShiftRemarks AS Remarks FROM SHIFT ", dgvShifts)
    End Sub

    Private Sub dgvFDOShifts_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvShifts.SelectionChanged
        If dgvShifts.SelectedRows.Count > 0 Then
            lblShiftName.Text = dgvShifts.SelectedRows(0).Cells(1).Value.ToString
            txtShiftRemarks.Text = dgvShifts.SelectedRows(0).Cells(5).Value.ToString
            ShowLogins()
        Else
            lblShiftName.Text = "N/A"
            txtShiftRemarks.Text = ""
        End If
    End Sub
#End Region

#Region "Tab"
    Private Sub tsbRoomStatusQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbRoomStatusQuery.Click
        Display(Forms.frmQueryRMStat)
    End Sub

    Private Sub tsbSettingsQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSettingsQuery.Click
        Display(Forms.frmQuerySettings)
    End Sub
#End Region

#Region "MISC"

    Private Sub frmQueryShift_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        dgvFDOLogins.AlternatingRowsDefaultCellStyle = SetAlternatingColor()
        dgvShifts.AlternatingRowsDefaultCellStyle = SetAlternatingColor()

        dtpFrom.Value = DateAdd(DateInterval.Year, -1, Date.Now)
        dtpTo.Value = Date.Now
        dtpFrom.MaxDate = dtpTo.Value
        dtpTo.MinDate = dtpFrom.Value
        ShowShift()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Try
            Dim strFilePath As String = System.IO.Path.Combine(My.Settings.ReceiptLocation, lblFDO.Text.ToUpper & "-" & Format(Date.Now, "MMMM-dd-yyyy-hhmmss") & ".txt")

            Dim strContent As String = "SAINT LOUIS UNIVERSITY HOTEL" & NWLN & _
                                       GetHotelName().ToUpper & NWLN & _
                                       "BAGUIO CITY" & NWLN & NWLN & _
                                       "Shift: " & lblShiftName.Text & NWLN & _
                                       "Front Desk Officer: " & lblFDO.Text & NWLN & NWLN & _
                                       "Log In: " & lblLogIn.Text & NWLN & _
                                       "Log Out: " & lblLogOut.Text & NWLN & NWLN & _
                                       "       Total Cash: " & txtCash.Text & NWLN & _
                                       "     Total Cheque: " & txtCheque.Text & NWLN & _
                                       "                   _______________" & NWLN & _
                                       "          On Hand: " & txtOnHand.Text & NWLN & _
                                       "       Recompense: " & txtRecompense.Text & NWLN & _
                                       "       Total Bank: " & txtBank.Text & NWLN & _
                                       "Total Credit Card: " & txtCreditCard.Text & NWLN & _
                                       "                   _______________" & NWLN & _
                                       " Total Receivable: " & txtReceivable.Text & NWLN & _
                                       "                   _______________" & NWLN & _
                                       "      Total Sales: " & txtTotal.Text & NWLN & _
                                       "         Cash Out: " & txtCashOut.Text & NWLN & _
                                       "        Turn over: " & txtTurnOver.Text & NWLN & NWLN & _
                                       "Remarks:" & NWLN & txtLoginRemarks2.Text

            My.Computer.FileSystem.WriteAllText(strFilePath, strContent, False)

            frmPrint.lblTitle.Text = "Query Shift"
            frmPrint.txtFile.Text = String.Empty
            frmPrint.btnOpen.Enabled = False
            frmPrint.FillMe(strFilePath, "Print Shift Query")
            frmPrint.ShowDialog()

            My.Computer.FileSystem.DeleteFile(strFilePath)

        Catch ex As Exception
            Msg("1019") 'error in printing
        End Try
    End Sub

    Private Sub llbClose_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llbClose.LinkClicked
        Me.Close()
    End Sub
#End Region

End Class