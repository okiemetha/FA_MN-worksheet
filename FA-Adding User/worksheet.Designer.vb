<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Worksheet
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Worksheet))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnOk = New System.Windows.Forms.PictureBox()
        Me.btnCancle = New System.Windows.Forms.PictureBox()
        Me.ruSure = New System.Windows.Forms.PictureBox()
        Me.detail_Jobtype = New System.Windows.Forms.ComboBox()
        Me.btnnext = New System.Windows.Forms.PictureBox()
        Me.btnback = New System.Windows.Forms.PictureBox()
        Me.troubleshooting = New System.Windows.Forms.ComboBox()
        Me.inspection = New System.Windows.Forms.ComboBox()
        Me.problem = New System.Windows.Forms.ComboBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.btnOk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCancle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ruSure, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnnext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnback, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.btnOk)
        Me.Panel1.Controls.Add(Me.btnCancle)
        Me.Panel1.Controls.Add(Me.ruSure)
        Me.Panel1.Controls.Add(Me.detail_Jobtype)
        Me.Panel1.Controls.Add(Me.btnnext)
        Me.Panel1.Controls.Add(Me.btnback)
        Me.Panel1.Controls.Add(Me.troubleshooting)
        Me.Panel1.Controls.Add(Me.inspection)
        Me.Panel1.Controls.Add(Me.problem)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 600)
        Me.Panel1.TabIndex = 0
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.Transparent
        Me.btnOk.BackgroundImage = CType(resources.GetObject("btnOk.BackgroundImage"), System.Drawing.Image)
        Me.btnOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnOk.Location = New System.Drawing.Point(410, 373)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(137, 89)
        Me.btnOk.TabIndex = 28
        Me.btnOk.TabStop = False
        '
        'btnCancle
        '
        Me.btnCancle.BackColor = System.Drawing.Color.Transparent
        Me.btnCancle.BackgroundImage = CType(resources.GetObject("btnCancle.BackgroundImage"), System.Drawing.Image)
        Me.btnCancle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCancle.Location = New System.Drawing.Point(254, 373)
        Me.btnCancle.Name = "btnCancle"
        Me.btnCancle.Size = New System.Drawing.Size(137, 89)
        Me.btnCancle.TabIndex = 27
        Me.btnCancle.TabStop = False
        '
        'ruSure
        '
        Me.ruSure.BackgroundImage = CType(resources.GetObject("ruSure.BackgroundImage"), System.Drawing.Image)
        Me.ruSure.Location = New System.Drawing.Point(238, 88)
        Me.ruSure.Name = "ruSure"
        Me.ruSure.Size = New System.Drawing.Size(325, 425)
        Me.ruSure.TabIndex = 29
        Me.ruSure.TabStop = False
        '
        'detail_Jobtype
        '
        Me.detail_Jobtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.detail_Jobtype.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.detail_Jobtype.FormattingEnabled = True
        Me.detail_Jobtype.Location = New System.Drawing.Point(259, 79)
        Me.detail_Jobtype.Name = "detail_Jobtype"
        Me.detail_Jobtype.Size = New System.Drawing.Size(410, 33)
        Me.detail_Jobtype.TabIndex = 26
        '
        'btnnext
        '
        Me.btnnext.BackColor = System.Drawing.Color.Transparent
        Me.btnnext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnnext.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnnext.Location = New System.Drawing.Point(702, 259)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(116, 82)
        Me.btnnext.TabIndex = 25
        Me.btnnext.TabStop = False
        '
        'btnback
        '
        Me.btnback.BackColor = System.Drawing.Color.Transparent
        Me.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnback.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnback.Location = New System.Drawing.Point(-17, 259)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(108, 82)
        Me.btnback.TabIndex = 24
        Me.btnback.TabStop = False
        '
        'troubleshooting
        '
        Me.troubleshooting.BackColor = System.Drawing.Color.Pink
        Me.troubleshooting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.troubleshooting.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.troubleshooting.ForeColor = System.Drawing.Color.OrangeRed
        Me.troubleshooting.FormattingEnabled = True
        Me.troubleshooting.Location = New System.Drawing.Point(165, 440)
        Me.troubleshooting.Name = "troubleshooting"
        Me.troubleshooting.Size = New System.Drawing.Size(468, 37)
        Me.troubleshooting.TabIndex = 22
        '
        'inspection
        '
        Me.inspection.BackColor = System.Drawing.Color.LightGreen
        Me.inspection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.inspection.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.inspection.ForeColor = System.Drawing.Color.BlueViolet
        Me.inspection.FormattingEnabled = True
        Me.inspection.Location = New System.Drawing.Point(165, 298)
        Me.inspection.Name = "inspection"
        Me.inspection.Size = New System.Drawing.Size(468, 37)
        Me.inspection.TabIndex = 1
        '
        'problem
        '
        Me.problem.BackColor = System.Drawing.Color.LightSteelBlue
        Me.problem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.problem.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.problem.ForeColor = System.Drawing.SystemColors.Window
        Me.problem.FormattingEnabled = True
        Me.problem.Location = New System.Drawing.Point(165, 183)
        Me.problem.Name = "problem"
        Me.problem.Size = New System.Drawing.Size(468, 37)
        Me.problem.TabIndex = 0
        '
        'Worksheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Worksheet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Worksheet"
        Me.Panel1.ResumeLayout(False)
        CType(Me.btnOk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCancle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ruSure, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnnext, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnback, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents troubleshooting As Windows.Forms.ComboBox
    Friend WithEvents inspection As Windows.Forms.ComboBox
    Friend WithEvents problem As Windows.Forms.ComboBox
    Friend WithEvents btnback As Windows.Forms.PictureBox
    Friend WithEvents btnnext As Windows.Forms.PictureBox
    Friend WithEvents detail_Jobtype As Windows.Forms.ComboBox
    Friend WithEvents btnOk As Windows.Forms.PictureBox
    Friend WithEvents btnCancle As Windows.Forms.PictureBox
    Friend WithEvents ruSure As Windows.Forms.PictureBox
    Friend WithEvents Timer1 As Windows.Forms.Timer
End Class
