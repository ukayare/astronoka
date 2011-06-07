using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    //バトル用の画像設置
    public partial class trapbattle : Form
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
        private void setpic()
        {
            int l = piclist.GetLength(0);
            for (int j = 0; j < piclist.Length / l; j++)
            {
                for (int i = 0; i < l; i++)
                {
                    if (j < 2 || motimono.tfield[i, j - 2] == null)
                    {
                    }
                    else if (motimono.tfield[i, j - 2].direct == false)
                    {
                        //piclist[i,j].Image = null;
                        piclist[i, j].ImageLocation = "trap\\" + motimono.tfield[i, j - 2].type + motimono.tfield[i, j - 2].grade + ".bmp";
                    }
                    else
                        piclist[i, j].ImageLocation = "trap\\" + motimono.tfield[i, j - 2].type + motimono.tfield[i, j - 2].grade + motimono.tfield[i, j - 2].direction + ".bmp";

                }
            }
        }
    }
}
