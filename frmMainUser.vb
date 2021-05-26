Public Class frmMainUser
    Dim myPatient As New Patient

    Private Sub picActivePatients_DoubleClick(sender As Object, e As EventArgs) Handles picActivePatients.DoubleClick
        Dim myfrmPatientList As New frmPatientInList
        myPatient.PatientDetails = myfrmPatientList.lstPatientDetails
        myPatient.Status = "In-Patient"
        Me.Cursor = Cursors.WaitCursor
        myPatient.findStatus()
        myfrmPatientList.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub picSearch_DoubleClick(sender As Object, e As EventArgs) Handles picSearch.DoubleClick
        Dim myFrmPatientSearch As New frmPatientSearch
        myFrmPatientSearch.Show()
    End Sub

    Private Sub btnDeveloper_Click(sender As Object, e As EventArgs) Handles btnDeveloper.Click
        frmMainMenu.Show()
        Me.Close()
    End Sub



    Private Sub picClinicPatients_DoubleClick(sender As Object, e As EventArgs) Handles picClinicPatients.DoubleClick
        Dim myfrmPatientList As New frmPatientInList
        myPatient.PatientDetails = myfrmPatientList.lstPatientDetails
        myPatient.Status = "Clinic"
        Me.Cursor = Cursors.WaitCursor
        myPatient.findStatus()
        myfrmPatientList.Show()
        Me.Cursor = Cursors.Default
    End Sub


End Class