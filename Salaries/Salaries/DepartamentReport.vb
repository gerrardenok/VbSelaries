Public Class DepartamentReport

    Private Sub DepartamentReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SalariesDataSet.Отдел' table. You can move, or remove it, as needed.
        Me.ОтделTableAdapter.Fill(Me.SalariesDataSet.Отдел)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class