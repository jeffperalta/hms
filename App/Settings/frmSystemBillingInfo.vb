Option Explicit On
Option Strict On

Imports System.Data.SqlClient
Imports System.Data

' Programmer:   Jo Jefferson D. Peralta
' Date:         February 26, 2007
' Title:        frmSystemBillingInfo
' Purpose:      This interface is used to set the billing information used to determine
'               default values for refund percentage, expiration dates, and downpayments.
' Requirements: ->  (+/*)SYSTEM(SysID, ResGracePeriod, ResDownPaymentPercentage, RefPercentage, RefGracePeriod, TotalCashInFD)
'               ->  Required Fields at ResGracePeriod, ResDownPaymentPercentage, RefPercentage, RefGracePeriod
'               ->  If required fields are missing it is automatically set to zero (0)
'               ->  ResGracePeriod and RefGracePeriod is a positive number
'               ->  ResDownPaymentPercentage AND RefPercentage >=0 and <=100
'               ->  Set the refund percentage, downpayment percentage during reservation,
'                   days before a refund status is marked as expired, and the number of days
'                   a reservation is said to be valid.
'               ->  The values entered should be validated and appropriate message is shown
'               ->  The manager can initialize the amount at the front-desk
' Results:      ->  If the SYSTEM table has no rows on it a new record is added,
'                   However, if there is the record is altered with the new values.
'               ->  Billing information: Refund Percentage, Expiration Date For refunds,
'                   Reservation Downpayments, and Valid days for a reservation
'                   are set with valid values.
'MessageBox

Class frmSystemBillingInfo

    Private gState As State = State.waiting

#Region "FUNCTIONS/SUBROUTINES"

    Private Sub RefreshView()
        Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
            objConnection.Open()

            Using objCommand As SqlCommand = New SqlCommand("SELECT ISNULL(SYSTEM.ResGracePeriod,0), ISNULL(SYSTEM.ResDownPaymentPercentage, 0), ISNULL(SYSTEM.RefPercentage,0) , ISNULL(SYSTEM.RefGracePeriod, 0), ISNULL(TotalCashInFD, 0) FROM SYSTEM", objConnection)
                Using objReader As SqlDataReader = objCommand.ExecuteReader
                    objReader.Read()
                    Try
                        txtResVDR.Text = objReader(0).ToString()
                        txtResVD.Text = objReader(0).ToString()
                        txtResDR.Text = objReader(1).ToString()
                        txtResD.Text = objReader(1).ToString()
                        txtRefDR.Text = objReader(2).ToString()
                        txtRefD.Text = objReader(2).ToString()
                        txtRefVDR.Text = objReader(3).ToString()
                        txtRefVD.Text = objReader(3).ToString()
                        txtAmountInFrontDesk.Text = Format(objReader(4), "n")

                    Catch ex As Exception
                        'Error when null
                    End Try
                    objReader.Close()

                    chkPromptForRefund.Checked = My.Settings.PromtChangeToRefund
                End Using
            End Using

            objConnection.Close()
        End Using
    End Sub

    Private Function ThereAreInputErrors() As Boolean
        'Check for any input errors
        If Trim(txtResVD.Text) = String.Empty Then txtResVD.Text = "0"

        If Trim(txtResD.Text) = String.Empty Then txtResD.Text = "0"

        If Trim(txtRefD.Text) = String.Empty Then txtRefD.Text = "0"

        If Trim(txtRefVD.Text) = String.Empty Then txtRefVD.Text = "0"


        'check for valid days 
        Try
            Dim intTemp As Integer
            intTemp = CType(txtResVD.Text, Integer)

        Catch ex As Exception
            Msg("1001", , "The value for this field must be a positive whole number")
            txtResVD.SelectAll()
            txtResVD.Focus()
            Return True
            Exit Function
        End Try

        Try
            Dim intTemp As Integer
            intTemp = CType(txtRefVD.Text, Integer)
        Catch ex As Exception
            Msg("1001", , "The value for this field must be a positive whole number")
            txtRefVD.SelectAll()
            txtRefVD.Focus()
            Return True
            Exit Function
        End Try

        If Not IsNumeric(txtAmountInFrontDesk.Text) Then
            Msg("1001", Button.Ok, "Input must be numeric.")
            txtAmountInFrontDesk.SelectAll()
            txtAmountInFrontDesk.Focus()
            Return True
            Exit Function
        Else
            If CType(txtAmountInFrontDesk.Text, Double) < 0 Then
                Msg("1001", , "The value for this field must be a positive whole number")
                txtAmountInFrontDesk.SelectAll()
                txtAmountInFrontDesk.Focus()
                Return True
                Exit Function
            End If
        End If

        Return False

    End Function

#End Region

