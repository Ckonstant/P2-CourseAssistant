Imports System.IO
Imports Syncfusion.Windows.Forms

Public Class courseFileData
    Dim s As String
    Public pathView As String

    Private Sub GunaLabel1_Click(sender As Object, e As EventArgs)
        Dim pos As Integer = 0
        For Each x In Form1.names

            If x.Equals("Ηλεκτρονική") Then
                MsgBox(pos)
            End If
            pos += 1
        Next

    End Sub
    Private Sub BackUpDataBase(ByVal filePath As String)

        If File.Exists(GunaLabel4.Text) Then
            File.Copy(GunaLabel4.Text, filePath)
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
            MessageBoxAdv.Show("Επιτυχής αποθήκευση αρχείου.", "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub courseFileData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GunaContextMenuStrip1.Cursor = Cursors.Hand
        If GunaLabel2.Text = "pdf" Then
            PictureBox1.Visible = True

        Else
            PictureBox2.Visible = True
        End If
    End Sub
    Private Sub FilePath()
        Using sfdSaveFileDialog As New SaveFileDialog With {.DefaultExt = "pdf", .Title = "Save file as",
                                                            .FileName = String.Format(GunaLabel1.Text),
                                                            .InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                                                            .Filter = "All files (*.*)|*.*"}


            Dim result As DialogResult = sfdSaveFileDialog.ShowDialog

            If result = DialogResult.OK Then
                BackUpDataBase(sfdSaveFileDialog.FileName)
            End If
        End Using
    End Sub
    Private Sub GunaSeparator1_Click(sender As Object, e As EventArgs) Handles GunaSeparator1.Click

    End Sub

    Private Sub GunaSeparator1_MouseHover(sender As Object, e As EventArgs) Handles GunaSeparator1.MouseHover

    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click

    End Sub

    Private Sub GunaAdvenceButton1_MouseEnter(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.MouseEnter
        GunaSeparator1.BackColor = Color.FromArgb(250, 250, 250)
        GunaLabel1.BackColor = Color.FromArgb(250, 250, 250)
        GunaLabel4.BackColor = Color.FromArgb(250, 250, 250)
    End Sub

    Private Sub GunaAdvenceButton1_MouseLeave(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.MouseLeave
        GunaSeparator1.BackColor = Color.FromArgb(255, 255, 255)
        GunaLabel1.BackColor = Color.FromArgb(255, 255, 255)
        GunaLabel4.BackColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub GunaSeparator1_MouseEnter(sender As Object, e As EventArgs) Handles GunaSeparator1.MouseEnter
        GunaAdvenceButton1.BaseColor = Color.FromArgb(250, 250, 250)
        GunaSeparator1.BackColor = Color.FromArgb(250, 250, 250)
    End Sub

    Private Sub GunaSeparator1_MouseLeave(sender As Object, e As EventArgs) Handles GunaSeparator1.MouseLeave
        GunaAdvenceButton1.BaseColor = Color.FromArgb(255, 255, 255)
        GunaSeparator1.BackColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub GunaLabel1_Click_1(sender As Object, e As EventArgs) Handles GunaLabel1.Click
        ToolStripMenuItem3.PerformClick()
    End Sub

    Private Sub GunaLabel1_MouseEnter(sender As Object, e As EventArgs) Handles GunaLabel1.MouseEnter
        GunaAdvenceButton1.BaseColor = Color.FromArgb(250, 250, 250)
        GunaSeparator1.BackColor = Color.FromArgb(250, 250, 250)
        GunaLabel1.ForeColor = Color.DeepSkyBlue
        GunaLabel1.BackColor = Color.FromArgb(250, 250, 250)
    End Sub

    Private Sub GunaLabel1_MouseLeave(sender As Object, e As EventArgs) Handles GunaLabel1.MouseLeave
        GunaAdvenceButton1.BaseColor = Color.FromArgb(255, 255, 255)
        GunaSeparator1.BackColor = Color.FromArgb(255, 255, 255)
        GunaLabel1.ForeColor = Color.Black
        GunaLabel1.BackColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub GunaLabel4_Click(sender As Object, e As EventArgs) Handles GunaLabel4.Click
        'downloadMenu.Show()
    End Sub

    Private Sub GunaLabel4_MouseEnter(sender As Object, e As EventArgs) Handles GunaLabel4.MouseEnter
        GunaAdvenceButton1.BaseColor = Color.FromArgb(250, 250, 250)
        GunaSeparator1.BackColor = Color.FromArgb(250, 250, 250)
        GunaLabel4.ForeColor = Color.DeepSkyBlue
        GunaLabel4.BackColor = Color.FromArgb(250, 250, 250)
    End Sub

    Private Sub GunaLabel4_MouseLeave(sender As Object, e As EventArgs) Handles GunaLabel4.MouseLeave
        GunaAdvenceButton1.BaseColor = Color.FromArgb(255, 255, 255)
        GunaSeparator1.BackColor = Color.FromArgb(255, 255, 255)
        GunaLabel4.ForeColor = Color.Black
        GunaLabel4.BackColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub PictureBox2_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseClick

    End Sub

    Private Sub PictureBox2_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox2.MouseEnter
        GunaAdvenceButton1.BaseColor = Color.FromArgb(250, 250, 250)
        GunaSeparator1.BackColor = Color.FromArgb(250, 250, 250)

        GunaLabel4.BackColor = Color.FromArgb(250, 250, 250)
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        GunaAdvenceButton1.BaseColor = Color.FromArgb(255, 255, 255)
        GunaSeparator1.BackColor = Color.FromArgb(255, 255, 255)

        GunaLabel4.BackColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter
        GunaAdvenceButton1.BaseColor = Color.FromArgb(250, 250, 250)
        GunaSeparator1.BackColor = Color.FromArgb(250, 250, 250)

        GunaLabel4.BackColor = Color.FromArgb(250, 250, 250)
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        GunaAdvenceButton1.BaseColor = Color.FromArgb(255, 255, 255)
        GunaSeparator1.BackColor = Color.FromArgb(255, 255, 255)

        GunaLabel4.BackColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub GunaAdvenceTileButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton1.Click

        GunaContextMenuStrip1.Show(New Point(MousePosition.X - 170, MousePosition.Y))

    End Sub

    Private Sub GunaContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles GunaContextMenuStrip1.Opening

    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        If Form1.pdfFlag = True Then


            Dim test As String = GunaLabel4.Text
            test = Microsoft.VisualBasic.Right(test, 4)


            If (test <> ".pdf") Then
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
                MessageBoxAdv.Show("Μόνο αρχεία pdf μπορούν να γίνουν προεπισκόπηση!", "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ''lb_company.SaveAs(strNewFileName, 32)

                System.Diagnostics.Process.Start("notepad.exe", GunaLabel4.Text)
                Exit Sub
            End If


            If Application.OpenForms().OfType(Of pdfViewer).Any Then
                ' courseFiles.GunaPanel1.Controls.Clear()
                Form1.fullpathview = GunaLabel4.Text
                pdfViewer.Close()

                courseFiles.openChildForm(pdfViewer)

                courseFiles.GunaPanel3.Visible = True

            Else
                'courseFiles.GunaPanel1.Controls.Clear()
                'links.Close()
                Form1.fullpathview = GunaLabel4.Text
                courseFiles.openChildForm(pdfViewer)

                courseFiles.GunaPanel3.Visible = True
            End If
        Else
            Dim test As String = GunaLabel4.Text
            test = Microsoft.VisualBasic.Right(test, 4)


            If (test <> ".pdf") Then
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
                MessageBoxAdv.Show("Μόνο αρχεία pdf μπορούν να γίνουν προεπισκόπηση!", "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ''lb_company.SaveAs(strNewFileName, 32)

                System.Diagnostics.Process.Start("notepad.exe", GunaLabel4.Text)
                Exit Sub
            End If


            If Application.OpenForms().OfType(Of pdfViewer).Any Then
                ' courseFiles.GunaPanel1.Controls.Clear()
                Form1.fullpathview = GunaLabel4.Text
                pdfViewer.Close()

                labs.openChildForm(pdfViewer)

                labs.GunaPanel3.Visible = True

            Else
                'courseFiles.GunaPanel1.Controls.Clear()
                'links.Close()
                Form1.fullpathview = GunaLabel4.Text
                labs.openChildForm(pdfViewer)

                labs.GunaPanel3.Visible = True
            End If

        End If
        ' courseMain.nav_home.PerformClick()
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        FilePath()
    End Sub
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Try
            Dim FileToDelete As String

            FileToDelete = GunaLabel4.Text

            If System.IO.File.Exists(FileToDelete) = True Then

                System.IO.File.Delete(FileToDelete)
                'courseFiles.Close()
                'courseFiles.Show()
                If courseFiles.GunaAdvenceButton1.Checked = True Then
                    courseFiles.GunaAdvenceButton1.PerformClick()
                ElseIf courseFiles.GunaAdvenceButton2.Checked = True Then

                    courseFiles.GunaAdvenceButton2.PerformClick()


                Else
                    courseFiles.GunaAdvenceButton3.PerformClick()
                End If
                ' courseMain.nav_home.PerformClick()
                If courseMain.nav_profile.Checked = True Then
                    courseMain.nav_profile.PerformClick()
                End If
            End If
        Catch ex As Exception
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
            MessageBoxAdv.Show(ex.Message, "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
