Option Explicit On
Option Strict On

Imports System.Data
Imports System.Data.SqlClient

' Programmer:   Jo Jefferson D. Peralta
' Date:         March 06, 2007
' Title:        frmRoomSettings
' Purpose:      ->  The user can view existing rooms in the hotel and use the search criteria to
'                   easily go through each room information.
'               ->  This interface is used to add new room, edit the previous, and delete room information.
'               ->  On the sidebar, the user can go to another interface that adds new facilities/features
'                   and also to another form that adds new room types and rates
'               ->  The user can add multiple rooms by delimiting the input with commas(,)
'                   However, the user must ensure that the information such as room floor, view, and number of occupants
'                   are common for those rooms.
'               ->  The user can also add rooms using the previously defined room information.
'                   The user must select the edit button and delimit the room number field with commas(,). In this case,
'                   the form will prompt the user if he likes to ADD (instead of editing) the rooms using the 
'                   original information that he intends to edit.
'               ->  In this interface the user can also assign multiple room rates
'                   However the user must specify the CURRENT among the rates that was assigned in a room.
'                   To do this right click on the list of available room rates.
'               ->  The user can also assign available features/facilities in a room.
'               ->  If a new room rate was created and the manager would like to assign it to an existing rooms, it will
'                   be very inconvinient if he starts to edit each rooms and include that rate using this interface
'                   So a new form is created the frmUpdateRoomCharges.
' Requirements: ->  (-/+/*)ROOM (RMNO, RMDesc, RMMaxGuest, FMFloor, RMView, RMTelNo, RMType, RMCurrStat, RMRemarks)
'               ->  [DELETE CASCADE](-)RMRATE_DETAILS(RMNo, RMRID, RMDActive) 
'               ->  [DELETE CASCADE](-)RMFEATURE_DETAILS(RMFID, RMNo)
'               ->  (+/*) RMRATE_DETAILS(RMNo, RMRID, RMDActive)
'               ->  (+/*) RMFEATURE_DETAILS(RMFID, RMNo)
'               ->  Deletion will not continue if a room is already reserved or registered
'               ->  If the user would like to delete a room but the above requirement is in effect
'                   He can go to the room rack interface to apply the appropriate status for the room
'                   So the room cannot be reserved or registered.
'               ->  Required Fields at RMNo, RmMaxGuest, RMType
'               ->  At least one RMDActive is equal to 'TRUE' (This is the current rate)
'               ->  RMCurrStat is by default equal to 'CLEAN'
' Results:      ->  A new room information is added.
'               ->  The previous information are edited and/or deleted
'               ->  A new rate can be assigned to an existing room using this interface, 
'                   however there is a more dedicated interface for this purpose.
'               ->  Room information are viewed using the search facility of this interface.
'>>>MessageDone

Public Class frmRoomSettings

    Private gState As State = State.waiting
    Private gRoomNo() As String
    Private SaveThisRoom As ArrayList = New ArrayList

