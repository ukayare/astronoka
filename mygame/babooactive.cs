﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Timers;

namespace WindowsFormsApplication1
{
    //バブーの行動
    public class babooactive
    {
        //インスタンス（動くバブーとフィールド）
        public babooactive(baboo b,trap[,] f)
        {
            this.baboo = b;
            this.field = f;
            yokomax = field.Length / field.GetLength(0);
            tatemax = field.GetLength(0);
            distcalcstart(4, 8);
            goalpointset(4, 8);
        }

        internal baboo baboo;//動くバブー

        //座標
        public point now = new point(4, 0);

        public point goalpoint;
        List<point> pointlist = new List<point>();//目標地点のリスト（エサ使用時の保持のため

        //方向0 up 1 right 2 down 3 left
        public int direction = 0;
        public int fakedirection;

        int[,] giveup = new int[9, 9];//あきらめ

        int yokomax;//横の長さ
        int tatemax;//縦の長さ

        trap[,] field;//フィールド
        public int[,] staying = new int[9, 9];//滞在時間
        public int[,] distance=new int[9,9];//ゴールまでの距離
        Boolean[,] walked = new Boolean[9, 9];//歩いたところ
        public Boolean[,] happen = new Boolean[9, 9];//起動した？

        public Boolean sennpufrag = false;//扇風機のフラグ
        public int senpudirection;//扇風機の行く方向
        int senpucount = 0;//扇風機で動くマスのカウント
        public Boolean torifrag = false;//トリモチフラグ
        int toricount = 0;//トリモチでとまるカウント
        public int[,] happeningcount = new int[9, 9];//何回起動した？（扇風機の限界設定

        public Boolean actioednfrag = false;//触った？
        public Boolean destruction = false;//破壊?
        public point destructpoint;

        public int farcount=0;

        //バトルスタート（まだ未実装
        public void start()
        {
            //ゴール座標にいくまで動く
            while (!(now.x == 4 && now.y == 8))
            {
                move();
                
            }
        }

        //各フラグの一括リセット
        private void fragreset()
        {
            sennpufrag = false;
            torifrag = false;
            actioednfrag = false;
        }

        //扇風機で動く
        public void senpumove()
        {
            //どこに動くのか
            switch (senpudirection)
            {//端っこなら動かない、んでカウント減らす
                case 0:
                    if (now.y != tatemax - 1)
                        now.y++;
                    senpucount--;
                    break;
                case 1:
                    if (now.x != yokomax - 1)
                        now.x++;
                    senpucount--;
                    break;
                case 2:
                    if (now.y != 0)
                        now.y--;
                    senpucount--;
                    break;
                case 3:
                    if (now.x != 0)
                        now.x--;
                    senpucount--;
                    break;
            }

            //カウント０ならフラグ折って終わり
            if (senpucount == 0)
                sennpufrag = false;
        }

        //方向転換
        private void turn()
        {
            staying[now.x, now.y]++;
            actioednfrag = false;//起動フラグを折る（これしないとたってた場合なぜか起動してしまうため
            switch (direction)
            {
                case 0:
                    if (now.y == tatemax - 1 || distance[now.x, now.y] > distance[now.x, now.y + 1])
                        farcount++;
                    break;
                case 1:
                    if (now.x == yokomax - 1 || distance[now.x, now.y] > distance[now.x + 1, now.y])
                        farcount++;
                    break;
                case 2:
                    if (now.y == 0 || distance[now.x, now.y] > distance[now.x, now.y - 1])
                        farcount++;
                    break;
                case 3:
                    if (now.x == 0 || distance[now.x, now.y] > distance[now.x - 1, now.y])
                        farcount++;
                    break;
            }
            if (baboo.leftright == false)
                direction = (direction + 1) % 4;//時計回りに方向転換
            else
                direction = (direction - 1) % 4;//時計回りに方向転換

            staying[now.x, now.y]++;
        }


        private Boolean farmoveflag()
        {

            return false;
        }

