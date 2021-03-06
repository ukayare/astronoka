﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsApplication1
{
    //トラップバトル場
    public partial class trapfield : Form
    {
        public trapfield()
        {
            InitializeComponent();
        }

        internal int direction;//方向
        internal Boolean flag=false;//フラグ
        trap selectedtrap;

        int count = 0;
        int count2 = 0;
        private List<point> traprange= new List<point>();

        music sound;


        //ロード
        private void trapfield_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
            musicstart();
            comboset();

            makepiclist();
            setpic();
            this.label2.Text = "残り電力：" + (date.electmax - date.elect);
        }

        //閉じる
        private void butclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //指定した座標にトラップを設置
        private void trapset(int x, int y)
        {
            if (selectedtrap != null)//トラップは選択してあるか
            {
                if (motimono.trapenable[x, y] == 0 || motimono.tfield[x, y] != null)
                {
                    int i = motimono.traplist.FindIndex(t => t.name == this.listBox1.SelectedItem.ToString());
                    if (motimono.tfield[x, y] != null)
                    {
                        //すでに設置されている場合
                        if (motimono.traplist[i].elect > date.electmax - date.elect + motimono.tfield[x, y].elect)
                            MessageBox.Show("そのトラップを入れ替えても電力が足りません");
                        else if (MessageBox.Show("すでに" + motimono.tfield[x, y].name + "が設置されています。\n入れ替えて" + motimono.traplist[i].name + "を設置しますか？", "設置確認", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            trap swaptrap = motimono.tfield[x, y];
                            tremove(x, y);
                            i = motimono.traplist.FindIndex(t => t.name == this.listBox1.SelectedItem.ToString());
                            tset(x, y, i);
                            selectedtrap = swaptrap;
                            i = motimono.traplist.FindIndex(t => t.name == selectedtrap.name);
                            this.listBox1.SelectedIndex = i;

                        }

                    }
                    //何もない場合
                    else if (motimono.traplist[i].elect > date.electmax - date.elect)
                        MessageBox.Show("電力が足りません");
                    else
                    {
                        tset(x, y, i);
                    }
                }
                else
                    MessageBox.Show("起動範囲が重なっているため設置できません");
            }
            else
            {
                if (motimono.tfield[x, y] != null)//設置されてるか
                {
                    selectedtrap = motimono.tfield[x, y];
                    tremove(x, y);
                    this.listBox1.Items.Clear();
                    this.comboBox1.SelectedIndex = -1;
                    this.comboBox1.SelectedIndex = 0;
                    Flag.trapsearch();
                    
                    int i = motimono.traplist.FindIndex(t => t.name == selectedtrap.name);
                    this.listBox1.SelectedIndex = i;
                }
            }
        }

        //トラップ設置の処理
        private void tset(int x, int y, int i)
        {
            if (motimono.traplist[i].type == 13)
            {
                kakashidirect kd = new kakashidirect(motimono.traplist[i]);
                kd.pointer = this;
                kd.ShowDialog();
            }
            //方向設定する場合
            else if (motimono.traplist[i].direct == true)
            {
                trapdirection td = new trapdirection(motimono.traplist[i], x, y);
                td.pointer = this;
                td.ShowDialog();
            }

            //方向設置の場合はフラグが立ってるかをチェック//どっちもfalseは方向設定しないやつの場合
            if (!(motimono.traplist[i].direct == true ^ flag==true))
            {
                //設置用に作って設置
                trap t = new trap(motimono.traplist[i].type,motimono.traplist[i].grade);
                motimono.tfield[x, y] = t;
                //減らして０なら削除
                motimono.traplist[i].items--;
                if (motimono.traplist[i].items == 0)
                    motimono.traplist.RemoveAt(i);
                motimono.trapsort();
                this.listBox1.Items.Clear();
                comboset();
                //電力を減らす
                electset(motimono.tfield[x, y], true);

                motimono.trapenable[x, y] = 1;
                if (t.direct == true)//方向設置の場合directionを設定
                {
                    //設定して画像配置
                    motimono.tfield[x, y].direction = direction;
                    piclist[x, y + 2].ImageLocation = "trap\\" + motimono.tfield[x, y].type + motimono.tfield[x, y].grade + +motimono.tfield[x, y].direction + ".bmp";

                    //enableの設定(値の詳細はmotimono参照
                    if (t.happen == 2)
                    {
                        switch (t.direction)
                        {
                            case 0:
                                if (y < 8)
                                    motimono.trapenable[x, y + 1] = motimono.tfield[x, y].direction + 2;
                                break;
                            case 1:
                                if (x < 8)
                                    motimono.trapenable[x + 1, y] = motimono.tfield[x, y].direction + 2;
                                break;
                            case 2:
                                if (y > 0)
                                    motimono.trapenable[x, y - 1] = motimono.tfield[x, y].direction + 2;
                                break;
                            case 3:
                                if (x > 0)
                                    motimono.trapenable[x - 1, y] = motimono.tfield[x, y].direction + 2;
                                break;
                        }
                    }
                    else if (t.happen == 3)
                    {
                        switch (t.direction)
                        {
                            case 0:
                                if (y < 8)
                                    motimono.trapenable[x, y + 1] = motimono.tfield[x, y].direction + 6;
                                break;
                            case 1:
                                if (x < 8)
                                    motimono.trapenable[x + 1, y] = motimono.tfield[x, y].direction + 6;
                                break;
                            case 2:
                                if (y > 0)
                                    motimono.trapenable[x, y - 1] = motimono.tfield[x, y].direction + 6;
                                break;
                            case 3:
                                if (x > 0)
                                    motimono.trapenable[x - 1, y] = motimono.tfield[x, y].direction + 6;
                                break;
                        }
                    }
                }
                else
                {
                    piclist[x, y + 2].ImageLocation = "trap\\" + motimono.tfield[x, y].type + motimono.tfield[x, y].grade + ".bmp";
                }
                flag = false;//フラグは最後に折っておく
                if (motimono.trappointdset(motimono.tfield[x, y], x, y).Count > 0)
                {
                    if (motimono.tpointd[x, y] == null)
                        motimono.tpointd[x, y] = new trappoint();
                    motimono.tpointd[x, y].tplist.AddRange(motimono.trappointdset(motimono.tfield[x, y], x, y));
                    motimono.trappointset(x, y);
                }
                selectedtrap = null;
                this.trapextext.Text = "";
            }
        }

        //トラップの撤去
        private void tremove(int x, int y)
        {
            //撤去するトラップが持ち物に存在捨ている場合はそのままそこに加算
            int j = motimono.traplist.FindIndex(t => t.name == motimono.tfield[x, y].name);
            if (j != -1)
            {
                motimono.traplist[j].items++;
            }
            else
                motimono.traplist.Add(motimono.tfield[x, y]);
            motimono.trapenable[x, y] = 0;//設置識別を解除
            if (motimono.tfield[x, y].happen == 2 || motimono.tfield[x, y].happen == 3)//方向でenableセットしてる場合は初期化
            {
                //方向設定してあったらその方向も解除
                switch (motimono.tfield[x, y].direction)
                {
                    case 0:
                        if (y < 8)
                            motimono.trapenable[x, y + 1] = 0;
                        break;
                    case 1:
                        if (x < 8)
                            motimono.trapenable[x + 1, y] = 0;
                        break;
                    case 2:
                        if (y > 0)
                            motimono.trapenable[x, y - 1] = 0;
                        break;
                    case 3:
                        if (x > 0)
                            motimono.trapenable[x - 1, y] = 0;
                        break;
                }
            }
            electset(motimono.tfield[x, y], false);
            motimono.tfield[x, y] = null;//フィールドから消去
            motimono.trappointremove(x, y);
            piclist[x, y + 2].ImageLocation = null;//画像も戻す
            piclist[x, y + 2].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            motimono.trapsort();
            this.trapextext2.Text = "";
            mouseLeave(x, y);
            mouseEnter(x, y);
        }

        //トラップ選択
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedtrap = stringcreate.trap_listBox_changed(this.listBox1, this.trapextext,this.label1);
        }

        //種類選択
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            if (this.comboBox1.SelectedIndex != -1)
            {
                //全部は全て表示
                if (this.comboBox1.SelectedItem.ToString() == "全て")
                    foreach(trap t in motimono.traplist)
                        this.listBox1.Items.Add(t.name);
                
                else
                {
                    int i;
                    for (i = 0; i < Flag.tlist.Length; i++)
                        if (Flag.tname[i] == this.comboBox1.SelectedItem.ToString())
                            break;
                    int j = motimono.traplist.FindIndex(t => t.type == i);
                    this.listBox1.Items.Add(motimono.traplist[j].name);
                }
            }
        }


        private void musicstop()
        {
            sound.stop();
            sound.Dispose();
        }

        private void musicstart()
        {
            sound = new music("music\\settrap.mp3");
            sound.start();
        }

        private void trapfield_FormClosing(object sender, FormClosingEventArgs e)
        {
            musicstop();
        }

        //コンボボックスの設定
        private void comboset()
        {
            this.comboBox1.Items.Clear();
            Flag.trapsearch();
            this.comboBox1.Items.Add("全て");
            //存在する種類を追加
            for (int i = 0; i < Flag.tlist.Length; i++)
            {
                if (Flag.tlist[i] == true)
                    this.comboBox1.Items.Add(Flag.tname[i]);
            }
            this.comboBox1.SelectedIndex = -1;
            this.comboBox1.SelectedIndex = 0;
        }

        //電力セット（remorsetはfalseで撤去時、trueで設置時）
        private void electset(trap t,Boolean remorset)
        {
            if (remorset == true)
                date.elect += t.elect;
            else
                date.elect -= t.elect;
            this.label2.Text="残り電力："+(date.electmax-date.elect);
        }

        private void mouseEnter(int x, int y)
        {
            trapextext2.Text = "";
            //選択したものを取得
            if (motimono.tfield[x,y] != null)
            {
                trapextext2.AppendText(stringcreate.trapinfo(motimono.tfield[x, y]));
            }

            if (selectedtrap != null)
            {
                piclist[x, y + 2].ImageLocation = "trap\\" + selectedtrap.type + selectedtrap.grade + ".bmp";
                if (selectedtrap.constrange == true)
                {
                    traprange = motimono.trappointdset(selectedtrap, x, y);
                    foreach (point p in traprange)
                    {
                        rangedisplay(p);
                    }
                }
            }
            else if (motimono.tfield[x, y] != null && motimono.tfield[x, y].range == true)
            {
                traprange.AddRange(motimono.tpointd[x, y].tplist);
                foreach (point p in traprange)
                {
                    rangedisplay(p);
                }
            }
            this.label3.Text = x.ToString() + y.ToString();
            
        }

        private void rangedisplay(point p)
        {
            if (p.y < 0)
            {
                piclist[p.x, p.y + 2].BackColor = System.Drawing.Color.DarkGray;
            }
            else if (motimono.tfield[p.x, p.y] != null)
            {
                if (motimono.tfield[p.x, p.y].direct == true)//方向設置か
                    piclist[p.x, p.y + 2].ImageLocation = "trap\\" + motimono.tfield[p.x, p.y].type + motimono.tfield[p.x, p.y].grade + motimono.tfield[p.x, p.y].direction + "a.bmp";
                else
                    piclist[p.x, p.y + 2].ImageLocation = "trap\\" + motimono.tfield[p.x, p.y].type + motimono.tfield[p.x, p.y].grade + "a.bmp";
            }
            else
                piclist[p.x, p.y + 2].BackColor = System.Drawing.Color.DarkGray;
        }

        private void rangeundisplay(point p)
        {
            //最初に設置範囲外の処理
            if (p.y == -1)
            {
                if (p.x == 4)
                    piclist[p.x, p.y + 2].BackColor = System.Drawing.Color.Sienna;
                else
                    piclist[p.x, p.y + 2].BackColor = System.Drawing.Color.ForestGreen;
            }
            else if (p.y == -2)
            {
                if (p.x == 4)
                    piclist[p.x, p.y + 2].BackColor = System.Drawing.Color.Sienna;
                else
                    piclist[p.x, p.y + 2].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            }
            else if (((p.y >= 0 && p.y <= 1) || (p.y >= 7 && p.y <= 8)) && (p.x >= 3 && p.x <= 5))
                piclist[p.x, p.y + 2].BackColor = System.Drawing.Color.YellowGreen;
            else if (motimono.tfield[p.x, p.y] != null)
            {
                if (motimono.tfield[p.x, p.y].direct == true)//方向設置か
                    piclist[p.x, p.y + 2].ImageLocation = "trap\\" + motimono.tfield[p.x, p.y].type + motimono.tfield[p.x, p.y].grade + motimono.tfield[p.x, p.y].direction + ".bmp";
                else
                    piclist[p.x, p.y + 2].ImageLocation = "trap\\" + motimono.tfield[p.x, p.y].type + motimono.tfield[p.x, p.y].grade + ".bmp";
            }
            else
            {
                piclist[p.x, p.y + 2].ImageLocation = null;
                piclist[p.x, p.y + 2].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            }
        }

        private void mouseLeave(int x, int y)
        {
            this.trapextext2.Text = "";
            if (motimono.tfield[x, y] != null)
            {
                if (motimono.tfield[x, y].direct == true)
                    piclist[x, y + 2].ImageLocation = "trap\\" + motimono.tfield[x, y].type + motimono.tfield[x, y].grade + +motimono.tfield[x, y].direction + ".bmp";
                else
                    piclist[x, y + 2].ImageLocation = "trap\\" + motimono.tfield[x, y].type + motimono.tfield[x, y].grade + ".bmp";
            }
            else
            {
                piclist[x, y + 2].ImageLocation = null;
            }
            if (traprange.Count > 0)
            {
                foreach (point p in traprange)
                    rangeundisplay(p);
                traprange.Clear();
            }
            this.label3.Text = "0"+(count2-count);
        }


        private void butunselect_Click(object sender, EventArgs e)
        {
            this.listBox1.SelectedIndex = -1;
            selectedtrap = null;
        }

        private void trapextext2_TextChanged(object sender, EventArgs e)
        {

        }


    }
}