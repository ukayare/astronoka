using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml; 

namespace WindowsFormsApplication1
{
    //セーブとロード（メイン画面のパーシャル
    public static class saveload
    {
        //各ファイルからデータ読み出し
        public static void save()
        {
            datesave();
            seedsave();
            vagsave();
            vaghsave();
            trapsave();
            tfieldsave();
            pedroseedsave();
            pedrotrapsave();
            MessageBox.Show("セーブが完了しました");
        }

        //各ファイルにデータ書き込み
        public static void load()
        {
            //リストデータはいったんクリアしてから読み込み
            dateload();
            motimono.seedlist.Clear();
            seedload();
            motimono.vaglist.Clear();
            vagload();
            motimono.vaghatake = new vagetable[4, 6];
            vaghload();
            motimono.traplist.Clear();
            trapload();

            motimono.tfield = new trap[9, 9];

            motimono.tpointd = new trappoint[9, 9];
            motimono.tpoint = new trappoint[9, 9];

            motimono.trapenable = new int[9, 9];
            tfieldload();

            motimono.pedroseed.Clear();
            pedroseedload();
            motimono.pedrotrap.Clear();
            pedrotrapload();

            foreach(seed s in motimono.seedlist)
                s.set();
        }

        //以下各ファイルのIO　xmlで操作
        //日付関係
        public static void datesave()
        {
            string fname = "save\\date.xml";
            XmlTextWriter xtw = null;
            try
            {
                string[] separator = { "\r\n" };
                xtw = new XmlTextWriter(fname, Encoding.Default);
                //インデントするかどうか
                xtw.Formatting = Formatting.Indented;

                xtw.WriteStartDocument();//XML宣言
                xtw.WriteStartElement("セーブファイル");

                xtw.WriteElementString("name", date.name);//要素
                xtw.WriteElementString("day", date.day.ToString());
                xtw.WriteElementString("month", date.month.ToString());
                xtw.WriteElementString("year", date.year.ToString());
                xtw.WriteElementString("money", date.money.ToString());
                xtw.WriteElementString("fin", date.fin.ToString());
                xtw.WriteElementString("electmax", date.electmax.ToString());
                xtw.WriteElementString("elect", date.elect.ToString());

                xtw.WriteEndElement();

                xtw.WriteEndDocument();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                xtw.Close();
            }
        }

        public static void dateload()
        {
            string fname = "save\\date.xml";
            XmlTextReader reader= new XmlTextReader(fname);

            while(reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    if (reader.LocalName.Equals("セーブファイル"))
                    {
                    }
                    else if (reader.LocalName.Equals("name"))
                         date.name = reader.ReadString(); 
                    else if (reader.LocalName.Equals("day"))
                         int.TryParse(reader.ReadString(), out date.day); 
                    else if (reader.LocalName.Equals("month"))
                         int.TryParse(reader.ReadString(), out date.month); 
                    else if (reader.LocalName.Equals("year"))
                         int.TryParse(reader.ReadString(), out date.year); 
                    else if (reader.LocalName.Equals("money"))
                         int.TryParse(reader.ReadString(), out date.money); 
                    else if (reader.LocalName.Equals("fin"))
                        int.TryParse(reader.ReadString(), out date.fin);
                    else if (reader.LocalName.Equals("electmax"))
                        int.TryParse(reader.ReadString(), out date.electmax);
                    else if (reader.LocalName.Equals("elect"))
                        int.TryParse(reader.ReadString(), out date.elect);
                }
            }

            Flag.loadfrag = true;
            MessageBox.Show("ロードが完了しました");
            reader.Close();

        }

