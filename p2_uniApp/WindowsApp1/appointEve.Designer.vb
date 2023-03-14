<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class appointEve
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
        Me.assignedTo = New System.Windows.Forms.CheckBox()
        Me.cancel = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.ok = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.label7 = New System.Windows.Forms.Label()
        Me.comboBox1 = New System.Windows.Forms.ComboBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.EndTimeDateTimePickerAdv = New Syncfusion.Windows.Forms.Tools.DateTimePickerAdv()
        Me.StartTimeDateTimePickerAdv = New Syncfusion.Windows.Forms.Tools.DateTimePickerAdv()
        Me.EndDateDateTimePickerAdv = New Syncfusion.Windows.Forms.Tools.DateTimePickerAdv()
        Me.StartDateDateTimePickerAdv = New Syncfusion.Windows.Forms.Tools.DateTimePickerAdv()
        Me.SubjectTextBoxExt = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        CType(Me.EndTimeDateTimePickerAdv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EndTimeDateTimePickerAdv.Calendar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StartTimeDateTimePickerAdv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StartTimeDateTimePickerAdv.Calendar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EndDateDateTimePickerAdv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EndDateDateTimePickerAdv.Calendar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StartDateDateTimePickerAdv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StartDateDateTimePickerAdv.Calendar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubjectTextBoxExt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'assignedTo
        '
        Me.assignedTo.AutoSize = True
        Me.assignedTo.Location = New System.Drawing.Point(97, 129)
        Me.assignedTo.Name = "assignedTo"
        Me.assignedTo.Size = New System.Drawing.Size(85, 17)
        Me.assignedTo.TabIndex = 31
        Me.assignedTo.Text = "Assigned To"
        Me.assignedTo.UseVisualStyleBackColor = True
        '
        'cancel
        '
        Me.cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cancel.IsBackStageButton = True
        Me.cancel.Location = New System.Drawing.Point(395, 203)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(75, 23)
        Me.cancel.TabIndex = 30
        Me.cancel.Text = "Cancel"
        '
        'ok
        '
        Me.ok.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ok.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ok.IsBackStageButton = True
        Me.ok.Location = New System.Drawing.Point(293, 203)
        Me.ok.Name = "ok"
        Me.ok.Size = New System.Drawing.Size(75, 23)
        Me.ok.TabIndex = 29
        Me.ok.Text = "Ok"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(293, 133)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(33, 13)
        Me.label7.TabIndex = 28
        Me.label7.Text = "Label"
        '
        'comboBox1
        '
        Me.comboBox1.FormattingEnabled = True
        Me.comboBox1.Location = New System.Drawing.Point(351, 126)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(121, 21)
        Me.comboBox1.TabIndex = 27
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(94, 163)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(29, 13)
        Me.label6.TabIndex = 26
        Me.label6.Text = "hello"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(290, 92)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(52, 13)
        Me.label4.TabIndex = 25
        Me.label4.Text = "End Time"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(290, 48)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(55, 13)
        Me.label5.TabIndex = 24
        Me.label5.Text = "Start Time"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(94, 95)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(52, 13)
        Me.label3.TabIndex = 23
        Me.label3.Text = "End Date"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(94, 48)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(55, 13)
        Me.label2.TabIndex = 22
        Me.label2.Text = "Start Date"
        '
        'EndTimeDateTimePickerAdv
        '
        Me.EndTimeDateTimePickerAdv.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.EndTimeDateTimePickerAdv.BorderColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.EndTimeDateTimePickerAdv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.EndTimeDateTimePickerAdv.Calendar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.EndTimeDateTimePickerAdv.Calendar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EndTimeDateTimePickerAdv.Calendar.Culture = New System.Globalization.CultureInfo("en-US")
        Me.EndTimeDateTimePickerAdv.Calendar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.EndTimeDateTimePickerAdv.Calendar.GridLines = Syncfusion.Windows.Forms.Grid.GridBorderStyle.None
        Me.EndTimeDateTimePickerAdv.Calendar.HeaderEndColor = System.Drawing.Color.White
        Me.EndTimeDateTimePickerAdv.Calendar.HeaderStartColor = System.Drawing.Color.White
        Me.EndTimeDateTimePickerAdv.Calendar.HighlightColor = System.Drawing.Color.Black
        Me.EndTimeDateTimePickerAdv.Calendar.Iso8601CalenderFormat = False
        Me.EndTimeDateTimePickerAdv.Calendar.Location = New System.Drawing.Point(0, 0)
        Me.EndTimeDateTimePickerAdv.Calendar.MetroColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.EndTimeDateTimePickerAdv.Calendar.Name = "monthCalendar"
        Me.EndTimeDateTimePickerAdv.Calendar.ScrollButtonSize = New System.Drawing.Size(24, 24)
        Me.EndTimeDateTimePickerAdv.Calendar.Style = Syncfusion.Windows.Forms.VisualStyle.Metro
        Me.EndTimeDateTimePickerAdv.Calendar.TabIndex = 0
        Me.EndTimeDateTimePickerAdv.Calendar.WeekFont = New System.Drawing.Font("Verdana", 8.0!)
        '
        '
        '
        Me.EndTimeDateTimePickerAdv.Calendar.NoneButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.EndTimeDateTimePickerAdv.Calendar.NoneButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.EndTimeDateTimePickerAdv.Calendar.NoneButton.ForeColor = System.Drawing.Color.White
        Me.EndTimeDateTimePickerAdv.Calendar.NoneButton.Location = New System.Drawing.Point(78, 0)
        Me.EndTimeDateTimePickerAdv.Calendar.NoneButton.Size = New System.Drawing.Size(72, 20)
        Me.EndTimeDateTimePickerAdv.Calendar.NoneButton.ThemeName = "Metro"
        Me.EndTimeDateTimePickerAdv.Calendar.NoneButton.UseVisualStyle = True
        Me.EndTimeDateTimePickerAdv.Calendar.NoneButton.Visible = False
        '
        '
        '
        Me.EndTimeDateTimePickerAdv.Calendar.TodayButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.EndTimeDateTimePickerAdv.Calendar.TodayButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.EndTimeDateTimePickerAdv.Calendar.TodayButton.ForeColor = System.Drawing.Color.White
        Me.EndTimeDateTimePickerAdv.Calendar.TodayButton.Location = New System.Drawing.Point(0, 0)
        Me.EndTimeDateTimePickerAdv.Calendar.TodayButton.Size = New System.Drawing.Size(150, 20)
        Me.EndTimeDateTimePickerAdv.Calendar.TodayButton.ThemeName = "Metro"
        Me.EndTimeDateTimePickerAdv.Calendar.TodayButton.UseVisualStyle = True
        Me.EndTimeDateTimePickerAdv.CalendarSize = New System.Drawing.Size(189, 176)
        Me.EndTimeDateTimePickerAdv.Checked = False
        Me.EndTimeDateTimePickerAdv.DropDownImage = Nothing
        Me.EndTimeDateTimePickerAdv.DropDownNormalColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.EndTimeDateTimePickerAdv.DropDownPressedColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.EndTimeDateTimePickerAdv.DropDownSelectedColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.EndTimeDateTimePickerAdv.EnableNullDate = False
        Me.EndTimeDateTimePickerAdv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndTimeDateTimePickerAdv.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.EndTimeDateTimePickerAdv.Location = New System.Drawing.Point(351, 89)
        Me.EndTimeDateTimePickerAdv.MetroColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.EndTimeDateTimePickerAdv.MinValue = New Date(CType(0, Long))
        Me.EndTimeDateTimePickerAdv.Name = "EndTimeDateTimePickerAdv"
        Me.EndTimeDateTimePickerAdv.ShowCheckBox = False
        Me.EndTimeDateTimePickerAdv.ShowDropButton = False
        Me.EndTimeDateTimePickerAdv.ShowUpDown = True
        Me.EndTimeDateTimePickerAdv.Size = New System.Drawing.Size(121, 20)
        Me.EndTimeDateTimePickerAdv.Style = Syncfusion.Windows.Forms.VisualStyle.Metro
        Me.EndTimeDateTimePickerAdv.TabIndex = 21
        Me.EndTimeDateTimePickerAdv.ThemesEnabled = True
        Me.EndTimeDateTimePickerAdv.Value = New Date(2016, 9, 8, 15, 50, 34, 52)
        '
        'StartTimeDateTimePickerAdv
        '
        Me.StartTimeDateTimePickerAdv.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.StartTimeDateTimePickerAdv.BorderColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.StartTimeDateTimePickerAdv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.StartTimeDateTimePickerAdv.Calendar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.StartTimeDateTimePickerAdv.Calendar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StartTimeDateTimePickerAdv.Calendar.Culture = New System.Globalization.CultureInfo("en-US")
        Me.StartTimeDateTimePickerAdv.Calendar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.StartTimeDateTimePickerAdv.Calendar.GridLines = Syncfusion.Windows.Forms.Grid.GridBorderStyle.None
        Me.StartTimeDateTimePickerAdv.Calendar.HeaderEndColor = System.Drawing.Color.White
        Me.StartTimeDateTimePickerAdv.Calendar.HeaderStartColor = System.Drawing.Color.White
        Me.StartTimeDateTimePickerAdv.Calendar.HighlightColor = System.Drawing.Color.Black
        Me.StartTimeDateTimePickerAdv.Calendar.Iso8601CalenderFormat = False
        Me.StartTimeDateTimePickerAdv.Calendar.Location = New System.Drawing.Point(0, 0)
        Me.StartTimeDateTimePickerAdv.Calendar.MetroColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.StartTimeDateTimePickerAdv.Calendar.Name = "monthCalendar"
        Me.StartTimeDateTimePickerAdv.Calendar.ScrollButtonSize = New System.Drawing.Size(24, 24)
        Me.StartTimeDateTimePickerAdv.Calendar.Style = Syncfusion.Windows.Forms.VisualStyle.Metro
        Me.StartTimeDateTimePickerAdv.Calendar.TabIndex = 0
        Me.StartTimeDateTimePickerAdv.Calendar.WeekFont = New System.Drawing.Font("Verdana", 8.0!)
        '
        '
        '
        Me.StartTimeDateTimePickerAdv.Calendar.NoneButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.StartTimeDateTimePickerAdv.Calendar.NoneButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.StartTimeDateTimePickerAdv.Calendar.NoneButton.ForeColor = System.Drawing.Color.White
        Me.StartTimeDateTimePickerAdv.Calendar.NoneButton.Location = New System.Drawing.Point(78, 0)
        Me.StartTimeDateTimePickerAdv.Calendar.NoneButton.Size = New System.Drawing.Size(72, 20)
        Me.StartTimeDateTimePickerAdv.Calendar.NoneButton.ThemeName = "Metro"
        Me.StartTimeDateTimePickerAdv.Calendar.NoneButton.UseVisualStyle = True
        Me.StartTimeDateTimePickerAdv.Calendar.NoneButton.Visible = False
        '
        '
        '
        Me.StartTimeDateTimePickerAdv.Calendar.TodayButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.StartTimeDateTimePickerAdv.Calendar.TodayButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.StartTimeDateTimePickerAdv.Calendar.TodayButton.ForeColor = System.Drawing.Color.White
        Me.StartTimeDateTimePickerAdv.Calendar.TodayButton.Location = New System.Drawing.Point(0, 0)
        Me.StartTimeDateTimePickerAdv.Calendar.TodayButton.Size = New System.Drawing.Size(150, 20)
        Me.StartTimeDateTimePickerAdv.Calendar.TodayButton.ThemeName = "Metro"
        Me.StartTimeDateTimePickerAdv.Calendar.TodayButton.UseVisualStyle = True
        Me.StartTimeDateTimePickerAdv.CalendarSize = New System.Drawing.Size(189, 176)
        Me.StartTimeDateTimePickerAdv.Checked = False
        Me.StartTimeDateTimePickerAdv.DropDownImage = Nothing
        Me.StartTimeDateTimePickerAdv.DropDownNormalColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.StartTimeDateTimePickerAdv.DropDownPressedColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.StartTimeDateTimePickerAdv.DropDownSelectedColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.StartTimeDateTimePickerAdv.EnableNullDate = False
        Me.StartTimeDateTimePickerAdv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartTimeDateTimePickerAdv.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.StartTimeDateTimePickerAdv.Location = New System.Drawing.Point(351, 45)
        Me.StartTimeDateTimePickerAdv.MetroColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.StartTimeDateTimePickerAdv.MinValue = New Date(CType(0, Long))
        Me.StartTimeDateTimePickerAdv.Name = "StartTimeDateTimePickerAdv"
        Me.StartTimeDateTimePickerAdv.ShowCheckBox = False
        Me.StartTimeDateTimePickerAdv.ShowDropButton = False
        Me.StartTimeDateTimePickerAdv.ShowUpDown = True
        Me.StartTimeDateTimePickerAdv.Size = New System.Drawing.Size(121, 20)
        Me.StartTimeDateTimePickerAdv.Style = Syncfusion.Windows.Forms.VisualStyle.Metro
        Me.StartTimeDateTimePickerAdv.TabIndex = 20
        Me.StartTimeDateTimePickerAdv.ThemesEnabled = True
        Me.StartTimeDateTimePickerAdv.Value = New Date(2016, 9, 8, 15, 50, 34, 16)
        '
        'EndDateDateTimePickerAdv
        '
        Me.EndDateDateTimePickerAdv.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.EndDateDateTimePickerAdv.BorderColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.EndDateDateTimePickerAdv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.EndDateDateTimePickerAdv.Calendar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.EndDateDateTimePickerAdv.Calendar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EndDateDateTimePickerAdv.Calendar.Culture = New System.Globalization.CultureInfo("en-US")
        Me.EndDateDateTimePickerAdv.Calendar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.EndDateDateTimePickerAdv.Calendar.GridLines = Syncfusion.Windows.Forms.Grid.GridBorderStyle.None
        Me.EndDateDateTimePickerAdv.Calendar.HeaderEndColor = System.Drawing.Color.White
        Me.EndDateDateTimePickerAdv.Calendar.HeaderStartColor = System.Drawing.Color.White
        Me.EndDateDateTimePickerAdv.Calendar.HighlightColor = System.Drawing.Color.Black
        Me.EndDateDateTimePickerAdv.Calendar.Iso8601CalenderFormat = False
        Me.EndDateDateTimePickerAdv.Calendar.Location = New System.Drawing.Point(0, 0)
        Me.EndDateDateTimePickerAdv.Calendar.MetroColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.EndDateDateTimePickerAdv.Calendar.Name = "monthCalendar"
        Me.EndDateDateTimePickerAdv.Calendar.ScrollButtonSize = New System.Drawing.Size(24, 24)
        Me.EndDateDateTimePickerAdv.Calendar.Style = Syncfusion.Windows.Forms.VisualStyle.Metro
        Me.EndDateDateTimePickerAdv.Calendar.TabIndex = 0
        Me.EndDateDateTimePickerAdv.Calendar.WeekFont = New System.Drawing.Font("Verdana", 8.0!)
        '
        '
        '
        Me.EndDateDateTimePickerAdv.Calendar.NoneButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.EndDateDateTimePickerAdv.Calendar.NoneButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.EndDateDateTimePickerAdv.Calendar.NoneButton.ForeColor = System.Drawing.Color.White
        Me.EndDateDateTimePickerAdv.Calendar.NoneButton.Location = New System.Drawing.Point(78, 0)
        Me.EndDateDateTimePickerAdv.Calendar.NoneButton.Size = New System.Drawing.Size(72, 20)
        Me.EndDateDateTimePickerAdv.Calendar.NoneButton.ThemeName = "Metro"
        Me.EndDateDateTimePickerAdv.Calendar.NoneButton.UseVisualStyle = True
        '
        '
        '
        Me.EndDateDateTimePickerAdv.Calendar.TodayButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.EndDateDateTimePickerAdv.Calendar.TodayButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.EndDateDateTimePickerAdv.Calendar.TodayButton.ForeColor = System.Drawing.Color.White
        Me.EndDateDateTimePickerAdv.Calendar.TodayButton.Location = New System.Drawing.Point(0, 0)
        Me.EndDateDateTimePickerAdv.Calendar.TodayButton.Size = New System.Drawing.Size(78, 20)
        Me.EndDateDateTimePickerAdv.Calendar.TodayButton.ThemeName = "Metro"
        Me.EndDateDateTimePickerAdv.Calendar.TodayButton.UseVisualStyle = True
        Me.EndDateDateTimePickerAdv.CalendarSize = New System.Drawing.Size(189, 176)
        Me.EndDateDateTimePickerAdv.Checked = False
        Me.EndDateDateTimePickerAdv.DropDownImage = Nothing
        Me.EndDateDateTimePickerAdv.DropDownNormalColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.EndDateDateTimePickerAdv.DropDownPressedColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.EndDateDateTimePickerAdv.DropDownSelectedColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.EndDateDateTimePickerAdv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndDateDateTimePickerAdv.Location = New System.Drawing.Point(152, 92)
        Me.EndDateDateTimePickerAdv.MetroColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.EndDateDateTimePickerAdv.MinValue = New Date(CType(0, Long))
        Me.EndDateDateTimePickerAdv.Name = "EndDateDateTimePickerAdv"
        Me.EndDateDateTimePickerAdv.ShowCheckBox = False
        Me.EndDateDateTimePickerAdv.Size = New System.Drawing.Size(117, 20)
        Me.EndDateDateTimePickerAdv.Style = Syncfusion.Windows.Forms.VisualStyle.Metro
        Me.EndDateDateTimePickerAdv.TabIndex = 19
        Me.EndDateDateTimePickerAdv.ThemesEnabled = True
        Me.EndDateDateTimePickerAdv.Value = New Date(2016, 9, 8, 15, 10, 46, 0)
        '
        'StartDateDateTimePickerAdv
        '
        Me.StartDateDateTimePickerAdv.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.StartDateDateTimePickerAdv.BorderColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.StartDateDateTimePickerAdv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.StartDateDateTimePickerAdv.Calendar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.StartDateDateTimePickerAdv.Calendar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StartDateDateTimePickerAdv.Calendar.Culture = New System.Globalization.CultureInfo("en-US")
        Me.StartDateDateTimePickerAdv.Calendar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.StartDateDateTimePickerAdv.Calendar.GridLines = Syncfusion.Windows.Forms.Grid.GridBorderStyle.None
        Me.StartDateDateTimePickerAdv.Calendar.HeaderEndColor = System.Drawing.Color.White
        Me.StartDateDateTimePickerAdv.Calendar.HeaderStartColor = System.Drawing.Color.White
        Me.StartDateDateTimePickerAdv.Calendar.HighlightColor = System.Drawing.Color.Black
        Me.StartDateDateTimePickerAdv.Calendar.Iso8601CalenderFormat = False
        Me.StartDateDateTimePickerAdv.Calendar.Location = New System.Drawing.Point(0, 0)
        Me.StartDateDateTimePickerAdv.Calendar.MetroColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.StartDateDateTimePickerAdv.Calendar.Name = "monthCalendar"
        Me.StartDateDateTimePickerAdv.Calendar.ScrollButtonSize = New System.Drawing.Size(24, 24)
        Me.StartDateDateTimePickerAdv.Calendar.Style = Syncfusion.Windows.Forms.VisualStyle.Metro
        Me.StartDateDateTimePickerAdv.Calendar.TabIndex = 0
        Me.StartDateDateTimePickerAdv.Calendar.WeekFont = New System.Drawing.Font("Verdana", 8.0!)
        '
        '
        '
        Me.StartDateDateTimePickerAdv.Calendar.NoneButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.StartDateDateTimePickerAdv.Calendar.NoneButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.StartDateDateTimePickerAdv.Calendar.NoneButton.ForeColor = System.Drawing.Color.White
        Me.StartDateDateTimePickerAdv.Calendar.NoneButton.Location = New System.Drawing.Point(78, 0)
        Me.StartDateDateTimePickerAdv.Calendar.NoneButton.Size = New System.Drawing.Size(72, 20)
        Me.StartDateDateTimePickerAdv.Calendar.NoneButton.ThemeName = "Metro"
        Me.StartDateDateTimePickerAdv.Calendar.NoneButton.UseVisualStyle = True
        '
        '
        '
        Me.StartDateDateTimePickerAdv.Calendar.TodayButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.StartDateDateTimePickerAdv.Calendar.TodayButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.StartDateDateTimePickerAdv.Calendar.TodayButton.ForeColor = System.Drawing.Color.White
        Me.StartDateDateTimePickerAdv.Calendar.TodayButton.Location = New System.Drawing.Point(0, 0)
        Me.StartDateDateTimePickerAdv.Calendar.TodayButton.Size = New System.Drawing.Size(78, 20)
        Me.StartDateDateTimePickerAdv.Calendar.TodayButton.ThemeName = "Metro"
        Me.StartDateDateTimePickerAdv.Calendar.TodayButton.UseVisualStyle = True
        Me.StartDateDateTimePickerAdv.CalendarSize = New System.Drawing.Size(189, 176)
        Me.StartDateDateTimePickerAdv.Checked = False
        Me.StartDateDateTimePickerAdv.DropDownImage = Nothing
        Me.StartDateDateTimePickerAdv.DropDownNormalColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.StartDateDateTimePickerAdv.DropDownPressedColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.StartDateDateTimePickerAdv.DropDownSelectedColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.StartDateDateTimePickerAdv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartDateDateTimePickerAdv.Location = New System.Drawing.Point(152, 45)
        Me.StartDateDateTimePickerAdv.MetroColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.StartDateDateTimePickerAdv.MinValue = New Date(CType(0, Long))
        Me.StartDateDateTimePickerAdv.Name = "StartDateDateTimePickerAdv"
        Me.StartDateDateTimePickerAdv.ShowCheckBox = False
        Me.StartDateDateTimePickerAdv.Size = New System.Drawing.Size(117, 20)
        Me.StartDateDateTimePickerAdv.Style = Syncfusion.Windows.Forms.VisualStyle.Metro
        Me.StartDateDateTimePickerAdv.TabIndex = 18
        Me.StartDateDateTimePickerAdv.ThemesEnabled = True
        Me.StartDateDateTimePickerAdv.Value = New Date(2016, 9, 8, 15, 10, 46, 0)
        '
        'SubjectTextBoxExt
        '
        Me.SubjectTextBoxExt.BackColor = System.Drawing.Color.White
        Me.SubjectTextBoxExt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.SubjectTextBoxExt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SubjectTextBoxExt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SubjectTextBoxExt.Location = New System.Drawing.Point(153, 160)
        Me.SubjectTextBoxExt.MaxLength = 255
        Me.SubjectTextBoxExt.Name = "SubjectTextBoxExt"
        Me.SubjectTextBoxExt.Size = New System.Drawing.Size(319, 20)
        Me.SubjectTextBoxExt.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro
        Me.SubjectTextBoxExt.TabIndex = 17
        Me.SubjectTextBoxExt.ThemeName = "Metro"
        Me.SubjectTextBoxExt.WordWrap = False
        '
        'appointEve
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 249)
        Me.Controls.Add(Me.assignedTo)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.ok)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.comboBox1)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.EndTimeDateTimePickerAdv)
        Me.Controls.Add(Me.StartTimeDateTimePickerAdv)
        Me.Controls.Add(Me.EndDateDateTimePickerAdv)
        Me.Controls.Add(Me.StartDateDateTimePickerAdv)
        Me.Controls.Add(Me.SubjectTextBoxExt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "appointEve"
        Me.Text = "appointEve"
        CType(Me.EndTimeDateTimePickerAdv.Calendar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EndTimeDateTimePickerAdv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StartTimeDateTimePickerAdv.Calendar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StartTimeDateTimePickerAdv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EndDateDateTimePickerAdv.Calendar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EndDateDateTimePickerAdv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StartDateDateTimePickerAdv.Calendar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StartDateDateTimePickerAdv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubjectTextBoxExt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents assignedTo As CheckBox
    Private WithEvents cancel As Syncfusion.Windows.Forms.ButtonAdv
    Private WithEvents ok As Syncfusion.Windows.Forms.ButtonAdv
    Private WithEvents label7 As Label
    Private WithEvents comboBox1 As ComboBox
    Private WithEvents label6 As Label
    Private WithEvents label4 As Label
    Private WithEvents label5 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents EndTimeDateTimePickerAdv As Syncfusion.Windows.Forms.Tools.DateTimePickerAdv
    Private WithEvents StartTimeDateTimePickerAdv As Syncfusion.Windows.Forms.Tools.DateTimePickerAdv
    Private WithEvents EndDateDateTimePickerAdv As Syncfusion.Windows.Forms.Tools.DateTimePickerAdv
    Private WithEvents StartDateDateTimePickerAdv As Syncfusion.Windows.Forms.Tools.DateTimePickerAdv
    Private WithEvents SubjectTextBoxExt As Syncfusion.Windows.Forms.Tools.TextBoxExt
End Class
