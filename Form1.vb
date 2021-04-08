Public Class Form1
    Public Authors As Dictionary(Of Integer, String) = New Dictionary(Of Integer, String)
    Public Books As Dictionary(Of Integer, String) = New Dictionary(Of Integer, String)
    Public Connections As Dictionary(Of Integer, Integer) = New Dictionary(Of Integer, Integer)
    Public Function TakeFrom(FileName As String, ByRef d As Dictionary(Of Integer, String)) As Integer
        Dim sr As IO.StreamReader = New IO.StreamReader(My.Application.Info.DirectoryPath & "\" & FileName)
        Dim st As String
        While sr.Peek <> -1
            st = sr.ReadLine()
            If st <> "" Then
                Dim ObjectID As Integer = Convert.ToInt32(st.Split("!")(0))
                Dim ObjectName As String = st.Split("!")(1)
                d.Add(ObjectID, ObjectName)
            End If
        End While
        sr.Close()
        Return 1
    End Function

    Public Function TakeFrom(FileName As String, ByRef d As Dictionary(Of Integer, Integer)) As Integer
        Dim sr As IO.StreamReader = New IO.StreamReader(My.Application.Info.DirectoryPath & "\" & FileName)
        Dim st As String
        While sr.Peek <> -1
            st = sr.ReadLine()
            If st <> "" Then
                Dim ObjectID As Integer = Convert.ToInt32(st.Split("!")(0))
                Dim ObjectName As Integer = Convert.ToInt32(st.Split("!")(1))
                d.Add(ObjectID, ObjectName)
            End If
        End While
        sr.Close()
        Return 1
    End Function

    Public Function WriteIn(FileName As String, ByRef d As Dictionary(Of Integer, String)) As Integer
        Dim sw As IO.StreamWriter = New IO.StreamWriter(My.Application.Info.DirectoryPath & "\" & FileName)
        Dim Line As String
        For Each el As KeyValuePair(Of Integer, String) In d
            Line = Convert.ToString(el.Key) + "!" + el.Value
            sw.WriteLine(Line)
        Next
        sw.Close()
        Return 0
    End Function

    Public Function WriteIn(FileName As String, ByRef d As Dictionary(Of Integer, Integer)) As Integer
        Dim sw As IO.StreamWriter = New IO.StreamWriter(My.Application.Info.DirectoryPath & "\" & FileName)
        Dim Line As String
        For Each el As KeyValuePair(Of Integer, Integer) In d
            Line = Convert.ToString(el.Key) + "!" + Convert.ToString(el.Value)
            sw.WriteLine(Line)
        Next
        sw.Close()
        Return 0
        Return 0
    End Function

    Public Function InLB(LB As ListBox, d As Dictionary(Of Integer, String)) As Integer
        LB.Items.Clear()
        For Each el As KeyValuePair(Of Integer, String) In d
            LB.Items.Add(el.Value)
        Next
        Return 1
    End Function

    Public Function InCB(CB As ComboBox, d As Dictionary(Of Integer, String)) As Integer
        CB.Items.Clear()
        For Each el As KeyValuePair(Of Integer, String) In d
            CB.Items.Add(el.Value)
        Next
        CB.Text = d(1)
        Return 1
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TakeFrom("Авторы.txt", Authors)
        TakeFrom("Книги.txt", Books)
        TakeFrom("Связи.txt", Connections)

        InLB(AuthorsList, Authors)
        InLB(BooksList, Books)

        InCB(ComboBox1, Authors)

    End Sub

    Private Sub AuthorsList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AuthorsList.SelectedIndexChanged
        TextAuthor.Text = AuthorsList.SelectedItem.ToString()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim Value As String = ComboBox1.Text
        Dim i As Integer
        For Each el As KeyValuePair(Of Integer, String) In Authors
            If el.Value = Value Then
                i = el.Key
            End If
        Next
        ListBox1.Items.Clear()
        For Each el As KeyValuePair(Of Integer, Integer) In Connections
            If el.Value = i Then
                ListBox1.Items.Add(Books(el.Key))
            End If
        Next

    End Sub

    Private Sub BooksList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BooksList.SelectedIndexChanged
        TextBook.Text = BooksList.SelectedItem.ToString()
    End Sub

    Private Sub ConnectButton_Click(sender As Object, e As EventArgs) Handles ConnectButton.Click
        If TextAuthor.Text <> "" And TextBook.Text <> "" Then
            Dim i As Integer
            Dim j As Integer
            For Each el As KeyValuePair(Of Integer, String) In Authors
                If el.Value = TextAuthor.Text Then
                    i = el.Key
                End If
            Next

            For Each el As KeyValuePair(Of Integer, String) In Books
                If el.Value = TextBook.Text Then
                    j = el.Key
                End If
            Next
            Try
                Connections.Add(j, i)
                WriteIn("Связи.txt", Connections)
            Catch
                MessageBox.Show("Книга уже записана у этого или другого автора", "Предупреждение")
            End Try

        Else
            MessageBox.Show("Выделите элементы в списках", "Сообщение об ошибке")
        End If
        ComboBox1_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        If NameToAdd.Text <> "" Then
            If AuthorRadio.Checked Then
                Dim i As Integer = 1
                While Authors.ContainsKey(i)
                    i += 1
                End While
                Authors.Add(i, NameToAdd.Text)
                InLB(AuthorsList, Authors)
                InCB(ComboBox1, Authors)
                WriteIn("Авторы.txt", Authors)
            End If

            If BookRadio.Checked Then
                Dim i As Integer = 1
                While Books.ContainsKey(i)
                    i += 1
                End While
                Books.Add(i, NameToAdd.Text)
                InLB(BooksList, Books)
                WriteIn("Книги.txt", Books)
            End If
        Else
            MessageBox.Show("Введите наименование!", "Сообщение")
        End If
        ComboBox1_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub AuthorsList_DoubleClick(sender As Object, e As EventArgs) Handles AuthorsList.DoubleClick
        Dim i As Integer
        For Each el As KeyValuePair(Of Integer, String) In Authors
            If el.Value = AuthorsList.SelectedItem.ToString Then
                i = el.Key
                Authors.Remove(el.Key)
                Exit For
            End If
        Next
        Dim DeleteKeys As List(Of Integer) = New List(Of Integer)
        For Each el As KeyValuePair(Of Integer, Integer) In Connections
            If el.Value = i Then
                DeleteKeys.Add(el.Key)
            End If
        Next
        For index = 0 To DeleteKeys.Count - 1
            If DeleteKeys(index) <> 0 Then
                Connections.Remove(DeleteKeys(index))
            End If
        Next

        InLB(AuthorsList, Authors)
        InCB(ComboBox1, Authors)
        WriteIn("Авторы.txt", Authors)
        WriteIn("Связи.txt", Connections)
        ComboBox1_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub BooksList_DoubleClick(sender As Object, e As EventArgs) Handles BooksList.DoubleClick
        Dim i As Integer
        For Each el As KeyValuePair(Of Integer, String) In Books
            If el.Value = BooksList.SelectedItem.ToString Then
                i = el.Key
                Books.Remove(el.Key)
                Exit For
            End If
        Next
        Dim DeleteKeys As List(Of Integer) = New List(Of Integer)
        For Each el As KeyValuePair(Of Integer, Integer) In Connections
            If el.Key = i Then
                DeleteKeys.Add(el.Key)
            End If
        Next
        For index = 0 To DeleteKeys.Count - 1
            If DeleteKeys(index) <> 0 Then
                Connections.Remove(DeleteKeys(index))
            End If
        Next

        InLB(BooksList, Books)
        WriteIn("Книги.txt", Books)
        WriteIn("Связи.txt", Connections)
        ComboBox1_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
        Dim j As Integer
        For Each el As KeyValuePair(Of Integer, String) In Books
            If el.Value = ListBox1.SelectedItem.ToString Then
                j = el.Key
            End If
        Next
        Connections.Remove(j)
        WriteIn("Связи.txt", Connections)
        ComboBox1_SelectedIndexChanged(sender, e)
    End Sub
End Class
