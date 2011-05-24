using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public static class Flag
    {

        public static Boolean loadfrag = false;//ロードフラグ
        public static Boolean resfrag = false;//再起動フラグ
        public static Boolean finfrag = false;//終了フラグ
        public static Boolean movefrag = false;//移動フラグ

        public static Boolean newgameflag = false;

        //トラップの作成時とかそういうのに使う配列
        internal static Boolean[] tlist = new Boolean[17];

        internal static string[] tname = new string[] {"落とし穴"　,"フタ付き落とし穴",　"塀",　"扇風機",　"ジャンプ台",　"ぐるぐる台",
                    "冷水ぶっかけ装置",　"パンチングマシン",　"ビリビリマシン",　"風船サービス装置",
                "米俵サービス装置",　"おめでとう装置",　"エサ",　"カカシ",　"オリ",　"とりもち","怪光線"};
        internal static Boolean[] tlistpedro = new Boolean[17];

        //トラップのフラグ立て
        public static void trapsearch()
        {
            for (int j = 0; j < tlist.Length; j++)
                tlist[j] = false;

            for (int j = 0; j < tlist.Length; j++)
                if (motimono.traplist.Exists(t => t.type == j))
                    tlist[j] = true;
        }

        //持ってるとラップ調べる（店側
        public static void trapsearchpedro()
        {
            for (int j = 0; j < tlistpedro.Length; j++)
                tlistpedro[j] = false;

            for (int i = 0; i < motimono.pedrotrap.Count; i++)
                for (int j = 0; j < tlistpedro.Length; j++)
                    if (motimono.pedrotrap[i].type == j)
                    {
                        tlistpedro[j] = true;
                        break;
                    }
        }
    }
}
