
Public Class frmPatientIn

    Dim myAdmission As New Admission
    Private Sub frmPatientIn_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub btnAdmissionScreen_Click(sender As Object, e As EventArgs) Handles btnAdmissionScreen.Click
        frmAdmission.txtPatMRN.Text = myAdmission.ID
        frmAdmission.txtPatName.Text = myAdmission.Name
        frmAdmission.txtPatArea.Text = myAdmission.Location
        frmAdmission.txtPatSymphony.Text = myAdmission.Symphony
        frmAdmission.dtpPatDOB.Value = myAdmission.DOB
        frmAdmission.Show()
        Me.Close()
    End Sub

    Private Sub txtPatName_TextChanged(sender As Object, e As EventArgs) Handles txtPatName.TextChanged
        myAdmission.Name = txtPatName.Text
    End Sub

    Private Sub txtPatMRN_TextChanged(sender As Object, e As EventArgs) Handles txtPatMRN.TextChanged
        myAdmission.ID = txtPatMRN.Text
    End Sub

    Private Sub txtPatArea_TextChanged(sender As Object, e As EventArgs) Handles txtPatArea.TextChanged
        myAdmission.Location = txtPatArea.Text
    End Sub

    Private Sub dtpPatDOB_ValueChanged(sender As Object, e As EventArgs) Handles dtpPatDOB.ValueChanged
        myAdmission.DOB = dtpPatDOB.Value
    End Sub

    Private Sub txtPatSymphony_TextChanged(sender As Object, e As EventArgs) Handles txtPatSymphony.TextChanged
        myAdmission.Symphony = txtPatSymphony.Text
    End Sub

    Private Sub btnDischarge_Click(sender As Object, e As EventArgs) Handles btnDischarge.Click
        myAdmission.Status = txtPatStatus.Text
        myAdmission.DischargeDate = dtpDischargeDate.Value
        If myAdmission.CloseCurrentAdmission() = True Then
            MessageBox.Show("Patient Set to On Record")
            frmMainUser.Show()
            Me.Close()
        Else
            MessageBox.Show("Admission not Changed")
        End If
    End Sub

    Private Sub dtpAppointmentDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpAppointmentDate.ValueChanged
        myAdmission.AppointmentDate = dtpAppointmentDate.Value
    End Sub

    Private Sub btnAddClinic_Click(sender As Object, e As EventArgs) Handles btnAddClinic.Click
        If myAdmission.AddClinic = True Then
            MessageBox.Show("Clinic Date Added")
            frmMainUser.Show()
            Me.Close()
        Else messagebox.Show("Clinic Date Not Added")
        End If
    End Sub
End Class