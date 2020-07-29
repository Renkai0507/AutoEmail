namespace AutoEmail
{
    partial class Form1
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
            this.uiDataGridView1 = new Sunny.UI.UIDataGridView();
            this.Send = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Cust_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Creat_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ask_info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sendbody = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.uiComboBox1 = new Sunny.UI.UIComboBox();
            this.uiButton2 = new Sunny.UI.UIButton();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.uiDatePicker2 = new Sunny.UI.UIDatePicker();
            this.uiDatePicker1 = new Sunny.UI.UIDatePicker();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiGroupBox2 = new Sunny.UI.UIGroupBox();
            this.uiRichTextBox1 = new Sunny.UI.UIRichTextBox();
            this.uiGroupBox3 = new Sunny.UI.UIGroupBox();
            this.uiGroupBox4 = new Sunny.UI.UIGroupBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiRichTextBox2 = new Sunny.UI.UIRichTextBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiRichTextBox3 = new Sunny.UI.UIRichTextBox();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.uiRichTextBox4 = new Sunny.UI.UIRichTextBox();
            this.uiComboBox2 = new Sunny.UI.UIComboBox();
            this.uiLabel7 = new Sunny.UI.UILabel();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            this.uiGroupBox2.SuspendLayout();
            this.uiGroupBox3.SuspendLayout();
            this.uiGroupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiDataGridView1
            // 
            this.uiDataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.uiDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.uiDataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.uiDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.uiDataGridView1.ColumnHeadersHeight = 32;
            this.uiDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.uiDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Send,
            this.Cust_name,
            this.Creat_date,
            this.Ask_info,
            this.Product_type,
            this.EMail,
            this.Sendbody});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uiDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.uiDataGridView1.EnableHeadersVisualStyles = false;
            this.uiDataGridView1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.Location = new System.Drawing.Point(16, 41);
            this.uiDataGridView1.Name = "uiDataGridView1";
            this.uiDataGridView1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.uiDataGridView1.RowTemplate.Height = 29;
            this.uiDataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.uiDataGridView1.SelectedIndex = -1;
            this.uiDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiDataGridView1.Size = new System.Drawing.Size(682, 502);
            this.uiDataGridView1.TabIndex = 3;
            this.uiDataGridView1.TagString = null;
            // 
            // Send
            // 
            this.Send.FillWeight = 10F;
            this.Send.HeaderText = "寄信";
            this.Send.Name = "Send";
            this.Send.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Send.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Cust_name
            // 
            this.Cust_name.FillWeight = 92.978F;
            this.Cust_name.HeaderText = "客戶名稱";
            this.Cust_name.Name = "Cust_name";
            this.Cust_name.ReadOnly = true;
            // 
            // Creat_date
            // 
            this.Creat_date.FillWeight = 92.978F;
            this.Creat_date.HeaderText = "建單日期";
            this.Creat_date.Name = "Creat_date";
            this.Creat_date.ReadOnly = true;
            // 
            // Ask_info
            // 
            this.Ask_info.FillWeight = 92.978F;
            this.Ask_info.HeaderText = "詢問內容";
            this.Ask_info.Name = "Ask_info";
            this.Ask_info.ReadOnly = true;
            // 
            // Product_type
            // 
            this.Product_type.FillWeight = 92.978F;
            this.Product_type.HeaderText = "產品種類";
            this.Product_type.Name = "Product_type";
            this.Product_type.ReadOnly = true;
            // 
            // EMail
            // 
            this.EMail.FillWeight = 92.978F;
            this.EMail.HeaderText = "信箱";
            this.EMail.Name = "EMail";
            this.EMail.ReadOnly = true;
            // 
            // Sendbody
            // 
            this.Sendbody.FillWeight = 92.978F;
            this.Sendbody.HeaderText = "寄出內容";
            this.Sendbody.Name = "Sendbody";
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.uiComboBox2);
            this.uiGroupBox1.Controls.Add(this.uiLabel7);
            this.uiGroupBox1.Controls.Add(this.uiComboBox1);
            this.uiGroupBox1.Controls.Add(this.uiButton2);
            this.uiGroupBox1.Controls.Add(this.uiLabel3);
            this.uiGroupBox1.Controls.Add(this.uiButton1);
            this.uiGroupBox1.Controls.Add(this.uiDatePicker2);
            this.uiGroupBox1.Controls.Add(this.uiDatePicker1);
            this.uiGroupBox1.Controls.Add(this.uiLabel2);
            this.uiGroupBox1.Controls.Add(this.uiLabel1);
            this.uiGroupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiGroupBox1.Location = new System.Drawing.Point(16, 14);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.Radius = 20;
            this.uiGroupBox1.Size = new System.Drawing.Size(709, 152);
            this.uiGroupBox1.TabIndex = 4;
            this.uiGroupBox1.Text = "查詢";
            // 
            // uiComboBox1
            // 
            this.uiComboBox1.FillColor = System.Drawing.Color.White;
            this.uiComboBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiComboBox1.Location = new System.Drawing.Point(185, 55);
            this.uiComboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox1.Name = "uiComboBox1";
            this.uiComboBox1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.uiComboBox1.Radius = 20;
            this.uiComboBox1.Size = new System.Drawing.Size(150, 29);
            this.uiComboBox1.TabIndex = 9;
            this.uiComboBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiButton2.Location = new System.Drawing.Point(521, 68);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Size = new System.Drawing.Size(150, 64);
            this.uiButton2.TabIndex = 7;
            this.uiButton2.Text = "寄出";
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
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiButton1.Location = new System.Drawing.Point(365, 67);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(150, 65);
            this.uiButton1.TabIndex = 1;
            this.uiButton1.Text = "查詢";
            // 
            // uiDatePicker2
            // 
            this.uiDatePicker2.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.uiDatePicker2.FillColor = System.Drawing.Color.White;
            this.uiDatePicker2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiDatePicker2.Location = new System.Drawing.Point(18, 115);
            this.uiDatePicker2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiDatePicker2.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiDatePicker2.Name = "uiDatePicker2";
            this.uiDatePicker2.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.uiDatePicker2.Radius = 20;
            this.uiDatePicker2.Size = new System.Drawing.Size(150, 29);
            this.uiDatePicker2.SymbolDropDown = 61555;
            this.uiDatePicker2.SymbolNormal = 61555;
            this.uiDatePicker2.TabIndex = 3;
            this.uiDatePicker2.Text = "2020-07-28";
            this.uiDatePicker2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiDatePicker2.Value = new System.DateTime(2020, 7, 28, 16, 21, 25, 734);
            // 
            // uiDatePicker1
            // 
            this.uiDatePicker1.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.uiDatePicker1.FillColor = System.Drawing.Color.White;
            this.uiDatePicker1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiDatePicker1.Location = new System.Drawing.Point(18, 55);
            this.uiDatePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiDatePicker1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiDatePicker1.Name = "uiDatePicker1";
            this.uiDatePicker1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.uiDatePicker1.Radius = 20;
            this.uiDatePicker1.Size = new System.Drawing.Size(150, 29);
            this.uiDatePicker1.SymbolDropDown = 61555;
            this.uiDatePicker1.SymbolNormal = 61555;
            this.uiDatePicker1.TabIndex = 2;
            this.uiDatePicker1.Text = "2020-07-28";
            this.uiDatePicker1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiDatePicker1.Value = new System.DateTime(2020, 7, 28, 16, 21, 25, 734);
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
            this.uiGroupBox2.Controls.Add(this.uiDataGridView1);
            this.uiGroupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiGroupBox2.Location = new System.Drawing.Point(17, 174);
            this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox2.Radius = 20;
            this.uiGroupBox2.Size = new System.Drawing.Size(708, 562);
            this.uiGroupBox2.TabIndex = 5;
            this.uiGroupBox2.Text = "寄出資料";
            // 
            // uiRichTextBox1
            // 
            this.uiRichTextBox1.AutoWordSelection = true;
            this.uiRichTextBox1.FillColor = System.Drawing.Color.White;
            this.uiRichTextBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiRichTextBox1.Location = new System.Drawing.Point(4, 174);
            this.uiRichTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiRichTextBox1.Name = "uiRichTextBox1";
            this.uiRichTextBox1.Padding = new System.Windows.Forms.Padding(2);
            this.uiRichTextBox1.Size = new System.Drawing.Size(677, 534);
            this.uiRichTextBox1.TabIndex = 6;
            // 
            // uiGroupBox3
            // 
            this.uiGroupBox3.Controls.Add(this.uiGroupBox4);
            this.uiGroupBox3.Controls.Add(this.uiLabel6);
            this.uiGroupBox3.Controls.Add(this.uiRichTextBox4);
            this.uiGroupBox3.Controls.Add(this.uiRichTextBox1);
            this.uiGroupBox3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiGroupBox3.Location = new System.Drawing.Point(733, 14);
            this.uiGroupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox3.Name = "uiGroupBox3";
            this.uiGroupBox3.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox3.Radius = 20;
            this.uiGroupBox3.Size = new System.Drawing.Size(685, 722);
            this.uiGroupBox3.TabIndex = 8;
            this.uiGroupBox3.Text = "寄出內容";
            // 
            // uiGroupBox4
            // 
            this.uiGroupBox4.Controls.Add(this.uiLabel4);
            this.uiGroupBox4.Controls.Add(this.uiRichTextBox2);
            this.uiGroupBox4.Controls.Add(this.uiLabel5);
            this.uiGroupBox4.Controls.Add(this.uiRichTextBox3);
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
            // uiRichTextBox2
            // 
            this.uiRichTextBox2.AutoWordSelection = true;
            this.uiRichTextBox2.FillColor = System.Drawing.Color.White;
            this.uiRichTextBox2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiRichTextBox2.Location = new System.Drawing.Point(87, 23);
            this.uiRichTextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiRichTextBox2.Name = "uiRichTextBox2";
            this.uiRichTextBox2.Padding = new System.Windows.Forms.Padding(2);
            this.uiRichTextBox2.Radius = 15;
            this.uiRichTextBox2.Size = new System.Drawing.Size(228, 44);
            this.uiRichTextBox2.TabIndex = 7;
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
            // uiRichTextBox3
            // 
            this.uiRichTextBox3.AutoWordSelection = true;
            this.uiRichTextBox3.FillColor = System.Drawing.Color.White;
            this.uiRichTextBox3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiRichTextBox3.Location = new System.Drawing.Point(396, 23);
            this.uiRichTextBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiRichTextBox3.Name = "uiRichTextBox3";
            this.uiRichTextBox3.Padding = new System.Windows.Forms.Padding(2);
            this.uiRichTextBox3.Radius = 15;
            this.uiRichTextBox3.Size = new System.Drawing.Size(235, 44);
            this.uiRichTextBox3.TabIndex = 8;
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
            // uiRichTextBox4
            // 
            this.uiRichTextBox4.AutoWordSelection = true;
            this.uiRichTextBox4.FillColor = System.Drawing.Color.White;
            this.uiRichTextBox4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiRichTextBox4.Location = new System.Drawing.Point(98, 115);
            this.uiRichTextBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiRichTextBox4.Name = "uiRichTextBox4";
            this.uiRichTextBox4.Padding = new System.Windows.Forms.Padding(2);
            this.uiRichTextBox4.Radius = 15;
            this.uiRichTextBox4.Size = new System.Drawing.Size(231, 49);
            this.uiRichTextBox4.TabIndex = 8;
            // 
            // uiComboBox2
            // 
            this.uiComboBox2.FillColor = System.Drawing.Color.White;
            this.uiComboBox2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiComboBox2.Location = new System.Drawing.Point(185, 115);
            this.uiComboBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox2.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox2.Name = "uiComboBox2";
            this.uiComboBox2.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.uiComboBox2.Radius = 20;
            this.uiComboBox2.Size = new System.Drawing.Size(150, 29);
            this.uiComboBox2.TabIndex = 11;
            this.uiComboBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1431, 996);
            this.Controls.Add(this.uiGroupBox3);
            this.Controls.Add(this.uiGroupBox2);
            this.Controls.Add(this.uiGroupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            this.uiGroupBox2.ResumeLayout(false);
            this.uiGroupBox3.ResumeLayout(false);
            this.uiGroupBox3.PerformLayout();
            this.uiGroupBox4.ResumeLayout(false);
            this.uiGroupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIDataGridView uiDataGridView1;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIGroupBox uiGroupBox2;
        private Sunny.UI.UIDatePicker uiDatePicker2;
        private Sunny.UI.UIDatePicker uiDatePicker1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIRichTextBox uiRichTextBox1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Send;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cust_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Creat_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ask_info;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sendbody;
        private Sunny.UI.UIComboBox uiComboBox1;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UIGroupBox uiGroupBox3;
        private Sunny.UI.UIGroupBox uiGroupBox4;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UIRichTextBox uiRichTextBox2;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UIRichTextBox uiRichTextBox3;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UIRichTextBox uiRichTextBox4;
        private Sunny.UI.UIComboBox uiComboBox2;
        private Sunny.UI.UILabel uiLabel7;
    }
}

