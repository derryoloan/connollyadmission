<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPatientNew
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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.grpPatientDetails = New System.Windows.Forms.GroupBox()
        Me.lblSymphony = New System.Windows.Forms.Label()
        Me.dtpPatDOB = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPatSymphony = New System.Windows.Forms.TextBox()
        Me.txtPatArea = New System.Windows.Forms.TextBox()
        Me.txtPatMRN = New System.Windows.Forms.TextBox()
        Me.txtPatName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.grpPatientDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(252, 434)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(370, 66)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Add Patient Details to New Admission"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'grpPatientDetails
        '
        Me.grpPatientDetails.BackColor = System.Drawing.Color.WhiteSmoke
        Me.grpPatientDetails.Controls.Add(Me.lblSymphony)
        Me.grpPatientDetails.Controls.Add(Me.dtpPatDOB)
        Me.grpPatientDetails.Controls.Add(Me.Label2)
        Me.grpPatientDetails.Controls.Add(Me.Label3)
        Me.grpPatientDetails.Controls.Add(Me.Label4)
        Me.grpPatientDetails.Controls.Add(Me.Label5)
        Me.grpPatientDetails.Controls.Add(Me.txtPatSymphony)
        Me.grpPatientDetails.Controls.Add(Me.txtPatArea)
        Me.grpPatientDetails.Controls.Add(Me.txtPatMRN)
        Me.grpPatientDetails.Controls.Add(Me.txtPatName)
        Me.grpPatientDetails.Controls.Add(Me.Label6)
        Me.grpPatientDetails.ForeColor = System.Drawing.Color.MidnightBlue
        Me.grpPatientDetails.Location = New System.Drawing.Point(186, 52)
        Me.grpPatientDetails.Margin = New System.Windows.Forms.Padding(4)
        Me.grpPatientDetails.Name = "grpPatientDetails"
        Me.grpPatientDetails.Padding = New System.Windows.Forms.Padding(4)
        Me.grpPatientDetails.Size = New System.Drawing.Size(592, 259)
        Me.grpPatientDetails.TabIndex = 6
        Me.grpPatientDetails.TabStop = False
        Me.grpPatientDetails.Text = "Patient ID Details"
        '
        'lblSymphony
        '
        Me.lblSymphony.AutoSize = True
        Me.lblSymphony.Location = New System.Drawing.Point(296, 208)
        Me.lblSymphony.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSymphony.Name = "lblSymphony"
        Me.lblSymphony.Size = New System.Drawing.Size(204, 19)
        Me.lblSymphony.TabIndex = 28
        Me.lblSymphony.Text = "Number from ED Admission"
        Me.lblSymphony.Visible = False
        '
        'dtpPatDOB
        '
        Me.dtpPatDOB.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPatDOB.Location = New System.Drawing.Point(325, 132)
        Me.dtpPatDOB.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpPatDOB.Name = "dtpPatDOB"
        Me.dtpPatDOB.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtpPatDOB.Size = New System.Drawing.Size(111, 26)
        Me.dtpPatDOB.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 186)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 19)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Symphony Number"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 146)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 19)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "DOB"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 108)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 19)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Area"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 35)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 19)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Name"
        '
        'txtPatSymphony
        '
        Me.txtPatSymphony.Location = New System.Drawing.Point(268, 174)
        Me.txtPatSymphony.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPatSymphony.Name = "txtPatSymphony"
        Me.txtPatSymphony.Size = New System.Drawing.Size(206, 26)
        Me.txtPatSymphony.TabIndex = 4
        '
        'txtPatArea
        '
        Me.txtPatArea.Location = New System.Drawing.Point(268, 98)
        Me.txtPatArea.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPatArea.Name = "txtPatArea"
        Me.txtPatArea.Size = New System.Drawing.Size(206, 26)
        Me.txtPatArea.TabIndex = 2
        '
        'txtPatMRN
        '
        Me.txtPatMRN.Location = New System.Drawing.Point(268, 60)
        Me.txtPatMRN.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPatMRN.Name = "txtPatMRN"
        Me.txtPatMRN.Size = New System.Drawing.Size(206, 26)
        Me.txtPatMRN.TabIndex = 1
        '
        'txtPatName
        '
        Me.txtPatName.Location = New System.Drawing.Point(268, 25)
        Me.txtPatName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPatName.Name = "txtPatName"
        Me.txtPatName.Size = New System.Drawing.Size(206, 26)
        Me.txtPatName.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 70)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 19)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "MRN"
        '
        'frmPatientNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMargin = New System.Drawing.Size(10, 10)
        Me.AutoScrollMinSize = New System.Drawing.Size(10, 10)
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(948, 617)
        Me.Controls.Add(Me.grpPatientDetails)
        Me.Controls.Add(Me.btnAdd)
        Me.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmPatientNew"
        Me.Text = "Patient Details"
        Me.grpPatientDetails.ResumeLayout(False)
        Me.grpPatientDetails.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAdd As Button
    Friend WithEvents grpPatientDetails As GroupBox
    Friend WithEvents dtpPatDOB As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPatSymphony As TextBox
    Friend WithEvents txtPatArea As TextBox
    Friend WithEvents txtPatMRN As TextBox
    Friend WithEvents txtPatName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblSymphony As Label
End Class
