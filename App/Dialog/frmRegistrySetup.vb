Option Explicit On
Option Strict On

' Programmer:   Jo Jefferson D. Peralta
' Date:         February 15, 2007
' Title:        frmRegistrySetup
' Purpose:      When the application is runned for the first time this form is used to setup the system
'               Registry. The location of the control file is located at the system registry. It also saves the
'               information where the database for the helpfile is located.
' Requirements: ->  The changes are saved at the system registry.
'               ->  Location of the control file as well as the location of the helpfile database is saved.
'               ->  This interface is usually seen during the first run of the application.
'                   or unless the SluHotel Key at the registry was removed or deleted.
' Results:      ->  The registry is properly setup.

Public Class frmRegistrySetup

#Region "MISC"

    Private Sub FormLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SluHotel", "ControlFile", "C:\WINDOWS\VirVil\ControlFile\ControlFile.mdf") Is Nothing Or _
            My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SluHotel", "HelpFile", "C:\WINDOWS\CFHotel\HF\HelpFile.mdf") Is Nothing Then

            With My.Computer.Registry
                .CurrentUser.CreateSubKey("SluHotel")
                .SetValue("HKEY_CURRENT_USER\SluHotel", "ControlFile", "C:\WINDOWS\VirVil\ControlFile\ControlFile.mdf")
                .SetValue("HKEY_CURRENT_USER\SluHotel", "HelpFile", "C:\Program Files\VirVil\HelpFile\HelpFile.mdf")
            End With
        Else
            Label1.Text = "Registry is already set..."
            ProgressBar1.Value = 100
        End If

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Select Case ProgressBar1.Value
            Case 0
                ProgressBar1.Value += 20
            Case 20
                Label1.Text = "Checking registry for previous installation..."
                ProgressBar1.Value += 20
            Case 40
                Label1.Text = "Setting up control file..."
                ProgressBar1.Value += 20
            Case 60
                Label1.Text = "Setting up Help File..."
                ProgressBar1.Value += 20
            Case 80
                Label1.Text = "Copying Files..."
                ProgressBar1.Value += 20
            Case 100
                Label1.Text = "Registry was successfully modified..."
                Me.Close()
        End Select

    End Sub

#End Region

End Class
