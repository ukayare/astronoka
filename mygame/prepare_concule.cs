﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class prepare_concule : Form
    {
        public prepare_concule(int month,int day)
        {
            InitializeComponent();
            conculeset(month, day);
        }

        private void conculeset(int month,int day)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conculeseed cs = new conculeseed("");
            cs.ShowDialog();
        }
    }
}
