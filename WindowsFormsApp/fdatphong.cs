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
    public partial class fdatphong : Form
    {
        public fdatphong()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Modify modify = new Modify();
            txt_id_MKH.Text = fkhackhang.id_kh;
            dataGridView1.DataSource = modify.GetDataTableDatPhong();
            txt_id_hd.Text = (int.Parse(fkhackhang.id_hd) + 1).ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cellclick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            string id_p = row.Cells[0].Value.ToString();
            txt_id_p.Text = id_p;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txt_id_hd.Text == "" || txt_ngaydat.Text == "")
            {
                MessageBox.Show("vui long nhap ma hoa don va ngay dat");
            }
            else {
                string id_HD = txt_id_hd.Text;
                string ngayvao = txt_ngaydat.Text;
                string maPhong = txt_id_p.Text;
                string makhachhang = txt_id_MKH.Text;
                SqlConnection sqlConnection = new SqlConnection(Connection.conn);
                string query1 = "insert into HOADON values('"+id_HD+"','"+ makhachhang +"','"+ngayvao+"', null, '0', '"+maPhong+"')";
                string query2 = "update PHONG set tinhtrang =N'Đã thuê' where id_P = '"+ maPhong +"'";
                try
                {
                    sqlConnection.Open();
                    SqlCommand cmd = new SqlCommand(query1, sqlConnection);
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = query2;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("đặt phòng thành công");
                }
                catch
                {
                    MessageBox.Show(" khong dat duoc ");
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            fkhackhang a = new fkhackhang();
            this.Hide();
            a.ShowDialog();
        }

        private void close(object sender, FormClosedEventArgs e)
        {
            fkhackhang a = new fkhackhang();
            this.Hide();
            a.ShowDialog();
        }
    }
}
