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
Imports Microsoft.Vbe.Interop.Forms

Module 公式及计算
    Sub ph_insert(ph As Word.Paragraph, s As String, start As Integer) '在ph中左数第start个字符后面插入s
        Dim st = ph.Range.Start
        doc.ActiveDocument.Range(st, st).Select()
        doc.Selection.MoveRight(wdCharacter, start)
        doc.Selection.TypeText(s)
    End Sub
    Sub excel_run()
        If xls Is Nothing Then
            Dim f1 As New initialize_excel
            f1.Show()
            xls = CreateObject("Excel.Application")
            f1.pb1.Value = 100
            f1.Close()
        End If
    End Sub
    Sub 将数字代入公式()
        doc.ScreenUpdating = False '关闭屏幕刷新
        On Error GoTo Err
        '定义正则表达式对象
        Dim re = CreateObject("VBScript.RegExp") : re.Global = True
        Dim re1 = CreateObject("VBScript.RegExp") : re1.Global = True
        re1.Pattern = "[^=：:]+="

        Dim ph1 = Replace(doc.Selection.Paragraphs(1).Range.Text, " ", "")
        Dim out = Split(ph1, ",")
        Dim up = UBound(out)
        '创建一个下标从0开始,2行,up列的数组var_val,第一行储存变量名,第二行储存值
        Dim var_val(0 To 1, 0 To up)
        For i = 0 To up
            var_val(0, i) = Split(out(i), "=")(0)
            var_val(1, i) = Split(out(i), "=")(1)
        Next


        Dim ph_list(0 To doc.Selection.Paragraphs.Count - 2)
        For i = 2 To doc.Selection.Paragraphs.Count
            ph_list(i - 2) = doc.Selection.Paragraphs(i)
        Next

        Dim matches1, formu, match1_s, find_st
        For Each p In ph_list
            Dim s0 = p.Range.Text
            matches1 = re1.Execute(s0)
            If matches1.Count <> 0 Then
                match1_s = matches1(matches1.Count - 1).Value
                find_st = matches1(matches1.Count - 1).FirstIndex
                formu = match1_s

                For i = 0 To up
                    re.Pattern = "^" & var_val(0, i) & "(?=[=+\-*/^),])"
                    formu = re.Replace(formu, var_val(1, i))

                    re.Pattern = "[+\-*/^(,]" & var_val(0, i) & "(?=[=+\-*/^),])"
                    Dim matches = re.Execute(formu)
                    For Each m In matches
                        formu = Replace(formu, m.Value, Left(m.Value, 1) & var_val(1, i))
                    Next
                Next
                formu = Replace(formu, vbCr, "")
                ph_insert(p, formu, find_st + Len(match1_s))
            End If

        Next

        doc.ScreenUpdating = True '开启屏幕刷新
        Exit Sub
Err:    MsgBox("选区存在问题，程序终止！", vbExclamation)
        doc.ScreenUpdating = True '开启屏幕刷新
    End Sub
    Sub 数值计算(d, mode)
        doc.ScreenUpdating = False '关闭屏幕刷新
        excel_run()

        Dim out, formu, matches
        Dim re = CreateObject("VBScript.RegExp") : re.Global = True
        re.Pattern = "[^=：:]+(?=[=])"

        Dim ph_list(0 To doc.Selection.Paragraphs.Count - 1)
        For i = 1 To doc.Selection.Paragraphs.Count
            ph_list(i - 1) = doc.Selection.Paragraphs(i)
        Next

        For Each p In ph_list
            Dim s0 = p.Range.Text
            matches = re.Execute(s0)

            If matches.Count <> 0 Then
                Dim match_s = matches(matches.Count - 1).Value
                Dim find_st = matches(matches.Count - 1).FirstIndex
                formu = match_s
                out = xls.Round(xls.Evaluate(formu), d)
                If IsArray(out) Then out = out(1)
                If mode = "cal" Then '计算模式
                    ph_insert(p, CStr(out), find_st + Len(match_s) + 1) '+1的目的是使光标位于等号后面
                Else
                    Call 校核模式(p, out, p.Range.Start + find_st + Len(match_s) + 1)
                End If
            End If
        Next

        doc.ScreenUpdating = True '开启屏幕刷新
    End Sub
    Sub 校核模式(ph As Word.Paragraph, out As Double, rng_st As Integer)
        Dim st = ph.Range.Start
        Dim ed = ph.Range.End
        Dim check_text = doc.ActiveDocument.Range(rng_st, ed).Text
        Dim re = CreateObject("VBScript.RegExp") : re.Pattern = "[-.0-9]+"
        Dim matches = re.Execute(check_text)

        If matches.Count <> 0 Then
            Dim match_s = matches(0).Value
            Dim find_st = matches(0).FirstIndex
            If find_st <> 0 Then '数字没有紧跟在等号后面
                ph.Range.Font.ColorIndex = 6
            Else '数字紧跟在等号后面
                If CDbl(match_s) <> out Then
                    ph.Range.Font.ColorIndex = 6
                Else
                    ph.Range.Font.Color = -16777216
                End If
            End If
        Else '没有找到数字
            ph.Range.Font.ColorIndex = 6
        End If

    End Sub

    Sub 转换为专业型公式()
        doc.ScreenUpdating = False
        doc.Selection.Find.ClearFormatting()
        doc.Selection.Find.Replacement.ClearFormatting()
        Dim MyData As New DataObject

        doc.Selection.Range.Find.Execute(FindText:="*", ReplaceWith:="×", Replace:=wdReplaceAll, MatchWildcards:=False)
        MyData.SetText("^")   '符号^不能直接输入到替换框里,会被识别为当成通配符
        MyData.PutInClipboard() '将^号放进剪贴板里
        For i = 5 To 1 Step -1
            '下标替换
            With doc.Selection.Find.Font
                .Superscript = False
                .Subscript = True '查找下标
            End With
            With doc.Selection.Find.Replacement.Font
                .Superscript = False
                .Subscript = False '替换为无上下标
            End With
            With doc.Selection.Find
                .Text = "(?{" & i & "})"
                .Replacement.Text = "_\1"
                .Format = True
                .MatchWildcards = True
                .Wrap = wdFindStop
            End With
            doc.Selection.Find.Execute(Replace:=wdReplaceAll)
        Next
        '上标替换
        With doc.Selection.Find.Font
            .Superscript = True '查找上标
            .Subscript = False
        End With
        With doc.Selection.Find
            .Text = "(?)"
            .Replacement.Text = "^c\1"  '从剪贴板里获取^号
            .Format = True
            .MatchWildcards = True
            .Wrap = wdFindStop
        End With
        doc.Selection.Find.Execute(Replace:=wdReplaceAll)
        '建立公式
        doc.Selection.OMaths.Add(Range:=doc.Selection.Range)
        '转为专业型公式
        On Error Resume Next '有的公式明明转换成功了但还是会不明原因地报错
        doc.Selection.OMaths.BuildUp()
        doc.Selection.Font.Italic = False
        For Each OMath In doc.Selection.OMaths
            OMath.Type = wdOMathInline '公式内嵌
        Next

        doc.Selection.Find.Execute(FindText:="", ReplaceWith:="") '清除查找和替换框里的正则表达式
        doc.Selection.Find.ClearFormatting()
        doc.Selection.Find.Replacement.ClearFormatting()
        doc.Selection.Collapse(wdCollapseStart)
        MyData.SetText("")   '清空剪贴板
        doc.ScreenUpdating = True
    End Sub

End Module
