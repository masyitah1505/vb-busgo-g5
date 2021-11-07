<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class busAvailability
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim IDLabel As System.Windows.Forms.Label
        Dim BusNameLabel As System.Windows.Forms.Label
        Dim CurrentPlaceLabel As System.Windows.Forms.Label
        Dim DestinationLabel As System.Windows.Forms.Label
        Dim DepartureTimeLabel As System.Windows.Forms.Label
        Dim SeatNoLabel As System.Windows.Forms.Label
        Dim SeatLabel As System.Windows.Forms.Label
        Dim FullnameLabel As System.Windows.Forms.Label
        Dim PhoneNumberLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(busAvailability))
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.BusNameTextBox = New System.Windows.Forms.TextBox()
        Me.CurrentPlaceTextBox = New System.Windows.Forms.TextBox()
        Me.DestinationTextBox = New System.Windows.Forms.TextBox()
        Me.DepartureTimeTextBox = New System.Windows.Forms.TextBox()
        Me.SeatNoTextBox = New System.Windows.Forms.TextBox()
        Me.SeatTextBox = New System.Windows.Forms.TextBox()
        Me.FullnameTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneNumberTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.PreviousButton = New System.Windows.Forms.Button()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        IDLabel = New System.Windows.Forms.Label()
        BusNameLabel = New System.Windows.Forms.Label()
        CurrentPlaceLabel = New System.Windows.Forms.Label()
        DestinationLabel = New System.Windows.Forms.Label()
        DepartureTimeLabel = New System.Windows.Forms.Label()
        SeatNoLabel = New System.Windows.Forms.Label()
        SeatLabel = New System.Windows.Forms.Label()
        FullnameLabel = New System.Windows.Forms.Label()
        PhoneNumberLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(139, 84)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(25, 17)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'BusNameLabel
        '
        BusNameLabel.AutoSize = True
        BusNameLabel.Location = New System.Drawing.Point(139, 112)
        BusNameLabel.Name = "BusNameLabel"
        BusNameLabel.Size = New System.Drawing.Size(77, 17)
        BusNameLabel.TabIndex = 3
        BusNameLabel.Text = "Bus Name:"
        '
        'CurrentPlaceLabel
        '
        CurrentPlaceLabel.AutoSize = True
        CurrentPlaceLabel.Location = New System.Drawing.Point(139, 140)
        CurrentPlaceLabel.Name = "CurrentPlaceLabel"
        CurrentPlaceLabel.Size = New System.Drawing.Size(98, 17)
        CurrentPlaceLabel.TabIndex = 5
        CurrentPlaceLabel.Text = "Current Place:"
        '
        'DestinationLabel
        '
        DestinationLabel.AutoSize = True
        DestinationLabel.Location = New System.Drawing.Point(139, 168)
        DestinationLabel.Name = "DestinationLabel"
        DestinationLabel.Size = New System.Drawing.Size(83, 17)
        DestinationLabel.TabIndex = 7
        DestinationLabel.Text = "Destination:"
        '
        'DepartureTimeLabel
        '
        DepartureTimeLabel.AutoSize = True
        DepartureTimeLabel.Location = New System.Drawing.Point(139, 196)
        DepartureTimeLabel.Name = "DepartureTimeLabel"
        DepartureTimeLabel.Size = New System.Drawing.Size(111, 17)
        DepartureTimeLabel.TabIndex = 9
        DepartureTimeLabel.Text = "Departure Time:"
        '
        'SeatNoLabel
        '
        SeatNoLabel.AutoSize = True
        SeatNoLabel.Location = New System.Drawing.Point(139, 224)
        SeatNoLabel.Name = "SeatNoLabel"
        SeatNoLabel.Size = New System.Drawing.Size(63, 17)
        SeatNoLabel.TabIndex = 11
        SeatNoLabel.Text = "Seat No:"
        '
        'SeatLabel
        '
        SeatLabel.AutoSize = True
        SeatLabel.Location = New System.Drawing.Point(139, 252)
        SeatLabel.Name = "SeatLabel"
        SeatLabel.Size = New System.Drawing.Size(41, 17)
        SeatLabel.TabIndex = 13
        SeatLabel.Text = "Seat:"
        '
        'FullnameLabel
        '
        FullnameLabel.AutoSize = True
        FullnameLabel.Location = New System.Drawing.Point(139, 280)
        FullnameLabel.Name = "FullnameLabel"
        FullnameLabel.Size = New System.Drawing.Size(69, 17)
        FullnameLabel.TabIndex = 15
        FullnameLabel.Text = "Fullname:"
        '
        'PhoneNumberLabel
        '
        PhoneNumberLabel.AutoSize = True
        PhoneNumberLabel.Location = New System.Drawing.Point(139, 308)
        PhoneNumberLabel.Name = "PhoneNumberLabel"
        PhoneNumberLabel.Size = New System.Drawing.Size(107, 17)
        PhoneNumberLabel.TabIndex = 17
        PhoneNumberLabel.Text = "Phone Number:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(139, 336)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(46, 17)
        EmailLabel.TabIndex = 19
        EmailLabel.Text = "Email:"
        '
        'IDTextBox
        '
        Me.IDTextBox.Location = New System.Drawing.Point(256, 81)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(279, 22)
        Me.IDTextBox.TabIndex = 2
        '
        'BusNameTextBox
        '
        Me.BusNameTextBox.Location = New System.Drawing.Point(256, 109)
        Me.BusNameTextBox.Name = "BusNameTextBox"
        Me.BusNameTextBox.Size = New System.Drawing.Size(279, 22)
        Me.BusNameTextBox.TabIndex = 4
        '
        'CurrentPlaceTextBox
        '
        Me.CurrentPlaceTextBox.Location = New System.Drawing.Point(256, 137)
        Me.CurrentPlaceTextBox.Name = "CurrentPlaceTextBox"
        Me.CurrentPlaceTextBox.Size = New System.Drawing.Size(279, 22)
        Me.CurrentPlaceTextBox.TabIndex = 6
        '
        'DestinationTextBox
        '
        Me.DestinationTextBox.Location = New System.Drawing.Point(256, 165)
        Me.DestinationTextBox.Name = "DestinationTextBox"
        Me.DestinationTextBox.Size = New System.Drawing.Size(279, 22)
        Me.DestinationTextBox.TabIndex = 8
        '
        'DepartureTimeTextBox
        '
        Me.DepartureTimeTextBox.Location = New System.Drawing.Point(256, 193)
        Me.DepartureTimeTextBox.Name = "DepartureTimeTextBox"
        Me.DepartureTimeTextBox.Size = New System.Drawing.Size(279, 22)
        Me.DepartureTimeTextBox.TabIndex = 10
        '
        'SeatNoTextBox
        '
        Me.SeatNoTextBox.Location = New System.Drawing.Point(256, 221)
        Me.SeatNoTextBox.Name = "SeatNoTextBox"
        Me.SeatNoTextBox.Size = New System.Drawing.Size(279, 22)
        Me.SeatNoTextBox.TabIndex = 12
        '
        'SeatTextBox
        '
        Me.SeatTextBox.Location = New System.Drawing.Point(256, 249)
        Me.SeatTextBox.Name = "SeatTextBox"
        Me.SeatTextBox.Size = New System.Drawing.Size(279, 22)
        Me.SeatTextBox.TabIndex = 14
        '
        'FullnameTextBox
        '
        Me.FullnameTextBox.Location = New System.Drawing.Point(256, 277)
        Me.FullnameTextBox.Name = "FullnameTextBox"
        Me.FullnameTextBox.Size = New System.Drawing.Size(279, 22)
        Me.FullnameTextBox.TabIndex = 16
        '
        'PhoneNumberTextBox
        '
        Me.PhoneNumberTextBox.Location = New System.Drawing.Point(256, 305)
        Me.PhoneNumberTextBox.Name = "PhoneNumberTextBox"
        Me.PhoneNumberTextBox.Size = New System.Drawing.Size(279, 22)
        Me.PhoneNumberTextBox.TabIndex = 18
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(256, 333)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(279, 22)
        Me.EmailTextBox.TabIndex = 20
        '
        'PreviousButton
        '
        Me.PreviousButton.BackColor = System.Drawing.Color.White
        Me.PreviousButton.ForeColor = System.Drawing.Color.Black
        Me.PreviousButton.Location = New System.Drawing.Point(755, 81)
        Me.PreviousButton.Margin = New System.Windows.Forms.Padding(4)
        Me.PreviousButton.Name = "PreviousButton"
        Me.PreviousButton.Size = New System.Drawing.Size(129, 53)
        Me.PreviousButton.TabIndex = 24
        Me.PreviousButton.Text = "Previous"
        Me.PreviousButton.UseVisualStyleBackColor = False
        '
        'NextButton
        '
        Me.NextButton.BackColor = System.Drawing.Color.White
        Me.NextButton.ForeColor = System.Drawing.Color.Black
        Me.NextButton.Location = New System.Drawing.Point(755, 150)
        Me.NextButton.Margin = New System.Windows.Forms.Padding(4)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(129, 53)
        Me.NextButton.TabIndex = 25
        Me.NextButton.Text = "Next"
        Me.NextButton.UseVisualStyleBackColor = False
        '
        'DeleteButton
        '
        Me.DeleteButton.BackColor = System.Drawing.Color.White
        Me.DeleteButton.ForeColor = System.Drawing.Color.Black
        Me.DeleteButton.Location = New System.Drawing.Point(755, 216)
        Me.DeleteButton.Margin = New System.Windows.Forms.Padding(4)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(129, 53)
        Me.DeleteButton.TabIndex = 27
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = False
        '
        'SaveButton
        '
        Me.SaveButton.BackColor = System.Drawing.Color.White
        Me.SaveButton.ForeColor = System.Drawing.Color.Black
        Me.SaveButton.Location = New System.Drawing.Point(755, 274)
        Me.SaveButton.Margin = New System.Windows.Forms.Padding(4)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(129, 53)
        Me.SaveButton.TabIndex = 28
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(31, 54)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(47, 38)
        Me.BackButton.TabIndex = 30
        Me.BackButton.Text = "<"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'busAvailability
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.testing.My.Resources.Resources.bgbusgo
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.PreviousButton)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(BusNameLabel)
        Me.Controls.Add(Me.BusNameTextBox)
        Me.Controls.Add(CurrentPlaceLabel)
        Me.Controls.Add(Me.CurrentPlaceTextBox)
        Me.Controls.Add(DestinationLabel)
        Me.Controls.Add(Me.DestinationTextBox)
        Me.Controls.Add(DepartureTimeLabel)
        Me.Controls.Add(Me.DepartureTimeTextBox)
        Me.Controls.Add(SeatNoLabel)
        Me.Controls.Add(Me.SeatNoTextBox)
        Me.Controls.Add(SeatLabel)
        Me.Controls.Add(Me.SeatTextBox)
        Me.Controls.Add(FullnameLabel)
        Me.Controls.Add(Me.FullnameTextBox)
        Me.Controls.Add(PhoneNumberLabel)
        Me.Controls.Add(Me.PhoneNumberTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "busAvailability"
        Me.Text = "BusGo | Bus Availability"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents BusNameTextBox As TextBox
    Friend WithEvents CurrentPlaceTextBox As TextBox
    Friend WithEvents DestinationTextBox As TextBox
    Friend WithEvents DepartureTimeTextBox As TextBox
    Friend WithEvents SeatNoTextBox As TextBox
    Friend WithEvents SeatTextBox As TextBox
    Friend WithEvents FullnameTextBox As TextBox
    Friend WithEvents PhoneNumberTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents PreviousButton As Button
    Friend WithEvents NextButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents BackButton As Button
End Class
