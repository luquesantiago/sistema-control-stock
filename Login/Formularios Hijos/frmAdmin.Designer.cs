namespace Vista
{
    partial class frmAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxUser = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cboUserBloq = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateCaducidad = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cboRoles = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.groupBoxCFG = new System.Windows.Forms.GroupBox();
            this.cboRepeat = new System.Windows.Forms.CheckBox();
            this.cbo2FA = new System.Windows.Forms.CheckBox();
            this.cboSpecChar = new System.Windows.Forms.CheckBox();
            this.cboCaps = new System.Windows.Forms.CheckBox();
            this.cboMinChar = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxGridControls = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.groupBoxUserButtons = new System.Windows.Forms.GroupBox();
            this.btnCancelarUser = new System.Windows.Forms.Button();
            this.btnGuardarUser = new System.Windows.Forms.Button();
            this.groupBoxCFGButtons = new System.Windows.Forms.GroupBox();
            this.btnCancelarCFG = new System.Windows.Forms.Button();
            this.btnGuardarCFG = new System.Windows.Forms.Button();
            this.groupBoxUser.SuspendLayout();
            this.groupBoxCFG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxGridControls.SuspendLayout();
            this.groupBoxUserButtons.SuspendLayout();
            this.groupBoxCFGButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(529, 91);
            this.label1.TabIndex = 1;
            this.label1.Text = "Administrador";
            // 
            // groupBoxUser
            // 
            this.groupBoxUser.Controls.Add(this.lblNombre);
            this.groupBoxUser.Controls.Add(this.cboUserBloq);
            this.groupBoxUser.Controls.Add(this.label5);
            this.groupBoxUser.Controls.Add(this.dateCaducidad);
            this.groupBoxUser.Controls.Add(this.label4);
            this.groupBoxUser.Controls.Add(this.cboRoles);
            this.groupBoxUser.Controls.Add(this.label3);
            this.groupBoxUser.Controls.Add(this.label2);
            this.groupBoxUser.Controls.Add(this.txtPass);
            this.groupBoxUser.Controls.Add(this.txtUserName);
            this.groupBoxUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.groupBoxUser.Location = new System.Drawing.Point(533, 118);
            this.groupBoxUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxUser.Name = "groupBoxUser";
            this.groupBoxUser.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxUser.Size = new System.Drawing.Size(331, 335);
            this.groupBoxUser.TabIndex = 3;
            this.groupBoxUser.TabStop = false;
            this.groupBoxUser.Text = "Configurar Usuarios";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(40, 34);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Nombre";
            // 
            // cboUserBloq
            // 
            this.cboUserBloq.AutoSize = true;
            this.cboUserBloq.Location = new System.Drawing.Point(44, 290);
            this.cboUserBloq.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboUserBloq.Name = "cboUserBloq";
            this.cboUserBloq.Size = new System.Drawing.Size(96, 20);
            this.cboUserBloq.TabIndex = 5;
            this.cboUserBloq.Text = "Bloqueado";
            this.cboUserBloq.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 239);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Fecha de Caducidad";
            // 
            // dateCaducidad
            // 
            this.dateCaducidad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateCaducidad.Location = new System.Drawing.Point(44, 258);
            this.dateCaducidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateCaducidad.Name = "dateCaducidad";
            this.dateCaducidad.Size = new System.Drawing.Size(125, 22);
            this.dateCaducidad.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Roles";
            // 
            // cboRoles
            // 
            this.cboRoles.FormattingEnabled = true;
            this.cboRoles.Items.AddRange(new object[] {
            "persona",
            "empleado1",
            "empleado2",
            "admin"});
            this.cboRoles.Location = new System.Drawing.Point(44, 196);
            this.cboRoles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboRoles.Name = "cboRoles";
            this.cboRoles.Size = new System.Drawing.Size(230, 24);
            this.cboRoles.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre de Usuario";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(44, 134);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(230, 22);
            this.txtPass.TabIndex = 2;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(44, 76);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(230, 22);
            this.txtUserName.TabIndex = 1;
            // 
            // groupBoxCFG
            // 
            this.groupBoxCFG.Controls.Add(this.cboRepeat);
            this.groupBoxCFG.Controls.Add(this.cbo2FA);
            this.groupBoxCFG.Controls.Add(this.cboSpecChar);
            this.groupBoxCFG.Controls.Add(this.cboCaps);
            this.groupBoxCFG.Controls.Add(this.cboMinChar);
            this.groupBoxCFG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.groupBoxCFG.Location = new System.Drawing.Point(899, 118);
            this.groupBoxCFG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxCFG.Name = "groupBoxCFG";
            this.groupBoxCFG.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxCFG.Size = new System.Drawing.Size(331, 181);
            this.groupBoxCFG.TabIndex = 5;
            this.groupBoxCFG.TabStop = false;
            this.groupBoxCFG.Text = "Configurar Sistema";
            // 
            // cboRepeat
            // 
            this.cboRepeat.AutoSize = true;
            this.cboRepeat.Location = new System.Drawing.Point(21, 144);
            this.cboRepeat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboRepeat.Name = "cboRepeat";
            this.cboRepeat.Size = new System.Drawing.Size(152, 20);
            this.cboRepeat.TabIndex = 5;
            this.cboRepeat.Text = "Repetir Contraseñas";
            this.cboRepeat.UseVisualStyleBackColor = true;
            // 
            // cbo2FA
            // 
            this.cbo2FA.AutoSize = true;
            this.cbo2FA.Location = new System.Drawing.Point(21, 116);
            this.cbo2FA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbo2FA.Name = "cbo2FA";
            this.cbo2FA.Size = new System.Drawing.Size(185, 20);
            this.cbo2FA.TabIndex = 4;
            this.cbo2FA.Text = "Autentificacion en 2 Pasos";
            this.cbo2FA.UseVisualStyleBackColor = true;
            // 
            // cboSpecChar
            // 
            this.cboSpecChar.AutoSize = true;
            this.cboSpecChar.Location = new System.Drawing.Point(21, 87);
            this.cboSpecChar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboSpecChar.Name = "cboSpecChar";
            this.cboSpecChar.Size = new System.Drawing.Size(165, 20);
            this.cboSpecChar.TabIndex = 3;
            this.cboSpecChar.Text = "Caracteres especiales";
            this.cboSpecChar.UseVisualStyleBackColor = true;
            // 
            // cboCaps
            // 
            this.cboCaps.AutoSize = true;
            this.cboCaps.Location = new System.Drawing.Point(21, 59);
            this.cboCaps.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboCaps.Name = "cboCaps";
            this.cboCaps.Size = new System.Drawing.Size(181, 20);
            this.cboCaps.TabIndex = 2;
            this.cboCaps.Text = "Mayusculas y Minusculas";
            this.cboCaps.UseVisualStyleBackColor = true;
            // 
            // cboMinChar
            // 
            this.cboMinChar.AutoSize = true;
            this.cboMinChar.Location = new System.Drawing.Point(21, 30);
            this.cboMinChar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboMinChar.Name = "cboMinChar";
            this.cboMinChar.Size = new System.Drawing.Size(160, 20);
            this.cboMinChar.TabIndex = 1;
            this.cboMinChar.Text = "Minimo de Caracteres";
            this.cboMinChar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 118);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(483, 498);
            this.dataGridView1.TabIndex = 1;
            // 
            // groupBoxGridControls
            // 
            this.groupBoxGridControls.Controls.Add(this.btnEditar);
            this.groupBoxGridControls.Location = new System.Drawing.Point(187, 620);
            this.groupBoxGridControls.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxGridControls.Name = "groupBoxGridControls";
            this.groupBoxGridControls.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxGridControls.Size = new System.Drawing.Size(137, 74);
            this.groupBoxGridControls.TabIndex = 2;
            this.groupBoxGridControls.TabStop = false;
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(7, 16);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(122, 50);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // groupBoxUserButtons
            // 
            this.groupBoxUserButtons.Controls.Add(this.btnCancelarUser);
            this.groupBoxUserButtons.Controls.Add(this.btnGuardarUser);
            this.groupBoxUserButtons.Location = new System.Drawing.Point(620, 462);
            this.groupBoxUserButtons.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxUserButtons.Name = "groupBoxUserButtons";
            this.groupBoxUserButtons.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxUserButtons.Size = new System.Drawing.Size(157, 74);
            this.groupBoxUserButtons.TabIndex = 4;
            this.groupBoxUserButtons.TabStop = false;
            // 
            // btnCancelarUser
            // 
            this.btnCancelarUser.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarUser.Image")));
            this.btnCancelarUser.Location = new System.Drawing.Point(93, 14);
            this.btnCancelarUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelarUser.Name = "btnCancelarUser";
            this.btnCancelarUser.Size = new System.Drawing.Size(53, 50);
            this.btnCancelarUser.TabIndex = 2;
            this.btnCancelarUser.UseVisualStyleBackColor = true;
            this.btnCancelarUser.Click += new System.EventHandler(this.btnCancelarUser_Click);
            // 
            // btnGuardarUser
            // 
            this.btnGuardarUser.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarUser.Image")));
            this.btnGuardarUser.Location = new System.Drawing.Point(8, 14);
            this.btnGuardarUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardarUser.Name = "btnGuardarUser";
            this.btnGuardarUser.Size = new System.Drawing.Size(53, 50);
            this.btnGuardarUser.TabIndex = 1;
            this.btnGuardarUser.UseVisualStyleBackColor = true;
            this.btnGuardarUser.Click += new System.EventHandler(this.btnGuardarUser_Click);
            // 
            // groupBoxCFGButtons
            // 
            this.groupBoxCFGButtons.Controls.Add(this.btnCancelarCFG);
            this.groupBoxCFGButtons.Controls.Add(this.btnGuardarCFG);
            this.groupBoxCFGButtons.Location = new System.Drawing.Point(985, 302);
            this.groupBoxCFGButtons.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxCFGButtons.Name = "groupBoxCFGButtons";
            this.groupBoxCFGButtons.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxCFGButtons.Size = new System.Drawing.Size(157, 74);
            this.groupBoxCFGButtons.TabIndex = 6;
            this.groupBoxCFGButtons.TabStop = false;
            // 
            // btnCancelarCFG
            // 
            this.btnCancelarCFG.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarCFG.Image")));
            this.btnCancelarCFG.Location = new System.Drawing.Point(93, 14);
            this.btnCancelarCFG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelarCFG.Name = "btnCancelarCFG";
            this.btnCancelarCFG.Size = new System.Drawing.Size(53, 50);
            this.btnCancelarCFG.TabIndex = 2;
            this.btnCancelarCFG.UseVisualStyleBackColor = true;
            this.btnCancelarCFG.Click += new System.EventHandler(this.btnCancelarCFG_Click);
            // 
            // btnGuardarCFG
            // 
            this.btnGuardarCFG.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarCFG.Image")));
            this.btnGuardarCFG.Location = new System.Drawing.Point(8, 14);
            this.btnGuardarCFG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardarCFG.Name = "btnGuardarCFG";
            this.btnGuardarCFG.Size = new System.Drawing.Size(53, 50);
            this.btnGuardarCFG.TabIndex = 1;
            this.btnGuardarCFG.UseVisualStyleBackColor = true;
            this.btnGuardarCFG.Click += new System.EventHandler(this.btnGuardarCFG_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1246, 708);
            this.Controls.Add(this.groupBoxCFGButtons);
            this.Controls.Add(this.groupBoxUserButtons);
            this.Controls.Add(this.groupBoxGridControls);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBoxCFG);
            this.Controls.Add(this.groupBoxUser);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAdmin";
            this.Text = "Panel de Administrador";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.groupBoxUser.ResumeLayout(false);
            this.groupBoxUser.PerformLayout();
            this.groupBoxCFG.ResumeLayout(false);
            this.groupBoxCFG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxGridControls.ResumeLayout(false);
            this.groupBoxUserButtons.ResumeLayout(false);
            this.groupBoxCFGButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxUser;
        private System.Windows.Forms.GroupBox groupBoxCFG;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBoxGridControls;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.DateTimePicker dateCaducidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboRoles;
        private System.Windows.Forms.CheckBox cboRepeat;
        private System.Windows.Forms.CheckBox cbo2FA;
        private System.Windows.Forms.CheckBox cboSpecChar;
        private System.Windows.Forms.CheckBox cboCaps;
        private System.Windows.Forms.CheckBox cboMinChar;
        private System.Windows.Forms.CheckBox cboUserBloq;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxUserButtons;
        private System.Windows.Forms.Button btnCancelarUser;
        private System.Windows.Forms.Button btnGuardarUser;
        private System.Windows.Forms.GroupBox groupBoxCFGButtons;
        private System.Windows.Forms.Button btnCancelarCFG;
        private System.Windows.Forms.Button btnGuardarCFG;
        private System.Windows.Forms.Label lblNombre;
    }
}