using Coach_Ticket_Management.Forms.BaseForms;
using Coach_Ticket_Management.Forms.MainForms;
using Coach_Ticket_Management.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coach_Ticket_Management.Forms.ActionForms
{
    public partial class LoginForm : BaseForm
    {
        public LoginForm()
        {
            InitializeComponent();
            this.Load += LoginForm_Load;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            Text = "Đăng nhập";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.btn_login.Click += Btn_login_Click;
            this.textb_password.PasswordChar = '*';
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            LoginProcess.LoginStatus status = LoginProcess.Process(textb_username.Text, textb_password.Text);
            if (status == LoginProcess.LoginStatus.Successful)
            {
                MessageBox.Show("Đăng nhập thành công!");
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!");
            }
        }
    }
}
