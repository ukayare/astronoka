namespace WindowsFormsApplication1
{
    partial class astrodome
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.メニューToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restart = new System.Windows.Forms.ToolStripMenuItem();
            this.finish = new System.Windows.Forms.ToolStripMenuItem();
            this.newgame = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.butbus = new System.Windows.Forms.Button();
            this.namelabel = new System.Windows.Forms.Label();
            this.datelabel = new System.Windows.Forms.Label();
            this.moneylabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
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
            this.メニューToolStripMenuItem});
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
            this.restart.Size = new System.Drawing.Size(152, 22);
            this.restart.Text = "再起動";
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // finish
            // 
            this.finish.Name = "finish";
            this.finish.Size = new System.Drawing.Size(152, 22);
            this.finish.Text = "終了";
            this.finish.Click += new System.EventHandler(this.finish_Click);
            // 
            // newgame
            // 
            this.newgame.Location = new System.Drawing.Point(22, 52);
            this.newgame.Name = "newgame";
            this.newgame.Size = new System.Drawing.Size(170, 23);
            this.newgame.TabIndex = 1;
            this.newgame.Text = "コンクール会場";
            this.newgame.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(234, 72);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(480, 360);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // butbus
            // 
            this.butbus.Location = new System.Drawing.Point(22, 109);
            this.butbus.Name = "butbus";
            this.butbus.Size = new System.Drawing.Size(170, 23);
            this.butbus.TabIndex = 9;
            this.butbus.Text = "宇宙バス停";
            this.butbus.UseVisualStyleBackColor = true;
            this.butbus.Click += new System.EventHandler(this.butbus_Click);
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(639, 26);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(0, 12);
            this.namelabel.TabIndex = 15;
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
            // astrodome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.newgame);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.moneylabel);
            this.Controls.Add(this.datelabel);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.butbus);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "astrodome";
            this.Text = "アストロドーム";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.astrodome_FormClosing);
            this.Load += new System.EventHandler(this.astrodome_Load);
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
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button butbus;
        public System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label datelabel;
        private System.Windows.Forms.Label moneylabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}