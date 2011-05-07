using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    //種関係
    public class seed : yasai
    {
        //遺伝情報から種の情報形成
        public void set()
        {
            nameset();
            paraset();
            sum = element.Sum();
            title = titleset(sum);
            elenameset(element);
            most();
            if (syoki == true)
            {
                title = "初期";
                finname = title + repele + name;
            }
            else if (strengp != 0)
            {
                strset();
                finname = title + repele + name;
            }
            else
                finname = title + repele + name + id;
            setprice();

            if (element[0] > 150)
                grow++;
        }

        //交配の部分（混ぜる種を引数）
        public void mix(seed seed1, seed seed2)
        {
            if (seed1.strengp == 0 && seed2.strengp == 0)//混ぜるのに強化種が混じってないか
            {
                mixpara(seed1, seed2);
                henni();
            }
            //以下は強化種処理
            else if (seed1.strengp != 0)
                mixparas(seed2, seed1);
            else if (seed2.strengp != 0)
                mixparas(seed1, seed2);
            //ここまで
            paraset();//遺伝情報から名前設定
            if (seed1.strengp == 0 && seed2.strengp == 0)//強化種の場合ここでパラメーターを変化
                kyouka();
            sum = element.Sum();//要素の合計
            title = titleset(sum);//階級を設定
            elenameset(element);//各レベルの名前をつける
            most();//一番でかいパラメータを名前につける
            if (strengp != 0)//できた種が強化種のとき
            {
                strset();
            }
            finname = title + repele + name + id;//表示名をセット
            setprice();

            if (element[0] > 150)//でかい場合は成長日数を加算
                grow++;
        }

        //初期種を生成するときに使用
        public void baseset(int i,int j)
        {
            defpara();
            mendel = i;
            department = j;
            nameset();
            sum = element.Sum();
            syoki = true;
            finname = title + repele + name;
            setprice();
        }

        //種類を決定
        public void nameset()
        {
            if (mendel >= 120)
            {
                min = -200;
                max = 300;
            }

            if (department == -1)
            {//A
                switch (mendel)
                {
                    case 7:
                        name = "穴ホウレン草";
                        basep = 150;
                        mut1 = 3;
                        sell = 500;
                        break;
                    case 9:
                        name = "ニラクラウン";
                        basep = 290;
                        grow = 6;
                        mut1 = 4;
                        break;
                    case 11:
                        name = "透明キャベツ";
                        basep = 120;
                        mut1 = 5;
                        break;
                    case 13:
                        name = "ウキウキパセリ";
                        basep = 150;
                        grow = 6;
                        mut1 = 3;
                        break;
                    case 15:
                        name = "カリフラボール";
                        basep = 250;
                        grow = 6;
                        mut1 = 2;
                        break;
                    case 45:
                        name = "宇宙マメ";
                        basep = 650;
                        grow = 8;
                        mut1 = 6;
                        break;
                    case 60:
                        name = "ホタル唐辛子";
                        basep = 950;
                        grow = 8;
                        mut1 = 5;
                        break;
                    case 90:
                        name = "真空ワカメ";
                        basep = 600;
                        grow = 6;
                        mut1 = 7;
                        break;
                    case 150:
                        name = "月面コンブ";
                        basep = 900;
                        grow = 6;
                        mut1 = 9;
                        season = 4;
                        break;
                    case 450:
                        name = "チンゲンツリー";
                        basep = 900;
                        grow = 10;
                        mut1 = 7;
                        break;
                    case 600:
                        name = "妖精ピーマン";
                        basep = 1400;
                        grow = 10;
                        mut1 = 10;
                        break;
                    case 1050:
                        name = "水晶ハーブ";
                        basep = 1900;
                        grow = 6;
                        mut1 = 8;
                        mut2 = 9;
                        season = 1;
                        break;
                }
            }
            else if (department == 0)//B
            {
                switch (mendel)
                {
                    case 2:
                        name = "シマイモ";
                        basep = 90;
                        mut1 = 2;
                        sell = 50;
                        break;
                    case 4:
                        name = "星カブ";
                        basep = 140;
                        mut1 = 1;
                        sell = 80;
                        break;
                    case 6:
                        name = "腰かけレンコン";
                        basep = 130;
                        mut1 = 3;
                        break;
                    case 8:
                        name = "コスモニンジン";
                        basep = 280;
                        mut1 = 4;
                        break;
                    case 10:
                        name = "タマネギボム";
                        basep = 190;
                        grow = 6;
                        mut1 = 2;
                        break;
                    case 12:
                        name = "イモ球";
                        basep = 320;
                        grow = 8;
                        mut1 = 1;
                        break;

                    case 14:
                        name = "ゴボウ玉";
                        basep = 120;
                        mut1 = 1;
                        break;
                    case 30:
                        name = "火星カボチャ";
                        basep = 350;
                        grow = 6;
                        mut1 = 3;
                        break;
                    case 90:
                        name = "トゲガーリック";
                        basep = 750;
                        grow = 6;
                        mut1 = 9;
                        break;
                    case 120:
                        name = "カブトカケノコ";
                        basep = 1100;
                        grow = 10;
                        mut1 = 7;
                        mut2 = 2;
                        break;
                    case 300:
                        name = "冥王マツタケ";
                        basep = 1800;
                        grow = 6;
                        mut1 = 6;
                        mut2 = 3;
                        season = 3;
                        break;
                    case 600:
                        name = "貴婦人";
                        basep = 1700;
                        grow = 13;
                        mut1 = 8;
                        mut2 = 7;
                        break;
                }
            }
            else if (department == 1)
            {
                switch (mendel)//c
                {
                    case 5:
                        name = "トマトニアン";
                        basep = 200;
                        mut1 = 4;
                        break;
                    case 9:
                        name = "電灯キューリ";
                        basep = 80;
                        mut1 = 6;
                        break;
                    case 11:
                        name = "土星ナス";
                        basep = 200;
                        mut1 = 4;
                        break;
                    case 13:
                        name = "ドームメロン";
                        basep = 400;
                        grow = 8;
                        mut1 = 5;
                        break;
                    case 14:
                        name = "ひよこレモン";
                        basep = 110;
                        mut1 = 9;
                        break;
                    case 15:
                        name = "ロウソクコーン";
                        basep = 180;
                        grow = 6;
                        mut1 = 6;
                        break;
                    case 45:
                        name = "砲丸ピーチ";
                        basep = 500;
                        grow = 6;
                        mut1 = 9;
                        break;
                    case 60:
                        name = "イチゴブドウ";
                        basep = 1500;
                        grow = 6;
                        mut1 = 5;
                        season = 1;
                        break;
                    case 90:
                        name = "光速パイン";
                        basep = 1200;
                        grow = 13;
                        mut1 = 10;
                        mut2 = 1;
                        break;
                    case 150:
                        name = "スイカタワー";
                        basep = 1500;
                        grow = 8;
                        mut1 = 10;
                        mut2 = 5;
                        season = 2;
                        break;
                    case 450:
                        name = "銀河ドリアン";
                        basep = 1100;
                        grow = 8;
                        mut1 = 9;
                        mut2 = 4;
                        break;
                    case 1650:
                        name = "アストロキング";
                        basep = 2000;
                        grow = 13;
                        mut1 = 8;
                        mut2 = 10;
                        break;
                }
            }
        }

        //各遺伝情報からパラメーターを取得
        public void paraset()
        {
            int[] kotei = new int[10];
            int l = info.Length;
            for (int i = 0; i < info.GetLength(0); i++)
            {
                for (int j = 0; j < l / info.GetLength(0); j++)
                    switch (j)
                    {
                        case 0:
                            if (info[i, j] == true)
                            {
                                element[i] = 20;
                                kotei[i]++;
                            }
                            break;
                        case 1:
                            if (info[i, j] == true)
                            {
                                kotei[i]++;
                                element[i] += 8;
                            }
                            break;
                        case 2:
                            if (info[i, j] == true)
                            {
                                kotei[i]++;
                                element[i] += 3;
                            }
                            break;
                        case 3:
                            if (info[i, j] == true)
                            {
                                kotei[i]++;
                                element[i] += 15;
                            }
                            break;
                        case 4:
                            if (info[i, j] == true)
                            {
                                kotei[i]++;
                                element[i] += 30;
                            }
                            break;
                        case 5:
                            if (info[i, j] == true)
                            {
                                kotei[i]++;
                                element[i] += 5;
                            }
                            break;
                        case 6:
                            if (info[i, j] == true)
                            {
                                element[i] += 12;
                                kotei[i]++;
                            }
                            break;
                        case 7:
                            if (info[i, j] == true)
                            {
                                element[i] += 7;
                                kotei[i]++;
                            }
                            break;
                    }
            }

            for (int k = 0; k < kotei.Length; k++)
            {

                if (kotei[k] == 0 && (element[k] + fix[k]) != min && fix[k] < 0)
                {
                    for (int j = 0; j < l / info.GetLength(0); j++)
                        info[k, j] = true;
                    fix[k] -= 100;
                    element[k] += 100;
                }
                else if (kotei[k] == 8 && (element[k] + fix[k]) != max && fix[k] > 0)
                {
                    for (int j = 0; j < l / info.GetLength(0); j++)
                        info[k, j] = false;
                    fix[k] += 100;
                    element[k] -= 100;
                }
            }
            for (int k = 0; k < fix.Length; k++)
                element[k] = element[k] + fix[k];

        }

        //階級の決定
        public string titleset(int sum)
        {
            if (sum == 3000)
            {
                rank = 14;
                return "最終";
            }
            else if (sum > 2700)
            {
                rank = 13;
                return "奇跡";
            }
            else if (sum > 2300)
            {
                rank = 12;
                return "偉大";
            }
            else if (sum > 2000)
            {
                rank = 11;
                return "超絶";
            }
            else if (sum > 1800)
            {
                rank = 10;
                return "秘宝";
            }
            else if (sum > 1600)
            {
                rank = 9;
                return "名品";
            }
            else if (sum > 1450)
            {
                rank = 8;
                return "珠玉";
            }
            else if (sum > 1300)
            {
                rank = 8;
                return "高貴";
            }
            else if (sum > 1150)
            {
                rank = 7;
                return "特上";
            }
            else if (sum > 1000)
            {
                rank = 6;
                return "一流";
            }
            else if (sum > 900)
            {
                rank = 5;
                return "Ａ級";
            }
            else if (sum > 800)
            {
                rank = 4;
                return "名産";
            }
            else if (sum > 700)
            {
                rank = 3;
                return "高級";
            }
            else if (sum > 600)
            {
                rank = 2;
                return "優等";
            }
            else if (sum > 500)
            {
                rank = 1;
                return "良質";
            }
            else if (sum > 350)
            {
                rank = 0;
                return "平凡";
            }
            else if (sum > 200)
            {
                rank = -1;
                return "Ｃ級";
            }
            else if (sum > 50)
            {
                rank = -2;
                return "不良";
            }
            else if (sum > -100)
            {
                rank = -3;
                return "ゴミ";
            }
            else if (sum > -250)
            {
                rank = -4;
                return "悪質";
            }
            else if (sum > -400)
            {
                rank = -5;
                return "危険";
            }
            else if (sum > -600)
            {
                rank = -6;
                return "流血";
            }
            else if (sum > -800)
            {
                rank = -7;
                return "悪夢";
            }
            else if (sum > -1000)
            {
                rank = -8;
                return "禁断";
            }
            else if (sum > -1300)
            {
                rank = -9;
                return "恐怖";
            }
            else if (sum > -1700)
            {
                rank = -10;
                return "邪悪";
            }
            else if (sum > -2000)
            {
                rank = -11;
                return "死神";
            }
            else
            {
                rank = -12;
                return "破滅";
            }
        }

        //各要素のレベル名をセット
        public void elenameset(int[] ele)
        {

            for (int i = 0; i < elename.Length; i++)
            {
                switch (i)
                {
                    case 0://high
                        if (ele[i] == 300)
                        {
                            elelevel[i] = 11;
                            elename[i] = "究極巨大";
                            break;
                        }
                        else if (ele[i] >= 262)
                        {
                            elelevel[i] = 10;
                            elename[i] = "恒星サイズ";
                            break;
                        }
                        else if (ele[i] >= 232)
                        {
                            elelevel[i] = 9;
                            elename[i] = "惑星サイズ";
                            break;
                        }
                        else if (ele[i] >= 201)
                        {
                            elelevel[i] = 8;
                            elename[i] = "山のような";
                            break;
                        }
                        else if (ele[i] == 200)
                        {
                            elelevel[i] = 7;
                            elename[i] = "家ほどもある";
                            break;
                        }
                        else if (ele[i] >= 162)
                        {
                            elelevel[i] = 6;
                            elename[i] = "大巨人";
                            break;
                        }
                        else if (ele[i] >= 132)
                        {
                            elelevel[i] = 5;
                            elename[i] = "ジャイアント";
                            break;
                        }
                        else if (ele[i] >= 101)
                        {
                            elelevel[i] = 4;
                            elename[i] = "超ビッグ";
                            break;
                        }
                        else if (ele[i] == 100)
                        {
                            elelevel[i] = 3;
                            elename[i] = "ビッグ";
                            break;
                        }
                        else if (ele[i] >= 73)
                        {
                            elelevel[i] = 2;
                            elename[i] = "大きい";
                            break;
                        }
                        else if (ele[i] >= 43)
                        {
                            elelevel[i] = 1;
                            elename[i] = "やや大";
                            break;
                        }
                        else if (ele[i] == 40)
                        {
                            elelevel[i] = 0;
                            elename[i] = "";
                            break;
                        }
                        else if (ele[i] >= 3)
                        {
                            elelevel[i] = -1;
                            elename[i] = "やや小";
                            break;
                        }
                        else if (ele[i] == 0)
                        {
                            elelevel[i] = -2;
                            elename[i] = "スモール";
                            break;
                        }
                        else if (ele[i] >= -28)
                        {
                            elelevel[i] = -3;
                            elename[i] = "超スモール";
                            break;
                        }
                        else if (ele[i] >= -58)
                        {
                            elelevel[i] = -4;
                            elename[i] = "豆粒ほどの";
                            break;
                        }
                        else if (ele[i] >= -99)
                        {
                            elelevel[i] = -5;
                            elename[i] = "極小";
                            break;
                        }
                        else if (ele[i] == -100)
                        {
                            elelevel[i] = -6;
                            elename[i] = "ミクロ";
                            break;
                        }
                        else if (ele[i] >= -128)
                        {
                            elelevel[i] = -7;
                            elename[i] = "目に見えない";
                            break;
                        }
                        else if (ele[i] >= -158)
                        {
                            elelevel[i] = -8;
                            elename[i] = "分子レベル";
                            break;
                        }
                        else if (ele[i] >= -197)
                        {
                            elelevel[i] = -9;
                            elename[i] = "原子レベル";
                            break;
                        }
                        else
                        {
                            elelevel[i] = -10;
                            elename[i] = "究極極小";
                            break;
                        }
                    case 1://heavy
                        if (ele[i] == 300)
                        {
                            elelevel[i] = 11;
                            elename[i] = "銀河一重量";
                            break;
                        }
                        else if (ele[i] >= 262)
                        {
                            elelevel[i] = 10;
                            elename[i] = "天下一重量";
                            break;
                        }
                        else if (ele[i] >= 232)
                        {
                            elelevel[i] = 9;
                            elename[i] = "星より重い";
                            break;
                        }
                        else if (ele[i] >= 201)
                        {
                            elelevel[i] = 8;
                            elename[i] = "超ヘビー級";
                            break;
                        }
                        else if (ele[i] == 200)
                        {
                            elelevel[i] = 7;
                            elename[i] = "ゾウより重い";
                            break;
                        }
                        else if (ele[i] >= 162)
                        {
                            elelevel[i] = 6;
                            elename[i] = "持ち運び不可";
                            break;
                        }
                        else if (ele[i] >= 132)
                        {
                            elelevel[i] = 5;
                            elename[i] = "ヘビー級";
                            break;
                        }
                        else if (ele[i] >= 101)
                        {
                            elelevel[i] = 4;
                            elename[i] = "ライトヘビー";
                            break;
                        }
                        else if (ele[i] == 100)
                        {
                            elelevel[i] = 3;
                            elename[i] = "ずっしり";
                            break;
                        }
                        else if (ele[i] >= 73)
                        {
                            elelevel[i] = 2;
                            elename[i] = "重たい";
                            break;
                        }
                        else if (ele[i] >= 43)
                        {
                            elelevel[i] = 1;
                            elename[i] = "やや重";
                            break;
                        }
                        else if (ele[i] == 40)
                        {
                            elelevel[i] = 0;
                            elename[i] = "";
                            break;
                        }
                        else if (ele[i] >= 3)
                        {
                            elelevel[i] = -1;
                            elename[i] = "やや軽";
                            break;
                        }
                        else if (ele[i] == 0)
                        {
                            elelevel[i] = -2;
                            elename[i] = "軽量";
                            break;
                        }
                        else if (ele[i] >= -28)
                        {
                            elelevel[i] = -3;
                            elename[i] = "スカスカ";
                            break;
                        }
                        else if (ele[i] >= -58)
                        {
                            elelevel[i] = -4;
                            elename[i] = "かるがる";
                            break;
                        }
                        else if (ele[i] >= -99)
                        {
                            elelevel[i] = -5;
                            elename[i] = "ストロー級";
                            break;
                        }
                        else if (ele[i] == -100)
                        {
                            elelevel[i] = -6;
                            elename[i] = "超軽量";
                            break;
                        }
                        else if (ele[i] >= -128)
                        {
                            elelevel[i] = -7;
                            elename[i] = "ほとんど空気";
                            break;
                        }
                        else if (ele[i] >= -158)
                        {
                            elelevel[i] = -8;
                            elename[i] = "空気より軽い";
                            break;
                        }
                        else if (ele[i] >= -197)
                        {
                            elelevel[i] = -9;
                            elename[i] = "ほとんど水素";
                            break;
                        }
                        else
                        {
                            elelevel[i] = -10;
                            elename[i] = "宇宙最軽量";
                            break;
                        }
                    case 2://pattern
                        if (ele[i] == 300)
                        {
                            elelevel[i] = 11;
                            elename[i] = "至高の模様";
                            break;
                        }
                        else if (ele[i] >= 262)
                        {
                            elelevel[i] = 10;
                            elename[i] = "伝説の模様";
                            break;
                        }
                        else if (ele[i] >= 232)
                        {
                            elelevel[i] = 9;
                            elename[i] = "神秘の模様";
                            break;
                        }
                        else if (ele[i] >= 201)
                        {
                            elelevel[i] = 8;
                            elename[i] = "勇者の模様";
                            break;
                        }
                        else if (ele[i] == 200)
                        {
                            elelevel[i] = 7;
                            elename[i] = "稀少模様";
                            break;
                        }
                        else if (ele[i] >= 162)
                        {
                            elelevel[i] = 6;
                            elename[i] = "アートな模様";
                            break;
                        }
                        else if (ele[i] >= 132)
                        {
                            elelevel[i] = 5;
                            elename[i] = "ふしぎ模様";
                            break;
                        }
                        else if (ele[i] >= 101)
                        {
                            elelevel[i] = 4;
                            elename[i] = "珍奇模様";
                            break;
                        }
                        else if (ele[i] == 100)
                        {
                            elelevel[i] = 3;
                            elename[i] = "爆笑模様";
                            break;
                        }
                        else if (ele[i] >= 73)
                        {
                            elelevel[i] = 2;
                            elename[i] = "ゆかいな模様";
                            break;
                        }
                        else if (ele[i] >= 43)
                        {
                            elelevel[i] = 1;
                            elename[i] = "面白模様";
                            break;
                        }
                        else if (ele[i] == 40)
                        {
                            elelevel[i] = 0;
                            elename[i] = "";
                            break;
                        }
                        else if (ele[i] >= 3)
                        {
                            elelevel[i] = -1;
                            elename[i] = "変な模様";
                            break;
                        }
                        else if (ele[i] == 0)
                        {
                            elelevel[i] = -2;
                            elename[i] = "不吉模様";
                            break;
                        }
                        else if (ele[i] >= -28)
                        {
                            elelevel[i] = -3;
                            elename[i] = "催眠模様";
                            break;
                        }
                        else if (ele[i] >= -58)
                        {
                            elelevel[i] = -4;
                            elename[i] = "人面模様";
                            break;
                        }
                        else if (ele[i] >= -99)
                        {
                            elelevel[i] = -5;
                            elename[i] = "呪いの模様";
                            break;
                        }
                        else if (ele[i] == -100)
                        {
                            elelevel[i] = -6;
                            elename[i] = "凶悪模様";
                            break;
                        }
                        else if (ele[i] >= -128)
                        {
                            elelevel[i] = -7;
                            elename[i] = "血まみれ模様";
                            break;
                        }
                        else if (ele[i] >= -158)
                        {
                            elelevel[i] = -8;
                            elename[i] = "怨霊の模様";
                            break;
                        }
                        else if (ele[i] >= -197)
                        {
                            elelevel[i] = -9;
                            elename[i] = "悪魔の模様";
                            break;
                        }
                        else
                        {
                            elelevel[i] = -10;
                            elename[i] = "死神模様";
                            break;
                        }
                    case 3://nour
                        if (ele[i] == 300)
                        {
                            elelevel[i] = 11;
                            elename[i] = "奇跡の秘薬";
                            break;
                        }
                        else if (ele[i] >= 262)
                        {
                            elelevel[i] = 10;
                            elename[i] = "死者復活";
                            break;
                        }
                        else if (ele[i] >= 232)
                        {
                            elelevel[i] = 9;
                            elename[i] = "不老長寿";
                            break;
                        }
                        else if (ele[i] >= 201)
                        {
                            elelevel[i] = 8;
                            elename[i] = "万病治癒";
                            break;
                        }
                        else if (ele[i] == 200)
                        {
                            elelevel[i] = 7;
                            elename[i] = "体力全快";
                            break;
                        }
                        else if (ele[i] >= 162)
                        {
                            elelevel[i] = 6;
                            elename[i] = "精力増強";
                            break;
                        }
                        else if (ele[i] >= 132)
                        {
                            elelevel[i] = 5;
                            elename[i] = "滋養強壮";
                            break;
                        }
                        else if (ele[i] >= 101)
                        {
                            elelevel[i] = 4;
                            elename[i] = "解毒作用";
                            break;
                        }
                        else if (ele[i] == 100)
                        {
                            elelevel[i] = 3;
                            elename[i] = "健康になる";
                            break;
                        }
                        else if (ele[i] >= 73)
                        {
                            elelevel[i] = 2;
                            elename[i] = "栄養たっぷり";
                            break;
                        }
                        else if (ele[i] >= 43)
                        {
                            elelevel[i] = 1;
                            elename[i] = "ビタミン豊富";
                            break;
                        }
                        else if (ele[i] == 40)
                        {
                            elelevel[i] = 0;
                            elename[i] = "";
                            break;
                        }
                        else if (ele[i] >= 3)
                        {
                            elelevel[i] = -1;
                            elename[i] = "栄養不足";
                            break;
                        }
                        else if (ele[i] == 0)
                        {
                            elelevel[i] = -2;
                            elename[i] = "栄養なし";
                            break;
                        }
                        else if (ele[i] >= -28)
                        {
                            elelevel[i] = -3;
                            elename[i] = "なんとか食用";
                            break;
                        }
                        else if (ele[i] >= -58)
                        {
                            elelevel[i] = -4;
                            elename[i] = "体がしびれる";
                            break;
                        }
                        else if (ele[i] >= -99)
                        {
                            elelevel[i] = -5;
                            elename[i] = "体に悪い";
                            break;
                        }
                        else if (ele[i] == -100)
                        {
                            elelevel[i] = -6;
                            elename[i] = "毒薬原料";
                            break;
                        }
                        else if (ele[i] >= -128)
                        {
                            elelevel[i] = -7;
                            elename[i] = "デンジャラス";
                            break;
                        }
                        else if (ele[i] >= -158)
                        {
                            elelevel[i] = -8;
                            elename[i] = "呪いの猛毒";
                            break;
                        }
                        else if (ele[i] >= -197)
                        {
                            elelevel[i] = -9;
                            elename[i] = "即死注意";
                            break;
                        }
                        else
                        {
                            elelevel[i] = -10;
                            elename[i] = "地獄へ直行";
                            break;
                        }
                    case 4://sugar
                        if (ele[i] == 300)
                        {
                            elelevel[i] = 11;
                            elename[i] = "極上甘味";
                            break;
                        }
                        else if (ele[i] >= 262)
                        {
                            elelevel[i] = 10;
                            elename[i] = "最高甘味";
                            break;
                        }
                        else if (ele[i] >= 232)
                        {
                            elelevel[i] = 9;
                            elename[i] = "幸福甘味";
                            break;
                        }
                        else if (ele[i] >= 201)
                        {
                            elelevel[i] = 8;
                            elename[i] = "あまあまあま";
                            break;
                        }
                        else if (ele[i] == 200)
                        {
                            elelevel[i] = 7;
                            elename[i] = "極上甘味";
                            break;
                        }
                        else if (ele[i] >= 162)
                        {
                            elelevel[i] = 6;
                            elename[i] = "うっとり甘味";
                            break;
                        }
                        else if (ele[i] >= 132)
                        {
                            elelevel[i] = 5;
                            elename[i] = "上質甘味";
                            break;
                        }
                        else if (ele[i] >= 101)
                        {
                            elelevel[i] = 4;
                            elename[i] = "あまあま";
                            break;
                        }
                        else if (ele[i] == 100)
                        {
                            elelevel[i] = 3;
                            elename[i] = "甘味";
                            break;
                        }
                        else if (ele[i] >= 73)
                        {
                            elelevel[i] = 2;
                            elename[i] = "それなりに甘い";
                            break;
                        }
                        else if (ele[i] >= 43)
                        {
                            elelevel[i] = 1;
                            elename[i] = "やや甘";
                            break;
                        }
                        else if (ele[i] == 40)
                        {
                            elelevel[i] = 0;
                            elename[i] = "";
                            break;
                        }
                        else if (ele[i] >= 3)
                        {
                            elelevel[i] = -1;
                            elename[i] = "甘くない";
                            break;
                        }
                        else if (ele[i] == 0)
                        {
                            elelevel[i] = -2;
                            elename[i] = "ピリッと辛い";
                            break;
                        }
                        else if (ele[i] >= -28)
                        {
                            elelevel[i] = -3;
                            elename[i] = "やや辛";
                            break;
                        }
                        else if (ele[i] >= -58)
                        {
                            elelevel[i] = -4;
                            elename[i] = "中辛";
                            break;
                        }
                        else if (ele[i] >= -99)
                        {
                            elelevel[i] = -5;
                            elename[i] = "口内火事";
                            break;
                        }
                        else if (ele[i] == -100)
                        {
                            elelevel[i] = -6;
                            elename[i] = "激辛";
                            break;
                        }
                        else if (ele[i] >= -128)
                        {
                            elelevel[i] = -7;
                            elename[i] = "大激辛";
                            break;
                        }
                        else if (ele[i] >= -158)
                        {
                            elelevel[i] = -8;
                            elename[i] = "どとうの激辛";
                            break;
                        }
                        else if (ele[i] >= -197)
                        {
                            elelevel[i] = -9;
                            elename[i] = "口内破壊";
                            break;
                        }
                        else
                        {
                            elelevel[i] = -10;
                            elename[i] = "死に至る辛さ";
                            break;
                        }
                    case 5://texture
                        if (ele[i] == 300)
                        {
                            elelevel[i] = 11;
                            elename[i] = "宇宙一食感";
                            break;
                        }
                        else if (ele[i] >= 262)
                        {
                            elelevel[i] = 10;
                            elename[i] = "天使の食感";
                            break;
                        }
                        else if (ele[i] >= 232)
                        {
                            elelevel[i] = 9;
                            elename[i] = "至福の食感";
                            break;
                        }
                        else if (ele[i] >= 201)
                        {
                            elelevel[i] = 8;
                            elename[i] = "大吉食感";
                            break;
                        }
                        else if (ele[i] == 200)
                        {
                            elelevel[i] = 7;
                            elename[i] = "感涙食感";
                            break;
                        }
                        else if (ele[i] >= 162)
                        {
                            elelevel[i] = 6;
                            elename[i] = "ほんわか食感";
                            break;
                        }
                        else if (ele[i] >= 132)
                        {
                            elelevel[i] = 5;
                            elename[i] = "舌でとろける";
                            break;
                        }
                        else if (ele[i] >= 101)
                        {
                            elelevel[i] = 4;
                            elename[i] = "ふんわり";
                            break;
                        }
                        else if (ele[i] == 100)
                        {
                            elelevel[i] = 3;
                            elename[i] = "なめらか";
                            break;
                        }
                        else if (ele[i] >= 73)
                        {
                            elelevel[i] = 2;
                            elename[i] = "サクサク";
                            break;
                        }
                        else if (ele[i] >= 43)
                        {
                            elelevel[i] = 1;
                            elename[i] = "歯ざわりＯＫ";
                            break;
                        }
                        else if (ele[i] == 40)
                        {
                            elelevel[i] = 0;
                            elename[i] = "";
                            break;
                        }
                        else if (ele[i] >= 3)
                        {
                            elelevel[i] = -1;
                            elename[i] = "やや固い";
                            break;
                        }
                        else if (ele[i] == 0)
                        {
                            elelevel[i] = -2;
                            elename[i] = "固い";
                            break;
                        }
                        else if (ele[i] >= -28)
                        {
                            elelevel[i] = -3;
                            elename[i] = "バリバリ";
                            break;
                        }
                        else if (ele[i] >= -58)
                        {
                            elelevel[i] = -4;
                            elename[i] = "ガチガチ";
                            break;
                        }
                        else if (ele[i] >= -99)
                        {
                            elelevel[i] = -5;
                            elename[i] = "歯が欠ける";
                            break;
                        }
                        else if (ele[i] == -100)
                        {
                            elelevel[i] = -6;
                            elename[i] = "ほとんど岩石";
                            break;
                        }
                        else if (ele[i] >= -128)
                        {
                            elelevel[i] = -7;
                            elename[i] = "鋼鉄硬度";
                            break;
                        }
                        else if (ele[i] >= -158)
                        {
                            elelevel[i] = -8;
                            elename[i] = "超硬度";
                            break;
                        }
                        else if (ele[i] >= -197)
                        {
                            elelevel[i] = -9;
                            elename[i] = "破壊不能";
                            break;
                        }
                        else
                        {
                            elelevel[i] = -10;
                            elename[i] = "完全剛体";
                            break;
                        }
                    case 6://shape
                        if (ele[i] == 300)
                        {
                            elelevel[i] = 11;
                            elename[i] = "神秘の形状";
                            break;
                        }
                        else if (ele[i] >= 262)
                        {
                            elelevel[i] = 10;
                            elename[i] = "国宝形状";
                            break;
                        }
                        else if (ele[i] >= 232)
                        {
                            elelevel[i] = 9;
                            elename[i] = "感動的な形";
                            break;
                        }
                        else if (ele[i] >= 201)
                        {
                            elelevel[i] = 8;
                            elename[i] = "魅惑の形状";
                            break;
                        }
                        else if (ele[i] == 200)
                        {
                            elelevel[i] = 7;
                            elename[i] = "稀少形状";
                            break;
                        }
                        else if (ele[i] >= 162)
                        {
                            elelevel[i] = 6;
                            elename[i] = "アートな形";
                            break;
                        }
                        else if (ele[i] >= 132)
                        {
                            elelevel[i] = 5;
                            elename[i] = "ふしぎな形";
                            break;
                        }
                        else if (ele[i] >= 101)
                        {
                            elelevel[i] = 4;
                            elename[i] = "きれいな形";
                            break;
                        }
                        else if (ele[i] == 100)
                        {
                            elelevel[i] = 3;
                            elename[i] = "珍しい形";
                            break;
                        }
                        else if (ele[i] >= 73)
                        {
                            elelevel[i] = 2;
                            elename[i] = "陽気な形";
                            break;
                        }
                        else if (ele[i] >= 43)
                        {
                            elelevel[i] = 1;
                            elename[i] = "面白形状";
                            break;
                        }
                        else if (ele[i] == 40)
                        {
                            elelevel[i] = 0;
                            elename[i] = "";
                            break;
                        }
                        else if (ele[i] >= 3)
                        {
                            elelevel[i] = -1;
                            elename[i] = "おかしな形";
                            break;
                        }
                        else if (ele[i] == 0)
                        {
                            elelevel[i] = -2;
                            elename[i] = "崩れ形状";
                            break;
                        }
                        else if (ele[i] >= -28)
                        {
                            elelevel[i] = -3;
                            elename[i] = "いやな形";
                            break;
                        }
                        else if (ele[i] >= -58)
                        {
                            elelevel[i] = -4;
                            elename[i] = "みにくい形";
                            break;
                        }
                        else if (ele[i] >= -99)
                        {
                            elelevel[i] = -5;
                            elename[i] = "ぶきみな形";
                            break;
                        }
                        else if (ele[i] == -100)
                        {
                            elelevel[i] = -6;
                            elename[i] = "危険形状";
                            break;
                        }
                        else if (ele[i] >= -128)
                        {
                            elelevel[i] = -7;
                            elename[i] = "ヤバい形";
                            break;
                        }
                        else if (ele[i] >= -158)
                        {
                            elelevel[i] = -8;
                            elename[i] = "恐怖形状";
                            break;
                        }
                        else if (ele[i] >= -197)
                        {
                            elelevel[i] = -9;
                            elename[i] = "狂気の形";
                            break;
                        }
                        else
                        {
                            elelevel[i] = -10;
                            elename[i] = "魔神形状";
                            break;
                        }
                    case 7://flavor
                        if (ele[i] == 300)
                        {
                            elelevel[i] = 11;
                            elename[i] = "伝説風味";
                            break;
                        }
                        else if (ele[i] >= 262)
                        {
                            elelevel[i] = 10;
                            elename[i] = "うまうまうま";
                            break;
                        }
                        else if (ele[i] >= 232)
                        {
                            elelevel[i] = 9;
                            elename[i] = "魅惑の風味";
                            break;
                        }
                        else if (ele[i] >= 201)
                        {
                            elelevel[i] = 8;
                            elename[i] = "トレビアーン";
                            break;
                        }
                        else if (ele[i] == 200)
                        {
                            elelevel[i] = 7;
                            elename[i] = "うまうま";
                            break;
                        }
                        else if (ele[i] >= 162)
                        {
                            elelevel[i] = 6;
                            elename[i] = "絶妙隠し味";
                            break;
                        }
                        else if (ele[i] >= 132)
                        {
                            elelevel[i] = 5;
                            elename[i] = "デリシャス";
                            break;
                        }
                        else if (ele[i] >= 101)
                        {
                            elelevel[i] = 4;
                            elename[i] = "ほのかな滋味";
                            break;
                        }
                        else if (ele[i] == 100)
                        {
                            elelevel[i] = 3;
                            elename[i] = "良好風味";
                            break;
                        }
                        else if (ele[i] >= 73)
                        {
                            elelevel[i] = 2;
                            elename[i] = "うま味";
                            break;
                        }
                        else if (ele[i] >= 43)
                        {
                            elelevel[i] = 1;
                            elename[i] = "まあまあ";
                            break;
                        }
                        else if (ele[i] == 40)
                        {
                            elelevel[i] = 0;
                            elename[i] = "";
                            break;
                        }
                        else if (ele[i] >= 3)
                        {
                            elelevel[i] = -1;
                            elename[i] = "いまいち風味";
                            break;
                        }
                        else if (ele[i] == 0)
                        {
                            elelevel[i] = 2;
                            elename[i] = "味なし";
                            break;
                        }
                        else if (ele[i] >= -28)
                        {
                            elelevel[i] = -3;
                            elename[i] = "いやな後味";
                            break;
                        }
                        else if (ele[i] >= -58)
                        {
                            elelevel[i] = -4;
                            elename[i] = "金属風味";
                            break;
                        }
                        else if (ele[i] >= -99)
                        {
                            elelevel[i] = -5;
                            elename[i] = "トリハダ風味";
                            break;
                        }
                        else if (ele[i] == -100)
                        {
                            elelevel[i] = -6;
                            elename[i] = "悪寒風味";
                            break;
                        }
                        else if (ele[i] >= -128)
                        {
                            elelevel[i] = -7;
                            elename[i] = "雑巾風味";
                            break;
                        }
                        else if (ele[i] >= -158)
                        {
                            elelevel[i] = -8;
                            elename[i] = "気絶の風味";
                            break;
                        }
                        else if (ele[i] >= -197)
                        {
                            elelevel[i] = -9;
                            elename[i] = "殺人風味";
                            break;
                        }
                        else
                        {
                            elelevel[i] = -10;
                            elename[i] = "破滅の風味";
                            break;
                        }
                    case 8://smell
                        if (ele[i] == 300)
                        {
                            elelevel[i] = 11;
                            elename[i] = "癒しの芳香";
                            break;
                        }
                        else if (ele[i] >= 262)
                        {
                            elelevel[i] = 10;
                            elename[i] = "天国芳香";
                            break;
                        }
                        else if (ele[i] >= 232)
                        {
                            elelevel[i] = 9;
                            elename[i] = "神秘芳香";
                            break;
                        }
                        else if (ele[i] >= 201)
                        {
                            elelevel[i] = 8;
                            elename[i] = "超芳香";
                            break;
                        }
                        else if (ele[i] == 200)
                        {
                            elelevel[i] = 7;
                            elename[i] = "幸福芳香";
                            break;
                        }
                        else if (ele[i] >= 162)
                        {
                            elelevel[i] = 6;
                            elename[i] = "うっとり芳香";
                            break;
                        }
                        else if (ele[i] >= 132)
                        {
                            elelevel[i] = 5;
                            elename[i] = "清涼芳香";
                            break;
                        }
                        else if (ele[i] >= 101)
                        {
                            elelevel[i] = 4;
                            elename[i] = "落ちつく香り";
                            break;
                        }
                        else if (ele[i] == 100)
                        {
                            elelevel[i] = 3;
                            elename[i] = "芳香";
                            break;
                        }
                        else if (ele[i] >= 73)
                        {
                            elelevel[i] = 2;
                            elename[i] = "よい香り";
                            break;
                        }
                        else if (ele[i] >= 43)
                        {
                            elelevel[i] = 1;
                            elename[i] = "かすかな香り";
                            break;
                        }
                        else if (ele[i] == 40)
                        {
                            elelevel[i] = 0;
                            elename[i] = "";
                            break;
                        }
                        else if (ele[i] >= 3)
                        {
                            elelevel[i] = -1;
                            elename[i] = "気になる匂い";
                            break;
                        }
                        else if (ele[i] == 0)
                        {
                            elelevel[i] = -2;
                            elename[i] = "悪い匂い";
                            break;
                        }
                        else if (ele[i] >= -28)
                        {
                            elelevel[i] = -3;
                            elename[i] = "子犬の匂い";
                            break;
                        }
                        else if (ele[i] >= -58)
                        {
                            elelevel[i] = -4;
                            elename[i] = "刺激臭";
                            break;
                        }
                        else if (ele[i] >= -99)
                        {
                            elelevel[i] = -5;
                            elename[i] = "鼻曲がり集";
                            break;
                        }
                        else if (ele[i] == -100)
                        {
                            elelevel[i] = -6;
                            elename[i] = "大悪臭";
                            break;
                        }
                        else if (ele[i] >= -128)
                        {
                            elelevel[i] = -7;
                            elename[i] = "腐敗臭";
                            break;
                        }
                        else if (ele[i] >= -158)
                        {
                            elelevel[i] = -8;
                            elename[i] = "危険な悪臭";
                            break;
                        }
                        else if (ele[i] >= -197)
                        {
                            elelevel[i] = -9;
                            elename[i] = "失神悪臭";
                            break;
                        }
                        else
                        {
                            elelevel[i] = -10;
                            elename[i] = "悪夢の匂い";
                            break;
                        }
                    case 9://sound
                        if (ele[i] == 300)
                        {
                            elelevel[i] = 11;
                            elename[i] = "天上の調べ";
                            break;
                        }
                        else if (ele[i] >= 262)
                        {
                            elelevel[i] = 10;
                            elename[i] = "高貴音楽";
                            break;
                        }
                        else if (ele[i] >= 232)
                        {
                            elelevel[i] = 9;
                            elename[i] = "天使の歌声";
                            break;
                        }
                        else if (ele[i] >= 201)
                        {
                            elelevel[i] = 8;
                            elename[i] = "ハーモニー";
                            break;
                        }
                        else if (ele[i] == 200)
                        {
                            elelevel[i] = 7;
                            elename[i] = "感動音楽";
                            break;
                        }
                        else if (ele[i] >= 162)
                        {
                            elelevel[i] = 6;
                            elename[i] = "野菜ブルース";
                            break;
                        }
                        else if (ele[i] >= 132)
                        {
                            elelevel[i] = 5;
                            elename[i] = "風鈴兼用";
                            break;
                        }
                        else if (ele[i] >= 101)
                        {
                            elelevel[i] = 4;
                            elename[i] = "草笛吹き";
                            break;
                        }
                        else if (ele[i] == 100)
                        {
                            elelevel[i] = 3;
                            elename[i] = "快適リズム";
                            break;
                        }
                        else if (ele[i] >= 73)
                        {
                            elelevel[i] = 2;
                            elename[i] = "ドラマー";
                            break;
                        }
                        else if (ele[i] >= 43)
                        {
                            elelevel[i] = 1;
                            elename[i] = "かすかな音色";
                            break;
                        }
                        else if (ele[i] == 40)
                        {
                            elelevel[i] = 0;
                            elename[i] = "";
                            break;
                        }
                        else if (ele[i] >= 3)
                        {
                            elelevel[i] = -1;
                            elename[i] = "気になる音";
                            break;
                        }
                        else if (ele[i] == 0)
                        {
                            elelevel[i] = -2;
                            elename[i] = "不協和音";
                            break;
                        }
                        else if (ele[i] >= -28)
                        {
                            elelevel[i] = -3;
                            elename[i] = "歯ぎしり";
                            break;
                        }
                        else if (ele[i] >= -58)
                        {
                            elelevel[i] = -4;
                            elename[i] = "誰かの悪口";
                            break;
                        }
                        else if (ele[i] >= -99)
                        {
                            elelevel[i] = -5;
                            elename[i] = "親父の小言";
                            break;
                        }
                        else if (ele[i] == -100)
                        {
                            elelevel[i] = -6;
                            elename[i] = "迷惑騒音";
                            break;
                        }
                        else if (ele[i] >= -128)
                        {
                            elelevel[i] = -7;
                            elename[i] = "工事現場";
                            break;
                        }
                        else if (ele[i] >= -158)
                        {
                            elelevel[i] = -8;
                            elename[i] = "夫婦喧嘩";
                            break;
                        }
                        else if (ele[i] >= -197)
                        {
                            elelevel[i] = -9;
                            elename[i] = "絶叫悲鳴";
                            break;
                        }
                        else
                        {
                            elelevel[i] = -10;
                            elename[i] = "究極ノイズ";
                            break;
                        }

                }

            }
        }

        //今のメンデル数の野菜が存在するか
        public Boolean mendelok(int mend)
        {
            switch (mend)
            {
                case 2:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                case 30:
                case 45:
                case 60:
                case 90:
                case 120:
                case 150:
                case 300:
                case 450:
                case 600:
                case 1050:
                case 1650:
                    return true;
            }
            return false;
        }

        //２つの種の遺伝情報を混ぜる
        public void mixpara(seed seed1, seed seed2)
        {
            pure = seed1.pure && seed2.pure;

            int mend = seed1.mendel + seed2.mendel;//足し合わせ
            int dep = (seed1.department + seed2.department) / -1;//科の設定
            if (seed1.department == seed2.department)//同じ科の場合は突然変異で別の科にはならない
            {
                dep = seed1.department;
                if (seed1.mendel == seed2.mendel)//さらに同じメンデル数なら同じ種類の種ができる
                    mend = seed1.mendel;
            }

            if (mendelok(mend) == true)//新種の種が存在する場合
            {
                Random r1 = new Random();
                switch (r1.Next(3))//乱数でどの種類にするかを決定
                {
                    case 0:
                        mend = seed1.mendel;
                        dep = seed1.department;
                        break;
                    case 1:
                        mend = seed2.mendel;
                        dep = seed2.department;
                        break;
                }
            }
            else
            {
                Random r2 = new Random();
                switch (r2.Next(2))
                {
                    case 0:
                        mend = seed1.mendel;
                        dep = seed1.department;
                        break;
                    case 1:
                        mend = seed2.mendel;
                        dep = seed2.department;
                        break;
                }
            }
            mendel = mend;
            department = dep;

            nameset();

            int l = info.Length;

            Random r3 = new Random();
            for (int i = 0; i < info.GetLength(0); i++)//各要素の遺伝情報をどっちを採用するか決定
            {
                if (r3.Next(2) == 1)
                {
                    for (int j = 0; j < l / info.GetLength(0); j++)
                    {
                        if (max >= seed1.element[i])
                        {
                            info[i, j] = seed1.info[i, j];
                        }
                        else
                            info[i, j] = true;
                    }
                    fix[i] = seed1.fix[i];
                }
                else
                {
                    for (int j = 0; j < l / info.GetLength(0); j++)
                        if (max >= seed2.element[i])
                            info[i, j] = seed2.info[i, j];
                        else
                            info[i, j] = true;
                    fix[i] = seed2.fix[i];
                }
            }
        }

        //強化種交配（第一引数がベースで第二は強化種
        public void mixparas(seed seed1, seed seed2)//1 base 2 kyouka
        {
            //メンデル科と種類決定
            mendel = seed1.mendel;
            department = seed1.department;
            nameset();

            int stp = seed2.strengp;
            int l = info.Length;
            for (int i = 0; i < info.GetLength(0); i++)
            {
                for (int j = 0; j < l / info.GetLength(0); j++)
                    info[i, j] = seed1.info[i, j];
                fix[i] = seed1.fix[i];
            }
            while (stp != 0)//強化ポイント０になるか固定値到達までやる
            {
                if (info[seed2.strengele, 0] == info[seed2.strengele, 1])
                    if (info[seed2.strengele, 1] == info[seed2.strengele, 2])
                        if (info[seed2.strengele, 2] == info[seed2.strengele, 3])
                            if (info[seed2.strengele, 3] == info[seed2.strengele, 4])
                                if (info[seed2.strengele, 4] == info[seed2.strengele, 5])
                                    if (info[seed2.strengele, 5] == info[seed2.strengele, 6])
                                        if (info[seed2.strengele, 6] == info[seed2.strengele, 7])
                                        {
                                            //マイナスかプラスでちゃんと判別する
                                            if (info[seed2.strengele, 6] == true && seed2.strengp > 0)
                                                break;
                                            else if (info[seed2.strengele, 6] == false && seed2.strengp < 0)
                                                break;
                                        }

                Random r4 = new Random();//どこの遺伝情報を変化させるかの設定乱数
                int x = r4.Next() % 8;
                //強化できれば強化する
                if (info[seed2.strengele, x] == false && stp > 0)
                {
                    info[seed2.strengele, x] = true;
                    stp--;
                }
                else if (info[seed2.strengele, x] == true && stp < 0)
                {
                    info[seed2.strengele, x] = false;
                    stp++;
                }
            }
        }

        //突然変異
        public void henni()
        {
            //各変異属性を見てその部分をランダムで変化させる（一箇所
            if (mut1 != 0)
            {
                Random r1 = new Random();
                int x = r1.Next() % 8;
                info[mut1 - 1, x] = !info[mut1 - 1, x];
            }

            if (mut2 != 0)
            {
                Random r1 = new Random();
                int x = r1.Next() % 8;
                info[mut2 - 1, x] = !info[mut2 - 1, x];
            }
        }

        //強化種を作る
        public void kyouka()
        {
            //仮にできた種の変異属性からその属性の強化種を作るかを設定
            Random r1 = new Random();

            if (r1.Next(3) == 0)
            {
                //変異が１つか２つか
                if (mut2 != 0)//2つの場合
                {
                    Random r2 = new Random();
                    if (r2.Next(2) == 0)
                    {
                        //属性地でできる種を決定
                        if (element[mut1 - 1] > 100 && element[mut1 - 1] <= 200)
                        {
                            strengset(1);
                        }
                        else if (element[mut1 - 1] > 200)
                        {
                            strengset(2);
                        }
                        else if (element[mut1 - 1] >= -100 && element[mut1 - 1] < 0)
                        {
                            strengset(-1);
                        }
                        else if (element[mut1 - 1] < -100)
                        {
                            strengset(-2);
                        }
                    }
                    else
                    {
                        if (element[mut2 - 1] > 100 && element[mut2 - 1] <= 200)
                        {
                            strengset(1);
                        }
                        else if (element[mut2 - 1] > 200)
                        {
                            strengset(2);
                        }
                        else if (element[mut2 - 1] >= -100 && element[mut2 - 1] < 0)
                        {
                            strengset(-1);
                        }
                        else if (element[mut2 - 1] < -100)
                        {
                            strengset(-2);
                        }

                    }
                }
                else//１つ
                {

                    if (element[mut1 - 1] >= 100 && element[mut1 - 1] <= 200)
                    {
                        strengset(1);
                    }
                    else if (element[mut1 - 1] > 200)
                    {
                        strengset(2);
                    }
                    else if (element[mut1 - 1] >= -100 && element[mut1 - 1] < 0)
                    {
                        strengset(-1);
                    }
                    else if (element[mut1 - 1] < -100)
                    {
                        strengset(-2);
                    }
                }
            }
        }

        //強化ポイントの設定
        public void strengset(int point)
        {
            pure = false;
            strengp = point;
            strengele = mut1 - 1;
            mendel = 0;
            department = 2;
        }

        //初期種の遺伝情報設定（全属性４０
        public void defpara()
        {
            int l = info.Length;
            for (int j = 0; j < l / info.GetLength(0); j++)
                for (int i = 0; i < info.GetLength(0); i++)
                    if (j == 0 || j == 3 || j == 5)
                    {
                        info[i, j] = true;
                    }
                    else
                        info[i, j] = false;
            l = fix.Length;
            for (int i = 0; i < l; i++)
                fix[i] = 0;
            if (strengp == 0)
                title = "初期";
            paraset();
        }

        //一番高い属性を見て設定
        public void most()
        {
            int m = element.Max() - 40;
            int n = element.Min() - 40;

            if (Math.Abs(m) < Math.Abs(n))
                m = n;
            int i = 0;
            int j = 0;
            while (i < 10)
            {
                if ((element[i] - 40) == m)
                {
                    j = i;
                    if (j == mut1 - 1)
                        break;
                    else if (j == mut2 - 1)
                        break;
                }
                i++;
            }
            repele = elename[j];
        }

        //各属性の名称
        public void strset()
        {
            switch (strengele)
            {
                case 0:
                    title = "大きさ";
                    break;
                case 1:
                    title = "重さ";
                    break;
                case 2:
                    title = "模様";
                    break;
                case 3:
                    title = "栄養";
                    break;
                case 4:
                    title = "糖度";
                    break;
                case 5:
                    title = "食感";
                    break;
                case 6:
                    title = "形状";
                    break;
                case 7:
                    title = "風味";
                    break;
                case 8:
                    title = "匂い";
                    break;
                case 9:
                    title = "音色";
                    break;
            }
            name = "強化種";
            repele = "レベル" + strengp;
            defpara();
        }

        //野菜から種を獲得
        public void getseed(vagetable v)
        {
            //各パラメーターはコピー
            finname = v.finname;
            name = v.name;
            title = v.title;
            id = v.id;
            pure = v.pure;
            syoki = v.syoki;
            department = v.department;
            mendel = v.mendel;
            info = v.info;
            fix = v.fix;
            element = v.element;
            elename = v.elename;
            elelevel = v.elelevel;

            sum = element.Sum();

            //成長状態によって欠くできる種の数を決定
            if (v.mat == 4)
                items = 1;
            else if (v.mat == 5)
                items = 2;
            else if (v.mat == 6)
                items = 3;

            //各種名前をセット
            nameset();
            paraset();
            sum = element.Sum();
            title = titleset(sum);
            elenameset(element);
            most();
            if (syoki == true)
            {
                title = "初期";
                finname = title + repele + name;
            }
            else
                finname = title + repele + name + id;

            setprice();

            if (element[0] > 150)
                grow++;
        }

        //値段設定
        public void setprice()
        {
            //各属性のレベルを見て価格を決定
            for (int i = 0; i < elelevel.Length; i++)
            {
                switch (elelevel[i])
                {
                    case -10:
                        if (mut1 - 1 == i || mut2 - 1 == i)
                            bonusp += 1000;
                        else
                            bonusp += 500;
                        break;
                    case -9:
                        if (mut1 - 1 == i || mut2 - 1 == i)
                            bonusp += 780;
                        else
                            bonusp += 390;
                        break;
                    case -8:
                        if (mut1 - 1 == i || mut2 - 1 == i)
                            bonusp += 720;
                        else
                            bonusp += 360;
                        break;
                    case -7:
                        if (mut1 - 1 == i || mut2 - 1 == i)
                            bonusp += 660;
                        else
                            bonusp += 330;
                        break;
                    case -6:
                        if (mut1 - 1 == i || mut2 - 1 == i)
                            bonusp += 600;
                        else
                            bonusp += 300;
                        break;
                    case -5:
                        if (mut1 - 1 == i || mut2 - 1 == i)
                            bonusp += 200;
                        else
                            bonusp += 100;
                        break;
                    case -4:
                        if (mut1 - 1 == i || mut2 - 1 == i)
                            bonusp += -160;
                        else
                            bonusp += -80;
                        break;
                    case -3:
                        if (mut1 - 1 == i || mut2 - 1 == i)
                            bonusp += -100;
                        else
                            bonusp += -50;
                        break;
                    case -2:
                        if (mut1 - 1 == i || mut2 - 1 == i)
                            bonusp += -60;
                        else
                            bonusp += -30;
                        break;
                    case -1:
                        if (mut1 - 1 == i || mut2 - 1 == i)
                            bonusp += -10;
                        else
                            bonusp += -5;
                        break;
                    case 0:
                        bonusp += 0;
                        break;
                    case 1:
                        if (mut1 - 1 == i || mut2 - 1 == i)
                            bonusp += 10;
                        else
                            bonusp += 5;
                        break;
                    case 2:
                        if (mut1 - 1 == i || mut2 - 1 == i)
                            bonusp += 20;
                        else
                            bonusp += 10;
                        break;
                    case 3:
                        if (mut1 - 1 == i || mut2 - 1 == i)
                            bonusp += 60;
                        else
                            bonusp += 30;
                        break;
                    case 4:
                        if (mut1 - 1 == i || mut2 - 1 == i)
                            bonusp += 80;
                        else
                            bonusp += 40;
                        break;
                    case 5:
                        if (mut1 - 1 == i || mut2 - 1 == i)
                            bonusp += 100;
                        else
                            bonusp += 50;
                        break;
                    case 6:
                        if (mut1 - 1 == i || mut2 - 1 == i)
                            bonusp += 120;
                        else
                            bonusp += 60;
                        break;
                    case 7:
                        if (mut1 - 1 == i || mut2 - 1 == i)
                            bonusp += 200;
                        else
                            bonusp += 100;
                        break;
                    case 8:
                        if (mut1 - 1 == i || mut2 - 1 == i)
                            bonusp += 240;
                        else
                            bonusp += 120;
                        break;
                    case 9:
                        if (mut1 - 1 == i || mut2 - 1 == i)
                            bonusp += 280;
                        else
                            bonusp += 140;
                        break;
                    case 10:
                        if (mut1 - 1 == i || mut2 - 1 == i)
                            bonusp += 320;
                        else
                            bonusp += 160;
                        break;
                    case 11:
                        if (mut1 - 1 == i || mut2 - 1 == i)
                            bonusp += 600;
                        else
                            bonusp += 300;
                        break;
                }
            }
            price = basep + bonusp;
            if (price < 10)//値段の下限は１０
                price = 10;
        }

    }
}
