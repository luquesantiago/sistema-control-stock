using logica.sistema;
using logica.sistema.alta;
using logica.sistema.baja;
using logica.sistema.modificacion;
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

namespace Vista
{
    public partial class Articulos : Form
    {
        bool insertar=false;
        bool editar=false;
        public Articulos()
        {
            InitializeComponent();

            
        }
        public void actualizarDt()
        {
            DataTable dt = BuscarArticulosNombre.Buscar("");

            dataGridListado.DataSource = dt;
            dataGridListado.AutoResizeColumns();
            dataGridListado.AutoResizeRows();

            dataGridArticulo.DataSource = dt;
            dataGridArticulo.AutoResizeColumns();
            dataGridArticulo.AutoResizeRows();

        }
        private void frmArticulos_Load(object sender, EventArgs e)
        {
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = false;
            actualizarDt();

            cboCategoria.DataSource = MostrarCategoria.mostrar();
            cboCategoria.DisplayMember = "Nombre";
            cboCategoria.ValueMember = "idcategoria";
            cboCategoria.SelectedIndex = 1;
            cboCategoria.AutoCompleteMode = AutoCompleteMode.Suggest;

            cboProv.DataSource = MostrarProveedor.mostrar();
            cboProv.DisplayMember = "proveedor";
            cboProv.AutoCompleteMode = AutoCompleteMode.Suggest;



            dataGridListado.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridListado.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
            dataGridArticulo.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            insertar = true;
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;

            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;

        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            EliminarArticulo.eliminar(Convert.ToInt32(dataGridArticulo.SelectedCells[0].Value));
            actualizarDt();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            editar= true;
            btnNuevo.Enabled     = false;
            btnEditar.Enabled    = false;

            btnCancelar.Enabled  = true;
            btnGuardar.Enabled   = true;

            txtArticuloId.Text   = Convert.ToString(dataGridArticulo.SelectedCells[0].Value);
            txtNombre.Text       = Convert.ToString(dataGridArticulo.SelectedCells[2].Value);
            txtpuntoreaprov.Text = Convert.ToString(dataGridArticulo.SelectedCells[6].Value);
            txtDescripcion.Text  = Convert.ToString(dataGridArticulo.SelectedCells[7].Value);
            cboCategoria.Text    = Convert.ToString(dataGridArticulo.SelectedCells[8].Value);
            cboProv.Text         = Convert.ToString(dataGridArticulo.SelectedCells[9].Value);
            
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool isAgregable = true;

            if (txtNombre.Text == "")
            {
                isAgregable = false;
            }
            if (txtpuntoreaprov.Text == "" || !AddressValidator.IsValidNumber(txtpuntoreaprov.Text))
            {
                isAgregable = false;
            }
            if (txtDescripcion.Text == "")
            {
                isAgregable = false;
            }
            if (insertar && isAgregable)
            {

                if(InsertarArticulo.insertar(txtNombre.Text, txtDescripcion.Text, txtCategoriaId.Text, cboProv.Text, txtpuntoreaprov.Text))
                {
                    actualizarDt();
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = false;
                    txtArticuloId.Text = string.Empty;
                    cboCategoria.Text = string.Empty;
                    txtCategoriaId.Text = string.Empty;
                    txtDescripcion.Text = string.Empty;
                    txtNombre.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Error al agregar articulo");
                }
            }
            if (editar&& isAgregable)
            {
                if (EditarArticulo.editar(txtArticuloId.Text, txtNombre.Text, txtDescripcion.Text, txtCategoriaId.Text, cboProv.Text,txtpuntoreaprov.Text))
                {
                    actualizarDt();
                    btnNuevo.Enabled    = true;
                    btnEditar.Enabled   = true;
                    btnGuardar.Enabled  = false;
                    btnCancelar.Enabled = false;
                   

                }
                else
                {
                    MessageBox.Show("Error al actualizar el articulo");
                }

            }

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtArticuloId.Text  = string.Empty;
            cboCategoria.Text   = string.Empty;
            txtCategoriaId.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtNombre.Text      = string.Empty;

            btnNuevo.Enabled    = true;
            btnEditar.Enabled   = true;
            btnGuardar.Enabled  = false;
            btnCancelar.Enabled = false;
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
           dataGridListado.DataSource= BuscarArticulosNombre.Buscar(txtArticuloName.Text);
        }
        private void btnAnular_Click(object sender, EventArgs e)
        {
            actualizarDt();
        }
        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCategoriaId.Text = cboCategoria.SelectedValue.ToString();
        }

        private void txtArticuloName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dataGridListado.DataSource = BuscarArticulosNombre.Buscar(txtArticuloName.Text);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
