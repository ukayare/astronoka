namespace WindowsFormsApplication1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.メニューToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restart = new System.Windows.Forms.ToolStripMenuItem();
            this.finish = new System.Windows.Forms.ToolStripMenuItem();
            this.セーブロードToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemsave = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemload = new System.Windows.Forms.ToolStripMenuItem();
            this.newgame = new System.Windows.Forms.Button();
            this.butcontinue = new System.Windows.Forms.Button();
            this.buthatake = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.trapb = new System.Windows.Forms.Button();
            this.butped = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.nextday = new System.Windows.Forms.Button();
            this.butload = new System.Windows.Forms.Button();
            this.butsave = new System.Windows.Forms.Button();
            this.buttitle = new System.Windows.Forms.Button();
            this.namelabel = new System.Windows.Forms.Label();
            this.datelabel = new System.Windows.Forms.Label();
            this.moneylabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.finbut = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.butbattle = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.メニューToolStripMenuItem,
            this.セーブロードToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // メニューToolStripMenuItem
            // 
            this.メニューToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restart,
            this.finish});
            this.メニューToolStripMenuItem.Name = "メニューToolStripMenuItem";
            this.メニューToolStripMenuItem.Size = new System.Drawing.Size(68, 22);
            this.メニューToolStripMenuItem.Text = "メニュー";
            // 
            // restart
            // 
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(112, 22);
            this.restart.Text = "再起動";
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // finish
            // 
            this.finish.Name = "finish";
            this.finish.Size = new System.Drawing.Size(112, 22);
            this.finish.Text = "終了";
            this.finish.Click += new System.EventHandler(this.finish_Click);
            // 
            // セーブロードToolStripMenuItem
            // 
            this.セーブロードToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemsave,
            this.MenuItemload});
            this.セーブロードToolStripMenuItem.Name = "セーブロードToolStripMenuItem";
            this.セーブロードToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.セーブロードToolStripMenuItem.Text = "セーブ＆ロード";
            // 
            // MenuItemsave
            // 
            this.MenuItemsave.Name = "MenuItemsave";
            this.MenuItemsave.Size = new System.Drawing.Size(112, 22);
            this.MenuItemsave.Text = "セーブ";
            this.MenuItemsave.Click += new System.EventHandler(this.MenuItemsave_Click);
            // 
            // MenuItemload
            // 
            this.MenuItemload.Name = "MenuItemload";
            this.MenuItemload.Size = new System.Drawing.Size(112, 22);
            this.MenuItemload.Text = "ロード";
            this.MenuItemload.Click += new System.EventHandler(this.MenuItemload_Click);
            // 
            // newgame
            // 
            this.newgame.Dock = System.Windows.Forms.DockStyle.Top;
            this.newgame.Location = new System.Drawing.Point(3, 3);
            this.newgame.Name = "newgame";
            this.newgame.Size = new System.Drawing.Size(184, 23);
            this.newgame.TabIndex = 1;
            this.newgame.Text = "家";
            this.newgame.UseVisualStyleBackColor = true;
            this.newgame.Click += new System.EventHandler(this.newgame_Click);
            // 
            // butcontinue
            // 
            this.butcontinue.Dock = System.Windows.Forms.DockStyle.Top;
            this.butcontinue.Location = new System.Drawing.Point(3, 55);
            this.butcontinue.Name = "butcontinue";
            this.butcontinue.Size = new System.Drawing.Size(184, 23);
            this.butcontinue.TabIndex = 2;
            this.butcontinue.Text = "双眼鏡";
            this.butcontinue.UseVisualStyleBackColor = true;
            // 
            // buthatake
            // 
            this.buthatake.Dock = System.Windows.Forms.DockStyle.Top;
            this.buthatake.Location = new System.Drawing.Point(3, 107);
            this.buthatake.Name = "buthatake";
            this.buthatake.Size = new System.Drawing.Size(184, 23);
            this.buthatake.TabIndex = 3;
            this.buthatake.Text = "畑";
            this.buthatake.UseVisualStyleBackColor = true;
            this.buthatake.Click += new System.EventHandler(this.buthatake_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources._char;
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(199, 56);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(582, 369);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // trapb
            // 
            this.trapb.Dock = System.Windows.Forms.DockStyle.Top;
            this.trapb.Location = new System.Drawing.Point(3, 159);
            this.trapb.Name = "trapb";
            this.trapb.Size = new System.Drawing.Size(184, 23);
            this.trapb.TabIndex = 5;
            this.trapb.Text = "トラップ配置";
            this.trapb.UseVisualStyleBackColor = true;
            this.trapb.Click += new System.EventHandler(this.trapb_Click);
            // 
            // butped
            // 
            this.butped.Dock = System.Windows.Forms.DockStyle.Top;
            this.butped.Location = new System.Drawing.Point(3, 211);
            this.butped.Name = "butped";
            this.butped.Size = new System.Drawing.Size(184, 23);
            this.butped.TabIndex = 6;
            this.butped.Text = "ペドロを呼ぶ";
            this.butped.UseVisualStyleBackColor = true;
            this.butped.Click += new System.EventHandler(this.butped_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Location = new System.Drawing.Point(3, 263);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "宇宙バス停";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 53);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "オプション";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // nextday
            // 
            this.nextday.Dock = System.Windows.Forms.DockStyle.Top;
            this.nextday.Location = new System.Drawing.Point(3, 315);
            this.nextday.Name = "nextday";
            this.nextday.Size = new System.Drawing.Size(184, 23);
            this.nextday.TabIndex = 9;
            this.nextday.Text = "一日の終了";
            this.nextday.UseVisualStyleBackColor = true;
            this.nextday.Click += new System.EventHandler(this.nextday_Click);
            // 
            // butload
            // 
            this.butload.Dock = System.Windows.Forms.DockStyle.Top;
            this.butload.Location = new System.Drawing.Point(3, 54);
            this.butload.Name = "butload";
            this.butload.Size = new System.Drawing.Size(285, 23);
            this.butload.TabIndex = 10;
            this.butload.Text = "ロード";
            this.butload.UseVisualStyleBackColor = true;
            this.butload.Click += new System.EventHandler(this.butload_Click);
            // 
            // butsave
            // 
            this.butsave.Dock = System.Windows.Forms.DockStyle.Top;
            this.butsave.Location = new System.Drawing.Point(3, 3);
            this.butsave.Name = "butsave";
            this.butsave.Size = new System.Drawing.Size(285, 23);
            this.butsave.TabIndex = 5;
            this.butsave.Text = "セーブ";
            this.butsave.UseVisualStyleBackColor = true;
            this.butsave.Click += new System.EventHandler(this.butsave_Click);
            // 
            // buttitle
            // 
            this.buttitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttitle.Location = new System.Drawing.Point(294, 54);
            this.buttitle.Name = "buttitle";
            this.buttitle.Size = new System.Drawing.Size(285, 23);
            this.buttitle.TabIndex = 13;
            this.buttitle.Text = "タイトルに戻る";
            this.buttitle.UseVisualStyleBackColor = true;
            this.buttitle.Click += new System.EventHandler(this.buttitle_Click);
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.namelabel.Location = new System.Drawing.Point(294, 0);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(51, 16);
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
            this.moneylabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.moneylabel.Location = new System.Drawing.Point(3, 23);
            this.moneylabel.Name = "moneylabel";
            this.moneylabel.Size = new System.Drawing.Size(52, 16);
            this.moneylabel.TabIndex = 17;
            this.moneylabel.Text = "label1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // finbut
            // 
            this.finbut.Dock = System.Windows.Forms.DockStyle.Top;
            this.finbut.Location = new System.Drawing.Point(294, 3);
            this.finbut.Name = "finbut";
            this.finbut.Size = new System.Drawing.Size(285, 23);
            this.finbut.TabIndex = 18;
            this.finbut.Text = "ゲームの終了";
            this.finbut.UseVisualStyleBackColor = true;
            this.finbut.Click += new System.EventHandler(this.finbut_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(98, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // butbattle
            // 
            this.butbattle.Location = new System.Drawing.Point(98, 53);
            this.butbattle.Name = "butbattle";
            this.butbattle.Size = new System.Drawing.Size(89, 23);
            this.butbattle.TabIndex = 25;
            this.butbattle.Text = "トラップバトル";
            this.butbattle.UseVisualStyleBackColor = true;
            this.butbattle.Click += new System.EventHandler(this.butbattle_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 26);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 536);
            this.tableLayoutPanel1.TabIndex = 26;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.newgame, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.butcontinue, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.buthatake, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.trapb, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.butped, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.button3, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.nextday, 0, 6);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 56);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 7;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(190, 369);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.butsave, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.finbut, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.butload, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.buttitle, 1, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(199, 431);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(582, 102);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.datelabel, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.moneylabel, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.namelabel, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(199, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(582, 47);
            this.tableLayoutPanel5.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.button4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.butbattle, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 431);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(190, 100);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "アストロノーカ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.Shown += new System.EventHandler(this.Form3_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem メニューToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finish;
        private System.Windows.Forms.ToolStripMenuItem restart;
        private System.Windows.Forms.Button newgame;
        private System.Windows.Forms.Button butcontinue;
        private System.Windows.Forms.Button buthatake;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button trapb;
        private System.Windows.Forms.Button butped;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button nextday;
        private System.Windows.Forms.Button butload;
        private System.Windows.Forms.Button butsave;
        private System.Windows.Forms.Button buttitle;
        public System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label datelabel;
        private System.Windows.Forms.Label moneylabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button finbut;
        private System.Windows.Forms.ToolStripMenuItem セーブロードToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemsave;
        private System.Windows.Forms.ToolStripMenuItem MenuItemload;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button butbattle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        }
}