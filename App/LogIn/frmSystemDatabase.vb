Option Explicit On
Option Strict On

Imports System.Data
Imports System.Data.SqlClient

' Programmer:   Jo Jefferson D. Peralta
' Date:         February 27, 2007
' Title:        frmSystemDatabase
' Purpose:      This interface is triggered when the data files are missing or when there is 
'               no data files saved at the control file. Usually this happens during the first
'               use of the application where databases are not yet set. The user will have
'               to locate the data file and use the test button to verify it.
'             
' Requirements: ->  (+/-)DATABASEFILE(DatabaseNo, DatabasePath, HotelName, LastUsed)
'               ->  (*) DATABASEFILE(DatabasePath, HotelName, LastUsed)
'               ->  Unique Field at HotelName
'               ->  Can only have one default database signified by LastUsed=TRUE
'               ->  Required Field At DatabaseNo, HotelName, and DatabasePath 
'               ->  Path must be existing and the *.mdf file must be a right data file
'               ->  The user can add, delete, edit the databases for each hotel
'               ->  The application must ensure that there is a default database
'               ->  Hotel name must be unique
' Results:      ->  A new database is added at the control file, Modifications or deletions
'               ->  of previous database are saved at the control file.

Public Class frmSystemDatabase

    Private gstate As State = State.waiting
    Private Restart As Boolean = False
   
