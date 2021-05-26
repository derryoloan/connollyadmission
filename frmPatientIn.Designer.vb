<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPatientIn
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtPatStatus = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpDischargeDate = New System.Windows.Forms.DateTimePicker()
        Me.btnDischarge = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAdmissionScreen = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPatName = New System.Windows.Forms.TextBox()
        Me.txtPatMRN = New System.Windows.Forms.TextBox()
        Me.txtPatArea = New System.Windows.Forms.TextBox()
        Me.txtPatSymphony = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.dtpPatDOB = New System.Windows.Forms.DateTimePicker()
        Me.grpPatientID = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnAddClinic = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpAppointmentDate = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1.SuspendLayout()
        Me.grpPatientID.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(224, 6)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(91, 19)
        Me.Label20.TabIndex = 23
        Me.Label20.Text = "Patient Status"
        '
        'txtPatStatus
        '
        Me.txtPatStatus.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatStatus.Location = New System.Drawing.Point(321, 3)
        Me.txtPatStatus.Name = "txtPatStatus"
        Me.txtPatStatus.Size = New System.Drawing.Size(91, 26)
        Me.txtPatStatus.TabIndex = 24
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpDischargeDate)
        Me.GroupBox1.Controls.Add(Me.btnDischarge)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(34, 295)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(273, 164)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Close Current  Admission"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(213, 19)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Discharge Date Defaults to Today"
        '
        'dtpDischargeDate
        '
        Me.dtpDischargeDate.Location = New System.Drawing.Point(117, 41)
        Me.dtpDischargeDate.Name = "dtpDischargeDate"
        Me.dtpDischargeDate.Size = New System.Drawing.Size(143, 26)
        Me.dtpDischargeDate.TabIndex = 28
        '
        'btnDischarge
        '
        Me.btnDischarge.Location = New System.Drawing.Point(48, 93)
        Me.btnDischarge.Name = "btnDischarge"
        Me.btnDischarge.Size = New System.Drawing.Size(170, 23)
        Me.btnDischarge.TabIndex = 27
        Me.btnDischarge.Text = "Set Patient to On Record"
        Me.btnDischarge.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 19)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Discharge Date"
        '
        'btnAdmissionScreen
        '
        Me.btnAdmissionScreen.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmissionScreen.Location = New System.Drawing.Point(230, 234)
        Me.btnAdmissionScreen.Name = "btnAdmissionScreen"
        Me.btnAdmissionScreen.Size = New System.Drawing.Size(229, 29)
        Me.btnAdmissionScreen.TabIndex = 27
        Me.btnAdmissionScreen.Text = "View/Update Current Admission"
        Me.btnAdmissionScreen.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 19)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "MRN"
        '
        'txtPatName
        '
        Me.txtPatName.Location = New System.Drawing.Point(179, 17)
        Me.txtPatName.Name = "txtPatName"
        Me.txtPatName.Size = New System.Drawing.Size(100, 26)
        Me.txtPatName.TabIndex = 0
        '
        'txtPatMRN
        '
        Me.txtPatMRN.Location = New System.Drawing.Point(179, 41)
        Me.txtPatMRN.Name = "txtPatMRN"
        Me.txtPatMRN.Size = New System.Drawing.Size(100, 26)
        Me.txtPatMRN.TabIndex = 1
        '
        'txtPatArea
        '
        Me.txtPatArea.Location = New System.Drawing.Point(179, 67)
        Me.txtPatArea.Name = "txtPatArea"
        Me.txtPatArea.Size = New System.Drawing.Size(100, 26)
        Me.txtPatArea.TabIndex = 2
        '
        'txtPatSymphony
        '
        Me.txtPatSymphony.Location = New System.Drawing.Point(179, 119)
        Me.txtPatSymphony.Name = "txtPatSymphony"
        Me.txtPatSymphony.Size = New System.Drawing.Size(100, 26)
        Me.txtPatSymphony.TabIndex = 4
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(16, 24)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(46, 19)
        Me.lblName.TabIndex = 26
        Me.lblName.Text = "Name"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(22, 74)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(39, 19)
        Me.Label19.TabIndex = 25
        Me.Label19.Text = "Area"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(21, 100)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(42, 19)
        Me.Label18.TabIndex = 24
        Me.Label18.Text = "DOB"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 127)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(127, 19)
        Me.Label17.TabIndex = 23
        Me.Label17.Text = "Symphony Number"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpPatDOB
        '
        Me.dtpPatDOB.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPatDOB.Location = New System.Drawing.Point(179, 93)
        Me.dtpPatDOB.Name = "dtpPatDOB"
        Me.dtpPatDOB.Size = New System.Drawing.Size(100, 26)
        Me.dtpPatDOB.TabIndex = 27
        '
        'grpPatientID
        '
        Me.grpPatientID.Controls.Add(Me.dtpPatDOB)
        Me.grpPatientID.Controls.Add(Me.Label17)
        Me.grpPatientID.Controls.Add(Me.Label18)
        Me.grpPatientID.Controls.Add(Me.Label19)
        Me.grpPatientID.Controls.Add(Me.lblName)
        Me.grpPatientID.Controls.Add(Me.txtPatSymphony)
        Me.grpPatientID.Controls.Add(Me.txtPatArea)
        Me.grpPatientID.Controls.Add(Me.txtPatMRN)
        Me.grpPatientID.Controls.Add(Me.txtPatName)
        Me.grpPatientID.Controls.Add(Me.Label1)
        Me.grpPatientID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPatientID.Location = New System.Drawing.Point(176, 37)
        Me.grpPatientID.Name = "grpPatientID"
        Me.grpPatientID.Size = New System.Drawing.Size(333, 178)
        Me.grpPatientID.TabIndex = 5
        Me.grpPatientID.TabStop = False
        Me.grpPatientID.Text = "Patient ID Details"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnAddClinic)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.dtpAppointmentDate)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(358, 295)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(335, 164)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Patient Returning to Clinic"
        '
        'btnAddClinic
        '
        Me.btnAddClinic.Location = New System.Drawing.Point(87, 93)
        Me.btnAddClinic.Name = "btnAddClinic"
        Me.btnAddClinic.Size = New System.Drawing.Size(186, 23)
        Me.btnAddClinic.TabIndex = 31
        Me.btnAddClinic.Text = "Set Patient to Clinic"
        Me.btnAddClinic.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(86, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(187, 19)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Clinic Date Defaults to Today"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 19)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Set Date for Clinic"
        '
        'dtpAppointmentDate
        '
        Me.dtpAppointmentDate.Location = New System.Drawing.Point(166, 41)
        Me.dtpAppointmentDate.Name = "dtpAppointmentDate"
        Me.dtpAppointmentDate.Size = New System.Drawing.Size(144, 26)
        Me.dtpAppointmentDate.TabIndex = 0
        '
        'frmPatientIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(705, 495)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnAdmissionScreen)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txtPatStatus)
        Me.Controls.Add(Me.grpPatientID)
        Me.Name = "frmPatientIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patient Details"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpPatientID.ResumeLayout(False)
        Me.grpPatientID.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label20 As Label
    Friend WithEvents txtPatStatus As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnDischarge As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpDischargeDate As DateTimePicker
    Friend WithEvents btnAdmissionScreen As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPatName As TextBox
    Friend WithEvents txtPatMRN As TextBox
    Friend WithEvents txtPatArea As TextBox
    Friend WithEvents txtPatSymphony As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents dtpPatDOB As DateTimePicker
    Friend WithEvents grpPatientID As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnAddClinic As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpAppointmentDate As DateTimePicker
End Class
