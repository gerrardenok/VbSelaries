Public Class EmployersReportView

    Private Sub EmployersReportView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SalariesDataSet.EmployersView' table. You can move, or remove it, as needed.
        Me.EmployersViewTableAdapter.Fill(Me.SalariesDataSet.EmployersView)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class