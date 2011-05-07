namespace WindowsFormsApplication1
{
    partial class itemlist
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
            this.butclose = new System.Windows.Forms.Button();
            this.namebox1 = new System.Windows.Forms.ListBox();
            this.depbox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.butsyou = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butclose
            // 
            this.butclose.Location = new System.Drawing.Point(345, 194);
            this.butclose.Name = "butclose";
            this.butclose.Size = new System.Drawing.Size(75, 23);
            this.butclose.TabIndex = 0;
            this.butclose.Text = "閉じる";
            this.butclose.UseVisualStyleBackColor = true;
            this.butclose.Click += new System.EventHandler(this.butclose_Click);
            // 
            // namebox1
            // 
            this.namebox1.FormattingEnabled = true;
            this.namebox1.ItemHeight = 12;
            this.namebox1.Location = new System.Drawing.Point(208, 40);
            this.namebox1.Name = "namebox1";
            this.namebox1.Size = new System.Drawing.Size(120, 136);
            this.namebox1.TabIndex = 12;
            this.namebox1.SelectedIndexChanged += new System.EventHandler(this.namebox1_SelectedIndexChanged);
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
            this.depbox1.Location = new System.Drawing.Point(130, 40);
            this.depbox1.Name = "depbox1";
            this.depbox1.Size = new System.Drawing.Size(45, 64);
            this.depbox1.TabIndex = 11;
            this.depbox1.SelectedIndexChanged += new System.EventHandler(this.depbox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(727, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 10;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(378, 40);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(274, 136);
            this.listBox1.TabIndex = 9;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 12;
            this.listBox2.Items.AddRange(new object[] {
            "トラップ",
            "種",
            "野菜",
            "賞品",
            "倉庫"});
            this.listBox2.Location = new System.Drawing.Point(43, 40);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(40, 64);
            this.listBox2.TabIndex = 13;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // butsyou
            // 
            this.butsyou.Location = new System.Drawing.Point(678, 153);
            this.butsyou.Name = "butsyou";
            this.butsyou.Size = new System.Drawing.Size(75, 23);
            this.butsyou.TabIndex = 14;
            this.butsyou.Text = "詳細";
            this.butsyou.UseVisualStyleBackColor = true;
            this.butsyou.Click += new System.EventHandler(this.butsyou_Click);
            // 
            // itemlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 262);
            this.Controls.Add(this.butsyou);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.namebox1);
            this.Controls.Add(this.depbox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.butclose);
            this.Name = "itemlist";
            this.Text = "itemlist";
            this.Load += new System.EventHandler(this.itemlist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butclose;
        private System.Windows.Forms.ListBox namebox1;
        private System.Windows.Forms.ListBox depbox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button butsyou;
    }
}