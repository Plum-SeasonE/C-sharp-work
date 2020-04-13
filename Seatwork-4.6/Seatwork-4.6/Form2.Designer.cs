namespace Seatwork_4._6
{
    partial class Form2
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
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label_ID = new System.Windows.Forms.Label();
            this.label_customer = new System.Windows.Forms.Label();
            this.label_employee = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxCustomer = new System.Windows.Forms.TextBox();
            this.textBoxemployee = new System.Windows.Forms.TextBox();
            this.buttonCreat = new System.Windows.Forms.Button();
            this.itemsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderItemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tradeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tradeNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricePerTradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderItemIDDataGridViewTextBoxColumn,
            this.tradeNameDataGridViewTextBoxColumn,
            this.tradeNumDataGridViewTextBoxColumn,
            this.pricePerTradeDataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "Items";
            this.dataGridView1.DataSource = this.orderBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(289, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(508, 430);
            this.dataGridView1.TabIndex = 0;
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(28, 41);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(53, 15);
            this.label_ID.TabIndex = 1;
            this.label_ID.Text = "订单ID";
            // 
            // label_customer
            // 
            this.label_customer.AutoSize = true;
            this.label_customer.Location = new System.Drawing.Point(29, 103);
            this.label_customer.Name = "label_customer";
            this.label_customer.Size = new System.Drawing.Size(52, 15);
            this.label_customer.TabIndex = 2;
            this.label_customer.Text = "订货人";
            // 
            // label_employee
            // 
            this.label_employee.AutoSize = true;
            this.label_employee.Location = new System.Drawing.Point(29, 182);
            this.label_employee.Name = "label_employee";
            this.label_employee.Size = new System.Drawing.Size(52, 15);
            this.label_employee.TabIndex = 3;
            this.label_employee.Text = "发货人";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(134, 38);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 25);
            this.textBoxID.TabIndex = 4;
            // 
            // textBoxCustomer
            // 
            this.textBoxCustomer.Location = new System.Drawing.Point(134, 103);
            this.textBoxCustomer.Name = "textBoxCustomer";
            this.textBoxCustomer.Size = new System.Drawing.Size(100, 25);
            this.textBoxCustomer.TabIndex = 5;
            // 
            // textBoxemployee
            // 
            this.textBoxemployee.Location = new System.Drawing.Point(134, 182);
            this.textBoxemployee.Name = "textBoxemployee";
            this.textBoxemployee.Size = new System.Drawing.Size(100, 25);
            this.textBoxemployee.TabIndex = 6;
            // 
            // buttonCreat
            // 
            this.buttonCreat.Location = new System.Drawing.Point(93, 368);
            this.buttonCreat.Name = "buttonCreat";
            this.buttonCreat.Size = new System.Drawing.Size(109, 48);
            this.buttonCreat.TabIndex = 7;
            this.buttonCreat.Text = "确认创建";
            this.buttonCreat.UseVisualStyleBackColor = true;
            this.buttonCreat.Click += new System.EventHandler(this.buttonCreat_Click);
            // 
            // itemsBindingSource1
            // 
            this.itemsBindingSource1.DataMember = "Items";
            this.itemsBindingSource1.DataSource = this.orderBindingSource;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(Seatwork_3._16.Order);
            // 
            // orderItemIDDataGridViewTextBoxColumn
            // 
            this.orderItemIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.orderItemIDDataGridViewTextBoxColumn.DataPropertyName = "orderItemID";
            this.orderItemIDDataGridViewTextBoxColumn.HeaderText = "货物ID";
            this.orderItemIDDataGridViewTextBoxColumn.Name = "orderItemIDDataGridViewTextBoxColumn";
            // 
            // tradeNameDataGridViewTextBoxColumn
            // 
            this.tradeNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tradeNameDataGridViewTextBoxColumn.DataPropertyName = "tradeName";
            this.tradeNameDataGridViewTextBoxColumn.HeaderText = "货物名";
            this.tradeNameDataGridViewTextBoxColumn.Name = "tradeNameDataGridViewTextBoxColumn";
            // 
            // tradeNumDataGridViewTextBoxColumn
            // 
            this.tradeNumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tradeNumDataGridViewTextBoxColumn.DataPropertyName = "tradeNum";
            this.tradeNumDataGridViewTextBoxColumn.HeaderText = "货物数量";
            this.tradeNumDataGridViewTextBoxColumn.Name = "tradeNumDataGridViewTextBoxColumn";
            // 
            // pricePerTradeDataGridViewTextBoxColumn
            // 
            this.pricePerTradeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pricePerTradeDataGridViewTextBoxColumn.DataPropertyName = "pricePerTrade";
            this.pricePerTradeDataGridViewTextBoxColumn.HeaderText = "货物单价";
            this.pricePerTradeDataGridViewTextBoxColumn.Name = "pricePerTradeDataGridViewTextBoxColumn";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCreat);
            this.Controls.Add(this.textBoxemployee);
            this.Controls.Add(this.textBoxCustomer);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label_employee);
            this.Controls.Add(this.label_customer);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label label_customer;
        private System.Windows.Forms.Label label_employee;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxCustomer;
        private System.Windows.Forms.TextBox textBoxemployee;
        private System.Windows.Forms.Button buttonCreat;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.BindingSource itemsBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderItemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tradeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tradeNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricePerTradeDataGridViewTextBoxColumn;
    }
}