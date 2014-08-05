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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("기본 브라우저 설정")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("확장모드 설정")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("프로그램 설정", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2})
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("리스트 정보")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("다운로드 가능한 리스트")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("리스트 설정", New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode5})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProgramOption))
        Me.OptionTreeView = New System.Windows.Forms.TreeView()
        Me.OptionPresetChooseComboBox = New System.Windows.Forms.ComboBox()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.SaveSettingButton = New System.Windows.Forms.Button()
        Me.OptionTab = New System.Windows.Forms.GroupBox()
        Me.ExpandModePanel = New System.Windows.Forms.Panel()
        Me.ActionSettingGroupBox = New System.Windows.Forms.GroupBox()
        Me.ActionSetLabel = New System.Windows.Forms.Label()
        Me.ButtonActionComboBox = New System.Windows.Forms.ComboBox()
        Me.ProgramConfigPanel = New System.Windows.Forms.Panel()
        Me.NoticeRecvComboBox = New System.Windows.Forms.ComboBox()
        Me.NoticeRecvLabel = New System.Windows.Forms.Label()
        Me.ProgramModeComboBox = New System.Windows.Forms.ComboBox()
        Me.ProgramModeLabel = New System.Windows.Forms.Label()
        Me.AnimationFolderSetButton = New System.Windows.Forms.Button()
        Me.AnimationFolderTextBox = New System.Windows.Forms.TextBox()
        Me.AnimationFolderSetCheckBox = New System.Windows.Forms.CheckBox()
        Me.SplitLabel = New System.Windows.Forms.Label()
        Me.SearchFilterComboBox = New System.Windows.Forms.ComboBox()
        Me.SearchFilterLabel = New System.Windows.Forms.Label()
        Me.SearchCatComboBox = New System.Windows.Forms.ComboBox()
        Me.SearchCatLabel = New System.Windows.Forms.Label()
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
        Me.BrowserSetPanel = New System.Windows.Forms.Panel()
        Me.BrowserSetCheckBox = New System.Windows.Forms.CheckBox()
        Me.BrowserLocationSetButton = New System.Windows.Forms.Button()
        Me.BrowserLocationTextBox = New System.Windows.Forms.TextBox()
        Me.AvailiableListPanel = New System.Windows.Forms.Panel()
        Me.AvailiableListDownloadButton = New System.Windows.Forms.Button()
        Me.AvailiableListLabel = New System.Windows.Forms.Label()
        Me.AvailiableListComboBox = New System.Windows.Forms.ComboBox()
        Me.OptionSaveButton = New System.Windows.Forms.Button()
        Me.FormCloseButton = New System.Windows.Forms.Button()
        Me.ImageModeLabel = New System.Windows.Forms.Label()
        Me.ImageModeComboBox = New System.Windows.Forms.ComboBox()
        Me.OptionTab.SuspendLayout()
        Me.ExpandModePanel.SuspendLayout()
        Me.ActionSettingGroupBox.SuspendLayout()
        Me.ProgramConfigPanel.SuspendLayout()
        Me.ListInfoPanel.SuspendLayout()
        Me.ListSettingPanel.SuspendLayout()
        Me.BrowserSetPanel.SuspendLayout()
        Me.AvailiableListPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'OptionTreeView
        '
        Me.OptionTreeView.Location = New System.Drawing.Point(12, 38)
        Me.OptionTreeView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OptionTreeView.Name = "OptionTreeView"
        TreeNode1.Name = "DefaultBrowserSettingNode"
        TreeNode1.Text = "기본 브라우저 설정"
        TreeNode2.Name = "ExpandModeSetting"
        TreeNode2.Text = "확장모드 설정"
        TreeNode3.Name = "CommonConfig"
        TreeNode3.Text = "프로그램 설정"
        TreeNode4.Name = "ListInformationNode"
        TreeNode4.Text = "리스트 정보"
        TreeNode5.Name = "AvailiableListShowNode"
        TreeNode5.Text = "다운로드 가능한 리스트"
        TreeNode6.Name = "ListConfigNode"
        TreeNode6.Text = "리스트 설정"
        Me.OptionTreeView.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode3, TreeNode6})
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
        Me.OptionTab.Controls.Add(Me.BrowserSetPanel)
        Me.OptionTab.Controls.Add(Me.AvailiableListPanel)
        Me.OptionTab.Controls.Add(Me.ExpandModePanel)
        Me.OptionTab.Location = New System.Drawing.Point(287, 0)
        Me.OptionTab.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OptionTab.Name = "OptionTab"
        Me.OptionTab.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OptionTab.Size = New System.Drawing.Size(467, 391)
        Me.OptionTab.TabIndex = 0
        Me.OptionTab.TabStop = False
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
        Me.ProgramConfigPanel.Controls.Add(Me.SearchFilterComboBox)
        Me.ProgramConfigPanel.Controls.Add(Me.SearchFilterLabel)
        Me.ProgramConfigPanel.Controls.Add(Me.SearchCatComboBox)
        Me.ProgramConfigPanel.Controls.Add(Me.SearchCatLabel)
        Me.ProgramConfigPanel.Controls.Add(Me.CloseAlertComboBox)
        Me.ProgramConfigPanel.Controls.Add(Me.CloseAlertLabel)
        Me.ProgramConfigPanel.Controls.Add(Me.SystemTrayComboBox)
        Me.ProgramConfigPanel.Controls.Add(Me.SystemTrayLabel)
        Me.ProgramConfigPanel.Location = New System.Drawing.Point(6, 22)
        Me.ProgramConfigPanel.Name = "ProgramConfigPanel"
        Me.ProgramConfigPanel.Size = New System.Drawing.Size(446, 362)
        Me.ProgramConfigPanel.TabIndex = 0
        '
        'NoticeRecvComboBox
        '
        Me.NoticeRecvComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.NoticeRecvComboBox.FormattingEnabled = True
        Me.NoticeRecvComboBox.Items.AddRange(New Object() {"수신함", "수신하지 않음"})
        Me.NoticeRecvComboBox.Location = New System.Drawing.Point(231, 196)
        Me.NoticeRecvComboBox.Name = "NoticeRecvComboBox"
        Me.NoticeRecvComboBox.Size = New System.Drawing.Size(140, 23)
        Me.NoticeRecvComboBox.TabIndex = 15
        '
        'NoticeRecvLabel
        '
        Me.NoticeRecvLabel.AutoSize = True
        Me.NoticeRecvLabel.Location = New System.Drawing.Point(117, 199)
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
        Me.ProgramModeComboBox.Location = New System.Drawing.Point(232, 161)
        Me.ProgramModeComboBox.Name = "ProgramModeComboBox"
        Me.ProgramModeComboBox.Size = New System.Drawing.Size(140, 23)
        Me.ProgramModeComboBox.TabIndex = 13
        '
        'ProgramModeLabel
        '
        Me.ProgramModeLabel.AutoSize = True
        Me.ProgramModeLabel.Location = New System.Drawing.Point(117, 164)
        Me.ProgramModeLabel.Name = "ProgramModeLabel"
        Me.ProgramModeLabel.Size = New System.Drawing.Size(92, 15)
        Me.ProgramModeLabel.TabIndex = 12
        Me.ProgramModeLabel.Text = "프로그램 모드 : "
        '
        'AnimationFolderSetButton
        '
        Me.AnimationFolderSetButton.Enabled = False
        Me.AnimationFolderSetButton.Location = New System.Drawing.Point(346, 318)
        Me.AnimationFolderSetButton.Name = "AnimationFolderSetButton"
        Me.AnimationFolderSetButton.Size = New System.Drawing.Size(75, 23)
        Me.AnimationFolderSetButton.TabIndex = 11
        Me.AnimationFolderSetButton.Text = "폴더 지정"
        Me.AnimationFolderSetButton.UseVisualStyleBackColor = True
        '
        'AnimationFolderTextBox
        '
        Me.AnimationFolderTextBox.Location = New System.Drawing.Point(66, 319)
        Me.AnimationFolderTextBox.Name = "AnimationFolderTextBox"
        Me.AnimationFolderTextBox.ReadOnly = True
        Me.AnimationFolderTextBox.Size = New System.Drawing.Size(274, 22)
        Me.AnimationFolderTextBox.TabIndex = 10
        '
        'AnimationFolderSetCheckBox
        '
        Me.AnimationFolderSetCheckBox.AutoSize = True
        Me.AnimationFolderSetCheckBox.Location = New System.Drawing.Point(38, 294)
        Me.AnimationFolderSetCheckBox.Name = "AnimationFolderSetCheckBox"
        Me.AnimationFolderSetCheckBox.Size = New System.Drawing.Size(255, 19)
        Me.AnimationFolderSetCheckBox.TabIndex = 9
        Me.AnimationFolderSetCheckBox.Text = "애니메이션이 저장되는 폴더를 지정합니다."
        Me.AnimationFolderSetCheckBox.UseVisualStyleBackColor = True
        '
        'SplitLabel
        '
        Me.SplitLabel.AutoSize = True
        Me.SplitLabel.Location = New System.Drawing.Point(4, 265)
        Me.SplitLabel.Name = "SplitLabel"
        Me.SplitLabel.Size = New System.Drawing.Size(439, 15)
        Me.SplitLabel.TabIndex = 8
        Me.SplitLabel.Text = "────────────────────────────────────"
        '
        'SearchFilterComboBox
        '
        Me.SearchFilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SearchFilterComboBox.FormattingEnabled = True
        Me.SearchFilterComboBox.Items.AddRange(New Object() {"모두", "A+ 이상", "신뢰된것 모두"})
        Me.SearchFilterComboBox.Location = New System.Drawing.Point(232, 128)
        Me.SearchFilterComboBox.Name = "SearchFilterComboBox"
        Me.SearchFilterComboBox.Size = New System.Drawing.Size(140, 23)
        Me.SearchFilterComboBox.TabIndex = 7
        '
        'SearchFilterLabel
        '
        Me.SearchFilterLabel.AutoSize = True
        Me.SearchFilterLabel.Location = New System.Drawing.Point(102, 131)
        Me.SearchFilterLabel.Name = "SearchFilterLabel"
        Me.SearchFilterLabel.Size = New System.Drawing.Size(107, 15)
        Me.SearchFilterLabel.TabIndex = 6
        Me.SearchFilterLabel.Text = "검색 필터링 설정 : "
        '
        'SearchCatComboBox
        '
        Me.SearchCatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SearchCatComboBox.FormattingEnabled = True
        Me.SearchCatComboBox.Items.AddRange(New Object() {"Raw-Animation", "모든 카테고리", "애니메이션 전체", "Audio 전체", "Lossless Audio", "Lossy Audio"})
        Me.SearchCatComboBox.Location = New System.Drawing.Point(232, 92)
        Me.SearchCatComboBox.Name = "SearchCatComboBox"
        Me.SearchCatComboBox.Size = New System.Drawing.Size(140, 23)
        Me.SearchCatComboBox.TabIndex = 5
        '
        'SearchCatLabel
        '
        Me.SearchCatLabel.AutoSize = True
        Me.SearchCatLabel.Location = New System.Drawing.Point(90, 95)
        Me.SearchCatLabel.Name = "SearchCatLabel"
        Me.SearchCatLabel.Size = New System.Drawing.Size(119, 15)
        Me.SearchCatLabel.TabIndex = 4
        Me.SearchCatLabel.Text = "검색 카테고리 설정 : "
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
        Me.CloseAlertLabel.Location = New System.Drawing.Point(39, 61)
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
        Me.SystemTrayComboBox.Location = New System.Drawing.Point(231, 22)
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
        Me.ListProducerLabel.Location = New System.Drawing.Point(137, 117)
        Me.ListProducerLabel.Name = "ListProducerLabel"
        Me.ListProducerLabel.Size = New System.Drawing.Size(61, 15)
        Me.ListProducerLabel.TabIndex = 3
        Me.ListProducerLabel.Text = "LOADING"
        '
        'ListProducerInfoLabel
        '
        Me.ListProducerInfoLabel.AutoSize = True
        Me.ListProducerInfoLabel.Location = New System.Drawing.Point(51, 117)
        Me.ListProducerInfoLabel.Name = "ListProducerInfoLabel"
        Me.ListProducerInfoLabel.Size = New System.Drawing.Size(80, 15)
        Me.ListProducerInfoLabel.TabIndex = 2
        Me.ListProducerInfoLabel.Text = "리스트 제작 : "
        '
        'ListDateLabel
        '
        Me.ListDateLabel.AutoSize = True
        Me.ListDateLabel.Location = New System.Drawing.Point(137, 86)
        Me.ListDateLabel.Name = "ListDateLabel"
        Me.ListDateLabel.Size = New System.Drawing.Size(61, 15)
        Me.ListDateLabel.TabIndex = 1
        Me.ListDateLabel.Text = "LOADING"
        '
        'ListDateInfoLabel
        '
        Me.ListDateInfoLabel.AutoSize = True
        Me.ListDateInfoLabel.Location = New System.Drawing.Point(39, 86)
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
        Me.OldListComboBox.Location = New System.Drawing.Point(231, 22)
        Me.OldListComboBox.Name = "OldListComboBox"
        Me.OldListComboBox.Size = New System.Drawing.Size(140, 23)
        Me.OldListComboBox.TabIndex = 1
        '
        'CheckOldListLabel
        '
        Me.CheckOldListLabel.AutoSize = True
        Me.CheckOldListLabel.Location = New System.Drawing.Point(78, 25)
        Me.CheckOldListLabel.Name = "CheckOldListLabel"
        Me.CheckOldListLabel.Size = New System.Drawing.Size(134, 15)
        Me.CheckOldListLabel.TabIndex = 0
        Me.CheckOldListLabel.Text = "구작 리스트 확인 여부 : "
        '
        'BrowserSetPanel
        '
        Me.BrowserSetPanel.Controls.Add(Me.BrowserSetCheckBox)
        Me.BrowserSetPanel.Controls.Add(Me.BrowserLocationSetButton)
        Me.BrowserSetPanel.Controls.Add(Me.BrowserLocationTextBox)
        Me.BrowserSetPanel.Location = New System.Drawing.Point(6, 22)
        Me.BrowserSetPanel.Name = "BrowserSetPanel"
        Me.BrowserSetPanel.Size = New System.Drawing.Size(446, 362)
        Me.BrowserSetPanel.TabIndex = 2
        '
        'BrowserSetCheckBox
        '
        Me.BrowserSetCheckBox.AutoSize = True
        Me.BrowserSetCheckBox.Location = New System.Drawing.Point(18, 79)
        Me.BrowserSetCheckBox.Name = "BrowserSetCheckBox"
        Me.BrowserSetCheckBox.Size = New System.Drawing.Size(282, 19)
        Me.BrowserSetCheckBox.TabIndex = 3
        Me.BrowserSetCheckBox.Text = "프로그램에 사용할 기본 브라우저를 지정합니다."
        Me.BrowserSetCheckBox.UseVisualStyleBackColor = True
        '
        'BrowserLocationSetButton
        '
        Me.BrowserLocationSetButton.Enabled = False
        Me.BrowserLocationSetButton.Location = New System.Drawing.Point(356, 132)
        Me.BrowserLocationSetButton.Name = "BrowserLocationSetButton"
        Me.BrowserLocationSetButton.Size = New System.Drawing.Size(75, 23)
        Me.BrowserLocationSetButton.TabIndex = 2
        Me.BrowserLocationSetButton.Text = "위치 지정"
        Me.BrowserLocationSetButton.UseVisualStyleBackColor = True
        '
        'BrowserLocationTextBox
        '
        Me.BrowserLocationTextBox.Location = New System.Drawing.Point(37, 104)
        Me.BrowserLocationTextBox.Name = "BrowserLocationTextBox"
        Me.BrowserLocationTextBox.ReadOnly = True
        Me.BrowserLocationTextBox.Size = New System.Drawing.Size(394, 22)
        Me.BrowserLocationTextBox.TabIndex = 1
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
        'ImageModeLabel
        '
        Me.ImageModeLabel.AutoSize = True
        Me.ImageModeLabel.Location = New System.Drawing.Point(129, 234)
        Me.ImageModeLabel.Name = "ImageModeLabel"
        Me.ImageModeLabel.Size = New System.Drawing.Size(80, 15)
        Me.ImageModeLabel.TabIndex = 16
        Me.ImageModeLabel.Text = "이미지 모드 : "
        '
        'ImageModeComboBox
        '
        Me.ImageModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ImageModeComboBox.FormattingEnabled = True
        Me.ImageModeComboBox.Items.AddRange(New Object() {"원본", "오토 사이즈"})
        Me.ImageModeComboBox.Location = New System.Drawing.Point(231, 231)
        Me.ImageModeComboBox.Name = "ImageModeComboBox"
        Me.ImageModeComboBox.Size = New System.Drawing.Size(140, 23)
        Me.ImageModeComboBox.TabIndex = 17
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
        Me.ExpandModePanel.ResumeLayout(False)
        Me.ActionSettingGroupBox.ResumeLayout(False)
        Me.ProgramConfigPanel.ResumeLayout(False)
        Me.ProgramConfigPanel.PerformLayout()
        Me.ListInfoPanel.ResumeLayout(False)
        Me.ListInfoPanel.PerformLayout()
        Me.ListSettingPanel.ResumeLayout(False)
        Me.ListSettingPanel.PerformLayout()
        Me.BrowserSetPanel.ResumeLayout(False)
        Me.BrowserSetPanel.PerformLayout()
        Me.AvailiableListPanel.ResumeLayout(False)
        Me.AvailiableListPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OptionTreeView As System.Windows.Forms.TreeView
    Friend WithEvents OptionPresetChooseComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ResetButton As System.Windows.Forms.Button
    Friend WithEvents SaveSettingButton As System.Windows.Forms.Button
    Friend WithEvents OptionTab As System.Windows.Forms.GroupBox
    Friend WithEvents BrowserSetPanel As System.Windows.Forms.Panel
    Friend WithEvents BrowserLocationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProgramConfigPanel As System.Windows.Forms.Panel
    Friend WithEvents SystemTrayComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SystemTrayLabel As System.Windows.Forms.Label
    Friend WithEvents OptionSaveButton As System.Windows.Forms.Button
    Friend WithEvents FormCloseButton As System.Windows.Forms.Button
    Friend WithEvents CloseAlertComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CloseAlertLabel As System.Windows.Forms.Label
    Friend WithEvents BrowserLocationSetButton As System.Windows.Forms.Button
    Friend WithEvents AnimationFolderSetButton As System.Windows.Forms.Button
    Friend WithEvents AnimationFolderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AnimationFolderSetCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SplitLabel As System.Windows.Forms.Label
    Friend WithEvents SearchFilterComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SearchFilterLabel As System.Windows.Forms.Label
    Friend WithEvents SearchCatComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SearchCatLabel As System.Windows.Forms.Label
    Friend WithEvents BrowserSetCheckBox As System.Windows.Forms.CheckBox
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
End Class
