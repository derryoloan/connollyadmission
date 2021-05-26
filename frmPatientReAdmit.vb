Public Class frmPatientReAdmit
    Dim myAdmission As New Admission
    Dim myClearForm As New ClearForm
    Private Sub txtPatSymphony_TextChanged(sender As Object, e As EventArgs) Handles txtPatSymphony.TextChanged
        myAdmission.Symphony = txtPatSymphony.Text
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

    Private Sub btnReAdmit_Click(sender As Object, e As EventArgs) Handles btnReAdmit.Click
        If myAdmission.Symphony <> "" Then
            If myAdmission.Add_ReAdmission = True Then
                frmAdmission.txtPatMRN.Text = myAdmission.ID
                frmAdmission.txtPatName.Text = myAdmission.Name
                frmAdmission.txtPatArea.Text = myAdmission.Location
                frmAdmission.txtPatSymphony.Text = myAdmission.Symphony
                frmAdmission.dtpPatDOB.Value = myAdmission.DOB
                myClearForm.clearGrpBox(grpPatientID)
                txtPatSymphony.Text = ""
                frmAdmission.Show()
                Me.Close()
            Else messagebox.Show("Patient not Re-Admitted")
            End If
        Else MessageBox.Show("Please Enter a Symphony Number")
            txtPatSymphony.Focus()
        End If
    End Sub
End Class