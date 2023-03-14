Imports System.Collections.Specialized
Imports System.ComponentModel
Imports System.IO
Imports System.IO.Compression
Imports System.Net
Imports Syncfusion.Windows.Forms

Public Class miniMenu
    Private Sub GunaPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub miniMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Me.Location = New Point(Windows.Forms.Cursor.Position.X, Windows.Forms.Cursor.Position.Y + 5)
        Me.TopMost = True
        Me.Location = New Point(MousePosition)
        'Me.Location = New Point(GridScheduleSample.calendar.GunaAdvenceButton1.Location.X, GridScheduleSample.calendar.GunaAdvenceButton1.Location.Y)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub miniMenu_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        Me.Close()
        'Form1.TopMost = True

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
    Private Sub GunaAdvenceButton5_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton5.Click
        If Application.OpenForms().OfType(Of courseMain).Any Or Application.OpenForms().OfType(Of Form2).Any Then
            'GunaTransition2.HideSync(GunaPanel5)
            courseMain.Close()
            Form2.Close()
            openChildForm(courseMain)


            ''GunaTransition1.ShowSync(GunaPanel15)
            'GunaTransition2.ShowSync(GunaPanel5)

        Else

            openChildForm(courseMain)

        End If
        Me.Close()
    End Sub
    Dim dpath As String = My.Application.Info.DirectoryPath + "\FULLDATA\"
    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        MsgBox("hello")
        MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
        MessageBoxAdv.Show("Βαθμός Μαθήματος :" + My.Settings.vathmoiList(Form1.coursepos) + vbNewLine + "Όνομα Μαθήματος :" + Form1.names(Form1.coursepos) + vbNewLine + "Εξάμηνο Μαθήματος :" + Form1.courseEksamino(Form1.coursepos), "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' MsgBox("Βαθμός Μαθήματος :" + My.Settings.vathmoiList(Form1.coursepos) + vbNewLine + "Όνομα Μαθήματος :" + Form1.names(Form1.coursepos) + vbNewLine + "Εξάμηνο Μαθήματος :" + Form1.courseEksamino(Form1.coursepos))
    End Sub
    Public Function GetDownloadSize(ByVal URL As String) As Long
        Dim r As Net.WebRequest = Net.WebRequest.Create(URL)
        r.Method = Net.WebRequestMethods.Http.Get
        Using rsp = r.GetResponse()
            Return rsp.ContentLength
        End Using
    End Function

    Public Sub checkNewPackage()
        ''  Dim dir As New IO.DirectoryInfo(dpath + GunaLabel7.Text + ".zip")
        Try
            MsgBox(Form1.coursepos)
            Dim infoReader As System.IO.FileInfo = My.Computer.FileSystem.GetFileInfo(dpath + Form1.typos(Form1.coursepos) + ".zip")
            Dim newDsize As String = GetDownloadSize(Form1.courseDpLink(Form1.coursepos))
            ' MsgBox(newDsize)
            If infoReader.Length = 0 Then

                Exit Sub
            End If
            If infoReader.Exists Then
                If newDsize = infoReader.Length Then
                    MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
                    MessageBoxAdv.Show("Δεν βρέθηκε νέο πακέτο για λήψη", "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                Else
                    ' MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
                    Dim result As DialogResult = MessageBox.Show("Θέλετε να γίνει λήψη του πακέτου?", "University of Ioannina", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
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
        Me.Close()
    End Sub
    Private Sub client_ProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)




    End Sub
    Private Sub downloadPackage()
        Try
            AddHandler wc.DownloadFileCompleted, AddressOf OnDownloadComplete
            'AddHandler wc.DownloadProgressChanged, AddressOf client_ProgressChanged
            ' AddHandler wc.DownloadProgressChanged, AddressOf client_ProgressChanged
            If Not System.IO.Directory.Exists(dpath) Then
                System.IO.Directory.CreateDirectory(dpath)
            End If
            wc.DownloadFileAsync(New Uri(Form1.courseDpLink(Form1.coursepos)), dpath + Form1.typos(Form1.coursepos) + ".zip")
            ' GunaProgressBar1.Visible = True
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
    Dim WithEvents wc As New WebClient
    Private Sub DeleteDirectory(path As String)
        Try
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
                Me.Close()
            End If
        Catch ex As Exception
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
            MessageBoxAdv.Show(ex.Message, "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub GunaAdvenceButton3_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton3.Click
        checkNewPackage()
        ' Me.Close()
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
            MessageBoxAdv.Show(e.Error.Message, "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
    End Sub
    Private Sub GunaAdvenceButton4_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton4.Click
        MsgBox("h")
        MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro

        Dim result As DialogResult = MessageBox.Show("Θέλετε να γίνει οριστική Διαγραφή μαθήματος?", "University of Ioannina", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
        If result = vbYes Then
            DeleteDirectory(dpath + Form1.typos(Form1.coursepos))

        Else
            Exit Sub
        End If

    End Sub
    Dim agapFlag As Boolean = False
    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton2.Click
        'Form1.agaphmenaList.Add(Form1.coursepos)
        Dim saveTest As StringCollection = My.Settings.agaList

        For i = saveTest.Count - 1 To 0 Step -1
            If saveTest(i) = Form1.coursepos Then
                saveTest.RemoveAt(i)
                agapFlag = True
            End If
        Next
        If agapFlag = False Then
            saveTest.Add(Form1.coursepos)
        End If

        My.Settings.agaList = saveTest
        My.Settings.Save()
        Form1.GunaAdvenceTileButton4.PerformClick()
        Me.Close()
        'PictureBox1.Visible = False
        'PictureBox2.Visible = True
    End Sub
End Class