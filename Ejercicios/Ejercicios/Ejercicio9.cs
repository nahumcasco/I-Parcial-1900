using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POO;

namespace Ejercicios
{
    public partial class Ejercicio9 : Form
    {
        public Ejercicio9()
        {
            InitializeComponent();
        }

        Coche coche1 = null;

        List<Coche> listaCoches = new List<Coche>();


        private void button1_Click(object sender, EventArgs e)
        {
            //Instanciar un objeto de una clase
            //Coche miCoche = new Coche();

            //Coche miCoche2 = new Coche("Toyota", 2009);

            string marca = MarcaTextBox.Text;
            string modelo = ModeloTextBox.Text;
            decimal precio = Convert.ToDecimal(PrecioTextBox.Text);
            int km = Convert.ToInt32(KmTextBox.Text);
            int año = Convert.ToInt32(AñoTextBox.Text);

            coche1 = new Coche();

            coche1.Marca = marca;
            coche1.Modelo = modelo;
            coche1.Precio = precio;
            coche1.Kilometros = km;
            coche1.Año = año;

            listaCoches.Add(coche1);
            CochesDataGridView.DataSource = null;
            CochesDataGridView.DataSource = listaCoches;
            LimpiarControles();
            MarcaTextBox.Focus();
            //MessageBox.Show("Marca: " + coche1.Marca + ", Modelo: " + coche1.Modelo);

        }

        private void LimpiarControles()
        {
            MarcaTextBox.Clear();
            ModeloTextBox.Text = string.Empty;
            PrecioTextBox.Text = "";
            KmTextBox.Clear();
            AñoTextBox.Clear();
        }

    }
}
