using Coach_Ticket_Management.Database;
using Coach_Ticket_Management.Database.QLBVXKTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coach_Ticket_Management.Utils
{
    public static class DataAdapterHandler
    {
        public static QLBVXK.DataTable1DataTable GetDataTableVeXes()
        {
            DataTable1TableAdapter adapter = new DataTable1TableAdapter();
            return adapter.GetData();
        }
    }
}
