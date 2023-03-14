Public Class weekMenu
    Private Sub GunaAdvenceButton5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub weekMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pnt As Point
        pnt = (GridScheduleSample.calendar.GunaAdvenceButton1.PointToScreen(Point.Empty))
        pnt.X = pnt.X - 100
        pnt.Y = pnt.Y + 34
        Me.Location = pnt
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaAdvenceButton5_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaAdvenceButton4_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton4.Click

    End Sub

    Private Sub GunaAdvenceButton3_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton3.Click
        GridScheduleSample.calendar.menuItem12.PerformClick()
        GridScheduleSample.calendar.GunaAdvenceButton1.Text = "Ημέρα"
        Me.Close()
    End Sub

    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton2.Click
        GridScheduleSample.calendar.menuItem13.PerformClick()
        GridScheduleSample.calendar.GunaAdvenceButton1.Text = "Εργάσιμη"
        Me.Close()
    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        GridScheduleSample.calendar.menuItem14.PerformClick()
        GridScheduleSample.calendar.GunaAdvenceButton1.Text = "Εβδομάδα"
        Me.Close()
    End Sub

    Private Sub GunaAdvenceButton5_Click_2(sender As Object, e As EventArgs) Handles GunaAdvenceButton5.Click
        GridScheduleSample.calendar.menuItem15.PerformClick()
        GridScheduleSample.calendar.GunaAdvenceButton1.Text = "Μήνας"
        Me.Close()
    End Sub

    Private Sub weekMenu_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        Me.Close()
        Form1.BringToFront()
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class