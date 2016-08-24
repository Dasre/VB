<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class game2
    Inherits System.Windows.Forms.Form


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


    Private components As System.ComponentModel.IContainer


    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.appear = New System.Windows.Forms.Timer(Me.components)
        Me.alive = New System.Windows.Forms.Timer(Me.components)
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 467)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 31)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "擊殺數量"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(166, 467)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 26)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "倒數時間"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(316, 458)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 52)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "遊戲開始"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'appear
        '
        Me.appear.Interval = 350
        '
        'alive
        '
        Me.alive.Interval = 2000
        '
        'Button13
        '
        Me.Button13.Image = Global._1230.My.Resources.Resources._436fc7dd27724456ed6ab445426af7f91
        Me.Button13.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button13.Location = New System.Drawing.Point(523, 171)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(96, 120)
        Me.Button13.TabIndex = 17
        Me.Button13.UseVisualStyleBackColor = True
        Me.Button13.Visible = False
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.Transparent
        Me.Button12.Image = Global._1230.My.Resources.Resources._436fc7dd27724456ed6ab445426af7f91
        Me.Button12.Location = New System.Drawing.Point(34, 12)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(96, 120)
        Me.Button12.TabIndex = 16
        Me.Button12.UseVisualStyleBackColor = False
        Me.Button12.Visible = False
        '
        'Button11
        '
        Me.Button11.Image = Global._1230.My.Resources.Resources._436fc7dd27724456ed6ab445426af7f91
        Me.Button11.Location = New System.Drawing.Point(450, 320)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(96, 120)
        Me.Button11.TabIndex = 15
        Me.Button11.UseVisualStyleBackColor = True
        Me.Button11.Visible = False
        '
        'Button10
        '
        Me.Button10.Image = Global._1230.My.Resources.Resources._436fc7dd27724456ed6ab445426af7f91
        Me.Button10.Location = New System.Drawing.Point(316, 320)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(96, 120)
        Me.Button10.TabIndex = 14
        Me.Button10.UseVisualStyleBackColor = True
        Me.Button10.Visible = False
        '
        'Button9
        '
        Me.Button9.Image = Global._1230.My.Resources.Resources._436fc7dd27724456ed6ab445426af7f91
        Me.Button9.Location = New System.Drawing.Point(45, 320)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(96, 120)
        Me.Button9.TabIndex = 13
        Me.Button9.UseVisualStyleBackColor = True
        Me.Button9.Visible = False
        '
        'Button8
        '
        Me.Button8.Image = Global._1230.My.Resources.Resources._436fc7dd27724456ed6ab445426af7f91
        Me.Button8.Location = New System.Drawing.Point(191, 320)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(96, 120)
        Me.Button8.TabIndex = 12
        Me.Button8.UseVisualStyleBackColor = True
        Me.Button8.Visible = False
        '
        'Button7
        '
        Me.Button7.Image = Global._1230.My.Resources.Resources._436fc7dd27724456ed6ab445426af7f91
        Me.Button7.Location = New System.Drawing.Point(388, 171)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(96, 120)
        Me.Button7.TabIndex = 11
        Me.Button7.UseVisualStyleBackColor = True
        Me.Button7.Visible = False
        '
        'Button6
        '
        Me.Button6.Image = Global._1230.My.Resources.Resources._436fc7dd27724456ed6ab445426af7f91
        Me.Button6.Location = New System.Drawing.Point(245, 171)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(96, 120)
        Me.Button6.TabIndex = 10
        Me.Button6.UseVisualStyleBackColor = True
        Me.Button6.Visible = False
        '
        'Button5
        '
        Me.Button5.Image = Global._1230.My.Resources.Resources._436fc7dd27724456ed6ab445426af7f91
        Me.Button5.Location = New System.Drawing.Point(91, 171)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(96, 120)
        Me.Button5.TabIndex = 9
        Me.Button5.UseVisualStyleBackColor = True
        Me.Button5.Visible = False
        '
        'Button4
        '
        Me.Button4.Image = Global._1230.My.Resources.Resources._436fc7dd27724456ed6ab445426af7f91
        Me.Button4.Location = New System.Drawing.Point(450, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(96, 120)
        Me.Button4.TabIndex = 8
        Me.Button4.UseVisualStyleBackColor = True
        Me.Button4.Visible = False
        '
        'Button2
        '
        Me.Button2.Image = Global._1230.My.Resources.Resources._436fc7dd27724456ed6ab445426af7f91
        Me.Button2.Location = New System.Drawing.Point(316, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 120)
        Me.Button2.TabIndex = 6
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Button3
        '
        Me.Button3.Image = Global._1230.My.Resources.Resources._436fc7dd27724456ed6ab445426af7f91
        Me.Button3.Location = New System.Drawing.Point(180, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(96, 120)
        Me.Button3.TabIndex = 7
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'Button14
        '
        Me.Button14.Location = New System.Drawing.Point(450, 470)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(75, 23)
        Me.Button14.TabIndex = 18
        Me.Button14.Text = "捷徑"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'game2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._1230.My.Resources.Resources._1H0191937_3
        Me.ClientSize = New System.Drawing.Size(631, 543)
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "game2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "game2"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents appear As Timer
    Friend WithEvents alive As Timer
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
