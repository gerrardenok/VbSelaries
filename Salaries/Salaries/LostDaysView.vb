Public Class LostDaysForm

    Private Sub Init()
        ПропускDataGridView.Columns(0).Visible = False
    End Sub

    Private Sub LostDaysForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SalariesDataSet.Пропуск' table. You can move, or remove it, as needed.
        Me.ПропускTableAdapter.Fill(Me.SalariesDataSet.Пропуск)
        'TODO: This line of code loads data into the 'SalariesDataSet.Работник' table. You can move, or remove it, as needed.
        Me.РаботникTableAdapter.Fill(Me.SalariesDataSet.Работник)

        Init()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        LostDayCRUD.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        LostDaysViewReport.Show()
    End Sub
End Class