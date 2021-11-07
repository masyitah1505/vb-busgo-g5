Public Class designDashboard
    Private Sub ViewBusAvailabilityButton_Click(sender As Object, e As EventArgs) Handles ViewBusAvailabilityButton.Click
        Me.Hide()
        busAvailability.ShowDialog()
    End Sub

    Private Sub ViewSeatPositionButton_Click(sender As Object, e As EventArgs) Handles ViewSeatPositionButton.Click
        Me.Hide()
        busLegend.ShowDialog()
    End Sub

    Private Sub BookBusButton_Click(sender As Object, e As EventArgs) Handles BookBusButton.Click
        Me.Hide()
        bookBus.ShowDialog()
    End Sub

    Private Sub LogOutButton_Click(sender As Object, e As EventArgs) Handles LogOutButton.Click
        Me.Hide()
        adminHomepage.Show()
    End Sub
End Class