Public Class RFPIncreaseReportForm

    Public Sub InitAll()
        Me.Show()
    End Sub

    Private Sub RFPIncreaseReportForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SalariesDataSet.RFPIncreaseReport' table. You can move, or remove it, as needed.
        Me.RFPIncreaseReportTableAdapter.Fill(Me.SalariesDataSet.RFPIncreaseReport)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class