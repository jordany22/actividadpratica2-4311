using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pratica2ejercicio8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnContarPalabras_Click(object sender, EventArgs e)
        {
            string oracion = textOracion.Text.Trim();

            if (!string.IsNullOrEmpty(oracion))
            {
                // Separar por espacios eliminando espacios dobles
                string[] palabras = oracion.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                LblResultado.Text = $"Cantidad de palabras: {palabras.Length}";
            }
            else
            {
                LblResultado.Text = "Ingrese una oración.";
            }
        }
    }
}
