Imports System.Data
Imports System.Data.SqlClient
Public Class employeedashboard
    Dim conn As SqlConnection
    Dim cmd, cmd2, cmd3 As SqlCommand

    Private Sub employeedashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dttimer.Start()
        showentry.Start()
        showexit.Start()
    End Sub

    Private Sub dttimer_Tick(sender As Object, e As EventArgs) Handles dttimer.Tick
        lbltime.Text = DateTime.Now.ToString("h:mm:ss tt")
        lbldate.Text = DateTime.Now.ToString("MM/dd/yyyy ")

        'show data for PARKING 1
        Try
            conn = New SqlConnection("server=ZXYNETHJEIGN\SQLEXPRESS; database= DB_PARKSYSTEM; integrated security= SSPI")
            Dim cmd2 As New SqlCommand("select * from db_currentcus WHERE park_type='Parking 1'", conn)
            Dim adapter As New SqlDataAdapter(cmd2)
            Dim table As New DataTable
            adapter.Fill(table)
            If table.Rows.Count() > 0 Then
                conn.Open()
                'display name and balance
                p1rf.Text = table.Rows(0)(0).ToString()
                p1name.Text = table.Rows(0)(1).ToString()
                p1gb.BackColor = Color.DarkRed
                entry.rbp1.Enabled = False
                entry.rbp1.Checked = False
                conn.Close()
            Else
            End If
        Catch ex As Exception
        End Try
        'show data for PARKING 2
        Try
            conn = New SqlConnection("server=ZXYNETHJEIGN\SQLEXPRESS; database= DB_PARKSYSTEM; integrated security= SSPI")
            Dim cmd2 As New SqlCommand("select * from db_currentcus WHERE park_type='Parking 2'", conn)
            Dim adapter As New SqlDataAdapter(cmd2)
            Dim table As New DataTable
            adapter.Fill(table)
            If table.Rows.Count() > 0 Then
                conn.Open()
                'display name and balance
                p2rf.Text = table.Rows(0)(0).ToString()
                p2name.Text = table.Rows(0)(1).ToString()
                p2gb.BackColor = Color.DarkRed
                entry.rbp2.Enabled = False
                entry.rbp2.Checked = False
                conn.Close()
            Else
            End If
        Catch ex As Exception
        End Try
        'show data for PARKING 3
        Try

            Dim cmd2 As New SqlCommand("select * from db_currentcus WHERE park_type='Parking 3'", conn)
            Dim adapter As New SqlDataAdapter(cmd2)
            Dim table As New DataTable
            adapter.Fill(table)
            If table.Rows.Count() > 0 Then
                conn.Open()
                'display name and balance
                p3rf.Text = table.Rows(0)(0).ToString()
                p3name.Text = table.Rows(0)(1).ToString()
                p3gb.BackColor = Color.DarkRed
                entry.rbp3.Enabled = False
                entry.rbp3.Checked = False
                conn.Close()
            Else
            End If
        Catch ex As Exception
        End Try
        'show data for PARKING 4
        Try

            Dim cmd2 As New SqlCommand("select * from db_currentcus WHERE park_type='Parking 4'", conn)
            Dim adapter As New SqlDataAdapter(cmd2)
            Dim table As New DataTable
            adapter.Fill(table)
            If table.Rows.Count() > 0 Then
                conn.Open()
                'display name and balance
                p4rf.Text = table.Rows(0)(0).ToString()
                p4name.Text = table.Rows(0)(1).ToString()
                p4gb.BackColor = Color.DarkRed
                entry.rbp4.Enabled = False
                entry.rbp4.Checked = False
                conn.Close()
            Else
            End If
        Catch ex As Exception
        End Try
        'show data for ROTARY PARKING 1
        Try

            Dim cmd2 As New SqlCommand("select * from db_currentcus WHERE park_type='Rotary Parking 1'", conn)
            Dim adapter As New SqlDataAdapter(cmd2)
            Dim table As New DataTable
            adapter.Fill(table)
            If table.Rows.Count() > 0 Then
                conn.Open()
                'display name and balance
                r1rf.Text = table.Rows(0)(0).ToString()
                r1name.Text = table.Rows(0)(1).ToString()
                r1gb.BackColor = Color.DarkRed
                entry.rp1.Enabled = False
                entry.rp1.Checked = False
                conn.Close()
            Else
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub lblclose_Click(sender As Object, e As EventArgs) Handles lblclose.Click
        Dim rs As DialogResult = MsgBox("This will end your session? Would you like to log out?", MessageBoxButtons.YesNo)
        If rs = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            loginfrm.Show()
        Else
            MsgBox("Operation cancelled by the user!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub showentry_Tick(sender As Object, e As EventArgs) Handles showentry.Tick
        If String.IsNullOrEmpty(entryrf.Text) Then
            'do nothing
        Else
            Try
                conn = New SqlConnection("server=ZXYNETHJEIGN\SQLEXPRESS; database= DB_PARKSYSTEM; integrated security= SSPI")
                Dim cmd As New SqlCommand("select * from db_customer where rfid_no = @rfid_no", conn)
                cmd.Parameters.Add("@rfid_no", SqlDbType.NVarChar).Value = entryrf.Text
                Dim adapter As New SqlDataAdapter(cmd)
                Dim table As New DataTable
                adapter.Fill(table)
                If table.Rows.Count() > 0 Then
                    entry.entryrf.Text = entryrf.Text
                    entryrf.BorderColorFocused = Color.SeaGreen
                    entry.Show()
                    entryrf.Text = ""

                Else
                    entryrf.BorderColorFocused = Color.DarkRed
                End If
            Catch ex As Exception
                entryrf.Text = ""
            End Try
        End If


    End Sub

    Private Sub showexit_Tick(sender As Object, e As EventArgs) Handles showexit.Tick
        If String.IsNullOrEmpty(exitrf.Text) Then
            'do nothing
        Else
            Try
                conn = New SqlConnection("server=ZXYNETHJEIGN\SQLEXPRESS; database= DB_PARKSYSTEM; integrated security= SSPI")
                Dim cmd As New SqlCommand("select * from db_customer where rfid_no = @rfid_no", conn)
                cmd.Parameters.Add("@rfid_no", SqlDbType.NVarChar).Value = exitrf.Text
                Dim adapter As New SqlDataAdapter(cmd)
                Dim table As New DataTable
                adapter.Fill(table)
                If table.Rows.Count() > 0 Then
                    exitform.exitrf.Text = exitrf.Text
                    exitrf.BorderColorFocused = Color.SeaGreen
                    exitform.Show()
                    exitrf.Text = ""

                Else
                    entryrf.BorderColorFocused = Color.DarkRed
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs)
        Me.Refresh()
    End Sub

   
 

    Private Sub btnreload_Click(sender As Object, e As EventArgs) Handles btnreload.Click
        reload.Show()
    End Sub

    Private Sub btnsummary_Click(sender As Object, e As EventArgs) Handles btnsummary.Click
        summary.Show()
    End Sub

    Private Sub btnaccounts_Click(sender As Object, e As EventArgs) Handles btnaccounts.Click
        accounts.Show()
    End Sub

    Private Sub btncp_Click(sender As Object, e As EventArgs) Handles btncp.Click
        controlpanel.Show()
    End Sub
End Class