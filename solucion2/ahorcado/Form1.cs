using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ahorcado
{
    public partial class Form1 : Form
    {
        int oportunidades = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            if ((textBox1.Text.ToUpper() != "C") && (textBox1.Text.ToUpper() != "O") && (textBox1.Text.ToUpper() != "R") && (textBox1.Text.ToUpper() != "R") && (textBox1.Text.ToUpper() != "E") && (textBox1.Text.ToUpper() != "O") && (textBox1.Text.ToUpper() != "S"))
            {
               
                oportunidades = oportunidades -1 ;
                textBox10.Text = (oportunidades).ToString();
                if (oportunidades < 5) pictureBox1.Visible = true;
                if (oportunidades < 4) pictureBox2.Visible = true;     
                if (oportunidades < 3) pictureBox3.Visible = true;
                if (oportunidades < 2) pictureBox4.Visible = true;
                if (oportunidades < 1) pictureBox5.Visible = true;
                if (oportunidades <= 0)
                {
                    MessageBox.Show("Has perdido");
                    Application.Exit();

                }
               
            }
            else
            {

                
                if (textBox1.Text.ToUpper() == "C")
                {

                    textBox2.Text = "c";

                }
                if (textBox1.Text.ToUpper() == "O")
                {

                    textBox3.Text = "o";
                }
                if (textBox1.Text.ToUpper() == "R")
                {

                    textBox4.Text = "r";
                }
                if (textBox1.Text.ToUpper() == "R")
                {

                    textBox5.Text = "r";
                }
                if (textBox1.Text.ToUpper() == "E")
                {

                    textBox6.Text = "e";
                }
                if (textBox1.Text.ToUpper() == "O")
                {

                    textBox7.Text = "o";
                }
                if (textBox1.Text.ToUpper() == "S")
                {

                    textBox8.Text = "s";
                }
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
