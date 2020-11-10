Public Class adminform

    Private Sub lblclose_Click(sender As Object, e As EventArgs) Handles lblclose.Click
        Dim res As DialogResult = MsgBox("Are you sure you want to Logout Administrator?", MsgBoxStyle.OkCancel)
        If res = Windows.Forms.DialogResult.OK Then
            Me.Close()
            loginfrm.Show()
        Else
            MsgBox("Cancelled by the Administrator")
        End If
    End Sub
End Class