<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultantList
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
        Me.lstPatientDisc = New System.Windows.Forms.ListView()
        Me.PatientMRN = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PatientName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DOB = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Consultant = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnReport = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstPatientDisc
        '
        Me.lstPatientDisc.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lstPatientDisc.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.PatientMRN, Me.PatientName, Me.DOB, Me.Consultant})
        Me.lstPatientDisc.FullRowSelect = True
        Me.lstPatientDisc.GridLines = True
        Me.lstPatientDisc.Location = New System.Drawing.Point(12, 12)
        Me.lstPatientDisc.Name = "lstPatientDisc"
        Me.lstPatientDisc.Size = New System.Drawing.Size(294, 257)
        Me.lstPatientDisc.TabIndex = 4
        Me.lstPatientDisc.UseCompatibleStateImageBehavior = False
        Me.lstPatientDisc.View = System.Windows.Forms.View.Details
        '
        'PatientMRN
        '
        Me.PatientMRN.Text = "MRN"
        '
        'PatientName
        '
        Me.PatientName.Text = "Name"
        Me.PatientName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.PatientName.Width = 75
        '
        'DOB
        '
        Me.DOB.Text = "Date of Birth"
        Me.DOB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DOB.Width = 75
        '
        'Consultant
        '
        Me.Consultant.Text = "Consultant"
        Me.Consultant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Consultant.Width = 80
        '
        'btnReport
        '
        Me.btnReport.Location = New System.Drawing.Point(144, 325)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(75, 23)
        Me.btnReport.TabIndex = 5
        Me.btnReport.Text = "Copy to Print"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'frmConsultantList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 397)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.lstPatientDisc)
        Me.Name = "frmConsultantList"
        Me.Text = "In-patient Consultant List"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstPatientDisc As ListView
    Friend WithEvents PatientMRN As ColumnHeader
    Friend WithEvents PatientName As ColumnHeader
    Friend WithEvents DOB As ColumnHeader
    Friend WithEvents Consultant As ColumnHeader
    Friend WithEvents btnReport As Button
End Class
