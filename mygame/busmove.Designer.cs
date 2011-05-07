namespace WindowsFormsApplication1
{
    partial class busmove
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
            this.distlist = new System.Windows.Forms.ListBox();
            this.butgo = new System.Windows.Forms.Button();
            this.butno = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.distlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // distlist
            // 
            this.distlist.FormattingEnabled = true;
            this.distlist.ItemHeight = 12;
            this.distlist.Items.AddRange(new object[] {
            "自宅",
            "テンガロン村",
            "パンタロン町",
            "ソンブレロ市",
            "アストロドーム"});
            this.distlist.Location = new System.Drawing.Point(39, 12);
            this.distlist.Name = "distlist";
            this.distlist.Size = new System.Drawing.Size(120, 64);
            this.distlist.TabIndex = 0;
            this.distlist.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // butgo
            // 
            this.butgo.Location = new System.Drawing.Point(12, 160);
            this.butgo.Name = "butgo";
            this.butgo.Size = new System.Drawing.Size(75, 23);
            this.butgo.TabIndex = 1;
            this.butgo.Text = "行く";
            this.butgo.UseVisualStyleBackColor = true;
            this.butgo.Click += new System.EventHandler(this.butgo_Click);
            // 
            // butno
            // 
            this.butno.Location = new System.Drawing.Point(113, 160);
            this.butno.Name = "butno";
            this.butno.Size = new System.Drawing.Size(75, 23);
            this.butno.TabIndex = 2;
            this.butno.Text = "行かない";
            this.butno.UseVisualStyleBackColor = true;
            this.butno.Click += new System.EventHandler(this.butno_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "行き先を選んでください";
            // 
            // distlabel
            // 
            this.distlabel.AutoSize = true;
            this.distlabel.Location = new System.Drawing.Point(45, 132);
            this.distlabel.Name = "distlabel";
            this.distlabel.Size = new System.Drawing.Size(0, 12);
            this.distlabel.TabIndex = 4;
            // 
            // busmove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 195);
            this.Controls.Add(this.distlabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butno);
            this.Controls.Add(this.butgo);
            this.Controls.Add(this.distlist);
            this.Name = "busmove";
            this.Text = "busmove";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.busmove_FormClosing);
            this.Load += new System.EventHandler(this.busmove_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox distlist;
        private System.Windows.Forms.Button butgo;
        private System.Windows.Forms.Button butno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label distlabel;

    }
}