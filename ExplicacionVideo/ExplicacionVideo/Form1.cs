using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExplicacionVideo
{
    public partial class Form1 : Form
    {
        Empleado empleado;
        Nomina nomina;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void butbtnAlmacenarRegistroton1_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtNombre.Text == "" && txtIdentificacion.Text == "" && txtAsignacion.Text == "" && txtDiasLaborados.Text == " ")
                {
                    MessageBox.Show("Por Favor diligenciar todos los campos");
                }

                else
                {
                    var nombre = txtNombre.Text;

                    var identificacion = txtIdentificacion.Text;
                    var asignacionDia = decimal.Parse(txtAsignacion.Text);
                    var diasLaborados = int.Parse(txtDiasLaborados.Text);


                    empleado = new Empleado(nombre, identificacion, asignacionDia);

                    nomina = new Nomina(diasLaborados);

                    MessageBox.Show("Datos Guardados ");

                }

            }

            catch
            {


                MessageBox.Show("Error");

            }
            

        }

        private void btnCalcularSalario_Click(object sender, EventArgs e)
        {

            if (empleado == null || nomina == null)
            {
                MessageBox.Show("Por favor ingrese y almacene los datos del empleado primero.");
            }
            else
            {
                decimal salario = nomina.CalcularSalario(int.Parse(txtDiasLaborados.Text), decimal.Parse(txtAsignacion.Text));
                txtDevengado.Text = salario.ToString("C2");

            }
        }
    }
}
