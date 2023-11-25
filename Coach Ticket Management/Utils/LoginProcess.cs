using Coach_Ticket_Management.Database.QLBVXKTableAdapters;
using Coach_Ticket_Management.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coach_Ticket_Management.Utils
{
    public static class LoginProcess
    {
        public enum LoginStatus : byte
        {
            Successful,
            Failed,
            Disabled
        }

        public static LoginStatus Process(string username, string password)
        {
            NhanVienTableAdapter adapter = new NhanVienTableAdapter();
            DataTable dt = new DataTable();
            dt = adapter.GetDataByTenDangNhapMatKhau(username, password);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                CurrentUser.SetUser(Convert.ToInt32(row[0]), Convert.ToInt32(row[1]), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString());
                return LoginStatus.Successful;
            }
            else
            {
                return LoginStatus.Failed;
            }
        }
    }
}
