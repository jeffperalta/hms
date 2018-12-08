Option Explicit On
Option Strict On

Imports System.Data.SqlClient
Imports System.Data

' Programmer:   Jo Jefferson D. Peralta
' Date:         March 07, 2007
' Title:        frmLogin
' Purpose:      To identify if the user credential is valid or not.
'               The system users (SYS, QUER, and TRANS) are able to log without any constraints
'                plus this accounts can log to different databases found at the control file.
'               In case that a shift changes while in the login form (for instance the system clock was altered)
'                the application will still use the original shift on the time that the application opens
'                However, once the application restarts or closes the new shift schedule is adapted.              

' Requirements: ->  (+) LOG_INFO(LNo, LTimeIn, ShiftID, LStat, EID)
'               ->  (+) EMPLOYEE(EID, EFName, ELName, EMI, EPosition, EActive, EUserType)
'               ->  Insert a record at EMPLOYEE when a system user has logged to the application for the first time
'               ->  Lstat='END' for system users
'               ->  The application will detect if there are no shifts and conflicting shift schedules
'                   if there are no shifts, no other users can log to the system except the system users
'                   On the other hand, if there are conflicts in the shift schedules the application will announce to the
'                   user that it will automatically choose a shift with the highest ShiftNo.
'                   If the user disagrees on this he can use the frmAdvanceLogIn to determine a shift manually.
'               ->  Inactive user accounts are not allowed to use the application.
'               ->  Only 5 entries of incorrect user credentials are allowed otherwise the application will automatically abort
'               ->  If the user has not logged within 5 mins the application will automatically close
'               ->  This interface also detects if the user has a previous UNENDED log 
'                   and will resume to the same log no
' Results:      ->  If the user has successfully logged:
'                       LogNo()             -will have the value equal to the current LogNo
'                       DatabaseUser()      -is set to the current user ID
'                       UserPrivilege()     -will contain the user privilege of the current database user
'                       ShiftNow()          -will contain the shift number of default or if the user
'                                            chooses a shift manually at frmAdvanceLogIn this will have the corresponding value
'                       LogInAsSystem()     -is equal to true only if the system user account is used to log in the system
'                       IsValidShift()      -is false when there are conflicting shifts and there are no shifts schedules
'               ->  A new record is added in the employee table if the system user has log to the system for the first time
'               ->  A new record is added in the Log_info table

Public Class frmLogin

    Private ShiftStatus As ShiftStatus
    Private _StayedInSec As Integer = 0
    Private _NoOfTries As Integer = 0
    Private _Legal As Boolean = False

#Region "Functions/SubRoutines"

    Public Property ChangeShiftNumber() As String
        Get
            Return ShiftNow
        End Get
        Set(ByVal value As String)
            ShiftNow = value

            Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
                objConnection.Open()
                Using objCommand As SqlCommand = New SqlCommand("SELECT ShiftName FROM SHIFT WHERE ShiftID='" & value & "'", objConnection)
                    lblStatus.Text = objCommand.ExecuteScalar.ToString
                End Using
                objConnection.Close()
            End Using

            ShiftStatus = Log.ShiftStatus.ValidShift

        End Set
    End Property

#End Region

