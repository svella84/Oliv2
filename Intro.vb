Public Class Intro

    Private Sub Intro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim frm As New Oliv()

        Me.Hide()
        frm.Show()
        Me.Close()
        Timer1.Enabled = False

    End Sub

End Class