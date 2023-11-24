using Coach_Ticket_Management.Database.QLBVXKTableAdapters;
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
            dt = adapter.GetData()
            return LoginStatus.Successful;
        }
    }
}
