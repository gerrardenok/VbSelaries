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

    Private Sub EmployerView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SalariesDataSet.Работник' table. You can move, or remove it, as needed.
        Me.РаботникTableAdapter.Fill(Me.SalariesDataSet.Работник)
        'TODO: This line of code loads data into the 'SalariesDataSet.Работник' table. You can move, or remove it, as needed.
        Me.РаботникTableAdapter.Fill(Me.SalariesDataSet.Работник)

    End Sub

    Private Sub РаботникBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.РаботникBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SalariesDataSet)

    End Sub

    Private Sub РаботникBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles РаботникBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.РаботникBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SalariesDataSet)

    End Sub
End Class