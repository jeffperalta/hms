Option Explicit On
Option Strict On

' Programmer:   Jo Jefferson D. Peralta
' Date:         April 11, 2007
' Title:        frmNewDatabase
' Purpose:      This interface creates a new blank database. The application cd must be present because
'               The files are copied to the location specified by the user.
' Requirements: ->  If the default empty database is present the user is prompted to insert the 
'                   application CD to recopy the initial DB to its default location. And creates a new database.
'               ->  The correct application CD must be present. The database name must be a valid MDF file.
'               ->  Since the database is copied from the CD the application must change the file
'                   property from read-only to normal.
'               ->  If there is a database having the same file path the user is prompted to change the name
'                   or the disk location bacause the previous database file must not be overwritten.
'               ->  Once a new database is saved, the database information (including the hotel name) 
'                   must be specified at the control file.
' Results:      ->  A new database is saved at the specified location. However the user must manually saved
'                   the information to the control file.

Public Class frmNewDatabase

#Region "Function/Subroutines"

    Public ReadOnly Property Result() As String
        Get
            Try
                Return My.Computer.FileSystem.CombinePath(Trim(txtDatabaseLocation.Text), Trim(txtDatabaseName.Text) & ".mdf")
            Catch ex As Exception
                Return String.Empty
            End Try
        End Get
    End Property

    Public ReadOnly Property DatabaseName() As String
        Get
            Return txtDatabaseName.Text
        End Get
    End Property

    Private Function ThereAreInputErrors() As Boolean

        If Trim(txtDatabaseLocation.Text) = String.Empty Then
            Msg("1000")
            txtDatabaseLocation.Focus()
            txtDatabaseLocation.SelectAll()
            Return True
            Exit Function
        End If

        If Trim(txtDatabaseName.Text) = String.Empty Then
            Msg("1000")
            txtDatabaseName.Focus()
            txtDatabaseName.SelectAll()
            Return True
            Exit Function
        End If

        If Trim(txtDatabaseName.Text).Contains("/") Or Trim(txtDatabaseName.Text).Contains("\") Or Trim(txtDatabaseName.Text).ToUpper.Contains(".MDF") Then
            Msg("1001", , "This is not a valid databasename. It must not contain '/' or '\'.")
            txtDatabaseName.Focus()
            txtDatabaseName.SelectAll()
            Return True
            Exit Function
        End If

        With My.Computer.FileSystem
            If .FileExists(.CombinePath(Trim(txtDatabaseLocation.Text), Trim(txtDatabaseName.Text) & ".mdf")) Then
                Msg("1072")
                txtDatabaseName.Focus()
                txtDatabaseName.SelectAll()
                Return True
                Exit Function
            End If
        End With

        Return False

    End Function

#End Region

#Region "Command Button"

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If ThereAreInputErrors() Then Exit Sub

        Try

            With My.Computer.FileSystem
                If My.Computer.FileSystem.FileExists(.CombinePath(.SpecialDirectories.ProgramFiles, "VirVil\Database\InitialDB\InitialDb.mdf")) Then

                    .CopyFile(.CombinePath(.SpecialDirectories.ProgramFiles, "VirVil\Database\InitialDB\InitialDb.mdf"), _
                              .CombinePath(Trim(txtDatabaseLocation.Text), Trim(txtDatabaseName.Text) & ".mdf"))
                    Me.Close()

                Else

                    If Not IsLoadedAppCd() Then
                        Msg("1073")
                        Exit Sub
                    Else
                        .CopyFile(.CombinePath(CdDirectory, "Database\DataFile\EmptyDB.mdf"), .CombinePath(.SpecialDirectories.ProgramFiles, "VirVil\Database\InitialDB\InitialDb.mdf"))
                        Dim MyFileInfo_2 As System.IO.FileInfo = New System.IO.FileInfo(.CombinePath(.SpecialDirectories.ProgramFiles, "VirVil\Database\InitialDB\InitialDb.mdf"))
                        MyFileInfo_2.Attributes = IO.FileAttributes.Normal
                    End If

                    .CopyFile(.CombinePath(CdDirectory, LocationOfBlankDatabase), _
                              .CombinePath(Trim(txtDatabaseLocation.Text), Trim(txtDatabaseName.Text) & ".mdf"))
                    Dim MyFileInfo As System.IO.FileInfo = New System.IO.FileInfo(.CombinePath(Trim(txtDatabaseLocation.Text), Trim(txtDatabaseName.Text) & ".mdf"))
                    MyFileInfo.Attributes = IO.FileAttributes.Normal
                    Me.Close()

                End If
            End With

        Catch ex As Exception
            Msg("1008", , NWLN & ex.Message)
        End Try


    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        With FolderBrowserDialog1
            .Description = "Select Location of Database:"
            .ShowNewFolderButton = True

            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                txtDatabaseLocation.Text = .SelectedPath
            End If
        End With

    End Sub

#End Region

End Class