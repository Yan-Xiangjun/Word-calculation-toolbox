Partial Class Ribbon1
    Inherits Microsoft.Office.Tools.Ribbon.RibbonBase

    <System.Diagnostics.DebuggerNonUserCode()>
    Public Sub New(ByVal container As System.ComponentModel.IContainer)
        MyClass.New()

        'Windows.Forms 类撰写设计器支持所必需的
        If (container IsNot Nothing) Then
            container.Add(Me)
        End If

    End Sub

    <System.Diagnostics.DebuggerNonUserCode()>
    Public Sub New()
        MyBase.New(Globals.Factory.GetRibbonFactory())

        '组件设计器需要此调用。
        InitializeComponent()

    End Sub

    '组件重写释放以清理组件列表。
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

    '组件设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是组件设计器所必需的
    '可使用组件设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim RibbonDropDownItemImpl1 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl2 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl3 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl4 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl5 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl6 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl7 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl8 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl9 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl10 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl11 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl12 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl13 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl14 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl15 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl16 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl17 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl18 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl19 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl20 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl21 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl22 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl23 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl24 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl25 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl26 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl27 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl28 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl29 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl30 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl31 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl32 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl33 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Me.Tab1 = Me.Factory.CreateRibbonTab
        Me.Group1 = Me.Factory.CreateRibbonGroup
        Me.Button1 = Me.Factory.CreateRibbonButton
        Me.DropDown1 = Me.Factory.CreateRibbonDropDown
        Me.Button2 = Me.Factory.CreateRibbonButton
        Me.Button3 = Me.Factory.CreateRibbonButton
        Me.Button4 = Me.Factory.CreateRibbonButton
        Me.Button12 = Me.Factory.CreateRibbonButton
        Me.Button13 = Me.Factory.CreateRibbonButton
        Me.Group2 = Me.Factory.CreateRibbonGroup
        Me.Button5 = Me.Factory.CreateRibbonButton
        Me.Group3 = Me.Factory.CreateRibbonGroup
        Me.Button6 = Me.Factory.CreateRibbonButton
        Me.Group4 = Me.Factory.CreateRibbonGroup
        Me.ComboBox1 = Me.Factory.CreateRibbonComboBox
        Me.ComboBox3 = Me.Factory.CreateRibbonComboBox
        Me.Chk3 = Me.Factory.CreateRibbonCheckBox
        Me.ComboBox2 = Me.Factory.CreateRibbonComboBox
        Me.ComboBox4 = Me.Factory.CreateRibbonComboBox
        Me.Button7 = Me.Factory.CreateRibbonButton
        Me.Group5 = Me.Factory.CreateRibbonGroup
        Me.Button8 = Me.Factory.CreateRibbonButton
        Me.Group6 = Me.Factory.CreateRibbonGroup
        Me.Button9 = Me.Factory.CreateRibbonButton
        Me.Group7 = Me.Factory.CreateRibbonGroup
        Me.Chk4 = Me.Factory.CreateRibbonCheckBox
        Me.Button10 = Me.Factory.CreateRibbonButton
        Me.Button11 = Me.Factory.CreateRibbonButton
        Me.Tab1.SuspendLayout()
        Me.Group1.SuspendLayout()
        Me.Group2.SuspendLayout()
        Me.Group3.SuspendLayout()
        Me.Group4.SuspendLayout()
        Me.Group5.SuspendLayout()
        Me.Group6.SuspendLayout()
        Me.Group7.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tab1
        '
        Me.Tab1.Groups.Add(Me.Group1)
        Me.Tab1.Groups.Add(Me.Group2)
        Me.Tab1.Groups.Add(Me.Group3)
        Me.Tab1.Groups.Add(Me.Group4)
        Me.Tab1.Groups.Add(Me.Group5)
        Me.Tab1.Groups.Add(Me.Group6)
        Me.Tab1.Groups.Add(Me.Group7)
        Me.Tab1.Label = "计算书"
        Me.Tab1.Name = "Tab1"
        '
        'Group1
        '
        Me.Group1.Items.Add(Me.Button1)
        Me.Group1.Items.Add(Me.DropDown1)
        Me.Group1.Items.Add(Me.Button2)
        Me.Group1.Items.Add(Me.Button3)
        Me.Group1.Items.Add(Me.Button4)
        Me.Group1.Items.Add(Me.Button12)
        Me.Group1.Items.Add(Me.Button13)
        Me.Group1.Label = "公式及计算"
        Me.Group1.Name = "Group1"
        '
        'Button1
        '
        Me.Button1.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.Button1.Image = Global.计算书工具V22._10.My.Resources.Resources.铅笔_pencil
        Me.Button1.Label = "将数字代入公式"
        Me.Button1.Name = "Button1"
        Me.Button1.ShowImage = True
        Me.Button1.SuperTip = "将数字代入公式"
        '
        'DropDown1
        '
        RibbonDropDownItemImpl1.Label = "0"
        RibbonDropDownItemImpl1.Tag = ""
        RibbonDropDownItemImpl2.Label = "1"
        RibbonDropDownItemImpl3.Label = "2"
        RibbonDropDownItemImpl4.Label = "3"
        RibbonDropDownItemImpl5.Label = "4"
        Me.DropDown1.Items.Add(RibbonDropDownItemImpl1)
        Me.DropDown1.Items.Add(RibbonDropDownItemImpl2)
        Me.DropDown1.Items.Add(RibbonDropDownItemImpl3)
        Me.DropDown1.Items.Add(RibbonDropDownItemImpl4)
        Me.DropDown1.Items.Add(RibbonDropDownItemImpl5)
        Me.DropDown1.Label = "最大小数位数"
        Me.DropDown1.Name = "DropDown1"
        '
        'Button2
        '
        Me.Button2.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.Button2.Image = Global.计算书工具V22._10.My.Resources.Resources.计算器_calculator_one
        Me.Button2.Label = "计算"
        Me.Button2.Name = "Button2"
        Me.Button2.ShowImage = True
        Me.Button2.SuperTip = "数值计算"
        '
        'Button3
        '
        Me.Button3.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.Button3.Image = Global.计算书工具V22._10.My.Resources.Resources.校验_check_one
        Me.Button3.Label = "校核"
        Me.Button3.Name = "Button3"
        Me.Button3.ShowImage = True
        Me.Button3.SuperTip = "数值计算（手动选择）"
        '
        'Button4
        '
        Me.Button4.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.Button4.Image = Global.计算书工具V22._10.My.Resources.Resources.刷新_refresh_one
        Me.Button4.Label = "转换为专业型公式"
        Me.Button4.Name = "Button4"
        Me.Button4.ShowImage = True
        Me.Button4.SuperTip = "转换为专业型公式"
        '
        'Button12
        '
        Me.Button12.Image = Global.计算书工具V22._10.My.Resources.Resources.右上_小_right_small_up
        Me.Button12.Label = "公式内上标"
        Me.Button12.Name = "Button12"
        Me.Button12.ShowImage = True
        '
        'Button13
        '
        Me.Button13.Image = Global.计算书工具V22._10.My.Resources.Resources.右下_小_right_small_down
        Me.Button13.Label = "公式内下标"
        Me.Button13.Name = "Button13"
        Me.Button13.ShowImage = True
        '
        'Group2
        '
        Me.Group2.Items.Add(Me.Button5)
        Me.Group2.Label = "单位"
        Me.Group2.Name = "Group2"
        '
        'Button5
        '
        Me.Button5.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.Button5.Image = Global.计算书工具V22._10.My.Resources.Resources.自动列宽_auto_line_width
        Me.Button5.Label = "单位推断"
        Me.Button5.Name = "Button5"
        Me.Button5.ShowImage = True
        Me.Button5.SuperTip = "常用单位"
        '
        'Group3
        '
        Me.Group3.Items.Add(Me.Button6)
        Me.Group3.Label = "替换"
        Me.Group3.Name = "Group3"
        '
        'Button6
        '
        Me.Button6.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.Button6.Image = Global.计算书工具V22._10.My.Resources.Resources.报纸折叠_newspaper_folding
        Me.Button6.Label = "常用替换"
        Me.Button6.Name = "Button6"
        Me.Button6.ShowImage = True
        Me.Button6.SuperTip = "常用替换"
        '
        'Group4
        '
        Me.Group4.Items.Add(Me.ComboBox1)
        Me.Group4.Items.Add(Me.ComboBox3)
        Me.Group4.Items.Add(Me.Chk3)
        Me.Group4.Items.Add(Me.ComboBox2)
        Me.Group4.Items.Add(Me.ComboBox4)
        Me.Group4.Items.Add(Me.Button7)
        Me.Group4.Label = "段落排版"
        Me.Group4.Name = "Group4"
        '
        'ComboBox1
        '
        RibbonDropDownItemImpl6.Label = "一、*或一 *"
        RibbonDropDownItemImpl6.Tag = "[一-十][、 ]*,[一-十][一-十][、 ]*"
        RibbonDropDownItemImpl7.Label = "（一）*"
        RibbonDropDownItemImpl7.Tag = "[（(][一-十][)）]*,[（(][一-十][一-十][)）]*"
        RibbonDropDownItemImpl8.Label = "1. *"
        RibbonDropDownItemImpl8.Tag = "#. *,##. *"
        RibbonDropDownItemImpl9.Label = "（1）*"
        RibbonDropDownItemImpl9.Tag = "[（(]#[)）]*,[（(]##[)）]*"
        RibbonDropDownItemImpl10.Label = "1) *或1 *"
        RibbonDropDownItemImpl10.Tag = "#[)） ]*,##[)） ]*"
        RibbonDropDownItemImpl11.Label = "①*"
        RibbonDropDownItemImpl11.Tag = "[①②③④⑤⑥⑦⑧⑨⑩]*,"
        Me.ComboBox1.Items.Add(RibbonDropDownItemImpl6)
        Me.ComboBox1.Items.Add(RibbonDropDownItemImpl7)
        Me.ComboBox1.Items.Add(RibbonDropDownItemImpl8)
        Me.ComboBox1.Items.Add(RibbonDropDownItemImpl9)
        Me.ComboBox1.Items.Add(RibbonDropDownItemImpl10)
        Me.ComboBox1.Items.Add(RibbonDropDownItemImpl11)
        Me.ComboBox1.Items.Add(RibbonDropDownItemImpl12)
        Me.ComboBox1.Label = "一级标题"
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Text = Nothing
        '
        'ComboBox3
        '
        RibbonDropDownItemImpl13.Label = "（一）*"
        RibbonDropDownItemImpl13.Tag = "[（(][一-十][)）]*,[（(][一-十][一-十][)）]*"
        RibbonDropDownItemImpl14.Label = "1. *"
        RibbonDropDownItemImpl14.Tag = "#. *,##. *"
        RibbonDropDownItemImpl15.Label = "1.1.1 *"
        RibbonDropDownItemImpl15.Tag = "#.#.# *,##.#.# *"
        RibbonDropDownItemImpl16.Label = "（1）*"
        RibbonDropDownItemImpl16.Tag = "[（(]#[)）]*,[（(]##[)）]*"
        RibbonDropDownItemImpl17.Label = "1) *或1 *"
        RibbonDropDownItemImpl17.Tag = "#[)） ]*,##[)） ]*"
        RibbonDropDownItemImpl18.Label = "①*"
        RibbonDropDownItemImpl18.Tag = "[①②③④⑤⑥⑦⑧⑨⑩]*,"
        Me.ComboBox3.Items.Add(RibbonDropDownItemImpl13)
        Me.ComboBox3.Items.Add(RibbonDropDownItemImpl14)
        Me.ComboBox3.Items.Add(RibbonDropDownItemImpl15)
        Me.ComboBox3.Items.Add(RibbonDropDownItemImpl16)
        Me.ComboBox3.Items.Add(RibbonDropDownItemImpl17)
        Me.ComboBox3.Items.Add(RibbonDropDownItemImpl18)
        Me.ComboBox3.Items.Add(RibbonDropDownItemImpl19)
        Me.ComboBox3.Label = "三级标题"
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Text = Nothing
        '
        'Chk3
        '
        Me.Chk3.Label = "自动编号->普通文本"
        Me.Chk3.Name = "Chk3"
        '
        'ComboBox2
        '
        RibbonDropDownItemImpl20.Label = "（一）*"
        RibbonDropDownItemImpl20.Tag = "[（(][一-十][)）]*,[（(][一-十][一-十][)）]*"
        RibbonDropDownItemImpl21.Label = "1. *"
        RibbonDropDownItemImpl21.Tag = "#. *,##. *"
        RibbonDropDownItemImpl22.Label = "1.1 *"
        RibbonDropDownItemImpl22.Tag = "#.# *,##.# *"
        RibbonDropDownItemImpl23.Label = "（1）*"
        RibbonDropDownItemImpl23.Tag = "[（(]#[)）]*,[（(]##[)）]*"
        RibbonDropDownItemImpl24.Label = "1) *或1 *"
        RibbonDropDownItemImpl24.Tag = "#[)） ]*,##[)） ]*"
        RibbonDropDownItemImpl25.Label = "①*"
        RibbonDropDownItemImpl25.Tag = "[①②③④⑤⑥⑦⑧⑨⑩]*,"
        Me.ComboBox2.Items.Add(RibbonDropDownItemImpl20)
        Me.ComboBox2.Items.Add(RibbonDropDownItemImpl21)
        Me.ComboBox2.Items.Add(RibbonDropDownItemImpl22)
        Me.ComboBox2.Items.Add(RibbonDropDownItemImpl23)
        Me.ComboBox2.Items.Add(RibbonDropDownItemImpl24)
        Me.ComboBox2.Items.Add(RibbonDropDownItemImpl25)
        Me.ComboBox2.Items.Add(RibbonDropDownItemImpl26)
        Me.ComboBox2.Label = "  二级标题"
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Text = Nothing
        '
        'ComboBox4
        '
        RibbonDropDownItemImpl27.Label = "（一）*"
        RibbonDropDownItemImpl27.Tag = "[（(][一-十][)）]*,[（(][一-十][一-十][)）]*"
        RibbonDropDownItemImpl28.Label = "1. *"
        RibbonDropDownItemImpl28.Tag = "#. *,##. *"
        RibbonDropDownItemImpl29.Label = "1.1.1.1 *"
        RibbonDropDownItemImpl29.Tag = "#.#.#.# *,##.#.#.# *"
        RibbonDropDownItemImpl30.Label = "（1）*"
        RibbonDropDownItemImpl30.Tag = "[（(]#[)）]*,[（(]##[)）]*"
        RibbonDropDownItemImpl31.Label = "1) *或1 *"
        RibbonDropDownItemImpl31.Tag = "#[)） ]*,##[)） ]*"
        RibbonDropDownItemImpl32.Label = "①*"
        RibbonDropDownItemImpl32.Tag = "[①②③④⑤⑥⑦⑧⑨⑩]*,"
        Me.ComboBox4.Items.Add(RibbonDropDownItemImpl27)
        Me.ComboBox4.Items.Add(RibbonDropDownItemImpl28)
        Me.ComboBox4.Items.Add(RibbonDropDownItemImpl29)
        Me.ComboBox4.Items.Add(RibbonDropDownItemImpl30)
        Me.ComboBox4.Items.Add(RibbonDropDownItemImpl31)
        Me.ComboBox4.Items.Add(RibbonDropDownItemImpl32)
        Me.ComboBox4.Items.Add(RibbonDropDownItemImpl33)
        Me.ComboBox4.Label = "  四级标题"
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Text = Nothing
        '
        'Button7
        '
        Me.Button7.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.Button7.Image = Global.计算书工具V22._10.My.Resources.Resources.字母段落_paragraph_alphabet
        Me.Button7.Label = "段落排版"
        Me.Button7.Name = "Button7"
        Me.Button7.ShowImage = True
        Me.Button7.SuperTip = "段落排版"
        '
        'Group5
        '
        Me.Group5.Items.Add(Me.Button8)
        Me.Group5.Label = "表格排版"
        Me.Group5.Name = "Group5"
        '
        'Button8
        '
        Me.Button8.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.Button8.Image = Global.计算书工具V22._10.My.Resources.Resources._16宫格_grid_sixteen
        Me.Button8.Label = "表格排版"
        Me.Button8.Name = "Button8"
        Me.Button8.ShowImage = True
        Me.Button8.SuperTip = "表格排版"
        '
        'Group6
        '
        Me.Group6.Items.Add(Me.Button9)
        Me.Group6.Label = "图片编辑"
        Me.Group6.Name = "Group6"
        '
        'Button9
        '
        Me.Button9.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.Button9.Image = Global.计算书工具V22._10.My.Resources.Resources.立体透视_stereo_perspective
        Me.Button9.Label = "图片编辑"
        Me.Button9.Name = "Button9"
        Me.Button9.ShowImage = True
        Me.Button9.SuperTip = "图片编辑"
        '
        'Group7
        '
        Me.Group7.Items.Add(Me.Chk4)
        Me.Group7.Items.Add(Me.Button10)
        Me.Group7.Items.Add(Me.Button11)
        Me.Group7.Label = "其他"
        Me.Group7.Name = "Group7"
        '
        'Chk4
        '
        Me.Chk4.Label = "弹出的窗口保持浮动"
        Me.Chk4.Name = "Chk4"
        '
        'Button10
        '
        Me.Button10.Image = Global.计算书工具V22._10.My.Resources.Resources.数据库网络节点_database_network_point
        Me.Button10.Label = "打开建标库"
        Me.Button10.Name = "Button10"
        Me.Button10.ShowImage = True
        '
        'Button11
        '
        Me.Button11.Image = Global.计算书工具V22._10.My.Resources.Resources.数据库网络节点_database_network_point
        Me.Button11.Label = "打开项目地址"
        Me.Button11.Name = "Button11"
        Me.Button11.ShowImage = True
        '
        'Ribbon1
        '
        Me.Name = "Ribbon1"
        Me.RibbonType = "Microsoft.Word.Document"
        Me.Tabs.Add(Me.Tab1)
        Me.Tab1.ResumeLayout(False)
        Me.Tab1.PerformLayout()
        Me.Group1.ResumeLayout(False)
        Me.Group1.PerformLayout()
        Me.Group2.ResumeLayout(False)
        Me.Group2.PerformLayout()
        Me.Group3.ResumeLayout(False)
        Me.Group3.PerformLayout()
        Me.Group4.ResumeLayout(False)
        Me.Group4.PerformLayout()
        Me.Group5.ResumeLayout(False)
        Me.Group5.PerformLayout()
        Me.Group6.ResumeLayout(False)
        Me.Group6.PerformLayout()
        Me.Group7.ResumeLayout(False)
        Me.Group7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Tab1 As Microsoft.Office.Tools.Ribbon.RibbonTab
    Friend WithEvents Group1 As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents Button1 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents DropDown1 As Microsoft.Office.Tools.Ribbon.RibbonDropDown
    Friend WithEvents Button2 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents Button3 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents Button4 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents Group2 As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents Button5 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents Group3 As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents Button6 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents Group4 As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents Button7 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents Chk3 As Microsoft.Office.Tools.Ribbon.RibbonCheckBox
    Friend WithEvents Group5 As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents Button8 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents Group6 As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents Button9 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents ComboBox2 As Microsoft.Office.Tools.Ribbon.RibbonComboBox
    Friend WithEvents ComboBox3 As Microsoft.Office.Tools.Ribbon.RibbonComboBox
    Friend WithEvents ComboBox4 As Microsoft.Office.Tools.Ribbon.RibbonComboBox
    Friend WithEvents ComboBox1 As Microsoft.Office.Tools.Ribbon.RibbonComboBox
    Friend WithEvents Group7 As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents Chk4 As Microsoft.Office.Tools.Ribbon.RibbonCheckBox
    Friend WithEvents Button10 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents Button11 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents Button12 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents Button13 As Microsoft.Office.Tools.Ribbon.RibbonButton
End Class

Partial Class ThisRibbonCollection

    <System.Diagnostics.DebuggerNonUserCode()> _
    Friend ReadOnly Property Ribbon1() As Ribbon1
        Get
            Return Me.GetRibbon(Of Ribbon1)()
        End Get
    End Property
End Class
