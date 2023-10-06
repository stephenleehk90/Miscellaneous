namespace FileTimeStampMonitoring
{
    partial class frmMain
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lv_Path = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnOpenDir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Path = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_LastMonitorTime = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnMon = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ud_No_Update = new System.Windows.Forms.NumericUpDown();
            this.ud_Mon_Interval = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txt_ToEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_SMTPPassword = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_SMTPEmail = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txt_SMTPPort = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_SMTPServer = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.chk_SMTPSSL = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkOnTop = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ud_No_Update)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_Mon_Interval)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(831, 446);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lv_Path);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(823, 420);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Common Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lv_Path
            // 
            this.lv_Path.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lv_Path.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_Path.FullRowSelect = true;
            this.lv_Path.GridLines = true;
            this.lv_Path.Location = new System.Drawing.Point(3, 70);
            this.lv_Path.MultiSelect = false;
            this.lv_Path.Name = "lv_Path";
            this.lv_Path.Size = new System.Drawing.Size(817, 179);
            this.lv_Path.TabIndex = 23;
            this.lv_Path.UseCompatibleStateImageBehavior = false;
            this.lv_Path.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Name";
            this.columnHeader4.Width = 130;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Path";
            this.columnHeader1.Width = 326;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Last Updated Time";
            this.columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Status";
            this.columnHeader3.Width = 205;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 249);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(817, 47);
            this.panel2.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(475, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(273, 12);
            this.label9.TabIndex = 26;
            this.label9.Text = "No Updated Files Found/ No Files/ Fail to access directory";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Location = new System.Drawing.Point(445, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(24, 23);
            this.panel3.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(312, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 12);
            this.label7.TabIndex = 24;
            this.label7.Text = "Normal";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Green;
            this.panel4.Location = new System.Drawing.Point(282, 11);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(24, 23);
            this.panel4.TabIndex = 23;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(30, 11);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Name);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.btnOpenDir);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_Path);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(817, 67);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Monitoring Path List";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(64, 20);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(119, 22);
            this.txt_Name.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 12);
            this.label12.TabIndex = 18;
            this.label12.Text = "Name:";
            // 
            // btnOpenDir
            // 
            this.btnOpenDir.Location = new System.Drawing.Point(681, 20);
            this.btnOpenDir.Name = "btnOpenDir";
            this.btnOpenDir.Size = new System.Drawing.Size(30, 23);
            this.btnOpenDir.TabIndex = 17;
            this.btnOpenDir.Text = "...";
            this.btnOpenDir.UseVisualStyleBackColor = true;
            this.btnOpenDir.Click += new System.EventHandler(this.btnOpenDir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "Path:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_Path
            // 
            this.txt_Path.Location = new System.Drawing.Point(226, 21);
            this.txt_Path.Name = "txt_Path";
            this.txt_Path.Size = new System.Drawing.Size(433, 22);
            this.txt_Path.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(712, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_Status);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.lbl_LastMonitorTime);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnStop);
            this.groupBox3.Controls.Add(this.btnMon);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(3, 296);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(817, 52);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Run Monitoring";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Font = new System.Drawing.Font("Arial", 12.25F);
            this.lbl_Status.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Status.Location = new System.Drawing.Point(381, 20);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(69, 19);
            this.lbl_Status.TabIndex = 27;
            this.lbl_Status.Text = "Stopped";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12.25F);
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(246, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 19);
            this.label10.TabIndex = 26;
            this.label10.Text = "Monitoring Status: ";
            // 
            // lbl_LastMonitorTime
            // 
            this.lbl_LastMonitorTime.AutoSize = true;
            this.lbl_LastMonitorTime.Font = new System.Drawing.Font("Arial", 12.25F);
            this.lbl_LastMonitorTime.ForeColor = System.Drawing.Color.Blue;
            this.lbl_LastMonitorTime.Location = new System.Drawing.Point(638, 20);
            this.lbl_LastMonitorTime.Name = "lbl_LastMonitorTime";
            this.lbl_LastMonitorTime.Size = new System.Drawing.Size(20, 19);
            this.lbl_LastMonitorTime.TabIndex = 25;
            this.lbl_LastMonitorTime.Text = "- ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12.25F);
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(468, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 19);
            this.label6.TabIndex = 24;
            this.label6.Text = "Last Monitoring Time:";
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(137, 16);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(91, 31);
            this.btnStop.TabIndex = 23;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnMon
            // 
            this.btnMon.Location = new System.Drawing.Point(30, 16);
            this.btnMon.Name = "btnMon";
            this.btnMon.Size = new System.Drawing.Size(91, 31);
            this.btnMon.TabIndex = 22;
            this.btnMon.Text = "Start";
            this.btnMon.UseVisualStyleBackColor = true;
            this.btnMon.Click += new System.EventHandler(this.btnMon_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ud_No_Update);
            this.groupBox2.Controls.Add(this.ud_Mon_Interval);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(3, 348);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(817, 69);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // ud_No_Update
            // 
            this.ud_No_Update.Location = new System.Drawing.Point(213, 42);
            this.ud_No_Update.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.ud_No_Update.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ud_No_Update.Name = "ud_No_Update";
            this.ud_No_Update.Size = new System.Drawing.Size(116, 22);
            this.ud_No_Update.TabIndex = 15;
            this.ud_No_Update.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ud_Mon_Interval
            // 
            this.ud_Mon_Interval.Location = new System.Drawing.Point(213, 16);
            this.ud_Mon_Interval.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.ud_Mon_Interval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ud_Mon_Interval.Name = "ud_Mon_Interval";
            this.ud_Mon_Interval.Size = new System.Drawing.Size(116, 22);
            this.ud_Mon_Interval.TabIndex = 14;
            this.ud_Mon_Interval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(342, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "Minutes ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "Send Email  For No Update After";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "Minutes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Monitoring Interval:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(823, 420);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Email Information";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.txt_ToEmail);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.txt_SMTPPassword);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.txt_SMTPEmail);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.txt_SMTPPort);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.txt_SMTPServer);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.chk_SMTPSSL);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(817, 312);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Email Configuration";
            // 
            // txt_ToEmail
            // 
            this.txt_ToEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txt_ToEmail.Location = new System.Drawing.Point(133, 110);
            this.txt_ToEmail.Name = "txt_ToEmail";
            this.txt_ToEmail.Size = new System.Drawing.Size(427, 22);
            this.txt_ToEmail.TabIndex = 18;
            this.txt_ToEmail.TabStop = false;
            this.txt_ToEmail.Text = "sender@gmail.com";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "From  Email:";
            // 
            // txt_SMTPPassword
            // 
            this.txt_SMTPPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txt_SMTPPassword.Location = new System.Drawing.Point(132, 145);
            this.txt_SMTPPassword.Name = "txt_SMTPPassword";
            this.txt_SMTPPassword.PasswordChar = '*';
            this.txt_SMTPPassword.Size = new System.Drawing.Size(427, 22);
            this.txt_SMTPPassword.TabIndex = 16;
            this.txt_SMTPPassword.TabStop = false;
            this.txt_SMTPPassword.Text = "1234555";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(4, 148);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(83, 12);
            this.label19.TabIndex = 15;
            this.label19.Text = "SMTP Password:";
            // 
            // txt_SMTPEmail
            // 
            this.txt_SMTPEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txt_SMTPEmail.Location = new System.Drawing.Point(132, 79);
            this.txt_SMTPEmail.Name = "txt_SMTPEmail";
            this.txt_SMTPEmail.Size = new System.Drawing.Size(427, 22);
            this.txt_SMTPEmail.TabIndex = 14;
            this.txt_SMTPEmail.TabStop = false;
            this.txt_SMTPEmail.Text = "from@gmail.com";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(4, 116);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(51, 12);
            this.label20.TabIndex = 13;
            this.label20.Text = "To Email:";
            // 
            // txt_SMTPPort
            // 
            this.txt_SMTPPort.BackColor = System.Drawing.SystemColors.Window;
            this.txt_SMTPPort.Location = new System.Drawing.Point(132, 50);
            this.txt_SMTPPort.Name = "txt_SMTPPort";
            this.txt_SMTPPort.Size = new System.Drawing.Size(427, 22);
            this.txt_SMTPPort.TabIndex = 12;
            this.txt_SMTPPort.TabStop = false;
            this.txt_SMTPPort.Text = "465";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(4, 55);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 12);
            this.label18.TabIndex = 11;
            this.label18.Text = "SMTP Port:";
            // 
            // txt_SMTPServer
            // 
            this.txt_SMTPServer.BackColor = System.Drawing.SystemColors.Window;
            this.txt_SMTPServer.Location = new System.Drawing.Point(132, 15);
            this.txt_SMTPServer.Name = "txt_SMTPServer";
            this.txt_SMTPServer.Size = new System.Drawing.Size(427, 22);
            this.txt_SMTPServer.TabIndex = 10;
            this.txt_SMTPServer.TabStop = false;
            this.txt_SMTPServer.Text = "smtp.gmail.com";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 12);
            this.label11.TabIndex = 9;
            this.label11.Text = "SMTP Server:";
            // 
            // chk_SMTPSSL
            // 
            this.chk_SMTPSSL.AutoSize = true;
            this.chk_SMTPSSL.Location = new System.Drawing.Point(6, 189);
            this.chk_SMTPSSL.Name = "chk_SMTPSSL";
            this.chk_SMTPSSL.Size = new System.Drawing.Size(89, 16);
            this.chk_SMTPSSL.TabIndex = 4;
            this.chk_SMTPSSL.Text = "SSL Required";
            this.chk_SMTPSSL.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkOnTop);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 446);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(831, 54);
            this.panel1.TabIndex = 5;
            // 
            // chkOnTop
            // 
            this.chkOnTop.AutoSize = true;
            this.chkOnTop.Location = new System.Drawing.Point(12, 16);
            this.chkOnTop.Name = "chkOnTop";
            this.chkOnTop.Size = new System.Drawing.Size(138, 16);
            this.chkOnTop.TabIndex = 16;
            this.chkOnTop.Text = "Window Always on Top";
            this.chkOnTop.UseVisualStyleBackColor = true;
            this.chkOnTop.CheckedChanged += new System.EventHandler(this.chkOnTop_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(312, 16);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 26);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(404, 16);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 26);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.ForeColor = System.Drawing.Color.Green;
            this.label13.Location = new System.Drawing.Point(568, 115);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(200, 12);
            this.label13.TabIndex = 19;
            this.label13.Text = "(Use ; to separate multiple emails) ";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 500);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EMS Log Path Monitoring Utility";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ud_No_Update)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_Mon_Interval)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txt_SMTPPassword;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txt_SMTPEmail;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txt_SMTPPort;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_SMTPServer;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chk_SMTPSSL;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOpenDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Path;
        private System.Windows.Forms.TextBox txt_ToEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_LastMonitorTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnMon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ud_Mon_Interval;
        private System.Windows.Forms.NumericUpDown ud_No_Update;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView lv_Path;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox chkOnTop;
        private System.Windows.Forms.Label label13;
    }
}

