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
    public partial class adminBookAddView : Form
    {
        string _server = "localhost"; //DB 서버 주소, 로컬일 경우 localhost
        int _port = 3308; //DB 서버 포트
        string _database = "1zo"; //DB 이름
        string _id = "root"; //계정 아이디
        string _pw = "1234"; //계정 비밀번호
        string _connectionAddress = "";
        string fileContent = string.Empty;
        string filePath = String.Empty;

        string SelectBookName(MySqlConnection con)
        {
            string selectQuery = string.Format("select bookName from bookinfo where bookName ='{0}'", txtBookName.Text);
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            return (string)cmd.ExecuteScalar();
        }

        public adminBookAddView()
        {
            InitializeComponent();



        }

        private void 책추가도움말AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("※ 책 추가 방법\n\n"
                + "1. 기존에 있는 책의 수량을 추가할 때\n   책 제목에 있는 콤보 박스를 클릭해 추가할 책을\n   클릭하면 저자와 출판사가 자동 기입되며 수량을\n   따로 기입 후 추가 버튼 클릭\n\n"
                + "2. 기존의 책과 제목은 같지만 저자나 출판사가 다를 때\n   책 제목을 선택 후 자동으로 입력되는 저자나\n   출판사를 변경하고 수량을 기입 후 추가 버튼 클릭\n\n"
                + "3. 기존에 없는 새로운 책 추가 방법\n   책 제목에서 콤보 박스를 열지말고 텍스트를 책 제목에\n   기입 후 저자, 출판사, 수량 기입 후 추가 버튼 클릭", "책 추가 도움말");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}"
               , _server, _port, _database, _id, _pw);
            if (txtBookName.Text == "" || txtAuthor.Text == "" || txtPublisher.Text == "")
            {
                MessageBox.Show("책 정보를 기입해 주시기 바랍니다.");
            }
            else if (filePath == "")
            {
                MessageBox.Show("이미지를 선택해주세요");
            }
            else
            {
                string a = Assembly.GetEntryAssembly().Location;
                a = a.Substring(0, a.Length - 39);
                string copypath = a + "img\\" + txtBookName.Text + ".jpg";
                System.IO.File.Copy(filePath, copypath, true);
                copypath = copypath.Replace("\\", @"\\");
                try
                {
                    using (MySqlConnection con = new MySqlConnection(_connectionAddress))
                    {
                        con.Open();
                        if (txtBookName.Text == SelectBookName(con))
                        {
                            MessageBox.Show("중복된 책이 존재합니다.");
                        }
                        else
                        {
                            string insertQuery = string.Format
                                ("INSERT INTO bookinfo (bookName, bookAuthor, bookPublisher, bookImgPath) " +
                                "VALUES ('{0}', '{1}', '{2}', '{3}');", txtBookName.Text, txtAuthor.Text, txtPublisher.Text, copypath);

                            MySqlCommand cmd = new MySqlCommand(insertQuery, con);

                            if (cmd.ExecuteNonQuery() == 1)
                            {
                                string selectQuery = string.Format("select bookCode from bookinfo where bookName ='{0}' and bookAuthor ='{1}' and bookPublisher ='{2}'",
                                    txtBookName.Text,txtAuthor.Text,txtPublisher.Text);
                                MySqlCommand cmd2 = new MySqlCommand(selectQuery, con);

                                int bcode = (int)cmd2.ExecuteScalar();

                                string insertQuery1 = string.Format
                                ("INSERT INTO bookdetailinfo (bookCode) " +
                                "VALUES ('{0}');", bcode);

                                MySqlCommand cmd1 = new MySqlCommand(insertQuery1, con);
                                if (cmd1.ExecuteNonQuery() != 1)
                                    MessageBox.Show("추가 실패");
                            }


                            txtBookName.Text = "";
                            txtAuthor.Text = "";
                            txtPublisher.Text = "";
                            MessageBox.Show("책이 추가 되었습니다.");
                        }
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }

        }



        private void adminBookAddView_Load(object sender, EventArgs e)
        {

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

        private void txtBookName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAuthor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPublisher_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
