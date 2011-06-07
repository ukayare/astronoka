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
    public partial class calendar : Form
    {
        public calendar()
        {
            InitializeComponent();
            settableday();
        }

        private int month;
        private readonly TableLayoutPanel[] day=new TableLayoutPanel[28];

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void calendar_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
            this.month = date.month;
            monthchanged();
        }

        private void monthchanged()
        {
            this.labelmonth.Text = this.month + "月";

            switch (month)
            {
                case 1:
                    this.tableday17.BackColor = weekdaycolor;
                    this.tableday27.BackColor = weekdaycolor;

                    this.tableday1.BackColor = holidaycolor;
                    this.tableday25.BackColor = holidaycolor;

                    this.tableday10.BackColor = weekdaycolor;
                    break;
                case 2:
                    this.tableday1.BackColor = weekdaycolor;
                    this.tableday25.BackColor = weekdaycolor;

                    this.tableday10.BackColor = holidaycolor;

                    break;
                case 3:
                    this.tableday10.BackColor = weekdaycolor;

                    this.tableday20.BackColor = weekdaycolor;
                    this.tableday23.BackColor = weekdaycolor;
                    break;
                case 4:

                    this.tableday10.BackColor = holidaycolor;
                    this.tableday20.BackColor = holidaycolor;
                    this.tableday22.BackColor = holidaycolor;

                    this.tableday23.BackColor = weekdaycolor;

                    break;
                case 5:
                    this.tableday10.BackColor = weekdaycolor;
                    this.tableday20.BackColor = weekdaycolor;
                    this.tableday22.BackColor = weekdaycolor;

                    this.tableday23.BackColor = holidaycolor;

                    this.tableday17.BackColor = weekdaycolor;
                    this.tableday27.BackColor = weekdaycolor;

                    break;
                case 6:
                    this.tableday10.BackColor = weekdaycolor;
                    this.tableday20.BackColor = weekdaycolor;
                    this.tableday23.BackColor = weekdaycolor;

                    this.tableday17.BackColor = holidaycolor;
                    this.tableday27.BackColor = holidaycolor;

                    this.tableday1.BackColor = weekdaycolor;
                    this.tableday25.BackColor = weekdaycolor;

                    break;
            }

            if (month == date.month)
            {
                this.day[date.day - 1].BackColor = todaycolor;
            }
        }

        private System.Drawing.Color todaycolor
        {
            get
            {
                return System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            }
        }

        private System.Drawing.Color weekdaycolor
        {
            get
            {
                return System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            }
        }

        private System.Drawing.Color holidaycolor
        {
            get
            {
                return System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            month--;
            if (month == 0)
                month = 6;
            monthchanged();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            month++;
            if (month == 7)
                month = 1;
            monthchanged();
        }

        private string dayinfoset
        {
            set
            {
                this.dayinfo.Text = value;
            }
        }


        private void dayinfoclear()
        {
            dayinfoset = "";
            this.holoday.Text = "";
        }
        
        private void settableday()
        {
            this.day[0] = tableday1;
            this.day[1] = tableday2;
            this.day[2] = tableday3;
            this.day[3] = tableday4;
            this.day[4] = tableday5;
            this.day[5] = tableday6;
            this.day[6] = tableday7;
            this.day[7] = tableday8;
            this.day[8] = tableday9;
            this.day[9] = tableday10;
            this.day[10] = tableday11;
            this.day[11] = tableday12;
            this.day[12] = tableday13;
            this.day[13] = tableday14;
            this.day[14] = tableday15;
            this.day[15] = tableday16;
            this.day[16] = tableday17;
            this.day[17] = tableday18;
            this.day[18] = tableday19;
            this.day[19] = tableday20;
            this.day[20] = tableday21;
            this.day[21] = tableday22;
            this.day[22] = tableday23;
            this.day[23] = tableday24;
            this.day[24] = tableday25;
            this.day[25] = tableday26;
            this.day[26] = tableday27;
            this.day[27] = tableday28;
        }

        private void day7Enter(object sender, EventArgs e)
        {
            pantaset();
        }
        private void pantaset()
        {
            dayinfoset = "パンタロン町でコンクールを開催";
        }
        private void sonbset()
        {
            dayinfoset = "ソンブレロ市でコンクールを開催";
        }

        private void day14Enter(object sender, EventArgs e)
        {
            pantaset();
        }

        private void day21Enter(object sender, EventArgs e)
        {
            if (month != 1)
                dayinfoset = "テンガロン村でコンクールを開催";
            if (month == 2)
                this.holoday.Text = "新人の日";
            if (month == 4)
                this.holoday.Text = "収穫祭";
        }

        private void mouseLeave(object sender, EventArgs e)
        {
            dayinfoclear();
        }

        private void day28Enter(object sender, EventArgs e)
        {
            sonbset();
        }

        private void day1Enter(object sender, EventArgs e)
        {
            if (month == 1)
            {
                this.holoday.Text = "新年祭";
                dayinfoset = "アストロドームでコンクールを開催";
            }
        }

        private void day2Enter(object sender, EventArgs e)
        {

        }

        private void day3Enter(object sender, EventArgs e)
        {

        }

        private void day4Enter(object sender, EventArgs e)
        {

        }

        private void day5Enter(object sender, EventArgs e)
        {

        }

        private void day6Enter(object sender, EventArgs e)
        {

        }

        private void day8Enter(object sender, EventArgs e)
        {

        }

        private void day9Enter(object sender, EventArgs e)
        {

        }

        private void day10Enter(object sender, EventArgs e)
        {
            if (month == 2)
                this.holoday.Text = "ニッカポッカ記念日";
            if (month == 4)
                this.holoday.Text = "惑星探査の日";
        }

        private void day11Enter(object sender, EventArgs e)
        {

        }

        private void day12Enter(object sender, EventArgs e)
        {

        }

        private void day13Enter(object sender, EventArgs e)
        {

        }

        private void day15Enter(object sender, EventArgs e)
        {

        }

        private void day16Enter(object sender, EventArgs e)
        {

        }

        private void day17Enter(object sender, EventArgs e)
        {
            if (month == 6)
                this.holoday.Text = "満月の日";
        }

        private void day18Enter(object sender, EventArgs e)
        {

        }

        private void day19Enter(object sender, EventArgs e)
        {

        }

        private void day20Enter(object sender, EventArgs e)
        {
            if (month == 4)
                this.holoday.Text = "収穫祭";
        }

        private void day22Enter(object sender, EventArgs e)
        {
            if (month == 4)
                this.holoday.Text = "収穫祭";
        }

        private void day23Enter(object sender, EventArgs e)
        {
            if (month == 5)
            {
                this.holoday.Text = "暗黒星雲の日";
                sonbset();
            }
        }

        private void day24Enter(object sender, EventArgs e)
        {

        }

        private void day25Enter(object sender, EventArgs e)
        {
            if (month == 1)
            {
                this.holoday.Text = "ハーブ祭";
                sonbset();
            }
        }

        private void day26Enter(object sender, EventArgs e)
        {

        }

        private void day27Enter(object sender, EventArgs e)
        {
            if (month == 6)
            {
                this.holoday.Text = "雪祭り";
                sonbset();
            }
        }

    }
}
