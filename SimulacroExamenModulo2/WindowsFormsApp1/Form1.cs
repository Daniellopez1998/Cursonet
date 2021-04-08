using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Windows.Input;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cargarGrid();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        
        void cargarGrid()
        {
            var cargarGrid = from p in db.Empleados select p;
            DataGrid.DataSource = cargarGrid;
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                Empleados Persona = new Empleados();
                Persona.Id = int.Parse(txtId.Text);
                Persona.Nombre = txtName.Text;
                Persona.Apellido = txtSurname.Text;
                Persona.Edad = int.Parse(txtAge.Text);
                Persona.Casado = checkBox1.Checked;
                db.Empleados.InsertOnSubmit(Persona);
                db.SubmitChanges();
                cargarGrid();
               
                MessageBox.Show("Se ha añadido");
            }
            catch
            {
                MessageBox.Show("Falta algun Campo o el campo Id/Edad no es numerico");
            }
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Empleados Persona = db.Empleados.Single(p => p.Id == int.Parse(txtId.Text));
                Persona.Id = int.Parse(txtId.Text);
                Persona.Nombre = txtName.Text;
                Persona.Apellido = txtSurname.Text;
                Persona.Edad = int.Parse(txtAge.Text);
                Persona.Casado = checkBox1.Checked;
                db.SubmitChanges();
                cargarGrid();
                MessageBox.Show("Se ha modificado");
            }
            catch
            {
                MessageBox.Show("Falta algun Campo id o no existe");
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            try
            {
                Empleados Persona = db.Empleados.Single(p => p.Id == int.Parse(txtId.Text));
                db.Empleados.DeleteOnSubmit(Persona);
                db.SubmitChanges();
                cargarGrid();
                MessageBox.Show("Se ha eliminado");
                txtRegistros.Text = cont.ToString();
            }
             catch
            {
                MessageBox.Show("Falta algun Campo id o no existe");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'simulacroExamenModulo2DataSet.Empleados' Puede moverla o quitarla según sea necesario.
            this.empleadosTableAdapter.Fill(this.simulacroExamenModulo2DataSet.Empleados);

        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {

        }

        private void txtRegistros_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
