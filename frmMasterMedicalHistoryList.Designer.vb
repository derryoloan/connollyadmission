<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMasterMedicalHistoryList
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
        Me.lstvMasterMedicalHistory = New System.Windows.Forms.ListView()
        Me.SurMedID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SurMedHist = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNewMedicalHistory = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstvMasterMedicalHistory
        '
        Me.lstvMasterMedicalHistory.BackColor = System.Drawing.Color.Teal
        Me.lstvMasterMedicalHistory.BackgroundImageTiled = True
        Me.lstvMasterMedicalHistory.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.SurMedID, Me.SurMedHist})
        Me.lstvMasterMedicalHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstvMasterMedicalHistory.ForeColor = System.Drawing.SystemColors.Window
        Me.lstvMasterMedicalHistory.FullRowSelect = True
        Me.lstvMasterMedicalHistory.Location = New System.Drawing.Point(45, 50)
        Me.lstvMasterMedicalHistory.Name = "lstvMasterMedicalHistory"
        Me.lstvMasterMedicalHistory.Size = New System.Drawing.Size(263, 183)
        Me.lstvMasterMedicalHistory.TabIndex = 1
        Me.lstvMasterMedicalHistory.UseCompatibleStateImageBehavior = False
        Me.lstvMasterMedicalHistory.View = System.Windows.Forms.View.Details
        '
        'SurMedID
        '
        Me.SurMedID.Text = "ID"
        Me.SurMedID.Width = 59
        '
        'SurMedHist
        '
        Me.SurMedHist.Text = "Surgical Medical History"
        Me.SurMedHist.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.SurMedHist.Width = 202
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(12, 62)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(182, 22)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add New Medical Surgical  Term"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNewMedicalHistory)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Location = New System.Drawing.Point(78, 271)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add New Term"
        '
        'txtNewMedicalHistory
        '
        Me.txtNewMedicalHistory.Location = New System.Drawing.Point(43, 19)
        Me.txtNewMedicalHistory.Name = "txtNewMedicalHistory"
        Me.txtNewMedicalHistory.Size = New System.Drawing.Size(118, 20)
        Me.txtNewMedicalHistory.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(75, 236)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "If Medical Surgical term is not shown Above"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(127, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Double Click to Select"
        '
        'frmMasterMedicalHistoryList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 401)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lstvMasterMedicalHistory)
        Me.Name = "frmMasterMedicalHistoryList"
        Me.Text = "Medical and Surgical History List"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstvMasterMedicalHistory As ListView
    Friend WithEvents SurMedID As ColumnHeader
    Friend WithEvents SurMedHist As ColumnHeader
    Friend WithEvents btnAdd As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtNewMedicalHistory As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
