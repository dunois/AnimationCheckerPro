<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateCompleteForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateCompleteForm))
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.ChangeLog = New System.Windows.Forms.RichTextBox()
        Me.FormCloseButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("나눔고딕", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(12, 23)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(157, 28)
        Me.TitleLabel.TabIndex = 0
        Me.TitleLabel.Text = "업데이트 완료"
        '
        'ChangeLog
        '
        Me.ChangeLog.BackColor = System.Drawing.SystemColors.Control
        Me.ChangeLog.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ChangeLog.Location = New System.Drawing.Point(34, 83)
        Me.ChangeLog.Name = "ChangeLog"
        Me.ChangeLog.ReadOnly = True
        Me.ChangeLog.Size = New System.Drawing.Size(399, 198)
        Me.ChangeLog.TabIndex = 2
        Me.ChangeLog.Text = "Loading"
        '
        'FormCloseButton
        '
        Me.FormCloseButton.Location = New System.Drawing.Point(344, 54)
        Me.FormCloseButton.Name = "FormCloseButton"
        Me.FormCloseButton.Size = New System.Drawing.Size(75, 23)
        Me.FormCloseButton.TabIndex = 3
        Me.FormCloseButton.Text = "닫기"
        Me.FormCloseButton.UseVisualStyleBackColor = True
        '
        'UpdateCompleteForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 304)
        Me.Controls.Add(Me.FormCloseButton)
        Me.Controls.Add(Me.ChangeLog)
        Me.Controls.Add(Me.TitleLabel)
        Me.Font = New System.Drawing.Font("나눔바른고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UpdateCompleteForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "업데이트 완료"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TitleLabel As System.Windows.Forms.Label
    Friend WithEvents ChangeLog As System.Windows.Forms.RichTextBox
    Friend WithEvents FormCloseButton As System.Windows.Forms.Button
End Class
