<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployerCRUD
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
        Dim Код_ставкиLabel As System.Windows.Forms.Label
        Dim Код_отделаLabel As System.Windows.Forms.Label
        Dim Код_специальностиLabel As System.Windows.Forms.Label
        Me.SalariesDataSet = New Salaries.SalariesDataSet()
        Me.РаботникBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.РаботникTableAdapter = New Salaries.SalariesDataSetTableAdapters.РаботникTableAdapter()
        Me.TableAdapterManager = New Salaries.SalariesDataSetTableAdapters.TableAdapterManager()
        Me.ОтделTableAdapter = New Salaries.SalariesDataSetTableAdapters.ОтделTableAdapter()
        Me.СпециальностьTableAdapter = New Salaries.SalariesDataSetTableAdapters.СпециальностьTableAdapter()
        Me.СтавкаTableAdapter = New Salaries.SalariesDataSetTableAdapters.СтавкаTableAdapter()
        Me.ИмяTextBox = New System.Windows.Forms.TextBox()
        Me.ФамилияTextBox = New System.Windows.Forms.TextBox()
        Me.ОтчествоTextBox = New System.Windows.Forms.TextBox()
        Me.Дата_приёмаDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ТелефонTextBox = New System.Windows.Forms.TextBox()
        Me.Номер_пасспортаTextBox = New System.Windows.Forms.TextBox()
        Me.СтажTextBox = New System.Windows.Forms.TextBox()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.ОтделBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ОтделComboBox = New System.Windows.Forms.ComboBox()
        Me.СпециальностьBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.СпециальностьComboBox = New System.Windows.Forms.ComboBox()
        Me.СтавкаBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.СтавкаComboBox = New System.Windows.Forms.ComboBox()
        Me.RetairBtn = New System.Windows.Forms.Button()
        ИмяLabel = New System.Windows.Forms.Label()
        ФамилияLabel = New System.Windows.Forms.Label()
        ОтчествоLabel = New System.Windows.Forms.Label()
        Дата_приёмаLabel = New System.Windows.Forms.Label()
        ТелефонLabel = New System.Windows.Forms.Label()
        Номер_пасспортаLabel = New System.Windows.Forms.Label()
        СтажLabel = New System.Windows.Forms.Label()
        Код_ставкиLabel = New System.Windows.Forms.Label()
        Код_отделаLabel = New System.Windows.Forms.Label()
        Код_специальностиLabel = New System.Windows.Forms.Label()
        CType(Me.SalariesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.РаботникBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ОтделBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.СпециальностьBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.СтавкаBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ИмяLabel
        '
        ИмяLabel.AutoSize = True
        ИмяLabel.Location = New System.Drawing.Point(12, 9)
        ИмяLabel.Name = "ИмяLabel"
        ИмяLabel.Size = New System.Drawing.Size(32, 13)
        ИмяLabel.TabIndex = 3
        ИмяLabel.Text = "Имя:"
        '
        'ФамилияLabel
        '
        ФамилияLabel.AutoSize = True
        ФамилияLabel.Location = New System.Drawing.Point(12, 35)
        ФамилияLabel.Name = "ФамилияLabel"
        ФамилияLabel.Size = New System.Drawing.Size(59, 13)
        ФамилияLabel.TabIndex = 5
        ФамилияLabel.Text = "Фамилия:"
        '
        'ОтчествоLabel
        '
        ОтчествоLabel.AutoSize = True
        ОтчествоLabel.Location = New System.Drawing.Point(12, 61)
        ОтчествоLabel.Name = "ОтчествоLabel"
        ОтчествоLabel.Size = New System.Drawing.Size(57, 13)
        ОтчествоLabel.TabIndex = 7
        ОтчествоLabel.Text = "Отчество:"
        '
        'Дата_приёмаLabel
        '
        Дата_приёмаLabel.AutoSize = True
        Дата_приёмаLabel.Location = New System.Drawing.Point(12, 88)
        Дата_приёмаLabel.Name = "Дата_приёмаLabel"
        Дата_приёмаLabel.Size = New System.Drawing.Size(77, 13)
        Дата_приёмаLabel.TabIndex = 9
        Дата_приёмаLabel.Text = "Дата приёма:"
        '
        'ТелефонLabel
        '
        ТелефонLabel.AutoSize = True
        ТелефонLabel.Location = New System.Drawing.Point(12, 113)
        ТелефонLabel.Name = "ТелефонLabel"
        ТелефонLabel.Size = New System.Drawing.Size(55, 13)
        ТелефонLabel.TabIndex = 11
        ТелефонLabel.Text = "Телефон:"
        '
        'Номер_пасспортаLabel
        '
        Номер_пасспортаLabel.AutoSize = True
        Номер_пасспортаLabel.Location = New System.Drawing.Point(12, 139)
        Номер_пасспортаLabel.Name = "Номер_пасспортаLabel"
        Номер_пасспортаLabel.Size = New System.Drawing.Size(100, 13)
        Номер_пасспортаLabel.TabIndex = 13
        Номер_пасспортаLabel.Text = "Номер пасспорта:"
        '
        'СтажLabel
        '
        СтажLabel.AutoSize = True
        СтажLabel.Location = New System.Drawing.Point(12, 165)
        СтажLabel.Name = "СтажLabel"
        СтажLabel.Size = New System.Drawing.Size(36, 13)
        СтажLabel.TabIndex = 15
        СтажLabel.Text = "Стаж:"
        '
        'Код_ставкиLabel
        '
        Код_ставкиLabel.AutoSize = True
        Код_ставкиLabel.Location = New System.Drawing.Point(12, 191)
        Код_ставкиLabel.Name = "Код_ставкиLabel"
        Код_ставкиLabel.Size = New System.Drawing.Size(46, 13)
        Код_ставкиLabel.TabIndex = 17
        Код_ставкиLabel.Text = "Cтавка:"
        '
        'Код_отделаLabel
        '
        Код_отделаLabel.AutoSize = True
        Код_отделаLabel.Location = New System.Drawing.Point(12, 217)
        Код_отделаLabel.Name = "Код_отделаLabel"
        Код_отделаLabel.Size = New System.Drawing.Size(41, 13)
        Код_отделаLabel.TabIndex = 19
        Код_отделаLabel.Text = "Отдел:"
        '
        'Код_специальностиLabel
        '
        Код_специальностиLabel.AutoSize = True
        Код_специальностиLabel.Location = New System.Drawing.Point(12, 243)
        Код_специальностиLabel.Name = "Код_специальностиLabel"
        Код_специальностиLabel.Size = New System.Drawing.Size(88, 13)
        Код_специальностиLabel.TabIndex = 21
        Код_специальностиLabel.Text = "Cпециальность:"
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
        Me.TableAdapterManager.ОтделTableAdapter = Me.ОтделTableAdapter
        Me.TableAdapterManager.Прибавка_ЗПTableAdapter = Nothing
        Me.TableAdapterManager.ПропускTableAdapter = Nothing
        Me.TableAdapterManager.РаботникTableAdapter = Me.РаботникTableAdapter
        Me.TableAdapterManager.СпециальностьTableAdapter = Me.СпециальностьTableAdapter
        Me.TableAdapterManager.СтавкаTableAdapter = Me.СтавкаTableAdapter
        '
        'ОтделTableAdapter
        '
        Me.ОтделTableAdapter.ClearBeforeFill = True
        '
        'СпециальностьTableAdapter
        '
        Me.СпециальностьTableAdapter.ClearBeforeFill = True
        '
        'СтавкаTableAdapter
        '
        Me.СтавкаTableAdapter.ClearBeforeFill = True
        '
        'ИмяTextBox
        '
        Me.ИмяTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.РаботникBindingSource, "Имя", True))
        Me.ИмяTextBox.Location = New System.Drawing.Point(127, 6)
        Me.ИмяTextBox.Name = "ИмяTextBox"
        Me.ИмяTextBox.Size = New System.Drawing.Size(321, 20)
        Me.ИмяTextBox.TabIndex = 4
        '
        'ФамилияTextBox
        '
        Me.ФамилияTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.РаботникBindingSource, "Фамилия", True))
        Me.ФамилияTextBox.Location = New System.Drawing.Point(127, 32)
        Me.ФамилияTextBox.Name = "ФамилияTextBox"
        Me.ФамилияTextBox.Size = New System.Drawing.Size(321, 20)
        Me.ФамилияTextBox.TabIndex = 6
        '
        'ОтчествоTextBox
        '
        Me.ОтчествоTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.РаботникBindingSource, "Отчество", True))
        Me.ОтчествоTextBox.Location = New System.Drawing.Point(127, 58)
        Me.ОтчествоTextBox.Name = "ОтчествоTextBox"
        Me.ОтчествоTextBox.Size = New System.Drawing.Size(321, 20)
        Me.ОтчествоTextBox.TabIndex = 8
        '
        'Дата_приёмаDateTimePicker
        '
        Me.Дата_приёмаDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.РаботникBindingSource, "Дата_приёма", True))
        Me.Дата_приёмаDateTimePicker.Location = New System.Drawing.Point(127, 84)
        Me.Дата_приёмаDateTimePicker.Name = "Дата_приёмаDateTimePicker"
        Me.Дата_приёмаDateTimePicker.Size = New System.Drawing.Size(321, 20)
        Me.Дата_приёмаDateTimePicker.TabIndex = 10
        '
        'ТелефонTextBox
        '
        Me.ТелефонTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.РаботникBindingSource, "Телефон", True))
        Me.ТелефонTextBox.Location = New System.Drawing.Point(127, 110)
        Me.ТелефонTextBox.Name = "ТелефонTextBox"
        Me.ТелефонTextBox.Size = New System.Drawing.Size(321, 20)
        Me.ТелефонTextBox.TabIndex = 12
        '
        'Номер_пасспортаTextBox
        '
        Me.Номер_пасспортаTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.РаботникBindingSource, "Номер_пасспорта", True))
        Me.Номер_пасспортаTextBox.Location = New System.Drawing.Point(127, 136)
        Me.Номер_пасспортаTextBox.Name = "Номер_пасспортаTextBox"
        Me.Номер_пасспортаTextBox.Size = New System.Drawing.Size(321, 20)
        Me.Номер_пасспортаTextBox.TabIndex = 14
        '
        'СтажTextBox
        '
        Me.СтажTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.РаботникBindingSource, "Стаж", True))
        Me.СтажTextBox.Location = New System.Drawing.Point(127, 162)
        Me.СтажTextBox.Name = "СтажTextBox"
        Me.СтажTextBox.Size = New System.Drawing.Size(321, 20)
        Me.СтажTextBox.TabIndex = 16
        '
        'SaveBtn
        '
        Me.SaveBtn.Location = New System.Drawing.Point(15, 270)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(97, 25)
        Me.SaveBtn.TabIndex = 23
        Me.SaveBtn.Text = "Сохранить"
        Me.SaveBtn.UseVisualStyleBackColor = True
        '
        'CancelBtn
        '
        Me.CancelBtn.Location = New System.Drawing.Point(127, 270)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(93, 25)
        Me.CancelBtn.TabIndex = 24
        Me.CancelBtn.Text = "Отмена"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'DeleteBtn
        '
        Me.DeleteBtn.Location = New System.Drawing.Point(235, 270)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(94, 24)
        Me.DeleteBtn.TabIndex = 25
        Me.DeleteBtn.Text = "Удалить"
        Me.DeleteBtn.UseVisualStyleBackColor = True
        Me.DeleteBtn.Visible = False
        '
        'ОтделBindingSource
        '
        Me.ОтделBindingSource.DataMember = "Отдел"
        Me.ОтделBindingSource.DataSource = Me.SalariesDataSet
        '
        'ОтделComboBox
        '
        Me.ОтделComboBox.DataSource = Me.ОтделBindingSource
        Me.ОтделComboBox.DisplayMember = "Название"
        Me.ОтделComboBox.FormattingEnabled = True
        Me.ОтделComboBox.Location = New System.Drawing.Point(127, 215)
        Me.ОтделComboBox.Name = "ОтделComboBox"
        Me.ОтделComboBox.Size = New System.Drawing.Size(321, 21)
        Me.ОтделComboBox.TabIndex = 25
        Me.ОтделComboBox.ValueMember = "Код_отдела"
        '
        'СпециальностьBindingSource
        '
        Me.СпециальностьBindingSource.DataMember = "Специальность"
        Me.СпециальностьBindingSource.DataSource = Me.SalariesDataSet
        '
        'СпециальностьComboBox
        '
        Me.СпециальностьComboBox.DataSource = Me.СпециальностьBindingSource
        Me.СпециальностьComboBox.DisplayMember = "Название"
        Me.СпециальностьComboBox.FormattingEnabled = True
        Me.СпециальностьComboBox.Location = New System.Drawing.Point(127, 240)
        Me.СпециальностьComboBox.Name = "СпециальностьComboBox"
        Me.СпециальностьComboBox.Size = New System.Drawing.Size(321, 21)
        Me.СпециальностьComboBox.TabIndex = 25
        Me.СпециальностьComboBox.ValueMember = "Код_специальности"
        '
        'СтавкаBindingSource
        '
        Me.СтавкаBindingSource.DataMember = "Ставка"
        Me.СтавкаBindingSource.DataSource = Me.SalariesDataSet
        '
        'СтавкаComboBox
        '
        Me.СтавкаComboBox.DataSource = Me.СтавкаBindingSource
        Me.СтавкаComboBox.DisplayMember = "Название"
        Me.СтавкаComboBox.FormattingEnabled = True
        Me.СтавкаComboBox.Location = New System.Drawing.Point(127, 188)
        Me.СтавкаComboBox.Name = "СтавкаComboBox"
        Me.СтавкаComboBox.Size = New System.Drawing.Size(321, 21)
        Me.СтавкаComboBox.TabIndex = 25
        Me.СтавкаComboBox.ValueMember = "Код_ставки"
        '
        'RetairBtn
        '
        Me.RetairBtn.Location = New System.Drawing.Point(345, 269)
        Me.RetairBtn.Name = "RetairBtn"
        Me.RetairBtn.Size = New System.Drawing.Size(93, 25)
        Me.RetairBtn.TabIndex = 26
        Me.RetairBtn.Text = "Уволить"
        Me.RetairBtn.UseVisualStyleBackColor = True
        Me.RetairBtn.Visible = False
        '
        'EmployerCRUD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 321)
        Me.Controls.Add(Me.RetairBtn)
        Me.Controls.Add(Me.СтавкаComboBox)
        Me.Controls.Add(Me.СпециальностьComboBox)
        Me.Controls.Add(Me.ОтделComboBox)
        Me.Controls.Add(Me.DeleteBtn)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.SaveBtn)
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
        Me.Controls.Add(Код_ставкиLabel)
        Me.Controls.Add(Код_отделаLabel)
        Me.Controls.Add(Код_специальностиLabel)
        Me.Name = "EmployerCRUD"
        Me.Text = "Добавление/Редактирование работника"
        CType(Me.SalariesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.РаботникBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ИмяTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ФамилияTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ОтчествоTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Дата_приёмаDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ТелефонTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Номер_пасспортаTextBox As System.Windows.Forms.TextBox
    Friend WithEvents СтажTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SaveBtn As System.Windows.Forms.Button
    Friend WithEvents CancelBtn As System.Windows.Forms.Button
    Friend WithEvents DeleteBtn As System.Windows.Forms.Button
    Friend WithEvents ОтделTableAdapter As Salaries.SalariesDataSetTableAdapters.ОтделTableAdapter
    Friend WithEvents ОтделBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents СпециальностьTableAdapter As Salaries.SalariesDataSetTableAdapters.СпециальностьTableAdapter
    Friend WithEvents ОтделComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents СпециальностьBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents СтавкаTableAdapter As Salaries.SalariesDataSetTableAdapters.СтавкаTableAdapter
    Friend WithEvents СпециальностьComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents СтавкаBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents СтавкаComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents RetairBtn As System.Windows.Forms.Button
End Class
