Option Explicit On
Option Strict On

Imports System.IO
Imports System.Drawing.Printing


' Programmer:   Jo Jefferson Peralta
' Date:         April 2007
' Title:        frmPrint
' Purpose:      This interface is used to print text files. This is used in printing payment 
'               slips and some quey slips.
' Requirements: To print a document this interface will save a text file and later prints it.
' Results:      ->  A document is printed

Public Class frmPrint

    Private strFilePath As String = String.Empty
    Private objStreamToPrint As StreamReader
    Private objPrintFont As Font
    Private strPrintingName As String
    Private blnPrintAll As Boolean = True

#Region "Functions/SubRoutines"

    Public Sub FillMe(ByVal FilePath As String, Optional ByVal PrintingName As String = "Printing...")
        strFilePath = FilePath
        strPrintingName = PrintingName
        Try
            txtFile.Text = My.Computer.FileSystem.ReadAllText(strFilePath)
            blnPrintAll = False
        Catch ex As Exception
            Msg("1074")
        End Try
    End Sub

    Private Sub objPrintDocument_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)

        Dim sngLinesPerPage As Single = 0
        Dim sngVerticalPosition As Single = 0
        Dim intLineCount As Integer = 0
        Dim sngLeftMargin As Single = e.MarginBounds.Left
        Dim sngTopMargin As Single = e.MarginBounds.Top
        Dim strLine As String

        sngLinesPerPage = e.MarginBounds.Height / objPrintFont.GetHeight(e.Graphics)
        strLine = objStreamToPrint.ReadLine

        While intLineCount < sngLinesPerPage And Not (strLine Is Nothing)
            sngVerticalPosition = sngTopMargin + (intLineCount * objPrintFont.GetHeight(e.Graphics))
            e.Graphics.DrawString(strLine, objPrintFont, Brushes.Black, sngLeftMargin, sngVerticalPosition, New StringFormat())
            intLineCount += 1

            If (intLineCount < sngLinesPerPage) Then
                strLine = objStreamToPrint.ReadLine
            End If

        End While

        If strLine <> Nothing Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
            blnPrintAll = True
        End If

    End Sub

#End Region

#Region "Command Buttons"

    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click

        With OpenFileDialog1
            .Filter = "TEXT FILES (*.txt)|*.txt"
            .Title = "Open Text File"
            .InitialDirectory = My.Settings.ReceiptLocation

            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                FillMe(.FileName)
            End If
        End With

    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim objPrintDocument As PrintDocument = New PrintDocument

        objPrintDocument.DocumentName = strPrintingName

        With PrintDialog1
            .AllowPrintToFile = False
            .AllowSelection = False
            .AllowSomePages = False

            .Document = objPrintDocument

            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                objStreamToPrint = New StreamReader(strFilePath)

                objPrintFont = New Font("Lucida Console", 10)

                AddHandler objPrintDocument.PrintPage, AddressOf objPrintDocument_PrintPage

                objPrintDocument.PrinterSettings = .PrinterSettings

                objPrintDocument.Print()
                objStreamToPrint.Close()

                objStreamToPrint = Nothing
            End If

        End With
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

#End Region

#Region "MISC"

    Private Sub frmPrint_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Not blnPrintAll Then
            Select Case Msg("1075", Button.YesNoCancel)
                Case ButtonClicked.Yes
                    e.Cancel = True
                    btnPrint_Click(Nothing, Nothing)
                Case ButtonClicked.No
                    e.Cancel = False
                Case ButtonClicked.Cancel
                    e.Cancel = True
            End Select
        End If
    End Sub

#End Region

End Class