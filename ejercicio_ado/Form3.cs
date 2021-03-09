using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ejercicio_ado
{
    public partial class Form3 : Form
    {

        private SqlConnection conexion = new SqlConnection("Server = CADAVILES03\\SQLEXPRESS ; database=ejercicio_pruebas; integrated security = true");
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ejercicio_pruebasDataSet.prueba' Puede moverla o quitarla según sea necesario.
            this.pruebaTableAdapter.Fill(this.ejercicio_pruebasDataSet.prueba);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string id = textBox1.Text;
            string nombre = textBox2.Text;
            string edad = textBox3.Text;
            string cadena = "update prueba set nombre='" + nombre + "', edad=" + edad + " where id=" + id;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();
            if (cant == 1)
            {
                MessageBox.Show("Se modificaron los datos del articulo");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";


            } else
            {



                MessageBox.Show("No existe un articulo con el codigo ingresado");
            }

            conexion.Close();
            button1.Enabled = false;

        }
    }
}
