using Coach_Ticket_Management.Forms.BaseForms;
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
    public partial class QLChuyen : BaseForm
    {
        public QLChuyen()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void QLChuyen_Load(object sender, EventArgs e)
        {
            dataGridView_thongtinchuyenxe.AllowUserToAddRows = false;
            dataGridView_thongtinchuyenxe.AllowUserToDeleteRows = false;
            dataGridView_thongtinchuyenxe.AllowUserToResizeColumns = false;
            dataGridView_thongtinchuyenxe.AllowUserToResizeRows = false;
            dataGridView_thongtinchuyenxe.RowHeadersVisible = false;
            dataGridView_thongtinchuyenxe   .EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView_thongtinchuyenxe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView_thongtinchuyenxe.BackgroundColor = DefaultBackColor;
        }

        private void dataGridView_thongtinvexe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
