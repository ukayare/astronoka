using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    //起動用のクラス
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            title form1 = new title();//タイトル
            Form3 form3 = new Form3();//メイン画面
            form3 = form1.form3;
            Application.Run(form1);//タイトル走らせる

            //ここからタイトルが閉じたときの処理
            if (form1.finfrag == false)//終了フラグが立ってない
            {
                if(form3.loadfrag==true)//ロードフラグ立ってたらロードしてスタート
                    form3.load();
                Application.Run(form3);//じゃない場合はデフォルト起動
            }
        }
    }
}
