Imports System.Data
Imports System.Data.SqlClient
Public Class exitform
    Dim conn As SqlConnection
    Dim cmd, cmd2, cmd3 As SqlCommand
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
    End Sub


    Private Sub exitform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        searchtimer.Start()
        'TEXTBOX UNEDITABLE
        exitname.Enabled = False
        exitbal.Enabled = False
        exitparkarea.Enabled = False
    End Sub

    Private Sub searchtimer_Tick(sender As Object, e As EventArgs) Handles searchtimer.Tick
        If String.IsNullOrEmpty(exitrf.Text) Then
            'Do nothing
        Else
            'display data balance

            Try
                conn = New SqlConnection("server=ZXYNETHJEIGN\SQLEXPRESS; database= DB_PARKSYSTEM; integrated security= SSPI")
                Dim cmd As New SqlCommand("select * from db_customer where rfid_no = @rfid_no", conn)
                cmd.Parameters.Add("@rfid_no", SqlDbType.NVarChar).Value = exitrf.Text
                Dim adapter As New SqlDataAdapter(cmd)
                Dim table As New DataTable
                adapter.Fill(table)
                If table.Rows.Count() > 0 Then
                    conn.Open()
                    'display name and balance
                    exitname.Text = table.Rows(0)(1).ToString()
                    exitbal.Text = table.Rows(0)(3).ToString()
                    conn.Close()
                Else
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            'display parking lot area
            Try
                conn = New SqlConnection("server=ZXYNETHJEIGN\SQLEXPRESS; database= DB_PARKSYSTEM; integrated security= SSPI")
                Dim cmd2 As New SqlCommand("select * from db_currentcus where rfid_no = @rfid_no", conn)
                cmd2.Parameters.Add("@rfid_no", SqlDbType.NVarChar).Value = exitrf.Text
                Dim adapter As New SqlDataAdapter(cmd2)
                Dim table1 As New DataTable
                adapter.Fill(table1)
                If table1.Rows.Count() > 0 Then
                    conn.Open()
                    'display name and balance
                    exitparkarea.Text = table1.Rows(0)(2).ToString()
                    conn.Close()
                Else
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    
    Private Sub btnaccept_Click(sender As Object, e As EventArgs) Handles btnaccept.Click
        If exitbal.Text >= 80 Then
            conn = New SqlConnection("server=ZXYNETHJEIGN\SQLEXPRESS; database= DB_PARKSYSTEM; integrated security= SSPI")
            Dim cmd As New SqlCommand("DELETE FROM db_currentcus where rfid_no = @rfid_no", conn)
            cmd.Parameters.Add("@rfid_no", SqlDbType.NVarChar).Value = exitrf.Text
            conn.Open()
            If cmd.ExecuteNonQuery() = 1 Then
                exitbal.Text = Val(exitbal.Text) - 80
                'deducting balance

                Dim cmd2 As New SqlCommand("update db_customer SET bal = @bal where rfid_no = @rfid_no", conn)
                cmd2.Parameters.Add("@rfid_no", SqlDbType.VarChar).Value = exitrf.Text
                cmd2.Parameters.Add("@bal", SqlDbType.VarChar).Value = exitbal.Text

                If cmd2.ExecuteNonQuery() = 1 Then
                    MessageBox.Show("Successfully Updated")

                Else
                    MessageBox.Show("Date Not Updated")
                End If

                MessageBox.Show("Record Successfully Deleted!")
                conn.Close()

                'restore original state
                If exitparkarea.Text = "Parking 1" Then
                    employeedashboard.p1gb.BackColor = Color.SeaGreen
                    employeedashboard.p1rf.Text = ""
                    employeedashboard.p1name.Text = ""
                    entry.rbp1.Enabled = True
                ElseIf exitparkarea.Text = "Parking 2" Then
                    employeedashboard.p2gb.BackColor = Color.SeaGreen
                    employeedashboard.p2rf.Text = ""
                    employeedashboard.p2name.Text = ""
                    entry.rbp2.Enabled = True
                ElseIf exitparkarea.Text = "Parking 3" Then
                    employeedashboard.p3gb.BackColor = Color.SeaGreen
                    employeedashboard.p3rf.Text = ""
                    employeedashboard.p3name.Text = ""
                    entry.rbp3.Enabled = True
                ElseIf exitparkarea.Text = "Parking 4" Then
                    employeedashboard.p4gb.BackColor = Color.SeaGreen
                    employeedashboard.p4rf.Text = ""
                    employeedashboard.p4name.Text = ""
                    entry.rbp4.Enabled = True
                ElseIf exitparkarea.Text = "Rotary Parking 1" Then
                    employeedashboard.r1gb.BackColor = Color.SeaGreen
                    employeedashboard.r1rf.Text = ""
                    employeedashboard.r1name.Text = ""
                    entry.rbp4.Enabled = True

                End If
            End If
        Else
            MessageBox.Show("Insuffient Balance")
        End If
        


    End Sub

   
End Class