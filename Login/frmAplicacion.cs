using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using comun;
using logica;
using logica.sistema.articulos;
using servicios;
using Vista;
using Vista.Formularios_Hijos;
using Vista.Formularios_Hijos.Compras;
using Vista.Formularios_Hijos.Ventas;

namespace Login
{
    public partial class frmAplicacion : Form
    {
        public frmAplicacion()
        {
            InitializeComponent();
        }

        #region Variables

        private Panel subMenuActual;
        private Form FormActual;

        #endregion 

        #region Cosas para arrastrar la interfaz
        // Yo se q no queria q copie el codigo este pero me parece util
        // Copiado de https://stackoverflow.com/a/19491283

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion
        private void frmAplicacion_Load(object sender, EventArgs e) 
        {
            if (Comun.Nuevo)
            {
                Form frmCambioContr = new frmCambioContr();
                frmCambioContr.Show();
                if (SistemCache.Validacion/*&& validado=true*/)
                {
                    frmVerificacion verificacion = new frmVerificacion();
                    verificacion.Show();
                    frmCambioContr.Hide();
                    //validado = true;
                }
                this.Close();
            }
            else 
            {
                if (Comun.FechaFin <= DateTime.Today)
                {
                    if (BorrarinfoPersonal.borrar(Comun.UserID))
                    {
                        this.Close();
                    }
                }
                if (Comun.bloqueado == true)
                {
                    BloquearControles.DisableControls(this);
                    MessageBox.Show("Este usuario se encuentra Bloqueado");
                }
                else
                {
                  
                    BloquearControles.EnableControls(this);
                }
                lblUserName.Text = Comun.NombreUsuario.ToString();
                lblCargo.Text = Comun.NombrePermiso.ToString();



                switch (Comun.NombrePermiso)
                {
                    case "admin":
                        lblCompras.Visible = true;
                        lblOrdenCompras.Visible = true;
                        lblVentas.Visible = true;
                        lblArticulos.Visible = true;
                        lblCategorias.Visible = true;
                        lblProveedores.Visible = true;
                        lblClientes.Visible = true;

                        btnAdministrador.Enabled = true;
                        btnAdministrador.Visible = true;
                        break;

                    case "empleado1":
                        // Compras
                        lblCompras.Visible = true;
                        lblOrdenCompras.Visible = true;
                        lblArticulos.Visible = true;
                        lblCategorias.Visible = true;
                        lblProveedores.Visible = true;
                        break;

                    case "empleado2":
                        // Ventas
                        lblOrdenCompras.Visible = true;
                        lblVentas.Visible = true;
                        lblClientes.Visible = true;
                        break;

                    case "persona":
                        MessageBox.Show("El Usuario NO tiene Permisos");
                        Application.Exit();

                        break;

                    default:
                        BloquearControles.DisableControls(this);
                        break;
                }



            }

           

        }

        // Mover a Cambios controles
        private void abrirSubForm(Form frmhijo)
        {
            if (FormActual != null)
            {
                FormActual.Dispose();
            }

            FormActual = frmhijo;
            frmhijo.Show();
            frmhijo.BringToFront();

            frmhijo.TopLevel = false;
            frmhijo.FormBorderStyle = FormBorderStyle.None;
            frmhijo.Dock = DockStyle.Fill;

            lblTitulo.Tag = frmhijo;
            lblTitulo.Text = frmhijo.Text;
            panelWorkspace.Controls.Add(frmhijo);
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void lblInicio_Click(object sender, EventArgs e)
        {
            
        }
        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnAdministrador_Click(object sender, EventArgs e)
        {
            frmAdmin Admin = new frmAdmin();
            abrirSubForm(Admin);
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Close();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("dd / MM / yyyy | HH:mm:ss");            
        }
        private void lblCompras_Click(object sender, EventArgs e)
        {
            frmOrdenDeCompra Ingresos= new frmOrdenDeCompra();
            abrirSubForm(Ingresos);
        }
        private void lblVentas_Click(object sender, EventArgs e)
        {
            frmEgresos Egresos= new frmEgresos();
            abrirSubForm(Egresos);
        }
        private void lblAlmacen_Click(object sender, EventArgs e)
        {
            Articulos Articulos = new Articulos();
            abrirSubForm(Articulos);
        }
        private void lblConsulReportes_Click(object sender, EventArgs e)
        {
            frmCategoria Categorias = new frmCategoria();
            abrirSubForm(Categorias);
        }
        private void lblProveedores_Click(object sender, EventArgs e)
        {
            frmProveedores Proveedores = new frmProveedores();
            abrirSubForm(Proveedores);
        }
        //private void lblTelefonos_Click(object sender, EventArgs e)
        //{
        //    frmEjemplo Telefonos = new frmEjemplo();
        //    abrirSubForm(Telefonos);
        //}
        private void label1_Click(object sender, EventArgs e)
        {
            frmClientes clientes = new frmClientes();
            abrirSubForm(clientes);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            frmIngresos ingresos = new frmIngresos();
            abrirSubForm(ingresos);
        }
    }
}
