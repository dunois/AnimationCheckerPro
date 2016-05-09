Imports Microsoft.Win32
Public Class ImportantNotice
    Private Sub FExitButton_Click(sender As Object, e As EventArgs) Handles FExitButton.Click
        XMLWriter(MainForm.SettingFileLocation, "System", "Notice", MainForm.INIRead("Notice", "ImpNoticeType", MainForm.ACDataFolder & "\AnimationCheckerProList.ini"))
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