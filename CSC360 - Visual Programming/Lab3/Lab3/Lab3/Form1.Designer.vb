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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CustomerName = New System.Windows.Forms.Label()
        Me.IDNumber = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Items = New System.Windows.Forms.GroupBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.SnowboardBoots = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.SnowboardsLabel = New System.Windows.Forms.Label()
        Me.CustomerCharges = New System.Windows.Forms.GroupBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.RentalTotal = New System.Windows.Forms.Label()
        Me.SnowboardBootsCC = New System.Windows.Forms.Label()
        Me.SnowboardsCC = New System.Windows.Forms.Label()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.DailyRentalSummary = New System.Windows.Forms.GroupBox()
        Me.AvgChargePerCustomer = New System.Windows.Forms.Label()
        Me.TotalRentalCharges = New System.Windows.Forms.Label()
        Me.SnowboardsBootsRented = New System.Windows.Forms.Label()
        Me.SnowboardsRented = New System.Windows.Forms.Label()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.CalculateOrder = New System.Windows.Forms.Button()
        Me.Clear = New System.Windows.Forms.Button()
        Me.ClearAll = New System.Windows.Forms.Button()
        Me.Print = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.Items.SuspendLayout()
        Me.CustomerCharges.SuspendLayout()
        Me.DailyRentalSummary.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(140, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        '
        'CustomerName
        '
        Me.CustomerName.AutoSize = True
        Me.CustomerName.Location = New System.Drawing.Point(13, 13)
        Me.CustomerName.Name = "CustomerName"
        Me.CustomerName.Size = New System.Drawing.Size(85, 13)
        Me.CustomerName.TabIndex = 1
        Me.CustomerName.Text = "Customer Name:"
        '
        'IDNumber
        '
        Me.IDNumber.AutoSize = True
        Me.IDNumber.Location = New System.Drawing.Point(13, 42)
        Me.IDNumber.Name = "IDNumber"
        Me.IDNumber.Size = New System.Drawing.Size(58, 13)
        Me.IDNumber.TabIndex = 2
        Me.IDNumber.Text = "ID Number"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(140, 42)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 3
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(639, 328)
        Me.ShapeContainer1.TabIndex = 4
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderWidth = 2
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 318
        Me.LineShape1.X2 = 318
        Me.LineShape1.Y1 = 6
        Me.LineShape1.Y2 = 323
        '
        'Items
        '
        Me.Items.Controls.Add(Me.TextBox4)
        Me.Items.Controls.Add(Me.SnowboardBoots)
        Me.Items.Controls.Add(Me.TextBox3)
        Me.Items.Controls.Add(Me.SnowboardsLabel)
        Me.Items.Location = New System.Drawing.Point(16, 89)
        Me.Items.Name = "Items"
        Me.Items.Size = New System.Drawing.Size(200, 91)
        Me.Items.TabIndex = 5
        Me.Items.TabStop = False
        Me.Items.Text = "Enter Number of Items Rented"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(121, 54)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(73, 20)
        Me.TextBox4.TabIndex = 3
        '
        'SnowboardBoots
        '
        Me.SnowboardBoots.AutoSize = True
        Me.SnowboardBoots.Location = New System.Drawing.Point(9, 62)
        Me.SnowboardBoots.Name = "SnowboardBoots"
        Me.SnowboardBoots.Size = New System.Drawing.Size(109, 13)
        Me.SnowboardBoots.TabIndex = 2
        Me.SnowboardBoots.Text = "Snowboards w/Boots"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(121, 24)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(73, 20)
        Me.TextBox3.TabIndex = 1
        '
        'SnowboardsLabel
        '
        Me.SnowboardsLabel.AutoSize = True
        Me.SnowboardsLabel.Location = New System.Drawing.Point(6, 31)
        Me.SnowboardsLabel.Name = "SnowboardsLabel"
        Me.SnowboardsLabel.Size = New System.Drawing.Size(66, 13)
        Me.SnowboardsLabel.TabIndex = 0
        Me.SnowboardsLabel.Text = "Snowboards"
        '
        'CustomerCharges
        '
        Me.CustomerCharges.Controls.Add(Me.TextBox7)
        Me.CustomerCharges.Controls.Add(Me.TextBox6)
        Me.CustomerCharges.Controls.Add(Me.TextBox5)
        Me.CustomerCharges.Controls.Add(Me.RentalTotal)
        Me.CustomerCharges.Controls.Add(Me.SnowboardBootsCC)
        Me.CustomerCharges.Controls.Add(Me.SnowboardsCC)
        Me.CustomerCharges.Location = New System.Drawing.Point(17, 208)
        Me.CustomerCharges.Name = "CustomerCharges"
        Me.CustomerCharges.Size = New System.Drawing.Size(265, 108)
        Me.CustomerCharges.TabIndex = 6
        Me.CustomerCharges.TabStop = False
        Me.CustomerCharges.Text = "Customer Charges"
        '
        'TextBox7
        '
        Me.TextBox7.Enabled = False
        Me.TextBox7.Location = New System.Drawing.Point(154, 68)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 20)
        Me.TextBox7.TabIndex = 5
        Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox6
        '
        Me.TextBox6.Enabled = False
        Me.TextBox6.Location = New System.Drawing.Point(154, 43)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 4
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox5
        '
        Me.TextBox5.Enabled = False
        Me.TextBox5.Location = New System.Drawing.Point(154, 17)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 3
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RentalTotal
        '
        Me.RentalTotal.AutoSize = True
        Me.RentalTotal.Location = New System.Drawing.Point(7, 76)
        Me.RentalTotal.Name = "RentalTotal"
        Me.RentalTotal.Size = New System.Drawing.Size(65, 13)
        Me.RentalTotal.TabIndex = 2
        Me.RentalTotal.Text = "Rental Total"
        '
        'SnowboardBootsCC
        '
        Me.SnowboardBootsCC.AutoSize = True
        Me.SnowboardBootsCC.Location = New System.Drawing.Point(7, 50)
        Me.SnowboardBootsCC.Name = "SnowboardBootsCC"
        Me.SnowboardBootsCC.Size = New System.Drawing.Size(109, 13)
        Me.SnowboardBootsCC.TabIndex = 1
        Me.SnowboardBootsCC.Text = "Snowboards w/Boots"
        '
        'SnowboardsCC
        '
        Me.SnowboardsCC.AutoSize = True
        Me.SnowboardsCC.Location = New System.Drawing.Point(7, 25)
        Me.SnowboardsCC.Name = "SnowboardsCC"
        Me.SnowboardsCC.Size = New System.Drawing.Size(66, 13)
        Me.SnowboardsCC.TabIndex = 0
        Me.SnowboardsCC.Text = "Snowboards"
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'DailyRentalSummary
        '
        Me.DailyRentalSummary.Controls.Add(Me.AvgChargePerCustomer)
        Me.DailyRentalSummary.Controls.Add(Me.TotalRentalCharges)
        Me.DailyRentalSummary.Controls.Add(Me.SnowboardsBootsRented)
        Me.DailyRentalSummary.Controls.Add(Me.SnowboardsRented)
        Me.DailyRentalSummary.Controls.Add(Me.TextBox11)
        Me.DailyRentalSummary.Controls.Add(Me.TextBox10)
        Me.DailyRentalSummary.Controls.Add(Me.TextBox9)
        Me.DailyRentalSummary.Controls.Add(Me.TextBox8)
        Me.DailyRentalSummary.Location = New System.Drawing.Point(344, 17)
        Me.DailyRentalSummary.Name = "DailyRentalSummary"
        Me.DailyRentalSummary.Size = New System.Drawing.Size(271, 177)
        Me.DailyRentalSummary.TabIndex = 7
        Me.DailyRentalSummary.TabStop = False
        Me.DailyRentalSummary.Text = "Daily Rental Summary"
        '
        'AvgChargePerCustomer
        '
        Me.AvgChargePerCustomer.AutoSize = True
        Me.AvgChargePerCustomer.Location = New System.Drawing.Point(18, 145)
        Me.AvgChargePerCustomer.Name = "AvgChargePerCustomer"
        Me.AvgChargePerCustomer.Size = New System.Drawing.Size(129, 13)
        Me.AvgChargePerCustomer.TabIndex = 7
        Me.AvgChargePerCustomer.Text = "Avg Charge Per Customer"
        '
        'TotalRentalCharges
        '
        Me.TotalRentalCharges.AutoSize = True
        Me.TotalRentalCharges.Location = New System.Drawing.Point(18, 106)
        Me.TotalRentalCharges.Name = "TotalRentalCharges"
        Me.TotalRentalCharges.Size = New System.Drawing.Size(107, 13)
        Me.TotalRentalCharges.TabIndex = 6
        Me.TotalRentalCharges.Text = "Total Rental Charges"
        '
        'SnowboardsBootsRented
        '
        Me.SnowboardsBootsRented.AutoSize = True
        Me.SnowboardsBootsRented.Location = New System.Drawing.Point(18, 69)
        Me.SnowboardsBootsRented.Name = "SnowboardsBootsRented"
        Me.SnowboardsBootsRented.Size = New System.Drawing.Size(150, 13)
        Me.SnowboardsBootsRented.TabIndex = 5
        Me.SnowboardsBootsRented.Text = "Snowboards w/ Boots Rented"
        '
        'SnowboardsRented
        '
        Me.SnowboardsRented.AutoSize = True
        Me.SnowboardsRented.Location = New System.Drawing.Point(18, 31)
        Me.SnowboardsRented.Name = "SnowboardsRented"
        Me.SnowboardsRented.Size = New System.Drawing.Size(104, 13)
        Me.SnowboardsRented.TabIndex = 4
        Me.SnowboardsRented.Text = "Snowboards Rented"
        '
        'TextBox11
        '
        Me.TextBox11.Enabled = False
        Me.TextBox11.Location = New System.Drawing.Point(176, 142)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(89, 20)
        Me.TextBox11.TabIndex = 3
        Me.TextBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox10
        '
        Me.TextBox10.Enabled = False
        Me.TextBox10.Location = New System.Drawing.Point(176, 103)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(89, 20)
        Me.TextBox10.TabIndex = 2
        Me.TextBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox9
        '
        Me.TextBox9.Enabled = False
        Me.TextBox9.Location = New System.Drawing.Point(176, 62)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(62, 20)
        Me.TextBox9.TabIndex = 1
        Me.TextBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox8
        '
        Me.TextBox8.Enabled = False
        Me.TextBox8.Location = New System.Drawing.Point(176, 24)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(62, 20)
        Me.TextBox8.TabIndex = 0
        Me.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CalculateOrder
        '
        Me.CalculateOrder.Location = New System.Drawing.Point(365, 225)
        Me.CalculateOrder.Name = "CalculateOrder"
        Me.CalculateOrder.Size = New System.Drawing.Size(75, 23)
        Me.CalculateOrder.TabIndex = 8
        Me.CalculateOrder.Text = "Calculate Order"
        Me.CalculateOrder.UseVisualStyleBackColor = True
        '
        'Clear
        '
        Me.Clear.Location = New System.Drawing.Point(365, 256)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(75, 23)
        Me.Clear.TabIndex = 9
        Me.Clear.Text = "Clear"
        Me.Clear.UseVisualStyleBackColor = True
        '
        'ClearAll
        '
        Me.ClearAll.Location = New System.Drawing.Point(365, 287)
        Me.ClearAll.Name = "ClearAll"
        Me.ClearAll.Size = New System.Drawing.Size(75, 23)
        Me.ClearAll.TabIndex = 10
        Me.ClearAll.Text = "Clear All"
        Me.ClearAll.UseVisualStyleBackColor = True
        '
        'Print
        '
        Me.Print.Location = New System.Drawing.Point(485, 225)
        Me.Print.Name = "Print"
        Me.Print.Size = New System.Drawing.Size(75, 23)
        Me.Print.TabIndex = 11
        Me.Print.Text = "Print"
        Me.Print.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(484, 256)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 23)
        Me.button1.TabIndex = 12
        Me.button1.Text = "Exit"
        Me.button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 328)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.Print)
        Me.Controls.Add(Me.ClearAll)
        Me.Controls.Add(Me.Clear)
        Me.Controls.Add(Me.CalculateOrder)
        Me.Controls.Add(Me.DailyRentalSummary)
        Me.Controls.Add(Me.CustomerCharges)
        Me.Controls.Add(Me.Items)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.IDNumber)
        Me.Controls.Add(Me.CustomerName)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Form1"
        Me.Text = "Very Very Boards"
        Me.Items.ResumeLayout(False)
        Me.Items.PerformLayout()
        Me.CustomerCharges.ResumeLayout(False)
        Me.CustomerCharges.PerformLayout()
        Me.DailyRentalSummary.ResumeLayout(False)
        Me.DailyRentalSummary.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents CustomerName As System.Windows.Forms.Label
    Friend WithEvents IDNumber As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Items As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents SnowboardBoots As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents SnowboardsLabel As System.Windows.Forms.Label
    Friend WithEvents CustomerCharges As System.Windows.Forms.GroupBox
    Friend WithEvents RentalTotal As System.Windows.Forms.Label
    Friend WithEvents SnowboardBootsCC As System.Windows.Forms.Label
    Friend WithEvents SnowboardsCC As System.Windows.Forms.Label
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents DailyRentalSummary As System.Windows.Forms.GroupBox
    Friend WithEvents AvgChargePerCustomer As System.Windows.Forms.Label
    Friend WithEvents TotalRentalCharges As System.Windows.Forms.Label
    Friend WithEvents SnowboardsBootsRented As System.Windows.Forms.Label
    Friend WithEvents SnowboardsRented As System.Windows.Forms.Label
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents button1 As System.Windows.Forms.Button
    Friend WithEvents Print As System.Windows.Forms.Button
    Friend WithEvents ClearAll As System.Windows.Forms.Button
    Friend WithEvents Clear As System.Windows.Forms.Button
    Friend WithEvents CalculateOrder As System.Windows.Forms.Button
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox

End Class
