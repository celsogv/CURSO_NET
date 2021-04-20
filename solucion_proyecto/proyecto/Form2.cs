using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        DataClasses1DataContext valor = new DataClasses1DataContext();
        



        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {

            try
            {
                if ((txtAnadirUsuario.Text == "") || (txtAnadirContrasena.Text == ""))
                {
                    MessageBox.Show("Faltan campos por rellenar");



                }
                else
                {
                    usuarios MyUsuario = new usuarios();
                    MyUsuario.usuario = txtAnadirUsuario.Text;
                    MyUsuario.contrasena = txtAnadirContrasena.Text;
                    MyUsuario.administrador = false;
                    valor.usuarios.InsertOnSubmit(MyUsuario);
                    valor.SubmitChanges();
                    txtAnadirUsuario.Text = "";
                    txtAnadirContrasena.Text = "";

                }


            } catch
            {


                MessageBox.Show("Se ha producido un error");
                
            }

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form1 formulariouno = new Form1();
            formulariouno.Show();
            this.Hide();




        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                Application.Exit();

            } catch
            {
                MessageBox.Show("Se ha producido un error.");


            }

        }
    }
}
