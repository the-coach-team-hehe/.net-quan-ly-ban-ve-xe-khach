using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using Coach_Ticket_Management.Forms.ActionForms;

namespace Coach_Ticket_Management
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //#region DELETE THIS REGION WHEN RELEASH AND CHANGE THE CONNECTION STRING ALSO
            //string prevpath1 = Directory.GetParent(Assembly.GetExecutingAssembly().Location).FullName;
            //string prevpath2 = Directory.GetParent(prevpath1).FullName;
            //string path = Directory.GetParent(prevpath2).FullName + "\\DB_QLBVXK_Prim.mdf";

            //string name = "Coach_Ticket_Management.Properties.Settings.DB_QLBVXK_PrimConnectionString";

            //var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //configFile.ConnectionStrings.ConnectionStrings[name].ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + path + ";Integrated Security=True;Connect Timeout=30";
            //configFile.ConnectionStrings.ConnectionStrings[name].ProviderName = "System.Data.SqlClient";
            //configFile.Save(ConfigurationSaveMode.Modified);

            //#endregion DELETE THIS REGION WHEN RELEASH AND CHANGE THE CONNECTION STRING ALSO

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
