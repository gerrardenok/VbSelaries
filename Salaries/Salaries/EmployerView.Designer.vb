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
        Dim СтавкаLabel As System.Windows.Forms.Label
        Dim Код_отделаLabel As System.Windows.Forms.Label
        Dim Код_специальностиLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmployerView))
        Me.SalariesDataSet = New Salaries.SalariesDataSet()
        Me.РаботникBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.РаботникTableAdapter = New Salaries.SalariesDataSetTableAdapters.РаботникTableAdapter()
        Me.TableAdapterManager = New Salaries.SalariesDataSetTableAdapters.TableAdapterManager()
        Me.РаботникBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.РаботникBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ИмяTextBox = New System.Windows.Forms.TextBox()
        Me.ФамилияTextBox = New System.Windows.Forms.TextBox()
        Me.ОтчествоTextBox = New System.Windows.Forms.TextBox()
        Me.Дата_приёмаDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ТелефонTextBox = New System.Windows.Forms.TextBox()
        Me.Номер_пасспортаTextBox = New System.Windows.Forms.TextBox()
        Me.СтажTextBox = New System.Windows.Forms.TextBox()
        Me.СтавкаTextBox = New System.Windows.Forms.TextBox()
        Me.Код_отделаTextBox = New System.Windows.Forms.TextBox()
        Me.Код_специальностиTextBox = New System.Windows.Forms.TextBox()
        ИмяLabel = New System.Windows.Forms.Label()
        ФамилияLabel = New System.Windows.Forms.Label()
        ОтчествоLabel = New System.Windows.Forms.Label()
        Дата_приёмаLabel = New System.Windows.Forms.Label()
        ТелефонLabel = New System.Windows.Forms.Label()
        Номер_пасспортаLabel = New System.Windows.Forms.Label()
        СтажLabel = New System.Windows.Forms.Label()
        СтавкаLabel = New System.Windows.Forms.Label()
        Код_отделаLabel = New System.Windows.Forms.Label()
        Код_специальностиLabel = New System.Windows.Forms.Label()
        CType(Me.SalariesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.РаботникBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.РаботникBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.РаботникBindingNavigator.SuspendLayout()
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
        'СтавкаLabel
        '
        СтавкаLabel.AutoSize = True
        СтавкаLabel.Location = New System.Drawing.Point(12, 216)
        СтавкаLabel.Name = "СтавкаLabel"
        СтавкаLabel.Size = New System.Drawing.Size(46, 13)
        СтавкаLabel.TabIndex = 17
        СтавкаLabel.Text = "Ставка:"
        '
        'Код_отделаLabel
        '
        Код_отделаLabel.AutoSize = True
        Код_отделаLabel.Location = New System.Drawing.Point(12, 242)
        Код_отделаLabel.Name = "Код_отделаLabel"
        Код_отделаLabel.Size = New System.Drawing.Size(67, 13)
        Код_отделаLabel.TabIndex = 19
        Код_отделаLabel.Text = "Код отдела:"
        '
        'Код_специальностиLabel
        '
        Код_специальностиLabel.AutoSize = True
        Код_специальностиLabel.Location = New System.Drawing.Point(12, 268)
        Код_специальностиLabel.Name = "Код_специальностиLabel"
        Код_специальностиLabel.Size = New System.Drawing.Size(109, 13)
        Код_специальностиLabel.TabIndex = 21
        Код_специальностиLabel.Text = "Код специальности:"
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
        '
        'РаботникBindingNavigator
        '
        Me.РаботникBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.РаботникBindingNavigator.BindingSource = Me.РаботникBindingSource
        Me.РаботникBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.РаботникBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.РаботникBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.РаботникBindingNavigatorSaveItem})
        Me.РаботникBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.РаботникBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.РаботникBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.РаботникBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.РаботникBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.РаботникBindingNavigator.Name = "РаботникBindingNavigator"
        Me.РаботникBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.РаботникBindingNavigator.Size = New System.Drawing.Size(593, 25)
        Me.РаботникBindingNavigator.TabIndex = 0
        Me.РаботникBindingNavigator.Text = "BindingNavigator1"
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
        'РаботникBindingNavigatorSaveItem
        '
        Me.РаботникBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.РаботникBindingNavigatorSaveItem.Image = CType(resources.GetObject("РаботникBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.РаботникBindingNavigatorSaveItem.Name = "РаботникBindingNavigatorSaveItem"
        Me.РаботникBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.РаботникBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ИмяTextBox
        '
        Me.ИмяTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.РаботникBindingSource, "Имя", True))
        Me.ИмяTextBox.Location = New System.Drawing.Point(127, 31)
        Me.ИмяTextBox.Name = "ИмяTextBox"
        Me.ИмяTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ИмяTextBox.TabIndex = 4
        '
        'ФамилияTextBox
        '
        Me.ФамилияTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.РаботникBindingSource, "Фамилия", True))
        Me.ФамилияTextBox.Location = New System.Drawing.Point(127, 57)
        Me.ФамилияTextBox.Name = "ФамилияTextBox"
        Me.ФамилияTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ФамилияTextBox.TabIndex = 6
        '
        'ОтчествоTextBox
        '
        Me.ОтчествоTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.РаботникBindingSource, "Отчество", True))
        Me.ОтчествоTextBox.Location = New System.Drawing.Point(127, 83)
        Me.ОтчествоTextBox.Name = "ОтчествоTextBox"
        Me.ОтчествоTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ОтчествоTextBox.TabIndex = 8
        '
        'Дата_приёмаDateTimePicker
        '
        Me.Дата_приёмаDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.РаботникBindingSource, "Дата_приёма", True))
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
        Me.ТелефонTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ТелефонTextBox.TabIndex = 12
        '
        'Номер_пасспортаTextBox
        '
        Me.Номер_пасспортаTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.РаботникBindingSource, "Номер_пасспорта", True))
        Me.Номер_пасспортаTextBox.Location = New System.Drawing.Point(127, 161)
        Me.Номер_пасспортаTextBox.Name = "Номер_пасспортаTextBox"
        Me.Номер_пасспортаTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Номер_пасспортаTextBox.TabIndex = 14
        '
        'СтажTextBox
        '
        Me.СтажTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.РаботникBindingSource, "Стаж", True))
        Me.СтажTextBox.Location = New System.Drawing.Point(127, 187)
        Me.СтажTextBox.Name = "СтажTextBox"
        Me.СтажTextBox.Size = New System.Drawing.Size(200, 20)
        Me.СтажTextBox.TabIndex = 16
        '
        'СтавкаTextBox
        '
        Me.СтавкаTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.РаботникBindingSource, "Ставка", True))
        Me.СтавкаTextBox.Location = New System.Drawing.Point(127, 213)
        Me.СтавкаTextBox.Name = "СтавкаTextBox"
        Me.СтавкаTextBox.Size = New System.Drawing.Size(200, 20)
        Me.СтавкаTextBox.TabIndex = 18
        '
        'Код_отделаTextBox
        '
        Me.Код_отделаTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.РаботникBindingSource, "Код_отдела", True))
        Me.Код_отделаTextBox.Location = New System.Drawing.Point(127, 239)
        Me.Код_отделаTextBox.Name = "Код_отделаTextBox"
        Me.Код_отделаTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Код_отделаTextBox.TabIndex = 20
        '
        'Код_специальностиTextBox
        '
        Me.Код_специальностиTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.РаботникBindingSource, "Код_специальности", True))
        Me.Код_специальностиTextBox.Location = New System.Drawing.Point(127, 265)
        Me.Код_специальностиTextBox.Name = "Код_специальностиTextBox"
        Me.Код_специальностиTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Код_специальностиTextBox.TabIndex = 22
        '
        'EmployerView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 573)
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
        Me.Controls.Add(СтавкаLabel)
        Me.Controls.Add(Me.СтавкаTextBox)
        Me.Controls.Add(Код_отделаLabel)
        Me.Controls.Add(Me.Код_отделаTextBox)
        Me.Controls.Add(Код_специальностиLabel)
        Me.Controls.Add(Me.Код_специальностиTextBox)
        Me.Controls.Add(Me.РаботникBindingNavigator)
        Me.Name = "EmployerView"
        Me.Text = "Работники"
        CType(Me.SalariesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.РаботникBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.РаботникBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.РаботникBindingNavigator.ResumeLayout(False)
        Me.РаботникBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SalariesDataSet As Salaries.SalariesDataSet
    Friend WithEvents РаботникBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents РаботникTableAdapter As Salaries.SalariesDataSetTableAdapters.РаботникTableAdapter
    Friend WithEvents TableAdapterManager As Salaries.SalariesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents РаботникBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents РаботникBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ИмяTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ФамилияTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ОтчествоTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Дата_приёмаDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ТелефонTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Номер_пасспортаTextBox As System.Windows.Forms.TextBox
    Friend WithEvents СтажTextBox As System.Windows.Forms.TextBox
    Friend WithEvents СтавкаTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Код_отделаTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Код_специальностиTextBox As System.Windows.Forms.TextBox
End Class
