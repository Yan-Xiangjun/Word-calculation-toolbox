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
Public Class tbl_edit
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        doc.ScreenUpdating = False '关闭屏幕刷新
        Dim tb As Word.Table
        For Each tb In doc.Selection.Range.Tables
            '表格居中
            If Chk1.Checked = True Then tb.Range.Tables(1).Rows.Alignment = wdAlignRowCenter
            '表内文字水平居中
            If Chk2.Checked = True Then tb.Range.ParagraphFormat.Alignment = wdAlignParagraphCenter
            '表内文字垂直居中
            If Chk3.Checked = True Then tb.Range.Cells.VerticalAlignment = wdCellAlignVerticalCenter
            '所有框线
            If Chk4.Checked = True Then
                With tb.Borders(wdBorderTop)
                    .LineStyle = doc.Options.DefaultBorderLineStyle
                    .LineWidth = doc.Options.DefaultBorderLineWidth
                    .Color = doc.Options.DefaultBorderColor
                End With
                With tb.Borders(wdBorderLeft)
                    .LineStyle = doc.Options.DefaultBorderLineStyle
                    .LineWidth = doc.Options.DefaultBorderLineWidth
                    .Color = doc.Options.DefaultBorderColor
                End With
                With tb.Borders(wdBorderBottom)
                    .LineStyle = doc.Options.DefaultBorderLineStyle
                    .LineWidth = doc.Options.DefaultBorderLineWidth
                    .Color = doc.Options.DefaultBorderColor
                End With
                With tb.Borders(wdBorderRight)
                    .LineStyle = doc.Options.DefaultBorderLineStyle
                    .LineWidth = doc.Options.DefaultBorderLineWidth
                    .Color = doc.Options.DefaultBorderColor
                End With
                With tb.Borders(wdBorderHorizontal)
                    .LineStyle = doc.Options.DefaultBorderLineStyle
                    .LineWidth = doc.Options.DefaultBorderLineWidth
                    .Color = doc.Options.DefaultBorderColor
                End With
                With tb.Borders(wdBorderVertical)
                    .LineStyle = doc.Options.DefaultBorderLineStyle
                    .LineWidth = doc.Options.DefaultBorderLineWidth
                    .Color = doc.Options.DefaultBorderColor
                End With
            End If
        Next
        doc.ScreenUpdating = True '开启屏幕刷新
        If hold_or_close = "close" Then Close()
    End Sub

    '"取消"按钮
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class