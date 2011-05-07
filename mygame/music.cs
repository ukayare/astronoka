using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
// DllImport用
using System.Runtime.InteropServices;
// StringBuilder用
using System.Text;
using System.Reflection;

namespace WindowsFormsApplication1
{
    //音楽鳴らすやつ関係（よくわかんないとこおおい
    class music : Form
    {

        //読み込みコンストラクタ（なんか絶対パスじゃない動かんかったから絶対パス指定
        public music(string p)
        {
            Assembly myAssembly = Assembly.GetEntryAssembly();
            string pa = System.IO.Path.GetDirectoryName(myAssembly.Location);
            this.path = pa+"\\"+p;
        }

        [System.Runtime.InteropServices.DllImport("winmm.dll")]//なんかライブラリ読み込み
        private static extern Int32 mciSendString(string lpstrCommand, StringBuilder lpstrReturnString,
        int uReturnLength, IntPtr hwndCallback);


        private string aliasName = "MediaFile";

        string path;

        // Notify
        private const int MM_MCINOTIFY = 953;

        public void start()
        {
            //再生するファイル名
            string cmd;
            //ファイルを開く
            // Open
            mciSendString("open \"" + path + "\" alias " + aliasName, null, 0, IntPtr.Zero);
            
            //再生する
            cmd = "play " + aliasName;
            mciSendString(cmd+" from 0 notify", null, 0, this.Handle);



        }

        public void stop()
        {
            string cmd;
            //再生しているWAVEを停止する
            cmd = "stop " + aliasName;
            mciSendString(cmd, null, 0, IntPtr.Zero);
            //閉じる
            cmd = "close " + aliasName;
            mciSendString(cmd, null, 0, IntPtr.Zero);

        }

        protected override void WndProc(ref Message m)
        {
            // Loop処理
            if (m.Msg == MM_MCINOTIFY)
            {
                string cmd = "play " + aliasName;
                // 再生位置を戻し再生しなおす
                mciSendString(cmd + " from 0 notify", null, 0, this.Handle);
            }

            base.WndProc(ref m);
        }



    }

}
