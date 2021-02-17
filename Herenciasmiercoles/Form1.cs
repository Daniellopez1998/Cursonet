using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herenciasmiercoles
{
    public partial class CLIENTES : Form
    {
        public CLIENTES()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal resultado;
            int resultadoentero;
            DateTime fechaNacimiento = dtmFechaNacimiento.Value;
            DateTime fechaActual = DateTime.Now;
            int numerodias = (DateTime.Now - fechaNacimiento).Days;
            int numeromeses = numerodias / 30;
            resultado = numeromeses / 12;
            resultadoentero = Convert.ToInt32(Math.Floor(resultado));
            if (resultadoentero < 18) { 
            MessageBox.Show(txtNombre.Text + " tiene " + resultadoentero.ToString() + " año(s)" + "\n" + txtNombre.Text + " no es mayor de edad" + "\n Limite de credito: $" + txtCredito.Text);
            }
            else
            {
            MessageBox.Show(txtNombre.Text + " tiene " + resultadoentero.ToString() + " año(s)" + "\n" + txtNombre.Text + " si es mayor de edad" + "\n Limite de credito: $" + txtCredito.Text);
            }
        }
    }
}
