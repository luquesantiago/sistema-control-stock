namespace Vista
{
    partial class frmCambioContr
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblActualState = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblContraNuevaState = new System.Windows.Forms.Label();
            this.lblMatchError = new System.Windows.Forms.Label();
            this.txtContraActual = new System.Windows.Forms.TextBox();
            this.txtContraNueva = new System.Windows.Forms.TextBox();
            this.txtRepetirNueva = new System.Windows.Forms.TextBox();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.label1.Location = new System.Drawing.Point(129, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cambio de Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.label2.Location = new System.Drawing.Point(144, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña Actual";
            // 
            // lblActualState
            // 
            this.lblActualState.AutoSize = true;
            this.lblActualState.ForeColor = System.Drawing.Color.Red;
            this.lblActualState.Location = new System.Drawing.Point(194, 120);
            this.lblActualState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActualState.Name = "lblActualState";
            this.lblActualState.Size = new System.Drawing.Size(44, 20);
            this.lblActualState.TabIndex = 2;
            this.lblActualState.Text = "Error";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.label4.Location = new System.Drawing.Point(144, 166);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contraseña Nueva";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.label5.Location = new System.Drawing.Point(114, 257);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Repetir Contraseña Nueva";
            // 
            // lblContraNuevaState
            // 
            this.lblContraNuevaState.AutoSize = true;
            this.lblContraNuevaState.ForeColor = System.Drawing.Color.Red;
            this.lblContraNuevaState.Location = new System.Drawing.Point(194, 317);
            this.lblContraNuevaState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContraNuevaState.Name = "lblContraNuevaState";
            this.lblContraNuevaState.Size = new System.Drawing.Size(44, 20);
            this.lblContraNuevaState.TabIndex = 5;
            this.lblContraNuevaState.Text = "Error";
            // 
            // lblMatchError
            // 
            this.lblMatchError.AutoSize = true;
            this.lblMatchError.ForeColor = System.Drawing.Color.Red;
            this.lblMatchError.Location = new System.Drawing.Point(56, 412);
            this.lblMatchError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatchError.Name = "lblMatchError";
            this.lblMatchError.Size = new System.Drawing.Size(318, 20);
            this.lblMatchError.TabIndex = 6;
            this.lblMatchError.Text = "La contraseña no cumple con los requisitos!";
            // 
            // txtContraActual
            // 
            this.txtContraActual.Location = new System.Drawing.Point(117, 85);
            this.txtContraActual.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtContraActual.Name = "txtContraActual";
            this.txtContraActual.Size = new System.Drawing.Size(193, 26);
            this.txtContraActual.TabIndex = 7;
            // 
            // txtContraNueva
            // 
            this.txtContraNueva.Location = new System.Drawing.Point(118, 191);
            this.txtContraNueva.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtContraNueva.Name = "txtContraNueva";
            this.txtContraNueva.Size = new System.Drawing.Size(193, 26);
            this.txtContraNueva.TabIndex = 8;
            // 
            // txtRepetirNueva
            // 
            this.txtRepetirNueva.Location = new System.Drawing.Point(116, 282);
            this.txtRepetirNueva.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRepetirNueva.Name = "txtRepetirNueva";
            this.txtRepetirNueva.Size = new System.Drawing.Size(193, 26);
            this.txtRepetirNueva.TabIndex = 9;
            // 
            // btnCambiar
            // 
            this.btnCambiar.Location = new System.Drawing.Point(134, 372);
            this.btnCambiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(165, 35);
            this.btnCambiar.TabIndex = 10;
            this.btnCambiar.Text = "Cambiar Contraseña";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // frmCambioContr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(440, 452);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.txtRepetirNueva);
            this.Controls.Add(this.txtContraNueva);
            this.Controls.Add(this.txtContraActual);
            this.Controls.Add(this.lblMatchError);
            this.Controls.Add(this.lblContraNuevaState);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblActualState);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCambioContr";
            this.Text = "Cambiar Contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblActualState;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblContraNuevaState;
        private System.Windows.Forms.Label lblMatchError;
        private System.Windows.Forms.TextBox txtContraActual;
        private System.Windows.Forms.TextBox txtContraNueva;
        private System.Windows.Forms.TextBox txtRepetirNueva;
        private System.Windows.Forms.Button btnCambiar;
    }
}