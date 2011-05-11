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
    //ペドロ（店屋
    public partial class prdro : Form
    {
        public prdro()
        {
            InitializeComponent();
        }

        music sound;
        //選んだ種とトラップ
        seed selectedseed;
        trap selectedtrap;

        //持ってるとラップ調べる（店側
        public void trapsearch()
        {
            for (int j = 0; j < motimono.tlistpedro.Length; j++)
                motimono.tlistpedro[j] = false;

            for (int i = 0; i < motimono.pedrotrap.Count; i++)
            {
                for (int j = 0; j < motimono.tlistpedro.Length; j++)
                {
                    if (motimono.pedrotrap[i].type == j)
                    {
                        motimono.tlistpedro[j] = true;
                        break;
                    }
                }

            }
        }

        //閉じる
        private void butclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //ロード
        private void prdro_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
            musicstart();
            this.trapsearch();
        }

        //
        private void depbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.buyBox2.Items.Clear();
            this.buyBox2.SelectedIndex=-1;
            this.listBox.Items.Clear();
            this.namebox.Items.Clear();
            if (this.itembox.SelectedIndex != -1 && this.depbox.SelectedItem!=null)
            {
                if (this.itembox.SelectedItem.ToString() == "種")
                {
                    List<seed> curseed = new List<seed>();
                    string str =this.depbox.SelectedItem.ToString();
                    //選んだ項目にあったリストを取得
                    if (str == "全て")
                        curseed = motimono.seedlist;
                    else if (str == "A科")
                        curseed = motimono.seedlist.FindAll(s => s.department == -1);
                    else if (str == "B科")
                        curseed = motimono.seedlist.FindAll(s => s.department == 0);
                    else if (str == "C科")
                        curseed = motimono.seedlist.FindAll(s => s.department == 1);
                    else if (str == "強化種")
                        curseed = motimono.seedlist.FindAll(s => s.department == 2);
                    
                    foreach(seed s in curseed)
                        listset(s);
                }
                else if (this.itembox.SelectedItem.ToString() == "野菜")
                {
                    List<vagetable> curvag = new List<vagetable>();
                    string str = this.depbox.SelectedItem.ToString();
                    //選んだ項目にあったリストを取得
                    if (str == "全て")
                        curvag = motimono.vaglist;
                    else if (str == "A科")
                        curvag = motimono.vaglist.FindAll(s => s.department == -1);
                    else if (str == "B科")
                        curvag = motimono.vaglist.FindAll(s => s.department == 0);
                    else if (str == "C科")
                        curvag = motimono.vaglist.FindAll(s => s.department == 1);

                    foreach (vagetable v in motimono.vaglist)
                        listset(v);
                }
                if (this.itembox.SelectedItem.ToString() == "トラップ")
                {
                    foreach(trap t in motimono.traplist)
                        this.listBox.Items.Add(t.name);

                    for (int j = 0; j < motimono.tlist.Length; j++)
                    {
                        if (motimono.tlist[j]==true)
                        {
                            this.namebox.Items.Add(motimono.tname[j]);
                        }
                    }
                }
            }
        }
        //野菜種共通のリスト追加メソッド（じゃっかんまどろっこしいか？
        private void listset(yasai list)
        {
            Boolean same = false;

            for (int j = 0; j < this.namebox.Items.Count; j++)
                if (list.name == this.namebox.Items[j].ToString())
                    same = true;
            if (same == false)
                this.namebox.Items.Add(list.name);

            listBox.Items.Add(list.finname);
        }

        //種類選んだ
        private void namebox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.buyBox2.Items.Clear();
            this.buyBox2.SelectedIndex = -1;
            this.listBox.Items.Clear();

            if (this.itembox.SelectedIndex != -1 && this.namebox.SelectedItem!=null)
            {
                //種類によってリストを取得し表示する
                string x = this.namebox.SelectedItem.ToString();
                if (this.itembox.SelectedItem.ToString() == "種")
                {
                    List<seed> curseed = motimono.seedlist.FindAll(s=>s.name==x);
                    foreach(seed s in curseed)
                        this.listBox.Items.Add(s.finname);
                }
                else if (this.itembox.SelectedItem.ToString() == "野菜")
                {
                    List<vagetable> curvag = motimono.vaglist.FindAll(v => v.name == x);
                    foreach(vagetable v in curvag)
                        this.listBox.Items.Add(v.finname);
                }
                else if (this.itembox.SelectedItem.ToString() == "トラップ")
                {
                    int j=0;
                    if (this.namebox.SelectedItem.ToString() == "全て")
                    {
                        foreach(trap t in motimono.traplist)
                            this.listBox.Items.Add(t.name);
                    }
                    else
                    {
                        for (j = 0; j < motimono.tlist.Length; j++)
                        {
                            if (motimono.tname[j] == this.namebox.SelectedItem.ToString())
                            {
                                break;
                            }
                        }
                        List<trap> curtrap = motimono.traplist.FindAll(t => t.type == j);
                        foreach(trap t in curtrap)
                            this.listBox.Items.Add(t.name);
                    }
                }
            }
        }

        //種野菜とラップ選ぶ
        private void itembox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.buyBox2.Items.Clear();
            this.buyBox2.SelectedIndex = -1;

            this.listBox.Items.Clear();
            this.namebox.Items.Clear();
            this.depbox.Items.Clear();

            if (this.itembox.SelectedItem != null)
            {
                //ある科だけ追加
                if (this.itembox.SelectedItem.ToString() == "種")
                {
                    this.depbox.Items.Add("全て");

                    if (motimono.seedlist.Exists(s=>s.department==-1) == true)
                        this.depbox.Items.Add("A科");
                    if (motimono.seedlist.Exists(s => s.department == 0) == true)
                        this.depbox.Items.Add("B科");
                    if (motimono.seedlist.Exists(s => s.department == 1) == true)
                        this.depbox.Items.Add("C科");
                    if (motimono.seedlist.Exists(s => s.department == 2) == true)
                        this.depbox.Items.Add("強化種");

                }
                else if (this.itembox.SelectedItem.ToString() == "野菜")
                {
                    this.depbox.Items.Add("全て");

                    if (motimono.vaglist.Exists(v=>v.department==-1) == true)
                        this.depbox.Items.Add("A科");
                    if (motimono.vaglist.Exists(v => v.department == 0) == true)
                        this.depbox.Items.Add("B科");
                    if (motimono.vaglist.Exists(v => v.department == 1) == true)
                        this.depbox.Items.Add("C科");

                }
                else if (this.itembox.SelectedItem.ToString() == "トラップ")
                {
                    this.namebox.Items.Add("全て");
                    for (int i = 0; i < motimono.tlist.Length; i++)
                        if (motimono.tlist[i] == true)
                            this.namebox.Items.Add(motimono.tname[i]);
                }
            }
        }

        //売るものの決定 
        private void listBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            this.buyBox2.Items.Clear();
            this.buyBox2.SelectedIndex = -1;
            int j=0;//売るものの個数を設定
            if (this.itembox.SelectedIndex != -1 && this.listBox.SelectedItem!=null)
            {
                if (this.itembox.SelectedItem.ToString() == "種")
                {
                    j=motimono.seedlist.Find(s => s.finname == this.listBox.SelectedItem.ToString()).items;
                    for (int k = 1; k <= j; k++)
                        buyBox2.Items.Add(k);//個数をコンボボックスに入れる

                }
                else if (this.itembox.SelectedItem.ToString() == "野菜")
                {
                    j = motimono.vaglist.Find(v => v.finname == this.listBox.SelectedItem.ToString()).items;
                    for (int k = 1; k <= j; k++)
                        buyBox2.Items.Add(k);
                }
                else if (this.itembox.SelectedItem.ToString() == "トラップ")
                {
                    j = motimono.traplist.Find(t => t.name == this.listBox.SelectedItem.ToString()).items;
                    for (int k = 1; k <= j; k++)
                        buyBox2.Items.Add(k);
                }
            }
        }

        //売る個数決定
        private void buyBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (buyBox2.SelectedIndex != -1 && this.buyBox2.SelectedItem != null)
                if (this.itembox.SelectedItem.ToString() == "種")
                {
                    //種はどれでも１０
                    buylabel.Text = 10 * (this.buyBox2.SelectedIndex + 1) + "z";
                }
                //野菜トラップは該当するものの値段をとってくる
                else if (this.itembox.SelectedItem.ToString() == "野菜")
                {
                    buylabel.Text = motimono.vaglist.Find(v => v.finname == this.listBox.SelectedItem.ToString()).price * (this.buyBox2.SelectedIndex + 1) + "z";
                }
                else if (this.itembox.SelectedItem.ToString() == "トラップ")
                {
                    buylabel.Text = (motimono.traplist.Find(t => t.name == this.listBox.SelectedItem.ToString()).price * (this.buyBox2.SelectedIndex + 1)) / 2 + "z";
                }
        }

        //売却ボタン
        private void button2_Click(object sender, EventArgs e)
        {
            if (buyBox2.SelectedIndex != -1)
            {
                //売却確認
                if (MessageBox.Show("売却しますか？", "売却確認", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int find;
                    //おのおの該当するインデックス取ってきて操作
                    if (this.itembox.SelectedItem.ToString() == "種")
                    {
                        find = motimono.seedlist.FindIndex(s => s.finname == this.listBox.SelectedItem.ToString());
                        date.moneychanged(10 * (this.buyBox2.SelectedIndex + 1));
                        motimono.seedlist[find].items -= this.buyBox2.SelectedIndex + 1;
                        motimono.seedlist.RemoveAll(s => s.items == 0);
                    }
                    else if (this.itembox.SelectedItem.ToString() == "野菜")
                    {
                        find = motimono.vaglist.FindIndex(v => v.finname == this.listBox.SelectedItem.ToString());
                        date.moneychanged(motimono.vaglist[find].price * (this.buyBox2.SelectedIndex + 1));
                        motimono.vaglist[find].items -= this.buyBox2.SelectedIndex + 1;
                        motimono.vaglist.RemoveAll(v => v.items == 0);
                    }
                    else if (this.itembox.SelectedItem.ToString() == "トラップ")
                    {
                        find = motimono.traplist.FindIndex(t => t.name == this.listBox.SelectedItem.ToString());
                        date.moneychanged((motimono.traplist[find].price * (this.buyBox2.SelectedIndex + 1)) / 2);
                        motimono.traplist[find].items -= this.buyBox2.SelectedIndex + 1;
                        motimono.traplist.RemoveAll(t => t.items == 0);
                        motimono.trapsearch();
                    }
                    boxset();
                }

            }
            else
                MessageBox.Show("売却するものと個数を決めてください");
        }

        //ボックス初期化
        private void boxset()
        {
            this.depbox.Items.Clear(); 
            this.depbox.SelectedIndex=-1;
            this.listBox.Items.Clear();
            this.namebox.Items.Clear();
            this.buyBox2.Items.Clear();
            this.buyBox2.SelectedIndex = -1;
        }

        //買うもの選択
        private void bitemBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.bitemBox1.SelectedItem != null)
            {
                this.bnameBox.Items.Clear();
                this.listBox2.Items.Clear();
                if (this.bitemBox1.SelectedItem.ToString() == "種")
                {
                    this.bnameBox.Items.Add("全て");
                }
                else if (this.bitemBox1.SelectedItem.ToString() == "トラップ")
                {
                    this.bnameBox.Items.Add("全て");
                    for (int i = 0; i < motimono.tlistpedro.Length; i++)
                        if (motimono.tlistpedro[i] == true)
                            this.bnameBox.Items.Add(motimono.tname[i]);
                }
            }
        }

        //買う種類選択
        private void bnameBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.bitemBox1.SelectedIndex != -1 && this.bnameBox.SelectedItem!=null)
            {
                this.listBox2.Items.Clear();
                if (this.bitemBox1.SelectedItem.ToString() == "種")
                {
                    foreach(seed s in motimono.pedroseed)
                        this.listBox2.Items.Add(s.finname);
                }
                else if (this.bitemBox1.SelectedItem.ToString() == "トラップ")
                {
                    if (this.bnameBox.SelectedItem.ToString() == "全て")
                    {
                        foreach(trap t in motimono.pedrotrap)
                            this.listBox2.Items.Add(t.name);
                    }
                    else
                    {
                        int i;
                        for (i = 0; i < motimono.tlistpedro.Length; i++)
                            if(this.bnameBox.SelectedItem.ToString()==motimono.tname[i])
                                break;
                        List<trap> curtrap = motimono.pedrotrap.FindAll(t => t.type == i);
                        foreach(trap t in curtrap)
                                this.listBox2.Items.Add(t.name);
                    }
                }
            }
        }

        //買うもの選択
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //該当するものをそれぞれ取得
            if (this.bitemBox1.SelectedIndex != -1 && this.listBox2.SelectedItem != null && this.listBox2.SelectedIndex != -1)
            {
                if (this.bitemBox1.SelectedItem.ToString() == "種")
                {
                    selectedseed = motimono.pedroseed.Find(s => s.finname == this.listBox2.SelectedItem.ToString());
                }
                else if (this.bitemBox1.SelectedItem.ToString() == "トラップ")
                {
                    selectedtrap = motimono.pedrotrap.Find(t => t.name == this.listBox2.SelectedItem.ToString());
                }
            }
        }

        //買う個数決定
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ko;
            if (this.comboBox1.SelectedIndex != -1 && this.listBox2.SelectedIndex!=-1){
                int.TryParse(this.comboBox1.SelectedItem.ToString(), out ko);
                if (this.bitemBox1.SelectedIndex != -1)
                {
                    if (this.bitemBox1.SelectedItem.ToString() == "種")
                    {
                        this.plabel1.Text = selectedseed.sell * (ko) + "z";
                    }
                    else if (this.bitemBox1.SelectedItem.ToString() == "トラップ")
                    {
                        this.plabel1.Text = selectedtrap.price * (ko) + "z";
                    }
                }
            }
        }

        //購入決定
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.comboBox1.SelectedIndex != -1 && this.listBox2.SelectedIndex != -1)
            {
                if (MessageBox.Show("購入しますか？", "購入確認", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (this.bitemBox1.SelectedItem.ToString() == "種")
                    {
                        int ko;
                        int.TryParse(this.comboBox1.SelectedItem.ToString(), out ko);
                        seedbuy(selectedseed, ko);
                    }
                    else if (this.bitemBox1.SelectedItem.ToString() == "トラップ")
                    {
                        int ko;
                        int.TryParse(this.comboBox1.SelectedItem.ToString(), out ko);
                        trapbuy(selectedtrap, ko);
                    }
                    boxset();
                    motimono.trapsearch();
                }
            }
            else
                MessageBox.Show("購入するものと個数を選んでください");
        }

        //閉じる
        private void prdro_FormClosing(object sender, FormClosingEventArgs e)
        {
            musicstop();
        }


        private void musicstop()
        {
            sound.stop();
            sound.Dispose();
        }

        private void musicstart()
        {
            sound = new music("music\\pedro.mp3");
            sound.start();
        }

        //購入処理（種
        private void seedbuy(seed s, int count)
        {
            if (date.money >= (s.sell * (count)))//金ある？
            {
                date.moneychanged(-(s.sell * (count)));//金額減らす
                motimono.syoki(s.mendel, s.department, count);
                MessageBox.Show(s.finname + "を" + count + "個購入しました");
            }
            else
                MessageBox.Show("お金が足りません");
        }

        //購入処理（トラップ
        private void trapbuy(trap t, int count)
        {
            if (date.money >= (t.price * (count)))
            {
                date.moneychanged(-(t.price * (count)));
                motimono.gettrap(t,count);
                MessageBox.Show(t.name + "を" + count + "個購入しました");
            }
            else
                MessageBox.Show("お金が足りません");
        }

    }
}
