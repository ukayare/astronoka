namespace WindowsFormsApplication1
{
    partial class title
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(title));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.メニューToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restart = new System.Windows.Forms.ToolStripMenuItem();
            this.finish = new System.Windows.Forms.ToolStripMenuItem();
            this.newgame = new System.Windows.Forms.Button();
            this.butcontinue = new System.Windows.Forms.Button();
            this.butend = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(52, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 600);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.メニューToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
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
            // newgame
            // 
            this.newgame.Location = new System.Drawing.Point(193, 508);
            this.newgame.Name = "newgame";
            this.newgame.Size = new System.Drawing.Size(75, 23);
            this.newgame.TabIndex = 1;
            this.newgame.Text = "ニューゲーム";
            this.newgame.UseVisualStyleBackColor = true;
            this.newgame.Click += new System.EventHandler(this.newgame_Click);
            // 
            // butcontinue
            // 
            this.butcontinue.Location = new System.Drawing.Point(348, 508);
            this.butcontinue.Name = "butcontinue";
            this.butcontinue.Size = new System.Drawing.Size(75, 23);
            this.butcontinue.TabIndex = 2;
            this.butcontinue.Text = "コンテニュー";
            this.butcontinue.UseVisualStyleBackColor = true;
            this.butcontinue.Click += new System.EventHandler(this.butcontinue_Click);
            // 
            // butend
            // 
            this.butend.Location = new System.Drawing.Point(499, 508);
            this.butend.Name = "butend";
            this.butend.Size = new System.Drawing.Size(75, 23);
            this.butend.TabIndex = 3;
            this.butend.Text = "終了";
            this.butend.UseVisualStyleBackColor = true;
            this.butend.Click += new System.EventHandler(this.butend_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources._char;
            this.pictureBox2.Location = new System.Drawing.Point(-16, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(800, 600);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // title
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.butend);
            this.Controls.Add(this.butcontinue);
            this.Controls.Add(this.newgame);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "title";
            this.Text = "mygame";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Button butend;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

