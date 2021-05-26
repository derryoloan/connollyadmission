<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AdministrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewPatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AmmendPatientRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatabaseMaintenanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToMastercodesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewMasterCodesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManagePatientsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateInpatientsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiscahargeInPatientsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReAdmitPatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnUserMenu = New System.Windows.Forms.Button()
        Me.PatientByMedicationATCCodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministrationToolStripMenuItem, Me.ManagePatientsToolStripMenuItem, Me.ReportsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(527, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdministrationToolStripMenuItem
        '
        Me.AdministrationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewPatientToolStripMenuItem, Me.AmmendPatientRecordToolStripMenuItem, Me.DatabaseMaintenanceToolStripMenuItem})
        Me.AdministrationToolStripMenuItem.Name = "AdministrationToolStripMenuItem"
        Me.AdministrationToolStripMenuItem.Size = New System.Drawing.Size(98, 20)
        Me.AdministrationToolStripMenuItem.Text = "Administration"
        '
        'AddNewPatientToolStripMenuItem
        '
        Me.AddNewPatientToolStripMenuItem.Name = "AddNewPatientToolStripMenuItem"
        Me.AddNewPatientToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.AddNewPatientToolStripMenuItem.Text = "Add New Patient"
        '
        'AmmendPatientRecordToolStripMenuItem
        '
        Me.AmmendPatientRecordToolStripMenuItem.Name = "AmmendPatientRecordToolStripMenuItem"
        Me.AmmendPatientRecordToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.AmmendPatientRecordToolStripMenuItem.Text = "Ammend Patient Record"
        '
        'DatabaseMaintenanceToolStripMenuItem
        '
        Me.DatabaseMaintenanceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToMastercodesToolStripMenuItem, Me.ViewMasterCodesToolStripMenuItem})
        Me.DatabaseMaintenanceToolStripMenuItem.Name = "DatabaseMaintenanceToolStripMenuItem"
        Me.DatabaseMaintenanceToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.DatabaseMaintenanceToolStripMenuItem.Text = "Database Maintenance"
        '
        'AddToMastercodesToolStripMenuItem
        '
        Me.AddToMastercodesToolStripMenuItem.Name = "AddToMastercodesToolStripMenuItem"
        Me.AddToMastercodesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AddToMastercodesToolStripMenuItem.Text = "Add to Mastercodes"
        '
        'ViewMasterCodesToolStripMenuItem
        '
        Me.ViewMasterCodesToolStripMenuItem.Name = "ViewMasterCodesToolStripMenuItem"
        Me.ViewMasterCodesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ViewMasterCodesToolStripMenuItem.Text = "View MasterCodes"
        '
        'ManagePatientsToolStripMenuItem
        '
        Me.ManagePatientsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.UpdateInpatientsToolStripMenuItem, Me.DiscahargeInPatientsToolStripMenuItem, Me.ReAdmitPatientToolStripMenuItem})
        Me.ManagePatientsToolStripMenuItem.Name = "ManagePatientsToolStripMenuItem"
        Me.ManagePatientsToolStripMenuItem.Size = New System.Drawing.Size(107, 20)
        Me.ManagePatientsToolStripMenuItem.Text = "Manage Patients"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(200, 22)
        Me.ToolStripMenuItem1.Text = "Search for a Patient"
        '
        'UpdateInpatientsToolStripMenuItem
        '
        Me.UpdateInpatientsToolStripMenuItem.Name = "UpdateInpatientsToolStripMenuItem"
        Me.UpdateInpatientsToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.UpdateInpatientsToolStripMenuItem.Text = "Update Inpatients"
        '
        'DiscahargeInPatientsToolStripMenuItem
        '
        Me.DiscahargeInPatientsToolStripMenuItem.Name = "DiscahargeInPatientsToolStripMenuItem"
        Me.DiscahargeInPatientsToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.DiscahargeInPatientsToolStripMenuItem.Text = "Discaharge In-Patient(s)"
        '
        'ReAdmitPatientToolStripMenuItem
        '
        Me.ReAdmitPatientToolStripMenuItem.Name = "ReAdmitPatientToolStripMenuItem"
        Me.ReAdmitPatientToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.ReAdmitPatientToolStripMenuItem.Text = "Re-Admit Patient"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PatientByMedicationATCCodeToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'btnUserMenu
        '
        Me.btnUserMenu.Location = New System.Drawing.Point(419, 60)
        Me.btnUserMenu.Name = "btnUserMenu"
        Me.btnUserMenu.Size = New System.Drawing.Size(75, 23)
        Me.btnUserMenu.TabIndex = 1
        Me.btnUserMenu.Text = "User Menu"
        Me.btnUserMenu.UseVisualStyleBackColor = True
        '
        'PatientByMedicationATCCodeToolStripMenuItem
        '
        Me.PatientByMedicationATCCodeToolStripMenuItem.Name = "PatientByMedicationATCCodeToolStripMenuItem"
        Me.PatientByMedicationATCCodeToolStripMenuItem.Size = New System.Drawing.Size(243, 22)
        Me.PatientByMedicationATCCodeToolStripMenuItem.Text = "Patient by Medication ATC code"
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 180)
        Me.Controls.Add(Me.btnUserMenu)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMainMenu"
        Me.Tag = ","
        Me.Text = "Developer Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AdministrationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewPatientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AmmendPatientRecordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManagePatientsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateInpatientsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReAdmitPatientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DiscahargeInPatientsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DatabaseMaintenanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddToMastercodesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewMasterCodesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnUserMenu As Button
    Friend WithEvents PatientByMedicationATCCodeToolStripMenuItem As ToolStripMenuItem
End Class
