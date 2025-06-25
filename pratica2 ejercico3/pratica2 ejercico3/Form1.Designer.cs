namespace pratica2_ejercico3
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnconvertir = new System.Windows.Forms.Button();
            this.cbentrada = new System.Windows.Forms.ComboBox();
            this.cbnsalida = new System.Windows.Forms.ComboBox();
            this.lblresultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(575, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // btnconvertir
            // 
            this.btnconvertir.Location = new System.Drawing.Point(136, 245);
            this.btnconvertir.Name = "btnconvertir";
            this.btnconvertir.Size = new System.Drawing.Size(75, 23);
            this.btnconvertir.TabIndex = 1;
            this.btnconvertir.Text = "convertir";
            this.btnconvertir.UseVisualStyleBackColor = true;
            this.btnconvertir.Click += new System.EventHandler(this.btnconvertir_Click);
            // 
            // cbentrada
            // 
            this.cbentrada.FormattingEnabled = true;
            this.cbentrada.Location = new System.Drawing.Point(99, 71);
            this.cbentrada.Name = "cbentrada";
            this.cbentrada.Size = new System.Drawing.Size(121, 21);
            this.cbentrada.TabIndex = 2;
            // 
            // cbnsalida
            // 
            this.cbnsalida.FormattingEnabled = true;
            this.cbnsalida.Location = new System.Drawing.Point(341, 73);
            this.cbnsalida.Name = "cbnsalida";
            this.cbnsalida.Size = new System.Drawing.Size(121, 21);
            this.cbnsalida.TabIndex = 3;
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(548, 255);
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
            this.Controls.Add(this.cbnsalida);
            this.Controls.Add(this.cbentrada);
            this.Controls.Add(this.btnconvertir);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnconvertir;
        private System.Windows.Forms.ComboBox cbentrada;
        private System.Windows.Forms.ComboBox cbnsalida;
        private System.Windows.Forms.Label lblresultado;
    }
}

