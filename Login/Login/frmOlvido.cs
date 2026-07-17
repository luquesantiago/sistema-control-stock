using System;
using System.Data;
using servicios;
using logica;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmOlvido : Form
    {
        string mail;
        public frmOlvido()
        {
            InitializeComponent();
        }
        private void btnEnviarCorreo_Click(object sender, EventArgs e)
        {
            if (ConsultarPreguntasseg.coincide(txtUser.Text, lblPregunta.Text, txtPregunta.Text))
            {
                string Contraseña = crearContraseña.ArmarCadena(8);
                if (ActualizarPassword.actualizar(txtUser.Text, PasswordEncryptor.EncryptPassword(Contraseña) + 
                    PasswordEncryptor.EncryptPassword(txtUser.Text)))
                {
                    ArmarMail.Asunto = "Restablecimiento de Contraseña";
                    ArmarMail.NuevaContraseña = Contraseña;
                    ArmarMail.DireccionCorreo = mail;
                    ArmarMail.Preparar();
                    Application.OpenForms["frmLogin"].Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Algo inesperado sucedio durante la ejecucion :(");
                }
            }
            else
            {
                lblPreguntaState.Visible = true;
            }
        }
        private void btnObtPregunta_Click(object sender, EventArgs e)
        {
            if (validarUsuarioExistente.ValidarUsuarioExistente(txtUser.Text))
            {
                DataTable dt = ObtenerPreguntasseg.pregunta(txtUser.Text);
                lblPregunta.Text = dt.Rows[0][0].ToString();
                mail = dt.Rows[0][1].ToString();

                
                //txtUser.Enabled = false;
                lblUsrState.Visible = false;

                //txtPregunta.Enabled = false;
                
                //btnEnviarCorreo.Enabled = true;

                //btnObtPregunta.Enabled = false;
            }
            else
            {
                lblUsrState.Visible = true;
            }
        }
    }
}
