using Coach_Ticket_Management.Forms.BaseForms;
using Coach_Ticket_Management.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Coach_Ticket_Management.Forms.MainForms
{
    public partial class MainForm : BaseForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RoleAssignment();
        }

        private void RoleAssignment()
        {
            Role role = CurrentUser.Role;
            if (role == Role.Employee)
                quảnLýNhânViênToolStripMenuItem.Enabled = quảnLýNhânViênToolStripMenuItem.Visible = false;
        }
    }
}
