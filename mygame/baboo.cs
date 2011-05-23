using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    //バブー関係
    public class baboo
    {
        public baboo()
        {
            //嫌い度の設定
            for (int i = 0; i < this.hate.Length; i++)
            {
                if(!(i==4 || i==15 || i==6 || i==5 || i==12))
                    this.hate[i] = 100;
            }
        }

        public int specie=0;//種類
        public int variation = 0;

        public int heavy;//重さ
        int arm;//腕力
        int leg;//脚力
        public int stamina=100;//体力
        int stick;//粘り
        int mand;//
        public int vitality = 100;//アグレッシブ

        Boolean wing;//羽

        int push;//押す力
        int jump;//ジャンプ力
        public int punch=10;//パンチ力
        int kick;//キック力

        int[] resist = new int[18];//各トラップの耐性
        internal int[] hate = new int[18];//各トラップの嫌い度
        public int pointhate = 5;//とどまっている限界ターン数

        int[] happen = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};//引っかかった回数

        public Boolean leftright = false;//回転方向（false時計回りtrue反時計）
    }
}
