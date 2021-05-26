<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMasterDiagnosisList
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstvMasterDiagnosisList = New System.Windows.Forms.ListView()
        Me.DiagnosisID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Diagnosis = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtNewDiagnosis = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(141, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Double Click to Select"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(113, 249)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "If Diagnosis is not shown Above"
        '
        'lstvMasterDiagnosisList
        '
        Me.lstvMasterDiagnosisList.BackColor = System.Drawing.Color.Teal
        Me.lstvMasterDiagnosisList.BackgroundImageTiled = True
        Me.lstvMasterDiagnosisList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.DiagnosisID, Me.Diagnosis})
        Me.lstvMasterDiagnosisList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstvMasterDiagnosisList.ForeColor = System.Drawing.SystemColors.Window
        Me.lstvMasterDiagnosisList.FullRowSelect = True
        Me.lstvMasterDiagnosisList.Location = New System.Drawing.Point(80, 49)
        Me.lstvMasterDiagnosisList.Name = "lstvMasterDiagnosisList"
        Me.lstvMasterDiagnosisList.Size = New System.Drawing.Size(248, 183)
        Me.lstvMasterDiagnosisList.TabIndex = 7
        Me.lstvMasterDiagnosisList.UseCompatibleStateImageBehavior = False
        Me.lstvMasterDiagnosisList.View = System.Windows.Forms.View.Details
        '
        'DiagnosisID
        '
        Me.DiagnosisID.Text = "ID"
        Me.DiagnosisID.Width = 59
        '
        'Diagnosis
        '
        Me.Diagnosis.Text = "Diagnosis"
        Me.Diagnosis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Diagnosis.Width = 202
        '
        'txtNewDiagnosis
        '
        Me.txtNewDiagnosis.Location = New System.Drawing.Point(43, 19)
        Me.txtNewDiagnosis.Name = "txtNewDiagnosis"
        Me.txtNewDiagnosis.Size = New System.Drawing.Size(118, 20)
        Me.txtNewDiagnosis.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNewDiagnosis)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Location = New System.Drawing.Point(92, 279)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add New Term"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(12, 62)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(182, 22)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add New Diagnosis "
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'frmMasterDiagnosisList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstvMasterDiagnosisList)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMasterDiagnosisList"
        Me.Text = "Diagnosis List"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lstvMasterDiagnosisList As ListView
    Friend WithEvents DiagnosisID As ColumnHeader
    Friend WithEvents Diagnosis As ColumnHeader
    Friend WithEvents txtNewDiagnosis As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnAdd As Button
End Class
