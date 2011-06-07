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
    //トラップバトル
    public partial class trapbattle : Form
    {
        public trapbattle()
        {
            InitializeComponent();
        }

        babooactive ba;


        private void butclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void trapbattle_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
            makepiclist();
            setpic();
        }

        //以下デバッグ用のトラップバトルの処理
        //バトル開始
        private void butstart_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < motimono.todaybaboo.Count; i++)
            {
                //今日のバブーからバブーを取得
                ba = new babooactive(motimono.todaybaboo[i], motimono.tfield);
                //                ba.start();
                //                motimono.baboolist.Add(ba.baboo);
                //座標表示(x,y,向き)
                this.label2.Text = ba.now.x.ToString() + "," + ba.now.y.ToString() + "," + ba.direction.ToString();
                this.baboopic.ImageLocation = "baboo\\" + ba.baboo.specie + ba.baboo.variation + ba.direction + ".bmp";
                this.baboopic.Location = nowlocation(ba.now.x, ba.now.y);
            }
        }

        //トラップの起動判定
        private void traphappen()
        {
            if (motimono.tfield[ba.now.x, ba.now.y] != null)//踏むと起動するやつ
            {
                MessageBox.Show(motimono.tfield[ba.now.x, ba.now.y].name + "に引っかかった");
                ba.effect(motimono.tfield[ba.now.x, ba.now.y]);
            }
            else
            {
                int direct = (motimono.trapenable[ba.now.x, ba.now.y] - 2) % 4;//方向設定があるやつ（方向を取得
                switch (direct)
                {
                    //各方向が指す先の座標から起動
                    case 0:
                        effectpoint(ba.now.x, ba.now.y - 1);
                        break;
                    case 1:
                        effectpoint(ba.now.x - 1, ba.now.y);
                        break;
                    case 2:
                        effectpoint(ba.now.x, ba.now.y + 1);
                        break;
                    case 3:
                        effectpoint(ba.now.x + 1, ba.now.y);
                        break;
                }
            }
        }

        //座標引数で起動させる
        private void effectpoint(int x, int y)
        {
            MessageBox.Show(motimono.tfield[x, y].name + "に引っかかった");
            ba.effect(motimono.tfield[x, y]);//各トラップの効果はbabooactionを参照
        }

        //次の行動処理
        private void butnext_Click(object sender, EventArgs e)
        {
            MessageBox.Show(motimono.trapenable[ba.now.x, ba.now.y].ToString());
            if (motimono.tpoint[ba.now.x, ba.now.y] != null)
            {
                foreach (point p in motimono.tpoint[ba.now.x, ba.now.y].tplist)
                {
                    if (motimono.tfield[p.x, p.y].type == 12 && ba.happen[p.x, p.y] == false)
                    {
                        MessageBox.Show("エサ");
                        ba.esaeffect(p);
                        MessageBox.Show(ba.goalpoint.x.ToString() + ba.goalpoint.y.ToString());
                    }
                    else if (motimono.tfield[p.x, p.y].type == 13 && ba.happen[p.x, p.y] == false)
                    {
                        MessageBox.Show("カカシ");
                    }
                }
            }

            //触ったら起動するタイプが起動する場合
            if (ba.actioednfrag == true && ba.happen[ba.now.x, ba.now.y] == false)
            {
                traphappen();
            }
            /*普通に移動(条件は
                今いるところにとらっぷがない
                接触とラップの起動範囲
                トリモチに引っかかっていない状態
                一回起動の場合のトラップがもう起動している
                もう限界起動回数まで達している（１０回
                上記のいずれかをみたした場合
             */
            else if (motimono.trapenable[ba.now.x, ba.now.y] == 0 || motimono.trapenable[ba.now.x, ba.now.y] >= 6 || ba.torifrag == true || ba.happen[ba.now.x, ba.now.y] == true || ba.happeningcount[ba.now.x, ba.now.y] >= 10)
            {
                MessageBox.Show("");
                ba.move();
                if (ba.destruction == true)
                {
                    piclist[ba.destructpoint.x, ba.destructpoint.y + 2].Image = global::WindowsFormsApplication1.Properties.Resources._null;
                    ba.destruction = false;
                    ba.destructpoint = null;
                }
            }
            //扇風機起動しているとき
            else if (ba.sennpufrag == true && ba.happeningcount[ba.now.x, ba.now.y] < 10)
            {
                //足元にトラップがないまたは起動したトラップの場合
                if (motimono.trapenable[ba.now.x, ba.now.y] == 0 || ba.happen[ba.now.x, ba.now.y] == true)
                    ba.senpumove();
                //足元に起動するのがある場合扇風機のフラグ折って起動
                else
                {
                    ba.sennpufrag = false;
                    traphappen();
                }
            }
            //その他はそのままトラップ起動
            else
            {
                traphappen();
            }
            //座標表示（x,y,方向,滞在時間,起動回数）
            this.richTextBox1.Text += ba.now.x.ToString() + "," + ba.now.y.ToString() + "," + ba.direction.ToString() + "," + ba.staying[ba.now.x, ba.now.y] + "," + ba.happeningcount[ba.now.x, ba.now.y].ToString() + "," + ba.distance[ba.now.x, ba.now.y].ToString()+"\n";
            this.baboopic.ImageLocation = "baboo\\" + ba.baboo.specie + ba.baboo.variation + ba.direction + ".bmp";
            this.baboopic.Location =  nowlocation(ba.now.x,ba.now.y);
        }

        private System.Drawing.Point nowlocation(int x, int y)
        {
            System.Drawing.Point location = new System.Drawing.Point(this.tableLayoutPanel1.Location.X + this.piclist[ba.now.x, ba.now.y + 2].Location.X, this.tableLayoutPanel1.Location.Y + this.piclist[ba.now.x, ba.now.y + 2].Location.Y);
            return location;
        }
    }

}
