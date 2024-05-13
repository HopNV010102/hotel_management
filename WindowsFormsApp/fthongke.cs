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
    public partial class fthongke : Form
    {
        public fthongke()
        {
            InitializeComponent();
        }

        private void fthongke_Load(object sender, EventArgs e)
        {
  
            Modify modify = new Modify();
            dataGridView1.DataSource = modify.GetDataTableHoadon();
            int dt = 0;
            int a = dataGridView1.Rows.Count - 1;
            for (int i = 0; i < a; i++)
            {
                dt += int.Parse(dataGridView1.Rows[i].Cells[8].Value.ToString());

            }
            txt_Dt.Text = dt.ToString();

        }

        private void close(object sender, FormClosedEventArgs e)
        {
            fQLKS a = new fQLKS();
            this.Hide();
            a.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tu = txt_tungay.Text;
            string den = txt_denngay.Text;
           
            Modify modify = new Modify();
            dataGridView1.DataSource = modify.GetDataTableThongke(tu, den);

            int dt = 0;
            int a = dataGridView1.Rows.Count - 1;
            for (int i = 0; i < a; i++)
            {
                dt += int.Parse(dataGridView1.Rows[i].Cells[8].Value.ToString());

            }
            txt_Dt.Text = dt.ToString();
        }
    }
}
