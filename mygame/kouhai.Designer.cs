namespace WindowsFormsApplication1
{
    partial class kouhai
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.butmix = new System.Windows.Forms.Button();
            this.butfin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.depbox1 = new System.Windows.Forms.ListBox();
            this.depbox2 = new System.Windows.Forms.ListBox();
            this.namebox1 = new System.Windows.Forms.ListBox();
            this.namebox2 = new System.Windows.Forms.ListBox();
            this.butst1 = new System.Windows.Forms.Button();
            this.butst2 = new System.Windows.Forms.Button();
            this.butex = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(355, 171);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(274, 136);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 12;
            this.listBox2.Location = new System.Drawing.Point(355, 355);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(274, 136);
            this.listBox2.TabIndex = 1;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // butmix
            // 
            this.butmix.Location = new System.Drawing.Point(264, 512);
            this.butmix.Name = "butmix";
            this.butmix.Size = new System.Drawing.Size(75, 23);
            this.butmix.TabIndex = 2;
            this.butmix.Text = "交配";
            this.butmix.UseVisualStyleBackColor = true;
            this.butmix.Click += new System.EventHandler(this.butmix_Click);
            // 
            // butfin
            // 
            this.butfin.Location = new System.Drawing.Point(478, 512);
            this.butfin.Name = "butfin";
            this.butfin.Size = new System.Drawing.Size(75, 23);
            this.butfin.TabIndex = 3;
            this.butfin.Text = "終了";
            this.butfin.UseVisualStyleBackColor = true;
            this.butfin.Click += new System.EventHandler(this.butfin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(648, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(648, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 5;
            // 
            // depbox1
            // 
            this.depbox1.FormattingEnabled = true;
            this.depbox1.ItemHeight = 12;
            this.depbox1.Items.AddRange(new object[] {
            "全て",
            "A科",
            "B科",
            "C科",
            "強化種"});
            this.depbox1.Location = new System.Drawing.Point(65, 171);
            this.depbox1.Name = "depbox1";
            this.depbox1.Size = new System.Drawing.Size(43, 64);
            this.depbox1.TabIndex = 6;
            this.depbox1.SelectedIndexChanged += new System.EventHandler(this.depbox1_SelectedIndexChanged);
            // 
            // depbox2
            // 
            this.depbox2.FormattingEnabled = true;
            this.depbox2.ItemHeight = 12;
            this.depbox2.Items.AddRange(new object[] {
            "全て",
            "A科",
            "B科",
            "C科",
            "強化種"});
            this.depbox2.Location = new System.Drawing.Point(65, 355);
            this.depbox2.Name = "depbox2";
            this.depbox2.Size = new System.Drawing.Size(43, 64);
            this.depbox2.TabIndex = 7;
            this.depbox2.SelectedIndexChanged += new System.EventHandler(this.depbox2_SelectedIndexChanged);
            // 
            // namebox1
            // 
            this.namebox1.FormattingEnabled = true;
            this.namebox1.ItemHeight = 12;
            this.namebox1.Location = new System.Drawing.Point(150, 171);
            this.namebox1.Name = "namebox1";
            this.namebox1.Size = new System.Drawing.Size(120, 136);
            this.namebox1.TabIndex = 8;
            this.namebox1.SelectedIndexChanged += new System.EventHandler(this.namebox1_SelectedIndexChanged);
            // 
            // namebox2
            // 
            this.namebox2.FormattingEnabled = true;
            this.namebox2.ItemHeight = 12;
            this.namebox2.Location = new System.Drawing.Point(150, 355);
            this.namebox2.Name = "namebox2";
            this.namebox2.Size = new System.Drawing.Size(120, 136);
            this.namebox2.TabIndex = 9;
            this.namebox2.SelectedIndexChanged += new System.EventHandler(this.namebox2_SelectedIndexChanged);
            // 
            // butst1
            // 
            this.butst1.Location = new System.Drawing.Point(650, 284);
            this.butst1.Name = "butst1";
            this.butst1.Size = new System.Drawing.Size(75, 23);
            this.butst1.TabIndex = 10;
            this.butst1.Text = "詳細1";
            this.butst1.UseVisualStyleBackColor = true;
            this.butst1.Click += new System.EventHandler(this.butst1_Click);
            // 
            // butst2
            // 
            this.butst2.Location = new System.Drawing.Point(650, 468);
            this.butst2.Name = "butst2";
            this.butst2.Size = new System.Drawing.Size(75, 23);
            this.butst2.TabIndex = 11;
            this.butst2.Text = "詳細2";
            this.butst2.UseVisualStyleBackColor = true;
            this.butst2.Click += new System.EventHandler(this.butst2_Click);
            // 
            // butex
            // 
            this.butex.Location = new System.Drawing.Point(673, 26);
            this.butex.Name = "butex";
            this.butex.Size = new System.Drawing.Size(88, 23);
            this.butex.TabIndex = 12;
            this.butex.Text = "交配の手引き";
            this.butex.UseVisualStyleBackColor = true;
            this.butex.Click += new System.EventHandler(this.butex_Click);
            // 
            // kouhai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.butex);
            this.Controls.Add(this.butst2);
            this.Controls.Add(this.butst1);
            this.Controls.Add(this.namebox2);
            this.Controls.Add(this.namebox1);
            this.Controls.Add(this.depbox2);
            this.Controls.Add(this.depbox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butfin);
            this.Controls.Add(this.butmix);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "kouhai";
            this.Text = "kouhai";
            this.Load += new System.EventHandler(this.kouhai_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button butmix;
        private System.Windows.Forms.Button butfin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox depbox1;
        private System.Windows.Forms.ListBox depbox2;
        private System.Windows.Forms.ListBox namebox1;
        private System.Windows.Forms.ListBox namebox2;
        private System.Windows.Forms.Button butst1;
        private System.Windows.Forms.Button butst2;
        private System.Windows.Forms.Button butex;
    }
}