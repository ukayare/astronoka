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
            this.label2 = new System.Windows.Forms.Label();
            this.bagpic6 = new System.Windows.Forms.PictureBox();
            this.bagpic5 = new System.Windows.Forms.PictureBox();
            this.bagpic4 = new System.Windows.Forms.PictureBox();
            this.bagpic3 = new System.Windows.Forms.PictureBox();
            this.bagpic2 = new System.Windows.Forms.PictureBox();
            this.bagpic1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.bagpic6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagpic5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagpic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagpic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagpic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagpic1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
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
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.Location = new System.Drawing.Point(3, 246);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(93, 21);
            this.button7.TabIndex = 7;
            this.button7.Text = "←";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Top;
            this.button8.Location = new System.Drawing.Point(202, 246);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(95, 21);
            this.button8.TabIndex = 8;
            this.button8.Text = "→";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // namebox1
            // 
            this.namebox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.namebox1.FormattingEnabled = true;
            this.namebox1.ItemHeight = 12;
            this.namebox1.Location = new System.Drawing.Point(34, 3);
            this.namebox1.Name = "namebox1";
            this.namebox1.Size = new System.Drawing.Size(88, 215);
            this.namebox1.TabIndex = 13;
            this.namebox1.SelectedIndexChanged += new System.EventHandler(this.namebox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(236, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "所持数:";
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(128, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(184, 215);
            this.listBox1.TabIndex = 11;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // depbox1
            // 
            this.depbox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.depbox1.FormattingEnabled = true;
            this.depbox1.ItemHeight = 12;
            this.depbox1.Items.AddRange(new object[] {
            "全て"});
            this.depbox1.Location = new System.Drawing.Point(3, 3);
            this.depbox1.Name = "depbox1";
            this.depbox1.Size = new System.Drawing.Size(25, 52);
            this.depbox1.TabIndex = 15;
            this.depbox1.SelectedIndexChanged += new System.EventHandler(this.depbox1_SelectedIndexChanged);
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
            this.yasaiextext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.yasaiextext.Dock = System.Windows.Forms.DockStyle.Top;
            this.yasaiextext.Location = new System.Drawing.Point(3, 24);
            this.yasaiextext.Name = "yasaiextext";
            this.yasaiextext.ReadOnly = true;
            this.yasaiextext.Size = new System.Drawing.Size(189, 186);
            this.yasaiextext.TabIndex = 23;
            this.yasaiextext.Text = "";
            // 
            // info1
            // 
            this.info1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.info1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.info1.Dock = System.Windows.Forms.DockStyle.Top;
            this.info1.Location = new System.Drawing.Point(236, 24);
            this.info1.Name = "info1";
            this.info1.ReadOnly = true;
            this.info1.Size = new System.Drawing.Size(99, 172);
            this.info1.TabIndex = 24;
            this.info1.Text = "";
            // 
            // yasaiextext2
            // 
            this.yasaiextext2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.yasaiextext2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.yasaiextext2.Location = new System.Drawing.Point(3, 3);
            this.yasaiextext2.Name = "yasaiextext2";
            this.yasaiextext2.ReadOnly = true;
            this.yasaiextext2.Size = new System.Drawing.Size(190, 276);
            this.yasaiextext2.TabIndex = 25;
            this.yasaiextext2.Text = "";
            // 
            // info2
            // 
            this.info2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.info2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.info2.Location = new System.Drawing.Point(42, 30);
            this.info2.Name = "info2";
            this.info2.ReadOnly = true;
            this.info2.Size = new System.Drawing.Size(99, 172);
            this.info2.TabIndex = 26;
            this.info2.Text = "";
            // 
            // ele1
            // 
            this.ele1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ele1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ele1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ele1.Location = new System.Drawing.Point(198, 24);
            this.ele1.Name = "ele1";
            this.ele1.ReadOnly = true;
            this.ele1.Size = new System.Drawing.Size(32, 172);
            this.ele1.TabIndex = 28;
            this.ele1.Text = "";
            // 
            // ele2
            // 
            this.ele2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ele2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ele2.Location = new System.Drawing.Point(3, 30);
            this.ele2.Name = "ele2";
            this.ele2.ReadOnly = true;
            this.ele2.Size = new System.Drawing.Size(33, 172);
            this.ele2.TabIndex = 29;
            this.ele2.Text = "";
            // 
            // eleval1
            // 
            this.eleval1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.eleval1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eleval1.Dock = System.Windows.Forms.DockStyle.Top;
            this.eleval1.Location = new System.Drawing.Point(341, 24);
            this.eleval1.Name = "eleval1";
            this.eleval1.ReadOnly = true;
            this.eleval1.Size = new System.Drawing.Size(27, 172);
            this.eleval1.TabIndex = 30;
            this.eleval1.Text = "";
            // 
            // elename1
            // 
            this.elename1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.elename1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.elename1.Dock = System.Windows.Forms.DockStyle.Top;
            this.elename1.Location = new System.Drawing.Point(374, 24);
            this.elename1.Name = "elename1";
            this.elename1.ReadOnly = true;
            this.elename1.Size = new System.Drawing.Size(72, 172);
            this.elename1.TabIndex = 31;
            this.elename1.Text = "それなりに甘い";
            // 
            // eleval2
            // 
            this.eleval2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.eleval2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eleval2.Location = new System.Drawing.Point(147, 30);
            this.eleval2.Name = "eleval2";
            this.eleval2.ReadOnly = true;
            this.eleval2.Size = new System.Drawing.Size(27, 172);
            this.eleval2.TabIndex = 32;
            this.eleval2.Text = "";
            // 
            // elename2
            // 
            this.elename2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.elename2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.elename2.Location = new System.Drawing.Point(180, 30);
            this.elename2.Name = "elename2";
            this.elename2.ReadOnly = true;
            this.elename2.Size = new System.Drawing.Size(71, 172);
            this.elename2.TabIndex = 33;
            this.elename2.Text = "それなりに甘い";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(42, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "所持数:";
            this.label2.Visible = false;
            // 
            // bagpic6
            // 
            this.bagpic6.Location = new System.Drawing.Point(202, 138);
            this.bagpic6.Name = "bagpic6";
            this.bagpic6.Size = new System.Drawing.Size(95, 99);
            this.bagpic6.TabIndex = 21;
            this.bagpic6.TabStop = false;
            this.bagpic6.Click += new System.EventHandler(this.bagpic6_Click);
            this.bagpic6.MouseEnter += new System.EventHandler(this.bagpic6_MouseEnter);
            this.bagpic6.MouseLeave += new System.EventHandler(this.bagpic6_MouseLeave);
            // 
            // bagpic5
            // 
            this.bagpic5.Location = new System.Drawing.Point(102, 138);
            this.bagpic5.Name = "bagpic5";
            this.bagpic5.Size = new System.Drawing.Size(94, 99);
            this.bagpic5.TabIndex = 20;
            this.bagpic5.TabStop = false;
            this.bagpic5.Click += new System.EventHandler(this.bagpic5_Click);
            this.bagpic5.MouseEnter += new System.EventHandler(this.bagpic5_MouseEnter);
            this.bagpic5.MouseLeave += new System.EventHandler(this.bagpic5_MouseLeave);
            // 
            // bagpic4
            // 
            this.bagpic4.Location = new System.Drawing.Point(3, 138);
            this.bagpic4.Name = "bagpic4";
            this.bagpic4.Size = new System.Drawing.Size(93, 99);
            this.bagpic4.TabIndex = 19;
            this.bagpic4.TabStop = false;
            this.bagpic4.Click += new System.EventHandler(this.bagpic4_Click);
            this.bagpic4.MouseEnter += new System.EventHandler(this.bagpic4_MouseEnter);
            this.bagpic4.MouseLeave += new System.EventHandler(this.bagpic4_MouseLeave);
            // 
            // bagpic3
            // 
            this.bagpic3.Location = new System.Drawing.Point(202, 30);
            this.bagpic3.Name = "bagpic3";
            this.bagpic3.Size = new System.Drawing.Size(95, 98);
            this.bagpic3.TabIndex = 18;
            this.bagpic3.TabStop = false;
            this.bagpic3.Click += new System.EventHandler(this.bagpic3_Click);
            this.bagpic3.MouseEnter += new System.EventHandler(this.bagpic3_MouseEnter);
            this.bagpic3.MouseLeave += new System.EventHandler(this.bagpic3_MouseLeave);
            // 
            // bagpic2
            // 
            this.bagpic2.Location = new System.Drawing.Point(102, 30);
            this.bagpic2.Name = "bagpic2";
            this.bagpic2.Size = new System.Drawing.Size(94, 98);
            this.bagpic2.TabIndex = 17;
            this.bagpic2.TabStop = false;
            this.bagpic2.Click += new System.EventHandler(this.bagpic2_Click);
            this.bagpic2.MouseEnter += new System.EventHandler(this.bagpic2_MouseEnter);
            this.bagpic2.MouseLeave += new System.EventHandler(this.bagpic2_MouseLeave);
            // 
            // bagpic1
            // 
            this.bagpic1.Location = new System.Drawing.Point(3, 30);
            this.bagpic1.Name = "bagpic1";
            this.bagpic1.Size = new System.Drawing.Size(93, 98);
            this.bagpic1.TabIndex = 16;
            this.bagpic1.TabStop = false;
            this.bagpic1.Click += new System.EventHandler(this.bagpic1_Click);
            this.bagpic1.MouseEnter += new System.EventHandler(this.bagpic1_MouseEnter);
            this.bagpic1.MouseLeave += new System.EventHandler(this.bagpic1_MouseLeave);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.bagpic1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.bagpic2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.bagpic3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.bagpic4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.bagpic5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.bagpic6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.button7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button8, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 230);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(300, 270);
            this.tableLayoutPanel1.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 21);
            this.label3.TabIndex = 22;
            this.label3.Text = "label3";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.Controls.Add(this.depbox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.namebox1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.listBox1, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(315, 221);
            this.tableLayoutPanel2.TabIndex = 36;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.5F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.5F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.5F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel3.Controls.Add(this.yasaiextext, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.ele1, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.info1, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.eleval1, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.elename1, 4, 1);
            this.tableLayoutPanel3.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(323, 9);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(449, 213);
            this.tableLayoutPanel3.TabIndex = 37;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57F));
            this.tableLayoutPanel4.Controls.Add(this.yasaiextext2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(323, 230);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(456, 282);
            this.tableLayoutPanel4.TabIndex = 38;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.5F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.5F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel5.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.ele2, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.info2, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.eleval2, 2, 1);
            this.tableLayoutPanel5.Controls.Add(this.elename2, 3, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(199, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(254, 276);
            this.tableLayoutPanel5.TabIndex = 26;
            // 
            // hatake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.butex);
            this.Controls.Add(this.butclose);
            this.Name = "hatake";
            this.Text = "hatake";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.hatake_FormClosing);
            this.Load += new System.EventHandler(this.hatake_Load);
            this.Shown += new System.EventHandler(this.hatake_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.bagpic6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagpic5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagpic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagpic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagpic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagpic1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
    }
}