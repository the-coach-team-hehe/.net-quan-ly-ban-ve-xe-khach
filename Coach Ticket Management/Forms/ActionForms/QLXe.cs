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
    public partial class QLXe : BaseForm
    {
        DataTable dt = DataAdapterHandler.GetDataTableThongTinXes();
        Button prev;

        public QLXe()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void QLXe_Load(object sender, EventArgs e)
        {
            dataGridView_thongtinxe.AllowUserToAddRows = false;
            dataGridView_thongtinxe.AllowUserToDeleteRows = false;
            dataGridView_thongtinxe.AllowUserToResizeColumns = false;
            dataGridView_thongtinxe.AllowUserToResizeRows = false;
            dataGridView_thongtinxe.RowHeadersVisible = false;
            dataGridView_thongtinxe.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView_thongtinxe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_thongtinxe.BackgroundColor = DefaultBackColor;

            cbbox_loaixe.DataSource = DataAdapterHandler.GetDataTableXes();
            cbbox_loaixe.DisplayMember = "TenLoaiXe";
            cbbox_loaixe.ValueMember = "MaLoaiXe";


            cbbox2_loaixe.DataSource = DataAdapterHandler.GetDataTableXes();
            cbbox2_loaixe.DisplayMember = "TenLoaiXe";
            cbbox_loaixe.ValueMember = "MaLoaiXe";

            dataGridView_thongtinxe.DataSource = dt;
            dataGridView_thongtinxe.CellClick += DataGridView_thongtinxe_CellClick;
            FirstTimeSetEnabled();
        }

        private void DataGridView_thongtinxe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SetThis();
            }
        }

        private void SetThis()
        {
            DataGridViewRow r = dataGridView_thongtinxe.CurrentRow;
            tb2_maxe.Text = r.Cells[0].Value.ToString();
            cbbox2_loaixe.Text = r.Cells[1].Value.ToString();
            tb2_mausac.Text = r.Cells[2].Value.ToString();
            tb2_bienso.Text = r.Cells[3].Value.ToString();
            tb2_sochongoi.Text = r.Cells[4].Value.ToString();
            ControlHandler.SetEnabled(true, btn_sua, btn_xoa);
        }

        private void Reload()
        {
            DataTable dt = DataAdapterHandler.GetDataTableThongTinXes();
            dataGridView_thongtinxe.DataSource = dt;
        }

        private void FirstTimeSetEnabled()
        {
            ControlHandler.SetEnabled(true, dataGridView_thongtinxe, btn_them);
            ControlHandler.SetEnabled(false, tb2_maxe, tb2_bienso, tb2_sochongoi, 
                cbbox2_loaixe, tb2_mausac, btn_sua, btn_xoa, btn_luu, btn_huy);
        }
        
        private void btn_them_Click(object sender, EventArgs e)
        {
            prev = btn_them;
            ControlHandler.SetEnabled(false, btn_them, btn_sua, btn_xoa,
                dataGridView_thongtinxe);
            ControlHandler.SetEnabled(true, btn_luu, btn_huy, tb2_sochongoi, tb2_bienso, tb2_mausac, cbbox2_loaixe);
            ControlHandler.SetText(string.Empty, tb2_bienso, tb2_maxe, tb2_sochongoi, cbbox2_loaixe, tb2_mausac);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn xóa xe này không? Mọi chuyến xe liên quan sẽ không có mã xe!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                try
                {
                    MessageBox.Show(DataAdapterHandler.DeleteXe(Convert.ToInt32(tb2_maxe.Text)));
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
                dataGridView_thongtinxe);
            ControlHandler.SetEnabled(true, btn_luu, btn_huy, tb2_bienso, tb2_mausac);
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (prev == btn_them)
            {
                try
                {
                    int MaLoaiXe = Convert.ToInt32(cbbox2_loaixe.SelectedValue);
                    string MauSac = tb2_mausac.Text;
                    string BienSo = tb2_bienso.Text;
                    int SoChoNgoi = Convert.ToInt32(tb2_sochongoi.Text);
                    MessageBox.Show(DataAdapterHandler.InsertXe(MaLoaiXe, MauSac, BienSo, SoChoNgoi));
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
                    int MaXe = Convert.ToInt32(tb2_maxe.Text);
                    string MauSac = tb2_mausac.Text;
                    string BienSo = tb2_bienso.Text;
                    MessageBox.Show(DataAdapterHandler.UpdateXe(MaXe, MauSac, BienSo));
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