        public void move()
        {
            //向いてる方向
            switch (direction)
            {
                case 0:
                    //はじっこかすでに滞在しているところ、長期滞在しているところは行かない
                    if (now.y == tatemax - 1 || staying[now.x, now.y + 1] >= baboo.pointhate)
                    {
                        MessageBox.Show("test");
                        turn();
                    }
                    //なんか目の前にある場合
                    else if (field[now.x, now.y + 1] != null)
                    {
                        //嫌いならよける
                        if (baboo.hate[field[now.x, now.y + 1].type] >= 100)
                        {
                            MessageBox.Show("");
                            turn();
                        }
                        else
                        {
                            //攻撃的じゃない
                            if (baboo.vitality < 100)
                            {
                                //固定物ならよける
                                if (field[now.x, now.y + 1].kotei == true)
                                {
                                    turn();
                                }
                                //そのまま直進
                                else
                                {
                                    now.y++;
                                    fragreset();
                                }
                            }
                            //攻撃的
                            else
                            {
                                //固定物
                                if (field[now.x, now.y + 1].kotei == true)
                                {
                                    //あきらめてないならぶん殴る
                                    if (giveup[now.x, now.y + 1] < 100)
                                    {
                                        giveup[now.x, now.y + 1] += 30;//あきらめ度増加
                                        attack(field[now.x, now.y + 1]);
                                        staying[now.x, now.y]++;
                                    }
                                    //あきらめてたらもうよける
                                    else
                                    {
                                        turn();
                                    }
                                }
                                else
                                {
                                    //ここはジャンプすべきかもね
                                    now.y++;
                                    fragreset();
                                }
                            }
                        }
                    }
                    //もう滞在したくなかったら動く
                    else if (staying[now.x, now.y] >= baboo.pointhate)
                    {
                        now.y++;
                        fragreset();
                    }
                    //距離が近くならないんだったら回る
                    else if (distance[now.x, now.y + 1] >= distance[now.x, now.y])
                    {
                        turn();
                    }
                    //何もなければ直進
                    else
                    {
                        now.y++;
                        fragreset();
                    }
                    break;
                //以下同じ処理してる（同じ関数で渡せねーかなー方向ってのが意外とネック
                case 1:
                    if (now.x == yokomax - 1 || staying[now.x + 1, now.y] >= baboo.pointhate)
                    {
                        turn();
                    }
                    else if (field[now.x + 1, now.y] != null)
                    {
                        if (baboo.hate[field[now.x + 1, now.y].type] >= 100)
                        {
                            MessageBox.Show("");
                            turn();
                        }
                        else
                        {
                            if (baboo.vitality < 100)
                            {
                                if (field[now.x + 1, now.y].kotei == true)
                                {
                                    turn();
                                }
                                else
                                {
                                    now.x++;
                                    fragreset();
                                }
                            }
                            else
                            {
                                if (field[now.x + 1, now.y].kotei == true)
                                {
                                    if (giveup[now.x + 1, now.y] < 100)
                                    {
                                        giveup[now.x + 1, now.y] += 30;
                                        attack(field[now.x + 1, now.y]);
                                        staying[now.x, now.y]++;
                                    }
                                    else
                                        turn();
                                }
                                else
                                {
                                    now.x++;
                                    fragreset();
                                }
                            }
                        }
                    }
                    else if (staying[now.x, now.y] >= baboo.pointhate)
                    {
                        now.x++;
                        fragreset();
                    }
                    else if (distance[now.x + 1, now.y] >= distance[now.x, now.y])
                    {
                        turn();
                    }
                    else
                    {
                        now.x++;
                        fragreset();
                    }
                    break;
                case 2:
                    if (now.y == 0 || staying[now.x, now.y - 1] >= baboo.pointhate)
                    {
                        turn();
                    }
                    else if (field[now.x, now.y - 1] != null)
                    {
                        if (baboo.hate[field[now.x, now.y - 1].type] >= 100)
                        {
                            turn();
                        }
                        else
                        {
                            if (baboo.vitality < 100)
                            {
                                if (field[now.x, now.y - 1].kotei == true)
                                {
                                    turn();
                                }
                                else
                                {
                                    now.y--;
                                    fragreset();
                                }
                            }
                            else
                            {
                                if (field[now.x, now.y - 1].kotei == true)
                                {
                                    if (giveup[now.x, now.y - 1] < 100)
                                    {
                                        giveup[now.x, now.y - 1] += 30;
                                        attack(field[now.x, now.y - 1]);
                                        staying[now.x, now.y]++;
                                    }
                                    else
                                        turn();
                                }
                                else
                                {
                                    now.y--;
                                    fragreset();
                                }

                            }
                        }
                    }
                    else if (staying[now.x, now.y] >= baboo.pointhate)
                    {
                        now.y--;
                        fragreset();
                    }
                    else if (distance[now.x, now.y - 1] >= distance[now.x, now.y])
                    {
                        turn();
                    }
                    else
                    {
                        now.y--;
                        fragreset();
                    }
                    break;
                case 3:
                    if (now.x == 0 || staying[now.x - 1, now.y] >= baboo.pointhate)
                    {
                        turn();
                    }
                    else if (field[now.x - 1, now.y] != null)
                    {
                        if (baboo.hate[field[now.x - 1, now.y].type] >= 100)
                        {
                            turn();
                        }
                        else
                        {
                            if (baboo.vitality < 100)
                            {
                                if (field[now.x - 1, now.y].kotei == true)
                                {
                                    turn();
                                }
                                else
                                {
                                    now.x--;
                                    fragreset();
                                }
                            }
                            else
                            {
                                if (field[now.x - 1, now.y].kotei == true)
                                {
                                    if (giveup[now.x - 1, now.y] < 100)
                                    {
                                        giveup[now.x - 1, now.y] += 30;
                                        attack(field[now.x - 1, now.y]);
                                        staying[now.x, now.y]++;
                                    }
                                    else
                                        turn();
                                }
                                else
                                {
                                    now.x--;
                                    fragreset();
                                }
                            }
                        }
                    }
                    else if (staying[now.x, now.y] >= baboo.pointhate)
                    {
                        now.x--;
                        fragreset();
                    }
                    else if (distance[now.x - 1, now.y] >= distance[now.x, now.y])
                    {
                        turn();
                    }
                    else
                    {
                        now.x--;
                        fragreset();
                    }
                    break;
            }
            walked[now.x, now.y] = true;
        }

