<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMasterMedicationList
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNewMedication = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lstvMasterMedicationList = New System.Windows.Forms.ListView()
        Me.MasterMedID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MasterMedName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(186, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Double Click to Select"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(134, 258)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "If Medication is not shown Above"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtNewMedication)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Location = New System.Drawing.Point(120, 297)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(227, 110)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add New Medication"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Name"
        '
        'txtNewMedication
        '
        Me.txtNewMedication.Location = New System.Drawing.Point(86, 20)
        Me.txtNewMedication.Name = "txtNewMedication"
        Me.txtNewMedication.Size = New System.Drawing.Size(118, 20)
        Me.txtNewMedication.TabIndex = 3
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(22, 62)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(182, 22)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add New Medication" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lstvMasterMedicationList
        '
        Me.lstvMasterMedicationList.BackColor = System.Drawing.Color.Teal
        Me.lstvMasterMedicationList.BackgroundImageTiled = True
        Me.lstvMasterMedicationList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.MasterMedID, Me.MasterMedName})
        Me.lstvMasterMedicationList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstvMasterMedicationList.ForeColor = System.Drawing.SystemColors.Window
        Me.lstvMasterMedicationList.FullRowSelect = True
        Me.lstvMasterMedicationList.Location = New System.Drawing.Point(103, 58)
        Me.lstvMasterMedicationList.Name = "lstvMasterMedicationList"
        Me.lstvMasterMedicationList.Size = New System.Drawing.Size(267, 183)
        Me.lstvMasterMedicationList.TabIndex = 7
        Me.lstvMasterMedicationList.UseCompatibleStateImageBehavior = False
        Me.lstvMasterMedicationList.View = System.Windows.Forms.View.Details
        '
        'MasterMedID
        '
        Me.MasterMedID.Text = "ID"
        Me.MasterMedID.Width = 59
        '
        'MasterMedName
        '
        Me.MasterMedName.Text = "Medication Name"
        Me.MasterMedName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MasterMedName.Width = 202
        '
        'frmMasterMedicationList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 445)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lstvMasterMedicationList)
        Me.Name = "frmMasterMedicationList"
        Me.Text = "Select Medication"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtNewMedication As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents lstvMasterMedicationList As ListView
    Friend WithEvents MasterMedID As ColumnHeader
    Friend WithEvents MasterMedName As ColumnHeader
    Friend WithEvents Label3 As Label
End Class
