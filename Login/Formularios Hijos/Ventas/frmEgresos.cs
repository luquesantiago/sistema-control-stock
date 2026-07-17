using comun;
using logica.sistema;
using logica.sistema.baja;
using logica.sistema.venta;
using System;
using servicios;
using System.Data;
using System.Windows.Forms;
using servicios.validaciones;
using Vista.Controles;

namespace Vista.Formularios_Hijos.Ventas
{
    public partial class frmEgresos : Form
    {
        public frmEgresos()
        {
            InitializeComponent();
        }
        private void actualizardt()
        {
            DataTable dt = MostrarVenta.mostrar();

            dataGridListado.DataSource = dt;
            dataGridListado.AutoResizeColumns();
            dataGridListado.AutoResizeRows();

            dataGridDetalle.DataSource = dt;
            dataGridDetalle.AutoResizeColumns();
            dataGridDetalle.AutoResizeRows();

            dataGridCarrito.DataSource = carritoVenta.CrearDataTableCarrito(carritoconfig.ObtenerListaCarrito());
            dataGridCarrito.AutoResizeColumns();
            dataGridCarrito.AutoResizeRows();


        }
        private void frmEgresos_Load(object sender, EventArgs e)
        {
            fechaInicio.MaxDate = DateTime.Now;
            fechaFin.MaxDate = DateTime.Now;

            actualizardt();
            carritoconfig.vaciar_carrito();
            cboCliente.DataSource = MostrarCliente.mostrar();
            cboCliente.DisplayMember = "Nombre";
            cboCliente.ValueMember = "idcliente";
            cboCliente.SelectedIndex = 1;
            cboCliente.AutoCompleteMode = AutoCompleteMode.Suggest;

            DataTable dt = MostrarArticulo.Mostrar();
            cboArticulo.DataSource = dt;
            cboArticulo.DisplayMember = "nombre";
            cboArticulo.ValueMember = "idarticulo";
            cboArticulo.SelectedIndex = 1;
            cboArticulo.AutoCompleteMode = AutoCompleteMode.Suggest;

            cboComprobante.SelectedIndex = 0;
            cboComprobante.AutoCompleteMode = AutoCompleteMode.Suggest;

            dataGridListado.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridDetalle.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dataGridListado.DataSource = Buscar_venta_fecha.Buscar(fechaInicio.Value, fechaFin.Value);
            
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            cboCliente.Enabled = true;
            cboComprobante.Enabled = true;
            txtNumComprobante.Enabled = true;
            carritoconfig.agregar_carrito_al_historial_venta();
            actualizardt();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dataGridCarrito.Rows.Count > 0 || dataGridDetalle.Rows.Count > 0)
            {
                if (EliminarVenta.eliminar(Convert.ToInt32(dataGridDetalle.SelectedCells[0].Value)))
                {
                    actualizardt();
                }
                else
                {
                    MessageBox.Show("Error al Eliminar pedido");
                }
            }
            else
            {
                MessageBox.Show("No hay pedido para Eliminar");
            }
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            cboCliente.Enabled= false;
            cboComprobante.Enabled= false;
            txtNumComprobante.Enabled= false;

            bool isAgregable = true;

            

            if (txtStockInicial.Text == "" || !AddressValidator.IsValidNumber(txtStockInicial.Text))
            {
                isAgregable = false;
            }

            if (txtNumComprobante.Text == "" || !AddressValidator.IsValidNumber(txtNumComprobante.Text))
            {
                isAgregable = false;
            }

            if (isAgregable == true && Convert.ToDouble(txtStockInicial.Text) > Convert.ToDouble(lblStockActual.Text))
            {
                isAgregable = false;
                cambiosControles.lblStateError(lblStockState, "La venta excede el stock");
            }

            if (isAgregable)
            {
                double p = mostrarPrecio.mostrar(txtArticuloId.Text);

                carritoconfig.AgregarElementoCarrito(new carrito
                {
                    fecha = DateTime.Now,
                    users = Comun.NombreUsuario,
                    idcliente = Convert.ToInt32(txtClienteId.Text),
                    cliente = cboCliente.Text,
                    idarticulo = Convert.ToInt32(txtArticuloId.Text),
                    articulo = cboArticulo.Text,
                    stock_ingreso = Convert.ToInt32(txtStockInicial.Text),
                    precio = p,
                    total = p * Convert.ToInt32(txtStockInicial.Text),
                    tipo_comprobante = cboComprobante.Text,
                    Numero_Comprobante=Convert.ToInt64(txtNumComprobante.Text),
                }); 
                actualizardt();
            }
            else
            {
                MessageBox.Show("Error al Agregar Articulos al Carrito");
            }

            
        }
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dataGridCarrito.Rows.Count > 0)
            {
                carritoconfig.EliminarElementoCarrito(dataGridCarrito.SelectedRows[0].Index);
                actualizardt();
            }
            else
            {
                MessageBox.Show("el carrito esta vacio");
            }
        }

        private void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtClienteId.Text = cboCliente.SelectedValue.ToString();


        }

        private void cboArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtArticuloId.Text = cboArticulo.SelectedValue.ToString();
            lblStockActual.Text = Convert.ToString(StockArticulo.mostrar(Convert.ToInt32(txtArticuloId.Text)).Rows[0][0]);
        }

        private void btnvaciarcarrito_Click(object sender, EventArgs e)
        {
            cboCliente.Enabled = true;
            cboComprobante.Enabled = true;
            txtNumComprobante.Enabled = true;
            carritoconfig.vaciar_carrito();
            actualizardt();
        }

        private void fechaFin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dataGridListado.DataSource = Buscar_venta_fecha.Buscar(fechaInicio.Value, fechaFin.Value);
            }
        }
    }
}
