using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.IO;

namespace AutoEmail
{
    class EmailSend
    {

        string userName;
        string sendAddress;
        string pwd;
        static MailAddress MailFrom;        
        static List<string> MailCcs { get; set; }
        public  string attachmentPath { set; get; }
        public EmailSend(string user,string Address,string paswd)
        {
            ///設定寄件人
            #region 寄件者個人資訊
            userName = user;
            sendAddress = Address;
            pwd = paswd;

            MailFrom = new MailAddress(Address, userName, Encoding.UTF8);
            #endregion
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="信件標頭"></param>
        /// <param name="信件內容"></param>
        /// <param name="寄件對象"></param>
        public void DoSend(string title,string Mailbody,string MailTos)
        {
            #region 寄信主機Server及Port號
            #region 其他常用電子郵件SMTP主機及Port號
            // outlook.com || smtp.live.com port:25
            // yahoo.com.tw || smtp.mail.yahoo.com.tw port:465
            //hiBox
            #endregion
            string smtpServer = "www.hibox.hinet.net";
            int smtpPort = 25;
            #endregion
            MailMessage mms = new MailMessage();
            AlternateView htmlView = AlternateView.CreateAlternateViewFromString(Mailbody, null, "text/html");
            mms.From = MailFrom;
            mms.To.Add(MailTos);
            //副本信箱
            mms.CC.Add("info@jetec.com.tw");


            mms.Subject = title.Replace("\n","");
            //主旨編碼方式
            mms.SubjectEncoding = Encoding.UTF8;
            // 內容
            //mms.Body = body;
            mms.AlternateViews.Add(htmlView);
            //內容編碼方式
            mms.BodyEncoding = Encoding.UTF8;
            //是否採用HTML格式
            mms.IsBodyHtml = true;
            //信件重要程度
            mms.Priority = MailPriority.Normal;
            if (attachmentPath!=null)
            {
                //附件
                //foreach (var item in attachmentPath)
                //{
                Attachment attachment = new Attachment(attachmentPath);
                mms.Attachments.Add(attachment);
                //}
            }

            #region SMTP SERVER
            //設定發送信件的伺服器
            SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort);
            //填寫信箱帳號密碼
            smtpClient.Credentials = new System.Net.NetworkCredential(sendAddress, pwd);
            //是否使用SSL協定傳輸
            smtpClient.EnableSsl = true;
            //傳送信件
            
            try
            {
                smtpClient.Send(mms);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
            }
            //smtpClient.Send(mms);
            #endregion
        }









    }
}
