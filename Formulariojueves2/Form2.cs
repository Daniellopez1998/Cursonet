using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int intentos;
            intentos = int.Parse(contador.Text);
            if ((txtBox11.Text=="L") && (txtBox12.Text=="O") && (txtBox13.Text=="R") && (txtBox14.Text=="O") && (txtBox15.Text== "S") && (txtBox22.Text == "R") && (txtBox23.Text == "O") && (txtBox31.Text == "R") && (txtBox32.Text == "A") && (txtBox33.Text == "T") && (txtBox35.Text == "N"))
            {
                MessageBox.Show("Enhorabuena");
                Application.Exit();
            }
            else
            {
                if (intentos<5)
                {
                    intentos = intentos + 1;
                    contador.Text = intentos.ToString();
                }
                else
                {
                    MessageBox.Show("te has quedado sin intentos");
                    Application.Exit();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit(); 
            }
        }

        private void contador_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
