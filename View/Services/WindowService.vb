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

Imports BaseballScoreHelper.Services
Imports BaseballScoreHelper.ViewModels

Imports BaseballScoreView.Services


Namespace Global.BaseballScoreView.Views

Public Class WindowService
        Implements IWindowService

Public Sub showLineView(ByVal viewModel As VictoryLineViewModel) _
        Implements IWindowService.showLineView

    Dim frmLine As New LineView()
    frmLine.DataContext = viewModel
    frmLine.ShowDialog()
End Sub

End Class

End Namespace
