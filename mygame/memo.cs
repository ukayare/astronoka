using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class memo : Form
    {
        public memo()
        {
            InitializeComponent();
        }

        private void memo_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }

        //ファイルからテキスト読み込んで全部乗っける
        private void gettext(string tfile)
        {
            StreamReader reader = new StreamReader(tfile, System.Text.Encoding.GetEncoding("shift_jis"));
            this.richTextBox1.AppendText(reader.ReadToEnd());
            this.richTextBox1.Focus();
            this.richTextBox1.SelectAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.combomonth.SelectedItem == null || this.comboday.SelectedItem == null)
                MessageBox.Show("日付を確定してください");
            else if (this.richTextBox1.Text == "")
                MessageBox.Show("メモを入力してください");
            else
            {
                StreamWriter writer = new StreamWriter("memo\\" + month + day + ".txt");
                writer.Write(this.richTextBox1.Text);
                writer.Dispose();
                this.Dispose();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void combomonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            if (this.comboday.SelectedItem != null)
            {
                if (System.IO.File.Exists("memo\\" + month + day + ".txt"))
                    gettext("memo\\" + month + day + ".txt");
            }
        }

        private void comboday_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            if (this.combomonth.SelectedItem != null)
            {
                if (System.IO.File.Exists("memo\\" + month + day + ".txt"))
                    gettext("memo\\" + month + day + ".txt");
            }
        }

        private string month
        {
            get
            {
                return combomonth.SelectedItem.ToString();
            }
        }
        private string day
        {
            get
            {
                return comboday.SelectedItem.ToString();
            }
        }
    }
}
