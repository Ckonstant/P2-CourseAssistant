Imports System.IO
Imports Syncfusion.Windows.Forms

Public Class myFiles
    Dim table As DataTable
    Dim dipath As String = My.Application.Info.DirectoryPath + "\FULLDATA\"
    Dim sourcepath As String = dipath + "\myFiles"
    Private Sub GunaPanel1_Paint(sender As Object, e As PaintEventArgs) Handles GunaPanel1.Paint

    End Sub
    Private Sub LoadRows(ByVal dir As String)
        If IO.Directory.Exists(dir) Then
            Try
                For Each fn As String In IO.Directory.GetFiles(dir, "*.*")
                    table.Rows.Add(IO.Path.GetFileName(fn), fn)
                Next
            Catch ex As Exception
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
                MessageBoxAdv.Show(ex.Message, "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    Private Shared Sub CopyDirectory(ByVal sourcePath As String, ByVal destPath As String)
        Try
            If Not Directory.Exists(destPath) Then
                Directory.CreateDirectory(destPath)
            End If

            For Each file__1 As String In Directory.GetFiles(Path.GetDirectoryName(sourcePath))
                Dim dest As String = Path.Combine(destPath, Path.GetFileName(file__1))
                File.Copy(file__1, dest)
            Next

            For Each folder As String In Directory.GetDirectories(Path.GetDirectoryName(sourcePath))
                Dim dest As String = Path.Combine(destPath, Path.GetFileName(folder))
                CopyDirectory(folder, dest)
            Next
        Catch ex As Exception
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
            MessageBoxAdv.Show(ex.Message, "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GunaPanel1_DragDrop(sender As Object, e As DragEventArgs) Handles GunaPanel1.DragDrop
        Try
            Dim sourcepath As String
            Dim DestPath As String
            Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
            For Each path In files



                Dim c As courseFileData = New courseFileData
                c.Dock = DockStyle.Top

                c.GunaLabel4.Text = path
                c.GunaLabel1.Text = path.Substring(path.LastIndexOf("\") + 1)

                sourcepath = path

                Dim dir As New IO.DirectoryInfo(dipath + Form1.typos(Form1.coursepos) + "\myFiles")

                If dir.Exists Then
                    DestPath = dipath + Form1.typos(Form1.coursepos) + "\myFiles\" + path.Substring(path.LastIndexOf("\") + 1)
                    System.IO.File.Copy(sourcepath, DestPath, True)
                    GunaPanel1.Controls.Add(c)

                Else
                    My.Computer.FileSystem.CreateDirectory(dir.FullName)
                    DestPath = dipath + Form1.typos(Form1.coursepos) + "\myFiles\" + path.Substring(path.LastIndexOf("\") + 1)
                    System.IO.File.Copy(sourcepath, DestPath, True)
                    GunaPanel1.Controls.Add(c)
                End If





            Next
        Catch ex As Exception
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
            MessageBoxAdv.Show(ex.Message, "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GunaPanel1_DragEnter(sender As Object, e As DragEventArgs) Handles GunaPanel1.DragEnter
        Try
            If e.Data.GetDataPresent(DataFormats.FileDrop) Then
                e.Effect = DragDropEffects.Copy
            End If
        Catch ex As Exception
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
            MessageBoxAdv.Show(ex.Message, "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub myFiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            GunaPanel1.Controls.Clear()
            Dim fileExten As String
            Dim r As New Random
            Me.table = New DataTable
            table.Clear()

            With table.Columns
                .Add("Name", GetType(String))
                .Add("FullPath", GetType(String))
            End With
            Me.LoadRows(dipath + Form1.typos(Form1.coursepos) + "\myFiles")

            For i As Integer = table.Rows.Count - 1 To 0 Step -1
                Dim c As courseFileData = New courseFileData
                c.Dock = DockStyle.Top
                fileExten = table.Rows(i).Item(0).ToString
                c.GunaLabel1.Text = table.Rows(i).Item(0).ToString
                c.GunaLabel2.Text = fileExten.Substring(fileExten.LastIndexOf(".") + 1)
                c.GunaLabel3.Text = table.Rows(i).Item(0).ToString
                c.GunaLabel4.Text = table.Rows(i).Item(1).ToString

                GunaPanel1.Controls.Add(c)

            Next
        Catch ex As Exception
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
            MessageBoxAdv.Show(ex.Message, "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click

        Dim dlg As OpenFileDialog = New OpenFileDialog()
        dlg.Title = "Open Schedule file"
        dlg.InitialDirectory = Environment.CurrentDirectory
        'dlg.Filter = "Schedule files (*.schedule)|*.schedule|All files (*.*)|*.*"

        If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Try
                Dim sourcepath As String
                Dim DestPath As String




                Dim c As courseFileData = New courseFileData
                c.Dock = DockStyle.Top

                c.GunaLabel4.Text = dlg.FileName
                c.GunaLabel1.Text = dlg.FileName.Substring(dlg.FileName.LastIndexOf("\") + 1)

                sourcepath = dlg.FileName
                DestPath = dipath + Form1.typos(Form1.coursepos) + "\myFiles\" + dlg.FileName.Substring(dlg.FileName.LastIndexOf("\") + 1)

                System.IO.File.Copy(sourcepath, DestPath, True)

                GunaPanel1.Controls.Add(c)



            Catch ex As Exception
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
                MessageBoxAdv.Show(ex.Message, "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton2.Click
        Try
            Process.Start(dipath + Form1.typos(Form1.coursepos) + "\myFiles")
        Catch ex As Exception
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
            MessageBoxAdv.Show(ex.Message, "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GunaSeparator1_Click(sender As Object, e As EventArgs) Handles GunaSeparator1.Click

    End Sub
End Class