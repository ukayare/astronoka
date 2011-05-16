using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    //トラップ
    public class trap : item
    {
        public trap(int t, int g)//タイプとグレードを渡して形成
        {
            this.type = t;
            this.grade = g;
            trapset();
        }
        public string name;//トラップ名

        //0落とし穴　1フタ付き落とし穴　2塀　3扇風機　4ジャンプ台　5ぐるぐる台
        //6冷水ぶっかけ装置　7パンチングマシン　8ビリビリマシン　9風船サービス装置
        //10米俵サービス装置　11おめでとう装置　12エサ　13カカシ　14オリ　15とりもち　16怪光線
        public int type;//上記のどれか

        public int grade;//グレード

        //0何もしない　1上に乗る　2方向上に乗る　3殴る蹴る　4十字状
        public int happen;//起動タイプ
        public int elect;//電力
        public Boolean kotei=false;//固定物
        //0 up 1 right 2 down 3 left
        public int direction=0;//設置方向
        public Boolean direct=false;//方向設定するか
        public int resist = 100;//強度

        public Boolean range = false;//範囲があるか

        //トラップをセット
        public void trapset()
        {
            switch (type)
            {
                case 0:
                    happen = 1;
                    if (grade == 0)
                    {
                        name = "浅底落とし穴";
                        elect = 65;
                        price = 80;
                        break;
                    }
                    else if (grade == 1)
                    {
                        name = "深底落とし穴";
                        elect = 100;
                        price = 300;
                        break;
                    }
                    else
                    {
                        name = "地獄落とし穴";
                        elect = 150;
                        price = 1000;
                        break;
                    }
                case 1:
                    kotei = false;
                    happen = 1;
                    if (grade == 0)
                    {
                        name = "フタ付き落とし穴";
                        elect = 150;
                        price = 400;
                        break;
                    }
                    else
                    {
                        name = "深底フタ付き落とし穴";
                        elect = 150;
                        price = 500;
                        break;
                    }
                case 2:
                    happen = 0;
                    kotei = true;
                    if (grade == 0)
                    {
                        name = "ただの塀";
                        elect = 65;
                        price = 1500;
                        break;
                    }
                    else if (grade == 1)
                    {
                        name = "高い塀";
                        elect = 100;
                        price = 3000;
                        break;
                    }
                    else if (grade == 2)
                    {
                        name = "鉄壁の塀";
                        elect = 150;
                        price = 6000;
                        break;
                    }
                    else
                    {
                        name = "ワンダフルな塀";
                        elect = 200;
                        price = 500;
                        break;
                    }
                case 3:
                    kotei = true;
                    happen = 2;
                    direct = true;
                    range = true;
                    if (grade == 0)
                    {
                        name = "2マス扇風機";
                        elect = 100;
                        price = 600;
                        break;
                    }
                    else if (grade == 1)
                    {
                        name = "高級2マス扇風機";
                        elect = 200;
                        price = 3000;
                        break;
                    }
                    else if (grade == 2)
                    {
                        name = "3マス扇風機";
                        elect = 150;
                        price = 5000;
                        break;
                    }
                    else
                    {
                        name = "高級3マス扇風機";
                        elect = 200;
                        price = 10000;
                        break;
                    }
                case 4:
                    happen = 1;
                    direct = true;
                    range = true;
                    if (grade == 0)
                    {
                        name = "ジャンプ台";
                        elect = 100;
                        price = 100;
                        break;
                    }
                    else if (grade == 1)
                    {
                        name = "強力ジャンプ台";
                        elect = 100;
                        price = 1800;
                        break;
                    }
                    else if (grade == 2)
                    {
                        name = "桂馬ジャンプ台R";
                        elect = 150;
                        price = 700;
                        break;
                    }
                    else if (grade == 3)
                    {
                        name = "強力桂馬ジャンプ台R";
                        elect = 150;
                        price = 5000;
                        break;
                    }
                    else if (grade == 4)
                    {
                        name = "桂馬ジャンプ台L";
                        elect = 150;
                        price = 700;
                        break;
                    }
                    else
                    {
                        name = "強力桂馬ジャンプ台L";
                        elect = 150;
                        price = 5000;
                        break;
                    }
                case 5:
                    happen = 1;
                    if (grade == 0)
                    {
                        name = "ぐるぐる台R";
                        elect = 65;
                        price = 120;
                        break;
                    }
                    else if (grade == 1)
                    {
                        name = "ぐるぐる台L";
                        elect = 65;
                        price = 120;
                        break;
                    }
                    else if (grade == 2)
                    {
                        name = "ぐるぐる台U";
                        elect = 65;
                        price = 500;
                        break;
                    }
                    else if (grade == 3)
                    {
                        name = "強力ぐるぐる台R";
                        elect = 120;
                        price = 1200;
                        break;
                    }
                    else
                    {
                        name = "強力ぐるぐる台L";
                        elect = 120;
                        price = 1200;
                        break;
                    }
                case 6:
                    happen = 3;
                    kotei = true;
                    direct = true;
                    range = true;
                    if (grade == 0)
                    {
                        name = "冷水ぶっかけ装置";
                        elect = 200;
                        price = 1500;
                        break;
                    }
                    else
                    {
                        name = "超冷水ぶっかけ装置";
                        elect = 250;
                        price = 10000;
                        break;
                    }
                case 7:
                    kotei = true;
                    happen = 3;
                    range = true;
                    if (grade == 0)
                    {
                        direct = true;
                        name = "パンチングマシン";
                        elect = 200;
                        price = 6000;
                        break;
                    }
                    else
                    {
                        name = "必殺パンチングマシン";
                        elect = 250;
                        price = 30000;
                        break;
                    }
                case 8:
                    kotei = true;
                    happen = 3;
                    range = true;
                    if (grade == 0)
                    {
                        direct = true;
                        name = "ビリビリマシン";
                        elect = 200;
                        price = 5000;
                        break;
                    }
                    else
                    {
                        name = "特別ビリビリマシン";
                        elect = 250;
                        price = 20000;
                        break;
                    }
                case 9:
                    direct = true;
                    kotei = true;
                    range = true;
                    happen = 2;
                    name = "風船サービス装置";
                    elect = 200;
                    price = 10000;
                    break;
                case 10:
                    direct=true;
                    kotei = true;
                    range = true;
                    happen = 2;
                    name = "米俵サービス装置";
                    elect = 200;
                    price = 10000;
                    break;
                case 11:
                    direct =true;
                    kotei = true;
                    range = true;
                    happen = 2;
                    name = "おめでとう装置";
                    elect = 200;
                    price = 12000;
                    break;
                case 12:
                    kotei = true;
                    range = true;
                    happen = 4;
                    if (grade == 0)
                    {
                        name = "基本エサ";
                        elect = 65;
                        price = 100;
                        break;
                    }
                    else if (grade == 1)
                    {
                        name = "良質エサ";
                        elect = 100;
                        price = 500;
                        break;
                    }
                    else if (grade == 2)
                    {
                        name = "強力エサ";
                        elect = 150;
                        price = 800;
                        break;
                    }
                    else
                    {
                        name = "究極エサ";
                        elect = 200;
                        price = 1600;
                        break;
                    }
                case 13:
                    kotei = true;
                    direct =true;
                    range = true;
                    happen = 4;
                    if (grade == 0)
                    {
                        name = "ピートのカカシ";
                        elect = 100;
                        price = 1000;
                        break;
                    }
                    else if (grade == 1)
                    {
                        name = "ホラーなカカシ";
                        elect = 150;
                        price = 3000;
                        break;
                    }
                    else
                    {
                        name = "危険なサイレン";
                        elect = 200;
                        price = 10000;
                        break;
                    }
                case 14:
                    happen = 1;
                    if (grade == 0)
                    {
                        name = "捕獲のカゴ";
                        elect = 150;
                        price = 800;
                        break;
                    }
                    else if (grade == 1)
                    {
                        name = "アストロボンベ";
                        elect = 200;
                        price = 900;
                        break;
                    }
                    else
                    {
                        name = "大型オリ";
                        elect = 250;
                        price = 6000;
                        break;
                    }
                case 15:
                    happen = 1;
                    if (grade == 0)
                    {
                        name = "とりもち";
                        elect = 65;
                        price = 50;
                        break;
                    }
                    else
                    {
                        name = "マジックハンド";
                        elect = 200;
                        price = 1000;
                        break;
                    }
                case 16:
                    happen = 1;
                    name = "怪光線マシン";
                    elect = 200;
                    price = 20000;
                    break;
            }

        }

        
    }
}
