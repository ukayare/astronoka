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
    public partial class seedstatus : Form
    {
        public seedstatus(seed s)
        {
            this.s = s;
            InitializeComponent();
        }

        seed s;

        private void seedstatus_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;

            stringcreate.infoshow(s, this.yasaiextext, this.ele1, this.info1, this.eleval1, this.elename1, this.label1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
