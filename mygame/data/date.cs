using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    //日にちとかその辺のデータのクラス
    public static class date
    {
        internal static int day;//日
        internal static int month;//月
        internal static int year;//年
        internal static string week;//曜日
        internal static string season;//季節

        internal static string name;//自分の名前

        internal static int money;//所持金
        internal static int fin;//羽の枚数
        internal static int elect;//トラップ電力消費量
        internal static int electmax;

        //金の変化
        public static string moneychanged(int mon)
        {
            money = money + mon;
            return "羽：" + date.fin + "枚    " + date.money + "z";
        }

        //羽の変化
        public static string finchanged(int fin)
        {
            fin = fin + fin;
            return "羽：" + date.fin + "枚    " + date.money + "z";
        }


        //次の日への処理
        public static void nextday()
        {
            day++;//日にち加算
            if (day == 29)//月代わり
                seasonchange();
            youbi();
            yasaigrow();
        }

        private static void yasaigrow()
        {
            //畑に植えた野菜の成長
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 6; j++)
                    if (motimono.vaghatake[i, j] != null)
                        motimono.vaghatake[i, j].next();
        }

        private static void seasonchange()
        {
            day = 1;
            month++;

            if (month == 7)//翌年へ
            {
                month = 1;
                year++;
            }

            switch (month)//季節が変わるかチェック
            {
                case 1:
                    season = "春";
                    break;
                case 2:
                    season = "夏";
                    break;
                case 4:
                    season = "秋";
                    break;
                case 5:
                    season = "冬";
                    break;

            }
        }

        private static string youbi()
        {
            switch (day % 7)//曜日の設定
            {
                case 0:
                    week = "（日）";
                    break;
                case 1:
                    week = "（月）";
                    break;
                case 2:
                    week = "（火）";
                    break;
                case 3:
                    week = "（水）";
                    break;
                case 4:
                    week = "（木）";
                    break;
                case 5:
                    week = "（金）";
                    break;
                case 6:
                    week = "（土）";
                    break;
            }
            return week;
        }

        //祝日名（今は何もしない、休日と返す
        public static string holiday()
        {
            /*switch (month)
            {
                case 1:
                    if (day == 1)
                        return "新年祭";
                    else if (day == 25)
                        return "ハーブ祭";
                    else
                        break;
                case 2:
                    if (day == 10)
                        return "ニッカポッカ記念日";
                    else if (day == 21)
                        return "新人の日";
                    else
                        break;
                case 4:
                    if (day == 10)
                        return "惑星探査の日";
                    else if(day == 20 || day == 21 || day == 22)
                        return "収穫祭";
                    else
                        break;
                case 5:
                    if (day == 22)
                        return "暗黒星雲の日";
                    else
                        break;
                case 6:
                    if (day == 17)
                        return "満月の日";
                    else if (day == 27)
                        return "雪祭り";
                    else
                        break;

            }
            */
            return "休日";
        }

        //休日チェック
        public static Boolean holidayok()
        {
            //普通の休日
            if (day % 7 == 0)
                return true;

            //各月の祝日チェック（ここ設定ファイルで読み込ませるのもありかな
            switch (month)
            {
                case 1:
                    if (day == 1 || day == 25)
                        return true;
                    else
                        break;
                case 2:
                    if (day == 10 || day == 21)
                        return true;
                    else
                        break;
                case 4:
                    if (day == 10 || day == 20 || day == 21 || day == 22)
                        return true;
                    else
                        break;
                case 5:
                    if (day == 22)
                        return true;
                    else
                        break;
                case 6:
                    if (day == 17 || day == 27)
                        return true;
                    else
                        break;

            }
            return false;
        }
    }
}