#Region "Functions/Subroutines"

    Private Function IsCorrectDatabase() As Boolean
        'Path is already filtered. Only .mdf files are displayed by the dialog boxes

        'Check database objects
        Using objConnection As SqlConnection = SetUpConnection(txtPath.Text, True)
            objConnection.Open()
            Using objCommand As SqlCommand = New SqlCommand
                With objCommand
                    Try
                        .Connection = objConnection
                        .CommandText = "SELECT ALID, ALResOrReg, AlNature, AlOldVal, AlNewVal, AlTimeChanged, GNo, EID, RegNO, ResNO, RegDNo FROM ACTIVITY_LOG;"
                        .ExecuteNonQuery()

                        .CommandText = "SELECT PTID, BNAcctNo, BNName, BNBranch FROM BANK;"
                        .ExecuteNonQuery()

                        .CommandText = "SELECT PTID, CHNo, ChBank, CHMatDate, CHexpDate FROM CHEQUE;"
                        .ExecuteNonQuery()

                        .CommandText = "SELECT CID, CName, CAddress, CBranch, CContactPerson, CContact, Cpos FROM COMPANY;"
                        .ExecuteNonQuery()

                        .CommandText = "SELECT PTID, CCOwner, CCType, CCno FROM CREDIT_CARD;"
                        .ExecuteNonQuery()

                        .CommandText = "SELECT DBID, DBName, DBAddress, DBContact, DBStatus, DbAmt, DbBalance,DBDate, DBExpDate, DBRemarks FROM DIRECT_BILLER;"
                        .ExecuteNonQuery()

                        .CommandText = "SELECT EID, EFName, ELName, EMI, EPosition, EActive, EUsername, EUserPassword, EUsertype, EpicPath FROM EMPLOYEE;"
                        .ExecuteNonQuery()

                        .CommandText = "SELECT FDNO, FDReceiptNo, FDDate, FDCharge, FDModifiedByAMT, FDModifiedByPercent, FDModifiedCharge, FDBalance, FDRemarks, FDStat, FDServiceRep, FDDesc, RegNo, RegDNo, SID, ResNo, FDName FROM FOLIO_DETAILS;"
                        .ExecuteNonQuery()

                        .CommandText = "SELECT GNo, Giid, CID FROM GUEST;"
                        .ExecuteNonQuery()

                        .CommandText = "SELECT GIID, GItitle,GiFname,GILName, GIMI, GICountry, GIAddress, GIZIP, GIContact, GIEmail, GIGender, GICivilStat, GINat, GICit, GIBday FROM GUEST_INFO;"
                        .ExecuteNonQuery()

                        .CommandText = "SELECT Attribute, CurrentNo FROM KEYGEN;"
                        .ExecuteNonQuery()

                        .CommandText = "SELECT Lno, LTimeIN, LTimeOut, ShiftID, LStat, EID FROM LOG_INFO;"
                        .ExecuteNonQuery()

                        .CommandText = "SELECT PID, PAmt, PDate, PPayer, DBID, RegNo, LNo FROM PAYMENT;"
                        .ExecuteNonQuery()

                        .CommandText = "SELECT FDno, PID, PDAmt FROM PAYMENT_DETAILS;"
                        .ExecuteNonQuery()

                        .CommandText = "SELECT PTID, PTAmt, PTtype, PID FROM PAYMENT_TYPE_DETAILS;"
                        .ExecuteNonQuery()

                        .CommandText = "SELECT Attribute, Alpha, Previous, Remarks FROM PREKEYGEN;"
                        .ExecuteNonQuery()

                        .CommandText = "SELECT PTID, RefID FROM RECOMPENSE;"
                        .ExecuteNonQuery()

                        .CommandText = "SELECT RefID, RefAmt, RefDate, RefStat, RefTimeChanged, RefIssuedAmt, RefExpDate, RefRemarks, ResNo, RegNo, Lno FROM REFUND;"
                        .ExecuteNonQuery()

                        .CommandText = "SELECT RegNo, RegDate, RegStat, RegGuestType, RegAmt, RegBalance, RegRemarks, GNO, ResNO, DBID FROM REGISTRATION;"
                        .ExecuteNonQuery()

                        .CommandText = "SELECT RegDNo, RegDChkINTime, RegDChkOutTime, RegDLastUpdate, RegDDaysUpdated, RegDRMAmt, RegDRemarks, RegDStat, RegDNoGuest, RegDNoOfExtDays, RMNo, RegNo FROM REGISTRATION_DETAILS;"
                        .ExecuteNonQuery()

                        .CommandText = "SELECT ResNo, ResDate, ResNoRoom, ResGuestType, ResAmt, ResDownPay, ResBalance, ResStat, ResNoOccupants, ResRemarks, GNo, RegNo FROM RESERVATION;"
                        .ExecuteNonQuery()

                        .CommandText = "SELECT ResNo, RMNo, ResDTimeIn, ResDTimeOut, ResDStat, ResDNoDays, ResDByRequest, ResDNoOccupants FROM RESERVATION_DETAILS;"
                        .ExecuteNonQuery()

                        .CommandText = "SELECT RMFID, RMFName, RMFStatus, RMFRemarks FROM RMFEATURE;"
                        .ExecuteNonQuery()

                        .CommandText = "SELECT RMFID, RMNo FROM RMFEATURE_DETAILS;"
                        .ExecuteNonQuery()

                        .CommandText = "SELECT RMRID, RMRRemarks, RMRAmt, RMRStartTime, RMREndTime, RMRType, RMRname FROM RMRATE;"
                        .ExecuteNonQuery()

                        .CommandText = "SELECT RMNo, RMRID, RMDActive FROM RMRATE_DETAILS;"
                        .ExecuteNonQuery()

                        .CommandText = "SELECT RMSID, RMSName, RMSStartTime, RMSEndTime, RMSStat, ResNo, RMNo FROM RMSTATUS;"
                        .ExecuteNonQuery()

                        .CommandText = "SELECT RMNo, RMDesc, RMMaxGuest, RMFloor, RMView, RMTelNo, RMType, RMCurrStat, RMRemarks FROM ROOM;"
                        .ExecuteNonQuery()

                        .CommandText = "SELECT SID, SDesc, SDeptName, SStat FROM SERVICES_AND_AMENITIES;"
                        .ExecuteNonQuery()

                        .CommandText = "SELECT ShiftID, ShiftTimeStart, ShiftTimeEnd, ShiftName, ShiftStat, ShiftRemarks FROM SHIFT;"
                        .ExecuteNonQuery()

                        .CommandText = "SELECT LNo, SiAmtTurnOver, SITotalAmtCollected, SIAmtReceivable, SIcashOut, SIRemarks, SICashOnHand, SICash, SICheque, SIBank, SICCard, SIRecompense FROM SHIFT_INFO;"
                        .ExecuteNonQuery()

                        .CommandText = "SELECT SysID, ResGracePeriod, ResDownPaymentPercentage, RefPercentage, RefGracePeriod, TotalCashInFD FROM SYSTEM;"
                        .ExecuteNonQuery()

                        Return True
                    Catch ex As SqlException
                        Return False
                    End Try
                End With
            End Using
            objConnection.Close()
        End Using

    End Function

    Private Sub LoadDatabase()
        lblCount.Text = ListItems(GetControlFile(), "SELECT DatabaseNo AS [Database No], HotelName AS [Hotel Name], LastUsed AS [Default Database], DatabasePath AS [Database Path] FROM DatabaseFile", dgvListOfDatabase).ToString
    End Sub

    Private Function HasDefaultDatabase() As Boolean

        Using objConnection As SqlConnection = SetUpConnection(GetControlFile(), True)
            objConnection.Open()
            Using objDataSet As DataSet = SetUpDataSet(SetUpDataAdapter(objConnection, "SELECT * FROM DatabaseFile WHERE LastUsed = 'TRUE'", DatabaseTransactionState.SelectState), "Check")
                If objDataSet.Tables("Check").Rows.Count <> 1 Then
                    Return False
                Else
                    Return True
                End If
            End Using
            objConnection.Close()
        End Using

    End Function

    Private Function ThereAreInputErrors() As Boolean
        If Trim(txtPath.Text) = String.Empty Then
            Msg("1000")
            btnBrowsePath.Focus()
            Return True
            Exit Function
        End If

        If Trim(txtHotelName.Text) = String.Empty Then
            Msg("1000")
            txtHotelName.Focus()
            txtHotelName.SelectAll()
            Return True
            Exit Function
        End If

        If My.Computer.FileSystem.FileExists(txtPath.Text) = True Then
            If IsCorrectDatabase() = False Then
                Msg("1013")
                btnBrowsePath.Focus()
                Return True
                Exit Function
            End If
        Else
            Msg("1082")
            btnBrowsePath.Focus()
            Return True
            Exit Function
        End If

        If gState = State.adding Or (gState = State.updating Andalso String.Compare(txtHotelName.Text, dgvListOfDatabase.Item(1, dgvListOfDatabase.CurrentRow.Index).Value.ToString, True) <> 0) Then
            Using objConnection As SqlConnection = SetUpConnection(GetControlFile(), True)
                objConnection.Open()
                Using objDataSet As DataSet = SetUpDataSet(SetUpDataAdapter(objConnection, "SELECT * FROM DatabaseFile WHERE Hotelname = '" & txtHotelName.Text & "'", DatabaseTransactionState.SelectState), "Check")
                    If objDataSet.Tables("Check").Rows.Count <> 0 Then
                        Msg("1002")
                        txtHotelName.Focus()
                        txtHotelName.SelectAll()
                        Return True
                    Else
                        Return False
                    End If
                End Using
                objConnection.Close()
            End Using
        End If

    End Function

