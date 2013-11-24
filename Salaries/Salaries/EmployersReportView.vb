Public Class EmployersReportView

    Public Sub InitList()
        Me.Show()
        ' Copy sorting and filters
        Me.EmployersViewBindingSource.Filter = EmployersView.EmployersViewBindingSource.Filter
        Me.EmployersViewBindingSource.Sort = EmployersView.EmployersViewBindingSource.Sort

        Me.ReportViewer1.RefreshReport()
    End Sub

    Public Sub InitSingle(ByVal id As Integer)
        Me.Show()
        Me.EmployersViewBindingSource.Filter = "Код_работника = " & id
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub EmployersReportView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SalariesDataSet.EmployersView' table. You can move, or remove it, as needed.
        Me.EmployersViewTableAdapter.Fill(Me.SalariesDataSet.EmployersView)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class