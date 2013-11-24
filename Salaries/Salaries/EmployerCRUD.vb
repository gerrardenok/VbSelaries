Public Class EmployerCRUD

    Public Sub InitForm()
        Me.Show()
        ' Fill form
        Me.Init()
    End Sub

    Private Sub Init()
        Text = "Добавить работника"
        РаботникBindingSource.AddNew()
        РаботникBindingSource.MoveLast()
        ComboBoxsInit()
        DateTimePickersInit()
    End Sub

    Public Sub LoadForm(ByVal id As Integer)
        Me.Show()
        ' Fill form
        Me.Load(id)
    End Sub

    Private Sub Load(ByVal employerId As Integer)
        Text = "Редактировать работника"

        Dim index As Integer = РаботникBindingSource.Find("Код_работника", employerId)
        
        If (index = -1) Then
            MsgBox("Сотрудник не найден!")
            Return
        End If

        РаботникBindingSource.Position = index
        ' Show delete control
        DeleteBtn.Visible = True
        RetairBtn.Visible = True
        ComboBoxsLoad()
    End Sub

    Private Sub ComboBoxsInit()
        Dim current As DataRowView = РаботникBindingSource.Current
        current.Item("Код_ставки") = 1
        current.Item("Код_отдела") = 1
        current.Item("Код_специальности") = 1
    End Sub

    Private Sub DateTimePickersInit()
        Dim current As DataRowView = РаботникBindingSource.Current
        current.Item("Дата_приёма") = Дата_приёмаDateTimePicker.Value
    End Sub

    Private Sub ComboBoxsLoad()
        Dim current As DataRowView = РаботникBindingSource.Current
        СтавкаComboBox.SelectedValue = current.Item("Код_ставки")
        ОтделComboBox.SelectedValue = current.Item("Код_отдела")
        СпециальностьComboBox.SelectedValue = current.Item("Код_специальности")
    End Sub

    Private Sub EmployerCRUD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SalariesDataSet.Ставка' table. You can move, or remove it, as needed.
        Me.СтавкаTableAdapter.Fill(Me.SalariesDataSet.Ставка)
        'TODO: This line of code loads data into the 'SalariesDataSet.Специальность' table. You can move, or remove it, as needed.
        Me.СпециальностьTableAdapter.Fill(Me.SalariesDataSet.Специальность)
        'TODO: This line of code loads data into the 'SalariesDataSet.Отдел' table. You can move, or remove it, as needed.
        Me.ОтделTableAdapter.Fill(Me.SalariesDataSet.Отдел)
        'TODO: This line of code loads data into the 'SalariesDataSet.Ставка' table. You can move, or remove it, as needed.
        Me.СтавкаTableAdapter.Fill(Me.SalariesDataSet.Ставка)
        'TODO: This line of code loads data into the 'SalariesDataSet.Отдел' table. You can move, or remove it, as needed.
        Me.ОтделTableAdapter.Fill(Me.SalariesDataSet.Отдел)
        'TODO: This line of code loads data into the 'SalariesDataSet.Специальность' table. You can move, or remove it, as needed.
        Me.СпециальностьTableAdapter.Fill(Me.SalariesDataSet.Специальность)
        'TODO: This line of code loads data into the 'SalariesDataSet.Работник' table. You can move, or remove it, as needed.
        Me.РаботникTableAdapter.Fill(Me.SalariesDataSet.Работник)
    End Sub

    Private Sub SaveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBtn.Click
        Try
            Me.Validate()
            Me.РаботникBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.SalariesDataSet)
            MsgBox("Изменения были сохранены.")

            ' reload ds
            EmployersView.reloadDs()
        Catch ex As Exception
            MsgBox("Ошибка при сохранении работника " & ex.Message)
        End Try

    End Sub

    Private Sub CancelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBtn.Click
        Me.Close()
    End Sub

    Private Sub DeleteBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteBtn.Click
        Dim deleteResult As DialogResult = MessageBox.Show("Вы уверены что хотите удалить работника?", "Подтверждение удаления", MessageBoxButtons.YesNo)
        If (deleteResult = DialogResult.Yes) Then
            Try
                Dim current As DataRowView = РаботникBindingSource.Current
                current.Delete()
                TableAdapterManager.UpdateAll(Me.SalariesDataSet)

                ' reload ds
                EmployersView.reloadDs()

                Me.Close()
            Catch ex As Exception
                MsgBox("Ошибка при удалении работника " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub СтавкаComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles СтавкаComboBox.SelectedIndexChanged
        Dim current As DataRowView = РаботникBindingSource.Current
        Dim value As Integer = СтавкаComboBox.SelectedValue
        ' Warning on closing form combobox is unloaded 
        If (Not current Is Nothing And Not value = Nothing) Then
            current.Item("Код_ставки") = value
            Debug.WriteLine("СтавкаComboBox.SelectedValue:" & value)
            Debug.WriteLine("current.Item(Код_ставки): " & current.Item("Код_ставки"))
        End If
    End Sub

    Private Sub ОтделComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ОтделComboBox.SelectedIndexChanged
        Dim current As DataRowView = РаботникBindingSource.Current
        Dim value As Integer = ОтделComboBox.SelectedValue
        ' Warning on closing form combobox is unloaded 
        If (Not current Is Nothing And Not value = Nothing) Then
            current.Item("Код_отдела") = value
            Debug.WriteLine("ОтделComboBox.SelectedValue:" & value)
            Debug.WriteLine("current.Item(Код_отдела): " & current.Item("Код_отдела"))
        End If
    End Sub

    Private Sub СпециальностьComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles СпециальностьComboBox.SelectedIndexChanged
        Dim current As DataRowView = РаботникBindingSource.Current
        Dim value As Integer = СпециальностьComboBox.SelectedValue
        ' Warning on closing form combobox is unloaded 
        If (Not current Is Nothing And Not value = Nothing) Then
            current.Item("Код_специальности") = value
            Debug.WriteLine("СпециальностьComboBox.SelectedValue:" & value)
            Debug.WriteLine("current.Item(Код_специальности): " & current.Item("Код_специальности"))
        End If
    End Sub

    Private Sub RetairBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RetairBtn.Click
        Dim deleteResult As DialogResult = MessageBox.Show("Вы уверены что хотите УВОЛИТЬ работника?", "Подтверждение увольнения", MessageBoxButtons.YesNo)
        If (deleteResult = DialogResult.Yes) Then
            Dim current As DataRowView = РаботникBindingSource.Current

            current.Item("Дата_увольнения") = DateTime.Now
            SaveBtn_Click(sender, e)

            Me.Close()
        End If
    End Sub
End Class