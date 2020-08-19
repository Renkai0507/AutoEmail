namespace AutoEmail
{
    partial class frmAutomail
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.CB_product_type = new Sunny.UI.UIComboBox();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.CB_situation = new Sunny.UI.UIComboBox();
            this.Btn_send_mail = new Sunny.UI.UIButton();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.Btn_sendget = new Sunny.UI.UIButton();
            this.dtp_end = new Sunny.UI.UIDatePicker();
            this.dtp_start = new Sunny.UI.UIDatePicker();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiGroupBox2 = new Sunny.UI.UIGroupBox();
            this.dgv_commail = new Sunny.UI.UIDataGridView();
            this.uiGroupBox3 = new Sunny.UI.UIGroupBox();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.Btn_change = new Sunny.UI.UIButton();
            this.TB_filepath = new Sunny.UI.UIRichTextBox();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.TB_title = new Sunny.UI.UIRichTextBox();
            this.webView = new System.Windows.Forms.WebBrowser();
            this.uiGroupBox4 = new Sunny.UI.UIGroupBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.TB_askinfo = new Sunny.UI.UIRichTextBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.TB_product_type = new Sunny.UI.UIRichTextBox();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.TB_ask_product = new Sunny.UI.UIRichTextBox();
            this.bgw = new System.ComponentModel.BackgroundWorker();
            this.uiContextMenuStrip1 = new Sunny.UI.UIContextMenuStrip();
            this.uiContextMenuStrip2 = new Sunny.UI.UIContextMenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.uiGroupBox1.SuspendLayout();
            this.uiGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_commail)).BeginInit();
            this.uiGroupBox3.SuspendLayout();
            this.uiGroupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.label1);
            this.uiGroupBox1.Controls.Add(this.CB_product_type);
            this.uiGroupBox1.Controls.Add(this.uiLabel7);
            this.uiGroupBox1.Controls.Add(this.CB_situation);
            this.uiGroupBox1.Controls.Add(this.Btn_send_mail);
            this.uiGroupBox1.Controls.Add(this.uiLabel3);
            this.uiGroupBox1.Controls.Add(this.Btn_sendget);
            this.uiGroupBox1.Controls.Add(this.dtp_end);
            this.uiGroupBox1.Controls.Add(this.dtp_start);
            this.uiGroupBox1.Controls.Add(this.uiLabel2);
            this.uiGroupBox1.Controls.Add(this.uiLabel1);
            this.uiGroupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiGroupBox1.Location = new System.Drawing.Point(8, 10);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.Radius = 20;
            this.uiGroupBox1.Size = new System.Drawing.Size(709, 152);
            this.uiGroupBox1.TabIndex = 4;
            this.uiGroupBox1.Text = "查詢";
            // 
            // CB_product_type
            // 
            this.CB_product_type.FillColor = System.Drawing.Color.White;
            this.CB_product_type.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.CB_product_type.Location = new System.Drawing.Point(185, 115);
            this.CB_product_type.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CB_product_type.MinimumSize = new System.Drawing.Size(63, 0);
            this.CB_product_type.Name = "CB_product_type";
            this.CB_product_type.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.CB_product_type.Radius = 20;
            this.CB_product_type.Size = new System.Drawing.Size(150, 29);
            this.CB_product_type.TabIndex = 11;
            this.CB_product_type.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel7
            // 
            this.uiLabel7.AutoSize = true;
            this.uiLabel7.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabel7.Location = new System.Drawing.Point(193, 89);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(74, 21);
            this.uiLabel7.TabIndex = 10;
            this.uiLabel7.Text = "產品種類";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CB_situation
            // 
            this.CB_situation.FillColor = System.Drawing.Color.White;
            this.CB_situation.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.CB_situation.Location = new System.Drawing.Point(185, 55);
            this.CB_situation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CB_situation.MinimumSize = new System.Drawing.Size(63, 0);
            this.CB_situation.Name = "CB_situation";
            this.CB_situation.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.CB_situation.Radius = 20;
            this.CB_situation.Size = new System.Drawing.Size(150, 29);
            this.CB_situation.TabIndex = 9;
            this.CB_situation.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_send_mail
            // 
            this.Btn_send_mail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_send_mail.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.Btn_send_mail.Location = new System.Drawing.Point(521, 68);
            this.Btn_send_mail.Name = "Btn_send_mail";
            this.Btn_send_mail.Size = new System.Drawing.Size(150, 64);
            this.Btn_send_mail.TabIndex = 7;
            this.Btn_send_mail.Text = "寄出";
            this.Btn_send_mail.Click += new System.EventHandler(this.Btn_send_mail_Click);
            // 
            // uiLabel3
            // 
            this.uiLabel3.AutoSize = true;
            this.uiLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(193, 29);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(42, 21);
            this.uiLabel3.TabIndex = 8;
            this.uiLabel3.Text = "狀態";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_sendget
            // 
            this.Btn_sendget.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_sendget.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.Btn_sendget.Location = new System.Drawing.Point(365, 67);
            this.Btn_sendget.Name = "Btn_sendget";
            this.Btn_sendget.Size = new System.Drawing.Size(150, 65);
            this.Btn_sendget.TabIndex = 1;
            this.Btn_sendget.Text = "查詢";
            this.Btn_sendget.Click += new System.EventHandler(this.Btn_sendget_Click);
            // 
            // dtp_end
            // 
            this.dtp_end.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.dtp_end.FillColor = System.Drawing.Color.White;
            this.dtp_end.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.dtp_end.Location = new System.Drawing.Point(18, 115);
            this.dtp_end.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtp_end.MinimumSize = new System.Drawing.Size(63, 0);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.dtp_end.Radius = 20;
            this.dtp_end.Size = new System.Drawing.Size(150, 29);
            this.dtp_end.SymbolDropDown = 61555;
            this.dtp_end.SymbolNormal = 61555;
            this.dtp_end.TabIndex = 3;
            this.dtp_end.Text = "2020-07-28";
            this.dtp_end.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dtp_end.Value = new System.DateTime(2020, 7, 28, 16, 21, 25, 734);
            // 
            // dtp_start
            // 
            this.dtp_start.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.dtp_start.FillColor = System.Drawing.Color.White;
            this.dtp_start.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.dtp_start.Location = new System.Drawing.Point(18, 55);
            this.dtp_start.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtp_start.MinimumSize = new System.Drawing.Size(63, 0);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.dtp_start.Radius = 20;
            this.dtp_start.Size = new System.Drawing.Size(150, 29);
            this.dtp_start.SymbolDropDown = 61555;
            this.dtp_start.SymbolNormal = 61555;
            this.dtp_start.TabIndex = 2;
            this.dtp_start.Text = "2020-07-28";
            this.dtp_start.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dtp_start.Value = new System.DateTime(2020, 7, 28, 16, 21, 25, 734);
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(26, 89);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(74, 21);
            this.uiLabel2.TabIndex = 1;
            this.uiLabel2.Text = "結束日期";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(26, 29);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(74, 21);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "開始日期";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Controls.Add(this.dgv_commail);
            this.uiGroupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiGroupBox2.Location = new System.Drawing.Point(12, 170);
            this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox2.Radius = 20;
            this.uiGroupBox2.Size = new System.Drawing.Size(708, 562);
            this.uiGroupBox2.TabIndex = 5;
            this.uiGroupBox2.Text = "寄出資料";
            // 
            // dgv_commail
            // 
            this.dgv_commail.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgv_commail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_commail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_commail.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgv_commail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_commail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_commail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_commail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_commail.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_commail.EnableHeadersVisualStyles = false;
            this.dgv_commail.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.dgv_commail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgv_commail.Location = new System.Drawing.Point(3, 26);
            this.dgv_commail.Name = "dgv_commail";
            this.dgv_commail.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgv_commail.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgv_commail.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_commail.RowTemplate.Height = 29;
            this.dgv_commail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_commail.SelectedIndex = -1;
            this.dgv_commail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_commail.Size = new System.Drawing.Size(702, 533);
            this.dgv_commail.TabIndex = 5;
            this.dgv_commail.TagString = null;
            this.dgv_commail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_commail_CellContentClick);
            this.dgv_commail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_commail_KeyDown);
            // 
            // uiGroupBox3
            // 
            this.uiGroupBox3.Controls.Add(this.uiLabel8);
            this.uiGroupBox3.Controls.Add(this.Btn_change);
            this.uiGroupBox3.Controls.Add(this.TB_filepath);
            this.uiGroupBox3.Controls.Add(this.uiButton1);
            this.uiGroupBox3.Controls.Add(this.uiLabel9);
            this.uiGroupBox3.Controls.Add(this.TB_title);
            this.uiGroupBox3.Controls.Add(this.webView);
            this.uiGroupBox3.Controls.Add(this.uiGroupBox4);
            this.uiGroupBox3.Controls.Add(this.uiLabel6);
            this.uiGroupBox3.Controls.Add(this.TB_ask_product);
            this.uiGroupBox3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiGroupBox3.Location = new System.Drawing.Point(725, 10);
            this.uiGroupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox3.Name = "uiGroupBox3";
            this.uiGroupBox3.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox3.Radius = 20;
            this.uiGroupBox3.Size = new System.Drawing.Size(685, 722);
            this.uiGroupBox3.TabIndex = 8;
            this.uiGroupBox3.Text = "寄出內容";
            // 
            // uiLabel8
            // 
            this.uiLabel8.AutoSize = true;
            this.uiLabel8.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabel8.Location = new System.Drawing.Point(356, 123);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(42, 21);
            this.uiLabel8.TabIndex = 12;
            this.uiLabel8.Text = "附件";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_change
            // 
            this.Btn_change.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_change.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.Btn_change.Location = new System.Drawing.Point(288, 121);
            this.Btn_change.Name = "Btn_change";
            this.Btn_change.Size = new System.Drawing.Size(57, 27);
            this.Btn_change.TabIndex = 17;
            this.Btn_change.Text = "修改";
            this.Btn_change.Click += new System.EventHandler(this.uiButton2_Click);
            // 
            // TB_filepath
            // 
            this.TB_filepath.AutoWordSelection = true;
            this.TB_filepath.FillColor = System.Drawing.Color.White;
            this.TB_filepath.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.TB_filepath.Location = new System.Drawing.Point(407, 115);
            this.TB_filepath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_filepath.Name = "TB_filepath";
            this.TB_filepath.Padding = new System.Windows.Forms.Padding(2);
            this.TB_filepath.Radius = 15;
            this.TB_filepath.Size = new System.Drawing.Size(208, 37);
            this.TB_filepath.TabIndex = 9;
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiButton1.Location = new System.Drawing.Point(619, 121);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(57, 27);
            this.uiButton1.TabIndex = 12;
            this.uiButton1.Text = "查詢";
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // uiLabel9
            // 
            this.uiLabel9.AutoSize = true;
            this.uiLabel9.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabel9.Location = new System.Drawing.Point(16, 160);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(74, 21);
            this.uiLabel9.TabIndex = 16;
            this.uiLabel9.Text = "信件標頭";
            this.uiLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_title
            // 
            this.TB_title.AutoWordSelection = true;
            this.TB_title.FillColor = System.Drawing.Color.White;
            this.TB_title.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.TB_title.Location = new System.Drawing.Point(98, 156);
            this.TB_title.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_title.Name = "TB_title";
            this.TB_title.Padding = new System.Windows.Forms.Padding(2);
            this.TB_title.Radius = 15;
            this.TB_title.Size = new System.Drawing.Size(560, 57);
            this.TB_title.TabIndex = 9;
            // 
            // webView
            // 
            this.webView.CausesValidation = false;
            this.webView.Location = new System.Drawing.Point(14, 221);
            this.webView.MinimumSize = new System.Drawing.Size(20, 20);
            this.webView.Name = "webView";
            this.webView.Size = new System.Drawing.Size(668, 482);
            this.webView.TabIndex = 14;
            this.webView.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // uiGroupBox4
            // 
            this.uiGroupBox4.Controls.Add(this.uiLabel4);
            this.uiGroupBox4.Controls.Add(this.TB_askinfo);
            this.uiGroupBox4.Controls.Add(this.uiLabel5);
            this.uiGroupBox4.Controls.Add(this.TB_product_type);
            this.uiGroupBox4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiGroupBox4.Location = new System.Drawing.Point(11, 25);
            this.uiGroupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox4.Name = "uiGroupBox4";
            this.uiGroupBox4.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox4.Size = new System.Drawing.Size(647, 79);
            this.uiGroupBox4.TabIndex = 13;
            this.uiGroupBox4.Text = "參考資訊";
            // 
            // uiLabel4
            // 
            this.uiLabel4.AutoSize = true;
            this.uiLabel4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabel4.Location = new System.Drawing.Point(6, 32);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(74, 21);
            this.uiLabel4.TabIndex = 10;
            this.uiLabel4.Text = "詢問內容";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_askinfo
            // 
            this.TB_askinfo.AutoWordSelection = true;
            this.TB_askinfo.FillColor = System.Drawing.Color.White;
            this.TB_askinfo.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.TB_askinfo.Location = new System.Drawing.Point(87, 23);
            this.TB_askinfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_askinfo.Name = "TB_askinfo";
            this.TB_askinfo.Padding = new System.Windows.Forms.Padding(2);
            this.TB_askinfo.Radius = 15;
            this.TB_askinfo.Size = new System.Drawing.Size(228, 44);
            this.TB_askinfo.TabIndex = 7;
            // 
            // uiLabel5
            // 
            this.uiLabel5.AutoSize = true;
            this.uiLabel5.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabel5.Location = new System.Drawing.Point(314, 32);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(74, 21);
            this.uiLabel5.TabIndex = 11;
            this.uiLabel5.Text = "產品種類";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_product_type
            // 
            this.TB_product_type.AutoWordSelection = true;
            this.TB_product_type.FillColor = System.Drawing.Color.White;
            this.TB_product_type.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.TB_product_type.Location = new System.Drawing.Point(396, 23);
            this.TB_product_type.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_product_type.Name = "TB_product_type";
            this.TB_product_type.Padding = new System.Windows.Forms.Padding(2);
            this.TB_product_type.Radius = 15;
            this.TB_product_type.Size = new System.Drawing.Size(231, 44);
            this.TB_product_type.TabIndex = 8;
            // 
            // uiLabel6
            // 
            this.uiLabel6.AutoSize = true;
            this.uiLabel6.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabel6.Location = new System.Drawing.Point(10, 126);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(74, 21);
            this.uiLabel6.TabIndex = 12;
            this.uiLabel6.Text = "詢問產品";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_ask_product
            // 
            this.TB_ask_product.AutoWordSelection = true;
            this.TB_ask_product.FillColor = System.Drawing.Color.White;
            this.TB_ask_product.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.TB_ask_product.Location = new System.Drawing.Point(98, 120);
            this.TB_ask_product.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_ask_product.Name = "TB_ask_product";
            this.TB_ask_product.Padding = new System.Windows.Forms.Padding(2);
            this.TB_ask_product.Radius = 15;
            this.TB_ask_product.Size = new System.Drawing.Size(183, 32);
            this.TB_ask_product.TabIndex = 8;
            this.TB_ask_product.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_ask_product_KeyDown);
            // 
            // bgw
            // 
            this.bgw.WorkerReportsProgress = true;
            this.bgw.WorkerSupportsCancellation = true;
            this.bgw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_DoWork);
            this.bgw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.CompleteWork);
            // 
            // uiContextMenuStrip1
            // 
            this.uiContextMenuStrip1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiContextMenuStrip1.Name = "uiContextMenuStrip1";
            this.uiContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // uiContextMenuStrip2
            // 
            this.uiContextMenuStrip2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiContextMenuStrip2.Name = "uiContextMenuStrip2";
            this.uiContextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(651, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "0";
            // 
            // frmAutomail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1421, 754);
            this.Controls.Add(this.uiGroupBox3);
            this.Controls.Add(this.uiGroupBox2);
            this.Controls.Add(this.uiGroupBox1);
            this.Name = "frmAutomail";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAutomail_FormClosed);
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            this.uiGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_commail)).EndInit();
            this.uiGroupBox3.ResumeLayout(false);
            this.uiGroupBox3.PerformLayout();
            this.uiGroupBox4.ResumeLayout(false);
            this.uiGroupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIGroupBox uiGroupBox2;
        private Sunny.UI.UIDatePicker dtp_end;
        private Sunny.UI.UIDatePicker dtp_start;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIButton Btn_sendget;
        private Sunny.UI.UIComboBox CB_situation;
        private Sunny.UI.UIButton Btn_send_mail;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UIGroupBox uiGroupBox3;
        private Sunny.UI.UIGroupBox uiGroupBox4;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UIRichTextBox TB_askinfo;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UIRichTextBox TB_product_type;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UIRichTextBox TB_ask_product;
        private Sunny.UI.UIComboBox CB_product_type;
        private Sunny.UI.UILabel uiLabel7;
        private System.ComponentModel.BackgroundWorker bgw;
        private Sunny.UI.UIContextMenuStrip uiContextMenuStrip1;
        private Sunny.UI.UIContextMenuStrip uiContextMenuStrip2;
        public System.Windows.Forms.WebBrowser webView;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UIRichTextBox TB_title;
        private Sunny.UI.UIRichTextBox TB_filepath;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIDataGridView dgv_commail;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UIButton Btn_change;
        private System.Windows.Forms.Label label1;
    }
}

