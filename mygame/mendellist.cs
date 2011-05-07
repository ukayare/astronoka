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
    //メンデル表
    public partial class mendellist : Form
    {
        public mendellist()
        {
            InitializeComponent();
        }

        //ロード
        private void mendellist_Load(object sender, EventArgs e)
        {
            ReadCsv("mendel.csv");
        }

        //閉じる
        private void butclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //野菜の交配組み合わせ表示
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string make = "";//交配組み合わせの文字列
            DataGridViewCell c=DataGridView1.CurrentCell;//今選んだセル
            int res;
            int.TryParse(DataGridView1.Rows[c.RowIndex].Cells[0].Value.ToString(),out res);//今選んだやつのメンデル数を取得
            for (int i = 0; i < c.RowIndex; i++)//今より上の部分でループを回す
            {
                for (int j = 1; j < 4; j++)//横は全部
                {
                    if (this.DataGridView1.Rows[i].Cells[j].Value.ToString() != "　　　")//なんかある場合
                    {
                        for (int k = i; k < c.RowIndex; k++)//今指してるやつより後ろ（メンデル同じ場所）から
                        {
                            for (int l = 1; l < 4; l++)//横は全部
                            {
                                if (this.DataGridView1.Rows[k].Cells[l].Value.ToString() != "　　　" && 
                                    this.DataGridView1.Rows[i].Cells[j].Value.ToString() != this.DataGridView1.Rows[k].Cells[l].Value.ToString())//なんかあって同じやつじゃないとき
                                {
                                    //各メンデル数を記憶
                                    int a;
                                    int b;
                                    int.TryParse(this.DataGridView1.Rows[i].Cells[0].Value.ToString(), out a);
                                    int.TryParse(this.DataGridView1.Rows[k].Cells[0].Value.ToString(), out b);

                                    //組み合わせ的にOKならその組み合わせを記憶しておく
                                    if (a + b == res && ((j == l && j == c.ColumnIndex) || (j != l && j != c.ColumnIndex && l != c.ColumnIndex) && !(j>l && k==i)))
                                    {
                                        make += this.DataGridView1.Rows[i].Cells[j].Value.ToString() + "×" + this.DataGridView1.Rows[k].Cells[l].Value.ToString()+"\n";
                                    }
                                }
                            }
                        }
                    }
                }
            }
            MessageBox.Show(make);//最後に結果表示
        }

        public void ReadCsv(String fp)
        {
            // CSVファイルオープン
            StreamReader sr =
                new StreamReader(fp,
                System.Text.Encoding.GetEncoding("SHIFT-JIS"));
            // CSVファイルの各セルをDataGridViewに表示
            this.DataGridView1.Rows.Clear();
            int r = 0;
            String lin = "";
            do
            {
                lin = sr.ReadLine();
                if (lin != null)
                {
                    this.DataGridView1.Rows.Add();
                    String[] csv = lin.Split(',');
                    for (int c = 0; c <= csv.GetLength(0) - 1; c++)
                    {
                        if (c < this.DataGridView1.Columns.Count)
                        {
                            this.DataGridView1.Rows[r].Cells[c].Value = csv[c];
                        }
                    }
                    r += 1;
                }
            } while (lin != null);
            // CSVファイルクローズ
            sr.Close();
        }

    }
}
