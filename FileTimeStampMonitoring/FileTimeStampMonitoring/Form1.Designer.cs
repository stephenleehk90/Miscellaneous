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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "C:\\founder\\temp\\dbgraphic\\log",
            "15/03/2023 16:04:00"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "C:\\founder\\temp\\DBTELE\\LOG",
            "15/03/2023 16:04:00"}, -1);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lbl_LastSyncTime = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.btnMon = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(596, 418);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lbl_LastSyncTime);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.btn_Stop);
            this.tabPage3.Controls.Add(this.btnMon);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(588, 392);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Run Monitoring";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lbl_LastSyncTime
            // 
            this.lbl_LastSyncTime.AutoSize = true;
            this.lbl_LastSyncTime.Font = new System.Drawing.Font("Arial", 12.25F);
            this.lbl_LastSyncTime.ForeColor = System.Drawing.Color.Blue;
            this.lbl_LastSyncTime.Location = new System.Drawing.Point(324, 188);
            this.lbl_LastSyncTime.Name = "lbl_LastSyncTime";
            this.lbl_LastSyncTime.Size = new System.Drawing.Size(148, 19);
            this.lbl_LastSyncTime.TabIndex = 7;
            this.lbl_LastSyncTime.Text = "- 12/03/2023 16:01";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12.25F);
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(137, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Last Monitoring Time:";
            // 
            // btn_Stop
            // 
            this.btn_Stop.Enabled = false;
            this.btn_Stop.Location = new System.Drawing.Point(266, 96);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(91, 31);
            this.btn_Stop.TabIndex = 3;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = true;
            // 
            // btnMon
            // 
            this.btnMon.Location = new System.Drawing.Point(159, 96);
            this.btnMon.Name = "btnMon";
            this.btnMon.Size = new System.Drawing.Size(91, 31);
            this.btnMon.TabIndex = 2;
            this.btnMon.Text = "Start";
            this.btnMon.UseVisualStyleBackColor = true;
            this.btnMon.Click += new System.EventHandler(this.btnSyncToESF_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(588, 392);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Common Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 223);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(582, 166);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(342, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "Minutes ";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(183, 58);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(143, 22);
            this.textBox3.TabIndex = 12;
            this.textBox3.Text = "15";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "Send Email  For No Update After";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "Minutes";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(183, 31);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(143, 22);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "30";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Monitoring Interval:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 220);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Monitoring Path List";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(471, 20);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(30, 23);
            this.button6.TabIndex = 17;
            this.button6.Text = "...";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "Path:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(55, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(412, 22);
            this.textBox1.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(19, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(502, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.GridLines = true;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listView1.Location = new System.Drawing.Point(17, 52);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(512, 128);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Path";
            this.columnHeader1.Width = 313;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Last Updated Time";
            this.columnHeader2.Width = 189;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(588, 392);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Email Information";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox5);
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
            this.groupBox5.Size = new System.Drawing.Size(582, 312);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Email Configuration";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Window;
            this.textBox5.Location = new System.Drawing.Point(133, 80);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(427, 22);
            this.textBox5.TabIndex = 18;
            this.textBox5.TabStop = false;
            this.textBox5.Text = "sender@gmail.com";
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
            this.txt_SMTPEmail.Location = new System.Drawing.Point(132, 112);
            this.txt_SMTPEmail.Name = "txt_SMTPEmail";
            this.txt_SMTPEmail.Size = new System.Drawing.Size(427, 22);
            this.txt_SMTPEmail.TabIndex = 14;
            this.txt_SMTPEmail.TabStop = false;
            this.txt_SMTPEmail.Text = "recipient@gmail.com";
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
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 364);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 54);
            this.panel1.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(388, 18);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 26);
            this.button4.TabIndex = 1;
            this.button4.Text = "Save";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(480, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 26);
            this.button3.TabIndex = 0;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 418);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmMain";
            this.Text = "EMS Log Path Monitoring Utility";
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
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
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lbl_LastSyncTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Button btnMon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}

