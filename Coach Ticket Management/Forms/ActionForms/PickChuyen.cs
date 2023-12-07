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
    // Done
    public partial class PickChuyen : BaseForm
    {
        string _maChuyen = string.Empty;
        string _tenTuyen = string.Empty;
        string _thoiGianKhoiHanh = string.Empty;
        DataTable dt = DataAdapterHandler.GetDataTableThongTinChuyenXes();
        public PickChuyen(string MaChuyen, string TenTuyen)
        {
            InitializeComponent();
            this.Load += PickChuyen_Load;
            _maChuyen = MaChuyen;
            _tenTuyen = TenTuyen;
        }
        public PickChuyen()
        {
            InitializeComponent();
            this.Load += PickChuyen_Load;
        }

        private void PickChuyen_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            dataGridView_thongtinchuyen.DataSource = dt;
            dataGridView_thongtinchuyen.AllowUserToAddRows = false;
            dataGridView_thongtinchuyen.AllowUserToDeleteRows = false;
            dataGridView_thongtinchuyen.AllowUserToResizeColumns = false;
            dataGridView_thongtinchuyen.AllowUserToResizeRows = false;
            dataGridView_thongtinchuyen.RowHeadersVisible = false;
            dataGridView_thongtinchuyen.BackgroundColor = DefaultBackColor;
            dataGridView_thongtinchuyen.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView_thongtinchuyen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_thongtinchuyen.CellClick += DataGridView_thongtinchuyen_CellClick;

            cbbox_tuyen.DataSource = DataAdapterHandler.GetDataTableTuyens();
            cbbox_tuyen.DisplayMember = "TenTuyen";
            try
            {
                _maChuyen = dataGridView_thongtinchuyen.CurrentRow.Cells[0].Value.ToString();
                _tenTuyen = dataGridView_thongtinchuyen.CurrentRow.Cells[1].Value.ToString();
                _thoiGianKhoiHanh = dataGridView_thongtinchuyen.CurrentRow.Cells[3].Value.ToString();
            }
            catch
            {

            }
            
        }

        private void DataGridView_thongtinchuyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _maChuyen = dataGridView_thongtinchuyen.CurrentRow.Cells[0].Value.ToString();
                _tenTuyen = dataGridView_thongtinchuyen.CurrentRow.Cells[1].Value.ToString();
                _thoiGianKhoiHanh = dataGridView_thongtinchuyen.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            bool isHavePrev = false;
            string filter = string.Empty;
            if (cbbox_tuyen.Text != string.Empty)
            {
                filter += string.Format("([Tuyến] LIKE '%{0}%')", cbbox_tuyen.Text);
                isHavePrev = true;
            }
            if (dtpicker_ngaykhoihanh.Value != null)
            {
                string date = dtpicker_ngaykhoihanh.Value.ToString("dd/MM/yyyy");
                if (isHavePrev)
                    filter += " AND ";
                filter += string.Format("(CONVERT([Thời gian khởi hành], System.String) LIKE '%{0}%')", date);
            }
            dt.DefaultView.RowFilter = filter;
        }

        private void btn_chon_Click(object sender, EventArgs e)
        {
            if (dataGridView_thongtinchuyen.CurrentRow.Index >= 0 && dataGridView_thongtinchuyen.CurrentRow.Index < dataGridView_thongtinchuyen.Rows.Count)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn chuyến!");
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string GetMaChuyen()
        {
            return _maChuyen;
        }

        public string GetTenTuyen()
        {
            return _tenTuyen;
        }

        public string GetThoiGianKhoiHanh()
        {
            return _thoiGianKhoiHanh;
        }
    }
}
