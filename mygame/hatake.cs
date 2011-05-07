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
    //畑
    public partial class hatake : Form
    {
        public hatake()
        {
            InitializeComponent();
        }

        internal Form3 pointer = new Form3();//ポインタ
        seed s;//植える種
        seedstatus seedst;//種情報
        int hatanum = 0;//畑番号
        int num = 0;//区画
        PictureBox[] bagpic = new PictureBox[6];//野菜の画像表示
        Button[] but = new Button[6];//野菜のいろんな処理

        music sound;

        //閉じるボタン
        private void butclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //画面ロード
        private void hatake_Load(object sender, EventArgs e)
        {
            //中央表示
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;

            //配列にセットする
            bagpic[0] = this.bagpic1;
            bagpic[1] = this.bagpic2;
            bagpic[2] = this.bagpic3;
            bagpic[3] = this.bagpic4;
            bagpic[4] = this.bagpic5;
            bagpic[5] = this.bagpic6;

            but[0] = this.button1;
            but[1] = this.button2;
            but[2] = this.button3;
            but[3] = this.button4;
            but[4] = this.button5;
            but[5] = this.button6;

            //画像の貼り付け
            for (int i = 0; i < 6; i++)
            {
                hatapic(hatanum, i);
            }

            musicstart();            
        }

        //種の種類選択
        private void namebox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //選ばれてるか確認
            if (this.namebox1.SelectedItem != null)
            {
                List<seed> currentlist = new List<seed>();//一時的なリスト
                this.listBox1.Items.Clear();//いったん全消し
                //同じ種類のリストを取ってくる
                currentlist = motimono.seedlist.FindAll(s => s.name == this.namebox1.SelectedItem.ToString());
                foreach (seed s in currentlist)//種のリスト全回し
                    this.listBox1.Items.Add(s.finname);
            }
        }

        //種選択
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ちゃんと選ばれてるかチェック
            if (this.listBox1.SelectedIndex != -1 && this.listBox1.SelectedItem != null)
            {
                s = motimono.seedlist.Find(se => se.finname == this.listBox1.SelectedItem.ToString());
                this.label1.Text = s.items.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //種情報表示
        private void butst1_Click(object sender, EventArgs e)
        {
            //選ばれてるかチェック
            if (this.listBox1.SelectedIndex != -1 && this.listBox1.SelectedItem != null)
            {
                seedst = new seedstatus(s);
                seedst.ShowDialog();
            }
            else
                MessageBox.Show("種を選んでください");
        }

        //科の選択
        private void depbox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.depbox1.SelectedItem != null)//ちゃんと選ばれてるチェック
            {
                //いったんクリアーする
                this.listBox1.Items.Clear();
                this.namebox1.Items.Clear();
                int x = this.depbox1.SelectedIndex - 2;//科の値
                if (x == -2)//全てを選択
                    listboxset(motimono.seedlist);
                else
                {
                    List<seed> currentlist = new List<seed>();
                    currentlist = motimono.seedlist.FindAll(s => s.department == x);//選択した科のリストを取得
                    listboxset(currentlist);
                }
            }
        }

        //ボックスにセットする
        private void listboxset(List<seed> slist)
        {

            Boolean same = false;
            foreach (seed s in slist)
            {
                for (int j = 0; j < this.namebox1.Items.Count; j++)
                    //もうすでに種類が入っているならフラグ立てる
                    if (s.name == this.namebox1.Items[j].ToString())
                        same = true;
                //フラグ立ってないなら普通に種類追加
                if (same == false)
                    this.namebox1.Items.Add(s.name);
                same = false;

                //後はその種を追加
                listBox1.Items.Add(s.finname);
            }

        }

        //各区画のボタン（処理はhatakeset
        private void button1_Click(object sender, EventArgs e)
        {
            hatakeset(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hatakeset(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hatakeset(2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hatakeset(3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hatakeset(4);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hatakeset(5);
        }

        //リストボックスの初期化（最初は全てを選択していることになってる
        private void boxset()
        {
            this.listBox1.Items.Clear();
            this.namebox1.Items.Clear();
            foreach (seed s in motimono.seedlist)
            {
                this.listBox1.Items.Add(s.finname);
            }
            this.depbox1.SetSelected(0, true);
        }

        //種を植える処理
        private void hatakeset(int num)
        {
            //まず植わってるかを確認
            if (motimono.vaghatake[hatanum, num] == null)
            {
                if (this.listBox1.SelectedIndex != -1)
                {
                    vagetable v = new vagetable();//植える野菜を生成
                    if (s.strengp != 0)//今日歌手はだめ
                        MessageBox.Show("強化種は植えることはできません");
                    else if (s.season == 0
                        || (s.season == 1 && date.season == "春")
                        || (s.season == 2 && date.season == "夏")
                        || (s.season == 3 && date.season == "秋")
                        || (s.season == 4 && date.season == "冬"))//季節野菜もチェック
                    {
                        //植えるか確認
                        if (MessageBox.Show("植えてよろしいですか？", "確認", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            v.set(s);//植える種から野菜を生成
                            motimono.vaghatake[hatanum, num] = v;//植える
                            MessageBox.Show("完全成熟して種が3つできるまで\n" + v.grow + "日かかります");//成長日数を表示

                            //植えた分種を減らす
                            int find = motimono.seedlist.FindIndex(se => se == s);
                            motimono.seedlist[find].items--;
                            if (motimono.seedlist[find].items == 0)//０個になってたらリストから消去
                            {
                                motimono.seedlist.RemoveAt(find);
                            }

                            boxset();//リストボックス初期化
                            hatapic(hatanum, num);//画像を表示する
                        }
                    }
                    else//季節野菜のチェックにはじかれた
                        MessageBox.Show(date.season + "にこの野菜は植えることはできません");
                }
                else//そもそも種を選んでいない
                    MessageBox.Show("植える種を選んでください");
            }
            //なんか植わってるとき
            else
            {
                //植わってる野菜の情報を表示
                vagstatus vs = new vagstatus(motimono.vaghatake[hatanum, num]);
                vs.ShowDialog();

                //引き抜くフラグがたった
                if (vs.get == true)
                {
                    vagetable v = motimono.vaghatake[hatanum, num];
                    if (v.mat > 2 && v.mat < 8)//ちゃんと収穫できる状態
                    {
                        //収穫確認
                        if (MessageBox.Show("収穫します。\nよろしいですか？", "確認", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            int find = motimono.vaglist.FindIndex(getv => getv.yasaicheck(v));//もうその野菜あるかチェック

                            if(find!=-1)//あった場合
                                motimono.vaglist[find].items += v.items;
                            else//なかった場合
                            {
                                if (v.syoki == false)//初期フラグあるかどうか
                                    v.finname = v.title + v.repele + v.name + v.id;
                                else
                                    v.finname = v.title + v.repele + v.name;
                                motimono.vaglist.Add(v);
                            }

                            //種取れるときは種もとる
                            if (v.mat > 3 && v.mat < 8)
                            {
                                seed ns = new seed();
                                ns.getseed(v);
                                motimono.getseed(ns);
                            }
                            motimono.vaghatake[hatanum, num] = null;//空っぽにする
                            hatapic(hatanum, num);//画像もかえる
                        }
                    }
                    //まだ収穫できない
                    else
                    {
                        if (MessageBox.Show("整地します。\nよろしいですか？", "確認", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            motimono.vaghatake[hatanum, num] = null;
                            hatapic(hatanum, num);
                        }

                    }
                }
                vs.Dispose();
            }
        }

        //畑番号を変更（最大数でいろいろ変化
        private void button7_Click(object sender, EventArgs e)
        {
            hatanum--;
            if (hatanum < 0)
                hatanum = this.pointer.hatakemax;
            for (int i = 0; i < 6; i++)
            {
                hatapic(hatanum, i);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            hatanum++;
            if (hatanum > this.pointer.hatakemax)
                hatanum = 0;
            for (int i = 0; i < 6; i++)
            {
                hatapic(hatanum, i);
            }
        }

        //各区画の画像表示
        private void hatapic(int i, int j)
        {
            //ボタンのテキストを状態で変える
            if (motimono.vaghatake[i, j] == null)
            {
                bagpic[j].ImageLocation = "bagpicture\\null.bmp";
                but[j].Text = "植える";
            }
            else if (motimono.vaghatake[i, j].mat > 2 && motimono.vaghatake[i, j].mat < 8)
            {
                bagpic[j].ImageLocation = motimono.vaghatake[i, j].imagepath();
                but[j].Text = "状態";
            }
            else
            {
                bagpic[j].ImageLocation = motimono.vaghatake[i, j].imagepath();
                but[j].Text = "状態";
            }
        }

        private void musicstart()
        {
            sound = new music("music\\hatake.mp3");
            sound.start();
        }
        private void musicstop()
        {
            sound.stop();
            sound.Dispose();
        }

        private void butex_Click(object sender, EventArgs e)
        {
            explain();
        }

        //畑の説明画面を表示
        private void explain()
        {
            hatakeex hx = new hatakeex();
            hx.ShowDialog();
        }

        //閉じる
        private void hatake_FormClosing(object sender, FormClosingEventArgs e)
        {
            musicstop();
        }

        //ニューゲーム時にメッセージがこのフォームが出てから出すための処理
        private void hatake_Shown(object sender, EventArgs e)
        {
            if (this.pointer.loadfrag == false)
            {
                text st = new text("hatakestart", "peet");
                st.ShowDialog();
                explain();
                st = new text("hatakeexend", "peet");
                st.ShowDialog();

                this.pointer.loadfrag = true;
            }
        }
    }
}
