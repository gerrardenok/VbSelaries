Public Class EmployerView

    Public Shared Sub ShowById(ByVal id As Integer)
        Dim form As New EmployerView
        ' Load from and set binding source
        form.Show()
        ' Fill form
        form.FillById(id)
    End Sub

    Private Sub FillById(ByVal id As Integer)
        Dim index As Integer = РаботникBindingSource.Find("Код_работника", id)
        РаботникBindingSource.Position = index
        ' Set current position
        РаботникBindingNavigator.Refresh()
    End Sub

    Private Sub HideRelatedTableColumns()
        ПропускDataGridView.Columns(0).Visible = False
        ПропускDataGridView.Columns(3).Visible = False

        ЗарплатаDataGridView.Columns(4).Visible = False
        ЗарплатаDataGridView.Columns(6).Visible = False
    End Sub


    Private Sub EmployerView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SalariesDataSet.Специальность' table. You can move, or remove it, as needed.
        Me.СпециальностьTableAdapter.Fill(Me.SalariesDataSet.Специальность)
        'TODO: This line of code loads data into the 'SalariesDataSet.Отдел' table. You can move, or remove it, as needed.
        Me.ОтделTableAdapter.Fill(Me.SalariesDataSet.Отдел)
        'TODO: This line of code loads data into the 'SalariesDataSet.Пропуск' table. You can move, or remove it, as needed.
        Me.ПропускTableAdapter.Fill(Me.SalariesDataSet.Пропуск)
        'TODO: This line of code loads data into the 'SalariesDataSet.Зарплата' table. You can move, or remove it, as needed.
        Me.ЗарплатаTableAdapter.Fill(Me.SalariesDataSet.Зарплата)
        'TODO: This line of code loads data into the 'SalariesDataSet.Зарплата' table. You can move, or remove it, as needed.
        Me.ЗарплатаTableAdapter.Fill(Me.SalariesDataSet.Зарплата)
        'TODO: This line of code loads data into the 'SalariesDataSet.Пропуск' table. You can move, or remove it, as needed.
        Me.ПропускTableAdapter.Fill(Me.SalariesDataSet.Пропуск)
        'TODO: This line of code loads data into the 'SalariesDataSet.Работник' table. You can move, or remove it, as needed.
        Me.РаботникTableAdapter.Fill(Me.SalariesDataSet.Работник)
        'TODO: This line of code loads data into the 'SalariesDataSet.Работник' table. You can move, or remove it, as needed.
        Me.РаботникTableAdapter.Fill(Me.SalariesDataSet.Работник)

        HideRelatedTableColumns()
    End Sub

    Private Sub РаботникBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.РаботникBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SalariesDataSet)

    End Sub

    Private Sub РаботникBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.РаботникBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SalariesDataSet)

    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        Dim confirmResult As DialogResult = MessageBox.Show("Are you sure to delete this item ??", "Confirm Delete!!", MessageBoxButtons.YesNo)
        If (confirmResult = DialogResult.Yes) Then
            Me.Close()
        End If
    End Sub
End Class