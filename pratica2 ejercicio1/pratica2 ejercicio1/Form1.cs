
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pratica2_ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        
private void Btngenerar_Click(object sender, System.EventArgs e)
        {
            lsttabla.Items.Clear();
            if (int.TryParse(texNumero.Text, out int numero))
            {

                for (int i = 1; i <= 10; i++)
                {


                    lsttabla.Items.Add($"{numero} x {i} = {numero * i}");
                }
            }
    }
}
}

