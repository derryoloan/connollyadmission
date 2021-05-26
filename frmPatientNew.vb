Public Class frmPatientNew
    Dim myClearForm As New ClearForm
    Dim myPatient As New Patient
    Dim myAdmission As New Admission

    Private Sub frmPatientNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtPatName_TextChanged(sender As Object, e As EventArgs) Handles txtPatName.TextChanged
        myPatient.Name = txtPatName.Text
    End Sub

    Private Sub txtPatMRN_TextChanged(sender As Object, e As EventArgs) Handles txtPatMRN.TextChanged
        myPatient.ID = txtPatMRN.Text
    End Sub

    Private Sub txtPatArea_TextChanged(sender As Object, e As EventArgs) Handles txtPatArea.TextChanged
        myPatient.Location = txtPatArea.Text
    End Sub

    Private Sub txtPatSymphony_TextChanged(sender As Object, e As EventArgs) Handles txtPatSymphony.TextChanged
        myPatient.Symphony = txtPatSymphony.Text
    End Sub

    Private Sub dtpPatDOB_ValueChanged(sender As Object, e As EventArgs) Handles dtpPatDOB.ValueChanged
        myPatient.DOB = dtpPatDOB.Value
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If (myPatient.Name <> "" And myPatient.ID <> "" And myPatient.Location <> "" And myPatient.Symphony <> "" And myPatient.DOB.ToString <> "1/1/0001 12:00:00 AM") Then
            myPatient.Status = "In-Patient"
            If myPatient.AddPatientDetails() = True Then
                MessageBox.Show("Patient Details Saved")

                frmAdmission.txtPatMRN.Text = myPatient.ID
                frmAdmission.txtPatName.Text = myPatient.Name
                frmAdmission.txtPatArea.Text = myPatient.Location
                frmAdmission.txtPatSymphony.Text = myPatient.Symphony
                frmAdmission.dtpPatDOB.Value = myPatient.DOB
                myClearForm.clearGrpBox(grpPatientDetails)
                frmAdmission.Show()
                Me.Close()
            Else
                MessageBox.Show("Patient Details Not Saved")
            End If
        Else MessageBox.Show("Please Ensure all fields are filled in")
        End If
    End Sub

    Private Sub txtPatSymphony_MouseHover(sender As Object, e As EventArgs) Handles txtPatSymphony.MouseHover
        lblSymphony.Visible = True
    End Sub

    Private Sub txtPatSymphony_MouseLeave(sender As Object, e As EventArgs) Handles txtPatSymphony.MouseLeave
        lblSymphony.Visible = False
    End Sub
End Class