<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalaryCRUD
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
        Dim ОкладLabel As System.Windows.Forms.Label
        Dim На_рукиLabel As System.Windows.Forms.Label
        Dim Дата_выдачиLabel As System.Windows.Forms.Label
        Dim Код_работникаLabel As System.Windows.Forms.Label
        Dim МесяцLabel1 As System.Windows.Forms.Label
        Dim ГодLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SalaryCRUD))
        Me.SalariesDataSet = New Salaries.SalariesDataSet()
        Me.ЗарплатаBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ЗарплатаTableAdapter = New Salaries.SalariesDataSetTableAdapters.ЗарплатаTableAdapter()
        Me.TableAdapterManager = New Salaries.SalariesDataSetTableAdapters.TableAdapterManager()
        Me.РаботникTableAdapter = New Salaries.SalariesDataSetTableAdapters.РаботникTableAdapter()
        Me.ЗарплатаBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.ЗарплатаBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ОкладTextBox = New System.Windows.Forms.TextBox()
        Me.На_рукиTextBox = New System.Windows.Forms.TextBox()
        Me.Дата_выдачиDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.РаботникBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.РаботникComboBox = New System.Windows.Forms.ComboBox()
        Me.FormErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.МесяцMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.ГодMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        ОкладLabel = New System.Windows.Forms.Label()
        На_рукиLabel = New System.Windows.Forms.Label()
        Дата_выдачиLabel = New System.Windows.Forms.Label()
        Код_работникаLabel = New System.Windows.Forms.Label()
        МесяцLabel1 = New System.Windows.Forms.Label()
        ГодLabel = New System.Windows.Forms.Label()
        CType(Me.SalariesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ЗарплатаBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ЗарплатаBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ЗарплатаBindingNavigator.SuspendLayout()
        CType(Me.РаботникBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ОкладLabel
        '
        ОкладLabel.AutoSize = True
        ОкладLabel.Location = New System.Drawing.Point(12, 120)
        ОкладLabel.Name = "ОкладLabel"
        ОкладLabel.Size = New System.Drawing.Size(42, 13)
        ОкладLabel.TabIndex = 3
        ОкладLabel.Text = "Оклад:"
        '
        'На_рукиLabel
        '
        На_рукиLabel.AutoSize = True
        На_рукиLabel.Location = New System.Drawing.Point(12, 146)
        На_рукиLabel.Name = "На_рукиLabel"
        На_рукиLabel.Size = New System.Drawing.Size(50, 13)
        На_рукиLabel.TabIndex = 5
        На_рукиLabel.Text = "На руки:"
        '
        'Дата_выдачиLabel
        '
        Дата_выдачиLabel.AutoSize = True
        Дата_выдачиLabel.Location = New System.Drawing.Point(12, 173)
        Дата_выдачиLabel.Name = "Дата_выдачиLabel"
        Дата_выдачиLabel.Size = New System.Drawing.Size(76, 13)
        Дата_выдачиLabel.TabIndex = 11
        Дата_выдачиLabel.Text = "Дата выдачи:"
        '
        'Код_работникаLabel
        '
        Код_работникаLabel.AutoSize = True
        Код_работникаLabel.Location = New System.Drawing.Point(12, 41)
        Код_работникаLabel.Name = "Код_работникаLabel"
        Код_работникаLabel.Size = New System.Drawing.Size(58, 13)
        Код_работникаLabel.TabIndex = 13
        Код_работникаLabel.Text = "Работник:"
        '
        'МесяцLabel1
        '
        МесяцLabel1.AutoSize = True
        МесяцLabel1.Location = New System.Drawing.Point(12, 68)
        МесяцLabel1.Name = "МесяцLabel1"
        МесяцLabel1.Size = New System.Drawing.Size(43, 13)
        МесяцLabel1.TabIndex = 13
        МесяцLabel1.Text = "Месяц:"
        '
        'ГодLabel
        '
        ГодLabel.AutoSize = True
        ГодLabel.Location = New System.Drawing.Point(12, 97)
        ГодLabel.Name = "ГодLabel"
        ГодLabel.Size = New System.Drawing.Size(28, 13)
        ГодLabel.TabIndex = 14
        ГодLabel.Text = "Год:"
        '
        'SalariesDataSet
        '
        Me.SalariesDataSet.DataSetName = "SalariesDataSet"
        Me.SalariesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ЗарплатаBindingSource
        '
        Me.ЗарплатаBindingSource.DataMember = "Зарплата"
        Me.ЗарплатаBindingSource.DataSource = Me.SalariesDataSet
        '
        'ЗарплатаTableAdapter
        '
        Me.ЗарплатаTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Salaries.SalariesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Вычет_ЗПTableAdapter = Nothing
        Me.TableAdapterManager.ЗарплатаTableAdapter = Me.ЗарплатаTableAdapter
        Me.TableAdapterManager.ОтделTableAdapter = Nothing
        Me.TableAdapterManager.Прибавка_ЗПTableAdapter = Nothing
        Me.TableAdapterManager.ПропускTableAdapter = Nothing
        Me.TableAdapterManager.РаботникTableAdapter = Me.РаботникTableAdapter
        Me.TableAdapterManager.СпециальностьTableAdapter = Nothing
        Me.TableAdapterManager.СтавкаTableAdapter = Nothing
        '
        'РаботникTableAdapter
        '
        Me.РаботникTableAdapter.ClearBeforeFill = True
        '
        'ЗарплатаBindingNavigator
        '
        Me.ЗарплатаBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ЗарплатаBindingNavigator.BindingSource = Me.ЗарплатаBindingSource
        Me.ЗарплатаBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ЗарплатаBindingNavigator.DeleteItem = Nothing
        Me.ЗарплатаBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ЗарплатаBindingNavigatorSaveItem})
        Me.ЗарплатаBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ЗарплатаBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ЗарплатаBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ЗарплатаBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ЗарплатаBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ЗарплатаBindingNavigator.Name = "ЗарплатаBindingNavigator"
        Me.ЗарплатаBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ЗарплатаBindingNavigator.Size = New System.Drawing.Size(334, 25)
        Me.ЗарплатаBindingNavigator.TabIndex = 0
        Me.ЗарплатаBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'ЗарплатаBindingNavigatorSaveItem
        '
        Me.ЗарплатаBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ЗарплатаBindingNavigatorSaveItem.Image = CType(resources.GetObject("ЗарплатаBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ЗарплатаBindingNavigatorSaveItem.Name = "ЗарплатаBindingNavigatorSaveItem"
        Me.ЗарплатаBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ЗарплатаBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ОкладTextBox
        '
        Me.ОкладTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ЗарплатаBindingSource, "Оклад", True))
        Me.ОкладTextBox.Location = New System.Drawing.Point(103, 117)
        Me.ОкладTextBox.Name = "ОкладTextBox"
        Me.ОкладTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ОкладTextBox.TabIndex = 4
        '
        'На_рукиTextBox
        '
        Me.На_рукиTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ЗарплатаBindingSource, "На_руки", True))
        Me.На_рукиTextBox.Location = New System.Drawing.Point(103, 143)
        Me.На_рукиTextBox.Name = "На_рукиTextBox"
        Me.На_рукиTextBox.Size = New System.Drawing.Size(200, 20)
        Me.На_рукиTextBox.TabIndex = 6
        '
        'Дата_выдачиDateTimePicker
        '
        Me.Дата_выдачиDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ЗарплатаBindingSource, "Дата_выдачи", True))
        Me.Дата_выдачиDateTimePicker.Location = New System.Drawing.Point(103, 169)
        Me.Дата_выдачиDateTimePicker.Name = "Дата_выдачиDateTimePicker"
        Me.Дата_выдачиDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Дата_выдачиDateTimePicker.TabIndex = 12
        '
        'РаботникBindingSource
        '
        Me.РаботникBindingSource.DataMember = "Работник"
        Me.РаботникBindingSource.DataSource = Me.SalariesDataSet
        '
        'РаботникComboBox
        '
        Me.РаботникComboBox.DataSource = Me.РаботникBindingSource
        Me.РаботникComboBox.DisplayMember = "ФИО"
        Me.РаботникComboBox.FormattingEnabled = True
        Me.РаботникComboBox.Location = New System.Drawing.Point(103, 38)
        Me.РаботникComboBox.Name = "РаботникComboBox"
        Me.РаботникComboBox.Size = New System.Drawing.Size(200, 21)
        Me.РаботникComboBox.TabIndex = 13
        Me.РаботникComboBox.ValueMember = "Код_работника"
        '
        'FormErrorProvider
        '
        Me.FormErrorProvider.ContainerControl = Me
        '
        'МесяцMaskedTextBox
        '
        Me.МесяцMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ЗарплатаBindingSource, "Месяц", True))
        Me.МесяцMaskedTextBox.Location = New System.Drawing.Point(103, 65)
        Me.МесяцMaskedTextBox.Mask = "00"
        Me.МесяцMaskedTextBox.Name = "МесяцMaskedTextBox"
        Me.МесяцMaskedTextBox.Size = New System.Drawing.Size(200, 20)
        Me.МесяцMaskedTextBox.TabIndex = 14
        '
        'ГодMaskedTextBox
        '
        Me.ГодMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ЗарплатаBindingSource, "Год", True))
        Me.ГодMaskedTextBox.Location = New System.Drawing.Point(103, 90)
        Me.ГодMaskedTextBox.Mask = "0000"
        Me.ГодMaskedTextBox.Name = "ГодMaskedTextBox"
        Me.ГодMaskedTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ГодMaskedTextBox.TabIndex = 15
        '
        'SalaryCRUD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 203)
        Me.Controls.Add(ГодLabel)
        Me.Controls.Add(Me.ГодMaskedTextBox)
        Me.Controls.Add(МесяцLabel1)
        Me.Controls.Add(Me.МесяцMaskedTextBox)
        Me.Controls.Add(Me.РаботникComboBox)
        Me.Controls.Add(ОкладLabel)
        Me.Controls.Add(Me.ОкладTextBox)
        Me.Controls.Add(На_рукиLabel)
        Me.Controls.Add(Me.На_рукиTextBox)
        Me.Controls.Add(Дата_выдачиLabel)
        Me.Controls.Add(Me.Дата_выдачиDateTimePicker)
        Me.Controls.Add(Код_работникаLabel)
        Me.Controls.Add(Me.ЗарплатаBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "SalaryCRUD"
        Me.Text = "Зарплаты"
        CType(Me.SalariesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ЗарплатаBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ЗарплатаBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ЗарплатаBindingNavigator.ResumeLayout(False)
        Me.ЗарплатаBindingNavigator.PerformLayout()
        CType(Me.РаботникBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SalariesDataSet As Salaries.SalariesDataSet
    Friend WithEvents ЗарплатаBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ЗарплатаTableAdapter As Salaries.SalariesDataSetTableAdapters.ЗарплатаTableAdapter
    Friend WithEvents TableAdapterManager As Salaries.SalariesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ЗарплатаBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ЗарплатаBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ОкладTextBox As System.Windows.Forms.TextBox
    Friend WithEvents На_рукиTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Дата_выдачиDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents РаботникTableAdapter As Salaries.SalariesDataSetTableAdapters.РаботникTableAdapter
    Friend WithEvents РаботникBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents РаботникComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents FormErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents ГодMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents МесяцMaskedTextBox As System.Windows.Forms.MaskedTextBox
End Class
