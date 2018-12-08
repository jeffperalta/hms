Option Explicit On
Option Strict On

Imports System.Data
Imports System.Data.SqlClient

' Programmer:   Jo Jefferson D. Peralta
' Date:         March 18, 2007
' Title:        frmAmenitiesAndServices
' Purpose:      This interface adds amenities and services and charge this either to the room
'               of a guest or to the whole registration
' Requirements: ->  (+)FOLIO_DETAILS(FDNo, FDReceiptNo, FDDate, FDCharge, FDName, FDModifiedByAmt, FDModifiedByPercent, FDModifiedCharge, FDBalance, FDRemarks, FDStat, FDServiceRep, FDDesc, RegDNo, SID, ResNo)
'               ->  (-)FOLIO_DETAILS(FDNo)
'               ->  (+)SERVICES_AND_AMENETIES(SID, SDesc, SDeptName, SStat)
'               ->  (*)REGISTRATION(RegAmt, RegBalance)
'               ->  Unique Value at FDReceiptNo
'               ->  Money Transactions should not be a negative number
'               ->  A tuple is added in the SERVICES_AND_AMENITIES table when a new combination of department and service is typed in the combo boxes
'               ->  When the user does not provided for the slip no the application will automatically generate it, that is - equal to FDno
'               ->  User can only delete recent sevices but must use the guest folio interface to delete a service(this will be authorized by the manager)
' Results:      ->  A new services and amenities are charged to the Room or the registration of a guest
'               ->  Recently added services can be removed from the list
'               ->  A new service and amenity is added to the SERVICE_AND_AMENITIES table.
'msg

Public Class frmAmenitiesAndServices

    Private gRegNo As String = String.Empty
    Private gState As State = State.waiting
    Private gGIID As String = String.Empty

