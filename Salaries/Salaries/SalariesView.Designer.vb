<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalariesView
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
        Me.SalariesDataSet = New Salaries.SalariesDataSet()
        Me.РаботникBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.РаботникTableAdapter = New Salaries.SalariesDataSetTableAdapters.РаботникTableAdapter()
        Me.TableAdapterManager = New Salaries.SalariesDataSetTableAdapters.TableAdapterManager()
        Me.Вычет_ЗПTableAdapter = New Salaries.SalariesDataSetTableAdapters.Вычет_ЗПTableAdapter()
        Me.ЗарплатаTableAdapter = New Salaries.SalariesDataSetTableAdapters.ЗарплатаTableAdapter()
        Me.Прибавка_ЗПTableAdapter = New Salaries.SalariesDataSetTableAdapters.Прибавка_ЗПTableAdapter()
        Me.РаботникDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ЗарплатаBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ЗарплатаDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Вычет_ЗПBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Вычет_ЗПDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Прибавка_ЗПBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Прибавка_ЗПDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.SalariesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.РаботникBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.РаботникDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ЗарплатаBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ЗарплатаDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Вычет_ЗПBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Вычет_ЗПDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Прибавка_ЗПBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Прибавка_ЗПDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.TableAdapterManager.Вычет_ЗПTableAdapter = Me.Вычет_ЗПTableAdapter
        Me.TableAdapterManager.ЗарплатаTableAdapter = Me.ЗарплатаTableAdapter
        Me.TableAdapterManager.ОтделTableAdapter = Nothing
        Me.TableAdapterManager.Прибавка_ЗПTableAdapter = Me.Прибавка_ЗПTableAdapter
        Me.TableAdapterManager.ПропускTableAdapter = Nothing
        Me.TableAdapterManager.РаботникTableAdapter = Me.РаботникTableAdapter
        Me.TableAdapterManager.СпециальностьTableAdapter = Nothing
        Me.TableAdapterManager.СтавкаTableAdapter = Nothing
        '
        'Вычет_ЗПTableAdapter
        '
        Me.Вычет_ЗПTableAdapter.ClearBeforeFill = True
        '
        'ЗарплатаTableAdapter
        '
        Me.ЗарплатаTableAdapter.ClearBeforeFill = True
        '
        'Прибавка_ЗПTableAdapter
        '
        Me.Прибавка_ЗПTableAdapter.ClearBeforeFill = True
        '
        'РаботникDataGridView
        '
        Me.РаботникDataGridView.AutoGenerateColumns = False
        Me.РаботникDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.РаботникDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn13})
        Me.РаботникDataGridView.DataSource = Me.РаботникBindingSource
        Me.РаботникDataGridView.Location = New System.Drawing.Point(12, 36)
        Me.РаботникDataGridView.Name = "РаботникDataGridView"
        Me.РаботникDataGridView.ReadOnly = True
        Me.РаботникDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.РаботникDataGridView.Size = New System.Drawing.Size(367, 220)
        Me.РаботникDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Код_работника"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Код_работника"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "ФИО"
        Me.DataGridViewTextBoxColumn13.HeaderText = "ФИО"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Width = 300
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Chocolate
        Me.Label1.Location = New System.Drawing.Point(12, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 33)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Работники"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ЗарплатаBindingSource
        '
        Me.ЗарплатаBindingSource.DataMember = "FK_Зарплата_Работник"
        Me.ЗарплатаBindingSource.DataSource = Me.РаботникBindingSource
        '
        'ЗарплатаDataGridView
        '
        Me.ЗарплатаDataGridView.AutoGenerateColumns = False
        Me.ЗарплатаDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ЗарплатаDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn7})
        Me.ЗарплатаDataGridView.DataSource = Me.ЗарплатаBindingSource
        Me.ЗарплатаDataGridView.Location = New System.Drawing.Point(396, 36)
        Me.ЗарплатаDataGridView.Name = "ЗарплатаDataGridView"
        Me.ЗарплатаDataGridView.ReadOnly = True
        Me.ЗарплатаDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ЗарплатаDataGridView.Size = New System.Drawing.Size(495, 220)
        Me.ЗарплатаDataGridView.TabIndex = 5
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Код_зарплаты"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Код_зарплаты"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Месяц"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Месяц"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 50
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Год"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Год"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Оклад"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Оклад"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "На_руки"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Итог"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Дата_выдачи"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Дата выдачи"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Chocolate
        Me.Label2.Location = New System.Drawing.Point(391, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 33)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Зарплаты"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Chocolate
        Me.Label3.Location = New System.Drawing.Point(7, 259)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 33)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Надбавки"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Chocolate
        Me.Label4.Location = New System.Drawing.Point(391, 259)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 33)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Вычеты"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Вычет_ЗПBindingSource
        '
        Me.Вычет_ЗПBindingSource.DataMember = "FK_Вычет_ЗП_Зарплата"
        Me.Вычет_ЗПBindingSource.DataSource = Me.ЗарплатаBindingSource
        '
        'Вычет_ЗПDataGridView
        '
        Me.Вычет_ЗПDataGridView.AutoGenerateColumns = False
        Me.Вычет_ЗПDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Вычет_ЗПDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.Вычет_ЗПDataGridView.DataSource = Me.Вычет_ЗПBindingSource
        Me.Вычет_ЗПDataGridView.Location = New System.Drawing.Point(396, 295)
        Me.Вычет_ЗПDataGridView.Name = "Вычет_ЗПDataGridView"
        Me.Вычет_ЗПDataGridView.ReadOnly = True
        Me.Вычет_ЗПDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Вычет_ЗПDataGridView.Size = New System.Drawing.Size(495, 232)
        Me.Вычет_ЗПDataGridView.TabIndex = 8
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Код_вычета"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Код_вычета"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Название"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Название"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 200
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Сумма_вычета"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Сумма вычета"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'Прибавка_ЗПBindingSource
        '
        Me.Прибавка_ЗПBindingSource.DataMember = "FK_Прибавка_ЗП_Зарплата"
        Me.Прибавка_ЗПBindingSource.DataSource = Me.ЗарплатаBindingSource
        '
        'Прибавка_ЗПDataGridView
        '
        Me.Прибавка_ЗПDataGridView.AutoGenerateColumns = False
        Me.Прибавка_ЗПDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Прибавка_ЗПDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16})
        Me.Прибавка_ЗПDataGridView.DataSource = Me.Прибавка_ЗПBindingSource
        Me.Прибавка_ЗПDataGridView.Location = New System.Drawing.Point(12, 295)
        Me.Прибавка_ЗПDataGridView.Name = "Прибавка_ЗПDataGridView"
        Me.Прибавка_ЗПDataGridView.ReadOnly = True
        Me.Прибавка_ЗПDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Прибавка_ЗПDataGridView.Size = New System.Drawing.Size(367, 232)
        Me.Прибавка_ЗПDataGridView.TabIndex = 8
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Код_прибавки"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Код_прибавки"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Название"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Название"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Width = 200
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Сумма_прибавки"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Сумма прибавки"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(816, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Отчёт"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(735, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Добавить"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'SalariesView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(903, 539)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Прибавка_ЗПDataGridView)
        Me.Controls.Add(Me.Вычет_ЗПDataGridView)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ЗарплатаDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.РаботникDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "SalariesView"
        Me.Text = "Зарплаты"
        CType(Me.SalariesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.РаботникBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.РаботникDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ЗарплатаBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ЗарплатаDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Вычет_ЗПBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Вычет_ЗПDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Прибавка_ЗПBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Прибавка_ЗПDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SalariesDataSet As Salaries.SalariesDataSet
    Friend WithEvents РаботникBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents РаботникTableAdapter As Salaries.SalariesDataSetTableAdapters.РаботникTableAdapter
    Friend WithEvents TableAdapterManager As Salaries.SalariesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents РаботникDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ЗарплатаTableAdapter As Salaries.SalariesDataSetTableAdapters.ЗарплатаTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ЗарплатаBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Вычет_ЗПTableAdapter As Salaries.SalariesDataSetTableAdapters.Вычет_ЗПTableAdapter
    Friend WithEvents ЗарплатаDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Вычет_ЗПBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Прибавка_ЗПTableAdapter As Salaries.SalariesDataSetTableAdapters.Прибавка_ЗПTableAdapter
    Friend WithEvents Вычет_ЗПDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Прибавка_ЗПBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Прибавка_ЗПDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
