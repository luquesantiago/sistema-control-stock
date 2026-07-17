using logica;
using System;
using comun;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using servicios;

namespace Vista
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
           
           
             
                dataGridView1.DataSource = creardt.crear();
                dataGridView1.AutoResizeColumns();
                dataGridView1.AutoResizeRows();
                dateCaducidad.MinDate = DateTime.Today;

          
            

            cboMinChar.Checked = SistemCache.minChar;
            cboCaps.Checked = SistemCache.MayusyMin;
            cboSpecChar.Checked = SistemCache.Especiales;
            cbo2FA.Checked = SistemCache.Validacion;
            cboRepeat.Checked = SistemCache.repetirC;
            

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ObtenerDatos.obtener(Convert.ToString(dataGridView1.SelectedCells[1].Value));
            
            lblNombre.Text = DatosUcache.Nombre;
            txtUserName.Text = DatosUcache.Usuario;
            txtPass.Text = DatosUcache.Contrasena;
            cboRoles.Text = DatosUcache.Permiso;
            dateCaducidad.Value = DatosUcache.FechaFin;
            cboUserBloq.Checked = DatosUcache.bloqueado;

            BloquearControles.EnableControls(groupBoxUser);
        }
        private void btnGuardarUser_Click(object sender, EventArgs e)
        {
           if( ActualizarDatosu.intentar(cboUserBloq.Checked, txtUserName.Text, txtPass.Text, cboRoles.Text, dateCaducidad.Value))
           {
                MessageBox.Show("Cambios realizados correctamente!!");
            }
        }
        private void btnCancelarUser_Click(object sender, EventArgs e)
        {
            // Restablecer Cambios
            lblNombre.Text = DatosUcache.Nombre;
            txtUserName.Text = DatosUcache.Usuario;
            txtPass.Text = DatosUcache.Contrasena;
            cboRoles.Text = DatosUcache.Permiso;
            dateCaducidad.Value = DatosUcache.FechaFin;
            cboUserBloq.Checked = DatosUcache.bloqueado;
        }



        private void btnGuardarCFG_Click(object sender, EventArgs e)
        {
            ActualizarConfiguracionSis.ejecutar();
        }

        private void btnCancelarCFG_Click(object sender, EventArgs e)
        {
            cboMinChar.Checked = SistemCache.minChar;
            cboCaps.Checked = SistemCache.MayusyMin;
            cboSpecChar.Checked = SistemCache.Especiales;
            cbo2FA.Checked = SistemCache.Validacion;
            cboRepeat.Checked = SistemCache.repetirC;
        }
    }
}
