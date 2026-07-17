namespace Vista
{
    partial class frmOlvido
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
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPregunta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.lblCancelar = new System.Windows.Forms.Label();
            this.btnObtPregunta = new System.Windows.Forms.Button();
            this.btnEnviarCorreo = new System.Windows.Forms.Button();
            this.lblPreguntaState = new System.Windows.Forms.Label();
            this.lblUsrState = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(25, 44);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(200, 22);
            this.txtUser.TabIndex = 0;
            // 
            // txtPregunta
            // 
            this.txtPregunta.Location = new System.Drawing.Point(25, 121);
            this.txtPregunta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPregunta.Name = "txtPregunta";
            this.txtPregunta.Size = new System.Drawing.Size(310, 22);
            this.txtPregunta.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre de Usuario";
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.lblPregunta.Location = new System.Drawing.Point(25, 101);
            this.lblPregunta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(146, 16);
            this.lblPregunta.TabIndex = 3;
            this.lblPregunta.Text = "Pregunta de Seguridad";
            // 
            // lblCancelar
            // 
            this.lblCancelar.AutoSize = true;
            this.lblCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.lblCancelar.Location = new System.Drawing.Point(21, 187);
            this.lblCancelar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCancelar.Name = "lblCancelar";
            this.lblCancelar.Size = new System.Drawing.Size(61, 16);
            this.lblCancelar.TabIndex = 3;
            this.lblCancelar.Text = "Cancelar";
            // 
            // btnObtPregunta
            // 
            this.btnObtPregunta.Location = new System.Drawing.Point(235, 27);
            this.btnObtPregunta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnObtPregunta.Name = "btnObtPregunta";
            this.btnObtPregunta.Size = new System.Drawing.Size(101, 57);
            this.btnObtPregunta.TabIndex = 4;
            this.btnObtPregunta.Text = "Obtener Pregunta";
            this.btnObtPregunta.UseVisualStyleBackColor = true;
            this.btnObtPregunta.Click += new System.EventHandler(this.btnObtPregunta_Click);
            // 
            // btnEnviarCorreo
            // 
            this.btnEnviarCorreo.Location = new System.Drawing.Point(181, 165);
            this.btnEnviarCorreo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEnviarCorreo.Name = "btnEnviarCorreo";
            this.btnEnviarCorreo.Size = new System.Drawing.Size(155, 59);
            this.btnEnviarCorreo.TabIndex = 5;
            this.btnEnviarCorreo.Text = "Enviar correo con la nueva contraseña";
            this.btnEnviarCorreo.UseVisualStyleBackColor = true;
            this.btnEnviarCorreo.Click += new System.EventHandler(this.btnEnviarCorreo_Click);
            // 
            // lblPreguntaState
            // 
            this.lblPreguntaState.AutoSize = true;
            this.lblPreguntaState.ForeColor = System.Drawing.Color.Red;
            this.lblPreguntaState.Location = new System.Drawing.Point(25, 149);
            this.lblPreguntaState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPreguntaState.Name = "lblPreguntaState";
            this.lblPreguntaState.Size = new System.Drawing.Size(135, 16);
            this.lblPreguntaState.TabIndex = 6;
            this.lblPreguntaState.Text = "Respuesta incorrecta";
            this.lblPreguntaState.Visible = false;
            // 
            // lblUsrState
            // 
            this.lblUsrState.AutoSize = true;
            this.lblUsrState.ForeColor = System.Drawing.Color.Red;
            this.lblUsrState.Location = new System.Drawing.Point(25, 73);
            this.lblUsrState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsrState.Name = "lblUsrState";
            this.lblUsrState.Size = new System.Drawing.Size(120, 16);
            this.lblUsrState.TabIndex = 7;
            this.lblUsrState.Text = "Usuario Inexistente";
            this.lblUsrState.Visible = false;
            // 
            // frmOlvido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(370, 236);
            this.Controls.Add(this.lblUsrState);
            this.Controls.Add(this.lblPreguntaState);
            this.Controls.Add(this.btnEnviarCorreo);
            this.Controls.Add(this.btnObtPregunta);
            this.Controls.Add(this.lblCancelar);
            this.Controls.Add(this.lblPregunta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPregunta);
            this.Controls.Add(this.txtUser);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmOlvido";
            this.Text = "7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPregunta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.Label lblCancelar;
        private System.Windows.Forms.Button btnObtPregunta;
        private System.Windows.Forms.Button btnEnviarCorreo;
        private System.Windows.Forms.Label lblPreguntaState;
        private System.Windows.Forms.Label lblUsrState;
    }
}