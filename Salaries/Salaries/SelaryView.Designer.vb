<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelaryView
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
        Dim МесяцLabel As System.Windows.Forms.Label
        Dim ОкладLabel As System.Windows.Forms.Label
        Dim На_рукиLabel As System.Windows.Forms.Label
        Dim ГодLabel As System.Windows.Forms.Label
        Dim Дата_выдачиLabel As System.Windows.Forms.Label
        Dim ИмяLabel As System.Windows.Forms.Label
        Dim ОтчествоLabel As System.Windows.Forms.Label
        Dim ФамилияLabel As System.Windows.Forms.Label
        Dim НазваниеLabel As System.Windows.Forms.Label
        Dim Сумма_вычетаLabel As System.Windows.Forms.Label
        Dim НазваниеLabel2 As System.Windows.Forms.Label
        Dim Сумма_прибавкиLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SelaryView))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SalariesDataSet = New Salaries.SalariesDataSet()
        Me.SalaryJoinEmployerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalaryJoinEmployerTableAdapter = New Salaries.SalariesDataSetTableAdapters.SalaryJoinEmployerTableAdapter()
        Me.TableAdapterManager = New Salaries.SalariesDataSetTableAdapters.TableAdapterManager()
        Me.Вычет_ЗПTableAdapter = New Salaries.SalariesDataSetTableAdapters.Вычет_ЗПTableAdapter()
        Me.Прибавка_ЗПTableAdapter = New Salaries.SalariesDataSetTableAdapters.Прибавка_ЗПTableAdapter()
        Me.SalaryJoinEmployerBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.МесяцLabel1 = New System.Windows.Forms.Label()
        Me.ОкладLabel1 = New System.Windows.Forms.Label()
        Me.На_рукиLabel1 = New System.Windows.Forms.Label()
        Me.ГодLabel1 = New System.Windows.Forms.Label()
        Me.Дата_выдачиLabel1 = New System.Windows.Forms.Label()
        Me.ИмяLabel1 = New System.Windows.Forms.Label()
        Me.ОтчествоLabel1 = New System.Windows.Forms.Label()
        Me.ФамилияLabel1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Вычет_ЗПBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Вычет_ЗПDataRepeater = New Microsoft.VisualBasic.PowerPacks.DataRepeater()
        Me.Сумма_вычетаLabel1 = New System.Windows.Forms.Label()
        Me.НазваниеLabel1 = New System.Windows.Forms.Label()
        Me.Прибавка_ЗПBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Прибавка_ЗПDataRepeater = New Microsoft.VisualBasic.PowerPacks.DataRepeater()
        Me.Сумма_прибавкиLabel1 = New System.Windows.Forms.Label()
        Me.НазваниеLabel3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        МесяцLabel = New System.Windows.Forms.Label()
        ОкладLabel = New System.Windows.Forms.Label()
        На_рукиLabel = New System.Windows.Forms.Label()
        ГодLabel = New System.Windows.Forms.Label()
        Дата_выдачиLabel = New System.Windows.Forms.Label()
        ИмяLabel = New System.Windows.Forms.Label()
        ОтчествоLabel = New System.Windows.Forms.Label()
        ФамилияLabel = New System.Windows.Forms.Label()
        НазваниеLabel = New System.Windows.Forms.Label()
        Сумма_вычетаLabel = New System.Windows.Forms.Label()
        НазваниеLabel2 = New System.Windows.Forms.Label()
        Сумма_прибавкиLabel = New System.Windows.Forms.Label()
        CType(Me.SalariesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalaryJoinEmployerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalaryJoinEmployerBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SalaryJoinEmployerBindingNavigator.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Вычет_ЗПBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Вычет_ЗПDataRepeater.ItemTemplate.SuspendLayout()
        Me.Вычет_ЗПDataRepeater.SuspendLayout()
        CType(Me.Прибавка_ЗПBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Прибавка_ЗПDataRepeater.ItemTemplate.SuspendLayout()
        Me.Прибавка_ЗПDataRepeater.SuspendLayout()
        Me.SuspendLayout()
        '
        'МесяцLabel
        '
        МесяцLabel.AutoSize = True
        МесяцLabel.Location = New System.Drawing.Point(191, 16)
        МесяцLabel.Name = "МесяцLabel"
        МесяцLabel.Size = New System.Drawing.Size(43, 13)
        МесяцLabel.TabIndex = 20
        МесяцLabel.Text = "Месяц:"
        '
        'ОкладLabel
        '
        ОкладLabel.AutoSize = True
        ОкладLabel.Location = New System.Drawing.Point(17, 100)
        ОкладLabel.Name = "ОкладLabel"
        ОкладLabel.Size = New System.Drawing.Size(42, 13)
        ОкладLabel.TabIndex = 22
        ОкладLabel.Text = "Оклад:"
        '
        'На_рукиLabel
        '
        На_рукиLabel.AutoSize = True
        На_рукиLabel.Location = New System.Drawing.Point(191, 100)
        На_рукиLabel.Name = "На_рукиLabel"
        На_рукиLabel.Size = New System.Drawing.Size(50, 13)
        На_рукиLabel.TabIndex = 24
        На_рукиLabel.Text = "На руки:"
        '
        'ГодLabel
        '
        ГодLabel.AutoSize = True
        ГодLabel.Location = New System.Drawing.Point(191, 39)
        ГодLabel.Name = "ГодLabel"
        ГодLabel.Size = New System.Drawing.Size(28, 13)
        ГодLabel.TabIndex = 26
        ГодLabel.Text = "Год:"
        '
        'Дата_выдачиLabel
        '
        Дата_выдачиLabel.AutoSize = True
        Дата_выдачиLabel.Location = New System.Drawing.Point(15, 123)
        Дата_выдачиLabel.Name = "Дата_выдачиLabel"
        Дата_выдачиLabel.Size = New System.Drawing.Size(76, 13)
        Дата_выдачиLabel.TabIndex = 30
        Дата_выдачиLabel.Text = "Дата выдачи:"
        '
        'ИмяLabel
        '
        ИмяLabel.AutoSize = True
        ИмяLabel.Location = New System.Drawing.Point(15, 16)
        ИмяLabel.Name = "ИмяLabel"
        ИмяLabel.Size = New System.Drawing.Size(32, 13)
        ИмяLabel.TabIndex = 34
        ИмяLabel.Text = "Имя:"
        '
        'ОтчествоLabel
        '
        ОтчествоLabel.AutoSize = True
        ОтчествоLabel.Location = New System.Drawing.Point(15, 39)
        ОтчествоLabel.Name = "ОтчествоLabel"
        ОтчествоLabel.Size = New System.Drawing.Size(57, 13)
        ОтчествоLabel.TabIndex = 36
        ОтчествоLabel.Text = "Отчество:"
        '
        'ФамилияLabel
        '
        ФамилияLabel.AutoSize = True
        ФамилияLabel.Location = New System.Drawing.Point(15, 62)
        ФамилияLabel.Name = "ФамилияLabel"
        ФамилияLabel.Size = New System.Drawing.Size(59, 13)
        ФамилияLabel.TabIndex = 38
        ФамилияLabel.Text = "Фамилия:"
        '
        'НазваниеLabel
        '
        НазваниеLabel.AutoSize = True
        НазваниеLabel.Location = New System.Drawing.Point(19, 12)
        НазваниеLabel.Name = "НазваниеLabel"
        НазваниеLabel.Size = New System.Drawing.Size(60, 13)
        НазваниеLabel.TabIndex = 0
        НазваниеLabel.Text = "Название:"
        '
        'Сумма_вычетаLabel
        '
        Сумма_вычетаLabel.AutoSize = True
        Сумма_вычетаLabel.Location = New System.Drawing.Point(22, 48)
        Сумма_вычетаLabel.Name = "Сумма_вычетаLabel"
        Сумма_вычетаLabel.Size = New System.Drawing.Size(83, 13)
        Сумма_вычетаLabel.TabIndex = 2
        Сумма_вычетаLabel.Text = "Сумма вычета:"
        '
        'НазваниеLabel2
        '
        НазваниеLabel2.AutoSize = True
        НазваниеLabel2.Location = New System.Drawing.Point(16, 12)
        НазваниеLabel2.Name = "НазваниеLabel2"
        НазваниеLabel2.Size = New System.Drawing.Size(60, 13)
        НазваниеLabel2.TabIndex = 0
        НазваниеLabel2.Text = "Название:"
        '
        'Сумма_прибавкиLabel
        '
        Сумма_прибавкиLabel.AutoSize = True
        Сумма_прибавкиLabel.Location = New System.Drawing.Point(17, 47)
        Сумма_прибавкиLabel.Name = "Сумма_прибавкиLabel"
        Сумма_прибавкиLabel.Size = New System.Drawing.Size(95, 13)
        Сумма_прибавкиLabel.TabIndex = 2
        Сумма_прибавкиLabel.Text = "Сумма прибавки:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Chocolate
        Me.Label1.Location = New System.Drawing.Point(12, 229)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 27)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Прибавки"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Chocolate
        Me.Label2.Location = New System.Drawing.Point(396, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 27)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Вычеты"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Chocolate
        Me.Label3.Location = New System.Drawing.Point(-5, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 27)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Зарплата"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SalariesDataSet
        '
        Me.SalariesDataSet.DataSetName = "SalariesDataSet"
        Me.SalariesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SalaryJoinEmployerBindingSource
        '
        Me.SalaryJoinEmployerBindingSource.DataMember = "SalaryJoinEmployer"
        Me.SalaryJoinEmployerBindingSource.DataSource = Me.SalariesDataSet
        '
        'SalaryJoinEmployerTableAdapter
        '
        Me.SalaryJoinEmployerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Salaries.SalariesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Вычет_ЗПTableAdapter = Me.Вычет_ЗПTableAdapter
        Me.TableAdapterManager.ЗарплатаTableAdapter = Nothing
        Me.TableAdapterManager.ОтделTableAdapter = Nothing
        Me.TableAdapterManager.Прибавка_ЗПTableAdapter = Me.Прибавка_ЗПTableAdapter
        Me.TableAdapterManager.ПропускTableAdapter = Nothing
        Me.TableAdapterManager.РаботникTableAdapter = Nothing
        Me.TableAdapterManager.СпециальностьTableAdapter = Nothing
        Me.TableAdapterManager.СтавкаTableAdapter = Nothing
        '
        'Вычет_ЗПTableAdapter
        '
        Me.Вычет_ЗПTableAdapter.ClearBeforeFill = True
        '
        'Прибавка_ЗПTableAdapter
        '
        Me.Прибавка_ЗПTableAdapter.ClearBeforeFill = True
        '
        'SalaryJoinEmployerBindingNavigator
        '
        Me.SalaryJoinEmployerBindingNavigator.AddNewItem = Nothing
        Me.SalaryJoinEmployerBindingNavigator.BindingSource = Me.SalaryJoinEmployerBindingSource
        Me.SalaryJoinEmployerBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SalaryJoinEmployerBindingNavigator.DeleteItem = Nothing
        Me.SalaryJoinEmployerBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.SalaryJoinEmployerBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SalaryJoinEmployerBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SalaryJoinEmployerBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SalaryJoinEmployerBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SalaryJoinEmployerBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SalaryJoinEmployerBindingNavigator.Name = "SalaryJoinEmployerBindingNavigator"
        Me.SalaryJoinEmployerBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SalaryJoinEmployerBindingNavigator.Size = New System.Drawing.Size(759, 25)
        Me.SalaryJoinEmployerBindingNavigator.TabIndex = 20
        Me.SalaryJoinEmployerBindingNavigator.Text = "BindingNavigator1"
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
        'МесяцLabel1
        '
        Me.МесяцLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalaryJoinEmployerBindingSource, "Месяц", True))
        Me.МесяцLabel1.Location = New System.Drawing.Point(271, 16)
        Me.МесяцLabel1.Name = "МесяцLabel1"
        Me.МесяцLabel1.Size = New System.Drawing.Size(77, 23)
        Me.МесяцLabel1.TabIndex = 21
        Me.МесяцLabel1.Text = "Label4"
        '
        'ОкладLabel1
        '
        Me.ОкладLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalaryJoinEmployerBindingSource, "Оклад", True))
        Me.ОкладLabel1.Location = New System.Drawing.Point(94, 100)
        Me.ОкладLabel1.Name = "ОкладLabel1"
        Me.ОкладLabel1.Size = New System.Drawing.Size(101, 23)
        Me.ОкладLabel1.TabIndex = 23
        Me.ОкладLabel1.Text = "Label4"
        '
        'На_рукиLabel1
        '
        Me.На_рукиLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalaryJoinEmployerBindingSource, "На_руки", True))
        Me.На_рукиLabel1.Location = New System.Drawing.Point(271, 100)
        Me.На_рукиLabel1.Name = "На_рукиLabel1"
        Me.На_рукиLabel1.Size = New System.Drawing.Size(100, 23)
        Me.На_рукиLabel1.TabIndex = 25
        Me.На_рукиLabel1.Text = "Label4"
        '
        'ГодLabel1
        '
        Me.ГодLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalaryJoinEmployerBindingSource, "Год", True))
        Me.ГодLabel1.Location = New System.Drawing.Point(271, 39)
        Me.ГодLabel1.Name = "ГодLabel1"
        Me.ГодLabel1.Size = New System.Drawing.Size(77, 23)
        Me.ГодLabel1.TabIndex = 27
        Me.ГодLabel1.Text = "Label4"
        '
        'Дата_выдачиLabel1
        '
        Me.Дата_выдачиLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalaryJoinEmployerBindingSource, "Дата_выдачи", True))
        Me.Дата_выдачиLabel1.Location = New System.Drawing.Point(95, 123)
        Me.Дата_выдачиLabel1.Name = "Дата_выдачиLabel1"
        Me.Дата_выдачиLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Дата_выдачиLabel1.TabIndex = 31
        Me.Дата_выдачиLabel1.Text = "Label4"
        '
        'ИмяLabel1
        '
        Me.ИмяLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalaryJoinEmployerBindingSource, "Имя", True))
        Me.ИмяLabel1.Location = New System.Drawing.Point(95, 16)
        Me.ИмяLabel1.Name = "ИмяLabel1"
        Me.ИмяLabel1.Size = New System.Drawing.Size(100, 23)
        Me.ИмяLabel1.TabIndex = 35
        Me.ИмяLabel1.Text = "Label4"
        '
        'ОтчествоLabel1
        '
        Me.ОтчествоLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalaryJoinEmployerBindingSource, "Отчество", True))
        Me.ОтчествоLabel1.Location = New System.Drawing.Point(95, 39)
        Me.ОтчествоLabel1.Name = "ОтчествоLabel1"
        Me.ОтчествоLabel1.Size = New System.Drawing.Size(100, 23)
        Me.ОтчествоLabel1.TabIndex = 37
        Me.ОтчествоLabel1.Text = "Label4"
        '
        'ФамилияLabel1
        '
        Me.ФамилияLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalaryJoinEmployerBindingSource, "Фамилия", True))
        Me.ФамилияLabel1.Location = New System.Drawing.Point(95, 62)
        Me.ФамилияLabel1.Name = "ФамилияLabel1"
        Me.ФамилияLabel1.Size = New System.Drawing.Size(100, 23)
        Me.ФамилияLabel1.TabIndex = 39
        Me.ФамилияLabel1.Text = "Label4"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.МесяцLabel1)
        Me.GroupBox1.Controls.Add(МесяцLabel)
        Me.GroupBox1.Controls.Add(Me.ФамилияLabel1)
        Me.GroupBox1.Controls.Add(ФамилияLabel)
        Me.GroupBox1.Controls.Add(ОкладLabel)
        Me.GroupBox1.Controls.Add(Me.ОтчествоLabel1)
        Me.GroupBox1.Controls.Add(Me.ОкладLabel1)
        Me.GroupBox1.Controls.Add(ОтчествоLabel)
        Me.GroupBox1.Controls.Add(На_рукиLabel)
        Me.GroupBox1.Controls.Add(Me.ИмяLabel1)
        Me.GroupBox1.Controls.Add(Me.На_рукиLabel1)
        Me.GroupBox1.Controls.Add(ИмяLabel)
        Me.GroupBox1.Controls.Add(ГодLabel)
        Me.GroupBox1.Controls.Add(Me.Дата_выдачиLabel1)
        Me.GroupBox1.Controls.Add(Me.ГодLabel1)
        Me.GroupBox1.Controls.Add(Дата_выдачиLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(369, 161)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        '
        'Вычет_ЗПBindingSource
        '
        Me.Вычет_ЗПBindingSource.DataMember = "FK_Вычет_ЗП_Зарплата1"
        Me.Вычет_ЗПBindingSource.DataSource = Me.SalaryJoinEmployerBindingSource
        '
        'Вычет_ЗПDataRepeater
        '
        Me.Вычет_ЗПDataRepeater.DataSource = Me.Вычет_ЗПBindingSource
        '
        'Вычет_ЗПDataRepeater.ItemTemplate
        '
        Me.Вычет_ЗПDataRepeater.ItemTemplate.Controls.Add(Сумма_вычетаLabel)
        Me.Вычет_ЗПDataRepeater.ItemTemplate.Controls.Add(Me.Сумма_вычетаLabel1)
        Me.Вычет_ЗПDataRepeater.ItemTemplate.Controls.Add(НазваниеLabel)
        Me.Вычет_ЗПDataRepeater.ItemTemplate.Controls.Add(Me.НазваниеLabel1)
        Me.Вычет_ЗПDataRepeater.ItemTemplate.Size = New System.Drawing.Size(330, 81)
        Me.Вычет_ЗПDataRepeater.Location = New System.Drawing.Point(401, 65)
        Me.Вычет_ЗПDataRepeater.Name = "Вычет_ЗПDataRepeater"
        Me.Вычет_ЗПDataRepeater.Size = New System.Drawing.Size(338, 161)
        Me.Вычет_ЗПDataRepeater.TabIndex = 40
        Me.Вычет_ЗПDataRepeater.Text = "DataRepeater1"
        '
        'Сумма_вычетаLabel1
        '
        Me.Сумма_вычетаLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Вычет_ЗПBindingSource, "Сумма_вычета", True))
        Me.Сумма_вычетаLabel1.Location = New System.Drawing.Point(111, 48)
        Me.Сумма_вычетаLabel1.Name = "Сумма_вычетаLabel1"
        Me.Сумма_вычетаLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Сумма_вычетаLabel1.TabIndex = 3
        Me.Сумма_вычетаLabel1.Text = "Label4"
        '
        'НазваниеLabel1
        '
        Me.НазваниеLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Вычет_ЗПBindingSource, "Название", True))
        Me.НазваниеLabel1.Location = New System.Drawing.Point(111, 12)
        Me.НазваниеLabel1.Name = "НазваниеLabel1"
        Me.НазваниеLabel1.Size = New System.Drawing.Size(208, 23)
        Me.НазваниеLabel1.TabIndex = 1
        Me.НазваниеLabel1.Text = "Label4"
        '
        'Прибавка_ЗПBindingSource
        '
        Me.Прибавка_ЗПBindingSource.DataMember = "FK_Прибавка_ЗП_Зарплата1"
        Me.Прибавка_ЗПBindingSource.DataSource = Me.SalaryJoinEmployerBindingSource
        '
        'Прибавка_ЗПDataRepeater
        '
        Me.Прибавка_ЗПDataRepeater.DataSource = Me.Прибавка_ЗПBindingSource
        '
        'Прибавка_ЗПDataRepeater.ItemTemplate
        '
        Me.Прибавка_ЗПDataRepeater.ItemTemplate.Controls.Add(Сумма_прибавкиLabel)
        Me.Прибавка_ЗПDataRepeater.ItemTemplate.Controls.Add(Me.Сумма_прибавкиLabel1)
        Me.Прибавка_ЗПDataRepeater.ItemTemplate.Controls.Add(НазваниеLabel2)
        Me.Прибавка_ЗПDataRepeater.ItemTemplate.Controls.Add(Me.НазваниеLabel3)
        Me.Прибавка_ЗПDataRepeater.ItemTemplate.Size = New System.Drawing.Size(714, 82)
        Me.Прибавка_ЗПDataRepeater.Location = New System.Drawing.Point(17, 259)
        Me.Прибавка_ЗПDataRepeater.Name = "Прибавка_ЗПDataRepeater"
        Me.Прибавка_ЗПDataRepeater.Size = New System.Drawing.Size(722, 253)
        Me.Прибавка_ЗПDataRepeater.TabIndex = 40
        Me.Прибавка_ЗПDataRepeater.Text = "DataRepeater1"
        '
        'Сумма_прибавкиLabel1
        '
        Me.Сумма_прибавкиLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Прибавка_ЗПBindingSource, "Сумма_прибавки", True))
        Me.Сумма_прибавкиLabel1.Location = New System.Drawing.Point(118, 47)
        Me.Сумма_прибавкиLabel1.Name = "Сумма_прибавкиLabel1"
        Me.Сумма_прибавкиLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Сумма_прибавкиLabel1.TabIndex = 3
        Me.Сумма_прибавкиLabel1.Text = "Label4"
        '
        'НазваниеLabel3
        '
        Me.НазваниеLabel3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Прибавка_ЗПBindingSource, "Название", True))
        Me.НазваниеLabel3.Location = New System.Drawing.Point(82, 12)
        Me.НазваниеLabel3.Name = "НазваниеLabel3"
        Me.НазваниеLabel3.Size = New System.Drawing.Size(428, 23)
        Me.НазваниеLabel3.TabIndex = 1
        Me.НазваниеLabel3.Text = "Label4"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(161, 29)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 23)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "Добавить/Редактировать"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(315, 29)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 42
        Me.Button2.Text = "Отчёт"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(591, 32)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(148, 23)
        Me.Button3.TabIndex = 43
        Me.Button3.Text = "Добавить/Редактировать"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'SelaryView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(759, 524)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Прибавка_ЗПDataRepeater)
        Me.Controls.Add(Me.Вычет_ЗПDataRepeater)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.SalaryJoinEmployerBindingNavigator)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SelaryView"
        Me.Text = "SelaryView"
        CType(Me.SalariesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalaryJoinEmployerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalaryJoinEmployerBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SalaryJoinEmployerBindingNavigator.ResumeLayout(False)
        Me.SalaryJoinEmployerBindingNavigator.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Вычет_ЗПBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Вычет_ЗПDataRepeater.ItemTemplate.ResumeLayout(False)
        Me.Вычет_ЗПDataRepeater.ItemTemplate.PerformLayout()
        Me.Вычет_ЗПDataRepeater.ResumeLayout(False)
        CType(Me.Прибавка_ЗПBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Прибавка_ЗПDataRepeater.ItemTemplate.ResumeLayout(False)
        Me.Прибавка_ЗПDataRepeater.ItemTemplate.PerformLayout()
        Me.Прибавка_ЗПDataRepeater.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SalariesDataSet As Salaries.SalariesDataSet
    Friend WithEvents SalaryJoinEmployerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SalaryJoinEmployerTableAdapter As Salaries.SalariesDataSetTableAdapters.SalaryJoinEmployerTableAdapter
    Friend WithEvents TableAdapterManager As Salaries.SalariesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SalaryJoinEmployerBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Вычет_ЗПTableAdapter As Salaries.SalariesDataSetTableAdapters.Вычет_ЗПTableAdapter
    Friend WithEvents МесяцLabel1 As System.Windows.Forms.Label
    Friend WithEvents ОкладLabel1 As System.Windows.Forms.Label
    Friend WithEvents На_рукиLabel1 As System.Windows.Forms.Label
    Friend WithEvents ГодLabel1 As System.Windows.Forms.Label
    Friend WithEvents Дата_выдачиLabel1 As System.Windows.Forms.Label
    Friend WithEvents ИмяLabel1 As System.Windows.Forms.Label
    Friend WithEvents ОтчествоLabel1 As System.Windows.Forms.Label
    Friend WithEvents ФамилияLabel1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Вычет_ЗПBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Прибавка_ЗПTableAdapter As Salaries.SalariesDataSetTableAdapters.Прибавка_ЗПTableAdapter
    Friend WithEvents Вычет_ЗПDataRepeater As Microsoft.VisualBasic.PowerPacks.DataRepeater
    Friend WithEvents Сумма_вычетаLabel1 As System.Windows.Forms.Label
    Friend WithEvents НазваниеLabel1 As System.Windows.Forms.Label
    Friend WithEvents Прибавка_ЗПBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Прибавка_ЗПDataRepeater As Microsoft.VisualBasic.PowerPacks.DataRepeater
    Friend WithEvents Сумма_прибавкиLabel1 As System.Windows.Forms.Label
    Friend WithEvents НазваниеLabel3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
