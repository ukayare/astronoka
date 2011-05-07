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
    //トラップバトル場
    public partial class trapfield : Form
    {
        public trapfield()
        {
            InitializeComponent();
        }

        internal Form3 pointer = new Form3();//ポインタ
        public trapdirection td;//方向の決定
        internal int direction;//方向
        internal Boolean flag=false;//フラグ
        babooactive ba;//バブー行動（バトル用。これは別クラスで設定するかな

        music sound;

        //ロード
        private void trapfield_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
            musicstart();
            comboset();

            this.radioButton1.Select();
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
            MessageBox.Show(x.ToString() + y.ToString());
            if (this.radioButton1.Checked == true)//設置モード
            {
                if (this.listBox1.SelectedIndex != -1)//トラップは選択してあるか
                {
                    if (motimono.trapenable[x, y] == 0 || motimono.tfield[x,y]!=null)
                    {
                        int i = motimono.traplist.FindIndex(t => t.name == this.listBox1.SelectedItem.ToString());
                        if (motimono.tfield[x, y] != null)
                        {
                            //すでに設置されている場合
                            if (motimono.traplist[i].elect > date.electmax - date.elect + motimono.tfield[x, y].elect)
                                MessageBox.Show("そのトラップを入れ替えても電力が足りません");
                            else if (MessageBox.Show("すでに" + motimono.tfield[x, y].name + "が設置されています。\n入れ替えて" + motimono.traplist[i].name + "を設置しますか？", "設置確認", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                tremove(x, y);
                                tset(x, y, i);
                            }

                        }
                        //何もない場合
                        else if (motimono.traplist[i].elect > date.electmax - date.elect)
                            MessageBox.Show("電力が足りません");
                        else if (MessageBox.Show(motimono.traplist[i].name + "を設置しますか？", "設置確認", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            tset(x, y, i);
                        }
                    }
                    else
                        MessageBox.Show("起動範囲が重なっているため設置できません");
                }
                else
                    MessageBox.Show("設置するトラップを選んでください");
            }
            else if(this.radioButton2.Checked==true)//撤去モード
            {
                if (motimono.tfield[x, y] != null)//設置されてるか
                {
                    //撤去確認
                    if (MessageBox.Show(motimono.tfield[x, y].name + "を撤去しますか？", "撤去確認", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        tremove(x, y);
                        this.listBox1.Items.Clear();
                        this.comboBox1.SelectedIndex = -1;
                        this.comboBox1.SelectedIndex = 0;
                        this.pointer.trapsearch();
                    }
                }
                else
                    MessageBox.Show("トラップが設置されていません");
            }
        }

        //トラップ設置の処理
        private void tset(int x, int y, int i)
        {
            //方向設定する場合
            if (motimono.traplist[i].direct == true)
            {
                td = new trapdirection(motimono.traplist[i], x, y);
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
                if (flag == true)//方向設置の場合directionを設定
                {
                    //設定して画像配置
                    motimono.tfield[x, y].direction = direction;
                    piclist[x, y + 2].ImageLocation = "trap\\" + motimono.tfield[x, y].type + motimono.tfield[x, y].grade + +motimono.tfield[x,y].direction+".bmp";

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
                    piclist[x, y + 2].ImageLocation = "trap\\" + motimono.tfield[x, y].type + motimono.tfield[x, y].grade + ".bmp";
                flag = false;//フラグは最後に折っておく

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
            piclist[x, y + 2].ImageLocation = "trap\\null.bmp";//画像も戻す            
        }

        //トラップ選択
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //選択したものを取得
            if (this.listBox1.SelectedItem != null)
            {
                int i = motimono.traplist.FindIndex(t => t.name == this.listBox1.SelectedItem.ToString());
                this.label1.Text = motimono.traplist[i].items.ToString();
            }
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
                    for (i = 0; i < this.pointer.tlist.Length; i++)
                        if (this.pointer.tname[i] == this.comboBox1.SelectedItem.ToString())
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
            this.pointer.trapsearch();
            this.comboBox1.Items.Add("全て");
            //存在する種類を追加
            for (int i = 0; i < this.pointer.tlist.Length; i++)
            {
                if (this.pointer.tlist[i] == true)
                    this.comboBox1.Items.Add(this.pointer.tname[i]);
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
    }
}