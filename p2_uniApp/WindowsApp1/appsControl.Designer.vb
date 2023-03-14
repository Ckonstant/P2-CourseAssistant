<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class appsControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(appsControl))
        Me.GunaShadowPanel2 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.GunaAdvenceTileButton1 = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.GunaShadowPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaShadowPanel2
        '
        Me.GunaShadowPanel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel2.BaseColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel2.Controls.Add(Me.GunaAdvenceTileButton1)
        Me.GunaShadowPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaShadowPanel2.Location = New System.Drawing.Point(0, 0)
        Me.GunaShadowPanel2.Name = "GunaShadowPanel2"
        Me.GunaShadowPanel2.ShadowColor = System.Drawing.Color.Black
        Me.GunaShadowPanel2.ShadowShift = 1
        Me.GunaShadowPanel2.ShadowStyle = Guna.UI.WinForms.ShadowMode.ForwardDiagonal
        Me.GunaShadowPanel2.Size = New System.Drawing.Size(271, 210)
        Me.GunaShadowPanel2.TabIndex = 42
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
        'appsControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GunaShadowPanel2)
        Me.Name = "appsControl"
        Me.Size = New System.Drawing.Size(271, 210)
        Me.GunaShadowPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaShadowPanel2 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents GunaAdvenceTileButton1 As Guna.UI.WinForms.GunaAdvenceTileButton
End Class
