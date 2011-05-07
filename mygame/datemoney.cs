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
            date.money = date.money+mon;
            this.moneylabel.Text = "羽："+date.fin + "枚    "+date.money + "z";
        }

        //羽の変化
        public void finchanged(int fin)
        {
            date.fin = date.fin+fin;
            this.moneylabel.Text = "羽：" + date.fin + "枚" + date.money + "z";
        }


        //次の日への処理
        private void nextday_Click(object sender, EventArgs e)
        {
            //翌日への確認
            if (MessageBox.Show("今日の作業を終了しますか？", "一日の終了", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                date.day++;//日にち加算
                if (date.day == 29)//月代わり
                {
                    date.day = 1;
                    date.month++;

                    switch (date.month)//季節が変わるかチェック
                    {
                        case 1:
                            date.season = "春";
                            musicstop();
                            musicstart();
                            break;
                        case 2:
                            date.season = "夏";
                            musicstop();
                            musicstart();
                            break;
                        case 4:
                            date.season = "秋";
                            musicstop();
                            musicstart();
                            break;
                        case 5:
                            date.season = "冬";
                            musicstop();
                            musicstart();
                            break;
                    }
                }
                if (date.month == 7)//翌年へ
                {
                    date.month = 1;
                    date.year++;
                }
                switch (date.day % 7)//曜日の設定
                {
                    case 0:
                        date.week = "（日）";
                        break;
                    case 1:
                        date.week = "（月）";
                        break;
                    case 2:
                        date.week = "（火）";
                        break;
                    case 3:
                        date.week = "（水）";
                        break;
                    case 4:
                        date.week = "（木）";
                        break;
                    case 5:
                        date.week = "（金）";
                        break;
                    case 6:
                        date.week = "（土）";
                        break;
                }
                
                //表示の設定
                this.datelabel.Text = date.year + "年目 " + date.month + "月 " + date.day + "日" + date.week + date.season;

                //畑に植えた野菜の成長
                for (int i = 0; i < 4; i++)
                    for (int j = 0; j < 6; j++)
                        if (motimono.vaghatake[i, j] != null)
                            motimono.vaghatake[i, j].next();

                string dfile = "";//メッセージファイル

                if (holidayok() == true)//休日チェック、バス出てるのメッセージ
                {
                    this.button3.Enabled = true;
                    text st = new text(holiday(), "peet");
                    st.ShowDialog();
                }
                else
                    this.button3.Enabled = false;



                if (date.day == 1)//月初めのチェック
                    dfile = date.season + date.month.ToString();
                if (System.IO.File.Exists("text\\"+dfile+".txt"))
                {

                }
            }
        }

        //祝日名（今は何もしない、休日と返す
        private string holiday()
        {
            /*switch (date.month)
            {
                case 1:
                    if (date.day == 1)
                        return "新年祭";
                    else if (date.day == 25)
                        return "ハーブ祭";
                    else
                        break;
                case 2:
                    if (date.day == 10)
                        return "ニッカポッカ記念日";
                    else if (date.day == 21)
                        return "新人の日";
                    else
                        break;
                case 4:
                    if (date.day == 10)
                        return "惑星探査の日";
                    else if(date.day == 20 || date.day == 21 || date.day == 22)
                        return "収穫祭";
                    else
                        break;
                case 5:
                    if (date.day == 22)
                        return "暗黒星雲の日";
                    else
                        break;
                case 6:
                    if (date.day == 17)
                        return "満月の日";
                    else if (date.day == 27)
                        return "雪祭り";
                    else
                        break;

            }
            */
            return "休日";
        }

        //休日チェック
        private Boolean holidayok()
        {
            //普通の休日
            if (date.day % 7 == 0)
                return true;

            //各月の祝日チェック（ここ設定ファイルで読み込ませるのもありかな
            switch (date.month)
            {
                case 1:
                    if (date.day == 1 || date.day == 25)
                        return true;
                    else
                        break;
                case 2:
                    if (date.day == 10 || date.day == 21)
                        return true;
                    else
                        break;
                case 4:
                    if (date.day == 10 || date.day == 20 || date.day == 21 || date.day == 22)
                        return true;
                    else
                        break;
                case 5:
                    if (date.day == 22)
                        return true;
                    else
                        break;
                case 6:
                    if (date.day == 17 || date.day == 27)
                        return true;
                    else
                        break;

            }

            return false;
        }
    }
}
