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
            this.ele1 = new System.Windows.Forms.RichTextBox();
            this.info1 = new System.Windows.Forms.RichTextBox();
            this.eleval1 = new System.Windows.Forms.RichTextBox();
            this.elename1 = new System.Windows.Forms.RichTextBox();
            this.yasaiextext = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ele1
            // 
            this.ele1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ele1.Location = new System.Drawing.Point(197, 82);
            this.ele1.Name = "ele1";
            this.ele1.ReadOnly = true;
            this.ele1.Size = new System.Drawing.Size(39, 172);
            this.ele1.TabIndex = 44;
            this.ele1.Text = "";
            // 
            // info1
            // 
            this.info1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.info1.Location = new System.Drawing.Point(234, 82);
            this.info1.Name = "info1";
            this.info1.ReadOnly = true;
            this.info1.Size = new System.Drawing.Size(104, 172);
            this.info1.TabIndex = 43;
            this.info1.Text = "";
            // 
            // eleval1
            // 
            this.eleval1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.eleval1.Location = new System.Drawing.Point(336, 82);
            this.eleval1.Name = "eleval1";
            this.eleval1.ReadOnly = true;
            this.eleval1.Size = new System.Drawing.Size(32, 172);
            this.eleval1.TabIndex = 45;
            this.eleval1.Text = "";
            // 
            // elename1
            // 
            this.elename1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.elename1.Location = new System.Drawing.Point(366, 82);
            this.elename1.Name = "elename1";
            this.elename1.ReadOnly = true;
            this.elename1.Size = new System.Drawing.Size(80, 172);
            this.elename1.TabIndex = 46;
            this.elename1.Text = "";
            // 
            // yasaiextext
            // 
            this.yasaiextext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.yasaiextext.Location = new System.Drawing.Point(9, 12);
            this.yasaiextext.Name = "yasaiextext";
            this.yasaiextext.ReadOnly = true;
            this.yasaiextext.Size = new System.Drawing.Size(189, 242);
            this.yasaiextext.TabIndex = 42;
            this.yasaiextext.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 47;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(185, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 48;
            this.button1.Text = "閉じる";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // seedstatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 315);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ele1);
            this.Controls.Add(this.info1);
            this.Controls.Add(this.eleval1);
            this.Controls.Add(this.elename1);
            this.Controls.Add(this.yasaiextext);
            this.Name = "seedstatus";
            this.Text = "seedstatus";
            this.Load += new System.EventHandler(this.seedstatus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox ele1;
        private System.Windows.Forms.RichTextBox info1;
        private System.Windows.Forms.RichTextBox eleval1;
        private System.Windows.Forms.RichTextBox elename1;
        private System.Windows.Forms.RichTextBox yasaiextext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}