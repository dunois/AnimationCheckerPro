
Public Class SkinSettingForm
    Dim REG As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine
    Dim RegStorage As String = "Software\\Dunois Soft\\Animation Checker Pro"
    Dim FileName As String = ""
    Private Sub SkinFileOpenButton_Click(sender As Object, e As EventArgs) Handles SkinFileOpenButton.Click
        Dim OpenFileDialog As New OpenFileDialog
        If SkinFileLocationTextBox.Text = "" Or SkinFileLocationTextBox.Text = "다운로드한 스킨입니다." Then
            OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyPictures
        Else
            OpenFileDialog.InitialDirectory = SkinFileLocationTextBox.Text
        End If
        OpenFileDialog.Filter = "이미지 파일 (*.jpg)|*.jpg|모든 파일 (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            FileName = OpenFileDialog.FileName
            SkinFileLocationTextBox.Text = FileName
            SkinPictureBox.ImageLocation = FileName
            SkinApplyButton.Enabled = True
            ShowLargeImageButton.Enabled = True
        End If
    End Sub

    Private Sub ShowLargeImageButton_Click(sender As Object, e As EventArgs) Handles ShowLargeImageButton.Click
        LargeImageForm.LargePictureBox.ImageLocation = SkinPictureBox.ImageLocation
        LargeImageForm.ShowDialog()

    End Sub

    Private Sub SkinApplyButton_Click(sender As Object, e As EventArgs) Handles SkinApplyButton.Click
        Dim regkey As Microsoft.Win32.RegistryKey = REG.OpenSubKey(RegStorage, True)
        MainForm.SkinPanel.BackgroundImage = Image.FromFile(FileName)
        regkey.SetValue("SkinUse", "1", Microsoft.Win32.RegistryValueKind.String)
        If REG.OpenSubKey(RegStorage & "\\Skin") Is Nothing Then
            REG.CreateSubKey(RegStorage & "\\Skin")
        End If
        regkey = REG.OpenSubKey(RegStorage & "\\Skin", True)
        regkey.SetValue("SkinLocation", FileName, Microsoft.Win32.RegistryValueKind.String)
        regkey = REG.OpenSubKey(RegStorage, True)
        regkey.SetValue("DownloadedSkinCheck", 0)
        Me.Close()
    End Sub

    Private Sub SkinSettingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ImageModeComboBox.SelectedIndex = 0
        If REG.OpenSubKey(RegStorage & "\\Skin") Is Nothing Then
            REG.CreateSubKey(RegStorage & "\\Skin")
        End If
        Dim regkey As Microsoft.Win32.RegistryKey = REG.OpenSubKey(RegStorage, True)
        Dim SkinUseCheck As Integer = regkey.GetValue("SkinUse", 0)
        If SkinUseCheck = 1 Then
            Dim SkinDownloadedCheck As Integer = regkey.GetValue("DownloadedSkinCheck", 0)
            If SkinDownloadedCheck = 1 Then
                regkey = REG.OpenSubKey(RegStorage & "\\Skin")
                SkinFileLocationTextBox.Text = "다운로드한 스킨입니다."
                Dim SkinLocate As String = regkey.GetValue("SkinLocation", "")
                SkinPictureBox.ImageLocation = SkinLocate
            Else
                regkey = REG.OpenSubKey(RegStorage & "\\Skin")
                Dim SkinLocate As String = regkey.GetValue("SkinLocation", "")
                SkinFileLocationTextBox.Text = SkinLocate
                SkinPictureBox.ImageLocation = SkinLocate
            End If
            DeleteSkinButton.Enabled = True
            ShowLargeImageButton.Enabled = True
        Else

        End If
    End Sub

    Private Sub SkinSettingForm_DragOver(sender As Object, e As DragEventArgs) Handles MyBase.DragOver
        e.Effect = DragDropEffects.All
    End Sub

    Private Sub SkinSettingForm_DragDrop(sender As Object, e As DragEventArgs) Handles MyBase.DragDrop
        Dim Str As String
        '파일이 여러개 드래그 되었을 수도 있으니 For Each를 이용
        For Each Str In e.Data.GetData(DataFormats.FileDrop, False)
            '예제에서는 메세지박스에 파일이름 출력
            SkinFileLocationTextBox.Text = Str.ToString
            SkinPictureBox.ImageLocation = Str.ToString
            SkinApplyButton.Enabled = True
            ShowLargeImageButton.Enabled = True
        Next
    End Sub

    Private Sub ImageModeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ImageModeComboBox.SelectedIndexChanged
        If ImageModeComboBox.SelectedIndex = 0 Then
            SkinPictureBox.SizeMode = PictureBoxSizeMode.AutoSize
        ElseIf ImageModeComboBox.SelectedIndex = 1 Then
            SkinPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub DeleteSkinButton_Click(sender As Object, e As EventArgs) Handles DeleteSkinButton.Click
        Dim regkey As Microsoft.Win32.RegistryKey = REG.OpenSubKey(RegStorage, True)
        If MsgBox("선택한 스킨이 지워집니다." & Chr(10) & "그래도 진행하시겠습니까?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "확인") = System.Windows.Forms.DialogResult.Yes Then
            regkey.SetValue("SkinUse", 0, Microsoft.Win32.RegistryValueKind.String)
            MsgBox("완료되었습니다.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "완료")
            MainForm.SkinPanel.BackgroundImage = Nothing
            SkinFileLocationTextBox.Text = ""
            ShowLargeImageButton.Enabled = False
            DeleteSkinButton.Enabled = False
            SkinApplyButton.Enabled = False
            Me.Close()
        End If
    End Sub
End Class