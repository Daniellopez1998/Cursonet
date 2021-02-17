using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herenciasmartes
{
    public partial class Form1 : Form
    {
        Empleado myEmpleado = new Empleado();
        Nomina myNomina = new Nomina();
        public Form1()
        {
            InitializeComponent();
        }
        public Boolean IsValid(string Caja)
        {
            if (Caja != "") return true;
            else return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!IsValid(textBox1.Text))
            {
                label7.Visible = true;
                MessageBox.Show("FALTA ELEMENTO REQUERIDO");
            }

            if (!IsValid(textBox2.Text))
            {
                label8.Visible = true;
                MessageBox.Show("FALTA ELEMENTO REQUERIDO");
            }
            if (!IsValid(textBox3.Text))
            {
                label9.Visible = true;
                MessageBox.Show("FALTA ELEMENTO REQUERIDO");
            }

            if (!IsValid(textBox4.Text))
            {
                label10.Visible = true;
                MessageBox.Show("FALTA ELEMENTO REQUERIDO");
            }
            else { 
            myEmpleado.Nombre = textBox1.Text;
            myEmpleado.Identificacion = textBox2.Text;
            myEmpleado.AsignacionDia = Convert.ToDecimal(textBox3.Text);
            myNomina.DiasLaborados = Convert.ToInt32(textBox4.Text);
                MessageBox.Show("Se guardo el registro correctamente");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox5.Text = myNomina.Calcularnomina(Convert.ToInt32(myNomina.DiasLaborados),Convert.ToDecimal(myEmpleado.AsignacionDia)).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
    }
}
