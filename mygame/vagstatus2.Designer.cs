namespace WindowsFormsApplication1
{
    partial class vagstatus2
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
            this.infolabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.namelabel = new System.Windows.Forms.Label();
            this.butclose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.elelabel = new System.Windows.Forms.Label();
            this.levlabel = new System.Windows.Forms.Label();
            this.vagpic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.vagpic)).BeginInit();
            this.SuspendLayout();
            // 
            // infolabel
            // 
            this.infolabel.AutoSize = true;
            this.infolabel.Location = new System.Drawing.Point(64, 61);
            this.infolabel.Name = "infolabel";
            this.infolabel.Size = new System.Drawing.Size(0, 12);
            this.infolabel.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 72);
            this.label1.TabIndex = 6;
            this.label1.Text = "大きさ\n重さ\n模様\n栄養\n糖度\n食感";
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(24, 19);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(32, 12);
            this.namelabel.TabIndex = 5;
            this.namelabel.Text = "name";
            // 
            // butclose
            // 
            this.butclose.Location = new System.Drawing.Point(107, 356);
            this.butclose.Name = "butclose";
            this.butclose.Size = new System.Drawing.Size(75, 23);
            this.butclose.TabIndex = 4;
            this.butclose.Text = "閉じる";
            this.butclose.UseVisualStyleBackColor = true;
            this.butclose.Click += new System.EventHandler(this.butclose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "label3";
            // 
            // elelabel
            // 
            this.elelabel.AutoSize = true;
            this.elelabel.Location = new System.Drawing.Point(179, 61);
            this.elelabel.Name = "elelabel";
            this.elelabel.Size = new System.Drawing.Size(0, 12);
            this.elelabel.TabIndex = 11;
            // 
            // levlabel
            // 
            this.levlabel.AutoSize = true;
            this.levlabel.Location = new System.Drawing.Point(207, 61);
            this.levlabel.Name = "levlabel";
            this.levlabel.Size = new System.Drawing.Size(0, 12);
            this.levlabel.TabIndex = 12;
            // 
            // vagpic
            // 
            this.vagpic.Location = new System.Drawing.Point(94, 235);
            this.vagpic.Name = "vagpic";
            this.vagpic.Size = new System.Drawing.Size(100, 100);
            this.vagpic.TabIndex = 13;
            this.vagpic.TabStop = false;
            // 
            // vagstatus2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 412);
            this.Controls.Add(this.vagpic);
            this.Controls.Add(this.levlabel);
            this.Controls.Add(this.elelabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.infolabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.butclose);
            this.Name = "vagstatus2";
            this.Text = "vagstatus";
            this.Load += new System.EventHandler(this.vagstatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vagpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infolabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Button butclose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label elelabel;
        private System.Windows.Forms.Label levlabel;
        private System.Windows.Forms.PictureBox vagpic;
    }
}