using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maria_de_los_Angeles_Moreno_Gomez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double valor1, valor2, resultado;
        string operacion; 

        private void pantalla_TextChanged(object sender, EventArgs e)
        {

        }

        private void nueve_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "9";
        }

        private void ocho_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "8";
        }

        private void siete_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "7";
        }

        private void seis_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "6";
        }

        private void cinco_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "5";
        }

        private void cuatro_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "4";
        }

        private void tres_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "3";
        }

        private void dos_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "2";
        }

        private void uno_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "1";
        }

        private void suma_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(pantalla.Text);
            operacion = "+";
            pantalla.Clear();
        }

        private void resta_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(pantalla.Text);
            operacion = "-";
            pantalla.Clear();
        }

        private void multiplicacion_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(pantalla.Text);
            operacion = "x";
            pantalla.Clear();
        }

        private void division_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(pantalla.Text);
            operacion = "/";
            pantalla.Clear();
        }

        private void igual_Click(object sender, EventArgs e)
        {
            valor2 = double.Parse(pantalla.Text);
            if (operacion == "+")
            {
                resultado = valor1 + valor2;
            }
            if (operacion == "-")
            {
                resultado = valor1 - valor2;
            }
            if (operacion == "/")
            {
                resultado = valor1 / valor2;
            }
            if (operacion == "x")
            {
                resultado = valor1 * valor2;
            }
            pantalla.Text = resultado.ToString();
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            pantalla.Clear();
        }

        private void cero_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "0";
        }

        private void punto_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + ".";
        }
    }
}
