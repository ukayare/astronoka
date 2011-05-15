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
    //アストロドーム
    public partial class astrodome : Form
    {
        public astrodome()
        {
            InitializeComponent();
        }

        Boolean resfrag = false;//再起動フラグ

        music sound;//音楽用のクラス

        //再起動ボタン
        private void restart_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("再起動しますか？", "再起動", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {//押したら再起動
                resfrag = true;
                Flag.movefrag = false;
                Application.Restart();

            }
        }

        //終了ボタン
        private void finish_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //画面起動時の処理
        private void astrodome_Load(object sender, EventArgs e)
        {
            //中央に表示
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;

            //金とか年月とか名前とか表示
            this.datelabel.Text = date.year + "年目 " + date.month + "月 " + date.day + "日" + date.week + date.season;
            this.moneylabel.Text = "羽：" + date.fin + "枚" + date.money + "z";
            this.namelabel.Text = "名前：" + date.name;

            //音楽再生
            musicstart();
        }

        //閉じるときの処理
        private void astrodome_FormClosing(object sender, FormClosingEventArgs e)
        {
            //再起動フラグ長いときに閉じるなら終了確認
            if (resfrag == false)
            {
                e.Cancel = MessageBox.Show("終了しますかえ？", "終了", MessageBoxButtons.YesNo) == DialogResult.No;
                if (e.Cancel == false)
                {
                    Flag.finfrag = true;
                    Flag.movefrag = false;
                }
            }
        }

        //バス移動
        private void butbus_Click(object sender, EventArgs e)
        {
            musicstop();//音楽停止
            busmove busmove = new busmove();
            busmove.ShowDialog();
            Flag.movefrag = true;
            resfrag = true;
            this.Dispose();
        }

        //音楽関係
        private void musicstop()
        {
            sound.stop();
            sound.Dispose();
        }
        private void musicstart()
        {
            sound = new music("music\\astrodome.mp3");
            sound.start();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        
    }
}
