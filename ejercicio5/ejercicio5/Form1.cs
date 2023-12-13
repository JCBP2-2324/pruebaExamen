using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LblNum1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void tNum2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            int num1, num2, resultado; // Inicializo la variables

            try {
                num1 = int.Parse(tNum1.Text); // Asigno a la variable "num1" el valor introducido en el TextBox "tNum1" habiéndolo convertido previamente a tipo entero
                num2 = int.Parse(tNum2.Text); // Asigno a la variable "num2" el valor introducido en el TextBox "tNum2" habiéndolo convertido previamente a tipo entero
                resultado = num1 - num2; // Asigno a la variable "resultado" el valor obtenido de la suma de las variables "num1" y "num2"

                tResultado.Text = resultado.ToString(); // En el TextBox "tResultado" inserto el valor de la variable resultado habiéndolo convertido previamente a tipo cadena de texto
            }
            catch (FormatException FEx)
            {
                MessageBox.Show("Se ha producido el error: " + FEx.Message);            
            }
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            int num1, num2, resultado; // Inicializo la variables
            num1 = int.Parse(tNum1.Text); // Asigno a la variable "num1" el valor introducido en el TextBox "tNum1" habiéndolo convertido previamente a tipo entero
            num2 = int.Parse(tNum2.Text); // Asigno a la variable "num2" el valor introducido en el TextBox "tNum2" habiéndolo convertido previamente a tipo entero
            resultado = num1 + num2; // Asigno a la variable "resultado" el valor obtenido de la resta de las variables "num1" y "num2"

            tResultado.Text = resultado.ToString(); // En el TextBox "tResultado" inserto el valor de la variable "resultado" habiéndolo convertido previamente a tipo cadena de texto
        }
    }
}
