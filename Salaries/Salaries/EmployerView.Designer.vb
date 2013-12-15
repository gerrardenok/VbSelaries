<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployerView
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
        Dim ИмяLabel As System.Windows.Forms.Label
        Dim ФамилияLabel As System.Windows.Forms.Label
        Dim ОтчествоLabel As System.Windows.Forms.Label
        Dim Дата_приёмаLabel As System.Windows.Forms.Label
        Dim ТелефонLabel As System.Windows.Forms.Label
        Dim Номер_пасспортаLabel As System.Windows.Forms.Label
        Dim СтажLabel As System.Windows.Forms.Label
        Dim НазваниеLabel As System.Windows.Forms.Label
        Dim НазваниеLabel1 As System.Windows.Forms.Label
        Dim НазваниеLabel2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmployerView))
        Me.SalariesDataSet = New Salaries.SalariesDataSet()
        Me.РаботникBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.РаботникTableAdapter = New Salaries.SalariesDataSetTableAdapters.РаботникTableAdapter()
        Me.TableAdapterManager = New Salaries.SalariesDataSetTableAdapters.TableAdapterManager()
        Me.РаботникBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ИмяTextBox = New System.Windows.Forms.TextBox()
        Me.ФамилияTextBox = New System.Windows.Forms.TextBox()
        Me.ОтчествоTextBox = New System.Windows.Forms.TextBox()
        Me.Дата_приёмаDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ТелефонTextBox = New System.Windows.Forms.TextBox()
        Me.Номер_пасспортаTextBox = New System.Windows.Forms.TextBox()
        Me.СтажTextBox = New System.Windows.Forms.TextBox()
        Me.ЗарплатаBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ЗарплатаTableAdapter = New Salaries.SalariesDataSetTableAdapters.ЗарплатаTableAdapter()
        Me.ЗарплатаDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ПропускBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ПропускTableAdapter = New Salaries.SalariesDataSetTableAdapters.ПропускTableAdapter()
        Me.ПропускDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ОтделBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ОтделTableAdapter = New Salaries.SalariesDataSetTableAdapters.ОтделTableAdapter()
        Me.НазваниеTextBox = New System.Windows.Forms.TextBox()
        Me.СпециальностьBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.СпециальностьTableAdapter = New Salaries.SalariesDataSetTableAdapters.СпециальностьTableAdapter()
        Me.НазваниеTextBox1 = New System.Windows.Forms.TextBox()
        Me.СтавкаBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.СтавкаTableAdapter = New Salaries.SalariesDataSetTableAdapters.СтавкаTableAdapter()
        Me.НазваниеTextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        ИмяLabel = New System.Windows.Forms.Label()
        ФамилияLabel = New System.Windows.Forms.Label()
        ОтчествоLabel = New System.Windows.Forms.Label()
        Дата_приёмаLabel = New System.Windows.Forms.Label()
        ТелефонLabel = New System.Windows.Forms.Label()
        Номер_пасспортаLabel = New System.Windows.Forms.Label()
        СтажLabel = New System.Windows.Forms.Label()
        НазваниеLabel = New System.Windows.Forms.Label()
        НазваниеLabel1 = New System.Windows.Forms.Label()
        НазваниеLabel2 = New System.Windows.Forms.Label()
        CType(Me.SalariesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.РаботникBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.РаботникBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.РаботникBindingNavigator.SuspendLayout()
        CType(Me.ЗарплатаBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ЗарплатаDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ПропускBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ПропускDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ОтделBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.СпециальностьBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.СтавкаBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ИмяLabel
        '
        ИмяLabel.AutoSize = True
        ИмяLabel.Location = New System.Drawing.Point(12, 34)
        ИмяLabel.Name = "ИмяLabel"
        ИмяLabel.Size = New System.Drawing.Size(32, 13)
        ИмяLabel.TabIndex = 3
        ИмяLabel.Text = "Имя:"
        '
        'ФамилияLabel
        '
        ФамилияLabel.AutoSize = True
        ФамилияLabel.Location = New System.Drawing.Point(12, 60)
        ФамилияLabel.Name = "ФамилияLabel"
        ФамилияLabel.Size = New System.Drawing.Size(59, 13)
        ФамилияLabel.TabIndex = 5
        ФамилияLabel.Text = "Фамилия:"
        '
        'ОтчествоLabel
        '
        ОтчествоLabel.AutoSize = True
        ОтчествоLabel.Location = New System.Drawing.Point(12, 86)
        ОтчествоLabel.Name = "ОтчествоLabel"
        ОтчествоLabel.Size = New System.Drawing.Size(57, 13)
        ОтчествоLabel.TabIndex = 7
        ОтчествоLabel.Text = "Отчество:"
        '
        'Дата_приёмаLabel
        '
        Дата_приёмаLabel.AutoSize = True
        Дата_приёмаLabel.Location = New System.Drawing.Point(12, 113)
        Дата_приёмаLabel.Name = "Дата_приёмаLabel"
        Дата_приёмаLabel.Size = New System.Drawing.Size(77, 13)
        Дата_приёмаLabel.TabIndex = 9
        Дата_приёмаLabel.Text = "Дата приёма:"
        '
        'ТелефонLabel
        '
        ТелефонLabel.AutoSize = True
        ТелефонLabel.Location = New System.Drawing.Point(12, 138)
        ТелефонLabel.Name = "ТелефонLabel"
        ТелефонLabel.Size = New System.Drawing.Size(55, 13)
        ТелефонLabel.TabIndex = 11
        ТелефонLabel.Text = "Телефон:"
        '
        'Номер_пасспортаLabel
        '
        Номер_пасспортаLabel.AutoSize = True
        Номер_пасспортаLabel.Location = New System.Drawing.Point(12, 164)
        Номер_пасспортаLabel.Name = "Номер_пасспортаLabel"
        Номер_пасспортаLabel.Size = New System.Drawing.Size(100, 13)
        Номер_пасспортаLabel.TabIndex = 13
        Номер_пасспортаLabel.Text = "Номер пасспорта:"
        '
        'СтажLabel
        '
        СтажLabel.AutoSize = True
        СтажLabel.Location = New System.Drawing.Point(12, 190)
        СтажLabel.Name = "СтажLabel"
        СтажLabel.Size = New System.Drawing.Size(36, 13)
        СтажLabel.TabIndex = 15
        СтажLabel.Text = "Стаж:"
        '
        'НазваниеLabel
        '
        НазваниеLabel.AutoSize = True
        НазваниеLabel.Location = New System.Drawing.Point(13, 242)
        НазваниеLabel.Name = "НазваниеLabel"
        НазваниеLabel.Size = New System.Drawing.Size(41, 13)
        НазваниеLabel.TabIndex = 24
        НазваниеLabel.Text = "Отдел:"
        '
        'НазваниеLabel1
        '
        НазваниеLabel1.AutoSize = True
        НазваниеLabel1.Location = New System.Drawing.Point(12, 272)
        НазваниеLabel1.Name = "НазваниеLabel1"
        НазваниеLabel1.Size = New System.Drawing.Size(88, 13)
        НазваниеLabel1.TabIndex = 25
        НазваниеLabel1.Text = "Специальность:"
        '
        'НазваниеLabel2
        '
        НазваниеLabel2.AutoSize = True
        НазваниеLabel2.Location = New System.Drawing.Point(12, 215)
        НазваниеLabel2.Name = "НазваниеLabel2"
        НазваниеLabel2.Size = New System.Drawing.Size(46, 13)
        НазваниеLabel2.TabIndex = 26
        НазваниеLabel2.Text = "Ставка:"
        '
        'SalariesDataSet
        '
        Me.SalariesDataSet.DataSetName = "SalariesDataSet"
        Me.SalariesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'РаботникBindingSource
        '
        Me.РаботникBindingSource.DataMember = "Работник"
        Me.РаботникBindingSource.DataSource = Me.SalariesDataSet
        '
        'РаботникTableAdapter
        '
        Me.РаботникTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Salaries.SalariesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Вычет_ЗПTableAdapter = Nothing
        Me.TableAdapterManager.ЗарплатаTableAdapter = Nothing
        Me.TableAdapterManager.ОтделTableAdapter = Nothing
        Me.TableAdapterManager.Прибавка_ЗПTableAdapter = Nothing
        Me.TableAdapterManager.ПропускTableAdapter = Nothing
        Me.TableAdapterManager.РаботникTableAdapter = Me.РаботникTableAdapter
        Me.TableAdapterManager.СпециальностьTableAdapter = Nothing
        Me.TableAdapterManager.СтавкаTableAdapter = Nothing
        '
        'РаботникBindingNavigator
        '
        Me.РаботникBindingNavigator.AddNewItem = Nothing
        Me.РаботникBindingNavigator.BindingSource = Me.РаботникBindingSource
        Me.РаботникBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.РаботникBindingNavigator.DeleteItem = Nothing
        Me.РаботникBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripSeparator1, Me.ToolStripButton4})
        Me.РаботникBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.РаботникBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.РаботникBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.РаботникBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.РаботникBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.РаботникBindingNavigator.Name = "РаботникBindingNavigator"
        Me.РаботникBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.РаботникBindingNavigator.Size = New System.Drawing.Size(784, 25)
        Me.РаботникBindingNavigator.TabIndex = 0
        Me.РаботникBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(63, 22)
        Me.ToolStripButton1.Text = "Добавить"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(91, 22)
        Me.ToolStripButton2.Text = "Редактировать"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(43, 22)
        Me.ToolStripButton3.Text = "Отчёт"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(56, 22)
        Me.ToolStripButton4.Text = "Уволить"
        '
        'ИмяTextBox
        '
        Me.ИмяTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.РаботникBindingSource, "Имя", True))
        Me.ИмяTextBox.Location = New System.Drawing.Point(127, 31)
        Me.ИмяTextBox.Name = "ИмяTextBox"
        Me.ИмяTextBox.ReadOnly = True
        Me.ИмяTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ИмяTextBox.TabIndex = 4
        '
        'ФамилияTextBox
        '
        Me.ФамилияTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.РаботникBindingSource, "Фамилия", True))
        Me.ФамилияTextBox.Location = New System.Drawing.Point(127, 57)
        Me.ФамилияTextBox.Name = "ФамилияTextBox"
        Me.ФамилияTextBox.ReadOnly = True
        Me.ФамилияTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ФамилияTextBox.TabIndex = 6
        '
        'ОтчествоTextBox
        '
        Me.ОтчествоTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.РаботникBindingSource, "Отчество", True))
        Me.ОтчествоTextBox.Location = New System.Drawing.Point(127, 83)
        Me.ОтчествоTextBox.Name = "ОтчествоTextBox"
        Me.ОтчествоTextBox.ReadOnly = True
        Me.ОтчествоTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ОтчествоTextBox.TabIndex = 8
        '
        'Дата_приёмаDateTimePicker
        '
        Me.Дата_приёмаDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.РаботникBindingSource, "Дата_приёма", True))
        Me.Дата_приёмаDateTimePicker.Enabled = False
        Me.Дата_приёмаDateTimePicker.Location = New System.Drawing.Point(127, 109)
        Me.Дата_приёмаDateTimePicker.Name = "Дата_приёмаDateTimePicker"
        Me.Дата_приёмаDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Дата_приёмаDateTimePicker.TabIndex = 10
        '
        'ТелефонTextBox
        '
        Me.ТелефонTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.РаботникBindingSource, "Телефон", True))
        Me.ТелефонTextBox.Location = New System.Drawing.Point(127, 135)
        Me.ТелефонTextBox.Name = "ТелефонTextBox"
        Me.ТелефонTextBox.ReadOnly = True
        Me.ТелефонTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ТелефонTextBox.TabIndex = 12
        '
        'Номер_пасспортаTextBox
        '
        Me.Номер_пасспортаTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.РаботникBindingSource, "Номер_пасспорта", True))
        Me.Номер_пасспортаTextBox.Location = New System.Drawing.Point(127, 161)
        Me.Номер_пасспортаTextBox.Name = "Номер_пасспортаTextBox"
        Me.Номер_пасспортаTextBox.ReadOnly = True
        Me.Номер_пасспортаTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Номер_пасспортаTextBox.TabIndex = 14
        '
        'СтажTextBox
        '
        Me.СтажTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.РаботникBindingSource, "Стаж", True))
        Me.СтажTextBox.Location = New System.Drawing.Point(127, 187)
        Me.СтажTextBox.Name = "СтажTextBox"
        Me.СтажTextBox.ReadOnly = True
        Me.СтажTextBox.Size = New System.Drawing.Size(200, 20)
        Me.СтажTextBox.TabIndex = 16
        '
        'ЗарплатаBindingSource
        '
        Me.ЗарплатаBindingSource.DataMember = "FK_Зарплата_Работник"
        Me.ЗарплатаBindingSource.DataSource = Me.РаботникBindingSource
        '
        'ЗарплатаTableAdapter
        '
        Me.ЗарплатаTableAdapter.ClearBeforeFill = True
        '
        'ЗарплатаDataGridView
        '
        Me.ЗарплатаDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ЗарплатаDataGridView.AutoGenerateColumns = False
        Me.ЗарплатаDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ЗарплатаDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.ЗарплатаDataGridView.DataSource = Me.ЗарплатаBindingSource
        Me.ЗарплатаDataGridView.Location = New System.Drawing.Point(12, 319)
        Me.ЗарплатаDataGridView.Name = "ЗарплатаDataGridView"
        Me.ЗарплатаDataGridView.ReadOnly = True
        Me.ЗарплатаDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ЗарплатаDataGridView.Size = New System.Drawing.Size(760, 273)
        Me.ЗарплатаDataGridView.TabIndex = 24
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Месяц"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Месяц"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Оклад"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Оклад"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "На_руки"
        Me.DataGridViewTextBoxColumn3.HeaderText = "На_руки"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Год"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Год"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Код_зарплаты"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Код_зарплаты"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Дата_выдачи"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Дата_выдачи"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Код_работника"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Код_работника"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'ПропускBindingSource
        '
        Me.ПропускBindingSource.DataMember = "FK_Пропуск_Работник"
        Me.ПропускBindingSource.DataSource = Me.РаботникBindingSource
        '
        'ПропускTableAdapter
        '
        Me.ПропускTableAdapter.ClearBeforeFill = True
        '
        'ПропускDataGridView
        '
        Me.ПропускDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ПропускDataGridView.AutoGenerateColumns = False
        Me.ПропускDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ПропускDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13})
        Me.ПропускDataGridView.DataSource = Me.ПропускBindingSource
        Me.ПропускDataGridView.Location = New System.Drawing.Point(345, 57)
        Me.ПропускDataGridView.Name = "ПропускDataGridView"
        Me.ПропускDataGridView.ReadOnly = True
        Me.ПропускDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ПропускDataGridView.Size = New System.Drawing.Size(427, 228)
        Me.ПропускDataGridView.TabIndex = 24
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Код_пропуска"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Код_пропуска"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Причина"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Причина"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Оплата"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Оплата"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Код_работника"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Код_работника"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Месяц"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Месяц"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Год"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Год"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'ОтделBindingSource
        '
        Me.ОтделBindingSource.DataMember = "Работник_Отдел"
        Me.ОтделBindingSource.DataSource = Me.РаботникBindingSource
        '
        'ОтделTableAdapter
        '
        Me.ОтделTableAdapter.ClearBeforeFill = True
        '
        'НазваниеTextBox
        '
        Me.НазваниеTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ОтделBindingSource, "Название", True))
        Me.НазваниеTextBox.Location = New System.Drawing.Point(127, 239)
        Me.НазваниеTextBox.Name = "НазваниеTextBox"
        Me.НазваниеTextBox.ReadOnly = True
        Me.НазваниеTextBox.Size = New System.Drawing.Size(200, 20)
        Me.НазваниеTextBox.TabIndex = 25
        '
        'СпециальностьBindingSource
        '
        Me.СпециальностьBindingSource.DataMember = "Работник_Специальность"
        Me.СпециальностьBindingSource.DataSource = Me.РаботникBindingSource
        '
        'СпециальностьTableAdapter
        '
        Me.СпециальностьTableAdapter.ClearBeforeFill = True
        '
        'НазваниеTextBox1
        '
        Me.НазваниеTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.СпециальностьBindingSource, "Название", True))
        Me.НазваниеTextBox1.Location = New System.Drawing.Point(127, 267)
        Me.НазваниеTextBox1.Name = "НазваниеTextBox1"
        Me.НазваниеTextBox1.ReadOnly = True
        Me.НазваниеTextBox1.Size = New System.Drawing.Size(200, 20)
        Me.НазваниеTextBox1.TabIndex = 26
        '
        'СтавкаBindingSource
        '
        Me.СтавкаBindingSource.DataMember = "Работник_Ставка"
        Me.СтавкаBindingSource.DataSource = Me.РаботникBindingSource
        '
        'СтавкаTableAdapter
        '
        Me.СтавкаTableAdapter.ClearBeforeFill = True
        '
        'НазваниеTextBox2
        '
        Me.НазваниеTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.СтавкаBindingSource, "Название", True))
        Me.НазваниеTextBox2.Location = New System.Drawing.Point(127, 212)
        Me.НазваниеTextBox2.Name = "НазваниеTextBox2"
        Me.НазваниеTextBox2.ReadOnly = True
        Me.НазваниеTextBox2.Size = New System.Drawing.Size(200, 20)
        Me.НазваниеTextBox2.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Chocolate
        Me.Label3.Location = New System.Drawing.Point(340, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 27)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Пропуски:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Chocolate
        Me.Label1.Location = New System.Drawing.Point(7, 289)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 27)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Зарплаты:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EmployerView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 604)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(НазваниеLabel2)
        Me.Controls.Add(Me.НазваниеTextBox2)
        Me.Controls.Add(НазваниеLabel1)
        Me.Controls.Add(Me.НазваниеTextBox1)
        Me.Controls.Add(НазваниеLabel)
        Me.Controls.Add(Me.НазваниеTextBox)
        Me.Controls.Add(Me.ПропускDataGridView)
        Me.Controls.Add(Me.ЗарплатаDataGridView)
        Me.Controls.Add(ИмяLabel)
        Me.Controls.Add(Me.ИмяTextBox)
        Me.Controls.Add(ФамилияLabel)
        Me.Controls.Add(Me.ФамилияTextBox)
        Me.Controls.Add(ОтчествоLabel)
        Me.Controls.Add(Me.ОтчествоTextBox)
        Me.Controls.Add(Дата_приёмаLabel)
        Me.Controls.Add(Me.Дата_приёмаDateTimePicker)
        Me.Controls.Add(ТелефонLabel)
        Me.Controls.Add(Me.ТелефонTextBox)
        Me.Controls.Add(Номер_пасспортаLabel)
        Me.Controls.Add(Me.Номер_пасспортаTextBox)
        Me.Controls.Add(СтажLabel)
        Me.Controls.Add(Me.СтажTextBox)
        Me.Controls.Add(Me.РаботникBindingNavigator)
        Me.Name = "EmployerView"
        Me.Text = "Работники"
        CType(Me.SalariesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.РаботникBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.РаботникBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.РаботникBindingNavigator.ResumeLayout(False)
        Me.РаботникBindingNavigator.PerformLayout()
        CType(Me.ЗарплатаBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ЗарплатаDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ПропускBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ПропускDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ОтделBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.СпециальностьBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.СтавкаBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SalariesDataSet As Salaries.SalariesDataSet
    Friend WithEvents РаботникBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents РаботникTableAdapter As Salaries.SalariesDataSetTableAdapters.РаботникTableAdapter
    Friend WithEvents TableAdapterManager As Salaries.SalariesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents РаботникBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ИмяTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ФамилияTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ОтчествоTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Дата_приёмаDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ТелефонTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Номер_пасспортаTextBox As System.Windows.Forms.TextBox
    Friend WithEvents СтажTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ЗарплатаBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ЗарплатаTableAdapter As Salaries.SalariesDataSetTableAdapters.ЗарплатаTableAdapter
    Friend WithEvents ЗарплатаDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ПропускBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ПропускTableAdapter As Salaries.SalariesDataSetTableAdapters.ПропускTableAdapter
    Friend WithEvents ПропускDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ОтделBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ОтделTableAdapter As Salaries.SalariesDataSetTableAdapters.ОтделTableAdapter
    Friend WithEvents НазваниеTextBox As System.Windows.Forms.TextBox
    Friend WithEvents СпециальностьBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents СпециальностьTableAdapter As Salaries.SalariesDataSetTableAdapters.СпециальностьTableAdapter
    Friend WithEvents НазваниеTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents СтавкаBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents СтавкаTableAdapter As Salaries.SalariesDataSetTableAdapters.СтавкаTableAdapter
    Friend WithEvents НазваниеTextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
