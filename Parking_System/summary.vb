Imports System.Data
Imports System.Data.SqlClient
Public Class summary
    Dim conn = New SqlConnection("server=ZXYNETHJEIGN\SQLEXPRESS; database= DB_PARKSYSTEM; integrated security= SSPI")

    Private Sub summary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FilterData("")
        If cmbtype.Items.Count > 0 Then
            cmbtype.SelectedIndex = 0
        End If

        cmbdbase.Items.Clear()
        cmbdbase.Items.Add("Customer Time in")
        cmbdbase.Items.Add("Customer Time Out")
        cmbdbase.Items.Add("Current Customer")
        cmbdbase.SelectedIndex = 0

        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkRed
        DataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.DarkRed

    End Sub

    Public Sub FilterData(valueToSearch As String)
        'TIME IN
        If cmbdbase.SelectedIndex = 0 Then
            If cmbtype.SelectedIndex = 0 Then
                'RFID
                Dim searchQuery As String = "SELECT * from db_time_in where (rfid_no) like '%" & valueToSearch & "%'"
                Dim command As New SqlCommand(searchQuery, conn)
                Dim adapter As New SqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)
                DataGridView1.DataSource = table
            ElseIf cmbtype.SelectedIndex = 1 Then
                'Full name
                Dim searchQuery As String = "SELECT * from db_time_in where (fname) like '%" & valueToSearch & "%'"
                Dim command As New SqlCommand(searchQuery, conn)
                Dim adapter As New SqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)
                DataGridView1.DataSource = table
            ElseIf cmbtype.SelectedIndex = 2 Then
                'Full name
                Dim searchQuery As String = "SELECT * from db_time_in where (balance) like '%" & valueToSearch & "%'"
                Dim command As New SqlCommand(searchQuery, conn)
                Dim adapter As New SqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)
                DataGridView1.DataSource = table
            ElseIf cmbtype.SelectedIndex = 3 Then
                'Full name
                Dim searchQuery As String = "SELECT * from db_time_in where (tin) like '%" & valueToSearch & "%'"
                Dim command As New SqlCommand(searchQuery, conn)
                Dim adapter As New SqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)
                DataGridView1.DataSource = table
            ElseIf cmbtype.SelectedIndex = 4 Then
                'Full name
                Dim searchQuery As String = "SELECT * from db_time_in where (date) like '%" & valueToSearch & "%'"
                Dim command As New SqlCommand(searchQuery, conn)
                Dim adapter As New SqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)
                DataGridView1.DataSource = table
            ElseIf cmbtype.SelectedIndex = 5 Then
                'Full name
                Dim searchQuery As String = "SELECT * from db_time_in where (status) like '%" & valueToSearch & "%'"
                Dim command As New SqlCommand(searchQuery, conn)
                Dim adapter As New SqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)
                DataGridView1.DataSource = table
            End If
            'TIME OUT
        ElseIf cmbdbase.SelectedIndex = 1 Then
            If cmbtype.SelectedIndex = 0 Then
                'TIME OUT RFID
                Dim searchQuery As String = "SELECT * from db_time_out where (rfid_no) like '%" & valueToSearch & "%'"
                Dim command As New SqlCommand(searchQuery, conn)
                Dim adapter As New SqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)
                DataGridView1.DataSource = table
                'TIME OUT FULL NAME
            ElseIf cmbtype.SelectedIndex = 1 Then
                Dim searchQuery As String = "SELECT * from db_time_out where (fname) like '%" & valueToSearch & "%'"
                Dim command As New SqlCommand(searchQuery, conn)
                Dim adapter As New SqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)
                DataGridView1.DataSource = table
                'TIME OUT BALANCE
            ElseIf cmbtype.SelectedIndex = 2 Then
                Dim searchQuery As String = "SELECT * from db_time_out where (balance) like '%" & valueToSearch & "%'"
                Dim command As New SqlCommand(searchQuery, conn)
                Dim adapter As New SqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)
                DataGridView1.DataSource = table
                'TIME OUT
            ElseIf cmbtype.SelectedIndex = 2 Then
                Dim searchQuery As String = "SELECT * from db_time_out where (tout) like '%" & valueToSearch & "%'"
                Dim command As New SqlCommand(searchQuery, conn)
                Dim adapter As New SqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)
                DataGridView1.DataSource = table
                'TIME OUT DATE
            ElseIf cmbtype.SelectedIndex = 3 Then
                Dim searchQuery As String = "SELECT * from db_time_out where (date) like '%" & valueToSearch & "%'"
                Dim command As New SqlCommand(searchQuery, conn)
                Dim adapter As New SqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)
                DataGridView1.DataSource = table
                'TIME OUT BALANCE
            ElseIf cmbtype.SelectedIndex = 4 Then
                Dim searchQuery As String = "SELECT * from db_time_out where (status) like '%" & valueToSearch & "%'"
                Dim command As New SqlCommand(searchQuery, conn)
                Dim adapter As New SqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)
                DataGridView1.DataSource = table
            End If
            'CURRENT CUSTOMER
        ElseIf cmbdbase.SelectedIndex = 2 Then
            If cmbtype.SelectedIndex = 0 Then
                'RFID
                Dim searchQuery As String = "SELECT * from db_currentcus where (rfid_no) like '%" & valueToSearch & "%'"
                Dim command As New SqlCommand(searchQuery, conn)
                Dim adapter As New SqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)
                DataGridView1.DataSource = table
            ElseIf cmbtype.SelectedIndex = 1 Then
                'Full name
                Dim searchQuery As String = "SELECT * from db_currentcus where (name) like '%" & valueToSearch & "%'"
                Dim command As New SqlCommand(searchQuery, conn)
                Dim adapter As New SqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)
                DataGridView1.DataSource = table
            ElseIf cmbtype.SelectedIndex = 2 Then
                'BALANCE
                Dim searchQuery As String = "SELECT * from db_currentcus where (balance) like '%" & valueToSearch & "%'"
                Dim command As New SqlCommand(searchQuery, conn)
                Dim adapter As New SqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)
                DataGridView1.DataSource = table
            ElseIf cmbtype.SelectedIndex = 3 Then
                'TIME OUT
                Dim searchQuery As String = "SELECT * from db_currentcus where (tout) like '%" & valueToSearch & "%'"
                Dim command As New SqlCommand(searchQuery, conn)
                Dim adapter As New SqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)
                DataGridView1.DataSource = table
            ElseIf cmbtype.SelectedIndex = 4 Then
                'DATE
                Dim searchQuery As String = "SELECT * from db_currentcus where (date) like '%" & valueToSearch & "%'"
                Dim command As New SqlCommand(searchQuery, conn)
                Dim adapter As New SqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)
                DataGridView1.DataSource = table
            ElseIf cmbtype.SelectedIndex = 5 Then
                'STATUS
                Dim searchQuery As String = "SELECT * from db_currentcus where (status) like '%" & valueToSearch & "%'"
                Dim command As New SqlCommand(searchQuery, conn)
                Dim adapter As New SqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)
                DataGridView1.DataSource = table
            End If
        End If



    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        FilterData(searchtx.Text)
    End Sub

    Private Sub searchtx_KeyPress(sender As Object, e As KeyPressEventArgs) Handles searchtx.KeyPress
        FilterData(searchtx.Text)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub
End Class