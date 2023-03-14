Imports System.ComponentModel
Imports System.Net
Imports System.IO
Imports System.IO.Compression
Imports Syncfusion.Windows.Forms

Public Class courseControl
    Dim WithEvents wc As New WebClient

    Dim dpath As String = Application.StartupPath + "\FULLDATA\"
    Dim lastUpdate As DateTime
    Dim lastBytes As Long = 0
    Dim iSecond As Double = 0
    Private Sub GunaCircleButton2_Click(sender As Object, e As EventArgs) Handles GunaCircleButton2.Click
        miniMenu.Show()

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
    Private Sub GunaAdvenceTileButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaAdvenceTileButton1_BackColorChanged(sender As Object, e As EventArgs)

    End Sub







    Private Sub GunaCircleButton2_MouseEnter(sender As Object, e As EventArgs) Handles GunaCircleButton2.MouseEnter
        GunaAdvenceTileButton1.BaseColor = Color.FromArgb(237, 235, 233)
    End Sub

    Private Sub GunaCircleButton2_MouseLeave(sender As Object, e As EventArgs) Handles GunaCircleButton2.MouseLeave
        GunaAdvenceTileButton1.BaseColor = Color.FromArgb(255, 255, 255)
    End Sub
    Private Sub OnDownloadComplete(ByVal sender As Object, ByVal e As AsyncCompletedEventArgs)
        If Not e.Cancelled AndAlso e.Error Is Nothing Then

            Try




                Dim zipPath As String = (dpath + Form1.typos(Form1.coursepos) + ".zip")
                Dim extractPath As String = dpath
                'Using 

                ''ZipFile.CreateFromDirectory(startPath, zipPath)







                ZipFile.ExtractToDirectory(zipPath, extractPath)
                Form1.GunaCircleProgressBar7.Visible = False
                Alert1("Επιτυχής Εγκατάσταση Πακέτου!!", AlertForm.alertTypeEnum.Success)
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
    Private Sub client_ProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        Try
            '' MsgBox("Total size of :" + (e.TotalBytesToReceive / 1024D / 1024D).ToString("0.00") + "Found")
            Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString())
            Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString())
            Dim percentage As Double = bytesIn / totalBytes * 100
            GunaLabel4.Text = String.Format("{0} MB / {1} MB", (e.BytesReceived / 1024D / 1024D).ToString("0.00"), (e.TotalBytesToReceive / 1024D / 1024D).ToString("0.00"))
            '' ActiveForm.Text = ("Ποσοστό Ολοκλήρωσης: ") + e.ProgressPercentage.ToString & ("%")
            GunaLabel5.Text = "(" & e.ProgressPercentage & "%)"
            If lastBytes = 0 Then
                lastUpdate = DateTime.Now
                lastBytes = e.BytesReceived
                Return
            End If

            Dim now = DateTime.Now
            Dim timeSpan = now - lastUpdate
            If Not timeSpan.Seconds = 0 Then
                Dim bytesChange = e.BytesReceived - lastBytes
                Dim bytesPerSecond = bytesChange / timeSpan.Seconds

                lastBytes = e.BytesReceived
                lastUpdate = now
                GunaLabel2.Text = String.Format("{0} MB/s", (bytesPerSecond / 1024D / 1024D).ToString("0.00"))
                '' left.Text = "Timeleft:" + Math.Round(((1 - Me.ProgressBar1.Value / 100) * Math.Round((e.TotalBytesToReceive / 1024), 2)) / bytesPerSecond) + " s"
                '' left.Text = "Timeleft:" & Math.Round(((1 - Me.ProgressBar1.Value / 100) * Math.Round((e.TotalBytesToReceive / 1024), 2)) / bytesPerSecond / 1024D / 1024D) & " s"


                Dim iSpan As TimeSpan = TimeSpan.FromSeconds(iSecond)
                iSecond = Math.Round((e.TotalBytesToReceive - e.BytesReceived) / (bytesPerSecond))
                If iSecond < 60 Then
                    GunaLabel3.Text = "Estimated:" & iSpan.Seconds.ToString.PadLeft(1, "0"c) & "s"
                ElseIf iSecond < 3600 Then
                    GunaLabel3.Text = "Estimated:" & iSpan.Minutes.ToString.PadLeft(1, "0"c) & " minutes " &
                                iSpan.Seconds.ToString.PadLeft(1, "0"c) & "s"
                Else
                    GunaLabel3.Text = "Estimated:" & iSpan.Hours.ToString.PadLeft(1, "0"c) & " hours " &
                        iSpan.Minutes.ToString.PadLeft(1, "0"c) & " minutes "
                    ''&                         iSpan.Seconds.ToString.PadLeft(1, "0"c) & "s"
                End If
                ''left.Text = "Estimated:" & Math.Round((e.TotalBytesToReceive - e.BytesReceived) / (bytesPerSecond)) & "s"

            End If



            GunaProgressBar1.Value = e.ProgressPercentage

            If GunaProgressBar1.Value = 90 Then
                GunaLabel1.Text = "Αποσυμπίεση αρχειων..."
            End If
        Catch ex As Exception
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
            MessageBoxAdv.Show(ex.Message, "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub GunaAdvenceTileButton1_MouseLeave(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton1.MouseLeave
        GunaCircleButton2.BackColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub GunaAdvenceTileButton1_MouseEnter(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton1.MouseEnter

        GunaCircleButton2.BackColor = Color.FromArgb(237, 235, 233)
        'GunaCircleButton2.Visible = True
    End Sub

    Private Sub downloadPackage()
        Try
            Alert1("Κατέβασμα Πακέτου σε επεξεργασία...", AlertForm.alertTypeEnum.Info)
            Form1.GunaCircleProgressBar7.Visible = True
            AddHandler wc.DownloadFileCompleted, AddressOf OnDownloadComplete
            AddHandler wc.DownloadProgressChanged, AddressOf client_ProgressChanged
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
    Public coursePosition As Integer = 0
    Dim counti As Integer = 0
    Public Function GetDownloadSize(ByVal URL As String) As Long
        Dim r As Net.WebRequest = Net.WebRequest.Create(URL)
        r.Method = Net.WebRequestMethods.Http.Head
        Using rsp = r.GetResponse()
            Return rsp.ContentLength
        End Using
    End Function
    Public Sub checkNewPackage()
        MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro

        ''  Dim dir As New IO.DirectoryInfo(dpath + GunaLabel7.Text + ".zip")
        Try
            Dim infoReader As System.IO.FileInfo = My.Computer.FileSystem.GetFileInfo(dpath + Form1.typos(Form1.coursepos) + ".zip")
            Dim newDsize As String = GetDownloadSize(Form1.courseDpLink(Form1.coursepos))
            If infoReader.Exists Then
                If newDsize = infoReader.Length Then
                    MsgBox("Δεν υπάρχει νέο πακέτο.")
                    Exit Sub
                Else
                    Dim result As DialogResult = MessageBoxAdv.Show("Υπάρχει νέο πακέτο,Θέλετε να γίνει λήψη τώρα?", "University of Ioannina", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If result = vbYes Then
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
    Public Sub Alert1(msg As String, type As AlertForm.alertTypeEnum)
        Dim f As AlertForm = New AlertForm
        f.setAlert(msg, type)
    End Sub
    Private Sub GunaAdvenceTileButton1_MouseClick(sender As Object, e As MouseEventArgs) Handles GunaAdvenceTileButton1.MouseClick
        MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro


        counti = 0
        For Each x In Form1.names

            If x.Equals(courseName.Text) Then
                Form1.coursepos = counti
            End If
            counti += 1
        Next
        Form1.courseFlag = courseName.Text

        If e.Button = Windows.Forms.MouseButtons.Left Then
            Dim dir As New IO.DirectoryInfo(dpath + Form1.typos(Form1.coursepos)) ''gunalabel7.text  = p.x = anaptiksi folder
            If dir.Exists Then
                'checkNewPackage()

                If Application.OpenForms().OfType(Of courseMain).Any Or Application.OpenForms().OfType(Of Form2).Any Then
                    courseMain.Close()
                    Form2.Close()
                    openChildForm(courseMain)
                Else
                    openChildForm(courseMain)
                End If
            Else
                Dim result As DialogResult = MessageBoxAdv.Show("Κατεβάστε το πακέτο πρώτα πριν την επιλογή μαθήματος,Θέλετε να γίνει λήψη τώρα?", "University of Ioannina", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    downloadPackage()

                Else
                    If Application.OpenForms().OfType(Of courseMain).Any Or Application.OpenForms().OfType(Of Form2).Any Then
                        courseMain.Close()
                        Form2.Close()
                        openChildForm(courseMain)
                    Else
                        openChildForm(courseMain)
                    End If
                    Exit Sub
                End If

            End If
        ElseIf e.Button = Windows.Forms.MouseButtons.Right Then
            miniMenu.Show()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        GunaProgressBar1.Visible = True
        GunaProgressBar1.Increment(1)
        If GunaProgressBar1.Value = 100 Then
            GunaProgressBar1.Visible = False
            GunaProgressBar1.Value = 0
            Timer1.Stop()
        End If
    End Sub

    Private Sub GunaAdvenceTileButton1_Click_1(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton1.Click

    End Sub
End Class
