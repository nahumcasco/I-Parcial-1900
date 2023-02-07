using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios
{
    public partial class Ejercicio5 : Form
    {
        public Ejercicio5()
        {
            InitializeComponent();
        }

        private void HornearPizzabutton_Click(object sender, EventArgs e)
        {
            HornearPizza();
            MessageBox.Show("Termino de Hornear");
        }

        private void HornearPizza()
        {
            Thread.Sleep(10000);
        }

        private Task HornearPizzaAsync()
        {
            return Task.Delay(10000);
        }

        private void HornearPizza2button_Click(object sender, EventArgs e)
        {
            HornearPizzaAsync();
            MessageBox.Show("Otro Proceso");
        }

        private async void CalcularButton_Click(object sender, EventArgs e)
        {
            decimal num1 =Convert.ToDecimal(Numero1TextBox.Text);
            decimal num2 = Convert.ToDecimal(Numero2TextBox.Text);

            decimal resultado = await SumarAsync(num1, num2);

            MessageBox.Show($"La suma es: {resultado}");
            MessageBox.Show("La suma es: " + resultado);
        }

        private async Task<decimal> SumarAsync(decimal n1, decimal n2)
        {
            decimal suma = await Task.Run(() =>
            {
                return n1 + n2;
            });
            return suma;
        }


    }
}
