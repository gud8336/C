namespace BookManage
{
    partial class Main
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
            this.logout_btn = new System.Windows.Forms.Button();
            this.lbl_username = new System.Windows.Forms.Label();
            this.bookmenu = new System.Windows.Forms.DataGridView();
            this.roundPanel1 = new BookManage.RoundPanel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bookmenu)).BeginInit();
            this.roundPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logout_btn
            // 
            this.logout_btn.FlatAppearance.BorderSize = 0;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.ForeColor = System.Drawing.Color.White;
            this.logout_btn.Location = new System.Drawing.Point(691, 12);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(97, 23);
            this.logout_btn.TabIndex = 0;
            this.logout_btn.Text = "로그아웃";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.ForeColor = System.Drawing.Color.White;
            this.lbl_username.Location = new System.Drawing.Point(531, 16);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(71, 15);
            this.lbl_username.TabIndex = 1;
            this.lbl_username.Text = "사용자 이름";
            this.lbl_username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bookmenu
            // 
            this.bookmenu.AllowUserToAddRows = false;
            this.bookmenu.AllowUserToDeleteRows = false;
            this.bookmenu.AllowUserToResizeColumns = false;
            this.bookmenu.AllowUserToResizeRows = false;
            this.bookmenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bookmenu.BackgroundColor = System.Drawing.Color.White;
            this.bookmenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bookmenu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.bookmenu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bookmenu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.bookmenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookmenu.EnableHeadersVisualStyles = false;
            this.bookmenu.GridColor = System.Drawing.Color.SteelBlue;
            this.bookmenu.Location = new System.Drawing.Point(8, 4);
            this.bookmenu.Name = "bookmenu";
            this.bookmenu.ReadOnly = true;
            this.bookmenu.RowHeadersVisible = false;
            this.bookmenu.RowTemplate.Height = 25;
            this.bookmenu.Size = new System.Drawing.Size(763, 380);
            this.bookmenu.TabIndex = 3;
            this.bookmenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookmenu_CellContentClick);
            // 
            // roundPanel1
            // 
            this.roundPanel1.BackColor = System.Drawing.Color.SteelBlue;
            this.roundPanel1.BorderColor = System.Drawing.Color.White;
            this.roundPanel1.BorderRadius = 20;
            this.roundPanel1.BorderThickness = 0F;
            this.roundPanel1.Controls.Add(this.bookmenu);
            this.roundPanel1.Location = new System.Drawing.Point(11, 41);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Size = new System.Drawing.Size(777, 397);
            this.roundPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(599, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "님 환영합니다.";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(3)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.roundPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "BookManage";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookmenu)).EndInit();
            this.roundPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button logout_btn;
        private Label lbl_username;
        private DataGridView bookmenu;
        private RoundPanel roundPanel1;
        private Label label1;
    }
}