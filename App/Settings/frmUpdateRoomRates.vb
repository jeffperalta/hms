Option Explicit On
Option Strict On

Imports System.Data
Imports System.Data.SqlClient


Public Class frmUpdateRoomRates

    Private gState As State = State.waiting
    Private gOriginalRooms As ArrayList = New ArrayList
    Private gCheckedRooms As ArrayList = New ArrayList
    Private gUncheckedRooms As ArrayList = New ArrayList

#Region "Functions/Subroutines"

    Private Sub DisplayRoomRates()

        Dim CommandString As String = "SELECT RMRID AS [Rate No], RMRName AS [Rate Name], RMRAmt AS Amount, RMRStartTime AS [Starts On], RMREndTime AS [Ends On], " & _
                                      "       RMRRemarks AS Remarks, RMRType AS [Applied To] " & _
                                      "FROM   RMRATE "
        If optToday.Checked Then
            CommandString &= "WHERE  (RMRStartTime <= { fn NOW() }) "
        ElseIf optNextDays.Checked Then
            If IsNumeric(txtDays.Text) Then
                CommandString &= "WHERE  (RMRStartTime <= DATEADD(day, " & Trim(txtDays.Text) & ", { fn NOW() })) "
            Else
                frmParent.tssStatus.Text = "Not a number..."
                txtDays.SelectAll()
                txtDays.Focus()
            End If
        ElseIf optOnDate.Checked Then
            CommandString &= "WHERE  (RMRStartTime BETWEEN CONVERT(DATETIME,'" & Format(DateAdd(DateInterval.Day, 0, dtpDate.Value), "yyyy-MM-dd") & " 00:01:00',102) AND CONVERT(DATETIME,'" & Format(DateAdd(DateInterval.Day, 0, dtpDate.Value), "yyyy-MM-dd") & " 23:59:00', 102)) "
        Else
            'optSelectAll
            'leave the command string as is
        End If

        CommandString &= "ORDER BY RMRStartTime DESC"

        ListItems(DatabasePath, CommandString, dgvRooms)

    End Sub

    Private Sub DisplayRooms()

        lsvRoom.Items.Clear()

        If dgvRooms.SelectedRows.Count > 0 Then
            Dim SelectedIndex_Rate As Integer = dgvRooms.CurrentRow.Index

            lblCount.Text = ListItems(lsvRoom, SetUpDataSet(SetUpDataAdapter(SetUpConnection(DatabasePath, True), _
                            "SELECT DISTINCT ROOM.RMNo AS [Room No], ROOM.RMType AS Type, ROOM.RMCurrStat AS [Current Status] " & _
                            "FROM   RMRATE_DETAILS RIGHT OUTER JOIN " & _
                            "       ROOM ON RMRATE_DETAILS.RMNo = ROOM.RMNo " & _
                            "WHERE  (RMRATE_DETAILS.RMRID = '" & dgvRooms.Item(0, SelectedIndex_Rate).Value.ToString & "') ", DatabaseTransactionState.SelectState), "ROOM"), "ROOM").ToString

            gOriginalRooms.Clear()
            For Each ctlItem As ListViewItem In lsvRoom.Items
                gOriginalRooms.Add(ctlItem.Text)
            Next

            If chkViewAllRooms.Checked Then
                lblCount.Text = ListItems(lsvRoom, SetUpDataSet(SetUpDataAdapter(SetUpConnection(DatabasePath, True), _
                                "SELECT DISTINCT ROOM.RMNo AS [Room No], ROOM.RMType AS Type, ROOM.RMCurrStat AS [Current Status] " & _
                                "FROM   RMRATE_DETAILS LEFT OUTER JOIN " & _
                                "       ROOM ON RMRATE_DETAILS.RMNo = ROOM.RMNo ", _
                                DatabaseTransactionState.SelectState), "ROOM"), "ROOM").ToString
            End If

            lblCountSelected.Text = "0"
            gCheckedRooms.Clear()
            gUncheckedRooms.Clear()

            For Each ctlItem As ListViewItem In lsvRoom.Items
                If IsExisting("SELECT RMNo FROM RMRATE_DETAILS WHERE RMNo='" & ctlItem.Text & "' AND RMRID='" & dgvRooms.Item(0, SelectedIndex_Rate).Value.ToString & "' AND RMDActive='TRUE' ") Then
                    ctlItem.Checked = True
                    lblCountSelected.Text = CType(CInt(lblCountSelected.Text) + 1, String)

                    gCheckedRooms.Add(ctlItem.Text)
                Else
                    ctlItem.Checked = False
                    gUncheckedRooms.Add(ctlItem.Text)
                End If
            Next

        End If

        With lsvRoom
            .Columns(0).Width = 90
            .Columns(1).Width = 165
            .Columns(2).Width = 140
        End With

    End Sub

    Private Sub DisplayUnassignedRooms()
        lblCountUnassigned.Text = "0"
        lblCountUnassigned.Text = ListItems(DatabasePath, _
                                        "SELECT RMNo AS [Room No], RMType AS Type, RMCurrStat AS [Current Status] " & _
                                        "FROM   ROOM " & _
                                        "WHERE  (RMNo NOT IN " & _
                                        "        (SELECT RMNo " & _
                                        "         FROM   RMRATE_DETAILS " & _
                                        "         WHERE  (RMDActive = 'TRUE'))) ", dgvNoRates).ToString

    End Sub

    Private Sub DisplayRatesOfUnassignedRooms()

        lsvRoomRatesAndTypes.Items.Clear()

        If dgvNoRates.SelectedRows.Count > 0 Then

            ListItems(lsvRoomRatesAndTypes, SetUpDataSet(SetUpDataAdapter(SetUpConnection(DatabasePath, True), _
            "SELECT RMRATE.RMRName AS [Rate Name], RMRATE.RMRAmt AS Amount, RMRATE.RMRStartTime AS [Starts On], RMRATE.RMREndTime AS [Ends On], " & _
            "       RMRATE.RMRType AS [Applied to Room Type], RMRATE.RMRRemarks AS Remarks, RMRATE.RMRID AS [Rate No] " & _
            "FROM   RMRATE_DETAILS INNER JOIN " & _
            "       RMRATE ON RMRATE_DETAILS.RMRID = RMRATE.RMRID " & _
            "WHERE  (RMRATE_DETAILS.RMNo = '" & dgvNoRates.Item(0, dgvNoRates.CurrentRow.Index).Value.ToString & "') ", _
                DatabaseTransactionState.SelectState), "RATESANDTYPES"), "RATESANDTYPES")

            With lsvRoomRatesAndTypes
                .Columns(0).Width = 135
                .Columns(1).Width = 110
                .Columns(2).Width = 135
                .Columns(3).Width = 122
                .Columns(4).Width = 130
                .Columns(5).Width = 141
                .Columns(6).Width = 100
            End With
        End If
    End Sub

