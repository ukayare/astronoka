using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    //畑の説明
    public partial class hatakeex : Form
    {
        public hatakeex()
        {
            InitializeComponent();
        }

        text t;//説明表示用のやつ

        //ロード
        private void hatakeex_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }

        //閉じる
        private void butclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //以下各ボタンをクリックしたらそれぞれに対応したファイルを読み込んで表示
        private void buttane_Click(object sender, EventArgs e)
        {
            t = new text("tanemaki","peet");
            t.ShowDialog();
        }

        private void butyasai_Click(object sender, EventArgs e)
        {
            t = new text("seityou", "peet");
            t.ShowDialog();
        }

        private void butget_Click(object sender, EventArgs e)
        {
            t = new text("syuukaku", "peet");
            t.ShowDialog();
        }
    }
}