#Region "Functions/SubRoutines"

    Private Sub DisplayRooms()

        Dim strRoomType As String = TrimAll(cboRoomTypeExistingRoom.Text, True)
        Dim strRateName As String = TrimAll(cboViewRateName.Text, True)
        Dim strFeatureAndFacility As String = TrimAll(cboFeatureAndFacility.Text, True)

        Dim CommandString As String = "SELECT DISTINCT  " & _
                                      "       ROOM.RMNo AS [Room No], ROOM.RMType AS Type, RMRATE.RMRAmt AS Rate, RMRATE.RMRName AS [Rate Name], ISNULL(ROOM.RMFloor,'') AS Floor ,  " & _
                                      "       ISNULL(ROOM.RMView,'') AS [View], ISNULL(ROOM.RMDesc,'') AS Description, ROOM.RMMaxGuest AS [Maximum Guest], ISNULL(ROOM.RMTelNo,'') AS [Tel No],  " & _
                                      "       ISNULL(ROOM.RMRemarks,'') AS Remarks " & _
                                      "FROM   RMFEATURE INNER JOIN " & _
                                      "       RMFEATURE_DETAILS ON RMFEATURE.RMFID = RMFEATURE_DETAILS.RMFID RIGHT OUTER JOIN " & _
                                      "       ROOM INNER JOIN " & _
                                      "       RMRATE_DETAILS ON ROOM.RMNo = RMRATE_DETAILS.RMNo INNER JOIN " & _
                                      "       RMRATE ON RMRATE_DETAILS.RMRID = RMRATE.RMRID ON RMFEATURE_DETAILS.RMNo = ROOM.RMNo " & _
                                      "WHERE  (RMRATE_DETAILS.RMDActive = 'TRUE') "

        If Not chkDisplayAll.Checked Then
            If strRoomType <> String.Empty Then
                CommandString &= "AND ROOM.RMType = '" & strRoomType & "' "
            End If

            If strRateName <> String.Empty Then
                CommandString &= "AND RMRATE.RMRName ='" & strRateName & "' "
            End If

            If strFeatureAndFacility <> String.Empty Then
                CommandString &= "AND (RMFEATURE.RMFName = '" & strFeatureAndFacility & "') "
            End If
        End If

        lblCount.Text = ListItems(DatabasePath, CommandString, dgvExistingRoom).ToString()
    End Sub

    ''' <summary>
    ''' Displays the selections of all room rates and types
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub DisplayRoomRatesAndTypes()

        If gState <> State.waiting Then
            ListItems(lsvRoomRatesAndTypes, _
                      SetUpDataSet(SetUpDataAdapter(SetUpConnection(DatabasePath, True), _
                        "SELECT RMRName AS [Rate Name], RMRAmt AS [Amount], RMRStartTime AS [Start On], RMREndTime AS [End On], RMRType AS [Applied to Room Type], RMRRemarks AS [Remarks], RMRID as [Rate No] FROM RMRATE ORDER BY RMRType ", _
                        DatabaseTransactionState.SelectState), "RATES"), _
                      "RATES")

            If gState = State.updating Then
                Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
                    objConnection.Open()
                    Using objCommand As SqlCommand = New SqlCommand("SELECT RMRATE.RMRID, RMRATE.RMRName, RMRATE.RMRAmt " & _
                                                                    "FROM   RMRATE_DETAILS INNER JOIN " & _
                                                                    "       RMRATE ON RMRATE_DETAILS.RMRID = RMRATE.RMRID " & _
                                                                    "WHERE  (RMRATE_DETAILS.RMNo = '" & dgvExistingRoom.Item(0, dgvExistingRoom.CurrentRow.Index).Value.ToString & "') ", objConnection)
                        Using objReader As SqlDataReader = objCommand.ExecuteReader
                            Do While objReader.Read
                                For Each ctlItem As ListViewItem In lsvRoomRatesAndTypes.Items
                                    If String.Compare(objReader(0).ToString, ctlItem.SubItems(6).Text, True) = 0 Then
                                        ctlItem.Checked = True
                                        lblRateNo.Text = objReader(0).ToString
                                        lblCurrentRateName.Text = objReader(1).ToString
                                        lblRate.Text = objReader(2).ToString
                                        Continue Do
                                    End If
                                Next
                            Loop
                        End Using
                    End Using

                    objConnection.Close()
                End Using
            End If

            With lsvRoomRatesAndTypes
                .Columns(0).Width = 240 'Rate Name
                .Columns(1).Width = 90 'Amount
                .Columns(1).TextAlign = HorizontalAlignment.Right
                .Columns(2).Width = 140 'Starts On
                .Columns(3).Width = 140 'Ends On
                .Columns(4).Width = 200 'Room Type
                .Columns(5).Width = 300 'Remarks
                .Columns(6).Width = 90 'Rate No
            End With

        End If

    End Sub

    ''' <summary>
    ''' Displays the selections of all features and facilities
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub DisplayAmenitiesAndServices()

        If gState <> State.waiting Then
            ListItems(lsvFeaturesAndFacilities, _
                        SetUpDataSet(SetUpDataAdapter(SetUpConnection(DatabasePath, True), _
                        "SELECT RMFName as [Name], RMFRemarks AS [Remarks], RMFID as [Feature No] FROM RMFeature WHERE RMFStatus='TRUE'", _
                         DatabaseTransactionState.SelectState), "AmenitiesAndServices"), _
                      "AmenitiesAndServices")

            If gState = State.updating Then
                Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
                    objConnection.Open()
                    Using objCommand As SqlCommand = New SqlCommand("SELECT RMFEATURE.RMFName " & _
                                                                    "FROM   RMFEATURE_DETAILS INNER JOIN " & _
                                                                    "       RMFEATURE ON RMFEATURE_DETAILS.RMFID = RMFEATURE.RMFID " & _
                                                                    "WHERE  (RMFEATURE_DETAILS.RMNo = '" & dgvExistingRoom.Item(0, dgvExistingRoom.CurrentRow.Index).Value.ToString & "') ", _
                                                                    objConnection)

                        Using objReader As SqlDataReader = objCommand.ExecuteReader
                            Do While objReader.Read
                                For Each ctlItem As ListViewItem In lsvFeaturesAndFacilities.Items
                                    If String.Compare(objReader(0).ToString, ctlItem.Text, True) = 0 Then
                                        ctlItem.Checked = True
                                        Continue Do
                                    End If
                                Next
                            Loop
                        End Using

                    End Using
                    objConnection.Close()
                End Using
            End If

            With lsvFeaturesAndFacilities
                .Columns(0).Width = 200 'Name
                .Columns(1).Width = 500 'Remarks
                .Columns(2).Width = 119 'No
            End With

        End If
    End Sub

    Private Function ThereAreInputErrors() As Boolean

        If Trim(txtRoomNo.Text) = String.Empty Then
            Msg("1000")
            txtRoomNo.SelectAll()
            txtRoomNo.Focus()
            Return True
            Exit Function
        End If

        If Trim(txtNoOfOccupants.Text) = String.Empty Then
            Msg("1000")
            txtNoOfOccupants.SelectAll()
            txtNoOfOccupants.Focus()
            Return True
            Exit Function
        End If

        If Not IsNumeric(txtNoOfOccupants.Text) Then
            Msg("1001", , "The No. of Occupants must be a number")
            txtNoOfOccupants.SelectAll()
            txtNoOfOccupants.Focus()
            Return True
            Exit Function
        Else
            txtNoOfOccupants.Text = CType(txtNoOfOccupants.Text, Integer).ToString
            If CType(txtNoOfOccupants.Text, Integer) < 0 Then
                Msg("1001", , "The no. of occupants must be a positive number")
                txtNoOfOccupants.SelectAll()
                txtNoOfOccupants.Focus()
                Return True
                Exit Function
            End If
        End If

        If Trim(cboRoomType.Text) = String.Empty Then
            Msg("1000")
            cboRoomType.SelectAll()
            cboRoomType.Focus()
            tbcRoomSettings.SelectedIndex = 0
            Return True
            Exit Function
        End If

        If lblRateNo.Text = String.Empty Then
            Msg("1038", , "You must specify the current room rate" & NWLN & "Right Click on the list to define it.")
            tbcRoomSettings.SelectedIndex = 0
            Return True
            Exit Function
        End If

        SaveThisRoom.Clear()
        For intRoomNo As Integer = 0 To gRoomNo.GetUpperBound(0)
            gRoomNo(intRoomNo) = TrimAll(gRoomNo(intRoomNo), True)
            If gRoomNo(intRoomNo) <> String.Empty Then
                SaveThisRoom.Add(gRoomNo(intRoomNo))
            End If
        Next

        If SaveThisRoom.Count = 0 Then
            Msg("1039", , "You have not specified any room")
            txtRoomNo.SelectAll()
            txtRoomNo.Focus()
            Return True
            Exit Function
        Else
            If gState = State.updating AndAlso SaveThisRoom.Count > 1 Then
                If Msg("1041", Button.YesNo, "You cannot edit more than one room. However would you like to use this template to add another room") = ButtonClicked.Yes Then
                    gState = State.adding
                    frmParent.tssStatus.Text = "Adding a room using the template of room " & dgvExistingRoom.Item(0, dgvExistingRoom.CurrentRow.Index).Value.ToString

                    Do While txtRoomNo.Text.Contains(dgvExistingRoom.Item(0, dgvExistingRoom.CurrentRow.Index).Value.ToString)
                        txtRoomNo.Text = txtRoomNo.Text.Remove(txtRoomNo.Text.IndexOf(dgvExistingRoom.Item(0, dgvExistingRoom.CurrentRow.Index).Value.ToString), dgvExistingRoom.Item(0, dgvExistingRoom.CurrentRow.Index).Value.ToString.Length)
                    Loop
                Else
                    txtRoomNo.Select(txtRoomNo.Text.IndexOf(","), txtRoomNo.Text.Length)
                    txtRoomNo.Focus()
                End If

                If SaveThisRoom.Count > 1 Then
                    txtTelNo.Text = String.Empty
                    txtTelNo.Enabled = False
                End If

                txtRoomNo.SelectAll()
                txtRoomNo.Focus()
                Return True
                Exit Function
            End If
        End If

        For intCtr1 As Integer = 0 To SaveThisRoom.Count - 2
            For intCtr2 As Integer = intCtr1 + 1 To SaveThisRoom.Count - 1
                If String.Compare(CType(SaveThisRoom(intCtr1), String), CType(SaveThisRoom(intCtr2), String)) = 0 Then
                    Msg("1002")
                    txtRoomNo.SelectAll()
                    txtRoomNo.Focus()
                    Return True
                    Exit Function
                End If
            Next
        Next

        If gState = State.adding Or _
            (gState = State.updating AndAlso _
                    String.Compare(SaveThisRoom(0).ToString, dgvExistingRoom.Item(0, dgvExistingRoom.CurrentRow.Index).Value.ToString, True) <> 0) Then
            For intCtr1 As Integer = 0 To SaveThisRoom.Count - 1
                If IsExisting("SELECT RMNo FROM ROOM WHERE RMNo='" & SaveThisRoom(intCtr1).ToString & "'") Then
                    Msg("1002", , "Cannot insert duplicate value, this room number is already used")
                    txtRoomNo.Select(txtRoomNo.Text.IndexOf(SaveThisRoom(intCtr1).ToString), SaveThisRoom(intCtr1).ToString.Length)
                    txtRoomNo.Focus()
                    Return True
                    Exit Function
                End If
            Next
        End If

        Return False

    End Function

    Public Sub UpdateComboBoxes_FeaturesRatesTypes()
        ListItems(DatabasePath, "SELECT RMRName FROM RMRATE", cboViewRateName, "RMRName")
        ListItems(DatabasePath, "SELECT DISTINCT RMTYPE FROM ROOM UNION SELECT DISTINCT RMRTYPE FROM RMRATE", cboRoomTypeExistingRoom, "RMType")
        ListItems(DatabasePath, "SELECT DISTINCT RMTYPE FROM ROOM UNION SELECT DISTINCT RMRTYPE FROM RMRATE", cboRoomType, "RMType")
        ListItems(DatabasePath, "SELECT RMFName FROM RMFEATURE", cboFeatureAndFacility, "RMFName")
    End Sub

    Private Sub UpdateComboBoxes()
        ListItems(DatabasePath, "SELECT DISTINCT RMTYPE FROM ROOM UNION SELECT DISTINCT RMRTYPE FROM RMRATE", cboRoomTypeExistingRoom, "RMType")
        ListItems(DatabasePath, "SELECT DISTINCT RMTYPE FROM ROOM UNION SELECT DISTINCT RMRTYPE FROM RMRATE", cboRoomType, "RMType")
        ListItems(DatabasePath, "SELECT DISTINCT RMFloor FROM ROOM", cboFloor, "RMFloor")
        ListItems(DatabasePath, "SELECT DISTINCT RMView FROM ROOM", cboView, "RMView")
    End Sub

