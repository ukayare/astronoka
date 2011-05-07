namespace WindowsFormsApplication1
{
    partial class seedstatus
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
            this.butclose = new System.Windows.Forms.Button();
            this.namelabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.infolabel = new System.Windows.Forms.Label();
            this.plabel = new System.Windows.Forms.Label();
            this.elelabel = new System.Windows.Forms.Label();
            this.levlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butclose
            // 
            this.butclose.Location = new System.Drawing.Point(106, 221);
            this.butclose.Name = "butclose";
            this.butclose.Size = new System.Drawing.Size(75, 23);
            this.butclose.TabIndex = 0;
            this.butclose.Text = "閉じる";
            this.butclose.UseVisualStyleBackColor = true;
            this.butclose.Click += new System.EventHandler(this.butclose_Click);
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(24, 9);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(32, 12);
            this.namelabel.TabIndex = 1;
            this.namelabel.Text = "name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 72);
            this.label1.TabIndex = 2;
            this.label1.Text = "大きさ\r\n重さ\r\n模様\r\n栄養\r\n糖度\r\n食感";
            // 
            // infolabel
            // 
            this.infolabel.AutoSize = true;
            this.infolabel.Location = new System.Drawing.Point(64, 51);
            this.infolabel.Name = "infolabel";
            this.infolabel.Size = new System.Drawing.Size(0, 12);
            this.infolabel.TabIndex = 3;
            // 
            // plabel
            // 
            this.plabel.AutoSize = true;
            this.plabel.Location = new System.Drawing.Point(193, 9);
            this.plabel.Name = "plabel";
            this.plabel.Size = new System.Drawing.Size(30, 12);
            this.plabel.TabIndex = 4;
            this.plabel.Text = "price";
            // 
            // elelabel
            // 
            this.elelabel.AutoSize = true;
            this.elelabel.Location = new System.Drawing.Point(181, 51);
            this.elelabel.Name = "elelabel";
            this.elelabel.Size = new System.Drawing.Size(0, 12);
            this.elelabel.TabIndex = 5;
            // 
            // levlabel
            // 
            this.levlabel.AutoSize = true;
            this.levlabel.Location = new System.Drawing.Point(217, 51);
            this.levlabel.Name = "levlabel";
            this.levlabel.Size = new System.Drawing.Size(0, 12);
            this.levlabel.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // seedstatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.levlabel);
            this.Controls.Add(this.elelabel);
            this.Controls.Add(this.plabel);
            this.Controls.Add(this.infolabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.butclose);
            this.Name = "seedstatus";
            this.Text = "seedstatus";
            this.Load += new System.EventHandler(this.seedstatus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butclose;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label infolabel;
        private System.Windows.Forms.Label plabel;
        private System.Windows.Forms.Label elelabel;
        private System.Windows.Forms.Label levlabel;
        private System.Windows.Forms.Label label2;
    }
}