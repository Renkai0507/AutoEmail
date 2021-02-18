using My;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoEmail
{
    public partial class frmQuestList : Form
    {
        string strurl;
        DataTable AllDatatable;
        string Mailbody;
        EmailSend mail;
        string tempaskinfo;
        bool Startload = true;
        SetEDM EDM;
        public frmQuestList()
        {
            MDIParent.LoadSystemINI();
            InitializeComponent();
            initUI();
        }
        private void initUI()
        {
            dtp_start.Text = Mail_Config.MailStartDate;
            dtp_end.Text = Mail_Config.MailEndDate;
            CB_situation.Items.Add("全部"); CB_situation.Items.Add("尚未處理"); CB_situation.Items.Add("處理中");
            CB_situation.Items.Add("已報價"); CB_situation.Items.Add("未成交"); CB_situation.Items.Add("已成交");
            List<String> ProType = new List<string> {"全部", "大型顯示器", "空氣品質", "流量",
            "記錄器","資料收集器","溫濕","紅外線","壓力","差壓"
            ,"氣體","氣象儀器-土壤/pH","氣象儀器-日照/紫外線"
            ,"氣象儀器-風速/風向","氣象儀器-雨量","氣象儀器-其他","水質"
            ,"液位/料位","溫度貼紙",
            "溫控器","感溫線棒","無線傳輸","編碼器/電位計","能源管理控制","食品","其它"};
            CB_product_type.DataSource = (ProType);
            CB_product_type.SelectedItem = Mail_Config.ProductType;
            CB_situation.Text = Mail_Config.CustSituation;

            //刪除"全部"選項後，放入查看EDM下拉選單

            //ProType.RemoveAt(0);
            //CB_EDM.DataSource = (ProType);
            //CB_EDM.SelectedIndex = 0;

            // 使用BackgroundWorker時不能在工作執行緒中訪問UI執行緒部分，
            // 即你不能在BackgroundWorker的事件和方法中操作UI，否則會拋跨執行緒操作無效的異常
            // 新增下列語句可以避免異常。
            CheckForIllegalCrossThreadCalls = false;
            string curDir = Directory.GetCurrentDirectory();

           
            int Startload = 0;
            List<string> attributelist = new List<string>
            {"全部","光電產業","公共/消費性環境","公家機關","其它","冷凍空調","化工業",
             "半導體業","印刷","學校 user","學術/研究單位","尚未分類","工程公司","業主","機械製造",
             "機械設備製造","水資源","物流/倉儲","環保相關","生技製藥","生產 製造","畜牧/農業"
            ,"石化能源","研究單位"};
            CB_attribute.DataSource = attributelist;
            CB_attribute.SelectedItem = Mail_Config.Custtype;

            mail = new EmailSend(Mail_Config.MailUserName, Mail_Config.SendAddress, Mail_Config.MailPassword);
        }

       

        private void GetCopanydata(string strGet)
        {
            ///GET查詢資料
            strurl = "http://www.jetecbk.com.tw/Mail.php";
            AllDatatable = Cls_GetHttpData.HttpGet(strurl, strGet);
            //新增信箱欄位
            DataColumn mail = new DataColumn();
            mail.ColumnName = "mailbody";
            DataColumn cusname = new DataColumn();
            cusname.ColumnName = "cusname";
            AllDatatable.Columns.Add(mail);
            AllDatatable.Columns.Add(cusname);

            foreach (DataRow row in AllDatatable.Rows)
            {
                //string mails = Mailbody.Replace("|DATE|", row[1].ToString()).Replace("|Producttype|", ask_productSet(row[3].ToString()));
                //row[7] = mails;
                //row[8] = "Follow-" + string.Format("{0:yyyyMMdd}", DateTime.Now) +
                //         "-久德 " + ask_productSet(row[3].ToString()) + " TO " + strcompany(row[0].ToString());

            }

            dgv_commail.DataSource = AllDatatable;
            if (dgv_commail.ColumnCount < 5) return;
            dgv_commail.Columns[0].HeaderText = "公司名稱";
            dgv_commail.Columns[1].HeaderText = "建單日期";
            dgv_commail.Columns[2].HeaderText = "詢問內容";
            dgv_commail.Columns[3].HeaderText = "產品類別";
            dgv_commail.Columns[4].HeaderText = "信箱";
            dgv_commail.Columns[5].Visible = false;
            dgv_commail.Columns[6].HeaderText = "產類";
           

        }

        public string ask_productSet(string producttype)
        {
            switch (producttype)
            {
                case "大型顯示器": return "大型顯示器";
                case "空氣品質": return "空氣品質偵測產品";
                case "流量-AICHI": return "流量計(AICHI)";
                case "流量-RGL": return "流量計(RGL)";
                case "流量 - Siargo": return "流量計(Siargo)";
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
                case "液位/料位-JETEC": return "液位/料位傳感器(Jetec)";
                case "液位/料位-DINEL": return "液位/料位傳感器(DINEL)";
                case "水液位/料位-HONDA": return "液位/料位傳感器(HONDA)";
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
            }
            else
            {
                return company;
            }
            return company.Substring(0, cutpoint);

        }

        private void uiButton1_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            string filter = "CSV file (*.csv)|*.csv| All Files (*.*)|*.*";
            saveFileDialog1.Filter = filter;
            saveFileDialog1.Title = "匯出 " + "CSV";
            //saveFileDialog1.FileName = string.Format("{0:yyyyMMdd}", DateTime.Now);
            saveFileDialog1.FileName = "仁開很帥";
            StreamWriter writer = null;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //FileStream strfile = new FileStream(saveFileDialog1.FileName,FileMode.Open);
                filter = saveFileDialog1.FileName;
                writer = new StreamWriter(filter);
                writer.WriteLine("Email,客戶名稱,地址,聯絡人,電話,傳真,客戶屬性,詢問產品種類");
                foreach (DataGridViewRow d in dgv_commail.Rows)
                {
                    string cus_data = d.Cells[4].Value.ToString() + ","
                                   + d.Cells[0].Value.ToString() + ","
                                   + ","
                                   + d.Cells[5].Value.ToString() + ","
                                   + ","
                                   + ","
                                   + d.Cells[6].Value.ToString() + ","
                                   + d.Cells[3].Value.ToString();

                    writer.WriteLine(cus_data);
                }
                writer.Close();
                MessageBox.Show("匯出完成 : " + filter, "匯出", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void SaveToCSV(DataTable oTable, string FilePath)
        {
            string data = "";
            StreamWriter wr = new StreamWriter(FilePath, false, System.Text.Encoding.Default);
            foreach (DataColumn column in oTable.Columns)
            {
                data += column.ColumnName + ",";
            }
            data += "\n";
            wr.Write(data);
            data = "";

            foreach (DataRow row in oTable.Rows)
            {
                foreach (DataColumn column in oTable.Columns)
                {
                    data += row[column].ToString().Trim() + ",";
                }
                data += "\n";
                wr.Write(data);
                data = "";
            }
            data += "\n";

            wr.Dispose();
            wr.Close();
        }

        private void Btn_sendget_Click(object sender, EventArgs e)
        {
          
            string strGet;
            string strcheck = CB_situation.Text.Equals("全部") ? "" : CB_situation.Text;
            string strStart = dtp_start.Text;
            string strend = dtp_end.Text;
            string strproduct = CB_product_type.Text.Equals("全部") ? "" : CB_product_type.Text;
            string strattribute = CB_attribute.Text.Equals("全部") ? "" : CB_attribute.Text;
            strGet = "strsql=&strcheck=" + strcheck + "&start_date=" + strStart +
                     "&end_date=" + strend + "&product_type=" + strproduct + "&attribute=" + strattribute;
            GetCopanydata(strGet);
            label1.Text = dgv_commail.RowCount.ToString();
        }

        private void Btn_sendget_Click_1(object sender, EventArgs e)
        {
            string strGet;
            string strcheck = CB_situation.Text.Equals("全部") ? "" : CB_situation.Text;
            string strStart = dtp_start.Text;
            string strend = dtp_end.Text;
            string strproduct = CB_product_type.Text.Equals("全部") ? "" : CB_product_type.Text;
            string strattribute = CB_attribute.Text.Equals("全部") ? "" : CB_attribute.Text;
            strGet = "strsql=&strcheck=" + strcheck + "&start_date=" + strStart +
                     "&end_date=" + strend + "&product_type=" + strproduct + "&attribute=" + strattribute;
            GetCopanydata(strGet);
            label1.Text = dgv_commail.RowCount.ToString();
        }

        private void frmQuestList_FormClosed(object sender, FormClosedEventArgs e)
        {
            Mail_Config.CustSituation = CB_situation.Text;
            Mail_Config.ProductType = CB_product_type.Text;
            Mail_Config.Custtype = CB_attribute.Text;
            Mail_Config.MailStartDate = dtp_start.Text;            
            Mail_Config.MailEndDate = dtp_end.Text;
            string filePath = System.Windows.Forms.Application.StartupPath + "\\System.ini";

            MyINI myINI = new MyINI(filePath);
            myINI.setKeyValue("LastMailConfig", "CustSituation", Mail_Config.CustSituation);
            myINI.setKeyValue("LastMailConfig", "ProductType", Mail_Config.ProductType);
            myINI.setKeyValue("LastMailConfig", "Custtype", Mail_Config.Custtype);

   

        }
    }
}
