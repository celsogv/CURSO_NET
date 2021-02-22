using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace maquetacion_wpf
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Decimal descuento, iva, cantidad = 0, preciouni, pagado, total, preciototal;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                txtbox1.Text = "";
                txtbox2.Text = "";
                txtbox3.Text = "";
                txtbox4.Text = "";
                txtbox5.Text = "";
                txtbox6.Text = "";
                txtbox7.Text = "";
                txtbox8.Text = "";

            } catch
            {
                MessageBox.Show("Se ha producido un error");


            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtbox2.Text == "")
                {
                    MessageBox.Show("Falta el nombre por introducir");

                }
                else if (txtbox6.Text == "")
                {
                    MessageBox.Show("falta el precio unitariò por introducir");
                } else if (txtbox3.Text == "")
                {

                    MessageBox.Show("Falta el descuento por introducir");

                } else if (txtbox4.Text == "") {
                    MessageBox.Show("Falta el iva por introducir");


                } else 
                {
                    cantidad = cantidad + 1;
                    lvDatos.Items.Add(new { Nombre = txtbox2.Text, venta = cantidad, PecUni = txtbox6.Text, Descuento = txtbox3.Text });
                    txtbox5.Text = cantidad.ToString();
                } 

            } catch
            {

                MessageBox.Show("Se ha producido un error");

            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                PrintDialog pDialog = new PrintDialog();
                pDialog.ShowDialog();
            } catch
            {
                MessageBox.Show("Se ha producido un error");



            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            try
            {   
                lvDatos.Items.RemoveAt(0);
                lvDatos.Items.Refresh();
            } catch
            {
                MessageBox.Show("no quedan filas para eliminar");


            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {

            try
            {
                descuento = Decimal.Parse((txtbox3.Text));
                iva = Decimal.Parse((txtbox4).Text);
                preciouni = Decimal.Parse((txtbox6.Text));
                pagado = Decimal.Parse((txtbox7.Text));
                preciototal = (preciouni - descuento + iva) * cantidad;
                total = pagado - preciototal;
                txtbox8.Text = total.ToString();
                 
            } catch
            {

                MessageBox.Show("Se ha producido un error");


            }

        }
    }
}
