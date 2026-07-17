using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using logica;
using comun;
using Vista;
using Vista.Controles;

namespace Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            ObtenerConfigSis.obtener();
            groupBox1.TabStop = false;
            groupBox2.TabStop = false;
        }
        #region Cosas para arrastrar la interfaz


        // Yo se q no queria q copie el codigo este pero me parece util
        // Copiado de https://stackoverflow.com/a/19491283

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

    
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


    
        #endregion
        #region Controles de Ventana
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion
        #region TextBoxes
        private void txtUser_Enter(object sender, EventArgs e)
        {
            cambiosControles.placeHolder_Set(txtUser, lblErrorUsr, "Usuario123");
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            cambiosControles.placeHolder_Reset(txtUser, "Usuario123");
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            cambiosControles.placeHolder_Set(txtPass, lblErrorUsr, "Contraseña456");
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {

            cambiosControles.placeHolder_Reset(txtPass, "Contraseña456");
        }


        #endregion
        #region Mostrar Contraseña


        #endregion

        private void logear()
        {
            bool validar = true;

            // Chequear si el campo de usuario tiene texto
            if (string.IsNullOrEmpty(txtUser.Text) || txtUser.Text == "Usuario123")
            {
                lblErrorUsr.Visible = true;
                lblErrorUsr.Text = "Por favor rellene el campo";
                validar = false;
            }

            // Chequear si el campo de contraseña tiene texto
            if (string.IsNullOrEmpty(txtPass.Text) || txtPass.Text == "Contraseña456")
            {
                validar = false;
            }

            if (validar == true)
            {
                consultarlogueo cl = new consultarlogueo();

                if (cl.preguntar(txtUser.Text, txtPass.Text))
                {
                  frmAplicacion app = new frmAplicacion();
                    app.Show();
                    this.Hide();
                }
                else
                {
                    lblErrorUsr.Visible = true;
                    lblErrorUsr.Text = "Usuario o Contraseña erroneos";
                }
            }
        }
        private void lblOlvido_Click(object sender, EventArgs e)
        {
            frmOlvido Olvido = new frmOlvido();
            Olvido.Show();
            this.Hide();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegister register = new frmRegister();
            register.Show();
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {

            logear();
        }
        private void picShow_Click(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = !txtPass.UseSystemPasswordChar;
        }
        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
          if(  e.KeyCode== Keys.Enter)
            {
                logear();
            }
        }
    }
}
