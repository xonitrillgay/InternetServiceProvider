namespace InternetServiceProvider
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.UsersdataGridView = new System.Windows.Forms.DataGridView();
            this.iduserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginuserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passworduserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.internetServiceProviderDBDataSet10 = new InternetServiceProvider.InternetServiceProviderDBDataSet10();
            this.registerTableAdapter = new InternetServiceProvider.InternetServiceProviderDBDataSet10TableAdapters.registerTableAdapter();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.buttonUpdateRole = new System.Windows.Forms.Button();
            this.comboBoxNewRole = new System.Windows.Forms.ComboBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.roles = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.UsersdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internetServiceProviderDBDataSet10)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UsersdataGridView
            // 
            this.UsersdataGridView.AllowUserToAddRows = false;
            this.UsersdataGridView.AllowUserToDeleteRows = false;
            this.UsersdataGridView.AllowUserToResizeColumns = false;
            this.UsersdataGridView.AllowUserToResizeRows = false;
            this.UsersdataGridView.AutoGenerateColumns = false;
            this.UsersdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iduserDataGridViewTextBoxColumn,
            this.loginuserDataGridViewTextBoxColumn,
            this.passworduserDataGridViewTextBoxColumn,
            this.rolesDataGridViewTextBoxColumn});
            this.UsersdataGridView.DataSource = this.registerBindingSource;
            this.UsersdataGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.UsersdataGridView.Location = new System.Drawing.Point(0, 0);
            this.UsersdataGridView.MultiSelect = false;
            this.UsersdataGridView.Name = "UsersdataGridView";
            this.UsersdataGridView.ReadOnly = true;
            this.UsersdataGridView.RowHeadersVisible = false;
            this.UsersdataGridView.Size = new System.Drawing.Size(405, 450);
            this.UsersdataGridView.TabIndex = 0;
            this.UsersdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersdataGridView_CellClick);
            // 
            // iduserDataGridViewTextBoxColumn
            // 
            this.iduserDataGridViewTextBoxColumn.DataPropertyName = "id_user";
            this.iduserDataGridViewTextBoxColumn.HeaderText = "id_user";
            this.iduserDataGridViewTextBoxColumn.Name = "iduserDataGridViewTextBoxColumn";
            this.iduserDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loginuserDataGridViewTextBoxColumn
            // 
            this.loginuserDataGridViewTextBoxColumn.DataPropertyName = "login_user";
            this.loginuserDataGridViewTextBoxColumn.HeaderText = "login_user";
            this.loginuserDataGridViewTextBoxColumn.Name = "loginuserDataGridViewTextBoxColumn";
            this.loginuserDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passworduserDataGridViewTextBoxColumn
            // 
            this.passworduserDataGridViewTextBoxColumn.DataPropertyName = "password_user";
            this.passworduserDataGridViewTextBoxColumn.HeaderText = "password_user";
            this.passworduserDataGridViewTextBoxColumn.Name = "passworduserDataGridViewTextBoxColumn";
            this.passworduserDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rolesDataGridViewTextBoxColumn
            // 
            this.rolesDataGridViewTextBoxColumn.DataPropertyName = "roles";
            this.rolesDataGridViewTextBoxColumn.HeaderText = "roles";
            this.rolesDataGridViewTextBoxColumn.Name = "rolesDataGridViewTextBoxColumn";
            this.rolesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // registerBindingSource
            // 
            this.registerBindingSource.DataMember = "register";
            this.registerBindingSource.DataSource = this.internetServiceProviderDBDataSet10;
            // 
            // internetServiceProviderDBDataSet10
            // 
            this.internetServiceProviderDBDataSet10.DataSetName = "InternetServiceProviderDBDataSet10";
            this.internetServiceProviderDBDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registerTableAdapter
            // 
            this.registerTableAdapter.ClearBeforeFill = true;
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddUser.Location = new System.Drawing.Point(11, 140);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(168, 34);
            this.buttonAddUser.TabIndex = 1;
            this.buttonAddUser.Text = "Додати";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteUser.Location = new System.Drawing.Point(11, 14);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(168, 34);
            this.buttonDeleteUser.TabIndex = 2;
            this.buttonDeleteUser.Text = "Видалити";
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // buttonUpdateRole
            // 
            this.buttonUpdateRole.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdateRole.Location = new System.Drawing.Point(11, 19);
            this.buttonUpdateRole.Name = "buttonUpdateRole";
            this.buttonUpdateRole.Size = new System.Drawing.Size(168, 58);
            this.buttonUpdateRole.TabIndex = 3;
            this.buttonUpdateRole.Text = "Надати нові права доступу";
            this.buttonUpdateRole.UseVisualStyleBackColor = true;
            this.buttonUpdateRole.Click += new System.EventHandler(this.buttonUpdateRole_Click);
            // 
            // comboBoxNewRole
            // 
            this.comboBoxNewRole.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxNewRole.FormattingEnabled = true;
            this.comboBoxNewRole.Items.AddRange(new object[] {
            "admin",
            "user"});
            this.comboBoxNewRole.Location = new System.Drawing.Point(201, 38);
            this.comboBoxNewRole.Name = "comboBoxNewRole";
            this.comboBoxNewRole.Size = new System.Drawing.Size(147, 26);
            this.comboBoxNewRole.TabIndex = 4;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUsername.Location = new System.Drawing.Point(94, 21);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(254, 26);
            this.textBoxUsername.TabIndex = 5;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.Location = new System.Drawing.Point(94, 56);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxPassword.Size = new System.Drawing.Size(254, 26);
            this.textBoxPassword.TabIndex = 6;
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Location = new System.Drawing.Point(165, 95);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(183, 26);
            this.comboBoxRole.TabIndex = 7;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.username.Location = new System.Drawing.Point(11, 24);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(60, 23);
            this.username.TabIndex = 8;
            this.username.Text = "Логін";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(11, 59);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(77, 23);
            this.password.TabIndex = 9;
            this.password.Text = "Пароль";
            // 
            // roles
            // 
            this.roles.AutoSize = true;
            this.roles.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roles.Location = new System.Drawing.Point(11, 98);
            this.roles.Name = "roles";
            this.roles.Size = new System.Drawing.Size(151, 23);
            this.roles.TabIndex = 10;
            this.roles.Text = "Рівень доступу";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.roles);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.comboBoxRole);
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Controls.Add(this.textBoxUsername);
            this.panel1.Controls.Add(this.buttonAddUser);
            this.panel1.Location = new System.Drawing.Point(427, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 188);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.comboBoxNewRole);
            this.panel2.Controls.Add(this.buttonUpdateRole);
            this.panel2.Location = new System.Drawing.Point(427, 248);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(364, 101);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.buttonDeleteUser);
            this.panel3.Location = new System.Drawing.Point(427, 361);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(364, 74);
            this.panel3.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(302, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.UsersdataGridView);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsersdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internetServiceProviderDBDataSet10)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView UsersdataGridView;
        private InternetServiceProviderDBDataSet10 internetServiceProviderDBDataSet10;
        private System.Windows.Forms.BindingSource registerBindingSource;
        private InternetServiceProviderDBDataSet10TableAdapters.registerTableAdapter registerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iduserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginuserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passworduserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolesDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.Button buttonUpdateRole;
        private System.Windows.Forms.ComboBox comboBoxNewRole;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label roles;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}