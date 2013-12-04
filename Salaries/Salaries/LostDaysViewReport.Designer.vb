<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LostDaysViewReport
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
        Me.SalariesDataSet = New Salaries.SalariesDataSet()
        Me.LostDayReportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LostDayReportTableAdapter = New Salaries.SalariesDataSetTableAdapters.LostDayReportTableAdapter()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.SalariesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LostDayReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SalariesDataSet
        '
        Me.SalariesDataSet.DataSetName = "SalariesDataSet"
        Me.SalariesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LostDayReportBindingSource
        '
        Me.LostDayReportBindingSource.DataMember = "LostDayReport"
        Me.LostDayReportBindingSource.DataSource = Me.SalariesDataSet
        '
        'LostDayReportTableAdapter
        '
        Me.LostDayReportTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "LostDaysDataSet"
        ReportDataSource1.Value = Me.LostDayReportBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Salaries.LostDaysReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(13, 13)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(557, 254)
        Me.ReportViewer1.TabIndex = 0
        '
        'LostDaysViewReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 279)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "LostDaysViewReport"
        Me.Text = "Пропуски работника"
        CType(Me.SalariesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LostDayReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LostDayReportBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SalariesDataSet As Salaries.SalariesDataSet
    Friend WithEvents LostDayReportTableAdapter As Salaries.SalariesDataSetTableAdapters.LostDayReportTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
