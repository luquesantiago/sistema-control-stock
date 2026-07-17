using System;
using System.Windows.Forms;
using comun;
using logica;
using servicios;

namespace Vista
{
    public partial class frmCambioContr : Form
    {
        public frmCambioContr()
        {
            InitializeComponent();
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            bool cambiar = true;


            // Las contraseñas difieren
            if (txtContraNueva.Text != txtRepetirNueva.Text)
            {
                lblContraNuevaState.Visible = true;
                lblContraNuevaState.Text = "Las contraseñas no coinciden";
                cambiar = false;
            }
            else
            {
                lblContraNuevaState.Visible = false;
            }

            // Las contraseña actual ingresada difiere de la registrada
            if (txtContraActual.Text != Comun.Contrasena)
            {
                lblActualState.Text = "La Contraseña es Incorrecta";
                lblActualState.Visible = true;
                cambiar = false;
            }
            else
            {
                lblActualState.Visible = false;
            }

            // La contraseña no cumple con los requisitos establecidos
            if (ValidarContraseña.Validar(Comun.NombreUsuario, txtContraActual.Text))
            {
                lblMatchError.Visible = false;
            }
            else
            {
                lblMatchError.Visible = true;
                cambiar = false;
            }

            //
            if (cambiar)
            {
                if (ActualizarPassword.actualizar(Comun.NombreUsuario,PasswordEncryptor.EncryptPassword(txtContraNueva.Text)+ PasswordEncryptor.EncryptPassword(Comun.NombreUsuario)))
                {
                    lblMatchError.Visible = true;
                    lblMatchError.Text = "Contraseña Actualizada!";
                    Comun.Contrasena = txtContraNueva.Text;

                    Form frmPregunta = new frmPregunta();
                    frmPregunta.Show();
                    this.Close();
                }
            }
        }
    }
}
