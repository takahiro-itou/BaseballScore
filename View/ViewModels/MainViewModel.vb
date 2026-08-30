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


Namespace Global.BaseballScoreView.ViewModels

Public Class LeagueInfo
    Public Property LeagueName As String
End Class


Public Class MainViewModel

Public Property Leagues As List(Of LeagueInfo)

Public Sub New()
''--------------------------------------------------------------------
''    コンストラクタ
''--------------------------------------------------------------------

    ' ダミーデータを作る
    Me.Leagues = New List(Of LeagueInfo) From {
        New LeagueInfo With { .LeagueName = "League 1" },
        New LeagueInfo With { .LeagueName = "League 2" }
    }
End Sub


End Class

End Namespace
