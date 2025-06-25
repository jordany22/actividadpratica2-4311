namespace pratica2_ejercicio_6
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
            this.btnVerifcarp = new System.Windows.Forms.Button();
            this.mtxtNumero = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnVerifcarp
            // 
            this.btnVerifcarp.Location = new System.Drawing.Point(571, 244);
            this.btnVerifcarp.Name = "btnVerifcarp";
            this.btnVerifcarp.Size = new System.Drawing.Size(75, 23);
            this.btnVerifcarp.TabIndex = 0;
            this.btnVerifcarp.Text = "verificar";
            this.btnVerifcarp.UseVisualStyleBackColor = true;
            this.btnVerifcarp.Click += new System.EventHandler(this.btnVerifcarp_Click);
            // 
            // mtxtNumero
            // 
            this.mtxtNumero.Location = new System.Drawing.Point(510, 64);
            this.mtxtNumero.Mask = "00000";
            this.mtxtNumero.Name = "mtxtNumero";
            this.mtxtNumero.Size = new System.Drawing.Size(100, 20);
            this.mtxtNumero.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mtxtNumero);
            this.Controls.Add(this.btnVerifcarp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerifcarp;
        private System.Windows.Forms.MaskedTextBox mtxtNumero;
    }
}

