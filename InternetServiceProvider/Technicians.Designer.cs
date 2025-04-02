namespace InternetServiceProvider
{
    partial class Technicians
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Technicians));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.technicianidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.techniciansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.internetServiceProviderDBDataSet = new InternetServiceProvider.InternetServiceProviderDBDataSet();
            this.techniciansTableAdapter = new InternetServiceProvider.InternetServiceProviderDBDataSetTableAdapters.techniciansTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.report = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вийтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сервісToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запитиАбонентівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.призначенняТехніківToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фахівціToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.інтернетпланиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.обладнанняToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.абонентиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.платежіToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.адмінпанельToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techniciansBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internetServiceProviderDBDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            this.technicianidDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.activeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.techniciansBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(684, 266);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // technicianidDataGridViewTextBoxColumn
            // 
            this.technicianidDataGridViewTextBoxColumn.DataPropertyName = "technician_id";
            this.technicianidDataGridViewTextBoxColumn.HeaderText = "technician_id";
            this.technicianidDataGridViewTextBoxColumn.Name = "technicianidDataGridViewTextBoxColumn";
            this.technicianidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "first_name";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "last_name";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // activeDataGridViewTextBoxColumn
            // 
            this.activeDataGridViewTextBoxColumn.DataPropertyName = "active";
            this.activeDataGridViewTextBoxColumn.HeaderText = "active";
            this.activeDataGridViewTextBoxColumn.Name = "activeDataGridViewTextBoxColumn";
            this.activeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // techniciansBindingSource
            // 
            this.techniciansBindingSource.DataMember = "technicians";
            this.techniciansBindingSource.DataSource = this.internetServiceProviderDBDataSet;
            // 
            // internetServiceProviderDBDataSet
            // 
            this.internetServiceProviderDBDataSet.DataSetName = "InternetServiceProviderDBDataSet";
            this.internetServiceProviderDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // techniciansTableAdapter
            // 
            this.techniciansTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(12, 299);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 264);
            this.panel1.TabIndex = 1;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox6.Location = new System.Drawing.Point(138, 200);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(189, 26);
            this.textBox6.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(25, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Активний";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(25, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(25, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Телефон";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(25, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(25, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Прізвище";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5.Location = new System.Drawing.Point(138, 168);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(189, 26);
            this.textBox5.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(25, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ім\'я";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(138, 136);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(189, 26);
            this.textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(138, 104);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(189, 26);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(138, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(189, 26);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(138, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 26);
            this.textBox1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.report);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(374, 339);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 224);
            this.panel2.TabIndex = 2;
            // 
            // report
            // 
            this.report.BackColor = System.Drawing.SystemColors.Control;
            this.report.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("report.BackgroundImage")));
            this.report.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.report.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.report.Location = new System.Drawing.Point(222, 16);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(55, 52);
            this.report.TabIndex = 14;
            this.report.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.report.UseVisualStyleBackColor = false;
            this.report.Click += new System.EventHandler(this.report_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(39, 157);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 42);
            this.button3.TabIndex = 2;
            this.button3.Text = "Змінити";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(222, 85);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(55, 52);
            this.button5.TabIndex = 11;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(222, 153);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(55, 52);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(39, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 42);
            this.button2.TabIndex = 1;
            this.button2.Text = "Видалити";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(39, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Додати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(409, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(248, 29);
            this.label7.TabIndex = 3;
            this.label7.Text = "Керування записами";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.CadetBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.сервісToolStripMenuItem,
            this.фахівціToolStripMenuItem,
            this.абонентиToolStripMenuItem,
            this.платежіToolStripMenuItem,
            this.адмінпанельToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(709, 26);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вийтиToolStripMenuItem});
            this.файлToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 22);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // вийтиToolStripMenuItem
            // 
            this.вийтиToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.вийтиToolStripMenuItem.Name = "вийтиToolStripMenuItem";
            this.вийтиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.вийтиToolStripMenuItem.Text = "Вийти";
            this.вийтиToolStripMenuItem.Click += new System.EventHandler(this.вийтиToolStripMenuItem_Click);
            // 
            // сервісToolStripMenuItem
            // 
            this.сервісToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.запитиАбонентівToolStripMenuItem,
            this.призначенняТехніківToolStripMenuItem});
            this.сервісToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.сервісToolStripMenuItem.Name = "сервісToolStripMenuItem";
            this.сервісToolStripMenuItem.Size = new System.Drawing.Size(64, 22);
            this.сервісToolStripMenuItem.Text = "Сервіс";
            // 
            // запитиАбонентівToolStripMenuItem
            // 
            this.запитиАбонентівToolStripMenuItem.Name = "запитиАбонентівToolStripMenuItem";
            this.запитиАбонентівToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.запитиАбонентівToolStripMenuItem.Text = "Запити абонентів";
            this.запитиАбонентівToolStripMenuItem.Click += new System.EventHandler(this.запитиАбонентівToolStripMenuItem_Click);
            // 
            // призначенняТехніківToolStripMenuItem
            // 
            this.призначенняТехніківToolStripMenuItem.Name = "призначенняТехніківToolStripMenuItem";
            this.призначенняТехніківToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.призначенняТехніківToolStripMenuItem.Text = "Призначення техніків";
            this.призначенняТехніківToolStripMenuItem.Click += new System.EventHandler(this.призначенняТехніківToolStripMenuItem_Click);
            // 
            // фахівціToolStripMenuItem
            // 
            this.фахівціToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.інтернетпланиToolStripMenuItem1,
            this.обладнанняToolStripMenuItem1});
            this.фахівціToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.фахівціToolStripMenuItem.Name = "фахівціToolStripMenuItem";
            this.фахівціToolStripMenuItem.Size = new System.Drawing.Size(73, 22);
            this.фахівціToolStripMenuItem.Text = "Маркет";
            // 
            // інтернетпланиToolStripMenuItem1
            // 
            this.інтернетпланиToolStripMenuItem1.Name = "інтернетпланиToolStripMenuItem1";
            this.інтернетпланиToolStripMenuItem1.Size = new System.Drawing.Size(189, 22);
            this.інтернетпланиToolStripMenuItem1.Text = "Інтернет-плани";
            this.інтернетпланиToolStripMenuItem1.Click += new System.EventHandler(this.інтернетпланиToolStripMenuItem1_Click);
            // 
            // обладнанняToolStripMenuItem1
            // 
            this.обладнанняToolStripMenuItem1.Name = "обладнанняToolStripMenuItem1";
            this.обладнанняToolStripMenuItem1.Size = new System.Drawing.Size(189, 22);
            this.обладнанняToolStripMenuItem1.Text = "Обладнання";
            this.обладнанняToolStripMenuItem1.Click += new System.EventHandler(this.обладнанняToolStripMenuItem1_Click);
            // 
            // абонентиToolStripMenuItem
            // 
            this.абонентиToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.абонентиToolStripMenuItem.Name = "абонентиToolStripMenuItem";
            this.абонентиToolStripMenuItem.Size = new System.Drawing.Size(88, 22);
            this.абонентиToolStripMenuItem.Text = "Абоненти";
            this.абонентиToolStripMenuItem.Click += new System.EventHandler(this.абонентиToolStripMenuItem_Click);
            // 
            // платежіToolStripMenuItem
            // 
            this.платежіToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.платежіToolStripMenuItem.Name = "платежіToolStripMenuItem";
            this.платежіToolStripMenuItem.Size = new System.Drawing.Size(80, 22);
            this.платежіToolStripMenuItem.Text = "Платежі";
            this.платежіToolStripMenuItem.Click += new System.EventHandler(this.платежіToolStripMenuItem_Click);
            // 
            // адмінпанельToolStripMenuItem
            // 
            this.адмінпанельToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.адмінпанельToolStripMenuItem.Name = "адмінпанельToolStripMenuItem";
            this.адмінпанельToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.адмінпанельToolStripMenuItem.Text = "Адмін-панель";
            this.адмінпанельToolStripMenuItem.Click += new System.EventHandler(this.адмінпанельToolStripMenuItem_Click);
            // 
            // Technicians
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 576);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Technicians";
            this.Text = "Технічні фахівці";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techniciansBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internetServiceProviderDBDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private InternetServiceProviderDBDataSet internetServiceProviderDBDataSet;
        private System.Windows.Forms.BindingSource techniciansBindingSource;
        private InternetServiceProviderDBDataSetTableAdapters.techniciansTableAdapter techniciansTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn technicianidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem фахівціToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem інтернетпланиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem обладнанняToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сервісToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запитиАбонентівToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem призначенняТехніківToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem абонентиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem платежіToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вийтиToolStripMenuItem;
        private System.Windows.Forms.Button report;
        private System.Windows.Forms.ToolStripMenuItem адмінпанельToolStripMenuItem;
    }
}