#Region "Functions/Subroutines"

    Public Sub FillMe()

        Try

            If RegistrationIsNotSet Then
                Msg("1045")
                Exit Sub
            End If

            If Not IsExisting("SELECT REGNO FROM REGISTRATION WHERE REGISTRATION.RegNo='" & SearchedRegistrationNo & "' AND RegStat='REGISTERED'; ") Then
                Msg("1045")
                Exit Sub
            End If

            If gState <> State.waiting Then
                Select Case Msg("1033", Button.YesNoCancel)
                    Case ButtonClicked.Yes
                        If ThereAreInputErrors() Then
                            Exit Sub
                        Else
                            btnSave_Click(Nothing, Nothing)
                        End If
                    Case ButtonClicked.No
                        'Continue
                    Case ButtonClicked.Cancel
                        Exit Sub
                End Select
            End If

            gRegNo = SearchedRegistrationNo
            gGIID = SearchedGuestID

            Using objConnection As SqlConnection = SetUpConnection(DatabasePath(), True)
                objConnection.Open()
                Using objCommand As SqlCommand = New SqlCommand("SELECT ISNULL(GITitle,'') , ISNULL(GIFName,''), ISNULL(GILName,''), ISNULL(GIMI,'') FROM GUEST_INFO WHERE GIID='" & gGIID & "'", objConnection)
                    Using objDataReader As SqlDataReader = objCommand.ExecuteReader

                        lblGuest.Text = String.Empty
                        objDataReader.Read()
                        lblGuest.Text &= objDataReader(0).ToString & " " & objDataReader(1).ToString & " " & objDataReader(3).ToString & " " & objDataReader(2).ToString

                    End Using
                End Using
                objConnection.Close()
            End Using

            DisplayRooms()
            lsvAmenitiesAndServices.Items.Clear()
            lblNoOfAmenitiesAndServices.Text = "0"
            lblSubTotal.Text = "0"

            UpdateTotals()
            gState = State.updating

        Catch ex As Exception
            ClearControls(Me)
        End Try

    End Sub

    Private Sub DisplayRooms()

        If gRegNo <> String.Empty Then
            lblNumberOfRegisteredRooms.Text = ListItems(DatabasePath, _
                "SELECT ROOM.RMNo AS [Room No], ROOM.RMType AS [Room Type], REGISTRATION_DETAILS.RegDNoGuest AS [No of Guests],  " & _
                "       REGISTRATION_DETAILS.RegDStat AS Status, REGISTRATION_DETAILS.RegDRemarks AS Remarks,  " & _
                "       REGISTRATION_DETAILS.RegDNo AS [Accommodation No.] " & _
                "FROM   REGISTRATION_DETAILS INNER JOIN " & _
                "       ROOM ON REGISTRATION_DETAILS.RMNo = ROOM.RMNo " & _
                "WHERE  (REGISTRATION_DETAILS.RegNo = '" & gRegNo & "') AND (REGISTRATION_DETAILS.RegDStat = 'REGISTERED') ", _
                dgvRegisteredRoom).ToString
        End If

    End Sub

    Private Sub DisplayDepartment()
        ListItems(DatabasePath, "SELECT DISTINCT SDeptName FROM SERVICES_AND_AMENITIES ", _
                  cboDepartment, "SDeptName")
        cboDepartment.Text = String.Empty
    End Sub

    Private Sub DisplayAmenities()
        ListItems(DatabasePath, "SELECT DISTINCT SDesc FROM SERVICES_AND_AMENITIES WHERE SDeptName='" & _
                TrimAll(cboDepartment.Text, True) & "'", _
                cboService, "SDesc")
        cboService.Text = String.Empty
    End Sub

    Private Function ThereAreInputErrors() As Boolean

        If gRegNo = String.Empty Then
            Msg("1045", , "Please specify the registration to which this amenity should be charged.")
            Return True
            Exit Function
        End If

        If Trim(txtSlipNo.Text) <> String.Empty AndAlso IsExisting("SELECT FDNo FROM FOLIO_DETAILS WHERE FDReceiptNo='" & TrimAll(txtSlipNo.Text, True) & "'") Then
            Msg("1002", , "Cannot have duplicate values for this input field")
            txtSlipNo.SelectAll()
            txtSlipNo.Focus()
            Return True
            Exit Function
        End If

        If Trim(txtAmount.Text) = String.Empty Then
            Msg("1000", , "Saving will not continue until the required information is specified.")
            txtAmount.SelectAll()
            txtAmount.Focus()
            Return True
            Exit Function
        End If

        If Not IsNumeric(txtAmount.Text) Then
            Msg("1001", , "Please check your input. A numeric value is required")
            txtAmount.SelectAll()
            txtAmount.Focus()
            Return True
            Exit Function
        Else
            If CType(txtAmount.Text, Double) < 0 Then
                Msg("1001", , "Please check your input. A positive value is required.")
                txtAmount.SelectAll()
                txtAmount.Focus()
                Return True
                Exit Function
            End If
        End If

        If Trim(cboDepartment.Text) = String.Empty Then
            Msg("1000", , "Saving will not continue until the required information is specified.")
            cboDepartment.SelectAll()
            cboDepartment.Focus()
            Return True
            Exit Function
        End If

        If Trim(cboService.Text) = String.Empty Then
            Msg("1000", , "Saving will not continue until the required information is specified.")
            cboService.SelectAll()
            cboService.Focus()
            Return True
            Exit Function
        End If

        If radRegistration.Checked = False And radRoom.Checked = False Then
            Msg("1045", , "Please specify where the amenity should be added.")
            radRegistration.Focus()
            Return True
            Exit Function
        Else
            If radRoom.Checked AndAlso dgvRegisteredRoom.SelectedRows.Count = 0 Then
                Msg("1045", , "Please specify the room from where this amenity should be applied.")
                dgvRegisteredRoom.Focus()
                Return True
                Exit Function
            End If
        End If

        Return False
    End Function

    Private Sub AddToList(ByVal FDno As String, Optional ByVal ChargeTo As String = "REGISTRATION")

        Dim myListViewItem As ListViewItem = lsvAmenitiesAndServices.Items.Add(FDno)

        myListViewItem.SubItems.Add(txtSlipNo.Text)
        myListViewItem.SubItems.Add(TrimAll(cboService.Text, True))
        myListViewItem.SubItems.Add(txtAmount.Text)
        myListViewItem.SubItems.Add(ChargeTo)
        myListViewItem.SubItems.Add(TrimAll(cboDepartment.Text, True))
        myListViewItem.SubItems.Add(txtPersonnel.Text)
        myListViewItem.SubItems.Add(txtRemarks.Text)

        lblNoOfAmenitiesAndServices.Text = lsvAmenitiesAndServices.Items.Count.ToString
        lblSubTotal.Text = Format(CType(lblSubTotal.Text, Double) + CType(txtAmount.Text, Double), "n")

        ClearControls(Me)
        txtSlipNo.Focus()
    End Sub

    Private Sub UpdateTotals()

        lblTotalCharges.Text = Format(TotalCharges(gRegNo, Transaction.Registration), "n")
        lblTotalPayments.Text = Format(TotalPayments(gRegNo, Transaction.Registration), "n")
        lblTotalBalance.Text = Format(CType(lblTotalCharges.Text, Double) - CType(lblTotalPayments.Text, Double), "n")

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

                        Dim strSid As String = String.Empty

                        .Transaction = objTransaction

                        Try
                            'Check if the Service is new
                            If Not IsExisting("SELECT SID FROM SERVICES_AND_AMENITIES WHERE SDesc='" & TrimAll(cboService.Text, True) & "' AND SDeptName='" & TrimAll(cboDepartment.Text, True) & "'") Then
                                .CommandText = "INSERT INTO SERVICES_AND_AMENITIES (SID, SDesc, SDeptName, SStat) VALUES (@SID, @SDesc, @SDeptName, @SStat)"

                                strSid = GetPrimaryKeyNo("ServicesAndAmenities")
                                IncrementPrimaryKeyNo("ServicesAndAmenities")

                                With .Parameters
                                    .Clear()
                                    .AddWithValue("@SID", strSid)
                                    .AddWithValue("@SDesc", TrimAll(cboService.Text, True))
                                    .AddWithValue("@SDeptName", TrimAll(cboDepartment.Text, True))
                                    .AddWithValue("@SStat", 1).SqlDbType = SqlDbType.Bit
                                End With

                                .ExecuteNonQuery()
                            Else

                                .CommandText = "SELECT SID FROM SERVICES_AND_AMENITIES WHERE SDesc=@SDesc AND SDeptName=@SDeptName"

                                .Parameters.Clear()
                                .Parameters.AddWithValue("@SDesc", TrimAll(cboService.Text, True))
                                .Parameters.AddWithValue("@SDeptName", TrimAll(cboDepartment.Text, True))
                                strSid = .ExecuteScalar.ToString

                            End If  'Set value of StrSid

                            Dim blnChargeToRegistration As Boolean = False
                            If radRoom.Checked Then 'Charge to a room
                                .CommandText = "INSERT INTO FOLIO_DETAILS (FDNo, FDReceiptNo, FDDate, FDCharge, FDName, FDModifiedByAmt, FDModifiedByPercent, FdModifiedCharge, FDBalance, FdRemarks, FDStat, FDServiceRep, FDDesc, RegDNo, RegNo, SID) " & _
                                               "VALUES(@FDNo, @FDReceiptNo, @FDDate, @FDCharge, @FDName, 0, 0, @FdModifiedCharge, @FDBalance, @FdRemarks, 'UNPAID', @FDServiceRep, 'SERVICE', @RegDNo, @RegNo, @SID)"
                                blnChargeToRegistration = False
                            Else 'Charge to a registration
                                .CommandText = "INSERT INTO FOLIO_DETAILS (FDNo, FDReceiptNo, FDDate, FDCharge, FDName, FDModifiedByAmt, FDModifiedByPercent, FdModifiedCharge, FDBalance, FdRemarks, FDStat, FDServiceRep, FDDesc, RegNo, SID) " & _
                                               "VALUES(@FDNo, @FDReceiptNo, @FDDate, @FDCharge, @FDName, 0, 0, @FdModifiedCharge, @FDBalance, @FdRemarks, 'UNPAID', @FDServiceRep, 'SERVICE', @RegNo, @SID)"
                                blnChargeToRegistration = True
                            End If

                            Dim StrPrimaryKey As String = GetPrimaryKeyNo("FDNo")
                            IncrementPrimaryKeyNo("FDNo")

                            With .Parameters

                                .Clear()
                                .AddWithValue("@FDNo", StrPrimaryKey)

                                If Trim(txtSlipNo.Text) = String.Empty Then
                                    .AddWithValue("@FDReceiptNo", StrPrimaryKey)
                                Else
                                    .AddWithValue("@FDReceiptNo", TrimAll(txtSlipNo.Text))
                                End If

                                .AddWithValue("@FDDate", dtpDateIncurred.Value).SqlDbType = SqlDbType.DateTime
                                .AddWithValue("@FDCharge", txtAmount.Text).SqlDbType = SqlDbType.Money
                                .AddWithValue("@FDName", TrimAll(cboService.Text, True))
                                .AddWithValue("@FDBalance", txtAmount.Text).SqlDbType = SqlDbType.Money
                                .AddWithValue("@FDModifiedCharge", txtAmount.Text).SqlDbType = SqlDbType.Money
                                .AddWithValue("@FDRemarks", TrimAll(txtRemarks.Text))
                                .AddWithValue("@FDServiceRep", TrimAll(txtPersonnel.Text))
                                .AddWithValue("@RegNo", gRegNo)
                                .AddWithValue("@RegDNo", dgvRegisteredRoom.Item(5, dgvRegisteredRoom.CurrentRow.Index).Value)
                                .AddWithValue("@SID", strSid)

                            End With

                            .ExecuteNonQuery()

                            .CommandText = "UPDATE REGISTRATION SET RegAmt = RegAmt + @FDCharge, RegBalance = RegBalance + @FDCharge WHERE RegNo=@RegNo; "

                            With .Parameters
                                .Clear()
                                .AddWithValue("@FDCharge", txtAmount.Text).SqlDbType = SqlDbType.Money
                                .AddWithValue("@RegNo", gRegNo)
                            End With

                            .ExecuteNonQuery()

                            objTransaction.Commit()
                            frmParent.tssStatus.Text = "The transaction was saved..."
                            gState = State.waiting

                            If blnChargeToRegistration Then
                                AddToList(StrPrimaryKey)
                            Else
                                AddToList(StrPrimaryKey, "ROOM " & dgvRegisteredRoom.Item(0, dgvRegisteredRoom.CurrentRow.Index).Value.ToString)
                            End If

                            UpdateTotals()
                            DisplayDepartment()

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

    Private Sub tlsRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlsRemove.Click
        If lsvAmenitiesAndServices.Items.Count > 0 Then
            If Msg("1035", Button.YesNo) = ButtonClicked.No Then Exit Sub

            Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
                objConnection.Open()
                Using objTransaction As SqlTransaction = objConnection.BeginTransaction
                    Using objCommand As SqlCommand = objConnection.CreateCommand
                        With objCommand
                            .Transaction = objTransaction
                            Try
                                .CommandText = "DELETE FROM FOLIO_DETAILS WHERE FDNo=@FDNo"
                                .Parameters.AddWithValue("@FDNo", lsvAmenitiesAndServices.FocusedItem.Text)

                                .ExecuteNonQuery()

                                objTransaction.Commit()
                                frmParent.tssStatus.Text = "Item was deleted..."

                                lblSubTotal.Text = Format(CType(lblSubTotal.Text, Double) - CType(lsvAmenitiesAndServices.FocusedItem.SubItems(3).Text, Double), "n")
                                lsvAmenitiesAndServices.FocusedItem.Remove()
                                lblNoOfAmenitiesAndServices.Text = lsvAmenitiesAndServices.Items.Count.ToString

                                UpdateTotals()

                            Catch ex As Exception

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

    Private Sub cboDepartment_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboDepartment.Validating
        DisplayAmenities()
    End Sub

    Private Sub radRoom_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radRoom.CheckedChanged
        gbxRegisteredRoom.Enabled = radRoom.Checked
    End Sub

    Private Sub frmAmenitiesAndServices_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DisplayDepartment()
        DisplayAmenities()
        lblGuest.Text = "NONE"
    End Sub

    Private Sub _TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSlipNo.TextChanged, txtAmount.TextChanged, txtPersonnel.TextChanged, txtRemarks.TextChanged
        Dim ThisControl As TextBox = CType(sender, TextBox)
        If ThisControl.Text <> String.Empty Then
            If gRegNo <> String.Empty Then gState = State.updating
        End If
    End Sub

    Private Sub frmAmenitiesAndServices_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.BringToFront()
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
        Else
            e.Cancel = False
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
    End Sub

#End Region

#Region "TabButtons"

    Private Sub tsbGuestSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuestSearch.Click
        TriggeredBy = TriggeringForm.AmenitiesAndServices
        frmGuestSearch.ShowDialog()
    End Sub

#End Region

#Region "Side Bars"

    Private Sub ToolStripButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton8.Click
        SearchedRegistrationNo = gRegNo
        SearchedGuestID = gGIID
        Display(Forms.frmGuestFolio)
        frmGuestFolio.FillMe()
    End Sub

    Private Sub ToolStripButton13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton13.Click
        SearchedRegistrationNo = gRegNo
        SearchedGuestID = gGIID
        Display(Forms.frmGuestInformation)
        frmGuestInformation.FillMe()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        SearchedRegistrationNo = gRegNo
        SearchedGuestID = gGIID
        Display(Forms.frmPayment)
        frmPayment.FillMe()
    End Sub

#End Region
  
End Class