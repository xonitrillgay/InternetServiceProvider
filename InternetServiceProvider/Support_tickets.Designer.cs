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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Support_tickets));
            this.dataGridViewTickets = new System.Windows.Forms.DataGridView();
            this.ticketidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abonentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issuedescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creationdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closuredateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supportticketsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.internetServiceProviderDBDataSet3 = new InternetServiceProvider.InternetServiceProviderDBDataSet3();
            this.support_ticketsTableAdapter = new InternetServiceProvider.InternetServiceProviderDBDataSet3TableAdapters.support_ticketsTableAdapter();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.labelAbonent = new System.Windows.Forms.Label();
            this.labelIssueDescription = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelCreationDate = new System.Windows.Forms.Label();
            this.labelClosureDate = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.dateTimePickerCreationDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerClosureDate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxClosureDate = new System.Windows.Forms.CheckBox();
            this.comboBoxAbonent = new System.Windows.Forms.ComboBox();
            this.textBoxIssueDescription = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxSearchByDate = new System.Windows.Forms.ComboBox();
            this.buttonResetSearch = new System.Windows.Forms.Button();
            this.labelSearchByDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supportticketsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internetServiceProviderDBDataSet3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTickets
            // 
            this.dataGridViewTickets.AllowUserToAddRows = false;
            this.dataGridViewTickets.AllowUserToDeleteRows = false;
            this.dataGridViewTickets.AllowUserToResizeColumns = false;
            this.dataGridViewTickets.AllowUserToResizeRows = false;
            this.dataGridViewTickets.AutoGenerateColumns = false;
            this.dataGridViewTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ticketidDataGridViewTextBoxColumn,
            this.abonentidDataGridViewTextBoxColumn,
            this.issuedescriptionDataGridViewTextBoxColumn,
            this.ticketstatusDataGridViewTextBoxColumn,
            this.creationdateDataGridViewTextBoxColumn,
            this.closuredateDataGridViewTextBoxColumn});
            this.dataGridViewTickets.DataSource = this.supportticketsBindingSource;
            this.dataGridViewTickets.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewTickets.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTickets.MultiSelect = false;
            this.dataGridViewTickets.Name = "dataGridViewTickets";
            this.dataGridViewTickets.RowHeadersVisible = false;
            this.dataGridViewTickets.Size = new System.Drawing.Size(604, 526);
            this.dataGridViewTickets.TabIndex = 0;
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
            // buttonCreate
            // 
            this.buttonCreate.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreate.Location = new System.Drawing.Point(639, 376);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(118, 32);
            this.buttonCreate.TabIndex = 1;
            this.buttonCreate.Text = "Створити";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(763, 376);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(118, 32);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Видалити";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdate.Location = new System.Drawing.Point(702, 414);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(118, 32);
            this.buttonUpdate.TabIndex = 3;
            this.buttonUpdate.Text = "Змінити";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // labelAbonent
            // 
            this.labelAbonent.AutoSize = true;
            this.labelAbonent.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAbonent.Location = new System.Drawing.Point(8, 13);
            this.labelAbonent.Name = "labelAbonent";
            this.labelAbonent.Size = new System.Drawing.Size(73, 18);
            this.labelAbonent.TabIndex = 9;
            this.labelAbonent.Text = "Абонент";
            // 
            // labelIssueDescription
            // 
            this.labelIssueDescription.AutoSize = true;
            this.labelIssueDescription.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIssueDescription.Location = new System.Drawing.Point(8, 40);
            this.labelIssueDescription.Name = "labelIssueDescription";
            this.labelIssueDescription.Size = new System.Drawing.Size(105, 18);
            this.labelIssueDescription.TabIndex = 10;
            this.labelIssueDescription.Text = "Опис запиту";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatus.Location = new System.Drawing.Point(8, 172);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(70, 18);
            this.labelStatus.TabIndex = 11;
            this.labelStatus.Text = "Статус";
            // 
            // labelCreationDate
            // 
            this.labelCreationDate.AutoSize = true;
            this.labelCreationDate.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCreationDate.Location = new System.Drawing.Point(8, 202);
            this.labelCreationDate.Name = "labelCreationDate";
            this.labelCreationDate.Size = new System.Drawing.Size(132, 18);
            this.labelCreationDate.TabIndex = 12;
            this.labelCreationDate.Text = "Дата створення";
            // 
            // labelClosureDate
            // 
            this.labelClosureDate.AutoSize = true;
            this.labelClosureDate.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClosureDate.Location = new System.Drawing.Point(8, 259);
            this.labelClosureDate.Name = "labelClosureDate";
            this.labelClosureDate.Size = new System.Drawing.Size(139, 18);
            this.labelClosureDate.TabIndex = 13;
            this.labelClosureDate.Text = "Дата завершення";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(119, 164);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(211, 26);
            this.comboBoxStatus.TabIndex = 14;
            // 
            // dateTimePickerCreationDate
            // 
            this.dateTimePickerCreationDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerCreationDate.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerCreationDate.Location = new System.Drawing.Point(11, 223);
            this.dateTimePickerCreationDate.Name = "dateTimePickerCreationDate";
            this.dateTimePickerCreationDate.Size = new System.Drawing.Size(170, 25);
            this.dateTimePickerCreationDate.TabIndex = 15;
            // 
            // dateTimePickerClosureDate
            // 
            this.dateTimePickerClosureDate.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerClosureDate.Location = new System.Drawing.Point(11, 308);
            this.dateTimePickerClosureDate.Name = "dateTimePickerClosureDate";
            this.dateTimePickerClosureDate.Size = new System.Drawing.Size(170, 25);
            this.dateTimePickerClosureDate.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.checkBoxClosureDate);
            this.panel1.Controls.Add(this.comboBoxAbonent);
            this.panel1.Controls.Add(this.textBoxIssueDescription);
            this.panel1.Controls.Add(this.dateTimePickerClosureDate);
            this.panel1.Controls.Add(this.labelIssueDescription);
            this.panel1.Controls.Add(this.labelAbonent);
            this.panel1.Controls.Add(this.dateTimePickerCreationDate);
            this.panel1.Controls.Add(this.labelCreationDate);
            this.panel1.Controls.Add(this.labelStatus);
            this.panel1.Controls.Add(this.comboBoxStatus);
            this.panel1.Controls.Add(this.labelClosureDate);
            this.panel1.Location = new System.Drawing.Point(614, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 347);
            this.panel1.TabIndex = 17;
            // 
            // checkBoxClosureDate
            // 
            this.checkBoxClosureDate.AutoSize = true;
            this.checkBoxClosureDate.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxClosureDate.Location = new System.Drawing.Point(11, 280);
            this.checkBoxClosureDate.Name = "checkBoxClosureDate";
            this.checkBoxClosureDate.Size = new System.Drawing.Size(103, 22);
            this.checkBoxClosureDate.TabIndex = 19;
            this.checkBoxClosureDate.Text = "Завершено";
            this.checkBoxClosureDate.UseVisualStyleBackColor = true;
            // 
            // comboBoxAbonent
            // 
            this.comboBoxAbonent.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxAbonent.FormattingEnabled = true;
            this.comboBoxAbonent.Location = new System.Drawing.Point(119, 5);
            this.comboBoxAbonent.Name = "comboBoxAbonent";
            this.comboBoxAbonent.Size = new System.Drawing.Size(211, 26);
            this.comboBoxAbonent.TabIndex = 18;
            // 
            // textBoxIssueDescription
            // 
            this.textBoxIssueDescription.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxIssueDescription.Location = new System.Drawing.Point(119, 34);
            this.textBoxIssueDescription.Multiline = true;
            this.textBoxIssueDescription.Name = "textBoxIssueDescription";
            this.textBoxIssueDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxIssueDescription.Size = new System.Drawing.Size(211, 124);
            this.textBoxIssueDescription.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(905, 376);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // comboBoxSearchByDate
            // 
            this.comboBoxSearchByDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSearchByDate.FormattingEnabled = true;
            this.comboBoxSearchByDate.Location = new System.Drawing.Point(614, 482);
            this.comboBoxSearchByDate.Name = "comboBoxSearchByDate";
            this.comboBoxSearchByDate.Size = new System.Drawing.Size(250, 32);
            this.comboBoxSearchByDate.TabIndex = 21;
            this.comboBoxSearchByDate.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearchByDate_SelectedIndexChanged);
            this.comboBoxSearchByDate.Click += new System.EventHandler(this.comboBoxSearchByDate_Click);
            // 
            // buttonResetSearch
            // 
            this.buttonResetSearch.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonResetSearch.Location = new System.Drawing.Point(870, 478);
            this.buttonResetSearch.Name = "buttonResetSearch";
            this.buttonResetSearch.Size = new System.Drawing.Size(81, 36);
            this.buttonResetSearch.TabIndex = 22;
            this.buttonResetSearch.Text = "Скинути";
            this.buttonResetSearch.UseVisualStyleBackColor = true;
            this.buttonResetSearch.Click += new System.EventHandler(this.buttonResetSearch_Click);
            // 
            // labelSearchByDate
            // 
            this.labelSearchByDate.AutoSize = true;
            this.labelSearchByDate.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSearchByDate.Location = new System.Drawing.Point(609, 452);
            this.labelSearchByDate.Name = "labelSearchByDate";
            this.labelSearchByDate.Size = new System.Drawing.Size(172, 27);
            this.labelSearchByDate.TabIndex = 23;
            this.labelSearchByDate.Text = "Фільтрувати за:";
            // 
            // Support_tickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 526);
            this.Controls.Add(this.labelSearchByDate);
            this.Controls.Add(this.buttonResetSearch);
            this.Controls.Add(this.comboBoxSearchByDate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.dataGridViewTickets);
            this.Name = "Support_tickets";
            this.Text = "Запити абонентів";
            this.Load += new System.EventHandler(this.Support_tickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supportticketsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internetServiceProviderDBDataSet3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTickets;
        private InternetServiceProviderDBDataSet3 internetServiceProviderDBDataSet3;
        private System.Windows.Forms.BindingSource supportticketsBindingSource;
        private InternetServiceProviderDBDataSet3TableAdapters.support_ticketsTableAdapter support_ticketsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn abonentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn issuedescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creationdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn closuredateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label labelAbonent;
        private System.Windows.Forms.Label labelIssueDescription;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelCreationDate;
        private System.Windows.Forms.Label labelClosureDate;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.DateTimePicker dateTimePickerCreationDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerClosureDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxIssueDescription;
        private System.Windows.Forms.ComboBox comboBoxAbonent;
        private System.Windows.Forms.CheckBox checkBoxClosureDate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxSearchByDate;
        private System.Windows.Forms.Button buttonResetSearch;
        private System.Windows.Forms.Label labelSearchByDate;
    }
}