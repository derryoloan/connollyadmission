Public Class frmPatientSearch
    Dim myPatient As New Patient
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtPatientID.Text <> "" Then

            If IsNumeric(txtPatientID.Text) = True Then
                Dim myfrmPatientIn As New frmPatientIn
                Dim myfrmPatientReAdmit As New frmPatientReAdmit
                Dim myfrmPatientClinic As New frmPatientClinic
                myPatient.ID = txtPatientID.Text
                Me.Cursor = Cursors.WaitCursor
                If myPatient.findID() <> False Then
                    Select Case myPatient.Status
                        Case = "ON RECORD"
                            myfrmPatientReAdmit.txtPatStatus.Text = myPatient.Status
                            myfrmPatientReAdmit.txtPatMRN.Text = myPatient.ID
                            myfrmPatientReAdmit.txtPatName.Text = myPatient.Name
                            myfrmPatientReAdmit.txtPatArea.Text = myPatient.Location
                            myfrmPatientReAdmit.dtpPatDOB.Value = myPatient.DOB
                            myfrmPatientReAdmit.Show()
                            Me.Close()
                            Me.Cursor = Cursors.Default
                        Case = "In-Patient"
                            myfrmPatientIn.txtPatMRN.Text = myPatient.ID
                            myfrmPatientIn.txtPatName.Text = myPatient.Name
                            myfrmPatientIn.txtPatSymphony.Text = myPatient.Symphony
                            myfrmPatientIn.txtPatStatus.Text = myPatient.Status
                            myfrmPatientIn.dtpPatDOB.Value = myPatient.DOB
                            myfrmPatientIn.txtPatArea.Text = myPatient.Location
                            myfrmPatientIn.Show()
                            Me.Close()
                            Me.Cursor = Cursors.Default
                        Case = "Clinic"
                            myfrmPatientClinic.txtPatMRN.Text = myPatient.ID
                            myfrmPatientClinic.txtPatName.Text = myPatient.Name
                            myfrmPatientClinic.txtPatSymphony.Text = myPatient.Symphony
                            myfrmPatientClinic.lblStatus.Text = myPatient.Status
                            myfrmPatientClinic.dtpPatDOB.Value = myPatient.DOB
                            myfrmPatientClinic.txtPatArea.Text = myPatient.Location
                            myfrmPatientClinic.Show()
                            Me.Close()
                            Me.Cursor = Cursors.Default
                    End Select


                Else
                    Me.Cursor = Cursors.Default
                    If MsgBox("Patient Not Found, Would you like to add a new patient?", MsgBoxStyle.YesNo, "Patient Not Found") = vbYes Then
                        Dim myfrmPatientNew As New frmPatientNew
                        myfrmPatientNew.ShowDialog()
                        Me.Close()
                    End If
                End If
            Else

                MessageBox.Show("Please enter a MRN")
                txtPatientID.Text = ""
                    txtPatientID.Focus()
                End If
            End If

    End Sub
End Class
