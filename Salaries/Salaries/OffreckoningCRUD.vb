﻿Public Class OffreckoningCRUD

    Private Sub РаботникBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.РаботникBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SalariesDataSet)

    End Sub

    Private Sub OffreckoningCRUD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SalariesDataSet.Зарплата' table. You can move, or remove it, as needed.
        Me.ЗарплатаTableAdapter.Fill(Me.SalariesDataSet.Зарплата)
        'TODO: This line of code loads data into the 'SalariesDataSet.Зарплата' table. You can move, or remove it, as needed.
        Me.ЗарплатаTableAdapter.Fill(Me.SalariesDataSet.Зарплата)
        'TODO: This line of code loads data into the 'SalariesDataSet.Работник' table. You can move, or remove it, as needed.
        Me.РаботникTableAdapter.Fill(Me.SalariesDataSet.Работник)
        'TODO: This line of code loads data into the 'SalariesDataSet.Вычет_ЗП' table. You can move, or remove it, as needed.
        Me.Вычет_ЗПTableAdapter.Fill(Me.SalariesDataSet.Вычет_ЗП)
        'TODO: This line of code loads data into the 'SalariesDataSet.Вычет_ЗП' table. You can move, or remove it, as needed.
        Me.Вычет_ЗПTableAdapter.Fill(Me.SalariesDataSet.Вычет_ЗП)
        'TODO: This line of code loads data into the 'SalariesDataSet.Вычет_ЗП' table. You can move, or remove it, as needed.
        Me.Вычет_ЗПTableAdapter.Fill(Me.SalariesDataSet.Вычет_ЗП)
        'TODO: This line of code loads data into the 'SalariesDataSet.Зарплата' table. You can move, or remove it, as needed.
      
    End Sub

    Private Sub РаботникBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.РаботникBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SalariesDataSet)

    End Sub

    Private Sub Вычет_ЗПBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Вычет_ЗПBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Вычет_ЗПBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SalariesDataSet)

    End Sub

    Private Sub Вычет_ЗПBindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Вычет_ЗПBindingSource.CurrentChanged
        Dim current As DataRowView = Вычет_ЗПBindingSource.Current
        If (Not current Is Nothing) Then
            Dim currentEployerId = РаботникComboBox.SelectedValue
            Dim currentSelaryId = ЗарплатаComboBox.SelectedValue
            Dim isNewCurrent As Boolean = (IsDBNull(current.Item("Код_вычета")) Or (current.Item("Код_вычета") = -1))
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
    End Sub

    Private Sub ЗарплатаComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ЗарплатаComboBox.SelectedIndexChanged
        Dim current As DataRowView = Вычет_ЗПBindingSource.Current
        Dim currentSelaryId = ЗарплатаComboBox.SelectedValue
        If (Not current Is Nothing) Then
            current.Item("Код_зарплаты") = currentSelaryId
        End If
    End Sub
End Class