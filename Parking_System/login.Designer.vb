<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginfrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loginfrm))
        Me.txuser = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txpass = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.cmbtype = New System.Windows.Forms.ComboBox()
        Me.txpw = New System.Windows.Forms.CheckBox()
        Me.btnlogin = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txuser
        '
        Me.txuser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txuser.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txuser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txuser.HintForeColor = System.Drawing.Color.Empty
        Me.txuser.HintText = ""
        Me.txuser.isPassword = False
        Me.txuser.LineFocusedColor = System.Drawing.Color.Blue
        Me.txuser.LineIdleColor = System.Drawing.Color.Gray
        Me.txuser.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txuser.LineThickness = 3
        Me.txuser.Location = New System.Drawing.Point(799, 244)
        Me.txuser.Margin = New System.Windows.Forms.Padding(4)
        Me.txuser.Name = "txuser"
        Me.txuser.Size = New System.Drawing.Size(234, 33)
        Me.txuser.TabIndex = 0
        Me.txuser.Text = "Username"
        Me.txuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txpass
        '
        Me.txpass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txpass.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txpass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txpass.HintForeColor = System.Drawing.Color.Empty
        Me.txpass.HintText = ""
        Me.txpass.isPassword = True
        Me.txpass.LineFocusedColor = System.Drawing.Color.Blue
        Me.txpass.LineIdleColor = System.Drawing.Color.Gray
        Me.txpass.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txpass.LineThickness = 3
        Me.txpass.Location = New System.Drawing.Point(799, 285)
        Me.txpass.Margin = New System.Windows.Forms.Padding(4)
        Me.txpass.Name = "txpass"
        Me.txpass.Size = New System.Drawing.Size(234, 33)
        Me.txpass.TabIndex = 1
        Me.txpass.Text = "Password"
        Me.txpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbtype
        '
        Me.cmbtype.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtype.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbtype.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbtype.FormattingEnabled = True
        Me.cmbtype.Items.AddRange(New Object() {"Administrator", "Employee"})
        Me.cmbtype.Location = New System.Drawing.Point(923, 205)
        Me.cmbtype.Name = "cmbtype"
        Me.cmbtype.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbtype.Size = New System.Drawing.Size(110, 24)
        Me.cmbtype.TabIndex = 2
        '
        'txpw
        '
        Me.txpw.AutoSize = True
        Me.txpw.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txpw.Location = New System.Drawing.Point(923, 325)
        Me.txpw.Name = "txpw"
        Me.txpw.Size = New System.Drawing.Size(110, 22)
        Me.txpw.TabIndex = 3
        Me.txpw.Text = "Show Password"
        Me.txpw.UseVisualStyleBackColor = True
        '
        'btnlogin
        '
        Me.btnlogin.ActiveBorderThickness = 1
        Me.btnlogin.ActiveCornerRadius = 20
        Me.btnlogin.ActiveFillColor = System.Drawing.Color.DodgerBlue
        Me.btnlogin.ActiveForecolor = System.Drawing.Color.White
        Me.btnlogin.ActiveLineColor = System.Drawing.Color.Lime
        Me.btnlogin.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnlogin.BackgroundImage = CType(resources.GetObject("btnlogin.BackgroundImage"), System.Drawing.Image)
        Me.btnlogin.ButtonText = "Login"
        Me.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlogin.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnlogin.IdleBorderThickness = 1
        Me.btnlogin.IdleCornerRadius = 20
        Me.btnlogin.IdleFillColor = System.Drawing.Color.White
        Me.btnlogin.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.btnlogin.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btnlogin.Location = New System.Drawing.Point(842, 354)
        Me.btnlogin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(163, 35)
        Me.btnlogin.TabIndex = 4
        Me.btnlogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Prestige Elite Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(810, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 31)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "WELCOME"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Location = New System.Drawing.Point(148, 101)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(432, 304)
        Me.Panel1.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(889, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Sign in to continue"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(799, 200)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(28, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(801, 242)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(28, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(799, 284)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(28, 30)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 11
        Me.PictureBox3.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(781, 550)
        Me.Panel2.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(507, 504)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 17)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "EZEKIEL E. VILLARUBIA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(286, 504)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(186, 17)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "ANGELICA NICOLE A. TAPAR"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(92, 504)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 17)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "KENNETH JAY C. MIGUEL"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lithos Pro Regular", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1024, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 17)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "X"
        '
        'loginfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1054, 545)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.txpw)
        Me.Controls.Add(Me.cmbtype)
        Me.Controls.Add(Me.txpass)
        Me.Controls.Add(Me.txuser)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "loginfrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txuser As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txpass As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents cmbtype As System.Windows.Forms.ComboBox
    Friend WithEvents txpw As System.Windows.Forms.CheckBox
    Friend WithEvents btnlogin As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
