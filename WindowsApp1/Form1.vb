Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub mnuOpen_Click(sender As Object, e As EventArgs) Handles mnuOpen.Click

        Dim strFileName As String
        openFD.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        openFD.Title = "Buscando arquivo..."
        openFD.Filter = "Text Files|*.txt|Word Files|*.doc"
        Dim DidWork As Integer = openFD.ShowDialog()
        strFileName = openFD.FileName

        If DidWork = DialogResult.Cancel Then

            MessageBox.Show("Cancel Button Clicked")

        Else

            strFileName = openFD.FileName
            MessageBox.Show(strFileName)

        End If
    End Sub

    Private Sub mnuSave_Click(sender As Object, e As EventArgs) Handles mnuSave.Click
        Dim strFileName As String
        openFD.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        openFD.Title = "Buscando arquivo..."
        openFD.Filter = "Text Files|*.txt|Word Files|*.doc"
        saveFD.ShowDialog()
        strFileName = openFD.FileName
        saveFD.OverwritePrompt = True
    End Sub

    Private Sub mnuCopy_Click(sender As Object, e As EventArgs) Handles mnuCopy.Click
        TextBox1.Copy()
    End Sub

    Private Sub mnuPaste_Click(sender As Object, e As EventArgs) Handles mnuPaste.Click
        TextBox2.Paste()

    End Sub

    Private Sub mnuCut_Click(sender As Object, e As EventArgs) Handles mnuCut.Click
        TextBox1.Cut()

    End Sub

    Private Sub mnuUndo_Click(sender As Object, e As EventArgs) Handles mnuUndo.Click
        TextBox1.Undo()

    End Sub

    Private Sub mnuViewTextBoxes_Click(sender As Object, e As EventArgs) Handles mnuViewTextBoxes.Click
        mnuViewTextBoxes.Checked = Not mnuViewTextBoxes.Checked

        If mnuViewTextBoxes.Checked = True Then

            TextBox1.Visible = True
            TextBox2.Visible = True

        Else

            TextBox1.Visible = False
            TextBox2.Visible = False

        End If
    End Sub

    Private Sub mnuViewImage_Click(sender As Object, e As EventArgs) Handles mnuViewImage.Click
        Dim strFileName As String

        openFD.InitialDirectory = "C:\"

        openFD.Title = "Buscando uma imagem..."
        openFD.Filter = "jpegs|*.jpg|gifs|*.gif|Bitmaps|*.bmp"
        Dim DidWork As Integer = openFD.ShowDialog()

        If DidWork <> DialogResult.Cancel Then

            strFileName = openFD.FileName
            PictureBox1.Image = Image.FromFile(strFileName)
            openFD.Reset()

        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MyText(4) As String

        Dim i As Integer

        MyText(0) = "This"
        MyText(1) = "is"
        MyText(2) = "a"
        MyText(3) = "String"
        MyText(4) = "Array"

        For i = 0 To 4

            ListBox1.Items.Add(MyText(i))

        Next i
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim numbers(10) As Integer
        Dim times As Integer
        Dim StoreAnswer As Integer
        Dim i As Integer

        ListBox1.Items.Clear()

        times = Val(TextBox3.Text)

        For i = 1 To 10

            StoreAnswer = i * i * times

            numbers(i) = StoreAnswer
            ListBox1.Items.Add(times & " times " & i & " = " & numbers(i))

        Next i
    End Sub
End Class
