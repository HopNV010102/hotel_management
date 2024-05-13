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
    public partial class fkhackhang : Form
    {
        public static string id_kh;
        public static string id_hd;
        public fkhackhang()
        {
            InitializeComponent();
        }

        private void closed(object sender, FormClosedEventArgs e)
        {
            fQLKS a = new fQLKS();
            this.Hide();
            a.ShowDialog();
        }

        private void fkhackhang_Load(object sender, EventArgs e)
        {
           Modify modify = new Modify();
           dataGridView1.DataSource = modify.GetDataTablekhachhang();

        }

        private void click(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            id_kh = row.Cells[0].Value.ToString();
           txt_MKH.Text = row.Cells[0].Value.ToString();
            txt_tkh.Text = row.Cells[1].Value.ToString();
            txt_ngaysinh.Text = row.Cells[2].Value.ToString();
            txt_gioitinh.Text = row.Cells[3].Value.ToString();
            txt_cccd.Text = row.Cells[4].Value.ToString();
            txt_quoctich.Text = row.Cells[5].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Connection.conn);
            try
            {
                conn.Open();
                string id_kh = fkhackhang.id_kh;
                string sql = "select max(id_HD) from HOADON";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    id_hd = dta.GetInt32(0).ToString();
                    fdatphong a = new fdatphong();
                    a.ShowDialog();

                }
                else { MessageBox.Show("khách hàng chưa đặt phòng tại khách sạn", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi kết nối");
                Console.WriteLine(ex.Message);

            }
            finally { conn.Close(); }

        }

        private void traphong_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Connection.conn);
            try
            {
                conn.Open();
                string id_kh = fkhackhang.id_kh;
                string sql = "select  KHACHHANG.ten , KHACHHANG.ngaysinh , KHAChHANG.id_KH , PHONG.ten_P , HOADON.id_HD from KHACHHANG , HOADON , PHONG where KHACHHANG.id_KH = HOADON.id_KH and HOADON.id_P = PHONG.id_P and HOADON.ngaytra is null and HOADON.tinhtrang = '0' and KHACHHANG.id_KH ='" + id_kh + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    id_hd = dta.GetInt32(4).ToString();
                    ftraphong a = new ftraphong();
                    a.ShowDialog();

                }
                else { MessageBox.Show("khách hàng chưa đặt phòng tại khách sạn", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi kết nối");
                Console.WriteLine(ex.Message);

            }
            finally { conn.Close(); }

        }

        private void Dichvu_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Connection.conn);
            try
            {
                conn.Open();
                string id_kh = fkhackhang.id_kh;
                string sql = "select  KHACHHANG.ten , KHACHHANG.ngaysinh , KHAChHANG.id_KH , PHONG.ten_P , HOADON.id_HD from KHACHHANG , HOADON , PHONG where KHACHHANG.id_KH = HOADON.id_KH and HOADON.id_P = PHONG.id_P and HOADON.tinhtrang = '0' and KHACHHANG.id_KH ='" + id_kh + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    id_hd = dta.GetInt32(4).ToString() ;
                    fdatdichvu a = new fdatdichvu();
                    this.Hide();
                    a.ShowDialog();

                }
                else { MessageBox.Show("Vui lòng đặt phòng trước khi sử dụng dịch vụ của khách sạn", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi kết nối");
                Console.WriteLine(ex.Message);

            }
            finally { conn.Close(); }
         
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            Modify modify = new Modify();
            string id = txt_MKH.Text;
            string ten = txt_tkh.Text;
            string ngaysinh = txt_ngaysinh.Text;
            string gioitinh = txt_gioitinh.Text;
            string cccd = txt_cccd.Text;
            string quoctich = txt_quoctich.Text;
            if (modify.insertkhachhang(id, ten, ngaysinh, gioitinh, cccd, quoctich))
            {
                dataGridView1.DataSource = modify.GetDataTablekhachhang();
            }

        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            Modify modify = new Modify();
            string id = txt_MKH.Text;
            if (modify.deletekhachhang(id))
            {
                dataGridView1.DataSource = modify.GetDataTablekhachhang();
            }
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            Modify modify = new Modify();
            string id = txt_MKH.Text;
            string ten = txt_tkh.Text;
            string ngaysinh = txt_ngaysinh.Text;
            string gioitinh = txt_gioitinh.Text;
            string cccd = txt_cccd.Text;
            string quoctich = txt_quoctich.Text;
            if (modify.updatekhachhang(id, ten, ngaysinh, gioitinh, cccd, quoctich))
            {
                dataGridView1.DataSource = modify.GetDataTablekhachhang();
               
            }

        }
    
    }
}
