﻿using My;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace AutoEmail
{
    public partial class frmAutomail : Form
    {
        string strurl;
        DataTable AllDatatable;
        string Mailbody;        
        EmailSend mail;
        string tempaskinfo;
        bool Startload = true;
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
            List<String> ProType = new List<string> {"全部", "大型顯示器", "空氣品質", "流量-AICHI","流量-RGL","流量-Siargo",
            "流量-其他","記錄器","資料收集器-JETEC","資料收集器-其他","溫濕-JETEC","溫濕-GALLTEC"
            ,"溫濕-E+E","溫濕-其他","紅外線","壓力-JETEC","壓力-HUBA","壓力-COPAL","壓力-其他","差壓"
            ,"氣體-JETEC","氣體-Senko","氣體-GASDNA","氣體-手持","氣體-其他","氣象儀器-土壤/pH","氣象儀器-日照/紫外線"
            ,"氣象儀器-風速/風向","氣象儀器-雨量","氣象儀器-其他","水質相關"
            ,"液位/料位-Jetec","液位/料位-DINEL","液位/料位-HONDA","液位/料位-其他","溫度貼紙",
            "溫控器","感溫線棒","無線傳輸","編碼器/電位計","能源管理控制","食品","其它"};
            CB_product_type.DataSource=(ProType);
            CB_product_type.SelectedItem = Mail_Config.ProductType;
            CB_situation.Text = Mail_Config.CustSituation;

            // 使用BackgroundWorker時不能在工作執行緒中訪問UI執行緒部分，
            // 即你不能在BackgroundWorker的事件和方法中操作UI，否則會拋跨執行緒操作無效的異常
            // 新增下列語句可以避免異常。
            CheckForIllegalCrossThreadCalls = false;
            string curDir = Directory.GetCurrentDirectory();

            webView.Url =  new Uri(string.Format("file:///{0}/body.html", curDir));
            int Startload = 0;



            mail = new EmailSend(Mail_Config.MailUserName, Mail_Config.SendAddress, Mail_Config.MailPassword);
        }
       

        private void Btn_sendget_Click(object sender, EventArgs e)
        {
            
            if (Startload)
            {
                System.IO.StreamReader reader = new System.IO.StreamReader(webView.DocumentStream, Encoding.GetEncoding("BIG5"));
                Mailbody = reader.ReadToEnd();
                Startload = false;
            }
            string strGet;
            string strcheck=CB_situation.Text;
            string strStart = dtp_start.Text;
            string strend = dtp_end.Text;
            string strproduct = CB_product_type.Text.Equals("全部") ? "" : CB_product_type.Text;

            strGet = "strsql=&strcheck="+strcheck+"&start_date="+strStart+
                     "&end_date="+strend+"&product_type="+strproduct;
            GetCopanydata(strGet);
            label1.Text = dgv_commail.RowCount.ToString();
        }

        private void GetCopanydata(string strGet)
        {
            ///GET查詢資料
            strurl = "http://www.jetecbk.com.tw/Mail.php";
            AllDatatable =Cls_GetHttpData.HttpGet(strurl,strGet);
                //新增信箱欄位
                DataColumn mail = new DataColumn();
                mail.ColumnName = "mailbody";
                DataColumn cusname = new DataColumn();
                cusname.ColumnName = "cusname";
            AllDatatable.Columns.Add(mail);
            AllDatatable.Columns.Add(cusname);
            
            foreach (DataRow row in AllDatatable.Rows)
            {
                string mails = Mailbody.Replace("|DATE|",row[1].ToString()).Replace("|Producttype|", ask_productSet(row[3].ToString()));
                row[6] = mails;
                row[7] = "Follow-" + string.Format("{0:yyyyMMdd}", DateTime.Now) +
                         "-久德 "+ ask_productSet(row[3].ToString()) + " TO "+ strcompany(row[0].ToString()) ;

            }
            
            dgv_commail.DataSource = AllDatatable;
            if (dgv_commail.ColumnCount < 5) return;
            dgv_commail.Columns[0].HeaderText = "公司名稱";
            dgv_commail.Columns[1].HeaderText = "建單日期";
            dgv_commail.Columns[2].HeaderText = "詢問內容";
            dgv_commail.Columns[3].HeaderText = "產品類別";
            dgv_commail.Columns[4].HeaderText = "信箱";
            dgv_commail.Columns[5].Visible = false;
            dgv_commail.Columns[6].HeaderText = "寄件內容";
            dgv_commail.Columns[7].Visible = false;

        }
        public string strcompany(string company)
        {
            int cutpoint;
            if (company.Contains("new"))
            {
                cutpoint = company.IndexOf("new");
            }
            else if (company.Contains("("))
            {
                cutpoint = company.IndexOf("(");
            }else
            {
                return company;
            }
            return company.Substring(0, cutpoint);

        }

        private void frmAutomail_FormClosed(object sender, FormClosedEventArgs e)
        {
            Mail_Config.CustSituation = CB_situation.Text;
            Mail_Config.ProductType = CB_product_type.Text;
            Mail_Config.MailStartDate = dtp_start.Text;
            Mail_Config.MailEndDate = dtp_end.Text;

            // 設定INI SET值
            string filePath = System.Windows.Forms.Application.StartupPath + "\\System.ini";

            MyINI myINI = new MyINI(filePath);
            myINI.setKeyValue("LastMailConfig", "CustSituation", Mail_Config.CustSituation);
            myINI.setKeyValue("LastMailConfig", "ProductType", Mail_Config.ProductType);
            myINI.setKeyValue("LastMailConfig", "MailStartDate", Mail_Config.MailStartDate);
            myINI.setKeyValue("LastMailConfig", "MailEndDate", Mail_Config.MailEndDate);

        }

        private void dgv_commail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                LoadDgvData(e.RowIndex);
            }
            
        }

        void LoadDgvData(int RowIndex)
        {
            string title= dgv_commail[7, RowIndex].Value.ToString();
            ///產品類別
            string producttype = dgv_commail[3, RowIndex].Value.ToString();
            //詢問內容
            string askinfo = dgv_commail[2, RowIndex].Value.ToString();
            //寄初內容
            string mail = dgv_commail[6, RowIndex].Value.ToString();
            //顯示記出設定
            TB_askinfo.Text = askinfo;
            tempaskinfo = ask_productSet(producttype);
            TB_product_type.Text = producttype;
            TB_ask_product.Text = ask_productSet (producttype);
            TB_title.Text = title;
            webView.DocumentText = mail;
        }
        public string ask_productSet(string producttype)
        {
            switch (producttype)
            {
                case "大型顯示器": return "大型顯示器";
                case "空氣品質": return "空氣品質偵測產品";
                case "流量-AICHI": return "流量-AICHI";
                case "流量-RGL":return "流量-RGL";
                case "流量 - Siargo":return "流量 - Siargo";
                case "流量-其他": return "流量計";
                case "記錄器": return "記錄器";
                case "資料收集器-JETEC": return "溫濕度資料收集器-JETEC";
                case "資料收集器-其他": return "溫濕度資料收集器-JETEC";
                case "溫濕-JETEC": return "溫濕度監控相關產品";
                case "溫濕-GALLTEC": return "溫濕度監控相關產品";
                case "溫濕-E E": return "溫濕度監控相關產品";
                case "溫濕-其他": return "溫濕度監控相關產品";
                case "紅外線": return "紅外線測溫器";
                case "壓力-JETEC": return "壓力傳感器相關產品";
                case "壓力-HUBA": return "壓力傳感器相關產品";
                case "壓力-COPAL": return "壓力傳感器相關產品";
                case "壓力-其他": return "壓力傳感器相關產品";
                case "氣體-JETEC": return "氣體偵測器";
                case "差壓": return "差壓計";
                case "氣體-Senko": return "氣體偵測器";
                case "氣體-GASDNA": return "氣體偵測器";
                case "氣體-手持": return "手持氣體偵測器";
                case "氣體-其他": return "氣體偵測器";
                case "氣象儀器-土壤/pH": return "土壤測量傳感器";
                case "氣象儀器-日照/紫外線": return "日照/紫外線感測器";
                case "氣象儀器-風速/風向": return "風速/風向傳送器";
                case "氣象儀器-雨量": return "雨量偵測器";
                case "氣象儀器-其他": return "氣象監測相關儀器";
                case "水質相關": return "水質相關測量儀器";
                case "液位/料位-JETEC": return "液位/料位-Jetec";
                case "液位/料位-DINEL": return "液位/料位-DINEL傳感器";
                case "水液位/料位-HONDA": return "液位/料位-HONDA";
                case "液位/料位-其他": return "液位/料位傳感器";
                case "溫度貼紙": return "溫度貼紙";
                case "溫控器-TOHO": return "溫控器";
                case "溫控器-其他": return "溫控器";
                case "感溫線棒": return "感溫線棒";
                case "無線傳輸": return "無線傳輸相關";
                case "編碼器/電位計": return "編碼器/電位計";
                case "能源管理控制": return "能源管理控制儀器";
                case "食品": return "食品監測相關儀器";
                case "其它": return "監測相關儀器";

                default: return producttype;
            }
        }
        private void Btn_send_mail_Click(object sender, EventArgs e)
        {
            this.bgw.RunWorkerAsync(); // 运行 backgroundWorker 组件
            ProgressBar form = new ProgressBar(this.bgw);// 显示进度条窗体
            form.ShowDialog(this);
            form.Close();
        }
        private void bgw_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            int sendcnt=1;
            foreach (DataGridViewRow Row in dgv_commail.Rows)
            {
                if (Row.Cells[7].Value != null & IsValidEMailAddress(Row.Cells[4].Value.ToString()))
                {
                    mail.DoSend(Row.Cells[7].Value.ToString(), Row.Cells[6].Value.ToString(), Row.Cells[4].Value.ToString());
                    Thread.Sleep(300);
                }
                worker.ReportProgress(sendcnt*100/ dgv_commail.Rows.Count);
                if (worker.CancellationPending)  // 如果用户取消则跳出处理数据代码 
                {
                    e.Cancel = true;
                    break;
                }
                sendcnt += 1;
            }
        }
        public static bool IsValidEMailAddress(string email)
        {
            return Regex.IsMatch(email, @"^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$");
        }

        private void CompleteWork(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else if (e.Cancelled)
            {
            }
            else
            {
                MessageBox.Show("信件寄送完畢");
            }
        }

      

        private void uiButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select file";
            dialog.InitialDirectory = ".\\";
            dialog.Filter = "files (*.*)|";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                TB_filepath.Text= dialog.FileName;
                mail.attachmentPath = TB_filepath.Text;
            }
        }

      
        private void dgv_commail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                int RowIndex = this.dgv_commail.CurrentRow.Index;
                if (RowIndex < dgv_commail.RowCount - 1)
                {
                    try
                    {
                        LoadDgvData(RowIndex + 1);
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
            if (e.KeyCode == Keys.Up)
            {
                int RowIndex = this.dgv_commail.CurrentRow.Index;
                if (RowIndex > 0)
                {
                    try
                    {
                        LoadDgvData(RowIndex - 1);
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
        }

   

        private void uiButton2_Click(object sender, EventArgs e)
        {
            int Rowselect = dgv_commail.CurrentRow.Index;
            if (TB_ask_product.Text.Length != 0)
            {
                
                webView.DocumentText = webView.DocumentText.Replace(tempaskinfo, TB_ask_product.Text);
                dgv_commail[6, Rowselect].Value = webView.DocumentText.Replace(tempaskinfo, TB_ask_product.Text);
                TB_title.Text = TB_title.Text.Replace(tempaskinfo, TB_ask_product.Text);
                tempaskinfo = TB_ask_product.Text;
                dgv_commail[3, Rowselect].Value = tempaskinfo;
            }
            
            dgv_commail[7, Rowselect].Value = TB_title.Text;
            
        }

        private void TB_ask_product_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                Btn_change.PerformClick();
                dgv_commail.Select();
            }
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
        public static string Bodypath;
        public static List<string> MailBody;

        

        #endregion

    }



}
