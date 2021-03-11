using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_linq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
            DataClasses2DataContext northwind = new DataClasses2DataContext();

            void cargarCombo()
            {


                var cargaCombo = from p in northwind.Products
                               select p.ProductName;
                comboBox1.DataSource = cargaCombo;



        }

            void cargarGrid()
        {
            var cargaGrid = from p in northwind.Products select p;

            GridDatos.DataSource = cargaGrid;



        }




        private void Form1_Load(object sender, EventArgs e)
        {
            cargarCombo();
            cargarGrid();

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Products MYProduct = new Products();
                MYProduct.ProductName = TxtProd.Text;
                MYProduct.UnitPrice = int.Parse(TxtPrec.Text);
                MYProduct.UnitsInStock = short.Parse(TxtStock.Text);
                MYProduct.CategoryID = int.Parse(TxtCat.Text);
                northwind.Products.InsertOnSubmit(MYProduct);
                northwind.SubmitChanges();
                cargarGrid();
            } catch
            {


                MessageBox.Show("Se ha producido un error");
            }


        }

        private void BtnGuardar2_Click(object sender, EventArgs e)
        {


            try
            {
                Products MyProducto = northwind.Products.Single(p => p.ProductName == comboBox1.SelectedItem.ToString());
                MyProducto.ProductName = comboBox1.SelectedItem.ToString();
                MyProducto.UnitPrice = int.Parse(TxtPrec.Text);
                MyProducto.UnitsInStock = short.Parse(TxtStock.Text);
                MyProducto.CategoryID = int.Parse(TxtCat.Text);
                northwind.SubmitChanges();
                cargarGrid();
            } catch
            {
                MessageBox.Show("Se ha producido un error");



            }

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {


            try
            {
                Products MyProduct = northwind.Products.Single(predicate => predicate.ProductName == comboBox1.SelectedItem.ToString());
                northwind.Products.DeleteOnSubmit(MyProduct);
                northwind.SubmitChanges();
                cargarGrid();
            } catch
            {
                MessageBox.Show("Se ha producido un error");



            }

        }
    }
}
