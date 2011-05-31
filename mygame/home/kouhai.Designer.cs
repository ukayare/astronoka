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
            this.depbox1 = new System.Windows.Forms.ListBox();
            this.depbox2 = new System.Windows.Forms.ListBox();
            this.namebox1 = new System.Windows.Forms.ListBox();
            this.namebox2 = new System.Windows.Forms.ListBox();
            this.butex = new System.Windows.Forms.Button();
            this.yasaiextext = new System.Windows.Forms.RichTextBox();
            this.ele2 = new System.Windows.Forms.RichTextBox();
            this.info2 = new System.Windows.Forms.RichTextBox();
            this.eleval2 = new System.Windows.Forms.RichTextBox();
            this.elename2 = new System.Windows.Forms.RichTextBox();
            this.yasaiextext2 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.ele1 = new System.Windows.Forms.RichTextBox();
            this.info1 = new System.Windows.Forms.RichTextBox();
            this.eleval1 = new System.Windows.Forms.RichTextBox();
            this.elename1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(146, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(179, 206);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 12;
            this.listBox2.Location = new System.Drawing.Point(146, 3);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(179, 206);
            this.listBox2.TabIndex = 1;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // butmix
            // 
            this.butmix.Dock = System.Windows.Forms.DockStyle.Top;
            this.butmix.Location = new System.Drawing.Point(3, 3);
            this.butmix.Name = "butmix";
            this.butmix.Size = new System.Drawing.Size(253, 25);
            this.butmix.TabIndex = 2;
            this.butmix.Text = "交配";
            this.butmix.UseVisualStyleBackColor = true;
            this.butmix.Click += new System.EventHandler(this.butmix_Click);
            // 
            // butfin
            // 
            this.butfin.Dock = System.Windows.Forms.DockStyle.Top;
            this.butfin.Location = new System.Drawing.Point(262, 3);
            this.butfin.Name = "butfin";
            this.butfin.Size = new System.Drawing.Size(253, 25);
            this.butfin.TabIndex = 3;
            this.butfin.Text = "終了";
            this.butfin.UseVisualStyleBackColor = true;
            this.butfin.Click += new System.EventHandler(this.butfin_Click);
            // 
            // depbox1
            // 
            this.depbox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.depbox1.FormattingEnabled = true;
            this.depbox1.ItemHeight = 12;
            this.depbox1.Items.AddRange(new object[] {
            "全て",
            "A科",
            "B科",
            "C科",
            "強化種"});
            this.depbox1.Location = new System.Drawing.Point(3, 3);
            this.depbox1.Name = "depbox1";
            this.depbox1.Size = new System.Drawing.Size(39, 64);
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
            this.depbox2.Location = new System.Drawing.Point(3, 3);
            this.depbox2.Name = "depbox2";
            this.depbox2.Size = new System.Drawing.Size(39, 64);
            this.depbox2.TabIndex = 7;
            this.depbox2.SelectedIndexChanged += new System.EventHandler(this.depbox2_SelectedIndexChanged);
            // 
            // namebox1
            // 
            this.namebox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.namebox1.FormattingEnabled = true;
            this.namebox1.ItemHeight = 12;
            this.namebox1.Location = new System.Drawing.Point(48, 3);
            this.namebox1.Name = "namebox1";
            this.namebox1.Size = new System.Drawing.Size(92, 206);
            this.namebox1.TabIndex = 8;
            this.namebox1.SelectedIndexChanged += new System.EventHandler(this.namebox1_SelectedIndexChanged);
            // 
            // namebox2
            // 
            this.namebox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.namebox2.FormattingEnabled = true;
            this.namebox2.ItemHeight = 12;
            this.namebox2.Location = new System.Drawing.Point(48, 3);
            this.namebox2.Name = "namebox2";
            this.namebox2.Size = new System.Drawing.Size(92, 206);
            this.namebox2.TabIndex = 9;
            this.namebox2.SelectedIndexChanged += new System.EventHandler(this.namebox2_SelectedIndexChanged);
            // 
            // butex
            // 
            this.butex.Dock = System.Windows.Forms.DockStyle.Top;
            this.butex.Location = new System.Drawing.Point(521, 3);
            this.butex.Name = "butex";
            this.butex.Size = new System.Drawing.Size(254, 25);
            this.butex.TabIndex = 12;
            this.butex.Text = "交配の手引き";
            this.butex.UseVisualStyleBackColor = true;
            this.butex.Click += new System.EventHandler(this.butex_Click);
            // 
            // yasaiextext
            // 
            this.yasaiextext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.yasaiextext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.yasaiextext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yasaiextext.Location = new System.Drawing.Point(3, 3);
            this.yasaiextext.Name = "yasaiextext";
            this.yasaiextext.ReadOnly = true;
            this.yasaiextext.Size = new System.Drawing.Size(173, 206);
            this.yasaiextext.TabIndex = 37;
            this.yasaiextext.Text = "";
            // 
            // ele2
            // 
            this.ele2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ele2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ele2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ele2.Location = new System.Drawing.Point(3, 23);
            this.ele2.Name = "ele2";
            this.ele2.ReadOnly = true;
            this.ele2.Size = new System.Drawing.Size(31, 180);
            this.ele2.TabIndex = 45;
            this.ele2.Text = "";
            // 
            // info2
            // 
            this.info2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.info2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.info2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.info2.Location = new System.Drawing.Point(40, 23);
            this.info2.Name = "info2";
            this.info2.ReadOnly = true;
            this.info2.Size = new System.Drawing.Size(98, 180);
            this.info2.TabIndex = 44;
            this.info2.Text = "";
            // 
            // eleval2
            // 
            this.eleval2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.eleval2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eleval2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eleval2.Location = new System.Drawing.Point(144, 23);
            this.eleval2.Name = "eleval2";
            this.eleval2.ReadOnly = true;
            this.eleval2.Size = new System.Drawing.Size(26, 180);
            this.eleval2.TabIndex = 46;
            this.eleval2.Text = "";
            // 
            // elename2
            // 
            this.elename2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.elename2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.elename2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elename2.Location = new System.Drawing.Point(176, 23);
            this.elename2.Name = "elename2";
            this.elename2.ReadOnly = true;
            this.elename2.Size = new System.Drawing.Size(74, 180);
            this.elename2.TabIndex = 47;
            this.elename2.Text = "";
            // 
            // yasaiextext2
            // 
            this.yasaiextext2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.yasaiextext2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.yasaiextext2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yasaiextext2.Location = new System.Drawing.Point(3, 3);
            this.yasaiextext2.Name = "yasaiextext2";
            this.yasaiextext2.ReadOnly = true;
            this.yasaiextext2.Size = new System.Drawing.Size(173, 206);
            this.yasaiextext2.TabIndex = 43;
            this.yasaiextext2.Text = "";
            this.yasaiextext2.TextChanged += new System.EventHandler(this.yasaiextext2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(40, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 48;
            this.label2.Text = "所持数:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 562);
            this.tableLayoutPanel1.TabIndex = 49;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.butex, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.butfin, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.butmix, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 507);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(778, 52);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel7, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 31);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(778, 218);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56F));
            this.tableLayoutPanel5.Controls.Add(this.depbox1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.namebox1, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.listBox1, 2, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(328, 212);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59F));
            this.tableLayoutPanel7.Controls.Add(this.yasaiextext, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel8, 1, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(337, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(438, 212);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 4;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.5F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.5F));
            this.tableLayoutPanel8.Controls.Add(this.ele1, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.info1, 1, 1);
            this.tableLayoutPanel8.Controls.Add(this.eleval1, 2, 1);
            this.tableLayoutPanel8.Controls.Add(this.elename1, 3, 1);
            this.tableLayoutPanel8.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(182, 3);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(253, 206);
            this.tableLayoutPanel8.TabIndex = 38;
            // 
            // ele1
            // 
            this.ele1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ele1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ele1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ele1.Location = new System.Drawing.Point(3, 23);
            this.ele1.Name = "ele1";
            this.ele1.ReadOnly = true;
            this.ele1.Size = new System.Drawing.Size(31, 180);
            this.ele1.TabIndex = 39;
            this.ele1.Text = "大きさ";
            // 
            // info1
            // 
            this.info1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.info1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.info1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.info1.Location = new System.Drawing.Point(40, 23);
            this.info1.Name = "info1";
            this.info1.ReadOnly = true;
            this.info1.Size = new System.Drawing.Size(98, 180);
            this.info1.TabIndex = 38;
            this.info1.Text = "○○○○○○○○";
            // 
            // eleval1
            // 
            this.eleval1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.eleval1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eleval1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eleval1.Location = new System.Drawing.Point(144, 23);
            this.eleval1.Name = "eleval1";
            this.eleval1.ReadOnly = true;
            this.eleval1.Size = new System.Drawing.Size(26, 180);
            this.eleval1.TabIndex = 40;
            this.eleval1.Text = "-200";
            // 
            // elename1
            // 
            this.elename1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.elename1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.elename1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elename1.Location = new System.Drawing.Point(176, 23);
            this.elename1.Name = "elename1";
            this.elename1.ReadOnly = true;
            this.elename1.Size = new System.Drawing.Size(74, 180);
            this.elename1.TabIndex = 41;
            this.elename1.Text = "それなりに甘い";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(40, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "所持数:";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel9, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 283);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(778, 218);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56F));
            this.tableLayoutPanel6.Controls.Add(this.depbox2, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.namebox2, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.listBox2, 2, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(328, 212);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59F));
            this.tableLayoutPanel9.Controls.Add(this.yasaiextext2, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel10, 1, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(337, 3);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(438, 212);
            this.tableLayoutPanel9.TabIndex = 1;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 4;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.5F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.5F));
            this.tableLayoutPanel10.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel10.Controls.Add(this.elename2, 3, 1);
            this.tableLayoutPanel10.Controls.Add(this.info2, 1, 1);
            this.tableLayoutPanel10.Controls.Add(this.ele2, 0, 1);
            this.tableLayoutPanel10.Controls.Add(this.eleval2, 2, 1);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(182, 3);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 2;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(253, 206);
            this.tableLayoutPanel10.TabIndex = 44;
            // 
            // kouhai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "kouhai";
            this.Text = "kouhai";
            this.Load += new System.EventHandler(this.kouhai_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button butmix;
        private System.Windows.Forms.Button butfin;
        private System.Windows.Forms.ListBox depbox1;
        private System.Windows.Forms.ListBox depbox2;
        private System.Windows.Forms.ListBox namebox1;
        private System.Windows.Forms.ListBox namebox2;
        private System.Windows.Forms.Button butex;
        private System.Windows.Forms.RichTextBox yasaiextext;
        private System.Windows.Forms.RichTextBox ele2;
        private System.Windows.Forms.RichTextBox info2;
        private System.Windows.Forms.RichTextBox eleval2;
        private System.Windows.Forms.RichTextBox elename2;
        private System.Windows.Forms.RichTextBox yasaiextext2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.RichTextBox ele1;
        private System.Windows.Forms.RichTextBox info1;
        private System.Windows.Forms.RichTextBox eleval1;
        private System.Windows.Forms.RichTextBox elename1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
    }
}