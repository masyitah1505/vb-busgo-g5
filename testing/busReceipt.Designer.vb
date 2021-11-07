<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class busReceipt
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(busReceipt))
        Me.ReceiptGroupBox = New System.Windows.Forms.GroupBox()
        Me.EmailLabel = New System.Windows.Forms.Label()
        Me.FullnameLabel = New System.Windows.Forms.Label()
        Me.PhoneNoLabel = New System.Windows.Forms.Label()
        Me.SeatLabel = New System.Windows.Forms.Label()
        Me.DepartureLabel = New System.Windows.Forms.Label()
        Me.DestinationLabel = New System.Windows.Forms.Label()
        Me.CurrentPlaceLabel = New System.Windows.Forms.Label()
        Me.BusNameLabel = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.HomeButton = New System.Windows.Forms.Button()
        Me.printButton = New System.Windows.Forms.Button()
        Me.backHomepageButton = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.ReceiptGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'ReceiptGroupBox
        '
        Me.ReceiptGroupBox.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.ReceiptGroupBox.BackgroundImage = Global.testing.My.Resources.Resources.bgbusgo1
        Me.ReceiptGroupBox.Controls.Add(Me.EmailLabel)
        Me.ReceiptGroupBox.Controls.Add(Me.FullnameLabel)
        Me.ReceiptGroupBox.Controls.Add(Me.PhoneNoLabel)
        Me.ReceiptGroupBox.Controls.Add(Me.SeatLabel)
        Me.ReceiptGroupBox.Controls.Add(Me.DepartureLabel)
        Me.ReceiptGroupBox.Controls.Add(Me.DestinationLabel)
        Me.ReceiptGroupBox.Controls.Add(Me.CurrentPlaceLabel)
        Me.ReceiptGroupBox.Controls.Add(Me.BusNameLabel)
        Me.ReceiptGroupBox.Controls.Add(Me.Label9)
        Me.ReceiptGroupBox.Controls.Add(Me.Label8)
        Me.ReceiptGroupBox.Controls.Add(Me.Label5)
        Me.ReceiptGroupBox.Controls.Add(Me.Label7)
        Me.ReceiptGroupBox.Controls.Add(Me.Label6)
        Me.ReceiptGroupBox.Controls.Add(Me.Label1)
        Me.ReceiptGroupBox.Controls.Add(Me.Label3)
        Me.ReceiptGroupBox.Controls.Add(Me.Label4)
        Me.ReceiptGroupBox.Controls.Add(Me.Label2)
        Me.ReceiptGroupBox.ForeColor = System.Drawing.Color.White
        Me.ReceiptGroupBox.Location = New System.Drawing.Point(93, 63)
        Me.ReceiptGroupBox.Name = "ReceiptGroupBox"
        Me.ReceiptGroupBox.Size = New System.Drawing.Size(613, 309)
        Me.ReceiptGroupBox.TabIndex = 0
        Me.ReceiptGroupBox.TabStop = False
        Me.ReceiptGroupBox.Text = "Payment Receipt BusGo"
        '
        'EmailLabel
        '
        Me.EmailLabel.AutoSize = True
        Me.EmailLabel.BackColor = System.Drawing.Color.Transparent
        Me.EmailLabel.Location = New System.Drawing.Point(201, 222)
        Me.EmailLabel.Name = "EmailLabel"
        Me.EmailLabel.Size = New System.Drawing.Size(27, 13)
        Me.EmailLabel.TabIndex = 52
        Me.EmailLabel.Text = "N/A"
        '
        'FullnameLabel
        '
        Me.FullnameLabel.AutoSize = True
        Me.FullnameLabel.BackColor = System.Drawing.Color.Transparent
        Me.FullnameLabel.Location = New System.Drawing.Point(201, 170)
        Me.FullnameLabel.Name = "FullnameLabel"
        Me.FullnameLabel.Size = New System.Drawing.Size(27, 13)
        Me.FullnameLabel.TabIndex = 51
        Me.FullnameLabel.Text = "N/A"
        '
        'PhoneNoLabel
        '
        Me.PhoneNoLabel.AutoSize = True
        Me.PhoneNoLabel.BackColor = System.Drawing.Color.Transparent
        Me.PhoneNoLabel.Location = New System.Drawing.Point(201, 196)
        Me.PhoneNoLabel.Name = "PhoneNoLabel"
        Me.PhoneNoLabel.Size = New System.Drawing.Size(27, 13)
        Me.PhoneNoLabel.TabIndex = 51
        Me.PhoneNoLabel.Text = "N/A"
        '
        'SeatLabel
        '
        Me.SeatLabel.AutoSize = True
        Me.SeatLabel.BackColor = System.Drawing.Color.Transparent
        Me.SeatLabel.Location = New System.Drawing.Point(201, 142)
        Me.SeatLabel.Name = "SeatLabel"
        Me.SeatLabel.Size = New System.Drawing.Size(27, 13)
        Me.SeatLabel.TabIndex = 50
        Me.SeatLabel.Text = "N/A"
        '
        'DepartureLabel
        '
        Me.DepartureLabel.AutoSize = True
        Me.DepartureLabel.BackColor = System.Drawing.Color.Transparent
        Me.DepartureLabel.Location = New System.Drawing.Point(201, 117)
        Me.DepartureLabel.Name = "DepartureLabel"
        Me.DepartureLabel.Size = New System.Drawing.Size(27, 13)
        Me.DepartureLabel.TabIndex = 49
        Me.DepartureLabel.Text = "N/A"
        '
        'DestinationLabel
        '
        Me.DestinationLabel.AutoSize = True
        Me.DestinationLabel.BackColor = System.Drawing.Color.Transparent
        Me.DestinationLabel.Location = New System.Drawing.Point(201, 91)
        Me.DestinationLabel.Name = "DestinationLabel"
        Me.DestinationLabel.Size = New System.Drawing.Size(27, 13)
        Me.DestinationLabel.TabIndex = 48
        Me.DestinationLabel.Text = "N/A"
        '
        'CurrentPlaceLabel
        '
        Me.CurrentPlaceLabel.AutoSize = True
        Me.CurrentPlaceLabel.BackColor = System.Drawing.Color.Transparent
        Me.CurrentPlaceLabel.Location = New System.Drawing.Point(201, 64)
        Me.CurrentPlaceLabel.Name = "CurrentPlaceLabel"
        Me.CurrentPlaceLabel.Size = New System.Drawing.Size(27, 13)
        Me.CurrentPlaceLabel.TabIndex = 47
        Me.CurrentPlaceLabel.Text = "N/A"
        '
        'BusNameLabel
        '
        Me.BusNameLabel.AutoSize = True
        Me.BusNameLabel.BackColor = System.Drawing.Color.Transparent
        Me.BusNameLabel.Location = New System.Drawing.Point(201, 38)
        Me.BusNameLabel.Name = "BusNameLabel"
        Me.BusNameLabel.Size = New System.Drawing.Size(27, 13)
        Me.BusNameLabel.TabIndex = 46
        Me.BusNameLabel.Text = "N/A"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(1090, 284)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 14)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Bus Name:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(36, 222)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 14)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Email:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(36, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 14)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Seat:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(36, 196)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 14)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Phone Number:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(36, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 14)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Full Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(36, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 14)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Current Place:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(36, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 14)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Departure Time:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(36, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 14)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Bus Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(36, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 14)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Destination Place:"
        '
        'HomeButton
        '
        Me.HomeButton.BackColor = System.Drawing.Color.White
        Me.HomeButton.ForeColor = System.Drawing.Color.Black
        Me.HomeButton.Location = New System.Drawing.Point(459, 395)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(197, 43)
        Me.HomeButton.TabIndex = 35
        Me.HomeButton.Text = "CLICK HERE TO INSERT CUTOMER DATA IN THE RECEIPT"
        Me.HomeButton.UseVisualStyleBackColor = False
        '
        'printButton
        '
        Me.printButton.BackColor = System.Drawing.Color.White
        Me.printButton.ForeColor = System.Drawing.Color.Black
        Me.printButton.Location = New System.Drawing.Point(356, 395)
        Me.printButton.Name = "printButton"
        Me.printButton.Size = New System.Drawing.Size(97, 43)
        Me.printButton.TabIndex = 36
        Me.printButton.Text = "PRINT TICKET"
        Me.printButton.UseVisualStyleBackColor = False
        '
        'backHomepageButton
        '
        Me.backHomepageButton.Location = New System.Drawing.Point(662, 395)
        Me.backHomepageButton.Name = "backHomepageButton"
        Me.backHomepageButton.Size = New System.Drawing.Size(97, 43)
        Me.backHomepageButton.TabIndex = 37
        Me.backHomepageButton.Text = "END"
        Me.backHomepageButton.UseVisualStyleBackColor = True
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'busReceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.testing.My.Resources.Resources.bgbusgo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.backHomepageButton)
        Me.Controls.Add(Me.ReceiptGroupBox)
        Me.Controls.Add(Me.printButton)
        Me.Controls.Add(Me.HomeButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "busReceipt"
        Me.Text = "BusGo | Bus Receipt"
        Me.ReceiptGroupBox.ResumeLayout(False)
        Me.ReceiptGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReceiptGroupBox As GroupBox
    Friend WithEvents HomeButton As Button
    Friend WithEvents printButton As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents EmailLabel As Label
    Friend WithEvents FullnameLabel As Label
    Friend WithEvents PhoneNoLabel As Label
    Friend WithEvents SeatLabel As Label
    Friend WithEvents DepartureLabel As Label
    Friend WithEvents DestinationLabel As Label
    Friend WithEvents CurrentPlaceLabel As Label
    Friend WithEvents BusNameLabel As Label
    Friend WithEvents backHomepageButton As Button
    Friend WithEvents PrintForm1 As PowerPacks.Printing.PrintForm
End Class
