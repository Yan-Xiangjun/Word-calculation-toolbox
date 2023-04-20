'Copyright 2023 阎相君
'
'Licensed under the Apache License, Version 2.0 (the "License");
'you may not use this file except in compliance with the License.
'You may obtain a copy of the License at
'
'    http://www.apache.org/licenses/LICENSE-2.0
'
'Unless required by applicable law or agreed to in writing, software
'distributed under the License is distributed on an "AS IS" BASIS,
'WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
'See the License for the specific language governing permissions and
'limitations under the License.
Imports Microsoft.Office.Tools.Ribbon
Public Class Ribbon1

    Private Sub Ribbon1_Load(ByVal sender As System.Object, ByVal e As RibbonUIEventArgs) Handles MyBase.Load
        hold_or_close = "close"
    End Sub

    Private Sub Button1_Click(sender As Object, e As RibbonControlEventArgs) Handles Button1.Click
        Call 将数字代入公式()
    End Sub

    Private Sub Button2_Click(sender As Object, e As RibbonControlEventArgs)
        MsgBox(DropDown1.SelectedItem.Label)
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As RibbonControlEventArgs) Handles Button2.Click
        Dim d = CLng(DropDown1.SelectedItem.Label)
        Call 数值计算(d, "cal")
    End Sub

    Private Sub Button3_Click(sender As Object, e As RibbonControlEventArgs) Handles Button3.Click
        Dim d = CLng(DropDown1.SelectedItem.Label)
        Call 数值计算(d, "check")
    End Sub

    Private Sub Button4_Click(sender As Object, e As RibbonControlEventArgs) Handles Button4.Click
        Call 转换为专业型公式()
    End Sub
    '单位推断
    Private Sub Button5_Click(sender As Object, e As RibbonControlEventArgs) Handles Button5.Click
        Dim st = doc.Selection.Paragraphs(1).Range.Start
        Dim check_text = doc.ActiveDocument.Range(st, doc.Selection.Range.Start).Text

        Dim re = CreateObject("VBScript.RegExp") : re.Pattern = "^[a-zA-Zα-ωΑ-Ω]+|[^=][a-zA-Zα-ωΑ-Ω]+"
        Dim matches = re.Execute(check_text)

        Dim s
        If matches.Count <> 0 Then
            Dim match_s = matches(0).Value
            Dim find_st = matches(0).FirstIndex
            If Left(match_s, 1) Like "[=，,：:]" Then s = Mid(match_s, 2) Else s = match_s
            s = Left(s, 1)
            If dic_unit.ContainsKey(s) Then
                Dim f1 As New normal_units
                Dim units = Split(dic_unit(s), ",")
                For Each u In units
                    f1.Lst1.Items.Add(u)
                Next
                f1.Show()
                f1.TopMost = True
            End If
        End If

    End Sub
    '常用替换
    Private Sub Button6_Click(sender As Object, e As RibbonControlEventArgs) Handles Button6.Click
        Dim f1 As New normal_replacement
        f1.Show()
        f1.TopMost = True

    End Sub
    '段落排版
    Sub set_ph_type(cb As Object)

        If dic_title.ContainsKey(cb.Text) Then
            cb.Tag = dic_title(cb.Text)
        Else
            cb.Tag = cb.Text
        End If

    End Sub
    Private Sub Button7_Click(sender As Object, e As RibbonControlEventArgs) Handles Button7.Click

        Call set_ph_type(ComboBox1)
        Call set_ph_type(ComboBox2)
        Call set_ph_type(ComboBox3)
        Call set_ph_type(ComboBox4)

        Call 开始段落排版()

    End Sub
    '表格排版
    Private Sub Button8_Click(sender As Object, e As RibbonControlEventArgs) Handles Button8.Click
        Dim f1 As New tbl_edit
        f1.Show()
        f1.TopMost = True

    End Sub
    '图片编辑
    Private Sub Button9_Click(sender As Object, e As RibbonControlEventArgs) Handles Button9.Click
        Dim f1 As New pic_edit
        f1.Show()
        f1.TopMost = True

    End Sub
    '弹出的窗口保持浮动
    Private Sub Ch4_Click(sender As Object, e As RibbonControlEventArgs) Handles Chk4.Click
        If Chk4.Checked = True Then hold_or_close = "hold"
        If Chk4.Checked = False Then hold_or_close = "close"
    End Sub
    '打开建标库
    Private Sub Button10_Click(sender As Object, e As RibbonControlEventArgs) Handles Button10.Click
        Shell("explorer.exe http://www.jianbiaoku.com/", vbNormalFocus)
    End Sub
    '打开项目地址
    Private Sub Button11_Click(sender As Object, e As RibbonControlEventArgs) Handles Button11.Click
        Shell("explorer.exe https://gitee.com/yan-xiangjun/word-calculation-toolbox", vbNormalFocus)
    End Sub
    '公式内上标
    Private Sub Button12_Click(sender As Object, e As RibbonControlEventArgs) Handles Button12.Click
        Dim ed = doc.Selection.Range.End
        doc.Selection.Collapse(wdCollapseStart)
        doc.Selection.TypeText("^")
        doc.ActiveDocument.Range(ed + 1, ed + 1).Select() '因为多了一个^，所以+1
        Windows.Forms.SendKeys.Send(" ") '模拟按键
    End Sub

    Private Sub Button13_Click(sender As Object, e As RibbonControlEventArgs) Handles Button13.Click
        Dim ed = doc.Selection.Range.End
        doc.Selection.Collapse(wdCollapseStart)
        doc.Selection.TypeText("_")
        doc.ActiveDocument.Range(ed + 1, ed + 1).Select() '因为多了一个_，所以+1
        Windows.Forms.SendKeys.Send(" ") '模拟按键
    End Sub

End Class
