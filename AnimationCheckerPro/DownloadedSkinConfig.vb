Imports Microsoft.Win32
Public Class DownloadedSkinConfig
    Dim REG As RegistryKey = Microsoft.Win32.Registry.LocalMachine
    Dim RegStorage As String = "Software\\Dunois Soft\\Animation Checker Pro"
    Public SkinDeleted As Integer = 0
    Dim DSkinSet As RegistryKey = REG.OpenSubKey(RegStorage & "\\Skin\\Download", True)
    Dim SkinSet As RegistryKey = REG.OpenSubKey(RegStorage & "\\Skin", True)
    Dim SystemSet As RegistryKey = REG.OpenSubKey(RegStorage & "\\System", True)
    Dim ProgramSet As RegistryKey = REG.OpenSubKey(RegStorage, True)
    Private Sub DownloadedSkinConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DownloadedSkinListBox.Items.Clear()
        Dim getNumber As Integer = DSkinSet.GetValue("Number", 0)
        If getNumber = 0 Then
            DownloadedSkinListBox.Items.Add("다운로드한 배경화면이 없습니다.")
        Else
            For i As Integer = 1 To getNumber
                Dim SkinName As String = DSkinSet.GetValue("DSkin" & i & "Name")
                DownloadedSkinListBox.Items.Add(SkinName)
            Next
        End If
    End Sub
    Public Sub RefreshList()
        DownloadedSkinListBox.Items.Clear()
        Dim getNumber As Integer = DSkinSet.GetValue("Number", 0)
        If getNumber = 0 Then
            DownloadedSkinListBox.Items.Add("다운로드한 배경화면이 없습니다.")
        Else
            For i As Integer = 1 To getNumber
                Dim SkinName As String = DSkinSet.GetValue("DSkin" & i & "Name")
                DownloadedSkinListBox.Items.Add(SkinName)
            Next
        End If
    End Sub

    Private Sub DownloadedSkinListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DownloadedSkinListBox.SelectedIndexChanged
        If DownloadedSkinListBox.SelectedIndex = -1 Then

        Else
            Dim SelectedNumber As Integer = DownloadedSkinListBox.SelectedIndex + 1
            Dim CurrentUseSkinName As String = DSkinSet.GetValue("CurrentUseSkinNumber")
            Dim SkinUseType As Integer = SkinSet.GetValue("DownloadedSkinUse", 0)
            Dim SkinFileLocation As String = DSkinSet.GetValue("DSkin" & SelectedNumber & "Location")
            Dim SkinUseCheck As Integer = SystemSet.GetValue("SkinUse", 0)
            SelectedSkinNameLabel.Text = DownloadedSkinListBox.SelectedItem
            If SkinUseCheck = 0 Then
                CurrentUseSkinNameLabel.Text = "배경화면을 이용하고있지 않습니다."
                CurrentUseSkinShowButton.Enabled = False
            Else
                CurrentUseSkinShowButton.Enabled = True
                If SkinUseType = 0 Then
                    CurrentUseSkinNameLabel.Text = "다운로드한 배경화면을 이용하고있지 않습니다."
                Else
                    CurrentUseSkinNameLabel.Text = DownloadedSkinListBox.Items.Item(CurrentUseSkinName - 1)
                End If
            End If
            If My.Computer.FileSystem.FileExists(SkinFileLocation) Then
                SelectedSkinFileCheckLabel.Text = "선택한 배경화면이 존재합니다."
                SelectedSkinShowButton.Enabled = True
                SelectedSkinUseButton.Enabled = True
            Else
                SelectedSkinFileCheckLabel.Text = "선택한 배경화면이 존재하지 않습니다."
                SelectedSkinShowButton.Enabled = False
                SelectedSkinUseButton.Enabled = False
            End If
        End If
    End Sub

    Private Sub SelectedSkinUseButton_Click(sender As Object, e As EventArgs) Handles SelectedSkinUseButton.Click
        Dim SelectedNumber As Integer = DownloadedSkinListBox.SelectedIndex + 1
        Dim SkinFileLocation As String = DSkinSet.GetValue("DSkin" & SelectedNumber & "Location")
        DSkinSet.SetValue("CurrentUseSkinNumber", SelectedNumber, Microsoft.Win32.RegistryValueKind.String)
        SkinSet.SetValue("SkinLocation", SkinFileLocation, Microsoft.Win32.RegistryValueKind.String)
        SkinSet.SetValue("DownloadedSkinUse", 1, Microsoft.Win32.RegistryValueKind.String)
        SystemSet.SetValue("SkinUse", 1, Microsoft.Win32.RegistryValueKind.String)
        MainForm.SkinPanel.BackgroundImage = Image.FromFile(SkinFileLocation)
        MsgBox("변경하였습니다.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "변경완료")
    End Sub

    Private Sub CurrentUseSkinShowButton_Click(sender As Object, e As EventArgs) Handles CurrentUseSkinShowButton.Click
        Dim getSkinLocation As String = SkinSet.GetValue("SkinLocation")
        LargeImageForm.LargePictureBox.ImageLocation = getSkinLocation
        LargeImageForm.ShowDialog()
    End Sub

    Private Sub SelectedSkinShowButton_Click(sender As Object, e As EventArgs) Handles SelectedSkinShowButton.Click
        Dim SelectedNumber As Integer = DownloadedSkinListBox.SelectedIndex + 1
        Dim SkinLocation As String = DSkinSet.GetValue("DSkin" & SelectedNumber & "Location")
        LargeImageForm.LargePictureBox.ImageLocation = SkinLocation
        LargeImageForm.ShowDialog()
    End Sub

    Private Sub SkinFileSkinListDeleteButton_Click(sender As Object, e As EventArgs) Handles SkinFileSkinListDeleteButton.Click
        Dim SkinUseType As Integer = SkinSet.GetValue("DownloadedSkinUse", 0)
        If MsgBox("경고 : 다운로드한 배경화면 파일과 사용내역을 모두 삭제합니다." & Chr(10) & "그래도 진행하시겠습니까?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "삭제 확인") = System.Windows.Forms.DialogResult.Yes Then
            MainForm.SkinPanel.BackgroundImage = Nothing
            ProgramSet.SetValue("SkinDelete", 1, Microsoft.Win32.RegistryValueKind.String)
            REG.DeleteSubKey(RegStorage & "\\Skin\\Download")
            MsgBox("완료되었습니다. 다운로드한 배경화면은 재시작시 삭제됩니다.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "삭제 완료")
            DownloadedSkinListBox.Items.Clear()
            SelectedSkinNameLabel.Text = "항목을 선택해주세요"
            SelectedSkinFileCheckLabel.Text = "항목을 선택해주세요"
            CurrentUseSkinNameLabel.Text = "항목을 선택해주세요"
            If SkinUseType = 1 Then
                SystemSet.SetValue("SkinUse", 0, Microsoft.Win32.RegistryValueKind.String)
                SkinSet.SetValue("DownloadedSkinUse", 0, Microsoft.Win32.RegistryValueKind.String)
            End If
            SkinDeleted = 1
            SelectedSkinShowButton.Enabled = False
            SelectedSkinUseButton.Enabled = False
            SkinFileSkinListDeleteButton.Enabled = False
            SkinListDeleteButton.Enabled = False
            CurrentUseSkinShowButton.Enabled = False
            SkinDownloadForm.InstalledSkinCheckButton.Enabled = False
        Else

        End If
    End Sub

    Private Sub SkinListDeleteButton_Click(sender As Object, e As EventArgs) Handles SkinListDeleteButton.Click
        If MsgBox("경고 : 배경화면 사용내역을 모두 삭제합니다." & Chr(10) & "그래도 진행하시겠습니까?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "삭제 확인") = System.Windows.Forms.DialogResult.Yes Then
            REG.DeleteSubKey(RegStorage & "\\Skin\\Download")
            MsgBox("완료되었습니다.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "삭제 완료")
            DownloadedSkinListBox.Items.Clear()
            SelectedSkinNameLabel.Text = "항목을 선택해주세요"
            SelectedSkinFileCheckLabel.Text = "항목을 선택해주세요"
            CurrentUseSkinNameLabel.Text = "항목을 선택해주세요"
            SkinDeleted = 1
            SelectedSkinShowButton.Enabled = False
            SelectedSkinUseButton.Enabled = False
            SkinFileSkinListDeleteButton.Enabled = False
            SkinListDeleteButton.Enabled = False
            SkinDownloadForm.InstalledSkinCheckButton.Enabled = False
        Else

        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub
End Class