﻿Public Class Form4

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form1.Show()        Me.Hide()
    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "Библиотека2DataSet.КнгАвт". При необходимости она может быть перемещена или удалена.
        Me.КнгАвтTableAdapter.Fill(Me.Библиотека2DataSet.КнгАвт)

    End Sub
End Class