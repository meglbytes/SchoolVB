<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.display = New System.Windows.Forms.Button()
        Me.print = New System.Windows.Forms.Button()
        Me.clear = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ohappy = New System.Windows.Forms.PictureBox()
        Me.happy = New System.Windows.Forms.PictureBox()
        Me.ohhappy = New System.Windows.Forms.Label()
        Me.clickme = New System.Windows.Forms.Label()
        Me.behappy = New System.Windows.Forms.Label()
        Me.bhappy = New System.Windows.Forms.PictureBox()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.ohappy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.happy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bhappy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(73, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(117, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(271, 20)
        Me.TextBox1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Message of the Day:"
        '
        'display
        '
        Me.display.Location = New System.Drawing.Point(337, 184)
        Me.display.Name = "display"
        Me.display.Size = New System.Drawing.Size(75, 23)
        Me.display.TabIndex = 6
        Me.display.Text = "&Display"
        Me.display.UseVisualStyleBackColor = True
        '
        'print
        '
        Me.print.Location = New System.Drawing.Point(337, 213)
        Me.print.Name = "print"
        Me.print.Size = New System.Drawing.Size(75, 23)
        Me.print.TabIndex = 7
        Me.print.Text = "&Print"
        Me.print.UseVisualStyleBackColor = True
        '
        'clear
        '
        Me.clear.Location = New System.Drawing.Point(337, 242)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(75, 23)
        Me.clear.TabIndex = 8
        Me.clear.Text = "&Clear"
        Me.clear.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(337, 271)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "&Exit"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 184)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(147, 129)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Choose a Color:"
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(7, 92)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(45, 17)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.Text = "&Red"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(7, 68)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(54, 17)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.Text = "&Green"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(7, 44)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(56, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "&Yellow"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(7, 20)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(46, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "&Blue"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(117, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 0
        '
        'ohappy
        '
        Me.ohappy.Image = Global.WindowsApplication1.My.Resources.Resources.FACE02
        Me.ohappy.Location = New System.Drawing.Point(176, 183)
        Me.ohappy.Name = "ohappy"
        Me.ohappy.Size = New System.Drawing.Size(120, 110)
        Me.ohappy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ohappy.TabIndex = 11
        Me.ohappy.TabStop = False
        Me.ohappy.Visible = False
        '
        'happy
        '
        Me.happy.Image = Global.WindowsApplication1.My.Resources.Resources.FACE03
        Me.happy.Location = New System.Drawing.Point(176, 184)
        Me.happy.Name = "happy"
        Me.happy.Size = New System.Drawing.Size(120, 110)
        Me.happy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.happy.TabIndex = 12
        Me.happy.TabStop = False
        '
        'ohhappy
        '
        Me.ohhappy.AutoSize = True
        Me.ohhappy.Location = New System.Drawing.Point(207, 296)
        Me.ohhappy.Name = "ohhappy"
        Me.ohhappy.Size = New System.Drawing.Size(80, 13)
        Me.ohhappy.TabIndex = 0
        Me.ohhappy.Text = "Oh Happy Day!"
        Me.ohhappy.Visible = False
        '
        'clickme
        '
        Me.clickme.AutoSize = True
        Me.clickme.Location = New System.Drawing.Point(207, 296)
        Me.clickme.Name = "clickme"
        Me.clickme.Size = New System.Drawing.Size(48, 13)
        Me.clickme.TabIndex = 0
        Me.clickme.Text = "Click Me"
        '
        'behappy
        '
        Me.behappy.AutoSize = True
        Me.behappy.Location = New System.Drawing.Point(207, 296)
        Me.behappy.Name = "behappy"
        Me.behappy.Size = New System.Drawing.Size(57, 13)
        Me.behappy.TabIndex = 0
        Me.behappy.Text = "Be Happy!"
        '
        'bhappy
        '
        Me.bhappy.Image = Global.WindowsApplication1.My.Resources.Resources.FACE01
        Me.bhappy.Location = New System.Drawing.Point(176, 183)
        Me.bhappy.Name = "bhappy"
        Me.bhappy.Size = New System.Drawing.Size(120, 110)
        Me.bhappy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bhappy.TabIndex = 13
        Me.bhappy.TabStop = False
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 331)
        Me.Controls.Add(Me.bhappy)
        Me.Controls.Add(Me.behappy)
        Me.Controls.Add(Me.clickme)
        Me.Controls.Add(Me.ohhappy)
        Me.Controls.Add(Me.happy)
        Me.Controls.Add(Me.ohappy)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.print)
        Me.Controls.Add(Me.display)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Message of the Day"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ohappy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.happy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bhappy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents display As System.Windows.Forms.Button
    Friend WithEvents print As System.Windows.Forms.Button
    Friend WithEvents clear As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ohappy As System.Windows.Forms.PictureBox
    Friend WithEvents happy As System.Windows.Forms.PictureBox
    Friend WithEvents ohhappy As System.Windows.Forms.Label
    Friend WithEvents clickme As System.Windows.Forms.Label
    Friend WithEvents behappy As System.Windows.Forms.Label
    Friend WithEvents bhappy As System.Windows.Forms.PictureBox
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm

End Class
