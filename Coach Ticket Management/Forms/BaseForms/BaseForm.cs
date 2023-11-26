using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coach_Ticket_Management.Forms.BaseForms
{
    // BaseForm class for inherited form. Author: Vu Thanh Duong
    public partial class BaseForm : Form
    {
        /// <summary>
        /// Creating a form with default size 1000x600. Author: Vu Thanh Duong 
        /// </summary>
        public BaseForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.CenterToScreen();
            this.Icon = Properties.Resources.logo1;
        }
    }
}
