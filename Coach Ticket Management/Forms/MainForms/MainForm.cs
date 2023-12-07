using Coach_Ticket_Management.Forms.ActionForms;
using Coach_Ticket_Management.Forms.BaseForms;
using Coach_Ticket_Management.Models;
using Coach_Ticket_Management.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Coach_Ticket_Management.Forms.MainForms
{
    public partial class MainForm : BaseForm
    {
        Button previousActionButton;
        DataTable dt = DataAdapterHandler.GetDataTableVeXes();
        public MainForm()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FirstTimeSetEnabled();
            RoleAssignment();
            dataGridView_thongtinvexe.DataSource = dt;
            dataGridView_thongtinvexe.AllowUserToAddRows = false;
            dataGridView_thongtinvexe.AllowUserToDeleteRows = false;
            dataGridView_thongtinvexe.AllowUserToResizeColumns = false;
            dataGridView_thongtinvexe.AllowUserToResizeRows = false;
            dataGridView_thongtinvexe.RowHeadersVisible = false;
            dataGridView_thongtinvexe.BackgroundColor = DefaultBackColor;
            dataGridView_thongtinvexe.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView_thongtinvexe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView_thongtinvexe.CellClick += DataGridView_thongtinvexe_CellClick;
            cbbox2_loaive.DataSource = DataAdapterHandler.GetDataTableLoaiVes();
            cbbox2_loaive.DisplayMember = "TenLoaiVe";
            cbbox2_loaive.ValueMember = "MaLoaiVe";
            cbbox_tuyen.DataSource = DataAdapterHandler.GetDataTableTuyens();
            cbbox_tuyen.DisplayMember = "TenTuyen";
            cbbox_tuyen.Text = String.Empty;
        }

        private void DataGridView_thongtinvexe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                tb2_mave.Text = dataGridView_thongtinvexe.CurrentRow.Cells[0].Value.ToString();
                tb2_machuyen.Text = dataGridView_thongtinvexe.CurrentRow.Cells[1].Value.ToString();
                tb2_tuyen.Text = dataGridView_thongtinvexe.CurrentRow.Cells[2].Value.ToString();
                cbbox2_loaive.Text = dataGridView_thongtinvexe.CurrentRow.Cells[3].Value.ToString();
                tb2_nhanvienbanve.Text = dataGridView_thongtinvexe.CurrentRow.Cells[4].Value.ToString();
                
                tb2_tenkhachhang.Text = dataGridView_thongtinvexe.CurrentRow.Cells[6].Value.ToString();
                tb2_giave.Text = dataGridView_thongtinvexe.CurrentRow.Cells[7].Value.ToString();
                tb2_ngaykhoihanh.Text = dataGridView_thongtinvexe.CurrentRow.Cells[8].Value.ToString();

                cbbox2_soghe.DataSource = DataAdapterHandler.GetDataTableGhesConTrong(Convert.ToInt32(tb2_machuyen.Text));
                cbbox2_soghe.DisplayMember = "SoGhe";
                cbbox2_soghe.Text = dataGridView_thongtinvexe.CurrentRow.Cells[5].Value.ToString();
                ControlHandler.SetEnabled(true, btn_sua, btn_xoa, btn_inve);
            }
        }

        private void RoleAssignment()
        {
            Role role = CurrentUser.Role;
            if (role == Role.Employee)
                quảnLýNhânViênToolStripMenuItem.Enabled = quảnLýNhânViênToolStripMenuItem.Visible = false;
        }

        private void FirstTimeSetEnabled()
        {
            ControlHandler.SetEnabled(false, tb2_mave, tb2_machuyen, tb2_giave, tb2_ngaykhoihanh,
                tb2_nhanvienbanve, tb2_tuyen, tb2_tenkhachhang, btn_toPickChuyen, cbbox2_loaive,
                cbbox2_soghe, btn_sua, btn_xoa, btn_luu, btn_huy, btn_inve);
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            ControlHandler.SetEnabled(true, tb2_tenkhachhang, btn_toPickChuyen, cbbox2_loaive, cbbox2_soghe, btn_luu, btn_huy);
            ControlHandler.SetEnabled(false, btn_them, btn_xoa, btn_sua, dataGridView_thongtinvexe);
            ControlHandler.SetText(string.Empty, tb2_mave, tb2_tenkhachhang, tb2_tuyen, tb2_ngaykhoihanh, tb2_machuyen, cbbox2_loaive, cbbox2_soghe, tb2_giave);
            ControlHandler.SetText(CurrentUser.TenNhanVien, tb2_nhanvienbanve);
            previousActionButton = btn_them;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            previousActionButton = btn_xoa;
            DialogResult r = MessageBox.Show("Bạn có chắc muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                int MaVeXe = Convert.ToInt32(tb2_mave.Text);
                MessageBox.Show(DataAdapterHandler.XoaVeXe(MaVeXe));
            }
            previousActionButton = null;
            dt = DataAdapterHandler.GetDataTableVeXes();
            dataGridView_thongtinvexe.DataSource = dt;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            ControlHandler.SetEnabled(true, tb2_tenkhachhang, btn_toPickChuyen, cbbox2_loaive, cbbox2_soghe, btn_luu, btn_huy);
            ControlHandler.SetEnabled(false, btn_them, btn_xoa, btn_sua, dataGridView_thongtinvexe);
            previousActionButton = btn_sua;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (previousActionButton == btn_sua)
            {
                try
                {
                    int MaVeXe = Convert.ToInt32(tb2_mave.Text);
                    int MaChuyenXe = Convert.ToInt32(tb2_machuyen.Text);
                    int MaNhanVien = CurrentUser.MaNhanVien;
                    int MaLoaiVe = Convert.ToInt32(cbbox2_loaive.SelectedValue);
                    int SoGhe = Convert.ToInt32(cbbox2_soghe.Text);
                    string TenKhachHang = tb2_tenkhachhang.Text;
                    MessageBox.Show(DataAdapterHandler.UpdateVeXe(MaVeXe, MaChuyenXe, MaLoaiVe, MaNhanVien, SoGhe, TenKhachHang));
                }
                catch
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                }
            }
            if (previousActionButton == btn_them)
            {
                try
                {
                    int MaChuyenXe = Convert.ToInt32(tb2_machuyen.Text);
                    int MaNhanVien = CurrentUser.MaNhanVien;
                    int MaLoaiVe = Convert.ToInt32(cbbox2_loaive.SelectedValue);
                    int SoGhe = Convert.ToInt32(cbbox2_soghe.Text);
                    string TenKhachHang = tb2_tenkhachhang.Text;
                    MessageBox.Show(DataAdapterHandler.InsertVeXe(MaChuyenXe, MaLoaiVe, MaNhanVien, SoGhe, TenKhachHang));
                }
                catch
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                }

            }
            ControlHandler.SetEnabled(false, tb2_tenkhachhang, btn_toPickChuyen, cbbox2_loaive, cbbox2_soghe, btn_luu, btn_huy);
            ControlHandler.SetEnabled(true, btn_them, btn_xoa, dataGridView_thongtinvexe);
            previousActionButton = null;
            dt = DataAdapterHandler.GetDataTableVeXes();
            dataGridView_thongtinvexe.DataSource = dt;
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            bool isHavePrev = false;
            string filter = string.Empty;
            if (tb_mavexe.Text != string.Empty)
            {
                filter += string.Format("(CONVERT([Mã vé], System.String) = '%{0}%')", tb_mavexe.Text);
                isHavePrev = true;
            }
            if (tb_machuyen.Text != string.Empty)
            {
                if (isHavePrev)
                    filter += " AND ";
                filter += string.Format("(CONVERT([Mã chuyến], System.String) LIKE '%{0}%')", tb_machuyen.Text);
                isHavePrev = true;
            }
            if (dtpicker_ngaykhoihanh.Value != null)
            {
                string date = dtpicker_ngaykhoihanh.Value.ToString("dd/MM/yyyy");
                if (isHavePrev)
                    filter += " AND ";
                filter += string.Format("(CONVERT([Ngày khởi hành], System.String) LIKE '%{0}%')", date);
                isHavePrev = true;
            }
            if (tb_tenkhachhang.Text != string.Empty)
            {
                if (isHavePrev)
                    filter += " AND ";
                filter += string.Format("([Họ tên] LIKE '%{0}%')", tb_tenkhachhang.Text);
                isHavePrev = true;
            }
            if (cbbox_tuyen.Text != string.Empty)
            {
                if (isHavePrev)
                    filter += " AND ";
                filter += string.Format("([Tuyến] LIKE '%{0}%')", cbbox_tuyen.Text);
            }
            dt.DefaultView.RowFilter = filter;
        }

        private void btn_showall_Click(object sender, EventArgs e)
        {
            dt.DefaultView.RowFilter = String.Empty;
        }

        private void btn_toPickChuyen_Click(object sender, EventArgs e)
        {
            PickChuyen pickChuyen = new PickChuyen();
            if (previousActionButton == btn_sua)
                pickChuyen = new PickChuyen(tb2_machuyen.Text, tb2_tuyen.Text);
            pickChuyen.ShowDialog();
            tb2_machuyen.Text = pickChuyen.GetMaChuyen();
            tb2_tuyen.Text = pickChuyen.GetTenTuyen();
            tb2_ngaykhoihanh.Text = pickChuyen.GetThoiGianKhoiHanh();

            cbbox2_soghe.DataSource = null;
            if (tb2_machuyen.Text != string.Empty)
            {
                cbbox2_soghe.DataSource = DataAdapterHandler.GetDataTableGhesConTrong(Convert.ToInt32(tb2_machuyen.Text));
                cbbox2_soghe.DisplayMember = "SoGhe";
            }
            cbbox2_soghe.Text = String.Empty;
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            tb2_mave.Text = dataGridView_thongtinvexe.CurrentRow.Cells[0].Value.ToString();
            tb2_machuyen.Text = dataGridView_thongtinvexe.CurrentRow.Cells[1].Value.ToString();
            tb2_tuyen.Text = dataGridView_thongtinvexe.CurrentRow.Cells[2].Value.ToString();
            cbbox2_loaive.Text = dataGridView_thongtinvexe.CurrentRow.Cells[3].Value.ToString();
            tb2_nhanvienbanve.Text = dataGridView_thongtinvexe.CurrentRow.Cells[4].Value.ToString();

            tb2_tenkhachhang.Text = dataGridView_thongtinvexe.CurrentRow.Cells[6].Value.ToString();
            tb2_giave.Text = dataGridView_thongtinvexe.CurrentRow.Cells[7].Value.ToString();
            tb2_ngaykhoihanh.Text = dataGridView_thongtinvexe.CurrentRow.Cells[8].Value.ToString();

            cbbox2_soghe.DataSource = DataAdapterHandler.GetDataTableGhesConTrong(Convert.ToInt32(tb2_machuyen.Text));
            cbbox2_soghe.DisplayMember = "SoGhe";
            cbbox2_soghe.Text = dataGridView_thongtinvexe.CurrentRow.Cells[5].Value.ToString();
            ControlHandler.SetEnabled(true, btn_sua, btn_xoa);

            ControlHandler.SetEnabled(false, tb2_tenkhachhang, btn_toPickChuyen, cbbox2_loaive, cbbox2_soghe, btn_luu, btn_huy);
            ControlHandler.SetEnabled(true, btn_them, btn_xoa, dataGridView_thongtinvexe);
            previousActionButton = null;
        }
        private void btn_inve_Click(object sender, EventArgs e)
        {
            string MaVe = tb2_mave.Text;
            string MaChuyen = tb2_machuyen.Text;
            string Tuyen = tb2_tuyen.Text;
            string LoaiVe = cbbox2_loaive.Text;
            string TenKhachHang = tb2_tenkhachhang.Text;
            string GiaVe = tb2_giave.Text;
            string NgayKhoiHanh = tb2_ngaykhoihanh.Text;
            string SoGhe = cbbox2_soghe.Text;
            string NhanVienBan = tb2_nhanvienbanve.Text;
            Report report = new Report(MaVe, MaChuyen, Tuyen, LoaiVe, SoGhe, TenKhachHang, GiaVe, NgayKhoiHanh, NhanVienBan);
            report.ShowDialog();
            dt = DataAdapterHandler.GetDataTableVeXes();
            dataGridView_thongtinvexe.DataSource = dt;
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLNhanVien qLNhanVien = new QLNhanVien();
            qLNhanVien.ShowDialog();
            dt = DataAdapterHandler.GetDataTableVeXes();
            dataGridView_thongtinvexe.DataSource = dt;
        }

        private void quảnLýChuyếnXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLChuyen qlChuyenXe = new QLChuyen();
            qlChuyenXe.ShowDialog();
            dt = DataAdapterHandler.GetDataTableVeXes();
            dataGridView_thongtinvexe.DataSource = dt;
        }

        private void quảnLýXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLXe qLXe = new QLXe();
            qLXe.ShowDialog();
            dt = DataAdapterHandler.GetDataTableVeXes();
            dataGridView_thongtinvexe.DataSource = dt;
        }

        private void quảnLýTuyếnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLTuyen qLTuyen = new QLTuyen();
            qLTuyen.ShowDialog();
            dt = DataAdapterHandler.GetDataTableVeXes();
            dataGridView_thongtinvexe.DataSource = dt;
        }

        private void quảnLýTàiXếToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLTaiXe qLTaiXe = new QLTaiXe();
            qLTaiXe.ShowDialog();
            dt = DataAdapterHandler.GetDataTableVeXes();
            dataGridView_thongtinvexe.DataSource = dt;
        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
