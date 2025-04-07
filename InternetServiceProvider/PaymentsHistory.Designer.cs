namespace InternetServiceProvider
{
    partial class PaymentsHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentsHistory));
            this.pictureBoxClear = new System.Windows.Forms.PictureBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonStatus = new System.Windows.Forms.RadioButton();
            this.labelPaymentMethod = new System.Windows.Forms.Label();
            this.labelTicketDescription = new System.Windows.Forms.Label();
            this.labelPaymentDate = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelAbonent = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.comboBoxPaymentMethod = new System.Windows.Forms.ComboBox();
            this.comboBoxTicketDescription = new System.Windows.Forms.ComboBox();
            this.dateTimePickerPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxAbonent = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.paymentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abonentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentmethodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymenthistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentHistoryDataSet = new InternetServiceProvider.PaymentHistoryDataSet();
            this.payment_historyTableAdapter = new InternetServiceProvider.PaymentHistoryDataSetTableAdapters.payment_historyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClear)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymenthistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentHistoryDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxClear
            // 
            this.pictureBoxClear.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClear.Image")));
            this.pictureBoxClear.Location = new System.Drawing.Point(772, 350);
            this.pictureBoxClear.Name = "pictureBoxClear";
            this.pictureBoxClear.Size = new System.Drawing.Size(36, 36);
            this.pictureBoxClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClear.TabIndex = 37;
            this.pictureBoxClear.TabStop = false;
            this.pictureBoxClear.Click += new System.EventHandler(this.pictureBoxClear_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdate.Location = new System.Drawing.Point(606, 391);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(141, 35);
            this.buttonUpdate.TabIndex = 36;
            this.buttonUpdate.Text = "Оновити";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreate.Location = new System.Drawing.Point(606, 350);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(141, 35);
            this.buttonCreate.TabIndex = 35;
            this.buttonCreate.Text = "Створити";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.radioButtonStatus);
            this.panel1.Controls.Add(this.labelPaymentMethod);
            this.panel1.Controls.Add(this.labelTicketDescription);
            this.panel1.Controls.Add(this.labelPaymentDate);
            this.panel1.Controls.Add(this.labelAmount);
            this.panel1.Controls.Add(this.labelAbonent);
            this.panel1.Controls.Add(this.textBoxAmount);
            this.panel1.Controls.Add(this.comboBoxPaymentMethod);
            this.panel1.Controls.Add(this.comboBoxTicketDescription);
            this.panel1.Controls.Add(this.dateTimePickerPaymentDate);
            this.panel1.Controls.Add(this.comboBoxAbonent);
            this.panel1.Location = new System.Drawing.Point(579, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 332);
            this.panel1.TabIndex = 34;
            // 
            // radioButtonStatus
            // 
            this.radioButtonStatus.AutoSize = true;
            this.radioButtonStatus.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonStatus.Location = new System.Drawing.Point(7, 159);
            this.radioButtonStatus.Name = "radioButtonStatus";
            this.radioButtonStatus.Size = new System.Drawing.Size(96, 22);
            this.radioButtonStatus.TabIndex = 18;
            this.radioButtonStatus.TabStop = true;
            this.radioButtonStatus.Text = "Сплачено";
            this.radioButtonStatus.UseVisualStyleBackColor = true;
            this.radioButtonStatus.CheckedChanged += new System.EventHandler(this.radioButtonStatus_CheckedChanged);
            // 
            // labelPaymentMethod
            // 
            this.labelPaymentMethod.AutoSize = true;
            this.labelPaymentMethod.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaymentMethod.Location = new System.Drawing.Point(3, 269);
            this.labelPaymentMethod.Name = "labelPaymentMethod";
            this.labelPaymentMethod.Size = new System.Drawing.Size(150, 23);
            this.labelPaymentMethod.TabIndex = 17;
            this.labelPaymentMethod.Text = "Метод оплати";
            // 
            // labelTicketDescription
            // 
            this.labelTicketDescription.AutoSize = true;
            this.labelTicketDescription.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTicketDescription.Location = new System.Drawing.Point(3, 210);
            this.labelTicketDescription.Name = "labelTicketDescription";
            this.labelTicketDescription.Size = new System.Drawing.Size(237, 23);
            this.labelTicketDescription.TabIndex = 16;
            this.labelTicketDescription.Text = "Опис сплаченого запиту";
            // 
            // labelPaymentDate
            // 
            this.labelPaymentDate.AutoSize = true;
            this.labelPaymentDate.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaymentDate.Location = new System.Drawing.Point(3, 132);
            this.labelPaymentDate.Name = "labelPaymentDate";
            this.labelPaymentDate.Size = new System.Drawing.Size(257, 23);
            this.labelPaymentDate.TabIndex = 15;
            this.labelPaymentDate.Text = "Дата здійснення платежу";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmount.Location = new System.Drawing.Point(3, 73);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(58, 23);
            this.labelAmount.TabIndex = 14;
            this.labelAmount.Text = "Сума";
            // 
            // labelAbonent
            // 
            this.labelAbonent.AutoSize = true;
            this.labelAbonent.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAbonent.Location = new System.Drawing.Point(3, 10);
            this.labelAbonent.Name = "labelAbonent";
            this.labelAbonent.Size = new System.Drawing.Size(91, 23);
            this.labelAbonent.TabIndex = 13;
            this.labelAbonent.Text = "Абонент";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAmount.Location = new System.Drawing.Point(7, 99);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(253, 20);
            this.textBoxAmount.TabIndex = 12;
            // 
            // comboBoxPaymentMethod
            // 
            this.comboBoxPaymentMethod.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxPaymentMethod.FormattingEnabled = true;
            this.comboBoxPaymentMethod.Location = new System.Drawing.Point(7, 295);
            this.comboBoxPaymentMethod.Name = "comboBoxPaymentMethod";
            this.comboBoxPaymentMethod.Size = new System.Drawing.Size(253, 22);
            this.comboBoxPaymentMethod.TabIndex = 11;
            // 
            // comboBoxTicketDescription
            // 
            this.comboBoxTicketDescription.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxTicketDescription.FormattingEnabled = true;
            this.comboBoxTicketDescription.Location = new System.Drawing.Point(7, 236);
            this.comboBoxTicketDescription.Name = "comboBoxTicketDescription";
            this.comboBoxTicketDescription.Size = new System.Drawing.Size(253, 22);
            this.comboBoxTicketDescription.TabIndex = 10;
            this.comboBoxTicketDescription.SelectedIndexChanged += new System.EventHandler(this.comboBoxTicketDescription_SelectedIndexChanged);
            // 
            // dateTimePickerPaymentDate
            // 
            this.dateTimePickerPaymentDate.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerPaymentDate.Location = new System.Drawing.Point(7, 187);
            this.dateTimePickerPaymentDate.Name = "dateTimePickerPaymentDate";
            this.dateTimePickerPaymentDate.Size = new System.Drawing.Size(253, 20);
            this.dateTimePickerPaymentDate.TabIndex = 9;
            // 
            // comboBoxAbonent
            // 
            this.comboBoxAbonent.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxAbonent.FormattingEnabled = true;
            this.comboBoxAbonent.Location = new System.Drawing.Point(7, 39);
            this.comboBoxAbonent.Name = "comboBoxAbonent";
            this.comboBoxAbonent.Size = new System.Drawing.Size(253, 22);
            this.comboBoxAbonent.TabIndex = 8;
            this.comboBoxAbonent.SelectedIndexChanged += new System.EventHandler(this.comboBoxAbonent_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(753, 392);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 34);
            this.button2.TabIndex = 33;
            this.button2.Text = "Звіт";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.paymentidDataGridViewTextBoxColumn,
            this.abonentidDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.paymentdateDataGridViewTextBoxColumn,
            this.paymentmethodDataGridViewTextBoxColumn,
            this.ticketidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.paymenthistoryBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(573, 450);
            this.dataGridView1.TabIndex = 38;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // paymentdateDataGridViewTextBoxColumn
            // 
            this.paymentdateDataGridViewTextBoxColumn.DataPropertyName = "payment_date";
            this.paymentdateDataGridViewTextBoxColumn.HeaderText = "payment_date";
            this.paymentdateDataGridViewTextBoxColumn.Name = "paymentdateDataGridViewTextBoxColumn";
            // 
            // paymentmethodDataGridViewTextBoxColumn
            // 
            this.paymentmethodDataGridViewTextBoxColumn.DataPropertyName = "payment_method";
            this.paymentmethodDataGridViewTextBoxColumn.HeaderText = "payment_method";
            this.paymentmethodDataGridViewTextBoxColumn.Name = "paymentmethodDataGridViewTextBoxColumn";
            // 
            // ticketidDataGridViewTextBoxColumn
            // 
            this.ticketidDataGridViewTextBoxColumn.DataPropertyName = "ticket_id";
            this.ticketidDataGridViewTextBoxColumn.HeaderText = "ticket_id";
            this.ticketidDataGridViewTextBoxColumn.Name = "ticketidDataGridViewTextBoxColumn";
            // 
            // paymenthistoryBindingSource
            // 
            this.paymenthistoryBindingSource.DataMember = "payment_history";
            this.paymenthistoryBindingSource.DataSource = this.paymentHistoryDataSet;
            // 
            // paymentHistoryDataSet
            // 
            this.paymentHistoryDataSet.DataSetName = "PaymentHistoryDataSet";
            this.paymentHistoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // payment_historyTableAdapter
            // 
            this.payment_historyTableAdapter.ClearBeforeFill = true;
            // 
            // PaymentsHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBoxClear);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Name = "PaymentsHistory";
            this.Text = "Історія платежів";
            this.Load += new System.EventHandler(this.PaymentsHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClear)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymenthistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentHistoryDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxClear;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonStatus;
        private System.Windows.Forms.Label labelPaymentMethod;
        private System.Windows.Forms.Label labelTicketDescription;
        private System.Windows.Forms.Label labelPaymentDate;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelAbonent;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.ComboBox comboBoxPaymentMethod;
        private System.Windows.Forms.ComboBox comboBoxTicketDescription;
        private System.Windows.Forms.DateTimePicker dateTimePickerPaymentDate;
        private System.Windows.Forms.ComboBox comboBoxAbonent;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PaymentHistoryDataSet paymentHistoryDataSet;
        private System.Windows.Forms.BindingSource paymenthistoryBindingSource;
        private PaymentHistoryDataSetTableAdapters.payment_historyTableAdapter payment_historyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn abonentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentmethodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketidDataGridViewTextBoxColumn;
    }
}