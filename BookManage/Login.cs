using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManage
{
    public partial class Login : Form
    {
        string _server = "localhost"; //DB 서버 주소, 로컬일 경우 localhost
        int _port = 3308; //DB 서버 포트
        string _database = "1zo"; //DB 이름
        string _id = "root"; //계정 아이디
        string _pw = "1234"; //계정 비밀번호
        string _connectionAddress = "";

        public Login()
        {
            InitializeComponent();
            pass_text.UseSystemPasswordChar = true;
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
           
            _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}"
           , _server, _port, _database, _id, _pw);

            try
            {
                MySqlConnection con = new MySqlConnection(_connectionAddress);
                con.Open();

                int login_status = 0;

                string userId = id_text.Text;
                string userPw = pass_text.Text;

                string selectQuery = "SELECT * FROM USERINFO where userID =  \'" + userId + "\'";

                MySqlCommand cmd = new MySqlCommand(selectQuery, con);

                MySqlDataReader userAccount = cmd.ExecuteReader();

                while (userAccount.Read())
                {
                    if (userId == (string)userAccount["userId"] && userPw == (string)userAccount["userPw"])
                    {
                        login_status = 1;
                    }
                }
                con.Close();
                if (id_text.Text == "admin" && pass_text.Text == "1234")
                {
                    adminDefaultPage admin = new adminDefaultPage();

                    MessageBox.Show("관리자님으로 로그인 되었습니다.");
                    this.Visible = false;

                    admin.ShowDialog();

                }
                else if (login_status == 1)
                {
                    MessageBox.Show("로그인이 되었습니다.");
                    this.Visible = false;
                    Main main = new Main(id_text.Text);
                    main.ShowDialog();

                }
                else
                {
                    MessageBox.Show("회원 정보를 확인해 주세요");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
           
        }

        private void regi_btn_Click(object sender, EventArgs e)
        {
            RegisterMember register = new RegisterMember();
            register.ShowDialog();
        }
    }
}
