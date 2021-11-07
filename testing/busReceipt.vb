Imports System.Data.OleDb
Imports System.IO

Public Class busReceipt
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source = " & Application.StartupPath & "\RegisterStaff.accdb")
    Private Sub busReceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        Me.Hide()
        designDashboard.Show()

    End Sub

    Private Sub backHomepageButton_Click(sender As Object, e As EventArgs) Handles backHomepageButton.Click
        Me.Hide()
        designDashboard.Show()
    End Sub

    Private Sub printButton_Click(sender As Object, e As EventArgs) Handles printButton.Click
        Me.PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        Me.PrintForm1.Print()
    End Sub

End Class