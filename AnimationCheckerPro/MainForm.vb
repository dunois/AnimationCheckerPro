Imports System.Net
Imports System.IO

Public Class MainForm
    Public Version As Double = 1.43
    Public ACDataFolder As String = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData
    Public WeekdayName As String
    Public LoadedListStatus As Integer = 0
    Public Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    Public NTStatus As String = "LOADING"
    Public GStatus As String = "LOAIDNG"
    Public NTTime As Double
    Public GTime As Double
    Public PingTestStatus = 0
    Public SearchLink As String = ""
    Public SubLink As String = ""
    Public ListQuater As String = ""
    Public SettingFileLocation As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Dunois Software\AnimationCheckerPro\Settings.xml"
    Dim CloseToggleStatus As Boolean = False
    Dim ListDownloadError As Boolean = False
    Dim TodayDate = Weekday(My.Computer.Clock.LocalTime)
    Dim TimeInfo As Date = Date.Now
    Dim GetQMonth As String = ""
    Dim bCreated As Boolean
    Dim mtx As New System.Threading.Mutex(True, "AnimationCheckerPro.exe", bCreated)
    Dim SystemTrayed As Boolean = False
    Dim ErrorStatus As Boolean = False
    Dim LoadStageChecker As Boolean = True
    Dim ImageFile As System.IO.FileStream
    Dim ImageFileLocation As String

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
                    DownloadStatusLabel.Text = FileType & "를 다운로드 중입니다." & "(" &
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
                End
            End Try
            GetFileStream.Close()
            MyThisStream.Close()
            ThisResponese.Close()
            DownloadProgressBar.Value = 100
        Catch ex As Exception
            ErrorStatus = True
            MsgBox("필수 구성요소(" & FileType & ") 다운로드 실패!" & Chr(10) & "인터넷 문제일수 있습니다. 이 문제가 계속되면 tarry403@gmail.com 으로 메일을 보내주세요", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "오류")
            ErrorCloseButton.Visible = True
        End Try
    End Sub

    Public Sub ACConfigDownLoad()
        If My.Computer.FileSystem.FileExists(ACDataFolder & "\VersionInfo.ini") Then
            My.Computer.FileSystem.DeleteFile(ACDataFolder & "\VersionInfo.ini")
        End If
        Try
            My.Computer.Network.DownloadFile("http://dunois403.cafe24.com/ACPData/ACPVersion.ini", ACDataFolder & "\VersionInfo.ini")
        Catch ex As Exception
            MsgBox("버전 정보를 가져올 수 없습니다!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "오류")
            DownloadStatusLabel.Text = "다운로드 오류"
            DownSpeedLabel.Text = "다운로드 오류"
            ErrorStatus = True
            ErrorCloseButton.Visible = True
            End
        End Try
    End Sub
    Public Sub UpdaterProcess() 'XML
        Dim UpdaterVersion As String = XMLReader(SettingFileLocation, "System", "UpdaterVersion")
        Dim InternalUpdaterVersion As Double = INIRead("System", "UpdaterVersion", ACDataFolder & "\VersionInfo.ini")
        If My.Computer.FileSystem.FileExists(ACDataFolder & "\ACPUpdater.exe") = False Or UpdaterVersion = "Error" Then
            GetFileFromUrl("http://dunois403.cafe24.com/ACPData/ACPUpdater.exe", ACDataFolder & "\ACPUpdater.exe", "Updater")
            XMLWriter(SettingFileLocation, "System", "UpdaterVersion", InternalUpdaterVersion)
        Else
            If UpdaterVersion < InternalUpdaterVersion Then
                My.Computer.FileSystem.DeleteFile(ACDataFolder & "\ACPUpdater.exe")
                GetFileFromUrl("http://dunois403.cafe24.com/ACPData/ACPUpdater.exe", ACDataFolder & "\ACPUpdater.exe", "Updater")
                XMLWriter(SettingFileLocation, "System", "UpdaterVersion", InternalUpdaterVersion)
            End If
        End If
    End Sub
    Public Sub VersionCheck() 'XML
        Dim getVersion As Double = INIRead("System", "Version", ACDataFolder & "\VersionInfo.ini")
        If Command() = "noupdate" Or Command() = "debug" Then
            MsgBox("Alert! Command '" & Command() & "' is detected Program will not run update process" & Chr(10) & "Program Current Version : " & Version & " / Internal Version : " & getVersion, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        Else
            If getVersion > Version Then
                XMLWriter(SettingFileLocation, "System", "UpdateStatus", 1)
                Shell(ACDataFolder & "\ACPUpdater.exe " & Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Dunois Software\AnimationCheckerPro\", AppWinStyle.NormalFocus)
                End
            End If
        End If
    End Sub
    Public Sub ACListDownload()
        If My.Computer.FileSystem.FileExists(ACDataFolder & "\AnimationCheckerProList.ini") Then
            My.Computer.FileSystem.DeleteFile(ACDataFolder & "\AnimationCheckerProList.ini")
        End If
        getListQuater()
        Try
            Dim rq = Net.WebRequest.Create("http://dunois403.cafe24.com/ACPData/ACP" & ListQuater & ".rev.ini")
            rq.Timeout = 5000
            rq.GetResponse()
            GetFileFromUrl("http://dunois403.cafe24.com/ACPData/ACP" & ListQuater & ".rev.ini", ACDataFolder & "\AnimationCheckerProList.ini", "AnimationList")
            ListDownloadError = False
        Catch ex As Exception
            GetFileFromUrl("http://dunois403.cafe24.com/ACPData/AnimationCheckerProList.rev.ini", ACDataFolder & "\AnimationCheckerProList.ini", "AnimationList")
            ListDownloadError = True
        End Try
    End Sub
    Public Sub getListQuater()
        If Today.ToString("MM") = "01" Or Today.ToString("MM") = "02" Or Today.ToString("MM") = "03" Then
            GetQMonth = "01"
        ElseIf Today.ToString("MM") = "04" Or Today.ToString("MM") = "05" Or Today.ToString("MM") = "06" Then
            GetQMonth = "04"
        ElseIf Today.ToString("MM") = "07" Or Today.ToString("MM") = "08" Or Today.ToString("MM") = "09" Then
            GetQMonth = "07"
        ElseIf Today.ToString("MM") = "10" Or Today.ToString("MM") = "11" Or Today.ToString("MM") = "12" Then
            GetQMonth = "10"
        End If
        ListQuater = TimeInfo.ToString("yy") & GetQMonth
    End Sub
    Public Sub SettingApply() 'OK
        Dim getSkinUse As String = XMLReader(SettingFileLocation, "System", "SkinUse")
        Dim getSkinPath As String = XMLReader(SettingFileLocation, "System", "SkinPath")
        Dim getAction As String = XMLReader(SettingFileLocation, "System", "ActionType")
        Dim getTray As String = XMLReader(SettingFileLocation, "System", "SystemTray")
        MainPanel.Visible = True
        If getSkinUse = 1 Then
            If My.Computer.FileSystem.FileExists(getSkinPath) Then
                SkinPanel.BackgroundImage = Image.FromFile(getSkinPath)
            Else
                MsgBox("설정한 스킨이 존재하지 않습니다.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "오류")
            End If
        End If
        If getTray = 1 Then
            NotifyIcon.Visible = True
        End If
        If getAction = 1 Then
            SearchButton.Visible = False
            SubLinkButton.Visible = False
        Else
            SearchButton.Visible = True
            SubLinkButton.Visible = True
        End If

    End Sub
    Public Sub ExtraWork()
        Dim getUpdateStatus As String = XMLReader(SettingFileLocation, "System", "UpdateStatus")
        Dim getListDate As String = INIRead("System", "ListDate", ACDataFolder & "\AnimationCheckerProList.ini")
        WeekComboBox.SelectedIndex = TodayDate - 1
        If ListDownloadError = True Then
            Dim DownloadListYear As String = INIRead("System", "ListTargetYear", ACDataFolder & "\AnimationCheckerProList.ini")
            Dim DownloadListMonth As String = INIRead("System", "ListTargetMonth", ACDataFolder & "\AnimationCheckerProList.ini")
            Dim DownloadListQuarter As String = INIRead("System", "ListTargetQuarter", ACDataFolder & "\AnimationCheckerProList.ini")
            MsgBox("서버에 " & TimeInfo.ToString("yyyy") & "년 " & GetQMonth & "월 " & "리스트가 존재하지 않아 " & DownloadListYear & "년 " & DownloadListMonth & "월 리스트를 다운로드 했습니다.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "확인")
            ListQuater = DownloadListYear.Substring(2, 2) & DownloadListMonth
        End If
        If getUpdateStatus = "1" Or Command() = "-manual" Then
            If My.Computer.FileSystem.FileExists(ACDataFolder & "\Update.log") Then
                My.Computer.FileSystem.DeleteFile(ACDataFolder & "\Update.log")
            End If
            My.Computer.Network.DownloadFile("http://dunois403.cafe24.com/ACPData/Update.log", ACDataFolder & "\Update.log")
            UpdateCompleteForm.ShowDialog()
            XMLWriter(SettingFileLocation, "System", "UpdateStatus", 0)
        Else
            XMLWriter(SettingFileLocation, "System", "UpdateStatus", 0)
        End If
        Me.Text = Me.Text + " : " & getListDate
        Dim getCurrentNotice As String = XMLReader(SettingFileLocation, "System", "Notice")
        Dim getInternalNotice As String = INIRead("Notice", "ImpNoticeType", ACDataFolder & "\AnimationCheckerProList.ini")
        If getCurrentNotice = "Error" Then
            ImportantNotice.ShowDialog()
        ElseIf getCurrentNotice = getInternalNotice = False Then
            ImportantNotice.ShowDialog()
        End If
        If My.Computer.FileSystem.DirectoryExists(ACDataFolder & "\cache") Then

        Else
            My.Computer.FileSystem.CreateDirectory(ACDataFolder & "\cache")
        End If
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
                MsgBox("리스트를 불러오는 도중 오류가 발생하였습니다." & Chr(10) & "오류코드 : " & "W" & getWeekdayName & "_N" & i & Chr(10) & "문제가 계속되면 tarry403@gmail.com 으로 오류코드를 전송해주시면 빠르게 해결하겠습니다.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "오류")
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
        StartPosition = FormStartPosition.CenterScreen
        If Not bCreated Then '뮤텍스가 정상적으로 생성되지 않았으면 같은 이름의 뮤텍스가 있는것으로 판단
            MsgBox("프로그램이 이미 실행중입니다!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "오류")
            Application.ExitThread()
            NotifyIcon.Visible = False
            End
        Else
            If My.Computer.FileSystem.FileExists(SettingFileLocation) Then

            Else
                CreatXmlDoc("Settings.xml", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Dunois Software\AnimationCheckerPro")
            End If
            XMLWriter(SettingFileLocation, "System", "ProgramPath", My.Application.Info.DirectoryPath)
            XMLWriter(SettingFileLocation, "System", "ProgramVersion", Version)
            SettingChecker()
            FormLoadCompleteTimer.Enabled = True
        End If
    End Sub
    Private Sub FormLoadCompleteTimer_Tick(sender As Object, e As EventArgs) Handles FormLoadCompleteTimer.Tick
        FormLoadCompleteTimer.Enabled = False
        For i As Integer = 1 To 8
            ProjectLoading(i)
        Next
    End Sub
    Public Sub ProjectLoading(ByVal Stage As Integer)
        Application.DoEvents()
        If ErrorStatus = False Then
            If Stage = 1 Then
                ACConfigDownLoad()
            ElseIf Stage = 2 Then
                UpdaterProcess()
            ElseIf Stage = 3 Then
                VersionCheck()
            ElseIf Stage = 4 Then
                ACListDownload()
            ElseIf Stage = 5 Then
                SettingApply()
            ElseIf Stage = 6 Then
                ExtraWork()
            ElseIf Stage = 7 Then
                'Listloading()
                PingBackgroundWorker.RunWorkerAsync()
                LoadStageChecker = False
            End If
        Else
            MsgBox("프로그램을 로드할 수 없습니다!" & Chr(10) & "에러코드 : PL" & Stage, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "오류")
            End
        End If
    End Sub
    Private Sub ErrorCloseButton_Click(sender As Object, e As EventArgs) Handles ErrorCloseButton.Click
        End
    End Sub
    Public Sub ListReader()
        Application.DoEvents()
        Dim getSelectedItem As Integer = AnimationListBox.SelectedIndex + 1
        Dim getImageUrl As String = "http://dunois403.cafe24.com/" & INIRead(WeekdayName, "Ani" & getSelectedItem & "PictureUrl", ACDataFolder & "\AnimationCheckerProList.ini")
        Dim getImageFilterSet As String = XMLReader(SettingFileLocation, "System", "ImageFilter")
        Dim getImageRate As String = INIRead(WeekdayName, "Ani" & getSelectedItem & "PictureType", ACDataFolder & "\AnimationCheckerProList.ini")
        Dim getDN As Integer = WeekComboBox.SelectedIndex + 1
        If Not (StillCutPictureBox.Image Is Nothing) Then
            'StillCutPictureBox.Image.Dispose()
            StillCutPictureBox.Image = Nothing
            StillCutPictureBox.Width = 910
            StillCutPictureBox.Height = 420
        End If
        If ImageChecker(getImageUrl) = 0 Then
            Dim ImageLocation As String = ImageDownlaoder(getImageUrl)
            AnimationListBox.Enabled = True
            AnimationListBox.Focus()
            ImageFile = New System.IO.FileStream(ImageLocation, IO.FileMode.Open, IO.FileAccess.Read)
            ImageFileLocation = ImageLocation
            If getImageFilterSet = 1 And getImageRate = 1 Then
                FilterCancelButton.Visible = True
                HideImageButton.Visible = False
                ShowImageButton.Visible = False
                ImageErrorLabel.Visible = False
            Else
                FilterCancelButton.Visible = False
                HideImageButton.Visible = True
                ShowImageButton.Visible = True
                ImageErrorLabel.Visible = False
                StillCutPictureBox.Image = System.Drawing.Image.FromStream(ImageFile)
                ImageFile.Close()
            End If
        Else
            ImageErrorLabel.Visible = True
            HideImageButton.Visible = False
            ShowImageButton.Visible = False
        End If
        Dim getSubNumber As Integer = INIRead(WeekdayName, "Ani" & getSelectedItem & "SubNumber", ACDataFolder & "\AnimationCheckerProList.ini")
        If getSubNumber = 0 Then
            SubListBox.Items.Add("등록된 자막 제작자가 없습니다.")
        Else
            For i As Integer = 1 To getSubNumber
                Dim getSubName As String = INIRead(WeekdayName, "Ani" & getSelectedItem & "Sub" & i & "Name", ACDataFolder & "\AnimationCheckerProList.ini")
                If getSubName = "" Then
                    MsgBox("리스트를 불러오는 도중 오류가 발생하였습니다." & Chr(10) & "오류코드 : 2xD" & getDN & "_ITEM" & getSelectedItem & "_N" & i, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "오류")
                Else
                    SubListBox.Items.Add(getSubName)
                End If
            Next
        End If
        Dim getSearchNumber As Integer = INIRead(WeekdayName, "Ani" & getSelectedItem & "SearchNumber", ACDataFolder & "\AnimationCheckerProList.ini")
        If getSearchNumber = 0 Then
            SearchListBox.Items.Add("항목이 없습니다.")
        Else
            For i As Integer = 1 To getSearchNumber
                Dim GetSearchName As String = INIRead(WeekdayName, "Ani" & getSelectedItem & "Search" & i & "Name", ACDataFolder & "\AnimationCheckerProList.ini")
                If GetSearchName = "" Then
                    MsgBox("리스트를 불러오는 도중 오류가 발생하였습니다." & Chr(10) & "오류코드 : 1xD" & getDN & "N" & i, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "오류")
                Else
                    Dim getSearchType As Integer = INIRead(WeekdayName, "Ani" & getSelectedItem & "Search" & i & "Type", ACDataFolder & "\AnimationCheckerProList.ini")
                    If getSearchType = 0 Then
                        SearchListBox.Items.Add(GetSearchName & " (접속상태 : " & NTStatus & ")")
                    Else
                        SearchListBox.Items.Add(GetSearchName)
                    End If
                End If
            Next
        End If
        Dim getTime As String = INIRead(WeekdayName, "Ani" & getSelectedItem & "Time", ACDataFolder & "\AnimationCheckerProList.ini")
        TimeToolTip.ToolTipTitle = "방영시간"
        TimeToolTip.Show(getTime, AnimationListBox, 5000)
    End Sub
    Public Function ImageChecker(ByVal RequestUrl As String)
        Dim ImgReq = WebRequest.Create(RequestUrl)
        ImgReq.Timeout = 5000
        Try
            ImgReq.GetResponse()
            ImgReq.Abort()
            Return 0
        Catch ex As Exception
            ImgReq.Abort()
            Return 1
        End Try
    End Function
    Public Function ImageDownlaoder(ByVal DownloadUrl As String)
        Dim FileNameOnly As String = DownloadUrl.Substring(DownloadUrl.LastIndexOf("/") + 1)
        If My.Computer.FileSystem.FileExists(ACDataFolder & "\cache\" & FileNameOnly) Then
            Return ACDataFolder & "\cache\" & FileNameOnly
        End If
        AnimationListBox.Enabled = False
        Dim DownloadDestination As String = ACDataFolder & "\cache\" & FileNameOnly
        ImgDownloadProgressBar.Visible = True
        Dim ReDownBufferSize As Double = 0
        Dim ThisRequest As HttpWebRequest = DirectCast(WebRequest.Create(DownloadUrl), HttpWebRequest)
        Dim ThisResponese As HttpWebResponse = DirectCast(ThisRequest.GetResponse(), HttpWebResponse)
        Dim TotalSize As Integer = ThisResponese.ContentLength
        Dim MyThisStream As Stream = ThisResponese.GetResponseStream()
        Dim GetFileStream As New FileStream(DownloadDestination, FileMode.Create)
        Dim buff As Byte() = New Byte(TotalSize) {}
        Dim buffer As Byte() = buff
        Do Until GetFileStream.Length = TotalSize
            ReDownBufferSize = MyThisStream.Read(buff, 0, 1024)
            GetFileStream.Write(buffer, 0, ReDownBufferSize)
            Application.DoEvents()
            ImgDownloadProgressBar.Value = Math.Round(GetFileStream.Length) / Math.Round(TotalSize) * 100
        Loop
        GetFileStream.Close()
        MyThisStream.Close()
        ThisResponese.Close()
        ImgDownloadProgressBar.Visible = False
        Return ACDataFolder & "\cache\" & FileNameOnly
    End Function
    Private Sub AnimationListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AnimationListBox.SelectedIndexChanged
        Application.DoEvents()
        If AnimationListBox.SelectedIndex = -1 Then
            SearchListBox.Items.Clear()
            SubListBox.Items.Clear()
            SearchListBox.Items.Add("애니메이션을 선택하세요")
            SubListBox.Items.Add("애니메이션을 선택하세요")
        Else
            SearchListBox.Items.Clear()
            SubListBox.Items.Clear()
            SearchButton.Enabled = False
            SubLinkButton.Enabled = False
            ListReader()
        End If
    End Sub
    Private Sub WeekComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles WeekComboBox.SelectedIndexChanged
        AnimationListBox.Items.Clear()
        SubListBox.Items.Clear()
        SearchListBox.Items.Clear()
        If Not (StillCutPictureBox.Image Is Nothing) Then
            StillCutPictureBox.Image.Dispose()
            StillCutPictureBox.Image = Nothing
            StillCutPictureBox.Width = 910
            StillCutPictureBox.Height = 420
        End If
        SubListBox.Items.Add("애니메이션을 선택하세요")
        SearchListBox.Items.Add("애니메이션을 선택하세요")
        FilterCancelButton.Visible = False
        SearchButton.Enabled = False
        SubLinkButton.Enabled = False
        HideImageButton.Visible = False
        ShowImageButton.Visible = False
        ImageErrorLabel.Visible = False
        Listloading()
    End Sub
    Public Sub GetSearchLink()
        If SearchListBox.SelectedIndex = -1 Or SearchListBox.SelectedItem.ToString = "애니메이션을 선택하세요" Or SearchListBox.SelectedItem.ToString = "항목이 없습니다." Then

        Else
            Dim getSelectedListItem As Integer = AnimationListBox.SelectedIndex + 1
            Dim getSelectedSearchItem As Integer = SearchListBox.SelectedIndex + 1
            Dim getSearchEngineType As Integer = INIRead(WeekdayName, "Ani" & getSelectedListItem & "Search" & getSelectedSearchItem & "Type", ACDataFolder & "\AnimationCheckerProList.ini")
            If getSearchEngineType = 0 Then 'NT
                Dim getString As String = INIRead(WeekdayName, "Ani" & getSelectedListItem & "Search" & getSelectedSearchItem & "String", ACDataFolder & "\AnimationCheckerProList.ini")
                Dim getSearchCat As String = XMLReader(SettingFileLocation, "System", "NTCat")
                Dim getSearchFilter As String = XMLReader(SettingFileLocation, "System", "NTFilter")
                Dim SearchEngine As String = "http://www.nyaa.se/?page=search&cats="
                SearchLink = SearchEngine & getSearchCat & "&filter=" & getSearchFilter & "&term=" & getString
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

    Public Sub SearchFunc(ByVal Act As Integer, ByVal Type As Integer)
        If SearchListBox.SelectedIndex = -1 Or SearchListBox.SelectedItem = "항목이 없습니다." Or SearchListBox.SelectedItem = "애니메이션을 선택하세요" Then
            SearchButton.Enabled = False
        Else
            GetSearchLink()
            If Act = 0 Then
                SearchButton.Enabled = True
            ElseIf Act = 1 And Type = 1 Then
                Process.Start(SearchLink)
            End If
        End If
    End Sub

    Public Sub SubFunc(ByVal Act As Integer, ByVal Type As Integer)
        If SubListBox.SelectedIndex = -1 Or SubListBox.SelectedItem = "애니메이션을 선택하세요" Or SubListBox.SelectedItem = "등록된 자막 제작자가 없습니다." Then
            SubLinkButton.Enabled = False
        Else
            GetSubLink()
            If Act = 0 Then
                SubLinkButton.Enabled = True
            ElseIf Act = 1 And Type = 1 Then
                Process.Start(SubLink)
            End If
        End If
    End Sub

    Private Sub SearchListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SearchListBox.SelectedIndexChanged
        Dim ActionType As Integer = XMLReader(SettingFileLocation, "System", "ActionType")
        SearchFunc(ActionType, 0)
    End Sub

    Private Sub SubListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SubListBox.SelectedIndexChanged
        Dim ActionType As Integer = XMLReader(SettingFileLocation, "System", "ActionType")
        SubFunc(ActionType, 0)
    End Sub

    Private Sub SearchListBox_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles SearchListBox.MouseDoubleClick
        Dim ActionType As Integer = XMLReader(SettingFileLocation, "System", "ActionType")
        SearchFunc(ActionType, 1)
    End Sub

    Private Sub SubListBox_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles SubListBox.MouseDoubleClick
        Dim ActionType As Integer = XMLReader(SettingFileLocation, "System", "ActionType")
        SubFunc(ActionType, 1)
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        Process.Start(SearchLink)
    End Sub

    Private Sub SubLinkButton_Click(sender As Object, e As EventArgs) Handles SubLinkButton.Click
        Process.Start(SubLink)
    End Sub

    Private Sub ProgramConfigButton_Click(sender As Object, e As EventArgs) Handles ProgramConfigButton.Click
        ProgramOption.ShowDialog()
    End Sub

    Private Sub ProgramInformationButton_Click(sender As Object, e As EventArgs) Handles ProgramInformationButton.Click
        ProgramInformation.ShowDialog()
    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim getTray As String = XMLReader(SettingFileLocation, "System", "SystemTray")
        Dim getCloseAlert As String = XMLReader(SettingFileLocation, "System", "CloseAlert")
        If getTray = 1 And CloseToggleStatus = False Then
            Me.Hide()
            SystemTrayed = True
            e.Cancel = True
        ElseIf getCloseAlert = 0 Then
            Show()
            WindowState = FormWindowState.Normal
            Dim CloseAlertMsg = MsgBox("정말로 종료하시겠습니까?" & Chr(10) & "(이 설정은 옵션 - 프로그램 설정 에서 설정할수있습니다.)", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "확인")
            If CloseAlertMsg = vbYes Then
                'DeleteCache()
            Else
                e.Cancel = True
            End If
        ElseIf getCloseAlert = 1 Then
            NotifyIcon.Visible = False
            'DeleteCache()
            End
        End If
    End Sub
    Private Sub DeleteCache()
        If Not (StillCutPictureBox.Image Is Nothing) Then
            StillCutPictureBox.Image.Dispose()
        End If
        My.Computer.FileSystem.DeleteDirectory(ACDataFolder & "\cache", FileIO.DeleteDirectoryOption.DeleteAllContents)
    End Sub
    Private Sub SkinSetButton_Click(sender As Object, e As EventArgs)
        SkinSettingForm.ShowDialog()

    End Sub
    Private Sub PingBackgroundWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles PingBackgroundWorker.DoWork
        Application.DoEvents()
        For i As Integer = 1 To 2
            Dim WebString As String = ""
            If i = 1 Then
                WebString = "http://www.nyaa.se"
            ElseIf i = 2 Then
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
                    GStatus = "접속성공"
                    GTime = Timewatch.ElapsedMilliseconds / 1000
                End If
                Timewatch.Stop()
                Timewatch.Reset()
            Catch ex As Exception
                Dim ErrorMsg As String = ""
                If ex.Message = "작업 시간이 초과되었습니다." Then
                    ErrorMsg = "접속 실패"
                Else
                    ErrorMsg = "알 수 없는 오류"
                End If
                If i = 1 Then
                    NTStatus = ErrorMsg
                ElseIf i = 2 Then
                    GStatus = ErrorMsg
                End If
            End Try
        Next
        ProgramOption.ReTestButton.Enabled = True
    End Sub

    Private Sub ImageShowButton_Click(sender As Object, e As EventArgs) Handles FilterCancelButton.Click
        StillCutPictureBox.Image = System.Drawing.Image.FromStream(ImageFile)
        ImageFile.Close()
        FilterCancelButton.Visible = False
        HideImageButton.Visible = True
        ShowImageButton.Visible = True
    End Sub

    Private Sub CloseQuickMenu_Click(sender As Object, e As EventArgs) Handles CloseQuickMenu.Click
        CloseToggleStatus = True
        Close()
    End Sub

    Private Sub SkinRootButton_Click(sender As Object, e As EventArgs) Handles SkinRootButton.Click
        SkinSettingForm.ShowDialog()
    End Sub

    Private Sub InfoQuickMenu_Click(sender As Object, e As EventArgs) Handles InfoQuickMenu.Click
        If SystemTrayed = True Then
            OpenAppTray()
            ProgramInformation.ShowDialog()
        Else
            Me.WindowState = FormWindowState.Normal
            ProgramInformation.ShowDialog()
        End If
    End Sub

    Private Sub OpenQuickMenu_Click(sender As Object, e As EventArgs) Handles OpenQuickMenu.Click
        OpenAppTray()
    End Sub

    Private Sub OptionQuickMenu_Click(sender As Object, e As EventArgs) Handles OptionQuickMenu.Click
        If SystemTrayed = True Then
            OpenAppTray()
            ProgramOption.ShowDialog()
        Else
            Me.WindowState = FormWindowState.Normal
            ProgramOption.ShowDialog()
        End If
    End Sub

    Private Sub MainForm_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If My.Computer.FileSystem.FileExists(SettingFileLocation) Then
            Dim getTray As String = XMLReader(SettingFileLocation, "System", "SystemTray")
            If getTray = 2 And SystemTrayed = False And LoadStageChecker = False Then
                Me.Hide()
                SystemTrayed = True
                NotifyIcon.Visible = True
            End If
        Else 'FirstLoadStage

        End If
    End Sub

    Private Sub NotifyIcon_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon.MouseDoubleClick
        OpenAppTray()
    End Sub
    Public Sub OpenAppTray()
        Dim getTray As String = XMLReader(SettingFileLocation, "System", "SystemTray")
        If SystemTrayed = True Then
            Me.Show()
            Me.WindowState = FormWindowState.Normal
            SystemTrayed = False
            If getTray = 1 Then

            Else
                NotifyIcon.Visible = False
            End If
        End If
    End Sub

    Private Sub ListChangeButton_Click(sender As Object, e As EventArgs) Handles ListChangeButton.Click
        ProgramOption.OptionTreeView.SelectedNode = ProgramOption.OptionTreeView.Nodes(1).Nodes(0)
        ProgramOption.ShowDialog()
    End Sub

    Private Sub ShowImageButton_Click(sender As Object, e As EventArgs) Handles ShowImageButton.Click
        ImageFile = New System.IO.FileStream(ImageFileLocation, IO.FileMode.Open, IO.FileAccess.Read)
        LargeImageForm.LargePictureBox.Image = Image.FromStream(ImageFile)
        ImageFile.Close()
        LargeImageForm.ShowDialog()
    End Sub

    Private Sub HideImageButton_Click(sender As Object, e As EventArgs) Handles HideImageButton.Click
        If StillCutPictureBox.Visible = True Then
            StillCutPictureBox.Visible = False
            HideImageButton.Text = "이미지 보이기"
        Else
            StillCutPictureBox.Visible = True
            HideImageButton.Text = "이미지 숨기기"
        End If
    End Sub
    Private Sub StillCutPictureBox_SizeChanged(sender As Object, e As EventArgs) Handles StillCutPictureBox.SizeChanged
        If StillCutPictureBox.Width > 975 Then

        Else
            ImagePanel.Width = StillCutPictureBox.Width + 45
        End If
    End Sub

    Private Sub DeleteCacheButton_Click(sender As Object, e As EventArgs) Handles DeleteCacheButton.Click
        DeleteCache()
        My.Computer.FileSystem.CreateDirectory(ACDataFolder & "\cache")
        MsgBox("이미지 캐시를 지웠습니다.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "완료")
    End Sub
End Class