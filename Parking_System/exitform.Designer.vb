<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class exitform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(exitform))
        Me.exitbal = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.exitname = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.exitrf = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.exitparkarea = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnaccept = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.searchtimer = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'exitbal
        '
        Me.exitbal.BorderColorFocused = System.Drawing.Color.Blue
        Me.exitbal.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.exitbal.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.exitbal.BorderThickness = 3
        Me.exitbal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.exitbal.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.exitbal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.exitbal.isPassword = False
        Me.exitbal.Location = New System.Drawing.Point(216, 185)
        Me.exitbal.Margin = New System.Windows.Forms.Padding(4)
        Me.exitbal.Name = "exitbal"
        Me.exitbal.Size = New System.Drawing.Size(263, 30)
        Me.exitbal.TabIndex = 15
        Me.exitbal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(91, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Balance"
        '
        'exitname
        '
        Me.exitname.BorderColorFocused = System.Drawing.Color.Blue
        Me.exitname.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.exitname.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.exitname.BorderThickness = 3
        Me.exitname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.exitname.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.exitname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.exitname.isPassword = False
        Me.exitname.Location = New System.Drawing.Point(216, 147)
        Me.exitname.Margin = New System.Windows.Forms.Padding(4)
        Me.exitname.Name = "exitname"
        Me.exitname.Size = New System.Drawing.Size(263, 30)
        Me.exitname.TabIndex = 13
        Me.exitname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(87, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Name"
        '
        'exitrf
        '
        Me.exitrf.BorderColorFocused = System.Drawing.Color.Blue
        Me.exitrf.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.exitrf.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.exitrf.BorderThickness = 3
        Me.exitrf.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.exitrf.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.exitrf.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.exitrf.isPassword = False
        Me.exitrf.Location = New System.Drawing.Point(215, 109)
        Me.exitrf.Margin = New System.Windows.Forms.Padding(4)
        Me.exitrf.Name = "exitrf"
        Me.exitrf.Size = New System.Drawing.Size(263, 30)
        Me.exitrf.TabIndex = 11
        Me.exitrf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(91, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "RFID Card No."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(448, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Close"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Schoolbook", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(13, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 224)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "E" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "X" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "I" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "T" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "L" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "O" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "G"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'exitparkarea
        '
        Me.exitparkarea.BorderColorFocused = System.Drawing.Color.Blue
        Me.exitparkarea.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.exitparkarea.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.exitparkarea.BorderThickness = 3
        Me.exitparkarea.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.exitparkarea.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.exitparkarea.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.exitparkarea.isPassword = False
        Me.exitparkarea.Location = New System.Drawing.Point(216, 220)
        Me.exitparkarea.Margin = New System.Windows.Forms.Padding(4)
        Me.exitparkarea.Name = "exitparkarea"
        Me.exitparkarea.Size = New System.Drawing.Size(263, 30)
        Me.exitparkarea.TabIndex = 17
        Me.exitparkarea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(91, 230)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 20)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Parking Area"
        '
        'btnaccept
        '
        Me.btnaccept.ActiveBorderThickness = 1
        Me.btnaccept.ActiveCornerRadius = 20
        Me.btnaccept.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btnaccept.ActiveForecolor = System.Drawing.Color.White
        Me.btnaccept.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btnaccept.BackColor = System.Drawing.Color.White
        Me.btnaccept.BackgroundImage = CType(resources.GetObject("btnaccept.BackgroundImage"), System.Drawing.Image)
        Me.btnaccept.ButtonText = "Grant"
        Me.btnaccept.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnaccept.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaccept.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnaccept.IdleBorderThickness = 1
        Me.btnaccept.IdleCornerRadius = 20
        Me.btnaccept.IdleFillColor = System.Drawing.Color.White
        Me.btnaccept.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.btnaccept.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btnaccept.Location = New System.Drawing.Point(297, 259)
        Me.btnaccept.Margin = New System.Windows.Forms.Padding(5)
        Me.btnaccept.Name = "btnaccept"
        Me.btnaccept.Size = New System.Drawing.Size(181, 41)
        Me.btnaccept.TabIndex = 18
        Me.btnaccept.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'searchtimer
        '
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(1, -5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(59, 540)
        Me.Panel1.TabIndex = 19
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(9, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 43)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'exitform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(504, 422)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnaccept)
        Me.Controls.Add(Me.exitparkarea)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.exitbal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.exitname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.exitrf)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "exitform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "exitform"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents exitbal As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents exitname As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents exitrf As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents exitparkarea As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnaccept As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents searchtimer As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
