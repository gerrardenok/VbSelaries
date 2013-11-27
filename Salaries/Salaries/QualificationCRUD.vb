Public Class QualificationCRUD

    Private Sub Init()
        Text = "Добавить Специальность"
        СпециальностьBindingSource.AddNew()
        СпециальностьBindingSource.MoveLast()
    End Sub

    Public Sub InitForm()
        Me.Show()
        ' Fill form
        Me.Init()
    End Sub

    Private Sub Load(ByVal spId As Integer)
        Text = "Редактировать Специальность"

        Dim index As Integer = СпециальностьBindingSource.Find("Код_специальности", spId)

        If (index = -1) Then
            MsgBox("Специальность не найден!")
            Me.Close()
            Return
        End If

        СпециальностьBindingSource.Position = index
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

        Return result
    End Function

    Private Sub QualificationCRUD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SalariesDataSet.Специальность' table. You can move, or remove it, as needed.
        Me.СпециальностьTableAdapter.Fill(Me.SalariesDataSet.Специальность)

    End Sub

    Private Sub CancelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBtn.Click
        Me.Close()
    End Sub

    Private Sub SaveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBtn.Click
        Try
            'UI validation 
            If (Not ShowErrors()) Then
                'DS validation 
                Me.Validate()

                Me.СпециальностьBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.SalariesDataSet)

                DepartmentsView.reloadDs()
                MsgBox("Изменения были сохранены.")

                QualificationsView.reloadDs()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Ошибка при сохранении работника " & ex.Message)
        End Try
    End Sub

    Private Sub DeleteBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteBtn.Click
        Dim deleteResult As DialogResult = MessageBox.Show("Вы уверены что хотите удалить специальность?", "Подтверждение удаления", MessageBoxButtons.YesNo)
        If (deleteResult = DialogResult.Yes) Then
            Try
                Dim current As DataRowView = СпециальностьBindingSource.Current
                current.Delete()
                TableAdapterManager.UpdateAll(Me.SalariesDataSet)

                DepartmentsView.reloadDs()

                QualificationsView.reloadDs()
                Me.Close()
            Catch ex As Exception
                MsgBox("Ошибка при удалении специальности " & ex.Message)
            End Try
        End If
    End Sub
End Class