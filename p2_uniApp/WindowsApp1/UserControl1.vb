Imports Syncfusion.Windows.Forms

Public Class UserControl1
    Private Sub GunaLinePanel1_Paint(sender As Object, e As PaintEventArgs) Handles GunaLinePanel1.Paint

    End Sub

    Private Sub GunaPictureBox6_Click(sender As Object, e As EventArgs) Handles GunaPictureBox6.Click
        MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro

        Dim result As DialogResult
        Try

            result = MessageBoxAdv.Show("Θέλετε να γίνει προεπισκόπηση;", "University of Ioannina", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                MessageBoxAdv.Show("Σφάλμα κατά την προεπισκόπηση του αρχείου(.pdf αρχεία αποδεκτά)", "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch
        End Try
    End Sub

    Private Sub GunaCircleButton2_Click(sender As Object, e As EventArgs) Handles GunaCircleButton2.Click
        Try
            Dim i As Integer = 0
            Dim finalIndex As Integer = 0
            For Each index In Form4.ListBox1.Items
                If index = Label1.Text Then
                    finalIndex = i
                End If
                i += 1
            Next

            links.sumFiles = links.sumFiles - 1
            links.Label3.Text = "Συνολικά αρχεία = " + links.sumFiles.ToString
            links.totalFilesSize = links.totalFilesSize - Convert.ToDouble(GunaLabel4.Text)
            links.fileSizesum = links.fileSizesum - Convert.ToDouble(GunaLabel4.Text) * 1024 * 1024
            links.Label7.Text = links.totalFilesSize.ToString("N2") + " / 25 MB"
            links.GunaProgressBar1.Value = 100 * links.totalFilesSize / 25
            links.ListBox1.Items.RemoveAt(finalIndex)
            links.GradientPanel2.Controls.Remove(Me)
        Catch ex As Exception
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
            MessageBoxAdv.Show(ex.Message, "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
