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

namespace Formularios5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Boolean IsValid(string Caja)
        {
            if (Caja != "") return true;
            else return false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(txtBox1.Text, txtBox3.Text, txtBox5.Text, Reserva.Text, Fecha1.Text, Fecha2.Text, Fecha3.Text);
            dataGridView1.AllowUserToAddRows = false;
            if (!IsValid(txtBox1.Text))
            {
                label11.Visible = true;
                MessageBox.Show("FALTA ELEMENTO REQUERIDO");
            }

            if (!IsValid(txtBox3.Text))
            {
                label17.Visible = true;
                MessageBox.Show("FALTA ELEMENTO REQUERIDO");
            }
            if (!IsValid(Reserva.Text))
            {
                label12.Visible = true;
                MessageBox.Show("FALTA ELEMENTO REQUERIDO");
            }

            if (!IsValid(Reserva.Text))
            {
                label12.Visible = true;
                MessageBox.Show("FALTA ELEMENTO REQUERIDO");
            }

            if (!IsValid(Fecha1.Text))
            {
                label13.Visible = true;
                MessageBox.Show("FALTA ELEMENTO REQUERIDO");
            }

            if (!IsValid(Costo.Text))
            {
                label15.Visible = true;
                MessageBox.Show("FALTA ELEMENTO REQUERIDO");
            }

            DateTime date = DateTime.Now;
            string fechadia;
            fechadia = Convert.ToString(date.ToString("dd/MM/yyyy"));

            if (Fecha2.Text == fechadia)
            {
                label14.Visible = true;
                MessageBox.Show("La fecha no es valida");
            }

            if (Fecha3.Text == fechadia)
            {
                label16.Visible = true;
                MessageBox.Show("La fecha no es valida");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtBox1.Clear();
            txtBox3.Clear();
            txtBox5.Clear();
            Reserva.ResetText();
            Fecha1.ResetText();
            Fecha2.ResetText();
            Fecha3.ResetText();
            Costo.Clear();
            Observacion.Clear();
            Estado.ResetText();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using(var writetext=new StreamWriter("Write.txt"))
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    writetext.WriteLine($"{row.Cells[0].Value}, {row.Cells[1].Value}, {row.Cells[2].Value}, {row.Cells[3].Value}," +
                        $" {row.Cells[4].Value}, {row.Cells[5].Value}, {row.Cells[6].Value}");
                }
            }
        }

        
    }
}
