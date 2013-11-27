Public Class QualificationsView

    Private Sub Init()
        СпециальностьDataGridView.Columns(0).Visible = False
        РаботникDataGridView.Columns(0).Visible = False
    End Sub

    Private Sub QualificationsView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SalariesDataSet.Работник' table. You can move, or remove it, as needed.
        Me.РаботникTableAdapter.Fill(Me.SalariesDataSet.Работник)
        'TODO: This line of code loads data into the 'SalariesDataSet.Специальность' table. You can move, or remove it, as needed.
        Me.СпециальностьTableAdapter.Fill(Me.SalariesDataSet.Специальность)

        Me.Init()
    End Sub

    Private Sub РаботникDataGridView_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles РаботникDataGridView.CellContentDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow = РаботникDataGridView.Rows(e.RowIndex)
            Dim employerId As Integer = selectedRow.Cells(0).Value
            EmployerView.ShowById(employerId)
        End If
    End Sub

    Private Sub СпециальностьDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles СпециальностьDataGridView.CellDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow = СпециальностьDataGridView.Rows(e.RowIndex)
            Dim spId As Integer = selectedRow.Cells(0).Value
            QualificationCRUD.LoadForm(spId)
        End If
    End Sub

    Public Sub reloadDs()
        СпециальностьTableAdapter.Fill(SalariesDataSet.Специальность)
        _СпециальностьDataGridView.Refresh()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        QualificationCRUD.InitForm()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        QualificationsReport.Show()
    End Sub
End Class