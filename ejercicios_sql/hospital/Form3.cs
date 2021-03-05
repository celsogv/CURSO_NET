using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospital
{
    public partial class Form3 : Form
    {

        DataClasses1DataContext ClienteLinq = new DataClasses1DataContext();

        public Form3()
        {
            InitializeComponent();
            this.verdoctores();

        }
        void verdoctores()
        {


            dataGridView1.DataSource = ClienteLinq.listardoctores();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtCodHos.Text == "")
                {
                    MessageBox.Show("Falta el codigo del hospital");




                }
                else if (txtNumDoc.Text == "")
                {

                    MessageBox.Show("Falta el numero del doctor");



                }
                else if (txtNom.Text == "")
                {

                    MessageBox.Show("Falta el nombre del doctor");



                }
                else if (txtEspecialidad.Text == "")
                {
                    MessageBox.Show("Falta la especialidad");




                }
                else
                {

                   
                    ClienteLinq.insertardoctor(int.Parse(txtCodHos.Text), int.Parse(txtNumDoc.Text), txtNom.Text, txtEspecialidad.Text);
                    this.verdoctores();



                }

            } catch
            {


                MessageBox.Show("Se ha producido un error");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtNumDoc.Text == "")
                {



                    MessageBox.Show("Falta el numero del doctor");


                }
                else
                {

                   
                    ClienteLinq.eliminardoctor(int.Parse(txtNumDoc.Text));
                    this.verdoctores();




                }
            } catch
            {
                MessageBox.Show("Se ha producido un error");



            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtCodHos.Text == "")
                {
                    MessageBox.Show("Falta el codigo del hospital");




                }
                else if (txtNumDoc.Text == "")
                {

                    MessageBox.Show("Falta el numero del doctor");



                }
                else if (txtNom.Text == "")
                {

                    MessageBox.Show("Falta el nombre del doctor");



                }
                else if (txtEspecialidad.Text == "")
                {
                    MessageBox.Show("Falta la especialidad");




                }
                else
                {

                    
                    ClienteLinq.modificardoctor(int.Parse(txtCodHos.Text), int.Parse(txtNumDoc.Text), txtNom.Text, txtEspecialidad.Text);
                    this.verdoctores();



                }

            } catch
            {

                MessageBox.Show("Se ha producido un error");


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            } catch
            {


                MessageBox.Show("Se ha producio un error");

            }

        }
    }
}
