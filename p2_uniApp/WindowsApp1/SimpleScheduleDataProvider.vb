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


Namespace GridScheduleSample
#Region "simple data provider - concrete implementations of IScheduleDataProvider, IScheduleAppointmentList, IScheduleAppointment"

    ''' <summary>
    ''' Derives <see cref="ScheduleDataProvider"/> to implement <see cref="IScheduleDataProvider"/>.
    ''' </summary>
    ''' <remarks>
    ''' This implementation of IScheduleDataProvider uses a collection of <see cref="SimpleScheduleAppointment"/>
    ''' objects to hold the items displayed in the schedule. This collection is serialized to disk as a 
    ''' binary file. The serialization is restricted to the SimpleScheduleDataProvider.MasterList and the
    ''' SimpleScheduleAppointment objects that it holds. 
    ''' </remarks>
    Public Class SimpleScheduleDataProvider : Inherits ScheduleDataProvider

        Public Shared list As ListObjectList
        'INSTANT VB NOTE: The variable markerList was renamed since Visual Basic does not allow class members with the same name:
        Public Shared markerList_Renamed As ListObjectList
        'INSTANT VB NOTE: The variable reminderList was renamed since Visual Basic does not allow class members with the same name:
        Public Shared reminderList_Renamed As ListObjectList
        'INSTANT VB NOTE: The variable locationList was renamed since Visual Basic does not allow class members with the same name:
        Public Shared locationList_Renamed As ListObjectList

        Public Sub New()
            MyBase.New()
        End Sub

        Private fileName_Renamed As String

        Public Property FileName() As String
            Get
                Return fileName_Renamed
            End Get
            Set(ByVal value As String)
                fileName_Renamed = Value
            End Set
        End Property

        Private masterList_Renamed As SimpleScheduleAppointmentList
        Public Overrides Function GetLabels() As ILookUpObjectList
            Return List
        End Function

        Public Overrides Function GetLocations() As ILookUpObjectList
            Return locationList_Renamed
        End Function

        Public Overrides Function GetMarkers() As ILookUpObjectList
            Return markerList_Renamed
        End Function


        Public Overrides Function GetReminders() As ILookUpObjectList
            Return reminderList_Renamed
        End Function

        Public Overrides Sub InitLists()
            List = New ListObjectList()
            list.Add(New ListObject(0, "Κενό", Color.Black))
            list.Add(New ListObject(1, "Σημαντικό", Color.Red))
            list.Add(New ListObject(2, "Επαγγελματικο", Color.Purple))
            list.Add(New ListObject(3, "Προσωπικό", Color.Tomato))
            list.Add(New ListObject(4, "Διακοπές", Color.Pink))
            list.Add(New ListObject(5, "Υποχρεωτικό", Color.YellowGreen))
            list.Add(New ListObject(6, "’θληση", Color.Violet))
            list.Add(New ListObject(7, "Προετοιμασία", Color.Tomato))
            list.Add(New ListObject(8, "Εξετάσεις", Color.SpringGreen))

            list.Add(New ListObject(9, "Τηλεφώνημα", Color.RosyBrown))


            markerList_Renamed = New ListObjectList()
            markerList_Renamed.Add(New ListObject(0, "Ελέυθερο", Color.FromArgb(50, Color.Yellow))) '//same as noMarkColor
            markerList_Renamed.Add(New ListObject(1, "Ληξηπρόθεσμο", Color.YellowGreen))
            markerList_Renamed.Add(New ListObject(2, "Απασχολημένος", Color.Violet))
            markerList_Renamed.Add(New ListObject(3, "Εκτός Γραφείου", Color.Tomato))

            reminderList_Renamed = New ListObjectList()
            reminderList_Renamed.Add(New ListObject(0, "0 λεπτά", Color.Purple))
            reminderList_Renamed.Add(New ListObject(1, "5 λεπτά", Color.Purple))
            reminderList_Renamed.Add(New ListObject(2, "10 λεπτά", Color.Purple))
            reminderList_Renamed.Add(New ListObject(3, "15 λεπτά", Color.Purple))
            reminderList_Renamed.Add(New ListObject(4, "30 λεπτά", Color.Purple))
            reminderList_Renamed.Add(New ListObject(5, "1 ώρα", Color.Purple))
            reminderList_Renamed.Add(New ListObject(6, "2 ώρες", Color.Purple))
            reminderList_Renamed.Add(New ListObject(7, "3 ώρες", Color.Purple))
            reminderList_Renamed.Add(New ListObject(8, "4 ώρες", Color.Purple))
            reminderList_Renamed.Add(New ListObject(9, "5 ώρες", Color.Purple))
            reminderList_Renamed.Add(New ListObject(10, "6 ώρες", Color.Purple))
            reminderList_Renamed.Add(New ListObject(11, "7 ώρες", Color.Purple))
            reminderList_Renamed.Add(New ListObject(12, "8 ώρες", Color.Purple))
            reminderList_Renamed.Add(New ListObject(13, "9 ώρες", Color.Purple))
            reminderList_Renamed.Add(New ListObject(14, "10 ώρες", Color.Purple))
            reminderList_Renamed.Add(New ListObject(15, "11 ώρες", Color.Purple))
            reminderList_Renamed.Add(New ListObject(16, "12 ώρες", Color.Purple))
            reminderList_Renamed.Add(New ListObject(17, "18 ώρες", Color.Purple))

            locationList_Renamed = New ListObjectList()
            locationList_Renamed.Add(New ListObject(0, String.Empty, Color.Purple))
            locationList_Renamed.Add(New ListObject(1, "RoomB", Color.Red))
            locationList_Renamed.Add(New ListObject(2, "RoomC", Color.Purple))
            locationList_Renamed.Add(New ListObject(3, "RoomD", Color.RosyBrown))
            locationList_Renamed.Add(New ListObject(4, "RoomE", Color.PowderBlue))
        End Sub

        ''' <summary>
        ''' Get or sets an IScheduleAppointmentList collection that holds the IScheduleAppointments. 
        ''' </summary>
        Public Property MasterList() As SimpleScheduleAppointmentList
            Get
                Return masterList_Renamed
            End Get
            Set(ByVal value As SimpleScheduleAppointmentList)
                masterList_Renamed = Value
            End Set
        End Property

