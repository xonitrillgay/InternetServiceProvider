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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Technician_assignments));
            this.dataGridViewAssignments = new System.Windows.Forms.DataGridView();
            this.assignmentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.technicianidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assigneddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.completiondateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.technicianassignmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.internetServiceProviderDBDataSet4 = new InternetServiceProvider.InternetServiceProviderDBDataSet4();
            this.technician_assignmentsTableAdapter = new InternetServiceProvider.InternetServiceProviderDBDataSet4TableAdapters.technician_assignmentsTableAdapter();
            this.comboBoxTicket = new System.Windows.Forms.ComboBox();
            this.labelTicket = new System.Windows.Forms.Label();
            this.labelTechnician = new System.Windows.Forms.Label();
            this.labelAssignedDate = new System.Windows.Forms.Label();
            this.comboBoxTechnicians = new System.Windows.Forms.ComboBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.dateTimePickerAssignedDate = new System.Windows.Forms.DateTimePicker();
            this.pictureBoxClear = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelAssignments = new System.Windows.Forms.Label();
            this.buttonComplete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssignments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technicianassignmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internetServiceProviderDBDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClear)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewAssignments
            // 
            this.dataGridViewAssignments.AllowUserToAddRows = false;
            this.dataGridViewAssignments.AllowUserToDeleteRows = false;
            this.dataGridViewAssignments.AllowUserToResizeColumns = false;
            this.dataGridViewAssignments.AllowUserToResizeRows = false;
            this.dataGridViewAssignments.AutoGenerateColumns = false;
            this.dataGridViewAssignments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAssignments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.assignmentidDataGridViewTextBoxColumn,
            this.ticketidDataGridViewTextBoxColumn,
            this.technicianidDataGridViewTextBoxColumn,
            this.assigneddateDataGridViewTextBoxColumn,
            this.completiondateDataGridViewTextBoxColumn});
            this.dataGridViewAssignments.DataSource = this.technicianassignmentsBindingSource;
            this.dataGridViewAssignments.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewAssignments.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAssignments.MultiSelect = false;
            this.dataGridViewAssignments.Name = "dataGridViewAssignments";
            this.dataGridViewAssignments.RowHeadersVisible = false;
            this.dataGridViewAssignments.Size = new System.Drawing.Size(486, 450);
            this.dataGridViewAssignments.TabIndex = 0;
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
            // technicianassignmentsBindingSource
            // 
            this.technicianassignmentsBindingSource.DataMember = "technician_assignments";
            this.technicianassignmentsBindingSource.DataSource = this.internetServiceProviderDBDataSet4;
            // 
            // internetServiceProviderDBDataSet4
            // 
            this.internetServiceProviderDBDataSet4.DataSetName = "InternetServiceProviderDBDataSet4";
            this.internetServiceProviderDBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // technician_assignmentsTableAdapter
            // 
            this.technician_assignmentsTableAdapter.ClearBeforeFill = true;
            // 
            // comboBoxTicket
            // 
            this.comboBoxTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxTicket.FormattingEnabled = true;
            this.comboBoxTicket.Location = new System.Drawing.Point(17, 46);
            this.comboBoxTicket.Name = "comboBoxTicket";
            this.comboBoxTicket.Size = new System.Drawing.Size(345, 26);
            this.comboBoxTicket.TabIndex = 6;
            // 
            // labelTicket
            // 
            this.labelTicket.AutoSize = true;
            this.labelTicket.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTicket.Location = new System.Drawing.Point(13, 20);
            this.labelTicket.Name = "labelTicket";
            this.labelTicket.Size = new System.Drawing.Size(167, 23);
            this.labelTicket.TabIndex = 7;
            this.labelTicket.Text = "Запит абонента";
            // 
            // labelTechnician
            // 
            this.labelTechnician.AutoSize = true;
            this.labelTechnician.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTechnician.Location = new System.Drawing.Point(13, 89);
            this.labelTechnician.Name = "labelTechnician";
            this.labelTechnician.Size = new System.Drawing.Size(187, 23);
            this.labelTechnician.TabIndex = 8;
            this.labelTechnician.Text = "Технічний фахівець";
            // 
            // labelAssignedDate
            // 
            this.labelAssignedDate.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAssignedDate.Location = new System.Drawing.Point(13, 156);
            this.labelAssignedDate.Name = "labelAssignedDate";
            this.labelAssignedDate.Size = new System.Drawing.Size(319, 51);
            this.labelAssignedDate.TabIndex = 9;
            this.labelAssignedDate.Text = "Дата призначення запиту до виконання";
            // 
            // comboBoxTechnicians
            // 
            this.comboBoxTechnicians.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxTechnicians.FormattingEnabled = true;
            this.comboBoxTechnicians.Location = new System.Drawing.Point(17, 115);
            this.comboBoxTechnicians.Name = "comboBoxTechnicians";
            this.comboBoxTechnicians.Size = new System.Drawing.Size(345, 26);
            this.comboBoxTechnicians.TabIndex = 10;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreate.Location = new System.Drawing.Point(17, 251);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(126, 31);
            this.buttonCreate.TabIndex = 11;
            this.buttonCreate.Text = "Додати +";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdate.Location = new System.Drawing.Point(149, 251);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(126, 31);
            this.buttonUpdate.TabIndex = 13;
            this.buttonUpdate.Text = "Змінити ⟳";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // dateTimePickerAssignedDate
            // 
            this.dateTimePickerAssignedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerAssignedDate.Location = new System.Drawing.Point(17, 210);
            this.dateTimePickerAssignedDate.Name = "dateTimePickerAssignedDate";
            this.dateTimePickerAssignedDate.Size = new System.Drawing.Size(345, 24);
            this.dateTimePickerAssignedDate.TabIndex = 14;
            // 
            // pictureBoxClear
            // 
            this.pictureBoxClear.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClear.Image")));
            this.pictureBoxClear.Location = new System.Drawing.Point(300, 251);
            this.pictureBoxClear.Name = "pictureBoxClear";
            this.pictureBoxClear.Size = new System.Drawing.Size(47, 50);
            this.pictureBoxClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClear.TabIndex = 15;
            this.pictureBoxClear.TabStop = false;
            this.pictureBoxClear.Click += new System.EventHandler(this.pictureBoxClear_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dateTimePickerAssignedDate);
            this.panel1.Controls.Add(this.buttonUpdate);
            this.panel1.Controls.Add(this.buttonCreate);
            this.panel1.Controls.Add(this.pictureBoxClear);
            this.panel1.Controls.Add(this.comboBoxTechnicians);
            this.panel1.Controls.Add(this.labelAssignedDate);
            this.panel1.Controls.Add(this.labelTechnician);
            this.panel1.Controls.Add(this.labelTicket);
            this.panel1.Controls.Add(this.comboBoxTicket);
            this.panel1.Location = new System.Drawing.Point(497, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 325);
            this.panel1.TabIndex = 16;
            // 
            // labelAssignments
            // 
            this.labelAssignments.AutoSize = true;
            this.labelAssignments.Font = new System.Drawing.Font("Georgia", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAssignments.Location = new System.Drawing.Point(533, 18);
            this.labelAssignments.Name = "labelAssignments";
            this.labelAssignments.Size = new System.Drawing.Size(313, 29);
            this.labelAssignments.TabIndex = 17;
            this.labelAssignments.Text = "Призначення техніків";
            // 
            // buttonComplete
            // 
            this.buttonComplete.BackColor = System.Drawing.Color.LightGreen;
            this.buttonComplete.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonComplete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonComplete.Location = new System.Drawing.Point(539, 396);
            this.buttonComplete.Name = "buttonComplete";
            this.buttonComplete.Size = new System.Drawing.Size(307, 33);
            this.buttonComplete.TabIndex = 18;
            this.buttonComplete.Text = "Позначити, як завершене ✔";
            this.buttonComplete.UseVisualStyleBackColor = false;
            this.buttonComplete.Click += new System.EventHandler(this.buttonComplete_Click);
            // 
            // Technician_assignments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 450);
            this.Controls.Add(this.buttonComplete);
            this.Controls.Add(this.labelAssignments);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewAssignments);
            this.Name = "Technician_assignments";
            this.Text = "Призначення техніків";
            this.Load += new System.EventHandler(this.Technician_assignments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssignments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technicianassignmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internetServiceProviderDBDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClear)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAssignments;
        private InternetServiceProviderDBDataSet4 internetServiceProviderDBDataSet4;
        private System.Windows.Forms.BindingSource technicianassignmentsBindingSource;
        private InternetServiceProviderDBDataSet4TableAdapters.technician_assignmentsTableAdapter technician_assignmentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn assignmentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn technicianidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assigneddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn completiondateDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBoxTicket;
        private System.Windows.Forms.Label labelTicket;
        private System.Windows.Forms.Label labelTechnician;
        private System.Windows.Forms.Label labelAssignedDate;
        private System.Windows.Forms.ComboBox comboBoxTechnicians;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.DateTimePicker dateTimePickerAssignedDate;
        private System.Windows.Forms.PictureBox pictureBoxClear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelAssignments;
        private System.Windows.Forms.Button buttonComplete;
    }
}