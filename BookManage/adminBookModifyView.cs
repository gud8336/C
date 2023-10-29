using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManage
{
    public partial class adminBookModifyView : Form
    {
        string _server = "localhost"; //DB 서버 주소, 로컬일 경우 localhost
        int _port = 3308; //DB 서버 포트
        string _database = "1zo"; //DB 이름
        string _id = "root"; //계정 아이디
        string _pw = "1234"; //계정 비밀번호
        string _connectionAddress = "";
        int bCode;
        string fileContent = string.Empty;
        string filePath = string.Empty;

        int SelectBookCode(MySqlConnection con)
        {
            string selectQuery = string.Format("select bookCode from bookinfo where bookName ='{0}'", cbBookName.Text);
            MySqlCommand cmd2 = new MySqlCommand(selectQuery, con);
            return (int)cmd2.ExecuteScalar();
        }
        public adminBookModifyView()
        {
            InitializeComponent();
        }

        private void 책정보수정AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("※ 책 정보 수정 방법\n\n"
                + "0. 주의사항\n   대여가 한권이라도 된 책은 정보 수정이 불가하다.\n   ex) 현재 수량이 5권인 책에 대하여 수정을 진행할 때\n        1권 이상이 대여 중이라면 수정 불가\n\n"
                + "1. 책 정보 수정 방법\n   변경할 책의 책 제목을 콤보박스에서 선택하면 아래에\n   변경할 내용에 저자와 출판사가 들어가는데 이중에서\n   변경할 것을 바꾼후 수정버튼 클릭", "책 정보 수정 도움말");
        }

        private void adminBookModifyView_Load(object sender, EventArgs e)
        {
            // db에서 기존에 있는 책 제목을 전부 가져옴
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
            cbBookName.Refresh(); 
            
        }

        private void cbBookName_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 선택된것에 따른 책이름, 저자, 출판사를 db에서 가져옴
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

            txtAuthor.Text = Convert.ToString(dt.Rows[0][2]);
            txtPublisher.Text = Convert.ToString(dt.Rows[0][3]);
            txtImgPath.Text= Convert.ToString(dt.Rows[0][4]);

            txtChangeBookName.Text = cbBookName.Text;
            txtChangeAuthor.Text = txtAuthor.Text;
            txtChangePublisher.Text = txtPublisher.Text;

            //선택한 책이 대여중이면 삭제 불가능
            bCode = SelectBookCode(con);

            string sql1 = "select * from bookdetailinfo where bookCode =" + bCode;
            MySqlCommand cmd1 = new MySqlCommand(sql1, con);
            MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);

            if (Convert.ToString(dt1.Rows[0][1]) != "")
            {
                btnModify.Enabled = false;
            }
            else
            {
                btnModify.Enabled = true;
            }



            con.Close();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (txtChangeBookName.Text == "")
            {
                MessageBox.Show("수정할 정보를 확인해주세요");
            }
            else if (filePath == "")
            {
                MessageBox.Show("수정할 이미지를 선택해 주세요");
            }
            else { 
            _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}"
             , _server, _port, _database, _id, _pw);
            string a = Assembly.GetEntryAssembly().Location;
            a = a.Substring(0, a.Length - 39);
            string copypath = a + "img\\" + txtChangeBookName.Text + ".jpg";
            System.IO.File.Copy(filePath, copypath, true);
            copypath = copypath.Replace("\\", @"\\");
            MySqlConnection con = new MySqlConnection(_connectionAddress);
            con.Open();
            try
            {
                FileInfo file = new FileInfo(txtImgPath.Text);
                file.Delete();
            }
            catch (Exception e1)
            {
                Console.WriteLine("The deletion failed: {0}", e1.Message);
            }

            string strSql = "update bookinfo set bookName = '" + txtChangeBookName.Text + "',bookAuthor ='" + txtChangeAuthor.Text + "',bookPublisher = '" + txtChangePublisher.Text + "'" + ",bookImgPath ='" + copypath + "'" +
                "where bookCode= " + bCode;
            MySqlCommand cmd = new MySqlCommand(strSql, con);
            //에러
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            { }
            con.Close();
            cbBookName.Text = "";
            MessageBox.Show("수정이 완료 되었습니다.");
            }
        }

        private void btnChoiceImg_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();
                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }
        }
    }
}
