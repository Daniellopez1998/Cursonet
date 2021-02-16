using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulariojueves3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Paquete1_CheckedChanged(object sender, EventArgs e)
        {
            if (Paquete1.Checked)
            {
                txtBox1.Text = "1";
                txtBox2.Text = "1";
                txtBox3.Text = "1";
                txtBox1.Enabled = false;
                txtBox2.Enabled = false;
                txtBox3.Enabled = false;
                txtBox4.Enabled = false;
                txtBox5.Enabled = false;
                txtBox6.Enabled = false;
                txtBox7.Enabled = false;
                txtBox8.Enabled = false;
                Subtotal.Enabled = false;
                Total.Enabled = false;
                Iva.Enabled = false;
                Subtotal.Text = "62";

                decimal intTotal;
                intTotal = decimal.Parse(Subtotal.Text);
                intTotal = intTotal+ (intTotal * 16/100);
                Total.Text = intTotal.ToString();


            }
            else
            {
                txtBox1.Text = "0";
                txtBox2.Text = "0";
                txtBox3.Text = "0";
               
                
            }
           
        }

        private void Paquete2_CheckedChanged(object sender, EventArgs e)
        {
            if (Paquete2.Checked)
            {
                txtBox4.Text = "1";
                txtBox5.Text = "1";
                txtBox3.Text = "1";
                txtBox1.Enabled = false;
                txtBox2.Enabled = false;
                txtBox3.Enabled = false;
                txtBox4.Enabled = false;
                txtBox5.Enabled = false;
                txtBox6.Enabled = false;
                txtBox7.Enabled = false;
                txtBox8.Enabled = false;
                Subtotal.Enabled = false;
                Total.Enabled = false;
                Iva.Enabled = false;
                Subtotal.Text = "107";
                decimal intTotal;
                intTotal = decimal.Parse(Subtotal.Text);
                intTotal = intTotal + (intTotal * 16 / 100);
                Total.Text = intTotal.ToString();
            }
            else
            {
                txtBox4.Text = "0";
                txtBox5.Text = "0";
                txtBox3.Text = "0";
                
            }
        }

        private void Paquete3_CheckedChanged(object sender, EventArgs e)
        {
            if (Paquete3.Checked)
            {
                txtBox6.Text = "1";
                txtBox7.Text = "1";
                txtBox8.Text = "1";
                txtBox1.Enabled = false;
                txtBox2.Enabled = false;
                txtBox3.Enabled = false;
                txtBox4.Enabled = false;
                txtBox5.Enabled = false;
                txtBox6.Enabled = false;
                txtBox7.Enabled = false;
                txtBox8.Enabled = false;
                Subtotal.Enabled = false;
                Total.Enabled = false;
                Iva.Enabled = false;
                Subtotal.Text = "57";
                decimal intTotal;
                intTotal = decimal.Parse(Subtotal.Text);
                intTotal = intTotal + (intTotal * 16 / 100);
                Total.Text = intTotal.ToString();
            }
            else
            {
                txtBox6.Text = "0";
                txtBox7.Text = "0";
                txtBox8.Text = "0";
                
            }
        }
       
        private void Paquete4_CheckedChanged(object sender, EventArgs e)
        {
            txtBox1.Enabled = true;
            txtBox2.Enabled = true;
            txtBox3.Enabled = true;
            txtBox4.Enabled = true;
            txtBox5.Enabled = true;
            txtBox6.Enabled = true;
            txtBox7.Enabled = true;
            txtBox8.Enabled = true;
            Subtotal.Enabled = false;
            Total.Enabled = false;
            Iva.Enabled = false;
          
        }

        private void Iva_TextChanged(object sender, EventArgs e)
        {
            Iva.Text = "16%";
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            decimal intCambio;
            decimal intTotal;
            intTotal = decimal.Parse(Subtotal.Text);
            intTotal = intTotal + (intTotal * 16 / 100);
            intCambio = decimal.Parse(Pago.Text);
            intCambio = intCambio - intTotal;
            Cambio.Text = intCambio.ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal Otropedido;
            Otropedido = 35 * decimal.Parse(txtBox1.Text) + 15 * decimal.Parse(txtBox2.Text) + 12 * decimal.Parse(txtBox3.Text) + 70 * decimal.Parse(txtBox4.Text)
                + 25 * decimal.Parse(txtBox5.Text) + 30 * decimal.Parse(txtBox6.Text) + 15 * decimal.Parse(txtBox7.Text) + 12 * decimal.Parse(txtBox8.Text);
            Otropedido = Otropedido + (Otropedido * 16 / 100);
            Total.Text = Otropedido.ToString();
        }

    }
}