#Region "random data"

        ''' <summary>
        ''' A static method that provides random data, not really a part of the implementations.
        ''' </summary>
        ''' <returns>A SimpleScheduleAppointmentList object holding sample data.</returns>
        Public Shared Function InitializeRandomData() As SimpleScheduleAppointmentList
            'int tc = Environment.TickCount;
            'int tc = 26260100;// simple spread 
            Dim tc As Integer = 28882701 ' split the appointment across midnight & 3 items at 8am on 2 days ago

            Console.WriteLine("Random seed: {0}", tc)
            Dim r As Random = New Random(tc)
            Dim r1 As Random = New Random(tc)

            ' set the number of sample items ou want in this list.
            'int count = r.Next(20) + 4;
            Dim count As Integer = 400 '2000;//200;//30;

            'INSTANT VB NOTE: The local variable masterList was renamed since Visual Basic will not uniquely identify class members when local variables have the same name:
            Dim masterList_Renamed As SimpleScheduleAppointmentList = New SimpleScheduleAppointmentList()
            Dim now As DateTime = DateTime.Now.Date

            Dim i As Integer = 0
            'ORIGINAL LINE: for(int i = 0; i < count; i += 1)
            'INSTANT VB NOTE: This 'for' loop was translated to a VB 'Do While' loop:
            Do While i < count
                Dim item As ScheduleAppointment = CType(IIf(TypeOf masterList_Renamed.NewScheduleAppointment() Is ScheduleAppointment, masterList_Renamed.NewScheduleAppointment(), Nothing), ScheduleAppointment)

               


                Dim dayOffSet As Integer = 30 - r.Next(60)

                Dim hourOffSet As Integer = 24 - r.Next(48)

                Dim len As Integer = 30 * (r.Next(4) + 1)
                item.StartTime = now.AddDays(CDbl(dayOffSet)).AddHours(CDbl(hourOffSet))

                item.EndTime = item.StartTime.AddMinutes(CDbl(len))
                item.Subject = String.Format("subject{0}", i)
                item.Content = String.Format("content{0}", i)
                item.LabelValue = IIf(r1.Next(10) < 3, 0, r1.Next(10))
                item.LocationValue = String.Format("location{0}", r1.Next(5))

                item.ReminderValue = IIf(r1.Next(10) < 5, 0, r1.Next(12))
                item.Reminder = r1.Next(10) > 1
                item.AllDay = r1.Next(10) < 1


                item.MarkerValue = r1.Next(4)
                item.Dirty = False
                masterList_Renamed.Add(item)
                i += 1
            Loop

            'DisplayList("Before Sort", masterList);
            masterList_Renamed.SortStartTime()
            'DisplayList("After Sort", masterList);

            Return masterList_Renamed
        End Function

        Private Shared Sub DisplayList(ByVal title As String, ByVal list As ScheduleAppointmentList)
