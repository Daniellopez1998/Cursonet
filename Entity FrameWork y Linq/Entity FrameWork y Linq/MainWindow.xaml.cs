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

namespace Entity_FrameWork_y_Linq
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        EntityFrameworkEntities2 DbEntityes = new EntityFrameworkEntities2();

        public static DataGrid ControlDatagrid;

        public MainWindow()
        {
            //Cargamos el DataGrid con los datos
            InitializeComponent();
            MyDG.ItemsSource = DbEntityes.Profesores.ToList();
            ControlDatagrid = MyDG;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Boton añadir para la ventana añadir(Window2)
            Window2 Vinsertar = new Window2();
            Vinsertar.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //Boton Modificar para la ventana añadir(Window1)
            int Id = (MyDG.SelectedItem as Profesores).Id;
            Window1 Vcambiar = new Window1(Id);
            Vcambiar.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int Id = (MyDG.SelectedItem as Profesores).Id;
            var deleteProfe = DbEntityes.Profesores.Where(m=>m.Id==Id).Single();
            DbEntityes.Profesores.Remove(deleteProfe);
            DbEntityes.SaveChanges();
            ControlDatagrid.ItemsSource=DbEntityes.Profesores.ToList();
        }
    }
}
