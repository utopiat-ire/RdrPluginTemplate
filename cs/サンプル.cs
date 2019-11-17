using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Produire; // utopiat.Host.dllを参照すること

namespace RdrPluginSample
{
	// 静的種類の例
	public class 静的型サンプル : IProduireStaticClass // これを実装しないとプロデルから利用できない
	{
		// 手順
		[自分("で")]
		public void テストする([を]string 名前)
		{
			MessageBox.Show(名前 + "さん、こんにちは！");
		}
	}

	// 生成可能な種類の例
	public class 生成型サンプル : IProduireClass // これを実装しないとプロデルから利用できない
	{
		private string name;

		public 生成型サンプル()
		{
			name = "名無し";
		}
		public 生成型サンプル(string 名前)
		{
			this.name = 名前;
		}

		// 手順
		[自分("が")]
		public void 挨拶する()
		{
			MessageBox.Show(name + "さん、こんにちは！");
		}

		// 設定項目
		public string 名前
		{
			get { return name; }
			set { name = value; }
		}
	}
}
