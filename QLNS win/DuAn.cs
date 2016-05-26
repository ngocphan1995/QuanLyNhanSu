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
    public partial class DuAn : Form
    {
        private SqlConnection conn;
        private SqlDataAdapter adapter;
        private DataTable dataTable;
        public DuAn()
        {
            InitializeComponent();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO [CTDuAn] (MaDA, MaNV, NgayThamGia, CongViec) VALUES (@MaDA, @MaNV, @NgayThamgia, @CongViec)", conn);
            cmd.Parameters.AddWithValue("@MaDA", cbDuan.SelectedValue);
            cmd.Parameters.AddWithValue("@MaNV", cbNhanVien.SelectedValue);
            cmd.Parameters.AddWithValue("@NgayThamGia", tbNgayThamGia.Text);
            cmd.Parameters.AddWithValue("@Congviec", tbCongViec.Text);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm mới thành công", "Thông báo");
                loadGrid();
            }
            catch
            {
                MessageBox.Show("Lỗi không xác định", "Thông báo");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = DB.GetConnection();
            loadGrid();
            loadComboNhanVien();
            loadComboDuAn();
        }
        private void loadComboNhanVien()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM [NhanVien]", conn);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset, "NhanVien");
            cbNhanVien.DataSource = dataset.Tables["NhanVien"];
            cbNhanVien.DisplayMember = "HoTen";
            cbNhanVien.ValueMember = "MaNV";
        }
        private void loadComboDuAn()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM [DuAn]", conn);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset, "DuAn");
            cbDuan.DataSource = dataset.Tables["DuAn"];
            cbDuan.DisplayMember = "TenDA";
            cbDuan.ValueMember = "MaDA";
        }
        private void loadGrid()
        {
            adapter = new SqlDataAdapter("SELECT [NHANVIEN].HoTen , [DuAn].* , [CTDuAn].NgayThamGia , [CTDuAn].CongViec FROM [CTDuAn], [DuAn] , [NHANVIEN] WHERE [CTDuAn].MaDA = [DuAn].MaDA AND [CTDuAn].MaNV = [NHANVIEN].MaNV", conn);
            new SqlCommandBuilder(adapter);
            dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgvDuAn.DataSource = dataTable;
            load_form();
        }
        private void load_form()
        {
            if (dgvDuAn.SelectedRows.Count == 0)
                return;
            DataGridViewRow row = dgvDuAn.SelectedRows[0];
            cbNhanVien.Text = row.Cells["HoTen"].Value.ToString().Trim();
            tbCongViec.Text = row.Cells["CongViec"].Value.ToString().Trim();
            tbNgayThamGia.Text = row.Cells["NgayThamGia"].Value.ToString();
            cbDuan.Text = row.Cells["TenDA"].Value.ToString().Trim();
        }

        private void dgvDuAn_SelectionChanged(object sender, EventArgs e)
        {
            load_form();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("SELECT *   From [CTDuAn] as b, [DuAn] as a, [NhanVien] as c WHERE a.MaDA = b.MaDA AND b.MaNV = c.MaNV AND a.TenDA LIKE N'%" + tbSeach.Text.ToString() + "%'", conn);
            new SqlCommandBuilder(adapter);
            dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgvDuAn.DataSource = dataTable;
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            tbCongViec.Text = "";
            tbNgayThamGia.Text = "";
            tbSeach.Text = "";
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE [CTDuAn] SET MaDA =  '" + cbDuan.SelectedValue + "',NgayThamGia =  '" + tbNgayThamGia.Text + "',CongViec =  N'" + tbCongViec.Text + "' WHERE MaNV =  '" + cbNhanVien.SelectedValue + "' ", conn);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhât thành công", "Thông báo");
                loadGrid();
            }
            catch
            {
                MessageBox.Show("Lỗi không xác định", "Thông báo");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("DELETE FROM [CTDuAn] WHERE MaDA= '" + cbDuan.SelectedValue + "'  AND MaNV= '" + cbNhanVien.SelectedValue + "'  ", conn);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công", "Thông báo");
                loadGrid();
            }
            catch
            {
                MessageBox.Show("Lỗi không xác định", "Thông báo");
            }

        }
    }
}
