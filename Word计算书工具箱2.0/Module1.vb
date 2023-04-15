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
Module Module1
    Public doc As Word.Application = Globals.ThisAddIn.Application
    Public wdCollapseEnd = 0
    Public wdCollapseStart = 1
    Public wdCharacter = 1
    Public wdParagraph = 4
    Public wdExtend = 1

    Public wdFindStop = 0
    Public wdFindContinue = 1
    Public wdReplaceAll = 2

    Public wdSelectionIP = 1
    Public wdWithInTable = 12
    Public wdOMathInline = 1
    Public wdAlignParagraphCenter = 1
    Public wdAlignRowCenter = 1
    Public wdCellAlignVerticalCenter = 1
    Public wdStyleCaption = -35 '题注

    Public wdBorderTop = -1
    Public wdBorderLeft = -2
    Public wdBorderBottom = -3
    Public wdBorderRight = -4
    Public wdBorderHorizontal = -5
    Public wdBorderVertical = -6

    Public msoFalse = 0
    Public msoPictureGrayscale = 2
    Public wdRelativeHorizontalPositionMargin = 0

    Public hold_or_close

    Public xls As Object
    Public dic_title As New Dictionary(Of String, String) From {
            {"一、*或一 *", "^[一-十]+[、 " & vbTab & "]"},
            {"（一）*", "^[（(][一-十]+[)）]"},
            {"1. *", "^\d+\.[ " & vbTab & "]"}, '.后面必须有空格，不然像1.123这种数字也会被当成标题
            {"（1）*", "^[（(]\d+[)）]"},
            {"1) *或1 *", "^\d+[)） " & vbTab & "]"},
            {"①*", "^[①②③④⑤⑥⑦⑧⑨⑩]"},
            {"1.1 *", "^\d+\.\d+[ " & vbTab & "]"},
            {"1.1.1 *", "^\d+\.\d+\.\d+[ " & vbTab & "]"},
            {"1.1.1.1 *", "^\d+\.\d+\.\d+\.\d+[ " & vbTab & "]"}
        }
    Public dic_unit As New Dictionary(Of String, String) From {
            {"M", "kN·m,N·m,N·mm"},
            {"F", "kN,N"},
            {"P", "kN,N"},
            {"Q", "kN,N"},
            {"V", "kN,N,m³,mm³"},
            {"σ", "N/mm²,MPa"},
            {"τ", "N/mm²,MPa"},
            {"A", "m²,mm²"},
            {"S", "m²,mm²,mm³"},
            {"I", "mm⁴"},
            {"W", "mm³"},
            {"q", "kN/m²,kN/m"},
            {"g", "kN/m²,kN/m"}
        }
End Module
