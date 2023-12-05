using Coach_Ticket_Management.Forms.BaseForms;
using Coach_Ticket_Management.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coach_Ticket_Management.Forms.ActionForms
{
    public partial class QLChuyen : BaseForm
    {
        DataTable dt = DataAdapterHandler.GetDataTableThongTinChuyenXes1();

        Button previousBtn;
        public QLChuyen()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void QLChuyen_Load(object sender, EventArgs e)
        {
            FirstTimeSetEnabled();

            dataGridView_thongtinchuyenxe.AllowUserToAddRows = false;
            dataGridView_thongtinchuyenxe.AllowUserToDeleteRows = false;
            dataGridView_thongtinchuyenxe.AllowUserToResizeColumns = false;
            dataGridView_thongtinchuyenxe.AllowUserToResizeRows = false;
            dataGridView_thongtinchuyenxe.RowHeadersVisible = false;
            dataGridView_thongtinchuyenxe.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView_thongtinchuyenxe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_thongtinchuyenxe.BackgroundColor = DefaultBackColor;

            cbbox_tuyen.DataSource = DataAdapterHandler.GetDataTableTuyens();
            cbbox_tuyen.DisplayMember = "TenTuyen";

            cbbox2_tuyen.DataSource = DataAdapterHandler.GetDataTableTuyens();
            cbbox2_tuyen.DisplayMember = "TenTuyen";
            cbbox2_tuyen.ValueMember = "MaTuyen";

            cbbox2_taixe.DataSource = DataAdapterHandler.GetDataTableTaiXes();
            cbbox2_taixe.DisplayMember = "TenTaiXe";
            cbbox2_taixe.ValueMember = "MaTaiXe";

            cbbox2_xe.DataSource = DataAdapterHandler.GetDataTableXes();
            cbbox2_xe.DisplayMember = "MaXe";
            cbbox2_xe.ValueMember = "MaXe";

            this.dataGridView_thongtinchuyenxe.DataSource = dt;
            this.dataGridView_thongtinchuyenxe.CellClick += DataGridView_thongtinchuyenxe_CellClick;
        }

        private void DataGridView_thongtinchuyenxe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dataGridView_thongtinchuyenxe.CurrentRow;
                tb2_machuyenxe.Text = r.Cells[0].Value.ToString();
                cbbox2_tuyen.Text = r.Cells[1].Value.ToString();
                cbbox2_taixe.Text = r.Cells[2].Value.ToString();
                cbbox2_xe.Text = r.Cells[3].Value.ToString();
                dtpicker2_thoigiankhoihanh.Value = (DateTime)r.Cells[4].Value;
                tb2_soghedadat.Text = r.Cells[5].Value.ToString();

                ControlHandler.SetEnabled(true, btn_xoa, btn_sua);
            }
        }

        private void FirstTimeSetEnabled()
        {
            ControlHandler.SetEnabled(false, btn_sua, btn_xoa, btn_luu, btn_huy,
                tb2_machuyenxe, cbbox2_xe, cbbox2_taixe, tb2_soghedadat, dtpicker2_thoigiankhoihanh);
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            previousBtn = btn_them;
            ControlHandler.SetEnabled(true, cbbox2_taixe, cbbox2_xe, tb2_soghedadat, dtpicker2_thoigiankhoihanh, btn_luu, btn_huy);
            ControlHandler.SetEnabled(false, btn_sua, btn_them, btn_xoa, dataGridView_thongtinchuyenxe);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            previousBtn = btn_xoa;
            DialogResult r = MessageBox.Show("Bạn có muốn xóa chuyến xe này?", "Thông báo", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                try
                {
                    MessageBox.Show(DataAdapterHandler.DeleteChuyenXe(Convert.ToInt32(tb2_machuyenxe.Text)));
                }
                catch
                {
                    MessageBox.Show("Có lỗi xảy ra!");
                }
            }
            dt = DataAdapterHandler.GetDataTableThongTinChuyenXes();
            dataGridView_thongtinchuyenxe.DataSource = dt;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            previousBtn = btn_sua;
            ControlHandler.SetEnabled(true, cbbox2_taixe, cbbox2_tuyen, cbbox2_xe, dtpicker2_thoigiankhoihanh, btn_luu, btn_huy);
            ControlHandler.SetEnabled(false, btn_sua, btn_them, btn_xoa, dataGridView_thongtinchuyenxe);
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (previousBtn == btn_them)
            {
                try
                {
                    int MaXe = Convert.ToInt32(cbbox2_xe.SelectedValue);
                    int MaTuyen = Convert.ToInt32(cbbox2_tuyen.SelectedValue);
                    int MaTaiXe = Convert.ToInt32(cbbox2_taixe.SelectedValue);
                    DateTime dt = dtpicker2_thoigiankhoihanh.Value;
                    MessageBox.Show(DataAdapterHandler.InsertChuyenXe(MaXe, MaTuyen, MaTaiXe, dt));
                }
                catch
                {
                    MessageBox.Show("Có lỗi xảy ra!");
                }
            }
            if (previousBtn == btn_sua)
            {
                try
                {
                    int MaChuyenXe = Convert.ToInt32(tb2_machuyenxe.Text);
                    int MaXe = Convert.ToInt32(cbbox2_xe.Text);
                    int MaTuyen = Convert.ToInt32(cbbox2_tuyen.SelectedValue);
                    int MaTaiXe = Convert.ToInt32(cbbox2_taixe.SelectedValue);
                    DateTime dt = dtpicker2_thoigiankhoihanh.Value;
                    MessageBox.Show(DataAdapterHandler.UpdateChuyenXe(MaChuyenXe, MaXe, MaTaiXe, MaTuyen, dt));
                }
                catch
                {
                    MessageBox.Show("Có lỗi xảy ra!");
                }
            }
            ControlHandler.SetEnabled(false, btn_sua, btn_xoa, btn_luu, btn_huy,
                tb2_machuyenxe, cbbox2_xe, cbbox2_taixe, dtpicker2_thoigiankhoihanh);

            DataGridViewRow r = dataGridView_thongtinchuyenxe.CurrentRow;
            tb2_machuyenxe.Text = r.Cells[0].Value.ToString();
            cbbox2_tuyen.Text = r.Cells[1].Value.ToString();
            cbbox2_taixe.Text = r.Cells[2].Value.ToString();
            cbbox2_xe.Text = r.Cells[3].Value.ToString();
            dtpicker2_thoigiankhoihanh.Value = (DateTime)r.Cells[4].Value;
            tb2_soghedadat.Text = r.Cells[5].Value.ToString();

            ControlHandler.SetEnabled(true, btn_them, btn_xoa, btn_sua, dataGridView_thongtinchuyenxe);

            dt = DataAdapterHandler.GetDataTableThongTinChuyenXes1();
            dataGridView_thongtinchuyenxe.DataSource = dt;

            previousBtn = null;
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            ControlHandler.SetEnabled(false, btn_sua, btn_xoa, btn_luu, btn_huy,
                tb2_machuyenxe, cbbox2_xe, cbbox2_taixe, dtpicker2_thoigiankhoihanh);
            DataGridViewRow r = dataGridView_thongtinchuyenxe.CurrentRow;
            tb2_machuyenxe.Text = r.Cells[0].Value.ToString();
            cbbox2_tuyen.Text = r.Cells[1].Value.ToString();
            cbbox2_taixe.Text = r.Cells[2].Value.ToString();
            dtpicker2_thoigiankhoihanh.Value = (DateTime)r.Cells[3].Value;
            tb2_soghedadat.Text = r.Cells[3].Value.ToString();

            ControlHandler.SetEnabled(true, btn_xoa, btn_sua, dataGridView_thongtinchuyenxe);
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            // nothing here
        }

        private void btn_showall_Click(object sender, EventArgs e)
        {
            dt = DataAdapterHandler.GetDataTableThongTinChuyenXes1();
        }
    }
}
