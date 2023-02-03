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
    public partial class Ejercicio4 : Form
    {
        public Ejercicio4()
        {
            InitializeComponent();
        }

        private void EjecutarButton_Click(object sender, EventArgs e)
        {
            DateTime fecha = FechaDateTimePicker.Value;

            //DiaTextBox.Text = fecha.Day.ToString();
            //MesTextBox.Text = fecha.Month.ToString();
            //AñoTextBox.Text = fecha.Year.ToString();
            //SemanaTextBox.Text = fecha.DayOfWeek.ToString();

            DiaTextBox.Text = fecha.ToString("M");
            MesTextBox.Text = fecha.ToString("MMMM");
            AñoTextBox.Text = fecha.ToString("yyyy");
            SemanaTextBox.Text = fecha.ToString("dddd");

            int numeroDias = Convert.ToInt32(DiasTextBox.Text);
            DateTime fechaActual = DateTime.Now;
            CitaTextBox.Text = fechaActual.AddDays(numeroDias).ToShortDateString();

            int diasResta = Convert.ToInt32(DiasRestaTextBox.Text);
            NuevaFechaTextBox.Text = fecha.AddDays(-diasResta).ToShortDateString();

            MessageBox.Show("La Edad de la persona es: " + DevolverEdad(fecha));


        }

        private int DevolverEdad(DateTime fechaNacimiento)
        {
            int edad = 0;
            if (fechaNacimiento >= DateTime.Now)
            {
                return 0;
            }
            else
            {
                edad = DateTime.Now.Year - fechaNacimiento.Year;
                if (fechaNacimiento.Month > DateTime.Now.Month)
                {
                    --edad;
                }
            }
            return edad;
        }

    }
}
