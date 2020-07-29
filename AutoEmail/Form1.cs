using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoEmail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void SetGetdata()
        {
            string Getdata = "strsql=select&strcheck=123&start_date=0728&end_date=0729";
            
            //textBox1.Text= HttpHelper.HttpGet("http://www.jetecbk.com.tw/Mail.php", Getdata);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetGetdata();
        }

    }
}
