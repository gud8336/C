using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManage
{
    public partial class adminBookDelView : Form
    {
        string _server = "localhost"; //DB 서버 주소, 로컬일 경우 localhost
        int _port = 3308; //DB 서버 포트
        string _database = "1zo"; //DB 이름
        string _id = "root"; //계정 아이디
        string _pw = "1234"; //계정 비밀번호
        string _connectionAddress = "";
        string imgpath;
        public adminBookDelView()
        {
            InitializeComponent();

        }

        void dbupdate()
        {
            string _server = "localhost"; //DB 서버 주소, 로컬일 경우 localhost
            int _port = 3308; //DB 서버 포트
            string _database = "1zo"; //DB 이름
            string _id = "root"; //계정 아이디
            string _pw = "1234"; //계정 비밀번호
            string _connectionAddress = "";
            _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}"
              , _server, _port, _database, _id, _pw);

            this.cbBookName.Focus();

            MySqlConnection con = new MySqlConnection(_connectionAddress);
            con.Open();
            string strSql = "Select * from bookinfo ";
            MySqlCommand cmd = new MySqlCommand(strSql, con);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbBookName.Items.Add(dt.Rows[i]["bookname"]);
            }
            con.Close();
        }
        void setBookDetailInfoColName(DataTable dt)
        {
            dt.Columns["bookCode"].ColumnName = "책 코드";
            dt.Columns["rentalName"].ColumnName = "대여자";
            dt.Columns["rentalDate"].ColumnName = "대여일";
            dt.Columns["returnDate"].ColumnName = "반납일";
        }
        private void 책삭제도움말AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("※ 책 삭제 방법\n\n"
                + "0. 주의사항\n   대여가 되어있는 책은 삭제가 불가하다.\n   ex) 총 수량이 5권인 책에 대하여 4권을 삭제할려\n        하였을 때 2권 이상이 대여 중이라면 삭제 불가\n\n"
                + "1. 기존에 있는 책의 수량만 삭제할 때\n   책 제목에 있는 콤보 박스를 클릭해 삭제할 책을\n   클릭하면 저자와 출판사가 자동 기입되며 수량을\n   따로 기입 후 삭제 버튼 클릭\n\n"
                + "2. 기존에 있는 책을 삭제할 때\n   책 제목을 선택 후 자동으로 입력되는 저자나 출판사를\n   확인하고 수량을 -1을 기입 후 삭제 버튼 클릭", "책 삭제 도움말");
        }

        private void adminBookDelView_Load(object sender, EventArgs e)
        {

            dbupdate();
        }

        private void cbBookName_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 선택한 책 제목에 따라 저자와 출판사, 밑에 세부 정보를 바꿔줘야함
            _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}"
              , _server, _port, _database, _id, _pw);


            MySqlConnection con = new MySqlConnection(_connectionAddress);
            con.Open();
            string strSql = "SELECT * FROM bookinfo WHERE bookname = @Value";
            MySqlCommand cmd = new MySqlCommand(strSql, con);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);


            da.SelectCommand.Parameters.Add(new MySqlParameter("@Value", cbBookName.Text));
            DataTable dt = new DataTable();
            da.Fill(dt);

            lblAuthorValue.Text = Convert.ToString(dt.Rows[0][2]);
            lblPublisherValue.Text = Convert.ToString(dt.Rows[0][3]);

            string selectQuery = string.Format("select bookCode from bookinfo where bookName ='{0}'", cbBookName.Text);
            MySqlCommand cmd2 = new MySqlCommand(selectQuery, con);

            int bcode = (int)cmd2.ExecuteScalar();

            string selectimg = string.Format("select bookImgPath from bookinfo where bookName ='{0}'", cbBookName.Text);
            MySqlCommand cmd4 = new MySqlCommand(selectimg, con);

            imgpath = (string)cmd4.ExecuteScalar();

            string detailsql = "Select * from bookdetailinfo where bookCode =" + bcode;
            MySqlCommand cmd3 = new MySqlCommand(detailsql, con);

            MySqlDataAdapter da1 = new MySqlDataAdapter(cmd3);

            DataTable dt1 = new DataTable();
            da1.Fill(dt1);

            DGBookDetailInfo.DataSource = dt1;
            setBookDetailInfoColName(dt1);
            con.Close();

            if (dt1.Rows[0][2].ToString() != "") { btnDel.Enabled = false; }
            else btnDel.Enabled = true;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (cbBookName.Text == "")
            {
                MessageBox.Show("삭제할 책을 선택해주세요");
            }
            else
            {
                try
                {
                    using (MySqlConnection con = new MySqlConnection(_connectionAddress))
                    {
                        con.Open();

                        string strSql = "DELETE FROM bookinfo WHERE bookname = @Value;";

                        MySqlCommand cmd = new MySqlCommand(strSql, con);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        da.SelectCommand.Parameters.Add(new MySqlParameter("@Value", cbBookName.Text));

                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        lblAuthorValue.Text = "";
                        lblPublisherValue.Text = "";

                        cbBookName.Text = "";
                        con.Close();
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
                try
                {
                    FileInfo file = new FileInfo(imgpath);
                    file.Delete();
                }
                catch (Exception e1)
                {
                    Console.WriteLine("The deletion failed: {0}", e1.Message);
                }
                cbBookName.Items.Clear();
                MessageBox.Show("삭제 완료 되었습니다.");
                dbupdate();
            }
        }
    }
}
