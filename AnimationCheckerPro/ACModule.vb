Imports System.Net
Imports System.IO

Module ACModule
    Public Sub GetFileFromUrl(ByVal url As String, ByVal DownloadDestination As String, ByVal FileType As String)
        Try
            Dim ReDownBufferSize As Double = 0
            Dim ThisRequest As HttpWebRequest = DirectCast(WebRequest.Create(url), HttpWebRequest)
            Dim ThisResponese As HttpWebResponse = DirectCast(ThisRequest.GetResponse(), HttpWebResponse)
            Dim TotalSize As Integer = ThisResponese.ContentLength
            Dim MyThisStream As Stream = ThisResponese.GetResponseStream()
            Dim GetFileStream As New FileStream(DownloadDestination, FileMode.Create)
            Dim buff As Byte() = New Byte(TotalSize) {}
            Dim buffer As Byte() = buff
            '//전송속도 계산하는 것...
            Dim TMP As Long
            Dim StartTime As DateTime = Now
            Try
                Do Until GetFileStream.Length = TotalSize
                    ReDownBufferSize = MyThisStream.Read(buff, 0, 1024) '//파일 스트림을 읽는다..
                    GetFileStream.Write(buffer, 0, ReDownBufferSize)

                    TMP = DateDiff("s", StartTime, Now) + 1  '//두 시간 사이를 초당으로 "s" 계산한다. StartTime은 시작한 시간대, Now는 지금..
                    'DoEvents를 사용하여 실시간 표시.
                    Application.DoEvents()
                    MainForm.DownloadProgressBar.Value = Math.Round(GetFileStream.Length) / Math.Round(TotalSize) * 100
                    MainForm.DownloadStatusLabel.Text = FileType & "를 다운로드 중입니다." & "(" & _
                    Math.Round(GetFileStream.Length / 1024 ^ 2, 2) & "MB / " & Math.Round(TotalSize / 1024 ^ 2, 2) & "MB)"
                    '//초당 킬로바이트수가 어느정도 크기를 넘으면 MB로 표시한다.
                    If (GetFileStream.Length / TMP / 1024) > 850 Then
                        MainForm.DownSpeedLabel.Text = Format(((GetFileStream.Length / TMP / 1024) / 1024), "#0.##") & " MB/sec"
                    Else
                        MainForm.DownSpeedLabel.Text = Format(((GetFileStream.Length / TMP / 1024) / 1024), "#0.##") & " KB/sec"
                    End If
                Loop
                MainForm.DownloadStatusLabel.Text = FileType & "다운로드 완료"

            Catch ex As Exception
                MsgBox("", MsgBoxStyle.OkOnly, "")
                End
            End Try
            GetFileStream.Close()
            MyThisStream.Close()
            ThisResponese.Close()
            MainForm.DownloadProgressBar.Value = 100
        Catch ex As Exception
            MsgBox("필수 구성요소(" & FileType & ") 다운로드 실패!" & Chr(10) & "인터넷 문제일수 있습니다. 이 문제가 계속되면 tarry403@gmail.com 으로 메일을 보내주세요", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "오류")
            MainForm.ErrorCloseButton.Visible = True
        End Try
    End Sub
End Module
