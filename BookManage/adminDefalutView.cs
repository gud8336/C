
using System.Data;
using System.Net.Http.Headers;
using DataRow = System.Data.DataRow;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace BookManage
{
    public partial class adminDefaultPage : Form
    { 
        void setBookInfoColName(DataTable dt)
        {
            dt.Columns["bookCode"].ColumnName = "책 코드";
            dt.Columns["bookName"].ColumnName = "책 제목";
            dt.Columns["bookAuthor"].ColumnName = "저자";
            dt.Columns["bookPublisher"].ColumnName = "출판사";
            dt.Columns["bookImgPath"].ColumnName = "이미지";
        }
        void setBookDetailInfoColName(DataTable dt)
        {
            dt.Columns["bookCode"].ColumnName = "책 코드";
            dt.Columns["rentalName"].ColumnName = "대여자";
            dt.Columns["rentalDate"].ColumnName = "대여일";
            dt.Columns["returnDate"].ColumnName = "반납일";
        }

        void dbselect()
        {
            string _server = "localhost"; //DB 서버 주소, 로컬일 경우 localhost
            int _port = 3308; //DB 서버 포트
            string _database = "1zo"; //DB 이름
            string _id = "root"; //계정 아이디
            string _pw = "1234"; //계정 비밀번호
            string _connectionAddress = "";

            _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", _server, _port, _database, _id, _pw);

            MySqlConnection con = new MySqlConnection(_connectionAddress);
            con.Open();
            string strSql = "Select * from bookinfo";
            MySqlCommand cmd = new MySqlCommand(strSql, con);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            DGBookInfo.DataSource = dt;
            setBookInfoColName(dt);
            con.Close();
        }

        public adminDefaultPage()
        {
            InitializeComponent();
        }

        private void HelpInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("현재 존재하는 책제목이 현재 책 정보에 나오게 되며 한 행을\n클릭시 클릭한 행에 따른 세부 정보가 아래에 출력된다.", "도움말");
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
         
            adminBookAddView addView = new adminBookAddView();
            addView.Location = new Point(445, 196); // 고정위치 띄우기 나중에 관리자 폼이랑 맞추면됨
            addView.ShowDialog();
            dbselect();
        }

        private void btnModifyBook_Click(object sender, EventArgs e)
        {
            adminBookModifyView ModifyView = new adminBookModifyView();
            ModifyView.Location = new Point(445, 196); // 고정위치 띄우기 나중에 관리자 폼이랑 맞추면됨
            ModifyView.ShowDialog();
            dbselect();
        }

        private void btnDelBook_Click(object sender, EventArgs e)
        {
            adminBookDelView DelView = new adminBookDelView();
            DelView.Location = new Point(445, 196); // 고정위치 띄우기 나중에 관리자 폼이랑 맞추면됨
            DelView.ShowDialog();
            dbselect();
        }

        private void adminDefaultPage_Load(object sender, EventArgs e) // 폼이 로드 됬을때
        {
            dbselect();
        }



    private void DGBookInfo_CellContentClick(object sender, DataGridViewCellEventArgs e) // 현재 책 정보에서 내용을 클릭하였을때
        {

            string _server = "localhost"; //DB 서버 주소, 로컬일 경우 localhost
            int _port = 3308; //DB 서버 포트
            string _database = "1zo"; //DB 이름
            string _id = "root"; //계정 아이디
            string _pw = "1234"; //계정 비밀번호
            string _connectionAddress = "";
            string bookcode = DGBookInfo.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", _server, _port, _database, _id, _pw);

            MySqlConnection con = new MySqlConnection(_connectionAddress);
            con.Open();
            string strSql = "Select * from bookdetailinfo where bookCode = " +bookcode;
            MySqlCommand cmd = new MySqlCommand(strSql, con);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            DGBookDetailInfo.DataSource = dt;
            setBookDetailInfoColName(dt);

            con.Close();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Visible = true;
            this.Close();
        }
    }
}