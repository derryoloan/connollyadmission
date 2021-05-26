<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPatientWardList
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
        Me.lstvWardList = New System.Windows.Forms.ListView()
        Me.PatientName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MRN = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Ward = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'lstvWardList
        '
        Me.lstvWardList.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lstvWardList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.PatientName, Me.MRN, Me.Ward})
        Me.lstvWardList.GridLines = True
        Me.lstvWardList.Location = New System.Drawing.Point(108, 33)
        Me.lstvWardList.Name = "lstvWardList"
        Me.lstvWardList.Size = New System.Drawing.Size(257, 135)
        Me.lstvWardList.TabIndex = 0
        Me.lstvWardList.UseCompatibleStateImageBehavior = False
        Me.lstvWardList.View = System.Windows.Forms.View.Details
        '
        'PatientName
        '
        Me.PatientName.Text = "Patient"
        Me.PatientName.Width = 86
        '
        'MRN
        '
        Me.MRN.Text = "MRN"
        Me.MRN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MRN.Width = 74
        '
        'Ward
        '
        Me.Ward.Text = "Ward"
        Me.Ward.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Ward.Width = 90
        '
        'frmPatientWardList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 261)
        Me.Controls.Add(Me.lstvWardList)
        Me.Name = "frmPatientWardList"
        Me.Text = "Patient Ward List"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstvWardList As ListView
    Friend WithEvents PatientName As ColumnHeader
    Friend WithEvents MRN As ColumnHeader
    Friend WithEvents Ward As ColumnHeader
End Class