#End Region

#Region "Command Buttons"

    Private Sub btnNoRate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoRate.Click
        gState = State.updating

        gbxApplyToRoom.Enabled = False
        gbxRates.Enabled = False
        gbxNoRates.Enabled = True
        gbxNoRates.BringToFront()
    End Sub

    Private Sub btnSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectAll.Click
        For Each ctlItem As ListViewItem In lsvRoom.Items
            ctlItem.Checked = True
        Next
    End Sub

    Private Sub btnActivate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActivate.Click

        If lsvRoom.Items.Count > 0 Then
            If Msg("1034", Button.YesNo) = ButtonClicked.Yes Then

                Using objConnection As SqlConnection = SetUpConnection(DatabasePath(), True)
                    objConnection.Open()
                    Using objTransaction As SqlTransaction = objConnection.BeginTransaction

                        Using objCommand As SqlCommand = objConnection.CreateCommand
                            With objCommand
                                .Transaction = objTransaction

                                Try
                                    For Each ctlItem As ListViewItem In lsvRoom.Items

                                        .Parameters.Clear()
                                        .Parameters.AddWithValue("@RMNo", ctlItem.Text)
                                        .Parameters.AddWithValue("@RMRID", dgvRooms.Item(0, dgvRooms.CurrentRow.Index).Value)

                                        If gOriginalRooms.IndexOf(ctlItem.Text) = -1 Then
                                            If ctlItem.Checked = True Then
                                                .CommandText = "UPDATE RMRATE_DETAILS SET RMDActive='FALSE' WHERE RMNo=@RMNo"
                                                .ExecuteNonQuery()

                                                .CommandText = "INSERT INTO RMRATE_DETAILS (RMNo, RMRID, RMDActive) VALUES (@RMNo, @RMRID, 'TRUE')"
                                                .ExecuteNonQuery()
                                            End If
                                        Else

                                            Dim blnUpdate As Boolean = True

                                            If gCheckedRooms.IndexOf(ctlItem.Text) <> -1 And ctlItem.Checked = True Then
                                                blnUpdate = False
                                            End If

                                            If gUncheckedRooms.IndexOf(ctlItem.Text) <> -1 And ctlItem.Checked = False Then
                                                blnUpdate = False
                                            End If

                                            If blnUpdate Then
                                                .CommandText = "UPDATE RMRATE_DETAILS SET RMDActive='FALSE' WHERE RMNo=@RMNo"
                                                .ExecuteNonQuery()

                                                .CommandText = "UPDATE RMRATE_DETAILS SET RMDActive=@RMDActive WHERE RMNo=@RMNo AND RMRID=@RMRID"
                                                .Parameters.AddWithValue("@RMDActive", ctlItem.Checked).SqlDbType = SqlDbType.Bit
                                                .ExecuteNonQuery()
                                            End If

                                        End If
                                    Next

                                    objTransaction.Commit() 'change this
                                    frmParent.tssStatus.Text = "A new rate is in effective..."
                                    gState = State.waiting
                                    gbxRates.Enabled = True
                                    gbxApplyToRoom.Enabled = False

                                    DisplayUnassignedRooms()
                                    DisplayRatesOfUnassignedRooms()

                                    If CInt(lblCountUnassigned.Text) > 0 Then
                                        Msg("1038")
                                        btnNoRate.Focus()
                                    Else
                                        dgvRooms.Focus()
                                    End If

                                    chkViewAllRooms.Checked = False

                                Catch ex As Exception
                                    objTransaction.Rollback()
                                    Msg("1008", , NWLN & ex.Message)
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

    Private Sub btnCancelAtUnassignedRooms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelAtUnassignedRooms.Click
        gState = State.waiting

        gbxApplyToRoom.Enabled = False
        gbxRates.Enabled = True
        gbxNoRates.Enabled = False
        gbxApplyToRoom.BringToFront()
    End Sub

    Private Sub btnSaveAtUnassignedRooms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveAtUnassignedRooms.Click
        If dgvNoRates.SelectedRows.Count > 0 And lsvRoomRatesAndTypes.Items.Count > 0 And lsvRoomRatesAndTypes.CheckedItems.Count > 0 Then

            Dim strRateID As String = String.Empty
            For Each ctlItem As ListViewItem In lsvRoomRatesAndTypes.Items
                If ctlItem.Checked = True Then
                    strRateID = ctlItem.SubItems(6).Text
                End If
            Next

            Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
                objConnection.Open()
                Using objTransaction As SqlTransaction = objConnection.BeginTransaction
                    Using objCommand As SqlCommand = objConnection.CreateCommand
                        With objCommand
                            .Transaction = objTransaction

                            .CommandText = "UPDATE RMRATE_DETAILS SET RMDActive='TRUE' WHERE RMNo=@RMNo AND RMRID=@RMRID"
                            .Parameters.Clear()
                            .Parameters.AddWithValue("@RMNo", dgvNoRates.Item(0, dgvNoRates.CurrentRow.Index).Value)
                            .Parameters.AddWithValue("@RMRID", strRateID)

                            Try
                                .ExecuteNonQuery()

                                objTransaction.Commit()
                                DisplayUnassignedRooms()
                                frmParent.tssStatus.Text = "Saved..."
                                gState = State.updating

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

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
    End Sub
