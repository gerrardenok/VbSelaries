Public Class LostDaysViewReport
    Private Sub LostDaysViewReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SalariesDataSet.LostDayReport' table. You can move, or remove it, as needed.
        Me.LostDayReportTableAdapter.Fill(Me.SalariesDataSet.LostDayReport)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class