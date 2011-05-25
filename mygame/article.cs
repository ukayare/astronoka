using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace WindowsFormsApplication1
{
    public class article
    {
        public article(int topic,int year,int month,int day,string author,string title,int type)
        {
            this.topic = topic;
            this.year = year;
            this.month = month;
            this.day = day;
            this.author = author;
            this.title = title;
            this.type = type;
        }

        internal int topic;//0コンクール　1トラップ　2野菜　3私書箱

        internal readonly int year;
        internal readonly int month;
        internal readonly int day;

        internal readonly string author;
        internal readonly string title;
        internal readonly int type;

        public readonly string context
        {
            get
            {
                StreamReader reader = new StreamReader("astronet\\" + title + type + ".txt", System.Text.Encoding.GetEncoding("shift_jis"));
                return reader.ReadToEnd();
            }
        }
    }
}
