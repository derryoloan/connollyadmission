Public Class frmMaintenance
    Dim myMaster As New Master
    ''Diagnosis
    Private Sub txtDiagnosis_ID_TextChanged(sender As Object, e As EventArgs) Handles txtDiagnosis_ID.TextChanged
        myMaster.Diagnosis_ID = txtDiagnosis_ID.Text
    End Sub

    Private Sub txtDiagnosis_TextChanged(sender As Object, e As EventArgs) Handles txtDiagnosis.TextChanged
        myMaster.Diagnosis = txtDiagnosis.Text
    End Sub

    Private Sub btnAddDiagnosis_Click(sender As Object, e As EventArgs) Handles btnAddDiagnosis.Click
        If myMaster.AddDiagnosis() = True Then
            MessageBox.Show("Diagnosis Added to Databse")
        Else
            MessageBox.Show("Diagnosis not Added to Database")
        End If
        txtDiagnosis.Text = ""
        txtDiagnosis_ID.Text = ""
        txtDiagnosis_ID.Focus()
    End Sub
    ''Family History
    Private Sub txtFamilyHistoryID_TextChanged(sender As Object, e As EventArgs) Handles txtFamilyHistoryID.TextChanged
        myMaster.FamilyHistory_ID = txtFamilyHistoryID.Text
    End Sub

    Private Sub txtFamilyHistory_TextChanged(sender As Object, e As EventArgs) Handles txtFamilyHistory.TextChanged
        myMaster.FamilyHistory = txtFamilyHistory.Text
    End Sub

    Private Sub btnAddFamilyHistory_Click(sender As Object, e As EventArgs) Handles btnAddFamilyHistory.Click
        If myMaster.AddFamilyHistory() = True Then
            MessageBox.Show("Family History Added to Databse")
        Else
            MessageBox.Show("Family History not Added to Database")
        End If
        txtFamilyHistory.Text = ""
        txtFamilyHistoryID.Text = ""
        txtFamilyHistoryID.Focus()
    End Sub
    ''Risk Factor
    Private Sub txtRiskFactor_ID_TextChanged(sender As Object, e As EventArgs) Handles txtRiskFactor_ID.TextChanged
        myMaster.RiskFactor_ID = txtRiskFactor_ID.Text
    End Sub

    Private Sub txtRiskFactor_TextChanged(sender As Object, e As EventArgs) Handles txtRiskFactor.TextChanged
        myMaster.RiskFactor = txtRiskFactor.Text
    End Sub
    Private Sub btnAddRiskFactor_Click(sender As Object, e As EventArgs) Handles btnAddRiskFactor.Click
        If myMaster.AddRiskFactor() = True Then
            MessageBox.Show("Diagnosis Added to Databse")
        Else
            MessageBox.Show("Diagnosis not Added to Database")
        End If
        txtRiskFactor.Text = ""
        txtRiskFactor_ID.Text = ""
        txtRiskFactor_ID.Focus()
    End Sub
    'Presenting Complaint
    Private Sub txtPresentingComplaint_ID_TextChanged(sender As Object, e As EventArgs) Handles txtPresentingComplaint_ID.TextChanged
        myMaster.PC_ID = txtPresentingComplaint_ID.Text
    End Sub

    Private Sub txtPresentingComplaint_TextChanged(sender As Object, e As EventArgs) Handles txtPresentingComplaint.TextChanged
        myMaster.PresentingComplaint = txtPresentingComplaint.Text
    End Sub

    Private Sub btnAddPresentingComplaint_Click(sender As Object, e As EventArgs) Handles btnAddPresentingComplaint.Click
        If myMaster.AddPresentingComplaint() = True Then
            MessageBox.Show("Presenting Complaint Added to Databse")
        Else
            MessageBox.Show("Presenting Complaint not Added to Database")
        End If
        txtPresentingComplaint_ID.Text = ""
        txtPresentingComplaint.Text = ""
        txtPresentingComplaint_ID.Focus()
    End Sub
    '' Medical Surgical History
    Private Sub txtMedicalHistory_ID_TextChanged(sender As Object, e As EventArgs) Handles txtMedicalHistory_ID.TextChanged
        myMaster.MedicalHistory_ID = txtMedicalHistory_ID.Text
    End Sub

    Private Sub txtMedicalHistory_TextChanged(sender As Object, e As EventArgs) Handles txtMedicalHistory.TextChanged
        myMaster.MedicalHistory = txtMedicalHistory.Text
    End Sub

    Private Sub btnAddMedicalHistory_Click(sender As Object, e As EventArgs) Handles btnAddMedicalHistory.Click
        If myMaster.AddMedicalHistory() = True Then
            MessageBox.Show("Medical Surgical History Added to Databse")
        Else
            MessageBox.Show("Medical Surgical History not Added to Database")
        End If
        txtMedicalHistory_ID.Text = ""
        txtMedicalHistory.Text = ""
        txtMedicalHistory_ID.Focus()
    End Sub

    '' Medication

    Private Sub txtMedication_ID_TextChanged(sender As Object, e As EventArgs) Handles txtMedication_ID.TextChanged
        myMaster.Medication_ID = txtMedication_ID.Text
    End Sub

    Private Sub txtMedicationName_TextChanged(sender As Object, e As EventArgs) Handles txtMedicationName.TextChanged
        myMaster.MedicationName = txtMedicationName.Text
    End Sub



    Private Sub btnAddMedicationName_Click(sender As Object, e As EventArgs) Handles btnAddMedicationName.Click
        If myMaster.AddMedication() = True Then
            MessageBox.Show("Medication Added to Database")
        Else
            MessageBox.Show("Medication not Added to Database")
        End If

    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtMedication_ID.Text = ""
        txtMedicationName.Text = ""
        txtMedicalHistory_ID.Focus()
    End Sub
    ''               Registrar
    Private Sub txtReg_ID_TextChanged(sender As Object, e As EventArgs) Handles txtReg_ID.TextChanged
        myMaster.Reg_ID = txtReg_ID.Text
    End Sub

    Private Sub txtRegName_TextChanged(sender As Object, e As EventArgs) Handles txtRegName.TextChanged
        myMaster.RegName = txtRegName.Text
    End Sub

    Private Sub btnAddReg_Click(sender As Object, e As EventArgs) Handles btnAddReg.Click
        If myMaster.AddReg() = True Then
            MessageBox.Show("Registrar Added to Databse")
        Else
            MessageBox.Show("Registrar not Added to Database")
        End If
        txtReg_ID.Text = ""
        txtRegName.Text = ""
        txtReg_ID.Focus()
    End Sub
    ''                      Consultant
    Private Sub txtConsultant_ID_TextChanged(sender As Object, e As EventArgs) Handles txtConsultant_ID.TextChanged
        myMaster.Consultant_ID = txtConsultant_ID.Text
    End Sub

    Private Sub txtConsultant_TextChanged(sender As Object, e As EventArgs) Handles txtConsultant.TextChanged
        myMaster.ConsultantName = txtConsultant.Text
    End Sub

    Private Sub btnAddConsultant_Click(sender As Object, e As EventArgs) Handles btnAddConsultant.Click
        If myMaster.AddConsultant() = True Then
            MessageBox.Show("Consultant Added to Databse")
        Else
            MessageBox.Show("Consultant not Added to Database")
        End If
        txtConsultant_ID.Text = ""
        txtConsultant.Text = ""
        txtConsultant_ID.Focus()
    End Sub

    Private Sub btnClear_Click_1(sender As Object, e As EventArgs) Handles btnClear.Click

    End Sub
End Class