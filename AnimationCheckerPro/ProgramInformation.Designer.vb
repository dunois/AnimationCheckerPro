<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProgramInformation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProgramInformation))
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.MainTabControl = New System.Windows.Forms.TabControl()
        Me.ProgramInfoTabPage = New System.Windows.Forms.TabPage()
        Me.CopyrightLabel = New System.Windows.Forms.Label()
        Me.VersionInfoLabel = New System.Windows.Forms.Label()
        Me.ProgramLabel = New System.Windows.Forms.Label()
        Me.UpdateInfoTabPage = New System.Windows.Forms.TabPage()
        Me.ChangeLogRichTextBox = New System.Windows.Forms.RichTextBox()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainTabControl.SuspendLayout()
        Me.ProgramInfoTabPage.SuspendLayout()
        Me.UpdateInfoTabPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(8, 8)
        Me.LogoPictureBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(498, 192)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'MainTabControl
        '
        Me.MainTabControl.Controls.Add(Me.ProgramInfoTabPage)
        Me.MainTabControl.Controls.Add(Me.UpdateInfoTabPage)
        Me.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainTabControl.Location = New System.Drawing.Point(0, 0)
        Me.MainTabControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MainTabControl.Name = "MainTabControl"
        Me.MainTabControl.SelectedIndex = 0
        Me.MainTabControl.Size = New System.Drawing.Size(490, 401)
        Me.MainTabControl.TabIndex = 1
        '
        'ProgramInfoTabPage
        '
        Me.ProgramInfoTabPage.Controls.Add(Me.CopyrightLabel)
        Me.ProgramInfoTabPage.Controls.Add(Me.VersionInfoLabel)
        Me.ProgramInfoTabPage.Controls.Add(Me.ProgramLabel)
        Me.ProgramInfoTabPage.Controls.Add(Me.LogoPictureBox)
        Me.ProgramInfoTabPage.Location = New System.Drawing.Point(4, 24)
        Me.ProgramInfoTabPage.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ProgramInfoTabPage.Name = "ProgramInfoTabPage"
        Me.ProgramInfoTabPage.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ProgramInfoTabPage.Size = New System.Drawing.Size(482, 373)
        Me.ProgramInfoTabPage.TabIndex = 0
        Me.ProgramInfoTabPage.Text = "프로그램 정보"
        Me.ProgramInfoTabPage.UseVisualStyleBackColor = True
        '
        'CopyrightLabel
        '
        Me.CopyrightLabel.AutoSize = True
        Me.CopyrightLabel.Location = New System.Drawing.Point(42, 298)
        Me.CopyrightLabel.Name = "CopyrightLabel"
        Me.CopyrightLabel.Size = New System.Drawing.Size(406, 15)
        Me.CopyrightLabel.TabIndex = 3
        Me.CopyrightLabel.Text = "Copyrigth (C) Dunois Soft, DNSoft, REAL TIME™ All Right Reserved"
        '
        'VersionInfoLabel
        '
        Me.VersionInfoLabel.AutoSize = True
        Me.VersionInfoLabel.Location = New System.Drawing.Point(75, 268)
        Me.VersionInfoLabel.Name = "VersionInfoLabel"
        Me.VersionInfoLabel.Size = New System.Drawing.Size(90, 15)
        Me.VersionInfoLabel.TabIndex = 2
        Me.VersionInfoLabel.Text = "버전 : Loading"
        '
        'ProgramLabel
        '
        Me.ProgramLabel.AutoSize = True
        Me.ProgramLabel.Font = New System.Drawing.Font("나눔고딕", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ProgramLabel.Location = New System.Drawing.Point(40, 222)
        Me.ProgramLabel.Name = "ProgramLabel"
        Me.ProgramLabel.Size = New System.Drawing.Size(272, 28)
        Me.ProgramLabel.TabIndex = 1
        Me.ProgramLabel.Text = "Aniamtion Checker Pro"
        '
        'UpdateInfoTabPage
        '
        Me.UpdateInfoTabPage.BackColor = System.Drawing.SystemColors.Control
        Me.UpdateInfoTabPage.Controls.Add(Me.ChangeLogRichTextBox)
        Me.UpdateInfoTabPage.Location = New System.Drawing.Point(4, 24)
        Me.UpdateInfoTabPage.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.UpdateInfoTabPage.Name = "UpdateInfoTabPage"
        Me.UpdateInfoTabPage.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.UpdateInfoTabPage.Size = New System.Drawing.Size(482, 373)
        Me.UpdateInfoTabPage.TabIndex = 1
        Me.UpdateInfoTabPage.Text = "업데이트 정보"
        '
        'ChangeLogRichTextBox
        '
        Me.ChangeLogRichTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.ChangeLogRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ChangeLogRichTextBox.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.ChangeLogRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChangeLogRichTextBox.Font = New System.Drawing.Font("나눔바른고딕", 8.95!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ChangeLogRichTextBox.Location = New System.Drawing.Point(3, 4)
        Me.ChangeLogRichTextBox.Name = "ChangeLogRichTextBox"
        Me.ChangeLogRichTextBox.ReadOnly = True
        Me.ChangeLogRichTextBox.Size = New System.Drawing.Size(476, 365)
        Me.ChangeLogRichTextBox.TabIndex = 0
        Me.ChangeLogRichTextBox.Text = resources.GetString("ChangeLogRichTextBox.Text")
        '
        'ProgramInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 401)
        Me.Controls.Add(Me.MainTabControl)
        Me.Font = New System.Drawing.Font("나눔바른고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ProgramInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "프로그램 정보"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainTabControl.ResumeLayout(False)
        Me.ProgramInfoTabPage.ResumeLayout(False)
        Me.ProgramInfoTabPage.PerformLayout()
        Me.UpdateInfoTabPage.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents MainTabControl As System.Windows.Forms.TabControl
    Friend WithEvents ProgramInfoTabPage As System.Windows.Forms.TabPage
    Friend WithEvents CopyrightLabel As System.Windows.Forms.Label
    Friend WithEvents VersionInfoLabel As System.Windows.Forms.Label
    Friend WithEvents ProgramLabel As System.Windows.Forms.Label
    Friend WithEvents UpdateInfoTabPage As System.Windows.Forms.TabPage
    Friend WithEvents ChangeLogRichTextBox As System.Windows.Forms.RichTextBox
End Class
