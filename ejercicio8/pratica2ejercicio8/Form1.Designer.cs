namespace pratica2ejercicio8
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
            this.textOracion = new System.Windows.Forms.TextBox();
            this.btnContarPalabras = new System.Windows.Forms.Button();
            this.LblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textOracion
            // 
            this.textOracion.Location = new System.Drawing.Point(541, 78);
            this.textOracion.Name = "textOracion";
            this.textOracion.Size = new System.Drawing.Size(100, 20);
            this.textOracion.TabIndex = 0;
            // 
            // btnContarPalabras
            // 
            this.btnContarPalabras.Location = new System.Drawing.Point(343, 78);
            this.btnContarPalabras.Name = "btnContarPalabras";
            this.btnContarPalabras.Size = new System.Drawing.Size(75, 23);
            this.btnContarPalabras.TabIndex = 1;
            this.btnContarPalabras.Text = "contar";
            this.btnContarPalabras.UseVisualStyleBackColor = true;
            this.btnContarPalabras.Click += new System.EventHandler(this.btnContarPalabras_Click);
            // 
            // LblResultado
            // 
            this.LblResultado.AutoSize = true;
            this.LblResultado.Location = new System.Drawing.Point(382, 246);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(35, 13);
            this.LblResultado.TabIndex = 2;
            this.LblResultado.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.btnContarPalabras);
            this.Controls.Add(this.textOracion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textOracion;
        private System.Windows.Forms.Button btnContarPalabras;
        private System.Windows.Forms.Label LblResultado;
    }
}

