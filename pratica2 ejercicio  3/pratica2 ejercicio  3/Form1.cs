using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pratica2_ejercicio__3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbEntrada.Items.AddRange(new string[] { "Metros", "Centímetros", "Pulgadas" });
            cmbSalida.Items.AddRange(new string[] { "Metros", "Centímetros", "Pulgadas" });
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            double cantidad = double.Parse(txtcantidad.Text);
            string entrada = cmbEntrada.SelectedItem.ToString();
            string salida = cmbSalida.SelectedItem.ToString();

            double metros = cantidad;

            // Convertir a metros primero
            if (entrada == "Centímetros") metros = cantidad / 100;
            else if (entrada == "Pulgadas") metros = cantidad * 0.0254;

            // Convertir de metros a salida
            double resultado = metros;

            if (salida == "Centímetros") resultado = metros * 100;
            else if (salida == "Pulgadas") resultado = metros / 0.0254;

            lblresultado.Text = $"Resultado: {resultado}";
        }
    }
    }

