Public Class DepartamentCRUD
    Private Sub DepartamentCRUD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SalariesDataSet.Отдел' table. You can move, or remove it, as needed.
        Me.ОтделTableAdapter.Fill(Me.SalariesDataSet.Отдел)
    End Sub

    Private Sub Init()
        Text = "Добавить Отдел"
        ОтделBindingSource.AddNew()
        ОтделBindingSource.MoveLast()
        ' Fix for empty validation
        Фонд_ЗПTextBox.Text = 0
    End Sub

    Public Sub InitForm()
        Me.Show()
        ' Fill form
        Me.Init()
    End Sub

    Private Sub Load(ByVal deptartamnetId As Integer)
        Text = "Редактировать работника"

        Dim index As Integer = ОтделBindingSource.Find("Код_отдела", deptartamnetId)

        If (index = -1) Then
            MsgBox("Отдел не найден!")
            Me.Close()
            Return
        End If

        ОтделBindingSource.Position = index
        ' Show delete control
        DeleteBtn.Visible = True
    End Sub

    Public Sub LoadForm(ByVal id As Integer)
        Me.Show()
        ' Fill form
        Me.Load(id)
    End Sub

    Private Function ShowErrors() As Boolean
        FormErrorProvider.Dispose()
        Dim result As Boolean = False

        If ([String].IsNullOrEmpty(НазваниеTextBox.Text.Trim())) Then
            FormErrorProvider.SetError(НазваниеTextBox, "Это поле не может быть пустым!")
            result = True
        End If

        'If ([String].IsNullOrEmpty(Фонд_ЗПTextBox.Text.Trim())) Then
        'FormErrorProvider.SetError(Фонд_ЗПTextBox, "Это поле не может быть пустым!")
        'result = True
        'End If

        'Dim parsed As Double
        'If (Not [Decimal].TryParse(Фонд_ЗПTextBox.Text, parsed)) Then
        'FormErrorProvider.SetError(Фонд_ЗПTextBox, "Это поле должно быть числовым!")
        'result = True
        'End If

        Return result
    End Function

    Private Sub SaveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBtn.Click
        Try
            'UI validation 
            If (Not ShowErrors()) Then
                'DS validation 
                Me.Validate()

                Me.ОтделBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.SalariesDataSet)

                DepartmentsView.reloadDs()
                MsgBox("Изменения были сохранены.")

                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Ошибка при сохранении работника " & ex.Message)
        End Try
    End Sub

    Private Sub CancelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBtn.Click
        Me.Close()
    End Sub

    Private Sub DeleteBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteBtn.Click
        Dim deleteResult As DialogResult = MessageBox.Show("Вы уверены что хотите удалить отдел?", "Подтверждение удаления", MessageBoxButtons.YesNo)
        If (deleteResult = DialogResult.Yes) Then
            Try
                Dim current As DataRowView = ОтделBindingSource.Current
                current.Delete()
                TableAdapterManager.UpdateAll(Me.SalariesDataSet)

                DepartmentsView.reloadDs()

                Me.Close()
            Catch ex As Exception
                MsgBox("Ошибка при удалении отдела " & ex.Message)
            End Try
        End If
    End Sub
End Class