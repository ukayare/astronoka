using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    //交配マシン
    public partial class kouhai : Form
    {
        public kouhai()
        {
            InitializeComponent();
        }

        public seed s1;//混ぜる種１
        public seed s2;//混ぜる種２
        public seedstatus seedst;//種情報表示
        music sound;


        private void butmix_Click(object sender, EventArgs e)
        {
            Boolean loop=true;//ループフラグ
            Boolean can = false;//キャンセルフラグ
            if(this.listBox1.SelectedIndex ==-1 || this.listBox2.SelectedIndex==-1)//種選んでる？
                MessageBox.Show("種を選んでください");
            else if (!((s1==s2) &&s1.items<2))//１個しかないやつを選びあってない
            {
                seed s=new seed();
                while(loop==true){//交配しまーす（納得いくまでループ
                    s = new seed();
                    s.mix(s1, s2);//混ぜます
                    //DialogResult result = MessageBox.Show(s.finname + "\n" + s.element[s.mut1 - 1], "結果", MessageBoxButtons.YesNoCancel);
                    DialogResult result = MessageBox.Show(peetex(s), "結果", MessageBoxButtons.YesNoCancel);//予想表示
                    
                    if (result==DialogResult.Yes)//混ぜていいならループ抜ける
                        loop = false;
                    else if(result==DialogResult.Cancel)//キャンセルしても抜けるけど混ぜないよ
                    {
                        loop = false;
                        can = true;
                    }
                }
                if (can == false)//交配完了
                {
                    //使った種は減らす
                    int find = motimono.seedlist.FindIndex(se => se == s1);
                    motimono.seedlist[find].items--;
                    find = motimono.seedlist.FindIndex(se => se == s2);
                    motimono.seedlist[find].items--;

                    //０個のやつは消す
                    motimono.seedlist.RemoveAll(se => se.items == 0);

                    //種の獲得
                    motimono.getseed(s);
                    seedstatus st = new seedstatus(s);//ゲットした種の情報
                    st.ShowDialog();
                }
                motimono.seedsort();//ソート
                boxset();
                
            }
            else 
                MessageBox.Show("違う種を選んでください");

        }

        //ロード
        private void kouhai_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
            boxset();
            musicstart();
        }

        //閉じる
        private void butfin_Click(object sender, EventArgs e)
        {
            musicstop();
            this.Dispose();
        }

        //リストボックス初期化
        private void boxset()
        {
            stringcreate.infoclear(this.yasaiextext, this.ele1, this.info1, this.eleval1, this.elename1,this.label2);
            stringcreate.infoclear(this.yasaiextext2, this.ele2, this.info2, this.eleval2, this.elename2,this.label2);
            this.depbox1.Items.Clear(); 
            this.depbox2.Items.Clear();
            this.listBox1.Items.Clear();
            this.listBox2.Items.Clear();
            this.namebox1.Items.Clear();
            this.namebox2.Items.Clear();
            foreach (seed s in motimono.seedlist)
            {
                this.listBox1.Items.Add(s);
                this.listBox2.Items.Add(s);
            }

            this.depbox1.Items.Add("全て");
            this.depbox2.Items.Add("全て");

            //各科の種が存在してれば表示
            if (motimono.seedlist.Exists(s => s.department == -1) == true)
            {
                this.depbox1.Items.Add("A科");
                this.depbox2.Items.Add("A科");
            }
            if (motimono.seedlist.Exists(s => s.department == 0) == true)
            {
                this.depbox1.Items.Add("B科");
                this.depbox2.Items.Add("B科");
            }
            if (motimono.seedlist.Exists(s => s.department == 1) == true)
            {
                this.depbox1.Items.Add("C科");
                this.depbox2.Items.Add("C科");
            }
            if (motimono.seedlist.Exists(s => s.department == 2) == true)
            {
                this.depbox1.Items.Add("強化種");
                this.depbox2.Items.Add("強化種");
            }

            this.depbox1.SetSelected(0,true);
            this.depbox2.SetSelected(0, true);

        }

        //選択した種を取得
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedIndex != -1 && this.listBox1.SelectedItem != null)
            {
                s1 = stringcreate.seed_listBox_changed(this.listBox1, this.label1, this.yasaiextext, this.ele1, this.info1, this.eleval1, this.elename1);
                this.label1.Text = s1.items.ToString();
            }
        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listBox2.SelectedIndex != -1 && this.listBox2.SelectedItem != null)
            {
                s2 = stringcreate.seed_listBox_changed(this.listBox2, this.label2, this.yasaiextext2, this.ele2, this.info2, this.eleval2, this.elename2);
                this.label2.Text = s2.items.ToString();
            }
        }

        //どの科を選んだ？
        private void depbox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            stringcreate.infoclear(this.yasaiextext, this.ele1, this.info1, this.eleval1, this.elename1,this.label1);
            stringcreate.depbox_change(this.depbox1, listBox1, namebox1, "seed");
        }

        private void depbox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            stringcreate.infoclear(this.yasaiextext2, this.ele2, this.info2, this.eleval2, this.elename2, this.label1);
            stringcreate.depbox_change(this.depbox2, listBox2, namebox2, "seed");
        }

        //種類選択
        private void namebox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            stringcreate.infoclear(this.yasaiextext, this.ele1, this.info1, this.eleval1, this.elename1, this.label1);
            stringcreate.namebox_change(this.namebox1, this.listBox1, "seed");
        }
        private void namebox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            stringcreate.infoclear(this.yasaiextext2, this.ele2, this.info2, this.eleval2, this.elename2, this.label2);
            stringcreate.namebox_change(this.namebox2, this.listBox2, "seed");
        }


        //ピート君の予想
        private string peetex(seed s)
        {
            string result="";//予想の文字列
            List<string> t= new List<string>();//選ばれたパラメータレベル
            Random r = new Random();//何個情報表示するかの乱数
            int x;
            Boolean loop=true;//ループフラグ

            //表示数の決定
            if (r.Next(100) < 50)
                x = 2;
            else if (r.Next(100) < 80)
                x = 1;
            else
                x = 0;

            int y = 0;//レベルが０じゃないようその数
            for (int m = 0; m < 10; m++)
                if (s.element[m] != 40)
                    y++;

            //強化種か判別
            if (s.strengp == 0)//強化種じゃない
            {
                if (r.Next(100) < 85)
                {
                    for (int i = 0; i <= x; i++)
                    {
                        string k = "";
                        while (loop == true)
                        {
                            //どのパラメータの予想を出すか
                            Random r2 = new Random();
                            int l = r2.Next() % 10;
                            int n = r.Next(2);

                            while (l > -1 && l < 10)
                            {
                                k = s.elename[l];//選ばれたパラメータのレベルを取得
                                if (k != "")//レベルが０じゃないとき
                                {
                                    for (int j = 0; j < t.Count; j++)
                                        if (k == t[j])//もうすでに選ばれてるときまたやり直す
                                        {
                                            loop = true;
                                            break;
                                        }
                                        else
                                            loop = false;
                                    if (t.Count == 0)//リストが空ならフラグを折る
                                    {
                                        loop = false;
                                        break;
                                    }
                                }
                                if (loop == false)//フラグ折れてたら抜ける
                                    break;
                                //どっちにずらすか
                                if (n == 0)
                                    l++;
                                else
                                    l--;
                            }
                            if (t.Count >= y)//取りたい数よりも少なかったらフラグ折る
                                loop = false;
                        }//ここまでloopでループが回る

                        Boolean rep = false;//なんも出なかったか取ってきたやつがかぶってるかどうかのフラグ
                        for (int j = 0; j < t.Count; j++)
                            if (k == t[j] || k == "")
                                rep = true;

                        if (!(rep == true || k == ""))//フラグ立ってなければ結果文字列に追加
                            result += k + "\n";
                        t.Add(k);//リストに追加
                    }
                }

                Random r3 = new Random();//どの種かの表示
                switch (r3.Next(3))
                {
                    case 0://dep
                        if (s.department == -1)
                            result += "A科の種\n";
                        else if (s.department == 0)
                            result += "B科の種\n";
                        if (s.department == 1)
                            result += "C科の種\n";
                        break;
                    case 1://name
                        result += s.name + "の種";
                        break;
                    case 2:
                        result += "何かの種";
                        break;
                }
            }
            else//強化種のとき
            {
                switch (x)
                {
                    case 0:
                        result += "強化種";
                        break;
                    case 1:
                        result += "何かの種";
                        break;
                    case 2:
                        result += "特殊な野菜の種";
                        break;
                }
            }
            return result;
        }

        private void musicstart()
        {
            sound = new music("music\\kouhai.mp3");
            sound.start();
        }
        private void musicstop()
        {
            sound.stop();
            sound.Dispose();
        }

        //交配説明
        private void butex_Click(object sender, EventArgs e)
        {
            kouhaiex kex = new kouhaiex();
            kex.ShowDialog();
        }

        private void yasaiextext2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
