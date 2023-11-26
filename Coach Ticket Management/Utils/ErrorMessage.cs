using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coach_Ticket_Management.Utils
{
    public static class ErrorMessage
    {
        private static bool isExist(string exceptionMessage, string ErrorCode)
        {
            if (exceptionMessage.Contains(ErrorCode))
                return true;
            return false;
        }

        public static string GetErrorMessage(SqlException exception)
        {
            string exceptionMessage = exception.Message;
            if (isExist(exceptionMessage, "TRUNGGHE"))
                return "Ghế này đã có người đặt!";
            if (isExist(exceptionMessage, "KHONGCONCHO"))
                return "Ghế này đã có người đặt!";
            return "Lỗi không xác định";
        }


    }
}
