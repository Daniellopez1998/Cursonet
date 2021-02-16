using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulariojueves4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Letra.Text == "C") 
            {
                txtBox1.Text = "C";
            }
            else
            {
                if (Letra.Text == "O")
                {
                    txtBox2.Text = "O";
                    txtBox6.Text = "O";
                }
                else
                {
                    if (Letra.Text == "A")
                    {
                        txtBox4.Text = "A";
                    }
                    else
                    {
                        if (Letra.Text == "R")
                        {
                            txtBox3.Text = "R";
                        }
                        else
                        {
                            if (Letra.Text == "Z")
                            {
                                txtBox5.Text = "Z";
                            }
                            else
                                {
                                if (Letra.Text == "N")
                                {
                                    txtBox7.Text = "N";
                                }
                                else
                                {
                                    int intcontador;
                                    intcontador = int.Parse(contador.Text);
                                    if (intcontador > 0)
                                    {
                                        intcontador = intcontador - 1;
                                        contador.Text = intcontador.ToString();
                                        if (intcontador < 5 && intcontador > 3)
                                        {
                                            pictureBox1.Visible = true;
                                        }
                                        else if (intcontador < 4 && intcontador > 2)
                                        {
                                            pictureBox1.Visible = true;
                                            pictureBox2.Visible = true;
                                        }
                                        else if (intcontador < 3 && intcontador > 1)
                                        {
                                            pictureBox1.Visible = true;
                                            pictureBox2.Visible = true;
                                            pictureBox3.Visible = true;
                                        }
                                        else if (intcontador < 2 && intcontador > 0)
                                        {
                                            pictureBox1.Visible = true;
                                            pictureBox2.Visible = true;
                                            pictureBox3.Visible = true;
                                            pictureBox4.Visible = true;
                                        }
                                        else
                                        {
                                            pictureBox1.Visible = true;
                                            pictureBox2.Visible = true;
                                            pictureBox3.Visible = true;
                                            pictureBox4.Visible = true;
                                            pictureBox5.Visible = true;
                                            MessageBox.Show("Has perdido");
                                            Application.Exit();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            
        }
    }
}
