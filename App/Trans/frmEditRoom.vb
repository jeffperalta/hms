Option Strict On
Option Explicit On

Imports System.Data.SqlClient

Public Class frmEditRoom
    Private strInfo() As String
    Private strRMSID As String
    Private objAdapter As SqlDataAdapter
    Private objDataView As New DataView
    Private objDataSet As DataSet
    Private objDataTable As DataTable
    Private objDataRow As DataRow
    Private strFromForm As String

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Msg("1099")
        Me.Close()

    End Sub

    Public Sub RoomToEdit(ByVal strRoomInfo As String, ByVal from As String)

        strInfo = Split(strRoomInfo, "|")
        lblRoomNo.Text = strInfo(0)
        txtNoOfOccupants.Text = strInfo(1)
        lblNoOfNights.Text = strInfo(2)
        dtpCheckInDate.Text = strInfo(3)
        dtpCheckOutDate.Text = strInfo(4)
        dtpCheckInTime.Text = CDate(strInfo(3)).ToShortTimeString
        dtpCheckOutTime.Text = CDate(strInfo(4)).ToShortTimeString
        strRMSID = strInfo(5)
        strFromForm = from

        If strFromForm = "Res" Then

            chkRoomByRequest.Checked = CBool(strInfo(6))

        End If

    End Sub

    Private Sub frmEditRoom_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        lblRoomNo.Text = "0"
        txtNoOfOccupants.Text = String.Empty
        lblNoOfNights.Text = "0"
        dtpCheckInDate.Value = Now.Date
        dtpCheckOutDate.Value = Now.Date
        dtpCheckInTime.Value = Now.Date
        dtpCheckOutTime.Value = Now.Date

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click

        Dim strReturnInfo As String

        If invalidDate() = False Then

            Msg("1100")

        ElseIf CInt(lblNoOfNights.Text) < 1 Then
            Msg("1001", , "Invalid date input")
            dtpCheckOutDate.Focus()

        ElseIf IntegerInput(txtNoOfOccupants.Text.ToString) = False Then

            Msg("1001", , "Invalid number of occupants input")
            txtNoOfOccupants.Focus()

        Else

            strInfo(0) = lblRoomNo.Text
            strInfo(1) = txtNoOfOccupants.Text
            strInfo(2) = lblNoOfNights.Text
            strInfo(3) = dtpCheckInDate.Text & " " & dtpCheckInTime.Text
            strInfo(4) = dtpCheckOutDate.Text & " " & dtpCheckOutTime.Text

            If Me.Tag.ToString = "Reg" Then

                strReturnInfo = strInfo(0) & "|" & strInfo(1) & "|" & strInfo(2) & "|" & strInfo(3) & "|" & strInfo(4) & "|"
                frmUpdateRegistration.UpdateRoomInfo(strReturnInfo)
                Me.Close()

            ElseIf Me.Tag.ToString = "Res" Then
                strInfo(5) = chkRoomByRequest.Checked.ToString
                strReturnInfo = strInfo(0) & "|" & strInfo(1) & "|" & strInfo(2) & "|" & strInfo(3) & "|" & strInfo(4) & "|" & strInfo(5) & "|"
                frmUpdateReservation.UpdateRoomInfo(strReturnInfo)
                Me.Close()

            End If

        End If

    End Sub

    Private Sub dtpCheckInDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpCheckInDate.ValueChanged

        dtpCheckOutDate.MinDate = dtpCheckInDate.Value
        lblNoOfNights.Text = (dtpCheckOutDate.Value - dtpCheckInDate.Value).Days.ToString

    End Sub

    Private Sub dtpCheckOutDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpCheckOutDate.ValueChanged

        lblNoOfNights.Text = (dtpCheckOutDate.Value.Date - dtpCheckInDate.Value.Date).Days.ToString

    End Sub

    Private Function invalidDate() As Boolean

        Dim strCheckin As String = dtpCheckInDate.Text & " " & dtpCheckInTime.Text
        Dim strCheckout As String = dtpCheckOutDate.Text & " " & dtpCheckOutTime.Text

        Using objDatabaseConnection As SqlConnection = SetUpConnection(DatabasePath, True)

            Try

                If strFromForm = "Reg" Then

                    objAdapter = New SqlDataAdapter("SELECT COUNT(*) AS Result " & _
                                                    "FROM (SELECT RMSID, RMSName, RMSStartTime, RMSEndTime, RMSStat, ResNo, RMNo " & _
                                                          "FROM RMSTATUS " & _
                                                          "WHERE (RMNo = '" & lblRoomNo.Text & "') AND (RMSID <> '" & strRMSID & "') AND (RMSStartTime BETWEEN '" & strCheckin & "' AND '" & strCheckout & "')) AS ResultTable", objDatabaseConnection)
                    objDataSet = SetUpDataSet(objAdapter, "qryValidity")
                    objDataTable = objDataSet.Tables("qryValidity")

                    If CInt(objDataSet.Tables("qryValidity").Rows(0).Item(0).ToString()) > 0 Then

                        Return False

                    Else

                        Return True

                    End If

                Else

                    objAdapter = New SqlDataAdapter("SELECT COUNT(*) AS Result " & _
                                                    "FROM (SELECT RMSID, RMSName, RMSStartTime, RMSEndTime, RMSStat, ResNo, RMNo " & _
                                                           "FROM RMSTATUS " & _
                                                           "WHERE (RMNo = '" & lblRoomNo.Text & "') AND (RMSID <> '" & strRMSID & "') AND (RMSStartTime BETWEEN '" & strCheckin & "' AND '" & strCheckout & "') OR (RMNo = '" & lblRoomNo.Text & "') AND (RMSID <> '" & strRMSID & "') AND (RMSEndTime BETWEEN '" & strCheckin & "' AND '" & strCheckout & "')) AS ResultTable", objDatabaseConnection)
                    objDataSet = SetUpDataSet(objAdapter, "qryValidity")
                    objDataTable = objDataSet.Tables("qryValidity")

                    If CInt(objDataSet.Tables("qryValidity").Rows(0).Item(0).ToString()) > 0 Then

                        Return False

                    Else

                        Return True

                    End If

                End If

            Catch ex As Exception

                Msg("1008", , "An error occured while validating the room")

            End Try

        End Using

    End Function

End Class