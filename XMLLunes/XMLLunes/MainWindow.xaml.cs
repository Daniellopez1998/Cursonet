using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;
using System.Data;

namespace XMLLunes
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            cargarGrid();
        }

        public void cargarGrid()
        {
            XElement xelement = XElement.Load("Fichero.xml");
            IEnumerable<XElement> employees = xelement.Elements();
            dataGrid1.ItemsSource = null;
            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Nombre");
            foreach (var employee in employees) 
            {
                dt.Rows.Add(employee.Element("EmpId").Value, employee.Element("Name").Value);
                dataGrid1.ItemsSource = dt.DefaultView; 
                cmemp.Items.Add(employee.Element("Name").Value); 
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            XElement xEle = XElement.Load("Fichero.xml");
            xEle.AddFirst(new XElement("Employee", new XElement("EmpId", Textbox1.Text), new XElement("Name", Textbox2.Text)));
            xEle.Save("Fichero.xml");
            cargarGrid();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            XElement xEle = XElement.Load("Fichero.xml");
            var empleados = xEle.Elements("Employee").Elements("Name").ToList();
            foreach (XElement cEle in empleados) 
            {
                MessageBox.Show(cEle.Value.ToString());
                if (cEle.Value.ToString() == Textbox1.Text) cEle.Value = Textbox2.Text; 
            }
            xEle.Save("Fichero.xml");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            XElement xEle = XElement.Load("Fichero.xml");
            var empleados = xEle.Elements("Employee").Elements("Name").ToList();
            foreach (XElement cEle in empleados)
            {
                MessageBox.Show(cEle.Value.ToString());
                if (cEle.Value.ToString() == Textbox2.Text) xEle.Element("Employee").Remove();
            }
            xEle.Save("Fichero.xml");
        }

        
    }
}
