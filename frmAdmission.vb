Imports System.ComponentModel

Public Class frmAdmission
    Dim myAdmission As New Admission
    Dim myMaster As New Master
    Dim myDocument As New Document
    Private Sub frmAdmission_Load(sender As Object, e As EventArgs) Handles Me.Load


        'Admission Details

        'Add Master Selections
        myMaster.findConsultantList(cmbConsultant)
        myMaster.findRiskFactor(cmbRelRisk)
        'Set up Patient Infinity Boxes
        myAdmission.MedicalSurgicalList = lstvMedicalHistory
        myAdmission.RiskList = lstRelRisk
        myAdmission.FamilyRiskList = dgvFamilyRisk

        ''Admission Infinity Boxes
        myAdmission.PresentingComplaintList = dgvPresentingComplaint
        myAdmission.MedicationList = dgvMeds
        myAdmission.DischargeMedication = dgvDischargeMeds
        myAdmission.DiagnosisGrid = dgvDiagnosis
        myAdmission.DischargeDiagnosisList = dgvDischargeDiagnosis

        myAdmission.LabsDataGridView = dgLabView
        myAdmission.ProgressGrid = dgvProgressList

        'Set up Labs
        myAdmission.LabsDataGridView = dgLabView
        ''Set up Physical Examination
        myAdmission.Vitals = dgvVitals
        myAdmission.PhysicalSigns = dgvPhysicalSigns
        myAdmission.Organs = dgvOrgans
        myAdmission.Limbs = dgvLimbs
        myAdmission.PhysicalAssesment = dgvPhysicalAssesment
        'Patient Social History
        myAdmission.SocialHistory = dgvSocialHistory
        'Image
        myAdmission.Image = dgvImage
        'Previous History
        myAdmission.PreviousDiagnosis = dgvPreviousDiagnosis
        myAdmission.PreviousMedication = dgvPreviousMeds
        'Procedures
        myAdmission.ProcedureList = lvProcedureList



        '                                           Fill out Patient
        myAdmission.findPatientView()




        ''                                        Fill out Admission
        myAdmission.findAdmissionView()





        'Set up other Admission Boxes
        'Basic
        dtpAdmissionDate.Value = myAdmission.AdmissionDate
        dtpAdmissionTime.Value = myAdmission.AdmissionTime
        If myAdmission.Ward <> "" Then
            txtWard.Text = myAdmission.Ward
        Else txtWard.Text = "Not Entered"
        End If

        'Doctor
        If myAdmission.AdmittingDr <> "" Then
            txtDoctor.Text = myAdmission.AdmittingDr
        Else txtDoctor.Text = "Not Entered"
        End If
        If myAdmission.MCRN <> "" Then
            txtMCRN.Text = myAdmission.MCRN
        Else txtMCRN.Text = "Not Entered"
        End If
        If myAdmission.Bleep <> "" Then
            txtBleep.Text = myAdmission.Bleep
        Else txtBleep.Text = "Not Entered"
        End If

        If myAdmission.Consultant <> "" Then
            cmbConsultant.Text = myAdmission.Consultant
        Else cmbConsultant.Text = "Not Entered"
        End If


        'Referral
        If myAdmission.ReferralReason <> "" Then
            txtRefReason.Text = myAdmission.ReferralReason
        Else txtRefReason.Text = "Not Entered"
        End If

        dtpReferralDate.Value = myAdmission.ReferralDate
        dtpReferralTime.Value = myAdmission.ReferralTime
        dtpDateSeen.Value = myAdmission.DateSeen
        dtpSeenTime.Value = myAdmission.SeenTime
        'Pre Admission Medication
        cmbMedSource.Text = myAdmission.PreAdmMedSource
        txtMedSourceName.Text = myAdmission.PreAdmSourceName
        txtMedSourceTelNum.Text = myAdmission.PreAdmSourceTel
        dtpPreAdmMedDate.Value = myAdmission.PreAdmMedDate
        dgvMeds = myAdmission.MedicationList
        dgvMeds.Columns(0).ReadOnly = True
        dgvMeds.Columns(1).ReadOnly = True
        'Lab Results
        dgLabView = myAdmission.LabsDataGridView


        If dgLabView.Rows.Count <= 1 Then

            dgLabView.Columns.Add("Heading", "Test")
            dgLabView.Columns.Add("LabDate", "Results")
            dgLabView.Rows.Add(17)
            dgLabView.Rows(0).Cells(0).Value = "Date"
            dgLabView.Rows(1).Cells(0).Value = "FBC-Hb"
            dgLabView.Rows(2).Cells(0).Value = "FBC-MCV"
            dgLabView.Rows(3).Cells(0).Value = "FBC-MCH"
            dgLabView.Rows(4).Cells(0).Value = "FBC-HCT"
            dgLabView.Rows(5).Cells(0).Value = "FBC-WCC"
            dgLabView.Rows(6).Cells(0).Value = "FBC-Neutr"
            dgLabView.Rows(7).Cells(0).Value = "FBC-Lymph"
            dgLabView.Rows(8).Cells(0).Value = "FBC-Plts"
            dgLabView.Rows(9).Cells(0).Value = "Marker-CRP"
            dgLabView.Rows(10).Cells(0).Value = "Marker-ESR"
            dgLabView.Rows(11).Cells(0).Value = "U&E-Urea"
            dgLabView.Rows(12).Cells(0).Value = "U&E-Creatinine"
            dgLabView.Rows(13).Cells(0).Value = "U&E-EGFr"
            dgLabView.Rows(14).Cells(0).Value = "U&E-Na"
            dgLabView.Rows(15).Cells(0).Value = "U&E-K+"
            dgLabView.Rows(16).Cells(0).Value = "U&E-Ca(Correct)"

        End If
        dgLabView.Columns(0).ReadOnly = True
        Dim labColumnCount As Integer
        For labColumnCount = 0 To dgLabView.Columns.Count - 1
            dgLabView.Columns(labColumnCount).SortMode = DataGridViewColumnSortMode.NotSortable
        Next
        dgLabView.SelectionMode = DataGridViewSelectionMode.FullColumnSelect
        ''Progress Notes
        dgvProgressList = myAdmission.ProgressGrid

        Dim newProgressRow As Integer = dgvProgressList.Rows.Count()
        dgvProgressList.Columns(0).Width = 170
        dgvProgressList.Columns(1).Width = 750
        dgvProgressList.Rows.Add()
        dgvProgressList.Rows(newProgressRow).Cells(0).Value = DateTime.Now
        dgvProgressList.Rows(newProgressRow).Selected = True
            dgvProgressList.Focus()
            dgvProgressList.CurrentCell = dgvProgressList.Rows(newProgressRow).Cells(1)


        'PresentingComplaint
        dgvPresentingComplaint.Columns(0).Width = 100
        dgvPresentingComplaint.Columns(1).Width = 900
        dgvPresentingComplaint = myAdmission.PresentingComplaintList
        'FamilyRisk
        dgvFamilyRisk = myAdmission.FamilyRiskList
        'Diagnosis Lists
        dgvDiagnosis.Columns(1).Width = 150
        dgvDiagnosis.Columns(2).Width = 650
        dgvDiagnosis = myAdmission.DiagnosisGrid

        dgvDischargeDiagnosis = myAdmission.DischargeDiagnosisList
        dgvDischargeDiagnosis.Columns(1).Width = 150
        dgvDischargeDiagnosis.Columns(2).Width = 650
        'Physical Examination
        ''Datagrids
        dgvVitals.Columns(0).Width = 170
        dgvOrgans.Columns(0).Width = 200
        dgvLimbs.Columns(0).Width = 150
        dgvPhysicalAssesment.Columns(0).Width = 160
        dgvPhysicalSigns.Columns(0).Width = 150
        dgvVitals = myAdmission.Vitals
        dgvPhysicalSigns = myAdmission.PhysicalSigns
        dgvOrgans = myAdmission.Organs
        dgvLimbs = myAdmission.Limbs
        dgvPhysicalAssesment = myAdmission.PhysicalAssesment
        ''Radiobuttons
        If myAdmission.Fluid = "Wet" Then
            radioWet.Checked = True
            radioDry.Checked = False
        End If
        If myAdmission.Fluid = "Dry" Then
            radioDry.Checked = True
            radioWet.Checked = False
        End If
        If myAdmission.Condition = "Well" Then
            radioWell.Checked = True
            radioUnwell.Checked = False
        End If
        If myAdmission.Condition = "Unwell" Then
            radioUnwell.Checked = True
            radioWell.Checked = False
        End If
        ''Vitals DataGrid
        If dgvVitals.Rows.Count < 1 Then
            dgvVitals.Columns.Add("Vitals", "Vitals")
            dgvVitals.Columns.Add("vitalFinding", "Finding")
            dgvVitals.Rows.Add(11)
            dgvVitals.Rows(0).Cells(0).Value = "Temperature"
            dgvVitals.Rows(1).Cells(0).Value = "Heart Rate"
            dgvVitals.Rows(2).Cells(0).Value = "BP(Lying)"
            dgvVitals.Rows(3).Cells(0).Value = "BP(Standing)"
            dgvVitals.Rows(4).Cells(0).Value = "Resp.Rate"
            dgvVitals.Rows(5).Cells(0).Value = "O2 Sats"
            dgvVitals.Rows(6).Cells(0).Value = "GCS"
            dgvVitals.Rows(7).Cells(0).Value = "4AT"
            dgvVitals.Rows(8).Cells(0).Value = "Orientation-Time"
            dgvVitals.Rows(9).Cells(0).Value = "Orientation-Person"
            dgvVitals.Rows(10).Cells(0).Value = "Orientation-Place"
        End If
        ''PhysicalSigns DataGrid
        If dgvPhysicalSigns.Rows.Count < 1 Then
            dgvPhysicalSigns.Columns.Add("physicalSign", "Physical Sign")
        dgvPhysicalSigns.Columns.Add("physicalFinding", "Finding")
        dgvPhysicalSigns.Rows.Add(8)
        dgvPhysicalSigns.Rows(0).Cells(0).Value = "Hands&Nails"
        dgvPhysicalSigns.Rows(1).Cells(0).Value = "Eyes"
        dgvPhysicalSigns.Rows(2).Cells(0).Value = "ENT"
        dgvPhysicalSigns.Rows(3).Cells(0).Value = "Breasts"
        dgvPhysicalSigns.Rows(4).Cells(0).Value = "JVP"
        dgvPhysicalSigns.Rows(5).Cells(0).Value = "Carotid Bruits"
        dgvPhysicalSigns.Rows(6).Cells(0).Value = "Cervical LNs"
            dgvPhysicalSigns.Rows(7).Cells(0).Value = "Axillary LNs"
        End If
        ''Organs Datagrid
        If dgvOrgans.Rows.Count < 1 Then
                dgvOrgans.Columns.Add("Organ", "Organ")
            dgvOrgans.Columns.Add("organFinding", "Finding")
            dgvOrgans.Columns(0).Width = 180
            dgvOrgans.Rows.Add(18)
                dgvOrgans.Rows(0).Cells(0).Value = "HeartS1"
                dgvOrgans.Rows(1).Cells(0).Value = "HeartS2"
                dgvOrgans.Rows(2).Cells(0).Value = "Heart Added Sounds"
                dgvOrgans.Rows(3).Cells(0).Value = "Heart Murmers"
                dgvOrgans.Rows(4).Cells(0).Value = "Chest Left"
                dgvOrgans.Rows(5).Cells(0).Value = "Chest Right"
                dgvOrgans.Rows(6).Cells(0).Value = "Abdomen AAA"
                dgvOrgans.Rows(7).Cells(0).Value = "Abdomen Bowel Sounds"
                dgvOrgans.Rows(8).Cells(0).Value = "Abdomen Hernia"
                dgvOrgans.Rows(9).Cells(0).Value = "Abdomen PR"
                dgvOrgans.Rows(10).Cells(0).Value = "Cranial 2"
                dgvOrgans.Rows(11).Cells(0).Value = "Cranial 3 4 6"
                dgvOrgans.Rows(12).Cells(0).Value = "Cranial 5"
                dgvOrgans.Rows(13).Cells(0).Value = "Cranial 7"
                dgvOrgans.Rows(14).Cells(0).Value = "Cranial 8"
                dgvOrgans.Rows(15).Cells(0).Value = "Cranial 9 10"
                dgvOrgans.Rows(16).Cells(0).Value = "Cranial 11"
                dgvOrgans.Rows(17).Cells(0).Value = "Cranial 12"
            End If
            ''Add Limbs
            If dgvLimbs.Rows.Count < 1 Then
            dgvLimbs.Columns.Add("Blank", "")
            dgvLimbs.Columns.Add("RightArm", "Right Arm")
            dgvLimbs.Columns.Add("LeftArm", "Left Arm")
            dgvLimbs.Columns.Add("RightLeg", "Right Leg")
            dgvLimbs.Columns.Add("LeftLeg", "Left Leg")
            dgvLimbs.Rows.Add(6)
            dgvLimbs.Rows(0).Cells(0).Value = "Tone"
            dgvLimbs.Rows(1).Cells(0).Value = "Power"
            dgvLimbs.Rows(2).Cells(0).Value = "Reflexes"
            dgvLimbs.Rows(3).Cells(0).Value = "Co-Ordination"
            dgvLimbs.Rows(4).Cells(0).Value = "Sensation"
            dgvLimbs.Rows(5).Cells(0).Value = "Plantars"
        End If
        ''Add Assesment
        If dgvPhysicalAssesment.Rows.Count < 1 Then
            dgvPhysicalAssesment.Columns.Add("Area", "Area")
            dgvPhysicalAssesment.Columns.Add("Assesment", "Assesment")
            dgvPhysicalAssesment.Rows.Add(7)
            dgvPhysicalAssesment.Rows(0).Cells(0).Value = "Legs"
            dgvPhysicalAssesment.Rows(1).Cells(0).Value = "Peripheral Pulses"
            dgvPhysicalAssesment.Rows(2).Cells(0).Value = "Gait"
            dgvPhysicalAssesment.Rows(3).Cells(0).Value = "Back"
            dgvPhysicalAssesment.Rows(4).Cells(0).Value = "Joints"
            dgvPhysicalAssesment.Rows(5).Cells(0).Value = "Skin"
            dgvPhysicalAssesment.Rows(6).Cells(0).Value = "Others"
        End If

        'Fill out Social History
        dgvSocialHistory.Columns(0).Width = 180
        dgvSocialHistory.Columns(1).Width = 120
        dgvSocialHistory = myAdmission.SocialHistory
        'Image
        dgvImage = myAdmission.Image
        dgvImage.Columns(1).Width = 650
        If dgvImage.Rows.Count < 1 Then
            dgvImage.Columns.Add("Image", "Image")
        dgvImage.Columns.Add("ImageDetais", "Image Details")
        dgvImage.Rows.Add(5)
        dgvImage.Rows(0).Cells(0).Value = "ECG"
        dgvImage.Rows(1).Cells(0).Value = "CXR"
        dgvImage.Rows(2).Cells(0).Value = "MSU"
        dgvImage.Rows(3).Cells(0).Value = "XRay Other"
            dgvImage.Rows(4).Cells(0).Value = "Image Other"
        End If
        'Medic Reviews

        rchRegAssesment.Text = myAdmission.RegAssesment
        rchRegImpression.Text = myAdmission.RegImpression
        rchRegPlan.Text = myAdmission.RegPlan
        txtRegID.Text = myAdmission.RegID
        txtRegName.Text = myAdmission.RegName

        rchConAssesment.Text = myAdmission.ConAssesment
        rchConImpression.Text = myAdmission.ConImpression
        rchConPlan.Text = myAdmission.ConPlan
        txtConID.Text = myAdmission.ConID
        txtConName.Text = myAdmission.ConName

        'Add Progress Summary
        rtxtProgressSummary.Text = myAdmission.ProgressSummary


        'Add to DischargeDetails
        If myAdmission.DischargeMedication.Rows.Count = 0 Then
            dgvDischargeMeds = myAdmission.MedicationList
        Else
            dgvDischargeMeds = myAdmission.DischargeMedication
        End If
        dgvDischargeMeds.Columns(0).Visible = False
        dgvDischargeMeds.Columns(1).Width = 300
        dgvDischargeMeds.Columns(2).Width = 90
        dgvDischargeMeds.Columns(3).Width = 150
        dgvDischargeMeds.Columns(0).ReadOnly = True
        dgvDischargeMeds.Columns(1).ReadOnly = True
        Dim LastRowProgress As Integer = dgvProgressList.Rows.Count - 1
        If rtxtProgressSummary.Text <> "" Then
            txtProgressSummary.Text = myAdmission.ProgressSummary
        End If

        'Add to Previous Admission
        lblPreviousSymphony.Text = myAdmission.PreviousSymphony
        rchtxtPreviousSummary.Text = myAdmission.PreviousProgress
        If myAdmission.PreviousSymphony <> "" Then
            dtpPreviousAdmissionDate.Value = myAdmission.PreviousAdmissionDate
            dtpPreviousDischargeDate.Value = myAdmission.PreviousDischargeDate
        End If
        dgvPreviousDiagnosis.Columns(0).Width = 150
        dgvPreviousDiagnosis.Columns(1).Width = 600
        dgvPreviousDiagnosis = myAdmission.PreviousDiagnosis
        dgvPreviousMeds.Columns(0).Width = 150
        dgvPreviousMeds = myAdmission.PreviousMedication
        'Procedures
        lvProcedureList = myAdmission.ProcedureList
    End Sub



    ''Admission Details

    'Variables SetUp
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
    Private Sub dtpAdmissionDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpAdmissionDate.ValueChanged
        myAdmission.AdmissionDate = dtpAdmissionDate.Value
    End Sub

    Private Sub dtpReferralDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpReferralDate.ValueChanged
        myAdmission.ReferralDate = dtpReferralDate.Value
    End Sub

    Private Sub dtpDateSeen_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateSeen.ValueChanged
        myAdmission.DateSeen = dtpDateSeen.Value
    End Sub

    Private Sub txtRefReason_TextChanged(sender As Object, e As EventArgs) Handles txtRefReason.TextChanged
        myAdmission.ReferralReason = txtRefReason.Text
    End Sub

    Private Sub cmbConsultant_TextChanged(sender As Object, e As EventArgs) Handles cmbConsultant.TextChanged
        myAdmission.Consultant = cmbConsultant.Text
    End Sub

    Private Sub txtDoctor_TextChanged(sender As Object, e As EventArgs) Handles txtDoctor.TextChanged
        myAdmission.AdmittingDr = txtDoctor.Text
    End Sub

    Private Sub txtMCRN_TextChanged(sender As Object, e As EventArgs) Handles txtMCRN.TextChanged
        myAdmission.MCRN = txtMCRN.Text
    End Sub

    Private Sub txtBleep_TextChanged(sender As Object, e As EventArgs) Handles txtBleep.TextChanged
        myAdmission.Bleep = txtBleep.Text
    End Sub





    'Actions

    Private Sub btnClearPC_Click(sender As Object, e As EventArgs) Handles btnClearPC.Click
        Try
            dgvPresentingComplaint.Rows.Remove(dgvPresentingComplaint.SelectedRows(0))
        Catch
            MessageBox.Show("Please Select a Row")
        End Try
    End Sub



    ''History

    'Variables Setup

    ''Presenting Complaint
    Private Sub dgvPresentingComplaint_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvPresentingComplaint.EditingControlShowing
        'declare variable(cb) as a combobox
        Dim cb As ComboBox
        'e represent the editing control in the datagridview
        'the condition is, if the type of e is combobox then set your code for autocomplete
        If TypeOf e.Control Is ComboBox Then
            cb = e.Control
            'set the dropdown style of a combobox
            cb.DropDownStyle = ComboBoxStyle.DropDown
            'set the propety of a combobox to autocomplete mode.
            cb.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            cb.AutoCompleteSource = AutoCompleteSource.ListItems
        End If
    End Sub

    'Relevant Risk
    Private Sub cmbRelRisk_TextChanged(sender As Object, e As EventArgs) Handles cmbRelRisk.TextChanged
        myAdmission.RelevantRisk = cmbRelRisk.Text
    End Sub

    'Family History
    Private Sub dgvFamilyRisk_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvFamilyRisk.EditingControlShowing
        'declare variable(cb) as a combobox
        Dim cb As ComboBox
        'e represent the editing control in the datagridview
        'the condition is, if the type of e is combobox then set your code for autocomplete
        If TypeOf e.Control Is ComboBox Then
            cb = e.Control
            'set the dropdown style of a combobox
            cb.DropDownStyle = ComboBoxStyle.DropDown
            'set the propety of a combobox to autocomplete mode.
            cb.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            cb.AutoCompleteSource = AutoCompleteSource.ListItems
        End If
    End Sub



    'Medical/Surgical History
    Private Sub txtSurMedSeach_TextChanged(sender As Object, e As EventArgs) Handles txtSurMedSeach.TextChanged
        myMaster.MedicalHistorySearchID = txtSurMedSeach.Text
    End Sub

    'Medication Search
    Private Sub txtMedicationSearch_TextChanged(sender As Object, e As EventArgs) Handles txtMedicationSearch.TextChanged
        myMaster.MedicationSearchID = txtMedicationSearch.Text
    End Sub




    'Actions

    'Surgical/Medical History
    Private Sub btnSurgMedHistSearch_Click(sender As Object, e As EventArgs) Handles btnSurgMedHistSearch.Click
        Dim myFrmMasteredicalHistory As New frmMasterMedicalHistoryList
        myMaster.findMedicalHistory(myFrmMasteredicalHistory.lstvMasterMedicalHistory)
        myFrmMasteredicalHistory.ShowDialog()
        txtSurMedSeach.Text = ""

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnRemoveMedSurgTerm.Click
        Try
            lstvMedicalHistory.SelectedItems(0).Remove()
        Catch
            MessageBox.Show("Please Select a Row")
        End Try

    End Sub
    'Relevant Risk
    Private Sub btnAddRelRisks_Click(sender As Object, e As EventArgs) Handles btnAddRelRisks.Click
        If myAdmission.RelevantRisk <> "" Then
            lstRelRisk.Items.Add(myAdmission.RelevantRisk)
            cmbRelRisk.Text = ""
            myAdmission.RelevantRisk = ""
            cmbRelRisk.Focus()
        End If
    End Sub
    Private Sub btnRemoveRisk_Click(sender As Object, e As EventArgs) Handles btnRemoveRisk.Click
        lstRelRisk.Items.Remove(lstRelRisk.SelectedItem)
    End Sub
    'Medication
    Private Sub btnMedSearch_Click(sender As Object, e As EventArgs) Handles btnMedSearch.Click
        Dim myFrmMasterMedicationList As New frmMasterMedicationList
        myMaster.findMedication(myFrmMasterMedicationList.lstvMasterMedicationList)
        myFrmMasterMedicationList.ShowDialog()
        txtMedicationSearch.Text = ""
        If dgvMeds.Rows.Count > 0 Then
            dgvMeds.Focus()
            dgvMeds.BeginEdit(True)
        Else
            txtMedicationSearch.Focus()
        End If
    End Sub


    ''PreAdm Medications

    Private Sub cmbMedSource_TextChanged(sender As Object, e As EventArgs) Handles cmbMedSource.TextChanged
        myAdmission.PreAdmMedSource = cmbMedSource.Text
    End Sub

    Private Sub txtMedSourceName_TextChanged(sender As Object, e As EventArgs) Handles txtMedSourceName.TextChanged
        myAdmission.PreAdmSourceName = txtMedSourceName.Text
    End Sub

    Private Sub txtMedSourceTelNum_TextChanged(sender As Object, e As EventArgs) Handles txtMedSourceTelNum.TextChanged
        myAdmission.PreAdmSourceTel = txtMedSourceTelNum.Text
    End Sub

    Private Sub dtpPreAdmMedDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpPreAdmMedDate.ValueChanged
        myAdmission.PreAdmMedDate = dtpPreAdmMedDate.Value
    End Sub




    ''Diagnossis
    Private Sub btnDiagnosisSearch_Click(sender As Object, e As EventArgs) Handles btnDiagnosisSearch.Click
        Dim myFrmMasterDiagnosisList As New frmMasterDiagnosisList
        myMaster.findDiagnosis(myFrmMasterDiagnosisList.lstvMasterDiagnosisList)
        myFrmMasterDiagnosisList.ShowDialog()
        txtDiagnosis.Text = ""
    End Sub


    Private Sub btnRemoveDiagnosis_Click(sender As Object, e As EventArgs) Handles btnRemoveDiagnosis.Click
        Try
            dgvDiagnosis.Rows.Remove(dgvDiagnosis.SelectedRows(0))
        Catch
            MessageBox.Show("Please Select a Row")
        End Try
    End Sub

    Private Sub txtDiagnosis_TextChanged(sender As Object, e As EventArgs) Handles txtDiagnosis.TextChanged
        myMaster.DiagnosisSearchID = txtDiagnosis.Text
    End Sub



    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If myAdmission.AddAdmission() = True Then
            MessageBox.Show("Admission Details Updated")
        Else MessageBox.Show("Admission Details Not Updated")
        End If
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        frmMainUser.Show()
        Me.Close()
    End Sub

    Private Sub txtWard_TextChanged(sender As Object, e As EventArgs)
        myAdmission.Ward = txtWard.Text
    End Sub



    Private Sub btnSaveDiagnosis_Click(sender As Object, e As EventArgs) Handles btnSaveDiagnosis.Click
        myAdmission.DiagnosisGrid = dgvDiagnosis
        myAdmission.DischargeDiagnosisList = dgvDischargeDiagnosis
        If myAdmission.AddDiagnosis() = True Then
            MessageBox.Show("Details Saved")
        Else MessageBox.Show("Details Not Saved")
        End If
    End Sub
    ''' Labs

    Private Sub Labs_Click(sender As Object, e As EventArgs) Handles Labs.Click

    End Sub

    Private Sub btnSaveLabs_Click(sender As Object, e As EventArgs) Handles btnSaveLabs.Click
        Dim dtLab As New DataTable()
        dtLab.Columns.AddRange(New DataColumn(3) {New DataColumn("Symphony", GetType(String)),
                               New DataColumn("Date", GetType(String)), New DataColumn("LabTest", GetType(String)),
                               New DataColumn("LabResult", GetType(String))})
        Dim TestRow As Integer = 0
        For Column = 1 To dgLabView.Columns.Count - 1

            For Each row As DataGridViewRow In dgLabView.Rows
                If TestRow <= dgLabView.Rows.Count - 1 Then
                    Dim LabDate As String = dgLabView.Rows(0).Cells(Column).Value
                    Dim Symphony As String = myAdmission.Symphony
                    If dgLabView.Rows(TestRow).Cells(0).Value <> "Date" Then
                        Dim LabTest As String = dgLabView.Rows(TestRow).Cells(0).Value
                        Dim LabResult As String = dgLabView.Rows(TestRow).Cells(Column).Value
                        If (LabTest <> "" And LabDate <> "") Then
                            dtLab.Rows.Add(Symphony, LabDate, LabTest, LabResult)
                        End If
                    End If

                End If

                TestRow = TestRow + 1
            Next row

            TestRow = 0

        Next Column

        myAdmission.LabsDataTable = dtLab
        If myAdmission.AddLabResults() = True Then
            MessageBox.Show("Lab results Added to Database")
        Else
            MessageBox.Show("Lab Results Not Added to Database")
        End If

    End Sub

    Private Sub btnAddNewColumn_Click(sender As Object, e As EventArgs) Handles btnAddNewColumn.Click
        Dim ColumnIndex As Integer
        ColumnIndex = dgLabView.Columns.Count
        dgLabView.SelectionMode = DataGridViewSelectionMode.CellSelect
        dgLabView.Columns.Add("LabDate", "Results")
        dgLabView.Columns(ColumnIndex).SortMode = DataGridViewColumnSortMode.NotSortable
        dgLabView.SelectionMode = DataGridViewSelectionMode.FullColumnSelect
        'dgLabView.Columns.Add("LabDate" & ColumnIndex, "Results" & ColumnIndex)

    End Sub
    Private Sub btnDeleteColumn_Click(sender As Object, e As EventArgs) Handles btnDeleteColumn.Click

        Try
            If dgLabView.SelectedColumns(0).HeaderText <> dgLabView.Columns(0).HeaderText Then
                dgLabView.Columns.Remove(dgLabView.SelectedColumns(0))
            End If
        Catch
            MessageBox.Show("Please Select a Column")
        End Try

    End Sub

    Private Sub ctxtLab_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ctxtLab.ItemClicked
        Try
            If dgLabView.SelectedColumns(0).HeaderText <> dgLabView.Columns(0).HeaderText Then
                dgLabView.Columns.Remove(dgLabView.SelectedColumns(0))
            End If
        Catch
            MessageBox.Show("Please Select a Column")
        End Try

    End Sub
    Private Sub dgLabView_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgLabView.CellMouseDown
        If e.Button = MouseButtons.Right Then
            If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Exit Sub
            dgLabView.CurrentCell = dgLabView(e.ColumnIndex, e.RowIndex)
            ' Maybe modify the text on your context menu options here?
        End If
    End Sub
    Private Sub LabColumnDelete_Click(sender As Object, e As EventArgs) Handles LabColumnDelete.Click

    End Sub
    'Progress Notes
    'setting up Progress Notes
    Private Sub TabAdmission_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabAdmission.SelectedIndexChanged
        If TabAdmission.SelectedIndex = 2 Then
            If dgvMeds.Rows.Count > 0 Then
                dgvMeds.BeginEdit(True)
            End If
        End If
        If TabAdmission.SelectedIndex = 9 Then

            If dgvProgressList.Rows.Count > 0 Then
                dgvProgressList.BeginEdit(True)
            End If
        End If
    End Sub
    Private Sub btnAddProgressNote_Click(sender As Object, e As EventArgs) Handles btnAddProgressNote.Click
        Dim newProgressRow As Integer = dgvProgressList.Rows.Count()
        dgvProgressList.Columns(0).Width = 170
        dgvProgressList.Columns(1).Width = 750
        dgvProgressList.Rows.Add()
        dgvProgressList.Rows(newProgressRow).Cells(0).Value = DateTime.Now
        dgvProgressList.Rows(newProgressRow).Selected = True
        dgvProgressList.Focus()
        dgvProgressList.CurrentCell = dgvProgressList.Rows(newProgressRow).Cells(1)
    End Sub

    Private Sub btnSaveProgress_Click(sender As Object, e As EventArgs) Handles btnSaveProgress.Click
        myAdmission.ProgressGrid = dgvProgressList
        If myAdmission.AddProgress() = True Then
            MessageBox.Show("Progress Added")
        Else
            MessageBox.Show("Progress Not Added")
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        myDocument.MedSource = cmbMedSource.Text
        myDocument.MedSourceName = txtMedSourceName.Text
        myDocument.ExportExcel(dgvMeds)
    End Sub



    Private Sub btnSaveMedication_Click(sender As Object, e As EventArgs) Handles btnSaveMedication.Click

        myAdmission.MedicationList = dgvMeds
        If myAdmission.AddMedication() = True Then
            MessageBox.Show("Medication History Saved")
        End If
    End Sub



    Private Sub btnRemoveProgressNote_Click(sender As Object, e As EventArgs) Handles btnRemoveProgressNote.Click
        Try
            dgvProgressList.Rows.Remove(dgvProgressList.SelectedRows(0))
        Catch
            MessageBox.Show("Please Select a Row")
        End Try
    End Sub

    Private Sub txtWard_TextChanged_1(sender As Object, e As EventArgs) Handles txtWard.TextChanged
        myAdmission.Ward = txtWard.Text
    End Sub

    Private Sub btnSaveHistory_Click(sender As Object, e As EventArgs)
        myAdmission.PresentingComplaintList = dgvPresentingComplaint
        myAdmission.FamilyRiskList = dgvFamilyRisk
        myAdmission.MedicalSurgicalList = lstvMedicalHistory
        myAdmission.RiskList = lstRelRisk
        myAdmission.SocialHistory = dgvSocialHistory
        If myAdmission.AddPatientHistory = True And myAdmission.AddPresentingComplaint = True Then
            MessageBox.Show("Patient History Added")
        Else MessageBox.Show("Patient History Not Added")
        End If
    End Sub

    Private Sub btnRemoveFamilyRisk_Click(sender As Object, e As EventArgs) Handles btnRemoveFamilyRisk.Click
        Try
            dgvFamilyRisk.Rows.Remove(dgvFamilyRisk.SelectedRows(0))
        Catch
            MessageBox.Show("Please Select a Row")
        End Try
    End Sub

    Private Sub txtProgressSummary_TextChanged(sender As Object, e As EventArgs) Handles txtProgressSummary.TextChanged
        myAdmission.ProgressSummary = txtProgressSummary.Text
    End Sub

    Private Sub btnDischageSummary_Click(sender As Object, e As EventArgs) Handles btnDischageSummary.Click
        myDocument.Name = txtPatName.Text
        myDocument.ID = txtPatMRN.Text
        myDocument.Symphony = txtPatSymphony.Text
        myDocument.DiagnosisGrid = dgvDischargeDiagnosis
        myDocument.ProgressSummary = txtProgressSummary.Text
        myDocument.DischargeMeds = dgvDischargeMeds
        myDocument.CreateDischargeSummary()
    End Sub

    ''Physical Exam
    Private Sub picPerson_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles picPerson.MouseDoubleClick
        Dim x As String, y As String

        x = e.X
        y = e.Y
        If x >= 205 And x <= 270 Then
            MessageBox.Show("LeftArm")
        End If
    End Sub

    Private Sub btnAddPhysicalExam_Click(sender As Object, e As EventArgs) Handles btnAddPhysicalExam.Click
        myAdmission.Vitals = dgvVitals
        myAdmission.PhysicalSigns = dgvPhysicalSigns
        myAdmission.Organs = dgvOrgans
        myAdmission.Limbs = dgvLimbs
        myAdmission.PhysicalAssesment = dgvPhysicalAssesment
        If myAdmission.AddPhysicalExam() = True Then
            MessageBox.Show("Physical Exam Details Added")
        Else MessageBox.Show("Details Not Added")
        End If
    End Sub



    Private Sub radioWell_CheckedChanged(sender As Object, e As EventArgs) Handles radioWell.CheckedChanged
        myAdmission.Condition = "Well"
    End Sub

    Private Sub radioUnwell_CheckedChanged(sender As Object, e As EventArgs) Handles radioUnwell.CheckedChanged
        myAdmission.Condition = "Unwell"
    End Sub

    Private Sub radioWet_CheckedChanged(sender As Object, e As EventArgs) Handles radioWet.CheckedChanged
        myAdmission.Fluid = "Wet"
    End Sub

    Private Sub radioDry_CheckedChanged(sender As Object, e As EventArgs) Handles radioDry.CheckedChanged
        myAdmission.Fluid = "Dry"
    End Sub


    'Images
    Private Sub btnAddImageDetails_Click(sender As Object, e As EventArgs) Handles btnAddImageDetails.Click

        myAdmission.Image = dgvImage
        If myAdmission.AddImageDetails = True Then
            MessageBox.Show("Details Added")
        Else MessageBox.Show("Details not Added")
        End If
    End Sub
    'Consultant Plans
    Private Sub rchConAssesment_TextChanged(sender As Object, e As EventArgs) Handles rchConAssesment.TextChanged
        myAdmission.ConAssesment = rchConAssesment.Text
    End Sub

    Private Sub rchConImpression_TextChanged(sender As Object, e As EventArgs) Handles rchConImpression.TextChanged
        myAdmission.ConImpression = rchConImpression.Text
    End Sub

    Private Sub rchConPlan_TextChanged(sender As Object, e As EventArgs) Handles rchConPlan.TextChanged
        myAdmission.ConPlan = rchConPlan.Text
    End Sub

    Private Sub txtConName_TextChanged(sender As Object, e As EventArgs) Handles txtConName.TextChanged
        myAdmission.ConName = txtConName.Text
    End Sub

    Private Sub txtConID_TextChanged(sender As Object, e As EventArgs) Handles txtConID.TextChanged
        myAdmission.ConID = txtConID.Text
    End Sub

    Private Sub txtBtnAddConPlan_Click(sender As Object, e As EventArgs) Handles txtBtnAddConPlan.Click
        If myAdmission.AddMedicPlan() = True Then
            MessageBox.Show("Details Added")
        Else
            MessageBox.Show("Details Not Added")
        End If
    End Sub

    Private Sub rchRegAssesment_TextChanged(sender As Object, e As EventArgs) Handles rchRegAssesment.TextChanged
        myAdmission.RegAssesment = rchRegAssesment.Text
    End Sub

    Private Sub rchRegImpression_TextChanged(sender As Object, e As EventArgs) Handles rchRegImpression.TextChanged
        myAdmission.RegImpression = rchRegImpression.Text
    End Sub

    Private Sub rchRegPlan_TextChanged(sender As Object, e As EventArgs) Handles rchRegPlan.TextChanged
        myAdmission.RegPlan = rchRegPlan.Text
    End Sub

    Private Sub txtRegName_TextChanged(sender As Object, e As EventArgs) Handles txtRegName.TextChanged
        myAdmission.RegName = txtRegName.Text
    End Sub

    Private Sub txtRegID_TextChanged(sender As Object, e As EventArgs) Handles txtRegID.TextChanged
        myAdmission.RegID = txtRegID.Text
    End Sub

    Private Sub btnAddRegPlan_Click(sender As Object, e As EventArgs) Handles btnAddRegPlan.Click
        If myAdmission.AddMedicPlan("Reg") = True Then
            MessageBox.Show("Details Added")
        Else
            MessageBox.Show("Details Not Added")
        End If
    End Sub

    Private Sub btnExportPatient_Click(sender As Object, e As EventArgs) Handles btnExportPatient.Click
        myDocument.Name = txtPatName.Text
        myDocument.ID = txtPatMRN.Text
        myDocument.Location = txtPatArea.Text
        myDocument.Symphony = txtPatSymphony.Text
        myDocument.MedicalSurgicalList = lstvMedicalHistory
        myDocument.FamilyRiskList = dgvFamilyRisk
        myDocument.SocialHistory = dgvSocialHistory
        myDocument.CreatePatientDoc()
    End Sub

    Private Sub btnExportAdmission_Click(sender As Object, e As EventArgs) Handles btnExportAdmission.Click

        myDocument.Name = txtPatName.Text
        myDocument.ID = txtPatMRN.Text
        myDocument.Consultant = cmbConsultant.Text
        myDocument.AdmissionDate = dtpAdmissionDate.Value
        myDocument.AdmittingDr = txtDoctor.Text
        myDocument.ReferralDate = dtpReferralDate.Value
        myDocument.MCRN = txtMCRN.Text
        myDocument.Bleep = txtBleep.Text
        myDocument.ReferralReason = txtRefReason.Text
        myDocument.Ward = txtWard.Text
        myDocument.PresentingComplaintList = dgvPresentingComplaint
        myDocument.RiskList = lstRelRisk
        myDocument.DiagnosisGrid = dgvDiagnosis
        myDocument.RegAssesment = rchRegAssesment.Text
        myDocument.RegImpression = rchRegImpression.Text
        myDocument.RegPlan = rchRegPlan.Text
        myDocument.RegName = txtRegName.Text
        myDocument.RegID = txtRegID.Text
        myDocument.ConAssesment = rchConAssesment.Text
        myDocument.ConImpression = rchConImpression.Text
        myDocument.ConPlan = rchConPlan.Text
        myDocument.ConName = txtConName.Text
        myDocument.ConID = txtConID.Text

        myDocument.CreateAdmissionDoc()

    End Sub

    Private Sub rtxtProgressSummary_TextChanged(sender As Object, e As EventArgs) Handles rtxtProgressSummary.TextChanged
        myAdmission.ProgressSummary = rtxtProgressSummary.Text
    End Sub

    Private Sub rchtxtPreviousSummary_TextChanged(sender As Object, e As EventArgs) Handles rchtxtPreviousSummary.TextChanged
    End Sub
    ''Discharge Details
    Private Sub btnStopMedication_Click(sender As Object, e As EventArgs) Handles btnStopMedication.Click
        Try
            dgvDischargeMeds.Rows.Remove(dgvDischargeMeds.SelectedRows(0))
        Catch
            MessageBox.Show("Please Select a Row")
        End Try

    End Sub


    Private Sub btnSaveHistory_Click_1(sender As Object, e As EventArgs) Handles btnSaveHistory.Click
        myAdmission.PresentingComplaintList = dgvPresentingComplaint
        myAdmission.FamilyRiskList = dgvFamilyRisk
        myAdmission.MedicalSurgicalList = lstvMedicalHistory
        myAdmission.RiskList = lstRelRisk
        myAdmission.SocialHistory = dgvSocialHistory
        If myAdmission.AddPatientHistory = True And myAdmission.AddPresentingComplaint = True Then
            MessageBox.Show("Patient History Added")
        Else MessageBox.Show("Patient History Not Added")
        End If
    End Sub
    'Close event-Saving All Details
    Private Sub frmAdmission_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim result As Integer = MessageBox.Show("Would You like to Save Your Changes", "Save Admission Details", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then
            e.Cancel = True
        ElseIf result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then

            'Patient History
            myAdmission.PresentingComplaintList = dgvPresentingComplaint
            myAdmission.FamilyRiskList = dgvFamilyRisk
            myAdmission.MedicalSurgicalList = lstvMedicalHistory
            myAdmission.RiskList = lstRelRisk
            myAdmission.SocialHistory = dgvSocialHistory
            myAdmission.MedicationList = dgvMeds
            'Physical Examination
            myAdmission.Vitals = dgvVitals
            myAdmission.PhysicalSigns = dgvPhysicalSigns
            myAdmission.Organs = dgvOrgans
            myAdmission.Limbs = dgvLimbs
            myAdmission.PhysicalAssesment = dgvPhysicalAssesment
            ''Labs Datatable Setup
            Dim dtLab As New DataTable()
            'set up datatable
            dtLab.Columns.AddRange(New DataColumn(3) {New DataColumn("Symphony", GetType(String)),
                               New DataColumn("Date", GetType(String)), New DataColumn("LabTest", GetType(String)),
                               New DataColumn("LabResult", GetType(String))})
            'Get Values for datatable
            Dim TestRow As Integer = 0
            For Column = 1 To dgLabView.Columns.Count - 1
                For Each row As DataGridViewRow In dgLabView.Rows
                    If TestRow <= dgLabView.Rows.Count - 1 Then
                        Dim LabDate As String = dgLabView.Rows(0).Cells(Column).Value
                        Dim Symphony As String = myAdmission.Symphony
                        If dgLabView.Rows(TestRow).Cells(0).Value <> "Date" Then
                            Dim LabTest As String = dgLabView.Rows(TestRow).Cells(0).Value
                            Dim LabResult As String = dgLabView.Rows(TestRow).Cells(Column).Value
                            'Add values to datatable
                            If (LabTest <> "" And LabDate <> "") Then
                                dtLab.Rows.Add(Symphony, LabDate, LabTest, LabResult)
                            End If
                        End If
                    End If
                    TestRow = TestRow + 1
                Next row
                TestRow = 0
            Next Column
            myAdmission.LabsDataTable = dtLab
            'images
            myAdmission.Image = dgvImage
            'Diagnosis
            myAdmission.DiagnosisGrid = dgvDiagnosis
            myAdmission.DischargeDiagnosisList = dgvDischargeDiagnosis
            myAdmission.ProgressGrid = dgvProgressList
            'DischargeMedication
            myAdmission.DischargeMedication = dgvDischargeMeds
            'Procedures
            myAdmission.ProcedureList = lvProcedureList
            'Add Admission Details
            If myAdmission.AddProcedure() = True Then
                myAdmission.AddDischargeMedication()
                myAdmission.AddProgress()
                myAdmission.AddMedicPlan()
                myAdmission.AddMedicPlan("Reg")
                myAdmission.AddDiagnosis()
                myAdmission.AddImageDetails()
                myAdmission.AddLabResults()
                myAdmission.AddPhysicalExam()
                myAdmission.AddMedication()
                myAdmission.AddPatientHistory()
                myAdmission.AddPresentingComplaint()
                myAdmission.AddAdmission()
                MessageBox.Show("Admission Details Updated")
            Else MessageBox.Show("Admission Details Not Updated")
            End If
        End If


    End Sub

    Private Sub dtpReferralTime_ValueChanged(sender As Object, e As EventArgs) Handles dtpReferralTime.ValueChanged
        myAdmission.ReferralTime = dtpReferralTime.Value
    End Sub

    Private Sub dtpAdmissionTime_ValueChanged(sender As Object, e As EventArgs) Handles dtpAdmissionTime.ValueChanged
        myAdmission.AdmissionTime = dtpAdmissionTime.Value
    End Sub

    Private Sub dtpSeenTime_ValueChanged(sender As Object, e As EventArgs) Handles dtpSeenTime.ValueChanged
        myAdmission.SeenTime = dtpSeenTime.Value
    End Sub

    Private Sub txtDoctor_MouseClick(sender As Object, e As MouseEventArgs) Handles txtDoctor.MouseClick
        If txtDoctor.Text = "Not Entered" Then txtDoctor.Text = ""

    End Sub

    Private Sub txtMCRN_Click(sender As Object, e As EventArgs) Handles txtMCRN.Click
        If txtMCRN.Text = "Not Entered" Then txtMCRN.Text = ""
    End Sub

    Private Sub txtBleep_Click(sender As Object, e As EventArgs) Handles txtBleep.Click
        If txtBleep.Text = "Not Entered" Then txtBleep.Text = ""
    End Sub

    Private Sub txtRefReason_Click(sender As Object, e As EventArgs) Handles txtRefReason.Click
        If txtRefReason.Text = "Not Entered" Then txtRefReason.Text = ""
    End Sub

    Private Sub txtWard_Click(sender As Object, e As EventArgs) Handles txtWard.Click
        If txtWard.Text = "Not Entered" Then txtWard.Text = ""
    End Sub

    Private Sub grpAdmissionMed_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnClearMed_Click_1(sender As Object, e As EventArgs) Handles btnClearMed.Click
        Try
            dgvMeds.Rows.Remove(dgvMeds.SelectedRows(0))
        Catch
            MessageBox.Show("Please Select a Row")
        End Try
    End Sub

    Private Sub ItemDeletePMed_Click(sender As Object, e As EventArgs) Handles ItemDeletePMed.Click
        Try
            dgvMeds.Rows.Remove(dgvMeds.SelectedRows(0))
        Catch
            MessageBox.Show("Please Select a Row")
        End Try
    End Sub

    Private Sub dgvMeds_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvMeds.CellMouseDown
        If e.Button = MouseButtons.Right Then
            If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Exit Sub
            dgvMeds.CurrentCell = dgvMeds(e.ColumnIndex, e.RowIndex)
            ' Maybe modify the text on your context menu options here?
        End If
    End Sub

    Private Sub itemAddPMed_Click(sender As Object, e As EventArgs) Handles itemAddPMed.Click
        txtMedicationSearch.Text = ""
        txtMedicationSearch.Focus()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim myFrmDischargeMedicationList As New FrmDischargeMedicationSearch
        myMaster.findMedication(myFrmDischargeMedicationList.lstvMasterMedicationList)
        myFrmDischargeMedicationList.ShowDialog()
        txtDischargeMed.Text = ""
        dgvDischargeMeds.Focus()
        dgvDischargeMeds.BeginEdit(True)
    End Sub

    Private Sub txtDischargeMed_TextChanged(sender As Object, e As EventArgs) Handles txtDischargeMed.TextChanged
        myMaster.MedicationSearchID = txtDischargeMed.Text
    End Sub

    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs) Handles Panel7.Paint

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        txtDischargeMed.Text = ""
        txtDischargeMed.Focus()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Try
            dgvDischargeMeds.SelectedRows(0).Cells(3).Value = "Stopped"
        Catch
            MessageBox.Show("Please Select a Row")
        End Try
    End Sub

    Private Sub dgvDischargeMeds_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvDischargeMeds.CellMouseDown
        If e.Button = MouseButtons.Right Then
            If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Exit Sub
            dgvDischargeMeds.CurrentCell = dgvDischargeMeds(e.ColumnIndex, e.RowIndex)

        End If

    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Try
            dgvDischargeMeds.SelectedRows(0).Cells(3).Value = "Dose Changed"
            dgvDischargeMeds.SelectedRows(0).Cells(2).Value = ""
            dgvDischargeMeds.Focus()
            dgvDischargeMeds.CurrentCell = dgvDischargeMeds.SelectedRows(0).Cells(2)
        Catch
            MessageBox.Show("Please Select a Row")
        End Try
    End Sub

    Private Sub btnSearchMasterProcedure_Click(sender As Object, e As EventArgs) Handles btnSearchMasterProcedure.Click
        Dim myFrmMasterProcedure As New frmMasterProcedure
        myMaster.findProcedure(myFrmMasterProcedure.lvMasterProcedure)
        myFrmMasterProcedure.ShowDialog()
        txtProcedure.Text = ""
    End Sub

    Private Sub txtProcedure_TextChanged(sender As Object, e As EventArgs) Handles txtProcedure.TextChanged
        myMaster.ProcedureSearchID = txtProcedure.Text
    End Sub

    Private Sub btnDeleteProcedure_Click(sender As Object, e As EventArgs) Handles btnDeleteProcedure.Click
        Try
            lvProcedureList.SelectedItems(0).Remove()
        Catch
            MessageBox.Show("Please Select a Row")
        End Try
    End Sub

    Private Sub btnSaveProcedure_Click(sender As Object, e As EventArgs) Handles btnSaveProcedure.Click
        myAdmission.ProcedureList = lvProcedureList
        If myAdmission.AddProcedure = True Then
            MessageBox.Show("Procedures Added")
        End If
    End Sub
End Class