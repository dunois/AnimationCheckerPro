Imports System.Net
Imports System.IO
Public Class TestForm
    Public testtime As Integer
    Dim TodayDate = Weekday(My.Computer.Clock.LocalTime)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.DoEvents()
        For i As Integer = 1 To 3
            Dim WebString As String = ""
            If i = 1 Then
                WebString = "http://www.nyaa.se"
            ElseIf i = 2 Then
                WebString = "http://www.tokyotosho.info"
            ElseIf i = 3 Then
                WebString = "http://www.google.com"
            End If

            Try
                Dim rq = Net.WebRequest.Create(WebString)
                Dim Timewatch As New Stopwatch
                Timewatch.Start()
                rq.Timeout = 5000 '//5초이내 응답이없으면 실패로 간주 
                rq.GetResponse()
                MsgBox("접속성공 : " & WebString & " / " & Timewatch.ElapsedMilliseconds / 1000 & "초")
                Timewatch.Stop()
                Timewatch.Reset()
                rq.Abort()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        Next
    End Sub

    Private Sub AnissiaAPIWeekComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AnissiaAPIWeekComboBox.SelectedIndexChanged
        Dim SelectedWeek As Integer = AnissiaAPIWeekComboBox.SelectedIndex
        Dim WebRequest = Net.HttpWebRequest.Create("http://www.anissia.net/anitime/list?w=" & SelectedWeek)
        WebRequest.Headers("")
    End Sub

    Private Sub TestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AnissiaAPIWeekComboBox.SelectedIndex = TodayDate - 1
    End Sub
End Class