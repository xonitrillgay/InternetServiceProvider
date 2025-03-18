namespace InternetServiceProvider
{
    partial class Support_tickets
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
            this.ticketidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abonentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issuedescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creationdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closuredateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supportticketsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.internetServiceProviderDBDataSet3 = new InternetServiceProvider.InternetServiceProviderDBDataSet3();
            this.support_ticketsTableAdapter = new InternetServiceProvider.InternetServiceProviderDBDataSet3TableAdapters.support_ticketsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supportticketsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internetServiceProviderDBDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ticketidDataGridViewTextBoxColumn,
            this.abonentidDataGridViewTextBoxColumn,
            this.issuedescriptionDataGridViewTextBoxColumn,
            this.ticketstatusDataGridViewTextBoxColumn,
            this.creationdateDataGridViewTextBoxColumn,
            this.closuredateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.supportticketsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 90);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(800, 360);
            this.dataGridView1.TabIndex = 0;
            // 
            // ticketidDataGridViewTextBoxColumn
            // 
            this.ticketidDataGridViewTextBoxColumn.DataPropertyName = "ticket_id";
            this.ticketidDataGridViewTextBoxColumn.HeaderText = "ticket_id";
            this.ticketidDataGridViewTextBoxColumn.Name = "ticketidDataGridViewTextBoxColumn";
            this.ticketidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // abonentidDataGridViewTextBoxColumn
            // 
            this.abonentidDataGridViewTextBoxColumn.DataPropertyName = "abonent_id";
            this.abonentidDataGridViewTextBoxColumn.HeaderText = "abonent_id";
            this.abonentidDataGridViewTextBoxColumn.Name = "abonentidDataGridViewTextBoxColumn";
            // 
            // issuedescriptionDataGridViewTextBoxColumn
            // 
            this.issuedescriptionDataGridViewTextBoxColumn.DataPropertyName = "issue_description";
            this.issuedescriptionDataGridViewTextBoxColumn.HeaderText = "issue_description";
            this.issuedescriptionDataGridViewTextBoxColumn.Name = "issuedescriptionDataGridViewTextBoxColumn";
            // 
            // ticketstatusDataGridViewTextBoxColumn
            // 
            this.ticketstatusDataGridViewTextBoxColumn.DataPropertyName = "ticket_status";
            this.ticketstatusDataGridViewTextBoxColumn.HeaderText = "ticket_status";
            this.ticketstatusDataGridViewTextBoxColumn.Name = "ticketstatusDataGridViewTextBoxColumn";
            // 
            // creationdateDataGridViewTextBoxColumn
            // 
            this.creationdateDataGridViewTextBoxColumn.DataPropertyName = "creation_date";
            this.creationdateDataGridViewTextBoxColumn.HeaderText = "creation_date";
            this.creationdateDataGridViewTextBoxColumn.Name = "creationdateDataGridViewTextBoxColumn";
            // 
            // closuredateDataGridViewTextBoxColumn
            // 
            this.closuredateDataGridViewTextBoxColumn.DataPropertyName = "closure_date";
            this.closuredateDataGridViewTextBoxColumn.HeaderText = "closure_date";
            this.closuredateDataGridViewTextBoxColumn.Name = "closuredateDataGridViewTextBoxColumn";
            // 
            // supportticketsBindingSource
            // 
            this.supportticketsBindingSource.DataMember = "support_tickets";
            this.supportticketsBindingSource.DataSource = this.internetServiceProviderDBDataSet3;
            // 
            // internetServiceProviderDBDataSet3
            // 
            this.internetServiceProviderDBDataSet3.DataSetName = "InternetServiceProviderDBDataSet3";
            this.internetServiceProviderDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // support_ticketsTableAdapter
            // 
            this.support_ticketsTableAdapter.ClearBeforeFill = true;
            // 
            // Support_tickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Support_tickets";
            this.Text = "Support_tickets";
            this.Load += new System.EventHandler(this.Support_tickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supportticketsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internetServiceProviderDBDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private InternetServiceProviderDBDataSet3 internetServiceProviderDBDataSet3;
        private System.Windows.Forms.BindingSource supportticketsBindingSource;
        private InternetServiceProviderDBDataSet3TableAdapters.support_ticketsTableAdapter support_ticketsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn abonentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn issuedescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creationdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn closuredateDataGridViewTextBoxColumn;
    }
}