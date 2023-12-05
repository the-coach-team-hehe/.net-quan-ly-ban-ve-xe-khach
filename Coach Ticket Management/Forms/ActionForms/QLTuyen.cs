using Coach_Ticket_Management.Forms.BaseForms;
using Coach_Ticket_Management.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coach_Ticket_Management.Forms.ActionForms
{
    public partial class QLTuyen : BaseForm
    {
        DataTable dt = DataAdapterHandler.GetDataTableTuyens();
        Button prev;

        public QLTuyen()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void QLTuyen_Load(object sender, EventArgs e)
        {
            dataGridView_thongtintuyenxe.AllowUserToAddRows = false;
            dataGridView_thongtintuyenxe.AllowUserToDeleteRows = false;
            dataGridView_thongtintuyenxe.AllowUserToResizeColumns = false;
            dataGridView_thongtintuyenxe.AllowUserToResizeRows = false;
            dataGridView_thongtintuyenxe.RowHeadersVisible = false;
            dataGridView_thongtintuyenxe.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView_thongtintuyenxe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_thongtintuyenxe.BackgroundColor = DefaultBackColor;

            dataGridView_thongtintuyenxe.DataSource = dt;
        }
    }
}
