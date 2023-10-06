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
using System.IO;

namespace FileTimeStampMonitoring
{
    public partial class frmMain : Form
    {
        SettingClass settingClass;
        Setting setting;
        Thread syncThread;

        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnSyncToESF_Click(object sender, EventArgs e)
        {
            syncThread = null;
            syncThread = new Thread(new ThreadStart(onStart));
            syncThread.SetApartmentState(ApartmentState.STA);
            syncThread.IsBackground = true;
            syncThread.Start();
            btnMon.Enabled = false;
            btn_Stop.Enabled = true;
        }


        private void onStart()
        {
            ConfigHandler config = new ConfigHandler();
            setting = settingClass.GetSetting("");


            try
            {
            }
            catch (Exception e)
            {

            }

        }
    }
}
