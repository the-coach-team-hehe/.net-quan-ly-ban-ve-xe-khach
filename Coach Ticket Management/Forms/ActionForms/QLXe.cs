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
    public partial class QLXe : BaseForm
    {
        public QLXe()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void QLXe_Load(object sender, EventArgs e)
        {
            dataGridView_thongtinxe.AllowUserToAddRows = false;
            dataGridView_thongtinxe.AllowUserToDeleteRows = false;
            dataGridView_thongtinxe.AllowUserToResizeColumns = false;
            dataGridView_thongtinxe.AllowUserToResizeRows = false;
            dataGridView_thongtinxe.RowHeadersVisible = false;
            dataGridView_thongtinxe.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView_thongtinxe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView_thongtinxe.BackgroundColor = DefaultBackColor;
        }
    }
}