        //種
        public static void seedsave()
        {
            string fname = "save\\seed.xml";
            XmlTextWriter xtw = null;
            try
            {
                string[] separator = { "\r\n" };
                xtw = new XmlTextWriter(fname, Encoding.Default);
                //インデントするかどうか
                xtw.Formatting = Formatting.Indented;

                xtw.WriteStartDocument();//XML宣言
                xtw.WriteStartElement("種データ");
                for (int i = 0; i < motimono.seedlist.Count; i++)
                {

                    xtw.WriteStartElement("種");

                    xtw.WriteElementString("id", motimono.seedlist[i].id.ToString());
                    xtw.WriteElementString("items", motimono.seedlist[i].items.ToString());
                    xtw.WriteElementString("pure", motimono.seedlist[i].pure.ToString());
                    xtw.WriteElementString("strengp", motimono.seedlist[i].strengp.ToString());
                    xtw.WriteElementString("strengele", motimono.seedlist[i].strengele.ToString());
                    xtw.WriteElementString("department", motimono.seedlist[i].department.ToString());
                    xtw.WriteElementString("mendel", motimono.seedlist[i].mendel.ToString());
                    xtw.WriteElementString("syoki", motimono.seedlist[i].syoki.ToString());


                    xtw.WriteStartElement("info");
                    for (int j = 0; j < motimono.seedlist[i].info.GetLength(0); j++)
                        for (int k = 0; k < motimono.seedlist[i].info.Length / motimono.seedlist[i].info.GetLength(0); k++)
                            xtw.WriteElementString("info" + j+k, motimono.seedlist[i].info[j, k].ToString());
                    xtw.WriteEndElement();

                    xtw.WriteStartElement("fix");
                    for (int j = 0; j < motimono.seedlist[i].fix.Length; j++)
                        xtw.WriteElementString("fix" + j, motimono.seedlist[i].fix[j].ToString());
                    xtw.WriteEndElement();

                    xtw.WriteEndElement();
                }
                xtw.WriteEndElement();

                xtw.WriteEndDocument();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                xtw.Close();
            }
        }

