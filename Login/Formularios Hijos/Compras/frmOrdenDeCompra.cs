
using logica.sistema;
using System;
using System.Data;
using comun;
using servicios;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using logica.sistema.ingreso;
using logica.sistema.alta;
using System.Collections.Generic;
using servicios.validaciones;
using Login;
using logica.sistema.articulos;

namespace Vista
{
    public partial class frmOrdenDeCompra : Form
    {
        public frmOrdenDeCompra()
        {
            InitializeComponent();

        }
        private void actualizardt()
        {

            
            dateInicio.MaxDate = DateTime.Now;
            dateFin.MaxDate = DateTime.Now;

            DataTable dt = MostrarOrdendecompra.mostrar();

            dataGridListado.DataSource = dt;
            dataGridListado.AutoResizeColumns();
            dataGridListado.AutoResizeRows();

            dataGridDetalle.DataSource = dt;
            dataGridDetalle.AutoResizeColumns();
            dataGridDetalle.AutoResizeRows();

            dataGridCarrito.DataSource = carritoIngreso.CrearDataTableCarrito(carritoconfig.ObtenerListaCarrito());
            dataGridCarrito.AutoResizeColumns();
            dataGridCarrito.AutoResizeRows();
        }
        private void frmIngresos_Load(object sender, System.EventArgs e)
        {
            string aviso = AvisoStock.aviso();
            if (aviso != "")
            {
                MessageBox.Show(aviso);
            }
            actualizardt();
            carritoconfig.vaciar_carrito();
            cboProveedor.DataSource = MostrarProveedor.mostrar();
            cboProveedor.DisplayMember = "proveedor";
            cboProveedor.ValueMember = "idproveedor";
            cboProveedor.SelectedIndex = 1;
            cboProveedor.AutoCompleteMode = AutoCompleteMode.Suggest;

            cboArticulo.DataSource = MostrarArticulo.Mostrar();
            cboArticulo.Enabled = false;
            cboArticulo.DisplayMember = "nombre";
            cboArticulo.ValueMember = "idarticulo";
            cboArticulo.SelectedIndex = 1;
            cboArticulo.AutoCompleteMode = AutoCompleteMode.Suggest;
            

            dataGridListado.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridDetalle.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
    
        }


        private void btnBuscar_Click(object sender, System.EventArgs e)
        {
           dataGridListado.DataSource= Buscar_ordendecompra_fecha.Buscar(dateInicio.Value, dateFin.Value);

        }


        private void btnNuevo_Click(object sender, System.EventArgs e)
        {
            carritoconfig.agregar_carrito_al_historial_ingreso();
            actualizardt();
            cboProveedor.Enabled = true;
        }
        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            if (dataGridCarrito.Rows.Count > 0 || dataGridDetalle.Rows.Count > 0)
            {
                if (EliminarOrdendecompra.eliminar(Convert.ToInt32(dataGridDetalle.SelectedCells[0].Value)))
                {
                    actualizardt();
                }
                else
                {
                    MessageBox.Show("Error al Eliminar");
                }
            }
            else
            {
                MessageBox.Show("El Carrito esta vacio");
            }
            
            
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //agregar validaciones
            bool isAgregable = true;

            if (txtPrecioCompra.Text == "" || !AddressValidator.IsValidNumber(txtPrecioCompra.Text))
            {
                isAgregable = false;
            }

            if (txtStockInicial.Text == "" || !AddressValidator.IsValidNumber(txtStockInicial.Text))
            {
                isAgregable = false;
            }

           
            if (isAgregable)
            {
                carritoconfig.AgregarElementoCarrito
                (new carrito
                {
                    users = Comun.NombreUsuario,
                    fecha = DateTime.Now,
                    idproveedor = Convert.ToInt32(txtProvId.Text),
                    proveedor = cboProveedor.Text,
                    idarticulo = Convert.ToInt32(txtArticuloId.Text),
                    articulo = cboArticulo.Text,
                    total = Convert.ToDouble(txtPrecioCompra.Text) * Convert.ToDouble(txtStockInicial.Text),
                    precio = Convert.ToDouble(txtPrecioCompra.Text),
                    stock_ingreso = Convert.ToInt32(txtStockInicial.Text),
                    
                });
                cboProveedor.Enabled = false;
                actualizardt();
            }
            else
            {
                MessageBox.Show("Rellene los Campos");
            }
            
        }
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dataGridCarrito.Rows.Count>0) 
            {
                carritoconfig.EliminarElementoCarrito(dataGridCarrito.SelectedRows[0].Index);
                actualizardt();
            }
            else
            {
                MessageBox.Show("el carrito esta vacio");
            }
        }


        private void cboProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtProvId.Text = cboProveedor.SelectedValue.ToString();
            cboArticulo.Enabled = true;
            cboArticulo.DataSource = MostrarArticulo.mostrar_combo(Convert.ToInt32(txtProvId.Text));
            cboArticulo.DisplayMember = "nombre";
            cboArticulo.ValueMember = "idarticulo";
            cboArticulo.SelectedIndex = 0;

        }
        private void cboArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtArticuloId.Text= cboArticulo.SelectedValue.ToString();
        }

        private void dateFin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dataGridListado.DataSource = Buscar_ordendecompra_fecha.Buscar(dateInicio.Value, dateFin.Value);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            carritoconfig.vaciar_carrito();
            actualizardt();
            cboProveedor.Enabled = true;
        }
    }
}
