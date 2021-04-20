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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        DataClasses1DataContext valor = new DataClasses1DataContext();




        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            string individuo;
            string palabra;
            individuo = txtUsuario.Text;
            palabra = txtContrasena.Text;
            if ((txtUsuario.Text == "") || (txtContrasena.Text == ""))
            {
                MessageBox.Show("Faltan campos por rellenar");



            } else
            {

                var validar = (from p in valor.usuarios
                               where ((p.usuario == individuo) && (p.contrasena == palabra))
                               select p);
                if (validar.Count() == 0) MessageBox.Show("Acceso erroneo");
                else
                {
                    if ((txtUsuario.Text == "admin") && (txtContrasena.Text == "admin"))
                    {

                       
                       
                        Form2 formulario2 = new Form2();
                        formulario2.Show();
                        this.Hide();
                    }
                   
                    
                    else
                    {

                        
                        Form3 formulario3 = new Form3();
                        formulario3.Show();
                        this.Hide();


                    }


                }
               


            }
        }

        private void Form1_UnLoad(object sender, EventArgs e)
        {
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
