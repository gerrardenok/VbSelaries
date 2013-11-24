Public Class EmployersView
    Private Sub EmployersViewInit()
        ' Set default values
        EVSortCritetia.SelectedIndex = 0
        EVOrderCriteria.SelectedIndex = 0
        ' Hide empl id col
        EmployersViewDataGridView.Columns(10).Visible = False
    End Sub

    Public Sub reloadDs()
        EmployersViewTableAdapter.Fill(SalariesDataSet.EmployersView)
        EmployersViewDataGridView.Refresh()
    End Sub

    Private Sub EmployersViewSort()
        Dim sortCol As System.Windows.Forms.DataGridViewColumn
        Dim order As System.ComponentModel.ListSortDirection

        Select Case EVSortCritetia.SelectedIndex
            Case 0
                sortCol = EmployersViewDataGridView.Columns(0)
            Case 1
                sortCol = EmployersViewDataGridView.Columns(1)
            Case 2
                sortCol = EmployersViewDataGridView.Columns(2)
            Case 3
                sortCol = EmployersViewDataGridView.Columns(9)
            Case 4
                sortCol = EmployersViewDataGridView.Columns(11)
        End Select

        Select Case EVOrderCriteria.SelectedIndex
            Case 0
                order = System.ComponentModel.ListSortDirection.Ascending
            Case 1
                order = System.ComponentModel.ListSortDirection.Descending
        End Select

        EmployersViewDataGridView.Sort(sortCol, order)
    End Sub

    Private Function EmployersViewFilterCriterion() As String
        Dim departament As String = ОтделComboBox.Text
        Dim sp As String = СпециальностьComboBox.Text
        Dim filters = New List(Of String)

        If (Not [String].IsNullOrEmpty(sp)) Then
            filters.Add("Специальность='" & sp & "'")
        End If

        If (Not [String].IsNullOrEmpty(departament)) Then
            filters.Add("Отдел='" & departament & "'")
        End If

        Return ([String].Join(" AND ", filters))
    End Function

    Private Sub EmployersView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SalariesDataSet.Специальность' table. You can move, or remove it, as needed.
        СпециальностьTableAdapter.Fill(Me.SalariesDataSet.Специальность)
        'TODO: This line of code loads data into the 'SalariesDataSet.Отдел' table. You can move, or remove it, as needed.
        ОтделTableAdapter.Fill(Me.SalariesDataSet.Отдел)
        'TODO: This line of code loads data into the 'SalariesDataSet.EmployersView' table. You can move, or remove it, as needed.
        EmployersViewTableAdapter.Fill(Me.SalariesDataSet.EmployersView)

        EmployersViewInit()
        EmployersViewSort()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        EmployersViewSort()
    End Sub

    Private Sub btnFilterByDepartment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilterByDepartment.Click
        EmployersViewBindingSource.Filter = EmployersViewFilterCriterion()
    End Sub

    Private Sub btnResetFilters_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResetFilters.Click
        EmployersViewBindingSource.RemoveFilter()
    End Sub

    Private Sub EmployersViewDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles EmployersViewDataGridView.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow = EmployersViewDataGridView.Rows(e.RowIndex)
            Dim employerId As Integer = selectedRow.Cells(10).Value
            EmployerView.ShowById(employerId)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        EmployersReportView.InitList()
    End Sub
End Class