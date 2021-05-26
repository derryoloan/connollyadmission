<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportMedicationPatient
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
        Me.dgvReportPatientMed = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtATC = New System.Windows.Forms.TextBox()
        Me.btnATCSearch = New System.Windows.Forms.Button()
        Me.btnMainUser = New System.Windows.Forms.Button()
        CType(Me.dgvReportPatientMed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvReportPatientMed
        '
        Me.dgvReportPatientMed.AllowUserToAddRows = False
        Me.dgvReportPatientMed.AllowUserToDeleteRows = False
        Me.dgvReportPatientMed.AllowUserToResizeColumns = False
        Me.dgvReportPatientMed.AllowUserToResizeRows = False
        Me.dgvReportPatientMed.BackgroundColor = System.Drawing.Color.LemonChiffon
        Me.dgvReportPatientMed.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvReportPatientMed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReportPatientMed.Location = New System.Drawing.Point(79, 149)
        Me.dgvReportPatientMed.Name = "dgvReportPatientMed"
        Me.dgvReportPatientMed.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dgvReportPatientMed.RowHeadersVisible = False
        Me.dgvReportPatientMed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReportPatientMed.Size = New System.Drawing.Size(544, 165)
        Me.dgvReportPatientMed.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(74, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Patient Report"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(93, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ATC Code"
        '
        'txtATC
        '
        Me.txtATC.Location = New System.Drawing.Point(199, 40)
        Me.txtATC.Name = "txtATC"
        Me.txtATC.Size = New System.Drawing.Size(178, 20)
        Me.txtATC.TabIndex = 3
        '
        'btnATCSearch
        '
        Me.btnATCSearch.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnATCSearch.Location = New System.Drawing.Point(417, 38)
        Me.btnATCSearch.Name = "btnATCSearch"
        Me.btnATCSearch.Size = New System.Drawing.Size(105, 23)
        Me.btnATCSearch.TabIndex = 4
        Me.btnATCSearch.Text = "Search for Patients"
        Me.btnATCSearch.UseVisualStyleBackColor = False
        '
        'btnMainUser
        '
        Me.btnMainUser.Location = New System.Drawing.Point(549, 347)
        Me.btnMainUser.Name = "btnMainUser"
        Me.btnMainUser.Size = New System.Drawing.Size(141, 23)
        Me.btnMainUser.TabIndex = 5
        Me.btnMainUser.Text = "Go To Patient Menu"
        Me.btnMainUser.UseVisualStyleBackColor = True
        '
        'frmReportMedicationPatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(702, 382)
        Me.Controls.Add(Me.btnMainUser)
        Me.Controls.Add(Me.btnATCSearch)
        Me.Controls.Add(Me.txtATC)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvReportPatientMed)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Name = "frmReportMedicationPatient"
        Me.Text = "Report-Patients by Medication"
        CType(Me.dgvReportPatientMed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvReportPatientMed As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtATC As TextBox
    Friend WithEvents btnATCSearch As Button
    Friend WithEvents btnMainUser As Button
End Class
