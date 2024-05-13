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
    public partial class fthanhtoan : Form
    {
        public fthanhtoan()
        {
            InitializeComponent();
        }

        private void fthanhtoan_Load(object sender, EventArgs e)
        {
            txt_mahd.Text = ftraphong.ma_hd;
            txt_mkh.Text = ftraphong.ma_kh;
            txt_mp.Text = ftraphong.ma_p;
            string id_HD = txt_mahd.Text;
            Modify modify = new Modify();
            dataGridView1.DataSource = modify.GetDataTableHoaDonDichVu(id_HD);
            dataGridView2.DataSource = modify.GetDataTableHoaDonphong(id_HD);
            int a = dataGridView1.Rows.Count - 1 ;
            int tongDV = 0 ;
            int tongP = int.Parse(dataGridView2.Rows[0].Cells[5].Value.ToString());
            for (int i = 0; i < a; i++)
            {
           
                tongDV += int.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
             
            }
                
                txt_tong.Text = (tongDV+tongP).ToString();
         
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tong = txt_tong.Text;
            DialogResult dlr = MessageBox.Show(" Xác nhận thanh toán "+ tong +" ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            string id_HD = txt_mahd.Text;
            SqlConnection sqlConnection = new SqlConnection(Connection.conn);
            string query = "update HOADON set tinhtrang = '1' where id_HD = '" + id_HD + "'";

            if (dlr == DialogResult.Yes)
            {
                try
                {
                    sqlConnection.Open();
                    SqlCommand cmd = new SqlCommand(query, sqlConnection);
                    cmd.ExecuteNonQuery();
                    fkhackhang a = new fkhackhang();
                    this.Hide();
                    a.ShowDialog();

                }
                catch
                {
                    MessageBox.Show(" lỗi thao tác ");
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

