<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class courseMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(courseMain))
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.nav_settings = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.nav_history = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.nav_profile = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.nav_home = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaSeparator1 = New Guna.UI.WinForms.GunaSeparator()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GunaPanel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaPanel2
        '
        Me.GunaPanel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GunaPanel2.Controls.Add(Me.PictureBox1)
        Me.GunaPanel2.Controls.Add(Me.nav_settings)
        Me.GunaPanel2.Controls.Add(Me.nav_history)
        Me.GunaPanel2.Controls.Add(Me.nav_profile)
        Me.GunaPanel2.Controls.Add(Me.nav_home)
        Me.GunaPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel2.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(1279, 48)
        Me.GunaPanel2.TabIndex = 17
        '
        'nav_settings
        '
        Me.nav_settings.Animated = True
        Me.nav_settings.AnimationHoverSpeed = 0.07!
        Me.nav_settings.AnimationSpeed = 0.03!
        Me.nav_settings.BaseColor = System.Drawing.Color.WhiteSmoke
        Me.nav_settings.BorderColor = System.Drawing.Color.Black
        Me.nav_settings.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton
        Me.nav_settings.Checked = True
        Me.nav_settings.CheckedBaseColor = System.Drawing.Color.WhiteSmoke
        Me.nav_settings.CheckedBorderColor = System.Drawing.Color.Black
        Me.nav_settings.CheckedForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.nav_settings.CheckedImage = Nothing
        Me.nav_settings.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.nav_settings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.nav_settings.DialogResult = System.Windows.Forms.DialogResult.None
        Me.nav_settings.FocusedColor = System.Drawing.Color.Empty
        Me.nav_settings.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.nav_settings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.nav_settings.Image = Nothing
        Me.nav_settings.ImageSize = New System.Drawing.Size(20, 20)
        Me.nav_settings.LineBottom = 4
        Me.nav_settings.LineColor = System.Drawing.Color.WhiteSmoke
        Me.nav_settings.Location = New System.Drawing.Point(80, 3)
        Me.nav_settings.Name = "nav_settings"
        Me.nav_settings.OnHoverBaseColor = System.Drawing.Color.WhiteSmoke
        Me.nav_settings.OnHoverBorderColor = System.Drawing.Color.Black
        Me.nav_settings.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.nav_settings.OnHoverImage = Nothing
        Me.nav_settings.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.nav_settings.OnPressedColor = System.Drawing.Color.Black
        Me.nav_settings.OnPressedDepth = 0
        Me.nav_settings.Size = New System.Drawing.Size(112, 45)
        Me.nav_settings.TabIndex = 3
        Me.nav_settings.Text = "Γενικά"
        Me.nav_settings.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'nav_history
        '
        Me.nav_history.Animated = True
        Me.nav_history.AnimationHoverSpeed = 0.07!
        Me.nav_history.AnimationSpeed = 0.03!
        Me.nav_history.BaseColor = System.Drawing.Color.WhiteSmoke
        Me.nav_history.BorderColor = System.Drawing.Color.Black
        Me.nav_history.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton
        Me.nav_history.CheckedBaseColor = System.Drawing.Color.WhiteSmoke
        Me.nav_history.CheckedBorderColor = System.Drawing.Color.Black
        Me.nav_history.CheckedForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.nav_history.CheckedImage = Nothing
        Me.nav_history.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.nav_history.Cursor = System.Windows.Forms.Cursors.Hand
        Me.nav_history.DialogResult = System.Windows.Forms.DialogResult.None
        Me.nav_history.FocusedColor = System.Drawing.Color.Empty
        Me.nav_history.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.nav_history.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.nav_history.Image = Nothing
        Me.nav_history.ImageSize = New System.Drawing.Size(20, 20)
        Me.nav_history.LineBottom = 4
        Me.nav_history.LineColor = System.Drawing.Color.WhiteSmoke
        Me.nav_history.Location = New System.Drawing.Point(330, 3)
        Me.nav_history.Name = "nav_history"
        Me.nav_history.OnHoverBaseColor = System.Drawing.Color.WhiteSmoke
        Me.nav_history.OnHoverBorderColor = System.Drawing.Color.Black
        Me.nav_history.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.nav_history.OnHoverImage = Nothing
        Me.nav_history.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.nav_history.OnPressedColor = System.Drawing.Color.Black
        Me.nav_history.OnPressedDepth = 0
        Me.nav_history.Size = New System.Drawing.Size(112, 45)
        Me.nav_history.TabIndex = 2
        Me.nav_history.Text = "Εργασίες"
        Me.nav_history.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'nav_profile
        '
        Me.nav_profile.Animated = True
        Me.nav_profile.AnimationHoverSpeed = 0.07!
        Me.nav_profile.AnimationSpeed = 0.03!
        Me.nav_profile.BaseColor = System.Drawing.Color.WhiteSmoke
        Me.nav_profile.BorderColor = System.Drawing.Color.Black
        Me.nav_profile.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton
        Me.nav_profile.CheckedBaseColor = System.Drawing.Color.WhiteSmoke
        Me.nav_profile.CheckedBorderColor = System.Drawing.Color.Black
        Me.nav_profile.CheckedForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.nav_profile.CheckedImage = Nothing
        Me.nav_profile.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.nav_profile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.nav_profile.DialogResult = System.Windows.Forms.DialogResult.None
        Me.nav_profile.FocusedColor = System.Drawing.Color.Empty
        Me.nav_profile.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.nav_profile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.nav_profile.Image = Nothing
        Me.nav_profile.ImageSize = New System.Drawing.Size(20, 20)
        Me.nav_profile.LineBottom = 4
        Me.nav_profile.LineColor = System.Drawing.Color.WhiteSmoke
        Me.nav_profile.Location = New System.Drawing.Point(448, 3)
        Me.nav_profile.Name = "nav_profile"
        Me.nav_profile.OnHoverBaseColor = System.Drawing.Color.WhiteSmoke
        Me.nav_profile.OnHoverBorderColor = System.Drawing.Color.Black
        Me.nav_profile.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.nav_profile.OnHoverImage = Nothing
        Me.nav_profile.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.nav_profile.OnPressedColor = System.Drawing.Color.Black
        Me.nav_profile.OnPressedDepth = 0
        Me.nav_profile.Size = New System.Drawing.Size(112, 45)
        Me.nav_profile.TabIndex = 1
        Me.nav_profile.Text = "MyFiles"
        Me.nav_profile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'nav_home
        '
        Me.nav_home.Animated = True
        Me.nav_home.AnimationHoverSpeed = 0.07!
        Me.nav_home.AnimationSpeed = 0.03!
        Me.nav_home.BaseColor = System.Drawing.Color.WhiteSmoke
        Me.nav_home.BorderColor = System.Drawing.Color.Black
        Me.nav_home.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton
        Me.nav_home.CheckedBaseColor = System.Drawing.Color.WhiteSmoke
        Me.nav_home.CheckedBorderColor = System.Drawing.Color.Black
        Me.nav_home.CheckedForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.nav_home.CheckedImage = Nothing
        Me.nav_home.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.nav_home.Cursor = System.Windows.Forms.Cursors.Hand
        Me.nav_home.DialogResult = System.Windows.Forms.DialogResult.None
        Me.nav_home.FocusedColor = System.Drawing.Color.Empty
        Me.nav_home.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.nav_home.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.nav_home.Image = Nothing
        Me.nav_home.ImageSize = New System.Drawing.Size(20, 20)
        Me.nav_home.LineBottom = 4
        Me.nav_home.LineColor = System.Drawing.Color.WhiteSmoke
        Me.nav_home.Location = New System.Drawing.Point(198, 3)
        Me.nav_home.Name = "nav_home"
        Me.nav_home.OnHoverBaseColor = System.Drawing.Color.WhiteSmoke
        Me.nav_home.OnHoverBorderColor = System.Drawing.Color.Black
        Me.nav_home.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.nav_home.OnHoverImage = Nothing
        Me.nav_home.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.nav_home.OnPressedColor = System.Drawing.Color.Black
        Me.nav_home.OnPressedDepth = 0
        Me.nav_home.Size = New System.Drawing.Size(126, 45)
        Me.nav_home.TabIndex = 0
        Me.nav_home.Text = "Υλικό"
        Me.nav_home.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaSeparator1
        '
        Me.GunaSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.GunaSeparator1.Location = New System.Drawing.Point(0, 54)
        Me.GunaSeparator1.Name = "GunaSeparator1"
        Me.GunaSeparator1.Size = New System.Drawing.Size(1287, 10)
        Me.GunaSeparator1.TabIndex = 68
        '
        'GunaPanel1
        '
        Me.GunaPanel1.Location = New System.Drawing.Point(3, 70)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(1264, 640)
        Me.GunaPanel1.TabIndex = 69
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(4, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(43, 39)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'courseMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1279, 722)
        Me.Controls.Add(Me.GunaPanel1)
        Me.Controls.Add(Me.GunaSeparator1)
        Me.Controls.Add(Me.GunaPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "courseMain"
        Me.Text = "courseMain"
        Me.GunaPanel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents nav_settings As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents nav_history As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents nav_profile As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents nav_home As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GunaSeparator1 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
End Class
