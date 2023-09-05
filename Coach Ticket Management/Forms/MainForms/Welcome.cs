using Coach_Ticket_Management.Forms.Actions.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coach_Ticket_Management.Forms.MainForms
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

    }
}
