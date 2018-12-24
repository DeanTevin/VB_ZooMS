<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Animals
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Animals))
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.NewAnimalsTab = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ConditionTab = New System.Windows.Forms.TabPage()
        Me.RelocationTab = New System.Windows.Forms.TabPage()
        Me.AnimalDeleteTab = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.NewAnimalsTab.SuspendLayout()
        Me.ConditionTab.SuspendLayout()
        Me.RelocationTab.SuspendLayout()
        Me.AnimalDeleteTab.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(505, 2)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(62, 57)
        Me.Button3.TabIndex = 10
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(437, 2)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(62, 57)
        Me.Button2.TabIndex = 9
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.NewAnimalsTab)
        Me.TabControl1.Controls.Add(Me.ConditionTab)
        Me.TabControl1.Controls.Add(Me.RelocationTab)
        Me.TabControl1.Controls.Add(Me.AnimalDeleteTab)
        Me.TabControl1.Location = New System.Drawing.Point(21, 160)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(527, 358)
        Me.TabControl1.TabIndex = 8
        '
        'NewAnimalsTab
        '
        Me.NewAnimalsTab.BackgroundImage = CType(resources.GetObject("NewAnimalsTab.BackgroundImage"), System.Drawing.Image)
        Me.NewAnimalsTab.Controls.Add(Me.ComboBox4)
        Me.NewAnimalsTab.Controls.Add(Me.Label2)
        Me.NewAnimalsTab.Controls.Add(Me.TextBox1)
        Me.NewAnimalsTab.Controls.Add(Me.TextBox2)
        Me.NewAnimalsTab.Controls.Add(Me.ButtonAdd)
        Me.NewAnimalsTab.Controls.Add(Me.TextBox9)
        Me.NewAnimalsTab.Controls.Add(Me.Label12)
        Me.NewAnimalsTab.Controls.Add(Me.Label13)
        Me.NewAnimalsTab.Controls.Add(Me.Label14)
        Me.NewAnimalsTab.Location = New System.Drawing.Point(4, 25)
        Me.NewAnimalsTab.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NewAnimalsTab.Name = "NewAnimalsTab"
        Me.NewAnimalsTab.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NewAnimalsTab.Size = New System.Drawing.Size(519, 329)
        Me.NewAnimalsTab.TabIndex = 0
        Me.NewAnimalsTab.Text = "New Animals"
        Me.NewAnimalsTab.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(50, 189)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 24)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Status"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(129, 165)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(338, 22)
        Me.TextBox1.TabIndex = 45
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(129, 61)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(338, 22)
        Me.TextBox2.TabIndex = 44
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAdd.Location = New System.Drawing.Point(205, 273)
        Me.ButtonAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(137, 34)
        Me.ButtonAdd.TabIndex = 43
        Me.ButtonAdd.Text = "ADD NEW"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'TextBox9
        '
        Me.TextBox9.Enabled = False
        Me.TextBox9.Location = New System.Drawing.Point(129, 114)
        Me.TextBox9.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(338, 22)
        Me.TextBox9.TabIndex = 41
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(50, 139)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(146, 24)
        Me.Label12.TabIndex = 40
        Me.Label12.Text = "Species Name"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(50, 89)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(135, 24)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "Animal Name"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(50, 35)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(99, 24)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "Animal ID"
        '
        'ConditionTab
        '
        Me.ConditionTab.BackgroundImage = CType(resources.GetObject("ConditionTab.BackgroundImage"), System.Drawing.Image)
        Me.ConditionTab.Controls.Add(Me.ComboBox3)
        Me.ConditionTab.Controls.Add(Me.Label7)
        Me.ConditionTab.Controls.Add(Me.ComboBox1)
        Me.ConditionTab.Controls.Add(Me.TextBox4)
        Me.ConditionTab.Controls.Add(Me.Button1)
        Me.ConditionTab.Controls.Add(Me.Label3)
        Me.ConditionTab.Controls.Add(Me.Label4)
        Me.ConditionTab.Location = New System.Drawing.Point(4, 25)
        Me.ConditionTab.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ConditionTab.Name = "ConditionTab"
        Me.ConditionTab.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ConditionTab.Size = New System.Drawing.Size(519, 329)
        Me.ConditionTab.TabIndex = 1
        Me.ConditionTab.Text = "Animals Condition"
        Me.ConditionTab.UseVisualStyleBackColor = True
        '
        'RelocationTab
        '
        Me.RelocationTab.BackgroundImage = CType(resources.GetObject("RelocationTab.BackgroundImage"), System.Drawing.Image)
        Me.RelocationTab.Controls.Add(Me.ComboBox2)
        Me.RelocationTab.Controls.Add(Me.Label5)
        Me.RelocationTab.Controls.Add(Me.ComboBox5)
        Me.RelocationTab.Controls.Add(Me.TextBox3)
        Me.RelocationTab.Controls.Add(Me.Button4)
        Me.RelocationTab.Controls.Add(Me.Label6)
        Me.RelocationTab.Controls.Add(Me.Label8)
        Me.RelocationTab.Location = New System.Drawing.Point(4, 25)
        Me.RelocationTab.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RelocationTab.Name = "RelocationTab"
        Me.RelocationTab.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RelocationTab.Size = New System.Drawing.Size(519, 329)
        Me.RelocationTab.TabIndex = 2
        Me.RelocationTab.Text = "Animal Relocation"
        Me.RelocationTab.UseVisualStyleBackColor = True
        '
        'AnimalDeleteTab
        '
        Me.AnimalDeleteTab.BackgroundImage = CType(resources.GetObject("AnimalDeleteTab.BackgroundImage"), System.Drawing.Image)
        Me.AnimalDeleteTab.Controls.Add(Me.TextBox6)
        Me.AnimalDeleteTab.Controls.Add(Me.ComboBox6)
        Me.AnimalDeleteTab.Controls.Add(Me.Label9)
        Me.AnimalDeleteTab.Controls.Add(Me.TextBox5)
        Me.AnimalDeleteTab.Controls.Add(Me.Button5)
        Me.AnimalDeleteTab.Controls.Add(Me.TextBox7)
        Me.AnimalDeleteTab.Controls.Add(Me.Label10)
        Me.AnimalDeleteTab.Controls.Add(Me.Label11)
        Me.AnimalDeleteTab.Controls.Add(Me.Label15)
        Me.AnimalDeleteTab.Location = New System.Drawing.Point(4, 25)
        Me.AnimalDeleteTab.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AnimalDeleteTab.Name = "AnimalDeleteTab"
        Me.AnimalDeleteTab.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AnimalDeleteTab.Size = New System.Drawing.Size(519, 329)
        Me.AnimalDeleteTab.TabIndex = 3
        Me.AnimalDeleteTab.Text = "Delete Animals"
        Me.AnimalDeleteTab.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Impact", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(11, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(531, 59)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "CARE | INSPIRE | EMPOWER"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-28, 134)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(615, 433)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'TextBox4
        '
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(130, 131)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(338, 22)
        Me.TextBox4.TabIndex = 50
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(206, 239)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 34)
        Me.Button1.TabIndex = 49
        Me.Button1.Text = "UPDATE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(51, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 24)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Status"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(51, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 24)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Animal Name"
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(129, 217)
        Me.ComboBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(338, 24)
        Me.ComboBox4.TabIndex = 47
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(130, 81)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(338, 24)
        Me.ComboBox1.TabIndex = 51
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(51, 157)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(145, 24)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Change Status"
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(130, 183)
        Me.ComboBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(338, 24)
        Me.ComboBox3.TabIndex = 53
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(130, 183)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(338, 24)
        Me.ComboBox2.TabIndex = 60
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(51, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(141, 24)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Change Place"
        '
        'ComboBox5
        '
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Location = New System.Drawing.Point(130, 81)
        Me.ComboBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(338, 24)
        Me.ComboBox5.TabIndex = 58
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(130, 131)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(338, 22)
        Me.TextBox3.TabIndex = 57
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(206, 239)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(137, 34)
        Me.Button4.TabIndex = 56
        Me.Button4.Text = "UPDATE"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(51, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 24)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "Place"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(51, 55)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(135, 24)
        Me.Label8.TabIndex = 54
        Me.Label8.Text = "Animal Name"
        '
        'ComboBox6
        '
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Location = New System.Drawing.Point(130, 56)
        Me.ComboBox6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(338, 24)
        Me.ComboBox6.TabIndex = 56
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(51, 182)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 24)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "Status"
        '
        'TextBox5
        '
        Me.TextBox5.Enabled = False
        Me.TextBox5.Location = New System.Drawing.Point(130, 158)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(338, 22)
        Me.TextBox5.TabIndex = 54
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(206, 266)
        Me.Button5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(137, 34)
        Me.Button5.TabIndex = 52
        Me.Button5.Text = "DELETE"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TextBox7
        '
        Me.TextBox7.Enabled = False
        Me.TextBox7.Location = New System.Drawing.Point(130, 107)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(338, 22)
        Me.TextBox7.TabIndex = 51
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(51, 132)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(146, 24)
        Me.Label10.TabIndex = 50
        Me.Label10.Text = "Species Name"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(51, 82)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(135, 24)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "Animal Name"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(51, 28)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(99, 24)
        Me.Label15.TabIndex = 48
        Me.Label15.Text = "Animal ID"
        '
        'TextBox6
        '
        Me.TextBox6.Enabled = False
        Me.TextBox6.Location = New System.Drawing.Point(130, 209)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(338, 22)
        Me.TextBox6.TabIndex = 57
        '
        'Animals
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(587, 547)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Animals"
        Me.Text = "Animals"
        Me.TabControl1.ResumeLayout(False)
        Me.NewAnimalsTab.ResumeLayout(False)
        Me.NewAnimalsTab.PerformLayout()
        Me.ConditionTab.ResumeLayout(False)
        Me.ConditionTab.PerformLayout()
        Me.RelocationTab.ResumeLayout(False)
        Me.RelocationTab.PerformLayout()
        Me.AnimalDeleteTab.ResumeLayout(False)
        Me.AnimalDeleteTab.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Private WithEvents TabControl1 As TabControl
    Friend WithEvents NewAnimalsTab As TabPage
    Friend WithEvents ConditionTab As TabPage
    Friend WithEvents RelocationTab As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents AnimalDeleteTab As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox3 As TextBox
End Class
