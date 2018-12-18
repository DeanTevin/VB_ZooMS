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
        Me.ConditionTab = New System.Windows.Forms.TabPage()
        Me.RelocationTab = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.AnimalDeleteTab = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
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
        Me.Button3.Location = New System.Drawing.Point(568, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(70, 71)
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
        Me.Button2.Location = New System.Drawing.Point(492, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(70, 71)
        Me.Button2.TabIndex = 9
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.NewAnimalsTab)
        Me.TabControl1.Controls.Add(Me.ConditionTab)
        Me.TabControl1.Controls.Add(Me.RelocationTab)
        Me.TabControl1.Controls.Add(Me.AnimalDeleteTab)
        Me.TabControl1.Location = New System.Drawing.Point(24, 200)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(593, 447)
        Me.TabControl1.TabIndex = 8
        '
        'NewAnimalsTab
        '
        Me.NewAnimalsTab.BackgroundImage = CType(resources.GetObject("NewAnimalsTab.BackgroundImage"), System.Drawing.Image)
        Me.NewAnimalsTab.Location = New System.Drawing.Point(4, 29)
        Me.NewAnimalsTab.Name = "NewAnimalsTab"
        Me.NewAnimalsTab.Padding = New System.Windows.Forms.Padding(3)
        Me.NewAnimalsTab.Size = New System.Drawing.Size(585, 414)
        Me.NewAnimalsTab.TabIndex = 0
        Me.NewAnimalsTab.Text = "New Animals"
        Me.NewAnimalsTab.UseVisualStyleBackColor = True
        '
        'ConditionTab
        '
        Me.ConditionTab.BackgroundImage = CType(resources.GetObject("ConditionTab.BackgroundImage"), System.Drawing.Image)
        Me.ConditionTab.Location = New System.Drawing.Point(4, 29)
        Me.ConditionTab.Name = "ConditionTab"
        Me.ConditionTab.Padding = New System.Windows.Forms.Padding(3)
        Me.ConditionTab.Size = New System.Drawing.Size(585, 414)
        Me.ConditionTab.TabIndex = 1
        Me.ConditionTab.Text = "Animals Condition"
        Me.ConditionTab.UseVisualStyleBackColor = True
        '
        'RelocationTab
        '
        Me.RelocationTab.BackgroundImage = CType(resources.GetObject("RelocationTab.BackgroundImage"), System.Drawing.Image)
        Me.RelocationTab.Location = New System.Drawing.Point(4, 29)
        Me.RelocationTab.Name = "RelocationTab"
        Me.RelocationTab.Padding = New System.Windows.Forms.Padding(3)
        Me.RelocationTab.Size = New System.Drawing.Size(585, 414)
        Me.RelocationTab.TabIndex = 2
        Me.RelocationTab.Text = "Animal Relocation"
        Me.RelocationTab.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Impact", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(626, 68)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "CARE | INSPIRE | EMPOWER"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-31, 167)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(692, 541)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'AnimalDeleteTab
        '
        Me.AnimalDeleteTab.BackgroundImage = CType(resources.GetObject("AnimalDeleteTab.BackgroundImage"), System.Drawing.Image)
        Me.AnimalDeleteTab.Location = New System.Drawing.Point(4, 29)
        Me.AnimalDeleteTab.Name = "AnimalDeleteTab"
        Me.AnimalDeleteTab.Padding = New System.Windows.Forms.Padding(3)
        Me.AnimalDeleteTab.Size = New System.Drawing.Size(585, 414)
        Me.AnimalDeleteTab.TabIndex = 3
        Me.AnimalDeleteTab.Text = "Delete Animals"
        Me.AnimalDeleteTab.UseVisualStyleBackColor = True
        '
        'Animals
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(660, 684)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Animals"
        Me.Text = "Animals"
        Me.TabControl1.ResumeLayout(False)
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
End Class
