namespace InternetServiceProvider
{
    partial class Payments
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
            this.paymentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abonentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentmethodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymenthistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.internetServiceProviderDBDataSet5 = new InternetServiceProvider.InternetServiceProviderDBDataSet5();
            this.payment_historyTableAdapter = new InternetServiceProvider.InternetServiceProviderDBDataSet5TableAdapters.payment_historyTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymenthistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internetServiceProviderDBDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.paymentidDataGridViewTextBoxColumn,
            this.abonentidDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.paymentdateDataGridViewTextBoxColumn,
            this.paymentmethodDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.paymenthistoryBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 90);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(800, 360);
            this.dataGridView1.TabIndex = 0;
            // 
            // paymentidDataGridViewTextBoxColumn
            // 
            this.paymentidDataGridViewTextBoxColumn.DataPropertyName = "payment_id";
            this.paymentidDataGridViewTextBoxColumn.HeaderText = "payment_id";
            this.paymentidDataGridViewTextBoxColumn.Name = "paymentidDataGridViewTextBoxColumn";
            this.paymentidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // abonentidDataGridViewTextBoxColumn
            // 
            this.abonentidDataGridViewTextBoxColumn.DataPropertyName = "abonent_id";
            this.abonentidDataGridViewTextBoxColumn.HeaderText = "abonent_id";
            this.abonentidDataGridViewTextBoxColumn.Name = "abonentidDataGridViewTextBoxColumn";
            this.abonentidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentdateDataGridViewTextBoxColumn
            // 
            this.paymentdateDataGridViewTextBoxColumn.DataPropertyName = "payment_date";
            this.paymentdateDataGridViewTextBoxColumn.HeaderText = "payment_date";
            this.paymentdateDataGridViewTextBoxColumn.Name = "paymentdateDataGridViewTextBoxColumn";
            this.paymentdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentmethodDataGridViewTextBoxColumn
            // 
            this.paymentmethodDataGridViewTextBoxColumn.DataPropertyName = "payment_method";
            this.paymentmethodDataGridViewTextBoxColumn.HeaderText = "payment_method";
            this.paymentmethodDataGridViewTextBoxColumn.Name = "paymentmethodDataGridViewTextBoxColumn";
            this.paymentmethodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymenthistoryBindingSource
            // 
            this.paymenthistoryBindingSource.DataMember = "payment_history";
            this.paymenthistoryBindingSource.DataSource = this.internetServiceProviderDBDataSet5;
            // 
            // internetServiceProviderDBDataSet5
            // 
            this.internetServiceProviderDBDataSet5.DataSetName = "InternetServiceProviderDBDataSet5";
            this.internetServiceProviderDBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // payment_historyTableAdapter
            // 
            this.payment_historyTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(593, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 65);
            this.button2.TabIndex = 2;
            this.button2.Text = "Звіт по платежам клієнтів";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Payments";
            this.Text = "Payments";
            this.Load += new System.EventHandler(this.Payments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymenthistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internetServiceProviderDBDataSet5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private InternetServiceProviderDBDataSet5 internetServiceProviderDBDataSet5;
        private System.Windows.Forms.BindingSource paymenthistoryBindingSource;
        private InternetServiceProviderDBDataSet5TableAdapters.payment_historyTableAdapter payment_historyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn abonentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentmethodDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}