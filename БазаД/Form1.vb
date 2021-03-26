Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form2.Show()        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form3.Show()        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form4.Show()        Me.Hide()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Form5.Show()        Me.Hide()

        Form2.АвторыTableAdapter.Fill(Form2.Библиотека2DataSet.Авторы)
        Form3.ИздательстваTableAdapter.Fill(Form3.Библиотека2DataSet.Издательства)
        Form4.КнгАвтTableAdapter.Fill(Form4.Библиотека2DataSet.КнгАвт)
        Form5.Show()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "Библиотека2DataSet.Книги". При необходимости она может быть перемещена или удалена.
        Me.КнигиTableAdapter.Fill(Me.Библиотека2DataSet.Книги)

    End Sub
End Class
