Imports System.Net
Imports System.IO
Imports Microsoft.Win32

Public Class MainForm

    Public ACDataFolder As String = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData
    Dim ProjectLoadingFaild As Boolean = False
    Public Version As Double = 1.342
    Dim REG As RegistryKey = Registry.LocalMachine
    Public UserBrowser As String
    Dim RegStorage As String = "Software\\Dunois Soft\\Animation Checker Pro"
    Dim CloseCheck As Boolean = False
    Dim HideCheck As Boolean = False
    Dim getUserBrowser As String
    Public WeekdayName As String
    Dim TodayDate = Weekday(My.Computer.Clock.LocalTime)
    Dim ResizeMode As Boolean = False
    Dim LoadResize As Integer = 0
    Public LoadedListStatus As Integer = 0
    Dim NoticeNumber As Integer = 1
    Dim getNoticeLink As String
    Dim getNoticeLinked As Integer
    Dim ScreenNotSupport As Boolean = False
    Dim SystemTrayed As Boolean = False
    Public ProgramMode As Integer = 0
    Dim ErrorStatuse As Boolean = False
    Public Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    Dim bCreated As Boolean
    Dim mtx As New System.Threading.Mutex(True, "AnimationCheckerPro.exe", bCreated)
    Public NTStatus As String = "LOADING"
    Public TTStatus As String = "LOADING"
    Public GStatus As String = "LOAIDNG"
    Public NTTime As Double
    Public TTTime As Double
    Public GTime As Double
    Public PingTestStatus = 0
    Public SearchLink As String = ""
    Public SubLink As String = ""
    Dim ImageUrl As String = ""
    '필요 구분 선언
    Public Function INIRead(ByVal Session As String, ByVal KeyValue As String, ByVal INIFILE As String) As String
        Dim s As New String("", 1024)
        Dim ReturnValue As Long
        ReturnValue = GetPrivateProfileString(Session, KeyValue, "", s, 1024, INIFILE)
        Return Mid(s, 1, InStr(s, Chr(0)) - 1)

    End Function
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
                    DownloadProgressBar.Value = Math.Round(GetFileStream.Length) / Math.Round(TotalSize) * 100
                    DownloadStatusLabel.Text = FileType & "를 다운로드 중입니다." & "(" & _
                    Math.Round(GetFileStream.Length / 1024 ^ 2, 2) & "MB / " & Math.Round(TotalSize / 1024 ^ 2, 2) & "MB)"
                    '//초당 킬로바이트수가 어느정도 크기를 넘으면 MB로 표시한다.
                    If (GetFileStream.Length / TMP / 1024) > 850 Then
                        DownSpeedLabel.Text = Format(((GetFileStream.Length / TMP / 1024) / 1024), "#0.##") & " MB/sec"
                    Else
                        DownSpeedLabel.Text = Format(((GetFileStream.Length / TMP / 1024) / 1024), "#0.##") & " KB/sec"
                    End If
                Loop
                DownloadStatusLabel.Text = FileType & "다운로드 완료"

            Catch ex As Exception
                MsgBox("", MsgBoxStyle.OkOnly, "")
                End
            End Try
            GetFileStream.Close()
            MyThisStream.Close()
            ThisResponese.Close()
            DownloadProgressBar.Value = 100
        Catch ex As Exception
            ErrorStatuse = True
            MsgBox("필수 구성요소(" & FileType & ") 다운로드 실패!" & Chr(10) & "인터넷 문제일수 있습니다. 이 문제가 계속되면 tarry403@gmail.com 으로 메일을 보내주세요", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "오류")
            ErrorCloseButton.Visible = True
        End Try
    End Sub
    Public Sub ACConfigDownLoad()
        If My.Computer.FileSystem.FileExists(ACDataFolder & "\Config.ini") Then
            My.Computer.FileSystem.DeleteFile(ACDataFolder & "\Config.ini")
        End If
        Try
            My.Computer.Network.DownloadFile("http://gkskvhtm403.cafe24.com/ACPData/SystemConfig.ini", ACDataFolder & "\Config.ini")
        Catch ex As Exception
            MsgBox("다운로드에 실패하였습니다! 인터넷 문제일수있습니다.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "오류")
            DownloadStatusLabel.Text = "다운로드 오류"
            DownSpeedLabel.Text = "다운로드 오류"
            ErrorStatuse = True
            ErrorCloseButton.Visible = True
            End
        End Try
    End Sub
    Public Sub UpdaterProcess()
        Dim regkey As RegistryKey = REG.OpenSubKey(RegStorage, True)
        Dim UpdaterVersion As Double = regkey.GetValue("UpdaterVersion", 0)
        Dim InternalUpdaterVersion As Double = INIRead("System", "UpdaterVersion", ACDataFolder & "\Config.ini")
        If My.Computer.FileSystem.FileExists(ACDataFolder & "\ACPUpdater.exe") Then

        Else
            GetFileFromUrl("http://gkskvhtm403.cafe24.com/ACPData/ACPUpdater.exe", ACDataFolder & "\ACPUpdater.exe", "Updater")
        End If
        If UpdaterVersion < InternalUpdaterVersion Then
            My.Computer.FileSystem.DeleteFile(ACDataFolder & "\ACPUpdater.exe")
            GetFileFromUrl("http://gkskvhtm403.cafe24.com/ACPData/ACPUpdater.exe", ACDataFolder & "\ACPUpdater.exe", "Updater")
            regkey.SetValue("UpdaterVersion", InternalUpdaterVersion, RegistryValueKind.String)
        End If
    End Sub
    Public Sub VersionCheck()
        Dim getVersion As Double = INIRead("System", "Version", ACDataFolder & "\Config.ini")
        If Command() = "noupdate" Then
            MsgBox("Alert! Command 'noupdate' is detected Program will not run update process" & Chr(10) & "Program Current Version : " & Version & " / Internal Version : " & getVersion, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        Else
            If getVersion > Version Then
                Dim regkey As RegistryKey = REG.OpenSubKey(RegStorage, True)
                If regkey.GetValue("Update Status") Is Nothing Then
                    regkey.SetValue("Update Status", 1, RegistryValueKind.String)
                End If
                regkey.SetValue("Update Status", 1, RegistryValueKind.String)
                Shell(ACDataFolder & "\ACPUpdater.exe", AppWinStyle.NormalFocus)
                End
            Else

            End If
        End If
    End Sub
    Public Sub FactorCheck()
        Dim regkey As RegistryKey = REG.OpenSubKey(RegStorage, True)
        Dim getSkinDeleteCheck As Integer = regkey.GetValue("SkinDelete", 0)
        If getSkinDeleteCheck = 1 Then
            My.Computer.FileSystem.DeleteDirectory(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Skin", FileIO.DeleteDirectoryOption.DeleteAllContents)
            regkey.SetValue("SkinDelete", 0, RegistryValueKind.String)
        Else

        End If
        If My.Computer.FileSystem.FileExists(ACDataFolder & "\SkinList.ini") Then
            My.Computer.FileSystem.DeleteFile(ACDataFolder & "\SkinList.ini")
        End If
        GetFileFromUrl("http://dnsoft.me/ACPData/ACPSkinList.ini", ACDataFolder & "\SkinList.ini", "SkinList")
        If My.Computer.FileSystem.DirectoryExists(ACDataFolder & "\Skin") Then

        Else
            My.Computer.FileSystem.CreateDirectory(ACDataFolder & "\Skin")
        End If
    End Sub
    Public Sub ListDownload(ByVal ListType)
        If ListType = "OldList" Then
            GetFileFromUrl("http://dnsoft.me/ACPData/OLAnimationCheckerProList.rev.ini", ACDataFolder & "\AnimationCheckerProList.ini", "AnimationList")
        ElseIf ListType = "ProList" Then
            GetFileFromUrl("http://dnsoft.me/ACPData/AnimationCheckerProList.rev.ini", ACDataFolder & "\AnimationCheckerProList.ini", "AnimationList")
        End If
    End Sub
    Public Sub ACListDownload()
        Dim regkey As RegistryKey = REG.OpenSubKey(RegStorage & "\\List", True)
        Dim getDoubleListCheck As Integer = INIRead("System", "DoubleList", ACDataFolder & "\Config.ini")
        Dim getACPMonth As String = INIRead("System", "ProList", ACDataFolder & "\Config.ini")
        Dim getOlAMonth As String = INIRead("System", "OldList", ACDataFolder & "\Config.ini")
        Dim getOldListCheck As Integer = regkey.GetValue("OldListCheck", 0)
        If My.Computer.FileSystem.FileExists(ACDataFolder & "\AnimationCheckerProList.ini") Then
            My.Computer.FileSystem.DeleteFile(ACDataFolder & "\AnimationCheckerProList.ini")
        Else

        End If
        If getOldListCheck = 1 Then '구작리스트 확인 안함
            ListDownload("ProList")
        Else
            If getDoubleListCheck = 1 Then
                Dim DoubleListCheck = MsgBox("서버에 " & getACPMonth & " 리스트와 " & getOlAMonth & " 리스트가 있습니다." & Chr(10) & getOlAMonth & " 이전 분기 리스트를 불러오시겠습니까?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "확인")
                If DoubleListCheck = vbYes Then
                    ListDownload("OldList")
                Else
                    ListDownload("ProList")
                End If
            Else
                ListDownload("ProList")
            End If
        End If
    End Sub
    Public Sub SettingApply()
        Dim SystemSet As RegistryKey = REG.OpenSubKey(RegStorage & "\System", True)
        Dim SkinSet As RegistryKey = REG.OpenSubKey(RegStorage & "\\Skin")
        Dim getMode As Integer = SystemSet.GetValue("ModeType", 1)
        Dim getButtonAct As Integer = SystemSet.GetValue("ButtonActSet", 0)
        Dim SkinUseCheck As Integer = SystemSet.GetValue("SkinUse", 0)
        Dim ImageMode As Integer = SystemSet.GetValue("ImageMode", 0)
        Dim ScreenWidth As String = Screen.PrimaryScreen.WorkingArea.Size.Width
        Dim ScreenHeight As String = Screen.PrimaryScreen.WorkingArea.Size.Height + 20
        MainPanel.Visible = True
        '스킨 적용 시작
        If SkinUseCheck = 1 Then
            Dim SkinLocation As String = SkinSet.GetValue("SkinLocation")
            If My.Computer.FileSystem.FileExists(SkinLocation) Then
                SkinPanel.BackgroundImage = Image.FromFile(SkinLocation)
            Else
                MsgBox("설정한 스킨이 존재하지 않습니다.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "오류")
            End If
        Else

        End If
        '스킨 적용 종료
        '이미지 모드 적용 시작
        If ImageMode = 1 Then
            StillCutPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        ElseIf ImageMode = 0 Then
            StillCutPictureBox.SizeMode = PictureBoxSizeMode.AutoSize
        End If
        '이미지 모드 적용 종료
        '프로그램 모드 적용 시작
        If getMode = 1 Then
            LoadResize = 1
            If ScreenWidth <= 1280 Or ScreenHeight <= 720 Then
                Me.Width = 310
                getMode = 0
                MsgBox("이 해상도는 지원하지 않으므로 확장모드를 사용할수없습니다.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "해상도 오류")
                ScreenNotSupport = True
                ProgramMode = 0
            Else
                Me.Width = 1370
                Me.CenterToScreen()
                If getButtonAct = 1 Then
                    SearchButton.Visible = False
                    SubLinkButton.Visible = False
                End If
                ProgramMode = 1
            End If
            LoadResize = 0
        ElseIf getMode = 0 Then
            Me.Width = 310
            LoadResize = 0
            ProgramMode = 0
        End If
        '프로그램 모드 적용 종료
        '트레이 모드 적용 시작
        Dim getTrayStatus As Integer = SystemSet.GetValue("SystemTrayType", 3)
        If getTrayStatus = 0 Then
            NotifyIcon.Visible = True
        End If
        '트레이 모드 적용 종료
    End Sub
    Public Sub ExtraWork()
        Dim regkey As RegistryKey = REG.OpenSubKey(RegStorage, True)
        If regkey.GetValue("Update Status", 0) = 1 Then
            If My.Computer.FileSystem.FileExists(ACDataFolder & "\Update.log") Then
                My.Computer.FileSystem.DeleteFile(ACDataFolder & "\Update.log")
            End If
            My.Computer.Network.DownloadFile("http://gkskvhtm403.cafe24.com/ACPData/Update.log", ACDataFolder & "\Update.log")
            UpdateCompleteForm.ShowDialog()
            regkey.SetValue("Update Status", 0, RegistryValueKind.String)
        End If

        Dim getCurrentNoticeType As String = regkey.GetValue("NoticeType", "None")
        Dim getNoticeType As String = INIRead("Notice", "ImpNoticeType", ACDataFolder & "\AnimationCheckerProList.ini")
        If getCurrentNoticeType = getNoticeType = False Then
            ImportantNotice.ShowDialog()
        Else

        End If
        Dim SystemSet As RegistryKey = REG.OpenSubKey(RegStorage & "\\System", True)
        Dim NoticeRecvCheck As Integer = SystemSet.GetValue("NoticeReceive", 0)
        If NoticeRecvCheck = 0 Then
            If My.Computer.FileSystem.FileExists(ACDataFolder & "\Notice.ini") Then
                My.Computer.FileSystem.DeleteFile(ACDataFolder & "\Notice.ini")
            End If
            Try
                My.Computer.Network.DownloadFile("http://gkskvhtm403.cafe24.com/ACPData/Notice.ini", ACDataFolder & "\Notice.ini")
                NoticeTimer.Enabled = True
                NoticeTimer.Interval = 5000
            Catch ex As Exception
                MsgBox("다운로드에 실패하였습니다! 인터넷 문제일수있습니다.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "오류")
                DownloadStatusLabel.Text = "다운로드 오류"
                DownSpeedLabel.Text = "다운로드 오류"
                ErrorStatuse = True
                ErrorCloseButton.Visible = True
            End Try
        Else
            NoticeLabel.Text = ""
        End If
        WeekComboBox.SelectedIndex = TodayDate - 1
    End Sub
    Public Sub Listloading()
        Dim getWeekdayName As Integer = WeekComboBox.SelectedIndex + 1
        If getWeekdayName = 1 Then
            WeekdayName = "Sunday"
        ElseIf getWeekdayName = 2 Then
            WeekdayName = "Monday"
        ElseIf getWeekdayName = 3 Then
            WeekdayName = "Tuesday"
        ElseIf getWeekdayName = 4 Then
            WeekdayName = "Wednesday"
        ElseIf getWeekdayName = 5 Then
            WeekdayName = "Thursday"
        ElseIf getWeekdayName = 6 Then
            WeekdayName = "Friday"
        ElseIf getWeekdayName = 7 Then
            WeekdayName = "Saturday"
        End If
        Dim getWeekNumber As Integer = INIRead(WeekdayName, "Number", ACDataFolder & "\AnimationCheckerProList.ini")
        For i As Integer = 1 To getWeekNumber
            Dim getName As String = INIRead(WeekdayName, "Ani" & i & "Name", ACDataFolder & "\AnimationCheckerProList.ini")
            If getName = "" Then
                MsgBox("리스트를 불러오는 도중 오류가 발생하였습니다." & Chr(10) & "오류코드 : L.READ.LOAD_D" & getWeekdayName & "_N" & i & Chr(10) & "문제가 계속되면 tarry403@gmail.com 으로 오류코드를 전송해주시면 빠르게 해결하겠습니다.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "오류")
            Else
                Dim getCancelStatus As Integer = INIRead(WeekdayName, "Ani" & i & "CancelStatus", ACDataFolder & "\AnimationCheckerProList.ini")
                If getCancelStatus = 1 Then
                    AnimationListBox.Items.Add("[결방] " & getName)
                Else
                    AnimationListBox.Items.Add(getName)
                End If
            End If
        Next
    End Sub
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not bCreated Then '뮤텍스가 정상적으로 생성되지 않았으면 같은 이름의 뮤텍스가 있는것으로 판단
            MsgBox("프로그램이 이미 실행중입니다!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "오류")
            Application.ExitThread()
            End
        Else
            If REG.OpenSubKey(RegStorage) Is Nothing Then
                REG.CreateSubKey(RegStorage)
            End If
            If REG.OpenSubKey(RegStorage & "\\System") Is Nothing Then
                REG.CreateSubKey(RegStorage & "\\System")
            End If
            If REG.OpenSubKey(RegStorage & "\\List") Is Nothing Then
                REG.CreateSubKey(RegStorage & "\\List")
            End If
            If REG.OpenSubKey(RegStorage & "\\Search") Is Nothing Then
                REG.CreateSubKey(RegStorage & "\\Search")
            End If
            If REG.OpenSubKey(RegStorage & "\\Skin\\Download") Is Nothing Then
                REG.CreateSubKey(RegStorage & "\\Skin\\Download")
            End If
            Dim regkey As RegistryKey = REG.OpenSubKey(RegStorage, True)
            regkey.SetValue("CurrentProgramVersion", Version, RegistryValueKind.String)
            regkey.SetValue("Location", My.Application.Info.DirectoryPath & "\")
            FormLoadCompleteTimer.Enabled = True
            Me.StartPosition = FormStartPosition.CenterScreen
        End If
    End Sub
    Private Sub FormLoadCompleteTimer_Tick(sender As Object, e As EventArgs) Handles FormLoadCompleteTimer.Tick
        FormLoadCompleteTimer.Enabled = False
        For i As Integer = 1 To 8
            ProjectLoading(i)
        Next
    End Sub
    Public Sub WebReachTest(ByVal Website As String, ByVal Type As String)

    End Sub
    Public Sub ProjectLoading(ByVal Stage As Integer)
        Application.DoEvents()
        If ErrorStatuse = False Then
            If Stage = 1 Then
                ACConfigDownLoad()
            ElseIf Stage = 2 Then
                UpdaterProcess()
            ElseIf Stage = 3 Then
                VersionCheck()
            ElseIf Stage = 4 Then
                FactorCheck()
            ElseIf Stage = 5 Then
                ACListDownload()
            ElseIf Stage = 6 Then
                SettingApply()
            ElseIf Stage = 7 Then
                ExtraWork()
            ElseIf Stage = 8 Then
                'Listloading()
                PingBackgroundWorker.RunWorkerAsync()
            End If
        Else
            MsgBox("에러코드 : " & Stage & Chr(10) & "문제가 계속되면 tarry403@gmail.com 으로 연락주시기 바랍니다.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "오류")
            End
        End If
    End Sub
    Private Sub ErrorCloseButton_Click(sender As Object, e As EventArgs) Handles ErrorCloseButton.Click
        End
    End Sub
    Public Sub ModeApply()
        Dim regkey As RegistryKey = REG.OpenSubKey(RegStorage & "\\System")
        Dim getMode As Integer = regkey.GetValue("ModeType", "1")
        If ScreenNotSupport = True Then
            ResizeMode = True
            Me.Width = 310
            ResizeMode = False
        Else
            If getMode = 1 Then
                ResizeMode = True
                Me.Width = 1370
                ResizeMode = False
            ElseIf getMode = 0 Then
                ResizeMode = True
                Me.Width = 310
                ResizeMode = False
            End If
        End If
    End Sub
    Public Sub AniListReading(ByVal Type As String)
        Dim getSelectedItem As Integer = AnimationListBox.SelectedIndex + 1
        Dim SystemSet As RegistryKey = REG.OpenSubKey(RegStorage & "\\System", True)
        Dim getImgFilter As Integer = SystemSet.GetValue("ImageFiltering", 0)
        If Type = "t,img" Then
            StillCutPictureBox.Image = Nothing
            StillCutPictureBox.Width = 910
            StillCutPictureBox.Height = 420
            ImageErrorLabel.Visible = False
            Dim getTime As String = INIRead(WeekdayName, "Ani" & getSelectedItem & "Time", ACDataFolder & "\AnimationCheckerProList.ini")
            Dim getImageType As Integer = INIRead(WeekdayName, "Ani" & getSelectedItem & "PictureType", ACDataFolder & "\AnimationCheckerProList.ini")
            Dim getImageUrl As String = INIRead(WeekdayName, "Ani" & getSelectedItem & "PictureUrl", ACDataFolder & "\AnimationCheckerProList.ini")
            Dim getImageFilterRate As String = INIRead(WeekdayName, "Ani" & getSelectedItem & "PictureRate", ACDataFolder & "\AnimationCheckerProList.ini")
            If getImageType = 0 Then
                ImageUrl = "http://gkskvhtm403.cafe24.com/" & getImageUrl
            End If
            If getImgFilter = 1 Then
                If getImageFilterRate = "1" Then
                    ImageShowButton.Visible = True
                Else
                    ImageShowButton.Visible = False
                    ImageGet()
                End If
            Else
                ImageGet()
            End If
            OnAirTimeLabel.Text = getTime
        ElseIf Type = "sub" Then
            Dim getSubNumber As Integer = INIRead(WeekdayName, "Ani" & getSelectedItem & "SubNumber", ACDataFolder & "\AnimationCheckerProList.ini")
            If getSubNumber = 0 Then
                SubListBox.Items.Add("등록된 자막 제작자가 없습니다.")
            Else
                For i As Integer = 1 To getSubNumber
                    Dim getSubName As String = INIRead(WeekdayName, "Ani" & getSelectedItem & "Sub" & i & "Name", ACDataFolder & "\AnimationCheckerProList.ini")
                    If getSubName = "" Then
                        MsgBox("리스트를 불러오는 도중 오류가 발생하였습니다." & Chr(10) & "오류코드 : L.READ.LOAD_IN" & getSelectedItem & "_SN" & i & Chr(10) & "문제가 계속되면 tarry403@gmail.com 으로 오류코드를 전송해주시면 빠르게 해결하겠습니다.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "오류")
                    Else
                        SubListBox.Items.Add(getSubName)
                    End If
                Next
            End If
        ElseIf Type = "search" Then
            Dim getDN As Integer = WeekComboBox.SelectedIndex + 1
            Dim getSearchNumber As Integer = INIRead(WeekdayName, "Ani" & getSelectedItem & "SearchNumber", ACDataFolder & "\AnimationCheckerProList.ini")
            If getSearchNumber = 0 Then
                SearchListBox.Items.Add("항목이 없습니다.")
            Else
                For i As Integer = 1 To getSearchNumber
                    Dim GetSearchName As String = INIRead(WeekdayName, "Ani" & getSelectedItem & "Search" & i & "Name", ACDataFolder & "\AnimationCheckerProList.ini")
                    If GetSearchName = "" Then
                        MsgBox("리스트를 불러오는 도중 오류가 발생하였습니다." & Chr(10) & "오류코드 : L.READ.LOAD_DN" & getDN & "_IN" & getSelectedItem & "_TN" & i & Chr(10) & "문제가 계속되면 tarry403@gmail.com 으로 오류코드를 전송해주시면 빠르게 해결하겠습니다.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "오류")
                    Else
                        Dim getSearchType As Integer = INIRead(WeekdayName, "Ani" & getSelectedItem & "Search" & i & "Type", ACDataFolder & "\AnimationCheckerProList.ini")
                        If getSearchType = 0 Then
                            SearchListBox.Items.Add(GetSearchName & " (접속상태 : " & NTStatus & ")")
                        ElseIf getSearchType = 1 Then
                            SearchListBox.Items.Add(GetSearchName & " (접속상태 : " & TTStatus & ")")
                        Else
                            SearchListBox.Items.Add(GetSearchName)
                        End If
                    End If
                Next
            End If
        End If
    End Sub
    Private Sub ImageGet()
        Try
            Dim rq = Net.WebRequest.Create(ImageUrl)
            rq.Timeout = 5000
            rq.GetResponse()
            ImageErrorLabel.Visible = False
            StillCutPictureBox.ImageLocation = ImageUrl
            StillCutHideButton.Enabled = True
            ShowLargeImageButton.Enabled = True
            rq.Abort()
        Catch ex As Exception
            ImageErrorLabel.Visible = True
            StillCutHideButton.Enabled = False
            ShowLargeImageButton.Enabled = False
        End Try
    End Sub
    Private Sub AnimationListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AnimationListBox.SelectedIndexChanged
        If AnimationListBox.SelectedIndex = -1 Then
            SearchListBox.Items.Clear()
            SubListBox.Items.Clear()
            SearchListBox.Items.Add("애니메이션을 선택하세요")
            SubListBox.Items.Add("애니메이션을 선택하세요")
            NameLabel.Text = "애니메이션을 선택하세요"
        Else
            SearchListBox.Items.Clear()
            SubListBox.Items.Clear()
            SearchButton.Enabled = False
            SubLinkButton.Enabled = False
            NameLabel.Text = AnimationListBox.SelectedItem
            ModeApply()
            AniListReading("t,img")
            AniListReading("sub")
            AniListReading("search")
        End If
    End Sub
    Private Sub WeekComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles WeekComboBox.SelectedIndexChanged
        AnimationListBox.Items.Clear()
        SubListBox.Items.Clear()
        SearchListBox.Items.Clear()
        SubListBox.Items.Add("애니메이션을 선택하세요")
        SearchListBox.Items.Add("애니메이션을 선택하세요")
        NameLabel.Text = "애니메이션을 선택하세요"
        SearchButton.Enabled = False
        SubLinkButton.Enabled = False
        Listloading()
    End Sub

    Private Sub MiniModeButton_Click(sender As Object, e As EventArgs) Handles MiniModeButton.Click
        If Me.Width = 1370 Then
            ResizeMode = True
            Me.Width = 310
            ResizeMode = False
        End If
    End Sub
    Public Sub GetSearchLink()
        Dim regkey As RegistryKey = REG.OpenSubKey(RegStorage & "\\Search")
        If SearchListBox.SelectedIndex = -1 Or SearchListBox.SelectedItem.ToString = "애니메이션을 선택하세요" Or SearchListBox.SelectedItem.ToString = "항목이 없습니다." Then

        Else
            Dim getSelectedListItem As Integer = AnimationListBox.SelectedIndex + 1
            Dim getSelectedSearchItem As Integer = SearchListBox.SelectedIndex + 1
            Dim getSearchEngineType As Integer = INIRead(WeekdayName, "Ani" & getSelectedListItem & "Search" & getSelectedSearchItem & "Type", ACDataFolder & "\AnimationCheckerProList.ini")
            If getSearchEngineType = 0 Then 'NT
                Dim getString As String = INIRead(WeekdayName, "Ani" & getSelectedListItem & "Search" & getSelectedSearchItem & "String", ACDataFolder & "\AnimationCheckerProList.ini")
                Dim getSearchCat As String = regkey.GetValue("SearchCat", "1_11")
                Dim getSearchFilter As String = regkey.GetValue("SearchFilter", "0")
                Dim SearchEngine As String = "http://www.nyaa.se/?page=search&cats="
                SearchLink = SearchEngine & getSearchCat & "&filter=" & getSearchFilter & "&term=" & getString
            ElseIf getSearchEngineType = 1 Then 'TT
                Dim getString As String = INIRead(WeekdayName, "Ani" & getSelectedListItem & "Search" & getSelectedSearchItem & "String", ACDataFolder & "\AnimationCheckerProList.ini")
                Dim getSearchCat As String = regkey.GetValue("TTSearchCat", 0)
                Dim getMaxSize As String = regkey.GetValue("TTMaxSize", "")
                Dim getMinSize As String = regkey.GetValue("TTMinSize", "")
                Dim getSubmitter As String = regkey.GetValue("TTSubmitter", "")
                Dim SearchEngine As String = "http://tokyotosho.info/search.php?terms="
                SearchLink = SearchEngine & getString & "&type=" & getSearchCat & "&size_min=" & getMinSize & "&size_max=" & getMaxSize & "&username=" & getSubmitter
            ElseIf getSearchEngineType = 2 Then 'Leopard
                Dim getString As String = INIRead(WeekdayName, "Ani" & getSelectedListItem & "Search" & getSelectedSearchItem & "String", ACDataFolder & "\AnimationCheckerProList.ini")
                Dim SearchEngine As String = "http://leopard-raws.org/index.php?search="
                SearchLink = SearchEngine & getString
            ElseIf getSearchEngineType = 3 Then 'Costom
                Dim getString As String = INIRead(WeekdayName, "Ani" & getSelectedListItem & "Search" & getSelectedSearchItem & "String", ACDataFolder & "\AnimationCheckerProList.ini")
                SearchLink = getString
            End If
        End If
    End Sub
    Public Sub GetSubLink()
        If SubListBox.SelectedIndex = -1 Or SubListBox.SelectedItem.ToString = "애니메이션을 선택하세요" Or SubListBox.SelectedItem.ToString = "등록된 자막 제작자가 없습니다." Then

        Else
            Dim getSelectedListItem As Integer = AnimationListBox.SelectedIndex + 1
            Dim getSelectedSubItem As Integer = SubListBox.SelectedIndex + 1
            SubLink = INIRead(WeekdayName, "Ani" & getSelectedListItem & "Sub" & getSelectedSubItem & "Url", ACDataFolder & "\AnimationCheckerProList.ini")
        End If
    End Sub
    Private Sub SearchListBox_DoubleClick(sender As Object, e As EventArgs) Handles SearchListBox.DoubleClick
        If SearchListBox.SelectedIndex = -1 Or SearchListBox.SelectedItem = "애니메이션을 선택하세요" Or SearchListBox.SelectedItem = "항목이 없습니다." Then

        Else
            Dim regkey As RegistryKey = REG.OpenSubKey(RegStorage & "\\System")
            Dim getButtonAct As Integer = regkey.GetValue("ButtonActSet", 0)
            If ProgramMode = 0 Or getButtonAct = 1 Then
                GetSearchLink()
                Process.Start(SearchLink)
            Else

            End If
        End If
    End Sub

    Private Sub SubListBox_DoubleClick(sender As Object, e As EventArgs) Handles SubListBox.DoubleClick
        If SubListBox.SelectedIndex = -1 Or SubListBox.SelectedItem = "애니메이션을 선택하세요" Or SubListBox.SelectedItem = "등록된 자막 제작자가 없습니다." Then

        Else
            Dim regkey As RegistryKey = REG.OpenSubKey(RegStorage & "\\System")
            Dim getButtonAct As Integer = regkey.GetValue("ButtonActSet", 0)
            If ProgramMode = 0 Or getButtonAct = 1 Then
                GetSubLink()
                Process.Start(SubLink)
            Else

            End If
        End If
    End Sub

    Private Sub StillCutHideButton_Click(sender As Object, e As EventArgs) Handles StillCutHideButton.Click
        If StillCutPictureBox.Visible = True Then
            StillCutPictureBox.Visible = False
            StillCutHideButton.Text = "사진 보이기"
        Else
            StillCutPictureBox.Visible = True
            StillCutHideButton.Text = "사진 숨기기"
        End If
    End Sub

    Private Sub SearchListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SearchListBox.SelectedIndexChanged
        If ProgramMode = 1 Then
            If SearchListBox.SelectedIndex = -1 Or SearchListBox.SelectedItem = "항목이 없습니다." Or SearchListBox.SelectedItem = "애니메이션을 선택하세요" Then
                SearchButton.Enabled = False
            Else
                SearchButton.Enabled = True
            End If
        Else

        End If
    End Sub

    Private Sub SubListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SubListBox.SelectedIndexChanged
        If ProgramMode = 1 Then
            If SubListBox.SelectedIndex = -1 Or SubListBox.SelectedItem = "등록된 자막 제작자가 없습니다." Or SubListBox.SelectedItem = "애니메이션을 선택하세요" Then
                SubLinkButton.Enabled = False
            Else
                SubLinkButton.Enabled = True
            End If
        Else

        End If
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        If SearchListBox.SelectedIndex = -1 Or SearchListBox.SelectedItem.ToString = "애니메이션을 선택하세요" Or SearchListBox.SelectedItem.ToString = "항목이 없습니다." Then

        Else
            GetSearchLink()
            Process.Start(SearchLink)
        End If
    End Sub

    Private Sub SubLinkButton_Click(sender As Object, e As EventArgs) Handles SubLinkButton.Click
        If SubListBox.SelectedIndex = -1 Or SubListBox.SelectedItem.ToString = "애니메이션을 선택하세요" Or SubListBox.SelectedItem.ToString = "등록된 자막 제작자가 없습니다." Then

        Else
            GetSubLink()
            Process.Start(SubLink)
        End If
    End Sub

    Private Sub ShowLargeImageButton_Click(sender As Object, e As EventArgs) Handles ShowLargeImageButton.Click
        Dim getSelectedItem As Integer = AnimationListBox.SelectedIndex + 1
        Dim getImageType As Integer = INIRead(WeekdayName, "Ani" & getSelectedItem & "PictureType", ACDataFolder & "\AnimationCheckerProList.ini")
        Dim getImageUrl As String = INIRead(WeekdayName, "Ani" & getSelectedItem & "PictureUrl", ACDataFolder & "\AnimationCheckerProList.ini")
        Dim FinalUrl As String = ""
        If getImageType = 0 Then
            FinalUrl = "http://gkskvhtm403.cafe24.com/" & getImageUrl
        End If
        LargeImageForm.LargePictureBox.ImageLocation = FinalUrl
        LargeImageForm.ShowDialog()
    End Sub

    Private Sub ProgramConfigButton_Click(sender As Object, e As EventArgs) Handles ProgramConfigButton.Click
        ProgramOption.ShowDialog()
    End Sub

    Private Sub ProgramInformationButton_Click(sender As Object, e As EventArgs) Handles ProgramInformationButton.Click
        ProgramInformation.ShowDialog()
    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim regkey As RegistryKey = REG.OpenSubKey(RegStorage & "\\System")
        Dim getCloseTray As Integer = regkey.GetValue("SystemTrayType", 3)
        Dim getCloseAlert As Integer = regkey.GetValue("CloseAlert", 0)
        If getCloseTray = 2 Then
            If CloseCheck = True Then

            Else
                Me.Hide()
                HideCheck = True
                e.Cancel = True
                NotifyIcon.Visible = True
            End If
        Else
            If getCloseAlert = 0 Then
                Dim CloseAlertMsg = MsgBox("정말로 종료하시겠습니까?" & Chr(10) & "(이 설정은 옵션 - 프로그램 설정 에서 설정할수있습니다.)", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "확인")
                If CloseAlertMsg = vbYes Then

                Else
                    e.Cancel = True
                End If
            Else

            End If
        End If
    End Sub

    Private Sub CloseContextMenu_Click(sender As Object, e As EventArgs) Handles CloseContextMenu.Click
        If HideCheck = True Then
            CloseCheck = True
            Me.Close()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub NotifyIcon_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon.MouseDoubleClick
        If HideCheck = True Then
            HideCheck = False
            NotifyIcon.Visible = False
            Me.Show()
            Me.WindowState = FormWindowState.Normal
        Else

        End If
    End Sub

    Private Sub MainForm_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If REG.OpenSubKey(RegStorage & "\\System") Is Nothing Then
            REG.CreateSubKey(RegStorage & "\\System")
        Else

        End If
        Dim regkey As RegistryKey = REG.OpenSubKey(RegStorage & "\\System")
        Dim getMinimumTray As Integer = regkey.GetValue("SystemTrayType", 3)
        If getMinimumTray = 1 Then
            If SystemTrayed = False And ResizeMode = False And LoadResize = 0 Then
                Me.Hide()
                SystemTrayed = True
                HideCheck = True
                NotifyIcon.Visible = True
            ElseIf SystemTrayed = True Then
                Me.Show()
                SystemTrayed = False
                HideCheck = False
                NotifyIcon.Visible = False
            End If
        End If
    End Sub

    Private Sub OptionMenu_Click(sender As Object, e As EventArgs) Handles OptionMenu.Click
        If HideCheck = True Then
            Me.Show()
            Me.WindowState = FormWindowState.Normal
            ProgramOption.ShowDialog()
            HideCheck = False
            NotifyIcon.Visible = False
        Else
            ProgramOption.ShowDialog()
        End If
    End Sub

    Private Sub ProgramInfoButton_Click(sender As Object, e As EventArgs) Handles ProgramInfoButton.Click
        If HideCheck = True Then
            Me.Show()
            Me.WindowState = FormWindowState.Normal
            ProgramInformation.ShowDialog()
            HideCheck = False
            NotifyIcon.Visible = False
        Else
            ProgramInformation.ShowDialog()
        End If
    End Sub

    Private Sub OpenContextMenu_Click(sender As Object, e As EventArgs) Handles OpenContextMenu.Click
        Me.Show()
    End Sub

    Private Sub NoticeTimer_Tick(sender As Object, e As EventArgs) Handles NoticeTimer.Tick
        Dim getNoticeNumber As Integer = INIRead("Notice", "Number", ACDataFolder & "\Notice.ini")
        If getNoticeNumber = 0 Then

        Else
            getNoticeLinked = INIRead("Notice", "Notice" & NoticeNumber & "Linked", ACDataFolder & "\Notice.ini")
            If getNoticeLinked = 1 Then
                NoticeLabel.IsLink = True
            Else
                NoticeLabel.IsLink = False
            End If
            getNoticeLink = INIRead("Notice", "Notice" & NoticeNumber & "Link", ACDataFolder & "\Notice.ini")
            NoticeLabel.Text = INIRead("Notice", "Notice" & NoticeNumber, ACDataFolder & "\Notice.ini")
            If NoticeNumber = getNoticeNumber Then
                NoticeNumber = 1
            Else
                NoticeNumber = NoticeNumber + 1
            End If
        End If
    End Sub

    Private Sub NoticeLabel_Click(sender As Object, e As EventArgs) Handles NoticeLabel.Click
        If getNoticeLinked = 1 Then
            Shell(getUserBrowser & " " & getNoticeLink, AppWinStyle.NormalFocus)
        Else

        End If
    End Sub

    Private Sub SkinSetButton_Click(sender As Object, e As EventArgs) Handles SkinSetButton.Click
        SkinSettingForm.ShowDialog()

    End Sub

    Private Sub SkinDownloadButton_Click(sender As Object, e As EventArgs) Handles SkinDownloadButton.Click
        SkinDownloadForm.ShowDialog()

    End Sub

    Private Sub ManagementSkinButton_Click(sender As Object, e As EventArgs) Handles ManagementSkinButton.Click
        DownloadedSkinConfig.ShowDialog()

    End Sub
    Private Sub PingBackgroundWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles PingBackgroundWorker.DoWork
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
                rq.Timeout = 10000 '//5초이내 응답이없으면 실패로 간주 
                rq.GetResponse()
                If i = 1 Then
                    NTStatus = "접속성공"
                    NTTime = Timewatch.ElapsedMilliseconds / 1000
                ElseIf i = 2 Then
                    TTStatus = "접속성공"
                    TTTime = Timewatch.ElapsedMilliseconds / 1000
                ElseIf i = 3 Then
                    GStatus = "접속성공"
                    GTime = Timewatch.ElapsedMilliseconds / 1000
                End If
                Timewatch.Stop()
                Timewatch.Reset()
            Catch ex As Exception
                Dim ErrorMsg As String = ""
                If ex.Message = "작업 시간이 초과되었습니다." Then
                    ErrorMsg = "접속 실패"
                End If
                If i = 1 Then
                    NTStatus = ErrorMsg
                ElseIf i = 2 Then
                    TTStatus = ErrorMsg
                ElseIf i = 3 Then
                    GStatus = ErrorMsg
                End If
            End Try
        Next
        ProgramOption.ReTestButton.Enabled = True
    End Sub

    Private Sub TestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TestToolStripMenuItem.Click
        TestForm.ShowDialog()

    End Sub

    Private Sub ImageShowButton_Click(sender As Object, e As EventArgs) Handles ImageShowButton.Click
        ImageGet()
        ImageShowButton.Visible = False
    End Sub
End Class