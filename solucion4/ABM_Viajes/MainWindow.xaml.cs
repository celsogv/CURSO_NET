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

namespace ABM_Viajes
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string empresa;
        string fechasalida;
        string lugarsalida;
        string fechallegada;
        string lugarllegada;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void cancelar_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void aceptar_Click(object sender, RoutedEventArgs e)

        {
            //deec
            try
            {

                //asig
                MessageBox.Show("ESTIMADO " + nombre.Text + "\n" +"Reserva Realizada para el dia " + fecha_salida.Text.ToString() + "\n" + "De " + lugardesalida.Text + " a " + lugardellegada.Text + " para " + fecha_llegada.Text.ToString());
            } catch
            {

                MessageBox.Show("Se ha producido un error");
            }
        }
    }
}
