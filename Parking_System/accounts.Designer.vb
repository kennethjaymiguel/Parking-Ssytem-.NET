<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class accounts
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(accounts))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblclose = New System.Windows.Forms.Label()
        Me.searchtmr = New System.Windows.Forms.Timer(Me.components)
        Me.accountspnum = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.accountsname = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.accountsrf = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btncreate = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.lblnotregistered = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnupdate = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btndelete = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Minion Pro", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(205, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Accounts Form"
        '
        'lblclose
        '
        Me.lblclose.AutoSize = True
        Me.lblclose.BackColor = System.Drawing.Color.Transparent
        Me.lblclose.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblclose.ForeColor = System.Drawing.Color.White
        Me.lblclose.Location = New System.Drawing.Point(459, 15)
        Me.lblclose.Name = "lblclose"
        Me.lblclose.Size = New System.Drawing.Size(44, 16)
        Me.lblclose.TabIndex = 13
        Me.lblclose.Text = "CLOSE"
        '
        'searchtmr
        '
        Me.searchtmr.Interval = 2000
        '
        'accountspnum
        '
        Me.accountspnum.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.accountspnum.BorderColorFocused = System.Drawing.Color.Blue
        Me.accountspnum.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.accountspnum.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.accountspnum.BorderThickness = 3
        Me.accountspnum.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.accountspnum.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.accountspnum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.accountspnum.isPassword = False
        Me.accountspnum.Location = New System.Drawing.Point(230, 265)
        Me.accountspnum.Margin = New System.Windows.Forms.Padding(4)
        Me.accountspnum.Name = "accountspnum"
        Me.accountspnum.Size = New System.Drawing.Size(215, 35)
        Me.accountspnum.TabIndex = 19
        Me.accountspnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(99, 271)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 20)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Phone No."
        '
        'accountsname
        '
        Me.accountsname.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.accountsname.BorderColorFocused = System.Drawing.Color.Blue
        Me.accountsname.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.accountsname.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.accountsname.BorderThickness = 3
        Me.accountsname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.accountsname.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.accountsname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.accountsname.isPassword = False
        Me.accountsname.Location = New System.Drawing.Point(230, 222)
        Me.accountsname.Margin = New System.Windows.Forms.Padding(4)
        Me.accountsname.Name = "accountsname"
        Me.accountsname.Size = New System.Drawing.Size(215, 35)
        Me.accountsname.TabIndex = 17
        Me.accountsname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(99, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 20)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Name"
        '
        'accountsrf
        '
        Me.accountsrf.BorderColorFocused = System.Drawing.Color.Blue
        Me.accountsrf.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.accountsrf.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.accountsrf.BorderThickness = 3
        Me.accountsrf.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.accountsrf.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.accountsrf.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.accountsrf.isPassword = False
        Me.accountsrf.Location = New System.Drawing.Point(230, 164)
        Me.accountsrf.Margin = New System.Windows.Forms.Padding(4)
        Me.accountsrf.Name = "accountsrf"
        Me.accountsrf.Size = New System.Drawing.Size(215, 35)
        Me.accountsrf.TabIndex = 15
        Me.accountsrf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(99, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 20)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "RFID Card No."
        '
        'btncreate
        '
        Me.btncreate.ActiveBorderThickness = 1
        Me.btncreate.ActiveCornerRadius = 20
        Me.btncreate.ActiveFillColor = System.Drawing.Color.Yellow
        Me.btncreate.ActiveForecolor = System.Drawing.Color.Black
        Me.btncreate.ActiveLineColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btncreate.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btncreate.BackgroundImage = CType(resources.GetObject("btncreate.BackgroundImage"), System.Drawing.Image)
        Me.btncreate.ButtonText = "Create"
        Me.btncreate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncreate.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncreate.ForeColor = System.Drawing.Color.SeaGreen
        Me.btncreate.IdleBorderThickness = 1
        Me.btncreate.IdleCornerRadius = 20
        Me.btncreate.IdleFillColor = System.Drawing.Color.White
        Me.btncreate.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.btncreate.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btncreate.Location = New System.Drawing.Point(363, 305)
        Me.btncreate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btncreate.Name = "btncreate"
        Me.btncreate.Size = New System.Drawing.Size(82, 33)
        Me.btncreate.TabIndex = 21
        Me.btncreate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblnotregistered
        '
        Me.lblnotregistered.AutoSize = True
        Me.lblnotregistered.Font = New System.Drawing.Font("Buxton Sketch", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnotregistered.ForeColor = System.Drawing.Color.DarkRed
        Me.lblnotregistered.Location = New System.Drawing.Point(233, 203)
        Me.lblnotregistered.Name = "lblnotregistered"
        Me.lblnotregistered.Size = New System.Drawing.Size(142, 15)
        Me.lblnotregistered.TabIndex = 22
        Me.lblnotregistered.Text = "*RFID Card Not Yet Registered!"
        Me.lblnotregistered.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.lblclose)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-8, -8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(526, 125)
        Me.Panel1.TabIndex = 23
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(167, 46)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(36, 26)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(145, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(271, 20)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Create/ Edit/ Delete RFID Accounts"
        '
        'btnupdate
        '
        Me.btnupdate.ActiveBorderThickness = 1
        Me.btnupdate.ActiveCornerRadius = 20
        Me.btnupdate.ActiveFillColor = System.Drawing.Color.Yellow
        Me.btnupdate.ActiveForecolor = System.Drawing.Color.Black
        Me.btnupdate.ActiveLineColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnupdate.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnupdate.BackgroundImage = CType(resources.GetObject("btnupdate.BackgroundImage"), System.Drawing.Image)
        Me.btnupdate.ButtonText = "Update"
        Me.btnupdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnupdate.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnupdate.IdleBorderThickness = 1
        Me.btnupdate.IdleCornerRadius = 20
        Me.btnupdate.IdleFillColor = System.Drawing.Color.White
        Me.btnupdate.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.btnupdate.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btnupdate.Location = New System.Drawing.Point(363, 337)
        Me.btnupdate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(82, 33)
        Me.btnupdate.TabIndex = 24
        Me.btnupdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btndelete
        '
        Me.btndelete.ActiveBorderThickness = 1
        Me.btndelete.ActiveCornerRadius = 20
        Me.btndelete.ActiveFillColor = System.Drawing.Color.Yellow
        Me.btndelete.ActiveForecolor = System.Drawing.Color.Black
        Me.btndelete.ActiveLineColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btndelete.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btndelete.BackgroundImage = CType(resources.GetObject("btndelete.BackgroundImage"), System.Drawing.Image)
        Me.btndelete.ButtonText = "Delete"
        Me.btndelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndelete.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.ForeColor = System.Drawing.Color.SeaGreen
        Me.btndelete.IdleBorderThickness = 1
        Me.btndelete.IdleCornerRadius = 20
        Me.btndelete.IdleFillColor = System.Drawing.Color.White
        Me.btndelete.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.btndelete.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btndelete.Location = New System.Drawing.Point(363, 367)
        Me.btndelete.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(82, 33)
        Me.btndelete.TabIndex = 25
        Me.btndelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'accounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(509, 467)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.lblnotregistered)
        Me.Controls.Add(Me.btncreate)
        Me.Controls.Add(Me.accountspnum)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.accountsname)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.accountsrf)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "accounts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblclose As System.Windows.Forms.Label
    Friend WithEvents searchtmr As System.Windows.Forms.Timer
    Friend WithEvents accountspnum As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents accountsname As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents accountsrf As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btncreate As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents lblnotregistered As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnupdate As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btndelete As Bunifu.Framework.UI.BunifuThinButton2
End Class
