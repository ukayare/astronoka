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
    //ソンブレロ市(まだ未実装
    public partial class sonbrelo : townbase
    {
        public sonbrelo()
        {
            InitializeComponent();
            butnameset("トラップ屋", "種屋", "農業ロボット協会", "市内の人々");

            mpath = "music\\sonbrelo.mp3";
        }
        int i;
        protected override void butcon_Click(object sender, EventArgs e)
        {
        }
        protected override void butua_Click(object sender, EventArgs e)
        {
            i++;
        }
        protected override void button1_Click(object sender, EventArgs e)
        {
            i++;
        }
        protected override void button2_Click(object sender, EventArgs e)
        {
            i++;
        }
        protected override void button3_Click(object sender, EventArgs e)
        {
            i++;
        }
        protected override void button4_Click(object sender, EventArgs e)
        {
            i++;
        }
    }
}
