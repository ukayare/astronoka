namespace WindowsFormsApplication1
{
    public partial class townbase
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        protected System.ComponentModel.IContainer components = null;

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
        protected virtual void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.メニューToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restart = new System.Windows.Forms.ToolStripMenuItem();
            this.finish = new System.Windows.Forms.ToolStripMenuItem();
            this.butcon = new System.Windows.Forms.Button();
            this.butua = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
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
            // butcon
            // 
            this.butcon.Location = new System.Drawing.Point(22, 52);
            this.butcon.Name = "butcon";
            this.butcon.Size = new System.Drawing.Size(170, 23);
            this.butcon.TabIndex = 1;
            this.butcon.Text = "コンクール会場";
            this.butcon.UseVisualStyleBackColor = true;
            this.butcon.Click += new System.EventHandler(this.butcon_Click);
            // 
            // butua
            // 
            this.butua.Location = new System.Drawing.Point(22, 95);
            this.butua.Name = "butua";
            this.butua.Size = new System.Drawing.Size(170, 23);
            this.butua.TabIndex = 2;
            this.butua.Text = "宇宙農協";
            this.butua.UseVisualStyleBackColor = true;
            this.butua.Click += new System.EventHandler(this.butua_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "農業ロボット協会";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 183);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "メガネの若者";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(22, 231);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "ご隠居";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(22, 287);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(170, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "村の人々";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // butbus
            // 
            this.butbus.Location = new System.Drawing.Point(22, 355);
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
            // townbase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.butua);
            this.Controls.Add(this.butcon);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.moneylabel);
            this.Controls.Add(this.datelabel);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.butbus);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "townbase";
            this.Text = "テンガロン村";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.townbase_FormClosing);
            this.Load += new System.EventHandler(this.townbase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.PictureBox pictureBox1;
        protected System.Windows.Forms.MenuStrip menuStrip1;
        protected System.Windows.Forms.ToolStripMenuItem メニューToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem finish;
        protected System.Windows.Forms.ToolStripMenuItem restart;
        protected System.Windows.Forms.Button butcon;
        protected System.Windows.Forms.Button butua;
        protected System.Windows.Forms.Button button1;
        protected System.Windows.Forms.PictureBox pictureBox2;
        protected System.Windows.Forms.Button button2;
        protected System.Windows.Forms.Button button3;
        protected System.Windows.Forms.Button button4;
        protected System.Windows.Forms.Button butbus;
        public System.Windows.Forms.Label namelabel;
        protected System.Windows.Forms.Label datelabel;
        protected System.Windows.Forms.Label moneylabel;
        protected System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}