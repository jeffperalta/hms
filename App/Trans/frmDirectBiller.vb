Option Explicit On
Option Strict On

Imports System.Data
Imports System.Data.SqlClient

' Programmer:   Mark Andrew O. Rivera
'               Jo Jefferson D. Peralta
' Date:         April 05, 2007
' Title:        frmDirectBiller
' Purpose:      This interface is used to add, edit or delete direct biller information.
'               The user can assign a direct biller to any registrations irregardless of the status.
'               When a guest checks out and cannot pay at that time to clear his balances 
'               he can use his direct biller to assure that the registration account is cleared.
'               Supposedly the FDO should ensure that the direct biller amount is updated when the FDO checks out
'               because it is possible that the direct biller information is added before the actual checkout.
' Requirements: ->  (+/-)DIRECT_BILLER(DIRECT_BILLER (DBID, DBName, DBAddress, DBContact, DBStatus, DBAmt, DBBalance, DBDate, DBExpDate, DBRemarks))
'               ->  (*)DIRECT_BILLER(DBName, DBAddress, DBContact, DBStatus, DBAmt, DBBalance, DBDate, DBExpDate, DBRemarks))
'               ->  (*)REGISTRATION(DBID)
'               ->  Deletion will not continue if the direct biller already has a payment.
'               ->  During checkout the guest must ensure that the direct biller amount is equal to the registration balance.
'               ->  It is in this interface that the user can change the direct biller amount.
'               ->  However the amount must not be less than the total payments made. 
'                   Because direct billers are not allowed of any refunds.
'               ->  If its balance is equal to the payment then the direct biller status is set to PAID otherwise its UNPAID
'                   The user can also query those direct billers that reached the expiration date and manually change its status to UNCOLLECTIBLE
'               ->  Once a direct biller is set to a registration it cannot be reassigned to another one.
'                   The user will have to delete the information (assuming that it has no payments made) and create a new 
'                   direct biller information and assigned it to a new registration.
' Results:      ->  A direct biller is assigned to a single registration. Deletion and modification in the direct biller
'                   information is also done.
'               ->  If the guest wishes to checkout and really cannot pay the direct biller is used to assure
'                   that a balance will be paid even after the guest's active registration.
'>>>Messagebox Done:

Public Class frmDirectBiller

    Private gState As State = State.waiting

