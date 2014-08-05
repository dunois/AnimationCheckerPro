Imports Microsoft.Win32
Public Class ImportantNotice

    Private Sub FExitButton_Click(sender As Object, e As EventArgs) Handles FExitButton.Click
        Dim RegStorage As String = "Software\\Dunois Soft\\Animation Checker Pro"
        Dim REG As RegistryKey = Registry.LocalMachine
        Dim getNoticeType As String = MainForm.INIRead("Notice", "ImpNoticeType", MainForm.ACDataFolder & "\AnimationCheckerProList.ini")
        Dim regkey As RegistryKey = REG.OpenSubKey(RegStorage, True)
        regkey.SetValue("NoticeType", getNoticeType)
        Me.Close()
    End Sub

    Private Sub ImportantNotice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NoticeLabel.Text = MainForm.INIRead("Notice", "ImpNotice", MainForm.ACDataFolder & "\AnimationCheckerProList.ini")
        CloseButtonTimer.Interval = MainForm.INIRead("Notice", "ImpNoticeIntever", MainForm.ACDataFolder & "\AnimationCheckerProList.ini")
        NoticeLabel.Text = Replace(NoticeLabel.Text, "<br>", Chr(10))
        CloseButtonTimer.Enabled = True
    End Sub

    Private Sub CloseButtonTimer_Tick(sender As Object, e As EventArgs) Handles CloseButtonTimer.Tick
        CloseButtonTimer.Enabled = False
        FExitButton.Visible = True
    End Sub
End Class