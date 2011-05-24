namespace WindowsFormsApplication1
{
    partial class hatakeex
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
            this.buttane = new System.Windows.Forms.Button();
            this.butyasai = new System.Windows.Forms.Button();
            this.butget = new System.Windows.Forms.Button();
            this.butclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttane
            // 
            this.buttane.Location = new System.Drawing.Point(20, 33);
            this.buttane.Name = "buttane";
            this.buttane.Size = new System.Drawing.Size(150, 23);
            this.buttane.TabIndex = 0;
            this.buttane.Text = "種まきについて";
            this.buttane.UseVisualStyleBackColor = true;
            this.buttane.Click += new System.EventHandler(this.buttane_Click);
            // 
            // butyasai
            // 
            this.butyasai.Location = new System.Drawing.Point(20, 75);
            this.butyasai.Name = "butyasai";
            this.butyasai.Size = new System.Drawing.Size(150, 23);
            this.butyasai.TabIndex = 1;
            this.butyasai.Text = "野菜の成長について";
            this.butyasai.UseVisualStyleBackColor = true;
            this.butyasai.Click += new System.EventHandler(this.butyasai_Click);
            // 
            // butget
            // 
            this.butget.Location = new System.Drawing.Point(20, 117);
            this.butget.Name = "butget";
            this.butget.Size = new System.Drawing.Size(150, 23);
            this.butget.TabIndex = 2;
            this.butget.Text = "収穫について";
            this.butget.UseVisualStyleBackColor = true;
            this.butget.Click += new System.EventHandler(this.butget_Click);
            // 
            // butclose
            // 
            this.butclose.Location = new System.Drawing.Point(22, 155);
            this.butclose.Name = "butclose";
            this.butclose.Size = new System.Drawing.Size(150, 23);
            this.butclose.TabIndex = 3;
            this.butclose.Text = "説明終了";
            this.butclose.UseVisualStyleBackColor = true;
            this.butclose.Click += new System.EventHandler(this.butclose_Click);
            // 
            // hatakeex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 212);
            this.Controls.Add(this.butclose);
            this.Controls.Add(this.butget);
            this.Controls.Add(this.butyasai);
            this.Controls.Add(this.buttane);
            this.Name = "hatakeex";
            this.Text = "hatakeex";
            this.Load += new System.EventHandler(this.hatakeex_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttane;
        private System.Windows.Forms.Button butyasai;
        private System.Windows.Forms.Button butget;
        private System.Windows.Forms.Button butclose;
    }
}