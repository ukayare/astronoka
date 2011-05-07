namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.namebox = new System.Windows.Forms.TextBox();
            this.labelname = new System.Windows.Forms.Label();
            this.butdecide = new System.Windows.Forms.Button();
            this.butret = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(66, 53);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(162, 19);
            this.namebox.TabIndex = 0;
            this.namebox.TextChanged += new System.EventHandler(this.namebox_TextChanged);
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Location = new System.Drawing.Point(71, 22);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(152, 12);
            this.labelname.TabIndex = 1;
            this.labelname.Text = "あなたの名前を入力してください";
            // 
            // butdecide
            // 
            this.butdecide.Location = new System.Drawing.Point(66, 87);
            this.butdecide.Name = "butdecide";
            this.butdecide.Size = new System.Drawing.Size(75, 23);
            this.butdecide.TabIndex = 2;
            this.butdecide.Text = "決定";
            this.butdecide.UseVisualStyleBackColor = true;
            this.butdecide.Click += new System.EventHandler(this.butdecide_Click);
            // 
            // butret
            // 
            this.butret.Location = new System.Drawing.Point(153, 87);
            this.butret.Name = "butret";
            this.butret.Size = new System.Drawing.Size(75, 23);
            this.butret.TabIndex = 3;
            this.butret.Text = "戻る";
            this.butret.UseVisualStyleBackColor = true;
            this.butret.Click += new System.EventHandler(this.butret_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 135);
            this.Controls.Add(this.butret);
            this.Controls.Add(this.butdecide);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.namebox);
            this.Name = "Form2";
            this.Text = "名前登録";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Button butdecide;
        private System.Windows.Forms.Button butret;
    }
}