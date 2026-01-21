using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace andreaFormulario2
{
    public partial class Form1 : Form
    {
        Empleado empleado;
        Fecha fecha;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var nombre = textNombre.Text.Trim();
            var apellido = textApellido.Text.Trim();
            var genero = txtGenero.Text.Trim();
            var salarioTexto = textSalario.Text.Trim();
            var fechaNacimientoTexto = textFechanacimiento.Text.Trim();
            var fechaIngresoTexto = textFechaingreso.Text.Trim();


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

            if (!decimal.TryParse(salarioTexto, out decimal salario) || salario <= 500000)
            {
                MessageBox.Show("Error: Salario inválido (debe ser número > 500000)");
                errors++;
            }


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



                empleado = new Empleado(nombre, apellido, genero[0], salario, fechaNacimiento, fechaIngreso);




                MessageBox.Show("Empleado creado correctamente:");

            }
            else
            {
                MessageBox.Show("No se puede crear, tienes " + errors.ToString() + " errores.");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
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

        private void btnCaledad_Click(object sender, EventArgs e)
        {
            Fecha fechaNacimiento = empleado.darFechanacimiento();

            int edadEnMeses = fechaNacimiento.DiferenciaFechaMeses(fechaNacimiento);

            int edadEnAnios = edadEnMeses / 12;

            textCalcularedadaños.Text = edadEnAnios.ToString();



           
        }

        private void btnCalantiguedad_Click(object sender, EventArgs e)
        {
            int mesesAntiguedad = empleado.darFechaingreso().DiferenciaFechaMeses(empleado.darFechaingreso());
    
            int aniosAntiguedad = mesesAntiguedad / 12;
            textCalcularantiguedadaños.Text = aniosAntiguedad.ToString();
        }

        private void btnCalprestaciones_Click(object sender, EventArgs e)
        {
            int mesesAntiguedad = empleado.darFechaingreso().DiferenciaFechaMeses(empleado.darFechaingreso());
            int obtenerSalario = (int)empleado.darSalario();
            int aniosAntiguedad = mesesAntiguedad / 12;
            int calMultiplicacion = aniosAntiguedad * obtenerSalario;
            int calDivision = calMultiplicacion / 12;

            textPrestaciones.Text = calDivision.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // lo que gana el señor



            if (empleado == null)
            {
                MessageBox.Show("Primero debe guardar un empleado antes de mostrar el salario.");
                return;
            }

            else
            {
                MessageBox.Show("Salario: " + empleado.darSalario().ToString());
            }
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
                MessageBox.Show("Fecha ingreso: " + empleado.darFechaingreso().toStringb());


            }
        }
    }
}
