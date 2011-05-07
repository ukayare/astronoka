﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public Boolean resfrag = false;//再起動フラグ
        public Boolean loadfrag = false;//ロードフラグ
        public Boolean finfrag = false;//終了フラグ
        public Boolean movefrag = false;//移動フラグ

        internal int mode = 0;//移動位置
        internal int hatakemax = 0;//畑の数
        internal baboo[] baboolist = new baboo[10];//バブーのリスト
        internal List<baboo> todaybaboo = new List<baboo>();//本日のバブー
        internal List<trap> pedrotrap = new List<trap>();//ペドロさんのトラップリスト
        internal List<seed> pedroseed = new List<seed>();//ペドロさんの種リスト


        music sound;

        //トラップの作成時とかそういうのに使う配列
        internal Boolean[] tlist = new Boolean[17];
        internal string[] tname = new string[] {"落とし穴"　,"フタ付き落とし穴",　"塀",　"扇風機",　"ジャンプ台",　"ぐるぐる台",
                    "冷水ぶっかけ装置",　"パンチングマシン",　"ビリビリマシン",　"風船サービス装置",
                "米俵サービス装置",　"おめでとう装置",　"エサ",　"カカシ",　"オリ",　"とりもち","怪光線"};

        
        //再起動
        private void buttitle_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("タイトルに戻りますか？", "タイトル", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                resfrag = true;
                movefrag = false;
                Application.Restart();
            }
        }

        //ロード時
        private void Form3_Load(object sender, EventArgs e)
        {
            //中央表示
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;

            //ニューゲーム？
            if (loadfrag == false)
            {
                date.day = 1;
                date.month = 1;
                date.year = 1;
                date.week = "（月）";
                date.season = "春";
                date.money = 200;
                date.fin = 0;
                date.electmax = 1000;
                date.elect = 0;

                motimono.syoki(2,0,3);
                syokiset();

                motimono.todaybaboo.Add(motimono.syokibaboo());
            }
      
            this.datelabel.Text = date.year + "年目 " + date.month + "月 " + date.day + "日" + date.week + date.season;
            //この辺はデバッグ用の金増やし
            //moneychanged(0);
            //finchanged(0);
            this.namelabel.Text = "名前：" + date.name;
            this.moneylabel.Text = "羽：" + date.fin + "枚" + date.money + "z";

            musicstart();
        }

        //再起動
        private void restart_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("再起動しますか？", "再起動", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                resfrag = true;
                movefrag = false;
                Application.Restart();
            }
        }

        //終了
        private void finish_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //終了時
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (resfrag == false)
            {
                e.Cancel = MessageBox.Show("終了しますかあ？", "終了", MessageBoxButtons.YesNo) == DialogResult.No;
                movefrag = false;
            }
        }

        //セーブ
        private void butsave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("セーブしますか？", "セーブ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (System.IO.File.Exists("save\\date.xml"))//ファイルが存在してるときは上書き確認
                    if (MessageBox.Show("セーブデータを上書きしてもよろしいですか？", "セーブデータ上書き", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        save();
                if (!System.IO.Directory.Exists("save\\"))
                {
                    System.IO.Directory.CreateDirectory("save\\");
                    save();
                }
            }
        }

        //ロード
        private void butload_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ロードしますか？", "ロード", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //データを上書き
                load();
                loadfrag = true;
                this.datelabel.Text = date.year + "年目 " + date.month + "月 " + date.day + "日" + date.week + date.season;
                moneychanged(0);
                finchanged(0);
                this.namelabel.Text="名前："+date.name;
                movefrag = false;
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        //終了
        private void finbut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //セーブ
        private void MenuItemsave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("セーブしますか？", "セーブ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                save();
            }
        }

        //ロード
        private void MenuItemload_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ロードしますか？", "ロード", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                load();
                loadfrag = true;
                this.datelabel.Text = date.year + "年目 " + date.month + "月 " + date.day + "日" + date.week + date.season;
                moneychanged(0);
                finchanged(0);
                this.namelabel.Text = "名前：" + date.name;
            }
        }

        //おうちへ
        private void newgame_Click(object sender, EventArgs e)
        {
            musicstop();
            this.Hide();
            home home = new home();
            home.pointer = this;
            home.ShowDialog();
            this.Show();
            musicstart();
        }

        //バスで移動
        private void button3_Click(object sender, EventArgs e)
        {
            busmove busmove = new busmove();
            busmove.pointer = this;
            musicstop();
            busmove.ShowDialog();
            movefrag = true;
            resfrag = true;
            while (movefrag == true)//自宅に戻るまでループ
            {
                //どこに移動するかの選択
                switch (mode)
                {
                    case 0://自宅
                        movefrag = false;
                        this.Show();
                        break;
                    case 1://テンガロン
                        tengaron tengaron = new tengaron();
                        tengaron.pointer = this;
                        this.Hide();
                        tengaron.ShowDialog();
                        break;
                    case 2://パンタロン
                        pantaron pantaron = new pantaron();
                        pantaron.pointer = this;
                        this.Hide();
                        pantaron.ShowDialog();
                        break;
                    case 3://ソンブレロ
                        sonbrelo sonbrelo = new sonbrelo();
                        sonbrelo.pointer = this;
                        this.Hide();
                        sonbrelo.ShowDialog();
                        break;
                    case 4://アストロドーム
                        astrodome astrodome = new astrodome();
                        astrodome.pointer = this;
                        this.Hide();
                        astrodome.ShowDialog();
                        break;
                }
            }

            if (finfrag == true)
                Application.Exit();

            resfrag = false;
            musicstart();
        }

        //初期シマイモ増産（デバッグ用
        private void button5_Click(object sender, EventArgs e)
        {
            motimono.syoki(2, 0,1);
            //MessageBox.Show(s.sum.ToString());
        }

        //星株増産（デバッグ
        private void button6_Click(object sender, EventArgs e)
        {
            motimono.syoki(4, 0, 1);
        }

        //スイカタワー
        private void button7_Click(object sender, EventArgs e)
        {
            motimono.syoki(150, 1, 1);
        }

        //穴ほうれんそう
        private void button8_Click(object sender, EventArgs e)
        {
            motimono.syoki(7, -1, 1);
        }

        //畑へ
        private void buthatake_Click(object sender, EventArgs e)
        {
            hatake hatake = new hatake();
            hatake.pointer = this;
            this.Hide();
            musicstop();
            hatake.ShowDialog();
            this.Show();
            musicstart();
        }

        //ニューゲーム時の初期種配布
        public void syokiset()
        {
            seed s = new seed();
            s.baseset(2, 0);
            pedroseed.Add(s);
            motimono.seedsort();
            s = new seed();
            s.baseset(4, 0);
            pedroseed.Add(s);
            motimono.seedsort();

            pedrotrapset(4, 0);
            pedrotrapset(5, 0);
            pedrotrapset(5, 1);
            pedrotrapset(13, 0);
        }

        //ペドロさんの店にトラップ追加
        public void pedrotrapset(int t, int g)
        {
            trap strap = new trap(t, g);
            pedrotrap.Add(strap);
        }

        //ペドロ呼ぶ
        private void butped_Click(object sender, EventArgs e)
        {
            prdro pedro = new prdro();
            pedro.pointer = this;
            musicstop();
            pedro.ShowDialog();
            musicstart();
        }

        //トラップ配置
        private void trapb_Click(object sender, EventArgs e)
        {
            this.Hide();
            trapfield trapb = new trapfield();
            trapb.pointer = this;
            musicstop();
            trapb.ShowDialog();
            this.Show();
            musicstart();
        }


        private void musicstart()
        {
            if (date.season == "春")
                sound = new music("music\\spring.mp3");
            else if (date.season == "夏")
                sound = new music("music\\summer.mp3");
            else if (date.season == "秋")
                sound = new music("music\\autumn.mp3");
            else if (date.season == "冬")
                sound = new music("music\\winter.mp3");

            sound.start();
        }
        private void musicstop()
        {
            sound.stop();
            sound.Dispose();
        }

        //ニューゲーム時の処理
        private void Form3_Shown(object sender, EventArgs e)
        {
            if (loadfrag == false)
            {
                text st = new text("start", "peet");
                st.ShowDialog();
                hatake hatake = new hatake();
                hatake.pointer = this;
                this.Hide();
                musicstop();
                hatake.ShowDialog();
                this.Show();
                musicstart();
            }

        }

        //トラップ生産（デバッグ
        private void button1_Click(object sender, EventArgs e)
        {
            trap t= new trap(4,0);
            motimono.gettrap(t, 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 17; i++)
            {
                trap t = new trap(i, 0);
                motimono.gettrap(t, 3);
            }
        }

        //トラップのフラグ立て
        public void trapsearch()
        {
            for (int j = 0; j < tlist.Length; j++)
                tlist[j] = false;

            for (int j = 0; j < tlist.Length; j++)
                if (motimono.traplist.Exists(t => t.type == j))
                    tlist[j] = true;
        }

        //バトルフィールド
        private void butbattle_Click(object sender, EventArgs e)
        {
            trapbattle tb = new trapbattle();
            tb.pointer = this;
            musicstop();
            this.Hide();
            tb.ShowDialog();
            musicstart();
            this.Show();
        }
    }
}
