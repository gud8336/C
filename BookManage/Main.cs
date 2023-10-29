using MySql.Data.MySqlClient;
using System.Data;

namespace BookManage
{
    public partial class Main : Form
    {
        string _server = "localhost"; //DB ���� �ּ�, ������ ��� localhost
        int _port = 3308; //DB ���� ��Ʈ
        string _database = "1zo"; //DB �̸�
        string _id = "root"; //���� ���̵�
        string _pw = "1234"; //���� ��й�ȣ
        string _connectionAddress = "";

        public Main(string userid)
        {
            InitializeComponent();
            lbl_username.Text = userid;
            
        }

        void setColName(DataTable dt)
        {
            dt.Columns["bookCode"].ColumnName = "å �ڵ�";
            dt.Columns["bookName"].ColumnName = "å ����";
            dt.Columns["bookAuthor"].ColumnName = "����";
            dt.Columns["bookPublisher"].ColumnName = "���ǻ�";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //db���� ����������
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
            MessageBox.Show("�α׾ƿ� �Ǿ����ϴ�.");
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