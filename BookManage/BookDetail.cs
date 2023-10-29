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
    public partial class BookDetail : Form
    {
        string Bcode;
        string Pub;
        string Writer;
        string Bname;
        string Userid;

        string _server = "localhost"; //DB 서버 주소, 로컬일 경우 localhost
        int _port = 3308; //DB 서버 포트
        string _database = "1zo"; //DB 이름
        string _id = "root"; //계정 아이디
        string _pw = "1234"; //계정 비밀번호
        string _connectionAddress = "";
        string SelectBookImg(MySqlConnection con)
        {
            string strSql1 = "SELECT bookImgPath FROM bookinfo WHERE bookCode = " + Bcode;
            MySqlCommand cmd2 = new MySqlCommand(strSql1, con);
            return (string)cmd2.ExecuteScalar();
        }
        public BookDetail(string userid,DataGridViewCell bcode, DataGridViewCell bname, DataGridViewCell pub, DataGridViewCell writer)
        {
            InitializeComponent();
            this.Bcode = bcode.FormattedValue.ToString();
            this.Bname=bname.FormattedValue.ToString(); 
            this.Pub = pub.FormattedValue.ToString();
            this.Writer = writer.FormattedValue.ToString();
            this.Userid = userid;
        }

        private void BookDetail_Load(object sender, EventArgs e)
        {
            lbl_code.Text = Bcode;

            _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}"
              , _server, _port, _database, _id, _pw);


            MySqlConnection con = new MySqlConnection(_connectionAddress);
            con.Open();
            string strSql = "SELECT * FROM bookdetailinfo WHERE bookCode = @Value";
            MySqlCommand cmd = new MySqlCommand(strSql, con);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.SelectCommand.Parameters.Add(new MySqlParameter("@Value", lbl_code.Text));
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows[0][2].ToString() == "")
            {
                lbl_rentdate.Text = Convert.ToString(dt.Rows[0][2]);
                lbl_returndate.Text = Convert.ToString(dt.Rows[0][3]);
                lbl_rentname.Text= Convert.ToString(dt.Rows[0][1]);
            }
            else
            {
                lbl_rentname.Text = Convert.ToString(dt.Rows[0][1]);
                lbl_rentdate.Text = Convert.ToString(dt.Rows[0][2]).Substring(0,10);
                lbl_returndate.Text = Convert.ToString(dt.Rows[0][3]).Substring(0,10);
            }

            string path = SelectBookImg(con);

            con.Close();

            //이미지 출력
            bookpic.Load(path);
            bookpic.SizeMode =PictureBoxSizeMode.StretchImage;
            lbl_bname.Text = Bname;
            lbl_pub.Text = Pub;
            lbl_writer.Text = Writer;
            if(lbl_rentdate.Text !="" && lbl_returndate.Text != "")
            {
                btn_rent.Enabled = false;
                if(lbl_rentname.Text == Userid)
                {
                    btn_return.Enabled = true;
                }
                else
                {
                    btn_return.Enabled = false;
                }
            }
            else
            {
                btn_return.Enabled = false;
            }
        }

        private void btn_rent_Click(object sender, EventArgs e)
        {
            _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}"
              , _server, _port, _database, _id, _pw);

            label5.Text = DateTime.Now.ToString("yyyy-MM-dd");
            label8.Text= DateTime.Now.AddDays(7).ToString("yyyy-MM-dd"); 

            MySqlConnection con = new MySqlConnection(_connectionAddress);
            con.Open();
            string strSql = "update bookdetailinfo set rentalName = '" + Userid + "', rentalDate ='" + this.label5.Text + "',returnDate ='" + this.label8.Text+"' where bookCode= "+lbl_code.Text+";"; 
            MySqlCommand cmd = new MySqlCommand(strSql, con);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {            }
            lbl_rentdate.Text = label5.Text;
            lbl_returndate.Text = label8.Text;
            lbl_rentname.Text = Userid;

            con.Close();
            btn_return.Enabled = true;
            btn_rent.Enabled = false;
            MessageBox.Show("대여 되었습니다.");
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}"
             , _server, _port, _database, _id, _pw);
            MySqlConnection con = new MySqlConnection(_connectionAddress);
            con.Open();
            string strSql = "update bookdetailinfo set rentalName = NULL, rentalDate =NULL ,returnDate =NULL where bookCode= " + lbl_code.Text + ";";
            MySqlCommand cmd = new MySqlCommand(strSql, con);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            { }
            lbl_rentdate.Text = "";
            lbl_returndate.Text = "";
            lbl_rentname.Text = "";

            con.Close();
            btn_rent.Enabled = true;
            btn_return.Enabled = false;

            MessageBox.Show("반납 되었습니다.");
        }
    }
}
