namespace BookManage
{
    partial class Login
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
            this.id_text = new System.Windows.Forms.TextBox();
            this.pass_text = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.regi_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // id_text
            // 
            this.id_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(3)))), ((int)(((byte)(79)))));
            this.id_text.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.id_text.ForeColor = System.Drawing.Color.White;
            this.id_text.Location = new System.Drawing.Point(380, 179);
            this.id_text.Name = "id_text";
            this.id_text.PlaceholderText = "ID";
            this.id_text.Size = new System.Drawing.Size(302, 33);
            this.id_text.TabIndex = 0;
            // 
            // pass_text
            // 
            this.pass_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(3)))), ((int)(((byte)(79)))));
            this.pass_text.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pass_text.ForeColor = System.Drawing.Color.White;
            this.pass_text.Location = new System.Drawing.Point(380, 245);
            this.pass_text.Name = "pass_text";
            this.pass_text.PlaceholderText = "PassWord";
            this.pass_text.Size = new System.Drawing.Size(302, 33);
            this.pass_text.TabIndex = 1;
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.login_btn.FlatAppearance.BorderSize = 0;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login_btn.Location = new System.Drawing.Point(380, 301);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(302, 45);
            this.login_btn.TabIndex = 2;
            this.login_btn.Text = "로그인";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // regi_btn
            // 
            this.regi_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.regi_btn.FlatAppearance.BorderSize = 0;
            this.regi_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regi_btn.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.regi_btn.Location = new System.Drawing.Point(380, 376);
            this.regi_btn.Name = "regi_btn";
            this.regi_btn.Size = new System.Drawing.Size(302, 49);
            this.regi_btn.TabIndex = 3;
            this.regi_btn.Text = "회원가입";
            this.regi_btn.UseVisualStyleBackColor = false;
            this.regi_btn.Click += new System.EventHandler(this.regi_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(3)))), ((int)(((byte)(79)))));
            this.pictureBox1.Image = global::BookManage.Properties.Resources.mainimg;
            this.pictureBox1.Location = new System.Drawing.Point(-5, -19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 515);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BookManage.Properties.Resources.login;
            this.pictureBox2.Location = new System.Drawing.Point(399, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(268, 113);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(3)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(785, 479);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.regi_btn);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.pass_text);
            this.Controls.Add(this.id_text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox id_text;
        private TextBox pass_text;
        private Button login_btn;
        private Button regi_btn;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}