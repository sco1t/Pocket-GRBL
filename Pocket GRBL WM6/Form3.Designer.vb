<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Private mainMenu1 As System.Windows.Forms.MainMenu

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.mainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.ComboBox4 = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.Button10 = New System.Windows.Forms.Button
        Me.Button11 = New System.Windows.Forms.Button
        Me.Button12 = New System.Windows.Forms.Button
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.Add(Me.MenuItem2)
        Me.mainMenu1.MenuItems.Add(Me.MenuItem1)
        '
        'MenuItem2
        '
        Me.MenuItem2.Text = "Settings"
        '
        'MenuItem1
        '
        Me.MenuItem1.Text = "Back"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(86, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 26)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "+Y"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(86, 64)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(68, 26)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "-Y"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 15)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(68, 26)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "-X"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(160, 15)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(68, 26)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "+X"
        '
        'ComboBox3
        '
        Me.ComboBox3.Items.Add("0.1")
        Me.ComboBox3.Items.Add("1")
        Me.ComboBox3.Items.Add("5")
        Me.ComboBox3.Items.Add("10")
        Me.ComboBox3.Items.Add("25")
        Me.ComboBox3.Items.Add("100")
        Me.ComboBox3.Location = New System.Drawing.Point(12, 232)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(98, 22)
        Me.ComboBox3.TabIndex = 4
        '
        'ComboBox4
        '
        Me.ComboBox4.Items.Add("50")
        Me.ComboBox4.Items.Add("100")
        Me.ComboBox4.Items.Add("500")
        Me.ComboBox4.Items.Add("1000")
        Me.ComboBox4.Location = New System.Drawing.Point(124, 232)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(103, 22)
        Me.ComboBox4.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(124, 211)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 18)
        Me.Label1.Text = "Feed Rate"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 212)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 17)
        Me.Label2.Text = "Steps"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(12, 64)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(68, 26)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "-Z"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(159, 64)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(68, 26)
        Me.Button6.TabIndex = 9
        Me.Button6.Text = "+Z"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(12, 109)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(68, 26)
        Me.Button7.TabIndex = 10
        Me.Button7.Text = "M off"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(159, 153)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(68, 26)
        Me.Button8.TabIndex = 11
        Me.Button8.Text = "Zero Z"
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(159, 109)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(68, 26)
        Me.Button9.TabIndex = 12
        Me.Button9.Text = "M on"
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(86, 153)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(68, 26)
        Me.Button10.TabIndex = 15
        Me.Button10.Text = "Goto Zero"
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(12, 153)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(68, 26)
        Me.Button11.TabIndex = 16
        Me.Button11.Text = "Zero XY"
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(86, 109)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(68, 26)
        Me.Button12.TabIndex = 17
        Me.Button12.Text = "Unlock"
        '
        'CheckBox1
        '
        Me.CheckBox1.Location = New System.Drawing.Point(12, 189)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(100, 20)
        Me.CheckBox1.TabIndex = 20
        Me.CheckBox1.Text = "Ignore G53"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Menu = Me.mainMenu1
        Me.Name = "Form3"
        Me.Text = "Jog"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
End Class
