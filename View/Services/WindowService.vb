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
        ByVal viewModel As ScoreEditorViewModel) As Boolean
''--------------------------------------------------------------------
''    編集フォームを表示する。
''--------------------------------------------------------------------
Dim frmEdit As EditForm

    frmEdit = New EditForm
    frmEdit.DataContext = viewModel
    frmEdit.ShowDialog()

    Return  False
End Function


Public Overrides Function showLineView(
        ByVal viewModel As VictoryLineViewModel) As Boolean
''--------------------------------------------------------------------
''    優勝ラインビューを表示する。
''--------------------------------------------------------------------
Dim frmLine As LineView

    frmLine = New LineView()
    frmLine.DataContext = viewModel
    frmLine.ShowDialog()

    Return  True
End Function


Public           Function showMainView(
        ByVal viewModel As MainViewModel) As Boolean
''--------------------------------------------------------------------
''    メインビューを表示する。
''--------------------------------------------------------------------
Dim frmMain As MainWindow

    frmMain = New MainWindow()
    frmMain.DataContext = viewModel
    frmMain.Show()

    Return  True
End Function


End Class

End Namespace
