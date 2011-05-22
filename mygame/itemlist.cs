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

        private seed s1 = new seed();
        private vagetable v = new vagetable();
        private trap t=null;


        private void butclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //どの種類を選んだか
        private void namebox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            stringcreate.infoclear(this.yasaiextext, this.ele1, this.info1, this.eleval1, this.elename1,this.label1);
            this.bagpic.Image = null;
            stringcreate.namebox_change(this.listBox2,this.namebox1,this.listBox1);
        }


        private void depbox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            stringcreate.infoclear(this.yasaiextext, this.ele1, this.info1, this.eleval1, this.elename1, this.label1);
            this.bagpic.Image = null;
            stringcreate.depbox_change(this.listBox2, this.depbox1, this.namebox1, this.listBox1);
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
            this.bagpic.Image = null;
            seedvagtrap svt = stringcreate.listBox_change(this.listBox2, this.listBox1, this.label1, this.yasaiextext, this.ele1, this.info1, this.eleval1, this.elename1);
            if (svt.s != null)
                s1 = svt.s;
            if (svt.v != null)
            {
                v = svt.v;
                this.bagpic.ImageLocation = v.imagepath();
            }
            if (svt.t != null)
                t = svt.t;
        }

        //トラップ種野菜どれ選んだ？
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            stringcreate.infoclear(this.yasaiextext, this.ele1, this.info1, this.eleval1, this.elename1, this.label1);
            this.bagpic.Image = null;
            stringcreate.itemBox_change(this.listBox2,this.depbox1,this.namebox1,this.listBox1);
        }
    }
}
