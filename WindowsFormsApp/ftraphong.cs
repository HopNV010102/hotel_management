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
    public partial class ftraphong : Form
    {

        public static string ma_hd;
        public static string ma_p;
        public static string ma_kh = fkhackhang.id_kh;
        public ftraphong()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ftraphong_Load(object sender, EventArgs e)
        {
            txt_maKh.Text = fkhackhang.id_kh;
            Modify modify = new Modify();
            dataGridView1.DataSource = modify.GetDataTableTraPhong();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fkhackhang a = new fkhackhang();
            this.Hide();
            a.ShowDialog();
        }

        private void click(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            string id_hd = row.Cells[0].Value.ToString();
            string id_mp = row.Cells[5].Value.ToString();
            ma_hd = id_hd;
            ma_p = id_mp;
            txt_maHD.Text = id_hd;
            txt_maphong.Text = id_mp;
        }

        private void bt_traphong_Click(object sender, EventArgs e)
        {
            if (txt_ngaytra.Text =="")
            {
                MessageBox.Show("vui lòng nhập ngày trả phòng");
            }
            else
            {

                string ngaytra = txt_ngaytra.Text;
                SqlConnection sqlConnection = new SqlConnection(Connection.conn);
                string query1 = " update HOADON set ngaytra = '"+ngaytra+"' where id_HD = '"+ma_hd+"'";
                string query2 = "update PHONG set tinhtrang =N'Sẵn sàng' where id_P = '" + ma_p + "'";

                try
                {
                    sqlConnection.Open();
                    SqlCommand cmd = new SqlCommand(query1, sqlConnection);
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = query2;
                    cmd.ExecuteNonQuery();
                    fthanhtoan a = new fthanhtoan();
                    this.Hide();
                    a.ShowDialog();
               
                }
                catch
                {
                    MessageBox.Show(" khong tra duoc ");
                }
                finally
                {
                    sqlConnection.Close();
                }
            }


        }

        private void close(object sender, FormClosedEventArgs e)
        {
            fkhackhang a = new fkhackhang();
            this.Hide();
            a.ShowDialog();
        }
    }
}
