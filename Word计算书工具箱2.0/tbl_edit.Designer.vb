<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tbl_edit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tbl_edit))
        Me.Chk1 = New System.Windows.Forms.CheckBox()
        Me.Chk2 = New System.Windows.Forms.CheckBox()
        Me.Chk3 = New System.Windows.Forms.CheckBox()
        Me.Chk4 = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Chk1
        '
        Me.Chk1.AutoSize = True
        Me.Chk1.Checked = True
        Me.Chk1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chk1.Location = New System.Drawing.Point(52, 28)
        Me.Chk1.Name = "Chk1"
        Me.Chk1.Size = New System.Drawing.Size(119, 19)
        Me.Chk1.TabIndex = 0
        Me.Chk1.Text = "表格水平居中"
        Me.Chk1.UseVisualStyleBackColor = True
        '
        'Chk2
        '
        Me.Chk2.AutoSize = True
        Me.Chk2.Checked = True
        Me.Chk2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chk2.Location = New System.Drawing.Point(52, 66)
        Me.Chk2.Name = "Chk2"
        Me.Chk2.Size = New System.Drawing.Size(149, 19)
        Me.Chk2.TabIndex = 1
        Me.Chk2.Text = "表内文字水平居中"
        Me.Chk2.UseVisualStyleBackColor = True
        '
        'Chk3
        '
        Me.Chk3.AutoSize = True
        Me.Chk3.Checked = True
        Me.Chk3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chk3.Location = New System.Drawing.Point(52, 104)
        Me.Chk3.Name = "Chk3"
        Me.Chk3.Size = New System.Drawing.Size(149, 19)
        Me.Chk3.TabIndex = 2
        Me.Chk3.Text = "表内文字垂直居中"
        Me.Chk3.UseVisualStyleBackColor = True
        '
        'Chk4
        '
        Me.Chk4.AutoSize = True
        Me.Chk4.Checked = True
        Me.Chk4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chk4.Location = New System.Drawing.Point(52, 142)
        Me.Chk4.Name = "Chk4"
        Me.Chk4.Size = New System.Drawing.Size(89, 19)
        Me.Chk4.TabIndex = 3
        Me.Chk4.Text = "所有框线"
        Me.Chk4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(52, 185)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 30)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "确定"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Location = New System.Drawing.Point(152, 185)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 30)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "取消"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'tbl_edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Button2
        Me.ClientSize = New System.Drawing.Size(275, 238)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Chk4)
        Me.Controls.Add(Me.Chk3)
        Me.Controls.Add(Me.Chk2)
        Me.Controls.Add(Me.Chk1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "tbl_edit"
        Me.Text = "表格排版"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Chk1 As Windows.Forms.CheckBox
    Friend WithEvents Chk2 As Windows.Forms.CheckBox
    Friend WithEvents Chk3 As Windows.Forms.CheckBox
    Friend WithEvents Chk4 As Windows.Forms.CheckBox
    Friend WithEvents Button1 As Windows.Forms.Button
    Friend WithEvents Button2 As Windows.Forms.Button
End Class
