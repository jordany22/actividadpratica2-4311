using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pratica2__ejercicio_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVericarprimo_Click(object sender, EventArgs e)
        {
            if (int.TryParse(mtxtNumero.Text, out int numero))
            {
                if (EsPrimo(numero))
                {
                    MessageBox.Show("El número es primo.");
                }
                else
                {
                    MessageBox.Show("El número no es primo.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un número válido.");
            }
        }

        private bool EsPrimo(int num)
        {
            if (num <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
    }
    }

