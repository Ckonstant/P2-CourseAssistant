Imports Syncfusion.Windows.Forms

Public Class pdfViewer
    Private Sub GunaPanel1_Paint(sender As Object, e As PaintEventArgs) Handles GunaPanel1.Paint

    End Sub

    Private Sub pdfViewer_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            If Form1.windowFlag = False Then
                PictureBox2.Visible = True
                PictureBox3.Visible = False
                PictureBox4.Visible = False
                PictureBox5.Visible = False
            Else
                PictureBox2.Visible = False
                PictureBox3.Visible = True
                PictureBox4.Visible = True
                PictureBox5.Visible = True
            End If
            Me.BringToFront()
            GunaLabel1.Text = Form1.fullpathview
            AxAcroPDF1.src = Form1.fullpathview
        Catch ex As Exception
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
            MessageBoxAdv.Show("Δεν βρέθηκε το Adobe PDF Reader Dll.Παρακαλώ κατεβάστε το πακέτο!" + vbNewLine + "https://get.adobe.com/uk/reader/", "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Try
            Form1.windowFlag = False
            courseFiles.GunaPanel3.Visible = False
            labs.GunaPanel3.Visible = False
            Me.Close()
            'Form1.Show()
            'Form1.BringToFront()
        Catch ex As Exception
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
            MessageBoxAdv.Show(ex.Message, "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Try
            If Me.WindowState = FormWindowState.Normal Then
                Form1.windowFlag = True
                Dim fn As New pdfViewer
                'Form1.Hide()
                fn.Show()
                fn.WindowState = FormWindowState.Maximized
                PictureBox3.Visible = False
                PictureBox2.Visible = True
                fn.FormBorderStyle = FormBorderStyle.SizableToolWindow
                fn.ControlBox = False

            Else
                Form1.windowFlag = False
                Me.Close()
                PictureBox2.Visible = False
                PictureBox3.Visible = True
                'Form1.Show()
                Form1.BringToFront()
            End If
        Catch ex As Exception
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
            MessageBoxAdv.Show(ex.Message, "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        courseFiles.GunaPanel3.Visible = False
        labs.GunaPanel3.Visible = False
        Form1.windowFlag = False
        Form1.Show()
        Form1.BringToFront()

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        If Me.WindowState = FormWindowState.Normal Then

            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub
End Class