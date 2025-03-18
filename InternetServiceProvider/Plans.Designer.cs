namespace InternetServiceProvider
{
    partial class Plans
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
            this.planidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plannameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthlyfeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.internetServiceProviderDBDataSet2 = new InternetServiceProvider.InternetServiceProviderDBDataSet2();
            this.plansTableAdapter = new InternetServiceProvider.InternetServiceProviderDBDataSet2TableAdapters.plansTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plansBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internetServiceProviderDBDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.planidDataGridViewTextBoxColumn,
            this.plannameDataGridViewTextBoxColumn,
            this.monthlyfeeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.plansBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 90);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(800, 360);
            this.dataGridView1.TabIndex = 0;
            // 
            // planidDataGridViewTextBoxColumn
            // 
            this.planidDataGridViewTextBoxColumn.DataPropertyName = "plan_id";
            this.planidDataGridViewTextBoxColumn.HeaderText = "plan_id";
            this.planidDataGridViewTextBoxColumn.Name = "planidDataGridViewTextBoxColumn";
            this.planidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // plannameDataGridViewTextBoxColumn
            // 
            this.plannameDataGridViewTextBoxColumn.DataPropertyName = "plan_name";
            this.plannameDataGridViewTextBoxColumn.HeaderText = "plan_name";
            this.plannameDataGridViewTextBoxColumn.Name = "plannameDataGridViewTextBoxColumn";
            this.plannameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // monthlyfeeDataGridViewTextBoxColumn
            // 
            this.monthlyfeeDataGridViewTextBoxColumn.DataPropertyName = "monthly_fee";
            this.monthlyfeeDataGridViewTextBoxColumn.HeaderText = "monthly_fee";
            this.monthlyfeeDataGridViewTextBoxColumn.Name = "monthlyfeeDataGridViewTextBoxColumn";
            this.monthlyfeeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // plansBindingSource
            // 
            this.plansBindingSource.DataMember = "plans";
            this.plansBindingSource.DataSource = this.internetServiceProviderDBDataSet2;
            // 
            // internetServiceProviderDBDataSet2
            // 
            this.internetServiceProviderDBDataSet2.DataSetName = "InternetServiceProviderDBDataSet2";
            this.internetServiceProviderDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // plansTableAdapter
            // 
            this.plansTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(280, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Інтернет-плани";
            // 
            // Plans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Plans";
            this.Text = "Інтернет-плани";
            this.Load += new System.EventHandler(this.Plans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plansBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internetServiceProviderDBDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private InternetServiceProviderDBDataSet2 internetServiceProviderDBDataSet2;
        private System.Windows.Forms.BindingSource plansBindingSource;
        private InternetServiceProviderDBDataSet2TableAdapters.plansTableAdapter plansTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn planidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plannameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthlyfeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}