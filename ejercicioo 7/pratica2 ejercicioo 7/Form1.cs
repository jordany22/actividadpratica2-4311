using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pratica2_ejercicioo_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lstPrimos.Items.Clear();

            if (int.TryParse(txtInicio.Text, out int inicio) && int.TryParse(txtFin.Text, out int fin))
            {
                for (int num = inicio; num <= fin; num++)
                {
                    if (EsPrimo(num))
                    {
                        lstPrimos.Items.Add(num);
                    }
                }
            }
            else
            {
                MessageBox.Show("Ingrese valores numéricos válidos.");
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

