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
    public partial class RegisterMember : Form
    {
        string _server = "localhost"; //DB 서버 주소, 로컬일 경우 localhost
        int _port = 3308; //DB 서버 포트
        string _database = "1zo"; //DB 이름
        string _id = "root"; //계정 아이디
        string _pw = "1234"; //계정 비밀번호
        string _connectionAddress = "";
        
        public RegisterMember()
        {
            InitializeComponent();
            regi_pw.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}"
          , _server, _port, _database, _id, _pw);

            try
            {
                MySqlConnection con = new MySqlConnection (_connectionAddress);

                con.Open();

                string insertQuery = "INSERT INTO userinfo (userId, userPw, userName)" +
                    "Values('" + regi_id.Text + "', '" + regi_pw.Text + "', '" + regi_name.Text + "');";

                MySqlCommand cmd = new MySqlCommand(insertQuery, con);
                string selectQuery = string.Format("select userId from userinfo where userId ='{0}'", regi_id.Text);
                MySqlCommand cmd2 = new MySqlCommand(selectQuery, con);

                if (regi_id.Text=="" || regi_pw.Text=="" || regi_name.Text == "")
                {
                    MessageBox.Show("회원가입란 다시 확인해 주세요");
                }
                else if((string)cmd2.ExecuteScalar() == regi_id.Text)
                {
                    MessageBox.Show("중복된 아이디 입니다.");
                }
                else if (cmd.ExecuteNonQuery() == 1)
                {
                    //회원가입 정상적으로 될 시
                    MessageBox.Show(regi_name.Text + "님 회원가입 완료, 사용할 아이디는 " + regi_id.Text + "입니다.");

                    con.Close();

                    Close();

                }
                else
                {
                    MessageBox.Show("회원가입란 다시 확인해 주세요");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