#If console Then
			Console.WriteLine("*************" & title)
			For Each item As ScheduleAppointment In list
				Console.WriteLine(item)
			Next item
#End If
        End Sub
#End Region

#Region "base class overrides"

        ''' <summary>
        ''' Returns a the subset of MasterList between the 2 dates.
        ''' </summary>
        ''' <param name="startDate">Starting date limit for the returned items.</param>
        ''' <param name="endDate">Ending date limit for the returned items.</param>
        ''' <returns>Returns a the subset of MasterList.</returns>
        Public Overloads Overrides Function GetSchedule(ByVal startDate As DateTime, ByVal endDate As DateTime) As IScheduleAppointmentList
            Dim list As ScheduleAppointmentList = New ScheduleAppointmentList
            Dim start As DateTime = startDate.Date
            'INSTANT VB NOTE: The local variable end was renamed since it is a keyword in VB:
            Dim end_Renamed As DateTime = endDate.Date
            Dim item As ScheduleAppointment
            For Each item In Me.MasterList
                'item.EndTime.AddMinutes(-1) is to make sure an item that ends at 
                'midnight is not shown on the next days calendar

                If (item.StartTime.Date >= start AndAlso item.StartTime.Date <= end_Renamed) OrElse (item.EndTime.AddMinutes(-1).Date > start AndAlso item.EndTime.Date <= end_Renamed) Then
                    list.Add(item)
                End If
            Next item
            list.SortStartTime()
            'DisplayList(string.Format("************dates between {0} and {1}", startDate, endDate), list);
            Return list
        End Function
       
        ''' <summary>
        ''' Returns a the subset of MasterList between the 2 dates.
        ''' </summary>
        ''' <param name="day">Date for the returned items.</param>
        ''' <returns>Returns a the subset of MasterList.</returns>
        Public Overloads Overrides Function GetScheduleForDay(ByVal day As DateTime) As IScheduleAppointmentList
            Dim list As ScheduleAppointmentList = New ScheduleAppointmentList
            day = day.Date
            Dim item As ScheduleAppointment
            For Each item In Me.MasterList
                'do not want anything that ends at 12AM on the day
                If item.StartTime.Date = day OrElse (item.EndTime.Date = day AndAlso item.EndTime > day) Then
                    list.Add(item)
                End If
            Next item

            'DisplayList(string.Format("*************day {0}", day), list);
            Return list
        End Function

        ''' <summary>
        ''' Saves the MasterList as a diskfile.
        ''' </summary>
        Public Overrides Sub CommitChanges()
            SaveBinary(FileName)
            Me.IsDirty = False
        End Sub

        ''' <summary>
        ''' Gets or sets whether the MasterList has been modified.
        ''' </summary>
        Public Overrides Property IsDirty() As Boolean
            Get
                Dim val As Boolean = MyBase.IsDirty
                If (Not val) Then 'if no global setting marked list as dirty, check individual items
                    Dim item As ScheduleAppointment
                    For Each item In Me.MasterList
                        If item.Dirty Then
                            val = True
                            Exit For
                        End If
                    Next item
                End If
                Return val
            End Get
            Set(ByVal Value As Boolean)
                MyBase.IsDirty = Value
            End Set
        End Property


        ''' <summary>
        ''' Saves the current <see cref="MasterList"/> object in binary format to a file 
        ''' with the specified filename.
        ''' </summary>
        'INSTANT VB NOTE: The parameter fileName was renamed since Visual Basic will not uniquely identify class members when parameters have the same name:
        Public Sub SaveBinary(ByVal fileName_Renamed As String)
            Dim s As Stream = File.Create(fileName_Renamed)
            SaveBinary(s)
            s.Close()
        End Sub

        ''' <summary>
        ''' Saves the current <see cref="MasterList"/> object to a stream in binary format.
        ''' </summary>
        Public Sub SaveBinary(ByVal s As Stream)
            Dim b As BinaryFormatter = New BinaryFormatter
            b.AssemblyFormat = FormatterAssemblyStyle.Simple
            b.Serialize(s, Me.MasterList)
        End Sub


        ''' <summary>
        ''' Creates an instance of <see cref="SimpleScheduleDataProvider"/> and loads 
        ''' a previously serialized MasterList into the instance.
        ''' </summary>
        ''' <param name="fileName">The serialized filename.</param>
        ''' <returns>A SimpleScheduleDataProvider.</returns>
        ''' <remarks>
        ''' This method uses <see cref="AppDomain.CurrentDomain.AssemblyResolve"/> to 
        ''' avoid versioning issues with the binary serialization of the MasterList.
        ''' </remarks>
        'INSTANT VB NOTE: The parameter fileName was renamed since Visual Basic will not uniquely identify class members when parameters have the same name:
        Public Shared Function LoadBinary(ByVal fileName_Renamed As String) As SimpleScheduleDataProvider
            Dim t As SimpleScheduleDataProvider = New SimpleScheduleDataProvider
            Dim s As Stream = File.OpenRead(fileName_Renamed)
            Try
                AddHandler AppDomain.CurrentDomain.AssemblyResolve, AddressOf Syncfusion.ScheduleWindowsAssembly.AssemblyResolver
                Dim b As BinaryFormatter = New BinaryFormatter
                b.AssemblyFormat = FormatterAssemblyStyle.Simple
                Dim obj As Object = b.Deserialize(s)
                t.MasterList = CType(IIf(TypeOf obj Is SimpleScheduleAppointmentList, obj, Nothing), SimpleScheduleAppointmentList)

            Finally
                s.Close()
                RemoveHandler AppDomain.CurrentDomain.AssemblyResolve, AddressOf Syncfusion.ScheduleWindowsAssembly.AssemblyResolver
            End Try
            Return t
        End Function

        ''' <summary>
        ''' Overridden to return a <see cref="SimpleScheduleAppointment"/>.
        ''' </summary>
        ''' <returns></returns>
        Public Overrides Function NewScheduleAppointment() As IScheduleAppointment
            Return New SimpleScheduleAppointment
        End Function

        ''' <summary>
        ''' Overridden to add the item to the MasterList.
        ''' </summary>
        ''' <param name="item">IScheduleAppointment item to be added.</param>
        Public Overrides Sub AddItem(ByVal item As IScheduleAppointment)
            Me.MasterList.Add(item)
        End Sub

        ''' <summary>
        ''' Overridden to remove the item from the MasterList.
        ''' </summary>
        ''' <param name="item">IScheduleAppointment item to be removed.</param>
        Public Overrides Sub RemoveItem(ByVal item As IScheduleAppointment)
            Me.MasterList.Remove(item)
        End Sub
