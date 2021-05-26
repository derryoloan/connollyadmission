<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMasterProcedure
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
        Me.lvMasterProcedure = New System.Windows.Forms.ListView()
        Me.ProcedureID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Procedure = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lvMasterProcedure
        '
        Me.lvMasterProcedure.BackColor = System.Drawing.Color.FloralWhite
        Me.lvMasterProcedure.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ProcedureID, Me.Procedure})
        Me.lvMasterProcedure.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvMasterProcedure.FullRowSelect = True
        Me.lvMasterProcedure.GridLines = True
        Me.lvMasterProcedure.Location = New System.Drawing.Point(93, 101)
        Me.lvMasterProcedure.Name = "lvMasterProcedure"
        Me.lvMasterProcedure.Size = New System.Drawing.Size(800, 142)
        Me.lvMasterProcedure.TabIndex = 0
        Me.lvMasterProcedure.UseCompatibleStateImageBehavior = False
        Me.lvMasterProcedure.View = System.Windows.Forms.View.Details
        '
        'ProcedureID
        '
        Me.ProcedureID.Text = "ID"
        Me.ProcedureID.Width = 78
        '
        'Procedure
        '
        Me.Procedure.Text = "Procedure"
        Me.Procedure.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Procedure.Width = 604
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(409, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Double Click to Select"
        '
        'frmMasterProcedure
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(971, 318)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lvMasterProcedure)
        Me.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmMasterProcedure"
        Me.Text = "Procedure List"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lvMasterProcedure As ListView
    Friend WithEvents ProcedureID As ColumnHeader
    Friend WithEvents Procedure As ColumnHeader
    Friend WithEvents Label1 As Label
End Class
