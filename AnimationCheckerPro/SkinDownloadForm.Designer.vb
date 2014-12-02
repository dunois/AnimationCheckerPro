<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SkinDownloadForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SkinDownloadForm))
        Me.SkinListBox = New System.Windows.Forms.ListBox()
        Me.SkinPictureBox = New System.Windows.Forms.PictureBox()
        Me.SkinPanel = New System.Windows.Forms.Panel()
        Me.ShowLargeImageButton = New System.Windows.Forms.Button()
        Me.InstalledSkinCheckButton = New System.Windows.Forms.Button()
        Me.SkinApplyButton = New System.Windows.Forms.Button()
        Me.FormCloseButton = New System.Windows.Forms.Button()
        Me.ImageLabel = New System.Windows.Forms.Label()
        Me.ImageModeComboBox = New System.Windows.Forms.ComboBox()
        CType(Me.SkinPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SkinPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'SkinListBox
        '
        Me.SkinListBox.FormattingEnabled = True
        Me.SkinListBox.ItemHeight = 15
        Me.SkinListBox.Location = New System.Drawing.Point(2, 2)
        Me.SkinListBox.Name = "SkinListBox"
        Me.SkinListBox.Size = New System.Drawing.Size(255, 709)
        Me.SkinListBox.TabIndex = 0
        '
        'SkinPictureBox
        '
        Me.SkinPictureBox.Location = New System.Drawing.Point(12, 13)
        Me.SkinPictureBox.Name = "SkinPictureBox"
        Me.SkinPictureBox.Size = New System.Drawing.Size(927, 610)
        Me.SkinPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.SkinPictureBox.TabIndex = 1
        Me.SkinPictureBox.TabStop = False
        '
        'SkinPanel
        '
        Me.SkinPanel.Controls.Add(Me.SkinPictureBox)
        Me.SkinPanel.Location = New System.Drawing.Point(263, 44)
        Me.SkinPanel.Name = "SkinPanel"
        Me.SkinPanel.Size = New System.Drawing.Size(959, 637)
        Me.SkinPanel.TabIndex = 2
        '
        'ShowLargeImageButton
        '
        Me.ShowLargeImageButton.Location = New System.Drawing.Point(1111, 12)
        Me.ShowLargeImageButton.Name = "ShowLargeImageButton"
        Me.ShowLargeImageButton.Size = New System.Drawing.Size(110, 23)
        Me.ShowLargeImageButton.TabIndex = 3
        Me.ShowLargeImageButton.Text = "원본 크기로 보기"
        Me.ShowLargeImageButton.UseVisualStyleBackColor = True
        '
        'InstalledSkinCheckButton
        '
        Me.InstalledSkinCheckButton.Location = New System.Drawing.Point(959, 12)
        Me.InstalledSkinCheckButton.Name = "InstalledSkinCheckButton"
        Me.InstalledSkinCheckButton.Size = New System.Drawing.Size(146, 23)
        Me.InstalledSkinCheckButton.TabIndex = 4
        Me.InstalledSkinCheckButton.Text = "설치된 배경하면 확인"
        Me.InstalledSkinCheckButton.UseVisualStyleBackColor = True
        '
        'SkinApplyButton
        '
        Me.SkinApplyButton.Enabled = False
        Me.SkinApplyButton.Location = New System.Drawing.Point(878, 12)
        Me.SkinApplyButton.Name = "SkinApplyButton"
        Me.SkinApplyButton.Size = New System.Drawing.Size(75, 23)
        Me.SkinApplyButton.TabIndex = 5
        Me.SkinApplyButton.Text = "화면 적용"
        Me.SkinApplyButton.UseVisualStyleBackColor = True
        '
        'FormCloseButton
        '
        Me.FormCloseButton.Location = New System.Drawing.Point(1147, 688)
        Me.FormCloseButton.Name = "FormCloseButton"
        Me.FormCloseButton.Size = New System.Drawing.Size(75, 23)
        Me.FormCloseButton.TabIndex = 6
        Me.FormCloseButton.Text = "닫기"
        Me.FormCloseButton.UseVisualStyleBackColor = True
        '
        'ImageLabel
        '
        Me.ImageLabel.AutoSize = True
        Me.ImageLabel.Location = New System.Drawing.Point(263, 12)
        Me.ImageLabel.Name = "ImageLabel"
        Me.ImageLabel.Size = New System.Drawing.Size(68, 15)
        Me.ImageLabel.TabIndex = 7
        Me.ImageLabel.Text = "보기 모드 : "
        '
        'ImageModeComboBox
        '
        Me.ImageModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ImageModeComboBox.FormattingEnabled = True
        Me.ImageModeComboBox.Items.AddRange(New Object() {"리사이즈 없음", "리사이즈"})
        Me.ImageModeComboBox.Location = New System.Drawing.Point(349, 9)
        Me.ImageModeComboBox.Name = "ImageModeComboBox"
        Me.ImageModeComboBox.Size = New System.Drawing.Size(121, 23)
        Me.ImageModeComboBox.TabIndex = 8
        '
        'SkinDownloadForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 722)
        Me.Controls.Add(Me.ImageModeComboBox)
        Me.Controls.Add(Me.ImageLabel)
        Me.Controls.Add(Me.FormCloseButton)
        Me.Controls.Add(Me.SkinApplyButton)
        Me.Controls.Add(Me.InstalledSkinCheckButton)
        Me.Controls.Add(Me.ShowLargeImageButton)
        Me.Controls.Add(Me.SkinPanel)
        Me.Controls.Add(Me.SkinListBox)
        Me.Font = New System.Drawing.Font("나눔바른고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SkinDownloadForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "배경화면 다운로드"
        CType(Me.SkinPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SkinPanel.ResumeLayout(False)
        Me.SkinPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SkinListBox As System.Windows.Forms.ListBox
    Friend WithEvents SkinPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents SkinPanel As System.Windows.Forms.Panel
    Friend WithEvents ShowLargeImageButton As System.Windows.Forms.Button
    Friend WithEvents InstalledSkinCheckButton As System.Windows.Forms.Button
    Friend WithEvents SkinApplyButton As System.Windows.Forms.Button
    Friend WithEvents FormCloseButton As System.Windows.Forms.Button
    Friend WithEvents ImageLabel As System.Windows.Forms.Label
    Friend WithEvents ImageModeComboBox As System.Windows.Forms.ComboBox
End Class
