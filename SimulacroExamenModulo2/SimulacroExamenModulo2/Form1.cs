using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows;
using System.Windows.Input;



namespace SimulacroExamenModulo2
{
    
    public partial class Form1 : Form
    {
        DataClasses1DataContext Empleado = new DataClasses1DataContext();

        public Form1()
        {
            InitializeComponent();
            ListarAltas();
        }

        void ListarAltas()
        {
            DataGrid.DataSource = Empleado.SP_ListarAltas();
        }

        public Boolean Nulo(string Caja)
        {
            if (Caja != "") return true;
            else return false;
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            if (!Nulo(nId.Text) ||  System.Text.RegularExpressions.Regex.IsMatch(nId.Text, "[^1-9]") || !Nulo(txtName.Text) ||
                !Nulo(txtSurname.Text) || !Nulo(nAge.Text) || System.Text.RegularExpressions.Regex.IsMatch(nId.Text, "[^1-9]"))
            {
                MessageBox.Show("Falta algun campo");
            }
            else
            {
                try 
                {
                    Empleado.SP_Alta((int?)nId.Value, txtName.Text.ToUpper(), txtSurname.Text.ToUpper(), (int?)nAge.Value, checkBox1.Checked);
                    this.ListarAltas();
                    MessageBox.Show("Se añadio conrrectamente");
                    int cont;
                    cont = int.Parse(txtRegistros.Text);
                    cont +=1;
                    txtRegistros.Text = cont.ToString();
                }
                catch
                {
                    MessageBox.Show("El campo Id esta repetido");
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!Nulo(nId.Text) || System.Text.RegularExpressions.Regex.IsMatch(nId.Text, "[^1-9]") || !Nulo(txtName.Text) ||
                !Nulo(txtSurname.Text) || !Nulo(nAge.Text) || System.Text.RegularExpressions.Regex.IsMatch(nId.Text, "[^1-9]"))
            {
                MessageBox.Show("Falta algun campo");
            }
            else
            {
                Empleado.SP_ModificarAlta((int?)nId.Value, txtName.Text.ToUpper(), txtSurname.Text.ToUpper(), (int?)nAge.Value, checkBox1.Checked);
                this.ListarAltas();
                MessageBox.Show("Se modifico conrrectamente");
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            if (!Nulo(nId.Text))
            {
                MessageBox.Show("Pon el Id del Empleado a eliminar");
            }
            else
            {
                try 
                {
                    Empleado.SP_Baja(txtName.Text);
                    this.ListarAltas();
                    int cont;
                    cont = int.Parse(txtRegistros.Text);
                    cont -=1;
                    txtRegistros.Text = cont.ToString();
                }
                catch
                {
                    MessageBox.Show("No existe ese Iden la base de datos");
                }
            }
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            if (!Nulo(txtFiltro.Text))
            {
                MessageBox.Show("Pon el Nombre del Empleado a buscar");
            }
            else
            {
                try
                {
                  
                    this.ListarAltas();
                }
                catch
                {
                    MessageBox.Show("No existe ese nombre en la base de datos");
                }
            }
        }
    }
}
