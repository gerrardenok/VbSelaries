<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LostDayCRUD
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
        Dim ПричинаLabel As System.Windows.Forms.Label
        Dim Код_работникаLabel As System.Windows.Forms.Label
        Dim ОплатаLabel As System.Windows.Forms.Label
        Dim ГодLabel As System.Windows.Forms.Label
        Dim ДеньLabel1 As System.Windows.Forms.Label
        Dim МесяцLabel As System.Windows.Forms.Label
        Me.SalariesDataSet = New Salaries.SalariesDataSet()
        Me.ПропускBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ПропускTableAdapter = New Salaries.SalariesDataSetTableAdapters.ПропускTableAdapter()
        Me.TableAdapterManager = New Salaries.SalariesDataSetTableAdapters.TableAdapterManager()
        Me.РаботникTableAdapter = New Salaries.SalariesDataSetTableAdapters.РаботникTableAdapter()
        Me.ПричинаTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.РаботникBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.РаботникComboBox = New System.Windows.Forms.ComboBox()
        Me.ОплатаCheckBox = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.FormErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ГодMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.ДеньMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.МесяцMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        ПричинаLabel = New System.Windows.Forms.Label()
        Код_работникаLabel = New System.Windows.Forms.Label()
        ОплатаLabel = New System.Windows.Forms.Label()
        ГодLabel = New System.Windows.Forms.Label()
        ДеньLabel1 = New System.Windows.Forms.Label()
        МесяцLabel = New System.Windows.Forms.Label()
        CType(Me.SalariesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ПропускBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.РаботникBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ПричинаLabel
        '
        ПричинаLabel.AutoSize = True
        ПричинаLabel.Location = New System.Drawing.Point(14, 146)
        ПричинаLabel.Name = "ПричинаLabel"
        ПричинаLabel.Size = New System.Drawing.Size(53, 13)
        ПричинаLabel.TabIndex = 3
        ПричинаLabel.Text = "Причина:"
        '
        'Код_работникаLabel
        '
        Код_работникаLabel.AutoSize = True
        Код_работникаLabel.Location = New System.Drawing.Point(14, 44)
        Код_работникаLabel.Name = "Код_работникаLabel"
        Код_работникаLabel.Size = New System.Drawing.Size(58, 13)
        Код_работникаLabel.TabIndex = 7
        Код_работникаLabel.Text = "Работник:"
        '
        'ОплатаLabel
        '
        ОплатаLabel.AutoSize = True
        ОплатаLabel.Location = New System.Drawing.Point(17, 212)
        ОплатаLabel.Name = "ОплатаLabel"
        ОплатаLabel.Size = New System.Drawing.Size(47, 13)
        ОплатаLabel.TabIndex = 13
        ОплатаLabel.Text = "Оплата:"
        '
        'ГодLabel
        '
        ГодLabel.AutoSize = True
        ГодLabel.Location = New System.Drawing.Point(14, 121)
        ГодLabel.Name = "ГодLabel"
        ГодLabel.Size = New System.Drawing.Size(28, 13)
        ГодLabel.TabIndex = 17
        ГодLabel.Text = "Год:"
        '
        'SalariesDataSet
        '
        Me.SalariesDataSet.DataSetName = "SalariesDataSet"
        Me.SalariesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ПропускBindingSource
        '
        Me.ПропускBindingSource.DataMember = "Пропуск"
        Me.ПропускBindingSource.DataSource = Me.SalariesDataSet
        '
        'ПропускTableAdapter
        '
        Me.ПропускTableAdapter.ClearBeforeFill = True
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
        'РаботникTableAdapter
        '
        Me.РаботникTableAdapter.ClearBeforeFill = True
        '
        'ПричинаTextBox
        '
        Me.ПричинаTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПропускBindingSource, "Причина", True))
        Me.ПричинаTextBox.Location = New System.Drawing.Point(105, 143)
        Me.ПричинаTextBox.Multiline = True
        Me.ПричинаTextBox.Name = "ПричинаTextBox"
        Me.ПричинаTextBox.Size = New System.Drawing.Size(300, 58)
        Me.ПричинаTextBox.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Chocolate
        Me.Label1.Location = New System.Drawing.Point(12, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(453, 33)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Добавить пропуск"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.РаботникComboBox.Location = New System.Drawing.Point(105, 41)
        Me.РаботникComboBox.Name = "РаботникComboBox"
        Me.РаботникComboBox.Size = New System.Drawing.Size(300, 21)
        Me.РаботникComboBox.TabIndex = 13
        Me.РаботникComboBox.ValueMember = "Код_работника"
        '
        'ОплатаCheckBox
        '
        Me.ОплатаCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ПропускBindingSource, "Оплата", True))
        Me.ОплатаCheckBox.Location = New System.Drawing.Point(105, 207)
        Me.ОплатаCheckBox.Name = "ОплатаCheckBox"
        Me.ОплатаCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.ОплатаCheckBox.TabIndex = 14
        Me.ОплатаCheckBox.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(85, 240)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 37)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Добавить"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(225, 240)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(124, 37)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Отмена"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FormErrorProvider
        '
        Me.FormErrorProvider.ContainerControl = Me
        '
        'ГодMaskedTextBox
        '
        Me.ГодMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПропускBindingSource, "Год", True))
        Me.ГодMaskedTextBox.Location = New System.Drawing.Point(105, 118)
        Me.ГодMaskedTextBox.Mask = "0000"
        Me.ГодMaskedTextBox.Name = "ГодMaskedTextBox"
        Me.ГодMaskedTextBox.Size = New System.Drawing.Size(300, 20)
        Me.ГодMaskedTextBox.TabIndex = 18
        '
        'ДеньLabel1
        '
        ДеньLabel1.AutoSize = True
        ДеньLabel1.Location = New System.Drawing.Point(17, 71)
        ДеньLabel1.Name = "ДеньLabel1"
        ДеньLabel1.Size = New System.Drawing.Size(37, 13)
        ДеньLabel1.TabIndex = 19
        ДеньLabel1.Text = "День:"
        '
        'ДеньMaskedTextBox
        '
        Me.ДеньMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПропускBindingSource, "День", True))
        Me.ДеньMaskedTextBox.Location = New System.Drawing.Point(105, 66)
        Me.ДеньMaskedTextBox.Mask = "00"
        Me.ДеньMaskedTextBox.Name = "ДеньMaskedTextBox"
        Me.ДеньMaskedTextBox.Size = New System.Drawing.Size(300, 20)
        Me.ДеньMaskedTextBox.TabIndex = 20
        '
        'МесяцLabel
        '
        МесяцLabel.AutoSize = True
        МесяцLabel.Location = New System.Drawing.Point(17, 98)
        МесяцLabel.Name = "МесяцLabel"
        МесяцLabel.Size = New System.Drawing.Size(43, 13)
        МесяцLabel.TabIndex = 20
        МесяцLabel.Text = "Месяц:"
        '
        'МесяцMaskedTextBox
        '
        Me.МесяцMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПропускBindingSource, "Месяц", True))
        Me.МесяцMaskedTextBox.Location = New System.Drawing.Point(105, 91)
        Me.МесяцMaskedTextBox.Mask = "00"
        Me.МесяцMaskedTextBox.Name = "МесяцMaskedTextBox"
        Me.МесяцMaskedTextBox.Size = New System.Drawing.Size(300, 20)
        Me.МесяцMaskedTextBox.TabIndex = 21
        '
        'LostDayCRUD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 297)
        Me.Controls.Add(МесяцLabel)
        Me.Controls.Add(Me.МесяцMaskedTextBox)
        Me.Controls.Add(ДеньLabel1)
        Me.Controls.Add(Me.ДеньMaskedTextBox)
        Me.Controls.Add(Me.ГодMaskedTextBox)
        Me.Controls.Add(ГодLabel)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(ОплатаLabel)
        Me.Controls.Add(Me.ОплатаCheckBox)
        Me.Controls.Add(Me.РаботникComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(ПричинаLabel)
        Me.Controls.Add(Me.ПричинаTextBox)
        Me.Controls.Add(Код_работникаLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "LostDayCRUD"
        Me.Text = "Добавить"
        CType(Me.SalariesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ПропускBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.РаботникBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SalariesDataSet As Salaries.SalariesDataSet
    Friend WithEvents ПропускBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ПропускTableAdapter As Salaries.SalariesDataSetTableAdapters.ПропускTableAdapter
    Friend WithEvents TableAdapterManager As Salaries.SalariesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ПричинаTextBox As System.Windows.Forms.TextBox
    Friend WithEvents РаботникTableAdapter As Salaries.SalariesDataSetTableAdapters.РаботникTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents РаботникBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents РаботникComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ОплатаCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents FormErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents ГодMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents МесяцMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ДеньMaskedTextBox As System.Windows.Forms.MaskedTextBox
End Class
