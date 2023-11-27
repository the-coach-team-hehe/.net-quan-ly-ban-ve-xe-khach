using Coach_Ticket_Management.Forms.BaseForms;
using Coach_Ticket_Management.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coach_Ticket_Management.Forms.ActionForms
{
    public partial class QLNhanVien : BaseForm
    {
        Button previousActionButton;
        DataTable dt = DataAdapterHandler.GetDataTableThongTinNhanViens();
        public QLNhanVien()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.Load += QLNhanVien_Load;
        }

        private void QLNhanVien_Load(object sender, EventArgs e)
        {
            FirstTimeSetEnabled();
            dataGridView_thongtinnhanvien.DataSource = dt;
            dataGridView_thongtinnhanvien.AllowUserToAddRows = false;
            dataGridView_thongtinnhanvien.AllowUserToDeleteRows = false;
            dataGridView_thongtinnhanvien.AllowUserToResizeColumns = false;
            dataGridView_thongtinnhanvien.AllowUserToResizeRows = false;
            dataGridView_thongtinnhanvien.RowHeadersVisible = false;
            dataGridView_thongtinnhanvien.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView_thongtinnhanvien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView_thongtinnhanvien.BackgroundColor = DefaultBackColor;
            dataGridView_thongtinnhanvien.CellClick += DataGridView_thongtinnhanvien_CellClick;

            cbbox_chucvu.DataSource = DataAdapterHandler.GetDataTableChucVus();
            cbbox_chucvu.DisplayMember = "TenChucVu";

            cbbox2_chucvu.DataSource = DataAdapterHandler.GetDataTableChucVus();
            cbbox2_chucvu.DisplayMember = "TenChucVu";
            cbbox2_chucvu.ValueMember = "MaChucVu";

            cbbox2_chucvu.Text = string.Empty;

            tb2_matkhau.PasswordChar = '*';
            btn_showpassword.Text = "Hiển thị";
        }

        private void DataGridView_thongtinnhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dataGridView_thongtinnhanvien.CurrentRow;
                tb2_manhanvien.Text = r.Cells[0].Value.ToString();
                cbbox2_chucvu.Text = r.Cells[1].Value.ToString();
                tb2_tendangnhap.Text = r.Cells[2].Value.ToString();
                tb2_hotennhanvien.Text = r.Cells[3].Value.ToString();
                tb2_cccd.Text = r.Cells[4].Value.ToString();
                tb2_sodienthoai.Text = r.Cells[5].Value.ToString();
                tb2_diachi.Text = r.Cells[6].Value.ToString();

                DataTable cdt = DataAdapterHandler.GetMatKhauNhanVien(Convert.ToInt32(tb2_manhanvien.Text));

                tb2_matkhau.Text = cdt.Rows[0]["MatKhau"].ToString();

                ControlHandler.SetEnabled(true, btn_xoa, btn_sua);
            }
        }

        private void FirstTimeSetEnabled()
        {
            ControlHandler.SetEnabled(false, btn_sua, btn_xoa, btn_luu, btn_huy,
                tb2_manhanvien, cbbox2_chucvu, tb2_tendangnhap, tb2_hotennhanvien,
                tb2_cccd, tb2_sodienthoai, tb2_matkhau, tb2_diachi);
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            previousActionButton = btn_them;
            ControlHandler.SetEnabled(true, cbbox2_chucvu, tb2_tendangnhap, tb2_hotennhanvien,
                tb2_cccd, tb2_sodienthoai, tb2_matkhau, tb2_diachi, btn_them, btn_luu, btn_huy);
            ControlHandler.SetEnabled(false, btn_sua, btn_xoa, btn_them, dataGridView_thongtinnhanvien);
            ControlHandler.SetText(string.Empty, cbbox2_chucvu, tb2_tendangnhap, tb_hotennhanvien,
                tb2_cccd, tb2_sodienthoai, tb2_matkhau);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            previousActionButton = btn_xoa;
            DialogResult r = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?\n" +
                "Lưu ý: Các vé được bán bởi nhân viên này sẽ không hiển thị tên nhân viên bán!", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                try
                {
                    // do something
                }
                catch
                {
                    MessageBox.Show("Có lỗi không xác định!");
                }
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            previousActionButton = btn_sua;
            ControlHandler.SetEnabled(true, cbbox2_chucvu, tb2_tendangnhap, tb2_hotennhanvien,
                tb2_cccd, tb2_sodienthoai, tb2_diachi, tb2_matkhau, btn_them, btn_luu, btn_huy);
            ControlHandler.SetEnabled(false, btn_sua, btn_xoa, btn_them, dataGridView_thongtinnhanvien);
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (previousActionButton == btn_them)
            {
                try
                {
                    int MaChucVu = Convert.ToInt32(cbbox2_chucvu.SelectedValue);
                    string TenNhanVien = tb2_hotennhanvien.Text;
                    string DiaChi = tb2_diachi.Text;
                    string CCCD = tb2_cccd.Text;
                    string SoDienThoai = tb2_sodienthoai.Text;
                    string TenDangNhap = tb2_tendangnhap.Text;
                    string MatKhau = tb2_matkhau.Text;
                    MessageBox.Show(DataAdapterHandler.InsertNhanVien(MaChucVu, TenDangNhap, MatKhau, TenNhanVien, CCCD, DiaChi, SoDienThoai));
                }
                catch
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                }
            }
            if (previousActionButton == btn_sua)
            {
                try
                {
                    int MaNhanVien = Convert.ToInt32(tb2_manhanvien.Text);
                    int MaChucVu = Convert.ToInt32(cbbox2_chucvu.SelectedValue);
                    string TenNhanVien = tb2_hotennhanvien.Text;
                    string DiaChi = tb2_diachi.Text;
                    string CCCD = tb2_cccd.Text;
                    string SoDienThoai = tb2_sodienthoai.Text;
                    string TenDangNhap = tb2_tendangnhap.Text;
                    string MatKhau = tb2_matkhau.Text;
                    MessageBox.Show(DataAdapterHandler.UpdateNhanVien(MaNhanVien, MaChucVu, TenDangNhap, MatKhau, TenNhanVien, CCCD, DiaChi, SoDienThoai));
                }
                catch
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                }
            }
            ControlHandler.SetEnabled(false, cbbox2_chucvu, tb2_tendangnhap, tb2_hotennhanvien,
                tb2_cccd, tb2_sodienthoai, tb2_diachi, tb2_matkhau, btn_them, btn_luu, btn_huy);
            ControlHandler.SetEnabled(true, btn_sua, btn_xoa, btn_them, dataGridView_thongtinnhanvien);
            dt = DataAdapterHandler.GetDataTableThongTinNhanViens();
            dataGridView_thongtinnhanvien.DataSource = dt;
            previousActionButton = null;
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            ControlHandler.SetEnabled(false, cbbox2_chucvu, tb2_tendangnhap, tb2_hotennhanvien,
                tb2_cccd, tb2_sodienthoai, tb2_matkhau, tb2_diachi, btn_them, btn_luu, btn_huy);
            ControlHandler.SetEnabled(true, btn_sua, btn_xoa, btn_them, dataGridView_thongtinnhanvien);
            previousActionButton = null;
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            bool isHavePrev = false;
            string filter = string.Empty;
            if (tb_manhanvien.Text != string.Empty)
            {
                filter += string.Format("(CONVERT([Mã nhân viên], System.String) = '{0}')", tb_manhanvien.Text);
                isHavePrev = true;
            }
            if (cbbox_chucvu.Text != string.Empty)
            {
                if (isHavePrev)
                    filter += " AND ";
                filter += string.Format("([Chức vụ] LIKE '%{0}%')", cbbox_chucvu.Text);
                isHavePrev = true;
            }
            if (tb_hotennhanvien.Text != string.Empty)
            {
                if (isHavePrev)
                    filter += " AND ";
                filter += string.Format("([Họ tên nhân viên] LIKE '%{0}%')", tb_hotennhanvien.Text);
            }
            dt.DefaultView.RowFilter = filter;
        }

        private void btn_showall_Click(object sender, EventArgs e)
        {
            dt.DefaultView.RowFilter = string.Empty;
        }

        private void btn_showpassword_Click(object sender, EventArgs e)
        {
            if (tb2_matkhau.PasswordChar == '*')
            {
                tb2_matkhau.PasswordChar = '\0';
                btn_showpassword.Text = "Che";
            }
            else
            {
                tb2_matkhau.PasswordChar = '*';
                btn_showpassword.Text = "Hiển thị";
            }
        }
    }
}