#Region "Function/Subroutines"

    Private Sub DisplayDirectBiller()

        Dim strWhere As String = String.Empty
        Dim blnFirstWhere As Boolean = True

        If Not chkSelectAll.Checked Then
            
            If Not Trim(txtNameSearch.Text) = String.Empty Then
                If blnFirstWhere Then
                    strWhere &= " WHERE "
                    blnFirstWhere = False
                Else
                    strWhere &= " AND "
                End If

                strWhere &= " ((DIRECT_BILLER.DBName LIKE '" & TrimAll(txtNameSearch.Text, True) & "%') OR (GUEST_INFO.GIFName LIKE '" & TrimAll(txtNameSearch.Text, True) & "%')) "
            End If

            If chkExceded.Checked Then
                If blnFirstWhere Then
                    strWhere &= " WHERE "
                    blnFirstWhere = False
                Else
                    strWhere &= " AND "
                End If

                strWhere &= " (DIRECT_BILLER.DBExpDate >= { fn NOW() }) "
            End If

            If Trim(cboViewStatus.Text) <> String.Empty Then

                If blnFirstWhere Then
                    strWhere &= " WHERE "
                    blnFirstWhere = False
                Else
                    strWhere &= " AND "
                End If

                strWhere &= " (DIRECT_BILLER.DBStatus = '" & cboViewStatus.Text & "') "

            End If

        End If

        lblCountDirectBiller.Text = ListItems(DatabasePath, _
                                        "SELECT DIRECT_BILLER.DBID AS [Direct Biller ID], ISNULL(GUEST_INFO.GITitle, '') + ' ' + ISNULL(GUEST_INFO.GIFName, '') " & _
                                        "       + ' ' + ISNULL(GUEST_INFO.GILName, '') AS [Name of Guest], DIRECT_BILLER.DBName AS [Name of Direct Biller],  " & _
                                        "       DIRECT_BILLER.DBAddress AS Address, ISNULL(DIRECT_BILLER.DBContact,'') AS Contact, DIRECT_BILLER.DBAmt AS Amount,  " & _
                                        "       DIRECT_BILLER.DBBalance AS Balance, DIRECT_BILLER.DBDate AS Date, DIRECT_BILLER.DBExpDate AS [Expiration Date],  " & _
                                        "       DIRECT_BILLER.DBStatus AS Status, REGISTRATION.RegNo AS [Registration No], ISNULL(DIRECT_BILLER.DBRemarks,'') AS Remarks " & _
                                        "FROM   DIRECT_BILLER INNER JOIN " & _
                                        "       REGISTRATION ON DIRECT_BILLER.DBID = REGISTRATION.DBID INNER JOIN " & _
                                        "       GUEST ON REGISTRATION.GNo = GUEST.GNo INNER JOIN " & _
                                        "       GUEST_INFO ON GUEST.GIID = GUEST_INFO.GIID " & _
                                        strWhere, dgvDirectBiller).ToString()

     
    End Sub

    Private Sub DisplayRegistrations()

        Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
            objConnection.Open()
            Using objCommand As SqlCommand = New SqlCommand
                With objCommand
                    .Connection = objConnection

                    If gState = State.updating Then
                        'This function is certain that the subroutine calling it
                        'has already checked that there is a selected item at the datagrid
                        .CommandText = "SELECT REGISTRATION.RegNo AS [Registration No], ISNULL(GUEST_INFO.GITitle, '') + ' ' + ISNULL(GUEST_INFO.GIFName, '')  " & _
                                       "       + ' ' + ISNULL(GUEST_INFO.GILName, '') AS Name, REGISTRATION.RegDate AS [Registration Date], REGISTRATION.RegStat AS Status,  " & _
                                       "       REGISTRATION.RegRemarks AS Remarks " & _
                                       "FROM   REGISTRATION INNER JOIN " & _
                                       "       GUEST ON REGISTRATION.GNo = GUEST.GNo INNER JOIN " & _
                                       "       GUEST_INFO ON GUEST.GIID = GUEST_INFO.GIID " & _
                                       "WHERE  REGISTRATION.DBID='" & dgvDirectBiller.Item(0, dgvDirectBiller.CurrentRow.Index).Value.ToString & "' "

                    ElseIf gState = State.adding Then

                        .CommandText = "SELECT REGISTRATION.RegNo AS [Registration No], ISNULL(GUEST_INFO.GITitle, '') + ' ' + ISNULL(GUEST_INFO.GIFName, '')  " & _
                                       "       + ' ' + ISNULL(GUEST_INFO.GILName, '') AS Name, REGISTRATION.RegDate AS [Registration Date], REGISTRATION.RegStat AS Status,  " & _
                                       "       REGISTRATION.RegRemarks AS Remarks " & _
                                       "FROM   REGISTRATION INNER JOIN " & _
                                       "       GUEST ON REGISTRATION.GNo = GUEST.GNo INNER JOIN " & _
                                       "       GUEST_INFO ON GUEST.GIID = GUEST_INFO.GIID " & _
                                       "WHERE  (REGISTRATION.DBID IS NULL) " & _
                                       IIf(chkRegisteredOnly.Checked, " AND REGISTRATION.RegStat='REGISTERED' ", "").ToString & _
                                       "ORDER BY ISNULL(GUEST_INFO.GIFName, '') + ' ' + ISNULL(GUEST_INFO.GILName, '') ASC"
                    Else
                        'gstate = waiting | deleting
                        Exit Sub
                    End If

                    lvwRegistration.Items.Clear()

                    Using objReader As SqlDataReader = .ExecuteReader
                        Do While objReader.Read

                            Dim dblCharges As Double = TotalCharges(objReader(0).ToString, Transaction.Registration)
                            Dim dblPayment As Double = TotalPayments(objReader(0).ToString, Transaction.Registration)
                            Dim dblBalance As Double = dblCharges - dblPayment

                            If gState = State.adding AndAlso dblBalance > 0 Then
                                Dim lsvItem As ListViewItem = lvwRegistration.Items.Add(objReader(0).ToString)
                                lsvItem.SubItems.Add(objReader(1).ToString)
                                lsvItem.SubItems.Add(Format(dblCharges, "n"))
                                lsvItem.SubItems.Add(Format(dblPayment, "n"))
                                lsvItem.SubItems.Add(Format(dblBalance, "n"))
                                lsvItem.SubItems.Add(objReader(2).ToString)
                                lsvItem.SubItems.Add(objReader(3).ToString)
                                lsvItem.SubItems.Add(objReader(4).ToString)
                            ElseIf gState = State.updating Then
                                Dim lsvItem As ListViewItem = lvwRegistration.Items.Add(objReader(0).ToString)
                                lsvItem.SubItems.Add(objReader(1).ToString)
                                lsvItem.SubItems.Add(Format(dblCharges, "n"))
                                lsvItem.SubItems.Add(Format(dblPayment, "n"))
                                lsvItem.SubItems.Add(Format(dblBalance, "n"))
                                lsvItem.SubItems.Add(objReader(2).ToString)
                                lsvItem.SubItems.Add(objReader(3).ToString)
                                lsvItem.SubItems.Add(objReader(4).ToString)
                            End If
                        Loop
                        objReader.Close()
                    End Using

                    lblCountRegistration.Text = lvwRegistration.Items.Count.ToString

                End With
            End Using
            objConnection.Close()
        End Using
    End Sub

    Private Function ThereAreInputErrors() As Boolean

        If Trim(txtDBName.Text) = String.Empty Then
            Msg("1000")
            txtDBName.SelectAll()
            txtDBName.Focus()
            Return True
            Exit Function
        End If

        If Trim(txtDBAmount.Text) = String.Empty Then
             Msg("1000")
            txtDBAmount.SelectAll()
            txtDBAmount.Focus()
            Return True
            Exit Function
        Else
            If Not IsNumeric(txtDBAmount.Text) Then
                Msg("1001", Button.Ok, "A numeric value is required.")
                txtDBAmount.SelectAll()
                txtDBAmount.Focus()
                Return True
                Exit Function
            Else
                If CType(txtDBAmount.Text, Double) <= 0 Then
                    Msg("1001", Button.Ok, "The amount must be greater than zero")
                    txtDBAmount.SelectAll()
                    txtDBAmount.Focus()
                    Return True
                    Exit Function
                End If
            End If
        End If

        Select Case gState
            Case State.updating
                If CType(txtDBAmount.Text, Double) < CType(lblTotalPayment.Text, Double) Then
                    Msg("1063")
                    txtDBAmount.SelectAll()
                    txtDBAmount.Focus()
                    Return True
                    Exit Function
                End If

                If Not (chkMarkAsUncollectible.Checked) AndAlso CType(txtDBAmount.Text, Double) = CType(lblTotalPayment.Text, Double) Then
                    If Msg("1067", Button.YesNo) = ButtonClicked.No Then
                        txtDBAmount.SelectAll()
                        txtDBAmount.Focus()
                        Return True
                        Exit Function
                    End If
                End If

            Case State.adding

                If lvwRegistration.SelectedItems.Count <> 1 Then
                    Msg("1068", Button.Ok)
                    lvwRegistration.Focus()
                    Return True
                    Exit Function
                Else
                    If CType(lvwRegistration.FocusedItem.SubItems(4).Text, Double) <> CType(txtDBAmount.Text, Double) Then
                        If Msg("1060", Button.YesNo) = ButtonClicked.No Then
                            txtDBAmount.SelectAll()
                            txtDBAmount.Focus()
                            Return True
                            Exit Function
                        End If
                    End If
                End If

                If chkMarkAsUncollectible.Checked Then
                    If Msg("1069", Button.YesNo) = ButtonClicked.No Then
                        chkMarkAsUncollectible.Focus()
                        Return True
                        Exit Function
                    End If
                End If

        End Select

    End Function

