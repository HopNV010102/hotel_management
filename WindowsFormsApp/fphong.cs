using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class fphong : Form
    {
        public fphong()
        {
            InitializeComponent();
        }
        public static string id_P;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void fphong_Load(object sender, EventArgs e)
        {
            Modify modify = new Modify();
            dataGridView1.DataSource = modify.GetDataTablePhong();

        }

        private void fphong_closed(object sender, FormClosedEventArgs e)
        {
            fQLKS a = new fQLKS();
            this.Hide();
            a.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fdatphong a = new fdatphong();
            a.ShowDialog();
        }

        private void cellclick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            id_P = row.Cells[0].Value.ToString();
        }

        private void click(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            txt_maphong.Text = row.Cells[0].Value.ToString();
            txt_tenphong.Text = row.Cells[1].Value.ToString();
            txt_tinhtrang.Text = row.Cells[3].Value.ToString();
            txt_loaiphong.Text = row.Cells[2].Value.ToString();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            Modify modify = new Modify();
            string id = txt_maphong.Text;
            string ten = txt_tenphong.Text;
            string tinhtrang = txt_tinhtrang.Text;
            string loaiphong = txt_loaiphong.Text;
          
            if (modify.insertphong(id, ten, tinhtrang, loaiphong))
            {
                dataGridView1.DataSource = modify.GetDataTablePhong();
            }
            else { MessageBox.Show("Kiểm tra lại mã phòng hoặc loại phòng"); }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            Modify modify = new Modify();
            string id = txt_maphong.Text;
            if (modify.deletePhong(id))
            {
                dataGridView1.DataSource = modify.GetDataTablePhong();
            }
            else { MessageBox.Show("không xóa được phòng"); }
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            Modify modify = new Modify();
            string id = txt_maphong.Text;
            string ten = txt_tenphong.Text;
            string tinhtrang = txt_tinhtrang.Text;
            string loaiphong = txt_loaiphong.Text;

            if (modify.updatephong(id, ten, tinhtrang, loaiphong))
            {
                dataGridView1.DataSource = modify.GetDataTablePhong();
            }
            else { MessageBox.Show("Kiểm tra lại mã phòng hoặc loại phòng"); }

        }
    }
}
