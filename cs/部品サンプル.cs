using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Produire;

namespace RdrPluginSample
{
	// コントロール部品の種類の例
	public class 部品サンプル : Button, IProduireClass
	{
		// 1. Control型であるクラスを継承する
		// 2. IProduireClassを実装しないとプロデルから利用できない

		public 部品サンプル()
		{
			Text = "プラグインボタン";
		}

		// Control型の基本的なメソッドとプロパティは、
		// リファレンスにある「部品の基本形」ものから利用できる
	}
}
