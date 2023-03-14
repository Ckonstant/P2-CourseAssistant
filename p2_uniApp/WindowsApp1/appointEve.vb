Imports Syncfusion.Schedule

Public Class appointEve
    Private Sub ok_Click(sender As Object, e As EventArgs) Handles ok.Click
        Dim dataprovider As ArrayListDataProvider = New Syncfusion.Schedule.ArrayListDataProvider()
        Dim appointment As IScheduleAppointment = dataprovider.NewScheduleAppointment()
        appointment = dataprovider.NewScheduleAppointment()
        appointment.StartTime = StartDateDateTimePickerAdv.Value
        appointment.EndTime = EndDateDateTimePickerAdv.Value
        appointment.AllDay = False
        appointment.Subject = SubjectTextBoxExt.Text
        appointment.LabelValue = comboBox1.SelectedItem
        appointment.MarkerValue = 2
        dataprovider.AddItem(appointment)

    End Sub
End Class