Imports Microsoft.Win32
Public Class SkinDownloadForm
    Dim REG As RegistryKey = Registry.LocalMachine
    Dim RegStorage As String = "Software\\Dunois Soft\\Animation Checker Pro"
    Dim DSkinSet As RegistryKey
    Dim SkinSet As RegistryKey
    Dim SystemSet As RegistryKey
    Dim SkinFileExist As Boolean
    Dim SkinDuplicated As Boolean
    Dim ExistSkinLocation As String = ""
    Dim ExistSkinNumber As Integer = 0
    Private Sub SkinDownloadForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SkinListBox.Items.Clear()
        DSkinSet = REG.OpenSubKey(RegStorage & "\\Skin\\Download", True)
        SkinSet = REG.OpenSubKey(RegStorage & "\\Skin", True)
        SystemSet = REG.OpenSubKey(RegStorage & "\\System", True)
        ImageModeComboBox.SelectedIndex = 0
        Dim SkinListNumber As Integer = MainForm.INIRead("Skin", "Number", MainForm.ACDataFolder & "\SkinList.ini")
        For i As Integer = 1 To SkinListNumber
            Dim SkinName As String = MainForm.INIRead("Skin", "Skin" & i & "Name", MainForm.ACDataFolder & "\SkinList.ini")
            SkinListBox.Items.Add(SkinName)
        Next
    End Sub

    Private Sub FormCloseButton_Click(sender As Object, e As EventArgs) Handles FormCloseButton.Click
        Me.Close()
    End Sub

    Private Sub SkinListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SkinListBox.SelectedIndexChanged
        If SkinListBox.SelectedIndex = -1 Then

        Else
            Dim SelectedNumber As Integer = SkinListBox.SelectedIndex + 1
            Dim SkinLocation As String = MainForm.INIRead("Skin", "Skin" & SelectedNumber & "Location", MainForm.ACDataFolder & "\SkinList.ini")
            SkinPictureBox.ImageLocation = SkinLocation
            SkinApplyButton.Enabled = True
        End If
    End Sub

    Private Sub ShowLargeImageButton_Click(sender As Object, e As EventArgs) Handles ShowLargeImageButton.Click
        LargeImageForm.LargePictureBox.ImageLocation = SkinPictureBox.ImageLocation
        LargeImageForm.ShowDialog()
    End Sub

    Private Sub ImageModeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ImageModeComboBox.SelectedIndexChanged
        If ImageModeComboBox.SelectedIndex = 0 Then
            SkinPictureBox.SizeMode = PictureBoxSizeMode.AutoSize
        ElseIf ImageModeComboBox.SelectedIndex = 1 Then
            SkinPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub SkinApplyButton_Click(sender As Object, e As EventArgs) Handles SkinApplyButton.Click
        If SkinListBox.SelectedIndex = -1 Then

        Else
            If DownloadedSkinConfig.SkinDeleted = 1 Then
                MsgBox("오류 : 다운로드한 스킨 및 스킨내역을 모두 삭제하였기 때문에" & Chr(10) & "프로그램을 재시작하기 전까지 스킨을 다운로드 할수없습니다.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "오류")
            Else
                Dim InstalledSkinNumber As Integer = DSkinSet.GetValue("Number", 0)
                If InstalledSkinNumber = 0 Then '스킨 미존재
                    SkinDownload("None")
                    MsgBox("완료되었습니다.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "완료")
                Else
                    SkinDuplicateCheck()
                    If SkinDuplicated = True Then
                        If MsgBox("이미 다운로드한 스킨입니다. 적용하시겠습니까?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "이미 다운로드한 스킨") = System.Windows.Forms.DialogResult.Yes Then
                            SkinDownload("Duplicated")
                            MsgBox("완료되었습니다.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "완료")
                        Else
                            Exit Sub
                        End If
                    Else
                        SkinDownload("NotDuplicated")
                        MsgBox("완료되었습니다.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "완료")
                    End If
                End If
            End If
        End If
        DownloadedSkinConfig.RefreshList()
    End Sub

    Private Sub InstalledSkinCheckButton_Click(sender As Object, e As EventArgs) Handles InstalledSkinCheckButton.Click
        DownloadedSkinConfig.ShowDialog()
    End Sub
    Private Sub SkinDuplicateCheck()
        Dim SelectedNumber As Integer = SkinListBox.SelectedIndex + 1
        Dim InstalledSkinNumber As Integer = DSkinSet.GetValue("Number", 0)
        Dim getSkinName As String = MainForm.INIRead("Skin", "Skin" & SelectedNumber & "Name", MainForm.ACDataFolder & "\SkinList.ini")
        For i As Integer = 1 To InstalledSkinNumber
            Dim SkinName As String = DSkinSet.GetValue("DSkin" & i & "Name", "False")
            If SkinName = getSkinName Then
                Dim getDuplicatedSkinLocation As String = DSkinSet.GetValue("DSkin" & i & "Location", "None")
                If My.Computer.FileSystem.FileExists(getDuplicatedSkinLocation) Then
                    SkinFileExist = True
                    SkinDuplicated = True
                    ExistSkinLocation = DSkinSet.GetValue("DSkin" & i & "Location")
                    ExistSkinNumber = i
                    Exit For
                Else
                    SkinFileExist = False
                    SkinDuplicated = True
                    ExistSkinNumber = i
                    Exit For
                End If
            Else
                SkinDuplicated = False
            End If
        Next
    End Sub
    Private Sub SkinDownload(ByVal SkinExistType As String)
        Dim SelectedNumber As Integer = SkinListBox.SelectedIndex + 1
        Dim getSkinName As String = MainForm.INIRead("Skin", "Skin" & SelectedNumber & "Name", MainForm.ACDataFolder & "\SkinList.ini")
        Dim getSkinUrl As String = MainForm.INIRead("Skin", "Skin" & SelectedNumber & "Location", MainForm.ACDataFolder & "\SkinList.ini")
        Dim getSkinFileName As String = MainForm.INIRead("Skin", "Skin" & SelectedNumber & "FileName", MainForm.ACDataFolder & "\SkinList.ini")
        Dim InstalledSkinNumber As Integer = DSkinSet.GetValue("Number", 0)
        Dim SkinFileUrl As String = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Skin\" & getSkinFileName
        If SkinExistType = "None" Then
            If My.Computer.FileSystem.FileExists(SkinFileUrl) Then '스킨내역삭제 예외 처리
                My.Computer.FileSystem.DeleteFile(SkinFileUrl)
            End If
            Try
                '스킨 다운로드 시작 밎 적용
                My.Computer.Network.DownloadFile(getSkinUrl, SkinFileUrl)
                DSkinSet.SetValue("DSkin" & 1 & "Name", getSkinName, Microsoft.Win32.RegistryValueKind.String)
                DSkinSet.SetValue("DSkin" & 1 & "Location", SkinFileUrl, Microsoft.Win32.RegistryValueKind.String)
                DSkinSet.SetValue("CurrentUseSkinNumber", 1, Microsoft.Win32.RegistryValueKind.String)
                DSkinSet.SetValue("Number", 1, Microsoft.Win32.RegistryValueKind.String)
                SkinSet.SetValue("DownloadedSkinUse", 1, Microsoft.Win32.RegistryValueKind.String)
                SkinSet.SetValue("SkinLocation", SkinFileUrl)
                SystemSet.SetValue("SkinUse", 1, Microsoft.Win32.RegistryValueKind.String)
                MainForm.SkinPanel.BackgroundImage = Image.FromFile(SkinFileUrl)
            Catch ex As Exception
                MsgBox("스킨을 다운로드 할수 없습니다.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "오류")
                Exit Sub
                '스킨 미존재시 다운로드 종료
            End Try
        ElseIf SkinExistType = "NotDuplicated" Then
            If My.Computer.FileSystem.FileExists(SkinFileUrl) Then
                NotDuplicatedSkinSet(SkinFileUrl, getSkinName)
            Else
                Try
                    My.Computer.Network.DownloadFile(getSkinUrl, SkinFileUrl)
                    NotDuplicatedSkinSet(SkinFileUrl, getSkinName)
                Catch ex As Exception
                    MsgBox("스킨을 다운로드 할수 없습니다.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "오류")
                End Try
            End If
        ElseIf SkinExistType = "Duplicated" Then
            If SkinFileExist = True Then
                DuplicatedSkinSet(ExistSkinLocation)
            Else
                Try
                    My.Computer.Network.DownloadFile(getSkinUrl, SkinFileUrl)
                    DSkinSet.SetValue("DSkin" & ExistSkinNumber & "Location", SkinFileUrl, RegistryValueKind.String)
                    DuplicatedSkinSet(SkinFileUrl)
                Catch ex As Exception
                    MsgBox("스킨을 다운로드 할수 없습니다.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "오류")
                End Try
                '/파일없음
            End If
        End If
    End Sub
    Private Sub NotDuplicatedSkinSet(ByVal SkinFileLocation As String, ByVal GetSkinName As String)
        Dim InstalledSkinNumber As Integer = DSkinSet.GetValue("Number", 0)
        Dim SelectedNumber As Integer = SkinListBox.SelectedIndex + 1
        DSkinSet.SetValue("DSkin" & InstalledSkinNumber + 1 & "Name", getSkinName, Microsoft.Win32.RegistryValueKind.String)
        DSkinSet.SetValue("DSkin" & InstalledSkinNumber + 1 & "Location", SkinFileLocation, Microsoft.Win32.RegistryValueKind.String)
        DSkinSet.SetValue("CurrentUseSkinNumber", InstalledSkinNumber + 1, Microsoft.Win32.RegistryValueKind.String)
        DSkinSet.SetValue("Number", InstalledSkinNumber + 1, RegistryValueKind.String)
        SkinSet.SetValue("DownloadedSkinUse", 1, Microsoft.Win32.RegistryValueKind.String)
        SkinSet.SetValue("SkinLocation", SkinFileLocation)
        SystemSet.SetValue("SkinUse", 1, Microsoft.Win32.RegistryValueKind.String)
        MainForm.SkinPanel.BackgroundImage = Image.FromFile(SkinFileLocation)
    End Sub
    Private Sub DuplicatedSkinSet(ByVal SkinFileLocation As String)
        SkinSet.SetValue("SkinLocation", SkinFileLocation)
        SkinSet.SetValue("DownloadedSkinUse", 1, Microsoft.Win32.RegistryValueKind.String)
        DSkinSet.SetValue("CurrentUseSkinNumber", ExistSkinNumber, Microsoft.Win32.RegistryValueKind.String)
        SystemSet.SetValue("SkinUse", 1, RegistryValueKind.String)
        MainForm.SkinPanel.BackgroundImage = Image.FromFile(SkinFileLocation)
    End Sub
End Class