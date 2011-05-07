namespace WindowsFormsApplication1
{
    partial class pantaron :townbase
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        //private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        /*protected void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }*/

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        /*private new void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.メニューToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restart = new System.Windows.Forms.ToolStripMenuItem();
            this.finish = new System.Windows.Forms.ToolStripMenuItem();
            this.newgame = new System.Windows.Forms.Button();
            this.butcontinue = new System.Windows.Forms.Button();
            this.butend = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            // 
            // finish
            // 
            this.finish.Name = "finish";
            this.finish.Size = new System.Drawing.Size(112, 22);
            this.finish.Text = "終了";
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
            // butcontinue
            // 
            this.butcontinue.Location = new System.Drawing.Point(22, 95);
            this.butcontinue.Name = "butcontinue";
            this.butcontinue.Size = new System.Drawing.Size(170, 23);
            this.butcontinue.TabIndex = 2;
            this.butcontinue.Text = "宇宙農協";
            this.butcontinue.UseVisualStyleBackColor = true;
            // 
            // butend
            // 
            this.butend.Location = new System.Drawing.Point(22, 137);
            this.butend.Name = "butend";
            this.butend.Size = new System.Drawing.Size(170, 23);
            this.butend.TabIndex = 3;
            this.butend.Text = "ふとん屋";
            this.butend.UseVisualStyleBackColor = true;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "トラップ屋";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 231);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "コールテン研究所";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(22, 287);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "町の人々";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // butbus
            // 
            this.butbus.Location = new System.Drawing.Point(22, 355);
            this.butbus.Name = "butbus";
            this.butbus.Size = new System.Drawing.Size(170, 23);
            this.butbus.TabIndex = 9;
            this.butbus.Text = "宇宙バス停";
            this.butbus.UseVisualStyleBackColor = true;
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
            // pantaron
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.butend);
            this.Controls.Add(this.butcontinue);
            this.Controls.Add(this.newgame);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.moneylabel);
            this.Controls.Add(this.datelabel);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.butbus);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "pantaron";
            this.Text = "パンタロン町";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }*/

        #endregion

       
    }
}