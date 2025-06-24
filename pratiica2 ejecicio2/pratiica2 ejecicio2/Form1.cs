using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pratiica2_ejecicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int tiempototal; // en segndos
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtMinutos.Text, out int min) && int.TryParse(txtSegundo.Text, out int seg))
            {
                tiempototal = (min * 60) + seg;
                timer1.Start();
            }
            else
            {
                MessageBox.Show("INGRESE VALORES NUMERICOS VALIDOS.");
            }
}

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tiempototal  > 0) 
            {
                tiempototal--;
        }
            else
            {
                timer1.Stop();
                MessageBox.Show("tienpo agotado");
            }
        }
    }
}