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
            this.ele1 = new System.Windows.Forms.RichTextBox();
            this.info1 = new System.Windows.Forms.RichTextBox();
            this.eleval1 = new System.Windows.Forms.RichTextBox();
            this.elename1 = new System.Windows.Forms.RichTextBox();
            this.yasaiextext = new System.Windows.Forms.RichTextBox();
            this.bagpic = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.bagpic)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // butclose
            // 
            this.butclose.Dock = System.Windows.Forms.DockStyle.Top;
            this.butclose.Location = new System.Drawing.Point(3, 426);
            this.butclose.Name = "butclose";
            this.butclose.Size = new System.Drawing.Size(578, 23);
            this.butclose.TabIndex = 0;
            this.butclose.Text = "閉じる";
            this.butclose.UseVisualStyleBackColor = true;
            this.butclose.Click += new System.EventHandler(this.butclose_Click);
            // 
            // namebox1
            // 
            this.namebox1.FormattingEnabled = true;
            this.namebox1.ItemHeight = 12;
            this.namebox1.Location = new System.Drawing.Point(117, 3);
            this.namebox1.Name = "namebox1";
            this.namebox1.Size = new System.Drawing.Size(120, 172);
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
            this.depbox1.Location = new System.Drawing.Point(60, 3);
            this.depbox1.Name = "depbox1";
            this.depbox1.Size = new System.Drawing.Size(45, 64);
            this.depbox1.TabIndex = 11;
            this.depbox1.SelectedIndexChanged += new System.EventHandler(this.depbox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(43, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "所持数:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(290, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(274, 172);
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
            this.listBox2.Location = new System.Drawing.Point(3, 3);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(40, 64);
            this.listBox2.TabIndex = 13;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // ele1
            // 
            this.ele1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ele1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ele1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ele1.Location = new System.Drawing.Point(3, 23);
            this.ele1.Name = "ele1";
            this.ele1.ReadOnly = true;
            this.ele1.Size = new System.Drawing.Size(34, 183);
            this.ele1.TabIndex = 34;
            this.ele1.Text = "大きさ";
            // 
            // info1
            // 
            this.info1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.info1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.info1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.info1.Location = new System.Drawing.Point(43, 23);
            this.info1.Name = "info1";
            this.info1.ReadOnly = true;
            this.info1.Size = new System.Drawing.Size(105, 183);
            this.info1.TabIndex = 33;
            this.info1.Text = "";
            // 
            // eleval1
            // 
            this.eleval1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.eleval1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eleval1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eleval1.Location = new System.Drawing.Point(154, 23);
            this.eleval1.Name = "eleval1";
            this.eleval1.ReadOnly = true;
            this.eleval1.Size = new System.Drawing.Size(31, 183);
            this.eleval1.TabIndex = 35;
            this.eleval1.Text = "";
            // 
            // elename1
            // 
            this.elename1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.elename1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.elename1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elename1.Location = new System.Drawing.Point(191, 23);
            this.elename1.Name = "elename1";
            this.elename1.ReadOnly = true;
            this.elename1.Size = new System.Drawing.Size(75, 183);
            this.elename1.TabIndex = 36;
            this.elename1.Text = "それなりに甘い";
            // 
            // yasaiextext
            // 
            this.yasaiextext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.yasaiextext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.yasaiextext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yasaiextext.Location = new System.Drawing.Point(3, 3);
            this.yasaiextext.Name = "yasaiextext";
            this.yasaiextext.ReadOnly = true;
            this.yasaiextext.Size = new System.Drawing.Size(196, 209);
            this.yasaiextext.TabIndex = 32;
            this.yasaiextext.Text = "";
            // 
            // bagpic
            // 
            this.bagpic.Location = new System.Drawing.Point(272, 23);
            this.bagpic.Name = "bagpic";
            this.bagpic.Size = new System.Drawing.Size(95, 100);
            this.bagpic.TabIndex = 37;
            this.bagpic.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.butclose, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(584, 462);
            this.tableLayoutPanel1.TabIndex = 38;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.listBox2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.depbox1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.namebox1, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.listBox1, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 21);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(578, 178);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel3.Controls.Add(this.yasaiextext, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 205);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(578, 215);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.tableLayoutPanel4.Controls.Add(this.bagpic, 4, 1);
            this.tableLayoutPanel4.Controls.Add(this.elename1, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.info1, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.ele1, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.eleval1, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(205, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(370, 209);
            this.tableLayoutPanel4.TabIndex = 33;
            // 
            // itemlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "itemlist";
            this.Text = "itemlist";
            this.Load += new System.EventHandler(this.itemlist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bagpic)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butclose;
        private System.Windows.Forms.ListBox namebox1;
        private System.Windows.Forms.ListBox depbox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.RichTextBox ele1;
        private System.Windows.Forms.RichTextBox info1;
        private System.Windows.Forms.RichTextBox eleval1;
        private System.Windows.Forms.RichTextBox elename1;
        private System.Windows.Forms.RichTextBox yasaiextext;
        private System.Windows.Forms.PictureBox bagpic;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
    }
}