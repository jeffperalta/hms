Option Explicit On
Option Strict On

Imports System.Data.SqlClient
Imports System.Data

' Programmer:   Bobby Elbert D. Quiñones 
'               Jo Jefferson D. Peralta
' Date:         April 07, 2007
' Title:        frmRoomMaintenance
' Purpose:      This interface adds, edits, deletes features and facilities of a room
' Requirements: ->  (*)ROOM(RMCurrStat, RMRemarks)
'               ->  The RMStat table contains whether a room is registered or reserved and therefore can
'                   be preset or arranged before it will actually take in effect. However these rooms may
'                   have different status that varies daily. For this reason the RMCurrStat found at ROOM 
'                   table is necessary. Rooms can have a current status set to CLEAN, DIRTY, and MAINTENANCE.
'               ->  When a room checks out its current status is set to DIRTY and until it remains to have this
'                   status that room cannot have REGISTRATIONS. This interface changes this status to CLEAN,
'                   and therefore making this available to have registrations.
'               ->  The user can use the room search to easily determine which room to have changes in its current status.
' Results:      ->  The current room status is changed to either CLEAN, DIRTY, or under MAINTENANCE
'               ->  When multiple rooms are selected the new remark is appended to the old one. Otherwise when
'                   a single room is selected the old remark is overwritten with the new information.
'>>>Messages Done

Public Class frmRoomMaintenance

#Region "Function/SubRoutines"

    Private Sub DisplayRooms()

        Dim blnFirstWhere As Boolean = True

        Dim strSql As String = "SELECT RMNo AS [Room No], RMType AS [Room Type], RMCurrStat AS [Current Status], RMFloor AS Floor, RMView AS [View], RMTelNo AS [Telephone No],  " & _
                               "       RMMaxGuest AS Occupants, RMDesc AS Description, RMRemarks AS Remarks " & _
                               "FROM   ROOM "


        If Trim(cboRoomType.Text) <> String.Empty Then
            If blnFirstWhere Then
                strSql &= " WHERE "
                blnFirstWhere = False
            Else
                strSql &= " AND "
            End If

            strSql &= " (RMType = '" & TrimAll(cboRoomType.Text, True) & "') "

        End If

        If Trim(cboStatus.Text) <> String.Empty Then

            If blnFirstWhere Then
                strSql &= " WHERE "
                blnFirstWhere = False
            Else
                strSql &= " AND "
            End If

            strSql &= " (RMCurrStat = '" & TrimAll(cboStatus.Text, True) & "') "

        End If

        If Trim(cboView.Text) <> String.Empty Then

            If blnFirstWhere Then
                strSql &= " WHERE "
                blnFirstWhere = False
            Else
                strSql &= " AND "
            End If

            strSql &= " (RMView LIKE '%" & TrimAll(cboView.Text, True) & "%') "

        End If

        If Trim(txtDescription.Text) <> String.Empty Then

            If blnFirstWhere Then
                strSql &= " WHERE "
                blnFirstWhere = False
            Else
                strSql &= " AND "
            End If

            strSql &= " (RMDesc LIKE '%" & TrimAll(txtDescription.Text, True) & "%') "

        End If

        If Trim(txtOccupants.Text) <> String.Empty AndAlso IsNumeric(txtOccupants.Text) Then

            If blnFirstWhere Then
                strSql &= " WHERE "
                blnFirstWhere = False
            Else
                strSql &= " AND "
            End If

            strSql &= " (RMMaxGuest = " & TrimAll(txtOccupants.Text, True) & ") "

        End If

        If Trim(cboFeatures.Text) <> String.Empty Then

            If blnFirstWhere Then
                strSql &= " WHERE "
                blnFirstWhere = False
            Else
                strSql &= " AND "
            End If

            strSql &= " (RMNo IN " & _
                      "      (SELECT RMFEATURE_DETAILS.RMNo " & _
                      "      FROM   RMFEATURE INNER JOIN " & _
                      "      RMFEATURE_DETAILS ON RMFEATURE.RMFID = RMFEATURE_DETAILS.RMFID " & _
                      "      WHERE  (RMFEATURE.RMFName LIKE '%" & TrimAll(cboFeatures.Text, True) & "%'))) "

        End If

        strSql &= " ORDER BY [Room No] "

        Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
            objConnection.Open()
            Using objCommand As SqlCommand = New SqlCommand(strSql, objConnection)
                Using objReader As SqlDataReader = objCommand.ExecuteReader

                    lsvRoom.Items.Clear()
                    Do While objReader.Read

                        Dim lsvItem As ListViewItem = lsvRoom.Items.Add(objReader(0).ToString)
                        lsvItem.SubItems.Add(objReader(1).ToString)
                        lsvItem.SubItems.Add(objReader(2).ToString)
                        lsvItem.SubItems.Add(objReader(3).ToString)
                        lsvItem.SubItems.Add(objReader(4).ToString)
                        lsvItem.SubItems.Add(objReader(5).ToString)
                        lsvItem.SubItems.Add(objReader(6).ToString)
                        lsvItem.SubItems.Add(objReader(7).ToString)
                        lsvItem.SubItems.Add(objReader(8).ToString)

                        Select Case objReader(2).ToString.ToUpper
                            Case "DIRTY"
                                lsvItem.ImageKey = "DIRTY"
                            Case "CLEAN"
                                lsvItem.ImageKey = "CLEAN"
                            Case "MAINTENANCE"
                                lsvItem.ImageKey = "MAINTENANCE"
                        End Select

                    Loop
                End Using
            End Using
            objConnection.Close()
        End Using

        lblCount.Text = lsvRoom.Items.Count.ToString

    End Sub

    Private Function ThereAreInputErrors() As Boolean

        If lsvRoom.SelectedItems.Count = 0 Then
            Msg("1039")
            lsvRoom.Focus()
            Return True
            Exit Function
        End If

        If Not (radMaintenance.Checked Or radDirty.Checked Or radClean.Checked) Then
            Msg("1040")
            radMaintenance.Focus()
            Return True
            Exit Function
        End If

    End Function

    Private Sub UpdateComboBox()

        ListItems(DatabasePath, "SELECT DISTINCT RMType FROM ROOM", cboRoomType, "RMType")
        cboRoomType.Text = String.Empty
        ListItems(DatabasePath, "SELECT DISTINCT RMFName FROM RMFEATURE", cboFeatures, "RMFName")
        cboFeatures.Text = String.Empty
        ListItems(DatabasePath, "SELECT DISTINCT RMView FROM ROOM", cboView, "RMView")
        cboView.Text = String.Empty

    End Sub

