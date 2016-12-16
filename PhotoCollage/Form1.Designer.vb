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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ЗберегтиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОчиститиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ДопомогаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ЗавантажитиФотоToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.РедагуватиФотоToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ЗаповнитиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ЗменшитиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПовернутиФотоToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПовернутиВетикальToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ВидалитиФотоToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(12, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(333, 226)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(351, 25)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(382, 226)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox3.Location = New System.Drawing.Point(750, 25)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(347, 226)
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.InitialDirectory = "Application.pathname"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ЗберегтиToolStripMenuItem, Me.ОчиститиToolStripMenuItem, Me.ДопомогаToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1109, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ЗберегтиToolStripMenuItem
        '
        Me.ЗберегтиToolStripMenuItem.Name = "ЗберегтиToolStripMenuItem"
        Me.ЗберегтиToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.ЗберегтиToolStripMenuItem.Text = "Зберегти"
        '
        'ОчиститиToolStripMenuItem
        '
        Me.ОчиститиToolStripMenuItem.Name = "ОчиститиToolStripMenuItem"
        Me.ОчиститиToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.ОчиститиToolStripMenuItem.Text = "Очистити"
        '
        'ДопомогаToolStripMenuItem
        '
        Me.ДопомогаToolStripMenuItem.Name = "ДопомогаToolStripMenuItem"
        Me.ДопомогаToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.ДопомогаToolStripMenuItem.Text = "Допомога"
        '
        'PictureBox4
        '
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox4.Location = New System.Drawing.Point(12, 257)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(333, 228)
        Me.PictureBox4.TabIndex = 7
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox5.Location = New System.Drawing.Point(351, 257)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(382, 228)
        Me.PictureBox5.TabIndex = 8
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox6.Location = New System.Drawing.Point(750, 257)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(347, 228)
        Me.PictureBox6.TabIndex = 9
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox7.Location = New System.Drawing.Point(13, 500)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(332, 271)
        Me.PictureBox7.TabIndex = 10
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox8.Location = New System.Drawing.Point(351, 500)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(382, 271)
        Me.PictureBox8.TabIndex = 11
        Me.PictureBox8.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox9.Location = New System.Drawing.Point(750, 500)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(347, 271)
        Me.PictureBox9.TabIndex = 12
        Me.PictureBox9.TabStop = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ЗавантажитиФотоToolStripMenuItem, Me.РедагуватиФотоToolStripMenuItem, Me.ВидалитиФотоToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(177, 70)
        '
        'ЗавантажитиФотоToolStripMenuItem
        '
        Me.ЗавантажитиФотоToolStripMenuItem.Name = "ЗавантажитиФотоToolStripMenuItem"
        Me.ЗавантажитиФотоToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ЗавантажитиФотоToolStripMenuItem.Text = "Завантажити фото"
        '
        'РедагуватиФотоToolStripMenuItem
        '
        Me.РедагуватиФотоToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ЗаповнитиToolStripMenuItem, Me.ЗменшитиToolStripMenuItem, Me.ПовернутиФотоToolStripMenuItem, Me.ПовернутиВетикальToolStripMenuItem})
        Me.РедагуватиФотоToolStripMenuItem.Name = "РедагуватиФотоToolStripMenuItem"
        Me.РедагуватиФотоToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.РедагуватиФотоToolStripMenuItem.Text = "Редагувати фото"
        '
        'ЗаповнитиToolStripMenuItem
        '
        Me.ЗаповнитиToolStripMenuItem.Name = "ЗаповнитиToolStripMenuItem"
        Me.ЗаповнитиToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.ЗаповнитиToolStripMenuItem.Text = "Розширити фото"
        '
        'ЗменшитиToolStripMenuItem
        '
        Me.ЗменшитиToolStripMenuItem.Name = "ЗменшитиToolStripMenuItem"
        Me.ЗменшитиToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.ЗменшитиToolStripMenuItem.Text = "Оригінал фото"
        '
        'ПовернутиФотоToolStripMenuItem
        '
        Me.ПовернутиФотоToolStripMenuItem.Name = "ПовернутиФотоToolStripMenuItem"
        Me.ПовернутиФотоToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.ПовернутиФотоToolStripMenuItem.Text = "Повернути горизонталь"
        '
        'ПовернутиВетикальToolStripMenuItem
        '
        Me.ПовернутиВетикальToolStripMenuItem.Name = "ПовернутиВетикальToolStripMenuItem"
        Me.ПовернутиВетикальToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.ПовернутиВетикальToolStripMenuItem.Text = "Повернути вертикаль"
        '
        'ВидалитиФотоToolStripMenuItem
        '
        Me.ВидалитиФотоToolStripMenuItem.Name = "ВидалитиФотоToolStripMenuItem"
        Me.ВидалитиФотоToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ВидалитиФотоToolStripMenuItem.Text = "Видалити фото"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1109, 861)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Фото редактор 1.2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ЗберегтиToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ОчиститиToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ДопомогаToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ЗавантажитиФотоToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ВидалитиФотоToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents РедагуватиФотоToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ПовернутиФотоToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ПовернутиВетикальToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ЗменшитиToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ЗаповнитиToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
