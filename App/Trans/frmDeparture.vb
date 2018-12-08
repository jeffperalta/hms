Option Explicit On
Option Strict On

Imports System.Data
Imports System.Data.SqlClient

' Programmer:   Mark Andrew O. Rivera
'               Jo Jefferson D. Peralta
' Date:         April 06, 2007
' Title:        frmDeparture
' Purpose:      This interface is used to check the registration status before leaving the hotel.
'               It checks if the room charges are accounted properly, new refunds are informed to the user
'               Balance should be cleared out by either payment or having a direct biller.
'               Early and late checkouts are also determined and are recorded. In cases that there are power
'               interruption or any reason that hinders the use of this system but there are guests that 
'               would like to check out and clear their accounts, the FDO will have to update the room charges
'               later and as such he can change the date of checkout with the manager's approval.
' Requirements: ->  (*)REGISTRATION(RegRemarks)
'               ->  (+)REFUND(RefID, RefAmt, RefDate, RefStat, RefExpDate, RefRemarks, RegNo, LNo)
'               ->  (*)REGISTRATION(RegBalance) 'When refund occurs
'               ->  (+)ACTIVITY_LOG(ALID, ALResOrReg, ALNAture, AlOldVal, AlNewVal, AlTimeChanged, GNo, EID, RegDNo, RegNo) 'For early and late checkouts
'               ->  (*)REGISTRATION_DETAILS(RegDStat, RegDChkOutTime, RegDRemarks)
'               ->  (*)ROOM(RMCurrStat)
'               ->  (*)RMSTATUS(RMSEndTime, RMSStat)
'               ->  (*)REGISTRATION(RegStat) 'For fully checked out rooms
'               ->  (*)DIRECT_BILLER(DBID, DBStatus, DBAmt, DBBalance)
'               ->  The guest can only checkout when he has full payment of all his balances and at least there is a direct biller
'                   that gaurantees payment for his remaining balance. If the direct biller's amount is less than the 
'                   guest's registration balance then the user is prompted to whether allow it or not. 
'               ->  Therefore, we can have direct billers that pay less than the total balance of their corresponding
'                   guest(registration). It is left to the manager to allow such payments nevertheless the total amount of this biller
'                   can be modified anytime after the actual check out of the guest. The direct biller amount can be modified to include
'                   discounts and fines.
'               ->  The interface checks if the room charges are updated for instance if the guest stays 
'                   for a week then 7 room charges should be charged at the guest's folio
'               ->  However, for any reason that the FDO was not able to checkout the guest on the supposed date
'                   then he can checkout that guest as if it was done on his actual departure. He can do this by 
'                   changing the date value at this form but with the manager's approval.
'               ->  This interface also creates a new refund tuple when it detects a negative balance. However the refund must
'                   be formalized and released at the refund interface.
'               ->  Through this form the FDO can determine the guest that must checkout on a given date. He 
'                   can use the expected checkout query to easily determine and prepare in advance before the guest's actual
'                   departure time.
'               ->  Once the room is checked out the current status is set to DIRTY and will have to be changed at the 
'                   frmRoomMaintenance to 'CLEAN' so that it will be opened for the next accommodation/registration.
'               ->  Information that a room checksout early or late than the expected checkout is saved at the 
'                   ACTIVITY_LOG table to be used during Reservation/Registration Activity Log Report.
' Results:      ->  The guest is able to checkout with assurance that his balance will have to be paid.
'               ->  The rooms are released for the next registration.
'               ->  Activity Logs are monitored.
'               ->  When all the rooms are checked out the total balance is checked and must have payments or a direct biller.
'>>>Message Done:

Class frmDeparture

    Private gRegno As String = String.Empty
    Private gGiid As String = String.Empty
    Private gState As State = State.waiting
    Private gdblRefund As Double = 0.0
    Private gblnRefund As Boolean = False
    Private gblnFullCheckOut As Boolean = False

