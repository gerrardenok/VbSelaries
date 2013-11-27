<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QualificationCRUD
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
        Me.SalariesDataSet = New Salaries.SalariesDataSet()
        Me.СпециальностьBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.СпециальностьTableAdapter = New Salaries.SalariesDataSetTableAdapters.СпециальностьTableAdapter()
        Me.TableAdapterManager = New Salaries.SalariesDataSetTableAdapters.TableAdapterManager()
        Me.НазваниеTextBox = New System.Windows.Forms.TextBox()
        Me.ОписаниеTextBox = New System.Windows.Forms.TextBox()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.FormErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        НазваниеLabel = New System.Windows.Forms.Label()
        ОписаниеLabel = New System.Windows.Forms.Label()
        CType(Me.SalariesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.СпециальностьBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableAdapterManager.РаботникTableAdapter = Nothing
        Me.TableAdapterManager.СпециальностьTableAdapter = Me.СпециальностьTableAdapter
        Me.TableAdapterManager.СтавкаTableAdapter = Nothing
        '
        'НазваниеLabel
        '
        НазваниеLabel.AutoSize = True
        НазваниеLabel.Location = New System.Drawing.Point(12, 21)
        НазваниеLabel.Name = "НазваниеLabel"
        НазваниеLabel.Size = New System.Drawing.Size(60, 13)
        НазваниеLabel.TabIndex = 3
        НазваниеLabel.Text = "Название:"
        '
        'НазваниеTextBox
        '
        Me.НазваниеTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.СпециальностьBindingSource, "Название", True))
        Me.НазваниеTextBox.Location = New System.Drawing.Point(78, 18)
        Me.НазваниеTextBox.Name = "НазваниеTextBox"
        Me.НазваниеTextBox.Size = New System.Drawing.Size(282, 20)
        Me.НазваниеTextBox.TabIndex = 4
        '
        'ОписаниеLabel
        '
        ОписаниеLabel.AutoSize = True
        ОписаниеLabel.Location = New System.Drawing.Point(12, 53)
        ОписаниеLabel.Name = "ОписаниеLabel"
        ОписаниеLabel.Size = New System.Drawing.Size(60, 13)
        ОписаниеLabel.TabIndex = 5
        ОписаниеLabel.Text = "Описание:"
        '
        'ОписаниеTextBox
        '
        Me.ОписаниеTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.СпециальностьBindingSource, "Описание", True))
        Me.ОписаниеTextBox.Location = New System.Drawing.Point(78, 50)
        Me.ОписаниеTextBox.Multiline = True
        Me.ОписаниеTextBox.Name = "ОписаниеTextBox"
        Me.ОписаниеTextBox.Size = New System.Drawing.Size(282, 53)
        Me.ОписаниеTextBox.TabIndex = 6
        '
        'DeleteBtn
        '
        Me.DeleteBtn.Location = New System.Drawing.Point(269, 133)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(91, 32)
        Me.DeleteBtn.TabIndex = 13
        Me.DeleteBtn.Text = "Удалить"
        Me.DeleteBtn.UseVisualStyleBackColor = True
        Me.DeleteBtn.Visible = False
        '
        'CancelBtn
        '
        Me.CancelBtn.Location = New System.Drawing.Point(137, 133)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(111, 32)
        Me.CancelBtn.TabIndex = 12
        Me.CancelBtn.Text = "Отмена"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'SaveBtn
        '
        Me.SaveBtn.Location = New System.Drawing.Point(15, 133)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(95, 32)
        Me.SaveBtn.TabIndex = 11
        Me.SaveBtn.Text = "Сохранить"
        Me.SaveBtn.UseVisualStyleBackColor = True
        '
        'FormErrorProvider
        '
        Me.FormErrorProvider.ContainerControl = Me
        '
        'QualificationCRUD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(383, 179)
        Me.Controls.Add(Me.DeleteBtn)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(НазваниеLabel)
        Me.Controls.Add(Me.НазваниеTextBox)
        Me.Controls.Add(ОписаниеLabel)
        Me.Controls.Add(Me.ОписаниеTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "QualificationCRUD"
        Me.Text = "QualificationCRUD"
        CType(Me.SalariesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.СпециальностьBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SalariesDataSet As Salaries.SalariesDataSet
    Friend WithEvents СпециальностьBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents СпециальностьTableAdapter As Salaries.SalariesDataSetTableAdapters.СпециальностьTableAdapter
    Friend WithEvents TableAdapterManager As Salaries.SalariesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents НазваниеTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ОписаниеTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DeleteBtn As System.Windows.Forms.Button
    Friend WithEvents CancelBtn As System.Windows.Forms.Button
    Friend WithEvents SaveBtn As System.Windows.Forms.Button
    Friend WithEvents FormErrorProvider As System.Windows.Forms.ErrorProvider
End Class
