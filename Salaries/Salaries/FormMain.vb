Public Class FormMain
    Private Sub ПоказатьВсехToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ПоказатьВсехToolStripMenuItem.Click
        EmployersView.Show()
    End Sub

    Private Sub ДобавитьНовогоToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ДобавитьНовогоToolStripMenuItem.Click
        EmployerCRUD.InitForm()
    End Sub

    Private Sub ВсеОтделыToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ВсеОтделыToolStripMenuItem.Click
        DepartmentsView.Show()
    End Sub

    Private Sub ДобавитьОтделToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ДобавитьОтделToolStripMenuItem.Click
        DepartamentCRUD.InitForm()
    End Sub

    Private Sub ВсеСпециальностиToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ВсеСпециальностиToolStripMenuItem.Click
        QualificationsView.Show()
    End Sub

    Private Sub ДобавитьСпециальностьToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ДобавитьСпециальностьToolStripMenuItem.Click
        QualificationCRUD.InitForm()
    End Sub

    Private Sub ВсеПропукиToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ВсеПропукиToolStripMenuItem.Click
        OmissionsView.Init()
    End Sub

    Private Sub ДобавитьПропускToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ДобавитьПропускToolStripMenuItem.Click
        LostDayCRUD.InitForm()
    End Sub

    Private Sub ВсеЗарплатыToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ВсеЗарплатыToolStripMenuItem.Click
        SalariesView.InitForm()
    End Sub

    Private Sub ДобавитьЗПToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ДобавитьЗПToolStripMenuItem.Click
        SalaryCRUD.Show()
    End Sub

    Private Sub ДобавитьРедактироватьToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ДобавитьРедактироватьToolStripMenuItem.Click
        OffreckoningCRUD.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Help.ShowHelp(ParentForm, "D:\Курсовые\БД\Report\Справка.chm")
    End Sub
End Class
