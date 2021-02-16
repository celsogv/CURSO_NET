using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_formularios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Boton para sumar
            int num1, num2, resultado;
            if ((txtNumero1.Text == "") || (txtNumero2.Text == "")) MessageBox.Show("DEBES INTRODUCIR UN VALOR");
            else
            {
                num1 = int.Parse(txtNumero1.Text);
                num2 = int.Parse(txtNumero2.Text);
                resultado = num1 + num2;
                txtResultado.Text = resultado.ToString();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num1, num2, resultado;
            if ((txtNumero1.Text == "") || (txtNumero2.Text == "")) MessageBox.Show("DEBES INTRODUCIR UN VALOR");
            else
            {
                num1 = int.Parse(txtNumero1.Text);
                num2 = int.Parse(txtNumero2.Text);
                resultado = num1 - num2;
                txtResultado.Text = resultado.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
                int num1, num2, resultado;
                if ((txtNumero1.Text == "") || (txtNumero2.Text == "")) MessageBox.Show("DEBES INTRODUCIR UN VALOR");
                else
                {
                    num1 = int.Parse(txtNumero1.Text);
                    num2 = int.Parse(txtNumero2.Text);
                    resultado = num1 * num2;
                    txtResultado.Text = resultado.ToString();
                }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if ((txtNumero1.Text == "") || (txtNumero2.Text == "")) MessageBox.Show("DEBES INTRODUCIR UN VALOR");
            else
            {
                int num1, num2, resultado;
                num1 = int.Parse(txtNumero1.Text);
                num2 = int.Parse(txtNumero2.Text);
                resultado = num1 / num2;
                txtResultado.Text = resultado.ToString();
            }
        }
    }
}
