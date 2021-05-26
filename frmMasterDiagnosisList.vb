Public Class frmMasterDiagnosisList
    Dim mymaster As New Master

    Private Sub txtNewDiagnosis_TextChanged(sender As Object, e As EventArgs) Handles txtNewDiagnosis.TextChanged
        mymaster.Diagnosis = txtNewDiagnosis.Text
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtNewDiagnosis.Text <> "" Then
            mymaster.Diagnosis_ID = "x" & DateTime.Now
            If mymaster.AddDiagnosis() = True Then
                MessageBox.Show("New Diagnosis added")
                Dim RowCount As Integer = frmAdmission.dgvDiagnosis.Rows.Count - 1
                frmAdmission.dgvDiagnosis.Rows.Add(1)
                frmAdmission.dgvDiagnosis.Rows(RowCount).Cells(0).Value = mymaster.Diagnosis_ID
                frmAdmission.dgvDiagnosis.Rows(RowCount).Cells(1).Value = mymaster.Diagnosis
                RowCount = RowCount + 1
                frmAdmission.Show()
                Me.Close()
            Else
                MessageBox.Show("Diagnosis not added.")
            End If
        Else
            MessageBox.Show("Please Ensure Diagnosis is filled in")
        End If
    End Sub

    Private Sub lstvMasterDiagnosisList_DoubleClick(sender As Object, e As EventArgs) Handles lstvMasterDiagnosisList.DoubleClick

        Dim RowCount As Integer = frmAdmission.dgvDiagnosis.Rows.Count - 1
        frmAdmission.dgvDiagnosis.Rows.Add(1)
        frmAdmission.dgvDiagnosis.Rows(RowCount).Cells(0).Value = lstvMasterDiagnosisList.SelectedItems(0).Text
        frmAdmission.dgvDiagnosis.Rows(RowCount).Cells(1).Value = lstvMasterDiagnosisList.SelectedItems(0).SubItems(1).Text
        RowCount = RowCount + 1
        frmAdmission.Show()
        Me.Close()

    End Sub


End Class