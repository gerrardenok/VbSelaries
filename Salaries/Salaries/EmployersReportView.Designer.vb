<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployersReportView
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.EmployersViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalariesDataSet = New Salaries.SalariesDataSet()
        Me.EmployersViewTableAdapter = New Salaries.SalariesDataSetTableAdapters.EmployersViewTableAdapter()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.EmployersViewBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployersViewBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.EmployersViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalariesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployersViewBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployersViewBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EmployersViewBindingSource
        '
        Me.EmployersViewBindingSource.DataMember = "EmployersView"
        Me.EmployersViewBindingSource.DataSource = Me.SalariesDataSet
        '
        'SalariesDataSet
        '
        Me.SalariesDataSet.DataSetName = "SalariesDataSet"
        Me.SalariesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmployersViewTableAdapter
        '
        Me.EmployersViewTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "EmployersViewDataSet"
        ReportDataSource1.Value = Me.EmployersViewBindingSource2
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Salaries.EmployersReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(517, 351)
        Me.ReportViewer1.TabIndex = 0
        '
        'EmployersViewBindingSource1
        '
        Me.EmployersViewBindingSource1.DataMember = "EmployersView"
        Me.EmployersViewBindingSource1.DataSource = Me.SalariesDataSet
        '
        'EmployersViewBindingSource2
        '
        Me.EmployersViewBindingSource2.DataMember = "EmployersView"
        Me.EmployersViewBindingSource2.DataSource = Me.SalariesDataSet
        '
        'EmployersReportView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 375)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "EmployersReportView"
        Me.Text = "Отчёт по Работникам"
        CType(Me.EmployersViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalariesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployersViewBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployersViewBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EmployersViewBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SalariesDataSet As Salaries.SalariesDataSet
    Friend WithEvents EmployersViewTableAdapter As Salaries.SalariesDataSetTableAdapters.EmployersViewTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents EmployersViewBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents EmployersViewBindingSource1 As System.Windows.Forms.BindingSource
End Class
