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
    //野菜ステータス（畑
    public partial class vagstatus : Form
    {
        public vagstatus(vagetable ve)
        {
            InitializeComponent();
            this.v = ve;
        }

        public vagetable v;
        internal Boolean get = false;//収穫フラグ


        private void butclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //ロード
        private void vagstatus_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;

            //基本的に種情報のときを同じ記述（日数とかも追加してある
            this.namelabel.Text = v.finname;
            this.label2.Text = v.days + "日目";
            int l = v.info.Length;
            for (int i = 0; i < v.info.GetLength(0); i++)
            {
                if (i < 6)
                    this.elelabel.Text += v.element[i];
                levlabel.Text += v.elename[i] + "\n";

                if (i >= 6 && (v.mut1 - 1 == i || v.mut2 - 1 == i || v.element[i] != 40))
                {
                    this.elelabel.Text += v.element[i];
                    if (i == 6)
                        this.label1.Text += "形状";
                    if (i == 7)
                        this.label1.Text += "風味";
                    if (i == 8)
                        this.label1.Text += "匂い";
                    if (i == 9)
                        this.label1.Text += "音色";
                }
                for (int j = 0; j < l / v.info.GetLength(0); j++)
                {
                    if (i < 6)
                    {
                        if (v.info[i, j] == true)
                            this.infolabel.Text += "○";
                        else
                            this.infolabel.Text += "×";
                    }
                    else
                    {
                        if (v.element[i] != 40 || v.mut1 - 1 == i || v.mut2 - 1 == 1)
                        {
                            if (v.info[i, j] == true)
                                this.infolabel.Text += "○";
                            else
                                this.infolabel.Text += "×";
                        }
                    }

                }
                this.infolabel.Text += "\n";
                this.elelabel.Text += "\n";
                if (i >= 5)
                    this.label1.Text += "\n";
            }

            //成長状態の表示
            switch (v.mat)
            {
                case 0:
                    this.label3.Text = "発芽前";
                    break;
                case 1:
                    this.label3.Text = "発芽中";
                    break;
                case 2:
                    this.label3.Text = "成長中";
                    break;
                case 3:
                    this.label3.Text = "成熟";
                    break;
                case 4:
                    this.label3.Text = "種1つ";
                    break;
                case 5:
                    this.label3.Text = "種2つ";
                    break;
                case 6:
                case 7:
                    this.label3.Text = "種3つ";
                    break;
                case 8:
                    this.label3.Text = "枯れてます";
                    break;

            }

            //イメージの取得
            this.vagpic.ImageLocation = v.imagepath();

            //収穫かどうかのチェック
            if (v.mat > 2 && v.mat < 8)
            {
                butget.Text = "収穫";
            }
            else
            {
                butget.Text = "整地";
            }
        }

        //収穫ボタン
        private void butget_Click(object sender, EventArgs e)
        {
            get = true;//フラグたて
            this.Close();
        }        
    }
}
