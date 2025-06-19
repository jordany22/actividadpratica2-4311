namespace pratica2_ejercicio1
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
            this.Btngenerar = new System.Windows.Forms.Button();
            this.lsttabla = new System.Windows.Forms.ListBox();
            this.texNumero = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btngenerar
            // 
            this.Btngenerar.Location = new System.Drawing.Point(394, 228);
            this.Btngenerar.Name = "Btngenerar";
            this.Btngenerar.Size = new System.Drawing.Size(130, 23);
            this.Btngenerar.TabIndex = 0;
            this.Btngenerar.Text = "GENERAR TABLA";
            this.Btngenerar.UseVisualStyleBackColor = true;
            this.Btngenerar.Click += new System.EventHandler(this.Btngenerar_Click);
            // 
            // lsttabla
            // 
            this.lsttabla.FormattingEnabled = true;
            this.lsttabla.Location = new System.Drawing.Point(593, 156);
            this.lsttabla.Name = "lsttabla";
            this.lsttabla.Size = new System.Drawing.Size(120, 95);
            this.lsttabla.TabIndex = 1;
            // 
            // texNumero
            // 
            this.texNumero.Location = new System.Drawing.Point(438, 99);
            this.texNumero.Name = "texNumero";
            this.texNumero.Size = new System.Drawing.Size(100, 20);
            this.texNumero.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.texNumero);
            this.Controls.Add(this.lsttabla);
            this.Controls.Add(this.Btngenerar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btngenerar;
        private System.Windows.Forms.ListBox lsttabla;
        private System.Windows.Forms.TextBox texNumero;
    }
}

