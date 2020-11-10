<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class employeedashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(employeedashboard))
        Me.lbltime = New System.Windows.Forms.Label()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.dttimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblclose = New System.Windows.Forms.Label()
        Me.statpanel = New System.Windows.Forms.Panel()
        Me.r4gb = New System.Windows.Forms.GroupBox()
        Me.r4name = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.r4rf = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.r3gb = New System.Windows.Forms.GroupBox()
        Me.r3name = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.r3rf = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.p4gb = New System.Windows.Forms.GroupBox()
        Me.p4name = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.p4rf = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.r2name = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.r2gb = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.p3gb = New System.Windows.Forms.GroupBox()
        Me.p3name = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.p3rf = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.r1gb = New System.Windows.Forms.GroupBox()
        Me.r1name = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.r1rf = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.p2gb = New System.Windows.Forms.GroupBox()
        Me.p2name = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.p2rf = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.p1gb = New System.Windows.Forms.GroupBox()
        Me.p1name = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.p1rf = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.entryrf = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.showentry = New System.Windows.Forms.Timer(Me.components)
        Me.exitrf = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.showexit = New System.Windows.Forms.Timer(Me.components)
        Me.btnreload = New Bunifu.Framework.UI.BunifuTileButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btncp = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnsummary = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnaccounts = New Bunifu.Framework.UI.BunifuTileButton()
        Me.statpanel.SuspendLayout()
        Me.r4gb.SuspendLayout()
        Me.r3gb.SuspendLayout()
        Me.p4gb.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.p3gb.SuspendLayout()
        Me.r1gb.SuspendLayout()
        Me.p2gb.SuspendLayout()
        Me.p1gb.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.ForeColor = System.Drawing.Color.White
        Me.lbltime.Location = New System.Drawing.Point(750, 9)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(33, 13)
        Me.lbltime.TabIndex = 9
        Me.lbltime.Text = "TIME"
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.ForeColor = System.Drawing.Color.White
        Me.lbldate.Location = New System.Drawing.Point(822, 9)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(36, 13)
        Me.lbldate.TabIndex = 10
        Me.lbldate.Text = "DATE"
        '
        'dttimer
        '
        Me.dttimer.Interval = 2000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(28, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 24)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "EMPLOYEE DASHBOARD"
        '
        'lblclose
        '
        Me.lblclose.AutoSize = True
        Me.lblclose.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblclose.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblclose.ForeColor = System.Drawing.Color.White
        Me.lblclose.Location = New System.Drawing.Point(907, 7)
        Me.lblclose.Name = "lblclose"
        Me.lblclose.Size = New System.Drawing.Size(57, 17)
        Me.lblclose.TabIndex = 12
        Me.lblclose.Text = "LOGOUT"
        '
        'statpanel
        '
        Me.statpanel.Controls.Add(Me.r4gb)
        Me.statpanel.Controls.Add(Me.r3gb)
        Me.statpanel.Controls.Add(Me.p4gb)
        Me.statpanel.Controls.Add(Me.GroupBox3)
        Me.statpanel.Controls.Add(Me.p3gb)
        Me.statpanel.Controls.Add(Me.r1gb)
        Me.statpanel.Controls.Add(Me.p2gb)
        Me.statpanel.Controls.Add(Me.p1gb)
        Me.statpanel.Location = New System.Drawing.Point(233, 111)
        Me.statpanel.Name = "statpanel"
        Me.statpanel.Size = New System.Drawing.Size(550, 266)
        Me.statpanel.TabIndex = 13
        '
        'r4gb
        '
        Me.r4gb.BackColor = System.Drawing.Color.SeaGreen
        Me.r4gb.BackgroundImage = CType(resources.GetObject("r4gb.BackgroundImage"), System.Drawing.Image)
        Me.r4gb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.r4gb.Controls.Add(Me.r4name)
        Me.r4gb.Controls.Add(Me.Label12)
        Me.r4gb.Controls.Add(Me.r4rf)
        Me.r4gb.Controls.Add(Me.Label15)
        Me.r4gb.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r4gb.ForeColor = System.Drawing.Color.White
        Me.r4gb.Location = New System.Drawing.Point(412, 143)
        Me.r4gb.Name = "r4gb"
        Me.r4gb.Size = New System.Drawing.Size(127, 110)
        Me.r4gb.TabIndex = 10
        Me.r4gb.TabStop = False
        Me.r4gb.Text = "Rotary Parking 4"
        '
        'r4name
        '
        Me.r4name.AutoSize = True
        Me.r4name.BackColor = System.Drawing.Color.Transparent
        Me.r4name.Location = New System.Drawing.Point(28, 69)
        Me.r4name.Name = "r4name"
        Me.r4name.Size = New System.Drawing.Size(41, 16)
        Me.r4name.TabIndex = 3
        Me.r4name.Text = "Name"
        Me.r4name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(6, 53)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 16)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Name"
        '
        'r4rf
        '
        Me.r4rf.AutoSize = True
        Me.r4rf.BackColor = System.Drawing.Color.Transparent
        Me.r4rf.Location = New System.Drawing.Point(28, 37)
        Me.r4rf.Name = "r4rf"
        Me.r4rf.Size = New System.Drawing.Size(83, 16)
        Me.r4rf.TabIndex = 1
        Me.r4rf.Text = "RFID Card No."
        Me.r4rf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(6, 21)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(83, 16)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "RFID Card No."
        '
        'r3gb
        '
        Me.r3gb.BackColor = System.Drawing.Color.SeaGreen
        Me.r3gb.BackgroundImage = CType(resources.GetObject("r3gb.BackgroundImage"), System.Drawing.Image)
        Me.r3gb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.r3gb.Controls.Add(Me.r3name)
        Me.r3gb.Controls.Add(Me.Label17)
        Me.r3gb.Controls.Add(Me.r3rf)
        Me.r3gb.Controls.Add(Me.Label19)
        Me.r3gb.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r3gb.ForeColor = System.Drawing.Color.White
        Me.r3gb.Location = New System.Drawing.Point(279, 143)
        Me.r3gb.Name = "r3gb"
        Me.r3gb.Size = New System.Drawing.Size(127, 110)
        Me.r3gb.TabIndex = 9
        Me.r3gb.TabStop = False
        Me.r3gb.Text = "Rotary Parking 3"
        '
        'r3name
        '
        Me.r3name.AutoSize = True
        Me.r3name.BackColor = System.Drawing.Color.Transparent
        Me.r3name.Location = New System.Drawing.Point(28, 69)
        Me.r3name.Name = "r3name"
        Me.r3name.Size = New System.Drawing.Size(41, 16)
        Me.r3name.TabIndex = 3
        Me.r3name.Text = "Name"
        Me.r3name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Location = New System.Drawing.Point(6, 53)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(41, 16)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "Name"
        '
        'r3rf
        '
        Me.r3rf.AutoSize = True
        Me.r3rf.BackColor = System.Drawing.Color.Transparent
        Me.r3rf.Location = New System.Drawing.Point(28, 37)
        Me.r3rf.Name = "r3rf"
        Me.r3rf.Size = New System.Drawing.Size(83, 16)
        Me.r3rf.TabIndex = 1
        Me.r3rf.Text = "RFID Card No."
        Me.r3rf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Location = New System.Drawing.Point(6, 21)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(83, 16)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "RFID Card No."
        '
        'p4gb
        '
        Me.p4gb.BackColor = System.Drawing.Color.SeaGreen
        Me.p4gb.BackgroundImage = CType(resources.GetObject("p4gb.BackgroundImage"), System.Drawing.Image)
        Me.p4gb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.p4gb.Controls.Add(Me.p4name)
        Me.p4gb.Controls.Add(Me.Label10)
        Me.p4gb.Controls.Add(Me.p4rf)
        Me.p4gb.Controls.Add(Me.Label13)
        Me.p4gb.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p4gb.ForeColor = System.Drawing.Color.White
        Me.p4gb.Location = New System.Drawing.Point(412, 7)
        Me.p4gb.Name = "p4gb"
        Me.p4gb.Size = New System.Drawing.Size(127, 110)
        Me.p4gb.TabIndex = 6
        Me.p4gb.TabStop = False
        Me.p4gb.Text = "Parking 4"
        '
        'p4name
        '
        Me.p4name.AutoSize = True
        Me.p4name.BackColor = System.Drawing.Color.Transparent
        Me.p4name.Location = New System.Drawing.Point(28, 69)
        Me.p4name.Name = "p4name"
        Me.p4name.Size = New System.Drawing.Size(41, 16)
        Me.p4name.TabIndex = 3
        Me.p4name.Text = "Name"
        Me.p4name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(6, 53)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 16)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Name"
        '
        'p4rf
        '
        Me.p4rf.AutoSize = True
        Me.p4rf.BackColor = System.Drawing.Color.Transparent
        Me.p4rf.Location = New System.Drawing.Point(28, 37)
        Me.p4rf.Name = "p4rf"
        Me.p4rf.Size = New System.Drawing.Size(83, 16)
        Me.p4rf.TabIndex = 1
        Me.p4rf.Text = "RFID Card No."
        Me.p4rf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(6, 21)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 16)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "RFID Card No."
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.SeaGreen
        Me.GroupBox3.BackgroundImage = CType(resources.GetObject("GroupBox3.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.GroupBox3.Controls.Add(Me.r2name)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.r2gb)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(146, 143)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(127, 110)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Rotary Parking 2"
        '
        'r2name
        '
        Me.r2name.AutoSize = True
        Me.r2name.BackColor = System.Drawing.Color.Transparent
        Me.r2name.Location = New System.Drawing.Point(28, 69)
        Me.r2name.Name = "r2name"
        Me.r2name.Size = New System.Drawing.Size(41, 16)
        Me.r2name.TabIndex = 3
        Me.r2name.Text = "Name"
        Me.r2name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Location = New System.Drawing.Point(6, 53)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(41, 16)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "Name"
        '
        'r2gb
        '
        Me.r2gb.AutoSize = True
        Me.r2gb.BackColor = System.Drawing.Color.Transparent
        Me.r2gb.Location = New System.Drawing.Point(28, 37)
        Me.r2gb.Name = "r2gb"
        Me.r2gb.Size = New System.Drawing.Size(83, 16)
        Me.r2gb.TabIndex = 1
        Me.r2gb.Text = "RFID Card No."
        Me.r2gb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Location = New System.Drawing.Point(6, 21)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(83, 16)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "RFID Card No."
        '
        'p3gb
        '
        Me.p3gb.BackColor = System.Drawing.Color.SeaGreen
        Me.p3gb.BackgroundImage = CType(resources.GetObject("p3gb.BackgroundImage"), System.Drawing.Image)
        Me.p3gb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.p3gb.Controls.Add(Me.p3name)
        Me.p3gb.Controls.Add(Me.Label9)
        Me.p3gb.Controls.Add(Me.p3rf)
        Me.p3gb.Controls.Add(Me.Label11)
        Me.p3gb.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p3gb.ForeColor = System.Drawing.Color.White
        Me.p3gb.Location = New System.Drawing.Point(279, 7)
        Me.p3gb.Name = "p3gb"
        Me.p3gb.Size = New System.Drawing.Size(127, 110)
        Me.p3gb.TabIndex = 5
        Me.p3gb.TabStop = False
        Me.p3gb.Text = "Parking 3"
        '
        'p3name
        '
        Me.p3name.AutoSize = True
        Me.p3name.BackColor = System.Drawing.Color.Transparent
        Me.p3name.Location = New System.Drawing.Point(28, 69)
        Me.p3name.Name = "p3name"
        Me.p3name.Size = New System.Drawing.Size(41, 16)
        Me.p3name.TabIndex = 3
        Me.p3name.Text = "Name"
        Me.p3name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(6, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 16)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Name"
        '
        'p3rf
        '
        Me.p3rf.AutoSize = True
        Me.p3rf.BackColor = System.Drawing.Color.Transparent
        Me.p3rf.Location = New System.Drawing.Point(28, 37)
        Me.p3rf.Name = "p3rf"
        Me.p3rf.Size = New System.Drawing.Size(83, 16)
        Me.p3rf.TabIndex = 1
        Me.p3rf.Text = "RFID Card No."
        Me.p3rf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(6, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 16)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "RFID Card No."
        '
        'r1gb
        '
        Me.r1gb.BackColor = System.Drawing.Color.SeaGreen
        Me.r1gb.BackgroundImage = CType(resources.GetObject("r1gb.BackgroundImage"), System.Drawing.Image)
        Me.r1gb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.r1gb.Controls.Add(Me.r1name)
        Me.r1gb.Controls.Add(Me.Label25)
        Me.r1gb.Controls.Add(Me.r1rf)
        Me.r1gb.Controls.Add(Me.Label27)
        Me.r1gb.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r1gb.ForeColor = System.Drawing.Color.White
        Me.r1gb.Location = New System.Drawing.Point(13, 143)
        Me.r1gb.Name = "r1gb"
        Me.r1gb.Size = New System.Drawing.Size(127, 110)
        Me.r1gb.TabIndex = 7
        Me.r1gb.TabStop = False
        Me.r1gb.Text = "Rotary Parking 1"
        '
        'r1name
        '
        Me.r1name.AutoSize = True
        Me.r1name.BackColor = System.Drawing.Color.Transparent
        Me.r1name.Location = New System.Drawing.Point(28, 69)
        Me.r1name.Name = "r1name"
        Me.r1name.Size = New System.Drawing.Size(41, 16)
        Me.r1name.TabIndex = 3
        Me.r1name.Text = "Name"
        Me.r1name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Location = New System.Drawing.Point(6, 53)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(41, 16)
        Me.Label25.TabIndex = 2
        Me.Label25.Text = "Name"
        '
        'r1rf
        '
        Me.r1rf.AutoSize = True
        Me.r1rf.BackColor = System.Drawing.Color.Transparent
        Me.r1rf.Location = New System.Drawing.Point(28, 37)
        Me.r1rf.Name = "r1rf"
        Me.r1rf.Size = New System.Drawing.Size(83, 16)
        Me.r1rf.TabIndex = 1
        Me.r1rf.Text = "RFID Card No."
        Me.r1rf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Location = New System.Drawing.Point(6, 21)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(83, 16)
        Me.Label27.TabIndex = 0
        Me.Label27.Text = "RFID Card No."
        '
        'p2gb
        '
        Me.p2gb.BackColor = System.Drawing.Color.SeaGreen
        Me.p2gb.BackgroundImage = CType(resources.GetObject("p2gb.BackgroundImage"), System.Drawing.Image)
        Me.p2gb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.p2gb.Controls.Add(Me.p2name)
        Me.p2gb.Controls.Add(Me.Label6)
        Me.p2gb.Controls.Add(Me.p2rf)
        Me.p2gb.Controls.Add(Me.Label8)
        Me.p2gb.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p2gb.ForeColor = System.Drawing.Color.White
        Me.p2gb.Location = New System.Drawing.Point(146, 7)
        Me.p2gb.Name = "p2gb"
        Me.p2gb.Size = New System.Drawing.Size(127, 110)
        Me.p2gb.TabIndex = 4
        Me.p2gb.TabStop = False
        Me.p2gb.Text = "Parking 2"
        '
        'p2name
        '
        Me.p2name.AutoSize = True
        Me.p2name.BackColor = System.Drawing.Color.Transparent
        Me.p2name.Location = New System.Drawing.Point(28, 69)
        Me.p2name.Name = "p2name"
        Me.p2name.Size = New System.Drawing.Size(41, 16)
        Me.p2name.TabIndex = 3
        Me.p2name.Text = "Name"
        Me.p2name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(6, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 16)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Name"
        '
        'p2rf
        '
        Me.p2rf.AutoSize = True
        Me.p2rf.BackColor = System.Drawing.Color.Transparent
        Me.p2rf.Location = New System.Drawing.Point(28, 37)
        Me.p2rf.Name = "p2rf"
        Me.p2rf.Size = New System.Drawing.Size(83, 16)
        Me.p2rf.TabIndex = 1
        Me.p2rf.Text = "RFID Card No."
        Me.p2rf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(6, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "RFID Card No."
        '
        'p1gb
        '
        Me.p1gb.BackColor = System.Drawing.Color.SeaGreen
        Me.p1gb.BackgroundImage = CType(resources.GetObject("p1gb.BackgroundImage"), System.Drawing.Image)
        Me.p1gb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.p1gb.Controls.Add(Me.p1name)
        Me.p1gb.Controls.Add(Me.Label4)
        Me.p1gb.Controls.Add(Me.p1rf)
        Me.p1gb.Controls.Add(Me.Label3)
        Me.p1gb.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p1gb.ForeColor = System.Drawing.Color.White
        Me.p1gb.Location = New System.Drawing.Point(13, 7)
        Me.p1gb.Name = "p1gb"
        Me.p1gb.Size = New System.Drawing.Size(127, 110)
        Me.p1gb.TabIndex = 0
        Me.p1gb.TabStop = False
        Me.p1gb.Text = "Parking 1"
        '
        'p1name
        '
        Me.p1name.AutoSize = True
        Me.p1name.BackColor = System.Drawing.Color.Transparent
        Me.p1name.Location = New System.Drawing.Point(28, 69)
        Me.p1name.Name = "p1name"
        Me.p1name.Size = New System.Drawing.Size(41, 16)
        Me.p1name.TabIndex = 3
        Me.p1name.Text = "Name"
        Me.p1name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(6, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Name"
        '
        'p1rf
        '
        Me.p1rf.AutoSize = True
        Me.p1rf.BackColor = System.Drawing.Color.Transparent
        Me.p1rf.Location = New System.Drawing.Point(28, 37)
        Me.p1rf.Name = "p1rf"
        Me.p1rf.Size = New System.Drawing.Size(83, 16)
        Me.p1rf.TabIndex = 1
        Me.p1rf.Text = "RFID Card No."
        Me.p1rf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(6, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "RFID Card No."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(230, 405)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Entry Status"
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
        Me.entryrf.Location = New System.Drawing.Point(233, 426)
        Me.entryrf.Margin = New System.Windows.Forms.Padding(4)
        Me.entryrf.Name = "entryrf"
        Me.entryrf.Size = New System.Drawing.Size(168, 31)
        Me.entryrf.TabIndex = 15
        Me.entryrf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'showentry
        '
        Me.showentry.Interval = 2000
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
        Me.exitrf.Location = New System.Drawing.Point(624, 426)
        Me.exitrf.Margin = New System.Windows.Forms.Padding(4)
        Me.exitrf.Name = "exitrf"
        Me.exitrf.Size = New System.Drawing.Size(168, 31)
        Me.exitrf.TabIndex = 17
        Me.exitrf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(621, 405)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 17)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Exit Status"
        '
        'showexit
        '
        '
        'btnreload
        '
        Me.btnreload.BackColor = System.Drawing.Color.SeaGreen
        Me.btnreload.color = System.Drawing.Color.SeaGreen
        Me.btnreload.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.btnreload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnreload.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreload.ForeColor = System.Drawing.Color.White
        Me.btnreload.Image = CType(resources.GetObject("btnreload.Image"), System.Drawing.Image)
        Me.btnreload.ImagePosition = 14
        Me.btnreload.ImageZoom = 50
        Me.btnreload.LabelPosition = 29
        Me.btnreload.LabelText = "Reload"
        Me.btnreload.Location = New System.Drawing.Point(34, 139)
        Me.btnreload.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnreload.Name = "btnreload"
        Me.btnreload.Size = New System.Drawing.Size(83, 80)
        Me.btnreload.TabIndex = 18
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(795, 155)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(169, 134)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
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
        Me.btncp.Location = New System.Drawing.Point(34, 227)
        Me.btncp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btncp.Name = "btncp"
        Me.btncp.Size = New System.Drawing.Size(83, 80)
        Me.btncp.TabIndex = 19
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
        Me.btnsummary.Location = New System.Drawing.Point(125, 227)
        Me.btnsummary.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnsummary.Name = "btnsummary"
        Me.btnsummary.Size = New System.Drawing.Size(83, 80)
        Me.btnsummary.TabIndex = 20
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
        Me.btnaccounts.Location = New System.Drawing.Point(125, 139)
        Me.btnaccounts.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnaccounts.Name = "btnaccounts"
        Me.btnaccounts.Size = New System.Drawing.Size(83, 80)
        Me.btnaccounts.TabIndex = 21
        '
        'employeedashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(976, 499)
        Me.Controls.Add(Me.btnaccounts)
        Me.Controls.Add(Me.btnsummary)
        Me.Controls.Add(Me.btncp)
        Me.Controls.Add(Me.btnreload)
        Me.Controls.Add(Me.exitrf)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.entryrf)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.statpanel)
        Me.Controls.Add(Me.lblclose)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbldate)
        Me.Controls.Add(Me.lbltime)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "employeedashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "employeedashboard"
        Me.statpanel.ResumeLayout(False)
        Me.r4gb.ResumeLayout(False)
        Me.r4gb.PerformLayout()
        Me.r3gb.ResumeLayout(False)
        Me.r3gb.PerformLayout()
        Me.p4gb.ResumeLayout(False)
        Me.p4gb.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.p3gb.ResumeLayout(False)
        Me.p3gb.PerformLayout()
        Me.r1gb.ResumeLayout(False)
        Me.r1gb.PerformLayout()
        Me.p2gb.ResumeLayout(False)
        Me.p2gb.PerformLayout()
        Me.p1gb.ResumeLayout(False)
        Me.p1gb.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbltime As System.Windows.Forms.Label
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents dttimer As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblclose As System.Windows.Forms.Label
    Friend WithEvents statpanel As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents entryrf As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents showentry As System.Windows.Forms.Timer
    Friend WithEvents p1gb As System.Windows.Forms.GroupBox
    Friend WithEvents p1name As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents p1rf As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents p2gb As System.Windows.Forms.GroupBox
    Friend WithEvents p2name As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents p2rf As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents exitrf As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents showexit As System.Windows.Forms.Timer
    Friend WithEvents r4gb As System.Windows.Forms.GroupBox
    Friend WithEvents r4name As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents r4rf As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents r3gb As System.Windows.Forms.GroupBox
    Friend WithEvents r3name As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents r3rf As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents p4gb As System.Windows.Forms.GroupBox
    Friend WithEvents p4name As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents p4rf As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents r2name As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents r2gb As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents p3gb As System.Windows.Forms.GroupBox
    Friend WithEvents p3name As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents p3rf As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents r1gb As System.Windows.Forms.GroupBox
    Friend WithEvents r1name As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents r1rf As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents btnreload As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btncp As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnsummary As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnaccounts As Bunifu.Framework.UI.BunifuTileButton
End Class
