<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployersView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmployersView))
        Me.SalariesDataSet = New Salaries.SalariesDataSet()
        Me.EmployersViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployersViewTableAdapter = New Salaries.SalariesDataSetTableAdapters.EmployersViewTableAdapter()
        Me.TableAdapterManager = New Salaries.SalariesDataSetTableAdapters.TableAdapterManager()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.EVSortCritetia = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.EVOrderCriteria = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.EmployersViewBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ОтделBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ОтделTableAdapter = New Salaries.SalariesDataSetTableAdapters.ОтделTableAdapter()
        Me.ОтделComboBox = New System.Windows.Forms.ComboBox()
        Me.btnFilterByDepartment = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnResetFilters = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.СпециальностьComboBox = New System.Windows.Forms.ComboBox()
        Me.СпециальностьBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.СпециальностьTableAdapter = New Salaries.SalariesDataSetTableAdapters.СпециальностьTableAdapter()
        Me.EmployersViewDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Код_работника = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        CType(Me.SalariesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployersViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployersViewBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EmployersViewBindingNavigator.SuspendLayout()
        CType(Me.ОтделBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.СпециальностьBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployersViewDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SalariesDataSet
        '
        Me.SalariesDataSet.DataSetName = "SalariesDataSet"
        Me.SalariesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmployersViewBindingSource
        '
        Me.EmployersViewBindingSource.DataMember = "EmployersView"
        Me.EmployersViewBindingSource.DataSource = Me.SalariesDataSet
        '
        'EmployersViewTableAdapter
        '
        Me.EmployersViewTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = Salaries.SalariesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Вычет_ЗПTableAdapter = Nothing
        Me.TableAdapterManager.ЗарплатаTableAdapter = Nothing
        Me.TableAdapterManager.ОтделTableAdapter = Nothing
        Me.TableAdapterManager.Прибавка_ЗПTableAdapter = Nothing
        Me.TableAdapterManager.ПропускTableAdapter = Nothing
        Me.TableAdapterManager.РаботникTableAdapter = Nothing
        Me.TableAdapterManager.СпециальностьTableAdapter = Nothing
        Me.TableAdapterManager.СтавкаTableAdapter = Nothing
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(58, 22)
        Me.BindingNavigatorCountItem.Text = "Всего: {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(60, 22)
        Me.ToolStripLabel1.Text = "Критерий"
        '
        'EVSortCritetia
        '
        Me.EVSortCritetia.Items.AddRange(New Object() {"Имя ", "Фамилия ", "Отчество ", "Дата приёма", "Стаж"})
        Me.EVSortCritetia.Name = "EVSortCritetia"
        Me.EVSortCritetia.Size = New System.Drawing.Size(121, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(21, 22)
        Me.ToolStripLabel2.Text = "по"
        '
        'EVOrderCriteria
        '
        Me.EVOrderCriteria.Items.AddRange(New Object() {"Возростанию", "Убыванию"})
        Me.EVOrderCriteria.Name = "EVOrderCriteria"
        Me.EVOrderCriteria.Size = New System.Drawing.Size(121, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(82, 22)
        Me.ToolStripButton1.Text = "Сортировать"
        '
        'EmployersViewBindingNavigator
        '
        Me.EmployersViewBindingNavigator.AddNewItem = Nothing
        Me.EmployersViewBindingNavigator.BindingSource = Me.EmployersViewBindingSource
        Me.EmployersViewBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EmployersViewBindingNavigator.CountItemFormat = "Всего: {0}"
        Me.EmployersViewBindingNavigator.DeleteItem = Nothing
        Me.EmployersViewBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator2, Me.ToolStripLabel1, Me.EVSortCritetia, Me.ToolStripLabel2, Me.EVOrderCriteria, Me.ToolStripButton1})
        Me.EmployersViewBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EmployersViewBindingNavigator.MoveFirstItem = Nothing
        Me.EmployersViewBindingNavigator.MoveLastItem = Nothing
        Me.EmployersViewBindingNavigator.MoveNextItem = Nothing
        Me.EmployersViewBindingNavigator.MovePreviousItem = Nothing
        Me.EmployersViewBindingNavigator.Name = "EmployersViewBindingNavigator"
        Me.EmployersViewBindingNavigator.PositionItem = Nothing
        Me.EmployersViewBindingNavigator.Size = New System.Drawing.Size(1062, 25)
        Me.EmployersViewBindingNavigator.TabIndex = 0
        Me.EmployersViewBindingNavigator.Text = "BindingNavigator1"
        '
        'ОтделBindingSource
        '
        Me.ОтделBindingSource.DataMember = "Отдел"
        Me.ОтделBindingSource.DataSource = Me.SalariesDataSet
        '
        'ОтделTableAdapter
        '
        Me.ОтделTableAdapter.ClearBeforeFill = True
        '
        'ОтделComboBox
        '
        Me.ОтделComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ОтделComboBox.DataSource = Me.ОтделBindingSource
        Me.ОтделComboBox.DisplayMember = "Название"
        Me.ОтделComboBox.FormattingEnabled = True
        Me.ОтделComboBox.Location = New System.Drawing.Point(50, 19)
        Me.ОтделComboBox.Name = "ОтделComboBox"
        Me.ОтделComboBox.Size = New System.Drawing.Size(317, 21)
        Me.ОтделComboBox.TabIndex = 2
        Me.ОтделComboBox.ValueMember = "Код_отдела"
        '
        'btnFilterByDepartment
        '
        Me.btnFilterByDepartment.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFilterByDepartment.Location = New System.Drawing.Point(9, 51)
        Me.btnFilterByDepartment.Name = "btnFilterByDepartment"
        Me.btnFilterByDepartment.Size = New System.Drawing.Size(112, 23)
        Me.btnFilterByDepartment.TabIndex = 3
        Me.btnFilterByDepartment.Text = "Фильровать"
        Me.btnFilterByDepartment.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Отдел"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.btnResetFilters)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.СпециальностьComboBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnFilterByDepartment)
        Me.GroupBox1.Controls.Add(Me.ОтделComboBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 306)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1038, 80)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Фильтрация"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(225, 51)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Отчёт"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnResetFilters
        '
        Me.btnResetFilters.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnResetFilters.Location = New System.Drawing.Point(127, 51)
        Me.btnResetFilters.Name = "btnResetFilters"
        Me.btnResetFilters.Size = New System.Drawing.Size(92, 23)
        Me.btnResetFilters.TabIndex = 7
        Me.btnResetFilters.Text = "Сброс"
        Me.btnResetFilters.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(373, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Специальность"
        '
        'СпециальностьComboBox
        '
        Me.СпециальностьComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.СпециальностьComboBox.DataSource = Me.СпециальностьBindingSource
        Me.СпециальностьComboBox.DisplayMember = "Название"
        Me.СпециальностьComboBox.FormattingEnabled = True
        Me.СпециальностьComboBox.Location = New System.Drawing.Point(464, 19)
        Me.СпециальностьComboBox.Name = "СпециальностьComboBox"
        Me.СпециальностьComboBox.Size = New System.Drawing.Size(317, 21)
        Me.СпециальностьComboBox.TabIndex = 4
        Me.СпециальностьComboBox.ValueMember = "Код_специальности"
        '
        'СпециальностьBindingSource
        '
        Me.СпециальностьBindingSource.DataMember = "Специальность"
        Me.СпециальностьBindingSource.DataSource = Me.SalariesDataSet
        '
        'СпециальностьTableAdapter
        '
        Me.СпециальностьTableAdapter.ClearBeforeFill = True
        '
        'EmployersViewDataGridView
        '
        Me.EmployersViewDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EmployersViewDataGridView.AutoGenerateColumns = False
        Me.EmployersViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmployersViewDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.Код_работника})
        Me.EmployersViewDataGridView.DataSource = Me.EmployersViewBindingSource
        Me.EmployersViewDataGridView.Location = New System.Drawing.Point(0, 28)
        Me.EmployersViewDataGridView.MultiSelect = False
        Me.EmployersViewDataGridView.Name = "EmployersViewDataGridView"
        Me.EmployersViewDataGridView.ReadOnly = True
        Me.EmployersViewDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.EmployersViewDataGridView.Size = New System.Drawing.Size(1062, 272)
        Me.EmployersViewDataGridView.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Имя"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Имя"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Фамилия"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Фамилия"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Отчество"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Отчество"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Телефон"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Телефон"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Специальность"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Специальность"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Отдел"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Отдел"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Вид_ставки"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Вид ставки"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Дата_приёма"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Дата приёма"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Номер_пасспорта"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Номер пасспорта"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Стаж"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Стаж"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'Код_работника
        '
        Me.Код_работника.DataPropertyName = "Код_работника"
        Me.Код_работника.HeaderText = "Код работника"
        Me.Код_работника.Name = "Код_работника"
        Me.Код_работника.ReadOnly = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.SearchButton)
        Me.GroupBox2.Controls.Add(Me.SearchTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 392)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1030, 56)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Поиск по ФИО"
        '
        'SearchButton
        '
        Me.SearchButton.Location = New System.Drawing.Point(356, 14)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(82, 29)
        Me.SearchButton.TabIndex = 1
        Me.SearchButton.Text = "Поиск"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Location = New System.Drawing.Point(9, 19)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(341, 20)
        Me.SearchTextBox.TabIndex = 0
        '
        'EmployersView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1062, 460)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.EmployersViewDataGridView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.EmployersViewBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "EmployersView"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Все работники"
        CType(Me.SalariesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployersViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployersViewBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EmployersViewBindingNavigator.ResumeLayout(False)
        Me.EmployersViewBindingNavigator.PerformLayout()
        CType(Me.ОтделBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.СпециальностьBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployersViewDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SalariesDataSet As Salaries.SalariesDataSet
    Friend WithEvents EmployersViewBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmployersViewTableAdapter As Salaries.SalariesDataSetTableAdapters.EmployersViewTableAdapter
    Friend WithEvents TableAdapterManager As Salaries.SalariesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents EVSortCritetia As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents EVOrderCriteria As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents EmployersViewBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents ОтделBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ОтделTableAdapter As Salaries.SalariesDataSetTableAdapters.ОтделTableAdapter
    Friend WithEvents ОтделComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents btnFilterByDepartment As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents СпециальностьBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents СпециальностьTableAdapter As Salaries.SalariesDataSetTableAdapters.СпециальностьTableAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents СпециальностьComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents btnResetFilters As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents EmployersViewDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Код_работника As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents SearchButton As System.Windows.Forms.Button
    Friend WithEvents SearchTextBox As System.Windows.Forms.TextBox
End Class
