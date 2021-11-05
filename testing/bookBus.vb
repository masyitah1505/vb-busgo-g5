Imports System.Data.OleDb
Public Class bookBus
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source = " & Application.StartupPath & "\RegisterStaff.accdb")
    Private Sub BookButton_Click(sender As Object, e As EventArgs) Handles BookButton.Click
        'bus details
        Dim busname,
        currentplace,
        seat,
        departuretime,
        destination As String
        Dim selectedSeat As RadioButton

        busname = BusNameComboBox.Text
        currentplace = CurrentPlaceComboBox.Text
        destination = DestinationComboBox.Text
        seat = SeatComboBox.Text
        departuretime = DepartureTimeComboBox.Text

        selectedSeat = CType(sender, RadioButton)
        Select Case selectedSeat.Text
            Case "Left"

            Case "Right"

        End Select

        'passengers details
        Dim fullname,
            phonenumber,
            email As String

        fullname = FullnameTextBox.Text
        phonenumber = PhoneNumTextBox.Text
        email = EmailTextBox.Text


        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        'database
        Using cmd As New OleDbCommand("SELECT COUNT (*) FROM BusAndPassengers WHERE [BusName] = @BusName OR [CurrentPlace] = @CurrentPlace OR 
                                        [Destination] = @Destination OR [DepartureTime] = @DepartureTime OR [Seat] = @Seat OR 
                                        [Fullname] = @Fullname OR [PhoneNumber] = @PhoneNumber OR [Email] = @Email", conn)
            cmd.Parameters.AddWithValue("@BusName", OleDbType.VarChar).Value = BusNameComboBox.Text
            cmd.Parameters.AddWithValue("@CurrentPlace", OleDbType.VarChar).Value = CurrentPlaceComboBox.Text
            cmd.Parameters.AddWithValue("@Destination", OleDbType.VarChar).Value = DestinationComboBox.Text
            cmd.Parameters.AddWithValue("@DepartureTime", OleDbType.VarNumeric).Value = DepartureTimeComboBox.Text
            cmd.Parameters.AddWithValue("@Seat", OleDbType.VarNumeric).Value = SeatComboBox.Text
            cmd.Parameters.AddWithValue("@Fullname", OleDbType.VarNumeric).Value = FullnameTextBox.Text
            cmd.Parameters.AddWithValue("@PhoneNo", OleDbType.VarNumeric).Value = PhoneNumTextBox.Text
            cmd.Parameters.AddWithValue("@Email", OleDbType.VarChar).Value = EmailTextBox.Text

        End Using

        Using create As New OleDbCommand("INSERT INTO BusAndPassengers ([BusName] = @BusName OR [CurrentPlace] = @CurrentPlace OR 
                                        [Destination] = @Destination OR [DepartureTime] = @DepartureTime OR [Seat] = @Seat OR 
                                        [Fullname] = @Fullname OR [PhoneNumber] = @PhoneNumber OR [Email] = @Email", conn)
            create.Parameters.AddWithValue("@BusName", OleDbType.VarChar).Value = BusNameComboBox.Text
            create.Parameters.AddWithValue("@CurrentPlace", OleDbType.VarChar).Value = CurrentPlaceComboBox.Text
            create.Parameters.AddWithValue("@Destination", OleDbType.VarChar).Value = DestinationComboBox.Text
            create.Parameters.AddWithValue("@DepartureTime", OleDbType.VarNumeric).Value = DepartureTimeComboBox.Text
            create.Parameters.AddWithValue("@Seat", OleDbType.VarNumeric).Value = SeatComboBox.Text
            create.Parameters.AddWithValue("@Fullname", OleDbType.VarNumeric).Value = FullnameTextBox.Text
            create.Parameters.AddWithValue("@PhoneNo", OleDbType.VarNumeric).Value = PhoneNumTextBox.Text
            create.Parameters.AddWithValue("@Email", OleDbType.VarChar).Value = EmailTextBox.Text

            If create.ExecuteNonQuery Then
                MessageBox.Show("Your seat has been succesfully booked!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                BusNameComboBox.Items.Clear()
                CurrentPlaceComboBox.Items.Clear()
                DestinationComboBox.Items.Clear()
                DepartureTimeComboBox.Items.Clear()
                SeatComboBox.Items.Clear()
                FullnameTextBox.Clear()
                PhoneNumTextBox.Clear()
                EmailTextBox.Clear()

            End If

        End Using

        'pop up confirmation message
        MessageBox.Show("")

        conn.Close()

    End Sub

    Private Sub PayButton_Click(sender As Object, e As EventArgs) Handles PayButton.Click
        Const servicetax As Decimal = 0.06
        Dim ticketprice,
            total,
            cash,
            change As Decimal

        ticketprice = Decimal.Parse(TicketPriceTextBox.Text)
        total = Decimal.Parse(TotalTextBox.Text)
        cash = Decimal.Parse(CashTextBox.Text)
        change = Decimal.Parse(ChangeTextBox.Text)

        'calculate the payment
        total = ticketprice + servicetax

        'input the amount of money they pay
        change = cash - total

        'change it to string
        Dim formattedTotalString As String
        Dim formattedCashString As String
        Dim formattedChangeString As String
        Dim messageString As String

        formattedTotalString = total.ToString("c")
        formattedCashString = cash.ToString("c")
        formattedChangeString = change.ToString("c")
        'update/display change
        messageString = "Total : " & formattedTotalString & Environment.NewLine &
                        "Cash : " & formattedCashString & Environment.NewLine &
                        "Change : " & formattedChangeString & Environment.NewLine

        MessageBox.Show(messageString, "Payment Receipt BUSGo", MessageBoxButtons.OK)
        ViewTicketButton.Show()
    End Sub

    Private Sub ViewTicketButton_Click(sender As Object, e As EventArgs) Handles ViewTicketButton.Click
        Me.Hide()
    End Sub

End Class