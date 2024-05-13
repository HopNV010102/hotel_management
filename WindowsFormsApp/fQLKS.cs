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
    public partial class fQLKS : Form
    {
        public fQLKS()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bt_phong_Click(object sender, EventArgs e)
        {
            fphong f0 = new fphong();
            this.Hide();
            f0.ShowDialog();
        }

        private void bt_khachhang_Click(object sender, EventArgs e)
        {
            fkhackhang f0 = new fkhackhang();
            this.Hide();
            f0.ShowDialog();
        }

        private void bt_dichvu_Click(object sender, EventArgs e)
        {
            fdichvu f0 = new fdichvu();
            this.Hide();
            f0.ShowDialog();
        }

        private void bt_thongke_Click(object sender, EventArgs e)
        {
            fthongke f0 = new fthongke();
            this.Hide();
            f0.ShowDialog();
        }

        private void bt_thongtin_Click(object sender, EventArgs e)
        {
            fthongtin f0 = new fthongtin();
            this.Hide();
            f0.ShowDialog();
        }

        private void bt_trogiup_Click(object sender, EventArgs e)
        {
            ftrogiup f0 = new ftrogiup();
            this.Hide();
            f0.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fdangnhap f0 = new fdangnhap();
            this.Hide();
            f0.ShowDialog();
        }
    }
}
