namespace BookManage
{
    partial class BookDetail
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
            this.btn_return = new System.Windows.Forms.Button();
            this.btn_rent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_rentdate = new System.Windows.Forms.Label();
            this.lbl_writer = new System.Windows.Forms.Label();
            this.lbl_pub = new System.Windows.Forms.Label();
            this.lbl_bname = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_returndate = new System.Windows.Forms.Label();
            this.bookpic = new System.Windows.Forms.PictureBox();
            this.lbl_code = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_rentname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bookpic)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_return
            // 
            this.btn_return.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_return.Location = new System.Drawing.Point(213, 415);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(75, 23);
            this.btn_return.TabIndex = 0;
            this.btn_return.Text = "반납";
            this.btn_return.UseVisualStyleBackColor = false;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // btn_rent
            // 
            this.btn_rent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_rent.Location = new System.Drawing.Point(120, 415);
            this.btn_rent.Name = "btn_rent";
            this.btn_rent.Size = new System.Drawing.Size(75, 23);
            this.btn_rent.TabIndex = 0;
            this.btn_rent.Text = "대여";
            this.btn_rent.UseVisualStyleBackColor = false;
            this.btn_rent.Click += new System.EventHandler(this.btn_rent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(104, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "책이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(104, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "출판사";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(104, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "저자";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(104, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "대여일자";
            // 
            // lbl_rentdate
            // 
            this.lbl_rentdate.AutoSize = true;
            this.lbl_rentdate.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_rentdate.ForeColor = System.Drawing.Color.White;
            this.lbl_rentdate.Location = new System.Drawing.Point(246, 321);
            this.lbl_rentdate.Name = "lbl_rentdate";
            this.lbl_rentdate.Size = new System.Drawing.Size(0, 21);
            this.lbl_rentdate.TabIndex = 3;
            // 
            // lbl_writer
            // 
            this.lbl_writer.AutoSize = true;
            this.lbl_writer.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_writer.ForeColor = System.Drawing.Color.White;
            this.lbl_writer.Location = new System.Drawing.Point(246, 297);
            this.lbl_writer.Name = "lbl_writer";
            this.lbl_writer.Size = new System.Drawing.Size(42, 21);
            this.lbl_writer.TabIndex = 4;
            this.lbl_writer.Text = "저자";
            // 
            // lbl_pub
            // 
            this.lbl_pub.AutoSize = true;
            this.lbl_pub.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_pub.ForeColor = System.Drawing.Color.White;
            this.lbl_pub.Location = new System.Drawing.Point(246, 271);
            this.lbl_pub.Name = "lbl_pub";
            this.lbl_pub.Size = new System.Drawing.Size(58, 21);
            this.lbl_pub.TabIndex = 5;
            this.lbl_pub.Text = "출판사";
            // 
            // lbl_bname
            // 
            this.lbl_bname.AutoSize = true;
            this.lbl_bname.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_bname.ForeColor = System.Drawing.Color.White;
            this.lbl_bname.Location = new System.Drawing.Point(246, 245);
            this.lbl_bname.Name = "lbl_bname";
            this.lbl_bname.Size = new System.Drawing.Size(58, 21);
            this.lbl_bname.TabIndex = 6;
            this.lbl_bname.Text = "책이름";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(104, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "반납일자";
            // 
            // lbl_returndate
            // 
            this.lbl_returndate.AutoSize = true;
            this.lbl_returndate.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_returndate.ForeColor = System.Drawing.Color.White;
            this.lbl_returndate.Location = new System.Drawing.Point(246, 347);
            this.lbl_returndate.Name = "lbl_returndate";
            this.lbl_returndate.Size = new System.Drawing.Size(0, 21);
            this.lbl_returndate.TabIndex = 8;
            // 
            // bookpic
            // 
            this.bookpic.Location = new System.Drawing.Point(120, 48);
            this.bookpic.Name = "bookpic";
            this.bookpic.Size = new System.Drawing.Size(168, 167);
            this.bookpic.TabIndex = 9;
            this.bookpic.TabStop = false;
            // 
            // lbl_code
            // 
            this.lbl_code.AutoSize = true;
            this.lbl_code.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_code.ForeColor = System.Drawing.Color.White;
            this.lbl_code.Location = new System.Drawing.Point(246, 224);
            this.lbl_code.Name = "lbl_code";
            this.lbl_code.Size = new System.Drawing.Size(58, 21);
            this.lbl_code.TabIndex = 11;
            this.lbl_code.Text = "책이름";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(104, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 21);
            this.label7.TabIndex = 10;
            this.label7.Text = "책 코드";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(451, 449);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(449, 474);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "label8";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(104, 372);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 21);
            this.label9.TabIndex = 14;
            this.label9.Text = "대여자";
            // 
            // lbl_rentname
            // 
            this.lbl_rentname.AutoSize = true;
            this.lbl_rentname.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_rentname.ForeColor = System.Drawing.Color.White;
            this.lbl_rentname.Location = new System.Drawing.Point(246, 372);
            this.lbl_rentname.Name = "lbl_rentname";
            this.lbl_rentname.Size = new System.Drawing.Size(0, 21);
            this.lbl_rentname.TabIndex = 15;
            // 
            // BookDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(3)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(395, 470);
            this.Controls.Add(this.lbl_rentname);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_code);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bookpic);
            this.Controls.Add(this.lbl_returndate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_rentdate);
            this.Controls.Add(this.lbl_writer);
            this.Controls.Add(this.lbl_pub);
            this.Controls.Add(this.lbl_bname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_rent);
            this.Controls.Add(this.btn_return);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BookDetail";
            this.Text = "BookDetail";
            this.Load += new System.EventHandler(this.BookDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_return;
        private Button btn_rent;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lbl_rentdate;
        private Label lbl_writer;
        private Label lbl_pub;
        private Label lbl_bname;
        private Label label6;
        private Label lbl_returndate;
        private PictureBox bookpic;
        private Label lbl_code;
        private Label label7;
        private Label label5;
        private Label label8;
        private Label label9;
        private Label lbl_rentname;
    }
}