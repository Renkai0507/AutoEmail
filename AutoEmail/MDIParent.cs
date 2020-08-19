using My;
using System;
using System.Windows.Forms;

namespace AutoEmail
{
    public partial class MDIParent : Form
    {
        private int childFormNumber = 0;

        public MDIParent()
        {
            InitializeComponent();
            LoadSystemINI();
            ShowAutomail();
        }
        public void LoadSystemINI()
        {

            string filePath = System.Windows.Forms.Application.StartupPath + "\\System.ini";
            if (My.MyFileIO.FileExists(filePath))
            {
                My.MyINI myINI = new My.MyINI(filePath);
                Mail_Config.DataIP = myINI.getKeyValue("Database", "DataIP");
                Mail_Config.Datapage = myINI.getKeyValue("Database", "Datapage");
                Mail_Config.DataPassword = myINI.getKeyValue("Database", "DataPassword");
                Mail_Config.CustSituation = myINI.getKeyValue("LastMailConfig", "CustSituation");
                Mail_Config.ProductType = myINI.getKeyValue("LastMailConfig", "ProductType");
                Mail_Config.MailStartDate = myINI.getKeyValue("LastMailConfig", "MailStartDate");
                Mail_Config.MailEndDate = myINI.getKeyValue("LastMailConfig", "MailEndDate");
                Mail_Config.SendAddress = myINI.getKeyValue("SendMailConfig", "SendAddress");
                Mail_Config.MailUserName = myINI.getKeyValue("SendMailConfig", "MailUserName");
                Mail_Config.MailPassword = myINI.getKeyValue("SendMailConfig", "MailPassword");
                Mail_Config.SmtpServer = myINI.getKeyValue("SendMailConfig", "SmtpServer");
                Mail_Config.SmtpPort = Convert.ToInt32(myINI.getKeyValue("SendMailConfig", "SmtpPort"));
                Mail_Config.Bodypath = System.Windows.Forms.Application.StartupPath +
                    myINI.getKeyValue("SendMailConfig","Bodypath");
                ///
                ///信件內容載入List<string>
                ///List第一 第三位置是日期和產品
                Mail_Config.MailBody = new System.Collections.Generic.List<string> { };
                Mail_Config.MailBody.Add(myINI.getKeyValue("MailBody", "msg1"));
                Mail_Config.MailBody.Add(myINI.getKeyValue("MailBody", "msgdate"));
                Mail_Config.MailBody.Add(myINI.getKeyValue("MailBody", "msg2")); Mail_Config.MailBody.Add(myINI.getKeyValue("MailBody", "msgtype"));
                Mail_Config.MailBody.Add(myINI.getKeyValue("MailBody", "msg3")); Mail_Config.MailBody.Add(myINI.getKeyValue("MailBody", "msg4"));
                Mail_Config.MailBody.Add(myINI.getKeyValue("MailBody", "msg5")); Mail_Config.MailBody.Add(myINI.getKeyValue("MailBody", "msg6"));
                Mail_Config.MailBody.Add(myINI.getKeyValue("MailBody", "msg7")); Mail_Config.MailBody.Add(myINI.getKeyValue("MailBody", "msg8"));

            }
            else
            {
                MessageBox.Show("系統設定檔案System.INI載入失敗，請洽系統維護人員。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public bool IsShowChildForm(string MdiFormName)
        {
            foreach (Form var in MdiChildren)
            {
                if (MdiFormName == var.Name)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return true;
        }

        private void ShowAutomail()
        {
            if (IsShowChildForm("frmAutomail"))
            {
                frmAutomail FRAM = new frmAutomail();
                FRAM.MdiParent = this;
                FRAM.StartPosition = FormStartPosition.CenterScreen;
                FRAM.Show();

                //AddNewTab(FRFC); //Test TabControl
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAutomail();
        }
    }
}
