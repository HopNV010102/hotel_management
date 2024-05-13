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
    public partial class ftrogiup : Form
    {
        public ftrogiup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fQLKS f0 = new fQLKS();
            this.Hide();
            f0.ShowDialog();
        }
    }
}
