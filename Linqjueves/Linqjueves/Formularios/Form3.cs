using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linqjueves
{
    public partial class Form3 : Form
    {
        DataClasses1DataContext DoctorLinq = new DataClasses1DataContext();
        public Form3()
        {
            InitializeComponent();
            this.ListarAltas();
        }

        void ListarAltas()
        {
            DataGridDoctor.DataSource = DoctorLinq.SP_ListarDoctor();
        }
        public void Nulo(string valor)
        {
            if (valor == "") MessageBox.Show("Falta algun campo");
        }

        private void btnAltas_Click(object sender, EventArgs e)
        {
            string cadena = txtHospitalCod.Text;
            Nulo(cadena);
        }
    }
}
