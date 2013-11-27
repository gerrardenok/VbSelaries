<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DepartamentCRUD
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
        Dim ОписаниеLabel As System.Windows.Forms.Label
        Dim Фонд_ЗПLabel As System.Windows.Forms.Label
        Me.SalariesDataSet = New Salaries.SalariesDataSet()
        Me.ОтделBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ОтделTableAdapter = New Salaries.SalariesDataSetTableAdapters.ОтделTableAdapter()
        Me.TableAdapterManager = New Salaries.SalariesDataSetTableAdapters.TableAdapterManager()
        Me.НазваниеTextBox = New System.Windows.Forms.TextBox()
        Me.ОписаниеTextBox = New System.Windows.Forms.TextBox()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.FormErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Фонд_ЗПTextBox = New System.Windows.Forms.TextBox()
        НазваниеLabel = New System.Windows.Forms.Label()
        ОписаниеLabel = New System.Windows.Forms.Label()
        Фонд_ЗПLabel = New System.Windows.Forms.Label()
        CType(Me.SalariesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ОтделBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'НазваниеLabel
        '
        НазваниеLabel.AutoSize = True
        НазваниеLabel.Location = New System.Drawing.Point(7, 15)
        НазваниеLabel.Name = "НазваниеLabel"
        НазваниеLabel.Size = New System.Drawing.Size(60, 13)
        НазваниеLabel.TabIndex = 3
        НазваниеLabel.Text = "Название:"
        '
        'ОписаниеLabel
        '
        ОписаниеLabel.AutoSize = True
        ОписаниеLabel.Location = New System.Drawing.Point(7, 41)
        ОписаниеLabel.Name = "ОписаниеLabel"
        ОписаниеLabel.Size = New System.Drawing.Size(60, 13)
        ОписаниеLabel.TabIndex = 5
        ОписаниеLabel.Text = "Описание:"
        '
        'SalariesDataSet
        '
        Me.SalariesDataSet.DataSetName = "SalariesDataSet"
        Me.SalariesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Salaries.SalariesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Вычет_ЗПTableAdapter = Nothing
        Me.TableAdapterManager.ЗарплатаTableAdapter = Nothing
        Me.TableAdapterManager.ОтделTableAdapter = Me.ОтделTableAdapter
        Me.TableAdapterManager.Прибавка_ЗПTableAdapter = Nothing
        Me.TableAdapterManager.ПропускTableAdapter = Nothing
        Me.TableAdapterManager.РаботникTableAdapter = Nothing
        Me.TableAdapterManager.СпециальностьTableAdapter = Nothing
        Me.TableAdapterManager.СтавкаTableAdapter = Nothing
        '
        'НазваниеTextBox
        '
        Me.НазваниеTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ОтделBindingSource, "Название", True))
        Me.НазваниеTextBox.Location = New System.Drawing.Point(80, 12)
        Me.НазваниеTextBox.Name = "НазваниеTextBox"
        Me.НазваниеTextBox.Size = New System.Drawing.Size(353, 20)
        Me.НазваниеTextBox.TabIndex = 4
        '
        'ОписаниеTextBox
        '
        Me.ОписаниеTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ОтделBindingSource, "Описание", True))
        Me.ОписаниеTextBox.Location = New System.Drawing.Point(80, 38)
        Me.ОписаниеTextBox.Multiline = True
        Me.ОписаниеTextBox.Name = "ОписаниеTextBox"
        Me.ОписаниеTextBox.Size = New System.Drawing.Size(353, 47)
        Me.ОписаниеTextBox.TabIndex = 6
        '
        'SaveBtn
        '
        Me.SaveBtn.Location = New System.Drawing.Point(10, 128)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(110, 43)
        Me.SaveBtn.TabIndex = 8
        Me.SaveBtn.Text = "Сохранить"
        Me.SaveBtn.UseVisualStyleBackColor = True
        '
        'CancelBtn
        '
        Me.CancelBtn.Location = New System.Drawing.Point(167, 128)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(110, 43)
        Me.CancelBtn.TabIndex = 9
        Me.CancelBtn.Text = "Отмена"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'DeleteBtn
        '
        Me.DeleteBtn.Location = New System.Drawing.Point(323, 128)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(110, 43)
        Me.DeleteBtn.TabIndex = 10
        Me.DeleteBtn.Text = "Удалить"
        Me.DeleteBtn.UseVisualStyleBackColor = True
        Me.DeleteBtn.Visible = False
        '
        'FormErrorProvider
        '
        Me.FormErrorProvider.ContainerControl = Me
        '
        'Фонд_ЗПLabel
        '
        Фонд_ЗПLabel.AutoSize = True
        Фонд_ЗПLabel.Location = New System.Drawing.Point(7, 91)
        Фонд_ЗПLabel.Name = "Фонд_ЗПLabel"
        Фонд_ЗПLabel.Size = New System.Drawing.Size(57, 13)
        Фонд_ЗПLabel.TabIndex = 10
        Фонд_ЗПLabel.Text = "Фонд ЗП:"
        '
        'Фонд_ЗПTextBox
        '
        Me.Фонд_ЗПTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ОтделBindingSource, "Фонд_ЗП", True))
        Me.Фонд_ЗПTextBox.Location = New System.Drawing.Point(80, 91)
        Me.Фонд_ЗПTextBox.Name = "Фонд_ЗПTextBox"
        Me.Фонд_ЗПTextBox.Size = New System.Drawing.Size(353, 20)
        Me.Фонд_ЗПTextBox.TabIndex = 11
        '
        'DepartamentCRUD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 191)
        Me.Controls.Add(Фонд_ЗПLabel)
        Me.Controls.Add(Me.Фонд_ЗПTextBox)
        Me.Controls.Add(Me.DeleteBtn)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(НазваниеLabel)
        Me.Controls.Add(Me.НазваниеTextBox)
        Me.Controls.Add(ОписаниеLabel)
        Me.Controls.Add(Me.ОписаниеTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "DepartamentCRUD"
        Me.Text = "DepartamentCRUD"
        CType(Me.SalariesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ОтделBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SalariesDataSet As Salaries.SalariesDataSet
    Friend WithEvents ОтделBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ОтделTableAdapter As Salaries.SalariesDataSetTableAdapters.ОтделTableAdapter
    Friend WithEvents TableAdapterManager As Salaries.SalariesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents НазваниеTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ОписаниеTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SaveBtn As System.Windows.Forms.Button
    Friend WithEvents CancelBtn As System.Windows.Forms.Button
    Friend WithEvents DeleteBtn As System.Windows.Forms.Button
    Friend WithEvents FormErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents Фонд_ЗПTextBox As System.Windows.Forms.TextBox
End Class
