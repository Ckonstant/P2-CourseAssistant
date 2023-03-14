Imports LiveCharts
Imports LiveCharts.Defaults
Imports LiveCharts.Wpf
Imports System.Data.SqlClient
Imports System.Text
Imports System.Linq ' need to add 
Imports System.Windows.Media
Imports System.IO
Imports System.Drawing.Color
Imports Syncfusion.WinForms.DataGrid.Events
Imports Syncfusion.WinForms.DataGrid
Imports Syncfusion.WinForms.DataGrid.Styles
Imports System.Windows.Forms
Imports Syncfusion.WinForms.DataGrid.Enums
Imports Syncfusion.Windows.Forms
Imports System.Web
Imports System.Net.NetworkInformation
Imports System.Net
Imports System.Threading
Imports VB = Microsoft.VisualBasic
Imports System.ComponentModel
Imports System.IO.Compression
Imports System.Collections.Specialized

Public Class Form4
    Private currentForm As Form = Nothing


    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub GunaAdvenceTileButton10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaShadowPanel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub GunaAdvenceButton7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaAdvenceTileButton1_Click(sender As Object, e As EventArgs)

    End Sub
    Private Function DirSize(ByVal path As String) As Long
        Dim sz As Long = 0
        Dim d As DirectoryInfo = New DirectoryInfo(path)
        ' get file length
        Dim f As FileInfo
        For Each f In d.GetFiles()
            sz += f.Length
        Next
        ' recurse into directories
        Dim dx As DirectoryInfo
        For Each dx In d.GetDirectories()
            sz += DirSize(dx.FullName)
        Next
        Return sz
    End Function
    Private Sub GunaAdvenceTileButton1_MouseHover(sender As Object, e As EventArgs)

    End Sub




    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not Directory.Exists(My.Application.Info.DirectoryPath + "\FULLDATA\") Then
            Directory.CreateDirectory(My.Application.Info.DirectoryPath + "\FULLDATA\")
        End If
        Dim foldercount As Integer = 0
        If Form1.hideGrade = True Then
            PictureBox8.Visible = True
            PictureBox9.Visible = True
            PictureBox10.Visible = True
            Label35.Visible = False
            Label36.Visible = False
            Label37.Visible = False
        Else
            PictureBox8.Visible = False
            PictureBox9.Visible = False
            PictureBox10.Visible = False
            Label35.Visible = True
            Label36.Visible = True
            Label37.Visible = True
        End If
        ' MsgBox((DirSize(My.Application.Info.DirectoryPath + "\FULLDATA\") / 1024 / 1024 / 1024).ToString("N1"))
        Try
            foldercount = IO.Directory.GetDirectories(My.Application.Info.DirectoryPath + "\FULLDATA\").Count()
        Catch ex As Exception

        End Try
        Try
            If My.Settings.agaList Is Nothing Then
                My.Settings.agaList = New System.Collections.Specialized.StringCollection()
            End If
            If My.Settings.vathmoiList Is Nothing Then
                My.Settings.vathmoiList = New System.Collections.Specialized.StringCollection()
            End If
            RadialGauge1.Value = foldercount
            RadialGauge1.Ranges(0).EndValue = foldercount
            RadialGauge2.Value = My.Settings.agaList.Count
            RadialGauge2.Ranges(0).EndValue = My.Settings.agaList.Count
            RadialGauge3.Value = (DirSize(My.Application.Info.DirectoryPath + "\FULLDATA\") / 1024 / 1024).ToString("N1")
            RadialGauge3.Ranges(0).EndValue = (DirSize(My.Application.Info.DirectoryPath + "\FULLDATA\") / 1024 / 1024).ToString("N1")
            Dim countPerasmena As String = 0

            'Dim saveTest As StringCollection = My.Settings.vathmoiList
            If My.Settings.vathmoiList.Count < 60 Then
                For i = 0 To 66
                    My.Settings.vathmoiList.Add("1")
                    My.Settings.Save()
                Next


            End If
            'My.Settings.vathmoiList.Clear()
            ' My.Settings.Save()
            Dim s As String = 0
            For Each x In My.Settings.vathmoiList
                If x > 4 Then
                    s = s + x
                    countPerasmena = countPerasmena + 1
                End If
            Next
            Label44.Text = "   " + countPerasmena + "/47
Περασμένα"
            If countPerasmena <> 0 Then
                Label35.Text = (s / countPerasmena).ToString("N2")
            Else
                Label35.Text = 0
            End If

            Label36.Text = countPerasmena
            GunaGradient2Panel1.Visible = False
            GunaCircleProgressBar4.Value = countPerasmena
            Dim strURL As String = "https://www.cs.uoi.gr/nea/"



            ' loadWeb(strURL)
            'Debug.Print(HDoc.GetElementById("question-header").FirstChild.InnerText)
            ' Debug.Print(FindClass(HDoc, "cs-newscategorie"))
        Catch ex As Exception
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
            MessageBoxAdv.Show("Κάτι πήγε στραβά/Δοκιμάστε την επανεγκατάσταση του προγράμματος", "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' RadialGauge1.Value = 20
    End Sub
    Dim perasmena As Integer = 37
    Dim epiloghs As Integer = 5
    Dim ergasthria As Integer = 7

    Private Sub chartcolum()



        CartesianChart1.Series = New SeriesCollection From {
                New LineSeries With {
                .DataLabels = True,
                    .Title = "Περασμένα",
                    .PointGeometrySize = 15,
                    .Values = New ChartValues(Of Integer) From {
                        5,
                        1,
                        2,
                        1,
                        4,
                        1, 2, 4
                    }
                }
            }
        CartesianChart1.Series.Add(New LineSeries With {
            .DataLabels = True,
            .Title = "Μέσος Ορος",
            .StrokeThickness = 4,
            .PointGeometrySize = 15,
            .Values = New ChartValues(Of Integer) From {
                8,
                6,
                5,
                  7,
                       2,
                        10, 5, 12
            }
        })
        '' CartesianChart2.Series(1).Values.Add(48.0R)
        CartesianChart1.AxisX.RemoveAt(0)
        CartesianChart1.AxisY.RemoveAt(0)
        CartesianChart1.AxisX.Add(New Axis With {
            .Title = "Εξάμηνο",
            .Labels = {"1ο εξάμηνο", "2ο εξάμηνο", "3ο εξάμηνο", "4ο εξάμηνο", "5ο εξάμηνο", "6ο εξάμηνο", "7ο εξάμηνο", "8ο εξάμηνο"}
        })
        CartesianChart1.AxisY.Add(New Axis With {
            .Title = "Μαθήματα"
        })
    End Sub 'chart katheto me dedomena
    Private Sub Label3_Click(sender As Object, e As EventArgs)
        ' Declare DataTable
        Dim Table1 As New DataTable()
        ' Define columns
        Table1.Columns.Add("Μάθημα", GetType(System.String))
        Table1.Columns.Add("Column2", GetType(System.Int32))
        Table1.Columns.Add("Column3", GetType(System.Int32))
        ' Add a row of data
        Table1.Rows.Add("Item1", 44, 99)
        Table1.Rows.Add("Item2", 42, 3)
        'SfDataGrid1.DataSource = Table1
        chartcolum()
    End Sub

    Private Sub sfDataGrid_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs)
        CartesianChart1.AxisX.RemoveAt(0)
        CartesianChart1.AxisY.RemoveAt(0)
        chartcolum()
    End Sub

    Private Sub CartesianChart1_ChildChanged(sender As Object, e As Integration.ChildChangedEventArgs)

    End Sub

    Private Sub CartesianChart1_ChildChanged_1(sender As Object, e As Integration.ChildChangedEventArgs)

    End Sub

    Private Sub Form4_Scroll(sender As Object, e As ScrollEventArgs) Handles Me.Scroll

    End Sub

    Private Sub Label3_Click_1(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Panel1_Paint_1(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel1_Scroll(sender As Object, e As ScrollEventArgs) Handles Panel1.Scroll

    End Sub
    Private Property pageready As Boolean = False

    Private Sub WaitForPageLoad()
        AddHandler WebBrowser1.DocumentCompleted, New WebBrowserDocumentCompletedEventHandler(AddressOf PageWaiter)
        While Not pageready
            Application.DoEvents()
        End While
        pageready = False
    End Sub

    Private Sub PageWaiter(ByVal sender As Object, ByVal e As WebBrowserDocumentCompletedEventArgs)
        If WebBrowser1.ReadyState = WebBrowserReadyState.Complete Then
            pageready = True
            RemoveHandler WebBrowser1.DocumentCompleted, New WebBrowserDocumentCompletedEventHandler(AddressOf PageWaiter)
        End If
    End Sub
    Function loadWeb(webURL As String)
        Dim s As String
        Dim temp As String
        Dim listCounter As Integer
        'Dim s As String = FindClass(HDoc, "Σχόλια")
        WebBrowser1.Navigate(webURL)
        WaitForPageLoad()
        For i = ListBox2.Items.Count - 1 To 0 Step -1

            ListBox2.Items.RemoveAt(i)

        Next
        For i = ListBox3.Items.Count - 1 To 0 Step -1

            ListBox3.Items.RemoveAt(i)

        Next
        FlowLayoutPanel1.Controls.Clear()

        For Each elem As HtmlElement In WebBrowser1.Document.All
            If elem.GetAttribute("InnerText").Contains("Σχόλια") Then
                'If elem.GetAttribute("classname") = "cs-campus-info" Then
                ListBox2.Items.Add(elem.GetAttribute("href"))
                s = elem.InnerText
                ' temp = s.Substring(0, s.Length - 9)
                'ListBox3.Items.Add(elem.GetAttribute("InnerText"))
                'Dim c As newsFeed = New newsFeed
                ' c.Label1.Text = temp
                'FlowLayoutPanel1.Controls.Add(c)



            End If
        Next
        For i = ListBox2.Items.Count - 1 To 0 Step -1
            If ListBox2.Items(i).ToString().Trim.Length = 0 Then
                ' ListBox1.Items.RemoveAt(i)
                ListBox2.Items.RemoveAt(i)
            End If
        Next
        For Each elem As HtmlElement In WebBrowser1.Document.GetElementsByTagName("div")
            If elem.GetAttribute("classname") = "cs-campus-info" Then

                s = elem.InnerText
                temp = s.Substring(0, s.Length - 9)
                ListBox3.Items.Add(s)
                listCounter = ListBox3.Items.Count
                Dim c As newsFeed = New newsFeed
                c.Label1.Text = temp
                c.GunaLabel1.Text = ListBox2.Items(listCounter - 1)
                FlowLayoutPanel1.Controls.Add(c)



            End If
        Next



    End Function
    Function FindClass(Hdoc As HtmlDocument, strClass As String) As String
        Dim s As String
        Dim abc_alt As String
        ' get all Divs, and search by class name
        Dim OneElement As HtmlElement
        For Each OneElement In Hdoc.GetElementsByTagName("div")
            If OneElement.GetAttribute("InnerText").Contains("Σχόλια") Then
                'Return OneElement.InnerText
                ListBox1.Items.Add(OneElement.GetAttribute("InnerText"))
                ListBox2.Items.Add(OneElement.GetAttribute("href"))
                'MsgBox(OneElement.OuterHtml)
                s = OneElement.GetAttribute("InnerText")
                abc_alt = s.Substring(0, s.Length - 9)
                ListBox1.Items.Add(abc_alt)
                Dim c As newsFeed = New newsFeed
                c.Label1.Text = abc_alt
                FlowLayoutPanel1.Controls.Add(c)

            End If
        Next
        ' we get here, not found, so return a empty stirng
        Return "not found"

    End Function
    Private Sub Label1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label13_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label38_Click(sender As Object, e As EventArgs) Handles Label38.Click

    End Sub

    Private Sub GunaShadowPanel3_Paint(sender As Object, e As PaintEventArgs) Handles GunaShadowPanel3.Paint

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadialGauge3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs)

    End Sub
    Dim countNewsPage As Integer = 1
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Dim newURL As String
        countNewsPage += 1
        GunaCircleProgressBar7.Visible = True
        newURL = "https://www.cs.uoi.gr/nea/?page_id_all=" + countNewsPage.ToString
        loadWeb(newURL)
        Label16.Text = countNewsPage.ToString + "/56"
        If countNewsPage > 1 Then
            PictureBox6.Visible = True

        End If
        GunaCircleProgressBar7.Visible = False
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        GunaCircleProgressBar7.Visible = True
        Dim newURL As String
        countNewsPage -= 1
        If countNewsPage < 2 Then
            newURL = "https://www.cs.uoi.gr/nea"
            loadWeb(newURL)
            Label16.Text = "1/56"
            PictureBox6.Visible = False
        End If

        If countNewsPage > 0 Then
            newURL = "https://www.cs.uoi.gr/nea/?page_id_all=" + countNewsPage.ToString
            loadWeb(newURL)
            Label16.Text = countNewsPage.ToString + "/56"
        End If
        GunaCircleProgressBar7.Visible = False
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub nav_settings_Click(sender As Object, e As EventArgs) Handles nav_settings.Click
        nav_settings.Visible = False
        GunaAdvenceButton1.Visible = True

        Panel2.Visible = False
        GunaTransition1.Hide(GunaGradient2Panel1)

    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        Try
            GunaCircleProgressBar7.Visible = True
            Panel2.Visible = True
            GunaAdvenceButton1.Visible = False
            nav_settings.Visible = True

            Panel2.Visible = True
            GunaTransition1.Show(GunaGradient2Panel1)
            GunaGradient2Panel1.Select()
            Dim strURL As String = "https://www.cs.uoi.gr/nea/"



            loadWeb(strURL)
            GunaCircleProgressBar7.Visible = False
        Catch ex As Exception
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
            MessageBoxAdv.Show("Δεν ειναι δυνατή η φόρτωση των NewsFeed", "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub SfButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SfButton2_Click(sender As Object, e As EventArgs)

    End Sub
    Public Sub wait(ByVal seconds As Single)
        Static start As Single
        start = VB.Timer()
        Do While VB.Timer() < start + seconds
            System.Windows.Forms.Application.DoEvents()
        Loop
    End Sub
    Dim x As Integer = 200
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick




    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick


    End Sub




    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadialGauge1_Click(sender As Object, e As EventArgs) Handles RadialGauge1.Click

    End Sub

    Private Sub Label44_Click(sender As Object, e As EventArgs) Handles Label44.Click
        'MsgBox(My.Settings.vathmoiList.Count)
    End Sub

    Private Sub GunaCircleProgressBar4_Click(sender As Object, e As EventArgs) Handles GunaCircleProgressBar4.Click

    End Sub

    Private Sub Label34_Click(sender As Object, e As EventArgs) Handles Label34.Click
        'My.Settings.vathmoiList.Clear()
    End Sub

    Private Sub GunaShadowPanel4_Paint(sender As Object, e As PaintEventArgs) Handles GunaShadowPanel4.Paint

    End Sub

    Private Sub RadialGauge3_Click_1(sender As Object, e As EventArgs) Handles RadialGauge3.Click

    End Sub
End Class