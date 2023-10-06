using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.IO;
using System.Net.Mail;
using System.Net;

namespace FileTimeStampMonitoring
{
    public partial class frmMain : Form
    {
        SettingClass settingClass;
        Setting setting;
        Thread syncThread;
        Path_Setting[] lstPath_Setting;
        private static System.Timers.Timer aTimer;

        public frmMain()
        {
            InitializeComponent();
            settingClass = new SettingClass();
            lstPath_Setting = new Path_Setting[0];
        }




        private  void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            if (syncThread.ThreadState == null)
                return;
            if (syncThread.ThreadState == ThreadState.Aborted || syncThread.ThreadState == ThreadState.AbortRequested)
                return;
            string strValue = "";
            string strTemp = "";
            string strPath = "";
            try
            {
                for (int i = 0; i < lstPath_Setting.Length; i++)
                {
                    strTemp = lstPath_Setting[i].strPath.ToString();
                    strValue = "Name: " + lstPath_Setting[i].strName.ToString() + "\r\nPath: " + lstPath_Setting[i].strPath.ToString() + "\r\n";
                    lstPath_Setting[i].laseUpdateTime = GetDirectoryLastUpdatedTime(strTemp);
                    if (DateTime.Now.Subtract(lstPath_Setting[i].laseUpdateTime).TotalMinutes >= setting.iSendEmailNoUpdate)
                        strPath = strPath + strValue + "\r\n";
                }

                if (strPath!="")
                    SendAutomatedEmail("Paths with no updated files found, please check\r\n\r\n" + strPath);

                UpdateToGrid(true);
                UpdateLastMonitorTime();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on checking: " + ex.Message);
            }

        }

        private DateTime GetDirectoryLastUpdatedTime(string strPath)
        {
            try
            {
                DateTime dt = new DateTime(2000, 1, 1, 0, 0, 0);
                if (!Directory.Exists(strPath.Trim()))
                {
                    return dt;
                }

                DirectoryInfo di_source_directory = new DirectoryInfo(@strPath);
                FileSystemInfo[] ls_fi = di_source_directory.GetFileSystemInfos();

                DateTime ts_most_recent = (ls_fi.Any(a =>  a.Attributes != FileAttributes.Directory)
                                 ? ls_fi.Max(fi => fi.LastWriteTime)
                                 : dt);

                return ts_most_recent;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on getting directory last updated time: " + ex.Message);
                return new DateTime(2000, 1, 1, 0, 0, 0);
            }
        }

        private void UpdateToGrid(bool b_Check)
        {
//            lv_Path.Items.Clear();
            ClearAllItems();
            string strValue = "";
            for (int i = 0; i < lstPath_Setting.Length; i++)
            {
                strValue = lstPath_Setting[i].strName.ToString();
                ListViewItem lvi = new ListViewItem(strValue);

                strValue = lstPath_Setting[i].strPath.ToString();

                lvi.UseItemStyleForSubItems = false;
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi,strValue));

                if (b_Check)
                {
                    if (lstPath_Setting[i].laseUpdateTime != null)
                    {
                        if (lstPath_Setting[i].laseUpdateTime == new DateTime(2000, 1, 1, 0, 0, 0))
                            lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, "No Files/Fail to access directory"));
                        else
                            lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi,
                               lstPath_Setting[i].laseUpdateTime.ToString("dd/MM/yyyy HH:mm:ss")));

                        if (DateTime.Now.Subtract(lstPath_Setting[i].laseUpdateTime).TotalMinutes >= setting.iSendEmailNoUpdate)
                            lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi,
                                "", Color.White, Color.Red, lvi.Font));
                        else
                            lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi,
                                "", Color.White, Color.Green, lvi.Font));
                    }
                    //lv_Path.Items.Add(lvi);
                }
                AddItems(lvi);
            }
        }

        void UpdateLastMonitorTime()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)delegate { this.UpdateLastMonitorTime(); });
                return;
            }
            lbl_LastMonitorTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }


        void ClearAllItems()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)delegate { this.ClearAllItems(); });
                return;
            }
            lv_Path.Items.Clear();
        }

        void AddItems(ListViewItem lvi)
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)delegate { this.AddItems(lvi); });
                return;
            }
            lv_Path.Items.Add(lvi);
        }

        private void onStart()
        {
            ConfigHandler config = new ConfigHandler();
            setting = settingClass.GetSetting("");


            // Create a timer with a two second interval.

            aTimer = new System.Timers.Timer(setting.iSendEmailInterval*1000*60);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text.Trim() == "")
            {
                MessageBox.Show("Please input Name");
                return;
            }

            if (txt_Path.Text.Trim() == "")
            {
                MessageBox.Show("Please input Path");
                return;
            }

            if (!Directory.Exists(txt_Path.Text.Trim()))
            {
                MessageBox.Show("Path does not exist");
                return;
            }

            for (int i = 0; i < lstPath_Setting.Length; i++)
            {
                if (lstPath_Setting[i].strName.ToString().Trim() == txt_Name.Text.Trim())
                {
                    MessageBox.Show("Duplicate Name");
                    return;
                }
            }



            for (int i = 0; i < lstPath_Setting.Length; i++)
            {
                if (lstPath_Setting[i].strPath.ToString().Trim() == txt_Path.Text.Trim())
                {
                    MessageBox.Show("Duplicate Path");
                    return;
                }
            }


            Array.Resize(ref lstPath_Setting, lstPath_Setting.Length + 1);
            Path_Setting path_setting = new Path_Setting();
            path_setting.strPath =  txt_Path.Text.Trim();
            path_setting.strName = txt_Name.Text.Trim();
            path_setting.laseUpdateTime = GetDirectoryLastUpdatedTime(path_setting.strPath);
            lstPath_Setting[lstPath_Setting.Length - 1] = path_setting;


            UpdateToGrid(false);

        }

        private void btnOpenDir_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    txt_Path.Text = fbd.SelectedPath;
