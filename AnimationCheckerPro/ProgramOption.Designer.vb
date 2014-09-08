<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProgramOption
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("확장모드 설정")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("프로그램 설정", New System.Windows.Forms.TreeNode() {TreeNode1})
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("리스트 정보")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("다운로드 가능한 리스트")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("리스트 설정", New System.Windows.Forms.TreeNode() {TreeNode3, TreeNode4})
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("냐토렌트 검색 설정")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("도쿄도서관 검색 설정")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("사이트 현황")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("검색엔진 설정", New System.Windows.Forms.TreeNode() {TreeNode6, TreeNode7, TreeNode8})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProgramOption))
        Me.OptionTreeView = New System.Windows.Forms.TreeView()
        Me.OptionPresetChooseComboBox = New System.Windows.Forms.ComboBox()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.SaveSettingButton = New System.Windows.Forms.Button()
        Me.OptionTab = New System.Windows.Forms.GroupBox()
        Me.ProgramConfigPanel = New System.Windows.Forms.Panel()
        Me.ImageModeComboBox = New System.Windows.Forms.ComboBox()
        Me.ImageModeLabel = New System.Windows.Forms.Label()
        Me.NoticeRecvComboBox = New System.Windows.Forms.ComboBox()
        Me.NoticeRecvLabel = New System.Windows.Forms.Label()
        Me.ProgramModeComboBox = New System.Windows.Forms.ComboBox()
        Me.ProgramModeLabel = New System.Windows.Forms.Label()
        Me.AnimationFolderSetButton = New System.Windows.Forms.Button()
        Me.AnimationFolderTextBox = New System.Windows.Forms.TextBox()
        Me.AnimationFolderSetCheckBox = New System.Windows.Forms.CheckBox()
        Me.SplitLabel = New System.Windows.Forms.Label()
        Me.CloseAlertComboBox = New System.Windows.Forms.ComboBox()
        Me.CloseAlertLabel = New System.Windows.Forms.Label()
        Me.SystemTrayComboBox = New System.Windows.Forms.ComboBox()
        Me.SystemTrayLabel = New System.Windows.Forms.Label()
        Me.ListInfoPanel = New System.Windows.Forms.Panel()
        Me.ListProducerLabel = New System.Windows.Forms.Label()
        Me.ListProducerInfoLabel = New System.Windows.Forms.Label()
        Me.ListDateLabel = New System.Windows.Forms.Label()
        Me.ListDateInfoLabel = New System.Windows.Forms.Label()
        Me.ListSettingPanel = New System.Windows.Forms.Panel()
        Me.OldListComboBox = New System.Windows.Forms.ComboBox()
        Me.CheckOldListLabel = New System.Windows.Forms.Label()
        Me.AvailiableListPanel = New System.Windows.Forms.Panel()
        Me.AvailiableListDownloadButton = New System.Windows.Forms.Button()
        Me.AvailiableListLabel = New System.Windows.Forms.Label()
        Me.AvailiableListComboBox = New System.Windows.Forms.ComboBox()
        Me.ExpandModePanel = New System.Windows.Forms.Panel()
        Me.ActionSettingGroupBox = New System.Windows.Forms.GroupBox()
        Me.ActionSetLabel = New System.Windows.Forms.Label()
        Me.ButtonActionComboBox = New System.Windows.Forms.ComboBox()
        Me.WebReachTestPanel = New System.Windows.Forms.Panel()
        Me.ReTestButton = New System.Windows.Forms.Button()
        Me.GTRLabel = New System.Windows.Forms.Label()
        Me.TTSRLabel = New System.Windows.Forms.Label()
        Me.NTSRLabel = New System.Windows.Forms.Label()
        Me.GTLabel = New System.Windows.Forms.Label()
        Me.TTSTLabel = New System.Windows.Forms.Label()
        Me.NTSTLabel = New System.Windows.Forms.Label()
        Me.TTSetPanel = New System.Windows.Forms.Panel()
        Me.SubmitterTextBox = New System.Windows.Forms.TextBox()
        Me.SubmitterCheckBox = New System.Windows.Forms.CheckBox()
        Me.TTSizeGroupPanel = New System.Windows.Forms.Panel()
        Me.MaxSizeTextBox = New System.Windows.Forms.TextBox()
        Me.MaxSizeLabel = New System.Windows.Forms.Label()
        Me.MinSizeLabel = New System.Windows.Forms.Label()
        Me.MinSizeTextBox = New System.Windows.Forms.TextBox()
        Me.TTSizeCheckBox = New System.Windows.Forms.CheckBox()
        Me.TTCatComboBox = New System.Windows.Forms.ComboBox()
        Me.TTCatLabel = New System.Windows.Forms.Label()
        Me.NTSetPanel = New System.Windows.Forms.Panel()
        Me.SearchCatLabel = New System.Windows.Forms.Label()
        Me.SearchCatComboBox = New System.Windows.Forms.ComboBox()
        Me.SearchFilterLabel = New System.Windows.Forms.Label()
        Me.SearchFilterComboBox = New System.Windows.Forms.ComboBox()
        Me.OptionSaveButton = New System.Windows.Forms.Button()
        Me.FormCloseButton = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.OptionTab.SuspendLayout()
        Me.ProgramConfigPanel.SuspendLayout()
        Me.ListInfoPanel.SuspendLayout()
        Me.ListSettingPanel.SuspendLayout()
        Me.AvailiableListPanel.SuspendLayout()
        Me.ExpandModePanel.SuspendLayout()
        Me.ActionSettingGroupBox.SuspendLayout()
        Me.WebReachTestPanel.SuspendLayout()
        Me.TTSetPanel.SuspendLayout()
        Me.TTSizeGroupPanel.SuspendLayout()
        Me.NTSetPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'OptionTreeView
        '
        Me.OptionTreeView.Location = New System.Drawing.Point(12, 38)
        Me.OptionTreeView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OptionTreeView.Name = "OptionTreeView"
        TreeNode1.Name = "ExpandModeSetting"
        TreeNode1.Text = "확장모드 설정"
        TreeNode2.Name = "CommonConfigNode"
        TreeNode2.Text = "프로그램 설정"
        TreeNode3.Name = "ListInformationNode"
        TreeNode3.Text = "리스트 정보"
        TreeNode4.Name = "AvailiableListShowNode"
        TreeNode4.Text = "다운로드 가능한 리스트"
        TreeNode5.Name = "ListConfigNode"
        TreeNode5.Text = "리스트 설정"
        TreeNode6.Name = "NTSearchSettingNode"
        TreeNode6.Text = "냐토렌트 검색 설정"
        TreeNode7.Name = "TTSearchSettingNode"
        TreeNode7.Text = "도쿄도서관 검색 설정"
        TreeNode8.Name = "SiteStatusNode"
        TreeNode8.Text = "사이트 현황"
        TreeNode9.Name = "SearchEngineNode"
        TreeNode9.Text = "검색엔진 설정"
        Me.OptionTreeView.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode2, TreeNode5, TreeNode9})
        Me.OptionTreeView.Size = New System.Drawing.Size(255, 357)
        Me.OptionTreeView.TabIndex = 1
        '
        'OptionPresetChooseComboBox
        '
        Me.OptionPresetChooseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.OptionPresetChooseComboBox.FormattingEnabled = True
        Me.OptionPresetChooseComboBox.Items.AddRange(New Object() {"기본설정"})
        Me.OptionPresetChooseComboBox.Location = New System.Drawing.Point(12, 8)
        Me.OptionPresetChooseComboBox.Name = "OptionPresetChooseComboBox"
        Me.OptionPresetChooseComboBox.Size = New System.Drawing.Size(255, 23)
        Me.OptionPresetChooseComboBox.TabIndex = 2
        '
        'ResetButton
        '
        Me.ResetButton.Enabled = False
        Me.ResetButton.Location = New System.Drawing.Point(12, 402)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(120, 23)
        Me.ResetButton.TabIndex = 3
        Me.ResetButton.Text = "초기화"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'SaveSettingButton
        '
        Me.SaveSettingButton.Enabled = False
        Me.SaveSettingButton.Location = New System.Drawing.Point(147, 402)
        Me.SaveSettingButton.Name = "SaveSettingButton"
        Me.SaveSettingButton.Size = New System.Drawing.Size(120, 23)
        Me.SaveSettingButton.TabIndex = 4
        Me.SaveSettingButton.Text = "파일로 저장"
        Me.SaveSettingButton.UseVisualStyleBackColor = True
        '
        'OptionTab
        '
        Me.OptionTab.Controls.Add(Me.ProgramConfigPanel)
        Me.OptionTab.Controls.Add(Me.ListInfoPanel)
        Me.OptionTab.Controls.Add(Me.ListSettingPanel)
        Me.OptionTab.Controls.Add(Me.AvailiableListPanel)
        Me.OptionTab.Controls.Add(Me.ExpandModePanel)
        Me.OptionTab.Controls.Add(Me.WebReachTestPanel)
        Me.OptionTab.Controls.Add(Me.TTSetPanel)
        Me.OptionTab.Controls.Add(Me.NTSetPanel)
        Me.OptionTab.Location = New System.Drawing.Point(287, 0)
        Me.OptionTab.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OptionTab.Name = "OptionTab"
        Me.OptionTab.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OptionTab.Size = New System.Drawing.Size(467, 391)
        Me.OptionTab.TabIndex = 0
        Me.OptionTab.TabStop = False
        '
        'ProgramConfigPanel
        '
        Me.ProgramConfigPanel.Controls.Add(Me.ImageModeComboBox)
        Me.ProgramConfigPanel.Controls.Add(Me.ImageModeLabel)
        Me.ProgramConfigPanel.Controls.Add(Me.NoticeRecvComboBox)
        Me.ProgramConfigPanel.Controls.Add(Me.NoticeRecvLabel)
        Me.ProgramConfigPanel.Controls.Add(Me.ProgramModeComboBox)
        Me.ProgramConfigPanel.Controls.Add(Me.ProgramModeLabel)
        Me.ProgramConfigPanel.Controls.Add(Me.AnimationFolderSetButton)
        Me.ProgramConfigPanel.Controls.Add(Me.AnimationFolderTextBox)
        Me.ProgramConfigPanel.Controls.Add(Me.AnimationFolderSetCheckBox)
        Me.ProgramConfigPanel.Controls.Add(Me.SplitLabel)
        Me.ProgramConfigPanel.Controls.Add(Me.CloseAlertComboBox)
        Me.ProgramConfigPanel.Controls.Add(Me.CloseAlertLabel)
        Me.ProgramConfigPanel.Controls.Add(Me.SystemTrayComboBox)
        Me.ProgramConfigPanel.Controls.Add(Me.SystemTrayLabel)
        Me.ProgramConfigPanel.Location = New System.Drawing.Point(6, 22)
        Me.ProgramConfigPanel.Name = "ProgramConfigPanel"
        Me.ProgramConfigPanel.Size = New System.Drawing.Size(446, 362)
        Me.ProgramConfigPanel.TabIndex = 0
        '
        'ImageModeComboBox
        '
        Me.ImageModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ImageModeComboBox.FormattingEnabled = True
        Me.ImageModeComboBox.Items.AddRange(New Object() {"원본", "오토 사이즈"})
        Me.ImageModeComboBox.Location = New System.Drawing.Point(231, 196)
        Me.ImageModeComboBox.Name = "ImageModeComboBox"
        Me.ImageModeComboBox.Size = New System.Drawing.Size(140, 23)
        Me.ImageModeComboBox.TabIndex = 17
        '
        'ImageModeLabel
        '
        Me.ImageModeLabel.AutoSize = True
        Me.ImageModeLabel.Location = New System.Drawing.Point(129, 199)
        Me.ImageModeLabel.Name = "ImageModeLabel"
        Me.ImageModeLabel.Size = New System.Drawing.Size(80, 15)
        Me.ImageModeLabel.TabIndex = 16
        Me.ImageModeLabel.Text = "이미지 모드 : "
        '
        'NoticeRecvComboBox
        '
        Me.NoticeRecvComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.NoticeRecvComboBox.FormattingEnabled = True
        Me.NoticeRecvComboBox.Items.AddRange(New Object() {"수신함", "수신하지 않음"})
        Me.NoticeRecvComboBox.Location = New System.Drawing.Point(231, 152)
        Me.NoticeRecvComboBox.Name = "NoticeRecvComboBox"
        Me.NoticeRecvComboBox.Size = New System.Drawing.Size(140, 23)
        Me.NoticeRecvComboBox.TabIndex = 15
        '
        'NoticeRecvLabel
        '
        Me.NoticeRecvLabel.AutoSize = True
        Me.NoticeRecvLabel.Location = New System.Drawing.Point(120, 155)
        Me.NoticeRecvLabel.Name = "NoticeRecvLabel"
        Me.NoticeRecvLabel.Size = New System.Drawing.Size(92, 15)
        Me.NoticeRecvLabel.TabIndex = 14
        Me.NoticeRecvLabel.Text = "공지사항 수신 : "
        '
        'ProgramModeComboBox
        '
        Me.ProgramModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ProgramModeComboBox.FormattingEnabled = True
        Me.ProgramModeComboBox.Items.AddRange(New Object() {"미니 모드", "확장 모드"})
        Me.ProgramModeComboBox.Location = New System.Drawing.Point(231, 103)
        Me.ProgramModeComboBox.Name = "ProgramModeComboBox"
        Me.ProgramModeComboBox.Size = New System.Drawing.Size(140, 23)
        Me.ProgramModeComboBox.TabIndex = 13
        '
        'ProgramModeLabel
        '
        Me.ProgramModeLabel.AutoSize = True
        Me.ProgramModeLabel.Location = New System.Drawing.Point(120, 109)
        Me.ProgramModeLabel.Name = "ProgramModeLabel"
        Me.ProgramModeLabel.Size = New System.Drawing.Size(92, 15)
        Me.ProgramModeLabel.TabIndex = 12
        Me.ProgramModeLabel.Text = "프로그램 모드 : "
        '
        'AnimationFolderSetButton
        '
        Me.AnimationFolderSetButton.Enabled = False
        Me.AnimationFolderSetButton.Location = New System.Drawing.Point(345, 306)
        Me.AnimationFolderSetButton.Name = "AnimationFolderSetButton"
        Me.AnimationFolderSetButton.Size = New System.Drawing.Size(75, 23)
        Me.AnimationFolderSetButton.TabIndex = 11
        Me.AnimationFolderSetButton.Text = "폴더 지정"
        Me.AnimationFolderSetButton.UseVisualStyleBackColor = True
        '
        'AnimationFolderTextBox
        '
        Me.AnimationFolderTextBox.Location = New System.Drawing.Point(65, 307)
        Me.AnimationFolderTextBox.Name = "AnimationFolderTextBox"
        Me.AnimationFolderTextBox.ReadOnly = True
        Me.AnimationFolderTextBox.Size = New System.Drawing.Size(274, 22)
        Me.AnimationFolderTextBox.TabIndex = 10
        '
        'AnimationFolderSetCheckBox
        '
        Me.AnimationFolderSetCheckBox.AutoSize = True
        Me.AnimationFolderSetCheckBox.Location = New System.Drawing.Point(37, 282)
        Me.AnimationFolderSetCheckBox.Name = "AnimationFolderSetCheckBox"
        Me.AnimationFolderSetCheckBox.Size = New System.Drawing.Size(255, 19)
        Me.AnimationFolderSetCheckBox.TabIndex = 9
        Me.AnimationFolderSetCheckBox.Text = "애니메이션이 저장되는 폴더를 지정합니다."
        Me.AnimationFolderSetCheckBox.UseVisualStyleBackColor = True
        '
        'SplitLabel
        '
        Me.SplitLabel.AutoSize = True
        Me.SplitLabel.Location = New System.Drawing.Point(4, 244)
        Me.SplitLabel.Name = "SplitLabel"
        Me.SplitLabel.Size = New System.Drawing.Size(439, 15)
        Me.SplitLabel.TabIndex = 8
        Me.SplitLabel.Text = "────────────────────────────────────"
        '
        'CloseAlertComboBox
        '
        Me.CloseAlertComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CloseAlertComboBox.FormattingEnabled = True
        Me.CloseAlertComboBox.Items.AddRange(New Object() {"항상 표시", "표시하지 않음"})
        Me.CloseAlertComboBox.Location = New System.Drawing.Point(231, 58)
        Me.CloseAlertComboBox.Name = "CloseAlertComboBox"
        Me.CloseAlertComboBox.Size = New System.Drawing.Size(140, 23)
        Me.CloseAlertComboBox.TabIndex = 3
        '
        'CloseAlertLabel
        '
        Me.CloseAlertLabel.AutoSize = True
        Me.CloseAlertLabel.Location = New System.Drawing.Point(42, 66)
        Me.CloseAlertLabel.Name = "CloseAlertLabel"
        Me.CloseAlertLabel.Size = New System.Drawing.Size(170, 15)
        Me.CloseAlertLabel.TabIndex = 2
        Me.CloseAlertLabel.Text = "프로그램 닫기시 경고창 표시 : "
        '
        'SystemTrayComboBox
        '
        Me.SystemTrayComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SystemTrayComboBox.FormattingEnabled = True
        Me.SystemTrayComboBox.Items.AddRange(New Object() {"트레이 아이콘 항상 표시", "최소화시 표시", "닫기버튼 클릭시 표시", "표시하지 않음"})
        Me.SystemTrayComboBox.Location = New System.Drawing.Point(231, 16)
        Me.SystemTrayComboBox.Name = "SystemTrayComboBox"
        Me.SystemTrayComboBox.Size = New System.Drawing.Size(140, 23)
        Me.SystemTrayComboBox.TabIndex = 1
        '
        'SystemTrayLabel
        '
        Me.SystemTrayLabel.AutoSize = True
        Me.SystemTrayLabel.Location = New System.Drawing.Point(78, 25)
        Me.SystemTrayLabel.Name = "SystemTrayLabel"
        Me.SystemTrayLabel.Size = New System.Drawing.Size(131, 15)
        Me.SystemTrayLabel.TabIndex = 0
        Me.SystemTrayLabel.Text = "시스템 트레이로 표시 : "
        '
        'ListInfoPanel
        '
        Me.ListInfoPanel.Controls.Add(Me.ListProducerLabel)
        Me.ListInfoPanel.Controls.Add(Me.ListProducerInfoLabel)
        Me.ListInfoPanel.Controls.Add(Me.ListDateLabel)
        Me.ListInfoPanel.Controls.Add(Me.ListDateInfoLabel)
        Me.ListInfoPanel.Location = New System.Drawing.Point(6, 22)
        Me.ListInfoPanel.Name = "ListInfoPanel"
        Me.ListInfoPanel.Size = New System.Drawing.Size(446, 362)
        Me.ListInfoPanel.TabIndex = 7
        '
        'ListProducerLabel
        '
        Me.ListProducerLabel.AutoSize = True
        Me.ListProducerLabel.Location = New System.Drawing.Point(159, 51)
        Me.ListProducerLabel.Name = "ListProducerLabel"
        Me.ListProducerLabel.Size = New System.Drawing.Size(61, 15)
        Me.ListProducerLabel.TabIndex = 3
        Me.ListProducerLabel.Text = "LOADING"
        '
        'ListProducerInfoLabel
        '
        Me.ListProducerInfoLabel.AutoSize = True
        Me.ListProducerInfoLabel.Location = New System.Drawing.Point(73, 51)
        Me.ListProducerInfoLabel.Name = "ListProducerInfoLabel"
        Me.ListProducerInfoLabel.Size = New System.Drawing.Size(80, 15)
        Me.ListProducerInfoLabel.TabIndex = 2
        Me.ListProducerInfoLabel.Text = "리스트 제작 : "
        '
        'ListDateLabel
        '
        Me.ListDateLabel.AutoSize = True
        Me.ListDateLabel.Location = New System.Drawing.Point(159, 25)
        Me.ListDateLabel.Name = "ListDateLabel"
        Me.ListDateLabel.Size = New System.Drawing.Size(61, 15)
        Me.ListDateLabel.TabIndex = 1
        Me.ListDateLabel.Text = "LOADING"
        '
        'ListDateInfoLabel
        '
        Me.ListDateInfoLabel.AutoSize = True
        Me.ListDateInfoLabel.Location = New System.Drawing.Point(62, 25)
        Me.ListDateInfoLabel.Name = "ListDateInfoLabel"
        Me.ListDateInfoLabel.Size = New System.Drawing.Size(92, 15)
        Me.ListDateInfoLabel.TabIndex = 0
        Me.ListDateInfoLabel.Text = "리스트 제작일 : "
        '
        'ListSettingPanel
        '
        Me.ListSettingPanel.Controls.Add(Me.OldListComboBox)
        Me.ListSettingPanel.Controls.Add(Me.CheckOldListLabel)
        Me.ListSettingPanel.Location = New System.Drawing.Point(6, 22)
        Me.ListSettingPanel.Name = "ListSettingPanel"
        Me.ListSettingPanel.Size = New System.Drawing.Size(446, 362)
        Me.ListSettingPanel.TabIndex = 4
        '
        'OldListComboBox
        '
        Me.OldListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.OldListComboBox.FormattingEnabled = True
        Me.OldListComboBox.Items.AddRange(New Object() {"항상 확인함", "확인하지 않음"})
        Me.OldListComboBox.Location = New System.Drawing.Point(208, 22)
        Me.OldListComboBox.Name = "OldListComboBox"
        Me.OldListComboBox.Size = New System.Drawing.Size(140, 23)
        Me.OldListComboBox.TabIndex = 1
        '
        'CheckOldListLabel
        '
        Me.CheckOldListLabel.AutoSize = True
        Me.CheckOldListLabel.Location = New System.Drawing.Point(62, 25)
        Me.CheckOldListLabel.Name = "CheckOldListLabel"
        Me.CheckOldListLabel.Size = New System.Drawing.Size(134, 15)
        Me.CheckOldListLabel.TabIndex = 0
        Me.CheckOldListLabel.Text = "구작 리스트 확인 여부 : "
        '
        'AvailiableListPanel
        '
        Me.AvailiableListPanel.Controls.Add(Me.AvailiableListDownloadButton)
        Me.AvailiableListPanel.Controls.Add(Me.AvailiableListLabel)
        Me.AvailiableListPanel.Controls.Add(Me.AvailiableListComboBox)
        Me.AvailiableListPanel.Location = New System.Drawing.Point(6, 22)
        Me.AvailiableListPanel.Name = "AvailiableListPanel"
        Me.AvailiableListPanel.Size = New System.Drawing.Size(446, 362)
        Me.AvailiableListPanel.TabIndex = 14
        '
        'AvailiableListDownloadButton
        '
        Me.AvailiableListDownloadButton.Enabled = False
        Me.AvailiableListDownloadButton.Location = New System.Drawing.Point(208, 191)
        Me.AvailiableListDownloadButton.Name = "AvailiableListDownloadButton"
        Me.AvailiableListDownloadButton.Size = New System.Drawing.Size(75, 23)
        Me.AvailiableListDownloadButton.TabIndex = 2
        Me.AvailiableListDownloadButton.Text = "다운로드"
        Me.AvailiableListDownloadButton.UseVisualStyleBackColor = True
        '
        'AvailiableListLabel
        '
        Me.AvailiableListLabel.AutoSize = True
        Me.AvailiableListLabel.Location = New System.Drawing.Point(150, 117)
        Me.AvailiableListLabel.Name = "AvailiableListLabel"
        Me.AvailiableListLabel.Size = New System.Drawing.Size(133, 15)
        Me.AvailiableListLabel.TabIndex = 1
        Me.AvailiableListLabel.Text = "다운로드 가능한 리스트"
        '
        'AvailiableListComboBox
        '
        Me.AvailiableListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AvailiableListComboBox.FormattingEnabled = True
        Me.AvailiableListComboBox.Location = New System.Drawing.Point(153, 147)
        Me.AvailiableListComboBox.Name = "AvailiableListComboBox"
        Me.AvailiableListComboBox.Size = New System.Drawing.Size(130, 23)
        Me.AvailiableListComboBox.TabIndex = 0
        '
        'ExpandModePanel
        '
        Me.ExpandModePanel.Controls.Add(Me.ActionSettingGroupBox)
        Me.ExpandModePanel.Location = New System.Drawing.Point(6, 22)
        Me.ExpandModePanel.Name = "ExpandModePanel"
        Me.ExpandModePanel.Size = New System.Drawing.Size(446, 362)
        Me.ExpandModePanel.TabIndex = 7
        '
        'ActionSettingGroupBox
        '
        Me.ActionSettingGroupBox.Controls.Add(Me.ActionSetLabel)
        Me.ActionSettingGroupBox.Controls.Add(Me.ButtonActionComboBox)
        Me.ActionSettingGroupBox.Location = New System.Drawing.Point(12, 16)
        Me.ActionSettingGroupBox.Name = "ActionSettingGroupBox"
        Me.ActionSettingGroupBox.Size = New System.Drawing.Size(419, 116)
        Me.ActionSettingGroupBox.TabIndex = 2
        Me.ActionSettingGroupBox.TabStop = False
        Me.ActionSettingGroupBox.Text = "버튼/액션 설정"
        '
        'ActionSetLabel
        '
        Me.ActionSetLabel.Location = New System.Drawing.Point(22, 22)
        Me.ActionSetLabel.Name = "ActionSetLabel"
        Me.ActionSetLabel.Size = New System.Drawing.Size(391, 38)
        Me.ActionSetLabel.TabIndex = 2
        Me.ActionSetLabel.Text = "검색 및 링크 이동을 버튼을 사용하거나 리스트를 더블클릭해 사용할수있습니다"
        '
        'ButtonActionComboBox
        '
        Me.ButtonActionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ButtonActionComboBox.FormattingEnabled = True
        Me.ButtonActionComboBox.Items.AddRange(New Object() {"버튼", "리스트 더블클릭"})
        Me.ButtonActionComboBox.Location = New System.Drawing.Point(42, 67)
        Me.ButtonActionComboBox.Name = "ButtonActionComboBox"
        Me.ButtonActionComboBox.Size = New System.Drawing.Size(158, 23)
        Me.ButtonActionComboBox.TabIndex = 1
        '
        'WebReachTestPanel
        '
        Me.WebReachTestPanel.Controls.Add(Me.ReTestButton)
        Me.WebReachTestPanel.Controls.Add(Me.GTRLabel)
        Me.WebReachTestPanel.Controls.Add(Me.TTSRLabel)
        Me.WebReachTestPanel.Controls.Add(Me.NTSRLabel)
        Me.WebReachTestPanel.Controls.Add(Me.GTLabel)
        Me.WebReachTestPanel.Controls.Add(Me.TTSTLabel)
        Me.WebReachTestPanel.Controls.Add(Me.NTSTLabel)
        Me.WebReachTestPanel.Location = New System.Drawing.Point(6, 22)
        Me.WebReachTestPanel.Name = "WebReachTestPanel"
        Me.WebReachTestPanel.Size = New System.Drawing.Size(446, 362)
        Me.WebReachTestPanel.TabIndex = 15
        '
        'ReTestButton
        '
        Me.ReTestButton.Enabled = False
        Me.ReTestButton.Location = New System.Drawing.Point(333, 12)
        Me.ReTestButton.Name = "ReTestButton"
        Me.ReTestButton.Size = New System.Drawing.Size(96, 23)
        Me.ReTestButton.TabIndex = 6
        Me.ReTestButton.Text = "다시 테스트"
        Me.ReTestButton.UseVisualStyleBackColor = True
        '
        'GTRLabel
        '
        Me.GTRLabel.AutoSize = True
        Me.GTRLabel.Location = New System.Drawing.Point(189, 120)
        Me.GTRLabel.Name = "GTRLabel"
        Me.GTRLabel.Size = New System.Drawing.Size(61, 15)
        Me.GTRLabel.TabIndex = 5
        Me.GTRLabel.Text = "LOADING"
        '
        'TTSRLabel
        '
        Me.TTSRLabel.AutoSize = True
        Me.TTSRLabel.Location = New System.Drawing.Point(189, 80)
        Me.TTSRLabel.Name = "TTSRLabel"
        Me.TTSRLabel.Size = New System.Drawing.Size(61, 15)
        Me.TTSRLabel.TabIndex = 4
        Me.TTSRLabel.Text = "LOADING"
        '
        'NTSRLabel
        '
        Me.NTSRLabel.AutoSize = True
        Me.NTSRLabel.Location = New System.Drawing.Point(189, 40)
        Me.NTSRLabel.Name = "NTSRLabel"
        Me.NTSRLabel.Size = New System.Drawing.Size(61, 15)
        Me.NTSRLabel.TabIndex = 3
        Me.NTSRLabel.Text = "LOADING"
        '
        'GTLabel
        '
        Me.GTLabel.AutoSize = True
        Me.GTLabel.Location = New System.Drawing.Point(81, 120)
        Me.GTLabel.Name = "GTLabel"
        Me.GTLabel.Size = New System.Drawing.Size(102, 15)
        Me.GTLabel.TabIndex = 2
        Me.GTLabel.Text = "Google Stauts : "
        '
        'TTSTLabel
        '
        Me.TTSTLabel.AutoSize = True
        Me.TTSTLabel.Location = New System.Drawing.Point(50, 80)
        Me.TTSTLabel.Name = "TTSTLabel"
        Me.TTSTLabel.Size = New System.Drawing.Size(133, 15)
        Me.TTSTLabel.TabIndex = 1
        Me.TTSTLabel.Text = "TokyoTosho Status : "
        '
        'NTSTLabel
        '
        Me.NTSTLabel.AutoSize = True
        Me.NTSTLabel.Location = New System.Drawing.Point(107, 40)
        Me.NTSTLabel.Name = "NTSTLabel"
        Me.NTSTLabel.Size = New System.Drawing.Size(76, 15)
        Me.NTSTLabel.TabIndex = 0
        Me.NTSTLabel.Text = "NT Status : "
        '
        'TTSetPanel
        '
        Me.TTSetPanel.Controls.Add(Me.SubmitterTextBox)
        Me.TTSetPanel.Controls.Add(Me.SubmitterCheckBox)
        Me.TTSetPanel.Controls.Add(Me.TTSizeGroupPanel)
        Me.TTSetPanel.Controls.Add(Me.TTSizeCheckBox)
        Me.TTSetPanel.Controls.Add(Me.TTCatComboBox)
        Me.TTSetPanel.Controls.Add(Me.TTCatLabel)
        Me.TTSetPanel.Location = New System.Drawing.Point(6, 22)
        Me.TTSetPanel.Name = "TTSetPanel"
        Me.TTSetPanel.Size = New System.Drawing.Size(446, 362)
        Me.TTSetPanel.TabIndex = 7
        '
        'SubmitterTextBox
        '
        Me.SubmitterTextBox.Enabled = False
        Me.SubmitterTextBox.Location = New System.Drawing.Point(65, 216)
        Me.SubmitterTextBox.Name = "SubmitterTextBox"
        Me.SubmitterTextBox.Size = New System.Drawing.Size(131, 22)
        Me.SubmitterTextBox.TabIndex = 5
        '
        'SubmitterCheckBox
        '
        Me.SubmitterCheckBox.AutoSize = True
        Me.SubmitterCheckBox.Location = New System.Drawing.Point(37, 191)
        Me.SubmitterCheckBox.Name = "SubmitterCheckBox"
        Me.SubmitterCheckBox.Size = New System.Drawing.Size(183, 19)
        Me.SubmitterCheckBox.TabIndex = 4
        Me.SubmitterCheckBox.Text = "등록자 이름을 필터링 합니다."
        Me.SubmitterCheckBox.UseVisualStyleBackColor = True
        '
        'TTSizeGroupPanel
        '
        Me.TTSizeGroupPanel.Controls.Add(Me.MaxSizeTextBox)
        Me.TTSizeGroupPanel.Controls.Add(Me.MaxSizeLabel)
        Me.TTSizeGroupPanel.Controls.Add(Me.MinSizeLabel)
        Me.TTSizeGroupPanel.Controls.Add(Me.MinSizeTextBox)
        Me.TTSizeGroupPanel.Enabled = False
        Me.TTSizeGroupPanel.Location = New System.Drawing.Point(65, 100)
        Me.TTSizeGroupPanel.Name = "TTSizeGroupPanel"
        Me.TTSizeGroupPanel.Size = New System.Drawing.Size(366, 70)
        Me.TTSizeGroupPanel.TabIndex = 3
        '
        'MaxSizeTextBox
        '
        Me.MaxSizeTextBox.Location = New System.Drawing.Point(113, 42)
        Me.MaxSizeTextBox.Name = "MaxSizeTextBox"
        Me.MaxSizeTextBox.Size = New System.Drawing.Size(100, 22)
        Me.MaxSizeTextBox.TabIndex = 3
        '
        'MaxSizeLabel
        '
        Me.MaxSizeLabel.AutoSize = True
        Me.MaxSizeLabel.Location = New System.Drawing.Point(8, 45)
        Me.MaxSizeLabel.Name = "MaxSizeLabel"
        Me.MaxSizeLabel.Size = New System.Drawing.Size(99, 15)
        Me.MaxSizeLabel.TabIndex = 2
        Me.MaxSizeLabel.Text = "최대 크기(MB) : "
        '
        'MinSizeLabel
        '
        Me.MinSizeLabel.AutoSize = True
        Me.MinSizeLabel.Location = New System.Drawing.Point(8, 14)
        Me.MinSizeLabel.Name = "MinSizeLabel"
        Me.MinSizeLabel.Size = New System.Drawing.Size(99, 15)
        Me.MinSizeLabel.TabIndex = 1
        Me.MinSizeLabel.Text = "최소 크기(MB) : "
        '
        'MinSizeTextBox
        '
        Me.MinSizeTextBox.Location = New System.Drawing.Point(113, 10)
        Me.MinSizeTextBox.Name = "MinSizeTextBox"
        Me.MinSizeTextBox.Size = New System.Drawing.Size(100, 22)
        Me.MinSizeTextBox.TabIndex = 0
        '
        'TTSizeCheckBox
        '
        Me.TTSizeCheckBox.AutoSize = True
        Me.TTSizeCheckBox.Location = New System.Drawing.Point(37, 69)
        Me.TTSizeCheckBox.Name = "TTSizeCheckBox"
        Me.TTSizeCheckBox.Size = New System.Drawing.Size(207, 19)
        Me.TTSizeCheckBox.TabIndex = 2
        Me.TTSizeCheckBox.Text = "파일 사이즈 필터링을 사용합니다."
        Me.TTSizeCheckBox.UseVisualStyleBackColor = True
        '
        'TTCatComboBox
        '
        Me.TTCatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TTCatComboBox.FormattingEnabled = True
        Me.TTCatComboBox.Items.AddRange(New Object() {"All", "Anime", "Non-English", "Music", "Raws"})
        Me.TTCatComboBox.Location = New System.Drawing.Point(159, 19)
        Me.TTCatComboBox.Name = "TTCatComboBox"
        Me.TTCatComboBox.Size = New System.Drawing.Size(121, 23)
        Me.TTCatComboBox.TabIndex = 1
        '
        'TTCatLabel
        '
        Me.TTCatLabel.AutoSize = True
        Me.TTCatLabel.Location = New System.Drawing.Point(34, 22)
        Me.TTCatLabel.Name = "TTCatLabel"
        Me.TTCatLabel.Size = New System.Drawing.Size(119, 15)
        Me.TTCatLabel.TabIndex = 0
        Me.TTCatLabel.Text = "검색 카테고리 설정 : "
        '
        'NTSetPanel
        '
        Me.NTSetPanel.Controls.Add(Me.SearchCatLabel)
        Me.NTSetPanel.Controls.Add(Me.SearchCatComboBox)
        Me.NTSetPanel.Controls.Add(Me.SearchFilterLabel)
        Me.NTSetPanel.Controls.Add(Me.SearchFilterComboBox)
        Me.NTSetPanel.Location = New System.Drawing.Point(6, 22)
        Me.NTSetPanel.Name = "NTSetPanel"
        Me.NTSetPanel.Size = New System.Drawing.Size(446, 362)
        Me.NTSetPanel.TabIndex = 7
        '
        'SearchCatLabel
        '
        Me.SearchCatLabel.AutoSize = True
        Me.SearchCatLabel.Location = New System.Drawing.Point(62, 25)
        Me.SearchCatLabel.Name = "SearchCatLabel"
        Me.SearchCatLabel.Size = New System.Drawing.Size(119, 15)
        Me.SearchCatLabel.TabIndex = 4
        Me.SearchCatLabel.Text = "검색 카테고리 설정 : "
        '
        'SearchCatComboBox
        '
        Me.SearchCatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SearchCatComboBox.FormattingEnabled = True
        Me.SearchCatComboBox.Items.AddRange(New Object() {"Raw-Animation", "모든 카테고리", "애니메이션 전체", "Audio 전체", "Lossless Audio", "Lossy Audio"})
        Me.SearchCatComboBox.Location = New System.Drawing.Point(204, 22)
        Me.SearchCatComboBox.Name = "SearchCatComboBox"
        Me.SearchCatComboBox.Size = New System.Drawing.Size(140, 23)
        Me.SearchCatComboBox.TabIndex = 5
        '
        'SearchFilterLabel
        '
        Me.SearchFilterLabel.AutoSize = True
        Me.SearchFilterLabel.Location = New System.Drawing.Point(74, 61)
        Me.SearchFilterLabel.Name = "SearchFilterLabel"
        Me.SearchFilterLabel.Size = New System.Drawing.Size(107, 15)
        Me.SearchFilterLabel.TabIndex = 6
        Me.SearchFilterLabel.Text = "검색 필터링 설정 : "
        '
        'SearchFilterComboBox
        '
        Me.SearchFilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SearchFilterComboBox.FormattingEnabled = True
        Me.SearchFilterComboBox.Items.AddRange(New Object() {"모두", "A+ 이상", "신뢰된것 모두"})
        Me.SearchFilterComboBox.Location = New System.Drawing.Point(204, 58)
        Me.SearchFilterComboBox.Name = "SearchFilterComboBox"
        Me.SearchFilterComboBox.Size = New System.Drawing.Size(140, 23)
        Me.SearchFilterComboBox.TabIndex = 7
        '
        'OptionSaveButton
        '
        Me.OptionSaveButton.Location = New System.Drawing.Point(679, 398)
        Me.OptionSaveButton.Name = "OptionSaveButton"
        Me.OptionSaveButton.Size = New System.Drawing.Size(75, 23)
        Me.OptionSaveButton.TabIndex = 5
        Me.OptionSaveButton.Text = "저장"
        Me.OptionSaveButton.UseVisualStyleBackColor = True
        '
        'FormCloseButton
        '
        Me.FormCloseButton.Location = New System.Drawing.Point(598, 398)
        Me.FormCloseButton.Name = "FormCloseButton"
        Me.FormCloseButton.Size = New System.Drawing.Size(75, 23)
        Me.FormCloseButton.TabIndex = 6
        Me.FormCloseButton.Text = "닫기"
        Me.FormCloseButton.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'ProgramOption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(766, 437)
        Me.Controls.Add(Me.FormCloseButton)
        Me.Controls.Add(Me.OptionSaveButton)
        Me.Controls.Add(Me.SaveSettingButton)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.OptionPresetChooseComboBox)
        Me.Controls.Add(Me.OptionTreeView)
        Me.Controls.Add(Me.OptionTab)
        Me.Font = New System.Drawing.Font("나눔바른고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ProgramOption"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "프로그램 옵션"
        Me.OptionTab.ResumeLayout(False)
        Me.ProgramConfigPanel.ResumeLayout(False)
        Me.ProgramConfigPanel.PerformLayout()
        Me.ListInfoPanel.ResumeLayout(False)
        Me.ListInfoPanel.PerformLayout()
        Me.ListSettingPanel.ResumeLayout(False)
        Me.ListSettingPanel.PerformLayout()
        Me.AvailiableListPanel.ResumeLayout(False)
        Me.AvailiableListPanel.PerformLayout()
        Me.ExpandModePanel.ResumeLayout(False)
        Me.ActionSettingGroupBox.ResumeLayout(False)
        Me.WebReachTestPanel.ResumeLayout(False)
        Me.WebReachTestPanel.PerformLayout()
        Me.TTSetPanel.ResumeLayout(False)
        Me.TTSetPanel.PerformLayout()
        Me.TTSizeGroupPanel.ResumeLayout(False)
        Me.TTSizeGroupPanel.PerformLayout()
        Me.NTSetPanel.ResumeLayout(False)
        Me.NTSetPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OptionTreeView As System.Windows.Forms.TreeView
    Friend WithEvents OptionPresetChooseComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ResetButton As System.Windows.Forms.Button
    Friend WithEvents SaveSettingButton As System.Windows.Forms.Button
    Friend WithEvents OptionTab As System.Windows.Forms.GroupBox
    Friend WithEvents ProgramConfigPanel As System.Windows.Forms.Panel
    Friend WithEvents SystemTrayComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SystemTrayLabel As System.Windows.Forms.Label
    Friend WithEvents OptionSaveButton As System.Windows.Forms.Button
    Friend WithEvents FormCloseButton As System.Windows.Forms.Button
    Friend WithEvents CloseAlertComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CloseAlertLabel As System.Windows.Forms.Label
    Friend WithEvents AnimationFolderSetButton As System.Windows.Forms.Button
    Friend WithEvents AnimationFolderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AnimationFolderSetCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SplitLabel As System.Windows.Forms.Label
    Friend WithEvents SearchFilterComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SearchFilterLabel As System.Windows.Forms.Label
    Friend WithEvents SearchCatComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SearchCatLabel As System.Windows.Forms.Label
    Friend WithEvents ListSettingPanel As System.Windows.Forms.Panel
    Friend WithEvents OldListComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CheckOldListLabel As System.Windows.Forms.Label
    Friend WithEvents ListInfoPanel As System.Windows.Forms.Panel
    Friend WithEvents ListProducerLabel As System.Windows.Forms.Label
    Friend WithEvents ListProducerInfoLabel As System.Windows.Forms.Label
    Friend WithEvents ListDateLabel As System.Windows.Forms.Label
    Friend WithEvents ListDateInfoLabel As System.Windows.Forms.Label
    Friend WithEvents ProgramModeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ProgramModeLabel As System.Windows.Forms.Label
    Friend WithEvents AvailiableListPanel As System.Windows.Forms.Panel
    Friend WithEvents AvailiableListLabel As System.Windows.Forms.Label
    Friend WithEvents AvailiableListComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AvailiableListDownloadButton As System.Windows.Forms.Button
    Friend WithEvents ExpandModePanel As System.Windows.Forms.Panel
    Friend WithEvents ButtonActionComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents NoticeRecvComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents NoticeRecvLabel As System.Windows.Forms.Label
    Friend WithEvents ActionSettingGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents ActionSetLabel As System.Windows.Forms.Label
    Friend WithEvents ImageModeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ImageModeLabel As System.Windows.Forms.Label
    Friend WithEvents NTSetPanel As System.Windows.Forms.Panel
    Friend WithEvents TTSetPanel As System.Windows.Forms.Panel
    Friend WithEvents TTCatLabel As System.Windows.Forms.Label
    Friend WithEvents SubmitterTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SubmitterCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents TTSizeGroupPanel As System.Windows.Forms.Panel
    Friend WithEvents MaxSizeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MaxSizeLabel As System.Windows.Forms.Label
    Friend WithEvents MinSizeLabel As System.Windows.Forms.Label
    Friend WithEvents MinSizeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TTSizeCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents TTCatComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents WebReachTestPanel As System.Windows.Forms.Panel
    Friend WithEvents GTRLabel As System.Windows.Forms.Label
    Friend WithEvents TTSRLabel As System.Windows.Forms.Label
    Friend WithEvents NTSRLabel As System.Windows.Forms.Label
    Friend WithEvents GTLabel As System.Windows.Forms.Label
    Friend WithEvents TTSTLabel As System.Windows.Forms.Label
    Friend WithEvents NTSTLabel As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ReTestButton As System.Windows.Forms.Button
End Class
