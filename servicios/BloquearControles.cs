using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace servicios
{
    public static class BloquearControles
    {
        public static void DisableControls(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is GroupBox)
                    DisableControls(c);
                else
                    c.Enabled = false;
            }
        }
        public static void EnableControls(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is GroupBox)
                    EnableControls(c);
                else
                    c.Enabled = true;
            }
        }
    }
}
