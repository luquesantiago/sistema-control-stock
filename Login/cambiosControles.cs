using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Controles
{
    static class cambiosControles
    {
        // Manejar PlaceHolders
        #region Manejar Place Holders
        public static void placeHolder_Set(Control control,Control lblSate, string placeHolder)
        {
            lblSate.Visible = false;
            control.ForeColor = Color.FromArgb(90, 92, 230);
            if (control.Text == placeHolder)
            {
                control.Text = "";
            }        
        }

        public static void placeHolder_Reset(Control control, string placeHolder)
        {
            if (control.Text == "" || control.Text == placeHolder)
            {
                control.Text = placeHolder;
                control.ForeColor = Color.FromArgb(191, 205, 219);
            }
            else
            {
                control.ForeColor = Color.FromArgb(39, 39, 39);
            }
        }
        #endregion

        public static void lblStateError(Control label, string txt)
        {
            label.ForeColor = Color.FromArgb(255, 40, 40);
            label.Visible = true;
            label.Text = txt;
        }

        public static void lblStateValid(Control label, string txt)
        {
            label.ForeColor = Color.FromArgb(67, 177, 91);
            label.Visible = true;
            label.Text = txt;

        }

        // Cambiar de lugar el abrirSubForm aca


    }
}
