namespace WindowsFormsApplication1
{
    partial class prdro
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.bnameBox = new System.Windows.Forms.ListBox();
            this.butget = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.itembox = new System.Windows.Forms.ListBox();
            this.depbox = new System.Windows.Forms.ListBox();
            this.namebox = new System.Windows.Forms.ListBox();
            this.bitemBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.buyBox2 = new System.Windows.Forms.ComboBox();
            this.butclose = new System.Windows.Forms.Button();
            this.plabel1 = new System.Windows.Forms.Label();
            this.buylabel = new System.Windows.Forms.Label();
            this.ele1 = new System.Windows.Forms.RichTextBox();
            this.info1 = new System.Windows.Forms.RichTextBox();
            this.eleval1 = new System.Windows.Forms.RichTextBox();
            this.elename1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.yasaiextext = new System.Windows.Forms.RichTextBox();
            this.ele2 = new System.Windows.Forms.RichTextBox();
            this.info2 = new System.Windows.Forms.RichTextBox();
            this.eleval2 = new System.Windows.Forms.RichTextBox();
            this.elename2 = new System.Windows.Forms.RichTextBox();
            this.yasaiextext2 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 12;
            this.listBox.Location = new System.Drawing.Point(173, 240);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(166, 208);
            this.listBox.TabIndex = 0;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged_1);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 12;
            this.listBox2.Location = new System.Drawing.Point(156, 20);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(183, 160);
            this.listBox2.TabIndex = 1;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // bnameBox
            // 
            this.bnameBox.FormattingEnabled = true;
            this.bnameBox.ItemHeight = 12;
            this.bnameBox.Items.AddRange(new object[] {
            "パンチングマシン"});
            this.bnameBox.Location = new System.Drawing.Point(44, 20);
            this.bnameBox.Name = "bnameBox";
            this.bnameBox.Size = new System.Drawing.Size(111, 160);
            this.bnameBox.TabIndex = 2;
            this.bnameBox.SelectedIndexChanged += new System.EventHandler(this.bnameBox_SelectedIndexChanged);
            // 
            // butget
            // 
            this.butget.Location = new System.Drawing.Point(233, 187);
            this.butget.Name = "butget";
            this.butget.Size = new System.Drawing.Size(75, 23);
            this.butget.TabIndex = 3;
            this.butget.Text = "購入";
            this.butget.UseVisualStyleBackColor = true;
            this.butget.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100"});
            this.comboBox1.Location = new System.Drawing.Point(175, 187);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(52, 20);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // itembox
            // 
            this.itembox.FormattingEnabled = true;
            this.itembox.ItemHeight = 12;
            this.itembox.Items.AddRange(new object[] {
            "種",
            "野菜",
            "トラップ"});
            this.itembox.Location = new System.Drawing.Point(4, 240);
            this.itembox.Name = "itembox";
            this.itembox.Size = new System.Drawing.Size(39, 40);
            this.itembox.TabIndex = 5;
            this.itembox.SelectedIndexChanged += new System.EventHandler(this.itembox_SelectedIndexChanged);
            // 
            // depbox
            // 
            this.depbox.FormattingEnabled = true;
            this.depbox.ItemHeight = 12;
            this.depbox.Location = new System.Drawing.Point(40, 240);
            this.depbox.Name = "depbox";
            this.depbox.Size = new System.Drawing.Size(32, 88);
            this.depbox.TabIndex = 6;
            this.depbox.SelectedIndexChanged += new System.EventHandler(this.depbox_SelectedIndexChanged);
            // 
            // namebox
            // 
            this.namebox.FormattingEnabled = true;
            this.namebox.ItemHeight = 12;
            this.namebox.Location = new System.Drawing.Point(73, 240);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(100, 208);
            this.namebox.TabIndex = 7;
            this.namebox.SelectedIndexChanged += new System.EventHandler(this.namebox_SelectedIndexChanged);
            // 
            // bitemBox1
            // 
            this.bitemBox1.FormattingEnabled = true;
            this.bitemBox1.ItemHeight = 12;
            this.bitemBox1.Items.AddRange(new object[] {
            "種",
            "トラップ"});
            this.bitemBox1.Location = new System.Drawing.Point(4, 20);
            this.bitemBox1.Name = "bitemBox1";
            this.bitemBox1.Size = new System.Drawing.Size(40, 28);
            this.bitemBox1.TabIndex = 8;
            this.bitemBox1.SelectedIndexChanged += new System.EventHandler(this.bitemBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(233, 447);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "売却";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buyBox2
            // 
            this.buyBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.buyBox2.FormattingEnabled = true;
            this.buyBox2.Location = new System.Drawing.Point(184, 450);
            this.buyBox2.Name = "buyBox2";
            this.buyBox2.Size = new System.Drawing.Size(43, 20);
            this.buyBox2.TabIndex = 10;
            this.buyBox2.SelectedIndexChanged += new System.EventHandler(this.buyBox2_SelectedIndexChanged);
            // 
            // butclose
            // 
            this.butclose.Location = new System.Drawing.Point(343, 512);
            this.butclose.Name = "butclose";
            this.butclose.Size = new System.Drawing.Size(75, 23);
            this.butclose.TabIndex = 11;
            this.butclose.Text = "閉じる";
            this.butclose.UseVisualStyleBackColor = true;
            this.butclose.Click += new System.EventHandler(this.butclose_Click);
            // 
            // plabel1
            // 
            this.plabel1.AutoSize = true;
            this.plabel1.Location = new System.Drawing.Point(281, 178);
            this.plabel1.Name = "plabel1";
            this.plabel1.Size = new System.Drawing.Size(0, 12);
            this.plabel1.TabIndex = 12;
            // 
            // buylabel
            // 
            this.buylabel.AutoSize = true;
            this.buylabel.Location = new System.Drawing.Point(505, 461);
            this.buylabel.Name = "buylabel";
            this.buylabel.Size = new System.Drawing.Size(0, 12);
            this.buylabel.TabIndex = 13;
            // 
            // ele1
            // 
            this.ele1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ele1.Location = new System.Drawing.Point(531, 52);
            this.ele1.Name = "ele1";
            this.ele1.ReadOnly = true;
            this.ele1.Size = new System.Drawing.Size(39, 172);
            this.ele1.TabIndex = 45;
            this.ele1.Text = "";
            // 
            // info1
            // 
            this.info1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.info1.Location = new System.Drawing.Point(568, 52);
            this.info1.Name = "info1";
            this.info1.ReadOnly = true;
            this.info1.Size = new System.Drawing.Size(104, 172);
            this.info1.TabIndex = 44;
            this.info1.Text = "";
            // 
            // eleval1
            // 
            this.eleval1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.eleval1.Location = new System.Drawing.Point(670, 52);
            this.eleval1.Name = "eleval1";
            this.eleval1.ReadOnly = true;
            this.eleval1.Size = new System.Drawing.Size(32, 172);
            this.eleval1.TabIndex = 46;
            this.eleval1.Text = "";
            // 
            // elename1
            // 
            this.elename1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.elename1.Location = new System.Drawing.Point(700, 52);
            this.elename1.Name = "elename1";
            this.elename1.ReadOnly = true;
            this.elename1.Size = new System.Drawing.Size(80, 172);
            this.elename1.TabIndex = 47;
            this.elename1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 42;
            // 
            // yasaiextext
            // 
            this.yasaiextext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.yasaiextext.Location = new System.Drawing.Point(345, 21);
            this.yasaiextext.Name = "yasaiextext";
            this.yasaiextext.ReadOnly = true;
            this.yasaiextext.Size = new System.Drawing.Size(186, 203);
            this.yasaiextext.TabIndex = 43;
            this.yasaiextext.Text = "";
            // 
            // ele2
            // 
            this.ele2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ele2.Location = new System.Drawing.Point(536, 272);
            this.ele2.Name = "ele2";
            this.ele2.ReadOnly = true;
            this.ele2.Size = new System.Drawing.Size(39, 172);
            this.ele2.TabIndex = 50;
            this.ele2.Text = "";
            // 
            // info2
            // 
            this.info2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.info2.Location = new System.Drawing.Point(573, 272);
            this.info2.Name = "info2";
            this.info2.ReadOnly = true;
            this.info2.Size = new System.Drawing.Size(104, 172);
            this.info2.TabIndex = 49;
            this.info2.Text = "";
            // 
            // eleval2
            // 
            this.eleval2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.eleval2.Location = new System.Drawing.Point(675, 272);
            this.eleval2.Name = "eleval2";
            this.eleval2.ReadOnly = true;
            this.eleval2.Size = new System.Drawing.Size(32, 172);
            this.eleval2.TabIndex = 51;
            this.eleval2.Text = "";
            // 
            // elename2
            // 
            this.elename2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.elename2.Location = new System.Drawing.Point(705, 272);
            this.elename2.Name = "elename2";
            this.elename2.ReadOnly = true;
            this.elename2.Size = new System.Drawing.Size(80, 172);
            this.elename2.TabIndex = 52;
            this.elename2.Text = "";
            // 
            // yasaiextext2
            // 
            this.yasaiextext2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.yasaiextext2.Location = new System.Drawing.Point(345, 241);
            this.yasaiextext2.Name = "yasaiextext2";
            this.yasaiextext2.ReadOnly = true;
            this.yasaiextext2.Size = new System.Drawing.Size(191, 203);
            this.yasaiextext2.TabIndex = 48;
            this.yasaiextext2.Text = "";
            // 
            // prdro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.ele2);
            this.Controls.Add(this.info2);
            this.Controls.Add(this.eleval2);
            this.Controls.Add(this.elename2);
            this.Controls.Add(this.yasaiextext2);
            this.Controls.Add(this.ele1);
            this.Controls.Add(this.info1);
            this.Controls.Add(this.eleval1);
            this.Controls.Add(this.elename1);
            this.Controls.Add(this.yasaiextext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buylabel);
            this.Controls.Add(this.plabel1);
            this.Controls.Add(this.butclose);
            this.Controls.Add(this.buyBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bitemBox1);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.depbox);
            this.Controls.Add(this.itembox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.butget);
            this.Controls.Add(this.bnameBox);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox);
            this.Name = "prdro";
            this.Text = "prdro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.prdro_FormClosing);
            this.Load += new System.EventHandler(this.prdro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox bnameBox;
        private System.Windows.Forms.Button butget;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox itembox;
        private System.Windows.Forms.ListBox depbox;
        private System.Windows.Forms.ListBox namebox;
        private System.Windows.Forms.ListBox bitemBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox buyBox2;
        private System.Windows.Forms.Button butclose;
        private System.Windows.Forms.Label plabel1;
        private System.Windows.Forms.Label buylabel;
        private System.Windows.Forms.RichTextBox ele1;
        private System.Windows.Forms.RichTextBox info1;
        private System.Windows.Forms.RichTextBox eleval1;
        private System.Windows.Forms.RichTextBox elename1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox yasaiextext;
        private System.Windows.Forms.RichTextBox ele2;
        private System.Windows.Forms.RichTextBox info2;
        private System.Windows.Forms.RichTextBox eleval2;
        private System.Windows.Forms.RichTextBox elename2;
        private System.Windows.Forms.RichTextBox yasaiextext2;
    }
}