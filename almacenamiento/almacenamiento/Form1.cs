using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace almacenamiento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
         
            DatosCompartidos.Nombre = textBoxNombre.Text;
            DatosCompartidos.Documento = textBoxDocumento.Text;

            if (int.TryParse(textBoxEdad.Text, out int edad))
            {
                DatosCompartidos.Edad = edad;
            }
            else
            {
                DatosCompartidos.Edad = null;
            }

         
            if (decimal.TryParse(textBoxSaldo.Text, out decimal saldo))
            {
                DatosCompartidos.Saldo = saldo;
            }
            else
            {
                DatosCompartidos.Saldo = null;
            }

         
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
