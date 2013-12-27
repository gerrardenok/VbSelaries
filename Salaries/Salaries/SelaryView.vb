Public Class SelaryView
    Public Shared Sub ShowById(ByVal id As Integer)
        Dim form As New SelaryView
        ' LoadForm from and set binding source
        form.Show()
        ' Fill form
        form.FillById(id)
    End Sub

    Public Sub reloadDs()
        'SalaryJoinEmployerBindingSource.ResetBindings(False)
        SalaryJoinEmployerTableAdapter.Fill(SalariesDataSet.SalaryJoinEmployer)
        Вычет_ЗПTableAdapter.Fill(SalariesDataSet.Вычет_ЗП)
        Прибавка_ЗПTableAdapter.Fill(SalariesDataSet.Прибавка_ЗП)

        SalaryJoinEmployerBindingNavigator.Refresh()
        Вычет_ЗПDataRepeater.Refresh()
        Прибавка_ЗПDataRepeater.Refresh()
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
        SalaryCRUD.InitAll()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        OffreckoningCRUD.InitAll()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        RFPIncreaseCRUD.InitAll()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        SelariesReportingForm.InitAll()
    End Sub
End Class