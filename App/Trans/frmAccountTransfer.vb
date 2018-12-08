Option Explicit On
Option Strict On

Imports System.Data.SqlClient
Imports System.Data

' Programmer:   Howell Quindara
' Date:         March 18, 2007
' Title:        frmAccountTransfer
' Purpose:      This interface is use to transfer an account of a registered guest to another registered guest
' Requirements: ->  (+)FOLIO_DETAILS (FDNO, FDRECEIPTNO, FDDATE, FDCHARGE, FDMODIFIEDBYAMT, FDMODIFIEDBYPERCENT, FDMODIFIEDCHARGE, FDBALANCE, FDSTAT, REGNO, FDDESC, FDRemarks)
'               ->  (*)FOLIO_DETAILS (FDBALANCE, FDSTAT, FDModifiedByAmt, FDModifiedCharge, FDRemarks)
'               ->  (*)REGISTRATION (REGAMT,REGBALANCE)
'               ->  The guest holding the account
'               ->  The guest who will receive the account
'               ->  Both guest should have active registration or are not fully checked out
' Results:      ->  New charges for the receiver of the account
'               ->  The account of the guest holding the account may be paid or unpaid

Public Class frmAccountTransfer
    Private objAdapter As SqlDataAdapter
    Private objDataView As New DataView
    Private objDataSetGuestBill As DataSet
    Private objDataSetTransferTo As DataSet
    Private objDataTable As DataTable
    Private objDataRow As DataGridViewRow


    Private Sub btnGuestBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuestBill.Click

        TriggeredBy = TriggeringForm.AccountTransferFrom
        frmGuestSearch.ShowDialog()

    End Sub

    Public Sub FillGuestBill()

        lblGuestBillREGNO.Text = SearchedRegistrationNo


    End Sub

    Private Sub btnTransferredTo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransferredTo.Click

        TriggeredBy = TriggeringForm.AccountTransferTo
        frmGuestSearch.ShowDialog()

    End Sub

    Public Sub FillTransferTo()

        lblTransferToREGNO.Text = SearchedRegistrationNo

    End Sub

    Private Sub lblGuestBillREGNO_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblGuestBillREGNO.TextChanged

        If lblGuestBillREGNO.Text <> String.Empty Then

            If ActiveRegistration(lblGuestBillREGNO.Text.ToString) = False Then

                Msg("1050")

            Else

                Using objDatabaseConnection As SqlConnection = SetUpConnection(DatabasePath, True)

                    Try

                        objAdapter = New SqlDataAdapter("SELECT REGISTRATION_DETAILS.RMNo AS [Room No.], FOLIO_DETAILS.FDDesc AS [Description], FOLIO_DETAILS.FDDate AS [Date Incurred], FOLIO_DETAILS.FDServiceRep AS [Service Representative], FOLIO_DETAILS.FDCharge AS [Original Amount], FOLIO_DETAILS.FDModifiedCharge AS [Modified Charge], FOLIO_DETAILS.FDBalance AS [Balance], FOLIO_DETAILS.FDStat AS [Status], FOLIO_DETAILS.FDNo AS [Bill No.]" & _
                                                        "FROM FOLIO_DETAILS LEFT OUTER JOIN REGISTRATION_DETAILS ON FOLIO_DETAILS.RegDNo = REGISTRATION_DETAILS.RegDNo " & _
                                                        "WHERE (FOLIO_DETAILS.RegNo = '" & lblGuestBillREGNO.Text & "' AND (FOLIO_DETAILS.FDStat = 'UNPAID'))", objDatabaseConnection)
                        objDataSetGuestBill = SetUpDataSet(objAdapter, "qryFolio")
                        objDataView = New DataView(objDataSetGuestBill.Tables("qryFolio"))
                        dgvGuestBillInformation.DataSource = objDataView

                        lblTotalCharges.Text = "0"
                        lblTotalBalance.Text = "0"

                        For Each objDataRow In dgvGuestBillInformation.Rows

                            lblTotalCharges.Text = CDbl(CDbl(lblTotalCharges.Text) + CDbl(objDataRow.Cells(4).Value.ToString())).ToString
                            lblTotalBalance.Text = CDbl(CDbl(lblTotalBalance.Text) + CDbl(objDataRow.Cells(6).Value.ToString())).ToString

                        Next

                    Catch ex As Exception

                        Msg("1008", , "An error occured while loading the folio")
                        clearAccountTransfer()

                    End Try

                    Try

                        objAdapter = New SqlDataAdapter("SELECT GUEST_INFO.GIFName + ' ' + ISNULL(GUEST_INFO.GILName,'') AS Expr1, REGISTRATION.RegDate, REGISTRATION_DETAILS.RegDChkOutTime, GUEST_INFO.GIContact " & _
                                                        "FROM GUEST_INFO INNER JOIN GUEST ON GUEST_INFO.GIID = GUEST.GIID INNER JOIN REGISTRATION ON GUEST.GNo = REGISTRATION.GNo INNER JOIN REGISTRATION_DETAILS ON REGISTRATION.RegNo = REGISTRATION_DETAILS.RegNo " & _
                                                        "WHERE (REGISTRATION.RegNo = '" & lblGuestBillREGNO.Text & "') " & _
                                                        "ORDER BY REGISTRATION_DETAILS.RegDChkOutTime DESC", objDatabaseConnection)
                        objDataSetGuestBill = SetUpDataSet(objAdapter, "qryGuest")
                        lblGuestName.Text = objDataSetGuestBill.Tables("qryGuest").Rows(0).Item(0).ToString
                        lblCheckInDate.Text = objDataSetGuestBill.Tables("qryGuest").Rows(0).Item(1).ToString
                        lblCheckOutDate.Text = objDataSetGuestBill.Tables("qryGuest").Rows(0).Item(2).ToString
                        lblContactNo.Text = objDataSetGuestBill.Tables("qryGuest").Rows(0).Item(3).ToString
                        TextBox1.Text = "TRANSFERRED ACCOUNT FROM " & lblGuestName.Text.ToUpper & " TO " & lblTransferredToGuestName.Text.ToUpper

                    Catch ex As Exception

                        Msg("1008", , "An error occured while loading the guest bill info")
                        ClearAccountTransfer()

                    End Try

                End Using

            End If

        Else

            lblGuestName.Text = String.Empty
            lblCheckInDate.Text = String.Empty
            lblCheckOutDate.Text = String.Empty
            lblContactNo.Text = String.Empty

        End If

    End Sub

    Private Sub lblTransferToREGNO_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblTransferToREGNO.TextChanged

        If lblTransferToREGNO.Text <> String.Empty Then

            If ActiveRegistration(lblGuestBillREGNO.Text.ToString) = False Then

                Msg("1050")

            Else

                Using objDatabaseConnection As SqlConnection = SetUpConnection(DatabasePath, True)

                    Try

                        objAdapter = New SqlDataAdapter("SELECT GUEST_INFO.GIFName + ' ' + GUEST_INFO.GILName AS Expr1, REGISTRATION.RegDate, REGISTRATION_DETAILS.RegDChkOutTime, GUEST_INFO.GIContact " & _
                                                       "FROM GUEST_INFO INNER JOIN GUEST ON GUEST_INFO.GIID = GUEST.GIID INNER JOIN REGISTRATION ON GUEST.GNo = REGISTRATION.GNo INNER JOIN REGISTRATION_DETAILS ON REGISTRATION.RegNo = REGISTRATION_DETAILS.RegNo " & _
                                                       "WHERE (REGISTRATION.RegNo = '" & lblTransferToREGNO.Text & "') " & _
                                                       "ORDER BY REGISTRATION_DETAILS.RegDChkOutTime DESC", objDatabaseConnection)
                        objDataSetTransferTo = SetUpDataSet(objAdapter, "qryTransferTo")
                        lblTransferredToGuestName.Text = objDataSetTransferTo.Tables("qryTransferTo").Rows(0).Item(0).ToString
                        lblTransferredToCheckIn.Text = objDataSetTransferTo.Tables("qryTransferTo").Rows(0).Item(1).ToString
                        lblTransferredToCheckOut.Text = objDataSetTransferTo.Tables("qryTransferTo").Rows(0).Item(2).ToString
                        lblTransferredToContactNo.Text = objDataSetTransferTo.Tables("qryTransferTo").Rows(0).Item(3).ToString

                        TextBox1.Text = "TRANSFERRED ACCOUNT FROM " & lblGuestName.Text.ToUpper & " TO " & lblTransferredToGuestName.Text.ToUpper

                    Catch ex As Exception

                        Msg("1008", , "An error occured while loading the transfer to info" & NWLN & ex.Message)

                    End Try

                End Using

            End If

        Else

            lblTransferredToGuestName.Text = String.Empty
            lblTransferredToCheckIn.Text = String.Empty
            lblTransferredToCheckOut.Text = String.Empty
            lblTransferredToContactNo.Text = String.Empty

        End If

    End Sub

    Private Sub btnTransferAccout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransferAccout.Click

        If dgvGuestBillInformation.Rows.Count > 0 AndAlso dgvGuestBillInformation.SelectedRows.Count > 0 Then

            Dim blnRepeated As Boolean = False

            If dgvTransferredAccountInformation.Rows.Count > 0 Then

                For Each objDataRow In dgvTransferredAccountInformation.Rows

                    If dgvGuestBillInformation.Item(8, dgvGuestBillInformation.CurrentRow.Index).Value.ToString = objDataRow.Cells(9).Value.ToString Then

                        blnRepeated = True
                        Exit For

                    End If

                Next

            End If

            If lblGuestBillREGNO.Text = lblTransferToREGNO.Text Then

                Msg("1051", , NWLN & "Account transfer is not allowed to transfer the folio to the same person")

            ElseIf lblTransferToREGNO.Text = String.Empty Then

                Msg("1051", , NWLN & "No person to receive the account")

            ElseIf IsNumeric(txtAmountToBeTransferred.Text) = False Then

                Msg("1051", , NWLN & "Invalid input of amount")
                txtAmountToBeTransferred.SelectAll()
                txtAmountToBeTransferred.Focus()

            ElseIf CDbl(txtAmountToBeTransferred.Text) < 1 Then

                Msg("1051", , NWLN & "Invalid input of amount")
                txtAmountToBeTransferred.SelectAll()
                txtAmountToBeTransferred.Focus()

            ElseIf blnRepeated Then

                Msg("1051", , NWLN & "Record is already in the transferred account information ")

            ElseIf CDbl(txtAmountToBeTransferred.Text) > CDbl(dgvGuestBillInformation.SelectedRows(0).Cells(6).Value.ToString) Then

                Msg("1051", , NWLN & "Please input an amount less than or equals the folio balance")

            Else

                Dim dblBalance As Double = 0

                dblBalance = CDbl(CDbl(dgvGuestBillInformation.SelectedRows(0).Cells(6).Value.ToString) - CDbl(txtAmountToBeTransferred.Text))
                dgvTransferredAccountInformation.Rows.Add(dgvGuestBillInformation.SelectedRows(0).Cells(1).Value.ToString, _
                                    dgvGuestBillInformation.SelectedRows(0).Cells(2).Value.ToString, _
                                    dgvGuestBillInformation.SelectedRows(0).Cells(3).Value.ToString, _
                                    CDbl(dgvGuestBillInformation.SelectedRows(0).Cells(5).Value.ToString).ToString("n"), _
                                    CDbl(dblBalance.ToString).ToString("n"), _
                                    CDbl(txtAmountToBeTransferred.Text).ToString("n"), _
                                    lblGuestName.Text, _
                                    lblTransferredToGuestName.Text, _
                                    dtpDateTransferred.Value.ToShortDateString, _
                                    dgvGuestBillInformation.SelectedRows(0).Cells(8).Value.ToString)

            End If

        End If

    End Sub

    Private Sub llbClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClose.Click

        Me.Close()

    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click

        If dgvTransferredAccountInformation.Rows.Count > 0 Then

            dgvTransferredAccountInformation.Rows.Remove(dgvTransferredAccountInformation.SelectedRows(0))

        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

        ClearAccountTransfer()

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        AccountTransferSave()

    End Sub


    Private Sub tsbActGuestFolio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbActGuestFolio.Click

        Display(Forms.frmGuestFolio)

    End Sub

    Private Sub tsbActRmCharge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbActRmCharge.Click

        Display(Forms.frmUpdateRoomCharge)

    End Sub

    Private Sub tsbActAmnServ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbActAmnServ.Click

        Display(Forms.frmAmenitiesAndServices)

    End Sub

    Private Sub tsbActIncDec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbActIncDec.Click

        Display(Forms.frmModifyAmount)

    End Sub

    Private Sub tsbActGuestInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbActGuestInfo.Click

        Display(Forms.frmGuestInformation)

    End Sub

    Private Sub tsbActPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbActPayment.Click

        Display(Forms.frmPayment)

    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click

        Display(Forms.frmUncollectible)

    End Sub

    Private Sub AccountTransferSave()

        If dgvTransferredAccountInformation.Rows.Count < 1 Then

            Msg("1051", , "No guest account to be transferred")

        Else

            Using objReservationSaveConnection As SqlConnection = SetUpConnection(DatabasePath, True)

                If objReservationSaveConnection.State = ConnectionState.Closed Then objReservationSaveConnection.Open()

                Using objTransaction As SqlTransaction = objReservationSaveConnection.BeginTransaction

                    Using objCommand As SqlCommand = objReservationSaveConnection.CreateCommand

                        With objCommand

                            .Transaction = objTransaction

                            Try

                                For Each objDataRow In dgvTransferredAccountInformation.Rows

                                    .CommandText = "INSERT INTO FOLIO_DETAILS (FDNO, FDRECEIPTNO, FDDATE, FDCHARGE, FDMODIFIEDBYAMT, FDMODIFIEDBYPERCENT, FDMODIFIEDCHARGE, FDBALANCE, FDSTAT, REGNO, FDDESC, FDNAME, FDREMARKS) " & _
                                                   "VALUES ( '" & GetPrimaryKeyNo("FDNo") & " ', '" & GetPrimaryKeyNo("FDNo") & " ', '" & dtpDateTransferred.Value.ToShortDateString & "', '" & objDataRow.Cells(5).Value.ToString & "' , '0', '0', '" & objDataRow.Cells(5).Value.ToString & "', '" & objDataRow.Cells(5).Value.ToString & "' , 'UNPAID', '" & lblTransferToREGNO.Text & "', 'TRANSFER', 'TRANSFERED ACCOUNT', '" & TrimAll(TextBox1.Text, True) & "');"
                                    .ExecuteNonQuery()
                                    IncrementPrimaryKeyNo("FDNo")

                                    If CDbl(objDataRow.Cells(4).Value.ToString) = 0 Then

                                        .CommandText = "UPDATE FOLIO_DETAILS SET " & _
                                                       "FDModifiedBYAmt= -1 * FDCharge, " & _
                                                       "FDModifiedCharge='0', " & _
                                                       "FDBALANCE = '0', " & _
                                                       "FDSTAT = 'PAID', " & _
                                                       "FDREMARKS = FDREMARKS + '; " & TrimAll(TextBox1.Text, True) & "' " & _
                                                       "WHERE FDNO = '" & objDataRow.Cells(9).Value.ToString & "';"
                                        .ExecuteNonQuery()

                                    Else

                                        .CommandText = "UPDATE FOLIO_DETAILS SET " & _
                                                       "FDBALANCE = '" & objDataRow.Cells(4).Value.ToString & "', " & _
                                                       "FDModifiedByAmt = -1 * " & objDataRow.Cells(5).Value.ToString & ", " & _
                                                       "FDModifiedCharge = FDModifiedCharge - " & objDataRow.Cells(5).Value.ToString & ", " & _
                                                       "FDSTAT = 'UNPAID', " & _
                                                       "FDREMARKS = FDREMARKS + '; " & TrimAll(TextBox1.Text, True) & "' " & _
                                                       "WHERE FDNO = '" & objDataRow.Cells(9).Value.ToString & "';"
                                        .ExecuteNonQuery()

                                    End If

                                    .CommandText = "UPDATE REGISTRATION SET " & _
                                                   "REGAMT = REGAMT + " & CDbl(objDataRow.Cells(5).Value.ToString) & ", " & _
                                                   "REGBALANCE = REGBALANCE + " & CDbl(objDataRow.Cells(5).Value.ToString) & " " & _
                                                   "WHERE REGNO = '" & lblTransferToREGNO.Text & "';"
                                    .ExecuteNonQuery()

                                    .CommandText = "UPDATE REGISTRATION SET " & _
                                                  "REGAMT = REGAMT - " & CDbl(objDataRow.Cells(5).Value.ToString) & ", " & _
                                                  "REGBALANCE = REGBALANCE - " & CDbl(objDataRow.Cells(5).Value.ToString) & " " & _
                                                  "WHERE REGNO = '" & lblGuestBillREGNO.Text & "';"
                                    .ExecuteNonQuery()

                                Next

                                objTransaction.Commit()
                                Msg("1032")
                                lblTransferToREGNO.Text = String.Empty
                                lblGuestBillREGNO.Text = String.Empty
                                dgvGuestBillInformation.DataSource = vbNull
                                dgvTransferredAccountInformation.Rows.Clear()
                                txtAmountToBeTransferred.Text = "0"
                                TextBox1.Text = String.Empty 'remarks

                            Catch ex As Exception

                                objTransaction.Rollback()
                                Msg("1008", , "Saving failed " & NWLN & ex.Message)
                                lblTransferToREGNO.Text = String.Empty
                                lblGuestBillREGNO.Text = String.Empty
                                dgvGuestBillInformation.DataSource = vbNull
                                dgvTransferredAccountInformation.Rows.Clear()
                                txtAmountToBeTransferred.Text = "0"

                            End Try

                        End With

                    End Using

                End Using

            End Using

        End If

        lblTotalCharges.Text = "0"
        lblTotalBalance.Text = "0"

    End Sub

    Private Sub lblClose_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblClose.LinkClicked

        Me.Close()

    End Sub

    Private Sub frmAccountTransfer_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        If lblGuestBillREGNO.Text <> String.Empty And lblTransferToREGNO.Text <> String.Empty Then

            Select Case Msg("1033", Button.YesNoCancel)

                Case ButtonClicked.Yes
                    AccountTransferSave()
                Case ButtonClicked.Cancel
                    e.Cancel = True

            End Select

        End If

    End Sub

    Private Sub ClearAccountTransfer()

        lblTransferToREGNO.Text = String.Empty
        lblGuestBillREGNO.Text = String.Empty
        dgvGuestBillInformation.DataSource = vbNull
        dgvTransferredAccountInformation.Rows.Clear()
        txtAmountToBeTransferred.Text = ""
        lblTotalCharges.Text = "0"
        lblTotalBalance.Text = "0"

    End Sub

End Class