#End Region
    End Class

    ''' <summary>
    ''' Derives <see cref="ScheduleAppointmentList"/> to implement IScheduleAppointmentList.
    ''' </summary>
    <Serializable()> _
    Public Class SimpleScheduleAppointmentList : Inherits ScheduleAppointmentList : Implements ISerializable
#Region "ISerializable Members"

#Region "ISerializable Members"

        ''' <summary>
        ''' Used in serialization.
        ''' </summary>
        ''' <param name="info"> The SerializationInfo.</param>
        ''' <param name="context">The StreamingContext.</param>
        Protected Overridable Sub GetObjectData(ByVal info As SerializationInfo, ByVal context As StreamingContext) Implements ISerializable.GetObjectData
            ' GetObjectDatae(info, context)
            info.AddValue("List", Me.List)
        End Sub

#End Region


        ''' <summary>
        ''' Override to control serialization.
        ''' </summary>
        ''' <param name="info"> The SerializationInfo.</param>
        ''' <param name="context">The StreamingContext.</param>
        'Protected Overridable Sub GetObjectDatae(ByVal info As SerializationInfo, ByVal context As StreamingContext) 'Implements ISerializable.GetObjectData
        '    info.AddValue("List", Me.List)
        'End Sub


#End Region

        ''' <summary>
        ''' Used in serialization.
        ''' </summary>
        ''' <param name="info"> The SerializationInfo.</param>
        ''' <param name="context">The StreamingContext.</param>
        Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
            Me.List = CType(info.GetValue("List", GetType(ArrayList)), ArrayList)
        End Sub

        ''' <summary>
        ''' Default constructor.
        ''' </summary>
        Public Sub New()
            MyBase.New()

        End Sub

        ''' <summary>
        ''' Overridden to return a <see cref="SimpleScheduleAppointment"/>.
        ''' </summary>
        ''' <returns>A SimpleScheduleAppointment.</returns>
        Public Overrides Function NewScheduleAppointment() As IScheduleAppointment
            Return New SimpleScheduleAppointment()
        End Function


    End Class

    ''' <summary>
    ''' Derives <see cref="ScheduleAppointment"/> to implement IScheduleAppointment.
    ''' </summary>
    <Serializable()> _
    Public Class SimpleScheduleAppointment : Inherits ScheduleAppointment : Implements ISerializable
