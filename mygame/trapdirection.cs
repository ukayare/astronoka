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
    //トラップの方向決定
    public partial class trapdirection : Form
    {
        //コンストラクタでは設置するトラップをおく座標
        public trapdirection(trap t,int x,int y)
        {
            InitializeComponent();
            this.settrap = t;
            this.x = x;
            this.y = y;
        }

        trap settrap;//設置するトラップ
        PictureBox[,] piclist = new PictureBox[5,5];//座標の画像（設置周囲２マス
        Boolean[,] setenable = new Boolean[5, 5];//方向設定可能かどうか

        //座標
        int x;
        int y;

        internal trapfield pointer;//ぽいんた

        private void butclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void trapdirection_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;

            piclistset();
            directselect();
        }

        //設置可能な部分の画像をセット
        private void enablepicset(int i,int j)
        {
            if (x + i > -1 && y + j < 0 && x + i < 9)//はみ出していない場合
            {
                piclist[2 + i, 2 + j].Image = global::WindowsFormsApplication1.Properties.Resources.direct;
                setenable[2 + i, 2 + j] = true;
            }
            else if (motimono.tfield[x + i, y + j] == null)//何もない場合
            {
                piclist[2 + i, 2 + j].Image = global::WindowsFormsApplication1.Properties.Resources.direct;
                setenable[2 + i, 2 + j] = true;
            }
            else if (motimono.tfield[x + i, y + j].kotei == false)//その部分のトラップが固定物じゃない場合
            {
                if (motimono.tfield[x + i, y + j].direct == true)//方向設置か
                    piclist[2 + i, 2 + j].ImageLocation = "trap\\" + motimono.tfield[x + i, y + j].type + motimono.tfield[x + i, y + j].grade + motimono.tfield[x + i, y + j].direction + "a.bmp";
                else
                    piclist[2 + i, 2 + j].ImageLocation = "trap\\" + motimono.tfield[x + i, y + j].type + motimono.tfield[x + i, y + j].grade + "a.bmp";
                setenable[2 + i, 2 + j] = true;
            }

        }

        //設置方向のセット //type346789
        private void directselect()
        {
            for (int i = -2; i < 3; i++)
                for (int j = -2; j < 3; j++)
                {
                    if (x + i > -1 && y + j > -3 && x + i < 9 && y + j < 9)//はみ出してないか
                    {
                        //MessageBox.Show((x+i).ToString() + (y+j+2).ToString());
                        if (i == 0 && j == 0)//中心は配置トラップ
                            piclist[2 + i, 2 + j].ImageLocation = "trap\\" + settrap.type + settrap.grade + ".bmp";
                        else
                        {
                                piclist[2 + i, 2 + j].Image = this.pointer.piclist[x + i, y + j + 2].Image;//デフォルトでもとの画像を配置
                        }
                        if (settrap.type == 4)//ジャンプ台
                        {
                            if (settrap.grade < 2 && (Math.Abs(i) == 1 && Math.Abs(j) == 1))//普通の
                            {
                                enablepicset(i, j);
                            }
                            //桂馬R
                            else if (settrap.grade >= 2 && settrap.grade < 4 && ((Math.Abs(i) == 2 && Math.Abs(i + j) == 1) || (Math.Abs(i + j) == 3 && Math.Abs(j) == 2)))
                            {
                                enablepicset(i, j);
                            }
                            //桂馬L
                            else if (settrap.grade >= 4 && settrap.grade < 6 && ((Math.Abs(j) == 2 && Math.Abs(i + j) == 1) || (Math.Abs(i + j) == 3 && Math.Abs(i) == 2)))
                            {
                                enablepicset(i, j);
                            }
                        }
                        else if (settrap.type == 13)//カカシ
                        {

                        }
                        //パンチングとかその他の方向とラップ
                        else if ((settrap.type == 3 || (settrap.type > 5 && settrap.type < 12) || settrap.type == 13) && (y + j < 0 || motimono.trapenable[x + i, y + j] == 0))
                        {
                            if (Math.Abs(i + j) == 1 && (i == 0 || j == 0))
                            {
                                enablepicset(i, j);
                            }
                        }
                    }
                }
        }

        //配列としてpictureboxをセット
        private void piclistset()
        {
            piclist[0, 0] = pictureBox1;
            piclist[1, 0] = pictureBox2;
            piclist[2, 0] = pictureBox3;
            piclist[3, 0] = pictureBox4;
            piclist[4, 0] = pictureBox5;
            piclist[0, 1] = pictureBox6;
            piclist[1, 1] = pictureBox7;
            piclist[2, 1] = pictureBox8;
            piclist[3, 1] = pictureBox9;
            piclist[4, 1] = pictureBox10;
            piclist[0, 2] = pictureBox11;
            piclist[1, 2] = pictureBox12;
            piclist[2, 2] = pictureBox13;
            piclist[3, 2] = pictureBox14;
            piclist[4, 2] = pictureBox15;
            piclist[0, 3] = pictureBox16;
            piclist[1, 3] = pictureBox17;
            piclist[2, 3] = pictureBox18;
            piclist[3, 3] = pictureBox19;
            piclist[4, 3] = pictureBox20;
            piclist[0, 4] = pictureBox21;
            piclist[1, 4] = pictureBox22;
            piclist[2, 4] = pictureBox23;
            piclist[3, 4] = pictureBox24;
            piclist[4, 4] = pictureBox25;
        }

        

        //配置方向の決定
        private void directdecide(int i,int x,int y)
        {
            if (setenable[x, y] == true)//設置のフラグを立てて閉じる
            {
                this.pointer.direction = i;
                this.pointer.flag = true;
                this.Dispose();
            }
        }
        
        //各座標での設置イベント
        private void pictureBox18_Click(object sender, EventArgs e)
        {
            directdecide(0, 2, 3);
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            directdecide(0, 1, 4);
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            directdecide(0, 3, 4);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            directdecide(1, 3, 2);
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            directdecide(1, 4, 3);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            directdecide(1, 4, 1);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            directdecide(2, 2, 1);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            directdecide(2, 3, 0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            directdecide(2, 1, 0);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            directdecide(3, 1, 2);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            directdecide(3, 0, 1);
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            directdecide(3, 0, 3);
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            directdecide(0, 3, 3);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            directdecide(1, 3, 1);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            directdecide(2, 1, 1);
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            directdecide(3, 1, 3);
        }        
    }
}
