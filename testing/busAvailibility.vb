Imports System.Drawing.Printing

Public Class busAvailibility
    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        Me.Hide()
        adminHomepage.Show()
    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings

        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
            Dim pagesetup As New PageSettings
            With pagesetup
                .Margins.Right = 50
                .Margins.Left = 50
                .Margins.Top = 50
                .Margins.Bottom = 50
            End With

            PrintDocument1.DefaultPageSettings = pagesetup
        End If

        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage


    End Sub
End Class