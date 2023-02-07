using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios
{
    public partial class Ejercicio8 : Form
    {
        public Ejercicio8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RecorrerUnoAUno(1, 100);
        }

        private void RecorrerUnoAUno(int valorInicial, int valorFinal)
        {
            listBox1.Items.Add(valorInicial);

            if (valorInicial < valorFinal)
            {
                RecorrerUnoAUno(valorInicial + 1, valorFinal);
            }
        }

    }
}
