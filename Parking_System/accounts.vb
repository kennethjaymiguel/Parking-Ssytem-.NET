Imports System.Data
Imports System.Data.SqlClient

Public Class accounts
    Dim conn As SqlConnection
    Dim cmd, cmd1, cmd2, cmd3 As SqlCommand
    Private Sub searchtmr_Tick(sender As Object, e As EventArgs) Handles searchtmr.Tick
        If String.IsNullOrEmpty(accountsrf.Text) Then

        Else
          
            Try

                conn = New SqlConnection("server=ZXYNETHJEIGN\SQLEXPRESS; database= DB_PARKSYSTEM; integrated security= SSPI")
                Dim cmd As New SqlCommand("select * from db_customer where rfid_no = @rfid_no", conn)
                cmd.Parameters.Add("@rfid_no", SqlDbType.NVarChar).Value = accountsrf.Text
                Dim adapter As New SqlDataAdapter(cmd)
                Dim table As New DataTable
                adapter.Fill(table)
                If table.Rows.Count() > 0 Then
                    lblnotregistered.Visible = False
                    accountsrf.BorderColorFocused = Color.SeaGreen
                    accountsname.Text = table.Rows(0)(1).ToString()
                    accountspnum.Text = table.Rows(0)(2).ToString()


                Else
                    accountsrf.BorderColorFocused = Color.DarkRed
                    lblnotregistered.Visible = True
                    'INSERT INTO NEW CUSTOMER DATA
                    Try
                        Dim query2 As String = "insert into db_currentcus (rfid_no,fname,pnum) values (@rfid_no,@fname,@pnum)"
                        conn.Open()
                        cmd2 = New SqlCommand(query2, conn)
                        cmd2.Parameters.AddWithValue("@rfid_no", accountsrf.Text)
                        cmd2.Parameters.AddWithValue("@fname", accountsname.Text)
                        cmd2.Parameters.AddWithValue("@pnum", accountspnum.Text)
                        cmd2.ExecuteNonQuery()
                        conn.Close()
                    Catch ex As Exception

                    End Try
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
       
    End Sub

    Private Sub accounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        searchtmr.Start()

    End Sub

    Private Sub accountsname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles accountsname.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub accountspnum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles accountspnum.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                MessageBox.Show("Invalid Input! Numbers Only.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Handled = True
            End If
        End If
        If accountspnum.Text.Length >= 11 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MessageBox.Show("Phone number should be 11 digits only!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

  
    Private Sub lblclose_Click(sender As Object, e As EventArgs) Handles lblclose.Click
        Me.Close()
    End Sub
End Class