Public Class frmMessage

    Private Sub Button0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button0.Click
        If Button0.Text = "Show &Details" Then
            Me.Height = 420
            Button0.Text = "Hide &Details"
        ElseIf Button0.Text = "Hide &Details" Then
            Me.Height = 210
            Button0.Text = "Show &Details"
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DetermineWhatWasClicked(Button1.Text)
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DetermineWhatWasClicked(Button2.Text)
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        DetermineWhatWasClicked(Button3.Text)
        Me.Close()
    End Sub

    Private Sub DetermineWhatWasClicked(ByVal MyText As String)
        Select Case MyText.ToLower
            Case "ok"
                ButtonResult = ButtonClicked.Ok
            Case "yes"
                ButtonResult = ButtonClicked.Yes
            Case "no"
                ButtonResult = ButtonClicked.No
            Case "cancel"
                ButtonResult = ButtonClicked.Cancel
        End Select
    End Sub

End Class