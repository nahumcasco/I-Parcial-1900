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
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void EjecutarButton_Click(object sender, EventArgs e)
        {
            string cadena = CadenaTextBox.Text;

            LongitudTextBox.Text = Convert.ToString(cadena.Length);
            PrimerCaracterTextBox.Text = cadena.Substring(0, 1);
            UltimoCaracterTextBox.Text = cadena.Substring(cadena.Length - 1, 1);
            MayusculasTextBox.Text = cadena.ToUpper();
            MinusculasTextBox.Text = cadena.ToLower();
            ReemplazarTextBox.Text = cadena.Replace("a", "2");
        }
    }
}
