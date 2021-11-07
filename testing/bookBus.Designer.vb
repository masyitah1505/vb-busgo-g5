<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class bookBus
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bookBus))
        Me.PayButton = New System.Windows.Forms.Button()
        Me.ChangeTextBox = New System.Windows.Forms.TextBox()
        Me.BookButton = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PhoneNumTextBox = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CashTextBox = New System.Windows.Forms.TextBox()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ServiceTaxTextBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TicketPriceTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SeatNoComboBox = New System.Windows.Forms.ComboBox()
        Me.SeatRowComboBox = New System.Windows.Forms.ComboBox()
        Me.DepartureTimeComboBox = New System.Windows.Forms.ComboBox()
        Me.DestinationComboBox = New System.Windows.Forms.ComboBox()
        Me.CurrentPlaceComboBox = New System.Windows.Forms.ComboBox()
        Me.BusNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ViewTicketButton = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.FullnameTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PayButton
        '
        Me.PayButton.BackColor = System.Drawing.Color.White
        Me.PayButton.ForeColor = System.Drawing.Color.Black
        Me.PayButton.Location = New System.Drawing.Point(189, 178)
        Me.PayButton.Margin = New System.Windows.Forms.Padding(4)
        Me.PayButton.Name = "PayButton"
        Me.PayButton.Size = New System.Drawing.Size(129, 53)
        Me.PayButton.TabIndex = 24
        Me.PayButton.Text = "Pay"
        Me.PayButton.UseVisualStyleBackColor = False
        '
        'ChangeTextBox
        '
        Me.ChangeTextBox.Location = New System.Drawing.Point(144, 255)
        Me.ChangeTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ChangeTextBox.Name = "ChangeTextBox"
        Me.ChangeTextBox.Size = New System.Drawing.Size(173, 22)
        Me.ChangeTextBox.TabIndex = 32
        '
        'BookButton
        '
        Me.BookButton.BackColor = System.Drawing.Color.White
        Me.BookButton.ForeColor = System.Drawing.Color.Black
        Me.BookButton.Location = New System.Drawing.Point(327, 140)
        Me.BookButton.Margin = New System.Windows.Forms.Padding(4)
        Me.BookButton.Name = "BookButton"
        Me.BookButton.Size = New System.Drawing.Size(129, 53)
        Me.BookButton.TabIndex = 23
        Me.BookButton.Text = "Book"
        Me.BookButton.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(8, 91)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 18)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Email:"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(141, 87)
        Me.EmailTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(173, 22)
        Me.EmailTextBox.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(8, 59)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 18)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Phone Number:"
        '
        'PhoneNumTextBox
        '
        Me.PhoneNumTextBox.Location = New System.Drawing.Point(141, 55)
        Me.PhoneNumTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PhoneNumTextBox.Name = "PhoneNumTextBox"
        Me.PhoneNumTextBox.Size = New System.Drawing.Size(173, 22)
        Me.PhoneNumTextBox.TabIndex = 20
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(11, 258)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 18)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "Change:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(11, 130)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 18)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "Cash (RM):"
        '
        'CashTextBox
        '
        Me.CashTextBox.Location = New System.Drawing.Point(144, 127)
        Me.CashTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CashTextBox.Name = "CashTextBox"
        Me.CashTextBox.Size = New System.Drawing.Size(173, 22)
        Me.CashTextBox.TabIndex = 30
        '
        'TotalTextBox
        '
        Me.TotalTextBox.Location = New System.Drawing.Point(144, 95)
        Me.TotalTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(173, 22)
        Me.TotalTextBox.TabIndex = 28
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(11, 66)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 18)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Service Tax:"
        '
        'ServiceTaxTextBox
        '
        Me.ServiceTaxTextBox.Location = New System.Drawing.Point(144, 63)
        Me.ServiceTaxTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ServiceTaxTextBox.Name = "ServiceTaxTextBox"
        Me.ServiceTaxTextBox.Size = New System.Drawing.Size(173, 22)
        Me.ServiceTaxTextBox.TabIndex = 26
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(11, 34)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 18)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Ticket Price:"
        '
        'TicketPriceTextBox
        '
        Me.TicketPriceTextBox.Location = New System.Drawing.Point(144, 31)
        Me.TicketPriceTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TicketPriceTextBox.Name = "TicketPriceTextBox"
        Me.TicketPriceTextBox.Size = New System.Drawing.Size(173, 22)
        Me.TicketPriceTextBox.TabIndex = 24
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.SeatNoComboBox)
        Me.GroupBox1.Controls.Add(Me.SeatRowComboBox)
        Me.GroupBox1.Controls.Add(Me.DepartureTimeComboBox)
        Me.GroupBox1.Controls.Add(Me.DestinationComboBox)
        Me.GroupBox1.Controls.Add(Me.CurrentPlaceComboBox)
        Me.GroupBox1.Controls.Add(Me.BusNameComboBox)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(128, 49)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(464, 231)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bus Details"
        '
        'SeatNoComboBox
        '
        Me.SeatNoComboBox.FormattingEnabled = True
        Me.SeatNoComboBox.Items.AddRange(New Object() {"LEFT 1", "LEFT 2", "RIGHT 1", "RIGHT 2"})
        Me.SeatNoComboBox.Location = New System.Drawing.Point(141, 158)
        Me.SeatNoComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SeatNoComboBox.Name = "SeatNoComboBox"
        Me.SeatNoComboBox.Size = New System.Drawing.Size(173, 24)
        Me.SeatNoComboBox.TabIndex = 25
        '
        'SeatRowComboBox
        '
        Me.SeatRowComboBox.FormattingEnabled = True
        Me.SeatRowComboBox.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J"})
        Me.SeatRowComboBox.Location = New System.Drawing.Point(141, 193)
        Me.SeatRowComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SeatRowComboBox.Name = "SeatRowComboBox"
        Me.SeatRowComboBox.Size = New System.Drawing.Size(173, 24)
        Me.SeatRowComboBox.TabIndex = 24
        '
        'DepartureTimeComboBox
        '
        Me.DepartureTimeComboBox.FormattingEnabled = True
        Me.DepartureTimeComboBox.Items.AddRange(New Object() {"7.00 AM ", "9.00 AM ", "11.00 AM ", "02.00 PM ", "05.00 PM ", "08.00 PM ", "11.00 PM "})
        Me.DepartureTimeComboBox.Location = New System.Drawing.Point(141, 123)
        Me.DepartureTimeComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DepartureTimeComboBox.Name = "DepartureTimeComboBox"
        Me.DepartureTimeComboBox.Size = New System.Drawing.Size(173, 24)
        Me.DepartureTimeComboBox.TabIndex = 21
        '
        'DestinationComboBox
        '
        Me.DestinationComboBox.FormattingEnabled = True
        Me.DestinationComboBox.Items.AddRange(New Object() {"Terminal Bersepadu Selatan (TBS)", "Jitra Bus Terminal", "Johor Raya Bus Terminal", "Kuanatan Sentral Bus Terminal", "Melaka Sentral Bus Terminal", "Pontian Bus Terminal", "Sungai Petani Bus Station"})
        Me.DestinationComboBox.Location = New System.Drawing.Point(141, 90)
        Me.DestinationComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DestinationComboBox.Name = "DestinationComboBox"
        Me.DestinationComboBox.Size = New System.Drawing.Size(173, 24)
        Me.DestinationComboBox.TabIndex = 20
        '
        'CurrentPlaceComboBox
        '
        Me.CurrentPlaceComboBox.FormattingEnabled = True
        Me.CurrentPlaceComboBox.Items.AddRange(New Object() {"Hentian Bas Greenwood", "Terminal Bersepadu Selatan (TBS)"})
        Me.CurrentPlaceComboBox.Location = New System.Drawing.Point(141, 58)
        Me.CurrentPlaceComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CurrentPlaceComboBox.Name = "CurrentPlaceComboBox"
        Me.CurrentPlaceComboBox.Size = New System.Drawing.Size(173, 24)
        Me.CurrentPlaceComboBox.TabIndex = 19
        '
        'BusNameComboBox
        '
        Me.BusNameComboBox.FormattingEnabled = True
        Me.BusNameComboBox.Items.AddRange(New Object() {"Perdana Express", "Sani Express", "Adik Beradik", "Transnasional ", "Perak Transit", "Pancaran Matahari ", "Mayang Sari Express"})
        Me.BusNameComboBox.Location = New System.Drawing.Point(141, 27)
        Me.BusNameComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.BusNameComboBox.Name = "BusNameComboBox"
        Me.BusNameComboBox.Size = New System.Drawing.Size(173, 24)
        Me.BusNameComboBox.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(8, 159)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 18)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Seat:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(8, 127)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 18)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Departure Time:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(8, 95)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 18)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Destination Place:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(8, 63)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 18)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Current Place:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(8, 31)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 18)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Bus Name:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(11, 98)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 18)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Total (RM):"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.ViewTicketButton)
        Me.GroupBox3.Controls.Add(Me.PayButton)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.ChangeTextBox)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.CashTextBox)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.TotalTextBox)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.ServiceTaxTextBox)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.TicketPriceTextBox)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(613, 49)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(327, 455)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Total Price"
        '
        'ViewTicketButton
        '
        Me.ViewTicketButton.BackColor = System.Drawing.Color.White
        Me.ViewTicketButton.ForeColor = System.Drawing.Color.Black
        Me.ViewTicketButton.Location = New System.Drawing.Point(189, 395)
        Me.ViewTicketButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ViewTicketButton.Name = "ViewTicketButton"
        Me.ViewTicketButton.Size = New System.Drawing.Size(129, 53)
        Me.ViewTicketButton.TabIndex = 34
        Me.ViewTicketButton.Text = "View Ticket"
        Me.ViewTicketButton.UseVisualStyleBackColor = False
        Me.ViewTicketButton.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(8, 27)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 18)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Full Name:"
        '
        'FullnameTextBox
        '
        Me.FullnameTextBox.Location = New System.Drawing.Point(141, 23)
        Me.FullnameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.FullnameTextBox.Name = "FullnameTextBox"
        Me.FullnameTextBox.Size = New System.Drawing.Size(173, 22)
        Me.FullnameTextBox.TabIndex = 18
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.BookButton)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.EmailTextBox)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.PhoneNumTextBox)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.FullnameTextBox)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(128, 304)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(464, 201)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pessenger's Details"
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(25, 32)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(47, 38)
        Me.BackButton.TabIndex = 31
        Me.BackButton.Text = "<"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'bookBus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.testing.My.Resources.Resources.bgbusgo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "bookBus"
        Me.Text = "BusGo | Booking Ticket"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PayButton As Button
    Friend WithEvents ChangeTextBox As TextBox
    Friend WithEvents BookButton As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PhoneNumTextBox As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents CashTextBox As TextBox
    Friend WithEvents TotalTextBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ServiceTaxTextBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TicketPriceTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ViewTicketButton As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents FullnameTextBox As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DepartureTimeComboBox As ComboBox
    Friend WithEvents DestinationComboBox As ComboBox
    Friend WithEvents CurrentPlaceComboBox As ComboBox
    Friend WithEvents BusNameComboBox As ComboBox
    Friend WithEvents SeatRowComboBox As ComboBox
    Friend WithEvents SeatNoComboBox As ComboBox
    Friend WithEvents BackButton As Button
End Class
