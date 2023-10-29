namespace BookManage
{
    partial class RegisterMember
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
            this.regi_id = new System.Windows.Forms.TextBox();
            this.regi_pw = new System.Windows.Forms.TextBox();
            this.regi_name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // regi_id
            // 
            this.regi_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(3)))), ((int)(((byte)(79)))));
            this.regi_id.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.regi_id.ForeColor = System.Drawing.Color.White;
            this.regi_id.Location = new System.Drawing.Point(405, 228);
            this.regi_id.Name = "regi_id";
            this.regi_id.PlaceholderText = "ID";
            this.regi_id.Size = new System.Drawing.Size(303, 33);
            this.regi_id.TabIndex = 0;
            // 
            // regi_pw
            // 
            this.regi_pw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(3)))), ((int)(((byte)(79)))));
            this.regi_pw.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.regi_pw.ForeColor = System.Drawing.Color.White;
            this.regi_pw.Location = new System.Drawing.Point(405, 270);
            this.regi_pw.Name = "regi_pw";
            this.regi_pw.PlaceholderText = "PassWord";
            this.regi_pw.Size = new System.Drawing.Size(303, 33);
            this.regi_pw.TabIndex = 1;
            // 
            // regi_name
            // 
            this.regi_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(3)))), ((int)(((byte)(79)))));
            this.regi_name.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.regi_name.ForeColor = System.Drawing.Color.White;
            this.regi_name.Location = new System.Drawing.Point(404, 313);
            this.regi_name.Name = "regi_name";
            this.regi_name.PlaceholderText = "Name";
            this.regi_name.Size = new System.Drawing.Size(303, 33);
            this.regi_name.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(404, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(304, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "회원가입";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BookManage.Properties.Resources.mainimg;
            this.pictureBox1.Location = new System.Drawing.Point(-5, -9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 493);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BookManage.Properties.Resources.signUp;
            this.pictureBox2.Location = new System.Drawing.Point(420, 71);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(268, 113);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // RegisterMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(3)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(785, 479);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.regi_name);
            this.Controls.Add(this.regi_pw);
            this.Controls.Add(this.regi_id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RegisterMember";
            this.Text = "RegisterMember";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox regi_id;
        private TextBox regi_pw;
        private TextBox regi_name;
        private Button button1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}