namespace AutoEmail
{
    partial class frmQuestList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiGroupBox2 = new Sunny.UI.UIGroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_commail = new Sunny.UI.UIDataGridView();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.CB_product_type = new Sunny.UI.UIComboBox();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.CB_situation = new Sunny.UI.UIComboBox();
            this.Btn_sendget = new Sunny.UI.UIButton();
            this.dtp_end = new Sunny.UI.UIDatePicker();
            this.dtp_start = new Sunny.UI.UIDatePicker();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.CB_attribute = new Sunny.UI.UIComboBox();
            this.uiLabel10 = new Sunny.UI.UILabel();
            this.uiGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_commail)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Controls.Add(this.label1);
            this.uiGroupBox2.Controls.Add(this.dgv_commail);
            this.uiGroupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiGroupBox2.Location = new System.Drawing.Point(207, 14);
            this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox2.Radius = 20;
            this.uiGroupBox2.Size = new System.Drawing.Size(748, 595);
            this.uiGroupBox2.TabIndex = 12;
            this.uiGroupBox2.Text = "寄出資料";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(677, -5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "0";
            // 
            // dgv_commail
            // 
            this.dgv_commail.AllowUserToAddRows = false;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgv_commail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle29;
            this.dgv_commail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_commail.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgv_commail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_commail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_commail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.dgv_commail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_commail.DefaultCellStyle = dataGridViewCellStyle31;
            this.dgv_commail.EnableHeadersVisualStyles = false;
            this.dgv_commail.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.dgv_commail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgv_commail.Location = new System.Drawing.Point(12, 35);
            this.dgv_commail.Name = "dgv_commail";
            this.dgv_commail.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgv_commail.RowHeadersVisible = false;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.White;
            this.dgv_commail.RowsDefaultCellStyle = dataGridViewCellStyle32;
            this.dgv_commail.RowTemplate.Height = 29;
            this.dgv_commail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_commail.SelectedIndex = -1;
            this.dgv_commail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_commail.Size = new System.Drawing.Size(728, 531);
            this.dgv_commail.TabIndex = 5;
            this.dgv_commail.TagString = null;
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiButton1.Location = new System.Drawing.Point(18, 418);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(148, 73);
            this.uiButton1.TabIndex = 11;
            this.uiButton1.Text = "匯出名單";
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(26, 84);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(74, 21);
            this.uiLabel2.TabIndex = 1;
            this.uiLabel2.Text = "結束日期";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.AutoSize = true;
            this.uiLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(30, 145);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(42, 21);
            this.uiLabel3.TabIndex = 8;
            this.uiLabel3.Text = "狀態";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.uiLabel10);
            this.uiGroupBox1.Controls.Add(this.CB_attribute);
            this.uiGroupBox1.Controls.Add(this.CB_product_type);
            this.uiGroupBox1.Controls.Add(this.uiButton1);
            this.uiGroupBox1.Controls.Add(this.uiLabel7);
            this.uiGroupBox1.Controls.Add(this.CB_situation);
            this.uiGroupBox1.Controls.Add(this.Btn_sendget);
            this.uiGroupBox1.Controls.Add(this.uiLabel3);
            this.uiGroupBox1.Controls.Add(this.dtp_end);
            this.uiGroupBox1.Controls.Add(this.dtp_start);
            this.uiGroupBox1.Controls.Add(this.uiLabel2);
            this.uiGroupBox1.Controls.Add(this.uiLabel1);
            this.uiGroupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiGroupBox1.Location = new System.Drawing.Point(3, 15);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.Radius = 20;
            this.uiGroupBox1.Size = new System.Drawing.Size(183, 565);
            this.uiGroupBox1.TabIndex = 10;
            this.uiGroupBox1.Text = "查詢";
            // 
            // CB_product_type
            // 
            this.CB_product_type.FillColor = System.Drawing.Color.White;
            this.CB_product_type.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.CB_product_type.Location = new System.Drawing.Point(18, 227);
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
            this.uiLabel7.Location = new System.Drawing.Point(21, 204);
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
            this.CB_situation.Location = new System.Drawing.Point(18, 171);
            this.CB_situation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CB_situation.MinimumSize = new System.Drawing.Size(63, 0);
            this.CB_situation.Name = "CB_situation";
            this.CB_situation.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.CB_situation.Radius = 20;
            this.CB_situation.Size = new System.Drawing.Size(150, 29);
            this.CB_situation.TabIndex = 9;
            this.CB_situation.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_sendget
            // 
            this.Btn_sendget.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_sendget.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.Btn_sendget.Location = new System.Drawing.Point(18, 350);
            this.Btn_sendget.Name = "Btn_sendget";
            this.Btn_sendget.Size = new System.Drawing.Size(98, 49);
            this.Btn_sendget.TabIndex = 1;
            this.Btn_sendget.Text = "查詢";
            this.Btn_sendget.Click += new System.EventHandler(this.Btn_sendget_Click_1);
            // 
            // dtp_end
            // 
            this.dtp_end.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.dtp_end.FillColor = System.Drawing.Color.White;
            this.dtp_end.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.dtp_end.Location = new System.Drawing.Point(18, 110);
            this.dtp_end.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtp_end.MinimumSize = new System.Drawing.Size(63, 0);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.dtp_end.Radius = 20;
            this.dtp_end.Size = new System.Drawing.Size(150, 29);
            this.dtp_end.SymbolDropDown = 61555;
            this.dtp_end.SymbolNormal = 61555;
            this.dtp_end.TabIndex = 3;
            this.dtp_end.Text = "2021-02-09";
            this.dtp_end.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dtp_end.Value = new System.DateTime(2021, 2, 9, 0, 0, 0, 0);
            // 
            // dtp_start
            // 
            this.dtp_start.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.dtp_start.FillColor = System.Drawing.Color.White;
            this.dtp_start.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.dtp_start.Location = new System.Drawing.Point(18, 50);
            this.dtp_start.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtp_start.MinimumSize = new System.Drawing.Size(63, 0);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.dtp_start.Radius = 20;
            this.dtp_start.Size = new System.Drawing.Size(150, 29);
            this.dtp_start.SymbolDropDown = 61555;
            this.dtp_start.SymbolNormal = 61555;
            this.dtp_start.TabIndex = 2;
            this.dtp_start.Text = "2021-02-09";
            this.dtp_start.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dtp_start.Value = new System.DateTime(2021, 2, 9, 0, 0, 0, 0);
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(26, 24);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(74, 21);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "開始日期";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CB_attribute
            // 
            this.CB_attribute.FillColor = System.Drawing.Color.White;
            this.CB_attribute.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.CB_attribute.Location = new System.Drawing.Point(16, 293);
            this.CB_attribute.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CB_attribute.MinimumSize = new System.Drawing.Size(63, 0);
            this.CB_attribute.Name = "CB_attribute";
            this.CB_attribute.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.CB_attribute.Radius = 20;
            this.CB_attribute.Size = new System.Drawing.Size(150, 29);
            this.CB_attribute.TabIndex = 12;
            this.CB_attribute.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel10
            // 
            this.uiLabel10.AutoSize = true;
            this.uiLabel10.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabel10.Location = new System.Drawing.Point(21, 262);
            this.uiLabel10.Name = "uiLabel10";
            this.uiLabel10.Size = new System.Drawing.Size(74, 21);
            this.uiLabel10.TabIndex = 13;
            this.uiLabel10.Text = "客戶類別";
            this.uiLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmQuestList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(977, 662);
            this.Controls.Add(this.uiGroupBox2);
            this.Controls.Add(this.uiGroupBox1);
            this.Name = "frmQuestList";
            this.Text = "QuestList";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmQuestList_FormClosed);
            this.uiGroupBox2.ResumeLayout(false);
            this.uiGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_commail)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIGroupBox uiGroupBox2;
        private System.Windows.Forms.Label label1;
        private Sunny.UI.UIDataGridView dgv_commail;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIComboBox CB_product_type;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UIComboBox CB_situation;
        private Sunny.UI.UIButton Btn_sendget;
        private Sunny.UI.UIDatePicker dtp_end;
        private Sunny.UI.UIDatePicker dtp_start;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIComboBox CB_attribute;
        private Sunny.UI.UILabel uiLabel10;
    }
}