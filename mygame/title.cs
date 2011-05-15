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
    //タイトル画面
    public partial class title : Form
    {
        public title()
        {
            InitializeComponent();
        }


        Boolean resfrag = false;//再起動
        public string name;//入力した名前
        public Form3 form3 = new Form3();//メイン画面
        public Boolean finfrag = false;//終了
        public Boolean retfrag=false;//戻る
        music sound;
        
        //再起動
        private void restart_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("再起動しますか？", "再起動", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                resfrag = true;
                Application.Restart();
            }
        }

        //ロード
        private void Form1_Load(object sender, EventArgs e)
        {
            musicstart();
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
            
        }

        //終了
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (resfrag == false)
            {
                e.Cancel = MessageBox.Show("終了しますか？", "終了", MessageBoxButtons.YesNo) == DialogResult.No;
                if (e.Cancel == false)
                {
                    finfrag = true;
                }
            }
        }

        //終了
        private void finish_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //ニューゲーム
        private void newgame_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();//名前入力
            form2.pointer = this;
            musicstop();

            form2.ShowDialog();
            if (retfrag == false)//入力して始めるか
            {
                date.name = name;
                MessageBox.Show("あなたの名前は" + date.name + "です。\nこれから頑張ってください");
                resfrag = true;
                form3.namelabel.Text = "名前：" + date.name;
                this.Dispose();
            }
            else
            {
                retfrag = false;
                musicstart();
            }
        }

        private void butend_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //コンテニュー
        private void butcontinue_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists("save\\date.xml"))
            {
                resfrag = true;
                Flag.loadfrag = true;
                //form3.ShowDialog();
                //this.Hide();
                musicstop();
                this.Close();
            }
            else
                MessageBox.Show("セーブデーが存在しません。\nニューゲームで始めてください");

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void musicstop()
        {
            sound.stop();
            sound.Dispose();
        }
        private void musicstart()
        {
            sound = new music("music\\title.mp3");
            sound.start();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
