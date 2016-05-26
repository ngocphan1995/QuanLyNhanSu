using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace QLNS_win
{
    public partial class BANGLUONG : Form
    {
        public BANGLUONG()
        {
            InitializeComponent();
        }
        private SqlConnection con;
        private SqlConnection connect()
        {
            string str = "Server=DINHNAMPC\\DB;Database=nhansu;UID=Client;PWD=123456";
            return new SqlConnection(str);
        }
        private void getdata()
        {
            string sql = "select Luong.*,HoTen,TenPhongBan,(LuongTG+TienThuong+TienPhuCap-Tien_BHXH-Tien_BHYT-TienPhat)as tongtien from PHONGBAN,NHANVIEN,Luong where NHANVIEN.MaNV=Luong.MaNV and NHANVIEN.MaPhongBan=PHONGBAN.MaPhongBan";
            SqlCommand cm = new SqlCommand(sql, con);
            SqlDataAdapter ad = new SqlDataAdapter(cm);
            DataTable table = new DataTable();
            ad.Fill(table);
            gdluong.DataSource = table;

        }
        private void Form1_Load(object sender, EventArgs e)
        {

            con = DB.GetConnection();
            //con.Open();
            //Bitmap img = new Bitmap(@"res\edit.png");
            DataGridViewImageColumn Xoa = new DataGridViewImageColumn();
            Xoa.Name = "Sua";
            Xoa.HeaderText = "";
            //Xoa.Image = img;

            gdluong.Columns.Insert(0, Xoa);
            Xoa.Width = 100;

            getdata();
            additemsmasv();
            additemsMaBangLuong();
        }
        private void additemsmasv()
        {
            string sql = "SELECT CTQTLUONG.*,HoTen FROM CTQTLUONG,NHANVIEN WHERE NHANVIEN.MaNV=CTQTLUONG.MaNV";
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            cmbmanv.DisplayMember="HoTen";
            cmbmanv.ValueMember="MaNV";
            cmbmanv.DataSource = ds.Tables[0];


        }
        private void additemsMaBangLuong()
        {
            string sql = "SELECT * FROM Bang_Luong";
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            cmbbangluong.ValueMember = "MaBangLuong";
            cmbbangluong.DisplayMember = "MaBangLuong";
            cmbbangluong.DataSource = ds.Tables[0];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void gdluong_SelectionChanged(object sender, EventArgs e)
        {
            if (gdluong.SelectedRows.Count == 0) return;
            DataGridViewRow row = gdluong.SelectedRows[0];
            cmbmanv.Text = row.Cells["manv"].Value.ToString();
            cmbbangluong.Text = row.Cells["mabangluong"].Value.ToString();
            txtsongaylam.Text = row.Cells["songaylam"].Value.ToString();
            txttienthuong.Text = row.Cells["tienthuong"].Value.ToString();
            txttienphat.Text = row.Cells["tienphat"].Value.ToString();
            txttienphucap.Text = row.Cells["tienphucap"].Value.ToString();
        }

        private void btnthemmoi_Click(object sender, EventArgs e)
        {
            try
            {
                validate();
                con = connect();
                con.Open();
                string sql = "insert into Luong(MaNV,MaBangLuong,SoNgayLam,TienThuong,TienPhat,TienPhuCap) values (" + cmbmanv.SelectedValue + "," + cmbbangluong.SelectedValue + "," + txtsongaylam.Text + ", " + txttienthuong.Text + ", " + txttienphat.Text + ", " + txttienphucap.Text + ")";
                SqlCommand cm = new SqlCommand(sql, con);
                cm.ExecuteNonQuery();
                cmbmanv.Text = "";
                cmbbangluong.Text = "";
                txtsongaylam.Text = "";
                txttienthuong.Text = "";
                txttienphat.Text = "";
                txttienphucap.Text = "";
                getdata();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Có lỗi xảy ra", "Lỗi", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
            
        }

        private void gdluong_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            cmbmanv.Text = gdluong.CurrentRow.Cells["hoten"].Value.ToString();
            cmbbangluong.Text = gdluong.CurrentRow.Cells[1].Value.ToString();
            txtsongaylam.Text = gdluong.CurrentRow.Cells[3].Value.ToString();
            txttienthuong.Text = gdluong.CurrentRow.Cells[5].Value.ToString();
            txttienphat.Text = gdluong.CurrentRow.Cells[6].Value.ToString();
            txttienphucap.Text = gdluong.CurrentRow.Cells[7].Value.ToString();
            cmbmanv.Enabled = false;
            cmbbangluong.Enabled = false;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                con = connect();
                con.Open();
                if (MessageBox.Show("bạn chắc chắn muốn xóa bản ghi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {

                    string sql = "delete Luong  where MaNV=" + cmbmanv.SelectedValue + " and MaBangLuong=" + cmbbangluong.SelectedValue + "";
                    SqlCommand com = new SqlCommand(sql, con);
                    com.ExecuteNonQuery();
                    con.Close();

                    cmbmanv.Text = "";
                    cmbbangluong.Text = "";
                    txtsongaylam.Text = "";
                    txttienthuong.Text = "";
                    txttienphat.Text = "";
                    txttienphucap.Text = "";
                    cmbmanv.Enabled = true;
                    cmbbangluong.Enabled = true;
                    getdata();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("có lỗi xảy ra", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
             cmbmanv.Text = "";
            cmbbangluong.Text = "";
            txtsongaylam.Text = "";
            txttienthuong.Text = "";
            txttienphat.Text = "";
            txttienphucap.Text = "";
            cmbmanv.Enabled = true;
            cmbbangluong.Enabled = true;
        }
        private void validate()
        {
            if (cmbmanv.Text.Length == 0)
            {
                MessageBox.Show("bạn không được bỏ trống họ tên nhân viên", "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            else if(cmbbangluong.Text.Length==0)
                {
                MessageBox.Show("bạn không được bỏ trống mã bảng lương", "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            else if(txtsongaylam.Text.Length==0)
                {
                MessageBox.Show("bạn không được bỏ trống số ngày làm", "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            else if(txttienthuong.Text.Length==0)
                {
                MessageBox.Show("bạn không được bỏ trống tiền thưởng", "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
             else if(txttienphat.Text.Length==0)
                {
                MessageBox.Show("bạn không được bỏ trống tiền phạt", "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
             else if(txttienphucap.Text.Length==0)
                {
                MessageBox.Show("bạn không được bỏ trống tiền phụ cấp", "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
        }
        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                validate();
                con = connect();
                con.Open();
                string sql = "update Luong set SoNgayLam=" + txtsongaylam.Text + ",TienThuong=" + txttienthuong.Text + ",TienPhat=" + txttienphat.Text + ",TienPhuCap=" + txttienphucap.Text + " where MaNV=" + cmbmanv.SelectedValue + " and MaBangLuong=" + cmbbangluong.SelectedValue + "";
                SqlCommand cm = new SqlCommand(sql, con);
                cm.ExecuteNonQuery();
                cmbmanv.Text = "";
                cmbbangluong.Text = "";
                txtsongaylam.Text = "";
                txttienthuong.Text = "";
                txttienphat.Text = "";
                txttienphucap.Text = "";
                getdata();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("có lỗi xảy ra", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con = connect();
            con.Open();
            string sql = "select Luong.*,HoTen,TenPhongBan,(LuongTG+TienThuong+TienPhuCap-Tien_BHXH-Tien_BHYT-TienPhat)as tongtien from PHONGBAN,NHANVIEN,Luong where NHANVIEN.MaNV=Luong.MaNV and NHANVIEN.MaPhongBan=PHONGBAN.MaPhongBan and HoTen like N'%"+txttimkiem.Text+"%'";
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable tb=new DataTable();
            ad.Fill(tb);
            gdluong.DataSource = tb;
            if (tb.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy", "Thông báo", MessageBoxButtons.OKCancel);
            }
            txttimkiem.Text = "";
        }
    }
}
