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
    public partial class busmove : Form
    {
        public busmove()
        {
            InitializeComponent();
        }


        music sound;

        //ロード時の処理
        private void busmove_Load(object sender, EventArgs e)
        {
            //中央表示
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;

            musicstart();
        }

        //行き先選択で表示変更
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.distlabel.Text = "行き先：" + this.distlist.SelectedItem;
        }

        //フォーム閉じる
        private void butno_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //移動
        private void butgo_Click(object sender, EventArgs e)
        {
            if (this.distlist.SelectedIndex != -1)//選択しているかチェック
            {
                //行き先OKならフォームを開く準備して閉じる。同じ場合は何もしない
                if (MessageBox.Show(distlist.SelectedItem + "へ行きますか？", "行き先確認", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (motimono.mode != distlist.SelectedIndex)
                    {
                        motimono.mode = distlist.SelectedIndex;
                        this.Dispose();
                    }
                    else
                        MessageBox.Show("行き先は現在地です");
                }
            }
            else
                MessageBox.Show("行き先を選んでください");
        }

        private void musicstop()
        {
            sound.stop();
            sound.Dispose();
        }
        private void musicstart()
        {
            sound = new music("music\\bus.mp3");
            sound.start();
        }

        //閉じるときの処理
        private void busmove_FormClosing(object sender, FormClosingEventArgs e)
        {
            musicstop();
        }

    }
}
