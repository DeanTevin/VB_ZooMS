<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Place
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Place))
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.NewPlaceTab = New System.Windows.Forms.TabPage()
        Me.EditPlaceTab = New System.Windows.Forms.TabPage()
        Me.DeletePlaceTab = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
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
        Me.Button3.Location = New System.Drawing.Point(556, 0)
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
        Me.Button2.Location = New System.Drawing.Point(480, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(70, 71)
        Me.Button2.TabIndex = 9
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.NewPlaceTab)
        Me.TabControl1.Controls.Add(Me.EditPlaceTab)
        Me.TabControl1.Controls.Add(Me.DeletePlaceTab)
        Me.TabControl1.Location = New System.Drawing.Point(12, 197)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(593, 447)
        Me.TabControl1.TabIndex = 8
        '
        'NewPlaceTab
        '
        Me.NewPlaceTab.BackgroundImage = CType(resources.GetObject("NewPlaceTab.BackgroundImage"), System.Drawing.Image)
        Me.NewPlaceTab.Location = New System.Drawing.Point(4, 29)
        Me.NewPlaceTab.Name = "NewPlaceTab"
        Me.NewPlaceTab.Padding = New System.Windows.Forms.Padding(3)
        Me.NewPlaceTab.Size = New System.Drawing.Size(585, 414)
        Me.NewPlaceTab.TabIndex = 0
        Me.NewPlaceTab.Text = "New Place"
        Me.NewPlaceTab.UseVisualStyleBackColor = True
        '
        'EditPlaceTab
        '
        Me.EditPlaceTab.BackgroundImage = CType(resources.GetObject("EditPlaceTab.BackgroundImage"), System.Drawing.Image)
        Me.EditPlaceTab.Location = New System.Drawing.Point(4, 29)
        Me.EditPlaceTab.Name = "EditPlaceTab"
        Me.EditPlaceTab.Padding = New System.Windows.Forms.Padding(3)
        Me.EditPlaceTab.Size = New System.Drawing.Size(585, 414)
        Me.EditPlaceTab.TabIndex = 1
        Me.EditPlaceTab.Text = "Edit Place"
        Me.EditPlaceTab.UseVisualStyleBackColor = True
        '
        'DeletePlaceTab
        '
        Me.DeletePlaceTab.BackgroundImage = CType(resources.GetObject("DeletePlaceTab.BackgroundImage"), System.Drawing.Image)
        Me.DeletePlaceTab.Location = New System.Drawing.Point(4, 29)
        Me.DeletePlaceTab.Name = "DeletePlaceTab"
        Me.DeletePlaceTab.Padding = New System.Windows.Forms.Padding(3)
        Me.DeletePlaceTab.Size = New System.Drawing.Size(585, 414)
        Me.DeletePlaceTab.TabIndex = 2
        Me.DeletePlaceTab.Text = "Delete Place"
        Me.DeletePlaceTab.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Impact", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 111)
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
        Me.PictureBox1.Location = New System.Drawing.Point(-43, 164)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(692, 541)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'PlaceManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(640, 693)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "PlaceManagement"
        Me.Text = "PlaceManagement"
        Me.TabControl1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Private WithEvents TabControl1 As TabControl
    Friend WithEvents NewPlaceTab As TabPage
    Friend WithEvents EditPlaceTab As TabPage
    Friend WithEvents DeletePlaceTab As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
