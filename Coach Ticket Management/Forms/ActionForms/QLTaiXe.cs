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
    public partial class QLTaiXe : BaseForm
    {
        public QLTaiXe()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void QLTaiXe_Load(object sender, EventArgs e)
        {
            dataGridView_thongtintaixe.AllowUserToAddRows = false;
            dataGridView_thongtintaixe.AllowUserToDeleteRows = false;
            dataGridView_thongtintaixe.AllowUserToResizeColumns = false;
            dataGridView_thongtintaixe.AllowUserToResizeRows = false;
            dataGridView_thongtintaixe.RowHeadersVisible = false;
            dataGridView_thongtintaixe.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView_thongtintaixe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView_thongtintaixe.BackgroundColor = DefaultBackColor;
        }
    }
}
