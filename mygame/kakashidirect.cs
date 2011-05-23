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
    public partial class kakashidirect : Form
    {
        public kakashidirect(trap t)
        {
            InitializeComponent();
            this.settrap = t;
            picset();
        }

        //コンストラクタでは設置するトラップをおく座標
        trap settrap;//設置するトラップ

        internal trapfield pointer;//ぽいんた

        private void butclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void kakashidirect_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }
        

        //配置方向の決定
        private void directdecide(int i)
        {
            this.pointer.direction = i;
            this.pointer.flag = true;
            this.Dispose();
        }

        private void picset()
        {
            pictureBox1.ImageLocation = "trap\\kakashi" + settrap.grade + "0.bmp";
            pictureBox2.ImageLocation = "trap\\kakashi" + settrap.grade + "1.bmp";
            pictureBox3.ImageLocation = "trap\\kakashi" + settrap.grade + "2.bmp";
            pictureBox4.ImageLocation = "trap\\kakashi" + settrap.grade + "3.bmp";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            directdecide(0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            directdecide(1);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            directdecide(2);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            directdecide(3);
        }
    }
}
