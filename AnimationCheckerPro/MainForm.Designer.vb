﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.DownloadProgressBar = New System.Windows.Forms.ProgressBar()
        Me.DownSpeedLabel = New System.Windows.Forms.Label()
        Me.DownloadStatusLabel = New System.Windows.Forms.Label()
        Me.FormLoadCompleteTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ErrorCloseButton = New System.Windows.Forms.Button()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.SkinPanel = New System.Windows.Forms.Panel()
        Me.ImagePanel = New System.Windows.Forms.Panel()
        Me.ImgDownloadProgressBar = New System.Windows.Forms.ProgressBar()
        Me.FilterCancelButton = New System.Windows.Forms.Button()
        Me.ImageErrorLabel = New System.Windows.Forms.Label()
        Me.StillCutPictureBox = New System.Windows.Forms.PictureBox()
        Me.SubLinkButton = New System.Windows.Forms.Button()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.MainMenu = New System.Windows.Forms.ToolStrip()
        Me.WeekComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.OptionButton = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ProgramInformationButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgramConfigButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.SkinRootButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteCacheButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolMenuButton = New System.Windows.Forms.ToolStripDropDownButton()
        Me.SubFileNameChangerMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnimationSaveFolderOpenMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListChangeButton = New System.Windows.Forms.ToolStripButton()
        Me.ShowImageButton = New System.Windows.Forms.ToolStripButton()
        Me.HideImageButton = New System.Windows.Forms.ToolStripButton()
        Me.SubListBox = New System.Windows.Forms.ListBox()
        Me.SearchListBox = New System.Windows.Forms.ListBox()
        Me.AnimationListBox = New System.Windows.Forms.ListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SplashPictureBox = New System.Windows.Forms.PictureBox()
        Me.NotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.QuickMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenQuickMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.InfoQuickMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionQuickMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseQuickMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.PingBackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.TimeToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MainPanel.SuspendLayout()
        Me.SkinPanel.SuspendLayout()
        Me.ImagePanel.SuspendLayout()
        CType(Me.StillCutPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainMenu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.SplashPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.QuickMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'DownloadProgressBar
        '
        Me.DownloadProgressBar.Location = New System.Drawing.Point(71, 229)
        Me.DownloadProgressBar.Margin = New System.Windows.Forms.Padding(0)
        Me.DownloadProgressBar.Name = "DownloadProgressBar"
        Me.DownloadProgressBar.Size = New System.Drawing.Size(352, 23)
        Me.DownloadProgressBar.TabIndex = 0
        '
        'DownSpeedLabel
        '
        Me.DownSpeedLabel.AutoSize = True
        Me.DownSpeedLabel.BackColor = System.Drawing.Color.White
        Me.DownSpeedLabel.Location = New System.Drawing.Point(68, 262)
        Me.DownSpeedLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.DownSpeedLabel.Name = "DownSpeedLabel"
        Me.DownSpeedLabel.Size = New System.Drawing.Size(83, 15)
        Me.DownSpeedLabel.TabIndex = 1
        Me.DownSpeedLabel.Text = "다운로드 속도"
        '
        'DownloadStatusLabel
        '
        Me.DownloadStatusLabel.AutoSize = True
        Me.DownloadStatusLabel.BackColor = System.Drawing.Color.White
        Me.DownloadStatusLabel.Location = New System.Drawing.Point(435, 262)
        Me.DownloadStatusLabel.Name = "DownloadStatusLabel"
        Me.DownloadStatusLabel.Size = New System.Drawing.Size(83, 15)
        Me.DownloadStatusLabel.TabIndex = 3
        Me.DownloadStatusLabel.Text = "다운로드 상태"
        '
        'FormLoadCompleteTimer
        '
        '
        'ErrorCloseButton
        '
        Me.ErrorCloseButton.Location = New System.Drawing.Point(443, 229)
        Me.ErrorCloseButton.Name = "ErrorCloseButton"
        Me.ErrorCloseButton.Size = New System.Drawing.Size(75, 23)
        Me.ErrorCloseButton.TabIndex = 4
        Me.ErrorCloseButton.Text = "닫기"
        Me.ErrorCloseButton.UseVisualStyleBackColor = True
        Me.ErrorCloseButton.Visible = False
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.SkinPanel)
        Me.MainPanel.Controls.Add(Me.MainMenu)
        Me.MainPanel.Controls.Add(Me.SubListBox)
        Me.MainPanel.Controls.Add(Me.SearchListBox)
        Me.MainPanel.Controls.Add(Me.AnimationListBox)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(1354, 655)
        Me.MainPanel.TabIndex = 5
        Me.MainPanel.Visible = False
        '
        'SkinPanel
        '
        Me.SkinPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SkinPanel.Controls.Add(Me.ImagePanel)
        Me.SkinPanel.Controls.Add(Me.SubLinkButton)
        Me.SkinPanel.Controls.Add(Me.SearchButton)
        Me.SkinPanel.Controls.Add(Me.TimeLabel)
        Me.SkinPanel.Location = New System.Drawing.Point(290, 28)
        Me.SkinPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.SkinPanel.Name = "SkinPanel"
        Me.SkinPanel.Size = New System.Drawing.Size(1055, 618)
        Me.SkinPanel.TabIndex = 5
        '
        'ImagePanel
        '
        Me.ImagePanel.AutoScroll = True
        Me.ImagePanel.BackColor = System.Drawing.Color.Transparent
        Me.ImagePanel.Controls.Add(Me.ImgDownloadProgressBar)
        Me.ImagePanel.Controls.Add(Me.FilterCancelButton)
        Me.ImagePanel.Controls.Add(Me.ImageErrorLabel)
        Me.ImagePanel.Controls.Add(Me.StillCutPictureBox)
        Me.ImagePanel.Location = New System.Drawing.Point(50, 20)
        Me.ImagePanel.Name = "ImagePanel"
        Me.ImagePanel.Size = New System.Drawing.Size(975, 510)
        Me.ImagePanel.TabIndex = 8
        '
        'ImgDownloadProgressBar
        '
        Me.ImgDownloadProgressBar.Location = New System.Drawing.Point(334, 233)
        Me.ImgDownloadProgressBar.Name = "ImgDownloadProgressBar"
        Me.ImgDownloadProgressBar.Size = New System.Drawing.Size(350, 23)
        Me.ImgDownloadProgressBar.TabIndex = 13
        Me.ImgDownloadProgressBar.Visible = False
        '
        'FilterCancelButton
        '
        Me.FilterCancelButton.Location = New System.Drawing.Point(334, 233)
        Me.FilterCancelButton.Name = "FilterCancelButton"
        Me.FilterCancelButton.Size = New System.Drawing.Size(146, 23)
        Me.FilterCancelButton.TabIndex = 12
        Me.FilterCancelButton.Text = "이미지 보기"
        Me.FilterCancelButton.UseVisualStyleBackColor = True
        Me.FilterCancelButton.Visible = False
        '
        'ImageErrorLabel
        '
        Me.ImageErrorLabel.AutoSize = True
        Me.ImageErrorLabel.Location = New System.Drawing.Point(370, 237)
        Me.ImageErrorLabel.Name = "ImageErrorLabel"
        Me.ImageErrorLabel.Size = New System.Drawing.Size(215, 15)
        Me.ImageErrorLabel.TabIndex = 11
        Me.ImageErrorLabel.Text = "서버에 사진이 저장되어있지 않습니다."
        Me.ImageErrorLabel.Visible = False
        '
        'StillCutPictureBox
        '
        Me.StillCutPictureBox.Location = New System.Drawing.Point(27, 19)
        Me.StillCutPictureBox.Name = "StillCutPictureBox"
        Me.StillCutPictureBox.Size = New System.Drawing.Size(930, 420)
        Me.StillCutPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.StillCutPictureBox.TabIndex = 0
        Me.StillCutPictureBox.TabStop = False
        '
        'SubLinkButton
        '
        Me.SubLinkButton.Enabled = False
        Me.SubLinkButton.Location = New System.Drawing.Point(143, 560)
        Me.SubLinkButton.Margin = New System.Windows.Forms.Padding(0)
        Me.SubLinkButton.Name = "SubLinkButton"
        Me.SubLinkButton.Size = New System.Drawing.Size(90, 31)
        Me.SubLinkButton.TabIndex = 6
        Me.SubLinkButton.Text = "블로그 이동"
        Me.SubLinkButton.UseVisualStyleBackColor = True
        '
        'SearchButton
        '
        Me.SearchButton.Enabled = False
        Me.SearchButton.Location = New System.Drawing.Point(50, 560)
        Me.SearchButton.Margin = New System.Windows.Forms.Padding(0)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(83, 31)
        Me.SearchButton.TabIndex = 5
        Me.SearchButton.Text = "검색"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'TimeLabel
        '
        Me.TimeLabel.AutoSize = True
        Me.TimeLabel.Location = New System.Drawing.Point(132, 355)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(155, 15)
        Me.TimeLabel.TabIndex = 2
        Me.TimeLabel.Text = "애니메이션을 선택해주세요"
        '
        'MainMenu
        '
        Me.MainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WeekComboBox, Me.OptionButton, Me.ToolMenuButton, Me.ListChangeButton, Me.ShowImageButton, Me.HideImageButton})
        Me.MainMenu.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Size = New System.Drawing.Size(1354, 25)
        Me.MainMenu.TabIndex = 4
        Me.MainMenu.Text = "ToolStrip1"
        '
        'WeekComboBox
        '
        Me.WeekComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.WeekComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.WeekComboBox.Items.AddRange(New Object() {"일요일", "월요일", "화요일", "수요일", "목요일", "금요일", "토요일"})
        Me.WeekComboBox.Name = "WeekComboBox"
        Me.WeekComboBox.Size = New System.Drawing.Size(121, 25)
        '
        'OptionButton
        '
        Me.OptionButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.OptionButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramInformationButton, Me.ProgramConfigButton, Me.SkinRootButton, Me.DeleteCacheButton})
        Me.OptionButton.Image = CType(resources.GetObject("OptionButton.Image"), System.Drawing.Image)
        Me.OptionButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OptionButton.Name = "OptionButton"
        Me.OptionButton.Size = New System.Drawing.Size(44, 22)
        Me.OptionButton.Text = "옵션"
        '
        'ProgramInformationButton
        '
        Me.ProgramInformationButton.Name = "ProgramInformationButton"
        Me.ProgramInformationButton.Size = New System.Drawing.Size(178, 22)
        Me.ProgramInformationButton.Text = "프로그램 정보"
        '
        'ProgramConfigButton
        '
        Me.ProgramConfigButton.Name = "ProgramConfigButton"
        Me.ProgramConfigButton.Size = New System.Drawing.Size(178, 22)
        Me.ProgramConfigButton.Text = "프로그램 설정"
        '
        'SkinRootButton
        '
        Me.SkinRootButton.Name = "SkinRootButton"
        Me.SkinRootButton.Size = New System.Drawing.Size(178, 22)
        Me.SkinRootButton.Text = "배경화면 설정"
        '
        'DeleteCacheButton
        '
        Me.DeleteCacheButton.Name = "DeleteCacheButton"
        Me.DeleteCacheButton.Size = New System.Drawing.Size(178, 22)
        Me.DeleteCacheButton.Text = "이미지 캐시 지우기"
        '
        'ToolMenuButton
        '
        Me.ToolMenuButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolMenuButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SubFileNameChangerMenu, Me.AnimationSaveFolderOpenMenu})
        Me.ToolMenuButton.Enabled = False
        Me.ToolMenuButton.Image = CType(resources.GetObject("ToolMenuButton.Image"), System.Drawing.Image)
        Me.ToolMenuButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolMenuButton.Name = "ToolMenuButton"
        Me.ToolMenuButton.Size = New System.Drawing.Size(44, 22)
        Me.ToolMenuButton.Text = "도구"
        '
        'SubFileNameChangerMenu
        '
        Me.SubFileNameChangerMenu.Enabled = False
        Me.SubFileNameChangerMenu.Name = "SubFileNameChangerMenu"
        Me.SubFileNameChangerMenu.Size = New System.Drawing.Size(218, 22)
        Me.SubFileNameChangerMenu.Text = "자막 파일명 변환"
        '
        'AnimationSaveFolderOpenMenu
        '
        Me.AnimationSaveFolderOpenMenu.Name = "AnimationSaveFolderOpenMenu"
        Me.AnimationSaveFolderOpenMenu.Size = New System.Drawing.Size(218, 22)
        Me.AnimationSaveFolderOpenMenu.Text = "애니메이션 저장 폴더 열기"
        '
        'ListChangeButton
        '
        Me.ListChangeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ListChangeButton.Image = CType(resources.GetObject("ListChangeButton.Image"), System.Drawing.Image)
        Me.ListChangeButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ListChangeButton.Name = "ListChangeButton"
        Me.ListChangeButton.Size = New System.Drawing.Size(75, 22)
        Me.ListChangeButton.Text = "리스트 변경"
        '
        'ShowImageButton
        '
        Me.ShowImageButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ShowImageButton.Image = CType(resources.GetObject("ShowImageButton.Image"), System.Drawing.Image)
        Me.ShowImageButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ShowImageButton.Name = "ShowImageButton"
        Me.ShowImageButton.Size = New System.Drawing.Size(103, 22)
        Me.ShowImageButton.Text = "이미지 원본 보기"
        Me.ShowImageButton.Visible = False
        '
        'HideImageButton
        '
        Me.HideImageButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.HideImageButton.Image = CType(resources.GetObject("HideImageButton.Image"), System.Drawing.Image)
        Me.HideImageButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.HideImageButton.Name = "HideImageButton"
        Me.HideImageButton.Size = New System.Drawing.Size(87, 22)
        Me.HideImageButton.Text = "이미지 숨기기"
        Me.HideImageButton.Visible = False
        '
        'SubListBox
        '
        Me.SubListBox.FormattingEnabled = True
        Me.SubListBox.HorizontalScrollbar = True
        Me.SubListBox.ItemHeight = 15
        Me.SubListBox.Items.AddRange(New Object() {"애니메이션을 선택하세요"})
        Me.SubListBox.Location = New System.Drawing.Point(9, 477)
        Me.SubListBox.Margin = New System.Windows.Forms.Padding(0)
        Me.SubListBox.Name = "SubListBox"
        Me.SubListBox.Size = New System.Drawing.Size(278, 169)
        Me.SubListBox.TabIndex = 2
        '
        'SearchListBox
        '
        Me.SearchListBox.FormattingEnabled = True
        Me.SearchListBox.HorizontalScrollbar = True
        Me.SearchListBox.ItemHeight = 15
        Me.SearchListBox.Items.AddRange(New Object() {"애니메이션을 선택하세요"})
        Me.SearchListBox.Location = New System.Drawing.Point(9, 302)
        Me.SearchListBox.Margin = New System.Windows.Forms.Padding(0)
        Me.SearchListBox.Name = "SearchListBox"
        Me.SearchListBox.Size = New System.Drawing.Size(278, 169)
        Me.SearchListBox.TabIndex = 1
        '
        'AnimationListBox
        '
        Me.AnimationListBox.FormattingEnabled = True
        Me.AnimationListBox.HorizontalScrollbar = True
        Me.AnimationListBox.ItemHeight = 15
        Me.AnimationListBox.Items.AddRange(New Object() {"리스트를 로딩중입니다."})
        Me.AnimationListBox.Location = New System.Drawing.Point(9, 28)
        Me.AnimationListBox.Name = "AnimationListBox"
        Me.AnimationListBox.Size = New System.Drawing.Size(278, 259)
        Me.AnimationListBox.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SplashPictureBox)
        Me.Panel1.Controls.Add(Me.ErrorCloseButton)
        Me.Panel1.Controls.Add(Me.DownSpeedLabel)
        Me.Panel1.Controls.Add(Me.DownloadProgressBar)
        Me.Panel1.Controls.Add(Me.DownloadStatusLabel)
        Me.Panel1.Location = New System.Drawing.Point(380, 194)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(570, 329)
        Me.Panel1.TabIndex = 13
        '
        'SplashPictureBox
        '
        Me.SplashPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SplashPictureBox.Image = CType(resources.GetObject("SplashPictureBox.Image"), System.Drawing.Image)
        Me.SplashPictureBox.Location = New System.Drawing.Point(30, 28)
        Me.SplashPictureBox.Name = "SplashPictureBox"
        Me.SplashPictureBox.Size = New System.Drawing.Size(488, 195)
        Me.SplashPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.SplashPictureBox.TabIndex = 6
        Me.SplashPictureBox.TabStop = False
        '
        'NotifyIcon
        '
        Me.NotifyIcon.ContextMenuStrip = Me.QuickMenu
        Me.NotifyIcon.Icon = CType(resources.GetObject("NotifyIcon.Icon"), System.Drawing.Icon)
        Me.NotifyIcon.Text = "AnimationCheckerPro"
        '
        'QuickMenu
        '
        Me.QuickMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenQuickMenu, Me.ToolStripSeparator2, Me.InfoQuickMenu, Me.OptionQuickMenu, Me.ToolStripSeparator1, Me.CloseQuickMenu})
        Me.QuickMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.QuickMenu.Name = "QuickMenu"
        Me.QuickMenu.ShowCheckMargin = True
        Me.QuickMenu.ShowImageMargin = False
        Me.QuickMenu.ShowItemToolTips = False
        Me.QuickMenu.Size = New System.Drawing.Size(172, 104)
        '
        'OpenQuickMenu
        '
        Me.OpenQuickMenu.Name = "OpenQuickMenu"
        Me.OpenQuickMenu.Size = New System.Drawing.Size(171, 22)
        Me.OpenQuickMenu.Text = "프로그램 열기 (&O)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(168, 6)
        '
        'InfoQuickMenu
        '
        Me.InfoQuickMenu.Name = "InfoQuickMenu"
        Me.InfoQuickMenu.Size = New System.Drawing.Size(171, 22)
        Me.InfoQuickMenu.Text = "프로그램 정보 (&I)"
        '
        'OptionQuickMenu
        '
        Me.OptionQuickMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.OptionQuickMenu.Name = "OptionQuickMenu"
        Me.OptionQuickMenu.Size = New System.Drawing.Size(171, 22)
        Me.OptionQuickMenu.Text = "옵션 (&P)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(168, 6)
        '
        'CloseQuickMenu
        '
        Me.CloseQuickMenu.Name = "CloseQuickMenu"
        Me.CloseQuickMenu.Size = New System.Drawing.Size(171, 22)
        Me.CloseQuickMenu.Text = "끝내기 (&E)"
        '
        'PingBackgroundWorker
        '
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1354, 655)
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("나눔고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Animation CheckerPro"
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanel.PerformLayout()
        Me.SkinPanel.ResumeLayout(False)
        Me.SkinPanel.PerformLayout()
        Me.ImagePanel.ResumeLayout(False)
        Me.ImagePanel.PerformLayout()
        CType(Me.StillCutPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainMenu.ResumeLayout(False)
        Me.MainMenu.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.SplashPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.QuickMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DownloadProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents DownSpeedLabel As System.Windows.Forms.Label
    Friend WithEvents DownloadStatusLabel As System.Windows.Forms.Label
    Friend WithEvents FormLoadCompleteTimer As System.Windows.Forms.Timer
    Friend WithEvents ErrorCloseButton As System.Windows.Forms.Button
    Friend WithEvents MainPanel As System.Windows.Forms.Panel
    Friend WithEvents SkinPanel As System.Windows.Forms.Panel
    Friend WithEvents StillCutPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents MainMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents OptionButton As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ToolMenuButton As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents SubListBox As System.Windows.Forms.ListBox
    Friend WithEvents SearchListBox As System.Windows.Forms.ListBox
    Friend WithEvents AnimationListBox As System.Windows.Forms.ListBox
    Friend WithEvents SplashPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents TimeLabel As System.Windows.Forms.Label
    Friend WithEvents WeekComboBox As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents SubLinkButton As System.Windows.Forms.Button
    Friend WithEvents SearchButton As System.Windows.Forms.Button
    Friend WithEvents ImagePanel As System.Windows.Forms.Panel
    Friend WithEvents ProgramConfigButton As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SkinRootButton As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProgramInformationButton As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotifyIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents SubFileNameChangerMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnimationSaveFolderOpenMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PingBackgroundWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents ImageErrorLabel As System.Windows.Forms.Label
    Friend WithEvents FilterCancelButton As System.Windows.Forms.Button
    Friend WithEvents QuickMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents OpenQuickMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InfoQuickMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionQuickMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseQuickMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ListChangeButton As ToolStripButton
    Friend WithEvents ShowImageButton As ToolStripButton
    Friend WithEvents HideImageButton As ToolStripButton
    Friend WithEvents TimeToolTip As ToolTip
    Friend WithEvents ImgDownloadProgressBar As ProgressBar
    Friend WithEvents DeleteCacheButton As ToolStripMenuItem
End Class
