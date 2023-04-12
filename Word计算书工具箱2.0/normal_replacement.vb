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
Public Class normal_replacement
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        doc.ScreenUpdating = False '关闭屏幕刷新
        doc.Selection.Range.Find.ClearFormatting()
        doc.Selection.Range.Find.Replacement.ClearFormatting()
        '选区内*替换为× (不要开启通配符,否则"查找*"指的是"查找所有字符")
        If Op1.Checked = True Then doc.Selection.Range.Find.Execute(FindText:="*", ReplaceWith:="×", Replace:=wdReplaceAll, MatchWildcards:=False)
        '选区内×替换为*
        If Op2.Checked = True Then doc.Selection.Range.Find.Execute(FindText:="×", ReplaceWith:="*", Replace:=wdReplaceAll)
        '选区内↓替换为<┘
        If Op4.Checked = True Then doc.Selection.Range.Find.Execute(FindText:="^11", ReplaceWith:="^13", Replace:=wdReplaceAll)
        '选区内去↓
        If Op5.Checked = True Then doc.Selection.Range.Find.Execute(FindText:="^11", ReplaceWith:="", Replace:=wdReplaceAll)
        '选区内去空格
        If Chk1.Checked = True Then doc.Selection.Range.Find.Execute(FindText:=" ", ReplaceWith:="", Replace:=wdReplaceAll)
        '选区内去空行
        If Chk2.Checked = True Then
            Dim ph As Word.Paragraph
            For Each ph In doc.Selection.Range.Paragraphs
                If Len(ph.Range.Text) = 1 Then
                    ph.Range.Delete()
                End If
            Next
        End If

        doc.ScreenUpdating = True '开启屏幕刷新
        MsgBox("完成！", vbInformation)
        If hold_or_close = "close" Then Close()
    End Sub
    '"取消"按钮
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class