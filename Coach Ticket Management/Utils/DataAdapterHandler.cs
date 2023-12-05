using Coach_Ticket_Management.Database;
using Coach_Ticket_Management.Database.QLBVXKTableAdapters;
using Coach_Ticket_Management.Forms.ActionForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coach_Ticket_Management.Utils
{
    public static class DataAdapterHandler
    {
        public static QLBVXK.ThongTinVeXeDataTable GetDataTableVeXes()
        {
            ThongTinVeXeTableAdapter adapter = new ThongTinVeXeTableAdapter();
            return adapter.GetData();
        }

        public static QLBVXK.LoaiVeDataTable GetDataTableLoaiVes()
        {
            LoaiVeTableAdapter adapter = new LoaiVeTableAdapter();
            return adapter.GetData();
        }

        public static QLBVXK.TuyenDataTable GetDataTableTuyens()
        {
            TuyenTableAdapter adapter = new TuyenTableAdapter();
            return adapter.GetData();
        }

        public static QLBVXK.GheDataTable GetDataTableGhes(int MaChuyenXe)
        {
            GheTableAdapter adapter = new GheTableAdapter();
            return adapter.GetDataByMaChuyenXe(MaChuyenXe);
        }

        public static QLBVXK.GheDataTable GetDataTableGhesConTrong(int MaChuyenXe)
        {
            GheTableAdapter adapter = new GheTableAdapter();
            return adapter.GetData_ConTrong_ByMaChuyenXe(MaChuyenXe);
        }

        public static QLBVXK.ThongTinChuyenXeDataTable GetDataTableThongTinChuyenXes()
        {
            ThongTinChuyenXeTableAdapter adapter = new ThongTinChuyenXeTableAdapter();
            return adapter.GetData();
        }

        public static QLBVXK.ThongTinChuyenXe1DataTable GetDataTableThongTinChuyenXes1()
        {
            ThongTinChuyenXe1TableAdapter adapter = new ThongTinChuyenXe1TableAdapter();
            return adapter.GetData();
        }

        public static QLBVXK.ThongTinNhanVienDataTable GetDataTableThongTinNhanViens()
        {
            ThongTinNhanVienTableAdapter adapter = new ThongTinNhanVienTableAdapter();
            return adapter.GetData();
        }

        public static QLBVXK.ChucVuDataTable GetDataTableChucVus()
        {
            ChucVuTableAdapter adapter = new ChucVuTableAdapter();
            return adapter.GetData();
        }

        public static QLBVXK.NhanVienDataTable GetMatKhauNhanVien(int MaNhanVien)
        {
            NhanVienTableAdapter adapter = new NhanVienTableAdapter();
            return adapter.GetMatKhauByMaNhanVien(MaNhanVien);
        }

        public static QLBVXK.TaiXeDataTable GetDataTableTaiXes()
        {
            TaiXeTableAdapter adapter = new TaiXeTableAdapter();
            return adapter.GetData();
        }

        public static QLBVXK.XeDataTable GetDataTableXes()
        {
            XeTableAdapter adapter = new XeTableAdapter();
            return adapter.GetData();
        }

        public static QLBVXK.ThongTinXeDataTable GetDataTableThongTinXes()
        {
            ThongTinXeTableAdapter adapter = new ThongTinXeTableAdapter();
            return adapter.GetData();
        }

        public static string InsertVeXe(int MaChuyenXe, int MaLoaiVe, int MaNhanVien, int SoGhe, string TenKhachHang)
        {
            try
            {
                VeXeTableAdapter adapter = new VeXeTableAdapter();
                adapter.Insert(MaChuyenXe, MaLoaiVe, MaNhanVien, SoGhe, TenKhachHang, 0);
                return "Đặt vé thành công!";
            }
            catch (SqlException e)
            {
                return ErrorMessage.GetErrorMessage(e);
            }
        }

        public static string UpdateVeXe(int MaVeXe, int MaChuyenXe, int MaLoaiVe, int MaNhanVien, int SoGhe, string TenKhachHang)
        {
            try
            {
                VeXeTableAdapter adapter = new VeXeTableAdapter();
                adapter.AltUpdate(MaChuyenXe, MaLoaiVe, MaNhanVien, SoGhe, TenKhachHang, MaVeXe);
                return "Cập nhật thành công!";
            }
            catch (SqlException e)
            {
                return ErrorMessage.GetErrorMessage(e);
            }
        }

        public static string XoaVeXe(int MaVeXe)
        {
            try
            {
                VeXeTableAdapter adapter = new VeXeTableAdapter();
                adapter.AltDelete(MaVeXe);
                return "Xóa thành công!";
            }
            catch (SqlException e)
            {
                return ErrorMessage.GetErrorMessage(e);
            }
        }

        public static string InsertNhanVien(int MaChucVu, string TenDangNhap, string MatKhau, string TenNhanVien, string CCCD, string DiaChi, string SoDienThoai)
        {
            try
            {
                NhanVienTableAdapter adapter = new NhanVienTableAdapter();
                adapter.Insert(MaChucVu, TenDangNhap, MatKhau, TenNhanVien, CCCD, SoDienThoai, DiaChi);
                return "Thêm thành công";
            }
            catch (SqlException e)
            {
                return ErrorMessage.GetErrorMessage(e);
            }
        }

        public static string UpdateNhanVien(int MaNhanVien, int MaChucVu, string TenDangNhap, string MatKhau, string TenNhanVien, string CCCD, string DiaChi, string SoDienThoai)
        {
            try
            {
                NhanVienTableAdapter adapter = new NhanVienTableAdapter();
                adapter.AltUpdate(MaChucVu, TenDangNhap, MatKhau, TenNhanVien, CCCD, SoDienThoai, DiaChi, MaNhanVien);
                return "Cập nhật thành công";
            }
            catch (SqlException e)
            {
                return ErrorMessage.GetErrorMessage(e);
            }
        }

        public static string DeleteNhanVien(int MaNhanVien)
        {
            try
            {
                NhanVienTableAdapter adapter = new NhanVienTableAdapter();
                adapter.AltDelete(MaNhanVien);
                return "Xóa thành công";
            }
            catch (SqlException e)
            {
                return ErrorMessage.GetErrorMessage(e);
            }
        }

        public static string InsertChuyenXe(int MaXe, int MaTuyen, int MaTaiXe, DateTime thoiGianKhoiHanh)
        {
            try
            {
                ChuyenXeTableAdapter adapter = new ChuyenXeTableAdapter();
                adapter.Insert(MaXe, MaTuyen, MaTaiXe, thoiGianKhoiHanh, 0);
                return "Thêm thành công";
            }
            catch (SqlException e)
            {
                return ErrorMessage.GetErrorMessage(e);
            }
        }

        public static string UpdateChuyenXe(int MaChuyenXe, int MaXe, int MaTaiXe, int MaTuyen, DateTime thoiGianKhoiHanh)
        {
            try
            {
                ChuyenXeTableAdapter adapter = new ChuyenXeTableAdapter();
                adapter.AltUpdate(MaTuyen, MaXe, MaTaiXe, thoiGianKhoiHanh, MaChuyenXe);
                return "Cập nhật thành công";
            }
            catch (SqlException e)
            { 
                return ErrorMessage.GetErrorMessage(e);
            }
        }

        public static string DeleteChuyenXe(int MaChuyenXe)
        {
            try
            {
                ChuyenXeTableAdapter adapter = new ChuyenXeTableAdapter();
                adapter.AltDelete(MaChuyenXe);
                return "Xóa thành công";
            }
            catch (SqlException e)
            {
                return ErrorMessage.GetErrorMessage(e);
            }
        }

        public static string InsertXe(int MaLoaiXe, string MauSac, string BienSo, int SoChoNgoi)
        {
            try
            {
                XeTableAdapter adapter = new XeTableAdapter();
                adapter.Insert(MaLoaiXe, MauSac, BienSo, SoChoNgoi);
                return "Thêm thành công!";
            }
            catch (SqlException e)
            {
                return ErrorMessage.GetErrorMessage(e);
            }
        }

        public static string UpdateXe(int MaXe, string MauSac, string BienSo)
        {
            try
            {
                XeTableAdapter adapter = new XeTableAdapter();
                adapter.UpdateQuery(MauSac, BienSo, MaXe);
                return "Cập nhật thành công!";
            }
            catch (SqlException e)
            {
                return ErrorMessage.GetErrorMessage(e);
            }
        }

        public static string DeleteXe(int MaXe)
        {
            try
            {
                ChuyenXeTableAdapter adapter0 = new ChuyenXeTableAdapter();
                adapter0.UpdateByMaXe(MaXe);
                XeTableAdapter adapter = new XeTableAdapter();
                adapter.DeleteQuery(MaXe);
                return "Xóa thành công!";
            }
            catch (SqlException e)
            {
                return ErrorMessage.GetErrorMessage(e);
            }
        }

        public static string InsertTaiXe()
        {
            try
            {
                return "";
            }
            catch (SqlException e)
            {
                return ErrorMessage.GetErrorMessage(e);
            }
        }

        public static string UpdateTaiXe()
        {
            try
            {
                return "";
            }
            catch (SqlException e)
            {
                return ErrorMessage.GetErrorMessage(e);
            }
        }

        public static string DeleteTaiXe()
        {
            try
            {
                return "";
            }
            catch (SqlException e)
            {
                return ErrorMessage.GetErrorMessage(e);
            }
        }

        public static string InsertTuyen()
        {
            try
            {
                return "";
            }
            catch (SqlException e)
            {
                return ErrorMessage.GetErrorMessage(e);
            }
        }

        public static string UpdateTuyen()
        {
            try
            {
                return "";
            }
            catch (SqlException e)
            {
                return ErrorMessage.GetErrorMessage(e);
            }
        }

        public static string DeleteTuyen()
        {
            try
            {
                return "";
            }
            catch (SqlException e)
            {
                return ErrorMessage.GetErrorMessage(e);
            }
        }
    }
}
