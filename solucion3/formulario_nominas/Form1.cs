using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formulario_nominas
{
    public partial class Form1 : Form
    {


        Nomina trabajador = new Nomina();
        string formnombre, formidentificacion;
        decimal formsalario;
        int formdias;
        Decimal formresultado;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            formresultado = trabajador.getValorSalario();
            textBox5.Text = formresultado.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            trabajador.setNombre(textBox1.Text);
            trabajador.setIdentoficacion(textBox2.Text);
            trabajador.setSalario(Decimal.Parse(textBox3.Text));
            trabajador.setDias(int.Parse(textBox4.Text));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
