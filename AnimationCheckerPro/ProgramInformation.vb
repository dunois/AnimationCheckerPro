Public Class ProgramInformation

    Private Sub ProgramInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VersionInfoLabel.Text = "버전 : " & MainForm.Version
    End Sub
End Class