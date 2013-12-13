<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RFPIncreaseCRUD
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
        Dim Код_прибавкиLabel As System.Windows.Forms.Label
        Dim НазваниеLabel As System.Windows.Forms.Label
        Dim Сумма_прибавкиLabel As System.Windows.Forms.Label
        Dim Код_зарплатыLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RFPIncreaseCRUD))
        Me.SalariesDataSet = New Salaries.SalariesDataSet()
        Me.Прибавка_ЗПBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Прибавка_ЗПTableAdapter = New Salaries.SalariesDataSetTableAdapters.Прибавка_ЗПTableAdapter()
        Me.TableAdapterManager = New Salaries.SalariesDataSetTableAdapters.TableAdapterManager()
        Me.ЗарплатаTableAdapter = New Salaries.SalariesDataSetTableAdapters.ЗарплатаTableAdapter()
        Me.РаботникTableAdapter = New Salaries.SalariesDataSetTableAdapters.РаботникTableAdapter()
        Me.Прибавка_ЗПBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Прибавка_ЗПBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.НазваниеTextBox = New System.Windows.Forms.TextBox()
        Me.Сумма_прибавкиTextBox = New System.Windows.Forms.TextBox()
        Me.РаботникBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.РаботникComboBox = New System.Windows.Forms.ComboBox()
        Me.ЗарплатаBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ЗарплатаComboBox = New System.Windows.Forms.ComboBox()
        Me.FormErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Код_прибавкиLabel = New System.Windows.Forms.Label()
        НазваниеLabel = New System.Windows.Forms.Label()
        Сумма_прибавкиLabel = New System.Windows.Forms.Label()
        Код_зарплатыLabel = New System.Windows.Forms.Label()
        CType(Me.SalariesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Прибавка_ЗПBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Прибавка_ЗПBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Прибавка_ЗПBindingNavigator.SuspendLayout()
        CType(Me.РаботникBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ЗарплатаBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Код_прибавкиLabel
        '
        Код_прибавкиLabel.AutoSize = True
        Код_прибавкиLabel.Location = New System.Drawing.Point(13, 43)
        Код_прибавкиLabel.Name = "Код_прибавкиLabel"
        Код_прибавкиLabel.Size = New System.Drawing.Size(58, 13)
        Код_прибавкиLabel.TabIndex = 1
        Код_прибавкиLabel.Text = "Работник:"
        '
        'НазваниеLabel
        '
        НазваниеLabel.AutoSize = True
        НазваниеLabel.Location = New System.Drawing.Point(15, 104)
        НазваниеLabel.Name = "НазваниеLabel"
        НазваниеLabel.Size = New System.Drawing.Size(60, 13)
        НазваниеLabel.TabIndex = 3
        НазваниеLabel.Text = "Название:"
        '
        'Сумма_прибавкиLabel
        '
        Сумма_прибавкиLabel.AutoSize = True
        Сумма_прибавкиLabel.Location = New System.Drawing.Point(15, 130)
        Сумма_прибавкиLabel.Name = "Сумма_прибавкиLabel"
        Сумма_прибавкиLabel.Size = New System.Drawing.Size(95, 13)
        Сумма_прибавкиLabel.TabIndex = 5
        Сумма_прибавкиLabel.Text = "Сумма прибавки:"
        '
        'Код_зарплатыLabel
        '
        Код_зарплатыLabel.AutoSize = True
        Код_зарплатыLabel.Location = New System.Drawing.Point(12, 74)
        Код_зарплатыLabel.Name = "Код_зарплатыLabel"
        Код_зарплатыLabel.Size = New System.Drawing.Size(58, 13)
        Код_зарплатыLabel.TabIndex = 7
        Код_зарплатыLabel.Text = "Зарплата:"
        '
        'SalariesDataSet
        '
        Me.SalariesDataSet.DataSetName = "SalariesDataSet"
        Me.SalariesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Прибавка_ЗПBindingSource
        '
        Me.Прибавка_ЗПBindingSource.DataMember = "Прибавка_ЗП"
        Me.Прибавка_ЗПBindingSource.DataSource = Me.SalariesDataSet
        '
        'Прибавка_ЗПTableAdapter
        '
        Me.Прибавка_ЗПTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Salaries.SalariesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Вычет_ЗПTableAdapter = Nothing
        Me.TableAdapterManager.ЗарплатаTableAdapter = Me.ЗарплатаTableAdapter
        Me.TableAdapterManager.ОтделTableAdapter = Nothing
        Me.TableAdapterManager.Прибавка_ЗПTableAdapter = Me.Прибавка_ЗПTableAdapter
        Me.TableAdapterManager.ПропускTableAdapter = Nothing
        Me.TableAdapterManager.РаботникTableAdapter = Me.РаботникTableAdapter
        Me.TableAdapterManager.СпециальностьTableAdapter = Nothing
        Me.TableAdapterManager.СтавкаTableAdapter = Nothing
        '
        'ЗарплатаTableAdapter
        '
        Me.ЗарплатаTableAdapter.ClearBeforeFill = True
        '
        'РаботникTableAdapter
        '
        Me.РаботникTableAdapter.ClearBeforeFill = True
        '
        'Прибавка_ЗПBindingNavigator
        '
        Me.Прибавка_ЗПBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Прибавка_ЗПBindingNavigator.BindingSource = Me.Прибавка_ЗПBindingSource
        Me.Прибавка_ЗПBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Прибавка_ЗПBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Прибавка_ЗПBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Прибавка_ЗПBindingNavigatorSaveItem})
        Me.Прибавка_ЗПBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Прибавка_ЗПBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Прибавка_ЗПBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Прибавка_ЗПBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Прибавка_ЗПBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Прибавка_ЗПBindingNavigator.Name = "Прибавка_ЗПBindingNavigator"
        Me.Прибавка_ЗПBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Прибавка_ЗПBindingNavigator.Size = New System.Drawing.Size(454, 25)
        Me.Прибавка_ЗПBindingNavigator.TabIndex = 0
        Me.Прибавка_ЗПBindingNavigator.Text = "BindingNavigator1"
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
        'Прибавка_ЗПBindingNavigatorSaveItem
        '
        Me.Прибавка_ЗПBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Прибавка_ЗПBindingNavigatorSaveItem.Image = CType(resources.GetObject("Прибавка_ЗПBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Прибавка_ЗПBindingNavigatorSaveItem.Name = "Прибавка_ЗПBindingNavigatorSaveItem"
        Me.Прибавка_ЗПBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Прибавка_ЗПBindingNavigatorSaveItem.Text = "Save Data"
        '
        'НазваниеTextBox
        '
        Me.НазваниеTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Прибавка_ЗПBindingSource, "Название", True))
        Me.НазваниеTextBox.Location = New System.Drawing.Point(116, 101)
        Me.НазваниеTextBox.Name = "НазваниеTextBox"
        Me.НазваниеTextBox.Size = New System.Drawing.Size(300, 20)
        Me.НазваниеTextBox.TabIndex = 4
        '
        'Сумма_прибавкиTextBox
        '
        Me.Сумма_прибавкиTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Прибавка_ЗПBindingSource, "Сумма_прибавки", True))
        Me.Сумма_прибавкиTextBox.Location = New System.Drawing.Point(116, 127)
        Me.Сумма_прибавкиTextBox.Name = "Сумма_прибавкиTextBox"
        Me.Сумма_прибавкиTextBox.Size = New System.Drawing.Size(300, 20)
        Me.Сумма_прибавкиTextBox.TabIndex = 6
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
        Me.РаботникComboBox.Location = New System.Drawing.Point(116, 43)
        Me.РаботникComboBox.Name = "РаботникComboBox"
        Me.РаботникComboBox.Size = New System.Drawing.Size(300, 21)
        Me.РаботникComboBox.TabIndex = 7
        Me.РаботникComboBox.ValueMember = "Код_работника"
        '
        'ЗарплатаBindingSource
        '
        Me.ЗарплатаBindingSource.DataMember = "Зарплата"
        Me.ЗарплатаBindingSource.DataSource = Me.SalariesDataSet
        '
        'ЗарплатаComboBox
        '
        Me.ЗарплатаComboBox.DataSource = Me.ЗарплатаBindingSource
        Me.ЗарплатаComboBox.DisplayMember = "Displyed"
        Me.ЗарплатаComboBox.FormattingEnabled = True
        Me.ЗарплатаComboBox.Location = New System.Drawing.Point(116, 71)
        Me.ЗарплатаComboBox.Name = "ЗарплатаComboBox"
        Me.ЗарплатаComboBox.Size = New System.Drawing.Size(300, 21)
        Me.ЗарплатаComboBox.TabIndex = 8
        Me.ЗарплатаComboBox.ValueMember = "Код_зарплаты"
        '
        'FormErrorProvider
        '
        Me.FormErrorProvider.ContainerControl = Me
        '
        'RFPIncreaseCRUD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 171)
        Me.Controls.Add(Me.ЗарплатаComboBox)
        Me.Controls.Add(Me.РаботникComboBox)
        Me.Controls.Add(Код_прибавкиLabel)
        Me.Controls.Add(НазваниеLabel)
        Me.Controls.Add(Me.НазваниеTextBox)
        Me.Controls.Add(Сумма_прибавкиLabel)
        Me.Controls.Add(Me.Сумма_прибавкиTextBox)
        Me.Controls.Add(Код_зарплатыLabel)
        Me.Controls.Add(Me.Прибавка_ЗПBindingNavigator)
        Me.Name = "RFPIncreaseCRUD"
        Me.Text = "Прибавка к ЗП"
        CType(Me.SalariesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Прибавка_ЗПBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Прибавка_ЗПBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Прибавка_ЗПBindingNavigator.ResumeLayout(False)
        Me.Прибавка_ЗПBindingNavigator.PerformLayout()
        CType(Me.РаботникBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ЗарплатаBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SalariesDataSet As Salaries.SalariesDataSet
    Friend WithEvents Прибавка_ЗПBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Прибавка_ЗПTableAdapter As Salaries.SalariesDataSetTableAdapters.Прибавка_ЗПTableAdapter
    Friend WithEvents TableAdapterManager As Salaries.SalariesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Прибавка_ЗПBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Прибавка_ЗПBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents РаботникTableAdapter As Salaries.SalariesDataSetTableAdapters.РаботникTableAdapter
    Friend WithEvents НазваниеTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Сумма_прибавкиTextBox As System.Windows.Forms.TextBox
    Friend WithEvents РаботникBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ЗарплатаTableAdapter As Salaries.SalariesDataSetTableAdapters.ЗарплатаTableAdapter
    Friend WithEvents РаботникComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ЗарплатаBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ЗарплатаComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents FormErrorProvider As System.Windows.Forms.ErrorProvider
End Class
