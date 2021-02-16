using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formulario_contraseña
{
    public partial class Form2 : Form
    {
        int intentos = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto1, texto2, texto3, texto4, texto5, texto6, texto7, texto8, texto9, texto10, texto11;
            texto1 = textBox1.Text.ToUpper(); 
            texto2 = textBox2.Text.ToUpper();
            texto3 = textBox3.Text.ToUpper();
            texto4 = textBox4.Text.ToUpper();
            texto5 = textBox5.Text.ToUpper();
            texto6 = textBox6.Text.ToUpper();
            texto7 = textBox7.Text.ToUpper();
            texto8 = textBox8.Text.ToUpper();
            texto9 = textBox9.Text.ToUpper();
            texto10 = textBox10.Text.ToUpper();
            texto11 = textBox11.Text.ToUpper();
            Boolean linea1 = false;
            Boolean linea2 = false;
            Boolean linea3 = false;
            Form2 valorformulario = new Form2();
            

            if ((texto2 == "O") && (texto6=="R") && (texto7=="O"))
            {
                linea1 = true;
            }
            if ((texto1 == "L") && (texto2 == "O") && (texto3 == "R") && (texto4 == "O"))
            {
                linea2 = true;
            }
            if ((texto11 == "R") && (texto10 == "A") && (texto9 == "T") && (texto4 == "O") && (texto8 == "N"))
            {
                linea3 = true;
            }
            if ((linea1 == true) && (linea2 == true) && (linea3 == true))
            {
                MessageBox.Show("Has acertado");
               
            }
            else
            {
                textoIntentos.Text = textoIntentos.Text + 1;
                intentos = intentos + 1;

            }
            textoIntentos.Text = intentos.ToString();
            
            if (intentos > 4)
            {
                MessageBox.Show("Has superado el numero de intentos");

                Application.Exit();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
