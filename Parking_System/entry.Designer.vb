<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class entry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(entry))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.entryrf = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.entryname = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.entrybal = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.searchtimer = New System.Windows.Forms.Timer(Me.components)
        Me.rbp1 = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnaccept = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.rbp2 = New System.Windows.Forms.RadioButton()
        Me.rbp4 = New System.Windows.Forms.RadioButton()
        Me.rbp3 = New System.Windows.Forms.RadioButton()
        Me.rp4 = New System.Windows.Forms.RadioButton()
        Me.rp3 = New System.Windows.Forms.RadioButton()
        Me.rp2 = New System.Windows.Forms.RadioButton()
        Me.rp1 = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Perpetua", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(28, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Entry Log"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(386, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Close"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(66, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "RFID Card No."
        '
        'entryrf
        '
        Me.entryrf.BorderColorFocused = System.Drawing.Color.Blue
        Me.entryrf.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.entryrf.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.entryrf.BorderThickness = 3
        Me.entryrf.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.entryrf.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.entryrf.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.entryrf.isPassword = False
        Me.entryrf.Location = New System.Drawing.Point(190, 140)
        Me.entryrf.Margin = New System.Windows.Forms.Padding(4)
        Me.entryrf.Name = "entryrf"
        Me.entryrf.Size = New System.Drawing.Size(189, 30)
        Me.entryrf.TabIndex = 3
        Me.entryrf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'entryname
        '
        Me.entryname.BorderColorFocused = System.Drawing.Color.Blue
        Me.entryname.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.entryname.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.entryname.BorderThickness = 3
        Me.entryname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.entryname.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.entryname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.entryname.isPassword = False
        Me.entryname.Location = New System.Drawing.Point(190, 178)
        Me.entryname.Margin = New System.Windows.Forms.Padding(4)
        Me.entryname.Name = "entryname"
        Me.entryname.Size = New System.Drawing.Size(189, 30)
        Me.entryname.TabIndex = 5
        Me.entryname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(66, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 21)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Name"
        '
        'entrybal
        '
        Me.entrybal.BorderColorFocused = System.Drawing.Color.Blue
        Me.entrybal.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.entrybal.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.entrybal.BorderThickness = 3
        Me.entrybal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.entrybal.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.entrybal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.entrybal.isPassword = False
        Me.entrybal.Location = New System.Drawing.Point(190, 216)
        Me.entrybal.Margin = New System.Windows.Forms.Padding(4)
        Me.entrybal.Name = "entrybal"
        Me.entrybal.Size = New System.Drawing.Size(189, 30)
        Me.entrybal.TabIndex = 7
        Me.entrybal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(66, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 21)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Balance"
        '
        'searchtimer
        '
        '
        'rbp1
        '
        Me.rbp1.AutoSize = True
        Me.rbp1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbp1.ForeColor = System.Drawing.Color.White
        Me.rbp1.Location = New System.Drawing.Point(78, 299)
        Me.rbp1.Name = "rbp1"
        Me.rbp1.Size = New System.Drawing.Size(85, 21)
        Me.rbp1.TabIndex = 8
        Me.rbp1.TabStop = True
        Me.rbp1.Text = "Parking 1"
        Me.rbp1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(74, 266)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 21)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Parking Area"
        '
        'btnaccept
        '
        Me.btnaccept.ActiveBorderThickness = 1
        Me.btnaccept.ActiveCornerRadius = 20
        Me.btnaccept.ActiveFillColor = System.Drawing.Color.Yellow
        Me.btnaccept.ActiveForecolor = System.Drawing.Color.Black
        Me.btnaccept.ActiveLineColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnaccept.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnaccept.BackgroundImage = CType(resources.GetObject("btnaccept.BackgroundImage"), System.Drawing.Image)
        Me.btnaccept.ButtonText = "Grant"
        Me.btnaccept.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnaccept.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaccept.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnaccept.IdleBorderThickness = 1
        Me.btnaccept.IdleCornerRadius = 20
        Me.btnaccept.IdleFillColor = System.Drawing.Color.Black
        Me.btnaccept.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.btnaccept.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btnaccept.Location = New System.Drawing.Point(70, 420)
        Me.btnaccept.Margin = New System.Windows.Forms.Padding(5)
        Me.btnaccept.Name = "btnaccept"
        Me.btnaccept.Size = New System.Drawing.Size(296, 42)
        Me.btnaccept.TabIndex = 10
        Me.btnaccept.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rbp2
        '
        Me.rbp2.AutoSize = True
        Me.rbp2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbp2.ForeColor = System.Drawing.Color.White
        Me.rbp2.Location = New System.Drawing.Point(78, 326)
        Me.rbp2.Name = "rbp2"
        Me.rbp2.Size = New System.Drawing.Size(85, 21)
        Me.rbp2.TabIndex = 11
        Me.rbp2.TabStop = True
        Me.rbp2.Text = "Parking 2"
        Me.rbp2.UseVisualStyleBackColor = True
        '
        'rbp4
        '
        Me.rbp4.AutoSize = True
        Me.rbp4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbp4.ForeColor = System.Drawing.Color.White
        Me.rbp4.Location = New System.Drawing.Point(78, 380)
        Me.rbp4.Name = "rbp4"
        Me.rbp4.Size = New System.Drawing.Size(85, 21)
        Me.rbp4.TabIndex = 13
        Me.rbp4.TabStop = True
        Me.rbp4.Text = "Parking 4"
        Me.rbp4.UseVisualStyleBackColor = True
        '
        'rbp3
        '
        Me.rbp3.AutoSize = True
        Me.rbp3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbp3.ForeColor = System.Drawing.Color.White
        Me.rbp3.Location = New System.Drawing.Point(78, 353)
        Me.rbp3.Name = "rbp3"
        Me.rbp3.Size = New System.Drawing.Size(85, 21)
        Me.rbp3.TabIndex = 12
        Me.rbp3.TabStop = True
        Me.rbp3.Text = "Parking 3"
        Me.rbp3.UseVisualStyleBackColor = True
        '
        'rp4
        '
        Me.rp4.AutoSize = True
        Me.rp4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rp4.ForeColor = System.Drawing.Color.White
        Me.rp4.Location = New System.Drawing.Point(249, 380)
        Me.rp4.Name = "rp4"
        Me.rp4.Size = New System.Drawing.Size(130, 21)
        Me.rp4.TabIndex = 17
        Me.rp4.TabStop = True
        Me.rp4.Text = "Rotary Parking 4"
        Me.rp4.UseVisualStyleBackColor = True
        '
        'rp3
        '
        Me.rp3.AutoSize = True
        Me.rp3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rp3.ForeColor = System.Drawing.Color.White
        Me.rp3.Location = New System.Drawing.Point(249, 353)
        Me.rp3.Name = "rp3"
        Me.rp3.Size = New System.Drawing.Size(130, 21)
        Me.rp3.TabIndex = 16
        Me.rp3.TabStop = True
        Me.rp3.Text = "Rotary Parking 3"
        Me.rp3.UseVisualStyleBackColor = True
        '
        'rp2
        '
        Me.rp2.AutoSize = True
        Me.rp2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rp2.ForeColor = System.Drawing.Color.White
        Me.rp2.Location = New System.Drawing.Point(249, 326)
        Me.rp2.Name = "rp2"
        Me.rp2.Size = New System.Drawing.Size(130, 21)
        Me.rp2.TabIndex = 15
        Me.rp2.TabStop = True
        Me.rp2.Text = "Rotary Parking 2"
        Me.rp2.UseVisualStyleBackColor = True
        '
        'rp1
        '
        Me.rp1.AutoSize = True
        Me.rp1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rp1.ForeColor = System.Drawing.Color.White
        Me.rp1.Location = New System.Drawing.Point(249, 299)
        Me.rp1.Name = "rp1"
        Me.rp1.Size = New System.Drawing.Size(130, 21)
        Me.rp1.TabIndex = 14
        Me.rp1.TabStop = True
        Me.rp1.Text = "Rotary Parking 1"
        Me.rp1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-10, 456)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(465, 126)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'entry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(449, 572)
        Me.Controls.Add(Me.rp4)
        Me.Controls.Add(Me.rp3)
        Me.Controls.Add(Me.rp2)
        Me.Controls.Add(Me.rp1)
        Me.Controls.Add(Me.rbp4)
        Me.Controls.Add(Me.rbp3)
        Me.Controls.Add(Me.rbp2)
        Me.Controls.Add(Me.btnaccept)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.rbp1)
        Me.Controls.Add(Me.entrybal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.entryname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.entryrf)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "entry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "entry"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents entryrf As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents entrybal As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents searchtimer As System.Windows.Forms.Timer
    Friend WithEvents rbp1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnaccept As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents rbp2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbp4 As System.Windows.Forms.RadioButton
    Friend WithEvents rbp3 As System.Windows.Forms.RadioButton
    Friend WithEvents rp4 As System.Windows.Forms.RadioButton
    Friend WithEvents rp3 As System.Windows.Forms.RadioButton
    Friend WithEvents rp2 As System.Windows.Forms.RadioButton
    Friend WithEvents rp1 As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents entryname As Bunifu.Framework.UI.BunifuMetroTextbox
End Class
