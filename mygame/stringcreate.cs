using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace WindowsFormsApplication1
{
    public static class stringcreate
    {
        //トラップ選択
        public static trap trap_listBox_changed(System.Windows.Forms.ListBox listBox,System.Windows.Forms.RichTextBox trapextext)
        {
            trap selectedtrap=null;
            trapextext.Text = "";
            //選択したものを取得
            if (listBox.SelectedItem != null)
            {
                int i = motimono.traplist.FindIndex(t => t.name == listBox.SelectedItem.ToString());
                selectedtrap = motimono.traplist.Find(t => t.name == listBox.SelectedItem.ToString());
                StreamReader reader = new StreamReader("text\\trap\\" + selectedtrap.type.ToString() + selectedtrap.grade.ToString() + ".txt", System.Text.Encoding.GetEncoding("shift_jis"));
                trapextext.AppendText(reader.ReadToEnd());
            }
            return selectedtrap;
        }


        //どの個体を選んだか
        public static seedvagtrap listBox_change(System.Windows.Forms.ListBox itemBox, System.Windows.Forms.ListBox listBox,
            System.Windows.Forms.Label label1,System.Windows.Forms.RichTextBox yasaiextext,System.Windows.Forms.RichTextBox ele,System.Windows.Forms.RichTextBox info,
            System.Windows.Forms.RichTextBox eleval,System.Windows.Forms.RichTextBox elename)
        {
            seedvagtrap svt = new seedvagtrap();
            //選んでるかを確認
            if (itemBox.SelectedIndex != -1)
            {
                if (itemBox.SelectedItem.ToString() == "種")
                {
                    if (listBox.SelectedIndex != -1)
                    {
                        //選んだ個体を取得
                        svt.s = stringcreate.seed_listBox_changed(listBox, label1, yasaiextext, ele, info, eleval, elename);
                        label1.Text = svt.s.items.ToString();

                    }
                }
                else if (itemBox.SelectedItem.ToString() == "野菜")
                {
                    if (listBox.SelectedIndex != -1)
                    {
                        svt.v = stringcreate.vag_listBox_changed(listBox, label1, yasaiextext, ele, info, eleval, elename);
                        label1.Text = svt.v.items.ToString();
                    }
                }
                else if (itemBox.SelectedItem.ToString() == "トラップ")
                {
                    if (listBox.SelectedIndex != -1)
                    {
                        svt.t = stringcreate.trap_listBox_changed(listBox, yasaiextext);
                        label1.Text = svt.t.items.ToString();
                    }
                }

            }
            return svt;
        }


        public static void namebox_change(System.Windows.Forms.ListBox itemBox, System.Windows.Forms.ListBox namebox, System.Windows.Forms.ListBox listBox)
        {
            listBox.Items.Clear();
            if (itemBox.SelectedIndex != -1 && namebox.SelectedItem != null)
            {
                //野菜か種かトラップか
                string x = namebox.SelectedItem.ToString();
                if (itemBox.SelectedItem.ToString() == "種")
                {
                    stringcreate.namebox_change(namebox, listBox, "seed");
                }
                //以下もおんなじ処理（なんとかまとれねーかなー
                else if (itemBox.SelectedItem.ToString() == "野菜")
                {
                    stringcreate.namebox_change(namebox, listBox, "vag");
                }
                else if (itemBox.SelectedItem.ToString() == "トラップ")
                {
                    int j;
                    for (j = 0; j < Flag.tlist.Length; j++)
                        if (namebox.SelectedItem.ToString() == Flag.tname[j])
                            break;
                    List<trap> curtrap = new List<trap>();
                    curtrap = motimono.traplist.FindAll(t => t.type == j);
                    foreach (trap t in curtrap)
                        listBox.Items.Add(t.name);
                }
            }
        }


        public static void depbox_change(System.Windows.Forms.ListBox itemBox, System.Windows.Forms.ListBox depbox, System.Windows.Forms.ListBox namebox, System.Windows.Forms.ListBox listBox)
        {
            //いったんクリアー
            listBox.Items.Clear();
            namebox.Items.Clear();
            //以下どの科を選んだかでまずリストをとってきてそれについて表示させる
            if (itemBox.SelectedIndex != -1)
            {
                if (itemBox.SelectedItem.ToString() == "種")
                {
                    stringcreate.depbox_change(depbox, listBox, namebox, "seed");
                }
                else if (itemBox.SelectedItem.ToString() == "野菜")
                {
                    stringcreate.depbox_change(depbox, listBox, namebox, "vag");
                }
                else if (itemBox.SelectedItem.ToString() == "トラップ")
                {
                    for (int i = 0; i < Flag.tlist.Length; i++)
                    {
                        if (Flag.tlist[i] == true)
                            namebox.Items.Add(Flag.tname[i]);
                    }
                    foreach (trap t in motimono.traplist)
                        listBox.Items.Add(t.name);
                }
            }
        }


        //トラップ種野菜どれ選んだ？
        public static void itemBox_change(System.Windows.Forms.ListBox itemBox, System.Windows.Forms.ListBox depbox, System.Windows.Forms.ListBox namebox, System.Windows.Forms.ListBox listBox)
        {
            if (itemBox.SelectedItem != null)
            {

                listBox.Items.Clear();
                namebox.Items.Clear();
                depbox.Items.Clear();
                depbox.Items.Add("全て");

                if (itemBox.SelectedItem.ToString() == "種")
                {

                    //各科あるかどうか判別
                    if (motimono.seedlist.Exists(s => s.department == -1) == true)
                        depbox.Items.Add("A科");
                    if (motimono.seedlist.Exists(s => s.department == -0) == true)
                        depbox.Items.Add("B科");
                    if (motimono.seedlist.Exists(s => s.department == 1) == true)
                        depbox.Items.Add("C科");
                    if (motimono.seedlist.Exists(s => s.department == 2) == true)
                        depbox.Items.Add("強化種");

                }
                else if (itemBox.SelectedItem.ToString() == "野菜")
                {
                    if (motimono.vaglist.Exists(s => s.department == -1) == true)
                        depbox.Items.Add("A科");
                    if (motimono.vaglist.Exists(s => s.department == -0) == true)
                        depbox.Items.Add("B科");
                    if (motimono.vaglist.Exists(s => s.department == 1) == true)
                        depbox.Items.Add("C科");
                }
                else if (itemBox.SelectedItem.ToString() == "トラップ")
                {
                    for (int i = 0; i < Flag.tlist.Length; i++)
                    {
                        if (motimono.traplist.Exists(t => t.type == i) == true)
                            namebox.Items.Add(Flag.tname[i]);
                    }
                }
            }
        }

        //科の選択
        public static void depbox_change(System.Windows.Forms.ListBox depbox, System.Windows.Forms.ListBox listBox, System.Windows.Forms.ListBox namebox,string mode)
        {
            if (depbox.SelectedItem != null)//ちゃんと選ばれてるチェック
            {
                //いったんクリアーする
                listBox.Items.Clear();
                namebox.Items.Clear();
                int x = getdepnum(depbox.SelectedItem.ToString());//科の値
                if (x == -2)//全てを選択
                {
                    if(mode=="seed")
                        listboxset(motimono.seedlist, listBox, namebox);
                    else if(mode=="vag")
                        listboxset2(motimono.vaglist, listBox, namebox);
                }
                else
                {
                    if (mode == "seed")
                    {
                        List<seed> currentlist = new List<seed>();
                        currentlist = motimono.seedlist.FindAll(s => s.department == x);//選択した科のリストを取得
                        listboxset(currentlist, listBox, namebox);
                    }
                    else if (mode == "vag")
                    {
                        List<vagetable> currentlist = new List<vagetable>();
                        currentlist = motimono.vaglist.FindAll(s => s.department == x);//選択した科のリストを取得
                        listboxset2(currentlist, listBox, namebox);
                    }
                }
            }
        }

        public static void namebox_change(System.Windows.Forms.ListBox namebox,System.Windows.Forms.ListBox listBox,string mode)
        {
            //選ばれてるか確認
            if (namebox.SelectedItem != null)
            {
                listBox.Items.Clear();//いったん全消し
                if (mode == "seed")
                {
                    List<seed> currentlist = new List<seed>();//一時的なリスト
                    //同じ種類のリストを取ってくる
                    currentlist = motimono.seedlist.FindAll(s => s.name == namebox.SelectedItem.ToString());
                    foreach (yasai s in currentlist)//種のリスト全回し
                        listBox.Items.Add(s.finname);
                }
                else if (mode == "vag")
                {
                    List<seed> currentlist = new List<seed>();//一時的なリスト
                    //同じ種類のリストを取ってくる
                    currentlist = motimono.seedlist.FindAll(s => s.name == namebox.SelectedItem.ToString());
                    foreach (yasai s in currentlist)//種のリスト全回し
                        listBox.Items.Add(s.finname);
                }
            }
        }

        public static seed seed_listBox_changed(System.Windows.Forms.ListBox listBox, System.Windows.Forms.Label label1,
            System.Windows.Forms.RichTextBox yasaiextext,System.Windows.Forms.RichTextBox ele,System.Windows.Forms.RichTextBox info,System.Windows.Forms.RichTextBox eleval,System.Windows.Forms.RichTextBox elename)
        {
            seed s=null;
            //ちゃんと選ばれてるかチェック
            if (listBox.SelectedIndex != -1 && listBox.SelectedItem != null)
            {
                s = motimono.seedlist.Find(se => se.finname == listBox.SelectedItem.ToString());
                label1.Text = s.items.ToString();
                stringcreate.infoshow(s, yasaiextext, ele, info, eleval, elename);
            }
            return s;
        }

        public static vagetable vag_listBox_changed(System.Windows.Forms.ListBox listBox, System.Windows.Forms.Label label1,
            System.Windows.Forms.RichTextBox yasaiextext, System.Windows.Forms.RichTextBox ele, System.Windows.Forms.RichTextBox info, System.Windows.Forms.RichTextBox eleval, System.Windows.Forms.RichTextBox elename)
        {
            vagetable s = null;
            //ちゃんと選ばれてるかチェック
            if (listBox.SelectedIndex != -1 && listBox.SelectedItem != null)
            {
                s = motimono.vaglist.Find(se => se.finname == listBox.SelectedItem.ToString());
                label1.Text = s.items.ToString();
                stringcreate.infoshow(s, yasaiextext, ele, info, eleval, elename);
            }
            return s;
        }

        private static int getdepnum(string n)
        {
            int ret = 2;
            if (n == "全て")
                ret = -2;
            if (n == "A科")
                ret = -1;
            if (n == "B科")
                ret = 0;
            if (n == "C科")
                ret = 1;
            return ret;
        }

        public static void infoclear(System.Windows.Forms.RichTextBox extext, System.Windows.Forms.RichTextBox eletext, System.Windows.Forms.RichTextBox infotext, System.Windows.Forms.RichTextBox elevaltext, System.Windows.Forms.RichTextBox elenametext)
        {
            extext.Text = ""; eletext.Text = ""; infotext.Text = ""; elevaltext.Text = ""; elenametext.Text = "";
        }


        private static void listboxset(List<seed> slist, System.Windows.Forms.ListBox listBox, System.Windows.Forms.ListBox namebox)
        {
            foreach (seed s in slist)
                listboxseteach(s, listBox, namebox);
        }

        private static void listboxset2(List<vagetable> slist, System.Windows.Forms.ListBox listBox, System.Windows.Forms.ListBox namebox)
        {
            foreach (vagetable s in slist)
                listboxseteach(s, listBox, namebox);
        }

        private static void listboxseteach(yasai s, System.Windows.Forms.ListBox listBox, System.Windows.Forms.ListBox namebox)
        {
            Boolean same = false;
            for (int j = 0; j < namebox.Items.Count; j++)
                //もうすでに種類が入っているならフラグ立てる
                if (s.name == namebox.Items[j].ToString())
                    same = true;
            //フラグ立ってないなら普通に種類追加
            if (same == false)
                namebox.Items.Add(s.name);
            same = false;

            //後はその種を追加
            listBox.Items.Add(s.finname);
        }

        public static void infoshow(yasai s, System.Windows.Forms.RichTextBox extext, System.Windows.Forms.RichTextBox eletext, System.Windows.Forms.RichTextBox infotext, System.Windows.Forms.RichTextBox elevaltext, System.Windows.Forms.RichTextBox elenametext)
        {
            extext.Text = ""; eletext.Text = ""; infotext.Text = ""; elevaltext.Text = ""; elenametext.Text = "";

            extext.Text = stringcreate.yasaiex(s);

            eletext.Text = "大きさ\n重さ\n模様\n栄養\n糖度\n食感\n";

            int l = s.info.Length;
            for (int i = 0; i < s.info.GetLength(0); i++)
            {
                if (i < 6)//隠し属性じゃない
                    elevaltext.Text += s.element[i];

                elenametext.Text += s.elename[i];

                if (i >= 6 && (s.mut1 - 1 == i || s.mut2 - 1 == i || s.element[i] != 40))//隠し属性の場合は４０以外なら表示する
                {
                    elevaltext.Text += s.element[i];

                    if (i == 6)
                        eletext.Text += "形状\n";
                    if (i == 7)
                        eletext.Text += "風味\n";
                    if (i == 8)
                        eletext.Text += "匂い\n";
                    if (i == 9)
                        eletext.Text += "音色";
                }
                for (int j = 0; j < l / s.info.GetLength(0); j++)//遺伝情報の表示
                {
                    if (i < 6)
                    {
                        if (s.info[i, j] == true)
                            infotext.Text += "○";
                        else
                            infotext.Text += "×";
                    }
                    else
                    {
                        if (s.element[i] != 40 || s.mut1 - 1 == i || s.mut2 - 1 == 1)
                        {
                            if (s.info[i, j] == true)
                                infotext.Text += "○";
                            else
                                infotext.Text += "×";
                        }
                    }

                }
                if (i < 9)
                {
                    elevaltext.Text += "\n";
                    infotext.Text += "\n";
                    elenametext.Text += "\n";
                }
            }

        }       



        public static string yasaiex(yasai s)
        {
            string rets = s.finname+"\n";
            switch (s.department)
            {
                case -1:
                    rets += "A科野菜 ";
                    break;
                case 0:
                    rets += "B科野菜 ";
                    break;
                case 1:
                    rets += "C科野菜 ";
                    break;
            }

            rets += "メンデル数:"+s.mendel + "\n成長速度：";

            switch (s.grow)
            {
                case 3:
                case 4:
                    rets += "超速成\n";
                    break;
                case 6:
                case 7:
                    rets += "速成\n";
                    break;
                case 8:
                case 9:
                    rets += "普通\n";
                    break;
                case 10:
                case 11:
                    rets += "遅成\n";
                    break;
                case 13:
                case 14:
                    rets += "超遅成\n";
                    break;
            }

            rets += "種植え時期：";

            switch (s.season)
            {
                case 0:
                    rets += "ALL\n";
                    break;
                case 1:
                    rets += "春\n";
                    break;
                case 2:
                    rets += "夏\n";
                    break;
                case 3:
                    rets += "秋\n";
                    break;
                case 4:
                    rets += "冬\n";
                    break;
            }

            rets += "基本価格:" + s.basep + " ボーナス価格:" + s.bonusp + "\n価格:" + s.price + "\n\n";

            switch (s.mut1)
            {
                case 1:
                    rets += "大きさ";
                    break;
                case 2:
                    rets += "重さ";
                    break;
                case 3:
                    rets += "模様";
                    break;
                case 4:
                    rets += "栄養";
                    break;
                case 5:
                    rets += "糖度";
                    break;
                case 6:
                    rets += "食感";
                    break;
                case 7:
                    rets += "形状";
                    break;
                case 8:
                    rets += "風味";
                    break;
                case 9:
                    rets += "匂い";
                    break;
                case 10:
                    rets += "音色";
                    break;
            }

            switch (s.mut2)
            {
                case 1:
                    rets += "、大きさ";
                    break;
                case 2:
                    rets += "、重さ";
                    break;
                case 3:
                    rets += "、模様";
                    break;
                case 4:
                    rets += "、栄養";
                    break;
                case 5:
                    rets += "、糖度";
                    break;
                case 6:
                    rets += "、食感";
                    break;
                case 7:
                    rets += "、形状";
                    break;
                case 8:
                    rets += "、風味";
                    break;
                case 9:
                    rets += "、匂い";
                    break;
                case 10:
                    rets += "、音色";
                    break;
            }

            rets += "を改良するのに向いている野菜ですね。\n";

            switch (s.rank)
            {
                case 15:
                    rets += "宇宙広しといえど、これ以上の野菜はありえません。ついに辿りつきましたね。\n";
                    break;
                case 14:
                case 13:
                    rets += "これはもはや神の領域です。見ているだけで感動の涙が止まりません……。\n";
                    break;
                case 12:
                case 11:
                    rets += "こんなに素晴らしい野菜は見たことがありません！まさに食べる芸術品です！。\n";
                    break;
                case 10:
                case 9:
                    rets += "うーん、床の間に飾って鑑賞したいほど見事な出来栄えですね。\n";
                    break;
                case 8:
                case 7:
                    rets += "かなり素晴らしい野菜です。\nこれほどの質のものはなかなかありません。\n";
                    break;
                case 6:
                case 5:
                    rets += "品質としてはかなりのものです。\nこれなら自信を持って売れますね。\n";
                    break;
                case 4:
                case 3:
                    rets += "それなりにいい出来の野菜です。\n市場でもりっぱに通用しますよ。\n";
                    break;
                case 2:
                case 1:
                    rets += "品質は可もなく不可もなく、平均より少しだけ上という感じですね。\n";
                    break;
                case 0:
                case -1:
                    rets += "品質の点でちょっと物足りないですね。\n交配で質を上げる努力が必要です。\n";
                    break;
                case -2:
                    rets += "品質は、あまり良くありません。\n売って売れないことはないという野菜です。\n";
                    break;
                case -3:
                    rets += "うーん、品質が悪すぎますね。\nこれではほとんど価値はありません。\n";
                    break;
                case -4:
                case -5:
                    rets += "品質が悪いのを通りこして、毒としての価値が出てきてしまっていますよ。。\n";
                    break;
                case -6:
                case -7:
                    rets += "絶対に食べてはいけない、危険きわまりない野菜ですよ。\n";
                    break;
                case -8:
                case -9:
                    rets += "ボクたち、おそろしいものを作ってしまいましたよ……。触るのも危険です。\n";
                    break;
                case -10:
                case -11:
                    rets += "うう……。これはもう、野菜の形を借りた悪魔ですね……。。\n";
                    break;
                case -12:
                    rets += "ああ……。銀河広しといえど、これ以上、邪悪な野菜はありませんよ……。\n";
                    break;
            }

            rets += "完全成熟し、種が3つ収穫できるまで、" + (s.grow-s.days) + "日かかりますね。";
            return rets;
        }
    }
}
