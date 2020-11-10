Public Class controlpanel

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
    End Sub

    Private Sub controlpanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub entrybtnopen_Click(sender As Object, e As EventArgs) Handles entrybtnopen.Click
        entrybtnopen.Enabled = False
        entrybtnopen.BackColor = Color.DarkRed
        entrybtnclose.Enabled = True
        entrybtnclose.BackColor = Color.Black

    End Sub

    Private Sub entrybtnclose_Click(sender As Object, e As EventArgs) Handles entrybtnclose.Click
        entrybtnopen.Enabled = True
        entrybtnopen.BackColor = Color.Black
        entrybtnclose.Enabled = False
        entrybtnclose.BackColor = Color.DarkRed
    End Sub
End Class