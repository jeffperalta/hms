Option Explicit On
Option Strict On

Imports System.Data
Imports System.Data.SqlClient

' Programmer:   Jo Jefferson D. Peralta
' Date:         March 07, 2007
' Title:        frmControlFileMissing
' Purpose:      When the control file was moved, deleted, renamed outside the application
'               This interface is triggered. The user will have to locate the control file 
'               and test it whether it is th correct database
' Requirements: ->  (*) REGISTRY (HKEY_CURRENT_USER\SluHotel)
'               ->  Test the path if its existing and the *.mdf if it is a control file
' Results:      ->  The registry is edited and the location of the control file is saved

Public Class frmControlFileMissing

#Region "Functions/Subroutines"

    Private Function DatabaseIsCorrect() As Boolean

        Using objConnection As SqlConnection = SetUpConnection(txtPath.Text, True)
            Try
                objConnection.Open()
            Catch ex As SqlException
                MsgBox("A connection timeout occured. Please start the SQL server...")
                Exit Function
            End Try

            Using objCommand As SqlCommand = New SqlCommand("SELECT MessageNo, Message, Caption, Type, Remarks FROM MESSAGES; ", objConnection)
                Try
                    objCommand.ExecuteNonQuery()

                    objCommand.CommandText = "SELECT DatabaseNo, DatabasePath, HotelName, LastUsed, BackgroundImage FROM DATABASEFILE; "
                    objCommand.ExecuteNonQuery()

                    objCommand.CommandText = "SELECT ID, UserName, UserPassword, UserType FROM USERAUTHENTICATION; "
                    objCommand.ExecuteNonQuery()

                    Return True
                Catch ex As SqlException
                    Return False
                End Try
            End Using
            objConnection.Close()
        End Using

    End Function

#End Region

#Region "Command Button"

    Private Sub btnLocate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLocate.Click
        txtPath.Text = ShowOpenFileDialog()
    End Sub

    Private Sub btnRestart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestart.Click

        If My.Computer.FileSystem.FileExists(txtPath.Text) = False Then
            MsgNoDatabase("File Error", "This file path does not exist. ", "File does not exists", Button.Ok)
            txtPath.SelectAll()
            Exit Sub
        Else
            If DatabaseIsCorrect() Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SluHotel", "ControlFile", txtPath.Text)
                Application.Restart()
            End If
        End If

    End Sub

    Private Sub btnTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTest.Click
        If My.Computer.FileSystem.FileExists(txtPath.Text) = False Then
            MsgNoDatabase("File Error", "This file path does not exist. ", "File does not exists", Button.Ok)
            txtPath.SelectAll()
            Exit Sub
        Else
            If DatabaseIsCorrect() Then
                MsgNoDatabase("Test Successful.", "This database is a control file.", "Save and restart the application to apply the new changes.", Button.Ok, False)
            Else
                MsgNoDatabase("Test Failed.", "This is not a control file.", "The database might be a datafile or a helpfile.", Button.Ok, False)
            End If
        End If
    End Sub

#End Region

#Region "MISC"

    Private Sub txtPath_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPath.KeyDown
        If Trim(txtPath.Text) = String.Empty Then
            txtPath.Text = ShowOpenFileDialog()
        End If
    End Sub

#End Region

End Class