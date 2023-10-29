namespace BookManage
{
    partial class adminDefaultPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGBookInfo = new System.Windows.Forms.DataGridView();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnDelBook = new System.Windows.Forms.Button();
            this.btnModifyBook = new System.Windows.Forms.Button();
            this.DGBookDetailInfo = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.lbldetailBookInfo = new System.Windows.Forms.Label();
            this.lblBookInfo = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.roundPanel1 = new BookManage.RoundPanel();
            this.roundPanel2 = new BookManage.RoundPanel();
            ((System.ComponentModel.ISupportInitialize)(this.DGBookInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGBookDetailInfo)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.roundPanel1.SuspendLayout();
            this.roundPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGBookInfo
            // 
            this.DGBookInfo.AllowUserToAddRows = false;
            this.DGBookInfo.AllowUserToDeleteRows = false;
            this.DGBookInfo.AllowUserToResizeColumns = false;
            this.DGBookInfo.AllowUserToResizeRows = false;
            this.DGBookInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGBookInfo.BackgroundColor = System.Drawing.Color.White;
            this.DGBookInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGBookInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGBookInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGBookInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGBookInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGBookInfo.EnableHeadersVisualStyles = false;
            this.DGBookInfo.GridColor = System.Drawing.Color.SteelBlue;
            this.DGBookInfo.Location = new System.Drawing.Point(8, 7);
            this.DGBookInfo.Name = "DGBookInfo";
            this.DGBookInfo.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGBookInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGBookInfo.RowHeadersVisible = false;
            this.DGBookInfo.RowTemplate.Height = 25;
            this.DGBookInfo.Size = new System.Drawing.Size(483, 150);
            this.DGBookInfo.TabIndex = 1;
            this.DGBookInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGBookInfo_CellContentClick);
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(3)))), ((int)(((byte)(79)))));
            this.btnAddBook.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddBook.ForeColor = System.Drawing.Color.White;
            this.btnAddBook.Location = new System.Drawing.Point(150, 229);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(100, 35);
            this.btnAddBook.TabIndex = 2;
            this.btnAddBook.Text = "책 추가";
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnDelBook
            // 
            this.btnDelBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(3)))), ((int)(((byte)(79)))));
            this.btnDelBook.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelBook.ForeColor = System.Drawing.Color.White;
            this.btnDelBook.Location = new System.Drawing.Point(360, 229);
            this.btnDelBook.Name = "btnDelBook";
            this.btnDelBook.Size = new System.Drawing.Size(100, 35);
            this.btnDelBook.TabIndex = 3;
            this.btnDelBook.Text = "책 삭제";
            this.btnDelBook.UseVisualStyleBackColor = false;
            this.btnDelBook.Click += new System.EventHandler(this.btnDelBook_Click);
            // 
            // btnModifyBook
            // 
            this.btnModifyBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(3)))), ((int)(((byte)(79)))));
            this.btnModifyBook.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModifyBook.ForeColor = System.Drawing.Color.White;
            this.btnModifyBook.Location = new System.Drawing.Point(256, 229);
            this.btnModifyBook.Name = "btnModifyBook";
            this.btnModifyBook.Size = new System.Drawing.Size(100, 35);
            this.btnModifyBook.TabIndex = 4;
            this.btnModifyBook.Text = "책 정보 수정";
            this.btnModifyBook.UseVisualStyleBackColor = false;
            this.btnModifyBook.Click += new System.EventHandler(this.btnModifyBook_Click);
            // 
            // DGBookDetailInfo
            // 
            this.DGBookDetailInfo.AllowUserToAddRows = false;
            this.DGBookDetailInfo.AllowUserToDeleteRows = false;
            this.DGBookDetailInfo.AllowUserToResizeColumns = false;
            this.DGBookDetailInfo.AllowUserToResizeRows = false;
            this.DGBookDetailInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGBookDetailInfo.BackgroundColor = System.Drawing.Color.White;
            this.DGBookDetailInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGBookDetailInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGBookDetailInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGBookDetailInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGBookDetailInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGBookDetailInfo.EnableHeadersVisualStyles = false;
            this.DGBookDetailInfo.GridColor = System.Drawing.Color.SteelBlue;
            this.DGBookDetailInfo.Location = new System.Drawing.Point(8, 9);
            this.DGBookDetailInfo.Name = "DGBookDetailInfo";
            this.DGBookDetailInfo.ReadOnly = true;
            this.DGBookDetailInfo.RowHeadersVisible = false;
            this.DGBookDetailInfo.RowTemplate.Height = 25;
            this.DGBookDetailInfo.Size = new System.Drawing.Size(484, 168);
            this.DGBookDetailInfo.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 25);
            this.panel1.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.도움말ToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(535, 23);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 도움말ToolStripMenuItem
            // 
            this.도움말ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpInfo});
            this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            this.도움말ToolStripMenuItem.Size = new System.Drawing.Size(72, 19);
            this.도움말ToolStripMenuItem.Text = "도움말(&H)";
            // 
            // HelpInfo
            // 
            this.HelpInfo.Name = "HelpInfo";
            this.HelpInfo.Size = new System.Drawing.Size(154, 22);
            this.HelpInfo.Text = "도움말 정보(&A)";
            this.HelpInfo.Click += new System.EventHandler(this.HelpInfo_Click);
            // 
            // lbldetailBookInfo
            // 
            this.lbldetailBookInfo.AutoSize = true;
            this.lbldetailBookInfo.Font = new System.Drawing.Font("Malgun Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbldetailBookInfo.ForeColor = System.Drawing.Color.White;
            this.lbldetailBookInfo.Location = new System.Drawing.Point(25, 240);
            this.lbldetailBookInfo.Name = "lbldetailBookInfo";
            this.lbldetailBookInfo.Size = new System.Drawing.Size(84, 25);
            this.lbldetailBookInfo.TabIndex = 7;
            this.lbldetailBookInfo.Text = "세부정보";
            // 
            // lblBookInfo
            // 
            this.lblBookInfo.AutoSize = true;
            this.lblBookInfo.Font = new System.Drawing.Font("Malgun Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBookInfo.ForeColor = System.Drawing.Color.White;
            this.lblBookInfo.Location = new System.Drawing.Point(25, 36);
            this.lblBookInfo.Name = "lblBookInfo";
            this.lblBookInfo.Size = new System.Drawing.Size(114, 25);
            this.lblBookInfo.TabIndex = 8;
            this.lblBookInfo.Text = "현재 책 정보";
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(3)))), ((int)(((byte)(79)))));
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(418, 36);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(75, 23);
            this.btn_logout.TabIndex = 9;
            this.btn_logout.Text = "로그아웃";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // roundPanel1
            // 
            this.roundPanel1.BackColor = System.Drawing.Color.SteelBlue;
            this.roundPanel1.BorderColor = System.Drawing.Color.White;
            this.roundPanel1.BorderRadius = 20;
            this.roundPanel1.BorderThickness = 5F;
            this.roundPanel1.Controls.Add(this.DGBookInfo);
            this.roundPanel1.Location = new System.Drawing.Point(23, 61);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Size = new System.Drawing.Size(500, 163);
            this.roundPanel1.TabIndex = 10;
            // 
            // roundPanel2
            // 
            this.roundPanel2.BackColor = System.Drawing.Color.SteelBlue;
            this.roundPanel2.BorderColor = System.Drawing.Color.White;
            this.roundPanel2.BorderRadius = 20;
            this.roundPanel2.BorderThickness = 5F;
            this.roundPanel2.Controls.Add(this.DGBookDetailInfo);
            this.roundPanel2.Location = new System.Drawing.Point(22, 270);
            this.roundPanel2.Name = "roundPanel2";
            this.roundPanel2.Size = new System.Drawing.Size(501, 187);
            this.roundPanel2.TabIndex = 11;
            // 
            // adminDefaultPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(3)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(535, 474);
            this.Controls.Add(this.roundPanel2);
            this.Controls.Add(this.roundPanel1);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.lblBookInfo);
            this.Controls.Add(this.lbldetailBookInfo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnModifyBook);
            this.Controls.Add(this.btnDelBook);
            this.Controls.Add(this.btnAddBook);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "adminDefaultPage";
            this.Text = "관리자 페이지";
            this.Load += new System.EventHandler(this.adminDefaultPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGBookInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGBookDetailInfo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.roundPanel1.ResumeLayout(false);
            this.roundPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView DGBookInfo;
        private Button btnAddBook;
        private Button btnDelBook;
        private Button btnModifyBook;
        private DataGridView DGBookDetailInfo;
        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 도움말ToolStripMenuItem;
        private ToolStripMenuItem HelpInfo;
        private Label lbldetailBookInfo;
        private Label lblBookInfo;
        private Button btn_logout;
        private RoundPanel roundPanel1;
        private RoundPanel roundPanel2;
    }
}