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
        Me.Close()
<<<<<<< Updated upstream

=======
<<<<<<< HEAD
=======

>>>>>>> 43563f2424bf5eec6a6d590e8b045734b0777887
>>>>>>> Stashed changes
    End Sub
End Class