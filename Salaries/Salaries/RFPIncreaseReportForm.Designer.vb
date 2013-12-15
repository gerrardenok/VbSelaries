<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RFPIncreaseReportForm
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SalariesDataSet = New Salaries.SalariesDataSet()
        Me.RFPIncreaseReportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RFPIncreaseReportTableAdapter = New Salaries.SalariesDataSetTableAdapters.RFPIncreaseReportTableAdapter()
        CType(Me.SalariesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RFPIncreaseReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "RFPIncreaseDataSet"
        ReportDataSource1.Value = Me.RFPIncreaseReportBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Salaries.RFPIncreaseReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(13, 13)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(629, 397)
        Me.ReportViewer1.TabIndex = 0
        '
        'SalariesDataSet
        '
        Me.SalariesDataSet.DataSetName = "SalariesDataSet"
        Me.SalariesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RFPIncreaseReportBindingSource
        '
        Me.RFPIncreaseReportBindingSource.DataMember = "RFPIncreaseReport"
        Me.RFPIncreaseReportBindingSource.DataSource = Me.SalariesDataSet
        '
        'RFPIncreaseReportTableAdapter
        '
        Me.RFPIncreaseReportTableAdapter.ClearBeforeFill = True
        '
        'RFPIncreaseReportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 422)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "RFPIncreaseReportForm"
        Me.Text = "RFPIncreaseReportForm"
        CType(Me.SalariesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RFPIncreaseReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents RFPIncreaseReportBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SalariesDataSet As Salaries.SalariesDataSet
    Friend WithEvents RFPIncreaseReportTableAdapter As Salaries.SalariesDataSetTableAdapters.RFPIncreaseReportTableAdapter
End Class
