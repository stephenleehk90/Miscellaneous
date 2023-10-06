using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileTimeStampMonitoring
{
    class SettingClass
    {
        ConfigHandler config;
        Setting setting;
        String strCurViewName;
        public SettingClass()
        {
            config = new ConfigHandler();
        }

        public Setting GetSetting(String strViewName)
        {
            strCurViewName = strViewName;
            config = new ConfigHandler();
            setting = new Setting();

            LoadSetting();
            return setting;
        }

        private String PasswordEncryption(String strPassword)
        {
            String strDone = SSTCryptographer.Encrypt(strPassword, "founder");
            return strDone;
        }

        private String PasswordDecryption(String strPassword)
        {

            if (strPassword.Length == 0)
                return "";
            String strDone = SSTCryptographer.Decrypt(strPassword, "founder"); ;
            return strDone;
        }

        private void LoadSetting()
        {
            string strTemp = "";
            strTemp = config.GetKeyValue("SMTPServer");
            setting.strSMTPServer = strTemp;
            strTemp = "";
            strTemp = config.GetKeyValue("SMTPPort");
            setting.strSMTPPort = strTemp;
            strTemp = "";
            strTemp = config.GetKeyValue("SMTPEmail");
            setting.strSMTPEmail = strTemp;
            strTemp = "";
            strTemp = config.GetKeyValue("SMTPToEmail");
            setting.strToEmail = strTemp;
            strTemp = "";
            strTemp = config.GetKeyValue("SMTPPassword");
            setting.strSMTPPassword = PasswordDecryption(strTemp);
            strTemp = "";
            strTemp = config.GetKeyValue("EnableSMTPSSL");
            if (String.IsNullOrWhiteSpace(strTemp))
                setting.iSMTPSSLEnable = 0;
            else
                setting.iSMTPSSLEnable = Convert.ToInt32(strTemp);
            strTemp = "";
            strTemp = config.GetKeyValue("SMTPReceiver");
            setting.strSMTPReceiver = strTemp;

            strTemp = "";
            strTemp = config.GetKeyValue("SendEmailInterval");
            if (String.IsNullOrWhiteSpace(strTemp))
                setting.iSendEmailInterval = 30;
            else
                setting.iSendEmailInterval = Convert.ToInt32(strTemp);

            strTemp = "";
            strTemp = config.GetKeyValue("SendEmailNoUpdate");
            if (String.IsNullOrWhiteSpace(strTemp))
                setting.iSendEmailNoUpdate = 60;
            else
                setting.iSendEmailNoUpdate = Convert.ToInt32(strTemp);


            int iCount = 0;
            string strCount = config.GetKeyValue("Path_Count");
            if (strCount != "")
                iCount = Convert.ToInt32(config.GetKeyValue("Path_Count"));
            strTemp = "";
            Path_Setting[] lstPath_Setting = new Path_Setting[0];
            for (int i = 0; i < iCount; i++)
            {
                Array.Resize(ref lstPath_Setting, lstPath_Setting.Length + 1);
                Path_Setting path_setting = new Path_Setting();
                strTemp = config.GetKeyValue("Path_ID_" + i.ToString());
                path_setting.strPath = strTemp;

                strTemp = config.GetKeyValue("Path_Name_" + i.ToString());
                path_setting.strName = strTemp;
                
                lstPath_Setting[lstPath_Setting.Length - 1] = path_setting;
            }
            setting.Path_SettingList = lstPath_Setting;


        }


        public void SaveSetting(Setting setting)
        {
           // RemoveSyncSetting();
            this.setting = setting;
            String strValue = "";

            for (int i = 0; i < setting.Path_SettingList.Length; i++)
            {
                strValue = setting.Path_SettingList[i].strPath.ToString();
                config.GetKeyValue("Path_ID_" + i.ToString());
                config.UpdateKeyValue(strValue, "Path_ID_" + i.ToString());

                strValue = setting.Path_SettingList[i].strName.ToString();
                config.GetKeyValue("Path_Name_" + i.ToString());
                config.UpdateKeyValue(strValue, "Path_Name_" + i.ToString());

            }
            //config.GetKeyValue("Sync_Group_Count");
            config.UpdateKeyValue(setting.Path_SettingList.Length.ToString(), "Path_Count");

            config.UpdateKeyValue(setting.iSendEmailInterval.ToString(), "SendEmailInterval");
            config.UpdateKeyValue(setting.iSendEmailNoUpdate.ToString(), "SendEmailNoUpdate");

            config.UpdateKeyValue(setting.strSMTPServer, "SMTPServer");
            config.UpdateKeyValue(setting.strSMTPPort, "SMTPPort");
            config.UpdateKeyValue(setting.strSMTPEmail, "SMTPEmail");
            config.UpdateKeyValue(setting.strToEmail, "SMTPToEmail");
            config.UpdateKeyValue(PasswordEncryption(setting.strSMTPPassword), "SMTPPassword");
            config.UpdateKeyValue(setting.iSMTPSSLEnable.ToString(), "EnableSMTPSSL");
            config.UpdateKeyValue(setting.strSMTPReceiver, "SMTPReceiver");
        }

        public void RemoveSyncSetting()
        {
            for (int i = 0; i < setting.Path_SettingList.Length; i++)
            {
                config.RemoveSetting("Path_ID_" + i.ToString());
            }

        }

        private bool LoadTrueFalseSetting(String strKey)
        {
            bool bResult = false;
            try
            {
                bResult = bool.Parse(config.GetKeyValue(strKey));
            }
            catch (Exception ex)
            {
                bResult = false;
            }
            return bResult;
        }

        public void SaveSerialKey(String strSerialKey)
        {
            String strKey = config.GetKeyValue("SerialKey");
            config.UpdateKeyValue(strSerialKey, "SerialKey");
        }
    }
}

public class Setting
{
    public Path_Setting[] Path_SettingList { get; set; }
    public string strLogPath { get; set; }
    public int iSendEmailInterval { get; set; }
    public int iSendEmailNoUpdate { get; set; }
    public string strSMTPServer { get; set; }
    public string strSMTPPort { get; set; }
    public string strSMTPEmail { get; set; }
    public string strSMTPPassword { get; set; }
    public string strToEmail { get; set; }
    public int iSMTPSSLEnable { get; set; }
    public string strSMTPReceiver { get; set; }
}


public class Path_Setting
{
    public string strPath { get; set; }
    public string strName { get; set; }
    public DateTime laseUpdateTime { get; set; }
    public bool bError { get; set; }
}

