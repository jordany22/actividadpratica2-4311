namespace pratica2_ejercicio__3
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
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.cmbEntrada = new System.Windows.Forms.ComboBox();
            this.cmbSalida = new System.Windows.Forms.ComboBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.lblresultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(563, 63);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(100, 20);
            this.txtcantidad.TabIndex = 0;
            // 
            // cmbEntrada
            // 
            this.cmbEntrada.FormattingEnabled = true;
            this.cmbEntrada.Items.AddRange(new object[] {
            "Metros",
            "Centimetros",
            "Pulgadas"});
            this.cmbEntrada.Location = new System.Drawing.Point(91, 61);
            this.cmbEntrada.Name = "cmbEntrada";
            this.cmbEntrada.Size = new System.Drawing.Size(121, 21);
            this.cmbEntrada.TabIndex = 1;
            // 
            // cmbSalida
            // 
            this.cmbSalida.FormattingEnabled = true;
            this.cmbSalida.Items.AddRange(new object[] {
            "Metros",
            "Centimetros",
            "Pulgadas"});
            this.cmbSalida.Location = new System.Drawing.Point(348, 63);
            this.cmbSalida.Name = "cmbSalida";
            this.cmbSalida.Size = new System.Drawing.Size(121, 21);
            this.cmbSalida.TabIndex = 2;
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(585, 261);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(75, 23);
            this.btnConvertir.TabIndex = 3;
            this.btnConvertir.Text = "convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(182, 261);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(35, 13);
            this.lblresultado.TabIndex = 4;
            this.lblresultado.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.cmbSalida);
            this.Controls.Add(this.cmbEntrada);
            this.Controls.Add(this.txtcantidad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.ComboBox cmbEntrada;
        private System.Windows.Forms.ComboBox cmbSalida;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Label lblresultado;
    }
}

