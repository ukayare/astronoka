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
            this.button8 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.butbattle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.newgame.Location = new System.Drawing.Point(22, 52);
            this.newgame.Name = "newgame";
            this.newgame.Size = new System.Drawing.Size(170, 23);
            this.newgame.TabIndex = 1;
            this.newgame.Text = "家";
            this.newgame.UseVisualStyleBackColor = true;
            this.newgame.Click += new System.EventHandler(this.newgame_Click);
            // 
            // butcontinue
            // 
            this.butcontinue.Location = new System.Drawing.Point(22, 95);
            this.butcontinue.Name = "butcontinue";
            this.butcontinue.Size = new System.Drawing.Size(170, 23);
            this.butcontinue.TabIndex = 2;
            this.butcontinue.Text = "双眼鏡";
            this.butcontinue.UseVisualStyleBackColor = true;
            // 
            // buthatake
            // 
            this.buthatake.Location = new System.Drawing.Point(22, 137);
            this.buthatake.Name = "buthatake";
            this.buthatake.Size = new System.Drawing.Size(170, 23);
            this.buthatake.TabIndex = 3;
            this.buthatake.Text = "畑";
            this.buthatake.UseVisualStyleBackColor = true;
            this.buthatake.Click += new System.EventHandler(this.buthatake_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources._char;
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(234, 72);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(480, 360);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // trapb
            // 
            this.trapb.Location = new System.Drawing.Point(22, 183);
            this.trapb.Name = "trapb";
            this.trapb.Size = new System.Drawing.Size(170, 23);
            this.trapb.TabIndex = 5;
            this.trapb.Text = "トラップ配置";
            this.trapb.UseVisualStyleBackColor = true;
            this.trapb.Click += new System.EventHandler(this.trapb_Click);
            // 
            // butped
            // 
            this.butped.Location = new System.Drawing.Point(22, 231);
            this.butped.Name = "butped";
            this.butped.Size = new System.Drawing.Size(170, 23);
            this.butped.TabIndex = 6;
            this.butped.Text = "ペドロを呼ぶ";
            this.butped.UseVisualStyleBackColor = true;
            this.butped.Click += new System.EventHandler(this.butped_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(22, 287);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "宇宙バス停";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(22, 482);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(170, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "オプション";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // nextday
            // 
            this.nextday.Location = new System.Drawing.Point(22, 355);
            this.nextday.Name = "nextday";
            this.nextday.Size = new System.Drawing.Size(170, 23);
            this.nextday.TabIndex = 9;
            this.nextday.Text = "一日の終了";
            this.nextday.UseVisualStyleBackColor = true;
            this.nextday.Click += new System.EventHandler(this.nextday_Click);
            // 
            // butload
            // 
            this.butload.Location = new System.Drawing.Point(269, 507);
            this.butload.Name = "butload";
            this.butload.Size = new System.Drawing.Size(170, 23);
            this.butload.TabIndex = 10;
            this.butload.Text = "ロード";
            this.butload.UseVisualStyleBackColor = true;
            this.butload.Click += new System.EventHandler(this.butload_Click);
            // 
            // butsave
            // 
            this.butsave.Location = new System.Drawing.Point(269, 454);
            this.butsave.Name = "butsave";
            this.butsave.Size = new System.Drawing.Size(170, 23);
            this.butsave.TabIndex = 5;
            this.butsave.Text = "セーブ";
            this.butsave.UseVisualStyleBackColor = true;
            this.butsave.Click += new System.EventHandler(this.butsave_Click);
            // 
            // buttitle
            // 
            this.buttitle.Location = new System.Drawing.Point(544, 507);
            this.buttitle.Name = "buttitle";
            this.buttitle.Size = new System.Drawing.Size(170, 23);
            this.buttitle.TabIndex = 13;
            this.buttitle.Text = "タイトルに戻る";
            this.buttitle.UseVisualStyleBackColor = true;
            this.buttitle.Click += new System.EventHandler(this.buttitle_Click);
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(639, 26);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(35, 12);
            this.namelabel.TabIndex = 15;
            this.namelabel.Text = "名前：";
            // 
            // datelabel
            // 
            this.datelabel.AutoSize = true;
            this.datelabel.Location = new System.Drawing.Point(507, 26);
            this.datelabel.Name = "datelabel";
            this.datelabel.Size = new System.Drawing.Size(71, 12);
            this.datelabel.TabIndex = 16;
            this.datelabel.Text = "1年目1月1日";
            // 
            // moneylabel
            // 
            this.moneylabel.AutoSize = true;
            this.moneylabel.Location = new System.Drawing.Point(507, 52);
            this.moneylabel.Name = "moneylabel";
            this.moneylabel.Size = new System.Drawing.Size(35, 12);
            this.moneylabel.TabIndex = 17;
            this.moneylabel.Text = "label1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // finbut
            // 
            this.finbut.Location = new System.Drawing.Point(544, 454);
            this.finbut.Name = "finbut";
            this.finbut.Size = new System.Drawing.Size(170, 23);
            this.finbut.TabIndex = 18;
            this.finbut.Text = "ゲームの終了";
            this.finbut.UseVisualStyleBackColor = true;
            this.finbut.Click += new System.EventHandler(this.finbut_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(70, 398);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 22;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(117, 444);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // butbattle
            // 
            this.butbattle.Location = new System.Drawing.Point(22, 527);
            this.butbattle.Name = "butbattle";
            this.butbattle.Size = new System.Drawing.Size(170, 23);
            this.butbattle.TabIndex = 25;
            this.butbattle.Text = "トラップバトル";
            this.butbattle.UseVisualStyleBackColor = true;
            this.butbattle.Click += new System.EventHandler(this.butbattle_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.butbattle);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.butped);
            this.Controls.Add(this.trapb);
            this.Controls.Add(this.buthatake);
            this.Controls.Add(this.butcontinue);
            this.Controls.Add(this.newgame);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.finbut);
            this.Controls.Add(this.moneylabel);
            this.Controls.Add(this.datelabel);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.buttitle);
            this.Controls.Add(this.butsave);
            this.Controls.Add(this.butload);
            this.Controls.Add(this.nextday);
            this.Controls.Add(this.button4);
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
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button butbattle;
        }
}