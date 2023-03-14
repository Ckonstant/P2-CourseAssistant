Imports System.Diagnostics
Imports System
Imports System.Security
Imports System.ComponentModel
Public Class newsFeed
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Process.Start(GunaLabel1.Text)
    End Sub

    Private Sub Label1_MouseHover(sender As Object, e As EventArgs) Handles Label1.MouseHover
        Label1.ForeColor = Color.Red
    End Sub

    Private Sub Label1_MouseLeave(sender As Object, e As EventArgs) Handles Label1.MouseLeave
        Label1.ForeColor = Color.FromArgb(70, 71, 117)
    End Sub

    Private Sub newsFeed_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_MouseEnter(sender As Object, e As EventArgs) Handles Label1.MouseEnter
        Label1.ForeColor = Color.Red
        ToolTip1.SetToolTip(Label1, Label1.Text)
    End Sub
End Class
