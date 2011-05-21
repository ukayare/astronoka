namespace WindowsFormsApplication1
{
    partial class hatake
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
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.namebox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.depbox1 = new System.Windows.Forms.ListBox();
            this.bagpic1 = new System.Windows.Forms.PictureBox();
            this.bagpic2 = new System.Windows.Forms.PictureBox();
            this.bagpic3 = new System.Windows.Forms.PictureBox();
            this.bagpic4 = new System.Windows.Forms.PictureBox();
            this.bagpic5 = new System.Windows.Forms.PictureBox();
            this.bagpic6 = new System.Windows.Forms.PictureBox();
            this.butex = new System.Windows.Forms.Button();
            this.yasaiextext = new System.Windows.Forms.RichTextBox();
            this.info1 = new System.Windows.Forms.RichTextBox();
            this.yasaiextext2 = new System.Windows.Forms.RichTextBox();
            this.info2 = new System.Windows.Forms.RichTextBox();
            this.ele1 = new System.Windows.Forms.RichTextBox();
            this.ele2 = new System.Windows.Forms.RichTextBox();
            this.eleval1 = new System.Windows.Forms.RichTextBox();
            this.elename1 = new System.Windows.Forms.RichTextBox();
            this.eleval2 = new System.Windows.Forms.RichTextBox();
            this.elename2 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bagpic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagpic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagpic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagpic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagpic5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagpic6)).BeginInit();
            this.SuspendLayout();
            // 
            // butclose
            // 
            this.butclose.Location = new System.Drawing.Point(333, 527);
            this.butclose.Name = "butclose";
            this.butclose.Size = new System.Drawing.Size(75, 23);
            this.butclose.TabIndex = 0;
            this.butclose.Text = "閉じる";
            this.butclose.UseVisualStyleBackColor = true;
            this.butclose.Click += new System.EventHandler(this.butclose_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(118, 475);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(28, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "←";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(190, 475);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(28, 23);
            this.button8.TabIndex = 8;
            this.button8.Text = "→";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // namebox1
            // 
            this.namebox1.FormattingEnabled = true;
            this.namebox1.ItemHeight = 12;
            this.namebox1.Location = new System.Drawing.Point(38, 11);
            this.namebox1.Name = "namebox1";
            this.namebox1.Size = new System.Drawing.Size(89, 208);
            this.namebox1.TabIndex = 13;
            this.namebox1.SelectedIndexChanged += new System.EventHandler(this.namebox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(637, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 12;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(124, 11);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(198, 208);
            this.listBox1.TabIndex = 11;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // depbox1
            // 
            this.depbox1.FormattingEnabled = true;
            this.depbox1.ItemHeight = 12;
            this.depbox1.Items.AddRange(new object[] {
            "全て",
            "A科",
            "B科",
            "C科"});
            this.depbox1.Location = new System.Drawing.Point(12, 12);
            this.depbox1.Name = "depbox1";
            this.depbox1.Size = new System.Drawing.Size(26, 52);
            this.depbox1.TabIndex = 15;
            this.depbox1.SelectedIndexChanged += new System.EventHandler(this.depbox1_SelectedIndexChanged);
            // 
            // bagpic1
            // 
            this.bagpic1.Location = new System.Drawing.Point(12, 255);
            this.bagpic1.Name = "bagpic1";
            this.bagpic1.Size = new System.Drawing.Size(100, 100);
            this.bagpic1.TabIndex = 16;
            this.bagpic1.TabStop = false;
            this.bagpic1.Click += new System.EventHandler(this.bagpic1_Click);
            this.bagpic1.MouseEnter += new System.EventHandler(this.bagpic1_MouseEnter);
            this.bagpic1.MouseLeave += new System.EventHandler(this.bagpic1_MouseLeave);
            // 
            // bagpic2
            // 
            this.bagpic2.Location = new System.Drawing.Point(116, 255);
            this.bagpic2.Name = "bagpic2";
            this.bagpic2.Size = new System.Drawing.Size(100, 100);
            this.bagpic2.TabIndex = 17;
            this.bagpic2.TabStop = false;
            this.bagpic2.Click += new System.EventHandler(this.bagpic2_Click);
            this.bagpic2.MouseEnter += new System.EventHandler(this.bagpic2_MouseEnter);
            this.bagpic2.MouseLeave += new System.EventHandler(this.bagpic2_MouseLeave);
            // 
            // bagpic3
            // 
            this.bagpic3.Location = new System.Drawing.Point(222, 255);
            this.bagpic3.Name = "bagpic3";
            this.bagpic3.Size = new System.Drawing.Size(100, 100);
            this.bagpic3.TabIndex = 18;
            this.bagpic3.TabStop = false;
            this.bagpic3.Click += new System.EventHandler(this.bagpic3_Click);
            this.bagpic3.MouseEnter += new System.EventHandler(this.bagpic3_MouseEnter);
            this.bagpic3.MouseLeave += new System.EventHandler(this.bagpic3_MouseLeave);
            // 
            // bagpic4
            // 
            this.bagpic4.Location = new System.Drawing.Point(12, 361);
            this.bagpic4.Name = "bagpic4";
            this.bagpic4.Size = new System.Drawing.Size(100, 100);
            this.bagpic4.TabIndex = 19;
            this.bagpic4.TabStop = false;
            this.bagpic4.Click += new System.EventHandler(this.bagpic4_Click);
            this.bagpic4.MouseEnter += new System.EventHandler(this.bagpic4_MouseEnter);
            this.bagpic4.MouseLeave += new System.EventHandler(this.bagpic4_MouseLeave);
            // 
            // bagpic5
            // 
            this.bagpic5.Location = new System.Drawing.Point(116, 361);
            this.bagpic5.Name = "bagpic5";
            this.bagpic5.Size = new System.Drawing.Size(100, 100);
            this.bagpic5.TabIndex = 20;
            this.bagpic5.TabStop = false;
            this.bagpic5.Click += new System.EventHandler(this.bagpic5_Click);
            this.bagpic5.MouseEnter += new System.EventHandler(this.bagpic5_MouseEnter);
            this.bagpic5.MouseLeave += new System.EventHandler(this.bagpic5_MouseLeave);
            // 
            // bagpic6
            // 
            this.bagpic6.Location = new System.Drawing.Point(222, 361);
            this.bagpic6.Name = "bagpic6";
            this.bagpic6.Size = new System.Drawing.Size(100, 100);
            this.bagpic6.TabIndex = 21;
            this.bagpic6.TabStop = false;
            this.bagpic6.Click += new System.EventHandler(this.bagpic6_Click);
            this.bagpic6.MouseEnter += new System.EventHandler(this.bagpic6_MouseEnter);
            this.bagpic6.MouseLeave += new System.EventHandler(this.bagpic6_MouseLeave);
            // 
            // butex
            // 
            this.butex.Location = new System.Drawing.Point(574, 527);
            this.butex.Name = "butex";
            this.butex.Size = new System.Drawing.Size(75, 23);
            this.butex.TabIndex = 22;
            this.butex.Text = "畑の説明";
            this.butex.UseVisualStyleBackColor = true;
            this.butex.Click += new System.EventHandler(this.butex_Click);
            // 
            // yasaiextext
            // 
            this.yasaiextext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.yasaiextext.Location = new System.Drawing.Point(349, 12);
            this.yasaiextext.Name = "yasaiextext";
            this.yasaiextext.ReadOnly = true;
            this.yasaiextext.Size = new System.Drawing.Size(180, 200);
            this.yasaiextext.TabIndex = 23;
            this.yasaiextext.Text = "";
            // 
            // info1
            // 
            this.info1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.info1.Location = new System.Drawing.Point(570, 40);
            this.info1.Name = "info1";
            this.info1.ReadOnly = true;
            this.info1.Size = new System.Drawing.Size(104, 172);
            this.info1.TabIndex = 24;
            this.info1.Text = "";
            // 
            // yasaiextext2
            // 
            this.yasaiextext2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.yasaiextext2.Location = new System.Drawing.Point(349, 255);
            this.yasaiextext2.Name = "yasaiextext2";
            this.yasaiextext2.ReadOnly = true;
            this.yasaiextext2.Size = new System.Drawing.Size(180, 243);
            this.yasaiextext2.TabIndex = 25;
            this.yasaiextext2.Text = "";
            // 
            // info2
            // 
            this.info2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.info2.Location = new System.Drawing.Point(570, 289);
            this.info2.Name = "info2";
            this.info2.ReadOnly = true;
            this.info2.Size = new System.Drawing.Size(104, 172);
            this.info2.TabIndex = 26;
            this.info2.Text = "";
            // 
            // ele1
            // 
            this.ele1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ele1.Location = new System.Drawing.Point(533, 40);
            this.ele1.Name = "ele1";
            this.ele1.ReadOnly = true;
            this.ele1.Size = new System.Drawing.Size(39, 172);
            this.ele1.TabIndex = 28;
            this.ele1.Text = "";
            // 
            // ele2
            // 
            this.ele2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ele2.Location = new System.Drawing.Point(533, 289);
            this.ele2.Name = "ele2";
            this.ele2.ReadOnly = true;
            this.ele2.Size = new System.Drawing.Size(39, 172);
            this.ele2.TabIndex = 29;
            this.ele2.Text = "";
            // 
            // eleval1
            // 
            this.eleval1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.eleval1.Location = new System.Drawing.Point(672, 40);
            this.eleval1.Name = "eleval1";
            this.eleval1.ReadOnly = true;
            this.eleval1.Size = new System.Drawing.Size(32, 172);
            this.eleval1.TabIndex = 30;
            this.eleval1.Text = "";
            // 
            // elename1
            // 
            this.elename1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.elename1.Location = new System.Drawing.Point(702, 40);
            this.elename1.Name = "elename1";
            this.elename1.ReadOnly = true;
            this.elename1.Size = new System.Drawing.Size(80, 172);
            this.elename1.TabIndex = 31;
            this.elename1.Text = "";
            // 
            // eleval2
            // 
            this.eleval2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.eleval2.Location = new System.Drawing.Point(672, 289);
            this.eleval2.Name = "eleval2";
            this.eleval2.ReadOnly = true;
            this.eleval2.Size = new System.Drawing.Size(32, 172);
            this.eleval2.TabIndex = 32;
            this.eleval2.Text = "";
            // 
            // elename2
            // 
            this.elename2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.elename2.Location = new System.Drawing.Point(702, 289);
            this.elename2.Name = "elename2";
            this.elename2.ReadOnly = true;
            this.elename2.Size = new System.Drawing.Size(80, 172);
            this.elename2.TabIndex = 33;
            this.elename2.Text = "";
            // 
            // hatake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.ele2);
            this.Controls.Add(this.info2);
            this.Controls.Add(this.eleval2);
            this.Controls.Add(this.elename2);
            this.Controls.Add(this.ele1);
            this.Controls.Add(this.info1);
            this.Controls.Add(this.eleval1);
            this.Controls.Add(this.elename1);
            this.Controls.Add(this.yasaiextext2);
            this.Controls.Add(this.yasaiextext);
            this.Controls.Add(this.butex);
            this.Controls.Add(this.bagpic6);
            this.Controls.Add(this.bagpic5);
            this.Controls.Add(this.bagpic4);
            this.Controls.Add(this.bagpic3);
            this.Controls.Add(this.bagpic2);
            this.Controls.Add(this.bagpic1);
            this.Controls.Add(this.depbox1);
            this.Controls.Add(this.namebox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.butclose);
            this.Name = "hatake";
            this.Text = "hatake";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.hatake_FormClosing);
            this.Load += new System.EventHandler(this.hatake_Load);
            this.Shown += new System.EventHandler(this.hatake_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.bagpic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagpic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagpic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagpic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagpic5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagpic6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butclose;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ListBox namebox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox depbox1;
        private System.Windows.Forms.PictureBox bagpic1;
        private System.Windows.Forms.PictureBox bagpic2;
        private System.Windows.Forms.PictureBox bagpic3;
        private System.Windows.Forms.PictureBox bagpic4;
        private System.Windows.Forms.PictureBox bagpic5;
        private System.Windows.Forms.PictureBox bagpic6;
        private System.Windows.Forms.Button butex;
        private System.Windows.Forms.RichTextBox yasaiextext;
        private System.Windows.Forms.RichTextBox info1;
        private System.Windows.Forms.RichTextBox yasaiextext2;
        private System.Windows.Forms.RichTextBox info2;
        private System.Windows.Forms.RichTextBox ele1;
        private System.Windows.Forms.RichTextBox ele2;
        private System.Windows.Forms.RichTextBox eleval1;
        private System.Windows.Forms.RichTextBox elename1;
        private System.Windows.Forms.RichTextBox eleval2;
        private System.Windows.Forms.RichTextBox elename2;
    }
}