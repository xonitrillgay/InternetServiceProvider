namespace InternetServiceProvider
{
    partial class Technician_assignments
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
            this.internetServiceProviderDBDataSet4 = new InternetServiceProvider.InternetServiceProviderDBDataSet4();
            this.technicianassignmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.technician_assignmentsTableAdapter = new InternetServiceProvider.InternetServiceProviderDBDataSet4TableAdapters.technician_assignmentsTableAdapter();
            this.assignmentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.technicianidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assigneddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.completiondateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internetServiceProviderDBDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technicianassignmentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.assignmentidDataGridViewTextBoxColumn,
            this.ticketidDataGridViewTextBoxColumn,
            this.technicianidDataGridViewTextBoxColumn,
            this.assigneddateDataGridViewTextBoxColumn,
            this.completiondateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.technicianassignmentsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 90);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(800, 360);
            this.dataGridView1.TabIndex = 0;
            // 
            // internetServiceProviderDBDataSet4
            // 
            this.internetServiceProviderDBDataSet4.DataSetName = "InternetServiceProviderDBDataSet4";
            this.internetServiceProviderDBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // technicianassignmentsBindingSource
            // 
            this.technicianassignmentsBindingSource.DataMember = "technician_assignments";
            this.technicianassignmentsBindingSource.DataSource = this.internetServiceProviderDBDataSet4;
            // 
            // technician_assignmentsTableAdapter
            // 
            this.technician_assignmentsTableAdapter.ClearBeforeFill = true;
            // 
            // assignmentidDataGridViewTextBoxColumn
            // 
            this.assignmentidDataGridViewTextBoxColumn.DataPropertyName = "assignment_id";
            this.assignmentidDataGridViewTextBoxColumn.HeaderText = "assignment_id";
            this.assignmentidDataGridViewTextBoxColumn.Name = "assignmentidDataGridViewTextBoxColumn";
            this.assignmentidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ticketidDataGridViewTextBoxColumn
            // 
            this.ticketidDataGridViewTextBoxColumn.DataPropertyName = "ticket_id";
            this.ticketidDataGridViewTextBoxColumn.HeaderText = "ticket_id";
            this.ticketidDataGridViewTextBoxColumn.Name = "ticketidDataGridViewTextBoxColumn";
            // 
            // technicianidDataGridViewTextBoxColumn
            // 
            this.technicianidDataGridViewTextBoxColumn.DataPropertyName = "technician_id";
            this.technicianidDataGridViewTextBoxColumn.HeaderText = "technician_id";
            this.technicianidDataGridViewTextBoxColumn.Name = "technicianidDataGridViewTextBoxColumn";
            // 
            // assigneddateDataGridViewTextBoxColumn
            // 
            this.assigneddateDataGridViewTextBoxColumn.DataPropertyName = "assigned_date";
            this.assigneddateDataGridViewTextBoxColumn.HeaderText = "assigned_date";
            this.assigneddateDataGridViewTextBoxColumn.Name = "assigneddateDataGridViewTextBoxColumn";
            // 
            // completiondateDataGridViewTextBoxColumn
            // 
            this.completiondateDataGridViewTextBoxColumn.DataPropertyName = "completion_date";
            this.completiondateDataGridViewTextBoxColumn.HeaderText = "completion_date";
            this.completiondateDataGridViewTextBoxColumn.Name = "completiondateDataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(215, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Призначення техніків";
            // 
            // Technician_assignments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Technician_assignments";
            this.Text = "Technician_assignments";
            this.Load += new System.EventHandler(this.Technician_assignments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internetServiceProviderDBDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technicianassignmentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private InternetServiceProviderDBDataSet4 internetServiceProviderDBDataSet4;
        private System.Windows.Forms.BindingSource technicianassignmentsBindingSource;
        private InternetServiceProviderDBDataSet4TableAdapters.technician_assignmentsTableAdapter technician_assignmentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn assignmentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn technicianidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assigneddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn completiondateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}