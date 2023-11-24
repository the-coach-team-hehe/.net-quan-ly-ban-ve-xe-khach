using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coach_Ticket_Management.Models
{
    public static class CurrentUser
    {
        private static int _maNhanVien;
        private static int _maChucVu;
        private static string _tenDangNhap;
        private static string _matKhau;
        private static string _tenNhanVien;
        private static string _CCCD;
        private static string _soDienThoai;
        private static string _diaChi;

        private static Role _role;

        public static int MaNhanVien { get { return _maNhanVien; } }
        public static int MaChucVu { get { return _maChucVu; } }
        public static string TenDangNhap { get { return _tenDangNhap; } }
        public static string MatKhau { get { return _matKhau; } }
        public static string TenNhanVien { get { return _tenNhanVien; } }
        public static string CCCD { get { return _CCCD; } }
        public static string SoDienThoai { get { return _soDienThoai; } }
        public static string DiaChi { get { return _diaChi; }  }
        public static Role Role { get { return _role; } }

        public static void SetUser(int maNhanVien, int maChucVu, string tenDangNhap, string matKhau, string tenNhanVien, string iCCCD, string soDienThoai, string diaChi)
        {
            _maNhanVien = maNhanVien;
            _maChucVu = maChucVu;
            _tenDangNhap = tenDangNhap;
            _matKhau = matKhau;
            _tenNhanVien = tenNhanVien;
            _CCCD = iCCCD;
            _soDienThoai = soDienThoai;
            _diaChi = diaChi;

            if (_maChucVu == 1)
                _role = Role.Admin;
            else if (_maChucVu == 2)
                _role = Role.Manager;
            else
                _role = Role.Employee;
        }
    }
}
