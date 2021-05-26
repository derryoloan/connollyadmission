Public Class FrmDischargeMedicationSearch
    Dim myMaster As New Master
    Private Sub txtNewMedication_TextChanged(sender As Object, e As EventArgs) Handles txtNewMedication.TextChanged
        myMaster.MedicationName = txtNewMedication.Text
    End Sub



    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtNewMedication.Text <> "" Then
            myMaster.Medication_ID = "x" & DateTime.Now
            If myMaster.AddMedication() = True Then
                MessageBox.Show("New Medication added")
                Dim RowCount As Integer = frmAdmission.dgvMeds.Rows.Count
                frmAdmission.dgvDischargeMeds.Rows.Add(1)
                frmAdmission.dgvDischargeMeds.Rows(RowCount).Cells(1).Value = myMaster.MedicationName
                frmAdmission.dgvDischargeMeds.Rows(RowCount).Cells(0).Value = myMaster.Medication_ID
                RowCount = RowCount + 1
                txtNewMedication.Text = ""
                frmAdmission.Show()
                Me.Close()
            Else
                MessageBox.Show("Medication not added.")
            End If
        Else
            MessageBox.Show("Please Ensure Both Medication Name and Strength are filled in")
        End If
    End Sub

    Private Sub lstvMasterMedicationList_DoubleClick(sender As Object, e As EventArgs) Handles lstvMasterMedicationList.DoubleClick

        Dim RowCount As Integer = frmAdmission.dgvDischargeMeds.Rows.Count
        frmAdmission.dgvDischargeMeds.Rows.Add(1)
        frmAdmission.dgvDischargeMeds.Rows(RowCount).Cells(0).Value = lstvMasterMedicationList.SelectedItems(0).Text
        frmAdmission.dgvDischargeMeds.Rows(RowCount).Cells(1).Value = lstvMasterMedicationList.SelectedItems(0).SubItems(1).Text
        frmAdmission.dgvDischargeMeds.Rows(RowCount).Cells(3).Value = "New Medication"
        frmAdmission.dgvDischargeMeds.Columns(0).ReadOnly = True
        frmAdmission.dgvDischargeMeds.Columns(1).ReadOnly = True
        frmAdmission.dgvDischargeMeds.Rows(RowCount).Selected = True
        frmAdmission.dgvDischargeMeds.CurrentCell = frmAdmission.dgvDischargeMeds.Rows(RowCount).Cells(2)
        RowCount = RowCount + 1
        frmAdmission.Show()
        Me.Close()
    End Sub
End Class