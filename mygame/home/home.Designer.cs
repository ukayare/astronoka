namespace WindowsFormsApplication1
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.butmix = new System.Windows.Forms.Button();
            this.butcontinue = new System.Windows.Forms.Button();
            this.butend = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.butitem = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.butreturn = new System.Windows.Forms.Button();
            this.namelabel = new System.Windows.Forms.Label();
            this.datelabel = new System.Windows.Forms.Label();
            this.moneylabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(52, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 600);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // butmix
            // 
            this.butmix.Dock = System.Windows.Forms.DockStyle.Top;
            this.butmix.Location = new System.Drawing.Point(3, 3);
            this.butmix.Name = "butmix";
            this.butmix.Size = new System.Drawing.Size(184, 23);
            this.butmix.TabIndex = 1;
            this.butmix.Text = "交配マシン";
            this.butmix.UseVisualStyleBackColor = true;
            this.butmix.Click += new System.EventHandler(this.butmix_Click);
            // 
            // butcontinue
            // 
            this.butcontinue.Dock = System.Windows.Forms.DockStyle.Top;
            this.butcontinue.Location = new System.Drawing.Point(3, 49);
            this.butcontinue.Name = "butcontinue";
            this.butcontinue.Size = new System.Drawing.Size(184, 23);
            this.butcontinue.TabIndex = 2;
            this.butcontinue.Text = "カレンダー";
            this.butcontinue.UseVisualStyleBackColor = true;
            // 
            // butend
            // 
            this.butend.Dock = System.Windows.Forms.DockStyle.Top;
            this.butend.Location = new System.Drawing.Point(3, 95);
            this.butend.Name = "butend";
            this.butend.Size = new System.Drawing.Size(184, 23);
            this.butend.TabIndex = 3;
            this.butend.Text = "アストロネット";
            this.butend.UseVisualStyleBackColor = true;
            this.butend.Click += new System.EventHandler(this.butend_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(3, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "ピートと話す";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // butitem
            // 
            this.butitem.Dock = System.Windows.Forms.DockStyle.Top;
            this.butitem.Location = new System.Drawing.Point(3, 187);
            this.butitem.Name = "butitem";
            this.butitem.Size = new System.Drawing.Size(184, 23);
            this.butitem.TabIndex = 6;
            this.butitem.Text = "持ち物リスト";
            this.butitem.UseVisualStyleBackColor = true;
            this.butitem.Click += new System.EventHandler(this.butitem_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Location = new System.Drawing.Point(3, 233);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "写真館";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // butreturn
            // 
            this.butreturn.Dock = System.Windows.Forms.DockStyle.Top;
            this.butreturn.Location = new System.Drawing.Point(3, 325);
            this.butreturn.Name = "butreturn";
            this.butreturn.Size = new System.Drawing.Size(184, 23);
            this.butreturn.TabIndex = 9;
            this.butreturn.Text = "戻る";
            this.butreturn.UseVisualStyleBackColor = true;
            this.butreturn.Click += new System.EventHandler(this.butreturn_Click);
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.namelabel.Location = new System.Drawing.Point(294, 0);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(60, 19);
            this.namelabel.TabIndex = 15;
            this.namelabel.Text = "名前：";
            // 
            // datelabel
            // 
            this.datelabel.AutoSize = true;
            this.datelabel.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.datelabel.Location = new System.Drawing.Point(3, 0);
            this.datelabel.Name = "datelabel";
            this.datelabel.Size = new System.Drawing.Size(122, 19);
            this.datelabel.TabIndex = 16;
            this.datelabel.Text = "1年目1月1日";
            // 
            // moneylabel
            // 
            this.moneylabel.AutoSize = true;
            this.moneylabel.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.moneylabel.Location = new System.Drawing.Point(3, 23);
            this.moneylabel.Name = "moneylabel";
            this.moneylabel.Size = new System.Drawing.Size(61, 19);
            this.moneylabel.TabIndex = 17;
            this.moneylabel.Text = "label1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.Location = new System.Drawing.Point(3, 279);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(184, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "マイバブー";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(199, 56);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(582, 370);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 538);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.moneylabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.datelabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.namelabel, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(199, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(582, 47);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.butreturn, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.butmix, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.butcontinue, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.butend, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.button1, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.button3, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.button4, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.butitem, 0, 4);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 56);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 8;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(190, 370);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "home";
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.home_FormClosing);
            this.Load += new System.EventHandler(this.home_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button butmix;
        private System.Windows.Forms.Button butcontinue;
        private System.Windows.Forms.Button butend;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button butitem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button butreturn;
        public System.Windows.Forms.Label namelabel;
        public System.Windows.Forms.Label datelabel;
        public System.Windows.Forms.Label moneylabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}