using logica;
using logica.sistema;
using logica.sistema.alta;
using logica.sistema.baja;
using logica.sistema.cliente;
using logica.sistema.modificacion;
using servicios;
using servicios.validaciones;
using System;
using System.Data;
using System.Windows.Forms;
using Vista.Controles;

namespace Vista.Formularios_Hijos
{
    public partial class frmClientes : Form
    {
        bool editar=false;
        bool insertar=false;


        public frmClientes()
        {
            InitializeComponent();

        }
        private void frmClientes_Load(object sender, EventArgs e)
        {
            MostrarLocalidad mostrar = new MostrarLocalidad();
            cboLocalidad.DataSource = mostrar.mostrar();
            cboLocalidad.DisplayMember = "Nombre";
            cboDocumentoTipo.Text = "cuit";
            cboTipoTel.Text = "movil";

            dateTimePicker.MaxDate = DateTime.Now;

            btnBloquear.Enabled = true;
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = false;
            actualizarDt();
        }
        private void actualizarDt()
        {
            DataTable dt = BuscarClienteNumDocumento.Buscar("");

            dataGridListado.DataSource = dt;
            dataGridListado.AutoResizeColumns();
            dataGridListado.AutoResizeRows();

            dataGridMantenimiento.DataSource = dt;
            dataGridMantenimiento.AutoResizeColumns();
            dataGridMantenimiento.AutoResizeRows();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dataGridListado.DataSource = BuscarClienteNumDocumento.Buscar(txtBuscar.Text);

        }
        private void btnAnular_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            actualizarDt();
            
        }
     

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            insertar = true;
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;


        }
        private void btnBloquear_Click(object sender, EventArgs e)
        {
            EliminarCliente.eliminar(Convert.ToInt32(dataGridMantenimiento.SelectedCells[5].Value));
            actualizarDt();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            editar = true;
            btnEditar.Enabled = false;
            btnNuevo.Enabled = false;
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;

            txtNombre.Text = Convert.ToString(dataGridMantenimiento.SelectedCells[1].Value);
            dateTimePicker.Value = Convert.ToDateTime(dataGridMantenimiento.SelectedCells[3].Value);
            cboDocumentoTipo.Text = Convert.ToString(dataGridMantenimiento.SelectedCells[4].Value);
            txtDocumentoNumero.Text = Convert.ToString(dataGridMantenimiento.SelectedCells[5].Value);
            txtAltura.Text = Convert.ToString(dataGridMantenimiento.SelectedCells[6].Value);
            txtCalle.Text = Convert.ToString(dataGridMantenimiento.SelectedCells[7].Value);
            txtMail.Text = Convert.ToString(dataGridMantenimiento.SelectedCells[8].Value);
            txtTelefono.Text = Convert.ToString(dataGridMantenimiento.SelectedCells[9].Value);
            cboTipoTel.Text = "movil";
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool isAgregable = true;
            if (!EmailValidator.IsValidEmail(txtMail.Text))
            {
                isAgregable = false;
            }
            if (!FullNameValidator.IsValidFullName(txtNombre.Text) || txtNombre.Text == "")
            {
                isAgregable = false;
                cambiosControles.lblStateError(lblRazonState, "Nombre Invalido");
            }
            else
            {
                cambiosControles.lblStateValid(lblRazonState, "Nombre Valido");
            }
            if (!PhoneNumberValidator.IsValidPhoneNumber(txtTelefono.Text) || txtTelefono.Text == "")
            {
                isAgregable = false;
                cambiosControles.lblStateError(lblTelState, "Telefono Invalido");
            }
            else
            {
                cambiosControles.lblStateValid(lblTelState, "Telefono Valido");
            }
            if (!AddressValidator.istValidStreet(txtCalle.Text) || txtCalle.Text == "")
            {
                isAgregable = false;
                cambiosControles.lblStateError(lblCalleState, "Calle Invalida");
            }
            else
            {
                cambiosControles.lblStateValid(lblCalleState, "Calle Valida");
            }
            if (txtAltura.Text == "" || !AddressValidator.IsValidNumber(txtAltura.Text))
            {
                isAgregable = false;
                cambiosControles.lblStateError(lblAlturaState, "Altura Invalida");
            }
            else
            {
                cambiosControles.lblStateValid(lblAlturaState, "Altura Valida");
            }
            if (!DocumentValidator.IsValidCUIL(txtDocumentoNumero.Text) || txtDocumentoNumero.Text == "")
            {
                isAgregable = false;
                cambiosControles.lblStateError(lblDniState, "Documento Invalido");
            }
            else
            {
                cambiosControles.lblStateValid(lblDniState, "Documento Valido");
            }
            if (insertar && isAgregable)
            {
                if (!ValidarCliente.Preguntar(txtDocumentoNumero.Text))
                {
                    cambiosControles.lblStateError(lblDniState, "Documento Existente");
                }
                else
                {
                    if (InsertarCliente.insertar(txtNombre.Text, dateTimePicker.Value, cboDocumentoTipo.Text, txtDocumentoNumero.Text, txtTelefono.Text, txtMail.Text, txtCalle.Text, Convert.ToInt32(txtAltura.Text), cboLocalidad.Text))
                    {
                        actualizarDt();
                        btnNuevo.Enabled = true;
                        btnEditar.Enabled = true;

                        btnGuardar.Enabled = false;
                        btnCancelar.Enabled = false;

                    }
                    else
                    {
                        MessageBox.Show("error al agregar provedor consulte con el administrador del sistema");
                    }
                }
                
            }
            if (editar && isAgregable)
            {
                if (EditarCliente.editar(Convert.ToString(cboLocalidad.Text), txtNombre.Text, dateTimePicker.Value, cboDocumentoTipo.Text, txtDocumentoNumero.Text, Convert.ToInt32(txtAltura.Text), txtCalle.Text, txtTelefono.Text, txtMail.Text))
                {
                    actualizarDt();
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;

                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = false;

                }
                else
                {
                    MessageBox.Show("Error al Guardar");
                }
            }

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            cboDocumentoTipo.Text = "";
            txtDocumentoNumero.Text = "";
            txtCalle.Text = "";
            txtAltura.Text = "";
            txtMail.Text = "";
            txtTelefono.Text = "";

            cboTipoTel.Text = "";

            editar = false;
            insertar = false;
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;

            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {
            if (!EmailValidator.IsValidEmail(txtMail.Text))
            {
                cambiosControles.lblStateError(lblMailState, "Correo Invalido");
            }
            else
            {
                cambiosControles.lblStateValid(lblMailState, "Correo Valido");
            }
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dataGridListado.DataSource = BuscarClienteNumDocumento.Buscar(txtBuscar.Text);
            }
        }
    }
}
