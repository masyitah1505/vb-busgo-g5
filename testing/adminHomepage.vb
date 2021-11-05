Imports System.Data.OleDb
Imports System.IO
Public Class adminHomepage
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source = " & Application.StartupPath & "\RegisterStaff.accdb")

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        If UsernameTextBox.Text = Nothing Or PasswordTextBox.Text = Nothing Then
            MessageBox.Show("Please Fill Up all the Fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Using LOGIN As New OleDbCommand("SELECT COUNT (*) FROM RegisterStaff WHERE [Username] = @Username AND [Password] = @Password", conn)
            LOGIN.Parameters.AddWithValue("@Username", OleDbType.VarChar).Value = UsernameTextBox.Text
            LOGIN.Parameters.AddWithValue("@Password", OleDbType.VarChar).Value = PasswordTextBox.Text

            Dim logincount = Convert.ToInt32(LOGIN.ExecuteScalar())
            If logincount > 0 Then
                Me.Hide()
                bookBus.Show()
            Else
                MessageBox.Show("Invalid Credentials!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                UsernameTextBox.Clear()
                PasswordTextBox.Clear()
            End If
        End Using
        conn.Close()
    End Sub

    Private Sub RegisterLabel_Click(sender As Object, e As EventArgs) Handles RegisterLabel.Click
        adminRegister.Show()
    End Sub
End Class
