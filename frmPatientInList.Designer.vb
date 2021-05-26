<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPatientInList
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
        Me.lstPatientDetails = New System.Windows.Forms.ListView()
        Me.PatientName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PatientMRN = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Location = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DOB = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SymphonyID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PatientStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'lstPatientDetails
        '
        Me.lstPatientDetails.BackColor = System.Drawing.Color.FloralWhite
        Me.lstPatientDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstPatientDetails.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.PatientName, Me.PatientMRN, Me.Location, Me.DOB, Me.SymphonyID, Me.PatientStatus})
        Me.lstPatientDetails.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPatientDetails.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lstPatientDetails.FullRowSelect = True
        Me.lstPatientDetails.GridLines = True
        Me.lstPatientDetails.Location = New System.Drawing.Point(28, 70)
        Me.lstPatientDetails.Name = "lstPatientDetails"
        Me.lstPatientDetails.Size = New System.Drawing.Size(830, 157)
        Me.lstPatientDetails.TabIndex = 1
        Me.lstPatientDetails.UseCompatibleStateImageBehavior = False
        Me.lstPatientDetails.View = System.Windows.Forms.View.Details
        '
        'PatientName
        '
        Me.PatientName.Text = "Patient Name"
        Me.PatientName.Width = 181
        '
        'PatientMRN
        '
        Me.PatientMRN.Text = "Patient MRN"
        Me.PatientMRN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.PatientMRN.Width = 136
        '
        'Location
        '
        Me.Location.Text = "Location"
        Me.Location.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Location.Width = 116
        '
        'DOB
        '
        Me.DOB.Text = "DOB"
        Me.DOB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DOB.Width = 104
        '
        'SymphonyID
        '
        Me.SymphonyID.Text = "SymphonyID"
        Me.SymphonyID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.SymphonyID.Width = 136
        '
        'PatientStatus
        '
        Me.PatientStatus.Text = "Status"
        Me.PatientStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.PatientStatus.Width = 190
        '
        'frmPatientInList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(908, 365)
        Me.Controls.Add(Me.lstPatientDetails)
        Me.Name = "frmPatientInList"
        Me.Text = "Patient List"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstPatientDetails As ListView
    Friend WithEvents PatientName As ColumnHeader
    Friend WithEvents PatientMRN As ColumnHeader
    Friend WithEvents SymphonyID As ColumnHeader
    Friend WithEvents PatientStatus As ColumnHeader
    Friend WithEvents Location As ColumnHeader
    Friend WithEvents DOB As ColumnHeader
End Class
