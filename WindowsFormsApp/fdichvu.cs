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
    public partial class fdichvu : Form
    {
        public fdichvu()
        {
            InitializeComponent();
        }

        private void fdichvu_Load(object sender, EventArgs e)
        {
            Modify modify = new Modify();
            dataGridView1.DataSource = modify.GetDataTableDichVu();
        }

        private void close(object sender, FormClosedEventArgs e)
        {
            fQLKS a = new fQLKS();
            this.Hide();
            a.ShowDialog();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            Modify modify = new Modify();
            string id = txt_MDV.Text ;
            string ten = txt_tDV.Text;
            string gia = txt_giaDV.Text;
            if (modify.insertdichvu(id, ten, gia))
            {
                dataGridView1.DataSource = modify.GetDataTableDichVu();
            }
            else { MessageBox.Show("không thêm được dịch vụ do mã dịch vụ bị trùng"); }
        }

        private void click(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            txt_MDV.Text = row.Cells[0].Value.ToString();
            txt_tDV.Text = row.Cells[1].Value.ToString();
            txt_giaDV.Text = row.Cells[2].Value.ToString();
      
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            Modify modify = new Modify();
            string id = txt_MDV.Text;
            if (modify.deleteDichVu(id))
            {
                dataGridView1.DataSource = modify.GetDataTableDichVu();
            }
            else { MessageBox.Show("Không thể xóa"); }
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            Modify modify = new Modify();
            string id = txt_MDV.Text;
            string ten = txt_tDV.Text;
            string gia = txt_giaDV.Text;
            if (modify.updatedichvu(id, ten, gia))
            {
                dataGridView1.DataSource = modify.GetDataTableDichVu();
            }
            else { MessageBox.Show("không sửa được"); }
        }
    }
}
