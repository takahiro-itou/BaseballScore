''  -*-  coding: utf-8-with-signature-unix     -*-  ''
''************************************************************************
''                                                                      ''
''                  ---  Baseball  Score  Project  ---                  ''
''                                                                      ''
''          Copyright (C), 2017-2026, Takahiro Itou                     ''
''          All Rights Reserved.                                        ''
''                                                                      ''
''          License: (See COPYING or LICENSE files)                     ''
''          GNU Affero General Public License (AGPL) version 3,         ''
''          or (at your option) any later version.                      ''
''                                                                      ''
''************************************************************************

Imports WpfControl.Sample

Namespace Global.BaseballScoreView.Models

Public Class MySampleModel

Public Sub executeCommand()
''--------------------------------------------------------------------
''    適当な動作を実行する
''--------------------------------------------------------------------

End Sub


Private Sub runCount(ByVal message As String)
''--------------------------------------------------------------------
''    サンプル動作
''
''    入力テキスト中のアルファベットの個数を数える
''--------------------------------------------------------------------
Dim outText As String

    outText = $"Not Implemented {message}"
    MsgBox(outText, MsgBoxStyle.OkOnly)
End Sub


End Class

End Namespace
