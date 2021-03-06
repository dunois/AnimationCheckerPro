﻿Imports System.Net
Imports System.IO
Imports Microsoft.Win32
Imports System.Text.RegularExpressions

Public Class ProgramOption
    Dim TrayOption As String = XMLReader(MainForm.SettingFileLocation, "System", "SystemTray")
    Dim CloseAlertOption As String = XMLReader(MainForm.SettingFileLocation, "System", "CloseAlert")
    Dim ImageFilerOption As String = XMLReader(MainForm.SettingFileLocation, "System", "ImageFilter")
    Dim AniFolderPath As String = XMLReader(MainForm.SettingFileLocation, "System", "AniFolder")
    Dim ActionTypeOption As String = XMLReader(MainForm.SettingFileLocation, "System", "ActionType")
    Dim NTCatOption As String = XMLReader(MainForm.SettingFileLocation, "System", "NTCat")
    Dim NTFilterOption As String = XMLReader(MainForm.SettingFileLocation, "System", "NTFilter")
    Dim DLCCheck As Boolean = False

    Private Sub ProgramOption_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ListDate As String = MainForm.INIRead("System", "ListDate", MainForm.ACDataFolder & "\AnimationCheckerProList.ini")
        Dim ListProducer As String = MainForm.INIRead("System", "ListProducer", MainForm.ACDataFolder & "\AnimationCheckerProList.ini")
        TrayOption = XMLReader(MainForm.SettingFileLocation, "System", "SystemTray")
        CloseAlertOption = XMLReader(MainForm.SettingFileLocation, "System", "CloseAlert")
        ImageFilerOption = XMLReader(MainForm.SettingFileLocation, "System", "ImageFilter")
        AniFolderPath = XMLReader(MainForm.SettingFileLocation, "System", "AniFolder")
        ActionTypeOption = XMLReader(MainForm.SettingFileLocation, "System", "ActionType")
        NTCatOption = XMLReader(MainForm.SettingFileLocation, "System", "NTCat")
        NTFilterOption = XMLReader(MainForm.SettingFileLocation, "System", "NTFilter")
        SystemTrayComboBox.SelectedIndex = TrayOption
        CloseAlertComboBox.SelectedIndex = CloseAlertOption
        ImageFilteringComboBox.SelectedIndex = ImageFilerOption
        ButtonActionComboBox.SelectedIndex = ActionTypeOption
        If NTCatOption = "1_11" Then
            NTCatComboBox.SelectedIndex = 0
        ElseIf NTCatOption = "0_0" Then
            NTCatComboBox.SelectedIndex = 1
        ElseIf NTCatOption = "1_0" Then
            NTCatComboBox.SelectedIndex = 2
        ElseIf NTCatOption = "3_0" Then
            NTCatComboBox.SelectedIndex = 3
        ElseIf NTCatOption = "3_14" Then
            NTCatComboBox.SelectedIndex = 4
        ElseIf NTCatOption = "3_15" Then
            NTCatComboBox.SelectedIndex = 5
        End If
        NTFilterComboBox.SelectedIndex = NTFilterOption
        If AniFolderPath = "None" Then
            AnimationFolderTextBox.Text = ""
            AnimationFolderSetCheckBox.Checked = False
        Else
            AnimationFolderTextBox.Text = AniFolderPath
            AnimationFolderSetCheckBox.Checked = True
        End If
        ListDateLabel.Text = ListDate
        ListProducerLabel.Text = ListProducer
        OptionPreset.SelectedIndex = 0

    End Sub

    Private Sub OptionTreeView_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles OptionTreeView.AfterSelect
        OptionTab.Text = OptionTreeView.SelectedNode.Text
        If OptionTreeView.SelectedNode.Name = "CommonConfigNode" Then
            ProgramConfigPanel.BringToFront()
        ElseIf OptionTreeView.SelectedNode.Name = "ListConfigNode" Then
            ListInfoPanel.BringToFront()
        ElseIf OptionTreeView.SelectedNode.Name = "AvailiableListShowNode" Then
            AvailiableListPanel.BringToFront()
            AvailiableListComboBox.Items.Clear()
            If My.Computer.FileSystem.FileExists(MainForm.ACDataFolder & "\DownloadableList.ini") Then
                My.Computer.FileSystem.DeleteFile(MainForm.ACDataFolder & "\DownloadableList.ini")
            End If
            Try
                AvailiableListDownloadButton.Enabled = True
                My.Computer.Network.DownloadFile("http://dunois403.cafe24.com/ACPData/DLCList.ini", MainForm.ACDataFolder & "\DownloadableList.ini")
                AvailiableListComboBox.Items.Clear()
                Dim DLCListNumber As Integer = MainForm.INIRead("DLCL", "Number", MainForm.ACDataFolder & "\DownloadableList.ini")
                For i As Integer = 1 To DLCListNumber
                    Dim DLCListName As String = MainForm.INIRead("DLCL", "List" & i, MainForm.ACDataFolder & "\DownloadableList.ini")
                    AvailiableListComboBox.Items.Add(DLCListName)
                Next
                For i As Integer = 1 To DLCListNumber
                    Dim DLCListQut As String = MainForm.INIRead("DLCL", "List" & i & "Qut", MainForm.ACDataFolder & "\DownloadableList.ini")
                    If DLCListQut = MainForm.ListQuater Then
                        AvailiableListComboBox.SelectedIndex = i - 1
                        Exit For
                    End If
                Next
                DLCCheck = False
            Catch ex As Exception
                MsgBox("다운로드 가능한 리스트를 가져올 수 없습니다.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "오류")
                AvailiableListComboBox.Items.Add("불러오기 실패")
                AvailiableListComboBox.SelectedIndex = 0
                AvailiableListDownloadButton.Enabled = False
                DLCCheck = True
            End Try
        ElseIf OptionTreeView.SelectedNode.Name = "ExpandModeSetting" Then
            ExpandModePanel.BringToFront()
        ElseIf OptionTreeView.SelectedNode.Name = "NTSearchSettingNode" Then
            NTSetPanel.BringToFront()
        ElseIf OptionTreeView.SelectedNode.Name = "SiteStatusNode" Then
            WebReachTestPanel.BringToFront()
            ReTestButton.Enabled = True
            ReTestButton.Text = "다시 테스트"
            NTSRLabel.Text = MainForm.NTStatus & " / " & MainForm.NTTime & "초"
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

    Private Sub FormCloseButton_Click(sender As Object, e As EventArgs) Handles FormCloseButton.Click
        Me.Close()
    End Sub

    Private Sub AvailiableListComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AvailiableListComboBox.SelectedIndexChanged
        If AvailiableListComboBox.SelectedIndex = -1 Then
            AvailiableListDownloadButton.Enabled = False
        Else
            Dim getSelectListQut As String = MainForm.INIRead("DLCL", "List" & AvailiableListComboBox.SelectedIndex + 1 & "Qut", MainForm.ACDataFolder & "\DownloadableList.ini")
            If getSelectListQut = MainForm.ListQuater Then
                AvailiableListDownloadButton.Enabled = False
                AvailiableListDownloadButton.Width = 155
                AvailiableListDownloadButton.Text = "현재 다운로드한 리스트"
            ElseIf DLCCheck = True Then
                AvailiableListDownloadButton.Enabled = False
            Else
                AvailiableListDownloadButton.Enabled = True
                AvailiableListDownloadButton.Width = 75
                AvailiableListDownloadButton.Text = "다운로드"
            End If
        End If
    End Sub

    Private Sub AvailiableListDownloadButton_Click(sender As Object, e As EventArgs) Handles AvailiableListDownloadButton.Click
        Dim getSelectedListLocate As String = MainForm.INIRead("DLCL", "List" & AvailiableListComboBox.SelectedIndex + 1 & "Location", MainForm.ACDataFolder & "\DownloadableList.ini")
        Dim getSelectedListQut As String = MainForm.INIRead("DLCL", "List" & AvailiableListComboBox.SelectedIndex + 1 & "Qut", MainForm.ACDataFolder & "\DownloadableList.ini")
        If My.Computer.FileSystem.FileExists(MainForm.ACDataFolder & "\AnimationCheckerProList.ini") Then
            My.Computer.FileSystem.DeleteFile(MainForm.ACDataFolder & "\AnimationCheckerProList.ini")
        End If
        Try
            My.Computer.Network.DownloadFile("http://dunois403.cafe24.com/" & getSelectedListLocate, MainForm.ACDataFolder & "\AnimationCheckerProList.ini")
            MainForm.AnimationListBox.Items.Clear()
            MainForm.SearchListBox.Items.Clear()
            MainForm.SubListBox.Items.Clear()
            MainForm.Listloading()
            MainForm.ListQuater = getSelectedListQut
            MainForm.SearchListBox.Items.Add("애니메이션을 선택하세요")
            MainForm.SubListBox.Items.Add("애니메이션을 선택하세요")
            MsgBox("다운로드가 완료되었습니다.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "완료")
            AvailiableListDownloadButton.Enabled = False
            AvailiableListDownloadButton.Width = 155
            AvailiableListDownloadButton.Text = "현재 다운로드한 리스트"
            'MainForm.ListDateLabel.Text = MainForm.INIRead("System", "ListDate", MainForm.ACDataFolder & "\AnimationCheckerProList.ini")
        Catch ex As Exception
            MsgBox("선택한 리스트를 다운로드 할 수 없습니다.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "오류")
        End Try
    End Sub

    Private Sub ReTestButton_Click(sender As Object, e As EventArgs) Handles ReTestButton.Click
        MainForm.PingTestStatus = 0
        MainForm.NTStatus = "LOADING"
        MainForm.GStatus = "LOADING"
        NTSRLabel.Text = "LOADING"
        GTRLabel.Text = "LOADING"
        ReTestButton.Text = "진행중"
        ReTestButton.Enabled = False
        MainForm.PingBackgroundWorker.RunWorkerAsync()
    End Sub

    Private Sub OptionSaveButton_Click(sender As Object, e As EventArgs) Handles OptionSaveButton.Click
        XMLWriter(MainForm.SettingFileLocation, "System", "ActionType", ButtonActionComboBox.SelectedIndex)
        XMLWriter(MainForm.SettingFileLocation, "System", "CloseAlert", CloseAlertComboBox.SelectedIndex)
        XMLWriter(MainForm.SettingFileLocation, "System", "ImageFilter", ImageFilteringComboBox.SelectedIndex)
        XMLWriter(MainForm.SettingFileLocation, "System", "NTFilter", NTFilterComboBox.SelectedIndex)
        XMLWriter(MainForm.SettingFileLocation, "System", "SystemTray", SystemTrayComboBox.SelectedIndex)
        If NTCatComboBox.SelectedIndex = 0 Then
            XMLWriter(MainForm.SettingFileLocation, "System", "NTCat", "1_11")
        ElseIf NTCatComboBox.SelectedIndex = 1 Then
            XMLWriter(MainForm.SettingFileLocation, "System", "NTCat", "0_0")
        ElseIf NTCatComboBox.SelectedIndex = 2 Then
            XMLWriter(MainForm.SettingFileLocation, "System", "NTCat", "1_0")
        ElseIf NTCatComboBox.SelectedIndex = 3 Then
            XMLWriter(MainForm.SettingFileLocation, "System", "NTCat", "3_0")
        ElseIf NTCatComboBox.SelectedIndex = 4 Then
            XMLWriter(MainForm.SettingFileLocation, "System", "NTCat", "3_14")
        ElseIf NTCatComboBox.SelectedIndex = 5 Then
            XMLWriter(MainForm.SettingFileLocation, "System", "NTCat", "3_15")
        End If
        If SystemTrayComboBox.SelectedIndex = 1 Then
            MainForm.NotifyIcon.Visible = True
        Else
            MainForm.NotifyIcon.Visible = False
        End If
        If ButtonActionComboBox.SelectedIndex = 1 Then
            MainForm.SearchButton.Visible = False
            MainForm.SubLinkButton.Visible = False
        Else
            MainForm.SearchButton.Visible = True
            MainForm.SubLinkButton.Visible = True
        End If
        MsgBox("저장되었습니다.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "완료")
        Refresh()
        Close()
    End Sub
End Class