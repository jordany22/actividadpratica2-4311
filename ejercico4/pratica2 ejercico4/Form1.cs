using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pratica2_ejercico4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string palabra = txtPalabra.Text.ToLower().Replace(" ", "");
            string invertida = new string(palabra.Reverse().ToArray());

            if (palabra == invertida)
            {
                MessageBox.Show("Es palíndroma.");
            }
            else
            {
                MessageBox.Show("No es palíndroma.");
            }
        }
    }
}



