Public Class OffreckoningReportForm

    Public Sub InitAll()
        Me.Show()
    End Sub

    Private Sub OffreckoningReportForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SalariesDataSet.OfferckoningReport' table. You can move, or remove it, as needed.
        Me.OfferckoningReportTableAdapter.Fill(Me.SalariesDataSet.OfferckoningReport)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class