#End Region

#Region "Command Buttons"

    Private Sub btnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNew.Click

        gState = State.adding
        frmParent.tssStatus.Text = "Add new room..."

        gbxInput.Enabled = True
        gbxInput.BringToFront()
        gbxRooms.Enabled = False

        ClearControls(gbxInput)
        lblRateNo.Text = String.Empty
        lblCurrentRateName.Text = "NONE"
        lblRate.Text = "0.0000"

        DisplayRoomRatesAndTypes()
        DisplayAmenitiesAndServices()

        If lsvRoomRatesAndTypes.Items.Count = 0 Then
            Msg("1083", , "Please add a new room rate first.")
            frmRoomTypeAndRates.ShowDialog()
        End If

        txtRoomNo.Focus()
        txtRoomNo.SelectAll()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click

        ' 0 Room No
        ' 1 Room Type
        ' 2 Room Amt
        ' 3 Rate Name
        ' 4 Floor
        ' 5 View
        ' 6 Desc
        ' 7 Max Guest
        ' 8 TelNo
        ' 9 Remarks
        If dgvExistingRoom.SelectedRows.Count <> 0 Then
            gState = State.updating
            frmParent.tssStatus.Text = "Edit Room Information " & "(" & dgvExistingRoom.Item(0, dgvExistingRoom.CurrentRow.Index).Value.ToString & ")"

            gbxInput.Enabled = True
            gbxInput.BringToFront()
            gbxRooms.Enabled = False

            Dim intSelectedIndex As Integer = dgvExistingRoom.CurrentRow.Index

            txtRoomNo.Text = dgvExistingRoom.Item(0, intSelectedIndex).Value.ToString
            cboFloor.Text = dgvExistingRoom.Item(4, intSelectedIndex).Value.ToString
            cboView.Text = dgvExistingRoom.Item(5, intSelectedIndex).Value.ToString
            txtRMDescription.Text = dgvExistingRoom.Item(6, intSelectedIndex).Value.ToString
            txtNoOfOccupants.Text = dgvExistingRoom.Item(7, intSelectedIndex).Value.ToString
            txtTelNo.Text = dgvExistingRoom.Item(8, intSelectedIndex).Value.ToString
            txtRemarks.Text = dgvExistingRoom.Item(9, intSelectedIndex).Value.ToString

            DisplayRoomRatesAndTypes()
            DisplayAmenitiesAndServices()

            txtRoomNo.Focus()
            txtRoomNo.SelectAll()

        Else
            Msg("1005")
        End If

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        If dgvExistingRoom.SelectedRows.Count > 0 Then
            frmParent.tssStatus.Text = ""

            If IsExisting("SELECT RegDNo FROM REGISTRATION_DETAILS WHERE RMNO='" & dgvExistingRoom.Item(0, dgvExistingRoom.CurrentRow.Index).Value.ToString & "'") Then
                Msg("1006", , "Cannot delete this room because it was already registered")
                Exit Sub
            End If

            If IsExisting("SELECT ResNo FROM RESERVATION_DETAILS WHERE RMNo='" & dgvExistingRoom.Item(0, dgvExistingRoom.CurrentRow.Index).Value.ToString & "'") Then
                Msg("1006", , "Cannot delete this room because it is already reserved")
                Exit Sub
            End If

            If Msg("1035", Button.YesNo) = ButtonClicked.Yes Then
                Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
                    objConnection.Open()

                    Using objTransaction As SqlTransaction = objConnection.BeginTransaction
                        Using objCommand As SqlCommand = objConnection.CreateCommand
                            With objCommand
                                .Transaction = objTransaction
                                .CommandText = "DELETE FROM ROOM WHERE RMNo='" & dgvExistingRoom.Item(0, dgvExistingRoom.CurrentRow.Index).Value.ToString & "'"

                                Try
                                    .ExecuteNonQuery()
                                    objTransaction.Commit()

                                    DisplayRooms()

                                    frmParent.tssStatus.Text = "The room information is deleted..."
                                Catch ex As Exception

                                    objTransaction.Rollback()
                                    Msg("1008", Button.Ok, ex.Message)
                                End Try
                            End With
                        End Using
                    End Using

                    objConnection.Close()
                End Using
            End If

        Else
            Msg("1005")
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        frmParent.tssStatus.Text = ""

        gState = State.waiting
        gbxInput.Enabled = False
        gbxRooms.Enabled = True
        gbxRooms.BringToFront()

    End Sub

    Private Sub btnAddSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddSave.Click
        If ThereAreInputErrors() Then Exit Sub
        
        Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
            objConnection.Open()
            Using objTransaction As SqlTransaction = objConnection.BeginTransaction
                Using objCommand As SqlCommand = objConnection.CreateCommand
                    With objCommand
                        .Transaction = objTransaction
                        Select Case gState
                            Case State.adding
                                Try
                                    For Each strRoomNo As String In SaveThisRoom
                                        .CommandText = "INSERT INTO ROOM (RMNo, RMDesc, RMMaxGuest, RMFloor, RMView, RMTelNo, RMType, RMCurrStat, RMRemarks) " & _
                                                     "VALUES (@RMNo, @RMDesc, @RMMaxGuest, @RMFloor, @RMView, @RMTelNo, @RMType, @RMCurrStat, @RMRemarks)"

                                        With .Parameters
                                            .Clear()
                                            .AddWithValue("@RMNo", strRoomNo)
                                            .AddWithValue("@RMDesc", TrimAll(txtRMDescription.Text))
                                            .AddWithValue("@RMMaxGuest", Trim(txtNoOfOccupants.Text)).SqlDbType = SqlDbType.Int
                                            .AddWithValue("@RMFloor", TrimAll(cboFloor.Text))
                                            .AddWithValue("@RMView", TrimAll(cboView.Text))
                                            .AddWithValue("@RMTelNo", TrimAll(txtTelNo.Text))
                                            .AddWithValue("@RMType", TrimAll(cboRoomType.Text))
                                            .AddWithValue("@RMCurrStat", "CLEAN")
                                            .AddWithValue("@RMRemarks", TrimAll(txtRemarks.Text))
                                        End With


                                        .ExecuteNonQuery()

                                        For Each ctlItem As ListViewItem In lsvFeaturesAndFacilities.Items
                                            If ctlItem.Checked = True Then
                                                .CommandText = "INSERT INTO RMFEATURE_DETAILS (RMFID, RMNo) VALUES (@RMFID, @RMNo)"

                                                With .Parameters
                                                    .Clear()
                                                    .AddWithValue("@RMNo", strRoomNo)
                                                    .AddWithValue("@RMFID", ctlItem.SubItems(2).Text)
                                                End With

                                                .ExecuteNonQuery()
                                            End If
                                        Next

                                        For Each ctlItem As ListViewItem In lsvRoomRatesAndTypes.Items
                                            If ctlItem.Checked = True Then
                                                .CommandText = "INSERT INTO RMRATE_DETAILS (RMNo, RMRID, RMDActive) VALUES (@RMNo, @RMRID, @RMDActive)"

                                                With .Parameters
                                                    .Clear()
                                                    .AddWithValue("@RMNo", strRoomNo)
                                                    .AddWithValue("@RMRID", ctlItem.SubItems(6).Text)

                                                    If String.Compare(ctlItem.SubItems(6).Text, lblRateNo.Text, True) = 0 Then
                                                        .AddWithValue("@RMDActive", Boolean.TrueString).SqlDbType = SqlDbType.Bit
                                                    Else
                                                        .AddWithValue("@RMDActive", Boolean.FalseString).SqlDbType = SqlDbType.Bit
                                                    End If

                                                End With

                                                .ExecuteNonQuery()
                                            End If
                                        Next
                                    Next

                                    objTransaction.Commit()

                                    frmParent.tssStatus.Text = "A new room was added..."
                                    gState = State.waiting
                                    gbxInput.Enabled = False
                                    gbxRooms.Enabled = True
                                    gbxRooms.BringToFront()

                                    ClearControls(gbxInput)

                                    DisplayRooms()
                                    UpdateComboBoxes()

                                Catch ex As Exception
                                    objTransaction.Rollback()
                                    Msg("1008", Button.Ok, ex.Message)

                                End Try

                            Case State.updating

                                .CommandText = "UPDATE ROOM SET RMNo=@RMNo, RMDesc=@RMDesc, RMMaxGuest=@RMMaxGuest, RMFloor=@RMFloor, RMView=@RMView, RMTelNo=@RMTelNo, RMType=@RMType, RMRemarks=@RMRemarks WHERE RMNo=@RMNo_old"

                                With .Parameters
                                    .Clear()
                                    .AddWithValue("@RMNo", SaveThisRoom(0).ToString)
                                    .AddWithValue("@RMDesc", TrimAll(txtRMDescription.Text))
                                    .AddWithValue("@RMMaxGuest", Trim(txtNoOfOccupants.Text)).SqlDbType = SqlDbType.Int
                                    .AddWithValue("@RMFloor", TrimAll(cboFloor.Text))
                                    .AddWithValue("@RMView", TrimAll(cboView.Text))
                                    .AddWithValue("@RMTelNo", TrimAll(txtTelNo.Text))
                                    .AddWithValue("@RMType", TrimAll(cboRoomType.Text))
                                    .AddWithValue("@RMRemarks", TrimAll(txtRemarks.Text))
                                    .AddWithValue("@RMNo_old", dgvExistingRoom.Item(0, dgvExistingRoom.CurrentRow.Index).Value)
                                End With

                                Try
                                    .ExecuteNonQuery()

                                    'Use SaveThisRoom(0).ToString because the changes are cascaded
                                    .CommandText = "DELETE FROM RMFEATURE_DETAILS WHERE RMNO=@RMNo"
                                    .Parameters.Clear()
                                    .Parameters.AddWithValue("@RMNo", SaveThisRoom(0).ToString)
                                    .ExecuteNonQuery()

                                    For Each ctlItem As ListViewItem In lsvFeaturesAndFacilities.Items
                                        If ctlItem.Checked = True Then
                                            .CommandText = "INSERT INTO RMFEATURE_DETAILS (RMFID, RMNo) VALUES (@RMFID, @RMNo)"

                                            With .Parameters
                                                .Clear()
                                                .AddWithValue("@RMFID", Trim(ctlItem.SubItems(2).Text))
                                                .AddWithValue("@RMNo", Trim(SaveThisRoom(0).ToString))
                                            End With

                                            .ExecuteNonQuery()

                                        End If
                                    Next

                                    .CommandText = "DELETE FROM RMRATE_DETAILS WHERE RMNo=@RMNo"
                                    .Parameters.Clear()
                                    .Parameters.AddWithValue("@RMNo", SaveThisRoom(0).ToString)
                                    .ExecuteNonQuery()

                                    For Each ctlItem As ListViewItem In lsvRoomRatesAndTypes.Items
                                        If ctlItem.Checked = True Then
                                            .CommandText = "INSERT INTO RMRATE_DETAILS (RMNo, RMRID, RMDActive) VALUES (@RMNo, @RMRID, @RMDActive)"

                                            With .Parameters
                                                .Clear()
                                                .AddWithValue("@RMNo", SaveThisRoom(0).ToString)
                                                .AddWithValue("@RMRID", ctlItem.SubItems(6).Text)

                                                If String.Compare(ctlItem.SubItems(6).Text, lblRateNo.Text, True) = 0 Then
                                                    .AddWithValue("@RMDActive", Boolean.TrueString).SqlDbType = SqlDbType.Bit
                                                Else
                                                    .AddWithValue("@RMDActive", Boolean.FalseString).SqlDbType = SqlDbType.Bit
                                                End If

                                            End With

                                            .ExecuteNonQuery()
                                        End If
                                    Next

                                    objTransaction.Commit()

                                    frmParent.tssStatus.Text = "Room information was altered..."
                                    gState = State.waiting
                                    gbxInput.Enabled = False
                                    gbxRooms.Enabled = True
                                    gbxRooms.BringToFront()

                                    ClearControls(gbxInput)

                                    DisplayRooms()
                                    UpdateComboBoxes()
                                Catch ex As Exception
                                    objTransaction.Rollback()
                                    Msg("1008", Button.Ok, )

                                End Try

                        End Select
                    End With
                End Using
            End Using
            objConnection.Close()
        End Using

    End Sub

