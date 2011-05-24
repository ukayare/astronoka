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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // butmix
            // 
            this.butmix.Location = new System.Drawing.Point(22, 52);
            this.butmix.Name = "butmix";
            this.butmix.Size = new System.Drawing.Size(170, 23);
            this.butmix.TabIndex = 1;
            this.butmix.Text = "交配マシン";
            this.butmix.UseVisualStyleBackColor = true;
            this.butmix.Click += new System.EventHandler(this.butmix_Click);
            // 
            // butcontinue
            // 
            this.butcontinue.Location = new System.Drawing.Point(22, 95);
            this.butcontinue.Name = "butcontinue";
            this.butcontinue.Size = new System.Drawing.Size(170, 23);
            this.butcontinue.TabIndex = 2;
            this.butcontinue.Text = "カレンダー";
            this.butcontinue.UseVisualStyleBackColor = true;
            // 
            // butend
            // 
            this.butend.Location = new System.Drawing.Point(22, 137);
            this.butend.Name = "butend";
            this.butend.Size = new System.Drawing.Size(170, 23);
            this.butend.TabIndex = 3;
            this.butend.Text = "アストロネット";
            this.butend.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "ピートと話す";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // butitem
            // 
            this.butitem.Location = new System.Drawing.Point(22, 231);
            this.butitem.Name = "butitem";
            this.butitem.Size = new System.Drawing.Size(170, 23);
            this.butitem.TabIndex = 6;
            this.butitem.Text = "持ち物リスト";
            this.butitem.UseVisualStyleBackColor = true;
            this.butitem.Click += new System.EventHandler(this.butitem_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(22, 287);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "写真館";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // butreturn
            // 
            this.butreturn.Location = new System.Drawing.Point(22, 409);
            this.butreturn.Name = "butreturn";
            this.butreturn.Size = new System.Drawing.Size(170, 23);
            this.butreturn.TabIndex = 9;
            this.butreturn.Text = "戻る";
            this.butreturn.UseVisualStyleBackColor = true;
            this.butreturn.Click += new System.EventHandler(this.butreturn_Click);
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
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(22, 347);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(170, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "マイバブー";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(252, 72);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(480, 360);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.butitem);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.butend);
            this.Controls.Add(this.butcontinue);
            this.Controls.Add(this.butmix);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.moneylabel);
            this.Controls.Add(this.datelabel);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.butreturn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "home";
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.home_FormClosing);
            this.Load += new System.EventHandler(this.home_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
    }
}