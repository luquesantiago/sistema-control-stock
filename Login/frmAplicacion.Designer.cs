namespace Login
{
    partial class frmAplicacion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAplicacion));
            this.sidePanel = new System.Windows.Forms.Panel();
            this.lblCompras = new System.Windows.Forms.Label();
            this.lblClientes = new System.Windows.Forms.Label();
            this.lblProveedores = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdministrador = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblVentas = new System.Windows.Forms.Label();
            this.lblCategorias = new System.Windows.Forms.Label();
            this.lblOrdenCompras = new System.Windows.Forms.Label();
            this.lblArticulos = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.panelWorkspace = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(24)))), ((int)(((byte)(85)))));
            this.sidePanel.Controls.Add(this.lblCompras);
            this.sidePanel.Controls.Add(this.lblClientes);
            this.sidePanel.Controls.Add(this.lblProveedores);
            this.sidePanel.Controls.Add(this.lblCargo);
            this.sidePanel.Controls.Add(this.label2);
            this.sidePanel.Controls.Add(this.btnAdministrador);
            this.sidePanel.Controls.Add(this.btnLogOut);
            this.sidePanel.Controls.Add(this.lblFecha);
            this.sidePanel.Controls.Add(this.lblVentas);
            this.sidePanel.Controls.Add(this.lblCategorias);
            this.sidePanel.Controls.Add(this.lblOrdenCompras);
            this.sidePanel.Controls.Add(this.lblArticulos);
            this.sidePanel.Controls.Add(this.pictureBox2);
            this.sidePanel.Controls.Add(this.lblUserName);
            this.sidePanel.Location = new System.Drawing.Point(0, 28);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(4);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(209, 730);
            this.sidePanel.TabIndex = 2;
            // 
            // lblCompras
            // 
            this.lblCompras.AutoSize = true;
            this.lblCompras.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.lblCompras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.lblCompras.Image = ((System.Drawing.Image)(resources.GetObject("lblCompras.Image")));
            this.lblCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCompras.Location = new System.Drawing.Point(9, 172);
            this.lblCompras.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompras.Name = "lblCompras";
            this.lblCompras.Size = new System.Drawing.Size(108, 23);
            this.lblCompras.TabIndex = 19;
            this.lblCompras.Text = "      &Compras";
            this.lblCompras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCompras.Visible = false;
            this.lblCompras.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.lblClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.lblClientes.Image = ((System.Drawing.Image)(resources.GetObject("lblClientes.Image")));
            this.lblClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblClientes.Location = new System.Drawing.Point(9, 322);
            this.lblClientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(100, 23);
            this.lblClientes.TabIndex = 7;
            this.lblClientes.Text = "      &Clientes";
            this.lblClientes.Visible = false;
            this.lblClientes.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblProveedores
            // 
            this.lblProveedores.AutoSize = true;
            this.lblProveedores.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.lblProveedores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.lblProveedores.Image = ((System.Drawing.Image)(resources.GetObject("lblProveedores.Image")));
            this.lblProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblProveedores.Location = new System.Drawing.Point(9, 292);
            this.lblProveedores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProveedores.Name = "lblProveedores";
            this.lblProveedores.Size = new System.Drawing.Size(134, 23);
            this.lblProveedores.TabIndex = 6;
            this.lblProveedores.Text = "      &Proveedores";
            this.lblProveedores.Visible = false;
            this.lblProveedores.Click += new System.EventHandler(this.lblProveedores_Click);
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.lblCargo.Location = new System.Drawing.Point(56, 46);
            this.lblCargo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(75, 16);
            this.lblCargo.TabIndex = 16;
            this.lblCargo.Text = "Cargo / Rol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.label2.Location = new System.Drawing.Point(13, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mantenimiento";
            // 
            // btnAdministrador
            // 
            this.btnAdministrador.Enabled = false;
            this.btnAdministrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministrador.Image = ((System.Drawing.Image)(resources.GetObject("btnAdministrador.Image")));
            this.btnAdministrador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdministrador.Location = new System.Drawing.Point(60, 687);
            this.btnAdministrador.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdministrador.Name = "btnAdministrador";
            this.btnAdministrador.Size = new System.Drawing.Size(128, 34);
            this.btnAdministrador.TabIndex = 8;
            this.btnAdministrador.Text = " &Administrador";
            this.btnAdministrador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdministrador.UseVisualStyleBackColor = true;
            this.btnAdministrador.Visible = false;
            this.btnAdministrador.Click += new System.EventHandler(this.btnAdministrador_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.Location = new System.Drawing.Point(11, 687);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(41, 34);
            this.btnLogOut.TabIndex = 9;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.lblFecha.Location = new System.Drawing.Point(15, 74);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(140, 16);
            this.lblFecha.TabIndex = 13;
            this.lblFecha.Text = "00 / 00 / 0000 | 00:00:00";
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.lblVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.lblVentas.Image = ((System.Drawing.Image)(resources.GetObject("lblVentas.Image")));
            this.lblVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblVentas.Location = new System.Drawing.Point(9, 202);
            this.lblVentas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(91, 23);
            this.lblVentas.TabIndex = 3;
            this.lblVentas.Text = "      &Ventas";
            this.lblVentas.Visible = false;
            this.lblVentas.Click += new System.EventHandler(this.lblVentas_Click);
            // 
            // lblCategorias
            // 
            this.lblCategorias.AutoSize = true;
            this.lblCategorias.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.lblCategorias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.lblCategorias.Image = ((System.Drawing.Image)(resources.GetObject("lblCategorias.Image")));
            this.lblCategorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCategorias.Location = new System.Drawing.Point(9, 262);
            this.lblCategorias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategorias.Name = "lblCategorias";
            this.lblCategorias.Size = new System.Drawing.Size(114, 23);
            this.lblCategorias.TabIndex = 5;
            this.lblCategorias.Text = "      &Categoria";
            this.lblCategorias.Visible = false;
            this.lblCategorias.Click += new System.EventHandler(this.lblConsulReportes_Click);
            // 
            // lblOrdenCompras
            // 
            this.lblOrdenCompras.AutoSize = true;
            this.lblOrdenCompras.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.lblOrdenCompras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.lblOrdenCompras.Image = ((System.Drawing.Image)(resources.GetObject("lblOrdenCompras.Image")));
            this.lblOrdenCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblOrdenCompras.Location = new System.Drawing.Point(9, 142);
            this.lblOrdenCompras.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrdenCompras.Name = "lblOrdenCompras";
            this.lblOrdenCompras.Size = new System.Drawing.Size(185, 23);
            this.lblOrdenCompras.TabIndex = 1;
            this.lblOrdenCompras.Text = "      &Orden de Compras";
            this.lblOrdenCompras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblOrdenCompras.Visible = false;
            this.lblOrdenCompras.Click += new System.EventHandler(this.lblCompras_Click);
            // 
            // lblArticulos
            // 
            this.lblArticulos.AutoSize = true;
            this.lblArticulos.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.lblArticulos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.lblArticulos.Image = ((System.Drawing.Image)(resources.GetObject("lblArticulos.Image")));
            this.lblArticulos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblArticulos.Location = new System.Drawing.Point(9, 232);
            this.lblArticulos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArticulos.Name = "lblArticulos";
            this.lblArticulos.Size = new System.Drawing.Size(106, 23);
            this.lblArticulos.TabIndex = 4;
            this.lblArticulos.Text = "      &Articulos";
            this.lblArticulos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblArticulos.Visible = false;
            this.lblArticulos.Click += new System.EventHandler(this.lblAlmacen_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(8, 9);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.lblUserName.Location = new System.Drawing.Point(53, 9);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(115, 31);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Usuario";
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(19)))), ((int)(((byte)(72)))));
            this.TopPanel.Controls.Add(this.lblTitulo);
            this.TopPanel.Controls.Add(this.btnCerrar);
            this.TopPanel.Controls.Add(this.btnMinimizar);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(4);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1480, 30);
            this.TopPanel.TabIndex = 13;
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(719, 6);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(38, 16);
            this.lblTitulo.TabIndex = 14;
            this.lblTitulo.Text = "Inicio";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1448, 4);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(28, 18);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_1);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1413, 4);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(28, 18);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // panelWorkspace
            // 
            this.panelWorkspace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelWorkspace.Location = new System.Drawing.Point(222, 41);
            this.panelWorkspace.Margin = new System.Windows.Forms.Padding(4);
            this.panelWorkspace.Name = "panelWorkspace";
            this.panelWorkspace.Size = new System.Drawing.Size(1247, 708);
            this.panelWorkspace.TabIndex = 14;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmAplicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1480, 757);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.panelWorkspace);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAplicacion";
            this.Text = "Aplicacon";
            this.Load += new System.EventHandler(this.frmAplicacion_Load);
            this.sidePanel.ResumeLayout(false);
            this.sidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.Label lblCategorias;
        private System.Windows.Forms.Label lblOrdenCompras;
        private System.Windows.Forms.Label lblArticulos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Panel panelWorkspace;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAdministrador;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblProveedores;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Label lblCompras;
    }
}

