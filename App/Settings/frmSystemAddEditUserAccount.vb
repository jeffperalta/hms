Option Explicit On
Option Strict On

Imports System.Data
Imports System.Data.SqlClient

' Programmer:   Jo Jefferson D. Peralta
' Date:         February 25, 2007
' Title:        frmSystemAddEditUserAccount
' Purpose:      This interface adds new users and gives privileges to each.
'               Privilege may be for query, system, and transactional users
'               System users does not have any limits with regards to accessing different
'               forms/interfaces. Transactional users are assigned mostly to FDO's with privilege
'               of creating reservations, registrations, and accept payments. But this type of
'               users does not have access to system settings interfaces. Limited access can also
'               be granted to allow access in viewing reports and queries. Users with query privilege
'               cannot make any major transactions in the system aside from viewing reports and queries.
'               Aside from this types of users, the application has a general type of accounts that can
'               be used to access the different databases managed by this application. 
'               This accounts are saved in the control file, a separate database that holds the information
'               of each datafiles. Therefore this accounts are usable in whatever database was loaded.
' Requirements: ->  (+/-) EMPLOYEE(EID, EFName, ELName, EMI, EPosition, EActive, EUserName, EUserPassword, EUserType, EPicPath)
'               ->  (*) EMPLOYEE(EFName, ELName, EMI, EPosition, EActive, EUserName, EUserPassword, EUserType, EPicPath)
'               ->  (*) USERAUTHENTICATION (UserPassword)
'               ->  Deletion of Employee Information will not continuee if the user already has a log history
'               ->  Required Fields at EID, EFname, EActive, EuserName, EUserType
'               ->  Unique Fields At EUserName
'               ->  EUserName is not equal to sys, quer, and trans
'               ->  User Id and username should be provided and must be unique among users
'               ->  First Name, access level [QUERY| TRANSACTIONAL| SYSTEM], Status[Active|Inactive]
'               ->  Typical Users must not have the same usernames with advanced users [SYS|TRANS|QUER]
' Results:      ->  A new account is created.
'               ->  Old accounts are modified, or may be deleted especially when the account has 
'                   no transactions yet
'               ->  Modify the password of advanced users [SYS | TRANS | QUER]
'               ->  The default password for typical users is x[username]
'               ->  The default password for advance users is system
'Messagebox>>> true

Public Class frmSystemAddEditUserAccount

    Private gStatus As State = State.waiting
    Private gStatus_secondtab As State = State.waiting

