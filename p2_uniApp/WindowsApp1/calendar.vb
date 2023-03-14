'#define console


Imports Microsoft.VisualBasic
Imports System
Imports System.Globalization
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.IO
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Formatters
Imports System.Runtime.Serialization.Formatters.Binary
Imports Syncfusion.Schedule
Imports Syncfusion.Windows.Forms.Schedule
Imports Syncfusion.Windows.Forms

Namespace GridScheduleSample
    ''' <summary>
    ''' Summary description for Form1.
    ''' </summary>
    Public Class calendar : Inherits System.Windows.Forms.Form
        Private components As System.ComponentModel.IContainer
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()

            'initialize the data somehow - specific to your implementation
            Dim scheduleProvider As SimpleScheduleDataProvider
            If File.Exists("default.schedule") Then
                scheduleProvider = SimpleScheduleDataProvider.LoadBinary("default.schedule")
                scheduleProvider.FileName = "default.schedule"
            Else
                scheduleProvider = New SimpleScheduleDataProvider()
                scheduleProvider.MasterList = New SimpleScheduleAppointmentList()
                scheduleProvider.FileName = "default.schedule"
            End If

            Me.ScheduleControl1.ScheduleType = ScheduleViewType.Month 'ScheduleViewType.Day;//.WorkWeek;//.Week;//ScheduleViewType.WorkWeek;// ScheduleViewType.Day;//.WorkWeek;
            'set the data source
            Me.ScheduleControl1.DataSource = scheduleProvider
            ' Dim ico As System.Drawing.Icon = New System.Drawing.Icon(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("Icon", "Suite.ico"))
            '  Me.Icon = ico
            'subscibe to item click event
            ' AddHandler ScheduleControl1.ScheduleAppointmentClick, AddressOf ScheduleControl1_ScheduleAppointmentClick
            'Hook the event for showing the appointment.
            'AddHandler ScheduleControl1.ShowingAppointmentForm, AddressOf scheduleControl1_ShowingAppointmentForm

        End Sub
        Private grid As New ScheduleGrid()

        Private Sub item_Click(ByVal sender As Object, ByVal e As EventArgs)

            If form IsNot Nothing Then
                form.ShowDialog()
            End If
        End Sub
        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Not components Is Nothing Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub

        'overridden to close propertyForm if opened.


#Region "Windows Form Designer generated code"
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim Animation1 As Guna.UI.Animation.Animation = New Guna.UI.Animation.Animation()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(calendar))
            Me.ScheduleControl1 = New Syncfusion.Windows.Forms.Schedule.ScheduleControl()
            Me.menuItem2 = New System.Windows.Forms.MenuItem()
            Me.menuItem4 = New System.Windows.Forms.MenuItem()
            Me.menuItem3 = New System.Windows.Forms.MenuItem()
            Me.menuItem25 = New System.Windows.Forms.MenuItem()
            Me.menuItem27 = New System.Windows.Forms.MenuItem()
            Me.menuItem26 = New System.Windows.Forms.MenuItem()
            Me.menuItem5 = New System.Windows.Forms.MenuItem()
            Me.menuItem1 = New System.Windows.Forms.MenuItem()
            Me.menuItem7 = New System.Windows.Forms.MenuItem()
            Me.menuItem8 = New System.Windows.Forms.MenuItem()
            Me.menuItem9 = New System.Windows.Forms.MenuItem()
            Me.menuItem10 = New System.Windows.Forms.MenuItem()
            Me.menuItem6 = New System.Windows.Forms.MenuItem()
            Me.menuItem12 = New System.Windows.Forms.MenuItem()
            Me.menuItem13 = New System.Windows.Forms.MenuItem()
            Me.menuItem14 = New System.Windows.Forms.MenuItem()
            Me.menuItem15 = New System.Windows.Forms.MenuItem()
            Me.menuItem11 = New System.Windows.Forms.MenuItem()
            Me.menuItem19 = New System.Windows.Forms.MenuItem()
            Me.menuItem41 = New System.Windows.Forms.MenuItem()
            Me.menuItem42 = New System.Windows.Forms.MenuItem()
            Me.menuItem17 = New System.Windows.Forms.MenuItem()
            Me.menuItem32 = New System.Windows.Forms.MenuItem()
            Me.menuItem33 = New System.Windows.Forms.MenuItem()
            Me.menuItem34 = New System.Windows.Forms.MenuItem()
            Me.menuItem35 = New System.Windows.Forms.MenuItem()
            Me.menuItem36 = New System.Windows.Forms.MenuItem()
            Me.menuItem37 = New System.Windows.Forms.MenuItem()
            Me.menuItem18 = New System.Windows.Forms.MenuItem()
            Me.menuItem29 = New System.Windows.Forms.MenuItem()
            Me.menuItem30 = New System.Windows.Forms.MenuItem()
            Me.menuItem31 = New System.Windows.Forms.MenuItem()
            Me.menuItem22 = New System.Windows.Forms.MenuItem()
            Me.menuItem38 = New System.Windows.Forms.MenuItem()
            Me.menuItem39 = New System.Windows.Forms.MenuItem()
            Me.menuItem40 = New System.Windows.Forms.MenuItem()
            Me.menuItem28 = New System.Windows.Forms.MenuItem()
            Me.menuItem20 = New System.Windows.Forms.MenuItem()
            Me.MenuItem43 = New System.Windows.Forms.MenuItem()
            Me.menuItem21 = New System.Windows.Forms.MenuItem()
            Me.MenuItem44 = New System.Windows.Forms.MenuItem()
            Me.menuItem16 = New System.Windows.Forms.MenuItem()
            Me.menuItem24 = New System.Windows.Forms.MenuItem()
            Me.menuItem23 = New System.Windows.Forms.MenuItem()
            Me.mainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
            Me.GunaTransition1 = New Guna.UI.WinForms.GunaTransition(Me.components)
            Me.GunaSeparator1 = New Guna.UI.WinForms.GunaSeparator()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.GunaAdvenceButton5 = New Guna.UI.WinForms.GunaAdvenceButton()
            Me.GunaAdvenceButton4 = New Guna.UI.WinForms.GunaAdvenceButton()
            Me.GunaAdvenceButton3 = New Guna.UI.WinForms.GunaAdvenceButton()
            Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
            Me.GunaButton2 = New Guna.UI.WinForms.GunaButton()
            Me.GunaAdvenceButton2 = New Guna.UI.WinForms.GunaAdvenceButton()
            Me.GunaAdvenceButton1 = New Guna.UI.WinForms.GunaAdvenceButton()
            CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'ScheduleControl1
            '
            Me.ScheduleControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.ScheduleControl1.Appearance.AllDayItemFormat = "[subject] [starttime][description]"
            Me.ScheduleControl1.Appearance.EnableTransparentSpan = True
            Me.ScheduleControl1.Appearance.MonthShowFullWeek = True
            Me.ScheduleControl1.Appearance.NavigationCalendarArrowColor = System.Drawing.Color.RoyalBlue
            Me.ScheduleControl1.Appearance.NavigationCalendarStartDayOfWeek = System.DayOfWeek.Monday
            Me.ScheduleControl1.Appearance.VisualStyle = Syncfusion.Windows.Forms.GridVisualStyles.Metro
            Me.ScheduleControl1.Appearance.WeekHeaderFormat = "MMMM dd"
            Me.ScheduleControl1.Appearance.WeekMonthFullFormat = "dddd, dd MMMM yyyy"
            Me.ScheduleControl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(219, Byte), Integer))
            Me.ScheduleControl1.Culture = New System.Globalization.CultureInfo("")
            Me.ScheduleControl1.DataSource = Nothing
            Me.GunaTransition1.SetDecoration(Me.ScheduleControl1, Guna.UI.Animation.DecorationType.None)
            Me.ScheduleControl1.ISO8601CalenderFormat = False
            Me.ScheduleControl1.Location = New System.Drawing.Point(21, 105)
            Me.ScheduleControl1.Name = "ScheduleControl1"
            Me.ScheduleControl1.NavigationPanelPosition = Syncfusion.Schedule.CalendarNavigationPanelPosition.Hidden
            Me.ScheduleControl1.Size = New System.Drawing.Size(1207, 420)
            Me.ScheduleControl1.TabIndex = 3
            '
            'menuItem2
            '
            Me.menuItem2.Index = 0
            Me.menuItem2.Text = "Open Calendar..."
            '
            'menuItem4
            '
            Me.menuItem4.Index = 1
            Me.menuItem4.Text = "New Calendar..."
            '
            'menuItem3
            '
            Me.menuItem3.Index = 2
            Me.menuItem3.Text = "Save Calendar"
            '
            'menuItem25
            '
            Me.menuItem25.Index = 3
            Me.menuItem25.Text = "Save Calendar as..."
            '
            'menuItem27
            '
            Me.menuItem27.Index = 4
            Me.menuItem27.Text = "Merge Calendar..."
            '
            'menuItem26
            '
            Me.menuItem26.Index = 5
            Me.menuItem26.Text = "Random Data"
            '
            'menuItem5
            '
            Me.menuItem5.Index = 6
            Me.menuItem5.Text = "Exit"
            '
            'menuItem1
            '
            Me.menuItem1.Index = 0
            Me.menuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem2, Me.menuItem4, Me.menuItem3, Me.menuItem25, Me.menuItem27, Me.menuItem26, Me.menuItem5})
            Me.menuItem1.Text = "File"
            '
            'menuItem7
            '
            Me.menuItem7.Index = 0
            Me.menuItem7.Shortcut = System.Windows.Forms.Shortcut.F1
            Me.menuItem7.Text = "helloooo"
            '
            'menuItem8
            '
            Me.menuItem8.Index = 1
            Me.menuItem8.Text = "New AllDay Item"
            '
            'menuItem9
            '
            Me.menuItem9.Index = 2
            Me.menuItem9.Text = "Edit Item"
            '
            'menuItem10
            '
            Me.menuItem10.Index = 3
            Me.menuItem10.Text = "Delete Item"
            '
            'menuItem6
            '
            Me.menuItem6.Index = 1
            Me.menuItem6.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem7, Me.menuItem8, Me.menuItem9, Me.menuItem10})
            Me.menuItem6.Text = "Edit"
            '
            'menuItem12
            '
            Me.menuItem12.Index = 0
            Me.menuItem12.Text = "Day"
            '
            'menuItem13
            '
            Me.menuItem13.Index = 1
            Me.menuItem13.Text = "Workweek"
            '
            'menuItem14
            '
            Me.menuItem14.Index = 2
            Me.menuItem14.Text = "Week"
            '
            'menuItem15
            '
            Me.menuItem15.Index = 3
            Me.menuItem15.Text = "Month"
            '
            'menuItem11
            '
            Me.menuItem11.Index = 2
            Me.menuItem11.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem12, Me.menuItem13, Me.menuItem14, Me.menuItem15})
            Me.menuItem11.Text = "View"
            '
            'menuItem19
            '
            Me.menuItem19.Index = 0
            Me.menuItem19.Text = "Change..."
            '
            'menuItem41
            '
            Me.menuItem41.Index = 1
            Me.menuItem41.Text = "Load..."
            '
            'menuItem42
            '
            Me.menuItem42.Index = 2
            Me.menuItem42.Text = "Save..."
            '
            'menuItem17
            '
            Me.menuItem17.Index = 0
            Me.menuItem17.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem19, Me.menuItem41, Me.menuItem42})
            Me.menuItem17.Text = "s"
            '
            'menuItem32
            '
            Me.menuItem32.Index = 0
            Me.menuItem32.Text = "Invariant"
            '
            'menuItem33
            '
            Me.menuItem33.Index = 1
            Me.menuItem33.Text = "Application"
            '
            'menuItem34
            '
            Me.menuItem34.Index = 2
            Me.menuItem34.Text = "fr-FR"
            '
            'menuItem35
            '
            Me.menuItem35.Index = 3
            Me.menuItem35.Text = "it-IT"
            '
            'menuItem36
            '
            Me.menuItem36.Index = 4
            Me.menuItem36.Text = "en-US"
            '
            'menuItem37
            '
            Me.menuItem37.Index = 5
            Me.menuItem37.Text = "de-DE"
            '
            'menuItem18
            '
            Me.menuItem18.Index = 1
            Me.menuItem18.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem32, Me.menuItem33, Me.menuItem34, Me.menuItem35, Me.menuItem36, Me.menuItem37})
            Me.menuItem18.Text = "Culture"
            '
            'menuItem29
            '
            Me.menuItem29.Index = 0
            Me.menuItem29.Text = "Hidden"
            '
            'menuItem30
            '
            Me.menuItem30.Index = 1
            Me.menuItem30.Text = "Left"
            '
            'menuItem31
            '
            Me.menuItem31.Index = 2
            Me.menuItem31.Text = "Right"
            '
            'menuItem22
            '
            Me.menuItem22.Index = 2
            Me.menuItem22.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem29, Me.menuItem30, Me.menuItem31})
            Me.menuItem22.Text = "Navigation Panel"
            '
            'menuItem38
            '
            Me.menuItem38.Index = 0
            Me.menuItem38.Text = "Do Not Save"
            '
            'menuItem39
            '
            Me.menuItem39.Index = 1
            Me.menuItem39.Text = "Prompt Before Saving"
            '
            'menuItem40
            '
            Me.menuItem40.Index = 2
            Me.menuItem40.Text = "Save Without Prompt"
            '
            'menuItem28
            '
            Me.menuItem28.Index = 3
            Me.menuItem28.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem38, Me.menuItem39, Me.menuItem40})
            Me.menuItem28.Text = "Save on Close"
            '
            'menuItem20
            '
            Me.menuItem20.Checked = True
            Me.menuItem20.Index = 4
            Me.menuItem20.Text = "Week Numbers"
            '
            'MenuItem43
            '
            Me.MenuItem43.Index = 5
            Me.MenuItem43.Text = "Alerts"
            '
            'menuItem21
            '
            Me.menuItem21.Index = 6
            Me.menuItem21.Text = "Additional Panel"
            '
            'MenuItem44
            '
            Me.MenuItem44.Index = 7
            Me.MenuItem44.Text = "Test"
            '
            'menuItem16
            '
            Me.menuItem16.Index = 3
            Me.menuItem16.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem17, Me.menuItem18, Me.menuItem22, Me.menuItem28, Me.menuItem20, Me.MenuItem43, Me.menuItem21, Me.MenuItem44})
            Me.menuItem16.Text = "Options"
            '
            'menuItem24
            '
            Me.menuItem24.Index = 0
            Me.menuItem24.Text = "About..."
            '
            'menuItem23
            '
            Me.menuItem23.Index = 4
            Me.menuItem23.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem24})
            Me.menuItem23.Text = "Help"
            '
            'mainMenu1
            '
            Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem1, Me.menuItem6, Me.menuItem11, Me.menuItem16, Me.menuItem23})
            '
            'GunaTransition1
            '
            Me.GunaTransition1.AnimationType = Guna.UI.Animation.AnimationType.Scale
            Me.GunaTransition1.Cursor = Nothing
            Animation1.AnimateOnlyDifferences = True
            Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
            Animation1.LeafCoeff = 0!
            Animation1.MaxTime = 1.0!
            Animation1.MinTime = 0!
            Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
            Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
            Animation1.MosaicSize = 0
            Animation1.Padding = New System.Windows.Forms.Padding(0)
            Animation1.RotateCoeff = 0!
            Animation1.RotateLimit = 0!
            Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
            Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
            Animation1.TimeCoeff = 0!
            Animation1.TransparencyCoeff = 0!
            Me.GunaTransition1.DefaultAnimation = Animation1
            Me.GunaTransition1.Interval = 3
            Me.GunaTransition1.TimeStep = 0.05!
            '
            'GunaSeparator1
            '
            Me.GunaTransition1.SetDecoration(Me.GunaSeparator1, Guna.UI.Animation.DecorationType.None)
            Me.GunaSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
            Me.GunaSeparator1.Location = New System.Drawing.Point(0, 53)
            Me.GunaSeparator1.Name = "GunaSeparator1"
            Me.GunaSeparator1.Size = New System.Drawing.Size(1286, 10)
            Me.GunaSeparator1.TabIndex = 48
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.GunaTransition1.SetDecoration(Me.Label1, Guna.UI.Animation.DecorationType.None)
            Me.Label1.ForeColor = System.Drawing.Color.DimGray
            Me.Label1.Location = New System.Drawing.Point(839, 86)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(132, 13)
            Me.Label1.TabIndex = 53
            Me.Label1.Text = "defaultSchedule.Schedule"
            '
            'GunaAdvenceButton5
            '
            Me.GunaAdvenceButton5.AnimationHoverSpeed = 0.07!
            Me.GunaAdvenceButton5.AnimationSpeed = 0.03!
            Me.GunaAdvenceButton5.BackColor = System.Drawing.Color.Transparent
            Me.GunaAdvenceButton5.BaseColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(199, Byte), Integer))
            Me.GunaAdvenceButton5.BorderColor = System.Drawing.Color.Black
            Me.GunaAdvenceButton5.CheckedBaseColor = System.Drawing.Color.Gray
            Me.GunaAdvenceButton5.CheckedBorderColor = System.Drawing.Color.Black
            Me.GunaAdvenceButton5.CheckedForeColor = System.Drawing.Color.White
            Me.GunaAdvenceButton5.CheckedImage = CType(resources.GetObject("GunaAdvenceButton5.CheckedImage"), System.Drawing.Image)
            Me.GunaAdvenceButton5.CheckedLineColor = System.Drawing.Color.DimGray
            Me.GunaAdvenceButton5.Cursor = System.Windows.Forms.Cursors.Hand
            Me.GunaTransition1.SetDecoration(Me.GunaAdvenceButton5, Guna.UI.Animation.DecorationType.None)
            Me.GunaAdvenceButton5.DialogResult = System.Windows.Forms.DialogResult.None
            Me.GunaAdvenceButton5.FocusedColor = System.Drawing.Color.Empty
            Me.GunaAdvenceButton5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.GunaAdvenceButton5.ForeColor = System.Drawing.Color.White
            Me.GunaAdvenceButton5.Image = CType(resources.GetObject("GunaAdvenceButton5.Image"), System.Drawing.Image)
            Me.GunaAdvenceButton5.ImageSize = New System.Drawing.Size(24, 24)
            Me.GunaAdvenceButton5.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.GunaAdvenceButton5.Location = New System.Drawing.Point(1028, 68)
            Me.GunaAdvenceButton5.Name = "GunaAdvenceButton5"
            Me.GunaAdvenceButton5.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(199, Byte), Integer))
            Me.GunaAdvenceButton5.OnHoverBorderColor = System.Drawing.Color.Black
            Me.GunaAdvenceButton5.OnHoverForeColor = System.Drawing.Color.White
            Me.GunaAdvenceButton5.OnHoverImage = Nothing
            Me.GunaAdvenceButton5.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.GunaAdvenceButton5.OnPressedColor = System.Drawing.Color.Black
            Me.GunaAdvenceButton5.Radius = 3
            Me.GunaAdvenceButton5.Size = New System.Drawing.Size(44, 31)
            Me.GunaAdvenceButton5.TabIndex = 52
            Me.GunaAdvenceButton5.Text = "Δημιουργία Συμβάν"
            '
            'GunaAdvenceButton4
            '
            Me.GunaAdvenceButton4.AnimationHoverSpeed = 0.07!
            Me.GunaAdvenceButton4.AnimationSpeed = 0.03!
            Me.GunaAdvenceButton4.BackColor = System.Drawing.Color.Transparent
            Me.GunaAdvenceButton4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(199, Byte), Integer))
            Me.GunaAdvenceButton4.BorderColor = System.Drawing.Color.Black
            Me.GunaAdvenceButton4.CheckedBaseColor = System.Drawing.Color.Gray
            Me.GunaAdvenceButton4.CheckedBorderColor = System.Drawing.Color.Black
            Me.GunaAdvenceButton4.CheckedForeColor = System.Drawing.Color.White
            Me.GunaAdvenceButton4.CheckedImage = CType(resources.GetObject("GunaAdvenceButton4.CheckedImage"), System.Drawing.Image)
            Me.GunaAdvenceButton4.CheckedLineColor = System.Drawing.Color.DimGray
            Me.GunaAdvenceButton4.Cursor = System.Windows.Forms.Cursors.Hand
            Me.GunaTransition1.SetDecoration(Me.GunaAdvenceButton4, Guna.UI.Animation.DecorationType.None)
            Me.GunaAdvenceButton4.DialogResult = System.Windows.Forms.DialogResult.None
            Me.GunaAdvenceButton4.FocusedColor = System.Drawing.Color.Empty
            Me.GunaAdvenceButton4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.GunaAdvenceButton4.ForeColor = System.Drawing.Color.White
            Me.GunaAdvenceButton4.Image = CType(resources.GetObject("GunaAdvenceButton4.Image"), System.Drawing.Image)
            Me.GunaAdvenceButton4.ImageSize = New System.Drawing.Size(24, 24)
            Me.GunaAdvenceButton4.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.GunaAdvenceButton4.Location = New System.Drawing.Point(1079, 68)
            Me.GunaAdvenceButton4.Name = "GunaAdvenceButton4"
            Me.GunaAdvenceButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(199, Byte), Integer))
            Me.GunaAdvenceButton4.OnHoverBorderColor = System.Drawing.Color.Black
            Me.GunaAdvenceButton4.OnHoverForeColor = System.Drawing.Color.White
            Me.GunaAdvenceButton4.OnHoverImage = Nothing
            Me.GunaAdvenceButton4.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.GunaAdvenceButton4.OnPressedColor = System.Drawing.Color.Black
            Me.GunaAdvenceButton4.Radius = 3
            Me.GunaAdvenceButton4.Size = New System.Drawing.Size(44, 31)
            Me.GunaAdvenceButton4.TabIndex = 51
            Me.GunaAdvenceButton4.Text = "Δημιουργία Συμβάν"
            '
            'GunaAdvenceButton3
            '
            Me.GunaAdvenceButton3.AnimationHoverSpeed = 0.07!
            Me.GunaAdvenceButton3.AnimationSpeed = 0.03!
            Me.GunaAdvenceButton3.BackColor = System.Drawing.Color.Transparent
            Me.GunaAdvenceButton3.BaseColor = System.Drawing.Color.WhiteSmoke
            Me.GunaAdvenceButton3.BorderColor = System.Drawing.Color.LightGray
            Me.GunaAdvenceButton3.ButtonType = Guna.UI.WinForms.AdvenceButtonType.ToogleButton
            Me.GunaAdvenceButton3.CheckedBaseColor = System.Drawing.Color.WhiteSmoke
            Me.GunaAdvenceButton3.CheckedBorderColor = System.Drawing.Color.Black
            Me.GunaAdvenceButton3.CheckedForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.GunaAdvenceButton3.CheckedImage = CType(resources.GetObject("GunaAdvenceButton3.CheckedImage"), System.Drawing.Image)
            Me.GunaAdvenceButton3.CheckedLineColor = System.Drawing.Color.DimGray
            Me.GunaAdvenceButton3.Cursor = System.Windows.Forms.Cursors.Hand
            Me.GunaTransition1.SetDecoration(Me.GunaAdvenceButton3, Guna.UI.Animation.DecorationType.None)
            Me.GunaAdvenceButton3.DialogResult = System.Windows.Forms.DialogResult.None
            Me.GunaAdvenceButton3.FocusedColor = System.Drawing.Color.Empty
            Me.GunaAdvenceButton3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.GunaAdvenceButton3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.GunaAdvenceButton3.Image = CType(resources.GetObject("GunaAdvenceButton3.Image"), System.Drawing.Image)
            Me.GunaAdvenceButton3.ImageSize = New System.Drawing.Size(20, 20)
            Me.GunaAdvenceButton3.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.GunaAdvenceButton3.Location = New System.Drawing.Point(21, 69)
            Me.GunaAdvenceButton3.Name = "GunaAdvenceButton3"
            Me.GunaAdvenceButton3.OnHoverBaseColor = System.Drawing.Color.WhiteSmoke
            Me.GunaAdvenceButton3.OnHoverBorderColor = System.Drawing.Color.LightGray
            Me.GunaAdvenceButton3.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.GunaAdvenceButton3.OnHoverImage = CType(resources.GetObject("GunaAdvenceButton3.OnHoverImage"), System.Drawing.Image)
            Me.GunaAdvenceButton3.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.GunaAdvenceButton3.OnPressedColor = System.Drawing.Color.WhiteSmoke
            Me.GunaAdvenceButton3.Radius = 3
            Me.GunaAdvenceButton3.Size = New System.Drawing.Size(191, 32)
            Me.GunaAdvenceButton3.TabIndex = 50
            Me.GunaAdvenceButton3.Text = "Περιήγηση Ημερομηνιών"
            '
            'GunaPictureBox1
            '
            Me.GunaPictureBox1.BackgroundImage = CType(resources.GetObject("GunaPictureBox1.BackgroundImage"), System.Drawing.Image)
            Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
            Me.GunaTransition1.SetDecoration(Me.GunaPictureBox1, Guna.UI.Animation.DecorationType.None)
            Me.GunaPictureBox1.Location = New System.Drawing.Point(21, 9)
            Me.GunaPictureBox1.Name = "GunaPictureBox1"
            Me.GunaPictureBox1.Size = New System.Drawing.Size(156, 33)
            Me.GunaPictureBox1.TabIndex = 47
            Me.GunaPictureBox1.TabStop = False
            '
            'GunaButton2
            '
            Me.GunaButton2.AnimationHoverSpeed = 0.07!
            Me.GunaButton2.AnimationSpeed = 0.03!
            Me.GunaButton2.BackColor = System.Drawing.Color.Transparent
            Me.GunaButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(199, Byte), Integer))
            Me.GunaButton2.BorderColor = System.Drawing.Color.Black
            Me.GunaButton2.Cursor = System.Windows.Forms.Cursors.Hand
            Me.GunaTransition1.SetDecoration(Me.GunaButton2, Guna.UI.Animation.DecorationType.None)
            Me.GunaButton2.DialogResult = System.Windows.Forms.DialogResult.None
            Me.GunaButton2.FocusedColor = System.Drawing.Color.Empty
            Me.GunaButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.GunaButton2.ForeColor = System.Drawing.Color.White
            Me.GunaButton2.Image = CType(resources.GetObject("GunaButton2.Image"), System.Drawing.Image)
            Me.GunaButton2.ImageSize = New System.Drawing.Size(24, 24)
            Me.GunaButton2.Location = New System.Drawing.Point(977, 67)
            Me.GunaButton2.Name = "GunaButton2"
            Me.GunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(199, Byte), Integer))
            Me.GunaButton2.OnHoverBorderColor = System.Drawing.Color.Black
            Me.GunaButton2.OnHoverForeColor = System.Drawing.Color.White
            Me.GunaButton2.OnHoverImage = Nothing
            Me.GunaButton2.OnPressedColor = System.Drawing.Color.Black
            Me.GunaButton2.Radius = 4
            Me.GunaButton2.Size = New System.Drawing.Size(44, 32)
            Me.GunaButton2.TabIndex = 46
            Me.GunaButton2.Text = "Αποθήκευση"
            '
            'GunaAdvenceButton2
            '
            Me.GunaAdvenceButton2.AnimationHoverSpeed = 0.07!
            Me.GunaAdvenceButton2.AnimationSpeed = 0.03!
            Me.GunaAdvenceButton2.BackColor = System.Drawing.Color.Transparent
            Me.GunaAdvenceButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(199, Byte), Integer))
            Me.GunaAdvenceButton2.BorderColor = System.Drawing.Color.Black
            Me.GunaAdvenceButton2.CheckedBaseColor = System.Drawing.Color.Gray
            Me.GunaAdvenceButton2.CheckedBorderColor = System.Drawing.Color.Black
            Me.GunaAdvenceButton2.CheckedForeColor = System.Drawing.Color.White
            Me.GunaAdvenceButton2.CheckedImage = CType(resources.GetObject("GunaAdvenceButton2.CheckedImage"), System.Drawing.Image)
            Me.GunaAdvenceButton2.CheckedLineColor = System.Drawing.Color.DimGray
            Me.GunaAdvenceButton2.Cursor = System.Windows.Forms.Cursors.Hand
            Me.GunaTransition1.SetDecoration(Me.GunaAdvenceButton2, Guna.UI.Animation.DecorationType.None)
            Me.GunaAdvenceButton2.DialogResult = System.Windows.Forms.DialogResult.None
            Me.GunaAdvenceButton2.FocusedColor = System.Drawing.Color.Empty
            Me.GunaAdvenceButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.GunaAdvenceButton2.ForeColor = System.Drawing.Color.White
            Me.GunaAdvenceButton2.Image = CType(resources.GetObject("GunaAdvenceButton2.Image"), System.Drawing.Image)
            Me.GunaAdvenceButton2.ImageSize = New System.Drawing.Size(20, 20)
            Me.GunaAdvenceButton2.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.GunaAdvenceButton2.Location = New System.Drawing.Point(1070, 12)
            Me.GunaAdvenceButton2.Name = "GunaAdvenceButton2"
            Me.GunaAdvenceButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(199, Byte), Integer))
            Me.GunaAdvenceButton2.OnHoverBorderColor = System.Drawing.Color.Black
            Me.GunaAdvenceButton2.OnHoverForeColor = System.Drawing.Color.White
            Me.GunaAdvenceButton2.OnHoverImage = Nothing
            Me.GunaAdvenceButton2.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.GunaAdvenceButton2.OnPressedColor = System.Drawing.Color.Black
            Me.GunaAdvenceButton2.Radius = 3
            Me.GunaAdvenceButton2.Size = New System.Drawing.Size(158, 31)
            Me.GunaAdvenceButton2.TabIndex = 42
            Me.GunaAdvenceButton2.Text = "Δημιουργία Συμβάν"
            '
            'GunaAdvenceButton1
            '
            Me.GunaAdvenceButton1.Animated = True
            Me.GunaAdvenceButton1.AnimationHoverSpeed = 0.07!
            Me.GunaAdvenceButton1.AnimationSpeed = 0.03!
            Me.GunaAdvenceButton1.BackColor = System.Drawing.Color.Transparent
            Me.GunaAdvenceButton1.BaseColor = System.Drawing.Color.White
            Me.GunaAdvenceButton1.BorderColor = System.Drawing.Color.LightGray
            Me.GunaAdvenceButton1.BorderSize = 1
            Me.GunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray
            Me.GunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black
            Me.GunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White
            Me.GunaAdvenceButton1.CheckedImage = CType(resources.GetObject("GunaAdvenceButton1.CheckedImage"), System.Drawing.Image)
            Me.GunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray
            Me.GunaAdvenceButton1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.GunaTransition1.SetDecoration(Me.GunaAdvenceButton1, Guna.UI.Animation.DecorationType.None)
            Me.GunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None
            Me.GunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty
            Me.GunaAdvenceButton1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.GunaAdvenceButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.GunaAdvenceButton1.Image = CType(resources.GetObject("GunaAdvenceButton1.Image"), System.Drawing.Image)
            Me.GunaAdvenceButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.GunaAdvenceButton1.ImageSize = New System.Drawing.Size(10, 10)
            Me.GunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.GunaAdvenceButton1.Location = New System.Drawing.Point(1130, 67)
            Me.GunaAdvenceButton1.Name = "GunaAdvenceButton1"
            Me.GunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer))
            Me.GunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.LightGray
            Me.GunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.Black
            Me.GunaAdvenceButton1.OnHoverImage = CType(resources.GetObject("GunaAdvenceButton1.OnHoverImage"), System.Drawing.Image)
            Me.GunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.GunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black
            Me.GunaAdvenceButton1.Radius = 3
            Me.GunaAdvenceButton1.Size = New System.Drawing.Size(98, 32)
            Me.GunaAdvenceButton1.TabIndex = 8
            Me.GunaAdvenceButton1.Text = "Μήνας"
            '
            'calendar
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.AutoSize = True
            Me.BackColor = System.Drawing.Color.WhiteSmoke
            Me.ClientSize = New System.Drawing.Size(1279, 552)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.GunaAdvenceButton5)
            Me.Controls.Add(Me.GunaAdvenceButton4)
            Me.Controls.Add(Me.GunaAdvenceButton3)
            Me.Controls.Add(Me.GunaSeparator1)
            Me.Controls.Add(Me.GunaPictureBox1)
            Me.Controls.Add(Me.GunaButton2)
            Me.Controls.Add(Me.GunaAdvenceButton2)
            Me.Controls.Add(Me.GunaAdvenceButton1)
            Me.Controls.Add(Me.ScheduleControl1)
            Me.GunaTransition1.SetDecoration(Me, Guna.UI.Animation.DecorationType.None)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Menu = Me.mainMenu1
            Me.Name = "calendar"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Scheduler Demo"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
#End Region

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread()>
        Shared Sub Main()
            'Application.EnableVisualStyles();
            Application.Run(New calendar())
        End Sub



        'sample event handler to catch clicks on the schedule control.
        Private Sub ScheduleControl1_ScheduleAppointmentClick(ByVal sender As Object, ByVal e As ScheduleAppointmentClickEventArgs)
            Console.WriteLine("ScheduleControl1_ScheduleAppointmentClick: {0} {1}", e.ClickType, e.ClickDateTime)
        End Sub

#Region "utility methods"
        Private Sub CheckAndSaveIfNeeded(ByVal prompt As Boolean)
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro

            Dim name As String = (CType(Me.ScheduleControl1.DataSource, SimpleScheduleDataProvider)).FileName
            Dim i As Integer = name.LastIndexOf("\"c)
            If i > -1 Then
                name = name.Substring(i + 1)
            End If
            If Me.ScheduleControl1.DataSource.IsDirty AndAlso ((Not prompt) OrElse MessageBoxAdv.Show("Να γίνει αποθήκευση αλλαγών?", "University of Ioannina", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
                Me.ScheduleControl1.DataSource.CommitChanges()
            End If
        End Sub

#End Region

#Region "menu handlers"

#Region "File Menu"

#Region "file|open calendar"
        Private Sub menuItem2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem2.Click
            CheckAndSaveIfNeeded(True)

            Dim dlg As OpenFileDialog = New OpenFileDialog()
            dlg.Title = "Open Schedule file"
            dlg.InitialDirectory = Environment.CurrentDirectory
            dlg.Filter = "Schedule files (*.schedule)|*.schedule|All files (*.*)|*.*"

            If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Try
                    Me.ScheduleControl1.DataSource = SimpleScheduleDataProvider.LoadBinary(dlg.FileName)
                    CType(Me.ScheduleControl1.DataSource, SimpleScheduleDataProvider).FileName = dlg.FileName
                Catch ex As Exception
                    MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
                    MessageBoxAdv.Show(ex.Message, "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Sub
#End Region

#Region "file|save calendar"
        Private Sub menuItem3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem3.Click
            If (CType(Me.ScheduleControl1.DataSource, SimpleScheduleDataProvider)).FileName = "newScheduleFile.schedule" Then
                'do a saveas for new file
                Me.menuItem25.PerformClick()
            Else
                CheckAndSaveIfNeeded(False)
            End If
        End Sub

#End Region

#Region "file|new calendar"
        Private Sub menuItem4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem4.Click
            CheckAndSaveIfNeeded(True)

            Dim scheduleProvider As SimpleScheduleDataProvider = New SimpleScheduleDataProvider()
            scheduleProvider.MasterList = New SimpleScheduleAppointmentList()
            scheduleProvider.FileName = "newScheduleFile.schedule"
            scheduleProvider.IsDirty = True
            Me.ScheduleControl1.DataSource = scheduleProvider

        End Sub

#End Region

#Region "File|Random data..."
        Private Sub menuItem26_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem26.Click
            CheckAndSaveIfNeeded(True)

            Dim dataProvider As SimpleScheduleDataProvider = New SimpleScheduleDataProvider()
            dataProvider.MasterList = SimpleScheduleDataProvider.InitializeRandomData()
            dataProvider.FileName = "random.schedule"

            Me.ScheduleControl1.DataSource = dataProvider
        End Sub

#End Region

#Region "File|SaveAs"
        Private Sub menuItem25_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem25.Click
            Dim saveFile As SaveFileDialog = New SaveFileDialog()
            saveFile.DefaultExt = "*.schedule"
            saveFile.FileName = (CType(Me.ScheduleControl1.DataSource, SimpleScheduleDataProvider)).FileName
            saveFile.Filter = "Schedule Files|*.schedule"

            ' get a file name from the user
            If saveFile.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Try
                    CType(Me.ScheduleControl1.DataSource, SimpleScheduleDataProvider).SaveBinary(saveFile.FileName)

                Catch ex As Exception
                    MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
                    MessageBoxAdv.Show(ex.Message, "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Sub

#End Region

#Region "File|Merge"
        Private Sub menuItem27_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem27.Click
            Dim dlg As OpenFileDialog = New OpenFileDialog()
            dlg.Title = "Merge Schedule file"
            dlg.InitialDirectory = Environment.CurrentDirectory
            dlg.Filter = "Schedule files (*.schedule)|*.schedule|All files (*.*)|*.*"

            If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Try
                    Dim mergeProvider As SimpleScheduleDataProvider = SimpleScheduleDataProvider.LoadBinary(dlg.FileName)
                    Dim dataProvider As SimpleScheduleDataProvider = CType(IIf(TypeOf Me.ScheduleControl1.DataSource Is SimpleScheduleDataProvider, Me.ScheduleControl1.DataSource, Nothing), SimpleScheduleDataProvider)
                    Me.ScheduleControl1.Calendar.BeginUpdate()
                    Dim item As SimpleScheduleAppointment
                    For Each item In mergeProvider.MasterList
                        dataProvider.AddItem(item)
                    Next item
                    dataProvider.MasterList.SortStartTime()
                    Me.ScheduleControl1.Calendar.EndUpdate()
                    Me.ScheduleControl1.ResetProvider(Me.ScheduleControl1.ScheduleType)
                Catch ex As Exception
                    MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
                    MessageBoxAdv.Show(ex.Message, "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Sub
#End Region

#Region "file|exit"
        Private Sub menuItem5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem5.Click
            CheckAndSaveIfNeeded(True)
            Me.Close()
        End Sub

#End Region
#End Region

#Region "Edit Menu"

#Region "handle enabling menus"

        Private Sub menuItem6_Popup(ByVal sender As Object, ByVal e As EventArgs)
            'enable or disable the menu item depending upon a 
            'selected schedule item like Edit and Delete
            Me.menuItem9.Enabled = Me.ScheduleControl1.ItemSelected
            Me.menuItem10.Enabled = Me.ScheduleControl1.ItemSelected
        End Sub

#End Region

#Region "Edit|NewItem"
        Private Sub menuItem7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem7.Click
            Me.ScheduleControl1.PerformNewItemClick()
        End Sub

#End Region

#Region "Edit New AllDay Item"
        Private Sub menuItem8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem8.Click
            Me.ScheduleControl1.PerformNewAllDayItemClick()
        End Sub

#End Region

#Region "Edit|Edit Item"
        Private Sub menuItem9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem9.Click
            Me.ScheduleControl1.PerformEditItemClick()

        End Sub

#End Region

#Region "Edit|Delete Item"
        Private Sub menuItem10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem10.Click
            Me.ScheduleControl1.PerformDeleteItemClick()
        End Sub

#End Region

#End Region

#Region "a Menu"

#Region "View|Day"
        Public Sub menuItem12_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem12.Click
            If Me.ScheduleControl1.ScheduleType <> ScheduleViewType.Day Then
                Me.ScheduleControl1.PerformSwitchToScheduleViewTypeClick(ScheduleViewType.Day)
            End If
        End Sub

#End Region

#Region "View|WorkWeek"
        Private Sub menuItem13_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem13.Click
            If Me.ScheduleControl1.ScheduleType <> ScheduleViewType.WorkWeek Then
                Me.ScheduleControl1.PerformSwitchToScheduleViewTypeClick(ScheduleViewType.WorkWeek)
            End If
        End Sub
#End Region

#Region "View|Week"
        Private Sub menuItem14_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem14.Click
            If Me.ScheduleControl1.ScheduleType <> ScheduleViewType.Week Then
                Me.ScheduleControl1.PerformSwitchToScheduleViewTypeClick(ScheduleViewType.Week)
            End If
        End Sub
#End Region

#Region "View|Month"

        Private Sub menuItem15_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem15.Click
            If Me.ScheduleControl1.ScheduleType <> ScheduleViewType.Month Then
                Me.ScheduleControl1.PerformSwitchToScheduleViewTypeClick(ScheduleViewType.Month)
            End If
        End Sub
#End Region

#End Region

#Region "Options Menu"

#Region "Options | Appearance"



        'Options|Appearance|Load
        Private Sub menuItem41_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem41.Click
            Dim dlg As OpenFileDialog = New OpenFileDialog()
            dlg.Title = "Open Appearance file"
            dlg.InitialDirectory = Environment.CurrentDirectory
            dlg.Filter = "Appearance files (*.appearance)|*.appearance|All files (*.*)|*.*"

            If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Try
                    Dim appearance As ScheduleAppearance = ScheduleAppearance.LoadBinary(dlg.FileName)
                    appearance.AttachSchedule(Me.ScheduleControl1)
                Catch ex As Exception
                    MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
                    MessageBoxAdv.Show(ex.Message, "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Sub
        'Options|Appearance|Save
        Private Sub menuItem42_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem42.Click
            Dim saveFile As SaveFileDialog = New SaveFileDialog()
            saveFile.DefaultExt = "*.appearance"
            saveFile.FileName = ""
            saveFile.Filter = "Appearance Files|*.appearance"

            ' get a file name from the user
            If saveFile.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Try
                    Me.ScheduleControl1.Appearance.SaveBinary(saveFile.FileName)
                Catch ex As Exception
                    MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
                    MessageBoxAdv.Show(ex.Message, "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Sub

#End Region

#Region " Options|Week Numbers"
        Private Sub menuItem20_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem20.Click
            Me.ScheduleControl1.Calendar.ShowWeekNumbers = Not Me.ScheduleControl1.Calendar.ShowWeekNumbers
            Me.menuItem20.Checked = Me.ScheduleControl1.Calendar.ShowWeekNumbers
        End Sub

#End Region

#Region " Options|Show Additional Panel"
        Private p As Panel
        Private Sub menuItem21_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem21.Click
            Me.menuItem21.Checked = Not Me.menuItem21.Checked
            If Me.menuItem21.Checked Then
                p = New Panel()
                p.BackColor = Color.Blue
                p.Dock = DockStyle.Fill
                Me.ScheduleControl1.NavigationPanel.Controls.Add(p)
            Else
                Me.ScheduleControl1.NavigationPanel.Controls.Remove(p)
                p.Dispose()
                p = Nothing
            End If
        End Sub

#Region "Options|NavigationPanel"

        Private Sub menuItem22_Popup(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem22.Popup
            menuItem29.Checked = False
            menuItem30.Checked = False
            menuItem31.Checked = False
            Select Case Me.ScheduleControl1.NavigationPanelPosition
                Case CalendarNavigationPanelPosition.Hidden
                    menuItem29.Checked = True
                Case CalendarNavigationPanelPosition.Left
                    menuItem30.Checked = True
                Case CalendarNavigationPanelPosition.Right
                    menuItem31.Checked = True
            End Select
        End Sub


        'Options|NavigationPanel|Hidden
        Private Sub menuItem29_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem29.Click
            Me.ScheduleControl1.SetNavigationPanelPosition(CalendarNavigationPanelPosition.Hidden)
        End Sub
        'Options|NavigationPanel|Left
        Private Sub menuItem30_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem30.Click
            Me.ScheduleControl1.SetNavigationPanelPosition(CalendarNavigationPanelPosition.Left)
        End Sub
        'Options|NavigationPanel|Right
        Private Sub menuItem31_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem31.Click
            Me.ScheduleControl1.SetNavigationPanelPosition(CalendarNavigationPanelPosition.Right)
        End Sub

#End Region

#Region "Options|Culture"
        'set checks on popup
        Private Sub menuItem18_Popup(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem18.Popup
            menuItem32.Checked = False
            menuItem33.Checked = False
            menuItem34.Checked = False
            menuItem35.Checked = False
            menuItem36.Checked = False
            menuItem37.Checked = False

            If Me.ScheduleControl1.Culture.DisplayName = CultureInfo.InvariantCulture.DisplayName Then
                menuItem32.Checked = True
            ElseIf Me.ScheduleControl1.Culture.Name = Application.CurrentCulture.Name Then
                menuItem33.Checked = True
            End If

            If Me.ScheduleControl1.Culture.Name = "fr-FR" Then
                menuItem34.Checked = True
            ElseIf Me.ScheduleControl1.Culture.Name = "it-IT" Then
                menuItem35.Checked = True
            ElseIf Me.ScheduleControl1.Culture.Name = "en-US" Then
                menuItem36.Checked = True
            ElseIf Me.ScheduleControl1.Culture.Name = "de-DE" Then
                menuItem37.Checked = True
            End If
        End Sub

        'Options|Culture|Invariant
        Private Sub menuItem32_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem32.Click
            Me.ScheduleControl1.Culture = CultureInfo.InvariantCulture
        End Sub

        'Options|Culture|Application
        Private Sub menuItem33_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem33.Click
            Me.ScheduleControl1.Culture = Application.CurrentCulture
        End Sub

        'Options|Culture|IT
        Private Sub menuItem34_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem34.Click
            Me.ScheduleControl1.Culture = CultureInfo.CreateSpecificCulture("fr-FR")
        End Sub

        'Options|Culture|FR
        Private Sub menuItem35_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem35.Click
            Me.ScheduleControl1.Culture = CultureInfo.CreateSpecificCulture("it-IT")
        End Sub

        'Options|Culture|US
        Private Sub menuItem36_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem36.Click
            Me.ScheduleControl1.Culture = CultureInfo.CreateSpecificCulture("en-US")
        End Sub
        'Options|Culture|DE
        Private Sub menuItem37_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem37.Click
            Me.ScheduleControl1.Culture = CultureInfo.CreateSpecificCulture("de-DE")
        End Sub
#End Region

#Region "Options | Save On Close Behavior"

        'display check
        Private Sub menuItem28_Popup(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem28.Popup
            menuItem38.Checked = False
            menuItem39.Checked = False
            menuItem40.Checked = False
            Select Case Me.ScheduleControl1.DataSource.SaveOnCloseBehaviorAction
                Case SaveOnCloseBehavior.DoNotSave
                    menuItem38.Checked = True
                Case SaveOnCloseBehavior.PromptBeforeSave
                    menuItem39.Checked = True
                Case SaveOnCloseBehavior.SaveWithoutPrompt
                    menuItem40.Checked = True
            End Select
        End Sub

        'Options|SaveOnCloseBehavior|Do Not Save
        Private Sub menuItem38_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem38.Click
            Me.ScheduleControl1.DataSource.SaveOnCloseBehaviorAction = SaveOnCloseBehavior.DoNotSave
        End Sub
        'Options|SaveOnCloseBehavior|Propmt Before Saving
        Private Sub menuItem39_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem39.Click
            Me.ScheduleControl1.DataSource.SaveOnCloseBehaviorAction = SaveOnCloseBehavior.PromptBeforeSave
        End Sub
        'Options|SaveOnCloseBehavior|Save Without Prompt
        Private Sub menuItem40_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem40.Click
            Me.ScheduleControl1.DataSource.SaveOnCloseBehaviorAction = SaveOnCloseBehavior.SaveWithoutPrompt
        End Sub
#End Region



#End Region



#End Region



#End Region

        Private Sub MenuItem43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem43.Click
            Me.ScheduleControl1.EnableAlerts = Not Me.ScheduleControl1.EnableAlerts
            Me.MenuItem43.Checked = Me.ScheduleControl1.EnableAlerts
        End Sub

        Private Sub MenuItem44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem44.Click
            Dim dataProvider As SimpleScheduleDataProvider = Me.ScheduleControl1.DataSource
            If dataProvider Is Nothing Or dataProvider.MasterList.Count < 4 Then
                Me.menuItem26.PerformClick()
            End If
            'change to day
            Me.ScheduleControl1.SwitchToScheduleViewTypeDay(DateTime.Now)


            'enable alerts
            Me.ScheduleControl1.EnableAlerts = True
        End Sub

        Private form As AppointmentForm

        ''' <summary>
        ''' Raise the event when showing the appointment form
        ''' </summary>
        Private Sub scheduleControl1_ShowingAppointmentForm(ByVal sender As Object, ByVal e As ShowingAppointFormEventArgs)
            'Cancel the default appointform for schedule control
            e.Cancel = True
            'Shows the Custom appointment form
            form.ShowDialog()
        End Sub
        Private Sub calendnar_load(sender As Object, e As EventArgs) Handles MyBase.Load
            Me.ScheduleControl1.Culture = CultureInfo.CreateSpecificCulture("el-GR")
        End Sub

        Private Sub GunaTextBox1_TextChanged(sender As Object, e As EventArgs)

        End Sub

        Private Sub Button1_Click(sender As Object, e As EventArgs)

        End Sub

        Private Sub Button2_Click(sender As Object, e As EventArgs)

        End Sub

        Private WithEvents menuItem2 As MenuItem
        Private WithEvents menuItem4 As MenuItem
        Private WithEvents menuItem3 As MenuItem
        Private WithEvents menuItem25 As MenuItem
        Private WithEvents menuItem27 As MenuItem
        Private WithEvents menuItem26 As MenuItem
        Private WithEvents menuItem5 As MenuItem
        Private WithEvents menuItem1 As MenuItem
        Private WithEvents menuItem7 As MenuItem
        Private WithEvents menuItem8 As MenuItem
        Private WithEvents menuItem9 As MenuItem
        Private WithEvents menuItem10 As MenuItem
        Private WithEvents menuItem6 As MenuItem
        Private WithEvents menuItem11 As MenuItem
        Private WithEvents menuItem19 As MenuItem
        Private WithEvents menuItem41 As MenuItem
        Private WithEvents menuItem42 As MenuItem
        Private WithEvents menuItem17 As MenuItem
        Private WithEvents menuItem32 As MenuItem
        Private WithEvents menuItem33 As MenuItem
        Private WithEvents menuItem34 As MenuItem
        Private WithEvents menuItem35 As MenuItem
        Private WithEvents menuItem36 As MenuItem
        Private WithEvents menuItem37 As MenuItem
        Private WithEvents menuItem18 As MenuItem
        Private WithEvents menuItem29 As MenuItem
        Private WithEvents menuItem30 As MenuItem
        Private WithEvents menuItem31 As MenuItem
        Private WithEvents menuItem22 As MenuItem
        Private WithEvents menuItem38 As MenuItem
        Private WithEvents menuItem39 As MenuItem
        Private WithEvents menuItem40 As MenuItem
        Private WithEvents menuItem28 As MenuItem
        Private WithEvents menuItem20 As MenuItem
        Friend WithEvents MenuItem43 As MenuItem
        Private WithEvents menuItem21 As MenuItem
        Friend WithEvents MenuItem44 As MenuItem
        Private WithEvents menuItem16 As MenuItem
        Private WithEvents menuItem24 As MenuItem
        Private WithEvents menuItem23 As MenuItem
        Public WithEvents mainMenu1 As MainMenu

        Private Sub splitButton2_Click(sender As Object, e As EventArgs)



        End Sub

        Friend WithEvents GunaTransition1 As Guna.UI.WinForms.GunaTransition
        Friend WithEvents GunaAdvenceButton1 As Guna.UI.WinForms.GunaAdvenceButton

        Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
            Try
                GunaTransition1.ShowSync(weekMenu)
            Catch ex As Exception
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
                MessageBoxAdv.Show(ex.Message, "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Public WithEvents menuItem12 As MenuItem
        Public WithEvents ScheduleControl1 As ScheduleControl
        Public WithEvents menuItem13 As MenuItem
        Public WithEvents menuItem14 As MenuItem
        Public WithEvents menuItem15 As MenuItem
        Friend WithEvents GunaAdvenceButton2 As Guna.UI.WinForms.GunaAdvenceButton

        Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton2.Click
            Try
                Me.ScheduleControl1.PerformNewItemClick()
            Catch ex As Exception
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
                MessageBoxAdv.Show(ex.Message, "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub calendar_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
            'If MessageBox.Show("Αποθήκευση Αλλαγών?", Name & " Αλλαγή.", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            If (CType(Me.ScheduleControl1.DataSource, SimpleScheduleDataProvider)).FileName = "newScheduleFile.schedule" Then
                'do a saveas for new file
                Me.menuItem25.PerformClick()
            Else
                CheckAndSaveIfNeeded(True)
            End If
            ' End If
        End Sub

        Friend WithEvents GunaButton2 As Guna.UI.WinForms.GunaButton

        Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
            Try
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro

                If MessageBoxAdv.Show("Θέλετε να γίνει αποθήκευση των αλλαγών?", "University of Ioannina", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    If (CType(Me.ScheduleControl1.DataSource, SimpleScheduleDataProvider)).FileName = "newScheduleFile.schedule" Then
                        'do a saveas for new file
                        Me.menuItem25.PerformClick()
                    Else
                        CheckAndSaveIfNeeded(False)
                    End If
                End If
            Catch ex As Exception
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
                MessageBoxAdv.Show(ex.Message, "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
        Friend WithEvents GunaSeparator1 As Guna.UI.WinForms.GunaSeparator
        Dim flagMenuNav As Boolean = False
        Private Sub GunaButton1_Click(sender As Object, e As EventArgs)

        End Sub

        Friend WithEvents GunaAdvenceButton3 As Guna.UI.WinForms.GunaAdvenceButton

        Private Sub GunaAdvenceButton3_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton3.Click
            Try
                If flagMenuNav = False Then
                    Me.ScheduleControl1.SetNavigationPanelPosition(CalendarNavigationPanelPosition.Left)
                    flagMenuNav = True
                Else
                    Me.ScheduleControl1.SetNavigationPanelPosition(CalendarNavigationPanelPosition.Hidden)
                    flagMenuNav = False
                End If
            Catch ex As Exception
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
                MessageBoxAdv.Show(ex.Message, "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub GunaPictureBox1_Click(sender As Object, e As EventArgs) Handles GunaPictureBox1.Click

        End Sub

        Friend WithEvents GunaAdvenceButton4 As Guna.UI.WinForms.GunaAdvenceButton

        Private Sub GunaAdvenceButton4_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton4.Click
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro

            If MessageBoxAdv.Show("Θέλετε να δημιουργήσετε νέο Ημερολόγιο?", "University of Ioannina", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                CheckAndSaveIfNeeded(True)

                Dim scheduleProvider As SimpleScheduleDataProvider = New SimpleScheduleDataProvider()
                scheduleProvider.MasterList = New SimpleScheduleAppointmentList()
                scheduleProvider.FileName = "newScheduleFile.schedule"
                scheduleProvider.IsDirty = True
                Me.ScheduleControl1.DataSource = scheduleProvider
            End If
        End Sub

        Friend WithEvents GunaAdvenceButton5 As Guna.UI.WinForms.GunaAdvenceButton

        Private Sub GunaAdvenceButton5_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton5.Click

            CheckAndSaveIfNeeded(True)

            Dim dlg As OpenFileDialog = New OpenFileDialog()
            dlg.Title = "Open Schedule file"
            dlg.InitialDirectory = Environment.CurrentDirectory
            dlg.Filter = "Schedule files (*.schedule)|*.schedule|All files (*.*)|*.*"

            If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Try
                    Me.ScheduleControl1.DataSource = SimpleScheduleDataProvider.LoadBinary(dlg.FileName)
                    CType(Me.ScheduleControl1.DataSource, SimpleScheduleDataProvider).FileName = dlg.FileName
                    Label1.Text = dlg.SafeFileName
                Catch ex As Exception
                    MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
                    MessageBoxAdv.Show(ex.Message, "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If

        End Sub

        Friend WithEvents Label1 As Label

        Private Sub ScheduleControl1_Load(sender As Object, e As EventArgs) Handles ScheduleControl1.Load

        End Sub
    End Class
End Namespace



