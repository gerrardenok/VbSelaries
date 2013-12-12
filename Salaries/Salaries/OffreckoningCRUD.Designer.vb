<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OffreckoningCRUD
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
        Dim НазваниеLabel As System.Windows.Forms.Label
        Dim Сумма_вычетаLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OffreckoningCRUD))
        Me.SalariesDataSet = New Salaries.SalariesDataSet()
        Me.Вычет_ЗПBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Вычет_ЗПTableAdapter = New Salaries.SalariesDataSetTableAdapters.Вычет_ЗПTableAdapter()
        Me.TableAdapterManager = New Salaries.SalariesDataSetTableAdapters.TableAdapterManager()
        Me.Вычет_ЗПBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Вычет_ЗПBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.НазваниеTextBox = New System.Windows.Forms.TextBox()
        Me.Сумма_вычетаTextBox = New System.Windows.Forms.TextBox()
        Me.РаботникBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.РаботникTableAdapter = New Salaries.SalariesDataSetTableAdapters.РаботникTableAdapter()
        Me.РаботникComboBox = New System.Windows.Forms.ComboBox()
        Me.ЗарплатаBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ЗарплатаTableAdapter = New Salaries.SalariesDataSetTableAdapters.ЗарплатаTableAdapter()
        Me.ЗарплатаComboBox = New System.Windows.Forms.ComboBox()
        НазваниеLabel = New System.Windows.Forms.Label()
        Сумма_вычетаLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.SalariesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Вычет_ЗПBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Вычет_ЗПBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Вычет_ЗПBindingNavigator.SuspendLayout()
        CType(Me.РаботникBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ЗарплатаBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'НазваниеLabel
        '
        НазваниеLabel.AutoSize = True
        НазваниеLabel.Location = New System.Drawing.Point(8, 90)
        НазваниеLabel.Name = "НазваниеLabel"
        НазваниеLabel.Size = New System.Drawing.Size(60, 13)
        НазваниеLabel.TabIndex = 3
        НазваниеLabel.Text = "Название:"
        '
        'Сумма_вычетаLabel
        '
        Сумма_вычетаLabel.AutoSize = True
        Сумма_вычетаLabel.Location = New System.Drawing.Point(8, 116)
        Сумма_вычетаLabel.Name = "Сумма_вычетаLabel"
        Сумма_вычетаLabel.Size = New System.Drawing.Size(83, 13)
        Сумма_вычетаLabel.TabIndex = 5
        Сумма_вычетаLabel.Text = "Сумма вычета:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(8, 31)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(58, 13)
        Label1.TabIndex = 7
        Label1.Text = "Работник:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(10, 58)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(55, 13)
        Label2.TabIndex = 8
        Label2.Text = "Зарплата"
        '
        'SalariesDataSet
        '
        Me.SalariesDataSet.DataSetName = "SalariesDataSet"
        Me.SalariesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Вычет_ЗПBindingSource
        '
        Me.Вычет_ЗПBindingSource.DataMember = "Вычет_ЗП"
        Me.Вычет_ЗПBindingSource.DataSource = Me.SalariesDataSet
        '
        'Вычет_ЗПTableAdapter
        '
        Me.Вычет_ЗПTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Salaries.SalariesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Вычет_ЗПTableAdapter = Me.Вычет_ЗПTableAdapter
        Me.TableAdapterManager.ЗарплатаTableAdapter = Nothing
        Me.TableAdapterManager.ОтделTableAdapter = Nothing
        Me.TableAdapterManager.Прибавка_ЗПTableAdapter = Nothing
        Me.TableAdapterManager.ПропускTableAdapter = Nothing
        Me.TableAdapterManager.РаботникTableAdapter = Nothing
        Me.TableAdapterManager.СпециальностьTableAdapter = Nothing
        Me.TableAdapterManager.СтавкаTableAdapter = Nothing
        '
        'Вычет_ЗПBindingNavigator
        '
        Me.Вычет_ЗПBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Вычет_ЗПBindingNavigator.BindingSource = Me.Вычет_ЗПBindingSource
        Me.Вычет_ЗПBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Вычет_ЗПBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Вычет_ЗПBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Вычет_ЗПBindingNavigatorSaveItem})
        Me.Вычет_ЗПBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Вычет_ЗПBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Вычет_ЗПBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Вычет_ЗПBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Вычет_ЗПBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Вычет_ЗПBindingNavigator.Name = "Вычет_ЗПBindingNavigator"
        Me.Вычет_ЗПBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Вычет_ЗПBindingNavigator.Size = New System.Drawing.Size(490, 25)
        Me.Вычет_ЗПBindingNavigator.TabIndex = 0
        Me.Вычет_ЗПBindingNavigator.Text = "BindingNavigator1"
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
        'Вычет_ЗПBindingNavigatorSaveItem
        '
        Me.Вычет_ЗПBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Вычет_ЗПBindingNavigatorSaveItem.Image = CType(resources.GetObject("Вычет_ЗПBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Вычет_ЗПBindingNavigatorSaveItem.Name = "Вычет_ЗПBindingNavigatorSaveItem"
        Me.Вычет_ЗПBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Вычет_ЗПBindingNavigatorSaveItem.Text = "Save Data"
        '
        'НазваниеTextBox
        '
        Me.НазваниеTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Вычет_ЗПBindingSource, "Название", True))
        Me.НазваниеTextBox.Location = New System.Drawing.Point(97, 87)
        Me.НазваниеTextBox.Name = "НазваниеTextBox"
        Me.НазваниеTextBox.Size = New System.Drawing.Size(293, 20)
        Me.НазваниеTextBox.TabIndex = 4
        '
        'Сумма_вычетаTextBox
        '
        Me.Сумма_вычетаTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Вычет_ЗПBindingSource, "Сумма_вычета", True))
        Me.Сумма_вычетаTextBox.Location = New System.Drawing.Point(97, 113)
        Me.Сумма_вычетаTextBox.Name = "Сумма_вычетаTextBox"
        Me.Сумма_вычетаTextBox.Size = New System.Drawing.Size(293, 20)
        Me.Сумма_вычетаTextBox.TabIndex = 6
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
        'РаботникComboBox
        '
        Me.РаботникComboBox.DataSource = Me.РаботникBindingSource
        Me.РаботникComboBox.DisplayMember = "Имя"
        Me.РаботникComboBox.FormattingEnabled = True
        Me.РаботникComboBox.Location = New System.Drawing.Point(97, 28)
        Me.РаботникComboBox.Name = "РаботникComboBox"
        Me.РаботникComboBox.Size = New System.Drawing.Size(293, 21)
        Me.РаботникComboBox.TabIndex = 6
        Me.РаботникComboBox.ValueMember = "Код_работника"
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
        'ЗарплатаComboBox
        '
        Me.ЗарплатаComboBox.DataSource = Me.ЗарплатаBindingSource
        Me.ЗарплатаComboBox.DisplayMember = "Displyed"
        Me.ЗарплатаComboBox.FormattingEnabled = True
        Me.ЗарплатаComboBox.Location = New System.Drawing.Point(97, 55)
        Me.ЗарплатаComboBox.Name = "ЗарплатаComboBox"
        Me.ЗарплатаComboBox.Size = New System.Drawing.Size(293, 21)
        Me.ЗарплатаComboBox.TabIndex = 8
        Me.ЗарплатаComboBox.ValueMember = "Код_зарплаты"
        '
        'OffreckoningCRUD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 171)
        Me.Controls.Add(Me.ЗарплатаComboBox)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.РаботникComboBox)
        Me.Controls.Add(НазваниеLabel)
        Me.Controls.Add(Me.НазваниеTextBox)
        Me.Controls.Add(Сумма_вычетаLabel)
        Me.Controls.Add(Me.Сумма_вычетаTextBox)
        Me.Controls.Add(Me.Вычет_ЗПBindingNavigator)
        Me.Name = "OffreckoningCRUD"
        Me.Text = "Вычеты"
        CType(Me.SalariesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Вычет_ЗПBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Вычет_ЗПBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Вычет_ЗПBindingNavigator.ResumeLayout(False)
        Me.Вычет_ЗПBindingNavigator.PerformLayout()
        CType(Me.РаботникBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ЗарплатаBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SalariesDataSet As Salaries.SalariesDataSet
    Friend WithEvents Вычет_ЗПBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Вычет_ЗПTableAdapter As Salaries.SalariesDataSetTableAdapters.Вычет_ЗПTableAdapter
    Friend WithEvents TableAdapterManager As Salaries.SalariesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Вычет_ЗПBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Вычет_ЗПBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents НазваниеTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Сумма_вычетаTextBox As System.Windows.Forms.TextBox
    Friend WithEvents РаботникBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents РаботникTableAdapter As Salaries.SalariesDataSetTableAdapters.РаботникTableAdapter
    Friend WithEvents РаботникComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ЗарплатаBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ЗарплатаTableAdapter As Salaries.SalariesDataSetTableAdapters.ЗарплатаTableAdapter
    Friend WithEvents ЗарплатаComboBox As System.Windows.Forms.ComboBox
End Class
