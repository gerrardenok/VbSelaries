Public Class SalaryCRUD

    Private Function ShowErrors() As Boolean
        FormErrorProvider.Dispose()
        Dim result As Boolean = False

        If ([String].IsNullOrEmpty(ОкладTextBox.Text.Trim())) Then
            FormErrorProvider.SetError(ОкладTextBox, "Это поле не может быть пустым!")
            result = True
        End If

        'If ([String].IsNullOrEmpty(На_рукиTextBox.Text.Trim())) Then
        'FormErrorProvider.SetError(На_рукиTextBox, "Это поле не может быть пустым!")
        'result = True
        'End If


        If (Not МесяцMaskedTextBox.MaskFull) Then
            FormErrorProvider.SetError(МесяцMaskedTextBox, "Это поле не может быть пустым!")
            result = True
        Else
            Dim month As Integer = Integer.Parse(МесяцMaskedTextBox.Text())
            If (Not (month >= 1 And month <= 12)) Then
                FormErrorProvider.SetError(МесяцMaskedTextBox, "Введите правильные номер месяца!")
                result = True
            End If
        End If

        If (Not ГодMaskedTextBox.MaskFull) Then
            FormErrorProvider.SetError(ГодMaskedTextBox, "Это поле не может быть пустым!")
            result = True
        End If

        Return result
    End Function

    Private Sub ЗарплатаBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ЗарплатаBindingNavigatorSaveItem.Click
        If (Not ShowErrors()) Then
            Me.Validate()
            Me.ЗарплатаBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.SalariesDataSet)
        End If
    End Sub

    Private Sub SalaryCRUD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SalariesDataSet.Работник' table. You can move, or remove it, as needed.
        Me.РаботникTableAdapter.Fill(Me.SalariesDataSet.Работник)
        'TODO: This line of code loads data into the 'SalariesDataSet.Зарплата' table. You can move, or remove it, as needed.
        Me.ЗарплатаTableAdapter.Fill(Me.SalariesDataSet.Зарплата)
    End Sub

    Private Sub BindingNavigatorMoveNextItem_OwnerChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorMoveNextItem.OwnerChanged
    End Sub

    Private Sub ЗарплатаBindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ЗарплатаBindingSource.CurrentChanged
        Dim current As DataRowView = ЗарплатаBindingSource.Current
        Dim currentEployerId = РаботникComboBox.SelectedValue
        Dim isNewCurrent As Boolean = (IsDBNull(current.Item("Код_работника")))
        If (isNewCurrent) Then
            current.Item("Код_работника") = currentEployerId
            current.Item("Дата_выдачи") = Дата_выдачиDateTimePicker.Value
        Else
            РаботникComboBox.SelectedValue = current.Item("Код_работника")
        End If
    End Sub

    Private Sub РаботникComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles РаботникComboBox.SelectedIndexChanged
        Dim current As DataRowView = ЗарплатаBindingSource.Current
        Dim currentEployerId = РаботникComboBox.SelectedValue
        If (Not (current Is Nothing) And Not (currentEployerId Is Nothing)) Then
            current.Item("Код_работника") = currentEployerId
        End If
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        If (MessageBox.Show("Вы уверены что хотите удалить запись?", "Подтверждение", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes) Then
            If (ЗарплатаBindingSource.Count > 0) Then
                ЗарплатаBindingSource.RemoveCurrent()
            End If
        End If
    End Sub
End Class