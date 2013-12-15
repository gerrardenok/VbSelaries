<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelariesReportingForm
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
        Me.SelaryesReportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalariesDataSet = New Salaries.SalariesDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SelaryesReportTableAdapter = New Salaries.SalariesDataSetTableAdapters.SelaryesReportTableAdapter()
        CType(Me.SelaryesReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalariesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SelaryesReportBindingSource
        '
        Me.SelaryesReportBindingSource.DataMember = "SelaryesReport"
        Me.SelaryesReportBindingSource.DataSource = Me.SalariesDataSet
        '
        'SalariesDataSet
        '
        Me.SalariesDataSet.DataSetName = "SalariesDataSet"
        Me.SalariesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "SelariesReportDataSet"
        ReportDataSource1.Value = Me.SelaryesReportBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Salaries.SelariesReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(13, 13)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(541, 332)
        Me.ReportViewer1.TabIndex = 0
        '
        'SelaryesReportTableAdapter
        '
        Me.SelaryesReportTableAdapter.ClearBeforeFill = True
        '
        'SelariesReportingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 357)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "SelariesReportingForm"
        Me.Text = "Ведомость по ЗП"
        CType(Me.SelaryesReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalariesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SelaryesReportBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SalariesDataSet As Salaries.SalariesDataSet
    Friend WithEvents SelaryesReportTableAdapter As Salaries.SalariesDataSetTableAdapters.SelaryesReportTableAdapter
End Class
