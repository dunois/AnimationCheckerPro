Imports System.Net
Imports System.IO
Imports System.Text
Imports System.Text.RegularExpressions

Public Class TestForm
    Public testtime As Integer
    Dim TodayDate = Weekday(My.Computer.Clock.LocalTime)
    Public Title As String
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
    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        '//그리드의 선택영역 변경시 자막리스트를 불러옴 상세한부분은 위와 동일 
        Dim Source As String
        Try
            With DataGridView1.SelectedRows(0).DataBoundItem
                Using Web As New Net.WebClient
                    Source = Encoding.UTF8.GetString(Web.DownloadData("http://www.anissia.net/anitime/cap?i=" & .고유번호))
                End Using
                Dim J = New JSON(Source)
                DataGridView2.DataSource = J.Select(Function(x) New SubtList(x)).ToArray()
            End With
        Catch : End Try
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
        ReadOnly Property 종료일 As String
            Get
                With Source("ed")
                    If Source("ed") = "99999999" Then
                        Return "미정"
                    Else
                        Return DateAndTime.DateSerial(.Substring(0, 4), .Substring(4, 2), .Substring(6, 2))
                    End If

                End With
            End Get
        End Property
        Sub New(s As Dictionary(Of String, String))
            Source = s
        End Sub
    End Structure
    Structure SubtList
        Dim Source As Dictionary(Of String, String)
        ReadOnly Property 화수 As Object
            Get
                If IsNumeric(Source("s")) Then
                    Return Source("s") / 10
                Else
                    Return Source("s")
                End If
            End Get
        End Property
        ReadOnly Property 갱신일 As String
            Get
                With Source("d")
                    Return DateAndTime.DateSerial(.Substring(0, 4), .Substring(4, 2), .Substring(6, 2)) & " " & _
                    DateAndTime.TimeSerial(.Substring(8, 2), .Substring(10, 2), .Substring(12, 2))
                End With
            End Get
        End Property
        ReadOnly Property 주소 As String
            Get
                Return "http://" & Source("a")
            End Get
        End Property
        ReadOnly Property 제작자 As String
            Get
                Return Source("n")
            End Get
        End Property
        Sub New(s As Dictionary(Of String, String))
            Source = s
        End Sub
    End Structure

    Private Sub TestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AnissiaAPIWeekComboBox.SelectedIndex = TodayDate - 1
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        Dim msg As String = String.Format("Row: {0}, Column: {1}", _
    DataGridView2.CurrentCell.RowIndex, _
    DataGridView2.CurrentCell.ColumnIndex)
        If DataGridView2.CurrentCell.ColumnIndex = 2 Then
            Process.Start(DataGridView2.CurrentCell.Value)
        End If
        MessageBox.Show(msg & " / " & DataGridView2.CurrentCell.Value, "Current Cell")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try
            Dim rq = Net.WebRequest.Create("http://dnsoft.me/ACPData/ACData1410/aiten.png")
            rq.Timeout = 5000
            rq.GetResponse()
        Catch ex As Exception
            MsgBox("ex code : " & ex.HResult & " / ex massage : " & ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Today As Date = Date.Now
        Dim Month As String = ""
        If Today.ToString("MM") = "01" Or Today.ToString("MM") = "02" Or Today.ToString("MM") = "03" Then
            Month = "01"
        ElseIf Today.ToString("MM") = "04" Or Today.ToString("MM") = "05" Or Today.ToString("MM") = "06" Then
            Month = "04"
        ElseIf Today.ToString("MM") = "07" Or Today.ToString("MM") = "08" Or Today.ToString("MM") = "09" Then
            Month = "07"
        ElseIf Today.ToString("MM") = "10" Or Today.ToString("MM") = "11" Or Today.ToString("MM") = "12" Then
            Month = "10"
        End If
        MsgBox("get " & Today.ToString("yy") & Month & "List")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim ImgDownloadProgressBar As New ProgressBar
        ImgDownloadProgressBar.Location = New System.Drawing.Point(852, 360)
        ImgDownloadProgressBar.Size = New System.Drawing.Size(248, 18)
        ImgDownloadProgressBar.Visible = True
    End Sub
End Class

Public Class JSON
    Inherits List(Of Dictionary(Of String, String))
    Sub New(s As String)
        On Error Resume Next
        AddRange(Regex.Matches(s, "{.*?}").OfType(Of Match).Select( _
        Function(x) Regex.Matches(x.Value, "((""[^""]+"")|[^,{}]+):((""[^""]+"")|[^,{}]+)").OfType(Of Match).Select( _
        Function(xx) xx.Value.Replace("""", "")).ToDictionary( _
        Function(xx) xx.Split(":")(0), Function(xx) xx.Split(":")(1))).ToArray)
    End Sub
End Class