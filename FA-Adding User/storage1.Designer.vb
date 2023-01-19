<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class storage1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(storage1))
        Me.btnenter = New System.Windows.Forms.PictureBox()
        Me.btnback = New System.Windows.Forms.PictureBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.listbtn = New System.Windows.Forms.Button()
        Me.fillbtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnlocation = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.btnenter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnback, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnenter
        '
        Me.btnenter.BackColor = System.Drawing.Color.Transparent
        Me.btnenter.BackgroundImage = CType(resources.GetObject("btnenter.BackgroundImage"), System.Drawing.Image)
        Me.btnenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnenter.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnenter.Location = New System.Drawing.Point(680, 493)
        Me.btnenter.Name = "btnenter"
        Me.btnenter.Size = New System.Drawing.Size(108, 95)
        Me.btnenter.TabIndex = 65
        Me.btnenter.TabStop = False
        '
        'btnback
        '
        Me.btnback.BackColor = System.Drawing.Color.Transparent
        Me.btnback.BackgroundImage = CType(resources.GetObject("btnback.BackgroundImage"), System.Drawing.Image)
        Me.btnback.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnback.Location = New System.Drawing.Point(2, 498)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(136, 90)
        Me.btnback.TabIndex = 66
        Me.btnback.TabStop = False
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(148, 211)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(575, 132)
        Me.ListBox1.TabIndex = 67
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(121, 83)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(636, 32)
        Me.ComboBox1.TabIndex = 71
        '
        'listbtn
        '
        Me.listbtn.Location = New System.Drawing.Point(53, 247)
        Me.listbtn.Name = "listbtn"
        Me.listbtn.Size = New System.Drawing.Size(89, 56)
        Me.listbtn.TabIndex = 72
        Me.listbtn.Text = ">>>"
        Me.listbtn.UseVisualStyleBackColor = True
        '
        'fillbtn
        '
        Me.fillbtn.Location = New System.Drawing.Point(343, 498)
        Me.fillbtn.Name = "fillbtn"
        Me.fillbtn.Size = New System.Drawing.Size(114, 72)
        Me.fillbtn.TabIndex = 73
        Me.fillbtn.Text = "Fill"
        Me.fillbtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 24)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Location :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 25)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "กรุณาเลือก"
        '
        'btnlocation
        '
        Me.btnlocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.btnlocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnlocation.FormattingEnabled = True
        Me.btnlocation.Location = New System.Drawing.Point(121, 33)
        Me.btnlocation.Name = "btnlocation"
        Me.btnlocation.Size = New System.Drawing.Size(285, 32)
        Me.btnlocation.TabIndex = 78
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(223, 498)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(114, 72)
        Me.Button3.TabIndex = 74
        Me.Button3.Text = "Sort"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(121, 132)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(53, 38)
        Me.TextBox1.TabIndex = 79
        '
        'storage1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnlocation)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.fillbtn)
        Me.Controls.Add(Me.listbtn)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.btnenter)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "storage1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "storage1"
        CType(Me.btnenter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnback, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnenter As Windows.Forms.PictureBox
    Friend WithEvents btnback As Windows.Forms.PictureBox
    Friend WithEvents ListBox1 As Windows.Forms.ListBox
    Friend WithEvents ComboBox1 As Windows.Forms.ComboBox
    Friend WithEvents listbtn As Windows.Forms.Button
    Friend WithEvents fillbtn As Windows.Forms.Button
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents btnlocation As Windows.Forms.ComboBox
    Friend WithEvents Button3 As Windows.Forms.Button
    Friend WithEvents TextBox1 As Windows.Forms.TextBox
End Class
