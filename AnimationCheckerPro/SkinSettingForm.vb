
Public Class SkinSettingForm
    Dim FileName As String = ""
    Private Sub SkinFileOpenButton_Click(sender As Object, e As EventArgs) Handles SkinFileOpenButton.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = SkinFileLocationTextBox.Text
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
        MainForm.SkinPanel.BackgroundImage = Image.FromFile(FileName)
        XMLWriter(MainForm.ACDataFolder & "\Settings.xml", "System", "SkinUse", 1)
        XMLWriter(MainForm.ACDataFolder & "\Settings.xml", "System", "SkinPath", SkinFileLocationTextBox.Text)
        Me.Close()
    End Sub

    Private Sub SkinSettingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim getSkinUse As Integer = XMLReader(MainForm.ACDataFolder & "\Settings.xml", "System", "SkinUse")
        Dim getSkinPath As String = XMLReader(MainForm.ACDataFolder & "\Settings.xml", "System", "SkinPath")
        If getSkinUse = 0 Then

        Else
            If My.Computer.FileSystem.FileExists(getSkinPath) Then
                SkinFileLocationTextBox.Text = getSkinPath
                SkinPictureBox.ImageLocation = getSkinPath
                DeleteSkinButton.Enabled = True
                ShowLargeImageButton.Enabled = True
            Else
                MsgBox("스킨 파일이 존재하지 않습니다.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "오류")
            End If
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
            FileName = Str.ToString
        Next
    End Sub

    Private Sub DeleteSkinButton_Click(sender As Object, e As EventArgs) Handles DeleteSkinButton.Click
        If MsgBox("선택한 스킨이 지워집니다." & Chr(10) & "그래도 진행하시겠습니까?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "확인") = System.Windows.Forms.DialogResult.Yes Then
            XMLWriter(MainForm.ACDataFolder & "\Settings.xml", "System", "SkinUse", 0)
            XMLWriter(MainForm.ACDataFolder & "\Settings.xml", "System", "SkinPath", "None")
            MsgBox("완료되었습니다.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "완료")
            MainForm.SkinPanel.BackgroundImage = Nothing
            SkinFileLocationTextBox.Text = ""
            ShowLargeImageButton.Enabled = False
            DeleteSkinButton.Enabled = False
            SkinApplyButton.Enabled = False
            SkinPictureBox.Image = Nothing
            Me.Close()
        End If
    End Sub
End Class