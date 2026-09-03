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


Public Overrides Function showEditForm(
        ByVal viewMode As ScoreEditorViewModel) As Boolean
    Return  False
End Function


Public Overrides Function showLineView(
        ByVal viewModel As VictoryLineViewModel) As Boolean
    Dim frmLine As New LineView()
    frmLine.DataContext = viewModel
    frmLine.ShowDialog()
    Return  True
End Function


End Class

End Namespace
