using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formulario_factura
{
    public partial class Form1 : Form
    {
        string texto1, texto2, texto3, texto4, texto5, texto6, texto7, texto8, texto9, texto10, texto11, texto12;

        private void button1_Click(object sender, EventArgs e)
        {
            textBox13.Text = (Decimal.Parse(textBox12.Text) - Decimal.Parse(textBox11.Text)).ToString();
        }

        int subtotal;
        

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "1";
            textBox7.Text = "1";
            textBox8.Text = "1";
            textBox9.Text = (30.00 + 15.00 + 12.00).ToString();
            textBox10.Text = (Decimal.Parse(textBox9.Text) * 16 / 100).ToString();
            textBox11.Text = ((Decimal.Parse(textBox9.Text)) + (Decimal.Parse(textBox10.Text))).ToString();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "1";
            textBox4.Text = "1";
            textBox5.Text = "1";
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "0";
            textBox9.Text = (12.00 + 25.00 + 70.00).ToString();
            textBox10.Text = (Decimal.Parse(textBox9.Text) * 16 / 100).ToString();
            textBox11.Text = ((Decimal.Parse(textBox9.Text)) + (Decimal.Parse(textBox10.Text))).ToString();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "1";
            textBox2.Text = "1";
            textBox3.Text = "1";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "0";
            textBox9.Text = (35.00 + 15.00 + 12.00).ToString();
            textBox10.Text = (Decimal.Parse(textBox9.Text) * 16 / 100).ToString();
            textBox11.Text = ((Decimal.Parse(textBox9.Text)) + (Decimal.Parse(textBox10.Text))).ToString();
            

        }

    }
}
