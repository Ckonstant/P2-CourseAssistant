Imports Syncfusion.Windows.Forms

Public Class labs
    Dim table As DataTable
    Dim dipath As String = My.Application.Info.DirectoryPath + "\FULLDATA\"
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
    Private currentForm As Form = Nothing
    Public Sub openChildForm(childForm As Form)
        '' GunaTransition1.HideSync(currentForm)
        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        GunaPanel3.Controls.Add(childForm)
        GunaPanel3.Tag = childForm
        childForm.BringToFront()


        childForm.Show()



    End Sub
    Private Sub labs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            Me.LoadRows(dipath + Form1.typos(Form1.coursepos) + "\lab")

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

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
End Class