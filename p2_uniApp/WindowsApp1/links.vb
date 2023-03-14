Imports System.ComponentModel
Imports System.IO
Imports ExcelDataReader
Imports System.Data.OleDb
Imports System.Linq
Imports System.Data.SqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Imports ExcelAutoFormat = Microsoft.Office.Interop.Excel.XlRangeAutoFormat
Imports Microsoft.Office.Interop
Imports Microsoft.Office
Imports System.Xml.XPath
Imports System.Data
Imports System.Xml
Imports Syncfusion.WinForms.Controls
Imports Syncfusion.WinForms.DataGrid.Styles
Imports System.Windows.Forms
Imports Syncfusion.WinForms.DataGrid.Enums
Imports System.Collections.ObjectModel
Imports System
Imports Syncfusion.WinForms.DataGrid
Imports Syncfusion.WinForms.DataGrid.Events
Imports System.Drawing
Imports System.Globalization
Imports Syncfusion.WinForms.Input.Enums
Imports System.Net.Mail
Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.Windows.Forms
Public Class links
	Private Sub Button1_Click(sender As Object, e As EventArgs)

	End Sub

	Private Sub AxAcroPDF1_Enter(sender As Object, e As EventArgs)

	End Sub

	Private Sub links_Load(sender As Object, e As EventArgs) Handles Me.Load
		GunaDateTimePicker1.Format = DateTimePickerFormat.Custom
		GunaDateTimePicker1.CustomFormat = "dd/MM/yyyy"
		GunaDateTimePicker1.Value = Date.Now
		System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs)

	End Sub

	Private Sub Button3_Click(sender As Object, e As EventArgs)

	End Sub

	Private Sub Button4_Click(sender As Object, e As EventArgs)

	End Sub

	Private Sub GunaPanel1_Paint(sender As Object, e As PaintEventArgs)

	End Sub

	Private Sub Button5_Click(sender As Object, e As EventArgs)

	End Sub

	Private Sub GradientPanel2_Paint(sender As Object, e As PaintEventArgs) Handles GradientPanel2.Paint

	End Sub
	Dim listco As New List(Of String)
	Dim len As String
	Dim fullLenght As Double
	Dim fileExtension As String
	Public totalFilesSize As Double = 0
	Dim bytesLeft As Integer
	Dim totalbytes As Integer
	Public sumFiles As Integer = 0
	Public fileSizesum As Double = 0
	Private Sub GradientPanel2_DragDrop(sender As Object, e As DragEventArgs) Handles GradientPanel2.DragDrop
		Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
		For Each path In files


			ListBox1.Items.Add(System.IO.Path.GetFullPath(path))
			'CheckedListBox1.Items.Add(System.IO.Path.GetFullPath(OpenFileDialog1.FileName))

			'comboList.Add(System.IO.Path.GetFileName(OpenFileDialog1.FileName))
			listco.Clear()
			len = ((New System.IO.FileInfo(path).Length) / 1024 / 1024).ToString("N2")
			fullLenght = New System.IO.FileInfo(path).Length
			If fullLenght > 100000 Then
				len = ((New System.IO.FileInfo(path).Length) / 1024 / 1024).ToString("N2") + " MB"
			Else
				len = ((New System.IO.FileInfo(path).Length) / 1024).ToString("N2") + " KB"
			End If
			fileExtension = System.IO.Path.GetExtension(path)

			ListBox2.Items.Add(System.IO.Path.GetFileName(path) + len)
			ListBox3.Items.Add(fullLenght)
			Label2.Text = fullLenght
			For i = 0 To ListBox2.Items.Count - 1
				listco.Add(ListBox2.Items(i).ToString + "  " + " MB")
			Next
			Dim c As UserControl1 = New UserControl1
			c.Dock = DockStyle.Top
			c.BringToFront()
			c.Label1.Text = System.IO.Path.GetFullPath(path)
			c.GunaLabel1.Text = "Όνομα Αρχείου: " + (System.IO.Path.GetFileName(path))
			c.GunaLabel2.Text = "Μέγεθος Αρχείου :  " + len
			c.GunaLabel4.Text = (New System.IO.FileInfo(path).Length) / 1024 / 1024
			c.SfToolTip1.SetToolTip(c.GunaLabel1, System.IO.Path.GetFullPath(path))
			c.SfToolTip1.SetToolTip(c.GunaLabel2, "Το μέγεδος του αρχείου σε MB ή KB")
			If fileExtension = ".xlsx" Then
				c.GunaPictureBox1.Visible = True
				c.GunaPictureBox6.Visible = True
				c.GunaLabel3.Text = "Τύπος Αρχείου : Excel"
			ElseIf fileExtension = ".pdf" Then
				c.GunaPictureBox2.Visible = True
				c.GunaLabel3.Text = "Τύπος Αρχείου : PDF"
				c.GunaPictureBox6.Visible = True
			ElseIf fileExtension = ".png" OrElse fileExtension = ".jpg" OrElse fileExtension = ".jpeg" OrElse fileExtension = ".gif" Then
				c.GunaLabel3.Text = "Τύπος Αρχείου : Picture"
				c.GunaPictureBox3.Visible = True
			ElseIf fileExtension = ".zip" OrElse fileExtension = ".7z" OrElse fileExtension = ".rar" Then
				c.GunaLabel3.Text = "Τύπος Αρχείου : Zip File"
				c.GunaPictureBox5.Visible = True
			Else
				c.GunaLabel3.Text = "Τύπος Αρχείου : File"
				c.GunaPictureBox4.Visible = True
			End If
			GradientPanel2.Controls.Add(c)



			sumFiles = 0
			sumFiles = ListBox1.Items.Count
			Label3.Text = sumFiles.ToString
			fileSizesum = fileSizesum + fullLenght
			totalFilesSize = fileSizesum / 1024 / 1024
			Label4.Text = "Συνολικό μέγεθος αρχείων = " + totalFilesSize.ToString("N2") + " MB"
			GradientPanel2.BackgroundImage = Nothing
			Label1.Visible = False
			GunaProgressBar1.Value = 100 * totalFilesSize / 25
			Label7.Text = totalFilesSize.ToString("N2") + "/ 25MB"
			If totalFilesSize > 25 Then
				Label7.ForeColor = Color.Red
				Form1.Alert1("Φτάσατε το όριο των επιτρεπτών Αρχείων για αποστολή.", AlertForm.alertTypeEnum.Warning)
			End If
		Next
	End Sub

	Private Sub GradientPanel2_DragEnter(sender As Object, e As DragEventArgs) Handles GradientPanel2.DragEnter
		If e.Data.GetDataPresent(DataFormats.FileDrop) Then
			e.Effect = DragDropEffects.Copy

		End If
	End Sub



	Private Sub GunaAdvenceButton3_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton3.Click

		OpenFileDialog1.FileName = ""
		OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
		OpenFileDialog1.Filter = "All Files (*.*)|*.*|Excel files (*.xlsx)|*.xlsx|CSV Files (*.csv)|*.csv|XLS Files (*.xls)|*xls"

		If (OpenFileDialog1.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
			' GunaDataGridView1.Columns.Clear()

			Dim fi As New FileInfo(OpenFileDialog1.FileName)
			Dim FileName As String = OpenFileDialog1.FileName

			ListBox1.Items.Add(System.IO.Path.GetFullPath(OpenFileDialog1.FileName))


			len = ((New System.IO.FileInfo(OpenFileDialog1.FileName).Length) / 1024 / 1024).ToString("N2")
			fullLenght = New System.IO.FileInfo(OpenFileDialog1.FileName).Length
			If fullLenght > 100000 Then
				len = ((New System.IO.FileInfo(OpenFileDialog1.FileName).Length) / 1024 / 1024).ToString("N2") + " MB"
			Else
				len = ((New System.IO.FileInfo(OpenFileDialog1.FileName).Length) / 1024).ToString("N2") + " KB"
			End If
			fileExtension = System.IO.Path.GetExtension(OpenFileDialog1.FileName)
			'MsgBox(fileExtension)
			'ListBox2.Items.Add(System.IO.Path.GetFileName(OpenFileDialog1.FileName) + len)
			'ListBox3.Items.Add(fullLenght)
			Label2.Text = fullLenght
			For i = 0 To ListBox2.Items.Count - 1
				listco.Add(ListBox2.Items(i).ToString + "  " + " MB")
			Next
			Dim c As UserControl1 = New UserControl1
			c.Dock = DockStyle.Top
			c.BringToFront()
			c.Label1.Text = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)
			c.GunaLabel1.Text = "Όνομα Αρχείου: " + (System.IO.Path.GetFileName(OpenFileDialog1.FileName))
			c.GunaLabel2.Text = "Μέγεθος Αρχείου :  " + len
			c.GunaLabel4.Text = (New System.IO.FileInfo(OpenFileDialog1.FileName).Length) / 1024 / 1024
			c.SfToolTip1.SetToolTip(c.GunaLabel1, System.IO.Path.GetFullPath(OpenFileDialog1.FileName))
			c.SfToolTip1.SetToolTip(c.GunaLabel2, "Το μέγεδος του αρχείου σε MB ή KB")
			If fileExtension = ".xlsx" Then
				c.GunaPictureBox1.Visible = True
				c.GunaPictureBox6.Visible = True
				c.GunaLabel3.Text = "Τύπος Αρχείου : Excel"
			ElseIf fileExtension = ".pdf" Then
				c.GunaPictureBox2.Visible = True
				c.GunaLabel3.Text = "Τύπος Αρχείου : PDF"
			ElseIf fileExtension = ".png" OrElse fileExtension = ".jpg" OrElse fileExtension = ".jpeg" OrElse fileExtension = ".gif" Then
				c.GunaLabel3.Text = "Τύπος Αρχείου : Picture"
				c.GunaPictureBox3.Visible = True
			ElseIf fileExtension = ".zip" OrElse fileExtension = ".7z" OrElse fileExtension = ".rar" Then
				c.GunaLabel3.Text = "Τύπος Αρχείου : Zip File"
				c.GunaPictureBox5.Visible = True
			Else
				c.GunaLabel3.Text = "Τύπος Αρχείου : File"
				c.GunaPictureBox4.Visible = True
			End If
			GradientPanel2.Controls.Add(c)

		End If

		sumFiles = 0
		sumFiles = ListBox1.Items.Count
		Label3.Text = sumFiles.ToString
		fileSizesum = fileSizesum + fullLenght
		totalFilesSize = fileSizesum / 1024 / 1024
		Label4.Text = "Συνολικό μέγεθος αρχείων = " + totalFilesSize.ToString("N2") + " MB"
		GradientPanel2.BackgroundImage = Nothing
		Label1.Visible = False
		GunaProgressBar1.Value = 100 * totalFilesSize / 25
		Label7.Text = totalFilesSize.ToString("N2") + "/ 25MB"
		If totalFilesSize > 25 Then
			Label7.ForeColor = Color.Red
			Form1.Alert1("Φτάσατε το όριο των επιτρεπτών Αρχείων για αποστολή.", AlertForm.alertTypeEnum.Warning)
		End If
	End Sub
	Private Sub uploadMessage()
		Try
			Dim mail As New MailMessage()
			Dim SmtpServer As New SmtpClient("smtp.gmail.com")
			mail.From = New MailAddress("csforcesioannina@gmail.com")
			mail.[To].Add(GunaTextBox1.Text)
			mail.Subject = GunaComboBox1.SelectedItem.ToString + " Ημερομηνία: " + GunaDateTimePicker1.Text
			mail.Body = GunaLineTextBox2.Text

			'Dim attachment As System.Net.Mail.Attachment
			If ListBox1.Items.Count <> 0 Then ' This listbox holds the path of the files...
				For i = 0 To ListBox1.Items.Count - 1
					mail.Attachments.Add(New Attachment(ListBox1.Items.Item(i)))
				Next
			End If
			'attachment = New System.Net.Mail.Attachment("C:\Users\Akuaku\Desktop\fg.xlsx")
			'mail.Attachments.Add(attachment)

			SmtpServer.Port = 587
			SmtpServer.Credentials = New System.Net.NetworkCredential("csforcesioannina@gmail.com", "pwxjmrbsqzuayqht")
			SmtpServer.EnableSsl = True

			SmtpServer.Send(mail)
			MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
			MessageBoxAdv.Show("Το mail στάλθηκε με επιτυχία , θα σταλθεί απάντηση οταν γίνει ο έλεγχος του μέιλ!", "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Information)
			Form1.Alert1("Επιτυχημένη Αποστολή πακέτου", AlertForm.alertTypeEnum.Success)
			'MsgBox("sucess")
			GunaGradient2Panel1.Visible = False
			GunaGradient2Panel2.Visible = True
		Catch e As Exception

			Form1.Alert1("Αποτυχία Αποστολής πακέτου", AlertForm.alertTypeEnum.Error)
		End Try

		'MessageBox.Show("mail Send")
		'GunaProgressBar1.Visible = True
		'Timer1.Start()
	End Sub
	Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
		uploadMessage()
	End Sub

	Private Sub GunaGradient2Panel2_Paint(sender As Object, e As PaintEventArgs) Handles GunaGradient2Panel2.Paint

	End Sub
	Dim i As Integer = 0
	Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

	End Sub

	Private Sub GunaGradient2Panel2_MouseClick(sender As Object, e As MouseEventArgs) Handles GunaGradient2Panel2.MouseClick
		GunaGradient2Panel1.Visible = True
		GunaGradient2Panel2.Visible = False
		'GunaLabel2.ForeColor = Color.FromArgb(46, 204, 113)
		BackgroundWorker1.RunWorkerAsync()
	End Sub

	Private Sub GunaLabel2_Click(sender As Object, e As EventArgs) Handles GunaLabel2.Click
		GunaGradient2Panel1.Visible = True
		GunaGradient2Panel2.Visible = False
		'GunaLabel2.ForeColor = Color.FromArgb(46, 204, 113)
		BackgroundWorker1.RunWorkerAsync()
	End Sub

	Private Sub GunaButton8_Click(sender As Object, e As EventArgs) Handles GunaButton8.Click
		MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
		MessageBoxAdv.Show("Φόρμα Αποστολής E-Mail", "CS", MessageBoxButtons.OK, MessageBoxIcon.Information)
	End Sub

	Private Sub GunaLabel1_Click(sender As Object, e As EventArgs) Handles GunaLabel1.Click

	End Sub
End Class