        public void esaeffect(point p)
        {
            pointset(goalpoint);
            goalpointset(p.x, p.y);
            distcalcstart(p.x, p.y);
            happen[p.x, p.y] = true;
        }

        //トラップの効果
        public void effect(trap t)
        {
            //起動回数が１０以上はもう起動しない（これ扇風機だけだなあとで変えよう
            if (happeningcount[now.x, now.y] < 10)
            {
                happeningcount[now.x, now.y]++;
                switch (t.type)
                {
                    case 3://扇風機
                        if (t.grade < 2)//２マスの場合
                        {
                            senpudirection = t.direction;//飛ばされる方向決定
                            sennpufrag = true;//フラグ立てる
                            senpucount = 2;//カウント設定
                        }
                        else if (t.grade < 4)//３マス（処理は基本同じ
                        {
                            senpudirection = t.direction;
                            sennpufrag = true;
                            senpucount = 3;
                        }
                        senpumove();//とりあえず一回起動（これしないとかかりっぱになっちゃう
                        break;
                    case 4://ジャンプ台
                        happen[now.x, now.y] = true;//起動したフラグ立てる
                        now = motimono.tpointd[now.x, now.y].tplist[0];
                        break;
                    case 5://ぐるぐる
                        happen[now.x, now.y] = true;//起動したフラグ立て
                        if (t.grade == 0 || t.grade == 3)//R
                        {
                            fakedirection = direction;
                            direction = (direction + 1) % 4;
                        }
                        else if (t.grade == 1 || t.grade == 4)//L
                        {
                            fakedirection = direction;
                            direction = (direction - 1) % 4;
                        }
                        else if (t.grade == 2)//U
                        {
                            fakedirection = direction;
                            direction = (direction - 1) % 4;
                        }
                        break;
                    case 6://冷水
                    case 7://パンチ
                    case 8://ビリビリ
                        happen[now.x, now.y] = true;//起動フラグ
                        baboo.stamina -= 10;//スタミナ減少（これはここでまた変更しよう
                        fragreset();//フラグリセット（しないと永遠にかかる
                        break;
                    case 9://風船サービス
                        happen[now.x, now.y] = true;//起動フラグ
                        baboo.heavy -= 50;
                        break;
                    case 10://米俵サービス
                        happen[now.x, now.y] = true;
                        baboo.heavy += 50;
                        break;
                    case 11://おめでとう
                        happen[now.x, now.y] = true;
                        for (int i = 0; i < baboo.hate.Length; i++)
                            baboo.hate[i] -= 10;
                        break;
                    case 12://エサ
                        break;
                    case 15://とりもち
                        if (toricount == 0 && torifrag == false)//引っかかった瞬間
                        {
                            //カウント設定
                            if (t.grade == 0)
                            {
                                toricount = 5;
                            }
                            else if (t.grade == 0)
                            {
                                toricount = 7;
                            }
                        }
                        else if (toricount != 0 || torifrag == false)//引っかかってる間
                        {
                            toricount--;
                            if (toricount == 0)//カウント０になったらフラグを折る
                                torifrag = true;
                        }
                        break;
                }
            }
        }

