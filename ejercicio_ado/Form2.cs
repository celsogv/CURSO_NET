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
    public partial class Form2 : Form
    {

        private SqlConnection conexion = new SqlConnection("Server = CADAVILES03\\SQLEXPRESS ; database=ejercicio_pruebas; integrated security = true");
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string id = textBox1.Text;
            string cadena = "select id, nombre, edad from prueba where id = " + id;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {


                label3.Text = registro["nombre"].ToString();
                label4.Text = registro["edad"].ToString();
                button2.Enabled = true;
                 
            } else
            {


                MessageBox.Show("no existe un articulo con el codigko ingresado");

            }
            conexion.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string id = textBox1.Text;
            string cadena = "delete from prueba where id=" + id;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();
            if (cant == 1)
            {

                label3.Text = "";
                label4.Text = "";
                MessageBox.Show("Se borron el articulo");



            } else
            {

                MessageBox.Show("No existe un articulo con el codigo ingresado");



            }
            conexion.Close();
            button1.Enabled = false;

    }   }
}
