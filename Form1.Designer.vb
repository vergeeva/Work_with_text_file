<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.AuthorsList = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BooksList = New System.Windows.Forms.ListBox()
        Me.TextAuthor = New System.Windows.Forms.TextBox()
        Me.TextBook = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ConnectButton = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.NameToAdd = New System.Windows.Forms.TextBox()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.AuthorRadio = New System.Windows.Forms.RadioButton()
        Me.BookRadio = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AuthorsList
        '
        Me.AuthorsList.FormattingEnabled = True
        Me.AuthorsList.ItemHeight = 19
        Me.AuthorsList.Location = New System.Drawing.Point(30, 36)
        Me.AuthorsList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AuthorsList.Name = "AuthorsList"
        Me.AuthorsList.Size = New System.Drawing.Size(336, 137)
        Me.AuthorsList.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Авторы"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Произведения"
        '
        'BooksList
        '
        Me.BooksList.FormattingEnabled = True
        Me.BooksList.ItemHeight = 19
        Me.BooksList.Location = New System.Drawing.Point(30, 199)
        Me.BooksList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BooksList.Name = "BooksList"
        Me.BooksList.Size = New System.Drawing.Size(336, 137)
        Me.BooksList.TabIndex = 2
        '
        'TextAuthor
        '
        Me.TextAuthor.Enabled = False
        Me.TextAuthor.Location = New System.Drawing.Point(15, 26)
        Me.TextAuthor.Name = "TextAuthor"
        Me.TextAuthor.Size = New System.Drawing.Size(211, 27)
        Me.TextAuthor.TabIndex = 4
        '
        'TextBook
        '
        Me.TextBook.Enabled = False
        Me.TextBook.Location = New System.Drawing.Point(15, 59)
        Me.TextBook.Name = "TextBook"
        Me.TextBook.Size = New System.Drawing.Size(211, 27)
        Me.TextBook.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ConnectButton)
        Me.GroupBox1.Controls.Add(Me.TextBook)
        Me.GroupBox1.Controls.Add(Me.TextAuthor)
        Me.GroupBox1.Location = New System.Drawing.Point(399, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(244, 137)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Создать связь"
        '
        'ConnectButton
        '
        Me.ConnectButton.Location = New System.Drawing.Point(17, 92)
        Me.ConnectButton.Name = "ConnectButton"
        Me.ConnectButton.Size = New System.Drawing.Size(208, 30)
        Me.ConnectButton.TabIndex = 6
        Me.ConnectButton.Text = "Соединить"
        Me.ConnectButton.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BookRadio)
        Me.GroupBox2.Controls.Add(Me.AuthorRadio)
        Me.GroupBox2.Controls.Add(Me.AddButton)
        Me.GroupBox2.Controls.Add(Me.NameToAdd)
        Me.GroupBox2.Location = New System.Drawing.Point(399, 197)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(244, 138)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Добавить"
        '
        'NameToAdd
        '
        Me.NameToAdd.Location = New System.Drawing.Point(15, 26)
        Me.NameToAdd.Name = "NameToAdd"
        Me.NameToAdd.Size = New System.Drawing.Size(211, 27)
        Me.NameToAdd.TabIndex = 7
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(15, 102)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(208, 30)
        Me.AddButton.TabIndex = 7
        Me.AddButton.Text = "Добавить"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'AuthorRadio
        '
        Me.AuthorRadio.AutoSize = True
        Me.AuthorRadio.Location = New System.Drawing.Point(16, 68)
        Me.AuthorRadio.Name = "AuthorRadio"
        Me.AuthorRadio.Size = New System.Drawing.Size(73, 23)
        Me.AuthorRadio.TabIndex = 8
        Me.AuthorRadio.TabStop = True
        Me.AuthorRadio.Text = "Автор"
        Me.AuthorRadio.UseVisualStyleBackColor = True
        '
        'BookRadio
        '
        Me.BookRadio.AutoSize = True
        Me.BookRadio.Location = New System.Drawing.Point(95, 68)
        Me.BookRadio.Name = "BookRadio"
        Me.BookRadio.Size = New System.Drawing.Size(131, 23)
        Me.BookRadio.TabIndex = 9
        Me.BookRadio.TabStop = True
        Me.BookRadio.Text = "Произведение"
        Me.BookRadio.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.ListBox1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Location = New System.Drawing.Point(30, 353)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(613, 181)
        Me.Panel1.TabIndex = 8
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(18, 31)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(336, 27)
        Me.ComboBox1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 19)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Выберите автора:"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 19
        Me.ListBox1.Location = New System.Drawing.Point(18, 83)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(336, 80)
        Me.ListBox1.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(165, 19)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Произведения автора:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(368, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(226, 154)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 557)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BooksList)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AuthorsList)
        Me.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Авторы и их произведения"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AuthorsList As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BooksList As ListBox
    Friend WithEvents TextAuthor As TextBox
    Friend WithEvents TextBook As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ConnectButton As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BookRadio As RadioButton
    Friend WithEvents AuthorRadio As RadioButton
    Friend WithEvents AddButton As Button
    Friend WithEvents NameToAdd As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
