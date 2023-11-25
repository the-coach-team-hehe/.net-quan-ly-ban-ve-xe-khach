using Coach_Ticket_Management.Forms.BaseForms;
using Coach_Ticket_Management.Models;
using Coach_Ticket_Management.Utils;
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
            dataGridView1.DataSource = DataAdapterHandler.GetDataTableVeXes();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void RoleAssignment()
        {
            Role role = CurrentUser.Role;
            if (role == Role.Employee)
                quảnLýNhânViênToolStripMenuItem.Enabled = quảnLýNhânViênToolStripMenuItem.Visible = false;
        }
    }
}
