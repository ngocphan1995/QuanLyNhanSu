using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLNS_win
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btNhanVien_Click(object sender, EventArgs e)
        {
            
        }

        private void btDuAn_Click(object sender, EventArgs e)
        {
            Form f1 = new DuAn();
            f1.Show();
        }

        private void btLuong_Click(object sender, EventArgs e)
        {
            Form f = new BANGLUONG();
            f.Show();
        }
    }
}
