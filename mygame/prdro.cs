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
            Flag.trapsearchpedro();
        }

        //
        private void depbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            stringcreate.infoclear(this.yasaiextext2, this.ele2, this.info2, this.eleval2, this.elename2);
            this.buyBox2.Items.Clear();
            this.buyBox2.SelectedIndex=-1;
            stringcreate.depbox_change(this.itembox, this.depbox, this.namebox, this.listBox);
        }

        //種類選んだ
        private void namebox_SelectedIndexChanged(object sender, EventArgs e)
        {
            stringcreate.infoclear(this.yasaiextext2, this.ele2, this.info2, this.eleval2, this.elename2);
            this.buyBox2.Items.Clear();
            this.buyBox2.SelectedIndex = -1;
            stringcreate.namebox_change(this.itembox,this.namebox,this.listBox);
        }

        //種野菜とラップ選ぶ
        private void itembox_SelectedIndexChanged(object sender, EventArgs e)
        {
            stringcreate.infoclear(this.yasaiextext2, this.ele2, this.info2, this.eleval2, this.elename2);
            this.buyBox2.Items.Clear();
            this.buyBox2.SelectedIndex = -1;
            stringcreate.itemBox_change(this.itembox, this.depbox, this.namebox, this.listBox);
        }

        private void itemcount(item i)
        {
            for (int k = 1; k <= i.items; k++)
                buyBox2.Items.Add(k);//個数をコンボボックスに入れる            
        }

        //売るものの決定 
        private void listBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            this.buyBox2.Items.Clear();
            this.buyBox2.SelectedIndex = -1;
            seedvagtrap svt=stringcreate.listBox_change(this.itembox, this.listBox, this.label1, this.yasaiextext2, this.ele2, this.info2, this.eleval2, this.elename2);
            if (svt.s != null)
                itemcount(svt.s);
            else if (svt.v != null)
                itemcount(svt.v);
            else if (svt.t != null)
                itemcount(svt.t);
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
                        Flag.trapsearch();
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
                    for (int i = 0; i < Flag.tlistpedro.Length; i++)
                        if (Flag.tlistpedro[i] == true)
                            this.bnameBox.Items.Add(Flag.tname[i]);
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
                        for (i = 0; i < Flag.tlistpedro.Length; i++)
                            if(this.bnameBox.SelectedItem.ToString()==Flag.tname[i])
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
                    stringcreate.infoshow(selectedseed, this.yasaiextext, this.ele1, this.info1, this.eleval1, this.elename1);

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
                    Flag.trapsearch();
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
