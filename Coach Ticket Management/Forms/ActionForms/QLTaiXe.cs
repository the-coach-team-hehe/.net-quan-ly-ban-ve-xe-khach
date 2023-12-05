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
    public partial class QLTaiXe : BaseForm
    {
        Button prev;
        DataTable dt = DataAdapterHandler.GetDataTableTaiXes();

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
            dataGridView_thongtintaixe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_thongtintaixe.BackgroundColor = DefaultBackColor;

            dataGridView_thongtintaixe.DataSource = dt;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            prev = btn_them;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            prev = btn_xoa;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            prev = btn_sua;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (prev == btn_them)
            {

            }
            if (prev == btn_sua)
            {

            }
            prev = null;
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {

        }
    }
}