#End Region

#Region "Command Button"

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        DisplayRooms()
        If lsvRoom.Items.Count = 0 Then
            Msg("1007")
        End If
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

                            If lsvRoom.SelectedItems.Count > 1 Then
                                .CommandText = "UPDATE ROOM SET RMCurrStat=@RMCurrStat, RMRemarks = RMRemarks + '; ' + @RMRemarks WHERE RMNo=@RMNo "
                            Else
                                .CommandText = "UPDATE ROOM SET RMCurrStat=@RMCurrStat, RMRemarks = @RMRemarks WHERE RMNo=@RMNo "
                            End If


                            For Each ctlItem As ListViewItem In lsvRoom.SelectedItems
                                With .Parameters
                                    .Clear()

                                    .AddWithValue("@RMRemarks", TrimAll(txtRemarks.Text))

                                    If radMaintenance.Checked Then
                                        .AddWithValue("@RMCurrStat", "MAINTENANCE")
                                    ElseIf radDirty.Checked Then
                                        .AddWithValue("@RMCurrStat", "DIRTY")
                                    ElseIf radClean.Checked Then
                                        .AddWithValue("@RMCurrStat", "CLEAN")
                                    End If

                                    .AddWithValue("@RMNo", ctlItem.Text)
                                End With

                                .ExecuteNonQuery()
                            Next

                            objTransaction.Commit()
                            frmParent.tssStatus.Text = "Current status was saved..."
                            DisplayRooms()

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

    Private Sub tsmClean_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmClean.Click
        radClean.Checked = True
        btnSave_Click(Nothing, Nothing)
    End Sub

    Private Sub tsmDirty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmDirty.Click
        radDirty.Checked = True
        btnSave_Click(Nothing, Nothing)
    End Sub

    Private Sub tsmMaintenance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmMaintenance.Click
        radMaintenance.Checked = True
        btnSave_Click(Nothing, Nothing)
    End Sub

#End Region

#Region "MISC"

    Private Sub frmRoomMaintenance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        UpdateComboBox()
        imgRoom.Images.Add("MAINTENANCE", My.Resources.Construction)
        imgRoom.Images.Add("CLEAN", My.Resources.Vacant)
        imgRoom.Images.Add("DIRTY", My.Resources.Dirty)
        DisplayRooms()

    End Sub

    Private Sub radDetails_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radDetails.CheckedChanged

        If radDetails.Checked Then
            lsvRoom.View = View.Details
        Else
            lsvRoom.View = View.LargeIcon
            DisplayRooms()
        End If

    End Sub

    Private Sub lvwRooms_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsvRoom.SelectedIndexChanged

        Try
            If lsvRoom.SelectedItems.Count = 1 Then 'Display Current status
                Select Case lsvRoom.FocusedItem.SubItems(2).Text.ToUpper
                    Case "MAINTENANCE"
                        radMaintenance.Checked = True
                    Case "DIRTY"
                        radDirty.Checked = True
                    Case "CLEAN"
                        radClean.Checked = True
                End Select

                txtRemarks.Text = lsvRoom.FocusedItem.SubItems(8).Text
            Else
                radMaintenance.Checked = False
                radDirty.Checked = False
                radClean.Checked = False
                picStatus.BackgroundImage = Nothing
                txtRemarks.Text = String.Empty
            End If
        Catch ex As Exception
            'Error when users saves and later selects by dragging
        End Try

    End Sub

    Private Sub radMaintenance_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radMaintenance.CheckedChanged, radClean.CheckedChanged, radDirty.CheckedChanged

        If radMaintenance.Checked = True Then
            picStatus.BackgroundImage = My.Resources.Construction
        ElseIf radDirty.Checked = True Then
            picStatus.BackgroundImage = My.Resources.Dirty
        Else
            picStatus.BackgroundImage = My.Resources.Vacant
        End If

    End Sub

    Private Sub lblClose_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblClose.LinkClicked
        Me.Close()
    End Sub

#End Region

#Region "Side bars"

    Private Sub tsbRoomRack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbRoomRack.Click
        Display(Forms.frmRoomRack)
    End Sub

#End Region

End Class