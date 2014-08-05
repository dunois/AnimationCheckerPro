﻿Imports System.Net
Imports System.IO
Imports Microsoft.Win32

Public Class MainForm

    Public ACDataFolder As String = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData
    Dim ProjectLoadingFaild As Boolean = False
    Public Version As Double = 1.26
    Dim REG As RegistryKey = Registry.LocalMachine
    Public UserBrowser As String
    Dim RegStorage As String = "Software\\Dunois Soft\\Animation Checker Pro"
    Dim CloseCheck As Boolean = False
    Dim HideCheck As Boolean = False
    Dim getUserBrowser As String
    Dim REQStatus As String = "Success"
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
    Public Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    Dim bCreated As Boolean
    Dim mtx As New System.Threading.Mutex(True, "AnimationCheckerPro.exe", bCreated)
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
            REQStatus = "오류"
            MsgBox("필수 구성요소(" & FileType & ") 다운로드 실패!" & Chr(10) & "인터넷 문제일수 있습니다. 이 문제가 계속되면 tarry403@gmail.com 으로 메일을 보내주세요", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "오류")
            ErrorCloseButton.Visible = True
        End Try
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
            REQStatus = "오류"
            ErrorCloseButton.Visible = True
            End
        End Try
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
        WeekComboBox.SelectedIndex = TodayDate - 1
    End Sub
    Public Sub ListDownload(ByVal ListType)
        If ListType = "OldList" Then
            GetFileFromUrl("http://dnsoft.me/ACPData/OLAnimationCheckerProList.ini", ACDataFolder & "\AnimationCheckerProList.ini", "AnimationList")
        ElseIf ListType = "ProList" Then
            GetFileFromUrl("http://dnsoft.me/ACPData/AnimationCheckerProList.ini", ACDataFolder & "\AnimationCheckerProList.ini", "AnimationList")
        End If
    End Sub
    Public Sub ACListDownload()
        Dim regkey As RegistryKey = REG.OpenSubKey(RegStorage, True)
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
        Dim regkey As RegistryKey = REG.OpenSubKey(RegStorage, True)
        getUserBrowser = regkey.GetValue("Browser", "IE")
        If getUserBrowser = "IE" Then
            getUserBrowser = My.Computer.FileSystem.SpecialDirectories.ProgramFiles & "\Internet Explorer\iexplore.exe"
        Else
            If My.Computer.FileSystem.FileExists(getUserBrowser) Then

            Else
                MsgBox("오류 : 기본으로 설정한 브라우저가 존재하지 않습니다. IE를 기본 브라우저로 선택합니다.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "오류")
                getUserBrowser = My.Computer.FileSystem.SpecialDirectories.ProgramFiles & "\Internet Explorer\iexplore.exe"
            End If
        End If '기본 브라우저 적용
        MainPanel.Visible = True
        Dim SkinUseCheck As Integer = regkey.GetValue("SkinUse", 0)
        If SkinUseCheck = 1 Then
            regkey = REG.OpenSubKey(RegStorage & "\\Skin")
            Dim SkinLocation As String = regkey.GetValue("SkinLocation")
            If My.Computer.FileSystem.FileExists(SkinLocation) Then
                SkinPanel.BackgroundImage = Image.FromFile(SkinLocation)
            Else
                MsgBox("설정한 스킨이 존재하지 않습니다.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "오류")
            End If
        Else

        End If '스킨 적용
        Dim ImageMode As Integer = regkey.GetValue("ImageMode", 0)
        If ImageMode = 1 Then
            StillCutPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        ElseIf ImageMode = 0 Then
            StillCutPictureBox.SizeMode = PictureBoxSizeMode.AutoSize
        End If '이미지 모드 적용

    End Sub
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not bCreated Then '뮤텍스가 정상적으로 생성되지 않았으면 같은 이름의 뮤텍스가 있는것으로 판단
            MsgBox("프로그램이 이미 실행중입니다!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "오류")
            Application.ExitThread()
            End
        Else
            If REG.OpenSubKey(RegStorage) Is Nothing Then
                REG.CreateSubKey(RegStorage)
            Else

            End If
            Dim regkey As RegistryKey = REG.OpenSubKey(RegStorage, True)
            If My.Computer.FileSystem.FileExists(ACDataFolder & "\ACPUpdater.exe") Then
                Dim UpdaterVersion As Double = regkey.GetValue("UpdaterVersion", 0)
                Dim InternalUpdaterVersion As Double = INIRead("System", "UpdaterVersion", ACDataFolder & "\Config.ini")
                regkey.SetValue("Location", My.Application.Info.DirectoryPath & "\")
                If UpdaterVersion < InternalUpdaterVersion Then
                    My.Computer.FileSystem.DeleteFile(ACDataFolder & "\ACPUpdater.exe")
                    GetFileFromUrl("http://gkskvhtm403.cafe24.com/ACPData/ACPUpdater.exe", ACDataFolder & "\ACPUpdater.exe", "Updater")
                    regkey.SetValue("UpdaterVersion", InternalUpdaterVersion, RegistryValueKind.String)
                End If
            Else
                GetFileFromUrl("http://gkskvhtm403.cafe24.com/ACPData/ACPUpdater.exe", ACDataFolder & "\ACPUpdater.exe", "Updater")
            End If
            regkey.SetValue("CurrentProgramVersion", Version, RegistryValueKind.String)

        End If
    End Sub
    Public Sub ProjectLoading(ByVal Phase As Integer)
        Application.DoEvents()
        ACConfigDownLoad()
        VersionCheck()
        FactorCheck()
        ACListDownload()
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
            Dim getCancelStatus As Integer = INIRead(WeekdayName, "Ani" & i & "CancelStatus", ACDataFolder & "\AnimationCheckerProList.ini")
            If getCancelStatus = 1 Then
                AnimationListBox.Items.Add("[결방] " & INIRead(WeekdayName, "Ani" & i & "Name", ACDataFolder & "\AnimationCheckerProList.ini"))
            Else
                AnimationListBox.Items.Add(INIRead(WeekdayName, "Ani" & i & "Name", ACDataFolder & "\AnimationCheckerProList.ini"))
            End If
        Next
    End Sub
    Private Sub ErrorCloseButton_Click(sender As Object, e As EventArgs) Handles ErrorCloseButton.Click
        End
    End Sub


    Private Sub AnimationListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AnimationListBox.SelectedIndexChanged
        Dim getSelectedItem As Integer = AnimationListBox.SelectedIndex + 1
        Dim regkey As RegistryKey = REG.OpenSubKey(RegStorage)
        If AnimationListBox.SelectedIndex = -1 Then
            SearchListBox.Items.Clear()
            SubListBox.Items.Clear()
            SearchListBox.Items.Add("애니메이션을 선택하세요")
            SubListBox.Items.Add("애니메이션을 선택하세요")
            NameLabel.Text = "애니메이션을 선택하세요"
        Else
            Dim getMode As Integer = regkey.GetValue("ModeType", "1")
            If getMode = 1 And ScreenNotSupport = False Then 'Full Mode
                If Me.Width = 1370 Then

                Else
                    ResizeMode = True
                    Me.Width = 1370
                    ResizeMode = False
                End If
                Dim getTime As String = INIRead(WeekdayName, "Ani" & getSelectedItem & "Time", ACDataFolder & "\AnimationCheckerProList.ini")
                Dim getImageType As Integer = INIRead(WeekdayName, "Ani" & getSelectedItem & "PictureType", ACDataFolder & "\AnimationCheckerProList.ini")
                Dim getImageUrl As String = INIRead(WeekdayName, "Ani" & getSelectedItem & "PictureUrl", ACDataFolder & "\AnimationCheckerProList.ini")
                Dim FinalUrl As String = ""
                If getImageType = 0 Then
                    FinalUrl = "http://gkskvhtm403.cafe24.com/" & getImageUrl
                End If
                StillCutPictureBox.ImageLocation = FinalUrl
                StillCutHideButton.Enabled = True
                ShowLargeImageButton.Enabled = True
                OnAirTimeLabel.Text = getTime
                SearchButton.Enabled = False
                SubLinkButton.Enabled = False
                NameLabel.Text = AnimationListBox.SelectedItem
            ElseIf getMode = 0 Or ScreenNotSupport = True Then
                If Me.Width = 1370 Then
                    ResizeMode = True
                    Me.Width = 310
                    ResizeMode = False
                End If
            End If
            SearchListBox.Items.Clear()
            SubListBox.Items.Clear()
            Dim getSubNumber As Integer = INIRead(WeekdayName, "Ani" & getSelectedItem & "SubNumber", ACDataFolder & "\AnimationCheckerProList.ini")
            Dim getSearchNumber As Integer = INIRead(WeekdayName, "Ani" & getSelectedItem & "SearchNumber", ACDataFolder & "\AnimationCheckerProList.ini")
            If getSubNumber = 0 Then
                SubListBox.Items.Add("등록된 자막 제작자가 없습니다.")
            Else
                For i As Integer = 1 To getSubNumber
                    SubListBox.Items.Add(INIRead(WeekdayName, "Ani" & getSelectedItem & "Sub" & i & "Name", ACDataFolder & "\AnimationCheckerProList.ini"))
                Next
            End If
            If getSearchNumber = 0 Then
                SearchListBox.Items.Add("항목이 없습니다.")
            Else
                For i As Integer = 1 To getSearchNumber
                    SearchListBox.Items.Add(INIRead(WeekdayName, "Ani" & getSelectedItem & "Search" & i & "Name", ACDataFolder & "\AnimationCheckerProList.ini"))
                Next
            End If
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

    Private Sub SearchListBox_DoubleClick(sender As Object, e As EventArgs) Handles SearchListBox.DoubleClick
        If SearchListBox.SelectedIndex = -1 Then

        Else
            If SearchListBox.SelectedItem.ToString = "애니메이션을 선택하세요" Or SearchListBox.SelectedItem.ToString = "항목이 없습니다." Then

            Else
                Dim getSelectedListItem As Integer = AnimationListBox.SelectedIndex + 1
                Dim getSelectedSearchItem As Integer = SearchListBox.SelectedIndex + 1
                Dim regkey As RegistryKey = REG.OpenSubKey(RegStorage)
                Dim getString As String = INIRead(WeekdayName, "Ani" & getSelectedListItem & "Search" & getSelectedSearchItem & "String", ACDataFolder & "\AnimationCheckerProList.ini")
                Dim getSearchType As Integer = INIRead(WeekdayName, "Ani" & getSelectedListItem & "Search" & getSelectedSearchItem & "Type", ACDataFolder & "\AnimationCheckerProList.ini")
                Dim getSearchCat As String = regkey.GetValue("SearchCat", "1_11")
                Dim getSearchFilter As String = regkey.GetValue("SearchFilter", "0")
                Dim getSearchEngine As String = ""
                If getSearchType = 0 Then
                    getSearchEngine = "http://www.nyaa.se/?page=search&cats="
                Else

                End If
                Dim FinalLink = getSearchEngine & getSearchCat & "&filter=" & getSearchFilter & "&term=" & getString
                Dim getMode As Integer = regkey.GetValue("ModeType", "1")
                Dim getButtonAct As Integer = regkey.GetValue("ButtonActSet", 0)
                If getMode = 0 Then
                    Shell(getUserBrowser & " " & FinalLink, AppWinStyle.NormalFocus)
                Else
                    If getButtonAct = 1 Then
                        Shell(getUserBrowser & " " & FinalLink, AppWinStyle.NormalFocus)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub MiniModeButton_Click(sender As Object, e As EventArgs) Handles MiniModeButton.Click
        If Me.Width = 1370 Then
            ResizeMode = True
            Me.Width = 310
            ResizeMode = False
        End If
    End Sub

    Private Sub SubListBox_DoubleClick(sender As Object, e As EventArgs) Handles SubListBox.DoubleClick
        If SubListBox.SelectedIndex = -1 Then

        Else
            If SubListBox.SelectedItem.ToString = "애니메이션을 선택하세요" Or SubListBox.SelectedItem.ToString = "등록된 자막 제작자가 없습니다." Then

            Else
                Dim regkey As RegistryKey = REG.OpenSubKey(RegStorage)
                Dim getSelectedListItem As Integer = AnimationListBox.SelectedIndex + 1
                Dim getSelectedSubItem As Integer = SubListBox.SelectedIndex + 1
                Dim getUrl As String = INIRead(WeekdayName, "Ani" & getSelectedListItem & "Sub" & getSelectedSubItem & "Url", ACDataFolder & "\AnimationCheckerProList.ini")
                Dim getMode As Integer = regkey.GetValue("ModeType", "1")
                Dim getButtonAct As Integer = regkey.GetValue("ButtonActSet", 0)
                If getMode = 0 Then
                    Shell(getUserBrowser & " " & getUrl, AppWinStyle.NormalFocus)
                Else
                    If getButtonAct = 1 Then
                        Shell(getUserBrowser & " " & getUrl, AppWinStyle.NormalFocus)
                    End If
                End If
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
        Dim regkey As RegistryKey = REG.OpenSubKey(RegStorage, True)
        Dim getMode As Integer = regkey.GetValue("ModeType", 1)
        If getMode = 1 Then
            If SearchListBox.SelectedIndex = -1 Then
                SearchButton.Enabled = False
            ElseIf SearchListBox.SelectedItem = "항목이 없습니다." Then
                SearchButton.Enabled = False
            Else
                SearchButton.Enabled = True
            End If
        Else

        End If
    End Sub

    Private Sub SubListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SubListBox.SelectedIndexChanged
        Dim regkey As RegistryKey = REG.OpenSubKey(RegStorage, True)
        Dim getMode As Integer = regkey.GetValue("ModeType", 1)
        If getMode = 1 Then
            If SubListBox.SelectedIndex = -1 Then
                SubLinkButton.Enabled = False
            ElseIf SubListBox.SelectedItem = "등록된 자막 제작자가 없습니다." Then
                SubLinkButton.Enabled = False
            Else
                SubLinkButton.Enabled = True
            End If
        Else

        End If
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        If SearchListBox.SelectedIndex = -1 Then

        Else
            Dim getSelectedListItem As Integer = AnimationListBox.SelectedIndex + 1
            Dim getSelectedSearchItem As Integer = SearchListBox.SelectedIndex + 1
            Dim regkey As RegistryKey = REG.OpenSubKey(RegStorage)
            Dim getString As String = INIRead(WeekdayName, "Ani" & getSelectedListItem & "Search" & getSelectedSearchItem & "String", ACDataFolder & "\AnimationCheckerProList.ini")
            Dim getSearchType As Integer = INIRead(WeekdayName, "Ani" & getSelectedListItem & "Search" & getSelectedSearchItem & "Type", ACDataFolder & "\AnimationCheckerProList.ini")
            Dim getSearchCat As String = regkey.GetValue("SearchCat", "1_11")
            Dim getSearchFilter As String = regkey.GetValue("SearchFilter", "0")
            Dim getSearchEngine As String = ""
            If getSearchType = 0 Then
                getSearchEngine = "http://www.nyaa.se/?page=search&cats="
            Else

            End If
            Dim FinalLink = getSearchEngine & getSearchCat & "&filter=" & getSearchFilter & "&term=" & getString
            Dim getMode As Integer = regkey.GetValue("ModeType", "1")
            Shell(getUserBrowser & " " & FinalLink, AppWinStyle.NormalFocus)
        End If
    End Sub

    Private Sub SubLinkButton_Click(sender As Object, e As EventArgs) Handles SubLinkButton.Click
        If SubListBox.SelectedIndex = -1 Then

        Else
            Dim getSelectedListItem As Integer = AnimationListBox.SelectedIndex + 1
            Dim getSelectedSubItem As Integer = SubListBox.SelectedIndex + 1
            Dim getUrl As String = INIRead(WeekdayName, "Ani" & getSelectedListItem & "Sub" & getSelectedSubItem & "Url", ACDataFolder & "\AnimationCheckerProList.ini")
            Shell(getUserBrowser & " " & getUrl, AppWinStyle.NormalFocus)
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
        Dim regkey As RegistryKey = REG.OpenSubKey(RegStorage)
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
        If REG.OpenSubKey(RegStorage) Is Nothing Then
            REG.CreateSubKey(RegStorage)
        Else

        End If
        Dim regkey As RegistryKey = REG.OpenSubKey(RegStorage)
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
End Class