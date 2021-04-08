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

namespace Linqjueves
{
    public partial class Form1 : Form
    {
        DataClasses1DataContext PacienteLinq = new DataClasses1DataContext();
        public Form1()
        {
            InitializeComponent();
            this.ListarAltas();
        }

        void ListarAltas()
        {
            DataGrid.DataSource = PacienteLinq.SP_ListarAltas();
        }

        public Boolean Nulo(string Caja)
        {
            if (Caja != "") return true;
            else return false;
        }


        private void btnAltas_Click(object sender, EventArgs e)
        {
            if (!Nulo(txtInscripcion.Text) || System.Text.RegularExpressions.Regex.IsMatch(txtInscripcion.Text, "[^0-9]") || !Nulo(txtNombre.Text) || !Nulo(txtApellidos.Text)
                 || !Nulo(txtFecha.Text) || System.Text.RegularExpressions.Regex.IsMatch(txtFecha.Text, "[^0-9]") || !Nulo(txtDireccion.Text) || !Nulo(txtNumSS.Text)
                 || System.Text.RegularExpressions.Regex.IsMatch(txtNumSS.Text, "[^0-9]"))
            {
                MessageBox.Show("Falta algun campo o Inscripcion/Numss/Fecha no es numerico");
            }
            else { 
                try { 
                if (radHombre.Checked)
                {
                    PacienteLinq.SP_Alta(txtInscripcion.Text, txtNombre.Text.ToUpper(),
                        txtApellidos.Text.ToUpper(), radHombre.Text.ToUpper(), txtFecha.Text.ToUpper(), txtDireccion.Text.ToUpper(), txtNumSS.Text);
                    this.ListarAltas();
                }
                else
                {
                    PacienteLinq.SP_Alta(txtInscripcion.Text, txtNombre.Text.ToUpper(),
                        txtApellidos.Text.ToUpper(), radMujer.Text.ToUpper(), txtFecha.Text.ToUpper(), txtDireccion.Text.ToUpper(), txtNumSS.Text);
                    this.ListarAltas();
                }
                }
                 catch
                {
                    MessageBox.Show("El numero de inscripción esta repetido");
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!Nulo(txtInscripcion.Text) || System.Text.RegularExpressions.Regex.IsMatch(txtInscripcion.Text, "[^0-9]") || !Nulo(txtNombre.Text) || !Nulo(txtApellidos.Text)
                || !Nulo(txtFecha.Text) || System.Text.RegularExpressions.Regex.IsMatch(txtFecha.Text, "[^0-9]") || !Nulo(txtDireccion.Text) || !Nulo(txtNumSS.Text)
                || System.Text.RegularExpressions.Regex.IsMatch(txtNumSS.Text, "[^0-9]"))
            {
                MessageBox.Show("Falta algun campo o Inscripcion/Numss/Fecha no es numerico");
            }
            else { 
                if (radHombre.Checked)
                {
                    PacienteLinq.SP_ModificarAlta(txtInscripcion.Text, txtNombre.Text.ToUpper(),
                        txtApellidos.Text.ToUpper(), radHombre.Text.ToUpper(), txtFecha.Text.ToUpper(), txtDireccion.Text.ToUpper(), txtNumSS.Text);
                    this.ListarAltas();
                }
                else
                {
                    PacienteLinq.SP_ModificarAlta(txtInscripcion.Text, txtNombre.Text.ToUpper(),
                        txtApellidos.Text.ToUpper(), radMujer.Text.ToUpper(), txtFecha.Text.ToUpper(), txtDireccion.Text.ToUpper(), txtNumSS.Text);
                    this.ListarAltas();
                }
            }
        }
        private void btnBajas_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();

            if (!Nulo(txtInscripcion.Text)){
                MessageBox.Show("Pon el número de inscripción del paciente a eliminar");
            }
            else
            {
                PacienteLinq.SP_Baja(txtInscripcion.Text);
                this.ListarAltas();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            using (var writetext = new StreamWriter("Write.txt"))
            {
                foreach (DataGridViewRow row in DataGrid.Rows)
                {
                    writetext.WriteLine($"{row.Cells[0].Value}, {row.Cells[1].Value}, {row.Cells[2].Value}, {row.Cells[3].Value}," +
                        $" {row.Cells[4].Value}, {row.Cells[5].Value}");
                }
            }
        }

        private void txtInscripcion_TextChanged(object sender, EventArgs e)
        {
            txtInscripcion.MaxLength = 5;
        }

        private void txtNumSS_TextChanged(object sender, EventArgs e)
        {
            txtNumSS.MaxLength = 10;
        }

        private void txtFecha_TextChanged(object sender, EventArgs e)
        {
            
            txtFecha.MaxLength = 8;
        }
    }
}
