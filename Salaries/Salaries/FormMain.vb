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
        LostDaysForm.Show()
    End Sub

    Private Sub ДобавитьПропускToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ДобавитьПропускToolStripMenuItem.Click
        LostDayCRUD.InitForm()
    End Sub
End Class
