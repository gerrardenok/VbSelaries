Public Class SelariesReportingForm

    Public Sub InitAll()
        Me.Show()
    End Sub

    Private Sub SelariesReportingForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SalariesDataSet.SelaryesReport' table. You can move, or remove it, as needed.
        Me.SelaryesReportTableAdapter.Fill(Me.SalariesDataSet.SelaryesReport)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class