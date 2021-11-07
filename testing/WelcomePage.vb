Public Class WelcomePage
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 1
        If ProgressBar1.Value <= 10 Then
            MessageLabel.Text = "Initilizing System"
        ElseIf ProgressBar1.Value <= 30 Then
            MessageLabel.Text = "Loading all Components"
        ElseIf ProgressBar1.Value <= 50 Then
            MessageLabel.Text = "Integrating Database"
        ElseIf ProgressBar1.Value <= 70 Then
            MessageLabel.Text = "Please Wait"
        ElseIf ProgressBar1.Value <= 100 Then
            MessageLabel.Text = "Welcome to BusGo System"

            If ProgressBar1.Value = 100 Then
                Timer1.Dispose()
                Me.Hide()
                adminHomepage.ShowDialog()
                Me.Close()
            End If

        End If
    End Sub
End Class