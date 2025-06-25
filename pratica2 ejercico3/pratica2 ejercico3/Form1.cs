using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pratica2_ejercico3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnconvertir_Click(object sender, EventArgs e)
        {
            double valor = double.Parse(txtCantidad.Text);
            string unidadOrigen = cmbOrigen.SelectedItem.ToString();
            string unidadDestino = cmbDestino.SelectedItem.ToString();

            // Convertir a metros primero
            double valorEnMetros = unidadOrigen switch
            {
                "Metros" => valor,
                "Centímetros" => valor / 100,
                "Pulgadas" => valor * 0.0254,
                _ => 0
            };

            // Convertir de metros a destino
            double resultado = unidadDestino switch
            {
                "Metros" => valorEnMetros,
                "Centímetros" => valorEnMetros * 100,
                "Pulgadas" => valorEnMetros / 0.0254,
                _ => 0
            };

            lblResultado.Text = $"Resultado: {resultado:F2} {unidadDestino}";
        }
    }
    }
}
