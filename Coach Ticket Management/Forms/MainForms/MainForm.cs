using Coach_Ticket_Management.Forms.ActionForms;
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
        Button previousActionButton;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FirstTimeSetEnabled();
            RoleAssignment();
            dataGridView_thongtinvexe.DataSource = DataAdapterHandler.GetDataTableVeXes();
            dataGridView_thongtinvexe.AllowUserToAddRows = false;
            dataGridView_thongtinvexe.AllowUserToDeleteRows = false;
            dataGridView_thongtinvexe.AllowUserToResizeColumns = false;
            dataGridView_thongtinvexe.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView_thongtinvexe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dataGridView_thongtinvexe.CellClick += DataGridView_thongtinvexe_CellClick;
        }

        private void DataGridView_thongtinvexe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                tb2_mave.Text = dataGridView_thongtinvexe.CurrentRow.Cells[0].Value.ToString();
                tb2_machuyen.Text = dataGridView_thongtinvexe.CurrentRow.Cells[1].Value.ToString();
                tb2_tuyen.Text = dataGridView_thongtinvexe.CurrentRow.Cells[2].Value.ToString();
                cbbox2_loaive.Text = dataGridView_thongtinvexe.CurrentRow.Cells[3].Value.ToString();
                tb2_nhanvienbanve.Text = dataGridView_thongtinvexe.CurrentRow.Cells[4].Value.ToString();
                cbbox2_soghe.Text = dataGridView_thongtinvexe.CurrentRow.Cells[5].Value.ToString();
                tb2_tenkhachhang.Text = dataGridView_thongtinvexe.CurrentRow.Cells[6].Value.ToString();
                tb2_giave.Text = dataGridView_thongtinvexe.CurrentRow.Cells[7].Value.ToString();
                tb2_ngaykhoihanh.Text = dataGridView_thongtinvexe.CurrentRow.Cells[8].Value.ToString();

                ControlHandler.SetEnabled(true, btn_sua, btn_xoa);
            }
        }

        private void RoleAssignment()
        {
            Role role = CurrentUser.Role;
            if (role == Role.Employee)
                quảnLýNhânViênToolStripMenuItem.Enabled = quảnLýNhânViênToolStripMenuItem.Visible = false;
        }

        private void FirstTimeSetEnabled()
        {
            ControlHandler.SetEnabled(false, tb2_mave, tb2_machuyen, tb2_giave, tb2_ngaykhoihanh,
                tb2_nhanvienbanve, tb2_tuyen, tb2_tenkhachhang, btn_toPickChuyen, cbbox2_loaive,
                cbbox2_soghe, btn_sua, btn_xoa, btn_luu);
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            ControlHandler.SetEnabled(true, tb2_tenkhachhang, btn_toPickChuyen, cbbox2_loaive, cbbox2_soghe, btn_luu);
            ControlHandler.SetEnabled(false, btn_them, btn_xoa, btn_sua, dataGridView_thongtinvexe);
            previousActionButton = btn_them;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            previousActionButton = btn_xoa;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            ControlHandler.SetEnabled(true, tb2_tenkhachhang, btn_toPickChuyen, cbbox2_loaive, cbbox2_soghe, btn_luu);
            ControlHandler.SetEnabled(false, btn_them, btn_xoa, btn_sua, dataGridView_thongtinvexe);
            previousActionButton = btn_sua;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (previousActionButton == btn_sua)
            {
                // do something
            }
            if (previousActionButton == btn_them)
            {
                // do something
            }
            ControlHandler.SetEnabled(false, tb2_tenkhachhang, btn_toPickChuyen, cbbox2_loaive, cbbox2_soghe, btn_luu);
            ControlHandler.SetEnabled(true, btn_them, btn_xoa, dataGridView_thongtinvexe);
            previousActionButton = null;
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_toPickChuyen_Click(object sender, EventArgs e)
        {
            PickChuyen pickChuyen = new PickChuyen();
            pickChuyen.ShowDialog();
        }
    }
}
