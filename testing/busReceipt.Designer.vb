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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(busReceipt))
        Me.ReceiptGroupBox = New System.Windows.Forms.GroupBox()
        Me.EmailLabel = New System.Windows.Forms.Label()
        Me.PhoneNoLabel = New System.Windows.Forms.Label()
        Me.FullnameLabel = New System.Windows.Forms.Label()
        Me.SeatLabel = New System.Windows.Forms.Label()
        Me.DepartureLabel = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DestinationLabel = New System.Windows.Forms.Label()
        Me.CurrentPlaceLabel = New System.Windows.Forms.Label()
        Me.BusNameLabel = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.HomeButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.ReceiptGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'ReceiptGroupBox
        '
        Me.ReceiptGroupBox.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.ReceiptGroupBox.BackgroundImage = Global.testing.My.Resources.Resources.bgbusgo1
        Me.ReceiptGroupBox.Controls.Add(Me.EmailLabel)
        Me.ReceiptGroupBox.Controls.Add(Me.PhoneNoLabel)
        Me.ReceiptGroupBox.Controls.Add(Me.FullnameLabel)
        Me.ReceiptGroupBox.Controls.Add(Me.SeatLabel)
        Me.ReceiptGroupBox.Controls.Add(Me.DepartureLabel)
        Me.ReceiptGroupBox.Controls.Add(Me.Label9)
        Me.ReceiptGroupBox.Controls.Add(Me.DestinationLabel)
        Me.ReceiptGroupBox.Controls.Add(Me.CurrentPlaceLabel)
        Me.ReceiptGroupBox.Controls.Add(Me.BusNameLabel)
        Me.ReceiptGroupBox.Controls.Add(Me.Label8)
        Me.ReceiptGroupBox.Controls.Add(Me.Label5)
        Me.ReceiptGroupBox.Controls.Add(Me.Label7)
        Me.ReceiptGroupBox.Controls.Add(Me.Label6)
        Me.ReceiptGroupBox.Controls.Add(Me.Label1)
        Me.ReceiptGroupBox.Controls.Add(Me.Label3)
        Me.ReceiptGroupBox.Controls.Add(Me.Label4)
        Me.ReceiptGroupBox.Controls.Add(Me.Label2)
        Me.ReceiptGroupBox.ForeColor = System.Drawing.Color.White
        Me.ReceiptGroupBox.Location = New System.Drawing.Point(124, 78)
        Me.ReceiptGroupBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ReceiptGroupBox.Name = "ReceiptGroupBox"
        Me.ReceiptGroupBox.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ReceiptGroupBox.Size = New System.Drawing.Size(817, 380)
        Me.ReceiptGroupBox.TabIndex = 0
        Me.ReceiptGroupBox.TabStop = False
        Me.ReceiptGroupBox.Text = "Payment Receipt BusGo"
        '
        'EmailLabel
        '
        Me.EmailLabel.AutoSize = True
        Me.EmailLabel.BackColor = System.Drawing.Color.Transparent
        Me.EmailLabel.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailLabel.ForeColor = System.Drawing.Color.White
        Me.EmailLabel.Location = New System.Drawing.Point(237, 273)
        Me.EmailLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EmailLabel.Name = "EmailLabel"
        Me.EmailLabel.Size = New System.Drawing.Size(73, 18)
        Me.EmailLabel.TabIndex = 50
        Me.EmailLabel.Text = "Bus Name:"
        '
        'PhoneNoLabel
        '
        Me.PhoneNoLabel.AutoSize = True
        Me.PhoneNoLabel.BackColor = System.Drawing.Color.Transparent
        Me.PhoneNoLabel.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneNoLabel.ForeColor = System.Drawing.Color.White
        Me.PhoneNoLabel.Location = New System.Drawing.Point(237, 241)
        Me.PhoneNoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PhoneNoLabel.Name = "PhoneNoLabel"
        Me.PhoneNoLabel.Size = New System.Drawing.Size(73, 18)
        Me.PhoneNoLabel.TabIndex = 49
        Me.PhoneNoLabel.Text = "Bus Name:"
        '
        'FullnameLabel
        '
        Me.FullnameLabel.AutoSize = True
        Me.FullnameLabel.BackColor = System.Drawing.Color.Transparent
        Me.FullnameLabel.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FullnameLabel.ForeColor = System.Drawing.Color.White
        Me.FullnameLabel.Location = New System.Drawing.Point(237, 209)
        Me.FullnameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FullnameLabel.Name = "FullnameLabel"
        Me.FullnameLabel.Size = New System.Drawing.Size(73, 18)
        Me.FullnameLabel.TabIndex = 48
        Me.FullnameLabel.Text = "Bus Name:"
        '
        'SeatLabel
        '
        Me.SeatLabel.AutoSize = True
        Me.SeatLabel.BackColor = System.Drawing.Color.Transparent
        Me.SeatLabel.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SeatLabel.ForeColor = System.Drawing.Color.White
        Me.SeatLabel.Location = New System.Drawing.Point(237, 175)
        Me.SeatLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SeatLabel.Name = "SeatLabel"
        Me.SeatLabel.Size = New System.Drawing.Size(73, 18)
        Me.SeatLabel.TabIndex = 47
        Me.SeatLabel.Text = "Bus Name:"
        '
        'DepartureLabel
        '
        Me.DepartureLabel.AutoSize = True
        Me.DepartureLabel.BackColor = System.Drawing.Color.Transparent
        Me.DepartureLabel.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DepartureLabel.ForeColor = System.Drawing.Color.White
        Me.DepartureLabel.Location = New System.Drawing.Point(237, 143)
        Me.DepartureLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DepartureLabel.Name = "DepartureLabel"
        Me.DepartureLabel.Size = New System.Drawing.Size(73, 18)
        Me.DepartureLabel.TabIndex = 46
        Me.DepartureLabel.Text = "Bus Name:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(1453, 350)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 18)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Bus Name:"
        '
        'DestinationLabel
        '
        Me.DestinationLabel.AutoSize = True
        Me.DestinationLabel.BackColor = System.Drawing.Color.Transparent
        Me.DestinationLabel.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DestinationLabel.ForeColor = System.Drawing.Color.White
        Me.DestinationLabel.Location = New System.Drawing.Point(237, 111)
        Me.DestinationLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DestinationLabel.Name = "DestinationLabel"
        Me.DestinationLabel.Size = New System.Drawing.Size(73, 18)
        Me.DestinationLabel.TabIndex = 44
        Me.DestinationLabel.Text = "Bus Name:"
        '
        'CurrentPlaceLabel
        '
        Me.CurrentPlaceLabel.AutoSize = True
        Me.CurrentPlaceLabel.BackColor = System.Drawing.Color.Transparent
        Me.CurrentPlaceLabel.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentPlaceLabel.ForeColor = System.Drawing.Color.White
        Me.CurrentPlaceLabel.Location = New System.Drawing.Point(237, 79)
        Me.CurrentPlaceLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CurrentPlaceLabel.Name = "CurrentPlaceLabel"
        Me.CurrentPlaceLabel.Size = New System.Drawing.Size(40, 18)
        Me.CurrentPlaceLabel.TabIndex = 43
        Me.CurrentPlaceLabel.Text = "Label"
        '
        'BusNameLabel
        '
        Me.BusNameLabel.AutoSize = True
        Me.BusNameLabel.BackColor = System.Drawing.Color.Transparent
        Me.BusNameLabel.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BusNameLabel.ForeColor = System.Drawing.Color.White
        Me.BusNameLabel.Location = New System.Drawing.Point(237, 47)
        Me.BusNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.BusNameLabel.Name = "BusNameLabel"
        Me.BusNameLabel.Size = New System.Drawing.Size(73, 18)
        Me.BusNameLabel.TabIndex = 42
        Me.BusNameLabel.Text = "Bus Name:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(48, 273)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 18)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Email:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(48, 175)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 18)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Seat:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(48, 241)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 18)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Phone Number:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(48, 209)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 18)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Full Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(48, 79)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 18)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Current Place:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(48, 143)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 18)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Departure Time:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(48, 47)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 18)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Bus Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(48, 111)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 18)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Destination Place:"
        '
        'HomeButton
        '
        Me.HomeButton.BackColor = System.Drawing.Color.White
        Me.HomeButton.ForeColor = System.Drawing.Color.Black
        Me.HomeButton.Location = New System.Drawing.Point(812, 486)
        Me.HomeButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(129, 53)
        Me.HomeButton.TabIndex = 35
        Me.HomeButton.Text = "Home"
        Me.HomeButton.UseVisualStyleBackColor = False
        '
        'PrintButton
        '
        Me.PrintButton.BackColor = System.Drawing.Color.White
        Me.PrintButton.ForeColor = System.Drawing.Color.Black
        Me.PrintButton.Location = New System.Drawing.Point(661, 486)
        Me.PrintButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(129, 53)
        Me.PrintButton.TabIndex = 36
        Me.PrintButton.Text = "Print Ticket"
        Me.PrintButton.UseVisualStyleBackColor = False
        '
        'PrintDocument1
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'busReceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.testing.My.Resources.Resources.bgbusgo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.ReceiptGroupBox)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.HomeButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "busReceipt"
        Me.Text = "BusGo | Bus Receipt"
        Me.ReceiptGroupBox.ResumeLayout(False)
        Me.ReceiptGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReceiptGroupBox As GroupBox
    Friend WithEvents HomeButton As Button
    Friend WithEvents PrintButton As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents EmailLabel As Label
    Friend WithEvents PhoneNoLabel As Label
    Friend WithEvents FullnameLabel As Label
    Friend WithEvents SeatLabel As Label
    Friend WithEvents DepartureLabel As Label
    Friend WithEvents DestinationLabel As Label
    Friend WithEvents CurrentPlaceLabel As Label
    Friend WithEvents BusNameLabel As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
