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
    public partial class astronet : Form
    {
        public astronet()
        {
            InitializeComponent();
        }

        music sound;

        private void astronet_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
            musicstart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            musicstop();
            this.Dispose();
        }

        private void musicstart()
        {
            sound = new music("music\\astronet.mp3");
            sound.start();
        }
        private void musicstop()
        {
            sound.stop();
            sound.Dispose();
        }
    }
}
