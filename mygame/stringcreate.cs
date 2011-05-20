using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public static class stringcreate
    {
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
                    rets += "と大きさ";
                    break;
                case 2:
                    rets += "と重さ";
                    break;
                case 3:
                    rets += "と模様";
                    break;
                case 4:
                    rets += "と栄養";
                    break;
                case 5:
                    rets += "と糖度";
                    break;
                case 6:
                    rets += "と食感";
                    break;
                case 7:
                    rets += "と形状";
                    break;
                case 8:
                    rets += "と風味";
                    break;
                case 9:
                    rets += "と匂い";
                    break;
                case 10:
                    rets += "と音色";
                    break;
            }

            rets += "を改良するのに向いている野菜ですね。\n";

            switch (s.rank)
            {
                case 14:
                    break;
                case 13:
                    break;
                case 12:
                    break;
                case 11:
                    break;
                case 10:
                    break;
                case 9:
                    break;
                case 8:
                    break;
                case 7:
                    break;
                case 6:
                    break;
                case 5:
                    break;
                case 4:
                    break;
                case 3:
                    break;
                case 2:
                    break;
                case 1:
                    break;
                case 0:
                    break;
                case -1:
                    break;
                case -2:
                    break;
                case -3:
                    break;
                case -4:
                    break;
                case -5:
                    break;
                case -6:
                    break;
                case -7:
                    break;
                case -8:
                    break;
                case -9:
                    break;
                case -10:
                    break;
                case -11:
                    break;
            }

            rets += "完全成熟し、種が3つ収穫できるまで、" + (s.grow-s.days) + "日かかりますね。";
            return rets;
        }
    }
}