#End Region

#Region "MISC"

    Private Sub frmUpdateRoomCharges_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DisplayRoomRates()
        DisplayRooms()
        DisplayUnassignedRooms()
    End Sub

    Private Sub dgvRooms_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvRooms.SelectionChanged
        DisplayRooms()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        gState = State.waiting

        gbxRates.Enabled = True
        gbxApplyToRoom.Enabled = False
        dgvRooms.Focus()

        chkViewAllRooms.Checked = False

    End Sub

    Private Sub dgvRooms_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvRooms.DoubleClick
        If dgvRooms.SelectedRows.Count > 0 Then

            gbxRates.Enabled = False
            gbxApplyToRoom.Enabled = True
            gState = State.updating

        Else
            Msg("1039")
        End If
    End Sub

    Private Sub radSelectAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radSelectAll.CheckedChanged
        DisplayRoomRates()
    End Sub

    Private Sub optToday_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optToday.CheckedChanged
        DisplayRoomRates()
    End Sub

    Private Sub optNextDays_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optNextDays.CheckedChanged
        DisplayRoomRates()
    End Sub

    Private Sub txtDays_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDays.TextChanged
        DisplayRoomRates()
    End Sub

    Private Sub optOnDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optOnDate.CheckedChanged
        DisplayRoomRates()
    End Sub

    Private Sub dtpDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDate.ValueChanged
        DisplayRoomRates()
    End Sub

    Private Sub dgvNoRates_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvNoRates.SelectionChanged
        DisplayRatesOfUnassignedRooms()
    End Sub

    Private Sub lsvRoomRatesAndTypes_ItemCheck(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles lsvRoomRatesAndTypes.ItemCheck
        For Each ctlItem As ListViewItem In lsvRoomRatesAndTypes.Items
            If ctlItem.Checked = True Then
                e.NewValue = CheckState.Unchecked
                frmParent.tssStatus.Text = "Select only one current rate..."
            End If
        Next
    End Sub

    Private Sub tsbSystemSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSystemSettings.Click
        Display(Forms.frmSettings)
        Me.Close()
    End Sub

    Private Sub tsbFeaturesAndFacilities_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbFeaturesAndFacilities.Click
        frmFeaturesAndFacilities.ShowDialog()
    End Sub

    Private Sub tsbRoomRatesAndTypes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbRoomRatesAndTypes.Click
        frmRoomTypeAndRates.ShowDialog()
    End Sub

    Private Sub frmUpdateRoomCharges_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If gState <> State.waiting Then

            Select Case Msg("1033", Button.YesNoCancel)
                Case ButtonClicked.Yes
                    If gbxApplyToRoom.Enabled = True Then 'User is activating a rate
                        btnActivate_Click(Nothing, Nothing)
                    ElseIf gbxNoRates.Enabled = True Then
                        btnSaveAtUnassignedRooms_Click(Nothing, Nothing)
                    End If
                    e.Cancel = False
                Case ButtonClicked.No
                    e.Cancel = False
                Case ButtonClicked.Cancel
                    e.Cancel = True
            End Select

        Else
            e.Cancel = False
        End If
    End Sub

    Private Sub chkViewAllRooms_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkViewAllRooms.CheckedChanged
        DisplayRooms()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Display(Forms.frmRoomSettings)
    End Sub
#End Region

End Class