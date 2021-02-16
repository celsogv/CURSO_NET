using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace formulario_hotel
{
    public partial class Form1 : Form
    {

        public Boolean IsValid(String caja)

        {


            if (caja != "") return true;
            else return false;
        }

        string texto1, texto2, texto3;

        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            using (var writetext = new StreamWriter("write.txt"))
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)

                {



                    writetext.WriteLine($"{row.Cells[0].Value}, {row.Cells[1].Value}, {row.Cells[2].Value}, {row.Cells[3].Value}, {row.Cells[4].Value}, {row.Cells[5].Value}, {row.Cells[6].Value}");
                }





            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!IsValid(textBox2.Text) || !IsValid(textBox4.Text) || !IsValid(textBox6.Text) || !IsValid(comboBox1.Text))
            {

                MessageBox.Show("Faltan campos por rellenar");

            }

            else
            {

                dataGridView1.Rows.Add(textBox2.Text, textBox4.Text, textBox6.Text, comboBox1.Text, dateTimePicker1.Text, dateTimePicker2.Text, dateTimePicker3.Text);
                dataGridView1.AllowUserToAddRows = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }
    }
}
