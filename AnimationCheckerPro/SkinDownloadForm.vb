Public Class SkinDownloadForm
    Dim REG As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine
    Dim RegStorage As String = "Software\\Dunois Soft\\Animation Checker Pro"
    Private Sub SkinDownloadForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SkinListBox.Items.Clear()
        If REG.OpenSubKey(RegStorage & "\\Skin\\Downloaded", True) Is Nothing Then
            REG.CreateSubKey(RegStorage & "\\Skin\\Downloaded")
        End If
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
                Dim SelectedNumber As Integer = SkinListBox.SelectedIndex + 1
                Dim regkey As Microsoft.Win32.RegistryKey = REG.OpenSubKey(RegStorage & "\\Skin\\Downloaded", True)
                Dim InstalledSkinNumber As Integer = regkey.GetValue("Number", 0)
                Dim getSkinName As String = MainForm.INIRead("Skin", "Skin" & SelectedNumber & "Name", MainForm.ACDataFolder & "\SkinList.ini")
                Dim getSkinUrl As String = MainForm.INIRead("Skin", "Skin" & SelectedNumber & "Location", MainForm.ACDataFolder & "\SkinList.ini")
                Dim getSkinFileName As String = MainForm.INIRead("Skin", "Skin" & SelectedNumber & "FileName", MainForm.ACDataFolder & "\SkinList.ini")
                Dim AlrSkinLocation As String = ""
                Dim AlrSkinNumber As Integer = 0
                Dim AlrSkinCheck As Boolean = False
                If InstalledSkinNumber = 0 Then
                    If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Skin\" & getSkinFileName) Then
                        Dim PPRegkey As Microsoft.Win32.RegistryKey = REG.OpenSubKey(RegStorage & "\\Skin")
                        Dim getUseSkinLocation As String = PPRegkey.GetValue("SkinLocation")
                        If getUseSkinLocation = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Skin\" & getSkinFileName Then
                            My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Skin\" & getSkinFileName)
                        Else

                        End If
                    End If
                    Try
                        Dim Pregkey As Microsoft.Win32.RegistryKey = REG.OpenSubKey(RegStorage & "\\Skin", True)
                        Pregkey.SetValue("SkinLocation", My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Skin\" & getSkinFileName)
                        My.Computer.Network.DownloadFile(getSkinUrl, My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Skin\" & getSkinFileName)
                        regkey.SetValue("DSkin" & InstalledSkinNumber + 1 & "Name", getSkinName, Microsoft.Win32.RegistryValueKind.String)
                        regkey.SetValue("DSkin" & InstalledSkinNumber + 1 & "Location", My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Skin\" & getSkinFileName, Microsoft.Win32.RegistryValueKind.String)
                        regkey.SetValue("CurrentUseSkinNumber", 1, Microsoft.Win32.RegistryValueKind.String)
                        regkey.SetValue("Number", 1, Microsoft.Win32.RegistryValueKind.String)
                        regkey = REG.OpenSubKey(RegStorage, True)
                        regkey.SetValue("DownloadedSkinCheck", 1, Microsoft.Win32.RegistryValueKind.String)
                        regkey.SetValue("SkinUse", 1, Microsoft.Win32.RegistryValueKind.String)
                        MainForm.SkinPanel.BackgroundImage = Image.FromFile(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Skin\" & getSkinFileName)
                    Catch ex As Exception

                    End Try
                Else
                    For i As Integer = 1 To InstalledSkinNumber
                        Dim SkinName As String = regkey.GetValue("DSkin" & i & "Name", "False")
                        If SkinName = getSkinName Then
                            AlrSkinCheck = True
                            AlrSkinLocation = regkey.GetValue("DSkin" & i & "Location")
                            AlrSkinNumber = i
                            Exit For
                        Else
                            AlrSkinCheck = False
                        End If
                    Next
                    If AlrSkinCheck = True Then
                        If MsgBox("이미 다운로드한 스킨입니다. 적용하시겠습니까?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "이미 다운로드한 스킨") = System.Windows.Forms.DialogResult.Yes Then
                            If My.Computer.FileSystem.FileExists(AlrSkinLocation) Then
                                '파일 있음/
                                Dim Pregkey As Microsoft.Win32.RegistryKey = REG.OpenSubKey(RegStorage & "\\Skin", True)
                                Pregkey.SetValue("SkinLocation", AlrSkinLocation)
                                regkey.SetValue("CurrentUseSkinNumber", AlrSkinNumber, Microsoft.Win32.RegistryValueKind.String)
                                MainForm.SkinPanel.BackgroundImage = Image.FromFile(AlrSkinLocation)
                                regkey = REG.OpenSubKey(RegStorage, True)
                                regkey.SetValue("DownloadedSkinCheck", 1, Microsoft.Win32.RegistryValueKind.String)
                                regkey.SetValue("SkinUse", 1)
                                MainForm.SkinPanel.BackgroundImage = Image.FromFile(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Skin\" & getSkinFileName)
                                '/파일있음
                            Else
                                '파일없음/
                                Try
                                    Dim Pregkey As Microsoft.Win32.RegistryKey = REG.OpenSubKey(RegStorage & "\\Skin", True)
                                    My.Computer.Network.DownloadFile(getSkinUrl, My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Skin\" & getSkinFileName)
                                    Pregkey.SetValue("SkinLocation", AlrSkinLocation)
                                    regkey.SetValue("CurrentUseSkin", AlrSkinNumber, Microsoft.Win32.RegistryValueKind.String)
                                    regkey.SetValue("DownloadedSkinCheck", 1, Microsoft.Win32.RegistryValueKind.String)
                                    MainForm.SkinPanel.BackgroundImage = Image.FromFile(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Skin\" & getSkinFileName)
                                    regkey = REG.OpenSubKey(RegStorage, True)
                                    regkey.SetValue("DownloadedSkinCheck", 1, Microsoft.Win32.RegistryValueKind.String)
                                    regkey.SetValue("SkinUse", 1, Microsoft.Win32.RegistryValueKind.String)
                                Catch ex As Exception

                                End Try
                                '/파일없음
                            End If
                        Else
                            '재적용안함/
                            '/재적용안함
                        End If
                    Else
                        '중복스킨 아님/
                        Dim PPRegkey As Microsoft.Win32.RegistryKey = REG.OpenSubKey(RegStorage & "\\Skin")
                        Dim getUseSkinLocation As String = PPRegkey.GetValue("SkinLocation")
                        If getUseSkinLocation = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Skin\" & getSkinFileName Then
                            My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Skin\" & getSkinFileName)
                        Else

                        End If
                        Try
                            Dim Pregkey As Microsoft.Win32.RegistryKey = REG.OpenSubKey(RegStorage & "\\Skin", True)
                            Pregkey.SetValue("SkinLocation", My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Skin\" & getSkinFileName)
                            My.Computer.Network.DownloadFile(getSkinUrl, My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Skin\" & getSkinFileName)
                            regkey.SetValue("DSkin" & InstalledSkinNumber + 1 & "Name", getSkinName, Microsoft.Win32.RegistryValueKind.String)
                            regkey.SetValue("DSkin" & InstalledSkinNumber + 1 & "Location", My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Skin\" & getSkinFileName, Microsoft.Win32.RegistryValueKind.String)
                            regkey.SetValue("CurrentUseSkinNumber", InstalledSkinNumber + 1, Microsoft.Win32.RegistryValueKind.String)
                            regkey.SetValue("Number", InstalledSkinNumber + 1, Microsoft.Win32.RegistryValueKind.String)
                            regkey = REG.OpenSubKey(RegStorage, True)
                            regkey.SetValue("DownloadedSkinCheck", 1, Microsoft.Win32.RegistryValueKind.String)
                            regkey.SetValue("SkinUse", 1, Microsoft.Win32.RegistryValueKind.String)
                            MainForm.SkinPanel.BackgroundImage = Image.FromFile(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Skin\" & getSkinFileName)
                        Catch ex As Exception

                        End Try
                    End If
                End If
                MsgBox("완료되었습니다.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "완료")
            End If
        End If
    End Sub

    Private Sub InstalledSkinCheckButton_Click(sender As Object, e As EventArgs) Handles InstalledSkinCheckButton.Click
        DownloadedSkinConfig.ShowDialog()
    End Sub
End Class