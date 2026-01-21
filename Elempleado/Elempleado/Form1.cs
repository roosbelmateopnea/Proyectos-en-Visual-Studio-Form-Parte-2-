using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Elempleado
{
    public partial class Form1 : Form
    {
        Empleado empleado;
        Fecha fecha;
        Persona persona;





        public Form1()
        {
            InitializeComponent();
        }

       



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCaledad_Click(object sender, EventArgs e)
        {
            
            Fecha fechaNacimiento = persona.darFechanacimiento();

            int edadEnMeses = fechaNacimiento.DiferenciaFechaMeses(fechaNacimiento);

            int edadEnAnios = edadEnMeses / 12;

            textCalcularedadaños.Text = edadEnAnios.ToString();

            


        }

        private void textSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textCalcularedad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textCalcularantiguedad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textPrestaciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textCalcularedad_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalantiguedad_Click(object sender, EventArgs e)
        {
            int mesesAntiguedad = empleado.darFechaIngreso().DiferenciaFechaMeses(empleado.darFechaIngreso());
            textCalcularantiguedadmeses.Text = mesesAntiguedad.ToString();



            int aniosAntiguedad = mesesAntiguedad / 12;
            textCalcularantiguedadaños.Text = aniosAntiguedad.ToString();


        }

        private void btnCalprestaciones_Click(object sender, EventArgs e)
        {

            int mesesAntiguedad = empleado.darFechaIngreso().DiferenciaFechaMeses(empleado.darFechaIngreso());
            int obtenerSalario = (int)empleado.darSalario();
            int aniosAntiguedad = mesesAntiguedad / 12;
            int calMultiplicacion = aniosAntiguedad * obtenerSalario;
            int calDivision = calMultiplicacion / 12;

            textPrestaciones.Text = calDivision.ToString();

            
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCargarimagen_Click(object sender, EventArgs e)
        {


            OpenFileDialog openFileDialog = new OpenFileDialog();

            
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(openFileDialog.FileName);

                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                btnCargarimagen.Visible = false;

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textFechanacimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void textFechaingreso_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textPrestaciones_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {


            try
            {
              
                decimal salarioNuevo = decimal.Parse(textSalario.Text);

               
                empleado.cambiarSalario(salarioNuevo);

               
            }
            catch
            {
                MessageBox.Show("Error: ingresa un número válido para el salario.");
            }



        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var nombre = textNombre.Text.Trim();
            var apellido = textApellido.Text.Trim();
            var genero = txtGenero.Text.Trim();
            var salarioTexto = textSalario.Text.Trim();
            var fechaNacimientoTexto = textFechanacimiento.Text.Trim();
            var fechaIngresoTexto = textFechaingreso.Text.Trim();
            var cargo = txtCargo.Text.Trim();

            

            int errors = 0;

           
            if (nombre == "")
            {
                MessageBox.Show("Error: Nombre vacío");
                errors++;
            }

            if (apellido == "")
            {
                MessageBox.Show("Error: Apellido vacío");
                errors++;
            }

            if (genero == "" || genero.Length > 1 || (genero != "M" && genero != "F" && genero != "f" && genero != "m"))
            {
                MessageBox.Show("Error: Género inválido (use M o F)");
                errors++;
            }


            decimal salario = 0;
            decimal.TryParse(salarioTexto, out salario);

            


            if (errors == 0)
            {
            
                Fecha fechaNacimiento;
                if (string.IsNullOrWhiteSpace(fechaNacimientoTexto))
                {
                    fechaNacimiento = new Fecha();
                }
                else
                {
                    string[] partesNac = fechaNacimientoTexto.Split('/');
                    int diaN = int.Parse(partesNac[0]);
                    int mesN = int.Parse(partesNac[1]);
                    int annioN = int.Parse(partesNac[2]);
                    fechaNacimiento = new Fecha(diaN, mesN, annioN);
                }

            
                Fecha fechaIngreso;
                if (string.IsNullOrWhiteSpace(fechaIngresoTexto))
                {
                    fechaIngreso = new Fecha(); 
                }
                else
                {
                    string[] partesIng = fechaIngresoTexto.Split('/');
                    int diaI = int.Parse(partesIng[0]);
                    int mesI = int.Parse(partesIng[1]);
                    int annioI = int.Parse(partesIng[2]);
                    fechaIngreso = new Fecha(diaI, mesI, annioI);
                }

                empleado = new Empleado(nombre, apellido, genero[0], salario, fechaIngreso, cargo, fechaNacimiento);




                MessageBox.Show("Empleado creado correctamente:");

            }
            else
            {
                MessageBox.Show("No se puede crear, tienes " + errors.ToString() + " errores.");
            }




        }

        private void listGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {



            decimal suma = empleado.aporteASalud() + empleado.aporteAPension();

            String msj = "Empleado: " + empleado.darNombre() + " " + empleado.darApellido() + "\n";
            msj += "Salario base: " + empleado.darSalario().ToString() + "\n";
            msj += "Aportes a salud y pension: " + suma.ToString() + "\n";
            msj += "Descuento por libranza: " + empleado.valorLibranza().ToString() + "\n";
            msj += "Total a pagar: " + empleado.netoAPagar().ToString() + "\n";
            msj += "Cargo: " + empleado.darCargo().ToString() + "\n";
            MessageBox.Show(msj);


        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Fehca de hoy

            


            if (empleado == null)
            {
                MessageBox.Show("Primero debe guardar un empleado antes de mostrar la fecha.");
                return;
            }

            else
            {
                MessageBox.Show("Fecha ingreso: " + empleado.darFechaIngreso().toStringb());
                

            }



        }

        private void textSalario_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textCalcularantiguedad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
