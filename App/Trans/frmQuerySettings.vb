Option Explicit On
Option Strict On
Imports System.Data.SqlClient

Public Class frmQuerySettings

#Region "Features And Facilities"

    Private Sub DisplayTab1()
        Dim strSQLStatement As String = "SELECT ROOM.RMNo AS [Room No], ROOM.RMType AS [Room Type], RMRATE.RMRName AS [Rate Name], RMRATE.RMRAmt AS Amount,  " & _
                                        "       RMRATE_DETAILS.RMDActive AS [Current Rate], RMRATE.RMRStartTime AS [Start Date], RMRATE.RMREndTime AS [End Date],  " & _
                                        "       RMRATE.RMRRemarks AS Remarks, ROOM.RMCurrStat AS [Room Current Status] " & _
                                        "FROM   RMRATE INNER JOIN " & _
                                        "       RMRATE_DETAILS ON RMRATE.RMRID = RMRATE_DETAILS.RMRID INNER JOIN " & _
                                        "       ROOM ON RMRATE_DETAILS.RMNo = ROOM.RMNo "

        Dim blnFirstCriteria As Boolean = True
        If Trim(cboRoomNumber.Text) <> String.Empty Then
            If blnFirstCriteria Then
                strSQLStatement &= " WHERE "
            Else
                strSQLStatement &= " AND "
            End If
            strSQLStatement &= " ROOM.RMNo='" & TrimAll(cboRoomNumber.Text, True) & "' "
            blnFirstCriteria = False
        End If

        If Trim(cboRoomRateType.Text) <> String.Empty Then
            If blnFirstCriteria Then
                strSQLStatement &= " WHERE "
            Else
                strSQLStatement &= " AND "
            End If
            strSQLStatement &= " RMRATE.RMRName = '" & TrimAll(cboRoomRateType.Text, True) & "' "
            blnFirstCriteria = False
        End If

        If chkActive.Checked Then
            If blnFirstCriteria Then
                strSQLStatement &= " WHERE "
            Else
                strSQLStatement &= " AND "
            End If
            strSQLStatement &= " RMRATE_DETAILS.RMDActive='TRUE' "
            blnFirstCriteria = False
        End If

        If IsNumeric(txtAmountFrom.Text) AndAlso IsNumeric(txtAmountTo.Text) Then
            If blnFirstCriteria Then
                strSQLStatement &= " WHERE "
            Else
                strSQLStatement &= " AND "
            End If
            strSQLStatement &= " RMRATE.RMRAmt BETWEEN " & txtAmountFrom.Text & " AND " & txtAmountTo.Text & " "
            blnFirstCriteria = False
        End If

        ListItems(DatabasePath, strSQLStatement, dgvRoomRates)
        lblTotalResult.Text = dgvRoomRates.Rows.Count.ToString

    End Sub

    Private Sub DisplayTab2()

        ListItems(DatabasePath, "SELECT SERVICES_AND_AMENITIES.SDesc AS [Amenity/Service Name], SERVICES_AND_AMENITIES.SDeptName AS [Department Name], " & _
                                "       SERVICES_AND_AMENITIES.SStat AS Status, COUNT(FOLIO_DETAILS.FDNo) AS Availed,  ISNULL(SUM(FOLIO_DETAILS.FDModifiedCharge), 0.0000) AS [Total Sales] " & _
                                "FROM   SERVICES_AND_AMENITIES LEFT OUTER JOIN " & _
                                "       FOLIO_DETAILS ON SERVICES_AND_AMENITIES.SID = FOLIO_DETAILS.SID " & _
                                "GROUP BY SERVICES_AND_AMENITIES.SDesc, SERVICES_AND_AMENITIES.SDeptName, SERVICES_AND_AMENITIES.SStat " & IIf(Trim(cboDepartment.Text) <> String.Empty, " HAVING SDeptName='" & TrimAll(cboDepartment.Text, True) & "' ", " ").ToString, dgvAmenities)
        Label2.Text = dgvAmenities.Rows.Count.ToString

    End Sub

    Private Sub DisplayTab3()
        ListItems(DatabasePath, "SELECT RMFEATURE.RMFName AS [Feature Name], RMFEATURE.RMFStatus AS Status, COUNT(RMFEATURE_DETAILS.RMNo) AS Used, " & _
                                "       RMFEATURE.RMFRemarks AS Remarks " & _
                                "FROM   RMFEATURE INNER JOIN " & _
                                "       RMFEATURE_DETAILS ON RMFEATURE.RMFID = RMFEATURE_DETAILS.RMFID " & _
                                "GROUP BY RMFEATURE.RMFName, RMFEATURE.RMFRemarks, RMFEATURE.RMFStatus " & IIf(RadioButton2.Checked, " ", IIf(RadioButton1.Checked, " HAVING RMFEATURE.RMFStatus='TRUE' ", " HAVING RMFEATURE.RMFStatus='FALSE' ")).ToString, DataGridView1)
        Label7.Text = DataGridView1.Rows.Count.ToString
    End Sub

#End Region

#Region "Command Button"

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DisplayTab3()
    End Sub

    Private Sub btnAmenitiesShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAmenitiesShow.Click
        DisplayTab2()
    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        DisplayTab1()
    End Sub

    Private Sub lblClose_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblClose.LinkClicked
        Me.Close()
    End Sub

    Private Sub btnViewRoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewRoom.Click
        Display(Forms.frmRoomRack)
    End Sub

#End Region

#Region "Side Bar"

    Private Sub tsbQueryShift_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbQueryShift.Click
        Display(Forms.frmQueryShift)
    End Sub

    Private Sub tsbQueryRmStat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbQueryRmStat.Click
        Display(Forms.frmQueryRMStat)
    End Sub

#End Region

#Region "MISC"

    Private Sub frmQuerySettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListItems(DatabasePath, "SELECT RMNo FROM ROOM", cboRoomNumber, "RMno")
        cboRoomNumber.Text = String.Empty
        ListItems(DatabasePath, "SELECT RMRName FROM RMRate", cboRoomRateType, "RMRName")
        cboRoomRateType.Text = String.Empty
        ListItems(DatabasePath, "SELECT DISTINCT SDeptName FROM SERVICES_AND_AMENITIES", cboDepartment, "SDeptName")
        cboDepartment.Text = String.Empty

        dgvRoomRates.AlternatingRowsDefaultCellStyle = SetAlternatingColor()
        dgvAmenities.AlternatingRowsDefaultCellStyle = SetAlternatingColor()
        DataGridView1.AlternatingRowsDefaultCellStyle = SetAlternatingColor()

        DisplayTab1()
        DisplayTab2()
        DisplayTab3()

    End Sub

#End Region

    
End Class
