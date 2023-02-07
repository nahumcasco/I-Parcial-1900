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
    public partial class Ejercicio7 : Form
    {
        public Ejercicio7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            //Matriz
            int[,] matriz1 = new int[2, 3] { 
                                                { 5, 6, 4 }, 
                                                { 9, 7, 3 } 
                                           };


            //Lenar la matriz
            Random aleatorio = new Random();
            int[,] matriz2 = new int[4, 6];
            
            for (int fila = 0; fila < matriz2.GetLength(0); fila++)
            {
                for (int col = 0; col < matriz2.GetLength(1); col++)
                {
                    if (matriz2[fila, col] == matriz2[fila, col])
                    {
                        matriz2[fila, col] = aleatorio.Next(0, 100);
                    }
                }
            }

            //Mostrar la matriz en el listbox
            for (int fila = 0; fila < matriz2.GetLength(0); fila++)
            {
                for (int col = 0; col < matriz2.GetLength(1); col++)
                {
                    listBox1.Items.Add("La posición: [" + fila + "," + col + "] = " + matriz2[fila, col]);
                }
            }
            
        }
    }
}
