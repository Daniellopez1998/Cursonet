using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herenciasmartes2
{
    public partial class Form1 : Form
    {
        Profesor p1 = new Profesor();
        Estudainte e1 = new Estudainte();
        public Form1()
        {
            InitializeComponent();
        }
        public Boolean IsValid(string Caja)
        {
            if (Caja != "") return true;
            else return false;
        }
            private void btnCapturarDatos_Click(object sender, EventArgs e)
        {
            if (radProfesor.Checked)
            {
                if (!IsValid(txtNombre.Text))
                {
                    label4.Visible = true;
                    MessageBox.Show("FALTA ELEMENTO REQUERIDO");
                }

                if (!IsValid(txtSueldo.Text))
                {
                    label5.Visible = true;
                    MessageBox.Show("FALTA ELEMENTO REQUERIDO");
                }
                else { 
                MessageBox.Show("Datos capturados");
                }
            }
            else
            {
                if (!IsValid(txtNombre.Text))
                {
                    label4.Visible = true;
                    MessageBox.Show("FALTA ELEMENTO REQUERIDO");
                }

                if (!IsValid(txtCalificacion.Text))
                {
                    label6.Visible = true;
                    MessageBox.Show("FALTA ELEMENTO REQUERIDO");
                }
                else
                {
                    MessageBox.Show("Datos capturados");
                }
            }
        }

        private void radProfesor_CheckedChanged(object sender, EventArgs e)
        {
            if (radProfesor.Checked)
            {
                txtSueldo.Enabled = true;
                txtCalificacion.Enabled = false;
                txtSueldo.Clear();
                txtCalificacion.Clear();
                txtNombre.Clear();

            }
            else
            {
                txtSueldo.Enabled = false;
                txtCalificacion.Enabled = true;
                txtSueldo.Clear();
                txtCalificacion.Clear();
                txtNombre.Clear();
            }
        }

        private void BtnMostrarDatos_Click(object sender, EventArgs e)
        {

            if (radProfesor.Checked)
            {
                if (!IsValid(txtNombre.Text))
                {
                    label4.Visible = true;
                    MessageBox.Show("FALTA ELEMENTO REQUERIDO");
                }

                if (!IsValid(txtSueldo.Text))
                {
                    label5.Visible = true;
                    MessageBox.Show("FALTA ELEMENTO REQUERIDO");
                }
                else
                {
                    MessageBox.Show("Nombre: " + txtNombre.Text + "\nSueldo: $" + txtSueldo.Text + "\n"+ txtNombre.Text + " " + p1.asistir() + "\n" + txtNombre.Text + " " + p1.Enseñar());
                }
            }
            else
            {
                if (!IsValid(txtNombre.Text))
                {
                    label4.Visible = true;
                    MessageBox.Show("FALTA ELEMENTO REQUERIDO");
                }

                if (!IsValid(txtCalificacion.Text))
                {
                    label6.Visible = true;
                    MessageBox.Show("FALTA ELEMENTO REQUERIDO");
                }
                else
                {
                    MessageBox.Show("Nombre: " + txtNombre.Text + "\nCalificacion: " + txtCalificacion.Text + txtNombre.Text + " " + "\n" + p1.asistir() + "\n" + txtNombre.Text + " " + e1.Estudiar());
                }
            }
        }
    }
}

