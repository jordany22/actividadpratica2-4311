using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pratica2_ejercicio_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerifcarp_Click(object sender, EventArgs e)
        {
            if (int.TryParse(mtxtNumero.Text, out int numero))
            {
                int suma = 0;

                for (int i = 1; i < numero; i++)
                {
                    if (numero % i == 0)
                    {
                        suma += i;
                    }
                }

                if (suma == numero)
                {
                    MessageBox.Show($"{numero} es un número perfecto.");
                }
                else
                {
                    MessageBox.Show($"{numero} no es un número perfecto.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un número válido.");
            }
    }
}
}