#Region "Buttons"

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
            objConnection.Open()
            Using objTransaction As SqlTransaction = objConnection.BeginTransaction
                Using objCommand As SqlCommand = objConnection.CreateCommand
                    With objCommand
                        .Transaction = objTransaction

                        Try

                            Select Case CheckUserNameAndPassword(txtUserName.Text, txtPassword.Text, True, True) 'check at the controlfile database
                                Case KindOfUserAccess.Illegal

                                    LogInAsSystem = False
                                    _Legal = False

                                    Select Case CheckUserNameAndPassword(txtUserName.Text, txtPassword.Text, False, True)
                                        Case KindOfUserAccess.Authorized 'At data file

                                            Select Case ShiftStatus
                                                Case Log.ShiftStatus.NoValidShift
                                                    Msg("1079", Button.Ok, "There is no defined shift schedule right now. " & NWLN & "Date and time of login: (" & Date.Now & ") " & NWLN & "Please contact the manager to arrange the shift schedules.")
                                                    Exit Sub
                                                Case Log.ShiftStatus.DuplicateShifts

                                                    .CommandText = "SELECT ShiftName FROM SHIFT WHERE ShiftID=@ShiftID"
                                                    .Parameters.AddWithValue("@ShiftID", ShiftNow)
                                                    Dim strShiftName As String = .ExecuteScalar.ToString

                                                    If Msg("1080", Button.OkCancel, "Date and time of login: (" & Date.Now & ")" & NWLN & _
                                                                              "The application will assign the user at shift No: " & ShiftNow() & _
                                                                              " - " & strShiftName) = ButtonClicked.Cancel Then
                                                        frmAdvanceLogIn.ShowDialog()
                                                        Exit Sub

                                                    Else
                                                        ShiftStatus = Log.ShiftStatus.ValidShift
                                                        OK_Click(Nothing, Nothing)
                                                    End If

                                                Case Log.ShiftStatus.ValidShift

                                                    _Legal = True

                                                    If IsExisting("SELECT Lno FROM LOG_INFO WHERE LStat='RESUME' AND EID='" & DatabaseUser & "'") Then

                                                        .CommandText = "SELECT EMPLOYEE.ELName  + ', ' + EMPLOYEE.EFName + ' ' + EMPLOYEE.EMI AS NAME, LOG_INFO.LNo, SHIFT.ShiftName, LOG_INFO.LTimeIn,  " & _
                                                                       "       EMPLOYEE.EID " & _
                                                                       "FROM   LOG_INFO INNER JOIN " & _
                                                                       "       SHIFT ON LOG_INFO.ShiftID = SHIFT.ShiftID INNER JOIN " & _
                                                                       "       EMPLOYEE ON LOG_INFO.EID = EMPLOYEE.EID " & _
                                                                       "WHERE  (LOG_INFO.LStat = 'RESUME') AND (LOG_INFO.EID = '" & DatabaseUser() & "');"

                                                        Using objReader As SqlDataReader = objCommand.ExecuteReader
                                                            objReader.Read()
                                                            LogNo() = objReader("LNo").ToString

                                                            Msg("1081", Button.Ok, "CURRENT LOG INFORMATION: " & NWLN & _
                                                                                    "   USER:       " & objReader("EID").ToString & NWLN & _
                                                                                    "   NAME:       " & objReader("Name").ToString & NWLN & _
                                                                                    "   LOG NUMBER: " & objReader("Lno").ToString & NWLN & _
                                                                                    "   SHIFT NAME: " & objReader("ShiftName").ToString & NWLN & _
                                                                                    "   TIME IN:    " & objReader("LTimeIn").ToString & NWLN)
                                                        End Using

                                                    Else

                                                        .CommandText = "INSERT INTO LOG_INFO (LNo, LTimeIn, ShiftID, EID, LStat) " & _
                                                                        "VALUES(@Lno, @LTimeIn, @ShiftID, @EID, 'RESUME'); "
                                                        With .Parameters
                                                            .Clear()
                                                            LogNo = GetPrimaryKeyNo("LogInfo")
                                                            .AddWithValue("@LNo", LogNo)
                                                            .AddWithValue("@LTimeIn", Date.Now)
                                                            .AddWithValue("@EID", DatabaseUser())
                                                            .AddWithValue("@ShiftID", ShiftNow)
                                                        End With
                                                        IncrementPrimaryKeyNo("LogInfo")

                                                        .ExecuteNonQuery()
                                                    End If

                                            End Select

                                        Case KindOfUserAccess.Blocked

                                            _Legal = False

                                            If _NoOfTries = 4 Then
                                                Application.Exit()
                                            Else
                                                _NoOfTries += 1
                                                lblTry.Text = CType(5 - _NoOfTries, String) & IIf(5 - _NoOfTries = 1, " try", " tries").ToString & " left"
                                            End If

                                            Msg("1070", Button.Ok)
                                            ClearControls(Me)
                                            txtUserName.Focus()

                                        Case KindOfUserAccess.Illegal

                                            _Legal = False

                                            If _NoOfTries = 4 Then
                                                Application.Exit()
                                            Else
                                                _NoOfTries += 1
                                                lblTry.Text = CType(5 - _NoOfTries, String) & IIf(5 - _NoOfTries = 1, " try", " tries").ToString & " left"
                                            End If

                                            Msg("1028", Button.Ok)
                                            ClearControls(Me, txtUserName)
                                            txtUserName.Focus()
                                            txtUserName.SelectAll()

                                    End Select

                                Case KindOfUserAccess.Authorized 'At control file

                                    _Legal = True
                                    LogInAsSystem = True

                                    If Not IsExisting("SELECT EID FROM EMPLOYEE WHERE EID='" & DatabaseUser & "'") Then

                                        .CommandText = "INSERT INTO EMPLOYEE (EID, EFName, ELName, EMI, Eposition, EuserName, Eactive, EUserType, EPicPath) " & _
                                                       "VALUES (@EID, @EFName, @ELName, @EMI, @EPosition, @EuserName, @Eactive, @EUserType, @EPicPath); "
                                        With .Parameters
                                            .AddWithValue("@EID", DatabaseUser())
                                            .AddWithValue("@EFName", "SYSTEM USER")
                                            .AddWithValue("@ELName", String.Empty)
                                            .AddWithValue("@EMI", String.Empty)
                                            .AddWithValue("@Eposition", "ADMINISTRATOR")
                                            .AddWithValue("@EuserName", txtUserName.Text)
                                            .AddWithValue("@Eactive", "ACTIVE")

                                            If String.Compare(txtUserName.Text, "SYS", True) = 0 Then
                                                .AddWithValue("@EUserType", "SYSTEM")
                                            ElseIf String.Compare(txtUserName.Text, "QUER", True) = 0 Then
                                                .AddWithValue("@EUserType", "QUERY")
                                            ElseIf String.Compare(txtUserName.Text, "TRANS", True) = 0 Then
                                                .AddWithValue("@EUserType", "TRANSACTION")
                                            End If

                                            .AddWithValue("@EPicPath", String.Empty)
                                        End With

                                        .ExecuteNonQuery()
                                    End If


                                    .CommandText = "INSERT INTO LOG_INFO (LNo, LTimeIn, ShiftID, EID, LStat) " & _
                                                   "VALUES(@Lno, @LTimeIn, @ShiftID, @EID, 'END'); "
                                    With .Parameters
                                        .Clear()

                                        LogNo() = GetPrimaryKeyNo("LogInfo")

                                        .AddWithValue("@LNo", LogNo())
                                        .AddWithValue("@LTimeIn", Date.Now)
                                        .AddWithValue("@EID", DatabaseUser())
                                        If ShiftNow = String.Empty Then
                                            .AddWithValue("@ShiftID", "NONE")
                                        Else
                                            .AddWithValue("@ShiftID", ShiftNow)
                                        End If

                                    End With
                                    IncrementPrimaryKeyNo("LogInfo")
                                    .ExecuteNonQuery()

                            End Select

                            objTransaction.Commit()

                        Catch ex As Exception

                            objTransaction.Rollback()
                            _Legal = False

                            Msg("1008", , NWLN & ex.Message)

                        End Try


                    End With
                End Using
            End Using
            objConnection.Close()
        End Using 'objConnection

        If _Legal = True Then

            Timer1.Enabled = False

            Select Case UserPrivilege()
                Case Privilege.system
                    frmSystem.Show()
                Case Privilege.query
                    frmQuery.Show()
                Case Privilege.transaction
                    frmTransaction.Show()
            End Select

            Me.Close()
        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Application.Exit()
    End Sub

