<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reload
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(reload))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.entrybal = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.entryname = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.entryrf = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.entryrel = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.stimer = New System.Windows.Forms.Timer(Me.components)
        Me.btnsave = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnreload = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 24)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Reload Dashboard"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(392, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 17)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Close"
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
        Me.entrybal.Location = New System.Drawing.Point(182, 206)
        Me.entrybal.Margin = New System.Windows.Forms.Padding(4)
        Me.entrybal.Name = "entrybal"
        Me.entrybal.Size = New System.Drawing.Size(189, 30)
        Me.entrybal.TabIndex = 19
        Me.entrybal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(58, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 21)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Balance"
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
        Me.entryname.Location = New System.Drawing.Point(182, 168)
        Me.entryname.Margin = New System.Windows.Forms.Padding(4)
        Me.entryname.Name = "entryname"
        Me.entryname.Size = New System.Drawing.Size(189, 30)
        Me.entryname.TabIndex = 17
        Me.entryname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(58, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 21)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Name"
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
        Me.entryrf.Location = New System.Drawing.Point(182, 130)
        Me.entryrf.Margin = New System.Windows.Forms.Padding(4)
        Me.entryrf.Name = "entryrf"
        Me.entryrf.Size = New System.Drawing.Size(189, 30)
        Me.entryrf.TabIndex = 15
        Me.entryrf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(58, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 21)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "RFID Card No."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(58, 251)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 21)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Reload Amount"
        '
        'entryrel
        '
        Me.entryrel.BorderColorFocused = System.Drawing.Color.Blue
        Me.entryrel.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.entryrel.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.entryrel.BorderThickness = 3
        Me.entryrel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.entryrel.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.entryrel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.entryrel.isPassword = False
        Me.entryrel.Location = New System.Drawing.Point(182, 276)
        Me.entryrel.Margin = New System.Windows.Forms.Padding(4)
        Me.entryrel.Name = "entryrel"
        Me.entryrel.Size = New System.Drawing.Size(189, 30)
        Me.entryrel.TabIndex = 21
        Me.entryrel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'stimer
        '
        '
        'btnsave
        '
        Me.btnsave.ActiveBorderThickness = 1
        Me.btnsave.ActiveCornerRadius = 20
        Me.btnsave.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btnsave.ActiveForecolor = System.Drawing.Color.White
        Me.btnsave.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btnsave.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnsave.BackgroundImage = CType(resources.GetObject("btnsave.BackgroundImage"), System.Drawing.Image)
        Me.btnsave.ButtonText = "Save"
        Me.btnsave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsave.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnsave.IdleBorderThickness = 1
        Me.btnsave.IdleCornerRadius = 20
        Me.btnsave.IdleFillColor = System.Drawing.Color.White
        Me.btnsave.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.btnsave.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btnsave.Location = New System.Drawing.Point(248, 341)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(5)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(123, 41)
        Me.btnsave.TabIndex = 22
        Me.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnreload
        '
        Me.btnreload.ActiveBorderThickness = 1
        Me.btnreload.ActiveCornerRadius = 20
        Me.btnreload.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btnreload.ActiveForecolor = System.Drawing.Color.White
        Me.btnreload.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btnreload.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnreload.BackgroundImage = CType(resources.GetObject("btnreload.BackgroundImage"), System.Drawing.Image)
        Me.btnreload.ButtonText = "Reload"
        Me.btnreload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnreload.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreload.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnreload.IdleBorderThickness = 1
        Me.btnreload.IdleCornerRadius = 20
        Me.btnreload.IdleFillColor = System.Drawing.Color.White
        Me.btnreload.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.btnreload.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btnreload.Location = New System.Drawing.Point(115, 341)
        Me.btnreload.Margin = New System.Windows.Forms.Padding(5)
        Me.btnreload.Name = "btnreload"
        Me.btnreload.Size = New System.Drawing.Size(123, 41)
        Me.btnreload.TabIndex = 23
        Me.btnreload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'reload
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(448, 500)
        Me.Controls.Add(Me.btnreload)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.entryrel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.entrybal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.entryname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.entryrf)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "reload"
        Me.Text = "reload"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents entrybal As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents entryname As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents entryrf As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents entryrel As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents stimer As System.Windows.Forms.Timer
    Friend WithEvents btnsave As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnreload As Bunifu.Framework.UI.BunifuThinButton2
End Class
