Public Class LostDayCRUD

    Public Sub InitForm()
        Me.Show()
        Me.Init()
    End Sub

    Private Sub Init()
        ПропускBindingSource.AddNew()
        ПропускBindingSource.MoveLast()
        ComboBoxsInit()
        CheckBoxsInit()
    End Sub

    Private Sub ComboBoxsInit()
        Dim current As DataRowView = ПропускBindingSource.Current
        current.Item("Код_работника") = 1
    End Sub

    Private Sub CheckBoxsInit()
        ОплатаCheckBox.Checked = False

        Dim current As DataRowView = ПропускBindingSource.Current
        current.Item("Оплата") = 0
    End Sub



    Private Function ShowErrors() As Boolean
        FormErrorProvider.Dispose()
        Dim result As Boolean = False

        If ([String].IsNullOrEmpty(ПричинаTextBox.Text.Trim())) Then
            FormErrorProvider.SetError(ПричинаTextBox, "Это поле не может быть пустым!")
            result = True
        End If

        If (Not ГодMaskedTextBox.MaskFull) Then
            FormErrorProvider.SetError(ГодMaskedTextBox, "Это поле не может быть пустым!")
            result = True
        End If

        If (Not МесяцMaskedTextBox.MaskFull) Then
            FormErrorProvider.SetError(МесяцMaskedTextBox, "Это поле не может быть пустым!")
            result = True
        Else
            If (Not (Integer.Parse(МесяцMaskedTextBox.Text) >= 1 And Integer.Parse(МесяцMaskedTextBox.Text) <= 12)) Then
                FormErrorProvider.SetError(МесяцMaskedTextBox, "Неправильные номер месяца!")
                result = True
            End If
        End If

        

        If (Not ДеньMaskedTextBox.MaskFull) Then
            FormErrorProvider.SetError(ДеньMaskedTextBox, "Это поле не может быть пустым!")
            result = True
        Else
            If (Not (Integer.Parse(ДеньMaskedTextBox.Text) >= 1 And Integer.Parse(ДеньMaskedTextBox.Text) <= 31)) Then
                FormErrorProvider.SetError(МесяцMaskedTextBox, "Неправильное число в месяце!")
                result = True
            End If
        End If

        Return result
    End Function

    Private Sub LostDayCRUD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SalariesDataSet.Работник' table. You can move, or remove it, as needed.
        Me.РаботникTableAdapter.Fill(Me.SalariesDataSet.Работник)
        'TODO: This line of code loads data into the 'SalariesDataSet.Пропуск' table. You can move, or remove it, as needed.
        Me.ПропускTableAdapter.Fill(Me.SalariesDataSet.Пропуск)

        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            'UI validation 
            If (Not ShowErrors()) Then
                'DS validation 
                Me.Validate()
                Me.ПропускBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.SalariesDataSet)

                MsgBox("Изменения были сохранены.")
            End If
        Catch ex As Exception
            MsgBox("Ошибка при сохранении работника " & ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub РаботникComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles РаботникComboBox.SelectedIndexChanged
        Dim current As DataRowView = ПропускBindingSource.Current
        Dim value As Integer = РаботникComboBox.SelectedValue
        ' Warning on closing form combobox is unloaded 
        If (Not current Is Nothing And Not value = Nothing) Then
            current.Item("Код_работника") = value
        End If
    End Sub

    Private Sub ОплатаCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ОплатаCheckBox.CheckedChanged
        Dim current As DataRowView = ПропускBindingSource.Current
        Dim value As Integer = 0
        If (ОплатаCheckBox.Checked) Then
            value = 1
        Else
            value = 0
        End If
        ' Warning on closing form combobox is unloaded 
        If (Not current Is Nothing And Not value = Nothing) Then
            current.Item("Оплата") = value
        End If
    End Sub
End Class