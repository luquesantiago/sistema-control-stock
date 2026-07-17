using logica.sistema;
using logica.sistema.ingreso;
using servicios.validaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Formularios_Hijos.Compras
{
    public partial class frmIngresos : Form
    {
        public frmIngresos()
        {
            InitializeComponent();
        }

        private void actualizarDt() 
        {
            dateProduccion.MaxDate = DateTime.Now;

            dateInicio.MaxDate = DateTime.Now;
            dateFin.MaxDate = DateTime.Now;

            DataTable dt = Mostrar_Ingreso.mostrar();

            dataGridListado.DataSource = dt;
            dataGridListado.AutoResizeColumns();
            dataGridListado.AutoResizeRows();

            dataGridDetalle.DataSource = dt; 
            dataGridDetalle.AutoResizeColumns();
            dataGridDetalle.AutoResizeRows();

            dataGridCarrito.DataSource = MostrarOrdendecompra.mostrar();
            dataGridCarrito.AutoResizeColumns();
            dataGridCarrito.AutoResizeRows();
        }

        private void frmIngresos_Load(object sender, EventArgs e)
        {
            actualizarDt();

            cboComprobante.SelectedIndex = 0;
            cboComprobante.AutoCompleteMode = AutoCompleteMode.Suggest;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            bool isAgregable = true;

            if (dateProduccion.Value == DateTime.Now)
            {
                isAgregable = false;
                MessageBox.Show("Fechas incorrectas");
            }

            if (dateVencimiento.Value == DateTime.Now)
            {
                isAgregable = false;
                MessageBox.Show("Fechas incorrectas");
            }

            if (!AddressValidator.IsValidNumber(txtNumComprobante.Text))
            {
                isAgregable = false;
            }

            if(dataGridCarrito.Rows.Count < 0)
            {
                isAgregable = false;
            }

            if (isAgregable)
            {
                Insertar_Ingreso.insertar(cboComprobante.Text, txtNumComprobante.Text, Convert.ToString(dataGridCarrito.SelectedCells[0].Value), dateProduccion.Value,dateVencimiento.Value);
                actualizarDt();
            }
            else
            {
                MessageBox.Show("Rellene los Campos Correctamente!");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dataGridListado.DataSource = buscar_Ingreso_Fecha.Buscar(dateInicio.Value, dateFin.Value);
        }

        private void dateFin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dataGridListado.DataSource = buscar_Ingreso_Fecha.Buscar(dateInicio.Value, dateFin.Value);
            }
        }
    }
}
