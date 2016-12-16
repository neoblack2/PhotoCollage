Imports System.IO
Imports System.String

Public Class Form1

    Dim Picture As Integer
    Dim Start As Boolean

    Public FilePath As String

    'При завантаженні програми підкорегувати розміри квадратів та розмір самої форми під розширення екрану
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.Height = Screen.PrimaryScreen.WorkingArea.Height / 1.05
        Me.Width = Me.Height * 1.3
        Me.Location = New Point((Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2)

        Start = False

        Debug.WriteLine(Screen.PrimaryScreen.WorkingArea.Height)

        Debug.WriteLine(Me.Height)

        Debug.WriteLine(Me.Height / 3.27)

        Dim SizeBoxWidth, SizeBoxHeight As String

        SizeBoxWidth = (Me.ClientSize.Width - 40) / 3
        SizeBoxHeight = (Me.ClientSize.Height - 55) / 3

        PictureBox1.Size = New System.Drawing.Size(SizeBoxWidth, SizeBoxHeight)
        PictureBox2.Size = New System.Drawing.Size(SizeBoxWidth, SizeBoxHeight)
        PictureBox3.Size = New System.Drawing.Size(SizeBoxWidth, SizeBoxHeight)
        PictureBox1.Location = New System.Drawing.Size(10, 25)
        PictureBox2.Location = New System.Drawing.Size(SizeBoxWidth + 20, 25)
        PictureBox3.Location = New System.Drawing.Size(SizeBoxWidth * 2 + 30, 25)

        PictureBox4.Size = New System.Drawing.Size(SizeBoxWidth, SizeBoxHeight)
        PictureBox5.Size = New System.Drawing.Size(SizeBoxWidth, SizeBoxHeight)
        PictureBox6.Size = New System.Drawing.Size(SizeBoxWidth, SizeBoxHeight)
        PictureBox4.Location = New System.Drawing.Size(10, 35 + SizeBoxHeight)
        PictureBox5.Location = New System.Drawing.Size(SizeBoxWidth + 20, 35 + SizeBoxHeight)
        PictureBox6.Location = New System.Drawing.Size(SizeBoxWidth * 2 + 30, 35 + SizeBoxHeight)

        PictureBox7.Size = New System.Drawing.Size(SizeBoxWidth, SizeBoxHeight)
        PictureBox8.Size = New System.Drawing.Size(SizeBoxWidth, SizeBoxHeight)
        PictureBox9.Size = New System.Drawing.Size(SizeBoxWidth, SizeBoxHeight)
        PictureBox7.Location = New System.Drawing.Size(10, 45 + SizeBoxHeight * 2)
        PictureBox8.Location = New System.Drawing.Size(SizeBoxWidth + 20, 45 + SizeBoxHeight * 2)
        PictureBox9.Location = New System.Drawing.Size(SizeBoxWidth * 2 + 30, 45 + SizeBoxHeight * 2)

    End Sub

    'Збереження всіх зображень
    Private Sub ЗберегтиToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ЗберегтиToolStripMenuItem.Click

        If PictureBox1.Image Is Nothing And PictureBox2.Image Is Nothing And PictureBox3.Image Is Nothing And PictureBox4.Image Is Nothing And PictureBox5.Image Is Nothing And PictureBox6.Image Is Nothing And PictureBox7.Image Is Nothing And PictureBox8.Image Is Nothing And PictureBox9.Image Is Nothing Then
            MessageBox.Show("Не завантажено жодного фото!", " Увага!")
            Exit Sub
        End If

        Me.BackColor = Color.White
        PictureBox1.BorderStyle = BorderStyle.None
        PictureBox2.BorderStyle = BorderStyle.None
        PictureBox3.BorderStyle = BorderStyle.None
        PictureBox4.BorderStyle = BorderStyle.None
        PictureBox5.BorderStyle = BorderStyle.None
        PictureBox6.BorderStyle = BorderStyle.None
        PictureBox7.BorderStyle = BorderStyle.None
        PictureBox8.BorderStyle = BorderStyle.None
        PictureBox9.BorderStyle = BorderStyle.None
        PictureBox1.Refresh()
        PictureBox2.Refresh()
        PictureBox3.Refresh()
        PictureBox4.Refresh()
        PictureBox5.Refresh()
        PictureBox6.Refresh()
        PictureBox7.Refresh()
        PictureBox8.Refresh()
        PictureBox9.Refresh()

        Dim BM As New Bitmap(Me.Bounds.Width - 24, Me.Bounds.Height - 85)
        Dim G As Graphics = Graphics.FromImage(BM)
        G.CopyFromScreen(Me.Bounds.X + 13, Me.Bounds.Y + 70, 0, 0, Me.Bounds.Size, CopyPixelOperation.SourceCopy)

        SaveFileDialog1.Filter = "Файл зображень (*.jpg)|*.jpg"
        FilePath = Path.GetDirectoryName(OpenFileDialog1.FileName)
        SaveFileDialog1.FileName = Microsoft.VisualBasic.Right(FilePath, Len(FilePath) - InStrRev(FilePath, "\", Len(FilePath), vbTextCompare))

        If SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            BM.Save(SaveFileDialog1.FileName)
            Me.BackColor = SystemColors.Control
            PictureBox1.BorderStyle = BorderStyle.Fixed3D
            PictureBox2.BorderStyle = BorderStyle.Fixed3D
            PictureBox3.BorderStyle = BorderStyle.Fixed3D
            PictureBox4.BorderStyle = BorderStyle.Fixed3D
            PictureBox5.BorderStyle = BorderStyle.Fixed3D
            PictureBox6.BorderStyle = BorderStyle.Fixed3D
            PictureBox7.BorderStyle = BorderStyle.Fixed3D
            PictureBox8.BorderStyle = BorderStyle.Fixed3D
            PictureBox9.BorderStyle = BorderStyle.Fixed3D
            Exit Sub
        End If

        Me.BackColor = SystemColors.Control
        PictureBox1.BorderStyle = BorderStyle.Fixed3D
        PictureBox2.BorderStyle = BorderStyle.Fixed3D
        PictureBox3.BorderStyle = BorderStyle.Fixed3D
        PictureBox4.BorderStyle = BorderStyle.Fixed3D
        PictureBox5.BorderStyle = BorderStyle.Fixed3D
        PictureBox6.BorderStyle = BorderStyle.Fixed3D
        PictureBox7.BorderStyle = BorderStyle.Fixed3D
        PictureBox8.BorderStyle = BorderStyle.Fixed3D
        PictureBox9.BorderStyle = BorderStyle.Fixed3D

    End Sub

    'Очистка всіх зображень
    Private Sub ОчиститиToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ОчиститиToolStripMenuItem.Click

        If MessageBox.Show("Ви дійсно бажаєте очистити всі зображення?", " Увага!", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            PictureBox1.Image = Nothing
            PictureBox2.Image = Nothing
            PictureBox3.Image = Nothing
            PictureBox4.Image = Nothing
            PictureBox5.Image = Nothing
            PictureBox6.Image = Nothing
            PictureBox7.Image = Nothing
            PictureBox8.Image = Nothing
            PictureBox9.Image = Nothing
            Start = False
        End If
    End Sub

    'Виклик контекстного меню в заданого квадратику
    Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown

        If e.Button = Windows.Forms.MouseButtons.Right Then
            Picture = 1
            ContextMenuStrip1.Show(MousePosition)
        End If

    End Sub

    'Виклик контекстного меню в заданого квадратику
    Private Sub PictureBox2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseDown

        If e.Button = Windows.Forms.MouseButtons.Right Then
            Picture = 2
            ContextMenuStrip1.Show(MousePosition)
        End If

    End Sub

    'Виклик контекстного меню в заданого квадратику
    Private Sub PictureBox3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox3.MouseDown

        If e.Button = Windows.Forms.MouseButtons.Right Then
            Picture = 3
            ContextMenuStrip1.Show(MousePosition)
        End If

    End Sub

    'Виклик контекстного меню в заданого квадратику
    Private Sub PictureBox4_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox4.MouseDown

        If e.Button = Windows.Forms.MouseButtons.Right Then
            Picture = 4
            ContextMenuStrip1.Show(MousePosition)
        End If

    End Sub

    'Виклик контекстного меню в заданого квадратику
    Private Sub PictureBox5_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox5.MouseDown

        If e.Button = Windows.Forms.MouseButtons.Right Then
            Picture = 5
            ContextMenuStrip1.Show(MousePosition)
        End If

    End Sub

    'Виклик контекстного меню в заданого квадратику
    Private Sub PictureBox6_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox6.MouseDown

        If e.Button = Windows.Forms.MouseButtons.Right Then
            Picture = 6
            ContextMenuStrip1.Show(MousePosition)
        End If

    End Sub

    'Виклик контекстного меню в заданого квадратику
    Private Sub PictureBox7_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox7.MouseDown

        If e.Button = Windows.Forms.MouseButtons.Right Then
            Picture = 7
            ContextMenuStrip1.Show(MousePosition)
        End If

    End Sub

    'Виклик контекстного меню в заданого квадратику
    Private Sub PictureBox8_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox8.MouseDown

        If e.Button = Windows.Forms.MouseButtons.Right Then
            Picture = 8
            ContextMenuStrip1.Show(MousePosition)
        End If

    End Sub

    'Виклик контекстного меню в заданого квадратику
    Private Sub PictureBox9_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox9.MouseDown

        If e.Button = Windows.Forms.MouseButtons.Right Then
            Picture = 9
            ContextMenuStrip1.Show(MousePosition)
        End If

    End Sub

    'Вибір і завантаження фото в квадратик
    Private Sub ЗавантажитиФотоToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ЗавантажитиФотоToolStripMenuItem.Click

        If Start = False Then
            OpenFileDialog1.InitialDirectory = Application.StartupPath
            Start = True
        Else
            OpenFileDialog1.InitialDirectory = Nothing
        End If

        OpenFileDialog1.Filter = "Файли зображень (*.jpg;*.jpeg;*.bmp;*.gif;*.png)|*.jpg;*.jpeg;*.bmp;*.gif;*.png"

        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                If OpenFileDialog1.OpenFile() IsNot Nothing Then

                    Select Case Picture
                        Case 1
                            PictureBox1.ImageLocation = OpenFileDialog1.FileName
                            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
                        Case 2
                            PictureBox2.ImageLocation = OpenFileDialog1.FileName
                            PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
                        Case 3
                            PictureBox3.ImageLocation = OpenFileDialog1.FileName
                            PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
                        Case 4
                            PictureBox4.ImageLocation = OpenFileDialog1.FileName
                            PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
                        Case 5
                            PictureBox5.ImageLocation = OpenFileDialog1.FileName
                            PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
                        Case 6
                            PictureBox6.ImageLocation = OpenFileDialog1.FileName
                            PictureBox6.SizeMode = PictureBoxSizeMode.Zoom
                        Case 7
                            PictureBox7.ImageLocation = OpenFileDialog1.FileName
                            PictureBox7.SizeMode = PictureBoxSizeMode.Zoom
                        Case 8
                            PictureBox8.ImageLocation = OpenFileDialog1.FileName
                            PictureBox8.SizeMode = PictureBoxSizeMode.Zoom
                        Case 9
                            PictureBox9.ImageLocation = OpenFileDialog1.FileName
                            PictureBox9.SizeMode = PictureBoxSizeMode.Zoom
                    End Select
                End If
            Catch Ex As Exception
                MessageBox.Show("Помилка відкриття файлу: " & Ex.Message)
            End Try
        End If

    End Sub

    'Очистка фото в квадратику
    Private Sub ВидалитиФотоToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ВидалитиФотоToolStripMenuItem.Click

        Select Case Picture
            Case 1
                PictureBox1.Image = Nothing
            Case 2
                PictureBox2.Image = Nothing
            Case 3
                PictureBox3.Image = Nothing
            Case 4
                PictureBox4.Image = Nothing
            Case 5
                PictureBox5.Image = Nothing
            Case 6
                PictureBox6.Image = Nothing
            Case 7
                PictureBox7.Image = Nothing
            Case 8
                PictureBox8.Image = Nothing
            Case 9
                PictureBox9.Image = Nothing
        End Select

    End Sub


    Private Sub ПовернутиФотоToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ПовернутиФотоToolStripMenuItem.Click

        Select Case Picture
            Case 1
                If PictureBox1.Image Is Nothing Then
                    MessageBox.Show("Не завантажено фото!", " Увага!")
                    Exit Sub
                End If
            Case 2
                If PictureBox2.Image Is Nothing Then
                    MessageBox.Show("Не завантажено фото!", " Увага!")
                    Exit Sub
                End If
            Case 3
                If PictureBox3.Image Is Nothing Then
                    MessageBox.Show("Не завантажено фото!", " Увага!")
                    Exit Sub
                End If
            Case 4
                If PictureBox4.Image Is Nothing Then
                    MessageBox.Show("Не завантажено фото!", " Увага!")
                    Exit Sub
                End If
            Case (5)
                If PictureBox5.Image Is Nothing Then
                    MessageBox.Show("Не завантажено фото!", " Увага!")
                    Exit Sub
                End If
            Case (6)
                If PictureBox6.Image Is Nothing Then
                    MessageBox.Show("Не завантажено фото!", " Увага!")
                    Exit Sub
                End If
            Case (7)
                If PictureBox7.Image Is Nothing Then
                    MessageBox.Show("Не завантажено фото!", " Увага!")
                    Exit Sub
                End If
            Case (8)
                If PictureBox8.Image Is Nothing Then
                    MessageBox.Show("Не завантажено фото!", " Увага!")
                    Exit Sub
                End If
            Case (9)
                If PictureBox9.Image Is Nothing Then
                    MessageBox.Show("Не завантажено фото!", " Увага!")
                    Exit Sub
                End If
        End Select

        Select Case Picture
            Case 1
                PictureBox1.Image.RotateFlip(RotateFlipType.RotateNoneFlipX)
                PictureBox1.Refresh()
            Case 2
                PictureBox2.Image.RotateFlip(RotateFlipType.RotateNoneFlipX)
                PictureBox2.Refresh()
            Case 3
                PictureBox3.Image.RotateFlip(RotateFlipType.RotateNoneFlipX)
                PictureBox3.Refresh()
            Case 4
                PictureBox4.Image.RotateFlip(RotateFlipType.RotateNoneFlipX)
                PictureBox4.Refresh()
            Case (5)
                PictureBox5.Image.RotateFlip(RotateFlipType.RotateNoneFlipX)
                PictureBox5.Refresh()
            Case (6)
                PictureBox6.Image.RotateFlip(RotateFlipType.RotateNoneFlipX)
                PictureBox6.Refresh()
            Case (7)
                PictureBox7.Image.RotateFlip(RotateFlipType.RotateNoneFlipX)
                PictureBox7.Refresh()
            Case (8)
                PictureBox8.Image.RotateFlip(RotateFlipType.RotateNoneFlipX)
                PictureBox8.Refresh()
            Case (9)
                PictureBox9.Image.RotateFlip(RotateFlipType.RotateNoneFlipX)
                PictureBox9.Refresh()
        End Select

    End Sub

    Private Sub ПовернутиВетикальToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ПовернутиВетикальToolStripMenuItem.Click

        Select Case Picture
            Case 1
                If PictureBox1.Image Is Nothing Then
                    MessageBox.Show("Не завантажено фото!", " Увага!")
                    Exit Sub
                End If
            Case 2
                If PictureBox2.Image Is Nothing Then
                    MessageBox.Show("Не завантажено фото!", " Увага!")
                    Exit Sub
                End If
            Case 3
                If PictureBox3.Image Is Nothing Then
                    MessageBox.Show("Не завантажено фото!", " Увага!")
                    Exit Sub
                End If
            Case 4
                If PictureBox4.Image Is Nothing Then
                    MessageBox.Show("Не завантажено фото!", " Увага!")
                    Exit Sub
                End If
            Case (5)
                If PictureBox5.Image Is Nothing Then
                    MessageBox.Show("Не завантажено фото!", " Увага!")
                    Exit Sub
                End If
            Case (6)
                If PictureBox6.Image Is Nothing Then
                    MessageBox.Show("Не завантажено фото!", " Увага!")
                    Exit Sub
                End If
            Case (7)
                If PictureBox7.Image Is Nothing Then
                    MessageBox.Show("Не завантажено фото!", " Увага!")
                    Exit Sub
                End If
            Case (8)
                If PictureBox8.Image Is Nothing Then
                    MessageBox.Show("Не завантажено фото!", " Увага!")
                    Exit Sub
                End If
            Case (9)
                If PictureBox9.Image Is Nothing Then
                    MessageBox.Show("Не завантажено фото!", " Увага!")
                    Exit Sub
                End If
        End Select

        Select Case Picture
            Case 1
                PictureBox1.Image.RotateFlip(RotateFlipType.RotateNoneFlipY)
                PictureBox1.Refresh()
            Case 2
                PictureBox2.Image.RotateFlip(RotateFlipType.RotateNoneFlipY)
                PictureBox2.Refresh()
            Case 3
                PictureBox3.Image.RotateFlip(RotateFlipType.RotateNoneFlipY)
                PictureBox3.Refresh()
            Case 4
                PictureBox4.Image.RotateFlip(RotateFlipType.RotateNoneFlipY)
                PictureBox4.Refresh()
            Case (5)
                PictureBox5.Image.RotateFlip(RotateFlipType.RotateNoneFlipY)
                PictureBox5.Refresh()
            Case (6)
                PictureBox6.Image.RotateFlip(RotateFlipType.RotateNoneFlipY)
                PictureBox6.Refresh()
            Case (7)
                PictureBox7.Image.RotateFlip(RotateFlipType.RotateNoneFlipY)
                PictureBox7.Refresh()
            Case (8)
                PictureBox8.Image.RotateFlip(RotateFlipType.RotateNoneFlipY)
                PictureBox8.Refresh()
            Case (9)
                PictureBox9.Image.RotateFlip(RotateFlipType.RotateNoneFlipY)
                PictureBox9.Refresh()
        End Select

    End Sub

    Private Sub ЗаповнитиToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ЗаповнитиToolStripMenuItem.Click

        Select Case Picture
            Case 1
                If PictureBox1.Image Is Nothing Then
                    MessageBox.Show("Не завантажено фото!", " Увага!")
                    Exit Sub
                End If
            Case 2
                If PictureBox2.Image Is Nothing Then
                    MessageBox.Show("Не завантажено фото!", " Увага!")
                    Exit Sub
                End If
            Case 3
                If PictureBox3.Image Is Nothing Then
                    MessageBox.Show("Не завантажено фото!", " Увага!")
                    Exit Sub
                End If
            Case 4
                If PictureBox4.Image Is Nothing Then
                    MessageBox.Show("Не завантажено фото!", " Увага!")
                    Exit Sub
                End If
            Case (5)
                If PictureBox5.Image Is Nothing Then
                    MessageBox.Show("Не завантажено фото!", " Увага!")
                    Exit Sub
                End If
            Case (6)
                If PictureBox6.Image Is Nothing Then
                    MessageBox.Show("Не завантажено фото!", " Увага!")
                    Exit Sub
                End If
            Case (7)
                If PictureBox7.Image Is Nothing Then
                    MessageBox.Show("Не завантажено фото!", " Увага!")
                    Exit Sub
                End If
            Case (8)
                If PictureBox8.Image Is Nothing Then
                    MessageBox.Show("Не завантажено фото!", " Увага!")
                    Exit Sub
                End If
            Case (9)
                If PictureBox9.Image Is Nothing Then
                    MessageBox.Show("Не завантажено фото!", " Увага!")
                    Exit Sub
                End If
        End Select

        Select Case Picture
            Case 1
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                PictureBox1.Refresh()
            Case 2
                PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
                PictureBox2.Refresh()
            Case 3
                PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
                PictureBox3.Refresh()
            Case 4
                PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
                PictureBox4.Refresh()
            Case (5)
                PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
                PictureBox5.Refresh()
            Case (6)
                PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
                PictureBox6.Refresh()
            Case (7)
                PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
                PictureBox7.Refresh()
            Case (8)
                PictureBox8.SizeMode = PictureBoxSizeMode.StretchImage
                PictureBox8.Refresh()
            Case (9)
                PictureBox9.SizeMode = PictureBoxSizeMode.StretchImage
                PictureBox9.Refresh()
        End Select

    End Sub

    Private Sub ЗменшитиToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ЗменшитиToolStripMenuItem.Click

        Select Case Picture
            Case 1
                If PictureBox1.Image Is Nothing Then
                    MessageBox.Show("Не завантажено фото!", " Увага!")
                    Exit Sub
                End If
            Case 2
                If PictureBox2.Image Is Nothing Then
                    MessageBox.Show("Не завантажено фото!", " Увага!")
                    Exit Sub
                End If
            Case 3
                If PictureBox3.Image Is Nothing Then
                    MessageBox.Show("Не завантажено фото!", " Увага!")
                    Exit Sub
                End If
            Case 4
                If PictureBox4.Image Is Nothing Then
                    MessageBox.Show("Не завантажено фото!", " Увага!")
                    Exit Sub
                End If
            Case (5)
                If PictureBox5.Image Is Nothing Then
                    MessageBox.Show("Не завантажено фото!", " Увага!")
                    Exit Sub
                End If
            Case (6)
                If PictureBox6.Image Is Nothing Then
                    MessageBox.Show("Не завантажено фото!", " Увага!")
                    Exit Sub
                End If
            Case (7)
                If PictureBox7.Image Is Nothing Then
                    MessageBox.Show("Не завантажено фото!", " Увага!")
                    Exit Sub
                End If
            Case (8)
                If PictureBox8.Image Is Nothing Then
                    MessageBox.Show("Не завантажено фото!", " Увага!")
                    Exit Sub
                End If
            Case (9)
                If PictureBox9.Image Is Nothing Then
                    MessageBox.Show("Не завантажено фото!", " Увага!")
                    Exit Sub
                End If
        End Select

        Select Case Picture
            Case 1
                PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
                PictureBox1.Refresh()
            Case 2
                PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
                PictureBox2.Refresh()
            Case 3
                PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
                PictureBox3.Refresh()
            Case 4
                PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
                PictureBox4.Refresh()
            Case (5)
                PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
                PictureBox5.Refresh()
            Case (6)
                PictureBox6.SizeMode = PictureBoxSizeMode.Zoom
                PictureBox6.Refresh()
            Case (7)
                PictureBox7.SizeMode = PictureBoxSizeMode.Zoom
                PictureBox7.Refresh()
            Case (8)
                PictureBox8.SizeMode = PictureBoxSizeMode.Zoom
                PictureBox8.Refresh()
            Case (9)
                PictureBox9.SizeMode = PictureBoxSizeMode.Zoom
                PictureBox9.Refresh()
        End Select

    End Sub

    Private Sub ДопомогаToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ДопомогаToolStripMenuItem.Click

        MessageBox.Show("Це программа для монтажу однієї великої фотографії з кількох малих." + vbCrLf + "Робота з фотографіями відбувається через праву кнопку мишки на " + vbCrLf + "пустому квадратику. Збереження фото робиться через верхнє меню" + vbCrLf + "Зберегти. Очищення усіх фотографій через пункт меню Очистити.", " Допомога!")

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Picture = 1
        ЗавантажитиФотоToolStripMenuItem.PerformClick()
    End Sub


    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Picture = 2
        ЗавантажитиФотоToolStripMenuItem.PerformClick()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Picture = 3
        ЗавантажитиФотоToolStripMenuItem.PerformClick()
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Picture = 4
        ЗавантажитиФотоToolStripMenuItem.PerformClick()
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        Picture = 5
        ЗавантажитиФотоToolStripMenuItem.PerformClick()
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        Picture = 6
        ЗавантажитиФотоToolStripMenuItem.PerformClick()
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        Picture = 7
        ЗавантажитиФотоToolStripMenuItem.PerformClick()
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        Picture = 8
        ЗавантажитиФотоToolStripMenuItem.PerformClick()
    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        Picture = 9
        ЗавантажитиФотоToolStripMenuItem.PerformClick()
    End Sub

End Class
