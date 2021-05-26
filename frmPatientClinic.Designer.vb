<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPatientClinic
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
        Me.grpPatientID = New System.Windows.Forms.GroupBox()
        Me.dtpPatDOB = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtPatSymphony = New System.Windows.Forms.TextBox()
        Me.txtPatArea = New System.Windows.Forms.TextBox()
        Me.txtPatMRN = New System.Windows.Forms.TextBox()
        Me.txtPatName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpDischargeDate = New System.Windows.Forms.DateTimePicker()
        Me.btnDischarge = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAdmissionScreen = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grpPatientID.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.grpPatientID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPatientID.Location = New System.Drawing.Point(59, 71)
        Me.grpPatientID.Name = "grpPatientID"
        Me.grpPatientID.Size = New System.Drawing.Size(420, 189)
        Me.grpPatientID.TabIndex = 6
        Me.grpPatientID.TabStop = False
        Me.grpPatientID.Text = "Patient ID Details"
        '
        'dtpPatDOB
        '
        Me.dtpPatDOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpPatDOB.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPatDOB.Location = New System.Drawing.Point(228, 116)
        Me.dtpPatDOB.Name = "dtpPatDOB"
        Me.dtpPatDOB.Size = New System.Drawing.Size(100, 26)
        Me.dtpPatDOB.TabIndex = 27
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(19, 151)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(143, 20)
        Me.Label17.TabIndex = 23
        Me.Label17.Text = "Symphony Number"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(118, 122)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(44, 20)
        Me.Label18.TabIndex = 24
        Me.Label18.Text = "DOB"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(121, 87)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(43, 20)
        Me.Label19.TabIndex = 25
        Me.Label19.Text = "Area"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(113, 22)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(51, 20)
        Me.lblName.TabIndex = 26
        Me.lblName.Text = "Name"
        '
        'txtPatSymphony
        '
        Me.txtPatSymphony.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatSymphony.Location = New System.Drawing.Point(228, 148)
        Me.txtPatSymphony.Name = "txtPatSymphony"
        Me.txtPatSymphony.Size = New System.Drawing.Size(100, 26)
        Me.txtPatSymphony.TabIndex = 4
        '
        'txtPatArea
        '
        Me.txtPatArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatArea.Location = New System.Drawing.Point(228, 81)
        Me.txtPatArea.Name = "txtPatArea"
        Me.txtPatArea.Size = New System.Drawing.Size(100, 26)
        Me.txtPatArea.TabIndex = 2
        '
        'txtPatMRN
        '
        Me.txtPatMRN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatMRN.Location = New System.Drawing.Point(228, 49)
        Me.txtPatMRN.Name = "txtPatMRN"
        Me.txtPatMRN.Size = New System.Drawing.Size(100, 26)
        Me.txtPatMRN.TabIndex = 1
        '
        'txtPatName
        '
        Me.txtPatName.BackColor = System.Drawing.Color.White
        Me.txtPatName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatName.Location = New System.Drawing.Point(228, 17)
        Me.txtPatName.Name = "txtPatName"
        Me.txtPatName.Size = New System.Drawing.Size(100, 26)
        Me.txtPatName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(117, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "MRN"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpDischargeDate)
        Me.GroupBox1.Controls.Add(Me.btnDischarge)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(97, 330)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(318, 145)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Close Current Encounter"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(249, 20)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Discharge Date Defaults to Today"
        '
        'dtpDischargeDate
        '
        Me.dtpDischargeDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDischargeDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDischargeDate.Location = New System.Drawing.Point(155, 25)
        Me.dtpDischargeDate.Name = "dtpDischargeDate"
        Me.dtpDischargeDate.Size = New System.Drawing.Size(115, 26)
        Me.dtpDischargeDate.TabIndex = 28
        '
        'btnDischarge
        '
        Me.btnDischarge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDischarge.Location = New System.Drawing.Point(42, 72)
        Me.btnDischarge.Name = "btnDischarge"
        Me.btnDischarge.Size = New System.Drawing.Size(235, 36)
        Me.btnDischarge.TabIndex = 27
        Me.btnDischarge.Text = "Set Patient to On Record"
        Me.btnDischarge.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 20)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Discharge Date"
        '
        'btnAdmissionScreen
        '
        Me.btnAdmissionScreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmissionScreen.Location = New System.Drawing.Point(114, 282)
        Me.btnAdmissionScreen.Name = "btnAdmissionScreen"
        Me.btnAdmissionScreen.Size = New System.Drawing.Size(301, 31)
        Me.btnAdmissionScreen.TabIndex = 28
        Me.btnAdmissionScreen.Text = "View Patient Record/Recent Admission Details"
        Me.btnAdmissionScreen.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(310, 25)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(57, 20)
        Me.lblStatus.TabIndex = 29
        Me.lblStatus.Text = "Label4"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(180, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 20)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Patient Status"
        '
        'frmPatientClinic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 487)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnAdmissionScreen)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpPatientID)
        Me.Name = "frmPatientClinic"
        Me.Text = "Patient Clinic Details"
        Me.grpPatientID.ResumeLayout(False)
        Me.grpPatientID.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpPatientID As GroupBox
    Friend WithEvents dtpPatDOB As DateTimePicker
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents txtPatSymphony As TextBox
    Friend WithEvents txtPatArea As TextBox
    Friend WithEvents txtPatMRN As TextBox
    Friend WithEvents txtPatName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpDischargeDate As DateTimePicker
    Friend WithEvents btnDischarge As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAdmissionScreen As Button
    Friend WithEvents lblStatus As Label
    Friend WithEvents Label4 As Label
End Class
