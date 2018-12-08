Option Explicit On
Option Strict On

Public Class frmMyNotes

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If Button2.Text = "Shortcut Keys" Then
            ListBox1.Visible = True
            TextBox1.Visible = False
            Button2.Text = "Hide"
        Else
            ListBox1.Visible = False
            TextBox1.Visible = True
            Button2.Text = "Shortcut Keys"
        End If

    End Sub

    Private Sub frmMyNotes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.MyNotes
        ListBox1.Visible = False
        TextBox1.Visible = True
        Button2.Text = "Shortcut Keys"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub frmMyNotes_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        My.Settings.MyNotes = TextBox1.Text
        My.Settings.Save()
    End Sub

End Class