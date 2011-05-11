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
    //町のベースとなるクラス（ぶっちゃけレイアウトとかその辺の処理めんどいから統一した
    public partial class townbase : Form
    {
        
        Boolean resfrag = false;
        public Form3 pointer = new Form3();

        music sound;

        public string mpath;

        public townbase()
        {
        }
        protected void restart_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("再起動しますか？", "再起動", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                resfrag = true;
                motimono.movefrag = false;
                Application.Restart();

            }
        }

        protected void finish_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected void townbase_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;

            this.datelabel.Text = date.year + "年目 " + date.month + "月 " + date.day + "日" + date.week + date.season;
            this.moneylabel.Text = "羽：" + date.fin + "枚" + date.money + "z";
            this.namelabel.Text = "名前：" + date.name;

            musicstart();
        }

        protected void townbase_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (resfrag == false)
            {
                e.Cancel = MessageBox.Show("終了しますかえ？", "終了", MessageBoxButtons.YesNo) == DialogResult.No;
                if (e.Cancel == false)
                {
                    motimono.finfrag = true;
                    motimono.movefrag = false;
                }
            }
        }

        protected void butbus_Click(object sender, EventArgs e)
        {
            musicstop();
            busmove busmove = new busmove();
            busmove.ShowDialog();
            motimono.movefrag = true;
            resfrag = true;
            this.Dispose();
        }

        protected void butnameset(string but1, string but2, string but3, string but4)
        {
            this.button1.Text = but1;
            this.button2.Text = but2;
            this.button3.Text = but3;
            this.button4.Text = but4;
        }


        protected virtual void butcon_Click(object sender, EventArgs e)
        {
        }
        protected virtual void butua_Click(object sender, EventArgs e)
        {
        }
        protected virtual void button1_Click(object sender, EventArgs e)
        {
        }
        protected virtual void button2_Click(object sender, EventArgs e)
        {
        }
        protected virtual void button3_Click(object sender, EventArgs e)
        {
        }
        protected virtual void button4_Click(object sender, EventArgs e)
        { 
        }

        private void musicstart()
        {
            sound = new music(mpath);
            sound.start();
        }
        private void musicstop()
        {
            sound.stop();
            sound.Dispose();
        }

    }
}