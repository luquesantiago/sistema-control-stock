namespace Vista
{
    partial class frmPregunta
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
            this.lblRespState = new System.Windows.Forms.Label();
            this.txtPregunta = new System.Windows.Forms.TextBox();
            this.txtRespuesta = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblPreguntaState = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.label1.Location = new System.Drawing.Point(47, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pregunta de Seguridad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.label2.Location = new System.Drawing.Point(43, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Respuesta";
            // 
            // lblRespState
            // 
            this.lblRespState.AutoSize = true;
            this.lblRespState.ForeColor = System.Drawing.Color.Red;
            this.lblRespState.Location = new System.Drawing.Point(145, 151);
            this.lblRespState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRespState.Name = "lblRespState";
            this.lblRespState.Size = new System.Drawing.Size(36, 16);
            this.lblRespState.TabIndex = 2;
            this.lblRespState.Text = "Error";
            this.lblRespState.Visible = false;
            // 
            // txtPregunta
            // 
            this.txtPregunta.Location = new System.Drawing.Point(47, 48);
            this.txtPregunta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPregunta.Name = "txtPregunta";
            this.txtPregunta.Size = new System.Drawing.Size(252, 22);
            this.txtPregunta.TabIndex = 3;
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.Location = new System.Drawing.Point(47, 123);
            this.txtRespuesta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.Size = new System.Drawing.Size(252, 22);
            this.txtRespuesta.TabIndex = 4;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(121, 178);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(100, 28);
            this.btnConfirmar.TabIndex = 5;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblPreguntaState
            // 
            this.lblPreguntaState.AutoSize = true;
            this.lblPreguntaState.ForeColor = System.Drawing.Color.Red;
            this.lblPreguntaState.Location = new System.Drawing.Point(145, 76);
            this.lblPreguntaState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPreguntaState.Name = "lblPreguntaState";
            this.lblPreguntaState.Size = new System.Drawing.Size(36, 16);
            this.lblPreguntaState.TabIndex = 6;
            this.lblPreguntaState.Text = "Error";
            this.lblPreguntaState.Visible = false;
            // 
            // frmPregunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(344, 238);
            this.Controls.Add(this.lblPreguntaState);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtRespuesta);
            this.Controls.Add(this.txtPregunta);
            this.Controls.Add(this.lblRespState);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPregunta";
            this.Text = "Pregunta de Seguridad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRespState;
        private System.Windows.Forms.TextBox txtPregunta;
        private System.Windows.Forms.TextBox txtRespuesta;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblPreguntaState;
    }
}