#Region "Function/Subroutines"

    Private Sub DisplayTypicalUser()
        ' 0 EID
        ' 1 EFName
        ' 2 ELName
        ' 3 EMI
        ' 4 EPosition
        ' 5 EActive
        ' 6 EUserName
        ' 7 EUserType
        ' 8 EPicPath
        lblCount.Text = ListItems(DatabasePath, "SELECT EID AS [User ID], EFName AS [First Name], ELName AS [Last Name], EMI AS [Middle Name], EPosition AS [Position] , EActive AS [Status], EUserName AS [Username], EUserType AS [Access Level], EPicPath AS [Picture Path] " & _
                                                "FROM EMPLOYEE WHERE EID Not IN ('DEFAULT1000','DEFAULT1001','DEFAULT1002') " & IIf(Trim(cboStatusView.Text).ToUpper = "ALL", "", "AND EActive = '" & cboStatusView.Text & "'").ToString, _
                                                dgvListOfUsers).ToString

    End Sub

    Private Sub DisplayAdvanceUsers()
        ListItems(GetControlFile(), "SELECT ID AS [User ID], UserName AS [User Name], UserType AS [User Type] FROM UserAuthentication", dgvAdvanceUsers)
    End Sub

    Private Sub UpdateComboBox()
        ListItems(DatabasePath, "SELECT DISTINCT EPosition FROM EMPLOYEE", cboPosition, "EPosition")
    End Sub

    Private Function ThereAreInputErrors() As Boolean

        If Trim(txtUserID.Text) = String.Empty Then
            Msg("1000")
            txtUserID.Focus()
            Return True
            Exit Function
        End If

        If Trim(txtFirstName.Text) = String.Empty Then
            Msg("1000")
            txtFirstName.Focus()
            Return True
            Exit Function
        End If

        If Trim(txtUsername.Text) = String.Empty Then
            Msg("1000")
            txtUsername.Focus()
            Return True
            Exit Function
        End If

        If Trim(txtUsername.Text).Length < 6 Then
            Msg("1078")
            txtUsername.SelectAll()
            txtUsername.Focus()
            Return True
            Exit Function
        End If

        If Trim(cboAccessLevel.Text) = String.Empty Then
            Msg("1000")
            cboAccessLevel.Focus()
            Return True
            Exit Function
        End If

        If Trim(cboStatus.Text) = String.Empty Then
            Msg("1000")
            cboStatus.Focus()
            Return True
            Exit Function
        End If

        If Trim(cboAccessLevel.Text).ToUpper <> "SYSTEM" And _
           Trim(cboAccessLevel.Text).ToUpper <> "TRANSACTION" And _
           Trim(cboAccessLevel.Text).ToUpper <> "QUERY" Then
            Msg("1084")
            cboAccessLevel.Focus()
            cboAccessLevel.SelectAll()
            Return True
            Exit Function
        End If

        If Trim(cboStatus.Text).ToUpper <> "ACTIVE" And _
           Trim(cboStatus.Text).ToUpper <> "INACTIVE" Then
            Msg("1085")
            cboStatus.Focus()
            cboStatus.SelectAll()
            Return True
            Exit Function
        End If

        'Ensure that when editing the txtbox for EID is disabled
        If gStatus = State.adding AndAlso _
                IsExisting("SELECT EID FROM EMPLOYEE WHERE EID = '" & TrimAll(txtUserID.Text) & "'") Then
            Msg("1002")
            txtUserID.Focus()
            txtUserID.SelectAll()
            Return True
            Exit Function
        End If

        If gStatus = State.adding Then
            If IsExisting("SELECT EID FROM EMPLOYEE WHERE EUserName='" & TrimAll(txtUsername.Text) & "'") Then
                Msg("1002")
                txtUsername.Focus()
                txtUsername.SelectAll()
                Return True
                Exit Function
            End If
        ElseIf gStatus = State.updating Then
            If TrimAll(txtUsername.Text) <> TrimAll(dgvListOfUsers.Item(6, dgvListOfUsers.CurrentRow.Index).Value.ToString) Then
                If IsExisting("SELECT EID FROM EMPLOYEE WHERE EUserName='" & TrimAll(txtUsername.Text) & "'") Then
                    Msg("1002")
                    txtUsername.Focus()
                    txtUsername.SelectAll()
                    Return True
                    Exit Function
                End If
            End If
        End If

        If TrimAll(txtUsername.Text) = "SYS" Or TrimAll(txtUsername.Text) = "QUER" Or TrimAll(txtUsername.Text) = "TRANS" Then
            Msg("1002")
            txtUsername.Focus()
            txtUsername.SelectAll()
            Return True
            Exit Function
        End If

        If TrimAll(txtUserID.Text) = "DEFAULT1000" Or TrimAll(txtUserID.Text) = "DEFAULT1001" Or TrimAll(txtUserID.Text) = "DEFAULT1002" Then
            Msg("1002")
            txtUserID.Focus()
            txtUserID.SelectAll()
            Return True
            Exit Function
        End If

        Return False

    End Function

    Private Function ThereAreInputErrorsAtSecondTab() As Boolean

        Select Case CheckUserNameAndPassword(txtAdvanceUserName.Text, txtAdvancePassword.Text, True, False)
            Case KindOfUserAccess.Illegal
                Msg("1028")
                txtAdvancePassword.Focus()
                txtAdvancePassword.SelectAll()
                Return True
                Exit Function
        End Select


        If Trim(txtAdvanceNewPassword.Text) = String.Empty Then
            Msg("1000")
            txtAdvanceNewPassword.Focus()
            txtAdvanceNewPassword.SelectAll()
            Return True
            Exit Function
        End If

        If Trim(txtAdvanceNewPassword.Text).Length < 6 Then
            Msg("1078")
            txtAdvanceNewPassword.Focus()
            txtAdvanceNewPassword.SelectAll()
            Return True
            Exit Function
        End If

        If TrimAll(txtAdvanceNewPassword.Text) <> TrimAll(txtAdvanceUserVerify.Text) Then
            Msg("1030")
            txtAdvanceUserVerify.Focus()
            txtAdvanceUserVerify.SelectAll()
            Return True
            Exit Function
        End If

        Return False

    End Function

