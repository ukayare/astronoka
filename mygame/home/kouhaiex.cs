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
    //交配の説明
    public partial class kouhaiex : Form
    {
        public kouhaiex()
        {
            InitializeComponent();
        }

        //閉じる
        private void butclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //メンデル表
        private void button3_Click(object sender, EventArgs e)
        {
            mendellist ml = new mendellist();
            ml.ShowDialog();
        }

        //交配説明
        private void button1_Click(object sender, EventArgs e)
        {
            text t = new text("basekouhai","peet");
            t.ShowDialog();
        }
    }
}
