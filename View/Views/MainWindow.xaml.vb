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


Namespace Global.BaseballScoreView.Views

Public Class MainWindow

Public Sub New()
''--------------------------------------------------------------------
''    コンストラクタ
''--------------------------------------------------------------------
    InitializeComponent()
End Sub


Private Sub mnuFileOpen_Click(sender As Object, e As EventArgs)
''--------------------------------------------------------------------
''    メニュー「ファイル」－「開く」
''--------------------------------------------------------------------
Dim dlgOpenFile As New Microsoft.Win32.OpenFileDialog

    With dlgOpenFile
        .DefaultExt = ".nes"
        .FileName = "*.nes"
        .Filter = "Nes Image(*.nes)|*.nes|All files(*.*)|*.*"
        .FilterIndex = 1

        If .ShowDialog() = True Then

        End If
    End With

End Sub


Private Sub mnuMagicLine_Click(sender As Object, e As EventArgs) Handles _
            mnuMagicLine.Click
''--------------------------------------------------------------------
''    メニュー「マジック」－「詳細表示」
''--------------------------------------------------------------------
Dim frmLine As LineView

    frmLine = New LineView()
    With frmLine
        ' .initializeFormPosition(Me.m_iniFileName, Me)
        ' .initializeView(Me.m_scoreData, Me.m_currentDate)
        .ShowDialog()
    End With

End Sub


Private Sub mnuScoreEdit_Click(sender As Object, e As EventArgs) Handles _
            mnuScoreEdit.Click
''--------------------------------------------------------------------
''    メニュー「スコア」－「編集」
''--------------------------------------------------------------------
Dim frmEdit As EditForm

    frmEdit = New EditForm()
    With frmEdit
        ' .initializeFormPosition(Me.m_iniFileName, Me)
        ' .setupSettings(m_scoreData, m_currentDate)
        If .ShowDialog() Then
            ' 変更内容を受け取る
'            .applyEditData(m_scoreData)
        End If
    End With

End Sub


End Class

End Namespace
