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
    public partial class Form1 : Form
    {
        string strurl;
        DataTable AllDatatable;
        
        public Form1()
        {
            InitializeComponent();
            strurl= "http://www.jetecbk.com.tw/Mail.php";
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
            dgv_commail.DataSource = AllDatatable;
            dgv_commail.Columns[0].HeaderText = "公司名稱";
            dgv_commail.Columns[1].HeaderText = "建單日期";
            dgv_commail.Columns[2].HeaderText = "詢問內容";
            dgv_commail.Columns[3].HeaderText = "產品類別";
            dgv_commail.Columns[4].HeaderText = "信箱";
            //dgv_commail.Columns[5].HeaderText = "寄件內容";
        }
    }




}
