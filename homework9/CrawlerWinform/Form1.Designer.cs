namespace CrawlerWinform
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonBegin = new System.Windows.Forms.Button();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.listBoxRecord = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonBegin
            // 
            this.buttonBegin.Location = new System.Drawing.Point(631, 72);
            this.buttonBegin.Name = "buttonBegin";
            this.buttonBegin.Size = new System.Drawing.Size(75, 23);
            this.buttonBegin.TabIndex = 0;
            this.buttonBegin.Text = "开始爬取";
            this.buttonBegin.UseVisualStyleBackColor = true;
            this.buttonBegin.Click += new System.EventHandler(this.buttonBegin_Click);
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(179, 70);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(403, 25);
            this.textBoxURL.TabIndex = 1;
            // 
            // listBoxRecord
            // 
            this.listBoxRecord.FormattingEnabled = true;
            this.listBoxRecord.ItemHeight = 15;
            this.listBoxRecord.Location = new System.Drawing.Point(12, 111);
            this.listBoxRecord.Name = "listBoxRecord";
            this.listBoxRecord.Size = new System.Drawing.Size(755, 319);
            this.listBoxRecord.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxRecord);
            this.Controls.Add(this.textBoxURL);
            this.Controls.Add(this.buttonBegin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBegin;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.ListBox listBoxRecord;
    }
}

