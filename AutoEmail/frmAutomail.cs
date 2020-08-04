using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.ComponentModel;
using System.Collections.Generic;
using System.Security.Policy;

namespace AutoEmail
{
    public partial class frmAutomail : Form
    {
        string strurl;
        DataTable AllDatatable;
        
        public frmAutomail()
        {
            InitializeComponent();
            initUI();
         
        }
        private void initUI()
        {
            dtp_start.Text = Mail_Config.MailStartDate;
            dtp_end.Text = Mail_Config.MailEndDate;
            CB_situation.Items.Add("全部"); CB_situation.Items.Add("尚未處理"); CB_situation.Items.Add("處理中");
            CB_situation.Items.Add("已報價"); CB_situation.Items.Add("未成交"); CB_situation.Items.Add("已成交");
            List<String> ProType = new List<string> {"全部", "大型顯示器", "空氣品質", "流量-AICHI", "流量-Siargo",
            "流量-其他","記錄器","資料收集器-JETEC","資料收集器-其他","溫濕-JETEC","溫濕-GALLTEC"
            ,"溫濕-E+E","溫濕-其他","紅外線","壓力-JETEC","壓力-HUBA","壓力-COPAL","壓力-其他","差壓"
            ,"氣體-JETEC","氣體-Senko","氣體-GASDNA","氣體-手持","氣體-其他","氣象儀器-土壤/pH","氣象儀器-日照/紫外線"
            ,"氣象儀器-風速/風向","氣象儀器-雨量","氣象儀器-其他","水質相關"};
            CB_product_type.DataSource=(ProType);
            CB_product_type.Text = Mail_Config.ProductType;
            CB_situation.Text = Mail_Config.CustSituation;
            for (int i = 0; i < Mail_Config.MailBody.Count; i++)
            {

                TB_mailbody.Text += Mail_Config.MailBody[i].Replace("|n", "\r\n");
            }


        }
        void SetGetdata()
        {
            
            //textBox1.Text= HttpHelper.HttpGet("http://www.jetecbk.com.tw/Mail.php", Getdata);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetGetdata();
        }

        private void Btn_sendget_Click(object sender, EventArgs e)
        {
            string strGet;
            strGet = "strsql=&strcheck=&start_date=2020-05-01&end_date=2020-05-31&product_type=";
            GetCopanydata(strGet);
        }

        private void GetCopanydata(string strGet)
        {
            AllDatatable=Cls_GetHttpData.HttpGet(strurl,strGet);
            
            foreach (var tmp in AllDatatable.Rows)
            {
                DataColumn mail = new DataColumn();
                mail.ColumnName = "mailbody";
                AllDatatable.Columns.Add(mail);
            }
            dgv_commail.DataSource = AllDatatable;
            dgv_commail.Columns[0].HeaderText = "公司名稱";
            dgv_commail.Columns[1].HeaderText = "建單日期";
            dgv_commail.Columns[2].HeaderText = "詢問內容";
            dgv_commail.Columns[3].HeaderText = "產品類別";
            dgv_commail.Columns[4].HeaderText = "信箱";
            //dgv_commail.Columns[5].HeaderText = "寄件內容";
        }

        private void frmAutomail_FormClosed(object sender, FormClosedEventArgs e)
        {
            Mail_Config.CustSituation = CB_situation.Text;
            Mail_Config.ProductType = CB_product_type.Text;
            Mail_Config.MailStartDate = dtp_start.Text;
            Mail_Config.MailEndDate = dtp_end.Text;
            My.MyINI.setKeyValue("","","");
            // 設定INI SET值

        }
    }
    static class Mail_Config
    {
        /// <summary>
        /// 自動寄信環境設定
        /// </summary>
        #region ***自動寄信環境設定

        public static string DataIP;
        public static string Datapage;
        public static string DataPassword;
        public static string CustSituation;
        public static string ProductType;
        public static string MailStartDate;
        public static string MailEndDate;
        public static string SendAddress;
        public static string MailUserName;
        public static string MailPassword;
        public static string SmtpServer;
        public static int    SmtpPort;
        public static List<string> MailBody;
        

        #endregion

    }



}
