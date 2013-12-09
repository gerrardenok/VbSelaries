Public Class OmissionsView

    Public Sub Init()
        Me.Show()
        Me.HideCols()
    End Sub

    Private Sub HideCols()
        РаботникDataGridView.Columns(0).Visible = False
    End Sub

    Private Sub РаботникBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.РаботникBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SalariesDataSet)
    End Sub

    Private Sub OmissionsView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SalariesDataSet.Пропуск' table. You can move, or remove it, as needed.
        Me.ПропускTableAdapter.Fill(Me.SalariesDataSet.Пропуск)
        'TODO: This line of code loads data into the 'SalariesDataSet.Работник' table. You can move, or remove it, as needed.
        Me.РаботникTableAdapter.Fill(Me.SalariesDataSet.Работник)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        LostDayCRUD.InitForm()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        LostDaysViewReport.Show()
    End Sub
End Class