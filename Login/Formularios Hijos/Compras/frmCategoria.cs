using logica.sistema;
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
using logica.sistema.alta;
using logica.sistema.modificacion;
using logica.sistema.baja;

namespace Vista
{
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();


        }
        private void frmCategoria_Load(object sender, EventArgs e)
        {
            actualizarDt();

            btnCancelar.Enabled = false;
            btnGuardar.Enabled = false;

            dataGridListado.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridMantenimiento.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridListado.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridMantenimiento.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridListado.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridMantenimiento.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        public void actualizarDt()
        {
            DataTable dt = MostrarCategoria.mostrar();

            dataGridMantenimiento.DataSource = dt;
            dataGridMantenimiento.AutoResizeColumns();
            dataGridMantenimiento.AutoResizeRows();
            
            dataGridListado.DataSource = dt;
            dataGridListado.AutoResizeColumns();
            dataGridListado.AutoResizeRows();

        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            bool isAgregable = true;

            if (isAgregable)
            {
                if (InsertarCategoria.insertar(txtCategoriaNombre.Text,txtDescripcion.Text))
                {
                    actualizarDt();
                }
                else
                {
                    MessageBox.Show("Error al insertaer los datos");
                }
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (EliminarCategoria.eliminar(Convert.ToInt32(dataGridMantenimiento.SelectedCells[0].Value)))
            {
                actualizarDt();
            }
            else
            {
                MessageBox.Show("Error al borrar categoria");
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {

            txtCategoriaId.Text = Convert.ToString(dataGridMantenimiento.SelectedCells[0].Value);
            txtCategoriaNombre.Text = Convert.ToString(dataGridMantenimiento.SelectedCells[1].Value);
            txtDescripcion.Text = Convert.ToString(dataGridMantenimiento.SelectedCells[2].Value);

            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            

            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;    
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Editar_Categoria.editar(Convert.ToInt32(txtCategoriaId.Text), txtCategoriaNombre.Text, txtDescripcion.Text))
            {
                actualizarDt();
                
                btnAnular.Enabled = true;
                btnNuevo.Enabled = true;
                btnEditar.Enabled = true;

                btnGuardar.Enabled = false;
                btnCancelar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error al guardar los datos");
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtCategoriaId.Text = "";
            txtCategoriaNombre.Text = "";
            txtDescripcion.Text = "";

            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
            
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dataGridListado.DataSource = BuscarCategoria.Buscar(txtBuscar.Text);
        }
        private void btnAnular_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            dataGridListado.DataSource = MostrarCategoria.mostrar();
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dataGridListado.DataSource = BuscarCategoria.Buscar(txtBuscar.Text);
            }
        }
    }
}