        public static void seedload()
        {
            string fname = "save\\seed.xml";
            XmlTextReader reader = new XmlTextReader(fname);
            seed s=new seed();
            int i = 0;
            int j = 0;
            int k = 0;

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    if (reader.LocalName.Equals("種"))
                        s = new seed();
                    else if (reader.LocalName.Equals("mendel"))
                        int.TryParse(reader.ReadString(), out s.mendel);
                    else if (reader.LocalName.Equals("id"))
                        int.TryParse(reader.ReadString(), out s.id);
                    else if (reader.LocalName.Equals("pure"))
                        Boolean.TryParse(reader.ReadString(), out s.pure);
                    else if (reader.LocalName.Equals("strengp"))
                        int.TryParse(reader.ReadString(), out s.strengp);
                    else if (reader.LocalName.Equals("strengele"))
                        int.TryParse(reader.ReadString(), out s.strengele);
                    else if (reader.LocalName.Equals("items"))
                        int.TryParse(reader.ReadString(), out s.items);
                    else if (reader.LocalName.Equals("department"))
                        int.TryParse(reader.ReadString(), out s.department);
                    else if (reader.LocalName.Equals("syoki"))
                        Boolean.TryParse(reader.ReadString(), out s.syoki);
                    else if (reader.LocalName.Equals("info"+i+j))
                    {
                        Boolean.TryParse(reader.ReadString(), out s.info[i,j]);
                        j++;
                        if (j == 8)
                        {
                            j=0;
                            i++;
                        }                            
                    }
                    else if (reader.LocalName.Equals("fix" + k))
                    {
                        int.TryParse(reader.ReadString(), out s.fix[k]);
                        k++;
                    }
                }
                else if (reader.NodeType == XmlNodeType.EndElement)
                {
                    if (reader.LocalName.Equals("種"))
                    {
                        motimono.seedlist.Add(s);
                        i = 0;
                        j = 0;
                        k = 0;
                    }
                }
            }

            Flag.loadfrag = true;
            reader.Close();

        }

        //野菜
        public static void vagsave()
        {
            string fname = "save\\vag.xml";
            XmlTextWriter xtw = null;
            try
            {
                string[] separator = { "\r\n" };
                xtw = new XmlTextWriter(fname, Encoding.Default);
                //インデントするかどうか
                xtw.Formatting = Formatting.Indented;

                xtw.WriteStartDocument();//XML宣言
                xtw.WriteStartElement("野菜データ");
                for (int i = 0; i < motimono.vaglist.Count; i++)
                {

                    xtw.WriteStartElement("野菜");

                    xtw.WriteElementString("id", motimono.vaglist[i].id.ToString());
                    xtw.WriteElementString("items", motimono.vaglist[i].items.ToString());
                    xtw.WriteElementString("pure", motimono.vaglist[i].pure.ToString());
                    xtw.WriteElementString("department", motimono.vaglist[i].department.ToString());
                    xtw.WriteElementString("mendel", motimono.vaglist[i].mendel.ToString());
                    xtw.WriteElementString("syoki", motimono.vaglist[i].syoki.ToString());
                    xtw.WriteElementString("days", motimono.vaglist[i].days.ToString());
                    xtw.WriteElementString("mat", motimono.vaglist[i].mat.ToString());


                    xtw.WriteStartElement("info");
                    for (int j = 0; j < motimono.vaglist[i].info.GetLength(0); j++)
                        for (int k = 0; k < motimono.vaglist[i].info.Length / motimono.vaglist[i].info.GetLength(0); k++)
                            xtw.WriteElementString("info" + j + k, motimono.vaglist[i].info[j, k].ToString());
                    xtw.WriteEndElement();

                    xtw.WriteStartElement("fix");
                    for (int j = 0; j < motimono.vaglist[i].fix.Length; j++)
                        xtw.WriteElementString("fix" + j, motimono.vaglist[i].fix[j].ToString());
                    xtw.WriteEndElement();

                    xtw.WriteEndElement();
                }
                xtw.WriteEndElement();

                xtw.WriteEndDocument();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                xtw.Close();
            }
        }
        //野菜読み込み時はいったん種情報に載せてから野菜に変換（インスタンスの関係
        public static void vagload()
        {
            string fname = "save\\vag.xml";
            XmlTextReader reader = new XmlTextReader(fname);
            seed v = new seed();
            int i = 0;
            int j = 0;
            int k = 0;

            int days = 0;
            int mat = 0;

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    if (reader.LocalName.Equals("野菜"))
                        v = new seed();
                    else if (reader.LocalName.Equals("mendel"))
                        int.TryParse(reader.ReadString(), out v.mendel);
                    else if (reader.LocalName.Equals("id"))
                        int.TryParse(reader.ReadString(), out v.id);
                    else if (reader.LocalName.Equals("pure"))
                        Boolean.TryParse(reader.ReadString(), out v.pure);
                    else if (reader.LocalName.Equals("items"))
                        int.TryParse(reader.ReadString(), out v.items);
                    else if (reader.LocalName.Equals("department"))
                        int.TryParse(reader.ReadString(), out v.department);
                    else if (reader.LocalName.Equals("syoki"))
                        Boolean.TryParse(reader.ReadString(), out v.syoki);
                    else if (reader.LocalName.Equals("days"))
                        int.TryParse(reader.ReadString(), out days);
                    else if (reader.LocalName.Equals("mat"))
                        int.TryParse(reader.ReadString(), out mat);
                    else if (reader.LocalName.Equals("info" + i + j))
                    {
                        Boolean.TryParse(reader.ReadString(), out v.info[i, j]);
                        j++;
                        if (j == 8)
                        {
                            j = 0;
                            i++;
                        }
                    }
                    else if (reader.LocalName.Equals("fix" + k))
                    {
                        int.TryParse(reader.ReadString(), out v.fix[k]);
                        k++;
                    }
                }
                else if (reader.NodeType == XmlNodeType.EndElement)
                {
                    if (reader.LocalName.Equals("野菜"))
                    {
                        vagetable vv = new vagetable();
                        v.set();
                        vv.set(v);
                        vv.days = days;
                        vv.mat = mat;
                        motimono.vaglist.Add(vv);
                        i = 0;
                        j = 0;
                        k = 0;
                    }
                }
            }

            Flag.loadfrag = true;
            reader.Close();

        }

        //畑野菜
        public static void vaghsave()
        {
            string fname = "save\\vagh.xml";
            XmlTextWriter xtw = null;
            try
            {
                string[] separator = { "\r\n" };
                xtw = new XmlTextWriter(fname, Encoding.Default);
                //インデントするかどうか
                xtw.Formatting = Formatting.Indented;

                xtw.WriteStartDocument();//XML宣言
                xtw.WriteStartElement("畑野菜データ");
                for (int i = 0; i < motimono.vaghatake.GetLength(0); i++)
                    for (int l = 0; l < motimono.vaghatake.Length / motimono.vaghatake.GetLength(0); l++)
                        if (motimono.vaghatake[i, l] != null)
                        {

                            xtw.WriteStartElement("畑野菜part"+i+l);

                            xtw.WriteElementString("idpart" + i + l, motimono.vaghatake[i, l].id.ToString());
                            xtw.WriteElementString("itemspart" + i + l, motimono.vaghatake[i, l].items.ToString());
                            xtw.WriteElementString("purepart" + i + l, motimono.vaghatake[i, l].pure.ToString());
                            xtw.WriteElementString("departmentpart" + i + l, motimono.vaghatake[i, l].department.ToString());
                            xtw.WriteElementString("mendelpart" + i + l, motimono.vaghatake[i, l].mendel.ToString());
                            xtw.WriteElementString("syokipart" + i + l, motimono.vaghatake[i, l].syoki.ToString());
                            xtw.WriteElementString("dayspart" + i + l, motimono.vaghatake[i, l].days.ToString());
                            xtw.WriteElementString("matpart" + i + l, motimono.vaghatake[i, l].mat.ToString());

                            xtw.WriteStartElement("info");
                            for (int j = 0; j < motimono.vaghatake[i, l].info.GetLength(0); j++)
                                for (int k = 0; k < motimono.vaghatake[i, l].info.Length / motimono.vaghatake[i, l].info.GetLength(0); k++)
                                    xtw.WriteElementString("infopart" + j + k + i + l, motimono.vaghatake[i, l].info[j, k].ToString());
                            xtw.WriteEndElement();

                            xtw.WriteStartElement("fix");
                            for (int j = 0; j < motimono.vaghatake[i, l].fix.Length; j++)
                                xtw.WriteElementString("fixpart" + j + i + l, motimono.vaghatake[i, l].fix[j].ToString());
                            xtw.WriteEndElement();

                            xtw.WriteEndElement();
                        }
                xtw.WriteEndElement();

                xtw.WriteEndDocument();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                xtw.Close();
            }
        }

        //畑野菜もいったん種にしてから変換
        public static void vaghload()
        {
            string fname = "save\\vagh.xml";
            XmlTextReader reader = new XmlTextReader(fname);
            seed v = new seed();
            int i = 0;
            int j = 0;
            int m = 0;

            int k = 0;
            int l = 0;

            int days=0;
            int mat = 0;

            string[] bun = { "part" };

            try
            {
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        string s = reader.LocalName;
                        if (System.Text.RegularExpressions.Regex.Match(s, "畑野菜part").Success == true)
                        {
                            string[] ps = s.Split(bun, StringSplitOptions.None);
                            int.TryParse(ps[1], out k);
                            k = k / 10;
                            int.TryParse(ps[1], out l);
                            l = l % 10;
                        }
                        if (s.Equals("畑野菜part"+k+l))
                            v = new seed();
                        else if (s.Equals("mendelpart" + k + l))
                            int.TryParse(reader.ReadString(), out v.mendel);
                        else if (s.Equals("idpart" + k + l))
                            int.TryParse(reader.ReadString(), out v.id);
                        else if (s.Equals("purepart" + k + l))
                            Boolean.TryParse(reader.ReadString(), out v.pure);
                        else if (s.Equals("itemspart" + k + l))
                            int.TryParse(reader.ReadString(), out v.items);
                        else if (s.Equals("departmentpart" + k + l))
                            int.TryParse(reader.ReadString(), out v.department);
                        else if (s.Equals("syokipart" + k + l))
                            Boolean.TryParse(reader.ReadString(), out v.syoki);
                        else if (s.Equals("dayspart" + k + l))
                            int.TryParse(reader.ReadString(), out days);
                        else if (s.Equals("matpart" + k + l))
                            int.TryParse(reader.ReadString(), out mat);
                        else if (s.Equals("infopart" + i + j + k + l))
                        {
                            Boolean.TryParse(reader.ReadString(), out v.info[i, j]);
                            j++;
                            if (j == 8)
                            {
                                j = 0;
                                i++;
                            }
                        }
                        else if (s.Equals("fixpart" + m + k + l))
                        {
                            int.TryParse(reader.ReadString(), out v.fix[m]);
                            m++;
                        }
                    }
                    else if (reader.NodeType == XmlNodeType.EndElement)
                    {
                        if (reader.LocalName.Equals("畑野菜part" + k + l))
                        {
                            vagetable vv = new vagetable();
                            v.set();
                            vv.set(v);
                            vv.days = days;
                            vv.mat = mat;
                            motimono.vaghatake[k,l]=vv;
                            i = 0;
                            j = 0;
                            m = 0;
                            k++;
                            if (k == 4)
                            {
                                k = 0;
                                l++;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Flag.loadfrag = true;
                reader.Close();
            }
        }

        //トラップ
        public static void trapsave()
        {
            string fname = "save\\trap.xml";
            XmlTextWriter xtw = null;
            try
            {
                string[] separator = { "\r\n" };
                xtw = new XmlTextWriter(fname, Encoding.Default);
                //インデントするかどうか
                xtw.Formatting = Formatting.Indented;

                xtw.WriteStartDocument();//XML宣言
                xtw.WriteStartElement("トラップデータ");

                for (int i = 0; i < motimono.traplist.Count; i++)
                {

                    xtw.WriteStartElement("トラップ");

                    xtw.WriteElementString("type", motimono.traplist[i].type.ToString());
                    xtw.WriteElementString("grade", motimono.traplist[i].grade.ToString());
                    xtw.WriteElementString("items", motimono.traplist[i].items.ToString());
                    
                    xtw.WriteEndElement();
                }
                xtw.WriteEndElement();

                xtw.WriteEndDocument();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                xtw.Close();
            }
        }

        public static void trapload()
        {
            string fname = "save\\trap.xml";
            XmlTextReader reader = new XmlTextReader(fname);
            trap t = new trap(0,0);

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    if (reader.LocalName.Equals("トラップ"))
                        t = new trap(0,0);
                    else if (reader.LocalName.Equals("type"))
                        int.TryParse(reader.ReadString(), out t.type);
                    else if (reader.LocalName.Equals("grade"))
                        int.TryParse(reader.ReadString(), out t.grade);
                    else if (reader.LocalName.Equals("items"))
                        int.TryParse(reader.ReadString(), out t.items);
                }
                else if (reader.NodeType == XmlNodeType.EndElement)
                {
                    if (reader.LocalName.Equals("トラップ"))
                    {
                        t.trapset();
                        motimono.traplist.Add(t);
                    }
                }
            }

            Flag.loadfrag = true;
            reader.Close();

        }

        //トラップフィールド
        public static void tfieldsave()
        {
            string fname = "save\\tfield.xml";
            XmlTextWriter xtw = null;
            try
            {
                string[] separator = { "\r\n" };
                xtw = new XmlTextWriter(fname, Encoding.Default);
                //インデントするかどうか
                xtw.Formatting = Formatting.Indented;

                xtw.WriteStartDocument();//XML宣言
                xtw.WriteStartElement("設置トラップデータ");

                for (int i = 0; i < motimono.tfield.GetLength(0); i++)
                    for (int l = 0; l < motimono.tfield.Length / motimono.tfield.GetLength(0); l++)
                    {
                        if (motimono.tfield[i, l] != null || motimono.trapenable[i, l] != 0)
                        {
                            xtw.WriteStartElement("設置トラップpart" + i + l);
                            if (motimono.tfield[i, l] != null)
                            {


                                xtw.WriteElementString("typepart" + i + l, motimono.tfield[i, l].type.ToString());
                                xtw.WriteElementString("gradepart" + i + l, motimono.tfield[i, l].grade.ToString());
                                xtw.WriteElementString("directionpart" + i + l, motimono.tfield[i, l].direction.ToString());

                            }

                            if (motimono.trapenable[i, l] != 0)
                                xtw.WriteElementString("enablepart" + i + l, motimono.trapenable[i, l].ToString());

                            xtw.WriteEndElement();
                        }
                    }
                xtw.WriteEndElement();
                xtw.WriteEndDocument();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                xtw.Close();
            }

        }

        public static void tfieldload()
        {
            string fname = "save\\tfield.xml";
            XmlTextReader reader = new XmlTextReader(fname);
            trap v = new trap(0, 0);

            Boolean flag=false;
            string[] bun = {"part"};
            int ten=-1;
            int iti=-1;
            int type = 0;
            int grade = 0;
            int direction = 0;

            try
            {
                while (reader.Read())
                {
                        if (reader.NodeType == XmlNodeType.Element)
                        {
                            string s = reader.LocalName;
                            string[] ps = s.Split(bun, StringSplitOptions.None);
                            if (s != "設置トラップデータ")
                            {
                                int.TryParse(ps[1], out ten);
                                ten = ten / 10;
                                int.TryParse(ps[1], out iti);
                                iti = iti % 10;
                            }
                            //MessageBox.Show(s+ten.ToString()+ iti.ToString());

                            if (s.Equals("設置トラップpart" + ten + iti))
                            {
                            }
                            else if (s.Equals("typepart" + ten + iti))
                            {
                                int.TryParse(reader.ReadString(), out type);
                                flag = true;
                            }
                            else if (s.Equals("gradepart" + ten + iti))
                                int.TryParse(reader.ReadString(), out grade);
                            else if (s.Equals("directionpart" + ten + iti))
                                int.TryParse(reader.ReadString(), out direction);
                            else if (s.Equals("enablepart" + ten + iti))
                                int.TryParse(reader.ReadString(), out motimono.trapenable[ten, iti]);

                        }
                        else if (reader.NodeType == XmlNodeType.EndElement)
                        {
                            if (reader.LocalName.Equals("設置トラップpart" + ten + iti))
                            {
                                if (flag == true)
                                {
                                    v = new trap(type, grade);
                                    v.trapset();
                                    if (v.direct == true)
                                    {
                                        v.direction = direction;
                                        //MessageBox.Show(direction.ToString());
                                    }
                                    motimono.tfield[ten , iti] = v;
                                    if (motimono.tpointd[ten, iti] == null)
                                        motimono.tpointd[ten, iti] = new trappoint();
                                    motimono.tpointd[ten, iti].tplist.AddRange(motimono.trappointdset(v, ten, iti));
                                    motimono.trappointset(ten, iti);
                                }
                                flag = false;
                            }
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Flag.loadfrag = true;
                reader.Close();
            }
        }

        //ペドロさんの種
        public static void pedroseedsave()
        {
            string fname = "save\\pedroseed.xml";
            XmlTextWriter xtw = null;
            try
            {
                string[] separator = { "\r\n" };
                xtw = new XmlTextWriter(fname, Encoding.Default);
                //インデントするかどうか
                xtw.Formatting = Formatting.Indented;

                xtw.WriteStartDocument();//XML宣言
                xtw.WriteStartElement("種データ");
                for (int i = 0; i <motimono.pedroseed.Count; i++)
                {
                    xtw.WriteStartElement("種");

                    xtw.WriteElementString("department",motimono.pedroseed[i].department.ToString());
                    xtw.WriteElementString("mendel",motimono.pedroseed[i].mendel.ToString());
                    xtw.WriteEndElement();
                }
                xtw.WriteEndElement();

                xtw.WriteEndDocument();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                xtw.Close();
            }
        }

        public static void pedroseedload()
        {
            string fname = "save\\pedroseed.xml";
            XmlTextReader reader = new XmlTextReader(fname);
            seed s = new seed();
            int men=0;
            int dep=0;
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    if (reader.LocalName.Equals("種"))
                        s = new seed();
                    else if (reader.LocalName.Equals("mendel"))
                        int.TryParse(reader.ReadString(), out men);
                    else if (reader.LocalName.Equals("department"))
                        int.TryParse(reader.ReadString(), out dep);
                }
                else if (reader.NodeType == XmlNodeType.EndElement)
                    if (reader.LocalName.Equals("種"))
                    {
                        s.baseset(men, dep);
                        motimono.pedroseed.Add(s);
                    }
            }

            Flag.loadfrag = true;
            reader.Close();

        }

        //ペドロさんのトラップ
        public static void pedrotrapsave()
        {
            string fname = "save\\pedrotrap.xml";
            XmlTextWriter xtw = null;
            try
            {
                string[] separator = { "\r\n" };
                xtw = new XmlTextWriter(fname, Encoding.Default);
                //インデントするかどうか
                xtw.Formatting = Formatting.Indented;

                xtw.WriteStartDocument();//XML宣言
                xtw.WriteStartElement("トラップデータ");

                for (int i = 0; i < motimono.pedrotrap.Count; i++)
                {
                    xtw.WriteStartElement("トラップ");

                    xtw.WriteElementString("type", motimono.pedrotrap[i].type.ToString());
                    xtw.WriteElementString("grade", motimono.pedrotrap[i].grade.ToString());

                    xtw.WriteEndElement();
                }
                xtw.WriteEndElement();

                xtw.WriteEndDocument();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                xtw.Close();
            }
        }

        public static void pedrotrapload()
        {
            string fname = "save\\pedrotrap.xml";
            XmlTextReader reader = new XmlTextReader(fname);
            trap t = new trap(0, 0);

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    if (reader.LocalName.Equals("トラップ"))
                        t = new trap(0, 0);
                    else if (reader.LocalName.Equals("type"))
                        int.TryParse(reader.ReadString(), out t.type);
                    else if (reader.LocalName.Equals("grade"))
                        int.TryParse(reader.ReadString(), out t.grade);
                }
                else if (reader.NodeType == XmlNodeType.EndElement)
                    if (reader.LocalName.Equals("トラップ"))
                    {
                        t.trapset();
                        motimono.pedrotrap.Add(t);
                    }
            }

            Flag.loadfrag = true;
            reader.Close();

        }

    }
}
