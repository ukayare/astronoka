using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    //種と野菜のスーパークラス（共通パラメータを記述
    public class yasai : item
    {
        public string finname = "";//表示名
        public string name = "";//種類名
        public int id = 1;//ID（finnameが一致したときの区別用

        public Boolean pure = true;//ピュアかどうか

        public Boolean syoki = false;//初期種

        public int strengp = 0;//強化ポイント
        public int strengele = 0;//強化属性

        public int department = 0;//-1-A 0-B 1-C科
        public int mendel = 2;//メンデル数
        public int grow = 3;//3 6 8 10 13//成長速度
        public int season = 0;//可能季節

        public int max = 200;//属性上限値
        public int min = -100;//属性下限値

        //基本的に1ひくとエレメント
        public int mut1 = 0;//変異属性その１
        public int mut2 = 0;//変異属性その２

        public int rank=0;//等級

        public int mat = 0;//0発芽前　1発芽　2成長中　3成熟　4種1つ　5種2つ　6種3つ　7完全成熟　8枯れてる

        //0 high,1 heavy,2 pattern,3 nour,4 sugar,5 texture,6 shape,7 flavor,8 smell,9 sound
        public int[] element = new int[10];//属性地
        public string[] elename = new string[10];//属性名
        public int[] elelevel = new int[10];//属性レベル

        public int sum;//属性合計値

        public string repele;//特徴属性（いわゆる一番パラメータがでかい（小さい）属性
        public string title;//階級


        public int basep;//野菜基本価格
        public int bonusp = 0;//属性ボーナス価格
        public int sell;//実際の値段

        public int days = -1;//成長日数

        public Boolean[,] info = new Boolean[10, 8];//遺伝情報

        public int[] fix = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };//固定値

        public Boolean get = false;

        //idのセット（finnameがかぶっててステータスが違う場合の判別）
        public Boolean idset(yasai y)
        {
            //パラメータが完全一致かチェック（id以外
            if (y.name == name &&
                y.title == title &&
                y.repele == repele &&
                y.id == id)
            {
                id++;
                return true;
            }
            return false;
        }

        //パラメータが一致かチェック（ID以外の照合
        public Boolean yasaicheck(yasai s)
        {
            if (mendel != s.mendel)
                return false;

            if (department != s.department)
                return false;

            if (pure != s.pure)
                return false;

            if (strengp != s.strengp)
                return false;

            if (strengele != s.strengele)
                return false;

            if (syoki != s.syoki)
                return false;

            if (s.fix != fix)
                return false;

            if (s.info != info)
                return false;

            return true;
        }

    }
}
