using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulariojueves
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1, n2, suma;
            if ((txtNumero1.Text == "") || (txtNumero2.Text == "")) MessageBox.Show("DEBES METER UN VALOR");
                else { 
                n1 = int.Parse(txtNumero1.Text);
                n2 = int.Parse(txtNumero2.Text);
                suma = n1 + n2;
                txtResultado.Text = suma.ToString();
                }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n1, n2, resta;
            if ((txtNumero1.Text == "") || (txtNumero2.Text == "")) MessageBox.Show("DEBES METER UN VALOR");
            else
            {
                n1 = int.Parse(txtNumero1.Text);
                n2 = int.Parse(txtNumero2.Text);
                resta = n1 - n2;
                txtResultado.Text = resta.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n1, n2, producto;
            if ((txtNumero1.Text == "") || (txtNumero2.Text == "")) MessageBox.Show("DEBES METER UN VALOR");
            else
            {
                n1 = int.Parse(txtNumero1.Text);
                n2 = int.Parse(txtNumero2.Text);
                producto = n1 * n2;
                txtResultado.Text = producto.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n1, n2, cociente;
            if ((txtNumero1.Text == "") || (txtNumero2.Text == "")) MessageBox.Show("DEBES METER UN VALOR");
            else
            {
                n1 = int.Parse(txtNumero1.Text);
                n2 = int.Parse(txtNumero2.Text);
                cociente = n1 / n2;
                txtResultado.Text = cociente.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
