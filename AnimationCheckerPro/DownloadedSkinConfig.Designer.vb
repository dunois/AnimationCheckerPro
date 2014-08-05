<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DownloadedSkinConfig
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DownloadedSkinConfig))
        Me.DownloadedSkinListBox = New System.Windows.Forms.ListBox()
        Me.SelectedSkinNameTitleLabel = New System.Windows.Forms.Label()
        Me.CurrentUseSkinNameTitleLabel = New System.Windows.Forms.Label()
        Me.SelectedSkinFileCheckTitleLabel = New System.Windows.Forms.Label()
        Me.SelectedSkinNameLabel = New System.Windows.Forms.Label()
        Me.CurrentUseSkinNameLabel = New System.Windows.Forms.Label()
        Me.SelectedSkinFileCheckLabel = New System.Windows.Forms.Label()
        Me.SelectedSkinUseButton = New System.Windows.Forms.Button()
        Me.CurrentUseSkinShowButton = New System.Windows.Forms.Button()
        Me.SelectedSkinShowButton = New System.Windows.Forms.Button()
        Me.SkinFileSkinListDeleteButton = New System.Windows.Forms.Button()
        Me.SkinListDeleteButton = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DownloadedSkinListBox
        '
        Me.DownloadedSkinListBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.DownloadedSkinListBox.FormattingEnabled = True
        Me.DownloadedSkinListBox.ItemHeight = 15
        Me.DownloadedSkinListBox.Location = New System.Drawing.Point(0, 0)
        Me.DownloadedSkinListBox.Margin = New System.Windows.Forms.Padding(0)
        Me.DownloadedSkinListBox.Name = "DownloadedSkinListBox"
        Me.DownloadedSkinListBox.Size = New System.Drawing.Size(421, 214)
        Me.DownloadedSkinListBox.TabIndex = 0
        '
        'SelectedSkinNameTitleLabel
        '
        Me.SelectedSkinNameTitleLabel.AutoSize = True
        Me.SelectedSkinNameTitleLabel.Location = New System.Drawing.Point(51, 232)
        Me.SelectedSkinNameTitleLabel.Name = "SelectedSkinNameTitleLabel"
        Me.SelectedSkinNameTitleLabel.Size = New System.Drawing.Size(104, 15)
        Me.SelectedSkinNameTitleLabel.TabIndex = 1
        Me.SelectedSkinNameTitleLabel.Text = "선택한 배경화면 : "
        '
        'CurrentUseSkinNameTitleLabel
        '
        Me.CurrentUseSkinNameTitleLabel.AutoSize = True
        Me.CurrentUseSkinNameTitleLabel.Location = New System.Drawing.Point(12, 262)
        Me.CurrentUseSkinNameTitleLabel.Name = "CurrentUseSkinNameTitleLabel"
        Me.CurrentUseSkinNameTitleLabel.Size = New System.Drawing.Size(143, 15)
        Me.CurrentUseSkinNameTitleLabel.TabIndex = 2
        Me.CurrentUseSkinNameTitleLabel.Text = "사용하고 있는 배경화면 : "
        '
        'SelectedSkinFileCheckTitleLabel
        '
        Me.SelectedSkinFileCheckTitleLabel.AutoSize = True
        Me.SelectedSkinFileCheckTitleLabel.Location = New System.Drawing.Point(87, 291)
        Me.SelectedSkinFileCheckTitleLabel.Name = "SelectedSkinFileCheckTitleLabel"
        Me.SelectedSkinFileCheckTitleLabel.Size = New System.Drawing.Size(68, 15)
        Me.SelectedSkinFileCheckTitleLabel.TabIndex = 3
        Me.SelectedSkinFileCheckTitleLabel.Text = "파일 확인 : "
        '
        'SelectedSkinNameLabel
        '
        Me.SelectedSkinNameLabel.AutoSize = True
        Me.SelectedSkinNameLabel.Location = New System.Drawing.Point(176, 232)
        Me.SelectedSkinNameLabel.Name = "SelectedSkinNameLabel"
        Me.SelectedSkinNameLabel.Size = New System.Drawing.Size(118, 15)
        Me.SelectedSkinNameLabel.TabIndex = 4
        Me.SelectedSkinNameLabel.Text = "항목을 선택해주세요"
        '
        'CurrentUseSkinNameLabel
        '
        Me.CurrentUseSkinNameLabel.AutoSize = True
        Me.CurrentUseSkinNameLabel.Location = New System.Drawing.Point(176, 262)
        Me.CurrentUseSkinNameLabel.Name = "CurrentUseSkinNameLabel"
        Me.CurrentUseSkinNameLabel.Size = New System.Drawing.Size(118, 15)
        Me.CurrentUseSkinNameLabel.TabIndex = 5
        Me.CurrentUseSkinNameLabel.Text = "항목을 선택해주세요"
        '
        'SelectedSkinFileCheckLabel
        '
        Me.SelectedSkinFileCheckLabel.AutoSize = True
        Me.SelectedSkinFileCheckLabel.Location = New System.Drawing.Point(176, 291)
        Me.SelectedSkinFileCheckLabel.Name = "SelectedSkinFileCheckLabel"
        Me.SelectedSkinFileCheckLabel.Size = New System.Drawing.Size(118, 15)
        Me.SelectedSkinFileCheckLabel.TabIndex = 6
        Me.SelectedSkinFileCheckLabel.Text = "항목을 선택해주세요"
        '
        'SelectedSkinUseButton
        '
        Me.SelectedSkinUseButton.Enabled = False
        Me.SelectedSkinUseButton.Location = New System.Drawing.Point(15, 321)
        Me.SelectedSkinUseButton.Name = "SelectedSkinUseButton"
        Me.SelectedSkinUseButton.Size = New System.Drawing.Size(203, 23)
        Me.SelectedSkinUseButton.TabIndex = 7
        Me.SelectedSkinUseButton.Text = "선택한 파일을 배경화면으로  사용"
        Me.SelectedSkinUseButton.UseVisualStyleBackColor = True
        '
        'CurrentUseSkinShowButton
        '
        Me.CurrentUseSkinShowButton.Enabled = False
        Me.CurrentUseSkinShowButton.Location = New System.Drawing.Point(224, 321)
        Me.CurrentUseSkinShowButton.Name = "CurrentUseSkinShowButton"
        Me.CurrentUseSkinShowButton.Size = New System.Drawing.Size(172, 23)
        Me.CurrentUseSkinShowButton.TabIndex = 8
        Me.CurrentUseSkinShowButton.Text = "사용중인 배경화면 보기"
        Me.CurrentUseSkinShowButton.UseVisualStyleBackColor = True
        '
        'SelectedSkinShowButton
        '
        Me.SelectedSkinShowButton.Enabled = False
        Me.SelectedSkinShowButton.Location = New System.Drawing.Point(15, 379)
        Me.SelectedSkinShowButton.Name = "SelectedSkinShowButton"
        Me.SelectedSkinShowButton.Size = New System.Drawing.Size(203, 23)
        Me.SelectedSkinShowButton.TabIndex = 9
        Me.SelectedSkinShowButton.Text = "선택한 파일 보기"
        Me.SelectedSkinShowButton.UseVisualStyleBackColor = True
        '
        'SkinFileSkinListDeleteButton
        '
        Me.SkinFileSkinListDeleteButton.Location = New System.Drawing.Point(15, 350)
        Me.SkinFileSkinListDeleteButton.Name = "SkinFileSkinListDeleteButton"
        Me.SkinFileSkinListDeleteButton.Size = New System.Drawing.Size(203, 23)
        Me.SkinFileSkinListDeleteButton.TabIndex = 10
        Me.SkinFileSkinListDeleteButton.Text = "배경화면 및 사용내역 삭제"
        Me.SkinFileSkinListDeleteButton.UseVisualStyleBackColor = True
        '
        'SkinListDeleteButton
        '
        Me.SkinListDeleteButton.Location = New System.Drawing.Point(224, 350)
        Me.SkinListDeleteButton.Name = "SkinListDeleteButton"
        Me.SkinListDeleteButton.Size = New System.Drawing.Size(172, 23)
        Me.SkinListDeleteButton.TabIndex = 11
        Me.SkinListDeleteButton.Text = "배경화면 다운로드내역 삭제"
        Me.SkinListDeleteButton.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(298, 409)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 12
        Me.Button6.Text = "닫기"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'DownloadedSkinConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 445)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.SkinListDeleteButton)
        Me.Controls.Add(Me.SkinFileSkinListDeleteButton)
        Me.Controls.Add(Me.SelectedSkinShowButton)
        Me.Controls.Add(Me.CurrentUseSkinShowButton)
        Me.Controls.Add(Me.SelectedSkinUseButton)
        Me.Controls.Add(Me.SelectedSkinFileCheckLabel)
        Me.Controls.Add(Me.CurrentUseSkinNameLabel)
        Me.Controls.Add(Me.SelectedSkinNameLabel)
        Me.Controls.Add(Me.SelectedSkinFileCheckTitleLabel)
        Me.Controls.Add(Me.CurrentUseSkinNameTitleLabel)
        Me.Controls.Add(Me.SelectedSkinNameTitleLabel)
        Me.Controls.Add(Me.DownloadedSkinListBox)
        Me.Font = New System.Drawing.Font("나눔바른고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DownloadedSkinConfig"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "다운로드한 배경화면 관리"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DownloadedSkinListBox As System.Windows.Forms.ListBox
    Friend WithEvents SelectedSkinNameTitleLabel As System.Windows.Forms.Label
    Friend WithEvents CurrentUseSkinNameTitleLabel As System.Windows.Forms.Label
    Friend WithEvents SelectedSkinFileCheckTitleLabel As System.Windows.Forms.Label
    Friend WithEvents SelectedSkinNameLabel As System.Windows.Forms.Label
    Friend WithEvents CurrentUseSkinNameLabel As System.Windows.Forms.Label
    Friend WithEvents SelectedSkinFileCheckLabel As System.Windows.Forms.Label
    Friend WithEvents SelectedSkinUseButton As System.Windows.Forms.Button
    Friend WithEvents CurrentUseSkinShowButton As System.Windows.Forms.Button
    Friend WithEvents SelectedSkinShowButton As System.Windows.Forms.Button
    Friend WithEvents SkinFileSkinListDeleteButton As System.Windows.Forms.Button
    Friend WithEvents SkinListDeleteButton As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
End Class
