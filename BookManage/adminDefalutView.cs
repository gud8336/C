
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
            dt.Columns["bookCode"].ColumnName = "å �ڵ�";
            dt.Columns["bookName"].ColumnName = "å ����";
            dt.Columns["bookAuthor"].ColumnName = "����";
            dt.Columns["bookPublisher"].ColumnName = "���ǻ�";
            dt.Columns["bookImgPath"].ColumnName = "�̹���";
        }
        void setBookDetailInfoColName(DataTable dt)
        {
            dt.Columns["bookCode"].ColumnName = "å �ڵ�";
            dt.Columns["rentalName"].ColumnName = "�뿩��";
            dt.Columns["rentalDate"].ColumnName = "�뿩��";
            dt.Columns["returnDate"].ColumnName = "�ݳ���";
        }

        void dbselect()
        {
            string _server = "localhost"; //DB ���� �ּ�, ������ ��� localhost
            int _port = 3308; //DB ���� ��Ʈ
            string _database = "1zo"; //DB �̸�
            string _id = "root"; //���� ���̵�
            string _pw = "1234"; //���� ��й�ȣ
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
            MessageBox.Show("���� �����ϴ� å������ ���� å ������ ������ �Ǹ� �� ����\nŬ���� Ŭ���� �࿡ ���� ���� ������ �Ʒ��� ��µȴ�.", "����");
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
         
            adminBookAddView addView = new adminBookAddView();
            addView.Location = new Point(445, 196); // ������ġ ���� ���߿� ������ ���̶� ���߸��
            addView.ShowDialog();
            dbselect();
        }

        private void btnModifyBook_Click(object sender, EventArgs e)
        {
            adminBookModifyView ModifyView = new adminBookModifyView();
            ModifyView.Location = new Point(445, 196); // ������ġ ���� ���߿� ������ ���̶� ���߸��
            ModifyView.ShowDialog();
            dbselect();
        }

        private void btnDelBook_Click(object sender, EventArgs e)
        {
            adminBookDelView DelView = new adminBookDelView();
            DelView.Location = new Point(445, 196); // ������ġ ���� ���߿� ������ ���̶� ���߸��
            DelView.ShowDialog();
            dbselect();
        }

        private void adminDefaultPage_Load(object sender, EventArgs e) // ���� �ε� ������
        {
            dbselect();
        }



    private void DGBookInfo_CellContentClick(object sender, DataGridViewCellEventArgs e) // ���� å �������� ������ Ŭ���Ͽ�����
        {

            string _server = "localhost"; //DB ���� �ּ�, ������ ��� localhost
            int _port = 3308; //DB ���� ��Ʈ
            string _database = "1zo"; //DB �̸�
            string _id = "root"; //���� ���̵�
            string _pw = "1234"; //���� ��й�ȣ
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