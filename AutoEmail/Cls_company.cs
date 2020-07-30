using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace AutoEmail
{
    class Cls_company
    {
        /// <summary>
        /// 公司名稱
        /// </summary>
        string cus_company { get; set; }
        /// <summary>
        /// 公司信箱
        /// </summary>
        MailAddress cus_email { get; set; }

        /// <summary>
        /// 詢問內容
        /// </summary>
        string Asks_nifo { get; set; }
        /// <summary>
        /// 產品類型
        /// </summary>
        string product_type { set; get; }
        /// <summary>
        /// 創件日期
        /// </summary>
        string creat_date { set; get; }
        /// <summary>
        /// 寄出內容
        /// </summary>
        string sendbody { set; get; }

    }
}
