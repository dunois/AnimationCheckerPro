Imports System.Net
Imports System.IO
Imports Microsoft.Win32
Imports System.Text.RegularExpressions

Public Class ProgramOption
    Dim REG As RegistryKey = Registry.LocalMachine
    Dim RegStorage As String = "Software\\Dunois Soft\\Animation Checker Pro"
    Dim TestInt As Integer = 0
    Dim SystemSet As RegistryKey
    Dim ListSet As RegistryKey
    Dim SearchSet As RegistryKey
    Private Sub ProgramOption_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SystemSet = REG.OpenSubKey(RegStorage & "\\System", True)
        ListSet = REG.OpenSubKey(RegStorage & "\\List", True)
        SearchSet = REG.OpenSubKey(RegStorage & "\\Search", True)
        Dim SystemTray As Integer = SystemSet.GetValue("SystemTrayType", 3)
        Dim CloseAlert As Integer = SystemSet.GetValue("CloseAlert", 0)
        Dim SearchCats As String = SearchSet.GetValue("SearchCat", "1_11")
        Dim SearchFilter As Integer = SearchSet.GetValue("SearchFilter", 0)
        Dim AnimationFolderUse As Integer = SystemSet.GetValue("AnimationFolderUse", 0)
        Dim AnimationFolder As String = SystemSet.GetValue("AnimationFolder")
        Dim OldListCheck As Integer = ListSet.GetValue("OldListCheck", 0)
        Dim ListDate As String = MainForm.INIRead("System", "ListDate", MainForm.ACDataFolder & "\AnimationCheckerProList.ini")
        Dim ListProducer As String = MainForm.INIRead("System", "ListProducer", MainForm.ACDataFolder & "\AnimationCheckerProList.ini")
        Dim getMode As Integer = SystemSet.GetValue("ModeType", 1)
        Dim NoticeRecive As Integer = SystemSet.GetValue("NoticeReceive", 0)
        Dim ActionSet As Integer = SystemSet.GetValue("ButtonActSet", 0)
        Dim ImageMode As Integer = SystemSet.GetValue("ImageMode", 0)
        Dim TTCats As Integer = SearchSet.GetValue("TTSearchCat", 0)
        Dim TTMin As String = SearchSet.GetValue("TTMinSize", "")
        Dim TTMax As String = SearchSet.GetValue("TTMaxSize", "")
        Dim TTSub As String = SearchSet.GetValue("TTSubmitter", "")
        Dim getImgFilter As Integer = SystemSet.GetValue("ImageFiltering", 0)
        OptionPresetChooseComboBox.SelectedIndex = 0
        SystemTrayComboBox.SelectedIndex = SystemTray
        CloseAlertComboBox.SelectedIndex = CloseAlert
        If SearchCats = "1_11" Then
            SearchCatComboBox.SelectedIndex = 0
        ElseIf SearchCats = "1_0" Then
            SearchCatComboBox.SelectedIndex = 1
        ElseIf SearchCats = "3_0" Then
            SearchCatComboBox.SelectedIndex = 2
        ElseIf SearchCats = "3_14" Then
            SearchCatComboBox.SelectedIndex = 3
        ElseIf SearchCats = "3_15" Then
            SearchCatComboBox.SelectedIndex = 4
        End If
        SearchFilterComboBox.SelectedIndex = SearchFilter
        If AnimationFolderUse = 0 Then

        Else
            AnimationFolderSetCheckBox.Checked = True
            AnimationFolderSetButton.Enabled = True
            AnimationFolderTextBox.Text = AnimationFolder
        End If
        NoticeRecvComboBox.SelectedIndex = NoticeRecive
        ListDateLabel.Text = ListDate
        ListProducerLabel.Text = ListProducer
        ProgramModeComboBox.SelectedIndex = getMode
        ButtonActionComboBox.SelectedIndex = ActionSet
        ImageModeComboBox.SelectedIndex = ImageMode
        NTSRLabel.Text = MainForm.NTStatus & " / " & MainForm.NTTime & "초"
        TTSRLabel.Text = MainForm.TTStatus & " / " & MainForm.TTTime & "초"
        GTRLabel.Text = MainForm.GStatus & " / " & MainForm.GTime & "초"
        If TTCats = 0 Then
            TTCatComboBox.SelectedIndex = 0
        ElseIf TTCats = 1 Then
            TTCatComboBox.SelectedIndex = 1
        ElseIf TTCats = 2 Then
            TTCatComboBox.SelectedIndex = 2
        ElseIf TTCats = 5 Then
            TTCatComboBox.SelectedIndex = 3
        ElseIf TTCats = 7 Then
            TTCatComboBox.SelectedIndex = 3
        End If
        If TTMin = "" And TTMax = "" Then
            TTSizeCheckBox.Checked = False
        Else
            TTSizeCheckBox.Checked = True
            MinSizeTextBox.Text = TTMin
            MaxSizeTextBox.Text = TTMax
        End If
        If TTSub = "" Then
            SubmitterCheckBox.Checked = False
        Else
            SubmitterCheckBox.Checked = True
            SubmitterTextBox.Text = TTSub
        End If
        ImageFilteringComboBox.SelectedIndex = getImgFilter
    End Sub

    Private Sub OptionTreeView_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles OptionTreeView.AfterSelect
        OptionTab.Text = OptionTreeView.SelectedNode.Text
        If OptionTreeView.SelectedNode.Name = "CommonConfigNode" Then
            ProgramConfigPanel.BringToFront()
        ElseIf OptionTreeView.SelectedNode.Name = "ListInformationNode" Then
            ListInfoPanel.BringToFront()
        ElseIf OptionTreeView.SelectedNode.Name = "AvailiableListShowNode" Then
            If My.Computer.FileSystem.FileExists(MainForm.ACDataFolder & "\DLCList.ini") Then
                My.Computer.FileSystem.DeleteFile(MainForm.ACDataFolder & "\DLCList.ini")
            End If
            Try
                My.Computer.Network.DownloadFile("http://gkskvhtm403.cafe24.com/ACPData/DLCList.ini", MainForm.ACDataFolder & "\DLCList.ini")
                AvailiableListPanel.BringToFront()
                AvailiableListComboBox.Items.Clear()
                Dim DLCListNumber As Integer = MainForm.INIRead("DLCL", "Number", MainForm.ACDataFolder & "\DLCList.ini")
                For i As Integer = 1 To DLCListNumber
                    Dim DLCListName As String = MainForm.INIRead("DLCL", "List" & i, MainForm.ACDataFolder & "\DLCList.ini")
                    AvailiableListComboBox.Items.Add(DLCListName)
                Next
                Dim getLoadedListStatus As Integer = MainForm.LoadedListStatus
                If getLoadedListStatus = 0 Then
                    Dim CurrentList As Integer = MainForm.INIRead("DLCL", "CurrentList", MainForm.ACDataFolder & "\DLCList.ini")
                    AvailiableListComboBox.SelectedIndex = CurrentList - 1
                    AvailiableListDownloadButton.Enabled = False
                Else
                    AvailiableListComboBox.SelectedIndex = getLoadedListStatus - 1
                    AvailiableListDownloadButton.Enabled = False
                End If
            Catch ex As Exception
                MsgBox("다운로드에 실패하였습니다! 인터넷 문제일수있습니다.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "오류")
            End Try
        ElseIf OptionTreeView.SelectedNode.Name = "ExpandModeSetting" Then
            ExpandModePanel.BringToFront()
        ElseIf OptionTreeView.SelectedNode.Name = "NTSearchSettingNode" Then
            NTSetPanel.BringToFront()
        ElseIf OptionTreeView.SelectedNode.Name = "TTSearchSettingNode" Then
            TTSetPanel.BringToFront()
        ElseIf OptionTreeView.SelectedNode.Name = "SiteStatusNode" Then
            WebReachTestPanel.BringToFront()
            ReTestButton.Enabled = True
            ReTestButton.Text = "다시 테스트"
            NTSRLabel.Text = MainForm.NTStatus & " / " & MainForm.NTTime & "초"
            TTSRLabel.Text = MainForm.TTStatus & " / " & MainForm.TTTime & "초"
            GTRLabel.Text = MainForm.GStatus & " / " & MainForm.GTime & "초"
        End If
    End Sub

    Private Sub AnimationFolderSetCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles AnimationFolderSetCheckBox.CheckedChanged
        If AnimationFolderSetCheckBox.Checked = True Then
            AnimationFolderSetButton.Enabled = True
        Else
            AnimationFolderSetButton.Enabled = False
        End If
    End Sub

    Private Sub AnimationFolderSetButton_Click(sender As Object, e As EventArgs) Handles AnimationFolderSetButton.Click
        Dim AnimationFolder As Integer = SystemSet.GetValue("AnimationFolderUse", 0)
        If AnimationFolder = 0 Then
            Dim OpenFolderDialog As New FolderBrowserDialog
            If (OpenFolderDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
                Dim FolderName As String = OpenFolderDialog.SelectedPath
                AnimationFolderTextBox.Text = FolderName
            End If
        Else
            Dim OpenFolderDialog As New FolderBrowserDialog
            If (OpenFolderDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
                Dim FolderName As String = OpenFolderDialog.SelectedPath
                OpenFolderDialog.RootFolder = AnimationFolder
                AnimationFolderTextBox.Text = FolderName
            End If
        End If
    End Sub

    Private Sub FormCloseButton_Click(sender As Object, e As EventArgs) Handles FormCloseButton.Click
        Me.Close()
    End Sub

    Private Sub OptionSaveButton_Click(sender As Object, e As EventArgs) Handles OptionSaveButton.Click
        SystemSet.SetValue("SystemTrayType", SystemTrayComboBox.SelectedIndex, RegistryValueKind.String)
        SystemSet.SetValue("CloseAlert", CloseAlertComboBox.SelectedIndex, RegistryValueKind.String)
        If SearchCatComboBox.SelectedIndex = 0 Then
            SearchSet.SetValue("SearchCat", "1_11", RegistryValueKind.String)
        ElseIf SearchCatComboBox.SelectedIndex = 1 Then
            SearchSet.SetValue("SearchCat", "0_0", RegistryValueKind.String)
        ElseIf SearchCatComboBox.SelectedIndex = 2 Then
            SearchSet.SetValue("SearchCat", "1_0", RegistryValueKind.String)
        ElseIf SearchCatComboBox.SelectedIndex = 3 Then
            SearchSet.SetValue("SearchCat", "3_0", RegistryValueKind.String)
        ElseIf SearchCatComboBox.SelectedIndex = 4 Then
            SearchSet.SetValue("SearchCat", "3_14", RegistryValueKind.String)
        ElseIf SearchCatComboBox.SelectedIndex = 5 Then
            SearchSet.SetValue("SearchCat", "3_15", RegistryValueKind.String)
        End If
        SystemSet.SetValue("SearchFilter", SearchFilterComboBox.SelectedIndex, RegistryValueKind.String)
        If AnimationFolderSetCheckBox.Checked = True Then
            If AnimationFolderTextBox.Text = "" Then

            Else
                SystemSet.SetValue("AnimationFolderUse", 1, RegistryValueKind.String)
                SystemSet.SetValue("AnimationFolder", AnimationFolderTextBox.Text)
            End If
        End If
        SystemSet.SetValue("ModeType", ProgramModeComboBox.SelectedIndex, RegistryValueKind.String)
        MainForm.ProgramMode = ProgramModeComboBox.SelectedIndex
        SystemSet.SetValue("NoticeReceive", NoticeRecvComboBox.SelectedIndex, RegistryValueKind.String)
        SystemSet.SetValue("ButtonActSet", ButtonActionComboBox.SelectedIndex, RegistryValueKind.String)
        If ButtonActionComboBox.SelectedIndex = 0 Then
            MainForm.SearchButton.Visible = True
            MainForm.SubLinkButton.Visible = True
        ElseIf ButtonActionComboBox.SelectedIndex = 1 Then
            MainForm.SearchButton.Visible = False
            MainForm.SubLinkButton.Visible = False
        End If
        SystemSet.SetValue("ImageMode", ImageModeComboBox.SelectedIndex, RegistryValueKind.String)
        If TTCatComboBox.SelectedIndex = 0 Then
            SearchSet.SetValue("TTSearchCat", 0, RegistryValueKind.String)
        ElseIf TTCatComboBox.SelectedIndex = 1 Then
            SearchSet.SetValue("TTSearchCat", 1, RegistryValueKind.String)
        ElseIf TTCatComboBox.SelectedIndex = 2 Then
            SearchSet.SetValue("TTSearchCat", 2, RegistryValueKind.String)
        ElseIf TTCatComboBox.SelectedIndex = 3 Then
            SearchSet.SetValue("TTSearchCat", 5, RegistryValueKind.String)
        ElseIf TTCatComboBox.SelectedIndex = 4 Then
            SearchSet.SetValue("TTSearchCat", 7, RegistryValueKind.String)
        End If
        If TTSizeCheckBox.Checked = True Then
            SearchSet.SetValue("TTMinSize", MinSizeTextBox.Text, RegistryValueKind.String)
            SearchSet.SetValue("TTMaxSize", MaxSizeTextBox.Text, RegistryValueKind.String)
        Else
            SearchSet.SetValue("TTMinSize", "", RegistryValueKind.String)
            SearchSet.SetValue("TTMaxSize", "", RegistryValueKind.String)
        End If
        If SubmitterCheckBox.Checked = True Then
            SearchSet.SetValue("TTSubmitter", SubmitterTextBox.Text, RegistryValueKind.String)
        Else
            SearchSet.SetValue("TTSubmitter", "", RegistryValueKind.String)
        End If
        SystemSet.SetValue("ImageFiltering", ImageFilteringComboBox.SelectedIndex, RegistryValueKind.String)
        MsgBox("저장되었습니다. 일부 옵션은 프로그램 재시작 후 적용됩니다.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "완료")
        Me.Close()
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click

    End Sub

    Private Sub AvailiableListComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AvailiableListComboBox.SelectedIndexChanged
        If AvailiableListComboBox.SelectedIndex = -1 Then
            AvailiableListDownloadButton.Enabled = False
        Else
            Dim GetLoadedList As Integer = MainForm.LoadedListStatus
            Dim getCurrentList As Integer = MainForm.INIRead("DLCL", "CurrentList", MainForm.ACDataFolder & "\DLCList.ini")
            If GetLoadedList = 0 Then
                If AvailiableListComboBox.SelectedIndex = getCurrentList - 1 Then
                    AvailiableListDownloadButton.Enabled = False
                    AvailiableListDownloadButton.Width = 155
                    AvailiableListDownloadButton.Text = "현재 다운로드한 리스트"
                Else
                    AvailiableListDownloadButton.Enabled = True
                    AvailiableListDownloadButton.Width = 75
                    AvailiableListDownloadButton.Text = "다운로드"
                End If
            Else
                If AvailiableListComboBox.SelectedIndex = GetLoadedList - 1 Then
                    AvailiableListDownloadButton.Enabled = False
                    AvailiableListDownloadButton.Width = 155
                    AvailiableListDownloadButton.Text = "현재 다운로드한 리스트"
                Else
                    AvailiableListDownloadButton.Enabled = True
                    AvailiableListDownloadButton.Width = 75
                    AvailiableListDownloadButton.Text = "다운로드"
                End If
            End If
        End If
    End Sub

    Private Sub AvailiableListDownloadButton_Click(sender As Object, e As EventArgs) Handles AvailiableListDownloadButton.Click
        Dim getSelectedListLocate As String = MainForm.INIRead("DLCL", "List" & AvailiableListComboBox.SelectedIndex + 1 & "Location", MainForm.ACDataFolder & "\DLCList.ini")
        MainForm.AnimationListBox.Items.Clear()
        MainForm.SearchListBox.Items.Clear()
        MainForm.SubListBox.Items.Clear()
        If My.Computer.FileSystem.FileExists(MainForm.ACDataFolder & "\AnimationCheckerProList.ini") Then
            My.Computer.FileSystem.DeleteFile(MainForm.ACDataFolder & "\AnimationCheckerProList.ini")
        End If
        Try
            My.Computer.Network.DownloadFile("http://gkskvhtm403.cafe24.com/" & getSelectedListLocate, MainForm.ACDataFolder & "\AnimationCheckerProList.ini")
            MainForm.Listloading()
            MainForm.LoadedListStatus = AvailiableListComboBox.SelectedIndex + 1
        Catch ex As Exception
            MsgBox("다운로드에 실패하였습니다! 인터넷 문제일수있습니다.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "오류")
        End Try
        MainForm.SearchListBox.Items.Add("애니메이션을 선택하세요")
        MainForm.SubListBox.Items.Add("애니메이션을 선택하세요")
        MsgBox("다운로드가 완료되었습니다.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "완료")
        Me.Close()
    End Sub

    Private Sub TTSizeCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles TTSizeCheckBox.CheckedChanged
        If TTSizeCheckBox.Checked = True Then
            TTSizeGroupPanel.Enabled = True
        Else
            TTSizeGroupPanel.Enabled = False
        End If
    End Sub

    Private Sub SubmitterCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles SubmitterCheckBox.CheckedChanged
        If SubmitterCheckBox.Checked = True Then
            SubmitterTextBox.Enabled = True
        Else
            SubmitterTextBox.Enabled = False
        End If
    End Sub

    Private Sub MaxSizeTextBox_TextChanged(sender As Object, e As EventArgs) Handles MaxSizeTextBox.TextChanged
        If IsNumeric(MaxSizeTextBox.Text) = False And Not MaxSizeTextBox.Text = "" Then
            MsgBox("숫자만 입력 가능합니다.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "오류")
            MaxSizeTextBox.Text = ""
        End If
    End Sub

    Private Sub MinSizeTextBox_TextChanged(sender As Object, e As EventArgs) Handles MinSizeTextBox.TextChanged
        If IsNumeric(MinSizeTextBox.Text) = False And Not MinSizeTextBox.Text = "" Then
            MsgBox("숫자만 입력 가능합니다.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "오류")
            MinSizeTextBox.Text = ""
        End If
    End Sub

    Private Sub WebReachTestPanel_Paint(sender As Object, e As PaintEventArgs) Handles WebReachTestPanel.Paint

    End Sub

    Private Sub ReTestButton_Click(sender As Object, e As EventArgs) Handles ReTestButton.Click
        MainForm.PingTestStatus = 0
        MainForm.NTStatus = "LOADING"
        MainForm.TTStatus = "LOADING"
        MainForm.GStatus = "LOADING"
        NTSRLabel.Text = "LOADING"
        TTSRLabel.Text = "LOADING"
        GTRLabel.Text = "LOADING"
        ReTestButton.Text = "진행중"
        ReTestButton.Enabled = False
        MainForm.PingBackgroundWorker.RunWorkerAsync()
    End Sub
End Class