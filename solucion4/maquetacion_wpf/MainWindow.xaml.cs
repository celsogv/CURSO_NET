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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txtbox1.Text = "";
            txtbox2.Text = "";
            txtbox3.Text = "";
            txtbox4.Text = "";
            txtbox5.Text = "";
            txtbox6.Text = "";
            txtbox7.Text = "";
            txtbox8.Text = "";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                if ((txtbox2.Text == "") || (txtbox6.Text == "") || (txtbox3.Text == ""))
                {
                    MessageBox.Show("Faltan campos por rellenar");

                }
                else
                {

                    lvDatos.Items.Add(new { Nombre = txtbox2.Text, venta = txtbox5.Text, PecUni = txtbox6.Text, Descuento = txtbox3.Text });
                    cantidad = cantidad + 1;
                    MessageBox.Show(cantidad.ToString());
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
            PrintDialog pDialog = new PrintDialog();
            pDialog.ShowDialog();
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
            descuento = Decimal.Parse((txtbox3.Text));
            iva = Decimal.Parse((txtbox4).Text);
            
            preciouni = Decimal.Parse((txtbox6.Text));
            pagado = Decimal.Parse((txtbox7.Text));
            preciototal = (preciouni - descuento + iva) * cantidad;
            total = pagado - preciototal;
            txtbox8.Text = total.ToString(); 

        }
    }
}