#Region "STATUS CHANGER"

    Private Sub txtResD_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtResD.TextChanged
        Try
            If CType(txtResD.Text, Double) <> CType(txtResDR.Text, Double) Then
                gState = State.updating
            Else
                gState = State.waiting
            End If
        Catch ex As Exception
        End Try
        frmParent.tssStatus.Text = "Ready..."
    End Sub

    Private Sub txtResVD_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtResVD.TextChanged
        Try
            If CType(txtResVD.Text, Double) <> CType(txtResVDR.Text, Double) Then
                gState = State.updating
            Else
                gState = State.waiting
            End If
        Catch ex As Exception
        End Try
        frmParent.tssStatus.Text = "Ready..."
    End Sub

    Private Sub txtRefD_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRefD.TextChanged
        Try
            If CType(txtRefD.Text, Double) <> CType(txtRefDR.Text, Double) Then
                gState = State.updating
            Else
                gState = State.waiting
            End If
        Catch ex As Exception
        End Try
        frmParent.tssStatus.Text = "Ready..."
    End Sub

    Private Sub txtRefVD_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRefVD.TextChanged
        Try
            If CType(txtRefVD.Text, Double) <> CType(txtRefVDR.Text, Double) Then
                gState = State.updating
            Else
                gState = State.waiting
            End If
        Catch ex As Exception
        End Try
        frmParent.tssStatus.Text = "Ready..."
    End Sub

#End Region

#Region "MISC"

    Private Sub frmSystemBillingInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Check if there is a record at the SYSTEM table
        If Not IsExisting("SELECT * FROM SYSTEM") Then
            Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
                objConnection.Open()
                Using objTransaction As SqlTransaction = objConnection.BeginTransaction
                    Using objCommand As SqlCommand = objConnection.CreateCommand
                        With objCommand
                            .Transaction = objTransaction
                            .CommandText = "INSERT INTO SYSTEM VALUES (1000, 0,0,0,0,0)"
                            Try
                                .ExecuteNonQuery()
                                objTransaction.Commit()

                            Catch ex As Exception
                                objTransaction.Rollback()
                            End Try
                        End With
                    End Using
                End Using
                objConnection.Close()
            End Using
        End If

        txtReceipt.Text = My.Settings.ReceiptLocation

        RefreshView()

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If ThereAreInputErrors() = True Then Exit Sub

        Using objConnection As SqlConnection = SetUpConnection(DatabasePath, True)
            If objConnection.State = ConnectionState.Closed Then objConnection.Open()
            Using objTransaction As SqlTransaction = objConnection.BeginTransaction
                Using objCommand As SqlCommand = objConnection.CreateCommand
                    objCommand.Transaction = objTransaction
                    objCommand.CommandText = "UPDATE SYSTEM SET ResGracePeriod=@ResGracePeriod, ResDownPaymentPercentage = @ResDownPaymentPercentage, " & _
                                             "RefPercentage=@RefPercentage, RefGracePeriod = @RefGracePeriod, TotalCashInFD= @TotalCashInFD; "

                    Try
                        With objCommand.Parameters
                            .AddWithValue("@ResGracePeriod", txtResVD.Text).SqlDbType = SqlDbType.Int
                            .AddWithValue("@ResDownPaymentPercentage", txtResD.Text).SqlDbType = SqlDbType.Decimal
                            .AddWithValue("@RefPercentage", txtRefD.Text).SqlDbType = SqlDbType.Decimal
                            .AddWithValue("@RefGracePeriod", txtRefVD.Text).SqlDbType = SqlDbType.Int
                            .AddWithValue("@TotalCashInFD", txtAmountInFrontDesk.Text).SqlDbType = SqlDbType.Money
                        End With

                        objCommand.ExecuteNonQuery()
                        objTransaction.Commit()
                        Msg("1032")
                        gState = State.waiting

                        frmParent.tssStatus.Text = "Billing information altered..."

                    Catch ex As SqlException

                        objTransaction.Rollback()

                        If ex.Number = 547 Then 'Constraint Error 
                            Msg("1002", Button.Ok, "Values less than zero (0) are not allowed." & NWLN & "---" & NWLN & ex.Message)
                        Else
                            Msg("1008", Button.Ok, ex.Number & NWLN & ex.Message)
                        End If

                        frmParent.tssStatus.Text = "Billing information was not saved..."

                    Catch ex As Exception

                        objTransaction.Rollback()
                        Msg("1008", Button.Ok, ex.Message) 'overflow
                        frmParent.tssStatus.Text = "Billing information was not saved..."

                    End Try
                End Using
            End Using
            If objConnection.State = ConnectionState.Open Then objConnection.Close()
        End Using

        My.Settings.PromtChangeToRefund = chkPromptForRefund.Checked
        My.Settings.Save()

        RefreshView()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        If gState <> State.waiting Then
            Select Case Msg("1033", Button.YesNoCancel)
                Case ButtonClicked.Yes
                    If ThereAreInputErrors() Then
                        Exit Sub
                    End If

                    btnSave_Click(Nothing, Nothing)
                    Me.Close()

                Case ButtonClicked.No
                    Me.Close()
                Case ButtonClicked.Cancel
                    Exit Sub
            End Select
        Else
            Me.Close()
        End If
    End Sub

    Private Sub btnReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReceipt.Click
        FolderBrowserDialog1.Description = "Select a folder where receipts will be saved:"
        FolderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer
        FolderBrowserDialog1.ShowNewFolderButton = True

        If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtReceipt.Text = FolderBrowserDialog1.SelectedPath
            My.Settings.ReceiptLocation = txtReceipt.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
    End Sub

#End Region

#Region "Side Bar"

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Display(Forms.frmSettings)
    End Sub

#End Region

End Class