        private void destructpointset()
        {
            switch(direction){
                case 0:
                    destructpoint = new point(now.x, now.y + 1);
                    break;
                case 1:
                    destructpoint = new point(now.x + 1, now.y);
                    break;
                case 2:
                    destructpoint = new point(now.x, now.y - 1);
                    break;
                case 3:
                    destructpoint = new point(now.x - 1, now.y);
                    break;
            }
        }

        public Boolean attack(trap t)//攻撃（パンチだけなんで後で増やす
        {
            if (t.type == 12)
            {
                MessageBox.Show("もぐもぐ");
                destructpointset();
                motimono.trappointremove(destructpoint.x, destructpoint.y);
                motimono.tfield[destructpoint.x, destructpoint.y] = null;
                destruction = true;
                if (goalpoint.x == destructpoint.x && goalpoint.y == destructpoint.y)
                {
                    MessageBox.Show(goalpoint.x.ToString() + goalpoint.y.ToString());
                    goalpoint = pointlist[0];
                    MessageBox.Show(goalpoint.x.ToString() + goalpoint.y.ToString());
                    distcalcstart(goalpoint.x, goalpoint.y);
                    pointlist.RemoveAt(0);
                }
                else
                {
                    MessageBox.Show(goalpoint.x.ToString() + goalpoint.y.ToString());
                    pointlist.RemoveAll(p => p.x == destructpoint.x && p.y == destructpoint.y);
                }
                return true;
            }
            MessageBox.Show("バブーパンチ！");
            if (t.happen == 3)
            {
                if ((t.type == 7 || t.type == 8) && t.grade == 1)
                {
                    actioednfrag = true;
                }
                else if(Math.Abs(t.direction-direction)==2)
                {
                    actioednfrag = true;                    
                }
            }
            return false;
        }

        //ダイクストラで目標までの距離をセット
        private void distcalcstart(int x, int y)
        {
            //擬似的にでかい距離をセット
            for (int iy = 0; iy < tatemax; iy++)
                for (int ix = 0; ix < yokomax; ix++)
                    distance[ix, iy] = 100;

            //計算スタート
            distcalc(x, y, 0);
            /*デバッグ用に全体の距離を表示
            string t = "";
            for (int iy = 0; iy < tatemax; iy++)
            {
                for (int ix = 0; ix < yokomax; ix++)
                    t += distance[ix, iy].ToString() + ",";
                t += "\n";
            }
            MessageBox.Show(t);
            */
        }

        //ダイクストラ計算（再起してます
        private void distcalc(int x, int y,int d)
        {
            distance[x, y] = d;//距離セット
            //配列からはみ出ないか
            if (y != tatemax - 1)
            {
                //参照座標の距離が今の座標の距離に比べでかいか
                if (distance[x, y] <= distance[x, y + 1])
                {
                    distcalc(x, y + 1, distance[x, y] + 1);
                }
                //参照座標のほうが小さいんならそっちにあわせてここをセットする
                else
                {
                    distance[x, y] = distance[x, y + 1] + 1;
                }
            }
            //以下同じ処理

            if (x != yokomax - 1)
            {
                if (distance[x, y] <= distance[x + 1, y])
                {
                    distcalc(x + 1, y, distance[x, y] + 1);
                }
                else
                {
                    distance[x, y] = distance[x+1, y] + 1;
                }
            }

            if (y != 0)
            {
                if (distance[x, y] <= distance[x, y - 1])
                {
                    distcalc(x, y - 1, distance[x, y] + 1);
                }
                else
                {
                    distance[x, y] = distance[x, y - 1] + 1;
                }
            }

            if (x != 0)
            {
                if (distance[x, y] <= distance[x - 1, y])
                {
                    distcalc(x - 1, y, distance[x, y] + 1);
                }
                else
                {
                    distance[x, y] = distance[x-1, y] + 1;
                }
            }
        }

        //目標座標を格納
        private void pointset(point p)
        {
            pointlist.Add(p);
        }
        //目標座標を設定
        private void goalpointset(int x, int y)
        {
            goalpoint = new point(x, y);
        }
    }
}
