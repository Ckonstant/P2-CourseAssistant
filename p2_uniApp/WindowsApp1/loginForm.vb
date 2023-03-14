Imports System.IO
Imports Syncfusion.Windows.Forms
Imports System.Security.Principal
Imports System.Configuration

Public Class loginForm
    Dim i As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        i += 1
        If i = 25 Then
            Timer1.Stop()
            GunaGradient2Panel1.Visible = False
            GunaGradient2Panel2.Visible = True
            '    GunaLabel2.ForeColor = Color.FromArgb(46, 204, 113)
            i = 0
            If GunaLineTextBox1.Text = "betatester" And GunaLineTextBox2.Text = "betatester" Then
                Form1.Show()
                Me.Close()
            Else
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
                MessageBoxAdv.Show("Λανθασμένο Συνθηματικό/Κωδικός!", "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub GunaGradient2Panel2_Paint(sender As Object, e As PaintEventArgs) Handles GunaGradient2Panel2.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub GunaGradient2Panel2_MouseClick(sender As Object, e As MouseEventArgs) Handles GunaGradient2Panel2.MouseClick
        Try
            GunaGradient2Panel1.Visible = True
            GunaGradient2Panel2.Visible = False
            Timer1.Start()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        Application.Exit()
    End Sub

    Private Sub GunaCheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles GunaCheckBox1.CheckedChanged
        If GunaCheckBox1.Checked = True Then
            GunaLineTextBox2.PasswordChar = ""
        Else
            GunaLineTextBox2.PasswordChar = "●"
        End If
    End Sub

    Private Sub GunaGradient2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles GunaGradient2Panel1.Paint

    End Sub

    Private Sub loginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim identity = WindowsIdentity.GetCurrent()
        Dim principal = New WindowsPrincipal(identity)
        Dim isElevated As Boolean = principal.IsInRole(WindowsBuiltInRole.Administrator)
        If Not isElevated Then
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
            MessageBoxAdv.Show("Παρακαλώ τρέξτε το πρόγραμμα σαν διαχειριστής για ομαλή λειτουργία!", "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        If Not Directory.Exists(My.Application.Info.DirectoryPath + "\FULLDATA\") Then
            Directory.CreateDirectory(My.Application.Info.DirectoryPath + "\FULLDATA\")
        End If
    End Sub

    Private Sub GunaLinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GunaLinkLabel2.LinkClicked
        MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
        MessageBoxAdv.Show("Δεν είναι εφικτή η δημιουργία προφίλ στο Beta Testing.", "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub

    Private Sub GunaLinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GunaLinkLabel1.LinkClicked
        MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
        MessageBoxAdv.Show("Όνομα Χρήστη : betatester" + vbNewLine + "Κωδικός Χρήστη : betatester", "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub GunaLabel2_Click(sender As Object, e As EventArgs) Handles GunaLabel2.Click
        Try
            GunaGradient2Panel1.Visible = True
            GunaGradient2Panel2.Visible = False
            Timer1.Start()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Try
            GunaGradient2Panel1.Visible = True
            GunaGradient2Panel2.Visible = False
            Timer1.Start()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal)
        MessageBox.Show(config.FilePath)
    End Sub
End Class