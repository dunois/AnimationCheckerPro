Imports System.Net
Imports System.IO
Imports System.Text
Imports System.Text.RegularExpressions
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
        '//콤보박스의값 변경시
        Dim Source As String
        Using Web As New Net.WebClient
            Source = Encoding.UTF8.GetString(Web.DownloadData("http://www.anissia.net/anitime/list?w=" & SelectedWeek))
            '//Anissia에서 방영리스트 불러옴 (JSON 형식 텍스트)
        End Using
        Dim J = New JSON(Source) '//JSON 클래스를 사용해 텍스트 분석 (키와 값으로 나눔)
        DataGridView1.DataSource = J.Select(Function(x) New AniList(x)).ToArray()
        '//구조체 AniList는 JSON 클래스를 사용해 키와 값으로 나눈 값을
        '//'http://www.anissia.net/?m=1&b=4' 에서 응답코드 설명을 참조하여 보기쉽게 정리한뒤
        '//그리드로 보기위해 DataGridView1 의 DataSource 속성에 입력
        DataGridView1.Columns(2).DefaultCellStyle.Format = "HH:mm"
    End Sub
    Structure AniList
        Dim Source As Dictionary(Of String, String)
        ReadOnly Property 고유번호 As Integer
            Get
                Return Source("i")
            End Get
        End Property
        ReadOnly Property 제목 As String
            Get
                Return Source("s")
            End Get
        End Property
        ReadOnly Property 시간 As Date
            Get
                With Source("t")
                    Return DateAndTime.TimeSerial(.Substring(0, 2), .Substring(2, 2), 0)
                End With
            End Get
        End Property
        ReadOnly Property 장르 As String
            Get
                Return Source("g")
            End Get
        End Property
        ReadOnly Property 주소 As String
            Get
                Return "http://" & Source("l")
            End Get
        End Property
        ReadOnly Property 시작일 As Date
            Get
                With Source("sd")
                    Return DateAndTime.DateSerial(.Substring(0, 4), .Substring(4, 2), .Substring(6, 2))
                End With
            End Get
        End Property
        ReadOnly Property 종료일 As Date
            Get
                With Source("ed")
                    Return DateAndTime.DateSerial(.Substring(0, 4), .Substring(4, 2), .Substring(6, 2))
                End With
            End Get
        End Property
        Sub New(s As Dictionary(Of String, String))
            Source = s
        End Sub
    End Structure

    Private Sub TestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AnissiaAPIWeekComboBox.SelectedIndex = TodayDate - 1
    End Sub
End Class

Public Class JSON
    Inherits List(Of Dictionary(Of String, String))
    Sub New(s As String)
        On Error Resume Next
        AddRange(Regex.Matches(s.Replace("""", ""), "{.*?}").OfType(Of Match).Select( _
                 Function(x) Regex.Matches(x.Value, "[^{},]+").OfType(Of Match)().ToDictionary( _
                     Function(xx) xx.Value.Split(":")(0), Function(xx) xx.Value.Split(":")(1))).ToArray)
    End Sub
End Class