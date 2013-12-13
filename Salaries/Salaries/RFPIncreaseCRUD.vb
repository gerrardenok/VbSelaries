Public Class RFPIncreaseCRUD

    Private Sub Прибавка_ЗПBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Прибавка_ЗПBindingNavigatorSaveItem.Click
        Try
            'UI validation 
            If (Not ShowErrors()) Then
                Me.Validate()
                Me.Прибавка_ЗПBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.SalariesDataSet)
            End If
        Catch ex As Exception
            MsgBox("Ошибка при сохранении работника " & ex.Message)
        End Try
    End Sub

    Private Function ShowErrors() As Boolean
        FormErrorProvider.Dispose()
        Dim result As Boolean = False

        If ([String].IsNullOrEmpty(НазваниеTextBox.Text.Trim())) Then
            FormErrorProvider.SetError(НазваниеTextBox, "Это поле не может быть пустым!")
            result = True
        End If

        If ([String].IsNullOrEmpty(Сумма_прибавкиTextBox.Text.Trim())) Then
            FormErrorProvider.SetError(Сумма_прибавкиTextBox, "Это поле не может быть пустым!")
            result = True
        Else
            Dim parsed As Double
            If (Not Double.TryParse(Сумма_прибавкиTextBox.Text, parsed)) Then
                FormErrorProvider.SetError(Сумма_прибавкиTextBox, "Это должно быть числовым!")
                result = True
            End If
        End If

        Return result
    End Function

    Private Sub RFPIncreaseCRUD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SalariesDataSet.Зарплата' table. You can move, or remove it, as needed.
        Me.ЗарплатаTableAdapter.Fill(Me.SalariesDataSet.Зарплата)
        'TODO: This line of code loads data into the 'SalariesDataSet.Работник' table. You can move, or remove it, as needed.
        Me.РаботникTableAdapter.Fill(Me.SalariesDataSet.Работник)
        'TODO: This line of code loads data into the 'SalariesDataSet.Прибавка_ЗП' table. You can move, or remove it, as needed.
        Me.Прибавка_ЗПTableAdapter.Fill(Me.SalariesDataSet.Прибавка_ЗП)

    End Sub

    Private Sub Прибавка_ЗПBindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Прибавка_ЗПBindingSource.CurrentChanged
        Dim current As DataRowView = Прибавка_ЗПBindingSource.Current
        If (Not current Is Nothing) Then
            Dim currentEployerId = РаботникComboBox.SelectedValue
            Dim currentSelaryId = ЗарплатаComboBox.SelectedValue
            Dim isNewCurrent As Boolean = (IsDBNull(current.Item("Код_прибавки")) Or (current.Item("Код_прибавки") = -1))
            ЗарплатаBindingSource.RemoveFilter()
            If (isNewCurrent) Then
                current.Item("Код_зарплаты") = currentSelaryId
                ЗарплатаBindingSource.Filter = "Код_работника=" & currentEployerId
            Else
                Dim index As Integer = ЗарплатаBindingSource.Find("Код_зарплаты", current.Item("Код_зарплаты"))
                If (Not index = -1) Then
                    Dim relatedSelary As DataRowView = ЗарплатаBindingSource.Item(index)
                    currentSelaryId = relatedSelary.Item("Код_зарплаты")
                    currentEployerId = relatedSelary.Item("Код_работника")

                    ЗарплатаBindingSource.Filter = "Код_работника=" & relatedSelary.Item("Код_работника")
                End If
            End If

            ЗарплатаComboBox.SelectedValue = currentSelaryId
            РаботникComboBox.SelectedValue = currentEployerId
        End If
    End Sub

    Private Sub РаботникComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles РаботникComboBox.SelectedIndexChanged
        ЗарплатаBindingSource.Filter = "Код_работника=" & РаботникComboBox.SelectedValue
        Dim current As DataRowView = Прибавка_ЗПBindingSource.Current
        Dim currentSelaryId = ЗарплатаComboBox.SelectedValue
        If (Not current Is Nothing) Then
            current.Item("Код_зарплаты") = currentSelaryId
        End If
    End Sub

    Private Sub ЗарплатаComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ЗарплатаComboBox.SelectedIndexChanged
        Dim current As DataRowView = Прибавка_ЗПBindingSource.Current
        Dim currentSelaryId = ЗарплатаComboBox.SelectedValue
        If (Not current Is Nothing) Then
            current.Item("Код_зарплаты") = currentSelaryId
        End If
    End Sub
End Class