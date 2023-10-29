using MySql.Data.MySqlClient;
using System.Data;

namespace BookManage
{
    public partial class Main : Form
    {
        string _server = "localhost"; //DB 서버 주소, 로컬일 경우 localhost
        int _port = 3308; //DB 서버 포트
        string _database = "1zo"; //DB 이름
        string _id = "root"; //계정 아이디
        string _pw = "1234"; //계정 비밀번호
        string _connectionAddress = "";

        public Main(string userid)
        {
            InitializeComponent();
            lbl_username.Text = userid;
            
        }

        void setColName(DataTable dt)
        {
            dt.Columns["bookCode"].ColumnName = "책 코드";
            dt.Columns["bookName"].ColumnName = "책 제목";
            dt.Columns["bookAuthor"].ColumnName = "저자";
            dt.Columns["bookPublisher"].ColumnName = "출판사";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //db에서 값가져오기
            _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", _server, _port, _database, _id, _pw);

            MySqlConnection con = new MySqlConnection(_connectionAddress);
            con.Open();
            string strSql = "Select bookCode,bookName,bookAuthor,bookPublisher from bookinfo";
            MySqlCommand cmd = new MySqlCommand(strSql, con);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            
            da.Fill(dt);
           
            bookmenu.DataSource = dt;
            setColName(dt);
            con.Close();

        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("로그아웃 되었습니다.");
            this.Close();
            Login login = new Login();
            login.Visible = true;
        }

        private void bookmenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BookDetail detail = new BookDetail(lbl_username.Text,bookmenu.Rows[e.RowIndex].Cells[0], 
                bookmenu.Rows[e.RowIndex].Cells[1], bookmenu.Rows[e.RowIndex].Cells[2], bookmenu.Rows[e.RowIndex].Cells[3]);

            detail.Owner = this;

            detail.ShowDialog();
        }
    }
}