<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnIncrement = New System.Windows.Forms.Button()
        Me.lblCounter = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnDecrease = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnIncrement
        '
        Me.btnIncrement.Location = New System.Drawing.Point(64, 174)
        Me.btnIncrement.Name = "btnIncrement"
        Me.btnIncrement.Size = New System.Drawing.Size(197, 69)
        Me.btnIncrement.TabIndex = 0
        Me.btnIncrement.Text = "カウントUP"
        Me.btnIncrement.UseVisualStyleBackColor = True
        '
        'lblCounter
        '
        Me.lblCounter.AutoSize = True
        Me.lblCounter.Location = New System.Drawing.Point(62, 119)
        Me.lblCounter.Name = "lblCounter"
        Me.lblCounter.Size = New System.Drawing.Size(57, 12)
        Me.lblCounter.TabIndex = 1
        Me.lblCounter.Text = "lblCounter"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(290, 174)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(171, 69)
        Me.btnReset.TabIndex = 2
        Me.btnReset.Text = "リセット"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnDecrease
        '
        Me.btnDecrease.Location = New System.Drawing.Point(64, 274)
        Me.btnDecrease.Name = "btnDecrease"
        Me.btnDecrease.Size = New System.Drawing.Size(197, 69)
        Me.btnDecrease.TabIndex = 3
        Me.btnDecrease.Text = "カウントDown"
        Me.btnDecrease.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 450)
        Me.Controls.Add(Me.btnDecrease)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.lblCounter)
        Me.Controls.Add(Me.btnIncrement)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnIncrement As Button
    Friend WithEvents lblCounter As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents btnDecrease As Button
End Class
