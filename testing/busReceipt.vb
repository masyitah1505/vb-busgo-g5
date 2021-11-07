Imports System.Data.OleDb
Imports System.IO

Public Class busReceipt
    Private Sub busReceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        Me.Hide()
        designDashboard.Show()
    End Sub


End Class