Public Class UpdateCompleteForm

    Private Sub UpdateCompleteForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim FS, FileStream
        If My.Computer.FileSystem.FileExists(MainForm.ACDataFolder & "\Update.log") Then
            FS = CreateObject("Scripting.FileSystemObject")  'FileSystem객체 생성
            FileStream = FS.OpenTextFile(MainForm.ACDataFolder & "\Update.log")  '파일을 엽니다.
            ChangeLog.Text = FileStream.ReadAll  '열린 파일에서 모든 내용을 읽어서 Text1에 표시합니다.
            FileStream.Close()  '파일을 닫습니다.
            FS = Nothing
        Else
            ChangeLog.Text = "오류"
        End If
    End Sub

    Private Sub FormCloseButton_Click(sender As Object, e As EventArgs) Handles FormCloseButton.Click
        Me.Close()
    End Sub
End Class