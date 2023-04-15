<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class normal_replacement
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(normal_replacement))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Op3 = New System.Windows.Forms.RadioButton()
        Me.Op2 = New System.Windows.Forms.RadioButton()
        Me.Op1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Op6 = New System.Windows.Forms.RadioButton()
        Me.Op5 = New System.Windows.Forms.RadioButton()
        Me.Op4 = New System.Windows.Forms.RadioButton()
        Me.Chk1 = New System.Windows.Forms.CheckBox()
        Me.Chk2 = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Op3)
        Me.GroupBox1.Controls.Add(Me.Op2)
        Me.GroupBox1.Controls.Add(Me.Op1)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(292, 113)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "*与×转换"
        '
        'Op3
        '
        Me.Op3.AutoSize = True
        Me.Op3.Checked = True
        Me.Op3.Location = New System.Drawing.Point(19, 75)
        Me.Op3.Name = "Op3"
        Me.Op3.Size = New System.Drawing.Size(73, 19)
        Me.Op3.TabIndex = 2
        Me.Op3.TabStop = True
        Me.Op3.Text = "不处理"
        Me.Op3.UseVisualStyleBackColor = True
        '
        'Op2
        '
        Me.Op2.AutoSize = True
        Me.Op2.Location = New System.Drawing.Point(19, 50)
        Me.Op2.Name = "Op2"
        Me.Op2.Size = New System.Drawing.Size(141, 19)
        Me.Op2.TabIndex = 1
        Me.Op2.Text = "选区内×替换为*"
        Me.Op2.UseVisualStyleBackColor = True
        '
        'Op1
        '
        Me.Op1.AutoSize = True
        Me.Op1.Location = New System.Drawing.Point(19, 24)
        Me.Op1.Name = "Op1"
        Me.Op1.Size = New System.Drawing.Size(141, 19)
        Me.Op1.TabIndex = 0
        Me.Op1.Text = "选区内*替换为×"
        Me.Op1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Op6)
        Me.GroupBox2.Controls.Add(Me.Op5)
        Me.GroupBox2.Controls.Add(Me.Op4)
        Me.GroupBox2.Location = New System.Drawing.Point(25, 158)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(292, 113)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "手动换行符↓处理"
        '
        'Op6
        '
        Me.Op6.AutoSize = True
        Me.Op6.Checked = True
        Me.Op6.Location = New System.Drawing.Point(19, 75)
        Me.Op6.Name = "Op6"
        Me.Op6.Size = New System.Drawing.Size(73, 19)
        Me.Op6.TabIndex = 2
        Me.Op6.TabStop = True
        Me.Op6.Text = "不处理"
        Me.Op6.UseVisualStyleBackColor = True
        '
        'Op5
        '
        Me.Op5.AutoSize = True
        Me.Op5.Location = New System.Drawing.Point(19, 50)
        Me.Op5.Name = "Op5"
        Me.Op5.Size = New System.Drawing.Size(103, 19)
        Me.Op5.TabIndex = 1
        Me.Op5.TabStop = True
        Me.Op5.Text = "选区内去↓"
        Me.Op5.UseVisualStyleBackColor = True
        '
        'Op4
        '
        Me.Op4.AutoSize = True
        Me.Op4.Location = New System.Drawing.Point(19, 24)
        Me.Op4.Name = "Op4"
        Me.Op4.Size = New System.Drawing.Size(156, 19)
        Me.Op4.TabIndex = 0
        Me.Op4.TabStop = True
        Me.Op4.Text = "选区内↓替换为<┘"
        Me.Op4.UseVisualStyleBackColor = True
        '
        'Chk1
        '
        Me.Chk1.AutoSize = True
        Me.Chk1.Location = New System.Drawing.Point(25, 277)
        Me.Chk1.Name = "Chk1"
        Me.Chk1.Size = New System.Drawing.Size(119, 19)
        Me.Chk1.TabIndex = 4
        Me.Chk1.Text = "选区内去空格"
        Me.Chk1.UseVisualStyleBackColor = True
        '
        'Chk2
        '
        Me.Chk2.AutoSize = True
        Me.Chk2.Location = New System.Drawing.Point(168, 277)
        Me.Chk2.Name = "Chk2"
        Me.Chk2.Size = New System.Drawing.Size(149, 19)
        Me.Chk2.TabIndex = 5
        Me.Chk2.Text = "选区内去空白段落"
        Me.Chk2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(78, 311)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 30)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "确定"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Location = New System.Drawing.Point(190, 311)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 30)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "取消"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'normal_replacement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Button2
        Me.ClientSize = New System.Drawing.Size(342, 360)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Chk2)
        Me.Controls.Add(Me.Chk1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "normal_replacement"
        Me.Text = "常用替换"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents Op3 As Windows.Forms.RadioButton
    Friend WithEvents Op2 As Windows.Forms.RadioButton
    Friend WithEvents Op1 As Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
    Friend WithEvents Op6 As Windows.Forms.RadioButton
    Friend WithEvents Op5 As Windows.Forms.RadioButton
    Friend WithEvents Op4 As Windows.Forms.RadioButton
    Friend WithEvents Chk1 As Windows.Forms.CheckBox
    Friend WithEvents Chk2 As Windows.Forms.CheckBox
    Friend WithEvents Button1 As Windows.Forms.Button
    Friend WithEvents Button2 As Windows.Forms.Button
End Class
