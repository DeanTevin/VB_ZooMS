<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Medicine
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Medicine))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.NewMedicineTab = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.NewMedStock = New System.Windows.Forms.TextBox()
        Me.NewMedName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.StockMedicineTab = New System.Windows.Forms.TabPage()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DeleteMedicineTab = New System.Windows.Forms.TabPage()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NewMedicineTab.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.StockMedicineTab.SuspendLayout()
        Me.DeleteMedicineTab.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-33, 164)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(692, 541)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Impact", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(10, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(626, 68)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CARE | INSPIRE | EMPOWER"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(490, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(70, 71)
        Me.Button2.TabIndex = 4
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(566, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(70, 71)
        Me.Button3.TabIndex = 5
        Me.Button3.UseVisualStyleBackColor = True
        '
        'NewMedicineTab
        '
        Me.NewMedicineTab.BackgroundImage = CType(resources.GetObject("NewMedicineTab.BackgroundImage"), System.Drawing.Image)
        Me.NewMedicineTab.Controls.Add(Me.Button1)
        Me.NewMedicineTab.Controls.Add(Me.NewMedStock)
        Me.NewMedicineTab.Controls.Add(Me.NewMedName)
        Me.NewMedicineTab.Controls.Add(Me.Label4)
        Me.NewMedicineTab.Controls.Add(Me.Label3)
        Me.NewMedicineTab.Location = New System.Drawing.Point(4, 29)
        Me.NewMedicineTab.Name = "NewMedicineTab"
        Me.NewMedicineTab.Padding = New System.Windows.Forms.Padding(3)
        Me.NewMedicineTab.Size = New System.Drawing.Size(585, 414)
        Me.NewMedicineTab.TabIndex = 0
        Me.NewMedicineTab.Text = "New Medicine"
        Me.NewMedicineTab.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(221, 288)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(165, 96)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "ADD NEW"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'NewMedStock
        '
        Me.NewMedStock.Location = New System.Drawing.Point(154, 241)
        Me.NewMedStock.Name = "NewMedStock"
        Me.NewMedStock.Size = New System.Drawing.Size(380, 26)
        Me.NewMedStock.TabIndex = 24
        '
        'NewMedName
        '
        Me.NewMedName.Location = New System.Drawing.Point(154, 139)
        Me.NewMedName.Name = "NewMedName"
        Me.NewMedName.Size = New System.Drawing.Size(380, 26)
        Me.NewMedName.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(65, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 26)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Initial Stock"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(65, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(177, 26)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Medicine Name"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.NewMedicineTab)
        Me.TabControl1.Controls.Add(Me.StockMedicineTab)
        Me.TabControl1.Controls.Add(Me.DeleteMedicineTab)
        Me.TabControl1.Location = New System.Drawing.Point(22, 197)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(593, 447)
        Me.TabControl1.TabIndex = 2
        '
        'StockMedicineTab
        '
        Me.StockMedicineTab.BackgroundImage = CType(resources.GetObject("StockMedicineTab.BackgroundImage"), System.Drawing.Image)
        Me.StockMedicineTab.Controls.Add(Me.TextBox3)
        Me.StockMedicineTab.Controls.Add(Me.TextBox4)
        Me.StockMedicineTab.Controls.Add(Me.ComboBox1)
        Me.StockMedicineTab.Controls.Add(Me.Button4)
        Me.StockMedicineTab.Controls.Add(Me.Button5)
        Me.StockMedicineTab.Controls.Add(Me.Label2)
        Me.StockMedicineTab.Controls.Add(Me.Label5)
        Me.StockMedicineTab.Controls.Add(Me.Label6)
        Me.StockMedicineTab.Location = New System.Drawing.Point(4, 29)
        Me.StockMedicineTab.Name = "StockMedicineTab"
        Me.StockMedicineTab.Padding = New System.Windows.Forms.Padding(3)
        Me.StockMedicineTab.Size = New System.Drawing.Size(585, 414)
        Me.StockMedicineTab.TabIndex = 4
        Me.StockMedicineTab.Text = "Medicine Stock"
        Me.StockMedicineTab.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(142, 233)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(380, 26)
        Me.TextBox3.TabIndex = 34
        '
        'TextBox4
        '
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(142, 152)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(380, 26)
        Me.TextBox4.TabIndex = 33
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(142, 82)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(380, 28)
        Me.ComboBox1.TabIndex = 32
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(393, 279)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(139, 83)
        Me.Button4.TabIndex = 31
        Me.Button4.Text = "ADD"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(90, 279)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(139, 83)
        Me.Button5.TabIndex = 30
        Me.Button5.Text = "TAKE"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(53, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 26)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Quantity"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(53, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 26)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Stock"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(53, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(177, 26)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Medicine Name"
        '
        'DeleteMedicineTab
        '
        Me.DeleteMedicineTab.BackgroundImage = CType(resources.GetObject("DeleteMedicineTab.BackgroundImage"), System.Drawing.Image)
        Me.DeleteMedicineTab.Controls.Add(Me.TextBox6)
        Me.DeleteMedicineTab.Controls.Add(Me.ComboBox2)
        Me.DeleteMedicineTab.Controls.Add(Me.Button6)
        Me.DeleteMedicineTab.Controls.Add(Me.Label8)
        Me.DeleteMedicineTab.Controls.Add(Me.Label9)
        Me.DeleteMedicineTab.Location = New System.Drawing.Point(4, 29)
        Me.DeleteMedicineTab.Name = "DeleteMedicineTab"
        Me.DeleteMedicineTab.Padding = New System.Windows.Forms.Padding(3)
        Me.DeleteMedicineTab.Size = New System.Drawing.Size(585, 414)
        Me.DeleteMedicineTab.TabIndex = 5
        Me.DeleteMedicineTab.Text = "Delete Medicine"
        Me.DeleteMedicineTab.UseVisualStyleBackColor = True
        '
        'TextBox6
        '
        Me.TextBox6.Enabled = False
        Me.TextBox6.Location = New System.Drawing.Point(142, 181)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(380, 26)
        Me.TextBox6.TabIndex = 25
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(142, 82)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(380, 28)
        Me.ComboBox2.TabIndex = 24
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(219, 263)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(165, 96)
        Me.Button6.TabIndex = 23
        Me.Button6.Text = "DELETE"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(53, 149)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 26)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Stock"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(53, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(177, 26)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Medicine Name"
        '
        'Medicine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(648, 690)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Medicine"
        Me.Text = "Form2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NewMedicineTab.ResumeLayout(False)
        Me.NewMedicineTab.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.StockMedicineTab.ResumeLayout(False)
        Me.StockMedicineTab.PerformLayout()
        Me.DeleteMedicineTab.ResumeLayout(False)
        Me.DeleteMedicineTab.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents NewMedicineTab As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents NewMedStock As TextBox
    Friend WithEvents NewMedName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Private WithEvents TabControl1 As TabControl
    Friend WithEvents StockMedicineTab As TabPage
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DeleteMedicineTab As TabPage
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
