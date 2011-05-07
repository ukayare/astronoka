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
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 12;
            this.listBox.Location = new System.Drawing.Point(343, 240);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(199, 88);
            this.listBox.TabIndex = 0;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged_1);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 12;
            this.listBox2.Location = new System.Drawing.Point(327, 44);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(178, 88);
            this.listBox2.TabIndex = 1;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // bnameBox
            // 
            this.bnameBox.FormattingEnabled = true;
            this.bnameBox.ItemHeight = 12;
            this.bnameBox.Location = new System.Drawing.Point(174, 44);
            this.bnameBox.Name = "bnameBox";
            this.bnameBox.Size = new System.Drawing.Size(111, 88);
            this.bnameBox.TabIndex = 2;
            this.bnameBox.SelectedIndexChanged += new System.EventHandler(this.bnameBox_SelectedIndexChanged);
            // 
            // butget
            // 
            this.butget.Location = new System.Drawing.Point(343, 168);
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
            this.comboBox1.Location = new System.Drawing.Point(207, 170);
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
            this.itembox.Location = new System.Drawing.Point(43, 240);
            this.itembox.Name = "itembox";
            this.itembox.Size = new System.Drawing.Size(39, 40);
            this.itembox.TabIndex = 5;
            this.itembox.SelectedIndexChanged += new System.EventHandler(this.itembox_SelectedIndexChanged);
            // 
            // depbox
            // 
            this.depbox.FormattingEnabled = true;
            this.depbox.ItemHeight = 12;
            this.depbox.Location = new System.Drawing.Point(110, 240);
            this.depbox.Name = "depbox";
            this.depbox.Size = new System.Drawing.Size(55, 88);
            this.depbox.TabIndex = 6;
            this.depbox.SelectedIndexChanged += new System.EventHandler(this.depbox_SelectedIndexChanged);
            // 
            // namebox
            // 
            this.namebox.FormattingEnabled = true;
            this.namebox.ItemHeight = 12;
            this.namebox.Location = new System.Drawing.Point(196, 240);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(120, 88);
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
            this.bitemBox1.Location = new System.Drawing.Point(43, 44);
            this.bitemBox1.Name = "bitemBox1";
            this.bitemBox1.Size = new System.Drawing.Size(40, 28);
            this.bitemBox1.TabIndex = 8;
            this.bitemBox1.SelectedIndexChanged += new System.EventHandler(this.bitemBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(343, 355);
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
            this.buyBox2.Location = new System.Drawing.Point(216, 355);
            this.buyBox2.Name = "buyBox2";
            this.buyBox2.Size = new System.Drawing.Size(43, 20);
            this.buyBox2.TabIndex = 10;
            this.buyBox2.SelectedIndexChanged += new System.EventHandler(this.buyBox2_SelectedIndexChanged);
            // 
            // butclose
            // 
            this.butclose.Location = new System.Drawing.Point(254, 407);
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
            this.buylabel.Location = new System.Drawing.Point(281, 363);
            this.buylabel.Name = "buylabel";
            this.buylabel.Size = new System.Drawing.Size(0, 12);
            this.buylabel.TabIndex = 13;
            // 
            // prdro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 442);
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
    }
}