using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coach_Ticket_Management.Models
{
    public static class SqlHandler
    {
        private static SqlConnection _connection;

        public static SqlConnection Connection { get => _connection; }

        public static void SetConnection(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
        }
    }
}
