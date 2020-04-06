namespace Seatwork_4._6
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_input = new System.Windows.Forms.Button();
            this.button_output = new System.Windows.Forms.Button();
            this.button_get = new System.Windows.Forms.Button();
            this.button_set = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_new = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(921, 380);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_input);
            this.panel1.Controls.Add(this.button_output);
            this.panel1.Controls.Add(this.button_get);
            this.panel1.Controls.Add(this.button_set);
            this.panel1.Controls.Add(this.button_delete);
            this.panel1.Controls.Add(this.button_new);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(921, 69);
            this.panel1.TabIndex = 1;
            // 
            // button_input
            // 
            this.button_input.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button_input.AutoSize = true;
            this.button_input.Location = new System.Drawing.Point(729, 0);
            this.button_input.Name = "button_input";
            this.button_input.Size = new System.Drawing.Size(138, 69);
            this.button_input.TabIndex = 5;
            this.button_input.Text = "导入订单";
            this.button_input.UseVisualStyleBackColor = true;
            // 
            // button_output
            // 
            this.button_output.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button_output.AutoSize = true;
            this.button_output.Location = new System.Drawing.Point(585, 0);
            this.button_output.Name = "button_output";
            this.button_output.Size = new System.Drawing.Size(138, 69);
            this.button_output.TabIndex = 4;
            this.button_output.Text = "导出订单";
            this.button_output.UseVisualStyleBackColor = true;
            // 
            // button_get
            // 
            this.button_get.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button_get.AutoSize = true;
            this.button_get.Location = new System.Drawing.Point(441, 0);
            this.button_get.Name = "button_get";
            this.button_get.Size = new System.Drawing.Size(138, 69);
            this.button_get.TabIndex = 3;
            this.button_get.Text = "查询订单";
            this.button_get.UseVisualStyleBackColor = true;
            // 
            // button_set
            // 
            this.button_set.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button_set.AutoSize = true;
            this.button_set.Location = new System.Drawing.Point(297, 0);
            this.button_set.Name = "button_set";
            this.button_set.Size = new System.Drawing.Size(138, 69);
            this.button_set.TabIndex = 2;
            this.button_set.Text = "修改订单";
            this.button_set.UseVisualStyleBackColor = true;
            // 
            // button_delete
            // 
            this.button_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button_delete.AutoSize = true;
            this.button_delete.Location = new System.Drawing.Point(153, 0);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(138, 69);
            this.button_delete.TabIndex = 1;
            this.button_delete.Text = "删除订单";
            this.button_delete.UseVisualStyleBackColor = true;
            // 
            // button_new
            // 
            this.button_new.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button_new.AutoSize = true;
            this.button_new.Location = new System.Drawing.Point(10, 0);
            this.button_new.Name = "button_new";
            this.button_new.Size = new System.Drawing.Size(138, 69);
            this.button_new.TabIndex = 0;
            this.button_new.Text = "新建订单";
            this.button_new.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.MinimumSize = new System.Drawing.Size(939, 497);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_input;
        private System.Windows.Forms.Button button_output;
        private System.Windows.Forms.Button button_get;
        private System.Windows.Forms.Button button_set;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_new;
        private System.Windows.Forms.DataGridViewTextBoxColumn customDataGridViewTextBoxColumn;
    }
}