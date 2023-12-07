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
    // 
    public partial class QLTaiXe : BaseForm
    {
        Button prev;
        DataTable dt = DataAdapterHandler.GetDataTableThongTinTaiXes();

        public QLTaiXe()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void QLTaiXe_Load(object sender, EventArgs e)
        {
            dataGridView_thongtintaixe.AllowUserToAddRows = false;
            dataGridView_thongtintaixe.AllowUserToDeleteRows = false;
            dataGridView_thongtintaixe.AllowUserToResizeColumns = false;
            dataGridView_thongtintaixe.AllowUserToResizeRows = false;
            dataGridView_thongtintaixe.RowHeadersVisible = false;
            dataGridView_thongtintaixe.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView_thongtintaixe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_thongtintaixe.BackgroundColor = DefaultBackColor;

            dataGridView_thongtintaixe.DataSource = dt;
            dataGridView_thongtintaixe.CellClick += DataGridView_thongtintaixe_CellClick;

            FirstTimeSetEnabled();
            btn_timkiem.Click += btn_timkiem_Click;
            btn_showall.Click += btn_showall_Click;
        }

        private void DataGridView_thongtintaixe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SetThis();
            }
        }

        private void SetThis()
        {
            DataGridViewRow r = dataGridView_thongtintaixe.CurrentRow;
            tb2_mataixe.Text = r.Cells[0].Value.ToString();
            tb2_hotentaixe.Text = r.Cells[1].Value.ToString();
            dtpicker_ngaysinh.Value = (DateTime)r.Cells[2].Value;
            tb2_sodienthoai.Text = r.Cells[3].Value.ToString();
            tb2_cccd.Text = r.Cells[4].Value.ToString();
            tb2_diachi.Text = r.Cells[5].Value.ToString();
            ControlHandler.SetEnabled(true, btn_sua, btn_xoa);
        }
        private void Reload()
        {
            dt = DataAdapterHandler.GetDataTableThongTinTaiXes();
            dataGridView_thongtintaixe.DataSource = dt;
        }

        private void FirstTimeSetEnabled()
        {
            ControlHandler.SetEnabled(true, dataGridView_thongtintaixe, btn_them);
            ControlHandler.SetEnabled(false, tb2_cccd, tb2_diachi, tb2_hotentaixe,
                tb2_mataixe, tb2_sodienthoai, btn_sua, btn_xoa, btn_luu, btn_huy, dtpicker_ngaysinh);
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            prev = btn_them;
            ControlHandler.SetEnabled(false, btn_them, btn_sua, btn_xoa,
                dataGridView_thongtintaixe);
            ControlHandler.SetEnabled(true, btn_luu, btn_huy, tb2_sodienthoai, tb2_hotentaixe, tb2_diachi, tb2_cccd, dtpicker_ngaysinh);
            ControlHandler.SetText(string.Empty, tb2_sodienthoai, tb2_hotentaixe, tb2_diachi, tb2_cccd, tb2_mataixe);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn xóa xe này không? Mọi chuyến xe liên quan sẽ không có mã xe!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                try
                {
                    MessageBox.Show(DataAdapterHandler.DeleteTaiXe(Convert.ToInt32(tb2_mataixe.Text)));
                }
                catch
                {
                    MessageBox.Show("Có lỗi không xác định!");
                }
            }
            Reload();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            prev = btn_sua;
            ControlHandler.SetEnabled(false, btn_them, btn_sua, btn_xoa,
                dataGridView_thongtintaixe);
            ControlHandler.SetEnabled(true, btn_luu, btn_huy, tb2_sodienthoai, tb2_hotentaixe, tb2_diachi, tb2_cccd, dtpicker_ngaysinh);
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (prev == btn_them)
            {
                try
                {
                    string TenTaiXe = tb2_hotentaixe.Text;
                    DateTime NgaySinh = dtpicker_ngaysinh.Value;
                    string CCCD = tb2_cccd.Text;
                    string SoDienThoai = tb2_sodienthoai.Text;
                    string DiaChi = tb2_diachi.Text;
                    MessageBox.Show(DataAdapterHandler.InsertTaiXe(TenTaiXe, NgaySinh, SoDienThoai, CCCD, DiaChi));
                }
                catch
                {
                    MessageBox.Show("Có lỗi nhập liệu!");
                }
            }
            if (prev == btn_sua)
            {
                try
                {
                    int MaTaiXe = Convert.ToInt32(tb2_mataixe.Text);
                    string TenTaiXe = tb2_hotentaixe.Text;
                    DateTime NgaySinh = dtpicker_ngaysinh.Value;
                    string CCCD = tb2_cccd.Text;
                    string SoDienThoai = tb2_sodienthoai.Text;
                    string DiaChi = tb2_diachi.Text;
                    MessageBox.Show(DataAdapterHandler.UpdateTaiXe(TenTaiXe, NgaySinh, SoDienThoai, CCCD, DiaChi, MaTaiXe));
                }
                catch
                {
                    MessageBox.Show("Có lỗi nhập liệu!");
                }
            }
            prev = null;
            FirstTimeSetEnabled();
            Reload();
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            SetThis();
            FirstTimeSetEnabled();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {

        }

        private void btn_showall_Click(object sender, EventArgs e)
        {
            Reload();
        }
    }
}
