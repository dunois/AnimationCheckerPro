<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImportantNotice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImportantNotice))
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.NoticeLabel = New System.Windows.Forms.Label()
        Me.FExitButton = New System.Windows.Forms.Button()
        Me.CloseButtonTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("나눔고딕", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(12, 9)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(90, 24)
        Me.TitleLabel.TabIndex = 0
        Me.TitleLabel.Text = "공지사항"
        '
        'NoticeLabel
        '
        Me.NoticeLabel.Location = New System.Drawing.Point(35, 50)
        Me.NoticeLabel.Name = "NoticeLabel"
        Me.NoticeLabel.Size = New System.Drawing.Size(406, 249)
        Me.NoticeLabel.TabIndex = 1
        Me.NoticeLabel.Text = "Loading"
        '
        'FExitButton
        '
        Me.FExitButton.Location = New System.Drawing.Point(390, 314)
        Me.FExitButton.Name = "FExitButton"
        Me.FExitButton.Size = New System.Drawing.Size(75, 23)
        Me.FExitButton.TabIndex = 2
        Me.FExitButton.Text = "닫기"
        Me.FExitButton.UseVisualStyleBackColor = True
        Me.FExitButton.Visible = False
        '
        'CloseButtonTimer
        '
        '
        'ImportantNotice
        '
        Me.AcceptButton = Me.FExitButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 349)
        Me.ControlBox = False
        Me.Controls.Add(Me.FExitButton)
        Me.Controls.Add(Me.NoticeLabel)
        Me.Controls.Add(Me.TitleLabel)
        Me.Font = New System.Drawing.Font("나눔바른고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ImportantNotice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "중요 공지사항"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TitleLabel As System.Windows.Forms.Label
    Friend WithEvents NoticeLabel As System.Windows.Forms.Label
    Friend WithEvents FExitButton As System.Windows.Forms.Button
    Friend WithEvents CloseButtonTimer As System.Windows.Forms.Timer
End Class