#End Region

#Region "Command Buttons"

    Private Sub btnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNew.Click

        If My.Settings.RestrictDirectBillers AndAlso UserPrivilege = Privilege.transaction Then
            frmAuthorization.ShowDialog()
            If frmAuthorization.Result = False Then
                Exit Sub
            End If
        End If

        gState = State.adding

        DisplayRegistrations()
        chkRegisteredOnly.Enabled = True

        chkMarkAsUncollectible.Checked = False
        grpDirectBillerInfo.Enabled = True
        grpPersonalInfo.Enabled = False
        ClearControls(grpDirectBillerInfo)
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If dgvDirectBiller.SelectedRows.Count = 1 Then

            If My.Settings.RestrictDirectBillers AndAlso UserPrivilege = Privilege.transaction Then
                frmAuthorization.ShowDialog()
                If frmAuthorization.Result = False Then
                    Exit Sub
                End If
            End If

            gState = State.updating

            'Cannot edit Registration
            DisplayRegistrations()
            chkRegisteredOnly.Enabled = False

            grpDirectBillerInfo.Enabled = True
            grpPersonalInfo.Enabled = False
            ClearControls(grpDirectBillerInfo)

            With dgvDirectBiller
                txtDBName.Text = .Item(2, .CurrentRow.Index).Value.ToString
                txtDBAddress.Text = .Item(3, .CurrentRow.Index).Value.ToString
                txtDBContact.Text = .Item(4, .CurrentRow.Index).Value.ToString
                dtpDateIncurred.Value = CType(.Item(7, .CurrentRow.Index).Value, Date)
                dtpExpirationDate.Value = CType(.Item(8, .CurrentRow.Index).Value, Date)

                If .Item(9, .CurrentRow.Index).Value.ToString.ToUpper = "UNCOLLECTIBLE" Then
                    chkMarkAsUncollectible.Checked = True
                Else
                    chkMarkAsUncollectible.Checked = False
                End If

                txtDBAmount.Text = Format(CType(.Item(5, .CurrentRow.Index).Value, Double), "n")
                txtDBRemarks.Text = .Item(11, .CurrentRow.Index).Value.ToString
            End With

            DisplayRegistrations()

            txtDBName.SelectAll()
            txtDBName.Focus()

        Else
            Msg("1005")
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        frmParent.tssStatus.Text = String.Empty

        If dgvDirectBiller.SelectedRows.Count = 1 Then

            If My.Settings.RestrictDirectBillers AndAlso UserPrivilege = Privilege.transaction Then
                frmAuthorization.ShowDialog()
                If frmAuthorization.Result = False Then
                    Exit Sub
                End If
            End If

            If Not IsExisting("SELECT PID FROM PAYMENT WHERE DBID='" & dgvDirectBiller.Item(0, dgvDirectBiller.CurrentRow.Index).Value.ToString & "'") Then
                If Msg("1035", Button.YesNo) = ButtonClicked.No Then Exit Sub

                Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
                    objConnection.Open()
                    Using objTransaction As SqlTransaction = objConnection.BeginTransaction
                        Using objCommand As SqlCommand = objConnection.CreateCommand
                            With objCommand
                                .Transaction = objTransaction

                                Try
                                    .CommandText = "UPDATE REGISTRATION SET DBID=NULL WHERE DBID=@DBID"
                                    With .Parameters
                                        .Clear()
                                        .AddWithValue("@DBID", dgvDirectBiller.Item(0, dgvDirectBiller.CurrentRow.Index).Value)
                                    End With
                                    .ExecuteNonQuery()

                                    .CommandText = "DELETE FROM DIRECT_BILLER WHERE DBID=@DBID"
                                    With .Parameters
                                        .Clear()
                                        .AddWithValue("@DBID", dgvDirectBiller.Item(0, dgvDirectBiller.CurrentRow.Index).Value)
                                    End With
                                    .ExecuteNonQuery()

                                    objTransaction.Commit()
                                    DisplayDirectBiller()
                                    frmParent.tssStatus.Text = "Direct biller information was deleted..."

                                Catch ex As Exception

                                    objTransaction.Rollback()
                                    Msg("1008", Button.Ok, ex.Message)

                                End Try
                            End With
                        End Using
                    End Using
                    objConnection.Close()
                End Using

            Else
                Msg("1006", Button.Ok, "Cannot delete this record because it already has payments")
            End If
        Else
            Msg("1005")
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        gState = State.waiting
        grpDirectBillerInfo.Enabled = False
        grpPersonalInfo.Enabled = True
        chkMarkAsUncollectible.Checked = False
        lvwRegistration.Items.Clear()
        ClearControls(grpDirectBillerInfo)
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If ThereAreInputErrors() Then Exit Sub

        Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
            objConnection.Open()
            Using objTransaction As SqlTransaction = objConnection.BeginTransaction
                Using objCommand As SqlCommand = objConnection.CreateCommand
                    With objCommand

                        .Transaction = objTransaction
                        Try
                            Select Case gState
                                Case State.adding
                                    .CommandText = "INSERT INTO DIRECT_BILLER (DBID, DBName, DBAddress, DBContact, DBStatus, DBAmt, DBBalance, DBDate, DBExpDate, DBRemarks) " & _
                                                   "VALUES(@DBID, @DBName, @DBAddress, @DBContact, @DBStatus, @DBAmt, @DBBalance, @DBDate, @DBExpDate, @DBRemarks) "

                                    Dim strDBID As String = GetPrimaryKeyNo("Direct Biller")
                                    IncrementPrimaryKeyNo("Direct Biller")

                                    With .Parameters
                                        .Clear()
                                        .AddWithValue("@DBID", strDBID)
                                        .AddWithValue("@DBName", TrimAll(txtDBName.Text))
                                        .AddWithValue("@DBAddress", TrimAll(txtDBAddress.Text))
                                        .AddWithValue("@DBContact", TrimAll(txtDBContact.Text))

                                        If chkMarkAsUncollectible.Checked Then
                                            .AddWithValue("@DBStatus", "UNCOLLECTIBLE")
                                        Else
                                            .AddWithValue("@DBStatus", "UNPAID")
                                        End If

                                        .AddWithValue("@DBAmt", TrimAll(txtDBAmount.Text)).SqlDbType = SqlDbType.Money
                                        .AddWithValue("@DBBalance", TrimAll(txtDBAmount.Text)).SqlDbType = SqlDbType.Money
                                        .AddWithValue("@DBDate", dtpDateIncurred.Value).SqlDbType = SqlDbType.DateTime
                                        .AddWithValue("@DBExpDate", dtpExpirationDate.Value).SqlDbType = SqlDbType.DateTime
                                        .AddWithValue("@DBRemarks", TrimAll(txtDBRemarks.Text))
                                    End With
                                    .ExecuteNonQuery()

                                    .CommandText = "UPDATE REGISTRATION SET DBID=@DBID WHERE RegNo=@RegNo"
                                    With .Parameters
                                        .Clear()
                                        .AddWithValue("@DBID", strDBID)
                                        .AddWithValue("@RegNo", lvwRegistration.FocusedItem.Text)
                                    End With
                                    .ExecuteNonQuery()

                                Case State.updating

                                    .CommandText = "UPDATE DIRECT_BILLER SET DBName=@DBName, DBAddress=@DBAddress, DBContact=@DBContact, " & _
                                                   "DBStatus=@DBStatus, DBAmt=@DBAmt, DBBalance=@DBBalance, DBDate=@DBDate, DBExpDate=@DBExpDate, " & _
                                                   "DBRemarks=@DBRemarks " & _
                                                   "WHERE DBID=@DBID "
                                    With .Parameters
                                        .Clear()
                                        .AddWithValue("@DBID", dgvDirectBiller.Item(0, dgvDirectBiller.CurrentRow.Index).Value.ToString)
                                        .AddWithValue("@DBName", TrimAll(txtDBName.Text))
                                        .AddWithValue("@DBAddress", TrimAll(txtDBAddress.Text))
                                        .AddWithValue("@DBContact", TrimAll(txtDBContact.Text))

                                        If chkMarkAsUncollectible.Checked Then
                                            .AddWithValue("@DBStatus", "UNCOLLECTIBLE")
                                        Else
                                            If CType(txtDBAmount.Text, Double) = CType(lblTotalPayment.Text, Double) Then
                                                .AddWithValue("@DBStatus", "PAID")
                                            Else
                                                .AddWithValue("@DBStatus", "UNPAID")
                                            End If
                                        End If

                                        .AddWithValue("@DBAmt", TrimAll(txtDBAmount.Text)).SqlDbType = SqlDbType.Money
                                        .AddWithValue("@DBBalance", CType(txtDBAmount.Text, Double) - CType(lblTotalPayment.Text, Double)).SqlDbType = SqlDbType.Money
                                        .AddWithValue("@DBDate", dtpDateIncurred.Value).SqlDbType = SqlDbType.DateTime
                                        .AddWithValue("@DBExpDate", dtpExpirationDate.Value).SqlDbType = SqlDbType.DateTime
                                        .AddWithValue("@DBRemarks", TrimAll(txtDBRemarks.Text))

                                    End With
                                    .ExecuteNonQuery()

                            End Select

                            objTransaction.Commit()
                            frmParent.tssStatus.Text = "Transaction Saved..."
                            DisplayDirectBiller()

                            gState = State.waiting
                            grpDirectBillerInfo.Enabled = False
                            grpPersonalInfo.Enabled = True
                            chkMarkAsUncollectible.Checked = False
                            lvwRegistration.Items.Clear()
                            ClearControls(grpDirectBillerInfo)

                        Catch ex As Exception

                            objTransaction.Rollback()
                            Msg("1008", Button.Ok, ex.Message)

                        End Try
                    End With
                End Using
            End Using
            objConnection.Close()
        End Using
    End Sub

