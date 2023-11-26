using Coach_Ticket_Management.Database;
using Coach_Ticket_Management.Database.QLBVXKTableAdapters;
using Coach_Ticket_Management.Forms.ActionForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
                adapter.AltUpdate(MaChuyenXe, MaLoaiVe, MaNhanVien, TenKhachHang, SoGhe, MaVeXe);
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
    }
}
