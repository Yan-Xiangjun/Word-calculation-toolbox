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
Module 段落排版
    Sub 开始段落排版()
        doc.ScreenUpdating = False '关闭屏幕刷新
        If Globals.Ribbons.Ribbon1.Chk3.Checked Then doc.Selection.Range.ListFormat.ConvertNumbersToText() '自动编号转文本
        '排版
        Dim ph As Word.Paragraph
        Dim re1 = CreateObject("VBScript.RegExp") : re1.Pattern = Globals.Ribbons.Ribbon1.ComboBox1.Tag
        Dim re2 = CreateObject("VBScript.RegExp") : re2.Pattern = Globals.Ribbons.Ribbon1.ComboBox2.Tag
        Dim re3 = CreateObject("VBScript.RegExp") : re3.Pattern = Globals.Ribbons.Ribbon1.ComboBox3.Tag
        Dim re4 = CreateObject("VBScript.RegExp") : re4.Pattern = Globals.Ribbons.Ribbon1.ComboBox4.Tag
        Dim re5 = CreateObject("VBScript.RegExp") : re5.Pattern = "^[图表]\d+"
        For Each ph In doc.Selection.Paragraphs
            Dim ph_text = ph.Range.Text

            If ph.Range.Information(wdWithInTable) = True Or ph.Style.NameLocal = "题注" Then '段落在表格中,或者它本身已经是"题注"了,则什么都不做

            ElseIf re4.Pattern IsNot Nothing And re4.Execute(ph_text).Count <> 0 Then
                ph.Style = doc.ActiveDocument.Styles("标题 4")

            ElseIf re3.Pattern IsNot Nothing And re3.Execute(ph_text).Count <> 0 Then
                ph.Style = doc.ActiveDocument.Styles("标题 3")

            ElseIf re2.Pattern IsNot Nothing And re2.Execute(ph_text).Count <> 0 Then
                ph.Style = doc.ActiveDocument.Styles("标题 2")

            ElseIf re1.Pattern IsNot Nothing And re1.Execute(ph_text).Count <> 0 Then
                ph.Style = doc.ActiveDocument.Styles("标题 1")

            ElseIf re5.Execute(ph_text).Count <> 0 Then
                ph.Range.ParagraphFormat.Alignment = wdAlignParagraphCenter '居中
                ph.Range.ParagraphFormat.CharacterUnitFirstLineIndent = 0 '无缩进

            ElseIf Len(ph.Range.Text) <> 2 Then '纯图片段落
                ph.Range.ParagraphFormat.CharacterUnitFirstLineIndent = 2 '首行缩进2字符

            End If
        Next
        doc.ScreenUpdating = True '开启屏幕刷新
    End Sub
End Module
