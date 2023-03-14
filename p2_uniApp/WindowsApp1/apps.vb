Imports Microsoft.Office.Interop.Word
Imports Microsoft.VisualBasic.FileIO
Imports Syncfusion.Windows.Forms

Public Class apps
    Private Sub apps_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GunaAdvenceTileButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton1.Click
        Process.Start("https://www.office.com/")
    End Sub

    Private Sub GunaAdvenceTileButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton2.Click
        Try
            Process.Start("WINWORD.exe")
        Catch

            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
            MessageBoxAdv.Show("Δεν βρέθηκε η εγκατάσταση της εφαρμογής", "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GunaAdvenceTileButton3_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton3.Click
        Try
            Process.Start("POWERPNT.exe")
        Catch

            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
            MessageBoxAdv.Show("Δεν βρέθηκε η εγκατάσταση της εφαρμογής", "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GunaAdvenceTileButton4_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton4.Click
        Process.Start("https://discord.gg/v6kJXC2KnY")
    End Sub

    Private Sub GunaAdvenceTileButton11_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton11.Click
        Try
            Process.Start("Excel.exe")
        Catch

            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
            MessageBoxAdv.Show("Δεν βρέθηκε η εγκατάσταση της εφαρμογής", "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GunaAdvenceTileButton8_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton8.Click
        Try
            Process.Start("OUTLOOK.exe")
        Catch

            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
            MessageBoxAdv.Show("Δεν βρέθηκε η εγκατάσταση της εφαρμογής", "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GunaAdvenceTileButton5_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton5.Click
        Try
            Process.Start("https://teams.microsoft.com/_?culture=el-gr&country=GR&lm=deeplink&lmsrc=homePageWeb&cmpid=WebSignIn#/scheduling-form/?startTime=Wed%20Apr%2013%202022%2014:30:00%20GMT%2B0300%20(Eastern%20European%20Summer%20Time)&endTime=Wed%20Apr%2013%202022%2015:00:00%20GMT%2B0300%20(Eastern%20European%20Summer%20Time)&opener=1&navCtx=time-block-click&calendarType=User&webinarType=None")
        Catch

            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
            MessageBoxAdv.Show("Δεν βρέθηκε η εγκατάσταση της εφαρμογής", "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GunaAdvenceTileButton6_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton6.Click
        Try
            Process.Start("https://www.wolframalpha.com/")
        Catch

            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
            MessageBoxAdv.Show("Δεν βρέθηκε η εγκατάσταση της εφαρμογής", "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GunaAdvenceTileButton7_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton7.Click
        Try
            Process.Start("https://drive.google.com/drive/u/2/folders/1Tz9JoMia5Jem5gwxFPBDo_19LyBqUgJN")
        Catch

            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
            MessageBoxAdv.Show("Δεν βρέθηκε η εγκατάσταση της εφαρμογής", "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GunaAdvenceTileButton9_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton9.Click
        Try
            Process.Start("https://ecourse.uoi.gr/")
        Catch

            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
            MessageBoxAdv.Show("Δεν βρέθηκε η εγκατάσταση της εφαρμογής", "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GunaAdvenceTileButton10_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton10.Click
        Try
            Process.Start("https://www.adobe.com/")
        Catch

            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
            MessageBoxAdv.Show("Δεν βρέθηκε η εγκατάσταση της εφαρμογής", "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class