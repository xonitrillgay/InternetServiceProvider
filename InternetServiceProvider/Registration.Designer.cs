namespace InternetServiceProvider
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.panel1 = new System.Windows.Forms.Panel();
            this.authorization = new System.Windows.Forms.Label();
            this.clearPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closedEye = new System.Windows.Forms.PictureBox();
            this.loginLabel = new System.Windows.Forms.LinkLabel();
            this.eyeOpen = new System.Windows.Forms.PictureBox();
            this.createButton = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clearPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closedEye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyeOpen)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.clearPictureBox);
            this.panel1.Controls.Add(this.authorization);
            this.panel1.Location = new System.Drawing.Point(211, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 71);
            this.panel1.TabIndex = 0;
            // 
            // authorization
            // 
            this.authorization.AutoSize = true;
            this.authorization.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorization.Location = new System.Drawing.Point(19, 15);
            this.authorization.Name = "authorization";
            this.authorization.Size = new System.Drawing.Size(210, 42);
            this.authorization.TabIndex = 4;
            this.authorization.Text = "Реєстрація";
            // 
            // clearPictureBox
            // 
            this.clearPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("clearPictureBox.Image")));
            this.clearPictureBox.Location = new System.Drawing.Point(480, 15);
            this.clearPictureBox.Name = "clearPictureBox";
            this.clearPictureBox.Size = new System.Drawing.Size(55, 49);
            this.clearPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.clearPictureBox.TabIndex = 13;
            this.clearPictureBox.TabStop = false;
            this.clearPictureBox.Click += new System.EventHandler(this.clearPictureBox_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // closedEye
            // 
            this.closedEye.Image = ((System.Drawing.Image)(resources.GetObject("closedEye.Image")));
            this.closedEye.Location = new System.Drawing.Point(572, 238);
            this.closedEye.Name = "closedEye";
            this.closedEye.Size = new System.Drawing.Size(35, 35);
            this.closedEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closedEye.TabIndex = 21;
            this.closedEye.TabStop = false;
            this.closedEye.Click += new System.EventHandler(this.closedEye_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.Location = new System.Drawing.Point(388, 373);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(52, 18);
            this.loginLabel.TabIndex = 20;
            this.loginLabel.TabStop = true;
            this.loginLabel.Text = "Увійти";
            this.loginLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loginLabel_LinkClicked);
            // 
            // eyeOpen
            // 
            this.eyeOpen.Image = ((System.Drawing.Image)(resources.GetObject("eyeOpen.Image")));
            this.eyeOpen.Location = new System.Drawing.Point(572, 238);
            this.eyeOpen.Name = "eyeOpen";
            this.eyeOpen.Size = new System.Drawing.Size(35, 35);
            this.eyeOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eyeOpen.TabIndex = 19;
            this.eyeOpen.TabStop = false;
            this.eyeOpen.Click += new System.EventHandler(this.eyeOpen_Click);
            // 
            // createButton
            // 
            this.createButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createButton.Location = new System.Drawing.Point(329, 328);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(165, 42);
            this.createButton.TabIndex = 18;
            this.createButton.Text = "Створити";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(339, 247);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(210, 20);
            this.textBoxPassword.TabIndex = 17;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(339, 216);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(210, 20);
            this.textBoxLogin.TabIndex = 16;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(228, 238);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(99, 29);
            this.password.TabIndex = 15;
            this.password.Text = "Пароль";
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.Location = new System.Drawing.Point(228, 207);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(74, 29);
            this.login.TabIndex = 14;
            this.login.Text = "Логін";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closedEye);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.eyeOpen);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Registration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clearPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closedEye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyeOpen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label authorization;
        private System.Windows.Forms.PictureBox clearPictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox closedEye;
        private System.Windows.Forms.LinkLabel loginLabel;
        private System.Windows.Forms.PictureBox eyeOpen;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label login;
    }
}