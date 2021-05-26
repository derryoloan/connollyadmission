<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaintenance
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.PresentingComplaint = New System.Windows.Forms.TabPage()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtPresentingComplaint = New System.Windows.Forms.TextBox()
        Me.txtPresentingComplaint_ID = New System.Windows.Forms.TextBox()
        Me.btnAddPresentingComplaint = New System.Windows.Forms.Button()
        Me.RiskFactor = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRiskFactor = New System.Windows.Forms.TextBox()
        Me.txtRiskFactor_ID = New System.Windows.Forms.TextBox()
        Me.btnAddRiskFactor = New System.Windows.Forms.Button()
        Me.FamilyHistory = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFamilyHistory = New System.Windows.Forms.TextBox()
        Me.btnAddFamilyHistory = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFamilyHistoryID = New System.Windows.Forms.TextBox()
        Me.MedicalSurgicalHistory = New System.Windows.Forms.TabPage()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtMedicalHistory = New System.Windows.Forms.TextBox()
        Me.txtMedicalHistory_ID = New System.Windows.Forms.TextBox()
        Me.btnAddMedicalHistory = New System.Windows.Forms.Button()
        Me.Medication = New System.Windows.Forms.TabPage()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtMedicationName = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtMedication_ID = New System.Windows.Forms.TextBox()
        Me.btnAddMedicationName = New System.Windows.Forms.Button()
        Me.Diagnosis = New System.Windows.Forms.TabPage()
        Me.txtDiagnosis_ID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDiagnosis = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAddDiagnosis = New System.Windows.Forms.Button()
        Me.Reg = New System.Windows.Forms.TabPage()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtRegName = New System.Windows.Forms.TextBox()
        Me.txtReg_ID = New System.Windows.Forms.TextBox()
        Me.btnAddReg = New System.Windows.Forms.Button()
        Me.Consultant = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtConsultant = New System.Windows.Forms.TextBox()
        Me.txtConsultant_ID = New System.Windows.Forms.TextBox()
        Me.btnAddConsultant = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.PresentingComplaint.SuspendLayout()
        Me.RiskFactor.SuspendLayout()
        Me.FamilyHistory.SuspendLayout()
        Me.MedicalSurgicalHistory.SuspendLayout()
        Me.Medication.SuspendLayout()
        Me.Diagnosis.SuspendLayout()
        Me.Reg.SuspendLayout()
        Me.Consultant.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.PresentingComplaint)
        Me.TabControl1.Controls.Add(Me.RiskFactor)
        Me.TabControl1.Controls.Add(Me.FamilyHistory)
        Me.TabControl1.Controls.Add(Me.MedicalSurgicalHistory)
        Me.TabControl1.Controls.Add(Me.Medication)
        Me.TabControl1.Controls.Add(Me.Diagnosis)
        Me.TabControl1.Controls.Add(Me.Reg)
        Me.TabControl1.Controls.Add(Me.Consultant)
        Me.TabControl1.Location = New System.Drawing.Point(30, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(620, 333)
        Me.TabControl1.TabIndex = 0
        '
        'PresentingComplaint
        '
        Me.PresentingComplaint.Controls.Add(Me.Label13)
        Me.PresentingComplaint.Controls.Add(Me.Label14)
        Me.PresentingComplaint.Controls.Add(Me.txtPresentingComplaint)
        Me.PresentingComplaint.Controls.Add(Me.txtPresentingComplaint_ID)
        Me.PresentingComplaint.Controls.Add(Me.btnAddPresentingComplaint)
        Me.PresentingComplaint.Location = New System.Drawing.Point(4, 22)
        Me.PresentingComplaint.Name = "PresentingComplaint"
        Me.PresentingComplaint.Padding = New System.Windows.Forms.Padding(3)
        Me.PresentingComplaint.Size = New System.Drawing.Size(612, 307)
        Me.PresentingComplaint.TabIndex = 6
        Me.PresentingComplaint.Text = "Presenting Complaint"
        Me.PresentingComplaint.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(173, 133)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(106, 13)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Presenting Complaint"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(153, 91)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(120, 13)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Presenting Complaint ID"
        '
        'txtPresentingComplaint
        '
        Me.txtPresentingComplaint.Location = New System.Drawing.Point(285, 130)
        Me.txtPresentingComplaint.Name = "txtPresentingComplaint"
        Me.txtPresentingComplaint.Size = New System.Drawing.Size(100, 20)
        Me.txtPresentingComplaint.TabIndex = 12
        '
        'txtPresentingComplaint_ID
        '
        Me.txtPresentingComplaint_ID.Location = New System.Drawing.Point(285, 88)
        Me.txtPresentingComplaint_ID.Name = "txtPresentingComplaint_ID"
        Me.txtPresentingComplaint_ID.Size = New System.Drawing.Size(100, 20)
        Me.txtPresentingComplaint_ID.TabIndex = 11
        '
        'btnAddPresentingComplaint
        '
        Me.btnAddPresentingComplaint.Location = New System.Drawing.Point(176, 195)
        Me.btnAddPresentingComplaint.Name = "btnAddPresentingComplaint"
        Me.btnAddPresentingComplaint.Size = New System.Drawing.Size(228, 23)
        Me.btnAddPresentingComplaint.TabIndex = 10
        Me.btnAddPresentingComplaint.Text = "Add Presenting Complaint to Database"
        Me.btnAddPresentingComplaint.UseVisualStyleBackColor = True
        '
        'RiskFactor
        '
        Me.RiskFactor.Controls.Add(Me.Label6)
        Me.RiskFactor.Controls.Add(Me.Label5)
        Me.RiskFactor.Controls.Add(Me.txtRiskFactor)
        Me.RiskFactor.Controls.Add(Me.txtRiskFactor_ID)
        Me.RiskFactor.Controls.Add(Me.btnAddRiskFactor)
        Me.RiskFactor.Location = New System.Drawing.Point(4, 22)
        Me.RiskFactor.Name = "RiskFactor"
        Me.RiskFactor.Padding = New System.Windows.Forms.Padding(3)
        Me.RiskFactor.Size = New System.Drawing.Size(612, 307)
        Me.RiskFactor.TabIndex = 1
        Me.RiskFactor.Text = "RiskFactor"
        Me.RiskFactor.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(172, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Risk Factor"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(158, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Risk Factor ID"
        '
        'txtRiskFactor
        '
        Me.txtRiskFactor.Location = New System.Drawing.Point(247, 124)
        Me.txtRiskFactor.Name = "txtRiskFactor"
        Me.txtRiskFactor.Size = New System.Drawing.Size(100, 20)
        Me.txtRiskFactor.TabIndex = 2
        '
        'txtRiskFactor_ID
        '
        Me.txtRiskFactor_ID.Location = New System.Drawing.Point(247, 79)
        Me.txtRiskFactor_ID.Name = "txtRiskFactor_ID"
        Me.txtRiskFactor_ID.Size = New System.Drawing.Size(100, 20)
        Me.txtRiskFactor_ID.TabIndex = 1
        '
        'btnAddRiskFactor
        '
        Me.btnAddRiskFactor.Location = New System.Drawing.Point(175, 188)
        Me.btnAddRiskFactor.Name = "btnAddRiskFactor"
        Me.btnAddRiskFactor.Size = New System.Drawing.Size(152, 23)
        Me.btnAddRiskFactor.TabIndex = 0
        Me.btnAddRiskFactor.Text = "Add Risk Factor to Database"
        Me.btnAddRiskFactor.UseVisualStyleBackColor = True
        '
        'FamilyHistory
        '
        Me.FamilyHistory.Controls.Add(Me.Label4)
        Me.FamilyHistory.Controls.Add(Me.txtFamilyHistory)
        Me.FamilyHistory.Controls.Add(Me.btnAddFamilyHistory)
        Me.FamilyHistory.Controls.Add(Me.Label1)
        Me.FamilyHistory.Controls.Add(Me.txtFamilyHistoryID)
        Me.FamilyHistory.Location = New System.Drawing.Point(4, 22)
        Me.FamilyHistory.Name = "FamilyHistory"
        Me.FamilyHistory.Padding = New System.Windows.Forms.Padding(3)
        Me.FamilyHistory.Size = New System.Drawing.Size(612, 307)
        Me.FamilyHistory.TabIndex = 0
        Me.FamilyHistory.Text = "FamilyHistory"
        Me.FamilyHistory.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(197, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Family History"
        '
        'txtFamilyHistory
        '
        Me.txtFamilyHistory.Location = New System.Drawing.Point(302, 112)
        Me.txtFamilyHistory.Name = "txtFamilyHistory"
        Me.txtFamilyHistory.Size = New System.Drawing.Size(100, 20)
        Me.txtFamilyHistory.TabIndex = 3
        '
        'btnAddFamilyHistory
        '
        Me.btnAddFamilyHistory.Location = New System.Drawing.Point(215, 181)
        Me.btnAddFamilyHistory.Name = "btnAddFamilyHistory"
        Me.btnAddFamilyHistory.Size = New System.Drawing.Size(175, 23)
        Me.btnAddFamilyHistory.TabIndex = 2
        Me.btnAddFamilyHistory.Text = "Add Family History to Database"
        Me.btnAddFamilyHistory.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(183, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Family History ID"
        '
        'txtFamilyHistoryID
        '
        Me.txtFamilyHistoryID.Location = New System.Drawing.Point(302, 72)
        Me.txtFamilyHistoryID.Name = "txtFamilyHistoryID"
        Me.txtFamilyHistoryID.Size = New System.Drawing.Size(100, 20)
        Me.txtFamilyHistoryID.TabIndex = 0
        '
        'MedicalSurgicalHistory
        '
        Me.MedicalSurgicalHistory.Controls.Add(Me.Label9)
        Me.MedicalSurgicalHistory.Controls.Add(Me.Label10)
        Me.MedicalSurgicalHistory.Controls.Add(Me.txtMedicalHistory)
        Me.MedicalSurgicalHistory.Controls.Add(Me.txtMedicalHistory_ID)
        Me.MedicalSurgicalHistory.Controls.Add(Me.btnAddMedicalHistory)
        Me.MedicalSurgicalHistory.Location = New System.Drawing.Point(4, 22)
        Me.MedicalSurgicalHistory.Name = "MedicalSurgicalHistory"
        Me.MedicalSurgicalHistory.Padding = New System.Windows.Forms.Padding(3)
        Me.MedicalSurgicalHistory.Size = New System.Drawing.Size(612, 307)
        Me.MedicalSurgicalHistory.TabIndex = 4
        Me.MedicalSurgicalHistory.Text = "Medical Surgical History"
        Me.MedicalSurgicalHistory.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(188, 155)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Medical Surgical History"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(174, 107)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(134, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Medical Surgical History ID"
        '
        'txtMedicalHistory
        '
        Me.txtMedicalHistory.Location = New System.Drawing.Point(314, 155)
        Me.txtMedicalHistory.Name = "txtMedicalHistory"
        Me.txtMedicalHistory.Size = New System.Drawing.Size(100, 20)
        Me.txtMedicalHistory.TabIndex = 12
        '
        'txtMedicalHistory_ID
        '
        Me.txtMedicalHistory_ID.Location = New System.Drawing.Point(314, 107)
        Me.txtMedicalHistory_ID.Name = "txtMedicalHistory_ID"
        Me.txtMedicalHistory_ID.Size = New System.Drawing.Size(100, 20)
        Me.txtMedicalHistory_ID.TabIndex = 11
        '
        'btnAddMedicalHistory
        '
        Me.btnAddMedicalHistory.Location = New System.Drawing.Point(185, 215)
        Me.btnAddMedicalHistory.Name = "btnAddMedicalHistory"
        Me.btnAddMedicalHistory.Size = New System.Drawing.Size(229, 23)
        Me.btnAddMedicalHistory.TabIndex = 10
        Me.btnAddMedicalHistory.Text = "Add Medical Surgical History to Database"
        Me.btnAddMedicalHistory.UseVisualStyleBackColor = True
        '
        'Medication
        '
        Me.Medication.Controls.Add(Me.btnClear)
        Me.Medication.Controls.Add(Me.txtMedicationName)
        Me.Medication.Controls.Add(Me.Label17)
        Me.Medication.Controls.Add(Me.Label12)
        Me.Medication.Controls.Add(Me.txtMedication_ID)
        Me.Medication.Controls.Add(Me.btnAddMedicationName)
        Me.Medication.Location = New System.Drawing.Point(4, 22)
        Me.Medication.Name = "Medication"
        Me.Medication.Padding = New System.Windows.Forms.Padding(3)
        Me.Medication.Size = New System.Drawing.Size(612, 307)
        Me.Medication.TabIndex = 5
        Me.Medication.Text = "Medication"
        Me.Medication.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(450, 82)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 17
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtMedicationName
        '
        Me.txtMedicationName.Location = New System.Drawing.Point(285, 110)
        Me.txtMedicationName.Name = "txtMedicationName"
        Me.txtMedicationName.Size = New System.Drawing.Size(100, 20)
        Me.txtMedicationName.TabIndex = 16
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(174, 113)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(90, 13)
        Me.Label17.TabIndex = 15
        Me.Label17.Text = "Medication Name"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(191, 82)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 13)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Medication ID"
        '
        'txtMedication_ID
        '
        Me.txtMedication_ID.Location = New System.Drawing.Point(285, 79)
        Me.txtMedication_ID.Name = "txtMedication_ID"
        Me.txtMedication_ID.Size = New System.Drawing.Size(100, 20)
        Me.txtMedication_ID.TabIndex = 11
        '
        'btnAddMedicationName
        '
        Me.btnAddMedicationName.Location = New System.Drawing.Point(230, 195)
        Me.btnAddMedicationName.Name = "btnAddMedicationName"
        Me.btnAddMedicationName.Size = New System.Drawing.Size(155, 23)
        Me.btnAddMedicationName.TabIndex = 10
        Me.btnAddMedicationName.Text = "Add Medication to Database"
        Me.btnAddMedicationName.UseVisualStyleBackColor = True
        '
        'Diagnosis
        '
        Me.Diagnosis.Controls.Add(Me.txtDiagnosis_ID)
        Me.Diagnosis.Controls.Add(Me.Label3)
        Me.Diagnosis.Controls.Add(Me.txtDiagnosis)
        Me.Diagnosis.Controls.Add(Me.Label2)
        Me.Diagnosis.Controls.Add(Me.btnAddDiagnosis)
        Me.Diagnosis.Location = New System.Drawing.Point(4, 22)
        Me.Diagnosis.Name = "Diagnosis"
        Me.Diagnosis.Padding = New System.Windows.Forms.Padding(3)
        Me.Diagnosis.Size = New System.Drawing.Size(612, 307)
        Me.Diagnosis.TabIndex = 3
        Me.Diagnosis.Text = "Diagnosis"
        Me.Diagnosis.UseVisualStyleBackColor = True
        '
        'txtDiagnosis_ID
        '
        Me.txtDiagnosis_ID.Location = New System.Drawing.Point(309, 69)
        Me.txtDiagnosis_ID.Name = "txtDiagnosis_ID"
        Me.txtDiagnosis_ID.Size = New System.Drawing.Size(130, 20)
        Me.txtDiagnosis_ID.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(191, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Diagnosis ID"
        '
        'txtDiagnosis
        '
        Me.txtDiagnosis.Location = New System.Drawing.Point(309, 107)
        Me.txtDiagnosis.Name = "txtDiagnosis"
        Me.txtDiagnosis.Size = New System.Drawing.Size(130, 20)
        Me.txtDiagnosis.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(205, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Diagnosis"
        '
        'btnAddDiagnosis
        '
        Me.btnAddDiagnosis.Location = New System.Drawing.Point(222, 188)
        Me.btnAddDiagnosis.Name = "btnAddDiagnosis"
        Me.btnAddDiagnosis.Size = New System.Drawing.Size(156, 23)
        Me.btnAddDiagnosis.TabIndex = 0
        Me.btnAddDiagnosis.Text = "Add Diagnosis to Database"
        Me.btnAddDiagnosis.UseVisualStyleBackColor = True
        '
        'Reg
        '
        Me.Reg.Controls.Add(Me.Label15)
        Me.Reg.Controls.Add(Me.Label16)
        Me.Reg.Controls.Add(Me.txtRegName)
        Me.Reg.Controls.Add(Me.txtReg_ID)
        Me.Reg.Controls.Add(Me.btnAddReg)
        Me.Reg.Location = New System.Drawing.Point(4, 22)
        Me.Reg.Name = "Reg"
        Me.Reg.Padding = New System.Windows.Forms.Padding(3)
        Me.Reg.Size = New System.Drawing.Size(612, 307)
        Me.Reg.TabIndex = 7
        Me.Reg.Text = "Registrar"
        Me.Reg.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(193, 137)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 13)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Registrar Name"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(210, 91)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(63, 13)
        Me.Label16.TabIndex = 13
        Me.Label16.Text = "Registrar ID"
        '
        'txtRegName
        '
        Me.txtRegName.Location = New System.Drawing.Point(285, 130)
        Me.txtRegName.Name = "txtRegName"
        Me.txtRegName.Size = New System.Drawing.Size(100, 20)
        Me.txtRegName.TabIndex = 12
        '
        'txtReg_ID
        '
        Me.txtReg_ID.Location = New System.Drawing.Point(285, 88)
        Me.txtReg_ID.Name = "txtReg_ID"
        Me.txtReg_ID.Size = New System.Drawing.Size(100, 20)
        Me.txtReg_ID.TabIndex = 11
        '
        'btnAddReg
        '
        Me.btnAddReg.Location = New System.Drawing.Point(200, 195)
        Me.btnAddReg.Name = "btnAddReg"
        Me.btnAddReg.Size = New System.Drawing.Size(185, 23)
        Me.btnAddReg.TabIndex = 10
        Me.btnAddReg.Text = "Add Registrar Name to Database"
        Me.btnAddReg.UseVisualStyleBackColor = True
        '
        'Consultant
        '
        Me.Consultant.Controls.Add(Me.Label7)
        Me.Consultant.Controls.Add(Me.Label8)
        Me.Consultant.Controls.Add(Me.txtConsultant)
        Me.Consultant.Controls.Add(Me.txtConsultant_ID)
        Me.Consultant.Controls.Add(Me.btnAddConsultant)
        Me.Consultant.Location = New System.Drawing.Point(4, 22)
        Me.Consultant.Name = "Consultant"
        Me.Consultant.Padding = New System.Windows.Forms.Padding(3)
        Me.Consultant.Size = New System.Drawing.Size(612, 307)
        Me.Consultant.TabIndex = 2
        Me.Consultant.Text = "Consultant"
        Me.Consultant.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(214, 119)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Consultant"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(200, 81)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Consultant ID"
        '
        'txtConsultant
        '
        Me.txtConsultant.Location = New System.Drawing.Point(277, 116)
        Me.txtConsultant.Name = "txtConsultant"
        Me.txtConsultant.Size = New System.Drawing.Size(100, 20)
        Me.txtConsultant.TabIndex = 7
        '
        'txtConsultant_ID
        '
        Me.txtConsultant_ID.Location = New System.Drawing.Point(277, 74)
        Me.txtConsultant_ID.Name = "txtConsultant_ID"
        Me.txtConsultant_ID.Size = New System.Drawing.Size(100, 20)
        Me.txtConsultant_ID.TabIndex = 6
        '
        'btnAddConsultant
        '
        Me.btnAddConsultant.Location = New System.Drawing.Point(217, 185)
        Me.btnAddConsultant.Name = "btnAddConsultant"
        Me.btnAddConsultant.Size = New System.Drawing.Size(171, 23)
        Me.btnAddConsultant.TabIndex = 5
        Me.btnAddConsultant.Text = "Add Consultant to Database"
        Me.btnAddConsultant.UseVisualStyleBackColor = True
        '
        'frmMaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 381)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmMaintenance"
        Me.Text = "Maintenance"
        Me.TabControl1.ResumeLayout(False)
        Me.PresentingComplaint.ResumeLayout(False)
        Me.PresentingComplaint.PerformLayout()
        Me.RiskFactor.ResumeLayout(False)
        Me.RiskFactor.PerformLayout()
        Me.FamilyHistory.ResumeLayout(False)
        Me.FamilyHistory.PerformLayout()
        Me.MedicalSurgicalHistory.ResumeLayout(False)
        Me.MedicalSurgicalHistory.PerformLayout()
        Me.Medication.ResumeLayout(False)
        Me.Medication.PerformLayout()
        Me.Diagnosis.ResumeLayout(False)
        Me.Diagnosis.PerformLayout()
        Me.Reg.ResumeLayout(False)
        Me.Reg.PerformLayout()
        Me.Consultant.ResumeLayout(False)
        Me.Consultant.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents FamilyHistory As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFamilyHistoryID As TextBox
    Friend WithEvents RiskFactor As TabPage
    Friend WithEvents Consultant As TabPage
    Friend WithEvents Diagnosis As TabPage
    Friend WithEvents txtDiagnosis_ID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDiagnosis As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAddDiagnosis As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFamilyHistory As TextBox
    Friend WithEvents btnAddFamilyHistory As Button
    Friend WithEvents PresentingComplaint As TabPage
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtPresentingComplaint As TextBox
    Friend WithEvents txtPresentingComplaint_ID As TextBox
    Friend WithEvents btnAddPresentingComplaint As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtRiskFactor As TextBox
    Friend WithEvents txtRiskFactor_ID As TextBox
    Friend WithEvents btnAddRiskFactor As Button
    Friend WithEvents MedicalSurgicalHistory As TabPage
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtMedicalHistory As TextBox
    Friend WithEvents txtMedicalHistory_ID As TextBox
    Friend WithEvents btnAddMedicalHistory As Button
    Friend WithEvents Medication As TabPage
    Friend WithEvents txtMedicationName As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtMedication_ID As TextBox
    Friend WithEvents btnAddMedicationName As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtConsultant As TextBox
    Friend WithEvents txtConsultant_ID As TextBox
    Friend WithEvents btnAddConsultant As Button
    Friend WithEvents Reg As TabPage
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtRegName As TextBox
    Friend WithEvents txtReg_ID As TextBox
    Friend WithEvents btnAddReg As Button
    Friend WithEvents btnClear As Button
End Class
