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
    // Done ... Searching
    public partial class QLTuyen : BaseForm
    {
        DataTable dt = DataAdapterHandler.GetDataTableThongTinTuyens();
        Button prev;

        public QLTuyen()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void QLTuyen_Load(object sender, EventArgs e)
        {
            dataGridView_thongtintuyenxe.AllowUserToAddRows = false;
            dataGridView_thongtintuyenxe.AllowUserToDeleteRows = false;
            dataGridView_thongtintuyenxe.AllowUserToResizeColumns = false;
            dataGridView_thongtintuyenxe.AllowUserToResizeRows = false;
            dataGridView_thongtintuyenxe.RowHeadersVisible = false;
            dataGridView_thongtintuyenxe.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView_thongtintuyenxe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_thongtintuyenxe.BackgroundColor = DefaultBackColor;

            cbbox_ddkhoihanh.DataSource = DataAdapterHandler.GetDataTableDiaDiems();
            cbbox_ddkhoihanh.DisplayMember = "TenDiaDiem";

            cbbox_ddketthuc.DataSource = DataAdapterHandler.GetDataTableDiaDiems();
            cbbox_ddketthuc.DisplayMember = "TenDiaDiem";

            cbbox2_ddkhoihanh.DataSource = DataAdapterHandler.GetDataTableDiaDiems();
            cbbox2_ddkhoihanh.DisplayMember = "TenDiaDiem";
            cbbox2_ddkhoihanh.ValueMember = "MaDiaDiem";

            cbbox2_ddketthuc.DataSource = DataAdapterHandler.GetDataTableDiaDiems();
            cbbox2_ddketthuc.DisplayMember = "TenDiaDiem";
            cbbox2_ddketthuc.ValueMember = "MaDiaDiem";

            cbbox2_ddketthuc.Text = cbbox2_ddkhoihanh.Text = string.Empty;

            dataGridView_thongtintuyenxe.DataSource = dt;
            dataGridView_thongtintuyenxe.CellClick += DataGridView_thongtintuyen_CellClick;

            FirstTimeSetEnabled();
            btn_them.Click += btn_them_Click;
            btn_xoa.Click += btn_xoa_Click;
            btn_sua.Click += btn_sua_Click;
            btn_huy.Click += btn_huy_Click;
            btn_luu.Click += btn_luu_Click;
            btn_timkiem.Click += btn_timkiem_Click;
            btn_showall.Click += btn_showall_Click;
        }

        private void DataGridView_thongtintuyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SetThis();
            }
        }

        private void SetThis()
        {
            DataGridViewRow r = dataGridView_thongtintuyenxe.CurrentRow;
            tb2_matuyen.Text = r.Cells[0].Value.ToString();
            tb2_tentuyen.Text = r.Cells[1].Value.ToString();
            cbbox2_ddkhoihanh.Text = r.Cells[2].Value.ToString();
            cbbox2_ddketthuc.Text = r.Cells[3].Value.ToString();
            tb2_giatuyen.Text = r.Cells[4].Value.ToString();
            ControlHandler.SetEnabled(true, btn_sua, btn_xoa);
        }

        private void Reload()
        {
            DataTable dt = DataAdapterHandler.GetDataTableThongTinTuyens();
            dataGridView_thongtintuyenxe.DataSource = dt;
        }

        private void FirstTimeSetEnabled()
        {
            ControlHandler.SetEnabled(true, dataGridView_thongtintuyenxe, btn_them);
            ControlHandler.SetEnabled(false, tb2_matuyen, tb2_tentuyen, tb2_giatuyen,
                cbbox2_ddketthuc, cbbox2_ddkhoihanh, btn_sua, btn_xoa, btn_luu, btn_huy);
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            prev = btn_them;
            ControlHandler.SetEnabled(false, btn_them, btn_sua, btn_xoa,
                dataGridView_thongtintuyenxe);
            ControlHandler.SetEnabled(true, btn_luu, btn_huy, cbbox2_ddkhoihanh, cbbox2_ddketthuc, tb2_giatuyen, tb2_tentuyen);
            ControlHandler.SetText(string.Empty, cbbox2_ddkhoihanh, cbbox2_ddketthuc, tb2_giatuyen, tb2_matuyen, tb2_tentuyen);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn xóa xe này không? Mọi chuyến xe liên quan sẽ không có mã xe!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                try
                {
                    int MaTuyen = Convert.ToInt32(tb2_matuyen.Text);
                    MessageBox.Show(DataAdapterHandler.DeleteTuyen(MaTuyen));
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
                dataGridView_thongtintuyenxe);
            ControlHandler.SetEnabled(true, btn_luu, btn_huy, cbbox2_ddkhoihanh, cbbox2_ddketthuc, tb2_giatuyen, tb2_tentuyen);
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (prev == btn_them)
            {
                try
                {
                    string TenTuyen = tb2_tentuyen.Text;
                    int MaDDKhoiHanh = Convert.ToInt32(cbbox2_ddkhoihanh.SelectedValue);
                    int MaDDKetThuc = Convert.ToInt32(cbbox2_ddketthuc.SelectedValue);
                    decimal GiaTuyen = Convert.ToDecimal(tb2_giatuyen.Text);
                    MessageBox.Show(DataAdapterHandler.InsertTuyen(TenTuyen, MaDDKhoiHanh, MaDDKetThuc, GiaTuyen));
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
                    int MaTuyen = Convert.ToInt32(tb2_matuyen.Text);
                    string TenTuyen = tb2_tentuyen.Text;
                    int MaDDKhoiHanh = Convert.ToInt32(cbbox2_ddkhoihanh.SelectedValue);
                    int MaDDKetThuc = Convert.ToInt32(cbbox2_ddketthuc.SelectedValue);
                    decimal GiaTuyen = Convert.ToDecimal(tb2_giatuyen.Text);
                    MessageBox.Show(DataAdapterHandler.UpdateTuyen(TenTuyen, MaDDKhoiHanh, MaDDKetThuc, GiaTuyen, MaTuyen));
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
