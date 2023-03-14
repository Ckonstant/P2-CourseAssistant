Imports Syncfusion.Windows.Forms

Public Class agaphmena
    Private Sub agaphmena_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try


            For Each x In My.Settings.agaList

                Dim c As courseControl = New courseControl
                c.GunaAdvenceTileButton1.Text = Form1.names(x)
                c.courseName.Text = Form1.names(x)
                FlowLayoutPanel1.Controls.Add(c)

            Next
        Catch ex As Exception
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
            MessageBoxAdv.Show(ex.Message, "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class