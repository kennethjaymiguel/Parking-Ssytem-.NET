<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminform))
        Me.lblclose = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnaccounts = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnsummary = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btncp = New Bunifu.Framework.UI.BunifuTileButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblclose
        '
        Me.lblclose.AutoSize = True
        Me.lblclose.BackColor = System.Drawing.Color.DimGray
        Me.lblclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblclose.Font = New System.Drawing.Font("High Tower Text", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblclose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblclose.Location = New System.Drawing.Point(923, 9)
        Me.lblclose.Name = "lblclose"
        Me.lblclose.Size = New System.Drawing.Size(82, 19)
        Me.lblclose.TabIndex = 0
        Me.lblclose.Text = "LOGOUT"
        Me.lblclose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(903, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(19, 27)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Font = New System.Drawing.Font("Hyper heliX", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(281, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(445, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Administrator Dashboard"
        '
        'btnaccounts
        '
        Me.btnaccounts.BackColor = System.Drawing.Color.SeaGreen
        Me.btnaccounts.color = System.Drawing.Color.SeaGreen
        Me.btnaccounts.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.btnaccounts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnaccounts.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaccounts.ForeColor = System.Drawing.Color.White
        Me.btnaccounts.Image = CType(resources.GetObject("btnaccounts.Image"), System.Drawing.Image)
        Me.btnaccounts.ImagePosition = 14
        Me.btnaccounts.ImageZoom = 50
        Me.btnaccounts.LabelPosition = 29
        Me.btnaccounts.LabelText = "Accounts"
        Me.btnaccounts.Location = New System.Drawing.Point(211, 168)
        Me.btnaccounts.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnaccounts.Name = "btnaccounts"
        Me.btnaccounts.Size = New System.Drawing.Size(83, 80)
        Me.btnaccounts.TabIndex = 24
        '
        'btnsummary
        '
        Me.btnsummary.BackColor = System.Drawing.Color.SeaGreen
        Me.btnsummary.color = System.Drawing.Color.SeaGreen
        Me.btnsummary.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.btnsummary.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsummary.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsummary.ForeColor = System.Drawing.Color.White
        Me.btnsummary.Image = CType(resources.GetObject("btnsummary.Image"), System.Drawing.Image)
        Me.btnsummary.ImagePosition = 14
        Me.btnsummary.ImageZoom = 50
        Me.btnsummary.LabelPosition = 29
        Me.btnsummary.LabelText = "Summary"
        Me.btnsummary.Location = New System.Drawing.Point(433, 168)
        Me.btnsummary.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnsummary.Name = "btnsummary"
        Me.btnsummary.Size = New System.Drawing.Size(83, 80)
        Me.btnsummary.TabIndex = 23
        '
        'btncp
        '
        Me.btncp.BackColor = System.Drawing.Color.SeaGreen
        Me.btncp.color = System.Drawing.Color.SeaGreen
        Me.btncp.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.btncp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncp.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncp.ForeColor = System.Drawing.Color.White
        Me.btncp.Image = CType(resources.GetObject("btncp.Image"), System.Drawing.Image)
        Me.btncp.ImagePosition = 14
        Me.btncp.ImageZoom = 50
        Me.btncp.LabelPosition = 29
        Me.btncp.LabelText = "Control"
        Me.btncp.Location = New System.Drawing.Point(324, 168)
        Me.btncp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btncp.Name = "btncp"
        Me.btncp.Size = New System.Drawing.Size(83, 80)
        Me.btncp.TabIndex = 22
        '
        'adminform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1017, 521)
        Me.Controls.Add(Me.btnaccounts)
        Me.Controls.Add(Me.btnsummary)
        Me.Controls.Add(Me.btncp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblclose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "adminform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblclose As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnaccounts As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnsummary As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btncp As Bunifu.Framework.UI.BunifuTileButton
End Class
