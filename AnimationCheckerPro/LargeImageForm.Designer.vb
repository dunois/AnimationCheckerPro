<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LargeImageForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LargeImageForm))
        Me.LargePictureBox = New System.Windows.Forms.PictureBox()
        Me.FormTimer = New System.Windows.Forms.Timer(Me.components)
        Me.FormCloseButton = New System.Windows.Forms.Button()
        CType(Me.LargePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LargePictureBox
        '
        Me.LargePictureBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LargePictureBox.Location = New System.Drawing.Point(0, 0)
        Me.LargePictureBox.Name = "LargePictureBox"
        Me.LargePictureBox.Size = New System.Drawing.Size(653, 435)
        Me.LargePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.LargePictureBox.TabIndex = 0
        Me.LargePictureBox.TabStop = False
        Me.LargePictureBox.WaitOnLoad = True
        '
        'FormTimer
        '
        '
        'FormCloseButton
        '
        Me.FormCloseButton.Location = New System.Drawing.Point(253, 196)
        Me.FormCloseButton.Name = "FormCloseButton"
        Me.FormCloseButton.Size = New System.Drawing.Size(155, 31)
        Me.FormCloseButton.TabIndex = 1
        Me.FormCloseButton.Text = "CloseButtonUnVisible"
        Me.FormCloseButton.UseVisualStyleBackColor = True
        '
        'LargeImageForm
        '
        Me.AcceptButton = Me.FormCloseButton
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(653, 435)
        Me.Controls.Add(Me.LargePictureBox)
        Me.Controls.Add(Me.FormCloseButton)
        Me.Font = New System.Drawing.Font("나눔바른고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LargeImageForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "이미지 원본 보기"
        CType(Me.LargePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LargePictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents FormTimer As System.Windows.Forms.Timer
    Friend WithEvents FormCloseButton As System.Windows.Forms.Button
End Class
