<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SkinSettingForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SkinSettingForm))
        Me.SkinFileOpenButton = New System.Windows.Forms.Button()
        Me.SkinApplyButton = New System.Windows.Forms.Button()
        Me.DeleteSkinButton = New System.Windows.Forms.Button()
        Me.SkinFileLocationTextBox = New System.Windows.Forms.TextBox()
        Me.ShowLargeImageButton = New System.Windows.Forms.Button()
        Me.SkinPanel = New System.Windows.Forms.Panel()
        Me.SkinPictureBox = New System.Windows.Forms.PictureBox()
        Me.TipLabel = New System.Windows.Forms.Label()
        Me.ImageModeComboBox = New System.Windows.Forms.ComboBox()
        Me.ImageModeLabel = New System.Windows.Forms.Label()
        Me.SkinPanel.SuspendLayout()
        CType(Me.SkinPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SkinFileOpenButton
        '
        Me.SkinFileOpenButton.Location = New System.Drawing.Point(763, 50)
        Me.SkinFileOpenButton.Margin = New System.Windows.Forms.Padding(0)
        Me.SkinFileOpenButton.Name = "SkinFileOpenButton"
        Me.SkinFileOpenButton.Size = New System.Drawing.Size(86, 29)
        Me.SkinFileOpenButton.TabIndex = 0
        Me.SkinFileOpenButton.Text = "파일열기"
        Me.SkinFileOpenButton.UseVisualStyleBackColor = True
        '
        'SkinApplyButton
        '
        Me.SkinApplyButton.Enabled = False
        Me.SkinApplyButton.Location = New System.Drawing.Point(9, 9)
        Me.SkinApplyButton.Margin = New System.Windows.Forms.Padding(0)
        Me.SkinApplyButton.Name = "SkinApplyButton"
        Me.SkinApplyButton.Size = New System.Drawing.Size(101, 29)
        Me.SkinApplyButton.TabIndex = 1
        Me.SkinApplyButton.Text = " 배경화면 적용"
        Me.SkinApplyButton.UseVisualStyleBackColor = True
        '
        'DeleteSkinButton
        '
        Me.DeleteSkinButton.Enabled = False
        Me.DeleteSkinButton.Location = New System.Drawing.Point(110, 9)
        Me.DeleteSkinButton.Margin = New System.Windows.Forms.Padding(0)
        Me.DeleteSkinButton.Name = "DeleteSkinButton"
        Me.DeleteSkinButton.Size = New System.Drawing.Size(108, 29)
        Me.DeleteSkinButton.TabIndex = 2
        Me.DeleteSkinButton.Text = "배경화면 지우기"
        Me.DeleteSkinButton.UseVisualStyleBackColor = True
        '
        'SkinFileLocationTextBox
        '
        Me.SkinFileLocationTextBox.Location = New System.Drawing.Point(32, 54)
        Me.SkinFileLocationTextBox.Name = "SkinFileLocationTextBox"
        Me.SkinFileLocationTextBox.ReadOnly = True
        Me.SkinFileLocationTextBox.Size = New System.Drawing.Size(704, 22)
        Me.SkinFileLocationTextBox.TabIndex = 3
        '
        'ShowLargeImageButton
        '
        Me.ShowLargeImageButton.Enabled = False
        Me.ShowLargeImageButton.Location = New System.Drawing.Point(852, 50)
        Me.ShowLargeImageButton.Name = "ShowLargeImageButton"
        Me.ShowLargeImageButton.Size = New System.Drawing.Size(86, 29)
        Me.ShowLargeImageButton.TabIndex = 4
        Me.ShowLargeImageButton.Text = "이미지 보기"
        Me.ShowLargeImageButton.UseVisualStyleBackColor = True
        '
        'SkinPanel
        '
        Me.SkinPanel.AutoScroll = True
        Me.SkinPanel.Controls.Add(Me.SkinPictureBox)
        Me.SkinPanel.Location = New System.Drawing.Point(9, 93)
        Me.SkinPanel.Name = "SkinPanel"
        Me.SkinPanel.Size = New System.Drawing.Size(929, 602)
        Me.SkinPanel.TabIndex = 5
        '
        'SkinPictureBox
        '
        Me.SkinPictureBox.Location = New System.Drawing.Point(13, 13)
        Me.SkinPictureBox.Name = "SkinPictureBox"
        Me.SkinPictureBox.Size = New System.Drawing.Size(858, 539)
        Me.SkinPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.SkinPictureBox.TabIndex = 0
        Me.SkinPictureBox.TabStop = False
        '
        'TipLabel
        '
        Me.TipLabel.AutoSize = True
        Me.TipLabel.Location = New System.Drawing.Point(658, 9)
        Me.TipLabel.Name = "TipLabel"
        Me.TipLabel.Size = New System.Drawing.Size(287, 15)
        Me.TipLabel.TabIndex = 6
        Me.TipLabel.Text = "파일을 끌어오면 쉽게 배경화면을 설정할수있습니다."
        '
        'ImageModeComboBox
        '
        Me.ImageModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ImageModeComboBox.FormattingEnabled = True
        Me.ImageModeComboBox.Items.AddRange(New Object() {"리사이즈 없음", "리사이즈"})
        Me.ImageModeComboBox.Location = New System.Drawing.Point(292, 12)
        Me.ImageModeComboBox.Name = "ImageModeComboBox"
        Me.ImageModeComboBox.Size = New System.Drawing.Size(121, 23)
        Me.ImageModeComboBox.TabIndex = 7
        '
        'ImageModeLabel
        '
        Me.ImageModeLabel.AutoSize = True
        Me.ImageModeLabel.Location = New System.Drawing.Point(221, 16)
        Me.ImageModeLabel.Name = "ImageModeLabel"
        Me.ImageModeLabel.Size = New System.Drawing.Size(68, 15)
        Me.ImageModeLabel.TabIndex = 8
        Me.ImageModeLabel.Text = "보기 모드 : "
        '
        'SkinSettingForm
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 707)
        Me.Controls.Add(Me.ImageModeLabel)
        Me.Controls.Add(Me.ImageModeComboBox)
        Me.Controls.Add(Me.TipLabel)
        Me.Controls.Add(Me.SkinPanel)
        Me.Controls.Add(Me.ShowLargeImageButton)
        Me.Controls.Add(Me.SkinFileLocationTextBox)
        Me.Controls.Add(Me.DeleteSkinButton)
        Me.Controls.Add(Me.SkinApplyButton)
        Me.Controls.Add(Me.SkinFileOpenButton)
        Me.Font = New System.Drawing.Font("나눔바른고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SkinSettingForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "배경화면 설정"
        Me.SkinPanel.ResumeLayout(False)
        Me.SkinPanel.PerformLayout()
        CType(Me.SkinPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SkinFileOpenButton As System.Windows.Forms.Button
    Friend WithEvents SkinApplyButton As System.Windows.Forms.Button
    Friend WithEvents DeleteSkinButton As System.Windows.Forms.Button
    Friend WithEvents SkinFileLocationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ShowLargeImageButton As System.Windows.Forms.Button
    Friend WithEvents SkinPanel As System.Windows.Forms.Panel
    Friend WithEvents SkinPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents TipLabel As System.Windows.Forms.Label
    Friend WithEvents ImageModeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ImageModeLabel As System.Windows.Forms.Label
End Class
