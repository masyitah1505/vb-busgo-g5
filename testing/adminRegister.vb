Imports System.Data.OleDb
Public Class adminRegister
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source = " & Application.StartupPath & "\RegisterStaff.accdb")
    Private Sub adminRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click
        If UsernameTextBox.Text = Nothing Or PasswordTextBox.Text = Nothing Or FullNameTextBox.Text = Nothing Or
            StaffNoTextBox.Text = Nothing Or EmailTextBox.Text = Nothing Or PhoneNoTextBox.Text = Nothing Then
            MessageBox.Show("Please Fill Up all the Fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        Using cmd As New OleDbCommand("SELECT COUNT (*) FROM RegisterStaff WHERE [Username] = @Username OR [Password] = @Password OR 
                                        [FullName] = @FullName OR [StaffNo] = @StaffNo OR [Email] = @Email OR [PhoneNo] = @PhoneNo", conn)
            cmd.Parameters.AddWithValue("@Username", OleDbType.VarChar).Value = UsernameTextBox.Text
            cmd.Parameters.AddWithValue("@Password", OleDbType.VarChar).Value = PasswordTextBox.Text
            cmd.Parameters.AddWithValue("@FullName", OleDbType.VarChar).Value = FullNameTextBox.Text
            cmd.Parameters.AddWithValue("@StaffNo", OleDbType.VarNumeric).Value = StaffNoTextBox.Text
            cmd.Parameters.AddWithValue("@Email", OleDbType.VarChar).Value = EmailTextBox.Text
            cmd.Parameters.AddWithValue("@PhoneNo", OleDbType.VarNumeric).Value = PhoneNoTextBox.Text

        End Using

        Using create As New OleDbCommand("INSERT INTO RegisterStaff([Username],[Password],[FullName],[StaffNo],[Email],[PhoneNo])
                                            VALUES(@Username,@Password,@FullName,@StaffNo,@Email,@PhoneNo)", conn)
            create.Parameters.AddWithValue("@Username", OleDbType.VarChar).Value = UsernameTextBox.Text
            create.Parameters.AddWithValue("@Password", OleDbType.VarChar).Value = PasswordTextBox.Text
            create.Parameters.AddWithValue("@FullName", OleDbType.VarChar).Value = FullNameTextBox.Text
            create.Parameters.AddWithValue("@StaffNo", OleDbType.VarNumeric).Value = StaffNoTextBox.Text
            create.Parameters.AddWithValue("@Email", OleDbType.VarChar).Value = EmailTextBox.Text
            create.Parameters.AddWithValue("@PhoneNo", OleDbType.VarNumeric).Value = PhoneNoTextBox.Text

            If create.ExecuteNonQuery Then
                MessageBox.Show("New Admin Registered!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                UsernameTextBox.Clear()
                PasswordTextBox.Clear()
                FullNameTextBox.Clear()
                StaffNoTextBox.Clear()
                EmailTextBox.Clear()
                PhoneNoTextBox.Clear()
            End If

        End Using
        conn.Close()
        Me.Close()
        designDashboard.Show()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Me.Hide()
        adminHomepage.Show()
    End Sub
End Class