#End Region

#Region "Typical User Tab"

    Private Sub dgvListOfUsers_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvListOfUsers.SelectionChanged
        If dgvListOfUsers.RowCount > 0 Then
            Dim intCurrentRow As Integer = dgvListOfUsers.CurrentRow.Index

            With dgvListOfUsers
                txtUserID.Text = .Item(0, intCurrentRow).Value.ToString
                txtFirstName.Text = .Item(1, intCurrentRow).Value.ToString
                txtLastName.Text = .Item(2, intCurrentRow).Value.ToString
                txtMiddleName.Text = .Item(3, intCurrentRow).Value.ToString
                cboPosition.Text = .Item(4, intCurrentRow).Value.ToString
                cboStatus.Text = .Item(5, intCurrentRow).Value.ToString
                txtUsername.Text = .Item(6, intCurrentRow).Value.ToString
                cboAccessLevel.Text = .Item(7, intCurrentRow).Value.ToString
                txtPicPath.Text = .Item(8, intCurrentRow).Value.ToString
            End With

            LoadPicture(txtPicPath.Text, pnlEmployee)

        End If
    End Sub

    Private Sub cboStatusView_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboStatusView.SelectedIndexChanged
        DisplayTypicalUser()
    End Sub


    Private Sub btnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNew.Click
        ClearControls(gbxAddEditUser)
        gbxAddEditUser.Enabled = True
        gbxListOfUsers.Enabled = False
        gStatus = State.adding
        pnlEmployee.BackColor = Color.WhiteSmoke
        pnlEmployee.BackgroundImage = Nothing
        txtUserID.Enabled = True
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If dgvListOfUsers.RowCount = 0 Then
            Msg("1005")
        ElseIf dgvListOfUsers.SelectedRows.Count = 0 Then
            Msg("1005", , "Please choose an item to edit")
        Else
            gbxAddEditUser.Enabled = True
            gbxListOfUsers.Enabled = False
            gStatus = State.updating
            txtUserID.Enabled = False

            Dim intCurrentRow As Integer = dgvListOfUsers.CurrentRow.Index

            With dgvListOfUsers
                txtUserID.Text = .Item(0, intCurrentRow).Value.ToString
                txtFirstName.Text = .Item(1, intCurrentRow).Value.ToString
                txtLastName.Text = .Item(2, intCurrentRow).Value.ToString
                txtMiddleName.Text = .Item(3, intCurrentRow).Value.ToString
                cboPosition.Text = .Item(4, intCurrentRow).Value.ToString
                cboStatus.Text = .Item(5, intCurrentRow).Value.ToString
                txtUsername.Text = .Item(6, intCurrentRow).Value.ToString
                cboAccessLevel.Text = .Item(7, intCurrentRow).Value.ToString
                txtPicPath.Text = .Item(8, intCurrentRow).Value.ToString
            End With

            LoadPicture(txtPicPath.Text, pnlEmployee)

        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        If dgvListOfUsers.RowCount = 0 Then
            Msg("1005", , "There are no items to delete")
            Exit Sub
        ElseIf dgvListOfUsers.SelectedRows.Count = 0 Then
            Msg("1005", , "Please choose an item to delete")
            Exit Sub
        End If

        If IsExisting("SELECT LNo FROM LOG_INFO WHERE EID='" & dgvListOfUsers.Item(0, dgvListOfUsers.CurrentRow.Index).Value.ToString & "'") Then
            Msg("1006", , "Cannot delete the employee information because there is already a log associated to it.")
            Exit Sub
        End If

        If Msg("1034", Button.YesNo) = ButtonClicked.Yes Then

            Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
                objConnection.Open()

                Using objTransaction As SqlTransaction = objConnection.BeginTransaction
                    Using objCommand As SqlCommand = objConnection.CreateCommand
                        With objCommand
                            .Transaction = objTransaction
                            Try
                                .CommandText = "DELETE FROM EMPLOYEE WHERE EID=@EID"
                                .Parameters.AddWithValue("@EID", dgvListOfUsers.Item(0, dgvListOfUsers.CurrentRow.Index).Value)
                                .ExecuteNonQuery()

                                objTransaction.Commit()
                                DisplayTypicalUser()
                                frmParent.tssStatus.Text = "User Account Deleted..."

                            Catch ex As Exception

                                objTransaction.Rollback()
                                Msg("1006" & NWLN & ex.Message)

                            End Try
                        End With
                    End Using
                End Using

                objConnection.Close()
            End Using
        End If
    End Sub


    Private Sub btnUserSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUserSave.Click
        If ThereAreInputErrors() Then Exit Sub

        Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
            objConnection.Open()
            Using objTransaction As SqlTransaction = objConnection.BeginTransaction
                Using objCommand As SqlCommand = objConnection.CreateCommand
                    With objCommand

                        .Transaction = objTransaction
                        Select Case gStatus
                            Case State.adding
                                .CommandText = "INSERT INTO EMPLOYEE (EID, EFName, ELName, EMI, EPosition, EActive, EUserName, EUserPassword, EUserType, EPicPath) " & _
                                               "VALUES (@EID, @EFName, @ELName, @EMI, @EPosition, @EActive, @EUserName, @EUserPassword, @EUserType, @EPicPath) "

                                .Parameters.AddWithValue("@EUserPassword", Encrypt("x" & TrimAll(txtUsername.Text).ToLower))
                            Case State.updating

                                .CommandText = "UPDATE EMPLOYEE SET EFName=@EFName, ELName=@ELName, EMI=@EMI, EPosition=@EPosition, " & _
                                               "EActive=@EActive, EUserName=@EUserName, EUserType=@EUserType, EPicPath=@EPicPath " & _
                                               "WHERE EID=@EID"
                        End Select

                        .Parameters.AddWithValue("@EID", TrimAll(txtUserID.Text))
                        .Parameters.AddWithValue("@EFName", TrimAll(txtFirstName.Text))
                        .Parameters.AddWithValue("@ELName", TrimAll(txtLastName.Text))
                        .Parameters.AddWithValue("@EMI", TrimAll(txtMiddleName.Text))
                        .Parameters.AddWithValue("@EPosition", TrimAll(cboPosition.Text))
                        .Parameters.AddWithValue("@EActive", TrimAll(cboStatus.Text))
                        .Parameters.AddWithValue("@EUserName", TrimAll(txtUsername.Text))
                        .Parameters.AddWithValue("@EUserType", TrimAll(cboAccessLevel.Text))
                        .Parameters.AddWithValue("@EPicPath", txtPicPath.Text)

                        Try
                            .ExecuteNonQuery()
                            objTransaction.Commit()

                            DisplayTypicalUser()
                            UpdateComboBox()

                            btnCancel_Click(Nothing, Nothing)

                            If gStatus = State.adding Then
                                frmParent.tssStatus.Text = "A new user account was successfully added..."
                            ElseIf gStatus = State.updating Then
                                frmParent.tssStatus.Text = "An account was successfully edited..."
                            End If

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

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        gbxAddEditUser.Enabled = False
        gbxListOfUsers.Enabled = True
        gStatus = State.waiting
        frmParent.tssStatus.Text = "Ready..."
    End Sub

    Private Sub btnPicPath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPicPath.Click
        With ofdPicPath
            .AddExtension = True
            .CheckFileExists = True
            .CheckPathExists = True
            .FileName = ""
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.ProgramFiles
            .Filter = "Picture Files (*.jpeg, *.png, *.bmp, *.gif, *.jpg) | *.jpeg; *.png; *.bmp; *.gif; *.jpg"
            .Title = "Employee's Picture"
        End With

        If ofdPicPath.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtPicPath.Text = ofdPicPath.FileName
        End If

        LoadPicture(txtPicPath.Text, pnlEmployee)

    End Sub

