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
    public partial class conculeseed : Form
    {
        public conculeseed(string themevag)
        {
            InitializeComponent();
            this.themevag = themevag;
        }

        string themevag;

        private void conculeseed_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;

            if (motimono.vaglist.Exists(s => s.department == -1) == true)
                this.depbox1.Items.Add("A科");
            if (motimono.vaglist.Exists(s => s.department == -0) == true)
                this.depbox1.Items.Add("B科");
            if (motimono.vaglist.Exists(s => s.department == 1) == true)
                this.depbox1.Items.Add("C科");

            this.depbox1.SelectedIndex = 0;
            int i = 0;
            for (i = 0; i < this.namebox1.Items.Count; i++)
            {
                if (this.namebox1.Items[i].ToString() == themevag)
                    break;
            }
            this.namebox1.SelectedIndex = i;
        }

        private void depbox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.bagpic.Image = null;
            stringcreate.infoclear(this.yasaiextext, this.ele1, this.info1, this.eleval1, this.elename1, this.label1);
            stringcreate.depbox_change(this.depbox1, this.listBox1,this.namebox1,"vag");
        }

        private void namebox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.bagpic.Image = null;
            stringcreate.infoclear(this.yasaiextext, this.ele1, this.info1, this.eleval1, this.elename1, this.label1);
            stringcreate.namebox_change(this.namebox1, this.listBox1,"vag");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.bagpic.Image = null;
            vagetable v = stringcreate.vag_listBox_changed(this.listBox1, this.label1, this.yasaiextext, this.ele1, this.info1, this.eleval1, this.elename1);
            this.bagpic.ImageLocation = v.imagepath;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
