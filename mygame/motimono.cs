using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    //各種持ち物のデータとかその辺（だいたいセーブしたりします
    public static class motimono
    {
        internal static List<seed> seedlist = new List<seed>();
        internal static List<vagetable> vaglist = new List<vagetable>();
        internal static List<trap> traplist = new List<trap>();
        internal static trap[,] tfield = new trap[9, 9];

        //0設置なし 1設置されてる 2上側 3右側 4下側 5左側 6上側（接触） 7右側（接触） 8下側（接触） 9左側（接触） 
        internal static int[,] trapenable = new int[9, 9];
        internal static vagetable[,] vaghatake = new vagetable[4, 6];

        internal static List<baboo> baboolist = new List<baboo>();
        internal static List<baboo> todaybaboo=new List<baboo>();

        internal static List<trap> pedrotrap = new List<trap>();//ペドロさんのトラップリスト
        internal static List<seed> pedroseed = new List<seed>();//ペドロさんの種リスト


        internal static int mode = 0;//移動位置
        internal static int hatakemax = 0;//畑の数

        public static trappoint[,] tpoint = new trappoint[9, 9];
        public static trappoint[,] tpointd = new trappoint[9, 9];
        
        public static List<point> trappointset(trap settrap,int x,int y)
        {
            List<point> traprange = new List<point>();
            if (settrap.type == 4)//ジャンプ台
            {
                if (settrap.grade < 2)//普通の
                {
                    switch (settrap.direction)
                    {
                        case 0:
                            traprange.Add(new point(x + 1, y + 1));
                            break;
                        case 1:
                            traprange.Add(new point(x + 1, y - 1));
                            break;
                        case 2:
                            traprange.Add(new point(x - 1, y - 1));
                            break;
                        case 3:
                            traprange.Add(new point(x - 1, y + 1));
                            break;
                    }
                }
                else if (settrap.grade < 4)//桂馬R
                {
                    switch (settrap.direction)
                    {
                        case 0:
                            traprange.Add(new point(x + 1, y + 2));
                            break;
                        case 1:
                            traprange.Add(new point(x + 2, y - 1));
                            break;
                        case 2:
                            traprange.Add(new point(x - 1, y - 2));
                            break;
                        case 3:
                            traprange.Add(new point(x - 2, y + 1));
                            break;
                    }
                }
                else//桂馬L
                {
                    switch (settrap.direction)
                    {
                        case 0:
                            traprange.Add(new point(x - 1, y + 2));
                            break;
                        case 1:
                            traprange.Add(new point(x + 2, y + 1));
                            break;
                        case 2:
                            traprange.Add(new point(x + 1, y - 2));
                            break;
                        case 3:
                            traprange.Add(new point(x - 2, y - 1));
                            break;
                    }
                }
            }
            else if (settrap.type == 3)//扇風機
            {
                if (settrap.grade < 2)//2マス
                {
                    switch (settrap.direction)
                    {
                        case 0:
                            if (y + 3 > 8)
                                traprange.Add(new point(x, 8));
                            else
                                traprange.Add(new point(x, y + 3));
                            break;
                        case 1:
                            if (x + 3 > 8)
                                traprange.Add(new point(8, y));
                            else
                                traprange.Add(new point(x + 3, y));
                            break;
                        case 2:
                            if (y - 3 < -2)
                                traprange.Add(new point(x, -2));
                            else
                                traprange.Add(new point(x, y - 3));
                            break;
                        case 3:
                            if (x - 3 < 0)
                                traprange.Add(new point(0, y));
                            else
                                traprange.Add(new point(x - 3, y));
                            break;
                    }
                }
                else//3マス
                {
                    switch (settrap.direction)
                    {
                        case 0:
                            if (y + 4 > 8)
                                traprange.Add(new point(x, 8));
                            else
                                traprange.Add(new point(x, y + 4));
                            break;
                        case 1:
                            if (x + 4 > 8)
                                traprange.Add(new point(8, y));
                            else
                                traprange.Add(new point(x + 4, y));
                            break;
                        case 2:
                            if (y - 4 < -2)
                                traprange.Add(new point(x, -2));
                            else
                                traprange.Add(new point(x, y - 4));
                            break;
                        case 3:
                            if (x - 4 < 0)
                                traprange.Add(new point(0, y));
                            else
                                traprange.Add(new point(x - 4, y));
                            break;
                    }
                }
            }
            else if (settrap.type == 6 || (settrap.type >= 9 && settrap.type <= 11) || ((settrap.type == 7 || settrap.type == 8) && settrap.grade == 0))
            {
                switch (settrap.direction)
                {
                    case 0:
                        traprange.Add(new point(x, y + 1));
                        break;
                    case 1:
                        traprange.Add(new point(x + 1, y));
                        break;
                    case 2:
                        traprange.Add(new point(x, y - 1));
                        break;
                    case 3:
                        traprange.Add(new point(x - 1, y));
                        break;
                }
            }
            else if ((settrap.type == 7 || settrap.type == 8) && settrap.grade == 1)
            {
                if (y != 8)
                    traprange.Add(new point(x, y + 1));
                if (x != 8)
                    traprange.Add(new point(x + 1, y));
                traprange.Add(new point(x, y - 1));
                if (x == 0)
                    traprange.Add(new point(x - 1, y));
            }
            else if (settrap.type == 12)
            {
                switch (settrap.grade)
                {
                    case 0:
                    case 1:
                        for (int i = 1; i <= 2; i++)
                        {
                            if (x + i < 9)
                            {
                                traprange.Add(new point(x + i, y));
                            }
                            if (x - i >= 0)
                            {
                                traprange.Add(new point(x - i, y));
                            }
                            if (y + i < 9)
                            {
                                traprange.Add(new point(x, y+i));
                            }
                            if (y - i >= 0)
                            {
                                traprange.Add(new point(x, y-i));
                            }
                        }
                        break;
                    case 2:
                    case 3:
                        for (int i = 1; i <= 3; i++)
                        {
                            if (x + i < 9)
                            {
                                motimono.tpoint[x + i, y].tplist.Add(new point(x, y));
                                motimono.tpointd[x, y].tplist.Add(new point(x + i, y));
                            }
                            if (x - i >= 0)
                            {
                                motimono.tpoint[x - i, y].tplist.Add(new point(x, y));
                                motimono.tpointd[x, y].tplist.Add(new point(x - i, y));
                            }
                            if (y + i < 9)
                            {
                                motimono.tpoint[x, y + i].tplist.Add(new point(x, y));
                                motimono.tpointd[x, y].tplist.Add(new point(x, y + i));
                            }
                            if (y - i >= 0)
                            {
                                motimono.tpoint[x, y - i].tplist.Add(new point(x, y));
                                motimono.tpointd[x, y].tplist.Add(new point(x, y - i));
                            }
                        }
                        break;
                }
            }
            return traprange;
        }
        

        //種のソート
        public static void seedsort()
        {
            List<seed> asortlist = seedlist.FindAll(s => s.department == -1);
            List<seed> bsortlist = seedlist.FindAll(s => s.department == 0);
            List<seed> csortlist = seedlist.FindAll(s => s.department == 1);
            List<seed> ssortlist = seedlist.FindAll(s => s.department == 2);            

            seedswap1(ref asortlist);
            seedswap1(ref bsortlist);
            seedswap1(ref csortlist);

            seedlist.Clear();
            seedlist.AddRange(asortlist);
            seedlist.AddRange(bsortlist);
            seedlist.AddRange(csortlist);
            seedlist.AddRange(ssortlist);
        }

        //ソートの肝（バブルです
        public static void seedswap1(ref List<seed> slist)
        {
            for (int i = 0; i < slist.Count; i++)
                for (int j = i + 1; j < slist.Count; j++)
                    if (slist[i].mendel > slist[j].mendel ||
                        (slist[i].mendel == slist[j].mendel && (slist[i].rank > slist[j].rank && slist[i].syoki == false)) ||
                        (slist[i].name == slist[j].name && slist[i].title == slist[j].title && slist[i].repele == slist[j].repele && slist[i].id > slist[j].id))
                    {
                        seed s = new seed();
                        s = slist[i];
                        slist[i] = slist[j];
                        slist[j] = s;
                    }
        }

        //トラップのソート（これもバブル
        public static void trapsort()
        {
            for (int i = 0; i < traplist.Count; i++)
                for (int j = i + 1; j < traplist.Count; j++)
                    if (traplist[i].type > traplist[j].type || (traplist[i].type == traplist[j].type && traplist[i].grade > traplist[j].grade))
                    {
                        trap t = traplist[i];
                        traplist[i] = traplist[j];
                        traplist[j] = t;
                    }
        }

        //初期種の生成
        public static void syoki(int men, int dep, int count)
        {
            seed s = new seed();
            s.baseset(men, dep);
            s.items = count;
            int find = seedlist.FindIndex(se => se.syoki == s.syoki && se.mendel == s.mendel && se.department == s.department);//かぶってるかチェック
            if (find != -1)//かぶってないときはついか
            {
                seedlist[find].items += count;
            }
            else
            {
                seedlist.Add(s);
                seedsort();
            }
        }

        //種の獲得
        public static void getseed(seed s)
        {
            Boolean nseed = true;//新しい種フラグ
            int find;
            //同じやつがいたらフラグを折る（種リスト野菜リスト畑野菜の全部探索
            if ((find=seedlist.FindIndex(se => se.yasaicheck(s) == true)) != -1)
            {
                seedlist[find].items += s.items;
                nseed = false;
            }
            if ((find = vaglist.FindIndex(v => v.yasaicheck(s) == true)) != -1 && nseed==true)
            {
                s.finname = vaglist[find].finname;
                seedlist.Add(s);
                nseed = false;
            }
            if(nseed==true)
                foreach (vagetable v in vaghatake)
                {
                    if (v != null)
                        if (v.yasaicheck(s))
                        {
                            s.finname = v.finname;
                            seedlist.Add(s);
                            nseed = false;
                            break;
                        }
                }

            //新しいのだった場合
            if (nseed == true)
            {
                Boolean loop2 = true;//ループ設定
                while (loop2 == true)
                {
                    loop2 = false;

                    //また全部で探索してIDかぶりしないようにする
                    List<seed> curseed = seedlist.FindAll(se => se.name == s.name);
                    foreach (seed se in curseed)
                        loop2 = s.idset(se);
                    List<vagetable> curvag = vaglist.FindAll(se => se.name == s.name);
                    foreach (vagetable v in curvag)
                        loop2 = s.idset(v);
                    foreach(vagetable v in vaghatake)
                        if (v != null)
                            loop2 = s.idset(v);
                }
                s.finname = s.title + s.repele + s.name + s.id;
                seedlist.Add(s);
            }

        }

        //トラップ獲得
        public static void gettrap(trap t, int count)
        {
            //同じやつがいるかチェックしてやる
            int find = traplist.FindIndex(tr => tr.type == t.type && tr.grade == t.grade);
            if (find != -1)
            {
                traplist[find].items += count;
            }
            else
                traplist.Add(t);

            trapsort();
        }


        //今日のバブーをセット（またテスト段階
        public static void settodaybaboo()
        {
            Random r1 = new Random();
            int x=r1.Next(baboolist.Count);
            todaybaboo.Add(baboolist[x]);
            baboolist.RemoveAt(x);
        }

        //バブーの進化（まだ
        public static void generatebaboo()
        {
            todaybaboo.Clear();
        }

        //初期のバブーを作る（まだ
        public static baboo syokibaboo()
        {
            baboo b = new baboo();
            return b;
        }
    }
}
