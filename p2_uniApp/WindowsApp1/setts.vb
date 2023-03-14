Imports System.Collections.Specialized
Imports System.IO
Imports Syncfusion.Windows.Forms

Public Class setts
    Private Sub GunaGoogleSwitch1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaWinSwitch1_CheckedChanged(sender As Object, e As EventArgs) Handles GunaWinSwitch1.CheckedChanged
        If GunaWinSwitch1.Checked = True Then
            Form1.GunaControlBox3.Visible = False
        Else
            Form1.GunaControlBox3.Visible = True
        End If
    End Sub

    Private Sub GunaWinSwitch4_CheckedChanged(sender As Object, e As EventArgs) Handles GunaWinSwitch4.CheckedChanged
        'MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
        ' MessageBoxAdv.Show("Μη διαθέσιμο πακέτο Θεμάτων προς το παρον!", "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub GunaWinSwitch2_CheckedChanged(sender As Object, e As EventArgs) Handles GunaWinSwitch2.CheckedChanged
        If GunaWinSwitch2.Checked = True Then
            Form1.GunaControlBox1.Visible = False
        Else
            Form1.GunaControlBox1.Visible = True
        End If
    End Sub

    Private Sub GunaWinSwitch5_CheckedChanged(sender As Object, e As EventArgs) Handles GunaWinSwitch5.CheckedChanged
        If GunaWinSwitch5.Checked = True Then
            Form1.hideGrade = True
        Else
            Form1.hideGrade = False
        End If
    End Sub

    Private Sub GunaAdvenceButton3_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton3.Click
        MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro

        Dim result As DialogResult = MessageBoxAdv.Show("Θέλετε να γίνει οριστική Διαγραφή όλων των πακέτων?", "University of Ioannina", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Try
                Dim packagePath As String = My.Application.Info.DirectoryPath + "\FULLDATA"
                Dim existPath As New IO.DirectoryInfo(packagePath) ''gunalabel7.text  = p.x = anaptiksi folder
                If existPath.Exists Then
                    System.IO.Directory.Delete(packagePath, True)
                    If Not Directory.Exists(My.Application.Info.DirectoryPath + "\FULLDATA\") Then
                        Directory.CreateDirectory(My.Application.Info.DirectoryPath + "\FULLDATA\")
                    End If
                Else
                    MessageBoxAdv.Show("Δεν υπάρχουν διαθέσιμα πακέτα για διαγραφή!", "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Catch ex As Exception
                MessageBoxAdv.Show(ex.Message, "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
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
    Private Sub setts_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro

        Dim result As DialogResult = MessageBoxAdv.Show("Θέλετε να αφαιρεθούν όλα τα μαθήματα από τα αγαπημένα?", "University of Ioannina", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        Try
            If result = DialogResult.Yes Then
                Dim saveTest As StringCollection = My.Settings.agaList
                For i = saveTest.Count - 1 To 0 Step -1

                    saveTest.RemoveAt(i)

                Next

                ' saveTest.RemoveAt(Form1.coursepos)
                My.Settings.agaList = saveTest
                My.Settings.Save()


            Else
            End If
        Catch ex As Exception
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
            MessageBoxAdv.Show(ex.Message, "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GunaAdvenceTileButton10_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton10.Click
        MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
        MessageBoxAdv.Show("Δεν Βρέθηκε νέα έκδοση !!", "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub GunaAdvenceTileButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton1.Click
        MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro

        Dim result As DialogResult = MessageBoxAdv.Show("Θέλετε να απεγκαταστήσετε την εφαρμογή?", "University of Ioannina", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            MessageBoxAdv.Show("ΣΦΑΛΜΑ!Δοκιμάστε να κάνετε απεγκατάσταση από τον πίνακα ελέγχου!", "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else


        End If
    End Sub

    Private Sub GunaButton8_Click(sender As Object, e As EventArgs) Handles GunaButton8.Click
        MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
        MessageBoxAdv.Show("Διάφορες Ρυθμίσεις,πολλές ρυθμίσεις υπό κατασκευή στο Beta", "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub GunaWinSwitch10_CheckedChanged(sender As Object, e As EventArgs) Handles GunaWinSwitch10.CheckedChanged
        If GunaWinSwitch10.Checked = True Then
            GunaLineTextBox1.Visible = False
        Else
            GunaLineTextBox1.Visible = True
        End If
    End Sub
End Class