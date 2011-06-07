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
    //おうち
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }


        music sound;

        private void restart_Click(object sender, EventArgs e)
        {

        }

        private void finish_Click(object sender, EventArgs e)
        {

        }

        private void butreturn_Click(object sender, EventArgs e)
        {
            musicstop();
            this.Dispose();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void home_Load_1(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;

            this.datelabel.Text = date.datedisplay;
            this.moneylabel.Text = date.moneyfindisplay;
            this.namelabel.Text = "名前：" + date.name;

            musicstart();
        }

        //交配マシンへ
        private void butmix_Click(object sender, EventArgs e)
        {
            this.Hide();
            kouhai kouhai = new kouhai();
            musicstop();
            kouhai.ShowDialog();
            this.Show();
            musicstart();
        }

        //持ち物リストへ
        private void butitem_Click(object sender, EventArgs e)
        {
            itemlist il = new itemlist();
            il.ShowDialog();
        }

        private void musicstart()
        {
            if (date.season == "春")
                sound = new music("music\\homespring.mp3");
            else if (date.season == "夏")
                sound = new music("music\\homesummer.mp3");
            else if (date.season == "秋")
                sound = new music("music\\homeautumn.mp3");
            else if (date.season == "冬")
                sound = new music("music\\homewinter.mp3");

            sound.start();
        }
        private void musicstop()
        {
            sound.stop();
            sound.Dispose();
        }

        private void home_FormClosing(object sender, FormClosingEventArgs e)
        {
            musicstop();
        }

        //ピートに話す
        private void button1_Click(object sender, EventArgs e)
        {
            text t = new text("test","");
            t.ShowDialog();
        }

        private void butend_Click(object sender, EventArgs e)
        {
            astronet an = new astronet();
            this.Hide();
            musicstop();
            an.ShowDialog();
            this.Show();
            musicstart();

        }

        private void butcontinue_Click(object sender, EventArgs e)
        {
            calendar c=new calendar();
            c.ShowDialog();
        }

    }
}