#Region "Function/Subroutines"

    Public Sub FillMe()

        Try
            If gState <> State.waiting Then
                Select Case Msg("1033", Button.YesNoCancel)
                    Case ButtonClicked.Yes
                        If ThereAreInputErrors() Then
                            Exit Sub
                        Else
                            btnSave_Click(Nothing, Nothing)
                        End If
                    Case ButtonClicked.No
                        'pass through
                    Case ButtonClicked.Cancel
                        Exit Sub
                End Select
            End If

            If RegistrationIsNotSet Then
                Msg("1045")
            Else
                If Not IsExisting("SELECT RegNo FROM REGISTRATION WHERE RegStat='REGISTERED' AND REGNO='" & SearchedRegistrationNo & "'") Then
                    Msg("1045")
                Else
                    gRegno = SearchedRegistrationNo
                    gGiid = SearchedGuestID

                    Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
                        objConnection.Open()
                        Using objCommand As SqlCommand = New SqlCommand("SELECT ISNULL(GITitle, '') + ' ' + ISNULL(GIFName, '') + ' ' + ISNULL(GILName,'') AS Name FROM GUEST_INFO WHERE GIID='" & SearchedGuestID & "'", objConnection)
                            Using objReader As SqlDataReader = objCommand.ExecuteReader
                                objReader.Read()
                                lblGuestName.Text = objReader(0).ToString
                                objReader.Close()
                            End Using


                            objCommand.CommandText = "SELECT REGISTRATION.RegNo, REGISTRATION.RegDate, COMPANY.CName " & _
                                                     "FROM   COMPANY INNER JOIN " & _
                                                     "       GUEST ON COMPANY.CID = GUEST.CID RIGHT OUTER JOIN " & _
                                                     "       REGISTRATION ON GUEST.GNo = REGISTRATION.GNo " & _
                                                     "WHERE  (REGISTRATION.RegNo = '" & gRegno & "') "

                            Using objReader As SqlDataReader = objCommand.ExecuteReader
                                objReader.Read()
                                lblCompanyName.Text = objReader(2).ToString
                                lblRegistrationNo.Text = gRegno
                                lblRegistrationDate.Text = Format(CType(objReader(1), Date), "MMMM dd, yyyy")
                                objReader.Close()
                            End Using

                        End Using
                        objConnection.Close()
                    End Using

                    DisplayRegisteredRooms()
                    DisplayCheckedOutRooms()
                    DisplayRefunds()
                    DisplayDirectBillers()
                    UpdateTotals()

                End If
            End If
        Catch ex As Exception
            ClearControls(Me)
        End Try

    End Sub

    Private Sub DisplayRegisteredRooms()

        Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
            objConnection.Open()
            Using objCommand As SqlCommand = New SqlCommand("SELECT REGISTRATION_DETAILS.RegDNo AS [Accommodation No], ROOM.RMNo AS [Room No], ROOM.RMType AS [Room Type],  " & _
                                                            "       REGISTRATION_DETAILS.RegDChkInTime AS [Check In Time], REGISTRATION_DETAILS.RegDChkOutTime AS [Check Out Time], DATEDIFF(day,  " & _
                                                            "       REGISTRATION_DETAILS.RegDChkInTime, '" & dtpCheckOutDate.Value.ToString & "') AS [Days at Hotel], REGISTRATION_DETAILS.RegDDaysUpdated AS [Updated Room Charges],  " & _
                                                            "       REGISTRATION_DETAILS.RegDNoOfExtDays AS Extension, ISNULL(SUM(FOLIO_DETAILS.FDModifiedCharge), 0) AS Amount,  " & _
                                                            "       ISNULL(SUM(FOLIO_DETAILS.FDBalance), 0) AS Balance, REGISTRATION_DETAILS.RegDRemarks AS Remarks " & _
                                                            "FROM   REGISTRATION_DETAILS INNER JOIN " & _
                                                            "       ROOM ON REGISTRATION_DETAILS.RMNo = ROOM.RMNo LEFT OUTER JOIN " & _
                                                            "       FOLIO_DETAILS ON REGISTRATION_DETAILS.RegDNo = FOLIO_DETAILS.RegDNo " & _
                                                            "GROUP BY REGISTRATION_DETAILS.RegDNo, ROOM.RMNo, ROOM.RMType, REGISTRATION_DETAILS.RegDChkInTime,  " & _
                                                            "       REGISTRATION_DETAILS.RegDChkOutTime, DATEDIFF(day, REGISTRATION_DETAILS.RegDChkInTime, '" & dtpCheckOutDate.Value.ToString & "'),  " & _
                                                            "       REGISTRATION_DETAILS.RegDDaysUpdated, REGISTRATION_DETAILS.RegDNoOfExtDays, REGISTRATION_DETAILS.RegDRemarks,  " & _
                                                            "       REGISTRATION_DETAILS.RegNo, REGISTRATION_DETAILS.RegDStat " & _
                                                            "HAVING (REGISTRATION_DETAILS.RegNo = '" & gRegno & "') AND (REGISTRATION_DETAILS.RegDStat = 'REGISTERED') ", objConnection)
                Using objReader As SqlDataReader = objCommand.ExecuteReader
                    lvwCheckInRooms.Items.Clear()
                    lsvCheckedOutRooms.Items.Clear()
                    Do While objReader.Read
                        Dim lsvItem As ListViewItem = lvwCheckInRooms.Items.Add(objReader(0).ToString)
                        lsvItem.SubItems.Add(objReader(1).ToString)
                        lsvItem.SubItems.Add(objReader(2).ToString)
                        lsvItem.SubItems.Add(objReader(3).ToString)
                        lsvItem.SubItems.Add(objReader(4).ToString)
                        lsvItem.SubItems.Add(IIf(CType(objReader(5), Double) < 0, "0", objReader(5).ToString).ToString)
                        lsvItem.SubItems.Add(objReader(6).ToString)
                        lsvItem.SubItems.Add(objReader(7).ToString)
                        lsvItem.SubItems.Add(Format(CType(objReader(8), Double), "n"))
                        lsvItem.SubItems.Add(Format(CType(objReader(9), Double), "n"))
                        lsvItem.SubItems.Add(objReader(10).ToString)
                    Loop
                End Using
            End Using
            objConnection.Close()
        End Using

        lblCountRegistered.Text = lvwCheckInRooms.Items.Count.ToString

    End Sub

    Private Sub DisplayCheckedOutRooms()

        lblCountCheckedOut.Text = ListItems(DatabasePath, "SELECT REGISTRATION_DETAILS.RegDNo AS [Accommodation No], ROOM.RMNo AS [Room No], ROOM.RMType AS [Room Type],  " & _
                                                          "       REGISTRATION_DETAILS.RegDChkInTime AS [Check In Time], REGISTRATION_DETAILS.RegDChkOutTime AS [Check Out Time], DATEDIFF(day,  " & _
                                                          "       REGISTRATION_DETAILS.RegDChkInTime, '" & dtpCheckOutDate.Value.ToString & "') AS [Days at Hotel], REGISTRATION_DETAILS.RegDDaysUpdated AS [Updated Room Charges],  " & _
                                                          "       REGISTRATION_DETAILS.RegDNoOfExtDays AS Extension, ISNULL(SUM(FOLIO_DETAILS.FDModifiedCharge), 0) AS Amount,  " & _
                                                          "       ISNULL(SUM(FOLIO_DETAILS.FDBalance), 0) AS Balance, REGISTRATION_DETAILS.RegDRemarks AS Remarks " & _
                                                          "FROM   REGISTRATION_DETAILS INNER JOIN " & _
                                                          "       ROOM ON REGISTRATION_DETAILS.RMNo = ROOM.RMNo LEFT OUTER JOIN " & _
                                                          "       FOLIO_DETAILS ON REGISTRATION_DETAILS.RegDNo = FOLIO_DETAILS.RegDNo " & _
                                                          "GROUP BY REGISTRATION_DETAILS.RegDNo, ROOM.RMNo, ROOM.RMType, REGISTRATION_DETAILS.RegDChkInTime,  " & _
                                                          "       REGISTRATION_DETAILS.RegDChkOutTime, DATEDIFF(day, REGISTRATION_DETAILS.RegDChkInTime, '" & dtpCheckOutDate.Value.ToString & "'),  " & _
                                                          "       REGISTRATION_DETAILS.RegDDaysUpdated, REGISTRATION_DETAILS.RegDNoOfExtDays, REGISTRATION_DETAILS.RegDRemarks,  " & _
                                                          "       REGISTRATION_DETAILS.RegNo, REGISTRATION_DETAILS.RegDStat " & _
                                                          "HAVING (REGISTRATION_DETAILS.RegNo = '" & gRegno & "') AND (REGISTRATION_DETAILS.RegDStat = 'CHECKED OUT') ", _
                                                          dgvCheckOutRooms).ToString

    End Sub

    Private Sub DisplayRefunds()

        lblCountRefund.Text = ListItems(DatabasePath, _
                    "SELECT REFUND.RefID AS [Refund No], REFUND.RefAmt AS Amount, ISNULL(REFUND.RefIssuedAmt, 0) AS [Amount To Issue], " & _
                    "       REFUND.RefDate AS [Date Of Refund], REFUND.RefExpDate AS [Expiration Date], REFUND.RefStat AS [Refund Status],  " & _
                    "       REFUND.RefRemarks AS Remarks " & _
                    "FROM   REFUND INNER JOIN " & _
                    "       REGISTRATION ON REFUND.RegNo = REGISTRATION.RegNo INNER JOIN " & _
                    "       GUEST ON REGISTRATION.GNo = GUEST.GNo " & _
                    "WHERE  (GUEST.GIID = '" & gGiid & "') " & _
                    "UNION " & _
                    "SELECT REFUND_1.RefID AS [Refund No], REFUND_1.RefAmt AS Amount, ISNULL(REFUND_1.RefIssuedAmt, 0) AS [Amount To Issue],  " & _
                    "       REFUND_1.RefDate AS [Date Of Refund], REFUND_1.RefExpDate AS [Expiration Date], REFUND_1.RefStat AS [Refund Status],  " & _
                    "       REFUND_1.RefRemarks AS Remarks " & _
                    "FROM   REFUND AS REFUND_1 INNER JOIN " & _
                    "       RESERVATION ON REFUND_1.ResNo = RESERVATION.ResNo INNER JOIN " & _
                    "       GUEST AS GUEST_1 ON RESERVATION.GNo = GUEST_1.GNo " & _
                    "WHERE  (GUEST_1.GIID = '" & gGiid & "') ", dgvRefund).ToString

        Dim dblAmount As Double = 0
        For intCtr As Integer = 0 To dgvRefund.RowCount - 1
            If dgvRefund.Item(5, intCtr).Value.ToString.ToUpper = "ONHOLD" Or dgvRefund.Item(5, intCtr).Value.ToString.ToUpper = "UNFINALIZED" Then
                dblAmount += CType(dgvRefund.Item(2, intCtr).Value, Double)
            End If
        Next
        lblRefundAmount.Text = Format(dblAmount, "n")

    End Sub

    Private Sub DisplayDirectBillers()

        lblDirectBillerCount.Text = ListItems(DatabasePath, _
                    "SELECT DIRECT_BILLER.DBID AS [Direct Biller No], DIRECT_BILLER.DBName AS Name, DIRECT_BILLER.DBAddress AS Address, " & _
                    "       DIRECT_BILLER.DBContact AS Contact, DIRECT_BILLER.DBAmt AS Amount, DIRECT_BILLER.DBBalance AS Balance,  " & _
                    "       DIRECT_BILLER.DBDate AS Date, DIRECT_BILLER.DBExpDate AS [Expiration Date], DIRECT_BILLER.DBRemarks AS Remarks,  " & _
                    "       DIRECT_BILLER.DBStatus AS Status " & _
                    "FROM   DIRECT_BILLER LEFT OUTER JOIN " & _
                    "       REGISTRATION ON DIRECT_BILLER.DBID = REGISTRATION.DBID " & _
                    "WHERE  (REGISTRATION.RegNo = '" & gRegno & "') AND (DIRECT_BILLER.DBStatus <> 'UNCOLLECTIBLE') ", _
                    dgvDirectBiller).ToString

        Dim dblAmount As Double = 0
        For intCtr As Integer = 0 To dgvDirectBiller.RowCount - 1
            dblAmount += CType(dgvDirectBiller.Item(4, intCtr).Value, Double)
        Next
        lblDirectBillerAmount.Text = Format(dblAmount, "n")

    End Sub

    Private Sub DisplayExpectedDepartures()

        lblExpectedCheckOut.Text = ListItems(DatabasePath(), "SELECT REGISTRATION_DETAILS.RegDNo AS [Accommodation No], ROOM.RMNo AS [Room No], ROOM.RMType AS [Room Type], REGISTRATION_DETAILS.RegDChkInTime AS [Check In Date],  " & _
                                                             "       REGISTRATION_DETAILS.RegDNoOfExtDays AS [Extension In Days], DATEADD(DAY, REGISTRATION_DETAILS.RegDNoOfExtDays,  " & _
                                                             "       REGISTRATION_DETAILS.RegDChkOutTime) AS [Expected Checkout], DATEDIFF(day, REGISTRATION_DETAILS.RegDChkInTime, '" & dtpExpectedCheckOut.Value.ToString & "')  " & _
                                                             "       AS [Days Stayed In Hotel], REGISTRATION_DETAILS.RegDRemarks AS [Remarks], ROOM.RMTelNo AS [Room Tel No], ROOM.RMFloor AS [Room Floor], ROOM.RMView AS [Room View]" & _
                                                             "FROM   REGISTRATION_DETAILS INNER JOIN " & _
                                                             "       ROOM ON REGISTRATION_DETAILS.RMNo = ROOM.RMNo " & _
                                                             "WHERE  (REGISTRATION_DETAILS.RegDStat = 'REGISTERED') AND (DATEADD(DAY, REGISTRATION_DETAILS.RegDNoOfExtDays, " & _
                                                             "       REGISTRATION_DETAILS.RegDChkOutTime) >= '" & dtpExpectedCheckOut.Value.ToString & "') ", dgvExpectedCheckout).ToString()


    End Sub

    Private Function ThereAreInputErrors() As Boolean

        DisplayDirectBillers()
        DisplayRefunds()

        If lsvCheckedOutRooms.Items.Count = 0 Then
            Msg("1005", Button.Ok, "There are no rooms to check out")
            Return True
            Exit Function
        End If

        If lvwCheckInRooms.Items.Count = lvwCheckInRooms.CheckedItems.Count Then 'Full check out
            gblnFullCheckOut = True

            Dim dblTotalBalance As Double = TotalBalance(gRegno, Transaction.Registration)
            If dblTotalBalance <> 0 Then
                If dblTotalBalance < 0 Then
                    Msg("1056", Button.Ok, "You can claim it after the guest registration has been checked out.")
                    gblnRefund = True
                    gdblRefund = -1 * dblTotalBalance
                End If

                If dblTotalBalance > 0 AndAlso dgvDirectBiller.RowCount > 0 Then
                    If CType(lblDirectBillerAmount.Text, Double) < dblTotalBalance Then
                        If Msg("1060", Button.YesNo) = ButtonClicked.No Then

                            Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
                                objConnection.Open()
                                Using objTransaction As SqlTransaction = objConnection.BeginTransaction
                                    Using objCommand As SqlCommand = objConnection.CreateCommand
                                        'If user does not allow then edit direct biller
                                        With objCommand
                                            .Transaction = objTransaction

                                            Dim TotalDirectBillerPayment As Double = TotalBalance(dgvDirectBiller.Item(0, 0).Value.ToString, Transaction.DirectBiller)


                                            .CommandText = "UPDATE DIRECT_BILLER SET DBAmt=@DBAmt, DBBalance=@DBBalance, DBStatus=@DBStatus WHERE DBID=@DBID"

                                            With .Parameters
                                                .Clear()

                                                .AddWithValue("@DBAmt", CType(lblTotalBalance.Text, Double))
                                                .AddWithValue("@DBID", dgvDirectBiller.Item(0, 0).Value.ToString)

                                                If TotalDirectBillerPayment >= CType(lblTotalBalance.Text, Double) Then
                                                    .AddWithValue("@DBBalance", 0)
                                                    .AddWithValue("@DBStatus", "PAID")
                                                Else
                                                    .AddWithValue("@DBBalance", CType(lblTotalBalance.Text, Double) - TotalDirectBillerPayment)
                                                    .AddWithValue("@DBStatus", "UNPAID")
                                                End If
                                            End With
                                            .ExecuteNonQuery()

                                        End With
                                    End Using
                                End Using
                                objConnection.Close()
                            End Using

                        End If
                    End If
                ElseIf dblTotalBalance > 0 Then
                    Msg("1061")
                    Return True
                    Exit Function
                End If
            End If
        End If

        Return False

    End Function

    Private Sub UpdateTotals()

        lblTotalCharges.Text = Format(TotalCharges(gRegno, Transaction.Registration), "n")
        lblTotalPayments.Text = Format(TotalPayments(gRegno, Transaction.Registration), "n")
        lblTotalBalance.Text = Format(CType(lblTotalCharges.Text, Double) - CType(lblTotalPayments.Text, Double), "n")

    End Sub

