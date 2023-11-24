using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coach_Ticket_Management.Controls
{
    public partial class LabelTextBox : UserControl
    {
        public LabelTextBox()
        {
            InitializeComponent();
        }

        public TextBox GetTextBox()
        {
            return textBox1;
        }

        public Label GetLabel()
        {
            return label1;
        }
    }
}
