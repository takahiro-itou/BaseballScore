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

Imports System.Windows

Imports BaseballScoreHelper.ViewModels

Imports BaseballScoreView.Views


Public Class Application

Protected Overrides Sub OnStartup(e As StartupEventArgs)
''--------------------------------------------------------------------
''    依存性注入
''--------------------------------------------------------------------
Dim wndSrv As WindowService

    MyBase.OnStartup(e)

    wndSrc = New WindowService()

    Dim vmMain As New MainViewModel(wndSrv)
    Dim frmMain As New MainWindow()
    frmMain.DataContext = vmMain
    frmMain.Show()
End Sub


End Class

End Namespace
