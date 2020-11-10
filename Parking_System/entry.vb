Imports System.Data
Imports System.Data.SqlClient
Public Class entry
    Dim conn As SqlConnection
    Dim cmd, cmd2, cmd3 As SqlCommand
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
    End Sub

    Private Sub entry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        searchtimer.Start()
    End Sub

    Private Sub searchtimer_Tick(sender As Object, e As EventArgs) Handles searchtimer.Tick
        'TEXTBOX UNEDITABLE
        entryname.Enabled = False
        entrybal.Enabled = False
        If String.IsNullOrEmpty(entryrf.Text) Then
            'Do nothing
            entryname.Text = ""
            entrybal.Text = ""
        Else
            Try
                conn = New SqlConnection("server=ZXYNETHJEIGN\SQLEXPRESS; database= DB_PARKSYSTEM; integrated security= SSPI")
                Dim cmd2 As New SqlCommand("select * from db_customer where rfid_no = @rfid_no", conn)
                cmd2.Parameters.Add("@rfid_no", SqlDbType.NVarChar).Value = entryrf.Text
                Dim adapter2 As New SqlDataAdapter(cmd2)
                Dim table2 As New DataTable
                adapter2.Fill(table2)
                If table2.Rows.Count() > 0 Then
                    conn.Open()
                    'display name and balance
                    entryname.Text = table2.Rows(0)(1).ToString()
                    entrybal.Text = table2.Rows(0)(3).ToString()
                    entryrf.BorderColorFocused = Color.SeaGreen
                    btnaccept.Enabled = True
                    conn.Close()
                    Dim cmd As New SqlCommand("select * from db_currentcus where rfid_no = @rfid_no", conn)
                    cmd.Parameters.Add("@rfid_no", SqlDbType.NVarChar).Value = entryrf.Text
                    Dim adapter As New SqlDataAdapter(cmd)
                    Dim table As New DataTable
                    adapter.Fill(table)
                    Try
                        If table.Rows.Count() > 0 Then
                            conn.Open()
                            entryrf.BorderColorFocused = Color.DarkRed
                            btnaccept.Enabled = False
                            entryrf.Text = ""
                            conn.Close()
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Already in the parking area")
                    End Try
                   
                Else
                End If
            Catch ex As Exception

            End Try
            
        End If
    End Sub

    Private Sub btnaccept_Click(sender As Object, e As EventArgs) Handles btnaccept.Click
        If rbp1.Checked = True Then
            Try
                conn = New SqlConnection("server=ZXYNETHJEIGN\SQLEXPRESS; database= DB_PARKSYSTEM; integrated security= SSPI")
                'insert into database current customer
                Dim query2 As String = "insert into db_currentcus (rfid_no,name,park_type,park_state) values (@rfid_no,@name,@park_type,@park_state)"
                conn.Open()
                cmd2 = New SqlCommand(query2, conn)
                cmd2.Parameters.AddWithValue("@rfid_no", entryrf.Text)
                cmd2.Parameters.AddWithValue("@name", entryname.Text)
                cmd2.Parameters.AddWithValue("@park_type", "Parking 1")
                cmd2.Parameters.AddWithValue("@park_state", rbp1.Checked)
                cmd2.ExecuteNonQuery()
                conn.Close()
                'insert into database time in
                Dim query3 As String = "insert into db_time_in (rfid_no,fname,balance,tin,date) values (@rfid_no,@fname,@balance,@tin,@date)"
                conn.Open()
                cmd3 = New SqlCommand(query3, conn)
                cmd3.Parameters.AddWithValue("@rfid_no", entryrf.Text)
                cmd3.Parameters.AddWithValue("@fname", entryname.Text)
                cmd3.Parameters.AddWithValue("@balance", entrybal.Text)
                cmd3.Parameters.AddWithValue("@tin", employeedashboard.lbltime.Text)
                cmd3.Parameters.AddWithValue("@date", employeedashboard.lbldate.Text)
                cmd3.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf rbp2.Checked = True Then
            Try
                conn = New SqlConnection("server=ZXYNETHJEIGN\SQLEXPRESS; database= DB_PARKSYSTEM; integrated security= SSPI")
                'insert into database current customer
                Dim query2 As String = "insert into db_currentcus (rfid_no,name,park_type,park_state) values (@rfid_no,@name,@park_type,@park_state)"
                conn.Open()
                cmd2 = New SqlCommand(query2, conn)
                cmd2.Parameters.AddWithValue("@rfid_no", entryrf.Text)
                cmd2.Parameters.AddWithValue("@name", entryname.Text)
                cmd2.Parameters.AddWithValue("@park_type", "Parking 2")
                cmd2.Parameters.AddWithValue("@park_state", rbp2.Checked)
                cmd2.ExecuteNonQuery()
                conn.Close()
                'insert into database time in
                Dim query3 As String = "insert into db_time_in (rfid_no,fname,balance,tin,date) values (@rfid_no,@fname,@balance,@tin,@date)"
                conn.Open()
                cmd3 = New SqlCommand(query3, conn)
                cmd3.Parameters.AddWithValue("@rfid_no", entryrf.Text)
                cmd3.Parameters.AddWithValue("@fname", entryname.Text)
                cmd3.Parameters.AddWithValue("@balance", entrybal.Text)
                cmd3.Parameters.AddWithValue("@tin", employeedashboard.lbltime.Text)
                cmd3.Parameters.AddWithValue("@date", employeedashboard.lbldate.Text)
                cmd3.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf rbp3.Checked = True Then
            Try
                conn = New SqlConnection("server=ZXYNETHJEIGN\SQLEXPRESS; database= DB_PARKSYSTEM; integrated security= SSPI")
                'insert into database current customer
                Dim query2 As String = "insert into db_currentcus (rfid_no,name,park_type,park_state) values (@rfid_no,@name,@park_type,@park_state)"
                conn.Open()
                cmd2 = New SqlCommand(query2, conn)
                cmd2.Parameters.AddWithValue("@rfid_no", entryrf.Text)
                cmd2.Parameters.AddWithValue("@name", entryname.Text)
                cmd2.Parameters.AddWithValue("@park_type", "Parking 3")
                cmd2.Parameters.AddWithValue("@park_state", rbp2.Checked)
                cmd2.ExecuteNonQuery()
                conn.Close()
                'insert into database time in
                Dim query3 As String = "insert into db_time_in (rfid_no,fname,balance,tin,date) values (@rfid_no,@fname,@balance,@tin,@date)"
                conn.Open()
                cmd3 = New SqlCommand(query3, conn)
                cmd3.Parameters.AddWithValue("@rfid_no", entryrf.Text)
                cmd3.Parameters.AddWithValue("@fname", entryname.Text)
                cmd3.Parameters.AddWithValue("@balance", entrybal.Text)
                cmd3.Parameters.AddWithValue("@tin", employeedashboard.lbltime.Text)
                cmd3.Parameters.AddWithValue("@date", employeedashboard.lbldate.Text)
                cmd3.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf rbp4.Checked = True Then
            Try
                conn = New SqlConnection("server=ZXYNETHJEIGN\SQLEXPRESS; database= DB_PARKSYSTEM; integrated security= SSPI")
                'insert into database current customer
                Dim query2 As String = "insert into db_currentcus (rfid_no,name,park_type,park_state) values (@rfid_no,@name,@park_type,@park_state)"
                conn.Open()
                cmd2 = New SqlCommand(query2, conn)
                cmd2.Parameters.AddWithValue("@rfid_no", entryrf.Text)
                cmd2.Parameters.AddWithValue("@name", entryname.Text)
                cmd2.Parameters.AddWithValue("@park_type", "Parking 4")
                cmd2.Parameters.AddWithValue("@park_state", rbp2.Checked)
                cmd2.ExecuteNonQuery()
                conn.Close()
                'insert into database time in
                Dim query3 As String = "insert into db_time_in (rfid_no,fname,balance,tin,date) values (@rfid_no,@fname,@balance,@tin,@date)"
                conn.Open()
                cmd3 = New SqlCommand(query3, conn)
                cmd3.Parameters.AddWithValue("@rfid_no", entryrf.Text)
                cmd3.Parameters.AddWithValue("@fname", entryname.Text)
                cmd3.Parameters.AddWithValue("@balance", entrybal.Text)
                cmd3.Parameters.AddWithValue("@tin", employeedashboard.lbltime.Text)
                cmd3.Parameters.AddWithValue("@date", employeedashboard.lbldate.Text)
                cmd3.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            'ROTARY PARKING 1
        ElseIf rp1.Checked = True Then
            Try
                conn = New SqlConnection("server=ZXYNETHJEIGN\SQLEXPRESS; database= DB_PARKSYSTEM; integrated security= SSPI")
                'insert into database current customer
                Dim query2 As String = "insert into db_currentcus (rfid_no,name,park_type,park_state) values (@rfid_no,@name,@park_type,@park_state)"
                conn.Open()
                cmd2 = New SqlCommand(query2, conn)
                cmd2.Parameters.AddWithValue("@rfid_no", entryrf.Text)
                cmd2.Parameters.AddWithValue("@name", entryname.Text)
                cmd2.Parameters.AddWithValue("@park_type", "Rotary Parking 1")
                cmd2.Parameters.AddWithValue("@park_state", rp1.Checked)
                cmd2.ExecuteNonQuery()
                conn.Close()
                'insert into database time in
                Dim query3 As String = "insert into db_time_in (rfid_no,fname,balance,tin,date) values (@rfid_no,@fname,@balance,@tin,@date)"
                conn.Open()
                cmd3 = New SqlCommand(query3, conn)
                cmd3.Parameters.AddWithValue("@rfid_no", entryrf.Text)
                cmd3.Parameters.AddWithValue("@fname", entryname.Text)
                cmd3.Parameters.AddWithValue("@balance", entrybal.Text)
                cmd3.Parameters.AddWithValue("@tin", employeedashboard.lbltime.Text)
                cmd3.Parameters.AddWithValue("@date", employeedashboard.lbldate.Text)
                cmd3.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            MsgBox("Please Select a Parking Area to Continue", MsgBoxStyle.Critical, "Notice")
        End If

    End Sub

 
    Private Sub entryname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles entryname.KeyPress
        Try
            If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MessageBox.Show("Numbers Only")
        End Try
       
    End Sub
End Class