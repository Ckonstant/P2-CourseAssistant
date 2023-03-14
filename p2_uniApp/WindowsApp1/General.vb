Imports System.Collections.Specialized
Imports System.ComponentModel
Imports System.IO
Imports System.IO.Compression
Imports System.Net
Imports Syncfusion.Windows.Forms

Public Class General
    Private Sub GunaAdvenceTileButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton2.Click

    End Sub
    Dim WithEvents wc As New WebClient
    Dim dpath As String = My.Application.Info.DirectoryPath + "\FULLDATA\"
    Private Sub General_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dir As New IO.DirectoryInfo(dpath + Form1.typos(Form1.coursepos)) ''gunalabel7.text  = p.x = anaptiksi folder
        If dir.Exists Then
            PictureBox5.Visible = False
            Label1.ForeColor = Color.FromArgb(91, 95, 199)
        Else
            PictureBox5.Visible = True
            Label1.ForeColor = Color.FromArgb(208, 140, 69)
        End If
        Dim usStates As New List(Of String)()

        usStates.Add("0")
        usStates.Add("0,5")
        usStates.Add("1")
        usStates.Add("1,5")
        usStates.Add("2")
        usStates.Add("2,5")
        usStates.Add("3")
        usStates.Add("3,5")
        usStates.Add("4")
        usStates.Add("4,5")
        usStates.Add("5")
        usStates.Add("5,5")
        usStates.Add("6")
        usStates.Add("6,5")
        usStates.Add("7")
        usStates.Add("7,5")
        usStates.Add("8")
        usStates.Add("8,5")
        usStates.Add("9")
        usStates.Add("9,5")
        usStates.Add("10")

        SfComboBox1.DataSource = usStates
        Label1.Text = Form1.names(Form1.coursepos)
        Dim saveTest As StringCollection = My.Settings.agaList
        If saveTest IsNot Nothing Then
            For i = saveTest.Count - 1 To 0 Step -1
                If saveTest(i) = Form1.coursepos Then
                    PictureBox1.Visible = False
                    PictureBox2.Visible = True
                End If
            Next
        End If
        GunaAdvenceTileButton2.Text = "Κωδικός Μαθήματος: " + Form1.courseID(Form1.coursepos)
        GunaAdvenceTileButton9.Text = "Ο Βαθμός μου            " + vbNewLine + My.Settings.vathmoiList(Form1.coursepos) 'Form1.courseGrade(Form1.coursepos)
        GunaAdvenceTileButton4.Text = "Εξάμηνο Σπουδών : " + Form1.courseEksamino(Form1.coursepos)
        GunaAdvenceTileButton3.Text = "Εργαστήριο Μαθήματος   " + Form1.courseLab(Form1.coursepos)
        GunaAdvenceTileButton7.Text = "Διδάσκων Καθηγητής   " + Form1.courseDidaskon(Form1.coursepos)
        Label2.Text = Form1.courseDrive(Form1.coursepos)
        Label3.Text = Form1.courseSite(Form1.coursepos)
        Label4.Text = Form1.courseDiscord(Form1.coursepos)
        If My.Settings.vathmoiList(Form1.coursepos) > 4.5 Then
            PictureBox3.Visible = True
        End If
    End Sub
    Private currentForm As Form = Nothing
    Public Sub openChildForm(childForm As Form)
        '' GunaTransition1.HideSync(currentForm)
        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        Form1.Panel1.Controls.Add(childForm)
        Form1.Panel1.Tag = childForm
        childForm.BringToFront()


        childForm.Show()



    End Sub
    Private Sub OnDownloadComplete(ByVal sender As Object, ByVal e As AsyncCompletedEventArgs)
        If Not e.Cancelled AndAlso e.Error Is Nothing Then

            Try




                Dim zipPath As String = (dpath + Form1.typos(Form1.coursepos) + ".zip")
                Dim extractPath As String = dpath

                ''ZipFile.CreateFromDirectory(startPath, zipPath)

                ZipFile.ExtractToDirectory(zipPath, extractPath)

                ''MsgBox("Επιτυχης εγκατασταση πακετου.")
                If Application.OpenForms().OfType(Of courseMain).Any Or Application.OpenForms().OfType(Of Form2).Any Then
                    courseMain.Close()
                    Form2.Close()
                    openChildForm(courseMain)
                Else
                    openChildForm(courseMain)
                End If
                ''  Me.Close()
                ''  Form1.Show()
            Catch ex As Exception
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
                MessageBoxAdv.Show(ex.Message, "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try


        Else

            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
            MessageBoxAdv.Show("Σφάλμα κατά την εγκατάσταση του πακέτου!", "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
    End Sub

    Private Sub GunaAdvenceTileButton6_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton6.Click
        Process.Start(Label2.Text)
        ' links.Show()
        'links.WebBrowser1.Navigate(Label3.Text)

    End Sub

    Private Sub GunaAdvenceTileButton8_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton8.Click
        Process.Start(Label3.Text)
    End Sub

    Private Sub GunaAdvenceTileButton5_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton5.Click
        Process.Start(Label4.Text)
    End Sub
    Public agapFlag As Boolean = False
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        'Form1.agaphmenaList.Add(Form1.coursepos)
        Try
            If My.Settings.agaList Is Nothing Then
                My.Settings.agaList = New System.Collections.Specialized.StringCollection()
            End If
            Dim saveTest As StringCollection = My.Settings.agaList
            saveTest.Add(Form1.coursepos)



            My.Settings.agaList = saveTest
            My.Settings.Save()
            PictureBox1.Visible = False
            PictureBox2.Visible = True
        Catch ex As Exception
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
            MessageBoxAdv.Show(ex.Message, "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub downloadPackage()
        Try
            AddHandler wc.DownloadFileCompleted, AddressOf OnDownloadComplete
            AddHandler wc.DownloadProgressChanged, AddressOf client_ProgressChanged
            ' AddHandler wc.DownloadProgressChanged, AddressOf client_ProgressChanged
            If Not System.IO.Directory.Exists(dpath) Then
                System.IO.Directory.CreateDirectory(dpath)
            End If
            wc.DownloadFileAsync(New Uri(Form1.courseDpLink(Form1.coursepos)), dpath + Form1.typos(Form1.coursepos) + ".zip")
            GunaProgressBar1.Visible = True
            'GunaLabel1.Visible = True
            'GunaLabel2.Visible = True
            ' GunaLabel3.Visible = True
            ' GunaLabel4.Visible = True
            ' GunaLabel5.Visible = True


        Catch ex As Exception
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
            MessageBoxAdv.Show(ex.Message, "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Function GetDownloadSize(ByVal URL As String) As Long
        Dim r As Net.WebRequest = Net.WebRequest.Create(URL)
        r.Method = Net.WebRequestMethods.Http.Get
        Using rsp = r.GetResponse()
            Return rsp.ContentLength
        End Using
    End Function
    Private Sub DeleteDirectory(path As String)
        If Directory.Exists(path) Then
            'Delete all files from the Directory
            For Each filepath As String In Directory.GetFiles(path)
                File.Delete(filepath)
            Next
            'Delete all child Directories
            For Each dir As String In Directory.GetDirectories(path)
                DeleteDirectory(dir)
            Next
            'Delete a Directory
            Directory.Delete(path)
        End If
    End Sub
    Private Sub client_ProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)



        GunaProgressBar1.Value = e.ProgressPercentage


    End Sub
    Public Sub checkNewPackage()
        ''  Dim dir As New IO.DirectoryInfo(dpath + GunaLabel7.Text + ".zip")
        Try
            Dim infoReader As System.IO.FileInfo = My.Computer.FileSystem.GetFileInfo(dpath + Form1.typos(Form1.coursepos) + ".zip")
            Dim newDsize As String = GetDownloadSize(Form1.courseDpLink(Form1.coursepos))
            'MsgBox(newDsize)
            If infoReader.Length = 0 Then
                Exit Sub
            End If
            If infoReader.Exists Then
                If newDsize = infoReader.Length Then
                    MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
                    MessageBoxAdv.Show("Δεν υπάρχει νέο πακέτο για το μάθημα!", "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                Else
                    MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
                    Dim result As DialogResult = MessageBoxAdv.Show("Υπάρχει νέο Πακέτο,Θέλετε να γίνει λήψη τώρα?", "University of Ioannina", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If result = vbYes Then
                        DeleteDirectory(dpath + Form1.typos(Form1.coursepos))
                        downloadPackage()
                    Else
                        Exit Sub
                    End If
                End If
            End If

        Catch ex As Exception
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
            MessageBoxAdv.Show(ex.Message, "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub GunaAdvenceTileButton10_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton10.Click
        checkNewPackage()
    End Sub

    Private Sub GunaAdvenceTileButton4_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton4.Click
        'MsgBox(SfComboBox1.SelectedItem)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro

        Dim result As DialogResult = MessageBoxAdv.Show("Το μάθημα βρίσκεται ήδη στον κατάλογο με τα αγαπημένα,Θέλετε να γίνει αφαίρεση?", "University of Ioannina", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        Try
            If result = DialogResult.Yes Then
                Dim saveTest As StringCollection = My.Settings.agaList
                For i = saveTest.Count - 1 To 0 Step -1
                    If saveTest(i) = Form1.coursepos Then
                        saveTest.RemoveAt(i)
                    End If
                Next

                ' saveTest.RemoveAt(Form1.coursepos)
                My.Settings.agaList = saveTest
                My.Settings.Save()
                PictureBox1.Visible = True
                PictureBox2.Visible = False

            Else
            End If
        Catch ex As Exception
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
            MessageBoxAdv.Show(ex.Message, "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GunaAdvenceTileButton9_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton9.Click
        'My.Settings.vathmoiList.Item(Form1.coursepos) = 10
        ' My.Settings.Save()
        'Form1.courseGrade(Form1.coursepos) = 10
        'Form3.Show()
        If SfComboBox1.Visible = False Then
            SfComboBox1.Visible = True
        Else
            SfComboBox1.Visible = False
        End If
        'PictureBox4.Visible = True

    End Sub

    Private Sub GunaAdvenceTileButton3_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton3.Click

    End Sub

    Private Sub GunaAdvenceTileButton7_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton7.Click

    End Sub

    Private Sub SfComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub SfComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles SfComboBox1.SelectedIndexChanged
        Try
            My.Settings.vathmoiList.Item(Form1.coursepos) = SfComboBox1.SelectedItem
            My.Settings.Save()
            SfComboBox1.Visible = False
            GunaAdvenceTileButton9.Text = "Ο Βαθμός μου            " + vbNewLine + My.Settings.vathmoiList(Form1.coursepos)
            If My.Settings.vathmoiList(Form1.coursepos) > 4.5 Then
                PictureBox3.Visible = True
            Else
                PictureBox3.Visible = False
            End If
            'courseMain.nav_settings.PerformClick()
        Catch ex As Exception
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
            MessageBoxAdv.Show(ex.Message, "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub
End Class