#End Region

#Region "MISC"

    Private Sub frmLogin_Load(ByVal sener As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text += " " & GetHotelName
        ShiftStatus = DetermineShiftNow()

        Select Case ShiftStatus
            Case Log.ShiftStatus.NoValidShift
                lblStatus.Text = "No shift schedule..."
            Case Log.ShiftStatus.DuplicateShifts
                lblStatus.Text = "Conflicting shifts..."
            Case Log.ShiftStatus.ValidShift
                lblStatus.Text = ShiftName()
        End Select

        'Display number of users that are currently logged
        Dim objDataset As DataSet = SetUpDataSet(SetUpDataAdapter(SetUpConnection(DatabasePath, True), "SELECT * FROM LOG_INFO WHERE LStat='RESUME'", DatabaseTransactionState.SelectState), "CHECK")
        lblLogNo.Text = "Logs: Currently there " & IIf(objDataset.Tables("Check").Rows.Count > 1, "are ", "is ").ToString & objDataset.Tables("Check").Rows.Count.ToString & IIf(objDataset.Tables("Check").Rows.Count > 1, " logs ", " log ").ToString & "in the system. "

        lblTime.Text = Format(Date.Now, "MMMM dd, yyyy hh:mm:ss tt")

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If _StayedInSec = 300 Then '5 mins
            Application.Exit()
        Else
            _StayedInSec += 1
        End If

        lblTime.Text = Format(Date.Now, "MMMM dd, yyyy hh:mm:ss tt")
    End Sub

    Private Sub GoToAdvancedSettingsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoToAdvancedSettingsToolStripMenuItem1.Click
        txtUserName.AutoCompleteCustomSource.Add(txtUserName.Text)
        frmAdvanceLogIn.ShowDialog()
    End Sub

    Private Sub NormalLogToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NormalLogToolStripMenuItem.Click
        OK_Click(Nothing, Nothing)
    End Sub

#End Region

End Class