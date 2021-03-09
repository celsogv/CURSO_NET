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

namespace ejercicio_acceso_ado
{


    public partial class Form1 : Form
    {

        private SqlConnection conexion = new SqlConnection("Server = CADAVILES03\\SQLEXPRESS ; database=ejercicio_ado; integrated security = true");
        public Form1()
        {
            InitializeComponent();
            cargar();
            cargarcombo();

        }


        public void cargar()
        {
            DataTable dt = new DataTable();
            string cadena = "select * from CLIENTE";
            SqlCommand cmd = new SqlCommand(cadena, conexion);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
            conexion.Close();



        }


        public void cargarcombo()
        {
            DataSet ds = new DataSet();
            string cadena = "select * from CLIENTE";
            SqlDataAdapter da = new SqlDataAdapter(cadena, conexion);
            da.Fill(ds, "CLIENTE");
            comboBox1.DataSource = ds.Tables[0].DefaultView;
            comboBox1.ValueMember = "IDCLIENTE";
            conexion.Close();




        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ejercicio_adoDataSet.CLIENTE' Puede moverla o quitarla según sea necesario.
  //          this.cLIENTETableAdapter.Fill(this.ejercicio_adoDataSet.CLIENTE);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();
            
            string idcliente = textBox1.Text;
            string nombres = textBox2.Text;
            string apellidos = textBox3.Text;
            string cadena = "insert into CLIENTE (IDCLIENTE, APELLIDOS, NOMBRES)" + 
                " values ('" + idcliente + "',  '" +  apellidos + "', '" + nombres + "')";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            cargar();
            cargarcombo();
            conexion.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string idcliente = textBox1.Text;
            string cadena = "delete from CLIENTE where IDCLIENTE=" + idcliente;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();
            if (cant == 1)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                MessageBox.Show("Se borro el cliente");
                cargar();
                cargarcombo();


            } else
            {
                MessageBox.Show("No existe el cliente ingresado");



            }
            conexion.Close();

         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string idcliente = textBox1.Text;
            string nombres = textBox2.Text;
            string apellidos = textBox3.Text;
            string cadena = "update cliente set APELLIDOS='" + apellidos + "', NOMBRES='" + nombres + "' where IDCLIENTE=" + idcliente;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();
            if (cant == 1)
            {
                MessageBox.Show("Se modificaron los clientes");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                cargar();
                cargarcombo();


            } else
            {
                MessageBox.Show("No existe el cliente con el identificador ingresado");



            }
            conexion.Close();


        }
    }
}
