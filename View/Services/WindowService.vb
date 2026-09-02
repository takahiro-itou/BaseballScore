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

Imports BaseballScoreView.Views


Namespace Global.BaseballScoreView.Services

Public Class WindowService
        Inherits AbstractWindowService


Public Function showEditForm(
        ByVal viewMode As ScoreEditorViewModel) As Boolean  _
        Implements IWindowService.showEditForm
    Return  False
End Function


Public Function showLineView(
        ByVal viewModel As VictoryLineViewModel) As Boolean _
        Implements IWindowService.showLineView

    Dim frmLine As New LineView()
    frmLine.DataContext = viewModel
    frmLine.ShowDialog()
    Return  True
End Sub


End Class

End Namespace
