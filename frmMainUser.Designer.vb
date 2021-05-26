<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainUser))
        Me.picActivePatients = New System.Windows.Forms.PictureBox()
        Me.picSearch = New System.Windows.Forms.PictureBox()
        Me.btnDeveloper = New System.Windows.Forms.Button()
        Me.picClinicPatients = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.picActivePatients, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picClinicPatients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picActivePatients
        '
        Me.picActivePatients.BackColor = System.Drawing.Color.White
        Me.picActivePatients.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picActivePatients.Image = Global.ConnollyAdmissionApp.My.Resources.Resources._1487456940_8
        Me.picActivePatients.Location = New System.Drawing.Point(23, 61)
        Me.picActivePatients.Name = "picActivePatients"
        Me.picActivePatients.Size = New System.Drawing.Size(367, 500)
        Me.picActivePatients.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picActivePatients.TabIndex = 1
        Me.picActivePatients.TabStop = False
        '
        'picSearch
        '
        Me.picSearch.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picSearch.BackColor = System.Drawing.Color.White
        Me.picSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picSearch.Image = CType(resources.GetObject("picSearch.Image"), System.Drawing.Image)
        Me.picSearch.Location = New System.Drawing.Point(852, 61)
        Me.picSearch.Name = "picSearch"
        Me.picSearch.Size = New System.Drawing.Size(378, 500)
        Me.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picSearch.TabIndex = 0
        Me.picSearch.TabStop = False
        '
        'btnDeveloper
        '
        Me.btnDeveloper.Location = New System.Drawing.Point(1118, 625)
        Me.btnDeveloper.Name = "btnDeveloper"
        Me.btnDeveloper.Size = New System.Drawing.Size(112, 23)
        Me.btnDeveloper.TabIndex = 2
        Me.btnDeveloper.Text = "Developer Menu"
        Me.btnDeveloper.UseVisualStyleBackColor = True
        '
        'picClinicPatients
        '
        Me.picClinicPatients.BackColor = System.Drawing.Color.White
        Me.picClinicPatients.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picClinicPatients.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picClinicPatients.Image = CType(resources.GetObject("picClinicPatients.Image"), System.Drawing.Image)
        Me.picClinicPatients.Location = New System.Drawing.Point(435, 230)
        Me.picClinicPatients.Name = "picClinicPatients"
        Me.picClinicPatients.Size = New System.Drawing.Size(382, 392)
        Me.picClinicPatients.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picClinicPatients.TabIndex = 3
        Me.picClinicPatients.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(590, 334)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = " Clinic Patients"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(174, 217)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "In-Patients"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(1009, 174)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(72, 14)
        Me.TextBox1.TabIndex = 6
        Me.TextBox1.Text = "All Patients"
        '
        'frmMainUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1252, 665)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picClinicPatients)
        Me.Controls.Add(Me.btnDeveloper)
        Me.Controls.Add(Me.picActivePatients)
        Me.Controls.Add(Me.picSearch)
        Me.Name = "frmMainUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Menu"
        CType(Me.picActivePatients, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picClinicPatients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picSearch As PictureBox
    Friend WithEvents picActivePatients As PictureBox
    Friend WithEvents btnDeveloper As Button
    Friend WithEvents picClinicPatients As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
