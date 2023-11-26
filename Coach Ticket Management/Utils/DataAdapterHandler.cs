using Coach_Ticket_Management.Database;
using Coach_Ticket_Management.Database.QLBVXKTableAdapters;
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

        public static string InsertVeXe()
        {
            try
            {
                VeXeTableAdapter adapter = new VeXeTableAdapter();
                adapter.Insert(1, 1, 1, 1, "Nguyễn Minh Đức", 0);
                return "Đặt vé thành công!";
            }
            catch (SqlException e)
            {
                return ErrorMessage.GetErrorMessage(e);
            }
        }

        public static string XoaVeXe()
        {
            try
            {
                return "Xóa thành công!";
            }
            catch (SqlException e)
            {
                return ErrorMessage.GetErrorMessage(e);
            }
        }
    }
}
