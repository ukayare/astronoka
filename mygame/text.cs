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
    //各種メッセージを表示する用
    public partial class text : Form
    {
        public text(string tfile,string pfile)
        {
            InitializeComponent();
            //ファイルが存在してれば読み出し
            if (System.IO.File.Exists("text\\" + tfile + ".txt"))
                gettext("text\\"+tfile+".txt");
            if (System.IO.File.Exists("charapic\\" + pfile + ".bmp"))
                getpic("charapic\\" + pfile + ".bmp");
        }

        private void butclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //ファイルからテキスト読み込んで全部乗っける
        private void gettext(string tfile)
        {
            StreamReader reader = new StreamReader(tfile,System.Text.Encoding.GetEncoding("shift_jis"));
            this.richTextBox1.AppendText(reader.ReadToEnd());
        }

        //画像ファイルを読み込む
        private void getpic(string pfile)
        {
            this.pictureBox1.ImageLocation = pfile;
        }


        private void text_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
            this.butclose.Focus();//閉じやすいようにフォーカスしておく
        }

    }
}
