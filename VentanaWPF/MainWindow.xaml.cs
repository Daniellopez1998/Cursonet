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

namespace VentanaWPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
        public Boolean IsValid(string Caja)
        {
            if (Caja != "") return true;
            else return false;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
        
            if (comboEmpresa.SelectedItem==null)
            {
                labelCorrecto1.Visibility = Visibility.Visible;
                MessageBox.Show("FALTA ELEMENTO EMPRESA");
            }

            else if (!IsValid(dtmSalida.Text))
            {
                labelCorrecto2.Visibility = Visibility.Visible;
                MessageBox.Show("FALTA ELEMENTO FECHA DE SALIDA");
            }

            else if (comboSalida.SelectedItem == null)
            {
                labelCorrecto3.Visibility = Visibility.Visible;
                MessageBox.Show("FALTA ELEMENTO LUGAR DE SALIDA");
            }

            else if (!IsValid(dtmLlegada.Text))
            {
                labelCorrecto5.Visibility = Visibility.Visible;
                MessageBox.Show("FALTA ELEMENTO FECHA DE LLEGADA");
            }

            else if (comboLlegada.SelectedItem == null)
            {
                labelCorrecto6.Visibility = Visibility.Visible;
                MessageBox.Show("FALTA ELEMENTO LUGAR DE LLEGADA");
            }

            else if (!IsValid(txtNombre.Text))
            {
                labelCorrecto7.Visibility = Visibility.Visible;
                MessageBox.Show("FALTA ELEMENTO NOMBRE");
            }

            else if (!IsValid(txtCorreo.Text))
            {
                labelCorrecto8.Visibility = Visibility.Visible;
                MessageBox.Show("FALTA ELEMENTO CORREO");
            }

            else if(rad1.IsChecked==false && rad2.IsChecked==false && rad3.IsChecked == false && rad4.IsChecked == false) 
            {
                labelCorrecto4.Visibility = Visibility.Visible;
                MessageBox.Show("FALTA ELEMENTO PERSONAS");
            }

            else
            {
                if (rad1.IsChecked == true)
                {
                    MessageBox.Show("Estimado " + txtNombre.Text + ", como cliente de " + comboEmpresa.Text + " le informamos lo siguiente:"
                    + "\n Reserva realizada para el dia " + dtmSalida.Text + "\n hasta el dia " + dtmLlegada.Text + " con salida desde "
                    + comboSalida.Text + ",\n con destino " + comboLlegada.Text + " para una personas." + "\n Se le ha enviado un correo a " + txtCorreo.Text);
                }

                else if (rad2.IsChecked == true)
                {
                    MessageBox.Show("Estimado " + txtNombre.Text + ", como cliente de " + comboEmpresa.Text + " le informamos lo siguiente:"
                        + "\n Reserva realizada para el dia " + dtmSalida.Text + "\n hasta el dia " + dtmLlegada.Text + " con salida desde "
                        + comboSalida.Text + ",\n con destino " + comboLlegada.Text + " para dos personas." + "\n Se le ha enviado un correo a " + txtCorreo.Text);
                }

                else if (rad3.IsChecked == true)
                {
                    MessageBox.Show("Estimado " + txtNombre.Text + ", como cliente de " + comboEmpresa.Text + " le informamos lo siguiente:"
                        + "\n Reserva realizada para el dia " + dtmSalida.Text + "\n hasta el dia " + dtmLlegada.Text + " con salida desde "
                        + comboSalida.Text + ",\n con destino " + comboLlegada.Text + " para tres personas." + "\n Se le ha enviado un correo a " + txtCorreo.Text);
                }

                else if (rad4.IsChecked == true)
                {
                    MessageBox.Show("Estimado " + txtNombre.Text + ", como cliente de " + comboEmpresa.Text + " le informamos lo siguiente:"
                        + "\n Reserva realizada para el dia " + dtmSalida.Text + "\n hasta el dia " + dtmLlegada.Text + " con salida desde "
                        + comboSalida.Text + ",\n con destino " + comboLlegada.Text + " para cuatro personas." + "\n Se le ha enviado un correo a " + txtCorreo.Text);
                }
            }
        }

     
    }
}
