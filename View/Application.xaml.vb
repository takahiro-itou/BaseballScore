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

Imports BaseballScoreHelper.Models
Imports BaseballScoreHelper.ViewModels

Imports BaseballScoreView.Services
Imports BaseballScoreView.Views

Imports System.Windows


Namespace Global.BaseballScoreView

Public Class Application

Protected Overrides Sub OnStartup(e As StartupEventArgs)
''--------------------------------------------------------------------
''    依存性注入
''--------------------------------------------------------------------
Dim vmMain As MainViewModel
Dim wndSrv As WindowService
Dim mdlDoc As ScoreDocument

    MyBase.OnStartup(e)

    ' 必要なインスタンスを生成する。
    wndSrv  = New WindowService()
    mdlDoc  = New ScoreDocument()
    vmMain  = New MainViewModel(wndSrv, mdlDoc)

    ' メインビューを表示する。
    wndSrv.showMainView(vmMain)
End Sub


End Class

End Namespace
