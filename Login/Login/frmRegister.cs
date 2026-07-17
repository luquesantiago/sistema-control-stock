using logica;
using servicios;
using servicios.validaciones;
using System;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Vista.Controles;

namespace Login
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();

            MostrarLocalidad mostrar = new MostrarLocalidad();

            cboLocalidad.DataSource = mostrar.mostrar();
            cboLocalidad.DisplayMember = "Nombre";

        }
        #region Drag

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        #endregion
        #region TxtBoxes

        #region TxtUser
        private void txtUser_Enter(object sender, EventArgs e)
        {
            cambiosControles.placeHolder_Set(txtUser, lblUserState, "Usuario123");
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            cambiosControles.placeHolder_Reset(txtUser, "Usuario123");
        }

        #endregion

        #region txtMail
        private void txtMail_Enter(object sender, EventArgs e)
        {
            cambiosControles.placeHolder_Set(txtMail, lblMailState, "correo@mail.com");
        }

        private void txtMail_Leave(object sender, EventArgs e)
        {
            cambiosControles.placeHolder_Reset(txtMail, "correo@mail.com");
        }

        #endregion

        #region txtNombre
        private void txtNombre_Enter(object sender, EventArgs e)
        {
            cambiosControles.placeHolder_Set(txtNombre, lblNombreState, "Roberto Gomez");
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            cambiosControles.placeHolder_Reset(txtNombre, "Roberto Gomez");
        }
        #endregion

        #region txtDNI
        private void txtDNI_Enter(object sender, EventArgs e)
        {
            cambiosControles.placeHolder_Set(txtDNI, lblDniState, "69.420.911");
        }

        private void txtDNI_Leave(object sender, EventArgs e)
        {
            cambiosControles.placeHolder_Reset(txtDNI, "69.420.911");
        }

        #endregion

        #region txtTelefono
        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            cambiosControles.placeHolder_Set(txtTelefono, lblTelefonoState, "11 4206 9911");
        }


        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            cambiosControles.placeHolder_Reset(txtTelefono, "11 4206 9911");
        }
        #endregion

        #endregion
        #region ControlesVentana
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion

        bool crearUsuario = true;
        private void crearu()
        {
            if (FullNameValidator.IsValidFullName(txtNombre.Text) && txtNombre.Text != "Roberto Gomez")
            {
                cambiosControles.lblStateValid(lblNombreState, "Nombre Valido");
            }
            else
            {
                cambiosControles.lblStateError(lblNombreState, "Nombre Invalido");
                crearUsuario = false;
            }

            if (DocumentValidator.IsValidDNI(txtDNI.Text) && txtDNI.Text != "69.420.911")
            {
                cambiosControles.lblStateValid(lblDniState, "DNI Valido");
            }
            else
            {
                cambiosControles.lblStateError(lblDniState, "DNI Invalido");
                crearUsuario = false;
            }

            if (PhoneNumberValidator.IsValidPhoneNumber(txtTelefono.Text) && txtTelefono.Text != "11 4206 9911")
            {
                cambiosControles.lblStateValid(lblTelefonoState, "Telefono Valido");
            }
            else
            {
                cambiosControles.lblStateError(lblTelefonoState, "Telefono Invalido");
                crearUsuario = false;
            }

            if (UsuarioValidator.Preguntar(txtUser.Text) && txtUser.Text != "Usuario123")
            {
                cambiosControles.lblStateValid(lblUserState, "Usuario Valido");
            }
            else
            {
                cambiosControles.lblStateError(lblUserState, "Usuario \nNo Disponible");
                crearUsuario = false;

            }
            if (EmailValidator.IsValidEmail(txtMail.Text) && txtMail.Text != "correo@mail.com")
            {
                cambiosControles.lblStateValid(lblMailState, "Correo valido");
            }
            else
            {
                cambiosControles.lblStateError(lblMailState, "Correo invalido");
                crearUsuario = false;
            }
            if (crearUsuario)
            {
                CrearUsuario crear = new CrearUsuario();
                if (crear.crear(txtUser.Text, crearContraseña.ArmarCadena(8), txtNombre.Text, txtMail.Text, txtTelefono.Text, cboTipoTel.Text, DateTime.Today, DateTime.Today.AddYears(1), "Banfield"))
                {
                    MessageBox.Show("Registrado Correctamente");

                    Application.OpenForms["frmLogin"].Show();
                    this.Close();
                }
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
        private void btnAbrirLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.Show();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            crearu();
        }
        private void txtMail_TextChanged(object sender, EventArgs e)
        {
            if (EmailValidator.IsValidEmail(txtMail.Text) && txtMail.Text != "correo@mail.com")
            {
                cambiosControles.lblStateValid(lblMailState, "Correo valido");
            }
            else
            {
                cambiosControles.lblStateError(lblMailState, "Correo invalido");
                
            }
        }
        private void cboLocalidad_KeyDown(object sender, KeyEventArgs e)
        {
           if( e.KeyCode == Keys.Enter)
            {
                crearu();
            }
        }

    }
}
