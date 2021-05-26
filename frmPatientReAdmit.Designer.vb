<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPatientReAdmit
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
        Me.PatientDetails = New System.Windows.Forms.TabPage()
        Me.grpPatientID = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPatName = New System.Windows.Forms.TextBox()
        Me.txtPatMRN = New System.Windows.Forms.TextBox()
        Me.txtPatArea = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.dtpPatDOB = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPatStatus = New System.Windows.Forms.TextBox()
        Me.grpReAdmit = New System.Windows.Forms.GroupBox()
        Me.btnReAdmit = New System.Windows.Forms.Button()
        Me.txtPatSymphony = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.PatientDetails.SuspendLayout()
        Me.grpPatientID.SuspendLayout()
        Me.grpReAdmit.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PatientDetails
        '
        Me.PatientDetails.Controls.Add(Me.grpReAdmit)
        Me.PatientDetails.Controls.Add(Me.txtPatStatus)
        Me.PatientDetails.Controls.Add(Me.Label2)
        Me.PatientDetails.Controls.Add(Me.grpPatientID)
        Me.PatientDetails.Location = New System.Drawing.Point(4, 22)
        Me.PatientDetails.Name = "PatientDetails"
        Me.PatientDetails.Padding = New System.Windows.Forms.Padding(3)
        Me.PatientDetails.Size = New System.Drawing.Size(474, 373)
        Me.PatientDetails.TabIndex = 0
        Me.PatientDetails.Text = "Patient Details"
        Me.PatientDetails.UseVisualStyleBackColor = True
        '
        'grpPatientID
        '
        Me.grpPatientID.Controls.Add(Me.dtpPatDOB)
        Me.grpPatientID.Controls.Add(Me.Label18)
        Me.grpPatientID.Controls.Add(Me.Label19)
        Me.grpPatientID.Controls.Add(Me.lblName)
        Me.grpPatientID.Controls.Add(Me.txtPatArea)
        Me.grpPatientID.Controls.Add(Me.txtPatMRN)
        Me.grpPatientID.Controls.Add(Me.txtPatName)
        Me.grpPatientID.Controls.Add(Me.Label1)
        Me.grpPatientID.Location = New System.Drawing.Point(68, 73)
        Me.grpPatientID.Name = "grpPatientID"
        Me.grpPatientID.Size = New System.Drawing.Size(339, 156)
        Me.grpPatientID.TabIndex = 5
        Me.grpPatientID.TabStop = False
        Me.grpPatientID.Text = "Patient ID Details"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "MRN"
        '
        'txtPatName
        '
        Me.txtPatName.Location = New System.Drawing.Point(189, 17)
        Me.txtPatName.Name = "txtPatName"
        Me.txtPatName.ReadOnly = True
        Me.txtPatName.Size = New System.Drawing.Size(100, 20)
        Me.txtPatName.TabIndex = 0
        '
        'txtPatMRN
        '
        Me.txtPatMRN.Location = New System.Drawing.Point(189, 48)
        Me.txtPatMRN.Name = "txtPatMRN"
        Me.txtPatMRN.ReadOnly = True
        Me.txtPatMRN.Size = New System.Drawing.Size(100, 20)
        Me.txtPatMRN.TabIndex = 1
        '
        'txtPatArea
        '
        Me.txtPatArea.Location = New System.Drawing.Point(189, 81)
        Me.txtPatArea.Name = "txtPatArea"
        Me.txtPatArea.ReadOnly = True
        Me.txtPatArea.Size = New System.Drawing.Size(100, 20)
        Me.txtPatArea.TabIndex = 2
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(48, 24)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 26
        Me.lblName.Text = "Name"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(54, 84)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(29, 13)
        Me.Label19.TabIndex = 25
        Me.Label19.Text = "Area"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(53, 120)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(30, 13)
        Me.Label18.TabIndex = 24
        Me.Label18.Text = "DOB"
        '
        'dtpPatDOB
        '
        Me.dtpPatDOB.Location = New System.Drawing.Point(166, 120)
        Me.dtpPatDOB.Name = "dtpPatDOB"
        Me.dtpPatDOB.Size = New System.Drawing.Size(157, 20)
        Me.dtpPatDOB.TabIndex = 27
        Me.dtpPatDOB.UseWaitCursor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(97, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Patient Status"
        '
        'txtPatStatus
        '
        Me.txtPatStatus.Location = New System.Drawing.Point(203, 26)
        Me.txtPatStatus.Name = "txtPatStatus"
        Me.txtPatStatus.ReadOnly = True
        Me.txtPatStatus.Size = New System.Drawing.Size(100, 20)
        Me.txtPatStatus.TabIndex = 12
        '
        'grpReAdmit
        '
        Me.grpReAdmit.Controls.Add(Me.Label3)
        Me.grpReAdmit.Controls.Add(Me.txtPatSymphony)
        Me.grpReAdmit.Controls.Add(Me.btnReAdmit)
        Me.grpReAdmit.Location = New System.Drawing.Point(95, 235)
        Me.grpReAdmit.Name = "grpReAdmit"
        Me.grpReAdmit.Size = New System.Drawing.Size(262, 115)
        Me.grpReAdmit.TabIndex = 13
        Me.grpReAdmit.TabStop = False
        Me.grpReAdmit.Text = "Re-Admission"
        '
        'btnReAdmit
        '
        Me.btnReAdmit.Location = New System.Drawing.Point(81, 76)
        Me.btnReAdmit.Name = "btnReAdmit"
        Me.btnReAdmit.Size = New System.Drawing.Size(100, 33)
        Me.btnReAdmit.TabIndex = 10
        Me.btnReAdmit.Text = "Re-Admit Patient"
        Me.btnReAdmit.UseVisualStyleBackColor = True
        '
        'txtPatSymphony
        '
        Me.txtPatSymphony.Location = New System.Drawing.Point(139, 35)
        Me.txtPatSymphony.Name = "txtPatSymphony"
        Me.txtPatSymphony.Size = New System.Drawing.Size(100, 20)
        Me.txtPatSymphony.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Symphony Number"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.PatientDetails)
        Me.TabControl1.Location = New System.Drawing.Point(12, 6)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(482, 399)
        Me.TabControl1.TabIndex = 11
        '
        'frmPatientReAdmit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 438)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmPatientReAdmit"
        Me.Text = "Patient Details"
        Me.PatientDetails.ResumeLayout(False)
        Me.PatientDetails.PerformLayout()
        Me.grpPatientID.ResumeLayout(False)
        Me.grpPatientID.PerformLayout()
        Me.grpReAdmit.ResumeLayout(False)
        Me.grpReAdmit.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PatientDetails As TabPage
    Friend WithEvents grpReAdmit As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPatSymphony As TextBox
    Friend WithEvents btnReAdmit As Button
    Friend WithEvents txtPatStatus As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents grpPatientID As GroupBox
    Friend WithEvents dtpPatDOB As DateTimePicker
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents txtPatArea As TextBox
    Friend WithEvents txtPatMRN As TextBox
    Friend WithEvents txtPatName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
End Class
