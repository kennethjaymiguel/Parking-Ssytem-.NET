Imports System.Data
Imports System.Data.SqlClient
Public Class reload
    Dim conn As SqlConnection
    Dim cmd, cmd2, cmd3 As SqlCommand
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
    End Sub


    Private Sub reload_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        stimer.Start()
    End Sub

    Private Sub stimer_Tick(sender As Object, e As EventArgs) Handles stimer.Tick
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
                btnsave.Enabled = True
                conn.Close()
            Else
            End If
        Catch ex As Exception
        End Try


    End Sub

    Private Sub btnreload_Click(sender As Object, e As EventArgs) Handles btnreload.Click
        entrybal.Text = Val(entrybal.Text) + Val(entryrel.Text)
        conn = New SqlConnection("server=ZXYNETHJEIGN\SQLEXPRESS; database= DB_PARKSYSTEM; integrated security= SSPI")

        Dim cmd As New SqlCommand("update db_customer SET bal = @bal where rfid_no = @rfid_no", conn)
        cmd.Parameters.Add("@rfid_no", SqlDbType.VarChar).Value = entryrf.Text
        cmd.Parameters.Add("@bal", SqlDbType.VarChar).Value = entrybal.Text
        conn.Open()
        If cmd.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Successfully Updated")
            entryrel.Text = ""
        Else
            MessageBox.Show("Date Not Updated")
        End If
        conn.Close()
    End Sub
End Class