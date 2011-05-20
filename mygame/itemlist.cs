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
    public partial class itemlist : Form
    {
        public itemlist()
        {
            InitializeComponent();
        }

        public seed s1 = new seed();
        public vagetable v = new vagetable();

        private void butclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //どの種類を選んだか
        private void namebox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            stringcreate.infoclear(this.yasaiextext, this.ele1, this.info1, this.eleval1, this.elename1);
            if (this.listBox2.SelectedIndex != -1 && this.namebox1.SelectedItem!=null)
            {
                //野菜か種かトラップか
                string x = this.namebox1.SelectedItem.ToString();
                if (this.listBox2.SelectedItem.ToString() == "種")
                {
                    stringcreate.namebox_change(this.namebox1, this.listBox1, "seed");
                }
                //以下もおんなじ処理（なんとかまとれねーかなー
                else if (this.listBox2.SelectedItem.ToString() == "野菜")
                {
                    stringcreate.namebox_change(this.namebox1, this.listBox1, "vag");
                }
                else if (this.listBox2.SelectedItem.ToString() == "トラップ")
                {
                    int j;
                    for (j=0; j < Flag.tlist.Length; j++)
                            if (this.namebox1.SelectedItem.ToString() == Flag.tname[j])
                                break;
                    this.listBox1.Items.Clear();
                    List<trap> curtrap = new List<trap>();
                    curtrap = motimono.traplist.FindAll(t=>t.type==j);
                    foreach(trap t in curtrap)
                            this.listBox1.Items.Add(t.name);                    
                }
            }
        }


        private void depbox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //いったんクリアー
            this.listBox1.Items.Clear();
            this.namebox1.Items.Clear();
            stringcreate.infoclear(this.yasaiextext, this.ele1, this.info1, this.eleval1, this.elename1);
            //以下どの科を選んだかでまずリストをとってきてそれについて表示させる
            if (this.listBox2.SelectedIndex != -1)
            {
                if (this.listBox2.SelectedItem.ToString() == "種")
                {
                    stringcreate.depbox_change(this.depbox1, this.listBox1, this.namebox1,"seed");
                }
                else if (this.listBox2.SelectedItem.ToString() == "野菜")
                {
                    stringcreate.depbox_change(this.depbox1, this.listBox1, this.namebox1, "vag");
                }
                else if (this.listBox2.SelectedItem.ToString() == "トラップ")
                {
                    for (int i = 0; i < Flag.tlist.Length; i++)
                    {
                        if (Flag.tlist[i] == true)
                            this.namebox1.Items.Add(Flag.tname[i]);
                    }
                    foreach (trap t in motimono.traplist)
                        this.listBox1.Items.Add(t.name);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void itemlist_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
            boxset();
            Flag.trapsearch();
        }

        private void boxset()
        {
            this.listBox1.Items.Clear();
            this.namebox1.Items.Clear();

            foreach(seed s in motimono.seedlist)
            this.listBox1.Items.Add(s.finname);

            this.depbox1.SetSelected(0, true);
        }

        //どの個体を選んだか
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //選んでるかを確認
            if (this.listBox2.SelectedIndex != -1)
            {
                if (this.listBox2.SelectedItem.ToString() == "種")
                {
                    if (this.listBox1.SelectedIndex != -1)
                    {
                        //選んだ個体を取得
                        s1 = stringcreate.seed_listBox_changed(this.listBox1, this.label1, this.yasaiextext, this.ele1, this.info1, this.eleval1, this.elename1);
                        this.label1.Text = s1.items.ToString();

                    }
                }
                else if (this.listBox2.SelectedItem.ToString() == "野菜")
                {
                    if (this.listBox1.SelectedIndex != -1)
                    {
                        v = stringcreate.vag_listBox_changed(this.listBox1, this.label1, this.yasaiextext, this.ele1, this.info1, this.eleval1, this.elename1);
                        this.label1.Text = v.items.ToString();
                    }
                }
            }
        }

        //トラップ種野菜どれ選んだ？
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            stringcreate.infoclear(this.yasaiextext, this.ele1, this.info1, this.eleval1, this.elename1);
            if (this.listBox2.SelectedItem.ToString() == "種")
            {
                this.listBox1.Items.Clear();
                this.namebox1.Items.Clear();
                this.depbox1.Items.Clear();
                this.depbox1.Items.Add("全て");

                //各科あるかどうか判別
                if (motimono.seedlist.Exists(s => s.department == -1) == true)
                    this.depbox1.Items.Add("A科");
                if (motimono.seedlist.Exists(s => s.department == -0) == true)
                    this.depbox1.Items.Add("B科");
                if (motimono.seedlist.Exists(s => s.department == 1) == true)
                    this.depbox1.Items.Add("C科");
                if (motimono.seedlist.Exists(s => s.department == 2) == true)
                    this.depbox1.Items.Add("強化種");

            }
            else if (this.listBox2.SelectedItem.ToString() == "野菜")
            {
                this.listBox1.Items.Clear();
                this.namebox1.Items.Clear();
                this.depbox1.Items.Clear();
                this.depbox1.Items.Add("全て");

                if (motimono.vaglist.Exists(s => s.department == -1) == true)
                    this.depbox1.Items.Add("A科");
                if (motimono.vaglist.Exists(s => s.department == -0) == true)
                    this.depbox1.Items.Add("B科");
                if (motimono.vaglist.Exists(s => s.department == 1) == true)
                    this.depbox1.Items.Add("C科");
            }
            else if (this.listBox2.SelectedItem.ToString() == "トラップ")
            {
                this.listBox1.Items.Clear();
                this.namebox1.Items.Clear();
                this.depbox1.Items.Clear();
                this.depbox1.Items.Add("全て");
                for (int i = 0; i < Flag.tlist.Length; i++)
                {
                    if(motimono.traplist.Exists(t=>t.type==i)==true)
                        this.namebox1.Items.Add(Flag.tname[i]);
                }
            }
        }
    }
}
