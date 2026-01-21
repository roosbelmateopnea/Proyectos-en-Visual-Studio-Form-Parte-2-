using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace andreaFormulario2
{
    internal class Empleado
    {
        private string nombre;
        private string apellido;
        private char genero;
        private PictureBox foto;
        private decimal salario;
        private Fecha fechaNacimiento;
        private Fecha fechaIngreso;

        // Constructores
        public Empleado(string pNombre, string pApellido, char pGenero)
        {
            // asifna fehca y salario yo lo hago programador
            this.nombre = pNombre;
            this.apellido = pApellido;
            this.genero = pGenero;
            this.salario = 0;


            this.fechaIngreso = new Fecha();
            this.fechaNacimiento = new Fecha();

        }

        public Empleado(string pNombre, string pApellido, char pGenero, decimal pSalario)
        {
            //ingresa salario usuario
            this.nombre = pNombre;
            this.apellido = pApellido;
            this.genero = pGenero;
            this.salario = pSalario;
            this.fechaIngreso = new Fecha();
            this.fechaNacimiento = new Fecha();
        }

        public Empleado(string pNombre, string pApellido, char pGenero, decimal pSalario, Fecha pFechaNacimiento, Fecha pFechaIngreso)
        {
            // ingrese tood el usuario
            this.nombre = pNombre;
            this.apellido = pApellido;
            this.genero = pGenero;
            this.salario = pSalario;
            this.fechaNacimiento = pFechaNacimiento;
            this.fechaIngreso = pFechaIngreso;
        }

        //  Get
        public string darNombre()
        {
            return this.nombre;
        }

        // Set
        public void cambiarNombre(string pNombre)
        {
            this.nombre = pNombre;
        }

        // Get

        public string darApellido()
        {
            return this.apellido;
        }

        // Set

        public void cambiarApellido(string pApellido)
        {
            this.apellido = pApellido;
        }


        // Get


        public char darGenero()
        {
            return this.genero;
        }


        // Set

        public void cambiarGenero(char pGenero)
        {
            this.genero = pGenero;
        }

        // Getters

        public decimal darSalario()
        {
            return this.salario;
        }


        // Set
        public void cambiarSalario(decimal pSalario)
        {
            this.salario = pSalario;
        }






        // Get
        public Fecha darFechanacimiento()
        {
            return this.fechaNacimiento;
        }


        // Set

        public void cambiarFechaNacimiento(Fecha pFechaNacimiento)
        {
            this.fechaNacimiento = pFechaNacimiento;
        }




        // Get
        public Fecha darFechaingreso()
        {
            return this.fechaIngreso;
        }

        // Set

        public void cambiarFechaIngreso(Fecha pFechaIngreso)
        {
            this.fechaIngreso = pFechaIngreso;
        }

        // Get

        public void cambiarFoto(PictureBox pFoto)
        {
            this.foto = pFoto;
        }


    }
}
