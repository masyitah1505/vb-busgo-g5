Imports System.Data.OleDb
Public Class bookBus
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source = " & Application.StartupPath & "\RegisterStaff.accdb")

    'bus details
        Dim busname,
        currentplace, seatNo,
        seat,
        departuretime,
        destination As String

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Hide()
        designDashboard.Show()
    End Sub


    'passengers details
    Dim fullname,
            phonenumber,
            email As String


    Public Sub BookButton_Click(sender As Object, e As EventArgs) Handles BookButton.Click


        busname = BusNameComboBox.Text
        currentplace = CurrentPlaceComboBox.Text
        destination = DestinationComboBox.Text
        seatNo = SeatNoComboBox.Text
        seat = SeatRowComboBox.Text
        departuretime = DepartureTimeComboBox.Text

        fullname = FullnameTextBox.Text
        phonenumber = PhoneNumTextBox.Text
        email = EmailTextBox.Text

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        'database
        Using cmd As New OleDbCommand("SELECT COUNT (*) FROM BusAndPassengers WHERE [BusName] = @BusName OR [CurrentPlace] = @CurrentPlace OR 
                                        [Destination] = @Destination OR [DepartureTime] = @DepartureTime OR [SeatNo] = @SeatNo OR [Seat] = @Seat OR 
                                        [Fullname] = @Fullname OR [PhoneNumber] = @PhoneNumber OR [Email] = @Email", conn)
            cmd.Parameters.AddWithValue("@BusName", OleDbType.VarChar).Value = BusNameComboBox.Text
            cmd.Parameters.AddWithValue("@CurrentPlace", OleDbType.VarChar).Value = CurrentPlaceComboBox.Text
            cmd.Parameters.AddWithValue("@Destination", OleDbType.VarChar).Value = DestinationComboBox.Text
            cmd.Parameters.AddWithValue("@DepartureTime", OleDbType.VarChar).Value = DepartureTimeComboBox.Text
            cmd.Parameters.AddWithValue("@SeatNo", OleDbType.VarChar).Value = SeatNoComboBox.Text
            cmd.Parameters.AddWithValue("@Seat", OleDbType.VarChar).Value = SeatRowComboBox.Text
            cmd.Parameters.AddWithValue("@Fullname", OleDbType.VarChar).Value = FullnameTextBox.Text
            cmd.Parameters.AddWithValue("@PhoneNumber", OleDbType.VarNumeric).Value = PhoneNumTextBox.Text
            cmd.Parameters.AddWithValue("@Email", OleDbType.VarChar).Value = EmailTextBox.Text

        End Using

        Using create As New OleDbCommand("INSERT INTO BusAndPassengers ([BusName],[CurrentPlace],[Destination],[DepartureTime],[SeatNo],[Seat],[Fullname],[PhoneNumber],[Email])
                                           VALUES(@BusName,@CurrentPlace,@Destination,@DepartureTime,@SeatNo,@Seat,@Fullname,@PhoneNumber,@Email)", conn)
            create.Parameters.AddWithValue("@BusName", OleDbType.VarChar).Value = BusNameComboBox.Text
            create.Parameters.AddWithValue("@CurrentPlace", OleDbType.VarChar).Value = CurrentPlaceComboBox.Text
            create.Parameters.AddWithValue("@Destination", OleDbType.VarChar).Value = DestinationComboBox.Text
            create.Parameters.AddWithValue("@DepartureTime", OleDbType.VarChar).Value = DepartureTimeComboBox.Text
            create.Parameters.AddWithValue("@SeatNo", OleDbType.VarChar).Value = SeatNoComboBox.Text
            create.Parameters.AddWithValue("@Seat", OleDbType.VarChar).Value = SeatRowComboBox.Text
            create.Parameters.AddWithValue("@Fullname", OleDbType.VarChar).Value = FullnameTextBox.Text
            create.Parameters.AddWithValue("@PhoneNumber", OleDbType.VarNumeric).Value = PhoneNumTextBox.Text
            create.Parameters.AddWithValue("@Email", OleDbType.VarChar).Value = EmailTextBox.Text

            Dim result As DialogResult = MessageBox.Show("Are you confirm to book?",
                                                      "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                If create.ExecuteNonQuery Then
                    MessageBox.Show("Your seat has been succesfully booked!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    'BusNameComboBox.Items.Clear()
                    'CurrentPlaceComboBox.Items.Clear()
                    'DestinationComboBox.Items.Clear()
                    'DepartureTimeComboBox.Items.Clear()
                    'SeatNoComboBox.Items.Clear()
                    'SeatRowComboBox.Items.Clear()
                    'FullnameTextBox.Clear()
                    'PhoneNumTextBox.Clear()
                    'EmailTextBox.Clear()

                End If


            Else
                MessageBox.Show("Please fil in again your details", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If result = DialogResult.Yes Then
                    Me.Show()
                End If
            End If

            'If create.ExecuteNonQuery Then
            'MessageBox.Show("Your seat has been succesfully booked!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'BusNameComboBox.Items.Clear()
            'CurrentPlaceComboBox.Items.Clear()
            'DestinationComboBox.Items.Clear()
            'DepartureTimeComboBox.Items.Clear()
            'SeatNoComboBox.Items.Clear()
            'SeatRowComboBox.Items.Clear()
            'FullnameTextBox.Clear()
            'PhoneNumTextBox.Clear()
            'EmailTextBox.Clear()

            'End If

        End Using

        conn.Close()

        Const servicetax As Decimal = 0.1
        Const TBSticketprice As Decimal = 60.0
        Const GWticketprice As Decimal = 50.0
        Dim total, servicetaxtotal As Decimal


        If CurrentPlaceComboBox.Text = "Terminal Bersepadu Selatan (TBS)" Then

            TicketPriceTextBox.Text = TBSticketprice.ToString("C")

            servicetaxtotal = servicetax * TBSticketprice
            ServiceTaxTextBox.Text = servicetaxtotal.ToString("C")

            'calculate the payment
            total = TBSticketprice + servicetaxtotal
            TotalTextBox.Text = total.ToString

        ElseIf CurrentPlaceComboBox.Text = "Hentian Bas Greenwood" Then

            TicketPriceTextBox.Text = GWticketprice.ToString("C")

            servicetaxtotal = servicetax * GWticketprice
            ServiceTaxTextBox.Text = servicetaxtotal.ToString("C")

            'calculate the payment
            total = GWticketprice + servicetaxtotal
            TotalTextBox.Text = total.ToString

        End If
    End Sub

    Private Sub PayButton_Click(sender As Object, e As EventArgs) Handles PayButton.Click

        Dim total As Decimal
        Dim cash As Decimal
        Dim change As Decimal

        cash = Decimal.Parse(CashTextBox.Text)
        total = Decimal.Parse(TotalTextBox.Text)


        'input the amount of money they pay
        change = cash - total
        ChangeTextBox.Text = change.ToString("C")


        'change it to string
        Dim formattedTotalString As String
        Dim formattedCashString As String
        Dim formattedChangeString As String
        Dim messageString As String

        formattedTotalString = total.ToString("c")
        formattedCashString = cash.ToString("c")
        formattedChangeString = change.ToString("c")
        'Update/ display change
        messageString = "Total : " & formattedTotalString & Environment.NewLine &
                       "Cash : " & formattedCashString & Environment.NewLine &
                      "Change : " & formattedChangeString & Environment.NewLine

        MessageBox.Show(messageString, "Payment Receipt BUSGo", MessageBoxButtons.OK)
        ViewTicketButton.Show()

    End Sub

    Public Sub ViewTicketButton_Click(sender As Object, e As EventArgs) Handles ViewTicketButton.Click
        Me.Hide()
        busReceipt.ShowDialog()
        'busname = busReceipt.BusNameLabel.Text
        busReceipt.BusNameLabel.Text = busname
        'currentplace = busReceipt.CurrentPlaceLabel.Text
        busReceipt.CurrentPlaceLabel.Text = currentplace
        'destination = busReceipt.DestinationLabel.Text
        busReceipt.DestinationLabel.Text = destination
        'departuretime = busReceipt.DepartureLabel.Text
        busReceipt.DepartureLabel.Text = departuretime
        'seatNo = busReceipt.SeatLabel.Text
        busReceipt.SeatLabel.Text = seatNo
        'seat = busReceipt.SeatLabel.Text
        busReceipt.SeatLabel.Text = seat
        'fullname = busReceipt.FullnameLabel.Text
        busReceipt.FullnameLabel.Text = fullname
        'phonenumber = busReceipt.PhoneNoLabel.Text
        busReceipt.PhoneNoLabel.Text = phonenumber
        'email = busReceipt.EmailLabel.Text
        busReceipt.EmailLabel.Text = email
    End Sub
End Class