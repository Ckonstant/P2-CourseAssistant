<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class courseControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(courseControl))
        Me.GunaContextMenuStrip1 = New Guna.UI.WinForms.GunaContextMenuStrip()
        Me.HideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GunaShadowPanel2 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.courseName = New System.Windows.Forms.Label()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaProgressBar1 = New Guna.UI.WinForms.GunaProgressBar()
        Me.GunaAdvenceTileButton1 = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GunaCircleButton2 = New Guna.UI.WinForms.GunaCircleButton()
        Me.GunaContextMenuStrip1.SuspendLayout()
        Me.GunaShadowPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaContextMenuStrip1
        '
        Me.GunaContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HideToolStripMenuItem, Me.ShowToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.RemoveToolStripMenuItem})
        Me.GunaContextMenuStrip1.Name = "GunaContextMenuStrip1"
        Me.GunaContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaContextMenuStrip1.RenderStyle.ColorTable = Nothing
        Me.GunaContextMenuStrip1.RenderStyle.RoundedEdges = True
        Me.GunaContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.GunaContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.GunaContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.GunaContextMenuStrip1.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault
        Me.GunaContextMenuStrip1.Size = New System.Drawing.Size(118, 92)
        '
        'HideToolStripMenuItem
        '
        Me.HideToolStripMenuItem.Name = "HideToolStripMenuItem"
        Me.HideToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.HideToolStripMenuItem.Text = "Hide"
        '
        'ShowToolStripMenuItem
        '
        Me.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem"
        Me.ShowToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.ShowToolStripMenuItem.Text = "Show"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'RemoveToolStripMenuItem
        '
        Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        Me.RemoveToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.RemoveToolStripMenuItem.Text = "Remove"
        '
        'GunaShadowPanel2
        '
        Me.GunaShadowPanel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel2.BaseColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel2.Controls.Add(Me.courseName)
        Me.GunaShadowPanel2.Controls.Add(Me.GunaLabel1)
        Me.GunaShadowPanel2.Controls.Add(Me.GunaLabel5)
        Me.GunaShadowPanel2.Controls.Add(Me.GunaLabel4)
        Me.GunaShadowPanel2.Controls.Add(Me.GunaLabel3)
        Me.GunaShadowPanel2.Controls.Add(Me.GunaLabel2)
        Me.GunaShadowPanel2.Controls.Add(Me.GunaProgressBar1)
        Me.GunaShadowPanel2.Controls.Add(Me.GunaAdvenceTileButton1)
        Me.GunaShadowPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaShadowPanel2.Location = New System.Drawing.Point(0, 0)
        Me.GunaShadowPanel2.Name = "GunaShadowPanel2"
        Me.GunaShadowPanel2.ShadowColor = System.Drawing.Color.Black
        Me.GunaShadowPanel2.ShadowShift = 1
        Me.GunaShadowPanel2.ShadowStyle = Guna.UI.WinForms.ShadowMode.ForwardDiagonal
        Me.GunaShadowPanel2.Size = New System.Drawing.Size(269, 210)
        Me.GunaShadowPanel2.TabIndex = 41
        '
        'courseName
        '
        Me.courseName.AutoSize = True
        Me.courseName.Location = New System.Drawing.Point(75, 47)
        Me.courseName.Name = "courseName"
        Me.courseName.Size = New System.Drawing.Size(39, 13)
        Me.courseName.TabIndex = 151
        Me.courseName.Text = "Label1"
        Me.courseName.Visible = False
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel1.Location = New System.Drawing.Point(31, 58)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(13, 15)
        Me.GunaLabel1.TabIndex = 146
        Me.GunaLabel1.Text = "1"
        Me.GunaLabel1.Visible = False
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel5.Location = New System.Drawing.Point(228, 176)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(13, 15)
        Me.GunaLabel5.TabIndex = 150
        Me.GunaLabel5.Text = "5"
        Me.GunaLabel5.Visible = False
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel4.Location = New System.Drawing.Point(156, 176)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(13, 15)
        Me.GunaLabel4.TabIndex = 149
        Me.GunaLabel4.Text = "4"
        Me.GunaLabel4.Visible = False
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel3.Location = New System.Drawing.Point(66, 176)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(13, 15)
        Me.GunaLabel3.TabIndex = 148
        Me.GunaLabel3.Text = "3"
        Me.GunaLabel3.Visible = False
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel2.Location = New System.Drawing.Point(31, 178)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(13, 15)
        Me.GunaLabel2.TabIndex = 147
        Me.GunaLabel2.Text = "2"
        Me.GunaLabel2.Visible = False
        '
        'GunaProgressBar1
        '
        Me.GunaProgressBar1.BorderColor = System.Drawing.Color.Black
        Me.GunaProgressBar1.ColorStyle = Guna.UI.WinForms.ColorStyle.[Default]
        Me.GunaProgressBar1.IdleColor = System.Drawing.Color.Gainsboro
        Me.GunaProgressBar1.Location = New System.Drawing.Point(13, 196)
        Me.GunaProgressBar1.Name = "GunaProgressBar1"
        Me.GunaProgressBar1.ProgressMaxColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.GunaProgressBar1.ProgressMinColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.GunaProgressBar1.Size = New System.Drawing.Size(245, 5)
        Me.GunaProgressBar1.TabIndex = 101
        Me.GunaProgressBar1.Visible = False
        '
        'GunaAdvenceTileButton1
        '
        Me.GunaAdvenceTileButton1.AllowDrop = True
        Me.GunaAdvenceTileButton1.Animated = True
        Me.GunaAdvenceTileButton1.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceTileButton1.AnimationSpeed = 0.03!
        Me.GunaAdvenceTileButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceTileButton1.BaseColor = System.Drawing.Color.White
        Me.GunaAdvenceTileButton1.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaAdvenceTileButton1.BorderSize = 1
        Me.GunaAdvenceTileButton1.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.GunaAdvenceTileButton1.CheckedBorderColor = System.Drawing.Color.White
        Me.GunaAdvenceTileButton1.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceTileButton1.CheckedImage = CType(resources.GetObject("GunaAdvenceTileButton1.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceTileButton1.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceTileButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaAdvenceTileButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceTileButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceTileButton1.Font = New System.Drawing.Font("Segoe UI Light", 15.75!)
        Me.GunaAdvenceTileButton1.ForeColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton1.Image = CType(resources.GetObject("GunaAdvenceTileButton1.Image"), System.Drawing.Image)
        Me.GunaAdvenceTileButton1.ImageSize = New System.Drawing.Size(52, 52)
        Me.GunaAdvenceTileButton1.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceTileButton1.Location = New System.Drawing.Point(3, 4)
        Me.GunaAdvenceTileButton1.Name = "GunaAdvenceTileButton1"
        Me.GunaAdvenceTileButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.GunaAdvenceTileButton1.OnHoverBorderColor = System.Drawing.Color.LightGray
        Me.GunaAdvenceTileButton1.OnHoverForeColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton1.OnHoverImage = Nothing
        Me.GunaAdvenceTileButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceTileButton1.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.GunaAdvenceTileButton1.Radius = 2
        Me.GunaAdvenceTileButton1.Size = New System.Drawing.Size(264, 202)
        Me.GunaAdvenceTileButton1.TabIndex = 2
        Me.GunaAdvenceTileButton1.Text = "Σχεδιαση και Αναλυση αλγοριθμων"
        '
        'Timer1
        '
        '
        'GunaCircleButton2
        '
        Me.GunaCircleButton2.Animated = True
        Me.GunaCircleButton2.AnimationHoverSpeed = 0.07!
        Me.GunaCircleButton2.AnimationSpeed = 0.03!
        Me.GunaCircleButton2.BackColor = System.Drawing.Color.White
        Me.GunaCircleButton2.BaseColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton2.BorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton2.ContextMenuStrip = Me.GunaContextMenuStrip1
        Me.GunaCircleButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaCircleButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaCircleButton2.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GunaCircleButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaCircleButton2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.GunaCircleButton2.Image = CType(resources.GetObject("GunaCircleButton2.Image"), System.Drawing.Image)
        Me.GunaCircleButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaCircleButton2.Location = New System.Drawing.Point(231, 19)
        Me.GunaCircleButton2.Name = "GunaCircleButton2"
        Me.GunaCircleButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.GunaCircleButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaCircleButton2.OnHoverImage = CType(resources.GetObject("GunaCircleButton2.OnHoverImage"), System.Drawing.Image)
        Me.GunaCircleButton2.OnPressedColor = System.Drawing.Color.Silver
        Me.GunaCircleButton2.Size = New System.Drawing.Size(27, 24)
        Me.GunaCircleButton2.TabIndex = 7
        Me.GunaCircleButton2.Visible = False
        '
        'courseControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Controls.Add(Me.GunaCircleButton2)
        Me.Controls.Add(Me.GunaShadowPanel2)
        Me.Margin = New System.Windows.Forms.Padding(10)
        Me.Name = "courseControl"
        Me.Size = New System.Drawing.Size(269, 210)
        Me.GunaContextMenuStrip1.ResumeLayout(False)
        Me.GunaShadowPanel2.ResumeLayout(False)
        Me.GunaShadowPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GunaCircleButton2 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents GunaContextMenuStrip1 As Guna.UI.WinForms.GunaContextMenuStrip
    Friend WithEvents HideToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GunaShadowPanel2 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents GunaAdvenceTileButton1 As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents GunaProgressBar1 As Guna.UI.WinForms.GunaProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents courseName As Label
End Class
