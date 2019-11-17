Imports System.Windows.Forms
Imports Produire ' utopiat.Host.dllを参照すること

' プラグインの情報
<Assembly: PluginName("プラグインサンプル")> 
<Assembly: PluginDescription("プラグインのサンプルです")> 
<Assembly: PluginVersion("1.0")> 
<Assembly: PluginAcceptVersion("1.0")> 

' 静的種類の例
Public Class 静的型サンプル
	Implements IProduireStaticClass	' これを実装しないとプロデルから利用できない

	' 手順
	<自分("で")> _
	Public Sub テストする(<を()> ByVal 名前 As String)
		MessageBox.Show(名前 + "さん、こんにちは！")
	End Sub

End Class

' 生成可能な種類の例
Public Class 生成型サンプル
	Implements IProduireClass ' これを実装しないとプロデルから利用できない

	Private MyName As String

	Public Sub New()
		MyName = "名無し"
	End Sub

	Public Sub New(ByVal 名前 As String)
		MyName = 名前
	End Sub

	' 手順
	<自分("が")> _
	Public Sub 挨拶する()
		MessageBox.Show(名前 + "さん、こんにちは！")
	End Sub

	' 設定項目
	Public Property 名前()
		Get
			Return MyName
		End Get
		Set(ByVal value)
			MyName = value
		End Set
	End Property
End Class

