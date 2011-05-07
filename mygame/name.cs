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
    //ニューゲームでの名前を決めるとこ
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public title pointer = new title();//ポインタ（指しとかないと保存できない

        music sound;
        
        //閉じる
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        //ロード
        private void Form2_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;

            musicstart();
        }

        //名前を入力したら即記憶
        private void namebox_TextChanged(object sender, EventArgs e)
        {
            pointer.name = this.namebox.Text;
        }

        //決定ボタン
        private void butdecide_Click(object sender, EventArgs e)
        {
            if (pointer.name!=null)
            {
                if (MessageBox.Show("名前：" + pointer.name + "でよろしいですか？", "名前の確認", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    musicstop();
                    this.Dispose();
                }
            }
            else//テキストボックスが空っぽ
                MessageBox.Show("名前を入力してください");
        }

        private void butret_Click(object sender, EventArgs e)
        {
            pointer.retfrag = true;
            musicstop();
            this.Dispose();
        }

        private void musicstop()
        {
            sound.stop();
            sound.Dispose();
        }
        private void musicstart()
        {
            sound = new music("music\\name.mp3");
            sound.start();
        }

    }
}
