namespace InternetServiceProvider
{
    partial class Auth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Auth));
            this.panel1 = new System.Windows.Forms.Panel();
            this.authorization = new System.Windows.Forms.Label();
            this.clearPictureBox = new System.Windows.Forms.PictureBox();
            this.login = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.eyeOpen = new System.Windows.Forms.PictureBox();
            this.regLabel = new System.Windows.Forms.LinkLabel();
            this.closedEye = new System.Windows.Forms.PictureBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clearPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyeOpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closedEye)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.authorization);
            this.panel1.Controls.Add(this.clearPictureBox);
            this.panel1.Location = new System.Drawing.Point(341, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 71);
            this.panel1.TabIndex = 0;
            // 
            // authorization
            // 
            this.authorization.AutoSize = true;
            this.authorization.Font = new System.Drawing.Font("Georgia", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorization.Location = new System.Drawing.Point(19, 15);
            this.authorization.Name = "authorization";
            this.authorization.Size = new System.Drawing.Size(234, 43);
            this.authorization.TabIndex = 3;
            this.authorization.Text = "Авторизація";
            // 
            // clearPictureBox
            // 
            this.clearPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("clearPictureBox.Image")));
            this.clearPictureBox.Location = new System.Drawing.Point(350, 15);
            this.clearPictureBox.Name = "clearPictureBox";
            this.clearPictureBox.Size = new System.Drawing.Size(43, 42);
            this.clearPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.clearPictureBox.TabIndex = 12;
            this.clearPictureBox.TabStop = false;
            this.clearPictureBox.Click += new System.EventHandler(this.clearPictureBox_Click);
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(377, 201);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(77, 29);
            this.login.TabIndex = 1;
            this.login.Text = "Логін";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(377, 236);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(97, 29);
            this.password.TabIndex = 2;
            this.password.Text = "Пароль";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.Location = new System.Drawing.Point(480, 201);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(210, 29);
            this.textBoxLogin.TabIndex = 6;
            this.textBoxLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLogin_KeyPress);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.Location = new System.Drawing.Point(480, 236);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(210, 29);
            this.textBoxPassword.TabIndex = 7;
            this.textBoxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPassword_KeyPress);
            // 
            // okButton
            // 
            this.okButton.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.okButton.Location = new System.Drawing.Point(468, 327);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(165, 42);
            this.okButton.TabIndex = 8;
            this.okButton.Text = "Ввійти";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 285);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // eyeOpen
            // 
            this.eyeOpen.Image = ((System.Drawing.Image)(resources.GetObject("eyeOpen.Image")));
            this.eyeOpen.Location = new System.Drawing.Point(701, 230);
            this.eyeOpen.Name = "eyeOpen";
            this.eyeOpen.Size = new System.Drawing.Size(35, 35);
            this.eyeOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eyeOpen.TabIndex = 11;
            this.eyeOpen.TabStop = false;
            this.eyeOpen.Click += new System.EventHandler(this.eyeOpen_Click);
            // 
            // regLabel
            // 
            this.regLabel.AutoSize = true;
            this.regLabel.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regLabel.Location = new System.Drawing.Point(509, 372);
            this.regLabel.Name = "regLabel";
            this.regLabel.Size = new System.Drawing.Size(83, 18);
            this.regLabel.TabIndex = 12;
            this.regLabel.TabStop = true;
            this.regLabel.Text = "Реєстрація";
            this.regLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.regLabel_LinkClicked);
            // 
            // closedEye
            // 
            this.closedEye.Image = ((System.Drawing.Image)(resources.GetObject("closedEye.Image")));
            this.closedEye.Location = new System.Drawing.Point(701, 230);
            this.closedEye.Name = "closedEye";
            this.closedEye.Size = new System.Drawing.Size(35, 35);
            this.closedEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closedEye.TabIndex = 13;
            this.closedEye.TabStop = false;
            this.closedEye.Click += new System.EventHandler(this.closedEye_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.MistyRose;
            this.buttonExit.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(45, 409);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(247, 29);
            this.buttonExit.TabIndex = 14;
            this.buttonExit.Text = "Завершити роботу програми";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.closedEye);
            this.Controls.Add(this.regLabel);
            this.Controls.Add(this.eyeOpen);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.panel1);
            this.Name = "Auth";
            this.Text = "Авторизація";
            this.Load += new System.EventHandler(this.Auth_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clearPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyeOpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closedEye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label authorization;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.PictureBox clearPictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox eyeOpen;
        private System.Windows.Forms.LinkLabel regLabel;
        private System.Windows.Forms.PictureBox closedEye;
        private System.Windows.Forms.Button buttonExit;
    }
}