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
Public Class pic_edit
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        doc.ScreenUpdating = False '关闭屏幕刷新
        Dim w_1st, h_1st
        '选区内第一张图片的宽度和高度
        If Op0_1.Checked = True Then
            Try
                w_1st = doc.Selection.InlineShapes(1).Width
                h_1st = doc.Selection.InlineShapes(1).Height
            Catch
                MsgBox("选区内没有嵌入型图片！", vbExclamation)
                Exit Sub
            End Try
        Else
            Try
                w_1st = doc.Selection.Range.ShapeRange(1).Width
                h_1st = doc.Selection.Range.ShapeRange(1).Height
            Catch
                MsgBox("选区内没有非嵌入型图片！", vbExclamation)
                Exit Sub
            End Try
        End If

        '嵌入型图片:
        If Chk5.Checked = True Then
            For Each InlineShape In doc.Selection.InlineShapes
                '宽度设为与第一张图片相同
                If Op1.Checked = True Then
                    InlineShape.Width = w_1st
                End If
                '高度设为与第一张图片相同
                If Op2.Checked = True Then
                    InlineShape.Height = h_1st
                End If
                '同时统一宽度和高度
                If Op3.Checked = True Then
                    InlineShape.LockAspectRatio = msoFalse '取消锁定纵横比
                    InlineShape.Width = w_1st
                    InlineShape.Height = h_1st
                End If
                '水平居中
                If Chk1.Checked = True Then
                    InlineShape.Range.ParagraphFormat.Alignment = wdAlignParagraphCenter '居中
                End If
                '灰度
                If Chk2.Checked = True Then
                    InlineShape.PictureFormat.ColorType = msoPictureGrayscale '灰度
                End If
                '对比度
                If Chk3.Checked = True Then
                    '如果Contrast = 0.6，由于(0.6-0.5)/0.5=20%，所以对比度+20%
                    '效果=(Contrast-0.5)/0.5
                    'Contrast=0.5*效果+0.5
                    InlineShape.PictureFormat.Contrast = 0.5 * (Num1.Value / 100) + 0.5
                End If
                '亮度
                If Chk4.Checked = True Then
                    InlineShape.PictureFormat.Brightness = 0.5 * (Num2.Value / 100) + 0.5
                End If
            Next
        End If
        '非嵌入型图片:
        If Chk6.Checked = True Then
            For Each Shape In doc.Selection.Range.ShapeRange
                '宽度设为与第一张图片相同
                If Op1.Checked = True Then
                    Shape.Width = w_1st
                End If
                '高度设为与第一张图片相同
                If Op2.Checked = True Then
                    Shape.Height = h_1st
                End If
                '同时统一宽度和高度
                If Op3.Checked = True Then
                    Shape.LockAspectRatio = msoFalse '取消锁定纵横比
                    Shape.Width = w_1st
                    Shape.Height = h_1st
                End If
                '水平居中
                If Chk1.Checked = True Then
                    Dim w_p = doc.ActiveDocument.PageSetup.PageWidth '页面宽度
                    Dim w_l = doc.ActiveDocument.PageSetup.LeftMargin '左边距
                    Dim w_r = doc.ActiveDocument.PageSetup.RightMargin '右边距
                    Shape.RelativeHorizontalPosition = wdRelativeHorizontalPositionMargin
                    Shape.Left = (w_p - w_l - w_r) / 2 - Shape.Width / 2
                End If
                '灰度
                If Chk2.Checked = True Then
                    Shape.PictureFormat.ColorType = msoPictureGrayscale '灰度
                End If
                '对比度
                If Chk3.Checked = True Then
                    Shape.PictureFormat.Contrast = 0.5 * (Num1.Value / 100) + 0.5
                End If
                '亮度
                If Chk4.Checked = True Then
                    Shape.PictureFormat.Brightness = 0.5 * (Num2.Value / 100) + 0.5
                End If
            Next
        End If
        doc.ScreenUpdating = True '开启屏幕刷新
        If hold_or_close = "close" Then Close()
    End Sub

    '"取消"按钮
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class