#End Region

#Region "MISC"

    Private Sub lblClose_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblClose.LinkClicked
        Me.Close()
    End Sub

    Private Sub chkSelectAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSelectAll.CheckedChanged
        chkExceded.Enabled = Not chkSelectAll.Checked
        txtNameSearch.Enabled = Not chkSelectAll.Checked
        cboViewStatus.Enabled = Not chkSelectAll.Checked
        DisplayDirectBiller()
    End Sub

    Private Sub frmDirectBiller_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgvDirectBiller.AlternatingRowsDefaultCellStyle = SetAlternatingColor()
        DisplayDirectBiller()
    End Sub

    Private Sub dgvDirectBiller_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvDirectBiller.SelectionChanged

        If dgvDirectBiller.SelectedRows.Count = 1 Then
            lblTotalAmount.Text = Format(TotalCharges(dgvDirectBiller.Item(0, dgvDirectBiller.CurrentRow.Index).Value.ToString, Transaction.DirectBiller), "n")
            lblTotalPayment.Text = Format(TotalPayments(dgvDirectBiller.Item(0, dgvDirectBiller.CurrentRow.Index).Value.ToString, Transaction.DirectBiller), "n")
            lblTotalBalance.Text = Format(CType(lblTotalAmount.Text, Double) - CType(lblTotalPayment.Text, Double), "n")
        End If

    End Sub

    Private Sub chkRegisteredOnly_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRegisteredOnly.CheckedChanged
        DisplayRegistrations()
    End Sub

    Private Sub lvwRegistration_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvwRegistration.SelectedIndexChanged
        If gState = State.adding AndAlso lvwRegistration.SelectedItems.Count = 1 Then
            txtDBAmount.Text = lvwRegistration.FocusedItem.SubItems(4).Text
        End If
    End Sub

    Private Sub chkExceded_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkExceded.CheckedChanged
        DisplayDirectBiller()
    End Sub

    Private Sub txtNameSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNameSearch.TextChanged
        DisplayDirectBiller()
    End Sub

    Private Sub cboViewStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboViewStatus.SelectedIndexChanged
        DisplayDirectBiller()
    End Sub

#End Region

#Region "Side Bars"

    Private Sub tsbActGuestInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbActGuestInfo.Click
        Display(Forms.frmGuestInformation)
        frmGuestInformation.FillMe()
    End Sub

    Private Sub tsbPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbBilling.Click
        Display(Forms.frmPayment)
        frmPayment.FillMe()
    End Sub

    Private Sub tsbGuestFolio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbFolio.Click
        Display(Forms.frmGuestFolio)
        frmGuestFolio.FillMe()
    End Sub

#End Region

End Class