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
    //構造体Dateに関する処理
    public partial class Form3 : Form
    {
        //金の変化
        public void moneychanged(int mon)
        {
            this.moneylabel.Text = date.moneychanged(mon);
        }

        //羽の変化
        public void finchanged(int fin)
        {
            this.moneylabel.Text = date.finchanged(fin);
        }


        //次の日への処理
        private void nextday_Click(object sender, EventArgs e)
        {
            //翌日への確認
            if (MessageBox.Show("今日の作業を終了しますか？", "一日の終了", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                date.nextday();
                if (date.day == 1)
                {
                    musicstop();
                    musicstart();
                }

                //表示の設定
                this.datelabel.Text = date.year + "年目 " + date.month + "月 " + date.day + "日" + date.week + date.season;


                string dfile = "";//メッセージファイル

                if (date.holidayok() == true)//休日チェック、バス出てるのメッセージ
                {
                    this.button3.Enabled = true;
                    text st = new text(date.holiday(), "peet");
                    st.ShowDialog();
                }
                else
                    this.button3.Enabled = false;



                if (date.day == 1)//月初めのチェック
                    dfile = date.season + date.month.ToString();
                if (System.IO.File.Exists("text\\" + dfile + ".txt"))
                {

                }
            }
        }
    }
}
