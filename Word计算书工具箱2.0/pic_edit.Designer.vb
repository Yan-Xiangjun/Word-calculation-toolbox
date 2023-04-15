<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pic_edit
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pic_edit))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Op0_2 = New System.Windows.Forms.RadioButton()
        Me.Op0_1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Op4 = New System.Windows.Forms.RadioButton()
        Me.Op3 = New System.Windows.Forms.RadioButton()
        Me.Op2 = New System.Windows.Forms.RadioButton()
        Me.Op1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Chk1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Num2 = New System.Windows.Forms.NumericUpDown()
        Me.Chk4 = New System.Windows.Forms.CheckBox()
        Me.Num1 = New System.Windows.Forms.NumericUpDown()
        Me.Chk3 = New System.Windows.Forms.CheckBox()
        Me.Chk2 = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Chk5 = New System.Windows.Forms.CheckBox()
        Me.Chk6 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.Num2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Num1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Op0_2)
        Me.GroupBox1.Controls.Add(Me.Op0_1)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(328, 83)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "选区内第一张图片是"
        '
        'Op0_2
        '
        Me.Op0_2.AutoSize = True
        Me.Op0_2.Location = New System.Drawing.Point(172, 40)
        Me.Op0_2.Name = "Op0_2"
        Me.Op0_2.Size = New System.Drawing.Size(88, 19)
        Me.Op0_2.TabIndex = 1
        Me.Op0_2.Text = "非嵌入型"
        Me.Op0_2.UseVisualStyleBackColor = True
        '
        'Op0_1
        '
        Me.Op0_1.AutoSize = True
        Me.Op0_1.Checked = True
        Me.Op0_1.Location = New System.Drawing.Point(18, 40)
        Me.Op0_1.Name = "Op0_1"
        Me.Op0_1.Size = New System.Drawing.Size(73, 19)
        Me.Op0_1.TabIndex = 0
        Me.Op0_1.TabStop = True
        Me.Op0_1.Text = "嵌入型"
        Me.Op0_1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Op4)
        Me.GroupBox2.Controls.Add(Me.Op3)
        Me.GroupBox2.Controls.Add(Me.Op2)
        Me.GroupBox2.Controls.Add(Me.Op1)
        Me.GroupBox2.Location = New System.Drawing.Point(27, 119)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(328, 138)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "大小"
        '
        'Op4
        '
        Me.Op4.AutoSize = True
        Me.Op4.Checked = True
        Me.Op4.Location = New System.Drawing.Point(18, 107)
        Me.Op4.Name = "Op4"
        Me.Op4.Size = New System.Drawing.Size(73, 19)
        Me.Op4.TabIndex = 3
        Me.Op4.TabStop = True
        Me.Op4.Text = "不处理"
        Me.Op4.UseVisualStyleBackColor = True
        '
        'Op3
        '
        Me.Op3.AutoSize = True
        Me.Op3.Location = New System.Drawing.Point(18, 82)
        Me.Op3.Name = "Op3"
        Me.Op3.Size = New System.Drawing.Size(313, 19)
        Me.Op3.TabIndex = 2
        Me.Op3.Text = "同时统一宽度和高度（会取消锁定纵横比）"
        Me.Op3.UseVisualStyleBackColor = True
        '
        'Op2
        '
        Me.Op2.AutoSize = True
        Me.Op2.Location = New System.Drawing.Point(18, 57)
        Me.Op2.Name = "Op2"
        Me.Op2.Size = New System.Drawing.Size(208, 19)
        Me.Op2.TabIndex = 1
        Me.Op2.Text = "高度设为与第一张图片相同"
        Me.Op2.UseVisualStyleBackColor = True
        '
        'Op1
        '
        Me.Op1.AutoSize = True
        Me.Op1.Location = New System.Drawing.Point(18, 32)
        Me.Op1.Name = "Op1"
        Me.Op1.Size = New System.Drawing.Size(208, 19)
        Me.Op1.TabIndex = 0
        Me.Op1.Text = "宽度设为与第一张图片相同"
        Me.Op1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Chk1)
        Me.GroupBox3.Location = New System.Drawing.Point(27, 270)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(328, 77)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "位置"
        '
        'Chk1
        '
        Me.Chk1.AutoSize = True
        Me.Chk1.Location = New System.Drawing.Point(18, 34)
        Me.Chk1.Name = "Chk1"
        Me.Chk1.Size = New System.Drawing.Size(89, 19)
        Me.Chk1.TabIndex = 0
        Me.Chk1.Text = "水平居中"
        Me.Chk1.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Num2)
        Me.GroupBox4.Controls.Add(Me.Chk4)
        Me.GroupBox4.Controls.Add(Me.Num1)
        Me.GroupBox4.Controls.Add(Me.Chk3)
        Me.GroupBox4.Controls.Add(Me.Chk2)
        Me.GroupBox4.Location = New System.Drawing.Point(27, 360)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(328, 165)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "颜色"
        '
        'Num2
        '
        Me.Num2.Location = New System.Drawing.Point(230, 121)
        Me.Num2.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.Num2.Minimum = New Decimal(New Integer() {99, 0, 0, -2147483648})
        Me.Num2.Name = "Num2"
        Me.Num2.Size = New System.Drawing.Size(79, 25)
        Me.Num2.TabIndex = 5
        '
        'Chk4
        '
        Me.Chk4.AutoSize = True
        Me.Chk4.Location = New System.Drawing.Point(18, 122)
        Me.Chk4.Name = "Chk4"
        Me.Chk4.Size = New System.Drawing.Size(159, 19)
        Me.Chk4.TabIndex = 4
        Me.Chk4.Text = "亮度（-99至99）："
        Me.Chk4.UseVisualStyleBackColor = True
        '
        'Num1
        '
        Me.Num1.Location = New System.Drawing.Point(230, 77)
        Me.Num1.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.Num1.Minimum = New Decimal(New Integer() {99, 0, 0, -2147483648})
        Me.Num1.Name = "Num1"
        Me.Num1.Size = New System.Drawing.Size(79, 25)
        Me.Num1.TabIndex = 3
        '
        'Chk3
        '
        Me.Chk3.AutoSize = True
        Me.Chk3.Location = New System.Drawing.Point(18, 78)
        Me.Chk3.Name = "Chk3"
        Me.Chk3.Size = New System.Drawing.Size(174, 19)
        Me.Chk3.TabIndex = 2
        Me.Chk3.Text = "对比度（-99至99）："
        Me.Chk3.UseVisualStyleBackColor = True
        '
        'Chk2
        '
        Me.Chk2.AutoSize = True
        Me.Chk2.Location = New System.Drawing.Point(18, 34)
        Me.Chk2.Name = "Chk2"
        Me.Chk2.Size = New System.Drawing.Size(59, 19)
        Me.Chk2.TabIndex = 0
        Me.Chk2.Text = "灰度"
        Me.Chk2.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Location = New System.Drawing.Point(207, 570)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 30)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "取消"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(107, 570)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 30)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "确定"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Chk5
        '
        Me.Chk5.AutoSize = True
        Me.Chk5.Checked = True
        Me.Chk5.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chk5.Location = New System.Drawing.Point(27, 532)
        Me.Chk5.Name = "Chk5"
        Me.Chk5.Size = New System.Drawing.Size(134, 19)
        Me.Chk5.TabIndex = 8
        Me.Chk5.Text = "操作嵌入型图片"
        Me.Chk5.UseVisualStyleBackColor = True
        '
        'Chk6
        '
        Me.Chk6.AutoSize = True
        Me.Chk6.Checked = True
        Me.Chk6.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chk6.Location = New System.Drawing.Point(206, 531)
        Me.Chk6.Name = "Chk6"
        Me.Chk6.Size = New System.Drawing.Size(149, 19)
        Me.Chk6.TabIndex = 9
        Me.Chk6.Text = "操作非嵌入型图片"
        Me.Chk6.UseVisualStyleBackColor = True
        '
        'pic_edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Button2
        Me.ClientSize = New System.Drawing.Size(389, 616)
        Me.Controls.Add(Me.Chk6)
        Me.Controls.Add(Me.Chk5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "pic_edit"
        Me.Text = "图片编辑"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.Num2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Num1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents Op0_2 As Windows.Forms.RadioButton
    Friend WithEvents Op0_1 As Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
    Friend WithEvents Op4 As Windows.Forms.RadioButton
    Friend WithEvents Op3 As Windows.Forms.RadioButton
    Friend WithEvents Op2 As Windows.Forms.RadioButton
    Friend WithEvents Op1 As Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As Windows.Forms.GroupBox
    Friend WithEvents Chk1 As Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As Windows.Forms.GroupBox
    Friend WithEvents Chk2 As Windows.Forms.CheckBox
    Friend WithEvents Num2 As Windows.Forms.NumericUpDown
    Friend WithEvents Chk4 As Windows.Forms.CheckBox
    Friend WithEvents Num1 As Windows.Forms.NumericUpDown
    Friend WithEvents Chk3 As Windows.Forms.CheckBox
    Friend WithEvents Button2 As Windows.Forms.Button
    Friend WithEvents Button1 As Windows.Forms.Button
    Friend WithEvents Chk5 As Windows.Forms.CheckBox
    Friend WithEvents Chk6 As Windows.Forms.CheckBox
End Class
