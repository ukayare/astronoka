using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace WindowsFormsApplication1
{
    public class article
    {
        public article(int topic,int year,int month,int day,string author,string title)
        {
            this.topic = topic;
            this.year = year;
            this.month = month;
            this.day = day;
            this.author = author;
            this.title = title;
        }

        readonly int topic;

        readonly int year;
        readonly int month;
        readonly int day;

        readonly string author;
        readonly string title;

        public string context
        {
            get
            {
                StreamReader reader = new StreamReader("astronet\\" + title + ".txt", System.Text.Encoding.GetEncoding("shift_jis"));
                return reader.ReadToEnd();
            }
        }

    }
}
