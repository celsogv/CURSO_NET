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

            MessageBox.Show(RadioButton.ContentProperty.ToString());


            //deec
            try
            {
                string valornombre = nombre.Text;
                string valorfechasalida = fecha_salida.Text.ToString();
                string valorlugardesalida = lugardesalida.Text;
                string valorlugardellegada = lugardellegada.Text;
                string valorfechallegada = fecha_llegada.Text.ToString();
                string valorempresa = txtempresa.Text;
                string valorcorreo = txtcorreo.Text;
                

                //asig
                MessageBox.Show("Empresa: " + valorempresa + "\n" + "ESTIMADO " + valornombre + " Correo " + valorcorreo + "\n" +"Reserva Realizada para el dia " + valorfechasalida + "\n" + "De " + valorlugardesalida + " a " + valorlugardellegada + " para " + valorfechallegada);
            } catch
            {

                MessageBox.Show("Se ha producido un error");
            }
        }
    }
}
