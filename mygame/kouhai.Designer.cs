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
            this.depbox1 = new System.Windows.Forms.ListBox();
            this.depbox2 = new System.Windows.Forms.ListBox();
            this.namebox1 = new System.Windows.Forms.ListBox();
            this.namebox2 = new System.Windows.Forms.ListBox();
            this.butex = new System.Windows.Forms.Button();
            this.ele1 = new System.Windows.Forms.RichTextBox();
            this.info1 = new System.Windows.Forms.RichTextBox();
            this.eleval1 = new System.Windows.Forms.RichTextBox();
            this.elename1 = new System.Windows.Forms.RichTextBox();
            this.yasaiextext = new System.Windows.Forms.RichTextBox();
            this.ele2 = new System.Windows.Forms.RichTextBox();
            this.info2 = new System.Windows.Forms.RichTextBox();
            this.eleval2 = new System.Windows.Forms.RichTextBox();
            this.elename2 = new System.Windows.Forms.RichTextBox();
            this.yasaiextext2 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(151, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(188, 196);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 12;
            this.listBox2.Location = new System.Drawing.Point(151, 284);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(188, 196);
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
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(566, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "所持数:";
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
            this.depbox1.Location = new System.Drawing.Point(12, 26);
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
            this.depbox2.Location = new System.Drawing.Point(12, 284);
            this.depbox2.Name = "depbox2";
            this.depbox2.Size = new System.Drawing.Size(43, 64);
            this.depbox2.TabIndex = 7;
            this.depbox2.SelectedIndexChanged += new System.EventHandler(this.depbox2_SelectedIndexChanged);
            // 
            // namebox1
            // 
            this.namebox1.FormattingEnabled = true;
            this.namebox1.ItemHeight = 12;
            this.namebox1.Location = new System.Drawing.Point(55, 26);
            this.namebox1.Name = "namebox1";
            this.namebox1.Size = new System.Drawing.Size(96, 196);
            this.namebox1.TabIndex = 8;
            this.namebox1.SelectedIndexChanged += new System.EventHandler(this.namebox1_SelectedIndexChanged);
            // 
            // namebox2
            // 
            this.namebox2.FormattingEnabled = true;
            this.namebox2.ItemHeight = 12;
            this.namebox2.Location = new System.Drawing.Point(55, 284);
            this.namebox2.Name = "namebox2";
            this.namebox2.Size = new System.Drawing.Size(96, 196);
            this.namebox2.TabIndex = 9;
            this.namebox2.SelectedIndexChanged += new System.EventHandler(this.namebox2_SelectedIndexChanged);
            // 
            // butex
            // 
            this.butex.Location = new System.Drawing.Point(650, 236);
            this.butex.Name = "butex";
            this.butex.Size = new System.Drawing.Size(88, 23);
            this.butex.TabIndex = 12;
            this.butex.Text = "交配の手引き";
            this.butex.UseVisualStyleBackColor = true;
            this.butex.Click += new System.EventHandler(this.butex_Click);
            // 
            // ele1
            // 
            this.ele1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ele1.Location = new System.Drawing.Point(531, 57);
            this.ele1.Name = "ele1";
            this.ele1.ReadOnly = true;
            this.ele1.Size = new System.Drawing.Size(39, 172);
            this.ele1.TabIndex = 39;
            this.ele1.Text = "";
            // 
            // info1
            // 
            this.info1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.info1.Location = new System.Drawing.Point(568, 57);
            this.info1.Name = "info1";
            this.info1.ReadOnly = true;
            this.info1.Size = new System.Drawing.Size(104, 172);
            this.info1.TabIndex = 38;
            this.info1.Text = "";
            // 
            // eleval1
            // 
            this.eleval1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.eleval1.Location = new System.Drawing.Point(670, 57);
            this.eleval1.Name = "eleval1";
            this.eleval1.ReadOnly = true;
            this.eleval1.Size = new System.Drawing.Size(32, 172);
            this.eleval1.TabIndex = 40;
            this.eleval1.Text = "";
            // 
            // elename1
            // 
            this.elename1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.elename1.Location = new System.Drawing.Point(700, 57);
            this.elename1.Name = "elename1";
            this.elename1.ReadOnly = true;
            this.elename1.Size = new System.Drawing.Size(80, 172);
            this.elename1.TabIndex = 41;
            this.elename1.Text = "";
            // 
            // yasaiextext
            // 
            this.yasaiextext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.yasaiextext.Location = new System.Drawing.Point(345, 26);
            this.yasaiextext.Name = "yasaiextext";
            this.yasaiextext.ReadOnly = true;
            this.yasaiextext.Size = new System.Drawing.Size(186, 203);
            this.yasaiextext.TabIndex = 37;
            this.yasaiextext.Text = "";
            // 
            // ele2
            // 
            this.ele2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ele2.Location = new System.Drawing.Point(531, 315);
            this.ele2.Name = "ele2";
            this.ele2.ReadOnly = true;
            this.ele2.Size = new System.Drawing.Size(39, 172);
            this.ele2.TabIndex = 45;
            this.ele2.Text = "";
            // 
            // info2
            // 
            this.info2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.info2.Location = new System.Drawing.Point(568, 315);
            this.info2.Name = "info2";
            this.info2.ReadOnly = true;
            this.info2.Size = new System.Drawing.Size(104, 172);
            this.info2.TabIndex = 44;
            this.info2.Text = "";
            // 
            // eleval2
            // 
            this.eleval2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.eleval2.Location = new System.Drawing.Point(670, 315);
            this.eleval2.Name = "eleval2";
            this.eleval2.ReadOnly = true;
            this.eleval2.Size = new System.Drawing.Size(32, 172);
            this.eleval2.TabIndex = 46;
            this.eleval2.Text = "";
            // 
            // elename2
            // 
            this.elename2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.elename2.Location = new System.Drawing.Point(700, 315);
            this.elename2.Name = "elename2";
            this.elename2.ReadOnly = true;
            this.elename2.Size = new System.Drawing.Size(80, 172);
            this.elename2.TabIndex = 47;
            this.elename2.Text = "";
            // 
            // yasaiextext2
            // 
            this.yasaiextext2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.yasaiextext2.Location = new System.Drawing.Point(345, 284);
            this.yasaiextext2.Name = "yasaiextext2";
            this.yasaiextext2.ReadOnly = true;
            this.yasaiextext2.Size = new System.Drawing.Size(186, 203);
            this.yasaiextext2.TabIndex = 43;
            this.yasaiextext2.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(566, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 48;
            this.label2.Text = "所持数:";
            // 
            // kouhai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.label2);
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
            this.Controls.Add(this.butex);
            this.Controls.Add(this.namebox2);
            this.Controls.Add(this.namebox1);
            this.Controls.Add(this.depbox2);
            this.Controls.Add(this.depbox1);
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
        private System.Windows.Forms.ListBox depbox1;
        private System.Windows.Forms.ListBox depbox2;
        private System.Windows.Forms.ListBox namebox1;
        private System.Windows.Forms.ListBox namebox2;
        private System.Windows.Forms.Button butex;
        private System.Windows.Forms.RichTextBox ele1;
        private System.Windows.Forms.RichTextBox info1;
        private System.Windows.Forms.RichTextBox eleval1;
        private System.Windows.Forms.RichTextBox elename1;
        private System.Windows.Forms.RichTextBox yasaiextext;
        private System.Windows.Forms.RichTextBox ele2;
        private System.Windows.Forms.RichTextBox info2;
        private System.Windows.Forms.RichTextBox eleval2;
        private System.Windows.Forms.RichTextBox elename2;
        private System.Windows.Forms.RichTextBox yasaiextext2;
        private System.Windows.Forms.Label label2;
    }
}