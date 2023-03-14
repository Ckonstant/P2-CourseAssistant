Public Class Form3


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim usStates As New List(Of String)()
        usStates.Add("0")
        usStates.Add("0,5")
        usStates.Add("1")
        usStates.Add("1,5")
        usStates.Add("2")
        usStates.Add("2,5")
        usStates.Add("3")
        usStates.Add("3,5")
        usStates.Add("4")
        usStates.Add("4,5")
        usStates.Add("5")
        usStates.Add("5,5")
        usStates.Add("6")
        usStates.Add("6,5")
        usStates.Add("7")
        usStates.Add("7,5")
        usStates.Add("8")
        usStates.Add("8,5")
        usStates.Add("9")
        usStates.Add("9,5")
        usStates.Add("10")

        SfComboBox1.DataSource = usStates
        SfComboBox1.SelectedIndex = 0
        Me.Location = New Point(MousePosition)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SfComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SfComboBox1.SelectedIndexChanged

    End Sub

    Private Sub SfComboBox1_TextChanged(sender As Object, e As EventArgs) Handles SfComboBox1.TextChanged

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        My.Settings.vathmoiList.Item(Form1.coursepos) = SfComboBox1.SelectedItem
        My.Settings.Save()
        courseMain.nav_settings.PerformClick()
    End Sub
End Class