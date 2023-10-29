namespace BookManage
{
    partial class adminBookModifyView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.도움말HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.책정보수정AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnModify = new System.Windows.Forms.Button();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.cbBookName = new System.Windows.Forms.ComboBox();
            this.panDefault = new System.Windows.Forms.Panel();
            this.txtImgPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panChange = new System.Windows.Forms.Panel();
            this.btnChoiceImg = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtChangeBookName = new System.Windows.Forms.TextBox();
            this.txtChangePublisher = new System.Windows.Forms.TextBox();
            this.txtChangeAuthor = new System.Windows.Forms.TextBox();
            this.lblChangePublisher = new System.Windows.Forms.Label();
            this.lblChangeAuthor = new System.Windows.Forms.Label();
            this.lblChangeBookName = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panDefault.SuspendLayout();
            this.panChange.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 26);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.도움말HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(522, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 도움말HToolStripMenuItem
            // 
            this.도움말HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.책정보수정AToolStripMenuItem});
            this.도움말HToolStripMenuItem.Name = "도움말HToolStripMenuItem";
            this.도움말HToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.도움말HToolStripMenuItem.Text = "도움말(&H)";
            // 
            // 책정보수정AToolStripMenuItem
            // 
            this.책정보수정AToolStripMenuItem.Name = "책정보수정AToolStripMenuItem";
            this.책정보수정AToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.책정보수정AToolStripMenuItem.Text = "책 정보 수정 도움말(&A)";
            this.책정보수정AToolStripMenuItem.Click += new System.EventHandler(this.책정보수정AToolStripMenuItem_Click);
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnModify.Location = new System.Drawing.Point(423, 232);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(87, 71);
            this.btnModify.TabIndex = 14;
            this.btnModify.Text = "수정";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // txtPublisher
            // 
            this.txtPublisher.BackColor = System.Drawing.SystemColors.Window;
            this.txtPublisher.Location = new System.Drawing.Point(122, 72);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.ReadOnly = true;
            this.txtPublisher.Size = new System.Drawing.Size(248, 23);
            this.txtPublisher.TabIndex = 13;
            // 
            // txtAuthor
            // 
            this.txtAuthor.BackColor = System.Drawing.SystemColors.Window;
            this.txtAuthor.Location = new System.Drawing.Point(122, 41);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.ReadOnly = true;
            this.txtAuthor.Size = new System.Drawing.Size(248, 23);
            this.txtAuthor.TabIndex = 12;
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPublisher.ForeColor = System.Drawing.Color.White;
            this.lblPublisher.Location = new System.Drawing.Point(45, 71);
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
            this.lblAuthor.Location = new System.Drawing.Point(60, 40);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(52, 20);
            this.lblAuthor.TabIndex = 10;
            this.lblAuthor.Text = "저자 : ";
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBookName.ForeColor = System.Drawing.Color.White;
            this.lblBookName.Location = new System.Drawing.Point(5, 6);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(107, 20);
            this.lblBookName.TabIndex = 9;
            this.lblBookName.Text = "기존 책 제목 : ";
            // 
            // cbBookName
            // 
            this.cbBookName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBookName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbBookName.Location = new System.Drawing.Point(122, 6);
            this.cbBookName.Name = "cbBookName";
            this.cbBookName.Size = new System.Drawing.Size(256, 23);
            this.cbBookName.TabIndex = 2;
            this.cbBookName.SelectedIndexChanged += new System.EventHandler(this.cbBookName_SelectedIndexChanged);
            // 
            // panDefault
            // 
            this.panDefault.BackColor = System.Drawing.Color.SteelBlue;
            this.panDefault.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panDefault.Controls.Add(this.cbBookName);
            this.panDefault.Controls.Add(this.txtImgPath);
            this.panDefault.Controls.Add(this.txtPublisher);
            this.panDefault.Controls.Add(this.txtAuthor);
            this.panDefault.Controls.Add(this.label1);
            this.panDefault.Controls.Add(this.lblPublisher);
            this.panDefault.Controls.Add(this.lblAuthor);
            this.panDefault.Controls.Add(this.lblBookName);
            this.panDefault.Location = new System.Drawing.Point(12, 41);
            this.panDefault.Name = "panDefault";
            this.panDefault.Size = new System.Drawing.Size(400, 139);
            this.panDefault.TabIndex = 15;
            // 
            // txtImgPath
            // 
            this.txtImgPath.BackColor = System.Drawing.SystemColors.Window;
            this.txtImgPath.Location = new System.Drawing.Point(122, 105);
            this.txtImgPath.Name = "txtImgPath";
            this.txtImgPath.ReadOnly = true;
            this.txtImgPath.Size = new System.Drawing.Size(248, 23);
            this.txtImgPath.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "이미지 주소 : ";
            // 
            // panChange
            // 
            this.panChange.BackColor = System.Drawing.Color.SteelBlue;
            this.panChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panChange.Controls.Add(this.btnChoiceImg);
            this.panChange.Controls.Add(this.label2);
            this.panChange.Controls.Add(this.txtChangeBookName);
            this.panChange.Controls.Add(this.txtChangePublisher);
            this.panChange.Controls.Add(this.txtChangeAuthor);
            this.panChange.Controls.Add(this.lblChangePublisher);
            this.panChange.Controls.Add(this.lblChangeAuthor);
            this.panChange.Controls.Add(this.lblChangeBookName);
            this.panChange.Location = new System.Drawing.Point(12, 203);
            this.panChange.Name = "panChange";
            this.panChange.Size = new System.Drawing.Size(400, 139);
            this.panChange.TabIndex = 16;
            // 
            // btnChoiceImg
            // 
            this.btnChoiceImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnChoiceImg.Location = new System.Drawing.Point(133, 105);
            this.btnChoiceImg.Name = "btnChoiceImg";
            this.btnChoiceImg.Size = new System.Drawing.Size(80, 24);
            this.btnChoiceImg.TabIndex = 15;
            this.btnChoiceImg.Text = "이미지 선택";
            this.btnChoiceImg.UseVisualStyleBackColor = false;
            this.btnChoiceImg.Click += new System.EventHandler(this.btnChoiceImg_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "변경할 이미지 : ";
            // 
            // txtChangeBookName
            // 
            this.txtChangeBookName.Location = new System.Drawing.Point(133, 8);
            this.txtChangeBookName.Name = "txtChangeBookName";
            this.txtChangeBookName.Size = new System.Drawing.Size(248, 23);
            this.txtChangeBookName.TabIndex = 14;
            // 
            // txtChangePublisher
            // 
            this.txtChangePublisher.Location = new System.Drawing.Point(133, 76);
            this.txtChangePublisher.Name = "txtChangePublisher";
            this.txtChangePublisher.Size = new System.Drawing.Size(248, 23);
            this.txtChangePublisher.TabIndex = 13;
            // 
            // txtChangeAuthor
            // 
            this.txtChangeAuthor.Location = new System.Drawing.Point(133, 42);
            this.txtChangeAuthor.Name = "txtChangeAuthor";
            this.txtChangeAuthor.Size = new System.Drawing.Size(248, 23);
            this.txtChangeAuthor.TabIndex = 12;
            // 
            // lblChangePublisher
            // 
            this.lblChangePublisher.AutoSize = true;
            this.lblChangePublisher.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblChangePublisher.ForeColor = System.Drawing.Color.White;
            this.lblChangePublisher.Location = new System.Drawing.Point(10, 75);
            this.lblChangePublisher.Name = "lblChangePublisher";
            this.lblChangePublisher.Size = new System.Drawing.Size(117, 20);
            this.lblChangePublisher.TabIndex = 11;
            this.lblChangePublisher.Text = "변경할 출판사 : ";
            // 
            // lblChangeAuthor
            // 
            this.lblChangeAuthor.AutoSize = true;
            this.lblChangeAuthor.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblChangeAuthor.ForeColor = System.Drawing.Color.White;
            this.lblChangeAuthor.Location = new System.Drawing.Point(25, 41);
            this.lblChangeAuthor.Name = "lblChangeAuthor";
            this.lblChangeAuthor.Size = new System.Drawing.Size(102, 20);
            this.lblChangeAuthor.TabIndex = 10;
            this.lblChangeAuthor.Text = "변경할 저자 : ";
            // 
            // lblChangeBookName
            // 
            this.lblChangeBookName.AutoSize = true;
            this.lblChangeBookName.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblChangeBookName.ForeColor = System.Drawing.Color.White;
            this.lblChangeBookName.Location = new System.Drawing.Point(5, 7);
            this.lblChangeBookName.Name = "lblChangeBookName";
            this.lblChangeBookName.Size = new System.Drawing.Size(122, 20);
            this.lblChangeBookName.TabIndex = 9;
            this.lblChangeBookName.Text = "변경할 책 제목 : ";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // adminBookModifyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(3)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(522, 355);
            this.Controls.Add(this.panChange);
            this.Controls.Add(this.panDefault);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "adminBookModifyView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "책 정보 수정";
            this.Load += new System.EventHandler(this.adminBookModifyView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panDefault.ResumeLayout(false);
            this.panDefault.PerformLayout();
            this.panChange.ResumeLayout(false);
            this.panChange.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 도움말HToolStripMenuItem;
        private ToolStripMenuItem 책정보수정AToolStripMenuItem;
        private Button btnModify;
        private TextBox txtPublisher;
        private TextBox txtAuthor;
        private Label lblPublisher;
        private Label lblAuthor;
        private Label lblBookName;
        private ComboBox cbBookName;
        private Panel panDefault;
        private Panel panChange;
        private TextBox txtChangeBookName;
        private TextBox txtChangePublisher;
        private TextBox txtChangeAuthor;
        private Label lblChangePublisher;
        private Label lblChangeAuthor;
        private Label lblChangeBookName;
        private TextBox txtImgPath;
        private Label label1;
        private Label label2;
        private Button btnChoiceImg;
        private OpenFileDialog openFileDialog1;
    }
}