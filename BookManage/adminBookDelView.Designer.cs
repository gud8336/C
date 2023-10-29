namespace BookManage
{
    partial class adminBookDelView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.도움말HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.책삭제도움말AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDel = new System.Windows.Forms.Button();
            this.cbBookName = new System.Windows.Forms.ComboBox();
            this.lblBookName = new System.Windows.Forms.Label();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblAuthorValue = new System.Windows.Forms.Label();
            this.lblPublisherValue = new System.Windows.Forms.Label();
            this.DGBookDetailInfo = new System.Windows.Forms.DataGridView();
            this.lbldetailBookInfo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.roundPanel1 = new BookManage.RoundPanel();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGBookDetailInfo)).BeginInit();
            this.panel2.SuspendLayout();
            this.roundPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(691, 26);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.도움말HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(691, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 도움말HToolStripMenuItem
            // 
            this.도움말HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.책삭제도움말AToolStripMenuItem});
            this.도움말HToolStripMenuItem.Name = "도움말HToolStripMenuItem";
            this.도움말HToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.도움말HToolStripMenuItem.Text = "도움말(&H)";
            // 
            // 책삭제도움말AToolStripMenuItem
            // 
            this.책삭제도움말AToolStripMenuItem.Name = "책삭제도움말AToolStripMenuItem";
            this.책삭제도움말AToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.책삭제도움말AToolStripMenuItem.Text = "책 삭제 도움말(&A)";
            this.책삭제도움말AToolStripMenuItem.Click += new System.EventHandler(this.책삭제도움말AToolStripMenuItem_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDel.Location = new System.Drawing.Point(504, 78);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(87, 71);
            this.btnDel.TabIndex = 1;
            this.btnDel.Text = "책 삭제";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // cbBookName
            // 
            this.cbBookName.BackColor = System.Drawing.SystemColors.Window;
            this.cbBookName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBookName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbBookName.Location = new System.Drawing.Point(1, 1);
            this.cbBookName.Name = "cbBookName";
            this.cbBookName.Size = new System.Drawing.Size(256, 23);
            this.cbBookName.TabIndex = 2;
            this.cbBookName.SelectedIndexChanged += new System.EventHandler(this.cbBookName_SelectedIndexChanged);
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBookName.ForeColor = System.Drawing.Color.White;
            this.lblBookName.Location = new System.Drawing.Point(115, 52);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(72, 20);
            this.lblBookName.TabIndex = 3;
            this.lblBookName.Text = "책 제목 : ";
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPublisher.ForeColor = System.Drawing.Color.White;
            this.lblPublisher.Location = new System.Drawing.Point(120, 120);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(67, 20);
            this.lblPublisher.TabIndex = 11;
            this.lblPublisher.Text = "출판사 : ";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAuthor.ForeColor = System.Drawing.Color.White;
            this.lblAuthor.Location = new System.Drawing.Point(131, 86);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(52, 20);
            this.lblAuthor.TabIndex = 10;
            this.lblAuthor.Text = "저자 : ";
            // 
            // lblAuthorValue
            // 
            this.lblAuthorValue.AutoSize = true;
            this.lblAuthorValue.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAuthorValue.ForeColor = System.Drawing.Color.White;
            this.lblAuthorValue.Location = new System.Drawing.Point(194, 86);
            this.lblAuthorValue.Name = "lblAuthorValue";
            this.lblAuthorValue.Size = new System.Drawing.Size(0, 20);
            this.lblAuthorValue.TabIndex = 16;
            // 
            // lblPublisherValue
            // 
            this.lblPublisherValue.AutoSize = true;
            this.lblPublisherValue.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPublisherValue.ForeColor = System.Drawing.Color.White;
            this.lblPublisherValue.Location = new System.Drawing.Point(194, 116);
            this.lblPublisherValue.Name = "lblPublisherValue";
            this.lblPublisherValue.Size = new System.Drawing.Size(0, 20);
            this.lblPublisherValue.TabIndex = 17;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGBookDetailInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGBookDetailInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGBookDetailInfo.EnableHeadersVisualStyles = false;
            this.DGBookDetailInfo.GridColor = System.Drawing.Color.SteelBlue;
            this.DGBookDetailInfo.Location = new System.Drawing.Point(6, 7);
            this.DGBookDetailInfo.Name = "DGBookDetailInfo";
            this.DGBookDetailInfo.ReadOnly = true;
            this.DGBookDetailInfo.RowHeadersVisible = false;
            this.DGBookDetailInfo.RowTemplate.Height = 25;
            this.DGBookDetailInfo.Size = new System.Drawing.Size(663, 166);
            this.DGBookDetailInfo.TabIndex = 18;
            // 
            // lbldetailBookInfo
            // 
            this.lbldetailBookInfo.AutoSize = true;
            this.lbldetailBookInfo.Font = new System.Drawing.Font("Malgun Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbldetailBookInfo.ForeColor = System.Drawing.Color.White;
            this.lbldetailBookInfo.Location = new System.Drawing.Point(4, 184);
            this.lbldetailBookInfo.Name = "lbldetailBookInfo";
            this.lbldetailBookInfo.Size = new System.Drawing.Size(84, 25);
            this.lbldetailBookInfo.TabIndex = 19;
            this.lbldetailBookInfo.Text = "세부정보";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.cbBookName);
            this.panel2.Location = new System.Drawing.Point(193, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 25);
            this.panel2.TabIndex = 20;
            // 
            // roundPanel1
            // 
            this.roundPanel1.BackColor = System.Drawing.Color.SteelBlue;
            this.roundPanel1.BorderColor = System.Drawing.Color.White;
            this.roundPanel1.BorderRadius = 20;
            this.roundPanel1.BorderThickness = 5F;
            this.roundPanel1.Controls.Add(this.DGBookDetailInfo);
            this.roundPanel1.Location = new System.Drawing.Point(7, 212);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Size = new System.Drawing.Size(675, 181);
            this.roundPanel1.TabIndex = 21;
            // 
            // adminBookDelView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(3)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(691, 396);
            this.Controls.Add(this.roundPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbldetailBookInfo);
            this.Controls.Add(this.lblPublisherValue);
            this.Controls.Add(this.lblAuthorValue);
            this.Controls.Add(this.lblPublisher);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblBookName);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "adminBookDelView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "책 삭제";
            this.Load += new System.EventHandler(this.adminBookDelView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGBookDetailInfo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.roundPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 도움말HToolStripMenuItem;
        private ToolStripMenuItem 책삭제도움말AToolStripMenuItem;
        private Button btnDel;
        private ComboBox cbBookName;
        private Label lblBookName;
        private Label lblPublisher;
        private Label lblAuthor;
        private Label lblAuthorValue;
        private Label lblPublisherValue;
        private DataGridView DGBookDetailInfo;
        private Label lbldetailBookInfo;
        private Panel panel2;
        private RoundPanel roundPanel1;
    }
}