#Region "ISerializable Members"

        ''' <summary>
        ''' Default constructor.
        ''' </summary>
        Public Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        ''' Overridden to handle serilaization.
        ''' </summary>
        ''' <param name="info">The SerialazationInfo.</param>
        ''' <param name="context">The StreamingContext.</param>
        Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
            Me.UniqueID = CInt(info.GetValue("UniqueID", GetType(Integer)))
            Me.Subject = CStr(info.GetValue("Subject", GetType(String)))
            Me.StartTime = CDate(info.GetValue("StartTime", GetType(DateTime)))
            Me.ReminderValue = CInt(info.GetValue("ReminderValue", GetType(Integer)))
            Me.Reminder = CBool(info.GetValue("Reminder", GetType(Boolean)))
            Me.Owner = CInt(info.GetValue("Owner", GetType(Integer)))
            Me.MarkerValue = CInt(info.GetValue("MarkerValue", GetType(Integer)))
            Me.LocationValue = CStr(info.GetValue("LocationValue", GetType(String)))
            Me.LabelValue = CInt(info.GetValue("LabelValue", GetType(Integer)))
            Me.EndTime = CDate(info.GetValue("EndTime", GetType(DateTime)))
            Me.Content = CStr(info.GetValue("Content", GetType(String)))
            Me.AllDay = CBool(info.GetValue("AllDay", GetType(Boolean)))

            Me.Dirty = False
        End Sub

        ''' <summary>
        ''' Handle serilaization.
        ''' </summary>
        ''' <param name="info">The SerialazationInfo.</param>
        ''' <param name="context">The StreamingContext.</param>
        Public Sub GetObjectData(ByVal info As SerializationInfo, ByVal context As StreamingContext) Implements ISerializable.GetObjectData
            info.AddValue("UniqueID", Me.UniqueID)
            info.AddValue("Subject", Me.Subject)
            info.AddValue("StartTime", Me.StartTime)
            info.AddValue("ReminderValue", Me.ReminderValue)
            info.AddValue("Reminder", Me.Reminder)
            info.AddValue("Owner", Me.Owner)
            info.AddValue("MarkerValue", Me.MarkerValue)
            info.AddValue("LocationValue", Me.LocationValue)
            info.AddValue("LabelValue", Me.LabelValue)
            info.AddValue("EndTime", Me.EndTime)
            info.AddValue("Content", Me.Content)
            info.AddValue("AllDay", Me.AllDay)

            'info.AddValue("Tag", this.Tag); assume Tag not serializable in this implemetation
        End Sub

#End Region

    End Class


#End Region

End Namespace
