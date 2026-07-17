using System;
using System.Collections.Generic;
using System.ComponentModel;
using comun;
using System.Data;
using logica.sistema;
using System.Windows.Forms;
using logica.sistema.alta;
using logica;
using logica.sistema.modificacion;
using logica.sistema.baja;
using servicios;
using System.Net.Sockets;
using servicios.validaciones;
using System.Drawing;
using Vista.Controles;
using logica.sistema.proveedor;

namespace Vista
{
    public partial class frmProveedores : Form
    {
        string razonAnterior;
        bool editarr = false;
        bool insertar = false;
        public frmProveedores()
        {
            InitializeComponent();

            MostrarLocalidad mostrar = new MostrarLocalidad();
            cboLocalidad.DataSource = mostrar.mostrar();
            cboLocalidad.DisplayMember = "Nombre";
            cboDocumentoTipo.Text = "cuit";
            cboSectorComercial.Text = "Electrodomesticos";
            cboTipoTel.Text = "movil";
           
        }
        private void frmProveedores_Load(object sender, EventArgs e)
        {
            btnCancelar.Enabled = false;
            btnGuardar.Enabled  = false;
            actualizardt();
        }
        private void actualizardt()
        {
            DataTable dt = BuscarProveedorNumDocumento.Buscar("");
             dt.Columns.RemoveAt(0);

            dataGridListado.DataSource = dt;
            dataGridListado.AutoResizeColumns();
            dataGridListado.AutoResizeRows();

            dataGridMantenimiento.DataSource = dt;
            dataGridMantenimiento.AutoResizeColumns();
            dataGridMantenimiento.AutoResizeRows();
                
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            provBuscar();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            insertar = true;
            btnEditar.Enabled = false;
            btnNuevo.Enabled = false;

            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;

        }
        private void btnEditar_Click(object sender, EventArgs e)
        {

            editarr = true;
            btnEditar.Enabled = false;
            btnNuevo.Enabled = false;
            
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
            
            txtRazonSocial.Text = Convert.ToString(dataGridMantenimiento.SelectedCells[0].Value);
            cboSectorComercial.Text = Convert.ToString(dataGridMantenimiento.SelectedCells[1].Value);
            cboDocumentoTipo.Text = Convert.ToString(dataGridMantenimiento.SelectedCells[2].Value);
            txtDocumentoNumero.Text = Convert.ToString(dataGridMantenimiento.SelectedCells[3].Value);
            txtCalle.Text = Convert.ToString(dataGridMantenimiento.SelectedCells[5].Value);
            txtAltura.Text = Convert.ToString(dataGridMantenimiento.SelectedCells[6].Value);
            txtMail.Text = Convert.ToString(dataGridMantenimiento.SelectedCells[8].Value);
            txtTelefono.Text = Convert.ToString(dataGridMantenimiento.SelectedCells[9].Value);


            cboTipoTel.Text = "movil";
            razonAnterior = txtRazonSocial.Text;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool isAgregable = true;
            if (!FullNameValidator.IsValidFullName(txtRazonSocial.Text) || txtRazonSocial.Text == "")
            {
                isAgregable = false;
                cambiosControles.lblStateError(lblRazonState, "Nombre Invalido");
            }
            else
            {
                isAgregable = true;
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
                if (!ValidarProveedor.Preguntar(txtDocumentoNumero.Text))
                {
                    cambiosControles.lblStateError(lblDniState, "Documento Existente");
                }
                else
                {
                    InsertarProveedor agregarProveedor = new InsertarProveedor();
                    if (agregarProveedor.insertar(cboLocalidad.Text, txtRazonSocial.Text, cboSectorComercial.Text, cboDocumentoTipo.Text, txtDocumentoNumero.Text, txtCalle.Text, Convert.ToInt32(txtAltura.Text), txtTelefono.Text, txtMail.Text, cboTipoTel.Text))
                    {
                        actualizardt();
                    }
                    else
                    {
                        MessageBox.Show("error al agregar provedor consulte con el administrador del sistema");
                    }
                }
            }
            if (editarr && isAgregable)
            {
                EditarProveedor editar = new EditarProveedor();
                if (editar.editar(cboLocalidad.Text, razonAnterior, txtRazonSocial.Text, cboSectorComercial.Text, cboDocumentoTipo.Text, txtDocumentoNumero.Text, txtCalle.Text, Convert.ToInt32(txtAltura.Text), txtTelefono.Text, txtMail.Text))
                {
                    actualizardt();
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnBloquear.Enabled = true;

                    btnCancelar.Enabled = false;
                    btnGuardar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("error al actualizar el proveedor");
                }
            }
           
        }
        private void btnBloquear_Click(object sender, EventArgs e)
        {
            EliminarProveedor eliminar = new EliminarProveedor();

            eliminar.eliminar(Convert.ToString(dataGridMantenimiento.SelectedCells[6].Value));
            actualizardt();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtRazonSocial.Text =       "";   
            cboSectorComercial.Text =   "";   
            cboDocumentoTipo.Text =     "";   
            txtDocumentoNumero.Text =   "";
            txtCalle.Text =             "";
            txtAltura.Text =            "";
            txtMail.Text =              "";
            txtTelefono.Text =          "";

            cboTipoTel.Text = "";

            editarr = false;
            insertar = false;
            btnNuevo.Enabled = true;  
            btnEditar.Enabled = true;

            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
        }
        private void btnAnular_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            
            dataGridListado.DataSource = BuscarProveedorNumDocumento.Buscar(txtBuscar.Text);
        }

        private void dataGridMantenimiento_Click(object sender, EventArgs e)
        {
            /*
            // Preguntar a ferrando si quiere cambiar icono con click
            if (Convert.ToBoolean(dataGridMantenimiento.SelectedCells[7].Value))
            {
                //icono desbloquear
                btnBloquear.ImageIndex = 1;
            }
            else
            {
                btnBloquear.ImageIndex = 2;
            }
            */
        }

        public void provBuscar()
        { 
            dataGridListado.DataSource = BuscarProveedorNumDocumento.Buscar(txtBuscar.Text);
        }
        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                provBuscar();
            }
        }

        
    }
}
