using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLNS_win
{
    public partial class Login : Form
    {
        private SqlConnection conn;
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int res = 0;
            SqlCommand com = new SqlCommand("login", conn);
            com.CommandType = CommandType.StoredProcedure;
            SqlParameter p1 = new SqlParameter("username", tbUsername.Text);
            SqlParameter p2 = new SqlParameter("password", tbpass.Text);
            com.Parameters.Add(p1);
            com.Parameters.Add(p2);
            res = (int)com.ExecuteScalar();
            if (res > 0)
            {
                MessageBox.Show("Đăng nhập thành công! ", "Đăng nhập");
                Form f1 = new Login();
                Form f2 = new Main();
                f1.Hide();
                f2.Show();
            }

            else
            {
                MessageBox.Show("Tài khoản hoặc tên đăng nhập chưa đúng!", "Cảnh báo");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            conn = DB.GetConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đăng nhập thành công! ", "Đăng nhập");
            Form f = new DuAn();
            f.Show();
            
        }
    }
}
