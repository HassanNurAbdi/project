Public Class Splaashvb

    Private Sub Splaashvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        BunifuProgressBar2.Width += 6
        If BunifuProgressBar2.Width >= 730 Then
            Timer1.Stop()
            Me.Hide()
            Form1.Show()


        End If
    End Sub
End Class