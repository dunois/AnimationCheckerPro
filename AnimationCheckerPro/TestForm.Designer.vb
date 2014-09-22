<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestForm
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.AnissiaAniListBox = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AnissiaAPIWeekComboBox = New System.Windows.Forms.ComboBox()
        Me.WebRQTLabel = New System.Windows.Forms.Label()
        Me.AnissiaSubListBox = New System.Windows.Forms.ListBox()
        Me.AnissiaTitleLabel = New System.Windows.Forms.Label()
        Me.AnissiaStatusLabel = New System.Windows.Forms.Label()
        Me.AnissiaTitleStatusLabel = New System.Windows.Forms.Label()
        Me.AnissiaSTDateLabel = New System.Windows.Forms.Label()
        Me.AnissiaEndDateLabel = New System.Windows.Forms.Label()
        Me.AnissiaGLabel = New System.Windows.Forms.Label()
        Me.AnissiaTimeLabel = New System.Windows.Forms.Label()
        Me.AnissiaSiteLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(111, 3)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 27)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Test start"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'AnissiaAniListBox
        '
        Me.AnissiaAniListBox.FormattingEnabled = True
        Me.AnissiaAniListBox.ItemHeight = 14
        Me.AnissiaAniListBox.Location = New System.Drawing.Point(23, 73)
        Me.AnissiaAniListBox.Name = "AnissiaAniListBox"
        Me.AnissiaAniListBox.Size = New System.Drawing.Size(260, 396)
        Me.AnissiaAniListBox.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.AnissiaSiteLabel)
        Me.GroupBox1.Controls.Add(Me.AnissiaTimeLabel)
        Me.GroupBox1.Controls.Add(Me.AnissiaGLabel)
        Me.GroupBox1.Controls.Add(Me.AnissiaEndDateLabel)
        Me.GroupBox1.Controls.Add(Me.AnissiaSTDateLabel)
        Me.GroupBox1.Controls.Add(Me.AnissiaTitleStatusLabel)
        Me.GroupBox1.Controls.Add(Me.AnissiaStatusLabel)
        Me.GroupBox1.Controls.Add(Me.AnissiaTitleLabel)
        Me.GroupBox1.Controls.Add(Me.AnissiaSubListBox)
        Me.GroupBox1.Controls.Add(Me.AnissiaAPIWeekComboBox)
        Me.GroupBox1.Controls.Add(Me.AnissiaAniListBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(742, 486)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Anissia API"
        '
        'AnissiaAPIWeekComboBox
        '
        Me.AnissiaAPIWeekComboBox.FormattingEnabled = True
        Me.AnissiaAPIWeekComboBox.Items.AddRange(New Object() {"Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"})
        Me.AnissiaAPIWeekComboBox.Location = New System.Drawing.Point(23, 34)
        Me.AnissiaAPIWeekComboBox.Name = "AnissiaAPIWeekComboBox"
        Me.AnissiaAPIWeekComboBox.Size = New System.Drawing.Size(260, 22)
        Me.AnissiaAPIWeekComboBox.TabIndex = 2
        '
        'WebRQTLabel
        '
        Me.WebRQTLabel.AutoSize = True
        Me.WebRQTLabel.Location = New System.Drawing.Point(12, 9)
        Me.WebRQTLabel.Name = "WebRQTLabel"
        Me.WebRQTLabel.Size = New System.Drawing.Size(93, 14)
        Me.WebRQTLabel.TabIndex = 3
        Me.WebRQTLabel.Text = "Web Req Test : "
        '
        'AnissiaSubListBox
        '
        Me.AnissiaSubListBox.FormattingEnabled = True
        Me.AnissiaSubListBox.ItemHeight = 14
        Me.AnissiaSubListBox.Location = New System.Drawing.Point(307, 241)
        Me.AnissiaSubListBox.Name = "AnissiaSubListBox"
        Me.AnissiaSubListBox.Size = New System.Drawing.Size(260, 228)
        Me.AnissiaSubListBox.TabIndex = 3
        '
        'AnissiaTitleLabel
        '
        Me.AnissiaTitleLabel.AutoSize = True
        Me.AnissiaTitleLabel.Location = New System.Drawing.Point(304, 73)
        Me.AnissiaTitleLabel.Name = "AnissiaTitleLabel"
        Me.AnissiaTitleLabel.Size = New System.Drawing.Size(50, 14)
        Me.AnissiaTitleLabel.TabIndex = 4
        Me.AnissiaTitleLabel.Text = "AniTitle"
        '
        'AnissiaStatusLabel
        '
        Me.AnissiaStatusLabel.AutoSize = True
        Me.AnissiaStatusLabel.Location = New System.Drawing.Point(304, 100)
        Me.AnissiaStatusLabel.Name = "AnissiaStatusLabel"
        Me.AnissiaStatusLabel.Size = New System.Drawing.Size(60, 14)
        Me.AnissiaStatusLabel.TabIndex = 5
        Me.AnissiaStatusLabel.Text = "AniStatus"
        '
        'AnissiaTitleStatusLabel
        '
        Me.AnissiaTitleStatusLabel.AutoSize = True
        Me.AnissiaTitleStatusLabel.Location = New System.Drawing.Point(510, 73)
        Me.AnissiaTitleStatusLabel.Name = "AnissiaTitleStatusLabel"
        Me.AnissiaTitleStatusLabel.Size = New System.Drawing.Size(110, 14)
        Me.AnissiaTitleStatusLabel.TabIndex = 6
        Me.AnissiaTitleStatusLabel.Text = "AniTitleWithStatus"
        '
        'AnissiaSTDateLabel
        '
        Me.AnissiaSTDateLabel.AutoSize = True
        Me.AnissiaSTDateLabel.Location = New System.Drawing.Point(304, 129)
        Me.AnissiaSTDateLabel.Name = "AnissiaSTDateLabel"
        Me.AnissiaSTDateLabel.Size = New System.Drawing.Size(96, 14)
        Me.AnissiaSTDateLabel.TabIndex = 7
        Me.AnissiaSTDateLabel.Text = "AniStartingDate"
        '
        'AnissiaEndDateLabel
        '
        Me.AnissiaEndDateLabel.AutoSize = True
        Me.AnissiaEndDateLabel.Location = New System.Drawing.Point(510, 129)
        Me.AnissiaEndDateLabel.Name = "AnissiaEndDateLabel"
        Me.AnissiaEndDateLabel.Size = New System.Drawing.Size(74, 14)
        Me.AnissiaEndDateLabel.TabIndex = 8
        Me.AnissiaEndDateLabel.Text = "AniEndDate"
        '
        'AnissiaGLabel
        '
        Me.AnissiaGLabel.AutoSize = True
        Me.AnissiaGLabel.Location = New System.Drawing.Point(304, 157)
        Me.AnissiaGLabel.Name = "AnissiaGLabel"
        Me.AnissiaGLabel.Size = New System.Drawing.Size(61, 14)
        Me.AnissiaGLabel.TabIndex = 9
        Me.AnissiaGLabel.Text = "AniGenre"
        '
        'AnissiaTimeLabel
        '
        Me.AnissiaTimeLabel.AutoSize = True
        Me.AnissiaTimeLabel.Location = New System.Drawing.Point(307, 187)
        Me.AnissiaTimeLabel.Name = "AnissiaTimeLabel"
        Me.AnissiaTimeLabel.Size = New System.Drawing.Size(54, 14)
        Me.AnissiaTimeLabel.TabIndex = 10
        Me.AnissiaTimeLabel.Text = "AniTime"
        '
        'AnissiaSiteLabel
        '
        Me.AnissiaSiteLabel.AutoSize = True
        Me.AnissiaSiteLabel.Location = New System.Drawing.Point(307, 215)
        Me.AnissiaSiteLabel.Name = "AnissiaSiteLabel"
        Me.AnissiaSiteLabel.Size = New System.Drawing.Size(47, 14)
        Me.AnissiaSiteLabel.TabIndex = 11
        Me.AnissiaSiteLabel.Text = "AniSite"
        '
        'TestForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 560)
        Me.Controls.Add(Me.WebRQTLabel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("나눔고딕", 9.0!)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "TestForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TestForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents AnissiaAniListBox As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents AnissiaSiteLabel As System.Windows.Forms.Label
    Friend WithEvents AnissiaTimeLabel As System.Windows.Forms.Label
    Friend WithEvents AnissiaGLabel As System.Windows.Forms.Label
    Friend WithEvents AnissiaEndDateLabel As System.Windows.Forms.Label
    Friend WithEvents AnissiaSTDateLabel As System.Windows.Forms.Label
    Friend WithEvents AnissiaTitleStatusLabel As System.Windows.Forms.Label
    Friend WithEvents AnissiaStatusLabel As System.Windows.Forms.Label
    Friend WithEvents AnissiaTitleLabel As System.Windows.Forms.Label
    Friend WithEvents AnissiaSubListBox As System.Windows.Forms.ListBox
    Friend WithEvents AnissiaAPIWeekComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents WebRQTLabel As System.Windows.Forms.Label
End Class
