using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class fdangnhap : Form
    {

        public static string tk ;
        public fdangnhap()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Connection.conn);
            try
            {
                conn.Open();
                tk = txtTaiKhoan.Text;
                string mk = txtMatKhau.Text;
                string sql = "select * from TAIKHOAN where ten_TK ='" +tk +"'and matkhau_TK ='"+mk+"'" ;
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read()==true)
                {
                    MessageBox.Show("đăng nhập thành công","thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    fQLKS a = new fQLKS();
                    this.Hide();
                    a.ShowDialog();

                }
                else { MessageBox.Show("tài khoản hoặc mật khẩu không chính xác","thông báo", MessageBoxButtons.OK,MessageBoxIcon.Error); }
            }
            catch(Exception ex)
            {
                MessageBox.Show("lỗi kết nối");
                Console.WriteLine(ex.Message);

            }
            finally { conn.Close(); }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn thực sự muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dlr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
