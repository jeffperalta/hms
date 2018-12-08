Option Explicit On
Option Strict On

''' <summary>
''' A form to test encyption
''' Used to change the usual text to encypted text
''' </summary>
''' <remarks></remarks>

Public Class frmEncrypt

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox2.Text = Encrypt(TextBox1.Text)
    End Sub

End Class