﻿namespace pratica2__ejercicio_5
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
            this.btnVericarprimo = new System.Windows.Forms.Button();
            this.mtxtNumero = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnVericarprimo
            // 
            this.btnVericarprimo.Location = new System.Drawing.Point(548, 245);
            this.btnVericarprimo.Name = "btnVericarprimo";
            this.btnVericarprimo.Size = new System.Drawing.Size(75, 23);
            this.btnVericarprimo.TabIndex = 0;
            this.btnVericarprimo.Text = "Verificar";
            this.btnVericarprimo.UseVisualStyleBackColor = true;
            this.btnVericarprimo.Click += new System.EventHandler(this.btnVericarprimo_Click);
            // 
            // mtxtNumero
            // 
            this.mtxtNumero.Location = new System.Drawing.Point(429, 66);
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
            this.Controls.Add(this.btnVericarprimo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVericarprimo;
        private System.Windows.Forms.MaskedTextBox mtxtNumero;
    }
}

