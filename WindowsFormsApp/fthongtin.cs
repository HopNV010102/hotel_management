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
    public partial class fthongtin : Form
    {
        public fthongtin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fQLKS f0 = new fQLKS();
            this.Hide();
            f0.ShowDialog();
        }

        private void fthongtin_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Connection.conn);
            try
            {
                conn.Open();
                string tentk = fdangnhap.tk;
                string sql = "select tenhienthi_TK , gioitinh , sdt , diachi , email from TaiKhoan where ten_TK = '"+tentk+"'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    txt_ten.Text = dta.GetString(0);
                    txt_gioitinh.Text = dta.GetString(1);
                    txt_sdt.Text = dta.GetString(2);
                    txt_diachi.Text = dta.GetString(3);
                    txt_email.Text = dta.GetString(4);
                }
                else { MessageBox.Show("ko có thong tin", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi kết nối");
                Console.WriteLine(ex.Message);

            }
            finally { conn.Close(); }


        }
       }


}

