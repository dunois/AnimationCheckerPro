Public Class LargeImageForm

    Private Sub LargeImageForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormTimer.Enabled = True
    End Sub

    Private Sub FormTimer_Tick(sender As Object, e As EventArgs) Handles FormTimer.Tick
        FormTimer.Enabled = False
        Me.CenterToScreen()
    End Sub
    Private Sub FormCloseButton_Click(sender As Object, e As EventArgs) Handles FormCloseButton.Click
        Me.Close()
    End Sub
End Class