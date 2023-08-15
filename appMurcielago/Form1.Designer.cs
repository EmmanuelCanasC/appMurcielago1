namespace appMurcielago
{
    partial class Form1
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
            this.lblResultado = new System.Windows.Forms.Label();
            this.MensajeTextBox = new System.Windows.Forms.TextBox();
            this.btnCifrar = new System.Windows.Forms.Button();
            this.btnDescifrar = new System.Windows.Forms.Button();
            this.MensajeCifradoTextBox = new System.Windows.Forms.TextBox();
            this.MensajeDescifradoTextBox = new System.Windows.Forms.TextBox();
            this.lblDescifrado = new System.Windows.Forms.Label();
            this.lblCifrado = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(163, 90);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 0;
            // 
            // MensajeTextBox
            // 
            this.MensajeTextBox.Location = new System.Drawing.Point(141, 49);
            this.MensajeTextBox.Name = "MensajeTextBox";
            this.MensajeTextBox.Size = new System.Drawing.Size(100, 20);
            this.MensajeTextBox.TabIndex = 1;
            // 
            // btnCifrar
            // 
            this.btnCifrar.Location = new System.Drawing.Point(49, 171);
            this.btnCifrar.Name = "btnCifrar";
            this.btnCifrar.Size = new System.Drawing.Size(75, 23);
            this.btnCifrar.TabIndex = 2;
            this.btnCifrar.Text = "Cifrar";
            this.btnCifrar.UseVisualStyleBackColor = true;
            this.btnCifrar.Click += new System.EventHandler(this.btnCifrar_Click);
            // 
            // btnDescifrar
            // 
            this.btnDescifrar.Location = new System.Drawing.Point(245, 171);
            this.btnDescifrar.Name = "btnDescifrar";
            this.btnDescifrar.Size = new System.Drawing.Size(75, 23);
            this.btnDescifrar.TabIndex = 3;
            this.btnDescifrar.Text = "Descifrar";
            this.btnDescifrar.UseVisualStyleBackColor = true;
            this.btnDescifrar.Click += new System.EventHandler(this.btnDescifrar_Click);
            // 
            // MensajeCifradoTextBox
            // 
            this.MensajeCifradoTextBox.Location = new System.Drawing.Point(141, 83);
            this.MensajeCifradoTextBox.Name = "MensajeCifradoTextBox";
            this.MensajeCifradoTextBox.Size = new System.Drawing.Size(100, 20);
            this.MensajeCifradoTextBox.TabIndex = 4;
            // 
            // MensajeDescifradoTextBox
            // 
            this.MensajeDescifradoTextBox.Location = new System.Drawing.Point(141, 121);
            this.MensajeDescifradoTextBox.Name = "MensajeDescifradoTextBox";
            this.MensajeDescifradoTextBox.Size = new System.Drawing.Size(100, 20);
            this.MensajeDescifradoTextBox.TabIndex = 5;
            // 
            // lblDescifrado
            // 
            this.lblDescifrado.AutoSize = true;
            this.lblDescifrado.Location = new System.Drawing.Point(75, 121);
            this.lblDescifrado.Name = "lblDescifrado";
            this.lblDescifrado.Size = new System.Drawing.Size(58, 13);
            this.lblDescifrado.TabIndex = 6;
            this.lblDescifrado.Text = "Descifrado";
            // 
            // lblCifrado
            // 
            this.lblCifrado.AutoSize = true;
            this.lblCifrado.Location = new System.Drawing.Point(75, 83);
            this.lblCifrado.Name = "lblCifrado";
            this.lblCifrado.Size = new System.Drawing.Size(40, 13);
            this.lblCifrado.TabIndex = 7;
            this.lblCifrado.Text = "Cifrado";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(75, 49);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(47, 13);
            this.lblMensaje.TabIndex = 8;
            this.lblMensaje.Text = "Mensaje";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 221);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.lblCifrado);
            this.Controls.Add(this.lblDescifrado);
            this.Controls.Add(this.MensajeDescifradoTextBox);
            this.Controls.Add(this.MensajeCifradoTextBox);
            this.Controls.Add(this.btnDescifrar);
            this.Controls.Add(this.btnCifrar);
            this.Controls.Add(this.MensajeTextBox);
            this.Controls.Add(this.lblResultado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox MensajeTextBox;
        private System.Windows.Forms.Button btnCifrar;
        private System.Windows.Forms.Button btnDescifrar;
        private System.Windows.Forms.TextBox MensajeCifradoTextBox;
        private System.Windows.Forms.TextBox MensajeDescifradoTextBox;
        private System.Windows.Forms.Label lblDescifrado;
        private System.Windows.Forms.Label lblCifrado;
        private System.Windows.Forms.Label lblMensaje;
    }
}

