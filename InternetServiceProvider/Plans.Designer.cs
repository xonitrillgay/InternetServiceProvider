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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Plans));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.planidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plannameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthlyfeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.internetServiceProviderDBDataSet2 = new InternetServiceProvider.InternetServiceProviderDBDataSet2();
            this.plansTableAdapter = new InternetServiceProvider.InternetServiceProviderDBDataSet2TableAdapters.plansTableAdapter();
            this.textBoxPlanName = new System.Windows.Forms.TextBox();
            this.textBoxMonthlyFee = new System.Windows.Forms.TextBox();
            this.labelPlanName = new System.Windows.Forms.Label();
            this.labelMonthlyFee = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.internetServiceProviderDBDataSet3 = new InternetServiceProvider.InternetServiceProviderDBDataSet3();
            this.internetServiceProviderDBDataSet5 = new InternetServiceProvider.InternetServiceProviderDBDataSet5();
            this.internetServiceProviderDBDataSet6 = new InternetServiceProvider.InternetServiceProviderDBDataSet6();
            this.dataGridViewAbonents = new System.Windows.Forms.DataGridView();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abonentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.abonentsTableAdapter = new InternetServiceProvider.InternetServiceProviderDBDataSet6TableAdapters.abonentsTableAdapter();
            this.labelAbonents = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plansBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internetServiceProviderDBDataSet2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.internetServiceProviderDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internetServiceProviderDBDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internetServiceProviderDBDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAbonents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.planidDataGridViewTextBoxColumn,
            this.plannameDataGridViewTextBoxColumn,
            this.monthlyfeeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.plansBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(304, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            // textBoxPlanName
            // 
            this.textBoxPlanName.Location = new System.Drawing.Point(327, 41);
            this.textBoxPlanName.Name = "textBoxPlanName";
            this.textBoxPlanName.Size = new System.Drawing.Size(180, 20);
            this.textBoxPlanName.TabIndex = 2;
            // 
            // textBoxMonthlyFee
            // 
            this.textBoxMonthlyFee.Location = new System.Drawing.Point(537, 41);
            this.textBoxMonthlyFee.Name = "textBoxMonthlyFee";
            this.textBoxMonthlyFee.Size = new System.Drawing.Size(180, 20);
            this.textBoxMonthlyFee.TabIndex = 3;
            // 
            // labelPlanName
            // 
            this.labelPlanName.AutoSize = true;
            this.labelPlanName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlanName.Location = new System.Drawing.Point(324, 12);
            this.labelPlanName.Name = "labelPlanName";
            this.labelPlanName.Size = new System.Drawing.Size(175, 20);
            this.labelPlanName.TabIndex = 4;
            this.labelPlanName.Text = "Назва інтернет-плану";
            // 
            // labelMonthlyFee
            // 
            this.labelMonthlyFee.AutoSize = true;
            this.labelMonthlyFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMonthlyFee.Location = new System.Drawing.Point(534, 12);
            this.labelMonthlyFee.Name = "labelMonthlyFee";
            this.labelMonthlyFee.Size = new System.Drawing.Size(106, 20);
            this.labelMonthlyFee.TabIndex = 5;
            this.labelMonthlyFee.Text = "Вартість/міс.";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonUpdate);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.buttonCreate);
            this.panel1.Location = new System.Drawing.Point(327, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 71);
            this.panel1.TabIndex = 4;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdate.Location = new System.Drawing.Point(306, 18);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(121, 32);
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Text = "Змінити";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(165, 18);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(121, 32);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Видалити";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreate.Location = new System.Drawing.Point(21, 18);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(121, 32);
            this.buttonCreate.TabIndex = 0;
            this.buttonCreate.Text = "Додати";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // internetServiceProviderDBDataSet3
            // 
            this.internetServiceProviderDBDataSet3.DataSetName = "InternetServiceProviderDBDataSet3";
            this.internetServiceProviderDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // internetServiceProviderDBDataSet5
            // 
            this.internetServiceProviderDBDataSet5.DataSetName = "InternetServiceProviderDBDataSet5";
            this.internetServiceProviderDBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // internetServiceProviderDBDataSet6
            // 
            this.internetServiceProviderDBDataSet6.DataSetName = "InternetServiceProviderDBDataSet6";
            this.internetServiceProviderDBDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewAbonents
            // 
            this.dataGridViewAbonents.AllowUserToAddRows = false;
            this.dataGridViewAbonents.AllowUserToDeleteRows = false;
            this.dataGridViewAbonents.AllowUserToResizeColumns = false;
            this.dataGridViewAbonents.AllowUserToResizeRows = false;
            this.dataGridViewAbonents.AutoGenerateColumns = false;
            this.dataGridViewAbonents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAbonents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dataGridViewAbonents.DataSource = this.abonentsBindingSource;
            this.dataGridViewAbonents.Location = new System.Drawing.Point(310, 218);
            this.dataGridViewAbonents.MultiSelect = false;
            this.dataGridViewAbonents.Name = "dataGridViewAbonents";
            this.dataGridViewAbonents.RowHeadersVisible = false;
            this.dataGridViewAbonents.Size = new System.Drawing.Size(485, 232);
            this.dataGridViewAbonents.TabIndex = 6;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "first_name";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "last_name";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // abonentsBindingSource
            // 
            this.abonentsBindingSource.DataMember = "abonents";
            this.abonentsBindingSource.DataSource = this.internetServiceProviderDBDataSet6;
            // 
            // abonentsTableAdapter
            // 
            this.abonentsTableAdapter.ClearBeforeFill = true;
            // 
            // labelAbonents
            // 
            this.labelAbonents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAbonents.Location = new System.Drawing.Point(346, 181);
            this.labelAbonents.Name = "labelAbonents";
            this.labelAbonents.Size = new System.Drawing.Size(413, 34);
            this.labelAbonents.TabIndex = 7;
            this.labelAbonents.Text = "Список абонентів для заданого тарифного плану";
            this.labelAbonents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(740, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Plans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelAbonents);
            this.Controls.Add(this.dataGridViewAbonents);
            this.Controls.Add(this.textBoxMonthlyFee);
            this.Controls.Add(this.labelMonthlyFee);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelPlanName);
            this.Controls.Add(this.textBoxPlanName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Plans";
            this.Text = "Інтернет-плани";
            this.Load += new System.EventHandler(this.Plans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plansBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internetServiceProviderDBDataSet2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.internetServiceProviderDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internetServiceProviderDBDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internetServiceProviderDBDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAbonents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.TextBox textBoxPlanName;
        private System.Windows.Forms.TextBox textBoxMonthlyFee;
        private System.Windows.Forms.Label labelPlanName;
        private System.Windows.Forms.Label labelMonthlyFee;
        private System.Windows.Forms.Panel panel1;
        private InternetServiceProviderDBDataSet3 internetServiceProviderDBDataSet3;
        private InternetServiceProviderDBDataSet5 internetServiceProviderDBDataSet5;
        private InternetServiceProviderDBDataSet6 internetServiceProviderDBDataSet6;
        private System.Windows.Forms.DataGridView dataGridViewAbonents;
        private System.Windows.Forms.BindingSource abonentsBindingSource;
        private InternetServiceProviderDBDataSet6TableAdapters.abonentsTableAdapter abonentsTableAdapter;
        private System.Windows.Forms.Label labelAbonents;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}