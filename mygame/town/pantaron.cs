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
    public partial class pantaron : townbase
    {
        //パンタロン町（まだ未実装
        public pantaron()
        {
            InitializeComponent();
            butnameset("ふとん屋", "トラップ屋", "コールテン研究所", "町の人々");

            mpath = "music\\pantaron.mp3";
        }

        

        protected override void butcon_Click(object sender, EventArgs e)
        {
        }
        protected override void butua_Click(object sender, EventArgs e)
        {
        }
        protected override void button1_Click(object sender, EventArgs e)
        {
        }
        protected override void button2_Click(object sender, EventArgs e)
        {
        }
        protected override void button3_Click(object sender, EventArgs e)
        {
        }
        protected override void button4_Click(object sender, EventArgs e)
        {
        }
    }
}
