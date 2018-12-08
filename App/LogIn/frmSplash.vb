Option Explicit On
Option Strict On

Imports System.Data.SqlClient

' Programmer:   Jo Jefferson D. Peralta
' Date:         February 27, 2007
' Title:        frmSplash
' Purpose:      Welcome to Saint Louis University Front Desk System
'               This checks if the control file or the data files are properly set
'               The application will also check if the registry is set by the installation CD
'               Copies the default database to the location where the report server's default 
'               database resides. If the database is not copied the old database (reports.mdf)
'               is used to view the reports.
'               To ensure that the reports are always updated ensure that no other application
'               is using the reports.mdf database.  The user will have to restart the application later.
' Requirements: ->  The Control File must be properly setup
'               ->  The data files must be properly setup
' Results:      ->  If the databases are missing the user will have to locate the files
'                   before the application can go to the log in form
'               ->  When the databases are in place, the log in form will be displayed

Public NotInheritable Class frmSplash

#Region "MISC"

    Private Sub tmrStatus_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrStatus.Tick
        If pgbProgress.Value < 100 Then
            pgbProgress.Value += 2
        Else
            pgbProgress.Value = 0
            Me.Close()
        End If
    End Sub

    Private Sub frmSplash_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed

        If Not My.Settings.blnFirstUse Then
            tmrStatus.Enabled = False
            Me.Hide()
            If My.Computer.FileSystem.FileExists(GetControlFile) = False Then
                If MsgNoDatabase("The Control File is Missing", "The Control File is missing. Inform the system administrator about this critical error.", "The control file contains the vital information of all databases managed by this application.", Button.OkCancel) = ButtonClicked.Ok Then
                    frmControlFileMissing.ShowDialog()
                Else
                    Application.ExitThread()
                End If
            Else
                'Check if there is a default database
                Using objConnection As SqlConnection = SetUpConnection(GetControlFile(), True)

                    Try
                        objConnection.Open()
                    Catch ex As Exception
                        MsgNoDatabase("Connection Problem.", "A connection timeout has occured. Please restart the application and start the SQL server.", "Try restarting the application or go to manage MyComputer and restart the SQL Server", Button.Ok)
                        Application.ExitThread()
                    End Try

                    Using objDataSet As DataSet = SetUpDataSet(SetUpDataAdapter(objConnection, "SELECT * FROM DatabaseFile WHERE LastUsed = 'TRUE'", DatabaseTransactionState.SelectState), "Check")
                        If objDataSet.Tables("Check").Rows.Count <> 1 Then
                            Me.Hide()
                            If MsgNoDatabase("No Default Database", "The control file has no default database. Inform the system administrator about this critical error.", "Select OK to define the default database", Button.OkCancel) = ButtonClicked.Ok Then
                                frmDatabaseMissing.Show()
                            Else
                                Application.ExitThread()
                            End If
                        Else

                            'By this time that the loaddefaultdatabase is called the
                            'the database path is already known
                            'The database number is already determined  
                            LoadDefaultDatabase()

                            If My.Computer.FileSystem.FileExists(DatabasePath) = False Then
                                Me.Hide()
                                If Msg("2001", Button.OkCancel, "Click Ok to locate the default database or Cancel to exit and repair the error later.") = ButtonClicked.Ok Then
                                    frmDatabaseMissing.Show()
                                Else
                                    Application.ExitThread()
                                End If
                            Else

                                Try
                                    If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.CombinePath(My.Computer.FileSystem.SpecialDirectories.ProgramFiles, "VirVil\ReportingServices\reports.mdf")) Then
                                        My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.CombinePath(My.Computer.FileSystem.SpecialDirectories.ProgramFiles, "VirVil\ReportingServices\reports.mdf"))
                                        If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.CombinePath(My.Computer.FileSystem.SpecialDirectories.ProgramFiles, "VirVil\ReportingServices\reports_log.ldf")) Then
                                            My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.CombinePath(My.Computer.FileSystem.SpecialDirectories.ProgramFiles, "VirVil\ReportingServices\reports_log.ldf"))
                                        End If
                                    End If

                                    My.Computer.FileSystem.CopyFile(DatabasePath, My.Computer.FileSystem.CombinePath(My.Computer.FileSystem.SpecialDirectories.ProgramFiles, "VirVil\ReportingServices\reports.mdf"), True)
                                    Using objConnection_Rep As SqlConnection = SetUpConnection(My.Computer.FileSystem.CombinePath(My.Computer.FileSystem.SpecialDirectories.ProgramFiles, "VirVil\ReportingServices\reports.mdf"), True)
                                        objConnection_Rep.Open()
                                        objConnection_Rep.Close()
                                    End Using

                                    My.Settings.DateOfReport = Date.Now
                                    My.Settings.HotelName = GetHotelName
                                    My.Settings.Save()

                                Catch ex As Exception
                                    'MsgBox(ex.Message)

                                    'Error when another application such as the Microsoft SQL server manager is using the database.
                                    'In this case the updated database is not copied to the specified location
                                    'and the old database is used in viewing the reports.
                                    'To have a solution, the user will have to ensure that no other application
                                    'is using the reports.mdf and he must restart the application (SLU-HFDS)
                                    'To update the reports' results.

                                End Try

                                frmLogin.Show()
                            End If
                            ''Try if there is no database in the control file, what will happen?
                        End If
                    End Using
                    objConnection.Close()
                End Using
            End If
        End If

    End Sub

    Private Sub frmSplash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'tmrStatus.Enabled = False
        'frmEncrypt.ShowDialog()

        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SluHotel", "ControlFile", Nothing) Is Nothing Or _
           My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SluHotel", "HelpFile", Nothing) Is Nothing Then
            tmrStatus.Enabled = False

            frmRegistrySetup.ShowDialog()

            My.Settings.blnFirstUse = True
            My.Settings.Save()

            tmrStatus.Enabled = True
        End If

        
        If My.Settings.blnFirstUse = True Then
            tmrStatus.Enabled = False

            Dim Cancelled As Boolean = False
            Do While Not IsLoadedAppCd()
                If MsgNoDatabase("Launching VirVil Solutions", "Please insert the VirVil Solutions CD. Necessary information must be copied.", "", Button.OkCancel) = ButtonClicked.Cancel Then
                    'My.Settings.blnFirstUse = True
                    'My.Settings.Save()
                    Cancelled = True
                    Exit Do
                End If
            Loop

            If Cancelled Then
                Application.ExitThread()
            End If

            ''Delete Previously installed application.
            'Try
            '    With My.Computer.FileSystem
            '        If .FileExists("C:\WINDOWS\VirVil\ControlFile\ControlFile.mdf") Then
            '            .DeleteFile("C:\WINDOWS\VirVil\ControlFile\ControlFile.mdf")
            '        End If

            '        If .FileExists(.CombinePath(.SpecialDirectories.ProgramFiles, "VirVil\Database\GonzagaChateau\GonzagaChateau.mdf")) Then
            '            .DeleteFile(.CombinePath(.SpecialDirectories.ProgramFiles, "VirVil\Database\GonzagaChateau\GonzagaChateau.mdf"))
            '        End If

            '        If .FileExists(.CombinePath(.SpecialDirectories.ProgramFiles, "VirVil\Database\InitialDB\InitialDb.mdf")) Then
            '            .DeleteFile(.CombinePath(.SpecialDirectories.ProgramFiles, "VirVil\Database\InitialDB\InitialDb.mdf"))
            '        End If

            '        If .FileExists(.CombinePath(.SpecialDirectories.ProgramFiles, "VirVil\HelpFile\HelpFile.mdf")) Then
            '            .DeleteFile(.CombinePath(.SpecialDirectories.ProgramFiles, "VirVil\HelpFile\HelpFile.mdf"))
            '        End If

            '        'If .DirectoryExists(.CombinePath(.SpecialDirectories.ProgramFiles, "VirVil\HelpFile\HelpPages")) Then
            '        '    .DeleteDirectory(.CombinePath(.SpecialDirectories.ProgramFiles, "VirVil\HelpFile\HelpPages"), FileIO.DeleteDirectoryOption.DeleteAllContents)
            '        'End If

            '        'If .DirectoryExists(.CombinePath(.SpecialDirectories.ProgramFiles, "VirVil\ReportingSevices\Reports")) Then
            '        '    .DeleteDirectory(.CombinePath(.SpecialDirectories.ProgramFiles, "VirVil\ReportingSevices\Reports"), FileIO.DeleteDirectoryOption.DeleteAllContents)
            '        'End If

            '        If .FileExists(.CombinePath(.SpecialDirectories.ProgramFiles, "VirVil\instguide.html")) Then
            '            .DeleteFile(.CombinePath(.SpecialDirectories.ProgramFiles, "VirVil\instguide.html"))
            '        End If

            '        If .FileExists(.CombinePath(.SpecialDirectories.ProgramFiles, "VirVil\readme.txt")) Then
            '            .DeleteFile(.CombinePath(.SpecialDirectories.ProgramFiles, "VirVil\readme.txt"))
            '        End If

            '        If .DirectoryExists("C:\Program Files\VirVil\PaySlips\GonzagaChateau") Then
            '            .DeleteDirectory("C:\Program Files\VirVil\PaySlips\GonzagaChateau", FileIO.DeleteDirectoryOption.DeleteAllContents)
            '        End If

            '    End With
            'Catch ex As Exception
            '    MessageBox.Show("Please restart the computer and open the application." & NWLN & ex.Message, "Restart Computer", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Application.ExitThread()
            'End Try

            Try
                With My.Computer.FileSystem
                    .CopyFile(.CombinePath(CdDirectory, "Database\ControlFile\ControlFile.mdf"), "C:\WINDOWS\VirVil\ControlFile\ControlFile.mdf")
                    Dim MyFileInfo As System.IO.FileInfo = New System.IO.FileInfo("C:\WINDOWS\VirVil\ControlFile\ControlFile.mdf")
                    MyFileInfo.Attributes = IO.FileAttributes.Normal

                    .CopyFile(.CombinePath(CdDirectory, "Database\DataFile\PopulatedDb.mdf"), .CombinePath(.SpecialDirectories.ProgramFiles, "VirVil\Database\GonzagaChateau\GonzagaChateau.mdf"))
                    MyFileInfo = New System.IO.FileInfo(.CombinePath(.SpecialDirectories.ProgramFiles, "VirVil\Database\GonzagaChateau\GonzagaChateau.mdf"))
                    MyFileInfo.Attributes = IO.FileAttributes.Normal

                    .CopyFile(.CombinePath(CdDirectory, "Database\DataFile\EmptyDB.mdf"), .CombinePath(.SpecialDirectories.ProgramFiles, "VirVil\Database\InitialDB\InitialDb.mdf"))
                    MyFileInfo = New System.IO.FileInfo(.CombinePath(.SpecialDirectories.ProgramFiles, "VirVil\Database\InitialDB\InitialDb.mdf"))
                    MyFileInfo.Attributes = IO.FileAttributes.Normal

                    .CopyFile(.CombinePath(CdDirectory, "Database\HelpFile\HelpFile.mdf"), .CombinePath(.SpecialDirectories.ProgramFiles, "VirVil\HelpFile\HelpFile.mdf"))
                    MyFileInfo = New System.IO.FileInfo(.CombinePath(.SpecialDirectories.ProgramFiles, "VirVil\HelpFile\HelpFile.mdf"))
                    MyFileInfo.Attributes = IO.FileAttributes.Normal

                    .CopyDirectory(.CombinePath(CdDirectory, "HelpPages"), .CombinePath(.SpecialDirectories.ProgramFiles, "VirVil\HelpFile\HelpPages"), True)
                    
                    .CopyDirectory(.CombinePath(CdDirectory, "ReportingService\Reports"), .CombinePath(.SpecialDirectories.ProgramFiles, "VirVil\ReportingServices\Reports"), True)
                 
                    .CopyFile(.CombinePath(CdDirectory, "instguide.html"), .CombinePath(.SpecialDirectories.ProgramFiles, "VirVil\instguide.html"))
                    MyFileInfo = New System.IO.FileInfo(.CombinePath(.SpecialDirectories.ProgramFiles, "VirVil\instguide.html"))
                    MyFileInfo.Attributes = IO.FileAttributes.Normal

                    .CopyFile(.CombinePath(CdDirectory, "readme.txt"), .CombinePath(.SpecialDirectories.ProgramFiles, "VirVil\readme.txt"))
                    MyFileInfo = New System.IO.FileInfo(.CombinePath(.SpecialDirectories.ProgramFiles, "VirVil\readme.txt"))
                    MyFileInfo.Attributes = IO.FileAttributes.Normal

                    .CreateDirectory("C:\Program Files\VirVil\PaySlips\GonzagaChateau")
                End With

                My.Settings.blnFirstUse = False
                My.Settings.Save()

            Catch ex As Exception
                'My.Settings.blnFirstUse = True
                'My.Settings.Save()
                MsgNoDatabase("Launching VirVil Solutions", _
                                "Cannot overwrite previous installation components and files.", _
                                "When reinstalling the application, secure a backup copy of your previous files located at C:/Program Files/VirVil/ and C:/Windows/VirVil/ to a different location." & NWLN & _
                                "After creating a backup, delete the original files including all folders and directories associated to VirVil Solutions." & NWLN & _
                                "If you encounter any problem during deleting, try to restart your computer and repeat the procedure.", Button.Ok)

            End Try
            tmrStatus.Enabled = True
        End If

        If Not My.Settings.blnFirstUse AndAlso My.Computer.Screen.Bounds.Width <> 1024 Or My.Computer.Screen.Bounds.Height <> 768 Then
            'tmrStatus.Enabled = False
            MsgNoDatabase("Screen Resolution", "The screen resolution must be set to 1024x768 for proper display.", "", Button.Ok)
            'Application.ExitThread()
        End If

    End Sub

#End Region

End Class

