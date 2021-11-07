Public Class busAvailability
    Private Sub BusAndPassengersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.BusAndPassengersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RegisterStaffDataSet)

    End Sub

    Private Sub busAvailability_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'RegisterStaffDataSet.BusAndPassengers' table. You can move, or remove it, as needed.
        Me.BusAndPassengersTableAdapter.Fill(Me.RegisterStaffDataSet.BusAndPassengers)

    End Sub

    Private Sub PreviousButton_Click(sender As Object, e As EventArgs) Handles PreviousButton.Click
        BusAndPassengersBindingSource.MovePrevious()
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        BusAndPassengersBindingSource.MoveNext()
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        BusAndPassengersBindingSource.RemoveCurrent()
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        On Error GoTo SaveErr

        BusAndPassengersBindingSource.EndEdit()

        BusAndPassengersTableAdapter.Update(RegisterStaffDataSet.BusAndPassengers)

        MessageBox.Show(”OK”)
SaveErr:
        Exit Sub
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub BusAndPassengersBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles BusAndPassengersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BusAndPassengersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RegisterStaffDataSet)

    End Sub
End Class