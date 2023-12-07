using Coach_Ticket_Management.Forms.BaseForms;
using Coach_Ticket_Management.Models;
using Coach_Ticket_Management.ReportItems;
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
    public partial class Report : BaseForm
    {
        public Report(string MaVe, string MaChuyen, string Tuyen, string LoaiVe, string SoGhe, string HoTenKhachHang, string GiaVe, string ThoiGianKhoiHanh, string NhanVienBan)
        {
            InitializeComponent();
            this.CenterToScreen();
            inVe1.SetParameterValue("Mã vé", MaVe);
            inVe1.SetParameterValue("Mã chuyến", MaChuyen);
            inVe1.SetParameterValue("Tuyến", Tuyen);
            inVe1.SetParameterValue("Loại vé", LoaiVe);
            inVe1.SetParameterValue("Số ghế", SoGhe);
            inVe1.SetParameterValue("Họ tên khách hàng", HoTenKhachHang);
            inVe1.SetParameterValue("Giá vé", GiaVe);
            inVe1.SetParameterValue("Thời gian khởi hành", ThoiGianKhoiHanh);
            inVe1.SetParameterValue("Nhân viên in", CurrentUser.TenNhanVien);
            inVe1.SetParameterValue("Nhân viên bán", NhanVienBan);
            crystalReportViewer1.Refresh();
        }
    }
}
