<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OmissionsView
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
        Me.РаботникDataGridView = New System.Windows.Forms.DataGridView()
        Me.ПропускBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ПропускTableAdapter = New Salaries.SalariesDataSetTableAdapters.ПропускTableAdapter()
        Me.ПропускDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Код_работника = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.SalariesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.РаботникBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.РаботникDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ПропускBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ПропускDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableAdapterManager.Вычет_ЗПTableAdapter = Nothing
        Me.TableAdapterManager.ЗарплатаTableAdapter = Nothing
        Me.TableAdapterManager.ОтделTableAdapter = Nothing
        Me.TableAdapterManager.Прибавка_ЗПTableAdapter = Nothing
        Me.TableAdapterManager.ПропускTableAdapter = Me.ПропускTableAdapter
        Me.TableAdapterManager.РаботникTableAdapter = Me.РаботникTableAdapter
        Me.TableAdapterManager.СпециальностьTableAdapter = Nothing
        Me.TableAdapterManager.СтавкаTableAdapter = Nothing
        '
        'РаботникDataGridView
        '
        Me.РаботникDataGridView.AutoGenerateColumns = False
        Me.РаботникDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.РаботникDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Код_работника, Me.DataGridViewTextBoxColumn13})
        Me.РаботникDataGridView.DataSource = Me.РаботникBindingSource
        Me.РаботникDataGridView.Location = New System.Drawing.Point(12, 37)
        Me.РаботникDataGridView.Name = "РаботникDataGridView"
        Me.РаботникDataGridView.ReadOnly = True
        Me.РаботникDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.РаботникDataGridView.Size = New System.Drawing.Size(357, 300)
        Me.РаботникDataGridView.TabIndex = 1
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
        Me.ПропускDataGridView.AutoGenerateColumns = False
        Me.ПропускDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ПропускDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn15})
        Me.ПропускDataGridView.DataSource = Me.ПропускBindingSource
        Me.ПропускDataGridView.Location = New System.Drawing.Point(387, 38)
        Me.ПропускDataGridView.Name = "ПропускDataGridView"
        Me.ПропускDataGridView.ReadOnly = True
        Me.ПропускDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ПропускDataGridView.Size = New System.Drawing.Size(499, 299)
        Me.ПропускDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "День"
        Me.DataGridViewTextBoxColumn20.HeaderText = "День"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        Me.DataGridViewTextBoxColumn20.Width = 50
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Месяц"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Месяц"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Width = 50
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "Год"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Год"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Width = 70
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Оплата"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Оплата"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn16.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn16.Width = 70
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Причина"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Причина"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Width = 200
        '
        'Код_работника
        '
        Me.Код_работника.DataPropertyName = "Код_работника"
        Me.Код_работника.HeaderText = "Код_работника"
        Me.Код_работника.Name = "Код_работника"
        Me.Код_работника.ReadOnly = True
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
        Me.Label1.Location = New System.Drawing.Point(12, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 33)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Работники"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Chocolate
        Me.Label2.Location = New System.Drawing.Point(382, -1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 33)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Пропуски"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(730, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Добавить"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(811, 9)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Отчёт"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'OmissionsView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(898, 349)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ПропускDataGridView)
        Me.Controls.Add(Me.РаботникDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "OmissionsView"
        Me.Text = "Пропуски"
        CType(Me.SalariesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.РаботникBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.РаботникDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ПропускBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ПропускDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SalariesDataSet As Salaries.SalariesDataSet
    Friend WithEvents РаботникBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents РаботникTableAdapter As Salaries.SalariesDataSetTableAdapters.РаботникTableAdapter
    Friend WithEvents TableAdapterManager As Salaries.SalariesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents РаботникDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ПропускTableAdapter As Salaries.SalariesDataSetTableAdapters.ПропускTableAdapter
    Friend WithEvents ПропускBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Код_работника As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ПропускDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
