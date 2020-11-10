Imports System.Data
Imports System.Data.SqlClient
Public Class loginfrm
    Dim conn As SqlConnection
    Dim cmd, cmd2 As SqlCommand

    Private Sub txpw_CheckedChanged(sender As Object, e As EventArgs) Handles txpw.CheckedChanged
        txpass.isPassword = Not txpw.Checked
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        conn = New SqlConnection("server=ZXYNETHJEIGN\SQLEXPRESS; database= DB_PARKSYSTEM; integrated security= SSPI")

        If cmbtype.SelectedIndex = 0 Then

            Dim query As String = "select * from db_admin where username=@username and password=@password"
            conn.Open()
            cmd = New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@username", txuser.Text)
            cmd.Parameters.AddWithValue("@password", txpass.Text)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                conn.Close()
                MsgBox("Access Granted!", MsgBoxStyle.Information, "Success!")
                Me.Hide()
                adminform.Show()

                Exit Sub
            End While
            MessageBox.Show("Invalid Credentials")
            conn.Close()

        ElseIf cmbtype.SelectedIndex = 1 Then

            Dim query As String = "select * from db_empl where username=@username and password=@password"
            conn.Open()
            cmd = New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@username", txuser.Text)
            cmd.Parameters.AddWithValue("@password", txpass.Text)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                conn.Close()
                MsgBox("Access Granted!", MsgBoxStyle.Information, "Success!")
                Me.Hide()
                employeedashboard.Show()

                Exit Sub
            End While
            MessageBox.Show("Invalid Credentials")
            conn.Close()
        Else
            MessageBox.Show("Please Select User Type!", "Error")
        End If
    End Sub

    Private Sub loginfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If cmbtype.Items.Count > 0 Then
            cmbtype.SelectedIndex = 0
        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        End
    End Sub
End Class