#End Region

#Region "Advance User Tab"

    Private Sub btnEditPassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditPassword.Click
        If dgvAdvanceUsers.SelectedRows.Count <> 0 Then
            txtAdvanceUserName.Text = dgvAdvanceUsers.Item(1, dgvAdvanceUsers.CurrentRow.Index).Value.ToString
            gStatus_secondtab = State.updating
            gbxListOfAdvanceUsers.Enabled = False
            gbxEditPassword.Enabled = True
        Else
            Msg("1005", , "Please choose an account to edit")
        End If
    End Sub

    Private Sub btnAdvanceUserSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdvanceUserSave.Click

        If ThereAreInputErrorsAtSecondTab() = True Then Exit Sub

        If Msg("1034", Button.YesNo) = ButtonClicked.Yes Then

            Using objConnection As SqlConnection = SetUpConnection(GetControlFile(), True)
                objConnection.Open()

                Using objTransaction As SqlTransaction = objConnection.BeginTransaction
                    Using objCommand As SqlCommand = objConnection.CreateCommand
                        With objCommand
                            .Transaction = objTransaction
                            .CommandText = "UPDATE UserAuthentication SET UserPassword = @UserPassword WHERE UserName=@UserName; "
                            .Parameters.AddWithValue("@UserPassword", Encrypt(txtAdvanceNewPassword.Text))
                            .Parameters.AddWithValue("@UserName", txtAdvanceUserName.Text)

                            Try
                                .ExecuteNonQuery()
                                objTransaction.Commit()
                                btnAdvanceUserCancel_Click(Nothing, Nothing)

                                frmParent.tssStatus.Text = "Password changed..."
                                btnAdvanceUserCancel_Click(Nothing, Nothing)

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

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click

        If dgvAdvanceUsers.SelectedRows.Count > 0 Then
            If Msg("1034", Button.YesNo) = ButtonClicked.Yes Then
                Using objConnection As SqlConnection = SetUpConnection(GetControlFile(), True)
                    objConnection.Open()
                    Using objTransaction As SqlTransaction = objConnection.BeginTransaction
                        Using objCommand As SqlCommand = objConnection.CreateCommand
                            With objCommand
                                .Transaction = objTransaction
                                .CommandText = "UPDATE UserAuthentication SET UserPassword = '" & Encrypt("system") & "' WHERE ID = @ID"
                                .Parameters.AddWithValue("@ID", dgvAdvanceUsers.Item(0, dgvAdvanceUsers.CurrentRow.Index).Value)

                                Try
                                    .ExecuteNonQuery()
                                    objTransaction.Commit()
                                    frmParent.tssStatus.Text = "Password restarted..."
                                Catch ex As Exception
                                    objTransaction.Rollback()
                                    Msg("1008", Button.Ok, NWLN & ex.Message)
                                End Try

                            End With
                        End Using
                    End Using
                    objConnection.Close()
                End Using
            End If
        Else
            Msg("1005", , "No item was selected")
        End If

    End Sub

    Private Sub btnAdvanceUserCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdvanceUserCancel.Click
        gStatus_secondtab = State.waiting
        ClearControls(gbxEditPassword)
        gbxEditPassword.Enabled = False
        gbxListOfAdvanceUsers.Enabled = True
    End Sub

