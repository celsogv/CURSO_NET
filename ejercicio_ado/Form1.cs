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
    public partial class Form1 : Form
    {


        private SqlConnection conexion = new SqlConnection("Server = CADAVILES03\\SQLEXPRESS ; database=ejercicio_pruebas; integrated security = true");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string iden = textBox1.Text;
            string nombre = textBox2.Text;
            string edad = textBox3.Text;
            string cadena = "insert into prueba(id, nombre, edad) " + "values (" + iden + ",'" + nombre + "'," + edad + ")";

            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Los datos de guardaron correctamente");
            textBox1.Text = "";
            textBox2.Text = "";
            conexion.Close();



        }
    }
}
