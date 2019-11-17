Imports System.Windows.Forms
Imports Produire ' utopiat.Host.dllを参照すること

' コントロール部品の種類の例
Public Class 部品サンプル
    Inherits Button ' 1. Control型であるクラスを継承する
    Implements IProduireClass ' 2. これを実装しないとプロデルから利用できない

    Public Sub New()
        Text = "プラグインボタン"
    End Sub

    ' Control型の基本的なメソッドとプロパティは、
    ' リファレンスにある「部品の基本形」ものから利用できる
End Class