#End Region

#Region "Command Button"

    Private Sub btnCheckOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckOut.Click

        gState = State.updating
        tbcInformation.SelectedIndex = 0

        If lvwCheckInRooms.CheckedItems.Count = 0 Then
            Msg("1039")
        Else
            For Each ctlItem As ListViewItem In lvwCheckInRooms.CheckedItems

                lblCountCheckOutToday.Text = lsvCheckedOutRooms.Items.Count.ToString

                'Index 5 -> stay in hotel
                'Index 6 -> room charges
                If CType(ctlItem.SubItems(5).Text, Integer) < CType(ctlItem.SubItems(6).Text, Integer) Then

                    Select Case Msg("1064", Button.YesNoCancel, "The number of room charges excede the number of days stayed at the hotel. This entails additional charges to the guest. Would you allow this?")
                        Case ButtonClicked.Yes
                            'Allow Additional Charges
                        Case ButtonClicked.No
                            Continue For
                        Case ButtonClicked.Cancel
                            Exit Sub
                    End Select

                ElseIf CType(ctlItem.SubItems(5).Text, Integer) > CType(ctlItem.SubItems(6).Text, Integer) Then
                    Msg("1066")
                    Continue For
                End If

                Dim lsvItem As ListViewItem = lsvCheckedOutRooms.Items.Add(ctlItem.Text)
                lsvItem.SubItems.Add(ctlItem.SubItems(1).Text)
                lsvItem.SubItems.Add(ctlItem.SubItems(2).Text)
                lsvItem.SubItems.Add(ctlItem.SubItems(3).Text)
                lsvItem.SubItems.Add(dtpCheckOutDate.Value.ToString)
                lsvItem.SubItems.Add(ctlItem.SubItems(5).Text)
                lsvItem.SubItems.Add(ctlItem.SubItems(6).Text)
                lsvItem.SubItems.Add(ctlItem.SubItems(7).Text)
                lsvItem.SubItems.Add(ctlItem.SubItems(8).Text)
                lsvItem.SubItems.Add(ctlItem.SubItems(9).Text)
                lsvItem.SubItems.Add(ctlItem.SubItems(10).Text & "; " & txtRemarksDetailed.Text)
                lsvItem.SubItems.Add(ctlItem.SubItems(4).Text)

                ctlItem.Remove()

            Next
        End If

    End Sub

    Private Sub btnChangeDateTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangeDateTime.Click
        If UserPrivilege <> Privilege.system Then
            frmAuthorization.ShowDialog()
            If frmAuthorization.Result = True Then
                dtpCheckOutDate.Enabled = True
                dtpCheckOutTime.Enabled = True
            Else
                dtpCheckOutDate.Enabled = False
            End If
        Else
            dtpCheckOutDate.Enabled = True
            dtpCheckOutTime.Enabled = True
            btnChangeDateTime.Enabled = False
        End If
    End Sub

    Private Sub btnReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReturn.Click
        If lsvCheckedOutRooms.SelectedItems.Count > 0 Then
            For Each ctlItem As ListViewItem In lsvCheckedOutRooms.SelectedItems
                Dim lsvItem As ListViewItem = lvwCheckInRooms.Items.Add(ctlItem.Text)
                lsvItem.SubItems.Add(ctlItem.SubItems(1).Text)
                lsvItem.SubItems.Add(ctlItem.SubItems(2).Text)
                lsvItem.SubItems.Add(ctlItem.SubItems(3).Text)
                lsvItem.SubItems.Add(ctlItem.SubItems(4).Text)
                lsvItem.SubItems.Add(ctlItem.SubItems(5).Text)
                lsvItem.SubItems.Add(ctlItem.SubItems(6).Text)
                lsvItem.SubItems.Add(ctlItem.SubItems(7).Text)
                lsvItem.SubItems.Add(ctlItem.SubItems(8).Text)
                lsvItem.SubItems.Add(ctlItem.SubItems(9).Text)
                lsvItem.SubItems.Add(ctlItem.SubItems(10).Text)

                ctlItem.Remove()
            Next

            lblCountCheckOutToday.Text = lsvCheckedOutRooms.Items.Count.ToString
            lblCountRegistered.Text = lvwCheckInRooms.Items.Count.ToString

        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        gdblRefund = 0.0
        gblnRefund = False
        gblnFullCheckOut = False

        If ThereAreInputErrors Then Exit Sub

        Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
            objConnection.Open()
            Using objTransaction As SqlTransaction = objConnection.BeginTransaction
                Using objCommand As SqlCommand = objConnection.CreateCommand
                    With objCommand
                        .Transaction = objTransaction

                        Try

                            'Save Registration Remarks
                            .CommandText = "UPDATE REGISTRATION SET RegRemarks = RegRemarks + @RegRemarks WHERE RegNo=@RegNo;"
                            With .Parameters
                                .Clear()
                                .AddWithValue("@RegRemarks", TrimAll(txtRemarksDetailed.Text))
                                .AddWithValue("@RegNo", gRegno)
                            End With
                            .ExecuteNonQuery()

                            If gblnRefund Then
                                .CommandText = "SELECT RefGracePeriod FROM SYSTEM"
                                Dim intGracePeriod As Integer = CType(.ExecuteScalar, Integer)

                                .CommandText = "INSERT INTO REFUND (RefId, RefAmt, RefDate, RefStat, RefExpDate, RefRemarks, RegNo, LNo) " & _
                                               "VALUES (@RefId, @RefAmt, @RefDate, @RefStat, @RefExpDate, @RefRemarks, @RegNo, @LNo);"
                                With .Parameters
                                    .Clear()
                                    .AddWithValue("@RefId", GetPrimaryKeyNo("REFUND"))
                                    IncrementPrimaryKeyNo("REFUND")
                                    .AddWithValue("@RefAmt", gdblRefund).SqlDbType = SqlDbType.Money
                                    .AddWithValue("@RefDate", Date.Now).SqlDbType = SqlDbType.DateTime
                                    .AddWithValue("@RefStat", "UNFINALIZED")
                                    .AddWithValue("@RefExpDate", DateAdd(DateInterval.Day, intGracePeriod, Date.Now))
                                    .AddWithValue("@RefRemarks", "REFUND FROM CHECKOUT; ")
                                    .AddWithValue("@RegNo", gRegno)
                                    .AddWithValue("@LNo", LogNo())
                                End With
                                .ExecuteNonQuery()

                                'Zero out registration amount after a refund has been saved.
                                .CommandText = "UPDATE REGISTRATION SET RegBalance=0 WHERE RegNo=@RegNo;"
                                .Parameters.Clear()
                                .Parameters.AddWithValue("@RegNo", gRegno)
                                .ExecuteNonQuery()

                            End If 'Determine Refund

                            For Each ctlItem As ListViewItem In lsvCheckedOutRooms.Items
                                Dim RealChkOutDate As Date = CType(ctlItem.SubItems(4).Text, Date), _
                                    SupposedChkOutDate As Date = CType(ctlItem.SubItems(11).Text, Date)

                                'Might have difference because they have different time, so format to MMMM dd,yyyy is necessary to compare on the dates only
                                If String.Compare(Format(RealChkOutDate, "MMMM dd, yyyy"), Format(SupposedChkOutDate, "MMMM dd, yyyy"), True) <> 0 Then

                                    .CommandText = "INSERT INTO ACTIVITY_LOG (ALID, ALResOrReg, ALNature, ALOldVal, ALNewVal, ALTimeChanged, GNo, EID, RegDNo, RegNo) " & _
                                                   "VALUES (@ALID, @ALResOrReg, @ALNature, @ALOldVal, @ALNewVal, @ALTimeChanged, @GNo, @EID, @RegDNo, @RegNo);"
                                    With .Parameters
                                        .Clear()
                                        .AddWithValue("@ALID", GetPrimaryKeyNo("ALID"))
                                        .AddWithValue("@ALResOrReg", "REGISTRATION")
                                        .AddWithValue("@ALOldVal", SupposedChkOutDate.ToString)
                                        .AddWithValue("@ALNewVal", RealChkOutDate.ToString)
                                        .AddWithValue("@ALTimeChanged", Date.Now)
                                        .AddWithValue("@GNo", SearchedGuestID)
                                        .AddWithValue("@EID", DatabaseUser())
                                        .AddWithValue("@RegDNo", ctlItem.SubItems(0).Text)
                                        .AddWithValue("@RegNo", gRegno)
                                        IncrementPrimaryKeyNo("ALID")

                                        If RealChkOutDate < SupposedChkOutDate Then
                                            'Early CheckOut
                                            .AddWithValue("@ALNature", "EARLY CHECKOUT")
                                        ElseIf RealChkOutDate > SupposedChkOutDate Then
                                            'Late Checkout
                                            .AddWithValue("@ALNature", "LATE CHECKOUT")
                                        End If
                                    End With

                                    .ExecuteNonQuery()
                                End If

                                .CommandText = "UPDATE REGISTRATION_DETAILS SET RegDStat=@RegDStat, " & _
                                               "RegDChkOutTime=@RegDChkOutTime, RegDRemarks = RegDRemarks + @RegDRemarks " & _
                                               "WHERE RegDNo=@RegDNo "
                                With .Parameters
                                    .Clear()
                                    .AddWithValue("@RegDStat", "CHECKED OUT")
                                    .AddWithValue("@RegDChkOutTime", ctlItem.SubItems(4).Text).SqlDbType = SqlDbType.DateTime
                                    .AddWithValue("@RegDNo", ctlItem.Text)
                                    .AddWithValue("@RegDRemarks", TrimAll(ctlItem.SubItems(10).Text))
                                End With
                                .ExecuteNonQuery()

                                'set checked out rooms to unclean
                                .CommandText = "UPDATE ROOM SET RMCurrStat=@RMCurrStat WHERE RMNo=@RMNo;"
                                With .Parameters
                                    .Clear()
                                    .AddWithValue("@RMCurrStat", "DIRTY")
                                    .AddWithValue("@RMNo", ctlItem.SubItems(1).Text)
                                End With
                                .ExecuteNonQuery()

                                'set room status info
                                .CommandText = "UPDATE RMSTATUS SET RMSEndTime=@RMSEndTime, RMSStat=@RMSStat " & _
                                               "WHERE RMNo=@RMNo AND RMSName='REGISTERED';"
                                With .Parameters
                                    .Clear()
                                    .AddWithValue("@RMSEndTime", ctlItem.SubItems(4).Text)
                                    .AddWithValue("@RMSStat", "CHECKED OUT")
                                    .AddWithValue("@RMNo", ctlItem.SubItems(1).Text)
                                End With
                                .ExecuteNonQuery()

                            Next 'ROOM

                            If gblnFullCheckOut Then
                                .CommandText = "UPDATE REGISTRATION SET RegStat='CHECKED OUT' WHERE RegNo=@RegNo;"
                                .Parameters.Clear()
                                .Parameters.AddWithValue("@RegNo", gRegno)
                                .ExecuteNonQuery()
                            End If

                            objTransaction.Commit()
                            gState = State.waiting

                            DisplayRegisteredRooms()
                            DisplayCheckedOutRooms()
                            DisplayRefunds()
                            UpdateTotals()

                            tbcInformation.SelectedIndex = 1

                        Catch ex As Exception
                            objTransaction.Rollback()
                            Msg("1008", Button.Ok, ex.Message)
                        Finally
                            dtpCheckOutDate.Enabled = False
                            dtpCheckOutDate.Value = Date.Now
                        End Try

                    End With
                End Using
            End Using
            objConnection.Close()
        End Using

    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        DisplayDirectBillers()
    End Sub

    Private Sub btnRefreshAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshAll.Click
        Try
            DisplayRegisteredRooms()
            DisplayRefunds()
            DisplayDirectBillers()
            UpdateTotals()
        Catch ex As Exception
            'Error happens when there is no items saved at the database 
        End Try
    End Sub

