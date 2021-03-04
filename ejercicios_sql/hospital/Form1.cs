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
    public partial class Form1 : Form

    {

        DataClasses1DataContext ClienteLinq = new DataClasses1DataContext();
        string sexo = "H";

        public Form1()
        {
            InitializeComponent();
            this.ListarEnfermos();

        }

        void ListarEnfermos()
        {


            dataGridView1.DataSource = ClienteLinq.listartodos();

        }

        
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();

            } catch
            {


                MessageBox.Show("Se ha producido un error");

            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtInscripcion.Text == "")
                {

                    MessageBox.Show("Falta el numero de inscripcion");


                }
                else if (txtNombre.Text == "")
                {


                    MessageBox.Show("falta el nombre");


                }
                else if (txtFecha.Text == "")
                {

                    MessageBox.Show("Falta la fecha");


                }
                else if (txtDireccion.Text == "")
                {


                    MessageBox.Show("falta la direccion");

                }
                else if (txtNumero.Text == "")
                {
                    MessageBox.Show("falta el numero de la seguridad social");



                }
                else
                {

                    

                    ClienteLinq.insertarenfermo(txtNombre.Text, int.Parse(txtNumero.Text), sexo, txtFecha.Text, txtDireccion.Text, int.Parse(txtNumero.Text));
                    this.ListarEnfermos();

                
                
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

                if (txtInscripcion.Text == "")
                {

                    MessageBox.Show("Falta el numero de inscripcion");


                }
                else if (txtNombre.Text == "")
                {


                    MessageBox.Show("falta el nombre");


                }
                else if (txtFecha.Text == "")
                {

                    MessageBox.Show("Falta la fecha");


                }
                else if (txtDireccion.Text == "")
                {


                    MessageBox.Show("falta la direccion");

                }
                else if (txtNumero.Text == "")
                {
                    MessageBox.Show("falta el numero de la seguridad social");



                }
                else
                {

                    
                    ClienteLinq.modificarenfermo(txtNombre.Text, int.Parse(txtInscripcion.Text), sexo, txtFecha.Text, txtDireccion.Text, int.Parse(txtNumero.Text));
                    this.ListarEnfermos();
                
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
                if (txtInscripcion.Text == "")
                {


                    MessageBox.Show("Falta el numero de inscripcion");

                }
                else
                {


                   
                    ClienteLinq.eliminarenfermo(int.Parse(txtInscripcion.Text));
                    this.ListarEnfermos();

                }

            } catch
            {
                MessageBox.Show("Se ha producido un error");



            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            sexo = "H";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            sexo = "M";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
