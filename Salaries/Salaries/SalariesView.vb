Public Class SalariesView

    Public Sub InitForm()
        Me.Show()
        HiddenFields()
    End Sub

    Public Sub LoadFormByEmplId(ByVal employerId As Integer)
        Me.Show()
        РаботникBindingSource.Filter = "Код_работника = " & employerId
        HiddenFields()
    End Sub

    Private Sub HiddenFields()
        РаботникDataGridView.Columns(0).Visible = False
        ЗарплатаDataGridView.Columns(0).Visible = False
        Прибавка_ЗПDataGridView.Columns(0).Visible = False
        Вычет_ЗПDataGridView.Columns(0).Visible = False
    End Sub

    Private Sub РаботникBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.РаботникBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SalariesDataSet)

    End Sub

    Private Sub SalariesView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SalariesDataSet.Прибавка_ЗП' table. You can move, or remove it, as needed.
        Me.Прибавка_ЗПTableAdapter.Fill(Me.SalariesDataSet.Прибавка_ЗП)
        'TODO: This line of code loads data into the 'SalariesDataSet.Вычет_ЗП' table. You can move, or remove it, as needed.
        Me.Вычет_ЗПTableAdapter.Fill(Me.SalariesDataSet.Вычет_ЗП)
        'TODO: This line of code loads data into the 'SalariesDataSet.Зарплата' table. You can move, or remove it, as needed.
        Me.ЗарплатаTableAdapter.Fill(Me.SalariesDataSet.Зарплата)
        'TODO: This line of code loads data into the 'SalariesDataSet.Работник' table. You can move, or remove it, as needed.
        Me.РаботникTableAdapter.Fill(Me.SalariesDataSet.Работник)

    End Sub

    Private Sub РаботникDataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles РаботникDataGridView.CellClick
        Dim filter As String = ЗарплатаBindingSource.Filter
        Debug.WriteLine(filter)
    End Sub

    Private Sub ЗарплатаDataGridView_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ЗарплатаDataGridView.CellContentDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow = ЗарплатаDataGridView.Rows(e.RowIndex)
            Dim selaryId As Integer = selectedRow.Cells(0).Value
            SelaryView.ShowById(selaryId)
        End If
    End Sub

    Private Sub РаботникDataGridView_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles РаботникDataGridView.CellContentDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow = РаботникDataGridView.Rows(e.RowIndex)
            Dim employerId As Integer = selectedRow.Cells(0).Value
            EmployerView.ShowById(employerId)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        SalaryCRUD.Show()
    End Sub
End Class