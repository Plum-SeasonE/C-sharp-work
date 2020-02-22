namespace caculator_2
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
            this.button_e = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_num1 = new System.Windows.Forms.TextBox();
            this.textBox2_op = new System.Windows.Forms.TextBox();
            this.textBox_num2 = new System.Windows.Forms.TextBox();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_e
            // 
            this.button_e.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_e.Font = new System.Drawing.Font("方正粗黑宋简体", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_e.Location = new System.Drawing.Point(251, 227);
            this.button_e.Name = "button_e";
            this.button_e.Size = new System.Drawing.Size(186, 106);
            this.button_e.TabIndex = 15;
            this.button_e.Text = "计算";
            this.button_e.UseVisualStyleBackColor = true;
            this.button_e.Click += new System.EventHandler(this.button_e_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("方正粗黑宋简体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(468, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 37);
            this.label1.TabIndex = 19;
            this.label1.Text = "=";
            // 
            // textBox_num1
            // 
            this.textBox_num1.Location = new System.Drawing.Point(63, 86);
            this.textBox_num1.Name = "textBox_num1";
            this.textBox_num1.Size = new System.Drawing.Size(116, 25);
            this.textBox_num1.TabIndex = 20;
            // 
            // textBox2_op
            // 
            this.textBox2_op.Location = new System.Drawing.Point(241, 86);
            this.textBox2_op.Name = "textBox2_op";
            this.textBox2_op.Size = new System.Drawing.Size(33, 25);
            this.textBox2_op.TabIndex = 21;
            // 
            // textBox_num2
            // 
            this.textBox_num2.Location = new System.Drawing.Point(342, 86);
            this.textBox_num2.Name = "textBox_num2";
            this.textBox_num2.Size = new System.Drawing.Size(116, 25);
            this.textBox_num2.TabIndex = 22;
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(509, 86);
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.Size = new System.Drawing.Size(116, 25);
            this.textBox_result.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "符号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "第二个数";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 26;
            this.label4.Text = "第一个数";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.textBox_num2);
            this.Controls.Add(this.textBox2_op);
            this.Controls.Add(this.textBox_num1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_e);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_e;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_num1;
        private System.Windows.Forms.TextBox textBox2_op;
        private System.Windows.Forms.TextBox textBox_num2;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

