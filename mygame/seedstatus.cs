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
    //種情報の表示
    public partial class seedstatus : Form
    {
        public seedstatus(seed se)
        {
            InitializeComponent();
            this.s = se;
        }

        public seed s;


        private void butclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //ロード時に情報を出して表示させておく
        private void seedstatus_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;

            this.namelabel.Text = s.finname;
            int l = s.info.Length;
            for (int i = 0; i < s.info.GetLength(0); i++)
            {
                if (i < 6)//隠し属性じゃない
                    elelabel.Text += s.element[i];
                levlabel.Text += s.elename[i] + "\n";

                if (i >= 6 && (s.mut1 - 1 == i || s.mut2 - 1 == i || s.element[i] != 40))//隠し属性の場合は４０以外なら表示する
                {
                    elelabel.Text += s.element[i];

                    if (i == 6)
                        this.label1.Text += "形状";
                    if (i == 7)
                        this.label1.Text += "風味";
                    if (i == 8)
                        this.label1.Text += "匂い";
                    if (i == 9)
                        this.label1.Text += "音色";
                }
                for (int j = 0; j < l / s.info.GetLength(0); j++)//遺伝情報の表示
                {
                    if (i < 6)
                    {
                        if (s.info[i, j] == true)
                            this.infolabel.Text += "○";
                        else
                            this.infolabel.Text += "×";
                    }
                    else
                    {
                        if (s.element[i] != 40 || s.mut1 - 1 == i || s.mut2 - 1 == 1)
                        {
                            if (s.info[i, j] == true)
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

            //価格とかを表示
            this.plabel.Text = "基本価格" + s.basep + "z\nボーナス" + s.bonusp + "z\n価格" + s.price + "z";
            this.label2.Text="完全成熟まで"+s.grow+"日かかります";
        }
    }
}
