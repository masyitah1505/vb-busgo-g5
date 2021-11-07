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
        Me.components = New System.ComponentModel.Container()
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
        Me.PreviousButton = New System.Windows.Forms.Button()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.RegisterStaffDataSet = New testing.RegisterStaffDataSet()
        Me.BusAndPassengersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BusAndPassengersTableAdapter = New testing.RegisterStaffDataSetTableAdapters.BusAndPassengersTableAdapter()
        Me.TableAdapterManager = New testing.RegisterStaffDataSetTableAdapters.TableAdapterManager()
        Me.BusAndPassengersBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BusAndPassengersBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
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
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BusNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrentPlaceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DestinationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartureTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SeatNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SeatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        CType(Me.RegisterStaffDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BusAndPassengersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BusAndPassengersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BusAndPassengersBindingNavigator.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(129, 72)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 31
        IDLabel.Text = "ID:"
        '
        'BusNameLabel
        '
        BusNameLabel.AutoSize = True
        BusNameLabel.Location = New System.Drawing.Point(129, 98)
        BusNameLabel.Name = "BusNameLabel"
        BusNameLabel.Size = New System.Drawing.Size(59, 13)
        BusNameLabel.TabIndex = 33
        BusNameLabel.Text = "Bus Name:"
        '
        'CurrentPlaceLabel
        '
        CurrentPlaceLabel.AutoSize = True
        CurrentPlaceLabel.Location = New System.Drawing.Point(129, 124)
        CurrentPlaceLabel.Name = "CurrentPlaceLabel"
        CurrentPlaceLabel.Size = New System.Drawing.Size(74, 13)
        CurrentPlaceLabel.TabIndex = 35
        CurrentPlaceLabel.Text = "Current Place:"
        '
        'DestinationLabel
        '
        DestinationLabel.AutoSize = True
        DestinationLabel.Location = New System.Drawing.Point(129, 150)
        DestinationLabel.Name = "DestinationLabel"
        DestinationLabel.Size = New System.Drawing.Size(63, 13)
        DestinationLabel.TabIndex = 37
        DestinationLabel.Text = "Destination:"
        '
        'DepartureTimeLabel
        '
        DepartureTimeLabel.AutoSize = True
        DepartureTimeLabel.Location = New System.Drawing.Point(129, 176)
        DepartureTimeLabel.Name = "DepartureTimeLabel"
        DepartureTimeLabel.Size = New System.Drawing.Size(83, 13)
        DepartureTimeLabel.TabIndex = 39
        DepartureTimeLabel.Text = "Departure Time:"
        '
        'SeatNoLabel
        '
        SeatNoLabel.AutoSize = True
        SeatNoLabel.Location = New System.Drawing.Point(129, 202)
        SeatNoLabel.Name = "SeatNoLabel"
        SeatNoLabel.Size = New System.Drawing.Size(49, 13)
        SeatNoLabel.TabIndex = 41
        SeatNoLabel.Text = "Seat No:"
        '
        'SeatLabel
        '
        SeatLabel.AutoSize = True
        SeatLabel.Location = New System.Drawing.Point(129, 228)
        SeatLabel.Name = "SeatLabel"
        SeatLabel.Size = New System.Drawing.Size(32, 13)
        SeatLabel.TabIndex = 43
        SeatLabel.Text = "Seat:"
        '
        'FullnameLabel
        '
        FullnameLabel.AutoSize = True
        FullnameLabel.Location = New System.Drawing.Point(129, 254)
        FullnameLabel.Name = "FullnameLabel"
        FullnameLabel.Size = New System.Drawing.Size(52, 13)
        FullnameLabel.TabIndex = 45
        FullnameLabel.Text = "Fullname:"
        '
        'PhoneNumberLabel
        '
        PhoneNumberLabel.AutoSize = True
        PhoneNumberLabel.Location = New System.Drawing.Point(129, 280)
        PhoneNumberLabel.Name = "PhoneNumberLabel"
        PhoneNumberLabel.Size = New System.Drawing.Size(81, 13)
        PhoneNumberLabel.TabIndex = 47
        PhoneNumberLabel.Text = "Phone Number:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(129, 306)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 49
        EmailLabel.Text = "Email:"
        '
        'PreviousButton
        '
        Me.PreviousButton.BackColor = System.Drawing.Color.White
        Me.PreviousButton.ForeColor = System.Drawing.Color.Black
        Me.PreviousButton.Location = New System.Drawing.Point(566, 66)
        Me.PreviousButton.Name = "PreviousButton"
        Me.PreviousButton.Size = New System.Drawing.Size(97, 43)
        Me.PreviousButton.TabIndex = 24
        Me.PreviousButton.Text = "Previous"
        Me.PreviousButton.UseVisualStyleBackColor = False
        '
        'NextButton
        '
        Me.NextButton.BackColor = System.Drawing.Color.White
        Me.NextButton.ForeColor = System.Drawing.Color.Black
        Me.NextButton.Location = New System.Drawing.Point(566, 122)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(97, 43)
        Me.NextButton.TabIndex = 25
        Me.NextButton.Text = "Next"
        Me.NextButton.UseVisualStyleBackColor = False
        '
        'DeleteButton
        '
        Me.DeleteButton.BackColor = System.Drawing.Color.White
        Me.DeleteButton.ForeColor = System.Drawing.Color.Black
        Me.DeleteButton.Location = New System.Drawing.Point(566, 176)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(97, 43)
        Me.DeleteButton.TabIndex = 27
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = False
        '
        'SaveButton
        '
        Me.SaveButton.BackColor = System.Drawing.Color.White
        Me.SaveButton.ForeColor = System.Drawing.Color.Black
        Me.SaveButton.Location = New System.Drawing.Point(964, 550)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(97, 43)
        Me.SaveButton.TabIndex = 28
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(23, 44)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(2)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(35, 31)
        Me.BackButton.TabIndex = 30
        Me.BackButton.Text = "<"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'RegisterStaffDataSet
        '
        Me.RegisterStaffDataSet.DataSetName = "RegisterStaffDataSet"
        Me.RegisterStaffDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BusAndPassengersBindingSource
        '
        Me.BusAndPassengersBindingSource.DataMember = "BusAndPassengers"
        Me.BusAndPassengersBindingSource.DataSource = Me.RegisterStaffDataSet
        '
        'BusAndPassengersTableAdapter
        '
        Me.BusAndPassengersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BusAndPassengersTableAdapter = Me.BusAndPassengersTableAdapter
        Me.TableAdapterManager.UpdateOrder = testing.RegisterStaffDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BusAndPassengersBindingNavigator
        '
        Me.BusAndPassengersBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BusAndPassengersBindingNavigator.BindingSource = Me.BusAndPassengersBindingSource
        Me.BusAndPassengersBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BusAndPassengersBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BusAndPassengersBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BusAndPassengersBindingNavigatorSaveItem})
        Me.BusAndPassengersBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.BusAndPassengersBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BusAndPassengersBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BusAndPassengersBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BusAndPassengersBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BusAndPassengersBindingNavigator.Name = "BusAndPassengersBindingNavigator"
        Me.BusAndPassengersBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BusAndPassengersBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.BusAndPassengersBindingNavigator.TabIndex = 31
        Me.BusAndPassengersBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BusAndPassengersBindingNavigatorSaveItem
        '
        Me.BusAndPassengersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BusAndPassengersBindingNavigatorSaveItem.Image = CType(resources.GetObject("BusAndPassengersBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BusAndPassengersBindingNavigatorSaveItem.Name = "BusAndPassengersBindingNavigatorSaveItem"
        Me.BusAndPassengersBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.BusAndPassengersBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BusAndPassengersBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(218, 69)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox.TabIndex = 32
        '
        'BusNameTextBox
        '
        Me.BusNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BusAndPassengersBindingSource, "BusName", True))
        Me.BusNameTextBox.Location = New System.Drawing.Point(218, 95)
        Me.BusNameTextBox.Name = "BusNameTextBox"
        Me.BusNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BusNameTextBox.TabIndex = 34
        '
        'CurrentPlaceTextBox
        '
        Me.CurrentPlaceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BusAndPassengersBindingSource, "CurrentPlace", True))
        Me.CurrentPlaceTextBox.Location = New System.Drawing.Point(218, 121)
        Me.CurrentPlaceTextBox.Name = "CurrentPlaceTextBox"
        Me.CurrentPlaceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CurrentPlaceTextBox.TabIndex = 36
        '
        'DestinationTextBox
        '
        Me.DestinationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BusAndPassengersBindingSource, "Destination", True))
        Me.DestinationTextBox.Location = New System.Drawing.Point(218, 147)
        Me.DestinationTextBox.Name = "DestinationTextBox"
        Me.DestinationTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DestinationTextBox.TabIndex = 38
        '
        'DepartureTimeTextBox
        '
        Me.DepartureTimeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BusAndPassengersBindingSource, "DepartureTime", True))
        Me.DepartureTimeTextBox.Location = New System.Drawing.Point(218, 173)
        Me.DepartureTimeTextBox.Name = "DepartureTimeTextBox"
        Me.DepartureTimeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DepartureTimeTextBox.TabIndex = 40
        '
        'SeatNoTextBox
        '
        Me.SeatNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BusAndPassengersBindingSource, "SeatNo", True))
        Me.SeatNoTextBox.Location = New System.Drawing.Point(218, 199)
        Me.SeatNoTextBox.Name = "SeatNoTextBox"
        Me.SeatNoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SeatNoTextBox.TabIndex = 42
        '
        'SeatTextBox
        '
        Me.SeatTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BusAndPassengersBindingSource, "Seat", True))
        Me.SeatTextBox.Location = New System.Drawing.Point(218, 225)
        Me.SeatTextBox.Name = "SeatTextBox"
        Me.SeatTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SeatTextBox.TabIndex = 44
        '
        'FullnameTextBox
        '
        Me.FullnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BusAndPassengersBindingSource, "Fullname", True))
        Me.FullnameTextBox.Location = New System.Drawing.Point(218, 251)
        Me.FullnameTextBox.Name = "FullnameTextBox"
        Me.FullnameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FullnameTextBox.TabIndex = 46
        '
        'PhoneNumberTextBox
        '
        Me.PhoneNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BusAndPassengersBindingSource, "PhoneNumber", True))
        Me.PhoneNumberTextBox.Location = New System.Drawing.Point(218, 277)
        Me.PhoneNumberTextBox.Name = "PhoneNumberTextBox"
        Me.PhoneNumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PhoneNumberTextBox.TabIndex = 48
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BusAndPassengersBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(218, 303)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EmailTextBox.TabIndex = 50
        '
        'UpdateButton
        '
        Me.UpdateButton.BackColor = System.Drawing.Color.White
        Me.UpdateButton.ForeColor = System.Drawing.Color.Black
        Me.UpdateButton.Location = New System.Drawing.Point(566, 239)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(97, 43)
        Me.UpdateButton.TabIndex = 51
        Me.UpdateButton.Text = "Save"
        Me.UpdateButton.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.BusNameDataGridViewTextBoxColumn, Me.CurrentPlaceDataGridViewTextBoxColumn, Me.DestinationDataGridViewTextBoxColumn, Me.DepartureTimeDataGridViewTextBoxColumn, Me.SeatNoDataGridViewTextBoxColumn, Me.SeatDataGridViewTextBoxColumn, Me.FullnameDataGridViewTextBoxColumn, Me.PhoneNumberDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BusAndPassengersBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(343, 288)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(429, 150)
        Me.DataGridView1.TabIndex = 52
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'BusNameDataGridViewTextBoxColumn
        '
        Me.BusNameDataGridViewTextBoxColumn.DataPropertyName = "BusName"
        Me.BusNameDataGridViewTextBoxColumn.HeaderText = "BusName"
        Me.BusNameDataGridViewTextBoxColumn.Name = "BusNameDataGridViewTextBoxColumn"
        '
        'CurrentPlaceDataGridViewTextBoxColumn
        '
        Me.CurrentPlaceDataGridViewTextBoxColumn.DataPropertyName = "CurrentPlace"
        Me.CurrentPlaceDataGridViewTextBoxColumn.HeaderText = "CurrentPlace"
        Me.CurrentPlaceDataGridViewTextBoxColumn.Name = "CurrentPlaceDataGridViewTextBoxColumn"
        '
        'DestinationDataGridViewTextBoxColumn
        '
        Me.DestinationDataGridViewTextBoxColumn.DataPropertyName = "Destination"
        Me.DestinationDataGridViewTextBoxColumn.HeaderText = "Destination"
        Me.DestinationDataGridViewTextBoxColumn.Name = "DestinationDataGridViewTextBoxColumn"
        '
        'DepartureTimeDataGridViewTextBoxColumn
        '
        Me.DepartureTimeDataGridViewTextBoxColumn.DataPropertyName = "DepartureTime"
        Me.DepartureTimeDataGridViewTextBoxColumn.HeaderText = "DepartureTime"
        Me.DepartureTimeDataGridViewTextBoxColumn.Name = "DepartureTimeDataGridViewTextBoxColumn"
        '
        'SeatNoDataGridViewTextBoxColumn
        '
        Me.SeatNoDataGridViewTextBoxColumn.DataPropertyName = "SeatNo"
        Me.SeatNoDataGridViewTextBoxColumn.HeaderText = "SeatNo"
        Me.SeatNoDataGridViewTextBoxColumn.Name = "SeatNoDataGridViewTextBoxColumn"
        '
        'SeatDataGridViewTextBoxColumn
        '
        Me.SeatDataGridViewTextBoxColumn.DataPropertyName = "Seat"
        Me.SeatDataGridViewTextBoxColumn.HeaderText = "Seat"
        Me.SeatDataGridViewTextBoxColumn.Name = "SeatDataGridViewTextBoxColumn"
        '
        'FullnameDataGridViewTextBoxColumn
        '
        Me.FullnameDataGridViewTextBoxColumn.DataPropertyName = "Fullname"
        Me.FullnameDataGridViewTextBoxColumn.HeaderText = "Fullname"
        Me.FullnameDataGridViewTextBoxColumn.Name = "FullnameDataGridViewTextBoxColumn"
        '
        'PhoneNumberDataGridViewTextBoxColumn
        '
        Me.PhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber"
        Me.PhoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber"
        Me.PhoneNumberDataGridViewTextBoxColumn.Name = "PhoneNumberDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        'busAvailability
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.testing.My.Resources.Resources.bgbusgo
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.UpdateButton)
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
        Me.Controls.Add(Me.BusAndPassengersBindingNavigator)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.PreviousButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "busAvailability"
        Me.Text = "BusGo | Bus Availability"
        CType(Me.RegisterStaffDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BusAndPassengersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BusAndPassengersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BusAndPassengersBindingNavigator.ResumeLayout(False)
        Me.BusAndPassengersBindingNavigator.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PreviousButton As Button
    Friend WithEvents NextButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents BackButton As Button
    Friend WithEvents RegisterStaffDataSet As RegisterStaffDataSet
    Friend WithEvents BusAndPassengersBindingSource As BindingSource
    Friend WithEvents BusAndPassengersTableAdapter As RegisterStaffDataSetTableAdapters.BusAndPassengersTableAdapter
    Friend WithEvents TableAdapterManager As RegisterStaffDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BusAndPassengersBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BusAndPassengersBindingNavigatorSaveItem As ToolStripButton
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
    Friend WithEvents UpdateButton As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BusNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CurrentPlaceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DestinationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DepartureTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SeatNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SeatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FullnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
