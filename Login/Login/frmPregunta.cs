using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using comun;
using logica;
using Login;

namespace Vista
{
    public partial class frmPregunta : Form
    {
        public frmPregunta()
        {
            InitializeComponent();
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtPregunta.Text != "" && txtRespuesta.Text != "")
            {
                if (ActualizarPreguntasseg.actualizar(txtPregunta.Text, txtRespuesta.Text))
                {
                    lblPreguntaState.ForeColor = Color.SpringGreen;
                    lblPreguntaState.Text = "Pregunta de Seguridad Guardada!";

                    

                    frmAplicacion Aplicacion = new frmAplicacion();
                    Aplicacion.Show();
                    this.Close();
                }
            }
            else
            {
                lblRespState.Text = "Rellene el campo!!";
                lblRespState.Visible = true;
            }
        }
    }
}
