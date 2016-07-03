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
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("다운로드 가능한 리스트")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("리스트 설정", New System.Windows.Forms.TreeNode() {TreeNode3})
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("NT 검색 설정")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("사이트 현황")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("검색엔진 설정", New System.Windows.Forms.TreeNode() {TreeNode5, TreeNode6})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProgramOption))
        Me.OptionTreeView = New System.Windows.Forms.TreeView()
        Me.OptionPreset = New System.Windows.Forms.ComboBox()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.SaveSettingButton = New System.Windows.Forms.Button()
        Me.OptionTab = New System.Windows.Forms.GroupBox()
        Me.ProgramConfigPanel = New System.Windows.Forms.Panel()
        Me.ImageFilteringComboBox = New System.Windows.Forms.ComboBox()
        Me.ImageFilteringLabel = New System.Windows.Forms.Label()
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
        Me.AvailiableListPanel = New System.Windows.Forms.Panel()
        Me.DownloadableListGroupBox = New System.Windows.Forms.GroupBox()
        Me.AvailiableListLabel = New System.Windows.Forms.Label()
        Me.AvailiableListDownloadButton = New System.Windows.Forms.Button()
        Me.AvailiableListComboBox = New System.Windows.Forms.ComboBox()
        Me.ExpandModePanel = New System.Windows.Forms.Panel()
        Me.ActionSettingGroupBox = New System.Windows.Forms.GroupBox()
        Me.ActionSetLabel = New System.Windows.Forms.Label()
        Me.ButtonActionComboBox = New System.Windows.Forms.ComboBox()
        Me.WebReachTestPanel = New System.Windows.Forms.Panel()
        Me.ReTestButton = New System.Windows.Forms.Button()
        Me.GTRLabel = New System.Windows.Forms.Label()
        Me.NTSRLabel = New System.Windows.Forms.Label()
        Me.GTLabel = New System.Windows.Forms.Label()
        Me.NTSTLabel = New System.Windows.Forms.Label()
        Me.NTSetPanel = New System.Windows.Forms.Panel()
        Me.NTCatLabel = New System.Windows.Forms.Label()
        Me.NTCatComboBox = New System.Windows.Forms.ComboBox()
        Me.NTFilterLabel = New System.Windows.Forms.Label()
        Me.NTFilterComboBox = New System.Windows.Forms.ComboBox()
        Me.OptionSaveButton = New System.Windows.Forms.Button()
        Me.FormCloseButton = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.OptionTab.SuspendLayout()
        Me.ProgramConfigPanel.SuspendLayout()
        Me.ListInfoPanel.SuspendLayout()
        Me.AvailiableListPanel.SuspendLayout()
        Me.DownloadableListGroupBox.SuspendLayout()
        Me.ExpandModePanel.SuspendLayout()
        Me.ActionSettingGroupBox.SuspendLayout()
        Me.WebReachTestPanel.SuspendLayout()
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
        TreeNode3.Name = "AvailiableListShowNode"
        TreeNode3.Text = "다운로드 가능한 리스트"
        TreeNode4.Name = "ListConfigNode"
        TreeNode4.Text = "리스트 설정"
        TreeNode5.Name = "NTSearchSettingNode"
        TreeNode5.Text = "NT 검색 설정"
        TreeNode6.Name = "SiteStatusNode"
        TreeNode6.Text = "사이트 현황"
        TreeNode7.Name = "SearchEngineNode"
        TreeNode7.Text = "검색엔진 설정"
        Me.OptionTreeView.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode2, TreeNode4, TreeNode7})
        Me.OptionTreeView.Size = New System.Drawing.Size(255, 357)
        Me.OptionTreeView.TabIndex = 1
        '
        'OptionPreset
        '
        Me.OptionPreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.OptionPreset.FormattingEnabled = True
        Me.OptionPreset.Items.AddRange(New Object() {"기본설정"})
        Me.OptionPreset.Location = New System.Drawing.Point(12, 8)
        Me.OptionPreset.Name = "OptionPreset"
        Me.OptionPreset.Size = New System.Drawing.Size(255, 23)
        Me.OptionPreset.TabIndex = 2
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
        Me.OptionTab.Controls.Add(Me.AvailiableListPanel)
        Me.OptionTab.Controls.Add(Me.ExpandModePanel)
        Me.OptionTab.Controls.Add(Me.WebReachTestPanel)
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
        Me.ProgramConfigPanel.Controls.Add(Me.ImageFilteringComboBox)
        Me.ProgramConfigPanel.Controls.Add(Me.ImageFilteringLabel)
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
        'ImageFilteringComboBox
        '
        Me.ImageFilteringComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ImageFilteringComboBox.FormattingEnabled = True
        Me.ImageFilteringComboBox.Items.AddRange(New Object() {"사용하지 않음", "사용함"})
        Me.ImageFilteringComboBox.Location = New System.Drawing.Point(231, 115)
        Me.ImageFilteringComboBox.Name = "ImageFilteringComboBox"
        Me.ImageFilteringComboBox.Size = New System.Drawing.Size(140, 23)
        Me.ImageFilteringComboBox.TabIndex = 19
        '
        'ImageFilteringLabel
        '
        Me.ImageFilteringLabel.AutoSize = True
        Me.ImageFilteringLabel.Location = New System.Drawing.Point(107, 120)
        Me.ImageFilteringLabel.Name = "ImageFilteringLabel"
        Me.ImageFilteringLabel.Size = New System.Drawing.Size(92, 15)
        Me.ImageFilteringLabel.TabIndex = 18
        Me.ImageFilteringLabel.Text = "이미지 필터링 : "
        '
        'AnimationFolderSetButton
        '
        Me.AnimationFolderSetButton.Enabled = False
        Me.AnimationFolderSetButton.Location = New System.Drawing.Point(345, 319)
        Me.AnimationFolderSetButton.Name = "AnimationFolderSetButton"
        Me.AnimationFolderSetButton.Size = New System.Drawing.Size(75, 23)
        Me.AnimationFolderSetButton.TabIndex = 11
        Me.AnimationFolderSetButton.Text = "폴더 지정"
        Me.AnimationFolderSetButton.UseVisualStyleBackColor = True
        '
        'AnimationFolderTextBox
        '
        Me.AnimationFolderTextBox.Location = New System.Drawing.Point(65, 320)
        Me.AnimationFolderTextBox.Name = "AnimationFolderTextBox"
        Me.AnimationFolderTextBox.ReadOnly = True
        Me.AnimationFolderTextBox.Size = New System.Drawing.Size(274, 22)
        Me.AnimationFolderTextBox.TabIndex = 10
        '
        'AnimationFolderSetCheckBox
        '
        Me.AnimationFolderSetCheckBox.AutoSize = True
        Me.AnimationFolderSetCheckBox.Location = New System.Drawing.Point(37, 295)
        Me.AnimationFolderSetCheckBox.Name = "AnimationFolderSetCheckBox"
        Me.AnimationFolderSetCheckBox.Size = New System.Drawing.Size(255, 19)
        Me.AnimationFolderSetCheckBox.TabIndex = 9
        Me.AnimationFolderSetCheckBox.Text = "애니메이션이 저장되는 폴더를 지정합니다."
        Me.AnimationFolderSetCheckBox.UseVisualStyleBackColor = True
        '
        'SplitLabel
        '
        Me.SplitLabel.AutoSize = True
        Me.SplitLabel.Location = New System.Drawing.Point(4, 259)
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
        Me.CloseAlertComboBox.Location = New System.Drawing.Point(231, 65)
        Me.CloseAlertComboBox.Name = "CloseAlertComboBox"
        Me.CloseAlertComboBox.Size = New System.Drawing.Size(140, 23)
        Me.CloseAlertComboBox.TabIndex = 3
        '
        'CloseAlertLabel
        '
        Me.CloseAlertLabel.AutoSize = True
        Me.CloseAlertLabel.Location = New System.Drawing.Point(30, 70)
        Me.CloseAlertLabel.Name = "CloseAlertLabel"
        Me.CloseAlertLabel.Size = New System.Drawing.Size(170, 15)
        Me.CloseAlertLabel.TabIndex = 2
        Me.CloseAlertLabel.Text = "프로그램 닫기시 경고창 표시 : "
        '
        'SystemTrayComboBox
        '
        Me.SystemTrayComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SystemTrayComboBox.FormattingEnabled = True
        Me.SystemTrayComboBox.Items.AddRange(New Object() {"표시하지 않음", "항상 표시", "최소화시 표시"})
        Me.SystemTrayComboBox.Location = New System.Drawing.Point(231, 15)
        Me.SystemTrayComboBox.Name = "SystemTrayComboBox"
        Me.SystemTrayComboBox.Size = New System.Drawing.Size(140, 23)
        Me.SystemTrayComboBox.TabIndex = 1
        '
        'SystemTrayLabel
        '
        Me.SystemTrayLabel.AutoSize = True
        Me.SystemTrayLabel.Location = New System.Drawing.Point(70, 20)
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
        Me.ListProducerLabel.Location = New System.Drawing.Point(128, 50)
        Me.ListProducerLabel.Name = "ListProducerLabel"
        Me.ListProducerLabel.Size = New System.Drawing.Size(61, 15)
        Me.ListProducerLabel.TabIndex = 3
        Me.ListProducerLabel.Text = "LOADING"
        '
        'ListProducerInfoLabel
        '
        Me.ListProducerInfoLabel.AutoSize = True
        Me.ListProducerInfoLabel.Location = New System.Drawing.Point(40, 50)
        Me.ListProducerInfoLabel.Name = "ListProducerInfoLabel"
        Me.ListProducerInfoLabel.Size = New System.Drawing.Size(80, 15)
        Me.ListProducerInfoLabel.TabIndex = 2
        Me.ListProducerInfoLabel.Text = "리스트 제작 : "
        '
        'ListDateLabel
        '
        Me.ListDateLabel.AutoSize = True
        Me.ListDateLabel.Location = New System.Drawing.Point(128, 20)
        Me.ListDateLabel.Name = "ListDateLabel"
        Me.ListDateLabel.Size = New System.Drawing.Size(61, 15)
        Me.ListDateLabel.TabIndex = 1
        Me.ListDateLabel.Text = "LOADING"
        '
        'ListDateInfoLabel
        '
        Me.ListDateInfoLabel.AutoSize = True
        Me.ListDateInfoLabel.Location = New System.Drawing.Point(30, 20)
        Me.ListDateInfoLabel.Name = "ListDateInfoLabel"
        Me.ListDateInfoLabel.Size = New System.Drawing.Size(92, 15)
        Me.ListDateInfoLabel.TabIndex = 0
        Me.ListDateInfoLabel.Text = "리스트 제작일 : "
        '
        'AvailiableListPanel
        '
        Me.AvailiableListPanel.Controls.Add(Me.DownloadableListGroupBox)
        Me.AvailiableListPanel.Location = New System.Drawing.Point(6, 22)
        Me.AvailiableListPanel.Name = "AvailiableListPanel"
        Me.AvailiableListPanel.Size = New System.Drawing.Size(446, 362)
        Me.AvailiableListPanel.TabIndex = 14
        '
        'DownloadableListGroupBox
        '
        Me.DownloadableListGroupBox.Controls.Add(Me.AvailiableListLabel)
        Me.DownloadableListGroupBox.Controls.Add(Me.AvailiableListDownloadButton)
        Me.DownloadableListGroupBox.Controls.Add(Me.AvailiableListComboBox)
        Me.DownloadableListGroupBox.Location = New System.Drawing.Point(12, 16)
        Me.DownloadableListGroupBox.Name = "DownloadableListGroupBox"
        Me.DownloadableListGroupBox.Size = New System.Drawing.Size(419, 116)
        Me.DownloadableListGroupBox.TabIndex = 3
        Me.DownloadableListGroupBox.TabStop = False
        Me.DownloadableListGroupBox.Text = "다운로드 가능한 리스트"
        '
        'AvailiableListLabel
        '
        Me.AvailiableListLabel.Location = New System.Drawing.Point(6, 22)
        Me.AvailiableListLabel.Name = "AvailiableListLabel"
        Me.AvailiableListLabel.Size = New System.Drawing.Size(407, 42)
        Me.AvailiableListLabel.TabIndex = 1
        Me.AvailiableListLabel.Text = "AnimationCheckerPro 에서 제공됬던 리스트를 다운로드 할수있습니다." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "일부 오래된 애니메이션의 미리보기 이미지는 제공되지 않을 수 " &
    "있습니다."
        '
        'AvailiableListDownloadButton
        '
        Me.AvailiableListDownloadButton.Enabled = False
        Me.AvailiableListDownloadButton.Location = New System.Drawing.Point(252, 67)
        Me.AvailiableListDownloadButton.Name = "AvailiableListDownloadButton"
        Me.AvailiableListDownloadButton.Size = New System.Drawing.Size(75, 23)
        Me.AvailiableListDownloadButton.TabIndex = 2
        Me.AvailiableListDownloadButton.Text = "다운로드"
        Me.AvailiableListDownloadButton.UseVisualStyleBackColor = True
        '
        'AvailiableListComboBox
        '
        Me.AvailiableListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AvailiableListComboBox.FormattingEnabled = True
        Me.AvailiableListComboBox.Location = New System.Drawing.Point(42, 67)
        Me.AvailiableListComboBox.Name = "AvailiableListComboBox"
        Me.AvailiableListComboBox.Size = New System.Drawing.Size(158, 23)
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
        Me.WebReachTestPanel.Controls.Add(Me.NTSRLabel)
        Me.WebReachTestPanel.Controls.Add(Me.GTLabel)
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
        Me.GTRLabel.Location = New System.Drawing.Point(112, 61)
        Me.GTRLabel.Name = "GTRLabel"
        Me.GTRLabel.Size = New System.Drawing.Size(61, 15)
        Me.GTRLabel.TabIndex = 5
        Me.GTRLabel.Text = "LOADING"
        '
        'NTSRLabel
        '
        Me.NTSRLabel.AutoSize = True
        Me.NTSRLabel.Location = New System.Drawing.Point(112, 18)
        Me.NTSRLabel.Name = "NTSRLabel"
        Me.NTSRLabel.Size = New System.Drawing.Size(61, 15)
        Me.NTSRLabel.TabIndex = 3
        Me.NTSRLabel.Text = "LOADING"
        '
        'GTLabel
        '
        Me.GTLabel.AutoSize = True
        Me.GTLabel.Location = New System.Drawing.Point(4, 60)
        Me.GTLabel.Name = "GTLabel"
        Me.GTLabel.Size = New System.Drawing.Size(102, 15)
        Me.GTLabel.TabIndex = 2
        Me.GTLabel.Text = "Google Stauts : "
        '
        'NTSTLabel
        '
        Me.NTSTLabel.AutoSize = True
        Me.NTSTLabel.Location = New System.Drawing.Point(30, 20)
        Me.NTSTLabel.Name = "NTSTLabel"
        Me.NTSTLabel.Size = New System.Drawing.Size(76, 15)
        Me.NTSTLabel.TabIndex = 0
        Me.NTSTLabel.Text = "NT Status : "
        '
        'NTSetPanel
        '
        Me.NTSetPanel.Controls.Add(Me.NTCatLabel)
        Me.NTSetPanel.Controls.Add(Me.NTCatComboBox)
        Me.NTSetPanel.Controls.Add(Me.NTFilterLabel)
        Me.NTSetPanel.Controls.Add(Me.NTFilterComboBox)
        Me.NTSetPanel.Location = New System.Drawing.Point(6, 22)
        Me.NTSetPanel.Name = "NTSetPanel"
        Me.NTSetPanel.Size = New System.Drawing.Size(446, 362)
        Me.NTSetPanel.TabIndex = 7
        '
        'NTCatLabel
        '
        Me.NTCatLabel.AutoSize = True
        Me.NTCatLabel.Location = New System.Drawing.Point(30, 20)
        Me.NTCatLabel.Name = "NTCatLabel"
        Me.NTCatLabel.Size = New System.Drawing.Size(119, 15)
        Me.NTCatLabel.TabIndex = 4
        Me.NTCatLabel.Text = "검색 카테고리 설정 : "
        '
        'NTCatComboBox
        '
        Me.NTCatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.NTCatComboBox.FormattingEnabled = True
        Me.NTCatComboBox.Items.AddRange(New Object() {"Raw-Animation", "모든 카테고리", "애니메이션 전체", "Audio 전체", "Lossless Audio", "Lossy Audio"})
        Me.NTCatComboBox.Location = New System.Drawing.Point(155, 15)
        Me.NTCatComboBox.Name = "NTCatComboBox"
        Me.NTCatComboBox.Size = New System.Drawing.Size(140, 23)
        Me.NTCatComboBox.TabIndex = 5
        '
        'NTFilterLabel
        '
        Me.NTFilterLabel.AutoSize = True
        Me.NTFilterLabel.Location = New System.Drawing.Point(40, 60)
        Me.NTFilterLabel.Name = "NTFilterLabel"
        Me.NTFilterLabel.Size = New System.Drawing.Size(107, 15)
        Me.NTFilterLabel.TabIndex = 6
        Me.NTFilterLabel.Text = "검색 필터링 설정 : "
        '
        'NTFilterComboBox
        '
        Me.NTFilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.NTFilterComboBox.FormattingEnabled = True
        Me.NTFilterComboBox.Items.AddRange(New Object() {"모두", "Filter remakes", "A+ 이상", "신뢰된것 모두"})
        Me.NTFilterComboBox.Location = New System.Drawing.Point(155, 55)
        Me.NTFilterComboBox.Name = "NTFilterComboBox"
        Me.NTFilterComboBox.Size = New System.Drawing.Size(140, 23)
        Me.NTFilterComboBox.TabIndex = 7
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
        Me.Controls.Add(Me.OptionPreset)
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
        Me.AvailiableListPanel.ResumeLayout(False)
        Me.DownloadableListGroupBox.ResumeLayout(False)
        Me.ExpandModePanel.ResumeLayout(False)
        Me.ActionSettingGroupBox.ResumeLayout(False)
        Me.WebReachTestPanel.ResumeLayout(False)
        Me.WebReachTestPanel.PerformLayout()
        Me.NTSetPanel.ResumeLayout(False)
        Me.NTSetPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OptionTreeView As System.Windows.Forms.TreeView
    Friend WithEvents OptionPreset As System.Windows.Forms.ComboBox
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
    Friend WithEvents NTFilterComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents NTFilterLabel As System.Windows.Forms.Label
    Friend WithEvents NTCatComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents NTCatLabel As System.Windows.Forms.Label
    Friend WithEvents ListInfoPanel As System.Windows.Forms.Panel
    Friend WithEvents ListProducerLabel As System.Windows.Forms.Label
    Friend WithEvents ListProducerInfoLabel As System.Windows.Forms.Label
    Friend WithEvents ListDateLabel As System.Windows.Forms.Label
    Friend WithEvents ListDateInfoLabel As System.Windows.Forms.Label
    Friend WithEvents AvailiableListPanel As System.Windows.Forms.Panel
    Friend WithEvents AvailiableListLabel As System.Windows.Forms.Label
    Friend WithEvents AvailiableListComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AvailiableListDownloadButton As System.Windows.Forms.Button
    Friend WithEvents ExpandModePanel As System.Windows.Forms.Panel
    Friend WithEvents ButtonActionComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ActionSettingGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents ActionSetLabel As System.Windows.Forms.Label
    Friend WithEvents NTSetPanel As System.Windows.Forms.Panel
    Friend WithEvents WebReachTestPanel As System.Windows.Forms.Panel
    Friend WithEvents GTRLabel As System.Windows.Forms.Label
    Friend WithEvents NTSRLabel As System.Windows.Forms.Label
    Friend WithEvents GTLabel As System.Windows.Forms.Label
    Friend WithEvents NTSTLabel As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ReTestButton As System.Windows.Forms.Button
    Friend WithEvents ImageFilteringComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ImageFilteringLabel As System.Windows.Forms.Label
    Friend WithEvents DownloadableListGroupBox As System.Windows.Forms.GroupBox
End Class
