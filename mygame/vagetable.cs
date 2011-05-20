using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    //野菜
    public class vagetable : yasai
    {
        public int status = 1;//0-injured 1-normal 2-good 3-better 4-best

        public int mat = 0;//0発芽前　1発芽　2成長中　3成熟　4種1つ　5種2つ　6種3つ　7完全成熟　8枯れてる

        //種から野菜を生成（コンストラクタにしてないのは・・・あとでするかも）
        public void set(seed s)
        {
            finname = s.finname;
            name = s.name;
            repele = s.repele;
            title = s.title;
            id = s.id;
            pure = s.pure;
            syoki = s.syoki;
            department = s.department;
            mendel = s.mendel;
            grow = s.grow;
            basep = s.basep;
            bonusp = s.bonusp;
            price = s.price;
            rank = s.rank;

            mut1 = s.mut1;
            mut2 = s.mut2;
            
            info = s.info;

            fix = s.fix;
            element = s.element;
            elename = s.elename;
            elelevel = s.elelevel;
        }

        //次の日にいくときの成長
        public void next()
        {
            days++;//日数加算
            //成長状態の設定
            if (element[0] < 150)//でかい場合（長いからもうちょっとうまい書き方を考える
            {
                if (grow == 3)
                    switch (days)
                    {
                        case 1:
                            mat = 2;
                            break;
                        case 2:
                            mat = 3;
                            break;
                        case 3:
                            mat = 6;
                            break;
                        case 4:
                        case 5:
                        case 6:
                            mat = 7;
                            break;
                        default:
                            mat = 8;
                            break;

                    }
                else if (grow == 6)
                    switch (days)
                    {
                        case 1:
                            mat = 1;
                            break;
                        case 2:
                            mat = 2;
                            break;
                        case 3:
                            mat = 3;
                            break;
                        case 4:
                            mat = 4;
                            break;
                        case 5:
                            mat = 5;
                            break;
                        case 6:
                            mat = 6;
                            break;
                        case 7:
                        case 8:
                        case 9:
                            mat = 7;
                            break;
                        default:
                            mat = 8;
                            break;
                    }
                else if (grow == 8)
                    switch (days)
                    {
                        case 1:
                            mat = 0;
                            break;
                        case 2:
                            mat = 1;
                            break;
                        case 3:
                        case 4:
                            mat = 2;
                            break;
                        case 5:
                            mat = 3;
                            break;
                        case 6:
                            mat = 4;
                            break;
                        case 7:
                            mat = 5;
                            break;
                        case 8:
                            mat = 6;
                            break;
                        case 9:
                        case 10:
                        case 11:
                            mat = 7;
                            break;
                        default:
                            mat = 8;
                            break;
                    }
                else if (grow == 10)
                    switch (days)
                    {
                        case 1:
                            mat = 0;
                            break;
                        case 2:
                        case 3:
                            mat = 1;
                            break;
                        case 4:
                        case 5:
                        case 6:
                            mat = 2;
                            break;
                        case 7:
                            mat = 3;
                            break;
                        case 8:
                            mat = 4;
                            break;
                        case 9:
                            mat = 5;
                            break;
                        case 10:
                            mat = 6;
                            break;
                        case 11:
                        case 12:
                        case 13:
                            mat = 7;
                            break;
                        default:
                            mat = 8;
                            break;
                    }
                else if (grow == 13)
                    switch (days)
                    {
                        case 1:
                        case 2:
                        case 3:
                            mat = 0;
                            break;
                        case 4:
                        case 5:
                        case 6:
                            mat = 1;
                            break;
                        case 7:
                            mat = 2;
                            break;
                        case 8:
                        case 9:
                        case 10:
                            mat = 3;
                            break;
                        case 11:
                            mat = 4;
                            break;
                        case 12:
                            mat = 5;
                            break;
                        case 13:
                            mat = 6;
                            break;
                        case 14:
                        case 15:
                        case 16:
                            mat = 7;
                            break;
                        default:
                            mat = 8;
                            break;
                    }
            }
            else
            {

                if (grow == 4)
                    switch (days)
                    {
                        case 1:
                            mat = 2;
                            break;
                        case 2:
                        case 3:
                            mat = 3;
                            break;
                        case 4:
                            mat = 6;
                            break;
                        case 5:
                        case 6:
                        case 7:
                            mat = 7;
                            break;
                        default:
                            mat = 8;
                            break;

                    }
                else if (grow == 7)
                    switch (days)
                    {
                        case 1:
                            mat = 1;
                            break;
                        case 2:
                            mat = 2;
                            break;
                        case 3:
                        case 4:
                            mat = 3;
                            break;
                        case 5:
                            mat = 4;
                            break;
                        case 6:
                            mat = 5;
                            break;
                        case 7:
                            mat = 6;
                            break;
                        case 8:
                        case 9:
                        case 10:
                            mat = 7;
                            break;
                        default:
                            mat = 8;
                            break;
                    }
                else if (grow == 9)
                    switch (days)
                    {
                        case 1:
                            mat = 0;
                            break;
                        case 2:
                            mat = 1;
                            break;
                        case 3:
                        case 4:
                            mat = 2;
                            break;
                        case 5:
                        case 6:
                            mat = 3;
                            break;
                        case 7:
                            mat = 4;
                            break;
                        case 8:
                            mat = 5;
                            break;
                        case 9:
                            mat = 6;
                            break;
                        case 10:
                        case 11:
                        case 12:
                            mat = 7;
                            break;
                        default:
                            mat = 8;
                            break;
                    }
                else if (grow == 11)
                    switch (days)
                    {
                        case 1:
                            mat = 0;
                            break;
                        case 2:
                        case 3:
                            mat = 1;
                            break;
                        case 4:
                        case 5:
                        case 6:
                            mat = 2;
                            break;
                        case 7:
                        case 8:
                            mat = 3;
                            break;
                        case 9:
                            mat = 4;
                            break;
                        case 10:
                            mat = 5;
                            break;
                        case 11:
                            mat = 6;
                            break;
                        case 12:
                        case 13:
                        case 14:
                            mat = 7;
                            break;
                        default:
                            mat = 8;
                            break;
                    }
                else if (grow == 14)
                    switch (days)
                    {
                        case 1:
                        case 2:
                        case 3:
                            mat = 0;
                            break;
                        case 4:
                        case 5:
                        case 6:
                            mat = 1;
                            break;
                        case 7:
                            mat = 2;
                            break;
                        case 8:
                        case 9:
                        case 10:
                        case 11:
                            mat = 3;
                            break;
                        case 12:
                            mat = 4;
                            break;
                        case 13:
                            mat = 5;
                            break;
                        case 14:
                            mat = 6;
                            break;
                        case 15:
                        case 16:
                        case 17:
                            mat = 7;
                            break;
                        default:
                            mat = 8;
                            break;
                    }
            }
        }

        //画像のパス設定
        public string imagepath()
        {
            string retstring = "";//返り値の文字列（パス
            //植えたばっかり
            if (mat == 0)
            {
                switch (department)
                {
                    case -1:
                        retstring = "bagpicture\\A0.bmp";
                        break;
                    case 0:
                        retstring = "bagpicture\\B0.bmp";
                        break;
                    case 1:
                        retstring = "bagpicture\\C0.bmp";
                        break;
                }
            }
            //発芽
            else if (mat == 1)
            {
                switch (department)
                {
                    case -1:
                        retstring = "bagpicture\\A1.bmp";
                        break;
                    case 0:
                        retstring = "bagpicture\\B1.bmp";
                        break;
                    case 1:
                        retstring = "bagpicture\\C1.bmp";
                        break;
                }
            }
            else
            {
                int st = picst(mat);//成長状態のモード
                //パス名は科＋メンデル数＋状態
                switch (department)
                {
                    case -1:
                        retstring = "bagpicture\\A" + mendel + st + ".bmp";
                        break;
                    case 0:
                        retstring = "bagpicture\\B" + mendel + st + ".bmp";
                        break;
                    case 1:
                        retstring = "bagpicture\\C" + mendel + st + ".bmp";
                        break;
                }
            }
            return retstring;
        }

        //完全成熟というか種付きは画像が同じ何でその辺の設定
        private int picst(int x)
        {
            if (x > 3 && x < 8)
                return 6;
            return x;

        }

    }
}
