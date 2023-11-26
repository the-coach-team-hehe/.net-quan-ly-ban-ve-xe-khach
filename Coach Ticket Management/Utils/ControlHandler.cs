using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coach_Ticket_Management.Utils
{
    public static class ControlHandler
    {
        public static void SetEnabled(bool isEnabled, params Control[] values)
        {
            foreach (Control value in values)
            {
                value.Enabled = isEnabled;
            }
        }

        public static void SetText(string text, params Control[] values)
        {
            foreach (Control value in values)
            {
                value.Text = text;
            }
        }
    }
}
