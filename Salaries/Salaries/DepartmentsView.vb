Public Class DepartmentsView

    Private Sub Init()
        РаботникDataGridView.Columns(0).Visible = False
        ОтделDataGridView.Columns(0).Visible = False
    End Sub

    Public Sub reloadDs()
        ОтделTableAdapter.Fill(SalariesDataSet.Отдел)
        ОтделDataGridView.Refresh()
    End Sub

    Private Sub DepartmentsView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SalariesDataSet.Работник' table. You can move, or remove it, as needed.
        Me.РаботникTableAdapter.Fill(Me.SalariesDataSet.Работник)
        'TODO: This line of code loads data into the 'SalariesDataSet.Отдел' table. You can move, or remove it, as needed.
        Me.ОтделTableAdapter.Fill(Me.SalariesDataSet.Отдел)

        Me.Init()
    End Sub

    Private Sub РаботникDataGridView_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles РаботникDataGridView.CellContentDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow = РаботникDataGridView.Rows(e.RowIndex)
            Dim employerId As Integer = selectedRow.Cells(0).Value
            EmployerView.ShowById(employerId)
        End If
    End Sub

    Private Sub ОтделDataGridView_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ОтделDataGridView.CellContentDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow = ОтделDataGridView.Rows(e.RowIndex)
            Dim id As Integer = selectedRow.Cells(0).Value
            DepartamentCRUD.LoadForm(id)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DepartamentCRUD.InitForm()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DepartamentReport.Show()
    End Sub
End Class