#End Region

#Region "MISC"

    Private Sub chkFullCheckOut_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFullCheckOut.CheckedChanged
        If chkFullCheckOut.Checked = True Then
            For Each ctlItem As ListViewItem In lvwCheckInRooms.Items
                ctlItem.Checked = True
            Next
        End If
    End Sub

    Private Sub dtpCheckOutDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpCheckOutDate.ValueChanged
        DisplayRegisteredRooms()
        For Each ctlItem As ListViewItem In lvwCheckInRooms.Items
            For Each ctlListedItem As ListViewItem In lsvCheckedOutRooms.Items
                If String.Compare(ctlItem.Text, ctlListedItem.Text) = 0 Then
                    ctlItem.Remove()
                    Exit For
                End If
            Next
        Next

        lblCountRegistered.Text = lvwCheckInRooms.Items.Count.ToString
    End Sub

    Private Sub dtpExpectedCheckOut_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpExpectedCheckOut.ValueChanged
        DisplayExpectedDepartures()
    End Sub

    Private Sub frmDeparture_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpCheckOutDate.Value = Date.Now
        dtpExpectedCheckOut.Value = Date.Now

        lblGuestName.Text = "-"
        lblCompanyName.Text = "-"
        lblRegistrationNo.Text = "-"
        lblRegistrationDate.Text = "-"

        dgvExpectedCheckout.AlternatingRowsDefaultCellStyle = SetAlternatingColor()
        dgvCheckOutRooms.AlternatingRowsDefaultCellStyle = SetAlternatingColor()
        dgvRefund.AlternatingRowsDefaultCellStyle = SetAlternatingColor()
        dgvDirectBiller.AlternatingRowsDefaultCellStyle = SetAlternatingColor()
    End Sub

    Private Sub frmDeparture_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If gState <> State.waiting Then
            Select Case Msg("1033", Button.YesNoCancel)
                Case ButtonClicked.Yes
                    If ThereAreInputErrors() Then
                        e.Cancel = True
                    Else
                        btnSave_Click(Nothing, Nothing)
                    End If
                Case ButtonClicked.No
                    e.Cancel = False
                Case ButtonClicked.Cancel
                    e.Cancel = True
            End Select
        End If
    End Sub

    Private Sub lvwCheckInRooms_ItemChecked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles lvwCheckInRooms.ItemChecked
        If lvwCheckInRooms.CheckedItems.Count = lvwCheckInRooms.Items.Count Then
            chkFullCheckOut.Checked = True
        Else
            chkFullCheckOut.Checked = False
        End If
    End Sub

    Private Sub lblClose_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblClose.LinkClicked
        Me.Close()
    End Sub

#End Region

#Region "Side Bars"

    Private Sub tsbGuestSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuestSearch.Click
        TriggeredBy = TriggeringForm.Departure
        frmGuestSearch.ShowDialog()
    End Sub

    Private Sub tsbDirectBiller_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbDirectBiller.Click
      
        Display(Forms.frmDirectBiller)

    End Sub

    Private Sub tsbActGuestInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbActGuestInfo.Click
        SearchedGuestID = gGiid
        SearchedRegistrationNo = gRegno
        Display(Forms.frmGuestInformation)
        frmGuestInformation.FillMe()
    End Sub

    Private Sub tsbGuestFolio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuestFolio.Click
        SearchedGuestID = gGiid
        SearchedRegistrationNo = gRegno
        Display(Forms.frmGuestFolio)
        frmGuestFolio.FillMe()
    End Sub

    Private Sub tsbActRmMaintenance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbActRmMaintenance.Click
        SearchedGuestID = gGiid
        SearchedRegistrationNo = gRegno
        Display(Forms.frmPayment)
        frmPayment.FillMe()
    End Sub

#End Region

End Class