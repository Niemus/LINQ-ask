Public Class Form5

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim knigi = Form1.Библиотека2DataSet.Tables("Книги")

        Dim Запрос1 = From kn In knigi.AsEnumerable Select kn!Название, kn!ГодИзд, kn!Цена
        TextBox1.Clear()
        For Each r In Запрос1
            TextBox1.AppendText(vbTab & r.ГодИзд & _
            vbTab & r.Цена & vbTab & _
            r.Название & vbCrLf)
        Next
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim knigi = Form1.Библиотека2DataSet.Tables("Книги")
        Dim avtory = Form2.Библиотека2DataSet.Tables("Авторы")
        Dim kngavt = Form4.Библиотека2DataSet.Tables("КнгАвт")
        Dim Запрос2 = From kn In knigi.AsEnumerable, ka In kngavt.AsEnumerable, avt In avtory.AsEnumerable Where kn!ГодИзд = 2008 And (kn!Код = ka!КодКниги And avt!Код = ka!КодАвтора) Select Фамилия = avt!Фамилия, Название = kn!Название
        TextBox1.Clear()
        For Each r In Запрос2
            TextBox1.AppendText(r.Фамилия & vbTab & r.Название & vbTab & vbCrLf)
        Next
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Dim knigi = Form1.Библиотека2DataSet.Tables("Книги")
        Dim Запрос3 = From kn In knigi.AsEnumerable Order By kn!ГодИзд Descending Select Название = kn!Название, ГодИзд = kn!ГодИзд
        TextBox1.Clear()
        For Each r In Запрос3
            TextBox1.AppendText(r.ГодИзд & vbTab & r.Название & vbCrLf)
        Next

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        Dim knigi = Form1.Библиотека2DataSet.Tables("Книги")
        Dim Запрос4 = From kn In knigi.AsEnumerable Select CDec(kn!Цена * kn!Количество)
        TextBox1.AppendText("Содержание запроса:" & vbCrLf)
        TextBox1.Clear()
        For Each v In Запрос4
            TextBox1.AppendText(vbTab & v & vbCrLf)
        Next

        Dim r = Aggregate v In Запрос4 Into Sum()
        TextBox1.AppendText(" Итого: " & r & vbCrLf)


    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim kolv = Form1.Библиотека2DataSet.Tables("Книги")
        Dim Запрос5 = From kn In kolv.AsEnumerable Select CDec(kn!Количество)
        TextBox1.AppendText("Содержание запроса:" & vbCrLf)
        TextBox1.Clear()
        For Each v In Запрос5
            TextBox1.AppendText(vbTab & v & vbCrLf)
        Next

        Dim r = Aggregate v In Запрос5 Into Sum()
        TextBox1.AppendText(" Всего книг: " & r & vbCrLf)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        'Dim kng = Form1.Библиотека2DataSet.Tables("Книги")
        'Dim Запрос6 = From kn In kng.AsEnumerable Select kn!Название
        'TextBox1.AppendText("Содержание запроса:" & vbCrLf)
        'TextBox1.Clear()
        'For Each r In Запрос6
        '    TextBox1.AppendText(vbTab & r.Название & vbCrLf)
        'Next


        'TextBox1.AppendText(" Всего книг: " & vbCrLf)
    End Sub
End Class