//                    string[] files = Directory.GetFiles(fbd.SelectedPath);
//                    System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnMon.Enabled = true;
            btnStop.Enabled = false;
            setting = settingClass.GetSetting("");
            lstPath_Setting = setting.Path_SettingList;

            txt_SMTPEmail.Text = setting.strSMTPEmail;
            txt_SMTPPassword.Text = setting.strSMTPPassword;
            txt_ToEmail.Text = setting.strSMTPReceiver;
            txt_SMTPServer.Text = setting.strSMTPServer;
            txt_SMTPPort.Text = setting.strSMTPPort;
            chk_SMTPSSL.Checked = setting.iSMTPSSLEnable==1 ? true : false;
            
            ud_No_Update.Text = setting.iSendEmailNoUpdate.ToString();
            ud_Mon_Interval.Text = setting.iSendEmailInterval.ToString();
            UpdateToGrid(false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ud_Mon_Interval.Text.Trim()=="")
            {
                MessageBox.Show("Please Input monitoring interval");
                return;
            }

            if (ud_No_Update.Text.Trim() == "")
            {
                MessageBox.Show("Please Input Send Email for No Update After (minutes)");
                return;
            }
            SaveData(true); 
        }


        private bool SaveData(bool b_msg)
        {
            try
            {
                setting.Path_SettingList = lstPath_Setting;

                setting.strSMTPEmail = txt_SMTPEmail.Text.Trim();
                setting.strSMTPPassword = txt_SMTPPassword.Text.Trim();
                setting.strSMTPReceiver = txt_ToEmail.Text.Trim();
                setting.strSMTPServer = txt_SMTPServer.Text.Trim();
                setting.strSMTPPort = txt_SMTPPort.Text.Trim();
                setting.iSMTPSSLEnable = chk_SMTPSSL.Checked ? 1 : 0;

                setting.iSendEmailInterval = Convert.ToInt32(ud_Mon_Interval.Value);
                setting.iSendEmailNoUpdate = Convert.ToInt32(ud_No_Update.Value);

                settingClass.SaveSetting(setting);

                if (b_msg)
                    MessageBox.Show("Save OK");

                return true;
            }
            catch (Exception ex)
            {
                    MessageBox.Show("Save Fail: " + ex.Message);
                    return false;
            }
        }

        private void btnMon_Click(object sender, EventArgs e)
        {
            if (ud_Mon_Interval.Text.Trim() == "")
            {
                MessageBox.Show("Please Input monitoring interval");
                return;
            }

            if (ud_No_Update.Text.Trim() == "")
            {
                MessageBox.Show("Please Input Send Email for No Update After (minutes)");
                return;
            }
            if (!SaveData(false))
                return;

            syncThread = null;
            syncThread = new Thread(new ThreadStart(onStart));
            syncThread.SetApartmentState(ApartmentState.STA);
            syncThread.IsBackground = true;
            syncThread.Start();

            btnMon.Enabled = false;
            btnStop.Enabled = true;
            lbl_Status.Text = "Running";
            Enable_Control(false);
        }

        private void Enable_Control(bool bEnable)
        {
            txt_Path.Enabled = bEnable;
            txt_Name.Enabled = bEnable;
            txt_SMTPPassword.Enabled = bEnable;
            txt_SMTPEmail.Enabled = bEnable;
            txt_SMTPPort.Enabled = bEnable;
            txt_SMTPServer.Enabled = bEnable;
            txt_ToEmail.Enabled = bEnable;
            btnAdd.Enabled = bEnable;
            btnDelete.Enabled = bEnable;
            btnOpenDir.Enabled = bEnable;
            btnSave.Enabled = bEnable;

            ud_Mon_Interval.Enabled = bEnable;
            ud_No_Update.Enabled = bEnable;
            chk_SMTPSSL.Enabled = bEnable;

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            syncThread.Abort();
            while (syncThread.ThreadState != ThreadState.Aborted)
            {
                Thread.Sleep(100);
            }
            aTimer.Stop();
            aTimer = null;
            syncThread = null;
            btnMon.Enabled = true;
            btnStop.Enabled = false;
            Enable_Control(true);
            lbl_Status.Text = "Stopped";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (lv_Path.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Please select a row!");
                return;
            }

            string strSelectItem = lv_Path.SelectedItems[0].Text;
            int numIdx = -1;

            for (int i = 0; i < lstPath_Setting.Length; i++)
            {
                if (lstPath_Setting[i].strName.ToString().Trim() == strSelectItem.Trim())
                {
                    numIdx = i;
                    break;
                }
            }

            if (numIdx >= 0)
            {
                List<Path_Setting> tmp = new List<Path_Setting>(lstPath_Setting);
                tmp.RemoveAt(numIdx);
                lstPath_Setting = tmp.ToArray();
                UpdateToGrid(false);
            }
        }

        public void SendAutomatedEmail(string Message)
        {
            if (Message.Length > 0)
            {
                ConfigHandler config = new ConfigHandler();

                String strFromMail = setting.strSMTPEmail;
                String strToMail = setting.strSMTPReceiver;

                String strSMTPServer = setting.strSMTPServer;
//                String strSMTPServer = config.GetKeyValue(("SMTPServer"));
                int iSMTPPort = 0;

//                String strSMTPPort = config.GetKeyValue(("SMTPPort"));
                String strSMTPPort = setting.strSMTPPort;
                if (!String.IsNullOrWhiteSpace(strSMTPPort))
                    iSMTPPort = Convert.ToInt32(strSMTPPort);
                int iSMTPSSL = setting.iSMTPSSLEnable;
 //               String strSMTPSSL = config.GetKeyValue(("EnableSMTPSSL"));
//                String strSMTPSSL = config.GetKeyValue(("EnableSMTPSSL"));
  //              if (!String.IsNullOrWhiteSpace(strSMTPSSL))
//                    iSMTPSSL = Convert.ToInt32(strSMTPSSL);

                if (strFromMail.Length == 0 || strToMail.Length == 0 || strSMTPServer.Length == 0)
                    return;

                try
                {
                    MailMessage ErrorMail = new MailMessage();
                    ErrorMail.From = new MailAddress(strFromMail);
                    foreach (var address in strToMail.Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries))
                    {
                        ErrorMail.To.Add(address);
                    }
                    ErrorMail.Subject = "EMS File Monitoring ";
                    ErrorMail.Body = "\r\n\r\n\r\n" + Message;
                    ErrorMail.IsBodyHtml = false;
                    SmtpClient MailSMTP = new SmtpClient(strSMTPServer, iSMTPPort);
                    if (iSMTPSSL == 1)
                    {
                        MailSMTP.UseDefaultCredentials = false;
//                        String strMailPassword = config.GetKeyValue(("SMTPPassword"));
                        String strMailPassword = setting.strSMTPPassword;
//                        if (strMailPassword.Length > 0)
  //                          strMailPassword = SSTCryptographer.Decrypt(strMailPassword, "founder");
                        MailSMTP.EnableSsl = true;
                        MailSMTP.Credentials = new NetworkCredential(strFromMail, strMailPassword);
                    }
                    try
                    {
                        MailSMTP.Send(ErrorMail);
                        ErrorMail.Dispose();
//                        config.UpdateKeyValue("0", "SendEmail");
                    }
                    catch (Exception ex)
                    {
//                        MessageBox.Show("Error on sending email: " + ex.Message);
                        WriteToFile("Error on sending email: " + ex.Message, false);
                    }
                }
                catch (Exception ex)
                {
//                    MessageBox.Show("Error on sending email: " + ex.Message);
                    WriteToFile("Error on sending email: " + ex.Message, false);
                }
            }
        }

        private static ReaderWriterLockSlim _readWriteLock = new ReaderWriterLockSlim();
        public static void WriteToFile(String message, Boolean bFirst)
        {
            if (message.Equals(".") || message.Equals("\n"))
                return;
            _readWriteLock.EnterWriteLock();
            try
            {
                String strFileName = CheckLogFile();
                Encoding encode = System.Text.UnicodeEncoding.Unicode;
                StreamWriter sw = new StreamWriter(strFileName, true, encode);
                if (bFirst)
                    sw.WriteLine();
                sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss   ") + message);
                sw.Flush();
                sw.Close();
            }
            catch (Exception ex) { }
            finally
            {
                // Release lock
                _readWriteLock.ExitWriteLock();
            }
        }

        public static String CheckLogFile()
        {
/*            ConfigHandler config = new ConfigHandler();
            String strLogFilePath = config.GetKeyValue(("LogPath"));
            if (strLogFilePath.LastIndexOf("\\") != strLogFilePath.Length)
                strLogFilePath = strLogFilePath + "\\";
            //serviceTimer.Stop();
            if (!Directory.Exists(strLogFilePath))
                Directory.CreateDirectory(strLogFilePath);
 */           String strLogFileName = Application.StartupPath + "\\" + DateTime.Now.ToString("yyyyMM") + "_error_log.txt";
            //serviceTimer.Start();
            return strLogFileName;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void lv_Path_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  btnDelete.Enabled = (lv_Path.SelectedItems.Count != 0);
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chkOnTop_CheckedChanged(object sender, EventArgs e)
        {
           this.TopMost = chkOnTop.Checked;
        }

    
    }

 

}