#End Region

#Region "Command Buttons"

    Private Sub btnAddnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddnew.Click

        gState = State.adding

        ClearControls(gbxInput)

        If dgvListOfDatabase.Rows.Count = 0 Then
            chkSetAsDefault.Checked = True
        Else
            chkSetAsDefault.Checked = False
        End If

        gbxInput.Enabled = True
        gbxInput.BringToFront()
        gbxListOfDatabase.Enabled = False

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click

        If dgvListOfDatabase.SelectedRows.Count > 0 Then
            gState = State.updating

            gbxInput.Enabled = True
            gbxInput.BringToFront()
            gbxListOfDatabase.Enabled = False

            txtHotelName.Text = dgvListOfDatabase.Item(1, dgvListOfDatabase.CurrentRow.Index).Value.ToString
            txtPath.Text = dgvListOfDatabase.Item(3, dgvListOfDatabase.CurrentRow.Index).Value.ToString
            chkSetAsDefault.Checked = CType(dgvListOfDatabase.Item(2, dgvListOfDatabase.CurrentRow.Index).Value, Boolean)

        Else
            Msg("1005")
        End If

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        If dgvListOfDatabase.SelectedRows.Count > 0 Then
            If dgvListOfDatabase.RowCount > 1 Then
                If chkSetAsDefault.CheckState <> CheckState.Checked Then
                    If Msg("1034", Button.YesNo) = ButtonClicked.Yes Then
                        Using objConnection As SqlConnection = SetUpConnection(GetControlFile(), True)
                            objConnection.Open()
                            Using objTransaction As SqlTransaction = objConnection.BeginTransaction
                                Using objCommand As SqlCommand = objConnection.CreateCommand
                                    objCommand.Transaction = objTransaction
                                    objCommand.CommandText = "DELETE FROM DatabaseFile WHERE DatabaseNo = @DatabaseNo"
                                    objCommand.Parameters.AddWithValue("@DatabaseNo", dgvListOfDatabase.Item(0, dgvListOfDatabase.CurrentRow.Index).Value)

                                    Try
                                        objCommand.ExecuteNonQuery()
                                        objTransaction.Commit()

                                        frmParent.tssStatus.Text = "Database deleted..."
                                        gstate = State.waiting

                                        ClearControls(gbxInput)
                                        LoadDatabase()

                                    Catch ex As Exception

                                        objTransaction.Rollback()
                                        Msg("1008", , NWLN & ex.Message)

                                    End Try

                                End Using
                            End Using
                            objConnection.Close()
                        End Using
                    End If
                Else
                    Msg("1016")
                End If
            Else
                Msg("1016", , "Deletion cannot procede because the control file must contain at least one database.")
            End If
        Else
            Msg("1014")
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If gState <> State.waiting Then
            gState = State.waiting
            gbxInput.Enabled = False
            gbxListOfDatabase.Enabled = True
            gbxListOfDatabase.BringToFront()
        End If
    End Sub

    Private Sub btnBrowsePath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowsePath.Click
        Dim strResult As String = ShowOpenFileDialog()
        If strResult <> String.Empty Then
            txtPath.Text = strResult
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If ThereAreInputErrors() Then Exit Sub

        Using objConnection As SqlConnection = SetUpConnection(GetControlFile(), True)

            objConnection.Open()
            Using objTransaction As SqlTransaction = objConnection.BeginTransaction

                Using objCommand As SqlCommand = objConnection.CreateCommand
                    With objCommand
                        .Transaction = objTransaction

                        Try
                            .CommandText = "UPDATE DatabaseFile SET LastUsed='FALSE'; "
                            .ExecuteNonQuery()

                            Select Case gState
                                Case State.adding
                                    .CommandText = "SELECT MAX(DatabaseNo) FROM DatabaseFile"

                                    Dim objMaxId As Object = .ExecuteScalar
                                    Dim intMaxDatabaseNo As Integer
                                    If objMaxId Is DBNull.Value Then
                                        intMaxDatabaseNo = 1000
                                    Else
                                        intMaxDatabaseNo = CType(objMaxId, Integer)
                                        intMaxDatabaseNo += 1
                                    End If

                                    .CommandText = "INSERT INTO DatabaseFile (DatabaseNo, DatabasePath, HotelName, LastUsed) VALUES (@DatabaseNo, @DatabasePath, @HotelName, @LastUsed); "
                                    .Parameters.AddWithValue("@DatabaseNo", intMaxDatabaseNo)
                                    .Parameters.AddWithValue("@DatabasePath", txtPath.Text)
                                    .Parameters.AddWithValue("@HotelName", Trim(txtHotelName.Text))
                                    .Parameters.AddWithValue("@LastUsed", chkSetAsDefault.Checked)

                                    .ExecuteNonQuery()

                                Case State.updating

                                    .CommandText = "UPDATE DatabaseFile SET DatabasePath=@DatabasePath,  HotelName=@HotelName, LastUsed=@LastUsed WHERE Databaseno=@DataBaseNo; "
                                    .Parameters.AddWithValue("@DatabasePath", txtPath.Text)
                                    .Parameters.AddWithValue("@HotelName", Trim(txtHotelName.Text))
                                    .Parameters.AddWithValue("@LastUsed", chkSetAsDefault.Checked)
                                    .Parameters.AddWithValue("@DatabaseNo", dgvListOfDatabase.Item(0, dgvListOfDatabase.CurrentRow.Index).Value)

                                    .ExecuteNonQuery()
                            End Select

                            objTransaction.Commit()

                            LoadDatabase()

                            gState = State.waiting

                            ClearControls(gbxInput)
                            gbxInput.Enabled = False
                            gbxListOfDatabase.Enabled = True
                            gbxListOfDatabase.BringToFront()

                            dgvListOfDatabase_SelectionChanged(Nothing, Nothing)

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

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btnTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTest.Click
        If My.Computer.FileSystem.FileExists(txtPath.Text) = True Then
            If IsCorrectDatabase() Then
                Msg("1012")
            Else
                Msg("1013")
            End If
        Else
            Msg("1010", Button.Ok, "Path does not exists, It was moved, renamed or deleted outside the application")
        End If
    End Sub

    Private Sub btnRestart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestart.Click
        Restart = True
        Application.Restart()
    End Sub