#End Region

#Region "MISC"

    Private Sub txtRoomNo_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtRoomNo.Validating

        txtRoomNo.Text = Trim(txtRoomNo.Text)

        Do While txtRoomNo.Text.StartsWith(",")
            txtRoomNo.Text = txtRoomNo.Text.Remove(0, 1)
        Loop

        Do While txtRoomNo.Text.EndsWith(",")
            txtRoomNo.Text = txtRoomNo.Text.Remove(txtRoomNo.Text.Length - 1, 1)
        Loop

        gRoomNo = Split(txtRoomNo.Text, ",")

        If gRoomNo.GetUpperBound(0) <> 0 Then
            'Multiple rooms are added
            txtTelNo.Text = String.Empty
            txtTelNo.Enabled = False
        Else
            txtTelNo.Enabled = True
        End If


    End Sub

    Private Sub frmRoomSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DisplayRooms()
        UpdateComboBoxes()
        UpdateComboBoxes_FeaturesRatesTypes()

        dgvExistingRoom.AlternatingRowsDefaultCellStyle = SetAlternatingColor()
    End Sub

    Private Sub tsbFeaturesAndFacilities_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbFeaturesAndFacilities.Click
        frmFeaturesAndFacilities.ShowDialog()
    End Sub

    Private Sub tsbRoomRatesAndTypes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbRoomRatesAndTypes.Click
        frmRoomTypeAndRates.ShowDialog()
    End Sub

    Private Sub tsbUpdateRates_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbUpdateRates.Click
        With frmUpdateRoomRates
            .MdiParent = frmParent
            .Show()
            .BringToFront()
            .Top = 0
            .Left = 0
            .AutoScaleMode = AutoScaleMode.None
        End With
    End Sub

    Private Sub cboRoomTypeExistingRoom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRoomTypeExistingRoom.TextChanged
        DisplayRooms()
    End Sub

    Private Sub chkDisplayAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDisplayAll.CheckedChanged

        cboRoomTypeExistingRoom.Enabled = Not chkDisplayAll.Checked
        cboViewRateName.Enabled = Not chkDisplayAll.Checked
        cboFeatureAndFacility.Enabled = Not chkDisplayAll.Checked

        DisplayRooms()
    End Sub

    Private Sub cboViewRateName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboViewRateName.TextChanged
        DisplayRooms()
    End Sub

    Private Sub cboFeatureAndFacility_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFeatureAndFacility.TextChanged
        DisplayRooms()
    End Sub

    Private Sub tsmSetAsCurrentRate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmSetAsCurrentRate.Click

        If lsvRoomRatesAndTypes.Items.Count = 0 Then
            Msg("1038", Button.Ok)
            Exit Sub
        End If

        For Each ctlItem As ListViewItem In lsvRoomRatesAndTypes.Items
            If ctlItem.Selected = True Then
                lblRate.Text = Format(CDbl(ctlItem.SubItems(1).Text), "n")
                lblCurrentRateName.Text = ctlItem.SubItems(0).Text
                lblRateNo.Text = ctlItem.SubItems(6).Text
                ctlItem.Checked = True
                Exit Sub
            End If
        Next

    End Sub

    Private Sub lsvRoomRatesAndTypes_ItemChecked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles lsvRoomRatesAndTypes.ItemChecked
        For Each ctlItem As ListViewItem In lsvRoomRatesAndTypes.Items
            If ctlItem.Checked = False And ctlItem.SubItems(6).Text = lblRateNo.Text Then
                lblRateNo.Text = String.Empty
                lblCurrentRateName.Text = "NONE"
                lblRate.Text = "0.0000"
            End If
        Next
    End Sub

    Private Sub lblClose_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblClose.LinkClicked
        Me.Close()
    End Sub

    Private Sub tsbSystemSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSystemSettings.Click
        Display(Forms.frmSettings)
    End Sub

    Private Sub frmRoomSettings_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If gState <> State.waiting Then
            Select Case Msg("1033", Button.YesNoCancel)
                Case ButtonClicked.Yes
                    If ThereAreInputErrors() Then
                        e.Cancel = True
                    Else
                        btnAddSave_Click(Nothing, Nothing)
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

#End Region

End Class