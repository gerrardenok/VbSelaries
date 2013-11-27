<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QualificationsView
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
        Me.СпециальностьBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.СпециальностьTableAdapter = New Salaries.SalariesDataSetTableAdapters.СпециальностьTableAdapter()
        Me.TableAdapterManager = New Salaries.SalariesDataSetTableAdapters.TableAdapterManager()
        Me.РаботникTableAdapter = New Salaries.SalariesDataSetTableAdapters.РаботникTableAdapter()
        Me.СпециальностьDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.РаботникBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.РаботникDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.SalariesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.СпециальностьBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.СпециальностьDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.РаботникBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.РаботникDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SalariesDataSet
        '
        Me.SalariesDataSet.DataSetName = "SalariesDataSet"
        Me.SalariesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.TableAdapterManager.СпециальностьTableAdapter = Me.СпециальностьTableAdapter
        Me.TableAdapterManager.СтавкаTableAdapter = Nothing
        '
        'РаботникTableAdapter
        '
        Me.РаботникTableAdapter.ClearBeforeFill = True
        '
        'СпециальностьDataGridView
        '
        Me.СпециальностьDataGridView.AutoGenerateColumns = False
        Me.СпециальностьDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.СпециальностьDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.СпециальностьDataGridView.DataSource = Me.СпециальностьBindingSource
        Me.СпециальностьDataGridView.Location = New System.Drawing.Point(12, 38)
        Me.СпециальностьDataGridView.Name = "СпециальностьDataGridView"
        Me.СпециальностьDataGridView.ReadOnly = True
        Me.СпециальностьDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.СпециальностьDataGridView.Size = New System.Drawing.Size(532, 184)
        Me.СпециальностьDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Код_специальности"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Код_специальности"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Название"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Название"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Описание"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Описание"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 300
        '
        'РаботникBindingSource
        '
        Me.РаботникBindingSource.DataMember = "FK_Работник_Специальность"
        Me.РаботникBindingSource.DataSource = Me.СпециальностьBindingSource
        '
        'РаботникDataGridView
        '
        Me.РаботникDataGridView.AutoGenerateColumns = False
        Me.РаботникDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.РаботникDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.РаботникDataGridView.DataSource = Me.РаботникBindingSource
        Me.РаботникDataGridView.Location = New System.Drawing.Point(12, 264)
        Me.РаботникDataGridView.Name = "РаботникDataGridView"
        Me.РаботникDataGridView.ReadOnly = True
        Me.РаботникDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.РаботникDataGridView.Size = New System.Drawing.Size(532, 222)
        Me.РаботникDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Код_работника"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Код_работника"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Имя"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Имя"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 120
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Фамилия"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Фамилия"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 120
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Отчество"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Отчество"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 120
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(387, 9)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Добавить"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(468, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Отчёт"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Chocolate
        Me.Label1.Location = New System.Drawing.Point(214, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 33)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Отделы"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Chocolate
        Me.Label2.Location = New System.Drawing.Point(214, 225)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 33)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Работники"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'QualificationsView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 498)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.РаботникDataGridView)
        Me.Controls.Add(Me.СпециальностьDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "QualificationsView"
        Me.Text = "Специальности"
        CType(Me.SalariesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.СпециальностьBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.СпециальностьDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.РаботникBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.РаботникDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SalariesDataSet As Salaries.SalariesDataSet
    Friend WithEvents СпециальностьBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents СпециальностьTableAdapter As Salaries.SalariesDataSetTableAdapters.СпециальностьTableAdapter
    Friend WithEvents TableAdapterManager As Salaries.SalariesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents СпециальностьDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents РаботникTableAdapter As Salaries.SalariesDataSetTableAdapters.РаботникTableAdapter
    Friend WithEvents РаботникBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents РаботникDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
