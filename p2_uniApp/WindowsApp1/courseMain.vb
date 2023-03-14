Public Class courseMain

    Private Sub courseMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openChildForm(General)
    End Sub
    Private currentForm As Form = Nothing

    Public Sub openChildForm(childForm As Form)
        '' GunaTransition1.HideSync(currentForm)
        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        GunaPanel1.Controls.Add(childForm)
        GunaPanel1.Tag = childForm
        childForm.BringToFront()


        childForm.Show()



    End Sub


    Private Sub GunaAdvenceTileButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)
        'downCourses.Show()
    End Sub

    Private Sub GunaAdvenceTileButton10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaPanel1_Paint(sender As Object, e As PaintEventArgs) Handles GunaPanel1.Paint

    End Sub

    Private Sub nav_home_Click(sender As Object, e As EventArgs) Handles nav_home.Click
        Form1.pdfFlag = True
        If Application.OpenForms().OfType(Of courseFiles).Any Or Application.OpenForms().OfType(Of General).Any Then
            courseFiles.Close()
            General.Close()
            openChildForm(courseFiles)
        Else
            openChildForm(courseFiles)
        End If
    End Sub

    Private Sub nav_settings_Click(sender As Object, e As EventArgs) Handles nav_settings.Click
        If Application.OpenForms().OfType(Of courseFiles).Any Or Application.OpenForms().OfType(Of General).Any Then
            courseFiles.Close()
            General.Close()
            openChildForm(General)
        Else
            openChildForm(General)
        End If
    End Sub

    Private Sub GunaSeparator1_Click(sender As Object, e As EventArgs) Handles GunaSeparator1.Click

    End Sub

    Private Sub nav_history_Click(sender As Object, e As EventArgs) Handles nav_history.Click
        Form1.pdfFlag = False
        If Application.OpenForms().OfType(Of courseFiles).Any Or Application.OpenForms().OfType(Of General).Any Or Application.OpenForms().OfType(Of labs).Any Then
            courseFiles.Close()
            General.Close()
            labs.Close()
            openChildForm(labs)
        Else
            openChildForm(labs)
        End If
    End Sub

    Private Sub nav_profile_Click(sender As Object, e As EventArgs) Handles nav_profile.Click
        If Application.OpenForms().OfType(Of courseFiles).Any Or Application.OpenForms().OfType(Of General).Any Or Application.OpenForms().OfType(Of labs).Any Or Application.OpenForms().OfType(Of myFiles).Any Then
            courseFiles.Close()
            General.Close()
            labs.Close()
            myFiles.Close()

            openChildForm(myFiles)
        Else
            openChildForm(myFiles)
        End If
    End Sub
End Class