#End Region

#Region "MISC"

    Private Sub frmSystemAddEditUserAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DisplayTypicalUser()
        DisplayAdvanceUsers()
        UpdateComboBox()

        dgvAdvanceUsers.AlternatingRowsDefaultCellStyle = SetAlternatingColor()
        dgvListOfUsers.AlternatingRowsDefaultCellStyle = SetAlternatingColor()


        With My.Settings
            chkGuestFolio.Checked = .RestrictDeleteAtFolio
            chkDirectBillers.Checked = .RestrictDirectBillers
            chkModification.Checked = .RestrictModifyAmount
            chkRefunds.Checked = .RestrictRefund()
            chkShift.Checked = .RestrictShiftChange
            chkUncollectibles.Checked = .RestrictUncollectibles
            chkRegistration.Checked = .RestrictUpdateRegistration
            chkReservation.Checked = .RestrictUpdateReservation
        End With

    End Sub

    Private Sub frmSystemAddEditUserAccount_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If gStatus <> State.waiting Then

            TabControl.SelectedIndex = 0
            Select Case Msg("1033", Button.YesNoCancel)
                Case ButtonClicked.Yes
                    If ThereAreInputErrors() Then
                        e.Cancel = True
                    Else
                        btnUserSave_Click(Nothing, Nothing)
                        e.Cancel = False
                    End If
                Case ButtonClicked.No
                    e.Cancel = False
                Case ButtonClicked.Cancel
                    e.Cancel = True
            End Select

        End If

        If gStatus_secondtab <> State.waiting Then
            TabControl.SelectedIndex = 1

            Select Case Msg("1033", Button.YesNoCancel)
                Case ButtonClicked.Yes
                    If ThereAreInputErrorsAtSecondTab() Then
                        e.Cancel = True
                    Else
                        btnAdvanceUserSave_Click(Nothing, Nothing)
                        e.Cancel = False
                    End If
                Case ButtonClicked.No
                    e.Cancel = False
                Case ButtonClicked.Cancel
                    e.Cancel = True

            End Select
        End If
    End Sub

    Private Sub lblClose_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblClose.LinkClicked
        Me.Close()
    End Sub

    Private Sub chkShift_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShift.CheckedChanged
        My.Settings.RestrictShiftChange = chkShift.Checked
        My.Settings.Save()
    End Sub

    Private Sub chkReservation_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkReservation.CheckedChanged
        My.Settings.RestrictUpdateReservation = chkReservation.Checked
        My.Settings.Save()
    End Sub

    Private Sub chkRegistration_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRegistration.CheckedChanged
        My.Settings.RestrictUpdateRegistration = chkRegistration.Checked
        My.Settings.Save()
    End Sub

    Private Sub chkGuestFolio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGuestFolio.CheckedChanged
        My.Settings.RestrictDeleteAtFolio = chkGuestFolio.Checked
        My.Settings.Save()
    End Sub

    Private Sub chkModification_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkModification.CheckedChanged
        My.Settings.RestrictModifyAmount = chkModification.Checked
        My.Settings.Save()
    End Sub

    Private Sub chkUncollectibles_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkUncollectibles.CheckedChanged
        My.Settings.RestrictUncollectibles = chkUncollectibles.Checked
        My.Settings.Save()
    End Sub

    Private Sub chkRefunds_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRefunds.CheckedChanged
        My.Settings.RestrictRefund = chkRefunds.Checked
        My.Settings.Save()
    End Sub

    Private Sub chkDirectBillers_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDirectBillers.CheckedChanged
        My.Settings.RestrictDirectBillers = chkDirectBillers.Checked
        My.Settings.Save()
    End Sub

#End Region

#Region "Side Bars"

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Display(Forms.frmSettings)
    End Sub

    Private Sub tsbReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbReset.Click
        Display(Forms.frmResetPassword)
    End Sub

    Private Sub ToolStripButton13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton13.Click
        Display(Forms.frmLogMonitoring)
    End Sub

#End Region

End Class