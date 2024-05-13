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
    public partial class fdatdichvu : Form
    {
        public fdatdichvu()
        {
            InitializeComponent();
        }

        private void fdichvu_Load(object sender, EventArgs e)
        {
            
        
            Modify modify = new Modify();
            txt_makh.Text = fkhackhang.id_kh;
            txt_mhd.Text = fkhackhang.id_hd;
            dataGridView1.DataSource = modify.GetDataTableDichVu();
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void closed(object sender, FormClosedEventArgs e)
        {
            fkhackhang a = new fkhackhang();
            this.Hide();
            a.ShowDialog();
        }

        private void click(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void click2(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            txt_madv.Text = row.Cells[0].Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            fkhackhang a = new fkhackhang();
            this.Hide();
            a.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id_HD = txt_mhd.Text;
            string id_DV =txt_madv.Text;
            string soluong = txt_sl.Text;
            string ngaysudung = txt_ngaysd.Text;
            SqlConnection sqlConnection = new SqlConnection(Connection.conn);
            string query1 = "insert into CHITIETHOADON values ('"+id_HD+"','"+id_DV+"','"+soluong+"','"+ngaysudung+"')";

            try
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand(query1, sqlConnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã thêm dịch vụ vào hóa đơn");
            }
            catch
            {
                MessageBox.Show(" khong them duoc ");
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
