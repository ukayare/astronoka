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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            article selectedarticle = motimono.astronetlist.Find(a => a.title == this.listBox1.SelectedItem.ToString());
            this.textBox1.Text = selectedarticle.title;
            this.textBox2.Text = selectedarticle.author;
            this.textBox3.Text = selectedarticle.year+"年"+selectedarticle.month+"月"+selectedarticle.day+"日";
            this.richTextBox1.Text = selectedarticle.context;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            List<article> currentlist = motimono.astronetlist.FindAll(a => a.topic == this.comboBox1.SelectedIndex);
            foreach (article a in currentlist)
            {
                this.listBox1.Items.Add(a.title);
            }
        }
    }
}
