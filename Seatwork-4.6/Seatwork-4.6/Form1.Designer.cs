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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_input = new System.Windows.Forms.Button();
            this.button_output = new System.Windows.Forms.Button();
            this.button_get = new System.Windows.Forms.Button();
            this.button_set = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_new = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.orderItemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tradeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tradeNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricePerTradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cumstomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderID,
            this.employeeDataGridViewTextBoxColumn,
            this.cumstomerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(471, 326);
            this.dataGridView1.TabIndex = 0;
            // 
            // orderID
            // 
            this.orderID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.orderID.DataPropertyName = "orderID";
            this.orderID.HeaderText = "orderID";
            this.orderID.Name = "orderID";
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
            this.panel1.Size = new System.Drawing.Size(1062, 69);
            this.panel1.TabIndex = 1;
            // 
            // button_input
            // 
            this.button_input.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button_input.AutoSize = true;
            this.button_input.Location = new System.Drawing.Point(871, 0);
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
            this.button_output.Location = new System.Drawing.Point(727, 0);
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
            this.button_get.Location = new System.Drawing.Point(583, 0);
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
            this.button_set.Location = new System.Drawing.Point(439, 0);
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
            this.button_delete.Location = new System.Drawing.Point(295, 0);
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
            this.button_new.Location = new System.Drawing.Point(152, 0);
            this.button_new.Name = "button_new";
            this.button_new.Size = new System.Drawing.Size(138, 69);
            this.button_new.TabIndex = 0;
            this.button_new.Text = "新建订单";
            this.button_new.UseVisualStyleBackColor = true;
            this.button_new.Click += new System.EventHandler(this.button_new_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderItemIDDataGridViewTextBoxColumn,
            this.tradeNameDataGridViewTextBoxColumn,
            this.tradeNumDataGridViewTextBoxColumn,
            this.pricePerTradeDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.orderItemBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(494, 143);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(569, 326);
            this.dataGridView2.TabIndex = 2;
            // 
            // orderItemIDDataGridViewTextBoxColumn
            // 
            this.orderItemIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.orderItemIDDataGridViewTextBoxColumn.DataPropertyName = "orderItemID";
            this.orderItemIDDataGridViewTextBoxColumn.HeaderText = "orderItemID";
            this.orderItemIDDataGridViewTextBoxColumn.Name = "orderItemIDDataGridViewTextBoxColumn";
            // 
            // tradeNameDataGridViewTextBoxColumn
            // 
            this.tradeNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tradeNameDataGridViewTextBoxColumn.DataPropertyName = "tradeName";
            this.tradeNameDataGridViewTextBoxColumn.HeaderText = "tradeName";
            this.tradeNameDataGridViewTextBoxColumn.Name = "tradeNameDataGridViewTextBoxColumn";
            // 
            // tradeNumDataGridViewTextBoxColumn
            // 
            this.tradeNumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tradeNumDataGridViewTextBoxColumn.DataPropertyName = "tradeNum";
            this.tradeNumDataGridViewTextBoxColumn.HeaderText = "tradeNum";
            this.tradeNumDataGridViewTextBoxColumn.Name = "tradeNumDataGridViewTextBoxColumn";
            // 
            // pricePerTradeDataGridViewTextBoxColumn
            // 
            this.pricePerTradeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pricePerTradeDataGridViewTextBoxColumn.DataPropertyName = "pricePerTrade";
            this.pricePerTradeDataGridViewTextBoxColumn.HeaderText = "pricePerTrade";
            this.pricePerTradeDataGridViewTextBoxColumn.Name = "pricePerTradeDataGridViewTextBoxColumn";
            // 
            // orderItemBindingSource
            // 
            this.orderItemBindingSource.DataSource = typeof(Seatwork_3._16.OrderItem);
            // 
            // employeeDataGridViewTextBoxColumn
            // 
            this.employeeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.employeeDataGridViewTextBoxColumn.DataPropertyName = "employee";
            this.employeeDataGridViewTextBoxColumn.HeaderText = "employee";
            this.employeeDataGridViewTextBoxColumn.Name = "employeeDataGridViewTextBoxColumn";
            // 
            // cumstomerDataGridViewTextBoxColumn
            // 
            this.cumstomerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cumstomerDataGridViewTextBoxColumn.DataPropertyName = "cumstomer";
            this.cumstomerDataGridViewTextBoxColumn.HeaderText = "cumstomer";
            this.cumstomerDataGridViewTextBoxColumn.Name = "cumstomerDataGridViewTextBoxColumn";
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(Seatwork_3._16.Order);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 468);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(1080, 515);
            this.MinimumSize = new System.Drawing.Size(1080, 515);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cumstomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderItemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tradeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tradeNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricePerTradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderItemBindingSource;
    }
}