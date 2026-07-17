using System;
using System.Drawing;
using System.Windows.Forms;
using comun;
using servicios;

namespace Vista
{
    public partial class frmVerificacion : Form
    {
        public int secondsLeft = 60;
        public frmVerificacion()
        {
            InitializeComponent();
        }
        private void frmVerificacion_Load(object sender, EventArgs e)
        {
            timer1.Start();
            enviarMail();
        }
        private static void enviarMail()
        {
            ArmarMail.Asunto = "Cambio de Contraseña";
            ArmarMail.NuevaContraseña = crearContraseña.ArmarCadena(6);
            ArmarMail.DireccionCorreo = Comun.Gmail;
            ArmarMail.Preparar();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            secondsLeft--;

            lblTiempo.Text = secondsLeft.ToString();

            if (lblTiempo.Text == "0")
            {
                lblReenviar.Enabled = true;
                lblReenviar.ForeColor = Color.FromArgb(0, 120, 215);

                timer1.Stop();
                timer1.Dispose();
            }
        }
        private void lblReenviar_Click(object sender, EventArgs e)
        {
            timer1.Start();

            lblReenviar.Enabled = false;
            lblReenviar.ForeColor = Color.FromArgb(68, 68, 68);

            enviarMail();
        }
        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == ArmarMail.NuevaContraseña)
            {
                Application.OpenForms["frmCambioContr"].Show();
                this.Close();
            }
            else
            {
                lblRespuestaState.Text = "Codigo de verificacion Invalido";
                lblRespuestaState.Visible = true;
            }
        }

      
    }
}
