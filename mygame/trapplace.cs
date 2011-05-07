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
    //各pictureboxのイベントを収納ラッパーしてるんで得にいじる必要なし
    public partial class trapfield : Form
    {
        internal PictureBox[,] piclist = new PictureBox[9, 11];
        private void makepiclist()
        {
            piclist[0, 0] = pictureBox1;
            piclist[1, 0] = pictureBox2;
            piclist[2, 0] = pictureBox3;
            piclist[3, 0] = pictureBox4;
            piclist[4, 0] = pictureBox5;
            piclist[5, 0] = pictureBox6;
            piclist[6, 0] = pictureBox7;
            piclist[7, 0] = pictureBox8;
            piclist[8, 0] = pictureBox9;
            piclist[0, 1] = pictureBox10;
            piclist[1, 1] = pictureBox11;
            piclist[2, 1] = pictureBox12;
            piclist[3, 1] = pictureBox13;
            piclist[4, 1] = pictureBox14;
            piclist[5, 1] = pictureBox15;
            piclist[6, 1] = pictureBox16;
            piclist[7, 1] = pictureBox17;
            piclist[8, 1] = pictureBox18;
            piclist[0, 2] = pictureBox19;
            piclist[1, 2] = pictureBox20;
            piclist[2, 2] = pictureBox21;
            piclist[3, 2] = pictureBox22;
            piclist[4, 2] = pictureBox23;
            piclist[5, 2] = pictureBox24;
            piclist[6, 2] = pictureBox25;
            piclist[7, 2] = pictureBox26;
            piclist[8, 2] = pictureBox27;
            piclist[0, 3] = pictureBox28;
            piclist[1, 3] = pictureBox29;
            piclist[2, 3] = pictureBox30;
            piclist[3, 3] = pictureBox31;
            piclist[4, 3] = pictureBox32;
            piclist[5, 3] = pictureBox33;
            piclist[6, 3] = pictureBox34;
            piclist[7, 3] = pictureBox35;
            piclist[8, 3] = pictureBox36;
            piclist[0, 4] = pictureBox37;
            piclist[1, 4] = pictureBox38;
            piclist[2, 4] = pictureBox39;
            piclist[3, 4] = pictureBox40;
            piclist[4, 4] = pictureBox41;
            piclist[5, 4] = pictureBox42;
            piclist[6, 4] = pictureBox43;
            piclist[7, 4] = pictureBox44;
            piclist[8, 4] = pictureBox45;
            piclist[0, 5] = pictureBox46;
            piclist[1, 5] = pictureBox47;
            piclist[2, 5] = pictureBox48;
            piclist[3, 5] = pictureBox49;
            piclist[4, 5] = pictureBox50;
            piclist[5, 5] = pictureBox51;
            piclist[6, 5] = pictureBox52;
            piclist[7, 5] = pictureBox53;
            piclist[8, 5] = pictureBox54;
            piclist[0, 6] = pictureBox55;
            piclist[1, 6] = pictureBox56;
            piclist[2, 6] = pictureBox57;
            piclist[3, 6] = pictureBox58;
            piclist[4, 6] = pictureBox59;
            piclist[5, 6] = pictureBox60;
            piclist[6, 6] = pictureBox61;
            piclist[7, 6] = pictureBox62;
            piclist[8, 6] = pictureBox63;
            piclist[0, 7] = pictureBox64;
            piclist[1, 7] = pictureBox65;
            piclist[2, 7] = pictureBox66;
            piclist[3, 7] = pictureBox67;
            piclist[4, 7] = pictureBox68;
            piclist[5, 7] = pictureBox69;
            piclist[6, 7] = pictureBox70;
            piclist[7, 7] = pictureBox71;
            piclist[8, 7] = pictureBox72;
            piclist[0, 8] = pictureBox73;
            piclist[1, 8] = pictureBox74;
            piclist[2, 8] = pictureBox75;
            piclist[3, 8] = pictureBox76;
            piclist[4, 8] = pictureBox77;
            piclist[5, 8] = pictureBox78;
            piclist[6, 8] = pictureBox79;
            piclist[7, 8] = pictureBox80;
            piclist[8, 8] = pictureBox81;
            piclist[0, 9] = pictureBox82;
            piclist[1, 9] = pictureBox83;
            piclist[2, 9] = pictureBox84;
            piclist[3, 9] = pictureBox85;
            piclist[4, 9] = pictureBox86;
            piclist[5, 9] = pictureBox87;
            piclist[6, 9] = pictureBox88;
            piclist[7, 9] = pictureBox89;
            piclist[8, 9] = pictureBox90;
            piclist[0, 10] = pictureBox91;
            piclist[1, 10] = pictureBox92;
            piclist[2, 10] = pictureBox93;
            piclist[3, 10] = pictureBox94;
            piclist[4, 10] = pictureBox95;
            piclist[5, 10] = pictureBox96;
            piclist[6, 10] = pictureBox97;
            piclist[7, 10] = pictureBox98;
            piclist[8, 10] = pictureBox99;
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            trapset(0, 0);
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            trapset(1, 0);
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            trapset(2, 0);
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            trapset(6, 0);
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            trapset(7, 0);
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            trapset(8, 0);
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            trapset(0, 1);
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            trapset(1, 1);
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            trapset(2, 1);
        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {
            trapset(6, 1);
        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {
            trapset(7, 1);
        }

        private void pictureBox36_Click(object sender, EventArgs e)
        {
            trapset(8, 1);
        }

        private void pictureBox37_Click(object sender, EventArgs e)
        {
            trapset(0, 2);
        }

        private void pictureBox38_Click(object sender, EventArgs e)
        {
            trapset(1, 2);
        }

        private void pictureBox39_Click(object sender, EventArgs e)
        {
            trapset(2, 2);
        }

        private void pictureBox40_Click(object sender, EventArgs e)
        {
            trapset(3, 2);
        }

        private void pictureBox41_Click(object sender, EventArgs e)
        {
            trapset(4, 2);
        }

        private void pictureBox42_Click(object sender, EventArgs e)
        {
            trapset(5, 2);
        }

        private void pictureBox43_Click(object sender, EventArgs e)
        {
            trapset(6, 2);
        }

        private void pictureBox44_Click(object sender, EventArgs e)
        {
            trapset(7, 2);
        }

        private void pictureBox45_Click(object sender, EventArgs e)
        {
            trapset(8, 2);
        }

        private void pictureBox46_Click(object sender, EventArgs e)
        {
            trapset(0, 3);
        }

        private void pictureBox47_Click(object sender, EventArgs e)
        {
            trapset(1, 3);
        }

        private void pictureBox48_Click(object sender, EventArgs e)
        {
            trapset(2, 3);
        }

        private void pictureBox49_Click(object sender, EventArgs e)
        {
            trapset(3, 3);
        }

        private void pictureBox50_Click(object sender, EventArgs e)
        {
            trapset(4, 3);
        }

        private void pictureBox51_Click(object sender, EventArgs e)
        {
            trapset(5, 3);
        }

        private void pictureBox52_Click(object sender, EventArgs e)
        {
            trapset(6, 3);
        }

        private void pictureBox53_Click(object sender, EventArgs e)
        {
            trapset(7, 3);
        }

        private void pictureBox54_Click(object sender, EventArgs e)
        {
            trapset(8, 3);
        }

        private void pictureBox55_Click(object sender, EventArgs e)
        {
            trapset(0, 4);
        }

        private void pictureBox56_Click(object sender, EventArgs e)
        {
            trapset(1, 4);
        }

        private void pictureBox57_Click(object sender, EventArgs e)
        {
            trapset(2, 4);
        }

        private void pictureBox58_Click(object sender, EventArgs e)
        {
            trapset(3, 4);
        }

        private void pictureBox59_Click(object sender, EventArgs e)
        {
            trapset(4, 4);
        }

        private void pictureBox60_Click(object sender, EventArgs e)
        {
            trapset(5, 4);
        }

        private void pictureBox61_Click(object sender, EventArgs e)
        {
            trapset(6, 4);
        }

        private void pictureBox62_Click(object sender, EventArgs e)
        {
            trapset(7, 4);
        }

        private void pictureBox63_Click(object sender, EventArgs e)
        {
            trapset(8, 4);
        }

        private void pictureBox64_Click(object sender, EventArgs e)
        {
            trapset(0, 5);
        }

        private void pictureBox65_Click(object sender, EventArgs e)
        {
            trapset(1, 5);
        }

        private void pictureBox66_Click(object sender, EventArgs e)
        {
            trapset(2, 5);
        }

        private void pictureBox67_Click(object sender, EventArgs e)
        {
            trapset(3, 5);
        }

        private void pictureBox68_Click(object sender, EventArgs e)
        {
            trapset(4, 5);
        }

        private void pictureBox69_Click(object sender, EventArgs e)
        {
            trapset(5, 5);
        }

        private void pictureBox70_Click(object sender, EventArgs e)
        {
            trapset(6, 5);
        }

        private void pictureBox71_Click(object sender, EventArgs e)
        {
            trapset(7, 5);
        }

        private void pictureBox72_Click(object sender, EventArgs e)
        {
            trapset(8, 5);
        }

        private void pictureBox73_Click(object sender, EventArgs e)
        {
            trapset(0, 6);
        }

        private void pictureBox74_Click(object sender, EventArgs e)
        {
            trapset(1, 6);
        }

        private void pictureBox75_Click(object sender, EventArgs e)
        {
            trapset(2, 6);
        }

        private void pictureBox76_Click(object sender, EventArgs e)
        {
            trapset(3, 6);
        }

        private void pictureBox77_Click(object sender, EventArgs e)
        {
            trapset(4, 6);
        }

        private void pictureBox78_Click(object sender, EventArgs e)
        {
            trapset(5, 6);
        }

        private void pictureBox79_Click(object sender, EventArgs e)
        {
            trapset(6, 6);
        }

        private void pictureBox80_Click(object sender, EventArgs e)
        {
            trapset(7, 6);
        }

        private void pictureBox81_Click(object sender, EventArgs e)
        {
            trapset(8, 6);
        }

        private void pictureBox82_Click(object sender, EventArgs e)
        {
            trapset(0, 7);
        }

        private void pictureBox83_Click(object sender, EventArgs e)
        {
            trapset(1, 7);
        }

        private void pictureBox84_Click(object sender, EventArgs e)
        {
            trapset(2, 7);
        }

        private void pictureBox88_Click(object sender, EventArgs e)
        {
            trapset(6, 7);
        }

        private void pictureBox89_Click(object sender, EventArgs e)
        {
            trapset(7, 7);
        }

        private void pictureBox90_Click(object sender, EventArgs e)
        {
            trapset(8, 7);
        }

        private void pictureBox91_Click(object sender, EventArgs e)
        {
            trapset(0, 8);
        }

        private void pictureBox92_Click(object sender, EventArgs e)
        {
            trapset(1, 8);
        }

        private void pictureBox93_Click(object sender, EventArgs e)
        {
            trapset(2, 8);
        }

        private void pictureBox97_Click(object sender, EventArgs e)
        {
            trapset(6, 8);
        }

        private void pictureBox98_Click(object sender, EventArgs e)
        {
            trapset(7, 8);
        }

        private void pictureBox99_Click(object sender, EventArgs e)
        {
            trapset(8, 8);
        }


        private void setpic()
        {
            int l=piclist.GetLength(0);
            for (int j = 0; j < piclist.Length / l; j++)
            {
                for (int i = 0; i < l; i++)
                {
                    if (j == 0)
                    {
                    }
                    else if (j == 1)
                    {
                    }
                    else if (motimono.tfield[i, j-2] == null)
                    {
                    }
                    else if (motimono.tfield[i, j - 2].direct==false)
                    {
                        //piclist[i,j].Image = null;
                        piclist[i, j].ImageLocation = "trap\\" + motimono.tfield[i, j - 2].type + motimono.tfield[i, j - 2].grade + ".bmp";
                    }
                    else
                        piclist[i, j].ImageLocation = "trap\\" + motimono.tfield[i, j - 2].type + motimono.tfield[i, j - 2].grade + motimono.tfield[i, j - 2].direction+".bmp";
                    
                }
            }
        }
    }
}