#End Region

#Region "MISC"

    Private Sub dgvListOfDatabase_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvListOfDatabase.SelectionChanged
        If dgvListOfDatabase.RowCount <> 0 Then
            txtHotelName.Text = dgvListOfDatabase.Item(1, dgvListOfDatabase.CurrentRow.Index).Value.ToString
            txtPath.Text = dgvListOfDatabase.Item(3, dgvListOfDatabase.CurrentRow.Index).Value.ToString
            chkSetAsDefault.Checked = CType(dgvListOfDatabase.Item(2, dgvListOfDatabase.CurrentRow.Index).Value, Boolean)
        End If
    End Sub

    Private Sub frmSystemDatabase_parent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadDatabase()
        dgvListOfDatabase.AlternatingRowsDefaultCellStyle = SetAlternatingColor()
    End Sub

    Private Sub frmSystemDatabase_parent_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        If Not Restart Then
            If gstate <> State.waiting Then
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

            If dgvListOfDatabase.Rows.Count > 0 Then
                If HasDefaultDatabase() = False Then
                    Msg("1016")
                    e.Cancel = True
                End If
            End If

        End If 'Restart
    End Sub

    Private Sub txtPath_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPath.KeyPress
        If Trim(txtPath.Text) = String.Empty Then
            btnBrowsePath_Click(Nothing, Nothing)
        End If
    End Sub

#End Region

End Class