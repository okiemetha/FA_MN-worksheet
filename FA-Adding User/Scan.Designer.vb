<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Scan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Scan))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.logIncode = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.logoutTime4 = New System.Windows.Forms.Label()
        Me.logoutTime3 = New System.Windows.Forms.Label()
        Me.logoutTime2 = New System.Windows.Forms.Label()
        Me.logoutTime1 = New System.Windows.Forms.Label()
        Me.btnclose = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btncancle = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.btnclose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btncancle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'logIncode
        '
        Me.logIncode.Font = New System.Drawing.Font("Perpetua Titling MT", 48.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logIncode.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.logIncode.Location = New System.Drawing.Point(128, 79)
        Me.logIncode.Name = "logIncode"
        Me.logIncode.Size = New System.Drawing.Size(203, 86)
        Me.logIncode.TabIndex = 1
        Me.logIncode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.btncancle)
        Me.Panel1.Controls.Add(Me.logIncode)
        Me.Panel1.Controls.Add(Me.logoutTime4)
        Me.Panel1.Controls.Add(Me.logoutTime3)
        Me.Panel1.Controls.Add(Me.logoutTime2)
        Me.Panel1.Controls.Add(Me.logoutTime1)
        Me.Panel1.Controls.Add(Me.btnclose)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(-2, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(454, 233)
        Me.Panel1.TabIndex = 3
        '
        'logoutTime4
        '
        Me.logoutTime4.AutoSize = True
        Me.logoutTime4.Location = New System.Drawing.Point(165, 10)
        Me.logoutTime4.Name = "logoutTime4"
        Me.logoutTime4.Size = New System.Drawing.Size(0, 13)
        Me.logoutTime4.TabIndex = 8
        Me.logoutTime4.Visible = False
        '
        'logoutTime3
        '
        Me.logoutTime3.AutoSize = True
        Me.logoutTime3.Location = New System.Drawing.Point(125, 10)
        Me.logoutTime3.Name = "logoutTime3"
        Me.logoutTime3.Size = New System.Drawing.Size(0, 13)
        Me.logoutTime3.TabIndex = 7
        Me.logoutTime3.Visible = False
        '
        'logoutTime2
        '
        Me.logoutTime2.AutoSize = True
        Me.logoutTime2.Location = New System.Drawing.Point(75, 10)
        Me.logoutTime2.Name = "logoutTime2"
        Me.logoutTime2.Size = New System.Drawing.Size(0, 13)
        Me.logoutTime2.TabIndex = 6
        Me.logoutTime2.Visible = False
        '
        'logoutTime1
        '
        Me.logoutTime1.AutoSize = True
        Me.logoutTime1.Location = New System.Drawing.Point(24, 10)
        Me.logoutTime1.Name = "logoutTime1"
        Me.logoutTime1.Size = New System.Drawing.Size(0, 13)
        Me.logoutTime1.TabIndex = 5
        Me.logoutTime1.Visible = False
        '
        'btnclose
        '
        Me.btnclose.BackgroundImage = CType(resources.GetObject("btnclose.BackgroundImage"), System.Drawing.Image)
        Me.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnclose.Location = New System.Drawing.Point(185, 176)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(81, 39)
        Me.btnclose.TabIndex = 4
        Me.btnclose.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FA_Adding_User.My.Resources.Resources.login1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(450, 278)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'btncancle
        '
        Me.btncancle.BackgroundImage = CType(resources.GetObject("btncancle.BackgroundImage"), System.Drawing.Image)
        Me.btncancle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btncancle.Location = New System.Drawing.Point(168, 168)
        Me.btncancle.Name = "btncancle"
        Me.btncancle.Size = New System.Drawing.Size(114, 62)
        Me.btncancle.TabIndex = 9
        Me.btncancle.TabStop = False
        '
        'Scan
        '
        Me.ClientSize = New System.Drawing.Size(446, 231)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Scan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btnclose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btncancle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnexit As Windows.Forms.Button
    Friend WithEvents TextBox1 As Windows.Forms.TextBox
    Friend WithEvents Timer1 As Windows.Forms.Timer

    Private Sub Scan_Designer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Friend WithEvents logIncode As Windows.Forms.TextBox
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents PictureBox1 As Windows.Forms.PictureBox
    Friend WithEvents btnclose As Windows.Forms.PictureBox
    Friend WithEvents logoutTime1 As Windows.Forms.Label
    Friend WithEvents logoutTime2 As Windows.Forms.Label
    Friend WithEvents logoutTime4 As Windows.Forms.Label
    Friend WithEvents logoutTime3 As Windows.Forms.Label
    Friend WithEvents btncancle As Windows.Forms.PictureBox
End Class
