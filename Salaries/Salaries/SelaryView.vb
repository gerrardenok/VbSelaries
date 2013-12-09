Public Class SelaryView
    Public Shared Sub ShowById(ByVal id As Integer)
        Dim form As New SelaryView
        ' LoadForm from and set binding source
        form.Show()
        ' Fill form
        form.FillById(id)
    End Sub

    Private Sub FillById(ByVal id As Integer)
        Dim index As Integer = SalaryJoinEmployerBindingSource.Find("Код_зарплаты", id)
        SalaryJoinEmployerBindingSource.Position = index
        ' Set current position
        SalaryJoinEmployerBindingNavigator.Refresh()
    End Sub


    Private Sub SelaryView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SalariesDataSet.Прибавка_ЗП' table. You can move, or remove it, as needed.
        Me.Прибавка_ЗПTableAdapter.Fill(Me.SalariesDataSet.Прибавка_ЗП)
        'TODO: This line of code loads data into the 'SalariesDataSet.Вычет_ЗП' table. You can move, or remove it, as needed.
        Me.Вычет_ЗПTableAdapter.Fill(Me.SalariesDataSet.Вычет_ЗП)
        'TODO: This line of code loads data into the 'SalariesDataSet.SalaryJoinEmployer' table. You can move, or remove it, as needed.
        Me.SalaryJoinEmployerTableAdapter.Fill(Me.SalariesDataSet.SalaryJoinEmployer)
        'TODO: This line of code loads data into the 'SalariesDataSet.Прибавка_ЗП' table. You can move, or remove it, as needed.
        Me.Прибавка_ЗПTableAdapter.Fill(Me.SalariesDataSet.Прибавка_ЗП)
        'TODO: This line of code loads data into the 'SalariesDataSet.Вычет_ЗП' table. You can move, or remove it, as needed.
        Me.Вычет_ЗПTableAdapter.Fill(Me.SalariesDataSet.Вычет_ЗП)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SalaryCRUD.Show()
    End Sub
End Class